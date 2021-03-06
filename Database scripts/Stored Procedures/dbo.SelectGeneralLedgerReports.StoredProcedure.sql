USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectGeneralLedgerReports]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectGeneralLedgerReports]
    @FromBranchCode VARCHAR(10) = '' ,
    @ToBranchCode VARCHAR(10) = '' ,
    @FromDivisionCode VARCHAR(10) = '' ,
    @ToDivisionCode VARCHAR(10) = '' ,
    @FromGLCode VARCHAR(50) = '' ,
    @ToGLCode VARCHAR(50) = '' ,
    @FromDate DATETIME = NULL ,
    @ToDate DATETIME = NULL ,
    @nType BIGINT = 0 ,
    @VoucherNatureCode VARCHAR(100) = '' ,
    @ReportSD AS VARCHAR(10) = 'DET' ,
    @Posted BIT = 1 ,
    @PostedED BIT = 0
AS 
    IF @nType = 0 --OPENING 1
        BEGIN			
            DECLARE @DocDate AS DATETIME
	
            IF EXISTS ( SELECT  *
                        FROM    sysobjects
                        WHERE   ID = OBJECT_ID(N'TempCOAOpeningLedger')
                                AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                BEGIN
                    DROP TABLE  TempCOAOpeningLedger
                END
	
	-- SELECT Division with Filter
            SELECT  DivisionCode AS SysDivisionCode ,
                    DivisionCode ,
                    Division ,
                    Division AS DivisionRptTitle
            INTO    #Divisions
            FROM    dbo.Divisions
            WHERE   ( dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode
                                                 AND     @ToDivisionCode )
	
            CREATE INDEX #IX_Divisions ON #Divisions (   DivisionCode )
            WITH   SORT_IN_TEMPDB
            ON [PRIMARY]
	-- SELECT Branch with Filter
            SELECT  BranchCode AS SysBranchCode ,
                    BranchCode ,
                    BranchDescription AS Branch ,
                    BranchDescription AS BranchRptTitle
            INTO    #Branches
            FROM    dbo.Branches
            WHERE   ( dbo.Branches.BranchCode BETWEEN @FromBranchCode
                                              AND     @ToBranchCode )
	
            CREATE INDEX #IX_Branches ON #Branches (   BranchCode )
            WITH   SORT_IN_TEMPDB
            ON [PRIMARY]
	-- SELECT GLAccount with Filter
            SELECT  GLCode ,
                    GLRptTitle ,
                    ControlCode ,
                    ControlRptTitle ,
                    GeneralCode ,
                    GeneralRptTitle ,
                    SubSidiaryCode ,
                    SubsidiaryRptTitle ,
                    SubsubCode ,
                    SubSubRptTitle
            INTO    #COACombineLedTBRptVW
            FROM    dbo.GL_GetCOACombineLedTBRptVW
            WHERE   ( dbo.GL_GetCOACombineLedTBRptVW.GLCode BETWEEN @FromGLCode
                                                            AND
                                                              @ToGLCode )
	
            CREATE INDEX #IX_COACombineLedTBRptVW ON #COACombineLedTBRptVW (   GLCode )
            WITH   SORT_IN_TEMPDB	
            ON [PRIMARY]
	-- SELECT Last Closing Date For OpeningBalanceTAB Filter
            SELECT  dbo.OpeningBalances.BranchCode ,
                    dbo.OpeningBalances.DivisionCode ,
                    dbo.OpeningBalances.GLCode ,
                    MAX(dbo.OpeningBalances.ClosingDate) AS ClosingDate
            INTO    #OpeningDate
            FROM    dbo.OpeningBalances
                    INNER JOIN #Branches ON dbo.OpeningBalances.BranchCode = #Branches.BranchCode
                    INNER JOIN #COACombineLedTBRptVW ON dbo.OpeningBalances.GLCode = #COACombineLedTBRptVW.GLCode
                    INNER JOIN #Divisions ON dbo.OpeningBalances.DivisionCode = #Divisions.DivisionCode
            WHERE   ( dbo.OpeningBalances.ClosingDate <= @ToDate )
            GROUP BY dbo.OpeningBalances.BranchCode ,
                    dbo.OpeningBalances.DivisionCode ,
                    dbo.OpeningBalances.GLCode
            CREATE INDEX #IX_OpeningDate ON #OpeningDate ( BranchCode, DivisionCode, GLCode, ClosingDate )
            WITH   SORT_IN_TEMPDB	
            ON [PRIMARY]
	
	-- SELECT OpeningBalance From OpeningBalanceTAB With ClosingDate Filter
            SELECT  dbo.OpeningBalances.ClosingDate ,
                    dbo.OpeningBalances.BranchCode ,
                    dbo.OpeningBalances.DivisionCode ,
                    dbo.OpeningBalances.GLCode ,
                    dbo.OpeningBalances.DebitBalance
                    - dbo.OpeningBalances.CreditBalance AS OpeningBalance
            INTO    #OpeningTAB
            FROM    dbo.OpeningBalances
                    INNER JOIN #OpeningDate ON dbo.OpeningBalances.BranchCode = #OpeningDate.BranchCode
                                               AND dbo.OpeningBalances.ClosingDate = #OpeningDate.ClosingDate
                                               AND dbo.OpeningBalances.DivisionCode = #OpeningDate.DivisionCode
                                               AND dbo.OpeningBalances.GLCode = #OpeningDate.GLCode
	
	-- SELECT Previous Closing Date For Master Transaction Filter
            SELECT  @DocDate = ISNULL(MIN(#OpeningDate.ClosingDate), 0) + 1
            FROM    #OpeningDate
	--PRINT @DocDate
	
	-- Select Master Transaction For DetailTransaction Filter
            SELECT  dbo.Vouchers.BranchCode ,
                    dbo.Vouchers.VoucherNature ,
                    dbo.Vouchers.VoucherNo ,
                    dbo.Vouchers.VoucherDate
            INTO    #TransMaster
            FROM    dbo.Vouchers
                    INNER JOIN #Branches ON dbo.Vouchers.BranchCode = #Branches.BranchCode
            WHERE   ( dbo.Vouchers.VoucherDate BETWEEN @DocDate
                                               AND     @ToDate )
                    AND ( dbo.Vouchers.Posted = @Posted
                          OR @PostedED = 0
                        ) 
            CREATE INDEX #IX_TransMaster ON #TransMaster ( BranchCode, VoucherNature, VoucherNo )
            WITH   SORT_IN_TEMPDB	
            ON [PRIMARY]	
	-- SELECT Detail Transaction With Date
            SELECT  dbo.VoucherDetails.BranchCode ,
                    #TransMaster.VoucherDate ,
                    dbo.VoucherDetails.GLCode ,
                    dbo.VoucherDetails.DivisionCode AS Division ,
                    dbo.VoucherDetails.Debit ,
                    dbo.VoucherDetails.Credit
            INTO    #TransDetail
            FROM    #TransMaster
                    INNER JOIN dbo.VoucherDetails ON #TransMaster.BranchCode = dbo.VoucherDetails.BranchCode
                                                     AND #TransMaster.VoucherNature = dbo.VoucherDetails.VoucherNature
                                                     AND #TransMaster.VoucherNo = dbo.VoucherDetails.VoucherNo
                    INNER JOIN #Divisions ON dbo.VoucherDetails.DivisionCode = #Divisions.DivisionCode
	
            CREATE INDEX #IX_TransDetail ON #TransDetail ( BranchCode, VoucherDate, GLCode, Division )
            WITH   SORT_IN_TEMPDB	
            ON [PRIMARY]	
	-- Select Transaction Balance
            SELECT  #TransDetail.BranchCode ,
                    #TransDetail.Division ,
                    #TransDetail.GLCode ,
                    SUM(#TransDetail.Debit) - SUM(#TransDetail.Credit) AS TransBalance
            INTO    #TransBalTAB
            FROM    #TransDetail
                    LEFT OUTER JOIN #OpeningDate ON #TransDetail.BranchCode = #OpeningDate.BranchCode
                                                    AND #TransDetail.VoucherDate > #OpeningDate.ClosingDate
                                                    AND #TransDetail.GLCode = #OpeningDate.GLCode
                                                    AND #TransDetail.Division = #OpeningDate.DivisionCode
            GROUP BY #TransDetail.BranchCode ,
                    #TransDetail.Division ,
                    #TransDetail.GLCode
	
	---   Final Opening Balance 
            SELECT  BranchCode ,
                    DivisionCode ,
                    GLCode ,
                    SUM(OpeningBalance) AS OpeningBalance
            INTO    #TransTAB
            FROM    ( SELECT    BranchCode ,
                                DivisionCode ,
                                GLCode ,
                                OpeningBalance
                      FROM      #OpeningTAB
                      UNION ALL
                      SELECT    BranchCode ,
                                Division ,
                                GLCode ,
                                TransBalance
                      FROM      #TransBalTAB
                    ) TransTAB
            GROUP BY BranchCode ,
                    DivisionCode ,
                    GLCode
	
	--- Final Opening Balance With Titles
            SELECT  #Branches.BranchCode ,
                    #Branches.BranchRptTitle ,
                    #Divisions.DivisionCode ,
                    #Divisions.DivisionRptTitle ,
                    #COACombineLedTBRptVW.GLCode ,
                    #COACombineLedTBRptVW.GLRptTitle ,
                    #COACombineLedTBRptVW.ControlCode ,
                    #COACombineLedTBRptVW.ControlRptTitle ,
                    #COACombineLedTBRptVW.GeneralCode ,
                    #COACombineLedTBRptVW.GeneralRptTitle ,
                    #COACombineLedTBRptVW.SubSidiaryCode ,
                    #COACombineLedTBRptVW.SubsidiaryRptTitle ,
                    #COACombineLedTBRptVW.SubsubCode ,
                    #COACombineLedTBRptVW.SubSubRptTitle ,
                    #TransTAB.OpeningBalance
            INTO    TempCOAOpeningLedger
            FROM    #TransTAB
                    INNER JOIN #Branches ON #TransTAB.BranchCode = #Branches.BranchCode
                    INNER JOIN #Divisions ON #TransTAB.DivisionCode = #Divisions.DivisionCode
                    INNER JOIN #COACombineLedTBRptVW ON #TransTAB.GLCode = #COACombineLedTBRptVW.GLCode
            WHERE   #TransTAB.OpeningBalance <> 0
        END
    ELSE 
        IF @nType = 1			--Account Ledger ALL Transaction 
            BEGIN
	
                IF EXISTS ( SELECT  *
                            FROM    sysobjects
                            WHERE   ID = OBJECT_ID(N'TempTransDetailLedger')
                                    AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                    BEGIN
                        DROP TABLE  TempTransDetailLedger
                    END
                SELECT  DivisionCode AS SysDivisionCode ,
                        DivisionCode ,
                        Division ,
                        Division AS DivisionRptTitle
                INTO    #DivisionsT
                FROM    dbo.Divisions
                WHERE   ( dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode
                                                     AND     @ToDivisionCode )
	
                CREATE INDEX [#IX_DivisionsT ] ON #DivisionsT (   DivisionCode )
                WITH   SORT_IN_TEMPDB
                ON [PRIMARY]
                SELECT  BranchCode AS SysBranchCode ,
                        BranchCode ,
                        BranchDescription AS Branch ,
                        BranchDescription AS BranchRptTitle
                INTO    #BranchesT
                FROM    dbo.Branches
                WHERE   ( dbo.Branches.BranchCode BETWEEN @FromBranchCode
                                                  AND     @ToBranchCode )
	
                CREATE INDEX #IX_BranchesT ON #BranchesT (   BranchCode )
                WITH   SORT_IN_TEMPDB
                ON [PRIMARY]	
	
                SELECT  GLCode ,
                        GLRptTitle ,
                        ControlCode ,
                        ControlRptTitle ,
                        GeneralCode ,
                        GeneralRptTitle ,
                        SubSidiaryCode ,
                        SubsidiaryRptTitle ,
                        SubsubCode ,
                        SubSubRptTitle
                INTO    #COACombineLedTBRptVWT
                FROM    dbo.GL_GetCOACombineLedTBRptVW
                WHERE   ( dbo.GL_GetCOACombineLedTBRptVW.GLCode BETWEEN @FromGLCode
                                                              AND
                                                              @ToGLCode )
                CREATE INDEX #IX_COACombineLedTBRptVWT ON #COACombineLedTBRptVWT ( GLCode )
                WITH   SORT_IN_TEMPDB	
                ON [PRIMARY]
	
                SELECT  NatureCode AS SysNatureCode ,
                        NatureCode ,
                        Nature ,
                        Nature AS NatureRptTitle
                INTO    #NatureTABT
                FROM    dbo.TransactionNatures
                WHERE   ',' + @VoucherNatureCode + ',' LIKE '%,'
                        + CAST(NatureCode AS VARCHAR) + ',%'
                        OR @VoucherNatureCode = ''
                CREATE INDEX #IX_NatureTABT ON #NatureTABT (   NatureCode )
                WITH   SORT_IN_TEMPDB	
                ON [PRIMARY]

                SELECT  dbo.Vouchers.BranchCode ,
                        dbo.Vouchers.VoucherNature ,
                        dbo.Vouchers.VoucherNo ,
                        dbo.Vouchers.VoucherDate ,
                        dbo.Vouchers.Description ,
                        dbo.Vouchers.RecordNo ,
                        dbo.Vouchers.OldRef ,
                        dbo.Vouchers.Posted ,
                        dbo.Vouchers.Locked
                INTO    #TransMasterT
                FROM    dbo.Vouchers
                        INNER JOIN #BranchesT ON dbo.Vouchers.BranchCode = #BranchesT.BranchCode
                WHERE   ( dbo.Vouchers.VoucherDate BETWEEN @FromDate
                                                   AND     @ToDate )
                        AND ( dbo.Vouchers.Posted = @Posted
                              OR @PostedED = 0
                            ) 
	
                CREATE INDEX #IX_TransMasterT ON #TransMasterT ( BranchCode, VoucherNature, VoucherNo )
                WITH   SORT_IN_TEMPDB	
                ON [PRIMARY]


                SELECT  #BranchesT.BranchCode ,
                        #BranchesT.BranchRptTitle ,
                        #DivisionsT.DivisionCode ,
                        #DivisionsT.DivisionRptTitle ,
                        #COACombineLedTBRptVWT.GLCode ,
                        #COACombineLedTBRptVWT.GLRptTitle ,
                        #NatureTABT.NatureCode ,
                        #NatureTABT.NatureRptTitle ,
                        #TransMasterT.VoucherDate ,
                        dbo.VoucherDetails.VoucherNo ,
                        #TransMasterT.OldRef ,
                        dbo.VoucherDetails.Narration ,
                        #TransMasterT.Description AS NarrationMain ,
                        #TransMasterT.RecordNo ,
                        dbo.VoucherDetails.Reference ,
                        dbo.VoucherDetails.Debit ,
                        dbo.VoucherDetails.Credit ,
                        #COACombineLedTBRptVWT.ControlCode ,
                        #COACombineLedTBRptVWT.ControlRptTitle ,
                        #COACombineLedTBRptVWT.GeneralCode ,
                        #COACombineLedTBRptVWT.GeneralRptTitle ,
                        #COACombineLedTBRptVWT.SubSidiaryCode ,
                        #COACombineLedTBRptVWT.SubsidiaryRptTitle ,
                        #COACombineLedTBRptVWT.SubsubCode ,
                        #COACombineLedTBRptVWT.SubSubRptTitle ,
                        #TransMasterT.Posted ,
                        #TransMasterT.Locked ,
                        dbo.VoucherDetails.RecordNo AS DetailRecordNo
                INTO    TempTransDetailLedger
                FROM    dbo.VoucherDetails
                        INNER JOIN #NatureTABT ON dbo.VoucherDetails.VoucherNature = #NatureTABT.NatureCode
                        INNER JOIN #BranchesT ON dbo.VoucherDetails.BranchCode = #BranchesT.BranchCode
                        INNER JOIN #DivisionsT ON dbo.VoucherDetails.DivisionCode = #DivisionsT.DivisionCode
                        INNER JOIN #COACombineLedTBRptVWT ON dbo.VoucherDetails.GLCode = #COACombineLedTBRptVWT.GLCode
                        INNER JOIN #TransMasterT ON dbo.VoucherDetails.BranchCode = #TransMasterT.BranchCode
                                                    AND dbo.VoucherDetails.VoucherNature = #TransMasterT.VoucherNature
                                                    AND dbo.VoucherDetails.VoucherNo = #TransMasterT.VoucherNo
	--  WHERE     (#TransMasterT.VoucherDate BETWEEN  @FromDate AND @ToDate ) 
	 -- ORDER BY  #TransMaster.VoucherDate, dbo.VoucherDetails.VoucherNo
	
/*
	SELECT     #BranchesT.BranchCode, #BranchesT.BranchRptTitle, #DivisionsT.DivisionCode, #DivisionsT.DivisionRptTitle, 
	      #COACombineLedTBRptVWT.GLCode, #COACombineLedTBRptVWT.GLRptTitle, #NatureTABT.NatureCode, 
	      #NatureTABT.NatureRptTitle, dbo.Vouchers.VoucherDate, dbo.VoucherDetails.VoucherNo, 
	      dbo.VoucherDetails.Narration, dbo.Vouchers.Narration AS NarrationMain, dbo.VoucherDetails.Reference, 
	      dbo.VoucherDetails.Debit, dbo.VoucherDetails.Credit, #COACombineLedTBRptVWT.ControlCode, 
	      #COACombineLedTBRptVWT.ControlRptTitle, #COACombineLedTBRptVWT.GeneralCode, 
	      #COACombineLedTBRptVWT.GeneralRptTitle, #COACombineLedTBRptVWT.SubSidiaryCode, 
	      #COACombineLedTBRptVWT.SubsidiaryRptTitle, #COACombineLedTBRptVWT.SubsubCode, 
	      #COACombineLedTBRptVWT.SubSubRptTitle INTO TempTransDetailLedger
	FROM         dbo.VoucherDetails INNER JOIN
	      #NatureTABT ON dbo.VoucherDetails.VoucherNature = #NatureTABT.NatureCode INNER JOIN
	      #BranchesT ON dbo.VoucherDetails.BranchCode = #BranchesT.BranchCode INNER JOIN
	      #DivisionsT ON dbo.VoucherDetails.Division = #DivisionsT.DivisionCode INNER JOIN
	      #COACombineLedTBRptVWT ON dbo.VoucherDetails.GLCode = #COACombineLedTBRptVWT.GLCode LEFT OUTER JOIN
	      dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
	      dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
	      dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo
	 WHERE     (dbo.Vouchers.VoucherDate BETWEEN  @FromDate AND @ToDate )
	 ORDER BY  dbo.Vouchers.VoucherDate, dbo.VoucherDetails.VoucherNo
*/		
            END
        ELSE 
            IF @nType = 2 
                BEGIN
                    IF EXISTS ( SELECT  *
                                FROM    sysobjects
                                WHERE   ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                        AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                        BEGIN
                            DROP TABLE  TempTransDetailLedgerTrial
                        END
                    SELECT  DivisionCode AS SysDivisionCode ,
                            DivisionCode ,
                            Division ,
                            Division AS DivisionRptTitle
                    INTO    #DivisionsTr
                    FROM    dbo.Divisions
                    WHERE   ( dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode
                                                         AND  @ToDivisionCode )
                    CREATE INDEX [#IX_DivisionsTr ] ON #DivisionsTr (   DivisionCode )
                    WITH   SORT_IN_TEMPDB
                    ON [PRIMARY]
	
                    SELECT  BranchCode AS SysBranchCode ,
                            BranchCode ,
                            BranchDescription AS Branch ,
                            BranchDescription AS BranchRptTitle
                    INTO    #BranchesTr
                    FROM    dbo.Branches
                    WHERE   ( dbo.Branches.BranchCode BETWEEN @FromBranchCode
                                                      AND     @ToBranchCode )
                    CREATE INDEX #IX_BranchesTr ON #BranchesTr (   BranchCode )
                    WITH   SORT_IN_TEMPDB
                    ON [PRIMARY]
	
                    SELECT  GLCode ,
                            GLRptTitle ,
                            ControlCode ,
                            ControlRptTitle ,
                            GeneralCode ,
                            GeneralRptTitle ,
                            SubSidiaryCode ,
                            SubsidiaryRptTitle ,
                            SubsubCode ,
                            SubSubRptTitle
                    INTO    #COACombineLedTBRptVWTr
                    FROM    dbo.GL_GetCOACombineLedTBRptVW
                    WHERE   ( dbo.GL_GetCOACombineLedTBRptVW.GLCode BETWEEN @FromGLCode
                                                              AND
                                                              @ToGLCode )
	
                    CREATE INDEX #IX_COACombineLedTBRptVWTr ON #COACombineLedTBRptVWTr (   GLCode )
                    WITH   SORT_IN_TEMPDB	
                    ON [PRIMARY]
                    SELECT  NatureCode AS SysNatureCode ,
                            NatureCode ,
                            Nature ,
                            Nature AS NatureRptTitle
                    INTO    #NatureTABTr
                    FROM    dbo.TransactionNatures
                    WHERE   ',' + @VoucherNatureCode + ',' LIKE '%,'
                            + CAST(NatureCode AS VARCHAR) + ',%'
                            OR @VoucherNatureCode = ''
	
                    CREATE INDEX #IX_NatureTABTr ON #NatureTABTr (   NatureCode )
                    WITH   SORT_IN_TEMPDB	
                    ON [PRIMARY]
	
                    SELECT  #BranchesTr.BranchCode ,
                            #BranchesTr.BranchRptTitle ,
                            #DivisionsTr.DivisionCode ,
                            #DivisionsTr.DivisionRptTitle ,
                            dbo.VoucherDetails.GLCode ,
                            SUM(dbo.VoucherDetails.Debit) AS DebitBalance ,
                            SUM(dbo.VoucherDetails.Credit) AS CreditBalance
                    INTO    #ConsTrans
                    FROM    dbo.VoucherDetails
                            INNER JOIN #NatureTABTr ON dbo.VoucherDetails.VoucherNature = #NatureTABTr.NatureCode
                            INNER JOIN #BranchesTr ON dbo.VoucherDetails.BranchCode = #BranchesTr.BranchCode
                            INNER JOIN #DivisionsTr ON dbo.VoucherDetails.DivisionCode = #DivisionsTr.DivisionCode
                            INNER JOIN #COACombineLedTBRptVWTr ON dbo.VoucherDetails.GLCode = #COACombineLedTBRptVWTr.GLCode
                            LEFT OUTER JOIN dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode
                                                            AND dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature
                                                            AND dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo
                    WHERE   ( dbo.Vouchers.VoucherDate BETWEEN @FromDate
                                                       AND    @ToDate )
                            AND ( dbo.Vouchers.Posted = @Posted
                                  OR @PostedED = 0
                                )
                    GROUP BY #BranchesTr.BranchCode ,
                            #BranchesTr.BranchRptTitle ,
                            #DivisionsTr.DivisionCode ,
                            #DivisionsTr.DivisionRptTitle ,
                            dbo.VoucherDetails.GLCode
	
                    CREATE INDEX #IX_ConsTrans ON #ConsTrans ( GLCode )
                    WITH   SORT_IN_TEMPDB	
                    ON [PRIMARY]
/*	SELECT     #ConsTrans.BranchCode, #ConsTrans.BranchRptTitle, #ConsTrans.DivisionCode, #ConsTrans.DivisionRptTitle, 
	                      #ConsTrans.DebitBalance, #ConsTrans.CreditBalance, #COACombineLedTBRptVWTr.GLCode, #COACombineLedTBRptVWTr.GLRptTitle, 
	                      #COACombineLedTBRptVWTr.ControlCode, #COACombineLedTBRptVWTr.ControlRptTitle, 
	                      #COACombineLedTBRptVWTr.GeneralCode, #COACombineLedTBRptVWTr.GeneralRptTitle, 
	                      #COACombineLedTBRptVWTr.SubSidiaryCode, #COACombineLedTBRptVWTr.SubsidiaryRptTitle, 
	                      #COACombineLedTBRptVWTr.SubsubCode, #COACombineLedTBRptVWTr.SubSubRptTitle INTO TempTransDetailLedgerTrial
	FROM         #ConsTrans INNER JOIN
	                      #COACombineLedTBRptVWTr ON  #ConsTrans.GLCode = #COACombineLedTBRptVWTr.GLCode*/
                    SELECT  #ConsTrans.BranchCode ,
                            #ConsTrans.BranchRptTitle ,
                            #ConsTrans.DivisionCode ,
                            #ConsTrans.DivisionRptTitle ,
                            #COACombineLedTBRptVWTr.GLCode ,
                            #COACombineLedTBRptVWTr.GLRptTitle ,
                            #COACombineLedTBRptVWTr.ControlCode ,
                            #COACombineLedTBRptVWTr.ControlRptTitle ,
                            #COACombineLedTBRptVWTr.GeneralCode ,
                            #COACombineLedTBRptVWTr.GeneralRptTitle ,
                            #COACombineLedTBRptVWTr.SubSidiaryCode ,
                            #COACombineLedTBRptVWTr.SubsidiaryRptTitle ,
                            #COACombineLedTBRptVWTr.SubsubCode ,
                            #COACombineLedTBRptVWTr.SubSubRptTitle ,
                            0 AS OpeningBalance ,
                            #ConsTrans.DebitBalance ,
                            #ConsTrans.CreditBalance
                    INTO    TempTransDetailLedgerTrial
                    FROM    #ConsTrans
                            INNER JOIN #COACombineLedTBRptVWTr ON #ConsTrans.GLCode = #COACombineLedTBRptVWTr.GLCode
                END
            ELSE 
                IF @nType = 3		--  GET COA Opening FROM TempTAB
                    BEGIN
                        IF EXISTS ( SELECT  *
                                    FROM    sysobjects
                                    WHERE   ID = OBJECT_ID(N'TempCOAOpeningLedger')
                                            AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                            BEGIN
                                SELECT  *
                                FROM    TempCOAOpeningLedger
                                DROP TABLE  TempCOAOpeningLedger
                            END
                        ELSE 
                            BEGIN
                                SELECT  '' AS Error
                                WHERE   0 = 1
                            END
                    END
                ELSE 
                    IF @nType = 4		--  GET Transaction Detail
                        BEGIN
                            IF EXISTS ( SELECT  *
                                        FROM    sysobjects
                                        WHERE   ID = OBJECT_ID(N'TempTransDetailLedger')
                                                AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                BEGIN
                                    SELECT  *
                                    FROM    TempTransDetailLedger
                                    ORDER BY BranchCode ,
                                            GLCode ,
                                            VoucherDate ,
                                            RecordNo 
		--DROP TABLE  TempTransDetailLedger
                                END
                            ELSE 
                                BEGIN
                                    SELECT  '' AS Error
                                    WHERE   0 = 1
                                END
                        END
                    ELSE 
                        IF @nType = 5		--  GET Transaction Detail for Trial Balance
                            BEGIN
/*	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempTransDetailLedgerTrial' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		SELECT   *	FROM         dbo.TempTransDetailLedgerTrial
		DROP TABLE  TempTransDetailLedgerTrial
		END
	ELSE
		BEGIN
			SELECT     '' AS Error
			WHERE 0 = 1
		END*/
                                IF EXISTS ( SELECT  *
                                            FROM    sysobjects
                                            WHERE   ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                    AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                    BEGIN
                                        SELECT  BranchCode ,
                                                BranchRptTitle ,
                                                DivisionCode ,
                                                DivisionRptTitle ,
                                                GLCode ,
                                                GLRptTitle ,
                                                ControlCode ,
                                                ControlRptTitle ,
                                                GeneralCode ,
                                                GeneralRptTitle ,
                                                SubSidiaryCode ,
                                                SubsidiaryRptTitle ,
                                                SubsubCode ,
                                                SubSubRptTitle ,
                                                SUM(OpeningBalance) AS OpBalance ,
                                                SUM(DebitBalance) AS DBBalance ,
                                                SUM(CreditBalance) AS CrBalance
                                        FROM    ( SELECT    BranchCode ,
                                                            BranchRptTitle ,
                                                            DivisionCode ,
                                                            DivisionRptTitle ,
                                                            GLCode ,
                                                            GLRptTitle ,
                                                            ControlCode ,
                                                            ControlRptTitle ,
                                                            GeneralCode ,
                                                            GeneralRptTitle ,
                                                            SubSidiaryCode ,
                                                            SubsidiaryRptTitle ,
                                                            SubsubCode ,
                                                            SubSubRptTitle ,
                                                            OpeningBalance ,
                                                            0 AS DebitBalance ,
                                                            0 AS CreditBalance
                                                  FROM      dbo.TempCOAOpeningLedger
                                                  UNION ALL
                                                  SELECT    BranchCode ,
                                                            BranchRptTitle ,
                                                            DivisionCode ,
                                                            DivisionRptTitle ,
                                                            GLCode ,
                                                            GLRptTitle ,
                                                            ControlCode ,
                                                            ControlRptTitle ,
                                                            GeneralCode ,
                                                            GeneralRptTitle ,
                                                            SubSidiaryCode ,
                                                            SubsidiaryRptTitle ,
                                                            SubsubCode ,
                                                            SubSubRptTitle ,
                                                            OpeningBalance ,
                                                            DebitBalance ,
                                                            CreditBalance
                                                  FROM      dbo.TempTransDetailLedgerTrial
                                                ) TrialBalance
                                        GROUP BY BranchCode ,
                                                BranchRptTitle ,
                                                DivisionCode ,
                                                DivisionRptTitle ,
                                                GLCode ,
                                                GLRptTitle ,
                                                ControlCode ,
                                                ControlRptTitle ,
                                                GeneralCode ,
                                                GeneralRptTitle ,
                                                SubSidiaryCode ,
                                                SubsidiaryRptTitle ,
                                                SubsubCode ,
                                                SubSubRptTitle 
                                    END
                                ELSE 
                                    BEGIN
                                        SELECT  '' AS Error
                                        WHERE   0 = 1
                                    END
                            END
                        ELSE 
                            IF @nType = 101		--  GET Trial Balance Consolidate , Control Wise
                                BEGIN
                                    IF EXISTS ( SELECT  *
                                                FROM    sysobjects
                                                WHERE   ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                        AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                        BEGIN
                                            SELECT  '' AS BranchCode ,
                                                    '' AS BranchRptTitle ,
                                                    '' AS DivisionCode ,
                                                    '' AS DivisionRptTitle ,
                                                    '' AS GLCode ,
                                                    '' AS GLRptTitle ,
                                                    ControlCode ,
                                                    ControlRptTitle ,
                                                    '' AS GeneralCode ,
                                                    '' AS GeneralRptTitle ,
                                                    '' AS SubSidiaryCode ,
                                                    '' AS SubsidiaryRptTitle ,
                                                    '' AS SubsubCode ,
                                                    '' AS SubSubRptTitle ,
                                                    SUM(OpeningBalance) AS OpBalance ,
                                                    SUM(DebitBalance) AS DbBalance ,
                                                    SUM(CreditBalance) AS CrBalance
                                            FROM    ( SELECT  BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                      FROM    dbo.TempCOAOpeningLedger
                                                      UNION ALL
                                                      SELECT  BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                      FROM    dbo.TempTransDetailLedgerTrial
                                                    ) Balances
                                            GROUP BY ControlCode ,
                                                    ControlRptTitle
                                            HAVING  ( ABS(SUM(OpeningBalance))
                                                      + ABS(SUM(DebitBalance))
                                                      + ABS(SUM(CreditBalance)) <> 0
                                                      AND @ReportSD = 'DET'
                                                    )
                                                    OR ( SUM(OpeningBalance)
                                                         + SUM(DebitBalance)
                                                         - SUM(CreditBalance) <> 0
                                                         AND @ReportSD = 'SUM'
                                                       ) 
                                        END
                                    ELSE 
                                        BEGIN
                                            SELECT  '' AS Error
                                            WHERE   0 = 1
                                        END
                                END
                            ELSE 
                                IF @nType = 104		--  GET Trial Balance Consolidate , General Wise
                                    BEGIN
                                        IF EXISTS ( SELECT  *
                                                    FROM    sysobjects
                                                    WHERE   ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                            AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                            BEGIN
                                                SELECT  '' AS BranchCode ,
                                                        '' AS BranchRptTitle ,
                                                        '' AS DivisionCode ,
                                                        '' AS DivisionRptTitle ,
                                                        '' AS GLCode ,
                                                        '' AS GLRptTitle ,
                                                        ControlCode ,
                                                        ControlRptTitle ,
                                                        GeneralCode ,
                                                        GeneralRptTitle ,
                                                        '' AS SubSidiaryCode ,
                                                        '' AS SubsidiaryRptTitle ,
                                                        '' AS SubsubCode ,
                                                        '' AS SubSubRptTitle ,
                                                        SUM(OpeningBalance) AS OpBalance ,
                                                        SUM(DebitBalance) AS DbBalance ,
                                                        SUM(CreditBalance) AS CrBalance
                                                FROM    ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                          FROM
                                                              dbo.TempCOAOpeningLedger
                                                          UNION ALL
                                                          SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                          FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                        ) Balances
                                                GROUP BY ControlCode ,
                                                        ControlRptTitle ,
                                                        GeneralCode ,
                                                        GeneralRptTitle
                                                HAVING  ( ABS(SUM(OpeningBalance))
                                                          + ABS(SUM(DebitBalance))
                                                          + ABS(SUM(CreditBalance)) <> 0
                                                          AND @ReportSD = 'DET'
                                                        )
                                                        OR ( SUM(OpeningBalance)
                                                             + SUM(DebitBalance)
                                                             - SUM(CreditBalance) <> 0
                                                             AND @ReportSD = 'SUM'
                                                           ) 
                                            END
                                        ELSE 
                                            BEGIN
                                                SELECT  '' AS Error
                                                WHERE   0 = 1
                                            END
                                    END
                                ELSE 
                                    IF @nType = 108		--  GET Trial Balance Consolidate , Subsidiary Wise
                                        BEGIN
                                            IF EXISTS ( SELECT
                                                              *
                                                        FROM  sysobjects
                                                        WHERE ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                BEGIN
                                                    SELECT  '' AS BranchCode ,
                                                            '' AS BranchRptTitle ,
                                                            '' AS DivisionCode ,
                                                            '' AS DivisionRptTitle ,
                                                            '' AS GLCode ,
                                                            '' AS GLRptTitle ,
                                                            ControlCode ,
                                                            ControlRptTitle ,
                                                            GeneralCode ,
                                                            GeneralRptTitle ,
                                                            SubSidiaryCode ,
                                                            SubsidiaryRptTitle ,
                                                            '' AS SubsubCode ,
                                                            '' AS SubSubRptTitle ,
                                                            SUM(OpeningBalance) AS OpBalance ,
                                                            SUM(DebitBalance) AS DbBalance ,
                                                            SUM(CreditBalance) AS CrBalance
                                                    FROM    ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                            ) Balances
                                                    GROUP BY ControlCode ,
                                                            ControlRptTitle ,
                                                            GeneralCode ,
                                                            GeneralRptTitle ,
                                                            SubSidiaryCode ,
                                                            SubsidiaryRptTitle
                                                    HAVING  ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                            )
                                                            OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                END
                                            ELSE 
                                                BEGIN
                                                    SELECT  '' AS Error
                                                    WHERE   0 = 1
                                                END
                                        END
                                    ELSE 
                                        IF @nType = 112		--  GET Trial Balance Consolidate , Subsidiary Wise
                                            BEGIN
                                                IF EXISTS ( SELECT
                                                              *
                                                            FROM
                                                              sysobjects
                                                            WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                    BEGIN
                                                        SELECT
                                                              '' AS BranchCode ,
                                                              '' AS BranchRptTitle ,
                                                              '' AS DivisionCode ,
                                                              '' AS DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                        FROM  ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                        GROUP BY ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle
                                                        HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                    END
                                                ELSE 
                                                    BEGIN
                                                        SELECT
                                                              '' AS Error
                                                        WHERE 0 = 1
                                                    END
                                            END
                                        ELSE 
                                            IF @nType = 102		--  GET Trial Balance Branch , Control Wise
                                                BEGIN
                                                    IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                        BEGIN
                                                            SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              '' AS DivisionCode ,
                                                              '' AS DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              '' AS GeneralCode ,
                                                              '' AS GeneralRptTitle ,
                                                              '' AS SubSidiaryCode ,
                                                              '' AS SubsidiaryRptTitle ,
                                                              '' AS SubsubCode ,
                                                              '' AS SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                            FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                            GROUP BY BranchCode ,
                                                              BranchRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle
                                                            HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                        END
                                                    ELSE 
                                                        BEGIN
                                                            SELECT
                                                              '' AS Error
                                                            WHERE
                                                              0 = 1
                                                        END
                                                END
                                            ELSE 
                                                IF @nType = 105		--  GET Trial Balance Branch , General Wise
                                                    BEGIN
                                                        IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                            BEGIN
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              '' AS DivisionCode ,
                                                              '' AS DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              '' AS SubSidiaryCode ,
                                                              '' AS SubsidiaryRptTitle ,
                                                              '' AS SubsubCode ,
                                                              '' AS SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                              FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                              GROUP BY BranchCode ,
                                                              BranchRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle
                                                              HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                            END
                                                        ELSE 
                                                            BEGIN
                                                              SELECT
                                                              '' AS Error
                                                              WHERE
                                                              0 = 1
                                                            END
                                                    END
                                                ELSE 
                                                    IF @nType = 109		--  GET Trial Balance Branch , Subsidiary Wise
                                                        BEGIN
                                                            IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                              BEGIN
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              '' AS DivisionCode ,
                                                              '' AS DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              '' AS SubsubCode ,
                                                              '' AS SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                              FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                              GROUP BY BranchCode ,
                                                              BranchRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle
                                                              HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                              END
                                                            ELSE 
                                                              BEGIN
                                                              SELECT
                                                              '' AS Error
                                                              WHERE
                                                              0 = 1
                                                              END
                                                        END
                                                    ELSE 
                                                        IF @nType = 113		--  GET Trial Balance Branch , Subsidiary Wise
                                                            BEGIN
                                                              IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                              BEGIN
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              '' AS DivisionCode ,
                                                              '' AS DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                              FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                              GROUP BY BranchCode ,
                                                              BranchRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle
                                                              HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                              END
                                                              ELSE 
                                                              BEGIN
                                                              SELECT
                                                              '' AS Error
                                                              WHERE
                                                              0 = 1
                                                              END
                                                            END
                                                        ELSE 
                                                            IF @nType = 103
                                                              OR @nType = 121 		--  GET Trial Balance Division , Control Wise
                                                              BEGIN
                                                              IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                              BEGIN
                                                              SELECT
                                                              '' AS BranchCode ,
                                                              '' AS BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              '' AS GeneralCode ,
                                                              '' AS GeneralRptTitle ,
                                                              '' AS SubSidiaryCode ,
                                                              '' AS SubsidiaryRptTitle ,
                                                              '' AS SubsubCode ,
                                                              '' AS SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                              FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                              GROUP BY DivisionCode ,
                                                              DivisionRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle
                                                              HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                              END
                                                              ELSE 
                                                              BEGIN
                                                              SELECT
                                                              '' AS Error
                                                              WHERE
                                                              0 = 1
                                                              END
                                                              END
                                                            ELSE 
                                                              IF @nType = 106
                                                              OR @nType = 124 		--  GET Trial Balance Division , General Wise
                                                              BEGIN
                                                              IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                              BEGIN
                                                              SELECT
                                                              '' AS BranchCode ,
                                                              '' AS BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              '' AS SubSidiaryCode ,
                                                              '' AS SubsidiaryRptTitle ,
                                                              '' AS SubsubCode ,
                                                              '' AS SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                              FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                              GROUP BY DivisionCode ,
                                                              DivisionRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle
                                                              HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                              END
                                                              ELSE 
                                                              BEGIN
                                                              SELECT
                                                              '' AS Error
                                                              WHERE
                                                              0 = 1
                                                              END
                                                              END
                                                              ELSE 
                                                              IF @nType = 110
                                                              OR @nType = 128 		--  GET Trial Balance Division  , Subsidiary Wise
                                                              BEGIN
                                                              IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                              BEGIN
                                                              SELECT
                                                              '' AS BranchCode ,
                                                              '' AS BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              '' AS SubsubCode ,
                                                              '' AS SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                              FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                              GROUP BY DivisionCode ,
                                                              DivisionRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle
                                                              HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                              END
                                                              ELSE 
                                                              BEGIN
                                                              SELECT
                                                              '' AS Error
                                                              WHERE
                                                              0 = 1
                                                              END
                                                              END
                                                              ELSE 
                                                              IF @nType = 114
                                                              OR @nType = 132 		--  GET Trial Balance Division  , Subsidiary Wise
                                                              BEGIN
                                                              IF EXISTS ( SELECT
                                                              *
                                                              FROM
                                                              sysobjects
                                                              WHERE
                                                              ID = OBJECT_ID(N'TempTransDetailLedgerTrial')
                                                              AND OBJECTPROPERTY(ID,
                                                              N'IsTable') = 1 ) 
                                                              BEGIN
                                                              SELECT
                                                              '' AS BranchCode ,
                                                              '' AS BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              '' AS GLCode ,
                                                              '' AS GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              SUM(OpeningBalance) AS OpBalance ,
                                                              SUM(DebitBalance) AS DbBalance ,
                                                              SUM(CreditBalance) AS CrBalance
                                                              FROM
                                                              ( SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              0 AS DebitBalance ,
                                                              0 AS CreditBalance
                                                              FROM
                                                              dbo.TempCOAOpeningLedger
                                                              UNION ALL
                                                              SELECT
                                                              BranchCode ,
                                                              BranchRptTitle ,
                                                              DivisionCode ,
                                                              DivisionRptTitle ,
                                                              GLCode ,
                                                              GLRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle ,
                                                              OpeningBalance ,
                                                              DebitBalance ,
                                                              CreditBalance
                                                              FROM
                                                              dbo.TempTransDetailLedgerTrial
                                                              ) Balances
                                                              GROUP BY DivisionCode ,
                                                              DivisionRptTitle ,
                                                              ControlCode ,
                                                              ControlRptTitle ,
                                                              GeneralCode ,
                                                              GeneralRptTitle ,
                                                              SubSidiaryCode ,
                                                              SubsidiaryRptTitle ,
                                                              SubsubCode ,
                                                              SubSubRptTitle
                                                              HAVING
                                                              ( ABS(SUM(OpeningBalance))
                                                              + ABS(SUM(DebitBalance))
                                                              + ABS(SUM(CreditBalance)) <> 0
                                                              AND @ReportSD = 'DET'
                                                              )
                                                              OR ( SUM(OpeningBalance)
                                                              + SUM(DebitBalance)
                                                              - SUM(CreditBalance) <> 0
                                                              AND @ReportSD = 'SUM'
                                                              ) 
                                                              END
                                                              ELSE 
                                                              BEGIN
                                                              SELECT
                                                              '' AS Error
                                                              WHERE
                                                              0 = 1
                                                              END
                                                              END

GO
