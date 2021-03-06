USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectFinancialStatementReports]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
--drop PROCEDURE SelectFinancialStatementReports  
CREATE PROCEDURE [dbo].[SelectFinancialStatementReports]  
@FromBranchCode varchar(10)='',  
@ToBranchCode varchar(10)='' , 
@FromDivisionCode varchar(10)='',  
@ToDivisionCode varchar(10)='' , 
@FromGLCode varchar(50)='',  
@ToGLCode varchar(50)='', 
@FromFSFCode varchar(50)='',  
@ToFSFCode varchar(50)='', 
@FromDate DateTime= NULL ,  
@ToDate DateTime= NULL, 
@nType bigint =0 , 
@VoucherNatureCode   varchar(100) = '' ,
@ReportSD as varchar ( 10 ) = 'DET' ,
@Posted bit = 1,
@PostedED bit = 0
--2   112   3   0
AS
IF @nType = 0 --OPENING 1
	BEGIN			
	DECLARE @DocDate   as datetime
	
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempCOAOpening' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
	BEGIN
		DROP TABLE  TempCOAOpening
	END
	
	-- SELECT Division with Filter
	SELECT     DivisionCode as   SysDivisionCode, DivisionCode, Division, Division  AS DivisionRptTitle 
	INTO 	#DivisionTAB
	FROM         dbo.Divisions
	WHERE	(dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode AND @ToDivisionCode)
	
	CREATE INDEX #IX_DivisionTAB ON #DivisionTAB ( SysDivisionCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]
	-- SELECT Branch with Filter
	SELECT   BranchCode as   SysBranchCode, BranchCode, BranchDescription, BranchDescription as  BranchRptTitle 
	INTO #BranchTAB
	FROM         dbo.Branches
	WHERE (dbo.Branches.BranchCode BETWEEN @FromBranchCode AND @ToBranchCode)
	
	CREATE INDEX #IX_BranchTAB ON #BranchTAB ( SysBranchCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]
	-- SELECT GLAccount with Filter
	SELECT     GLCode as SysGLCode, GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, GeneralRptTitle, 
		SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle ,SysFSFGLCode
	INTO 	#COACombineLedTBRptVW
	FROM         dbo.GL_GetCOACombineLedTBRptVW
	WHERE  (dbo.GL_GetCOACombineLedTBRptVW.GLCode BETWEEN @FromGLCode AND @ToGLCode )
	CREATE INDEX #IX_COACombineLedTBRptVW ON #COACombineLedTBRptVW ( SysGLCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
	---- shamim
	
	SELECT    GLCode as  SysGLCode, GLCode as FSFGLCode, GLRptTitle as FSFGLRptTitle, ControlCode as FSFControlCode, ControlRptTitle as FSFControlRptTitle, GeneralCode as FSFGeneralCode , GeneralRptTitle as FSFGeneralRptTitle, 
		SubSidiaryCode as FSFSubSidiaryCode, SubsidiaryRptTitle as FSFSubsidiaryRptTitle, SubsubCode as FSFSubsubCode, SubSubRptTitle as FSFSubSubRptTitle
	INTO 	#FSFCombineLedTBRptVW
	FROM         dbo.GL_GetFSFCombineLedTBRptVW

	WHERE  (dbo.GL_GetFSFCombineLedTBRptVW.ControlCode BETWEEN @FromFSFCode AND @ToFSFCode ) --Fin. Stat.
		OR 
		  (dbo.GL_GetFSFCombineLedTBRptVW.GLCode BETWEEN @FromFSFCode AND @ToFSFCode )	    --FSCodes
--MAK
	CREATE INDEX #IX_FSFCombineLedTBRptVW ON #FSFCombineLedTBRptVW ( FSFGLCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
	SELECT     #COACombineLedTBRptVW.SysGLCode, #COACombineLedTBRptVW.GLCode, #COACombineLedTBRptVW.GLRptTitle, #COACombineLedTBRptVW.ControlCode, #COACombineLedTBRptVW.ControlRptTitle, #COACombineLedTBRptVW.GeneralCode, #COACombineLedTBRptVW.GeneralRptTitle, 
		#COACombineLedTBRptVW.SubSidiaryCode, #COACombineLedTBRptVW.SubsidiaryRptTitle, #COACombineLedTBRptVW.SubsubCode, #COACombineLedTBRptVW.SubSubRptTitle,#COACombineLedTBRptVW.SysFSFGLCode,
		#FSFCombineLedTBRptVW.FSFGLCode, #FSFCombineLedTBRptVW.FSFGLRptTitle, #FSFCombineLedTBRptVW.FSFControlCode, #FSFCombineLedTBRptVW.FSFControlRptTitle, #FSFCombineLedTBRptVW.FSFGeneralCode , #FSFCombineLedTBRptVW.FSFGeneralRptTitle, 
		#FSFCombineLedTBRptVW.FSFSubSidiaryCode, #FSFCombineLedTBRptVW.FSFSubsidiaryRptTitle, #FSFCombineLedTBRptVW.FSFSubsubCode, #FSFCombineLedTBRptVW.FSFSubSubRptTitle
	Into #COAAndFSFCombineVW
	From   #FSFCombineLedTBRptVW  INNER JOIN
    
    #COACombineLedTBRptVW
    ON #FSFCombineLedTBRptVW.FSFGLCode= #COACombineLedTBRptVW.SysFSFGLCode
	
	
	
	
	----
	
	
	
	
	-- SELECT Last Closing Date For OpeningBalanceTAB Filter
	SELECT     dbo.OpeningBalances.BranchCode, dbo.OpeningBalances.DivisionCode, dbo.OpeningBalances.GLCode, 
	                      MAX(dbo.OpeningBalances.ClosingDate) AS ClosingDate 
	INTO #OpeningDate
	FROM         dbo.OpeningBalances INNER JOIN
	                      #BranchTAB ON dbo.OpeningBalances.BranchCode = #BranchTAB.SysBranchCode INNER JOIN
	                      #COAAndFSFCombineVW ON dbo.OpeningBalances.GLCode = #COAAndFSFCombineVW.SysGLCode INNER JOIN
	                      #DivisionTAB ON dbo.OpeningBalances.DivisionCode = #DivisionTAB.SysDivisionCode
	WHERE     (dbo.OpeningBalances.ClosingDate <= @ToDate )
	GROUP BY dbo.OpeningBalances.BranchCode, dbo.OpeningBalances.DivisionCode, dbo.OpeningBalances.GLCode
	CREATE INDEX #IX_OpeningDate ON #OpeningDate ( BranchCode, DivisionCode, GLCode, ClosingDate )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
	-- SELECT OpeningBalance From OpeningBalanceTAB With ClosingDate Filter
	SELECT     dbo.OpeningBalances.ClosingDate, dbo.OpeningBalances.BranchCode, dbo.OpeningBalances.DivisionCode, 
	      dbo.OpeningBalances.GLCode, dbo.OpeningBalances.DebitBalance - dbo.OpeningBalances.CreditBalance AS OpeningBalance 
	INTO #OpeningTAB
	FROM         dbo.OpeningBalances INNER JOIN
	      #OpeningDate ON dbo.OpeningBalances.BranchCode = #OpeningDate.BranchCode AND 
	      dbo.OpeningBalances.ClosingDate = #OpeningDate.ClosingDate AND 
	      dbo.OpeningBalances.DivisionCode = #OpeningDate.DivisionCode AND 
	      dbo.OpeningBalances.GLCode = #OpeningDate.GLCode
	
	-- SELECT Previous Closing Date For Master Transaction Filter
	SELECT @DocDate = ISNULL( MIN(#OpeningDate.ClosingDate) , 0 ) + 1 FROM #OpeningDate
	--PRINT @DocDate
	
	-- Select Master Transaction For DetailTransaction Filter
	SELECT     dbo.Vouchers.BranchCode, dbo.Vouchers.VoucherNature, dbo.Vouchers.VoucherNo, 
		dbo.Vouchers.VoucherDate 
	INTO #TransMaster
	FROM         dbo.Vouchers INNER JOIN
		#BranchTAB ON dbo.Vouchers.BranchCode = #BranchTAB.SysBranchCode
	WHERE     (dbo.Vouchers.VoucherDate BETWEEN @DocDate AND @ToDate ) AND 
		      (dbo.Vouchers.Posted = @Posted OR @PostedED = 0 ) 
	CREATE INDEX #IX_TransMaster ON #TransMaster ( BranchCode, VoucherNature, VoucherNo )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]	
	-- SELECT Detail Transaction With Date
	SELECT     dbo.VoucherDetails.BranchCode, #TransMaster.VoucherDate, dbo.VoucherDetails.GLCode, 
		      dbo.VoucherDetails.DivisionCode, dbo.VoucherDetails.Debit, dbo.VoucherDetails.Credit 
	INTO #TransDetail
	FROM         #TransMaster INNER JOIN
		      dbo.VoucherDetails ON #TransMaster.BranchCode = dbo.VoucherDetails.BranchCode AND 
		      #TransMaster.VoucherNature = dbo.VoucherDetails.VoucherNature AND 
		      #TransMaster.VoucherNo = dbo.VoucherDetails.VoucherNo INNER JOIN
		      #DivisionTAB ON dbo.VoucherDetails.DivisionCode = #DivisionTAB.SysDivisionCode
	
	CREATE INDEX #IX_TransDetail ON #TransDetail ( BranchCode, VoucherDate, GLCode, DivisionCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]	
	-- Select Transaction Balance
	SELECT     #TransDetail.BranchCode, #TransDetail.DivisionCode, #TransDetail.GLCode, SUM(#TransDetail.Debit) 
		      - SUM(#TransDetail.Credit) AS TransBalance 
	INTO #TransBalTAB
	FROM         #TransDetail LEFT OUTER JOIN
		      #OpeningDate ON #TransDetail.BranchCode = #OpeningDate.BranchCode AND 
		      #TransDetail.VoucherDate > #OpeningDate.ClosingDate AND 
		      #TransDetail.GLCode = #OpeningDate.GLCode AND #TransDetail.DivisionCode = #OpeningDate.DivisionCode
	GROUP BY #TransDetail.BranchCode, #TransDetail.DivisionCode, #TransDetail.GLCode
	
	---   Final Opening Balance 
	SELECT     BranchCode, DivisionCode, GLCode, SUM(OpeningBalance) AS OpeningBalance INTO #TransTAB
	FROM         (SELECT     BranchCode, DivisionCode, GLCode, OpeningBalance
	                       FROM          #OpeningTAB
	                       UNION ALL
	                       SELECT     BranchCode, DivisionCode, GLCode, TransBalance
	                       FROM         #TransBalTAB) TransTAB
	GROUP BY BranchCode, DivisionCode, GLCode
	
	--- Final Opening Balance With Titles
	SELECT    #BranchTAB.BranchCode, #BranchTAB.BranchRptTitle, #DivisionTAB.DivisionCode, 
		      #DivisionTAB.DivisionRptTitle, #COAAndFSFCombineVW.GLCode, #COAAndFSFCombineVW.GLRptTitle, 
		      #COAAndFSFCombineVW.ControlCode, #COAAndFSFCombineVW.ControlRptTitle, 
		      #COAAndFSFCombineVW.GeneralCode, #COAAndFSFCombineVW.GeneralRptTitle, 
		      #COAAndFSFCombineVW.SubSidiaryCode, #COAAndFSFCombineVW.SubsidiaryRptTitle, 
		      #COAAndFSFCombineVW.SubsubCode, #COAAndFSFCombineVW.SubSubRptTitle, 	      
		      #COAAndFSFCombineVW.FSFGLCode, #COAAndFSFCombineVW.FSFGLRptTitle, 
		      #COAAndFSFCombineVW.FSFControlCode, #COAAndFSFCombineVW.FSFControlRptTitle, 
		      #COAAndFSFCombineVW.FSFGeneralCode, #COAAndFSFCombineVW.FSFGeneralRptTitle, 
		      #COAAndFSFCombineVW.FSFSubSidiaryCode, #COAAndFSFCombineVW.FSFSubsidiaryRptTitle, 
		      #COAAndFSFCombineVW.FSFSubsubCode, #COAAndFSFCombineVW.FSFSubSubRptTitle, 	      
		      
		      #TransTAB.OpeningBalance INTO TempCOAOpening
	FROM         #TransTAB INNER JOIN
		      #BranchTAB ON #TransTAB.BranchCode = #BranchTAB.SysBranchCode INNER JOIN
		      #DivisionTAB ON #TransTAB.DivisionCode = #DivisionTAB.SysDivisionCode INNER JOIN
		      #COAAndFSFCombineVW ON #TransTAB.GLCode = #COAAndFSFCombineVW.SysGLCode
	WHERE     #TransTAB.OpeningBalance <> 0
	END
	
	
ELSE IF @nType = 2
	BEGIN
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempTransDetailTrialFSF' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		DROP TABLE  TempTransDetailTrialFSF
		END
	SELECT    DivisionCode as  SysDivisionCode, DivisionCode, Division, Division AS DivisionRptTitle 
	INTO #DivisionTABTr
	FROM         dbo.Divisions
	WHERE	(dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode AND @ToDivisionCode)
	CREATE INDEX [#IX_DivisionTABTr ] ON #DivisionTABTr ( SysDivisionCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]
	
	
	SELECT  BranchCode as    SysBranchCode, BranchCode, BranchDescription, BranchDescription AS BranchRptTitle 
	INTO 	#BranchTABTr
	FROM         dbo.Branches
	WHERE (dbo.Branches.BranchCode BETWEEN @FromBranchCode AND @ToBranchCode)
	CREATE INDEX #IX_BranchTABTr ON #BranchTABTr ( SysBranchCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]
	
	
	SELECT     GLCode as SysGLCode, GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, GeneralRptTitle, 
		SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle, SysFSFGLCode 
	INTO 	#COACombineLedTBRptVWTr
	FROM         dbo.GL_GetCOACombineLedTBRptVW
	WHERE  (dbo.GL_GetCOACombineLedTBRptVW.GLCode BETWEEN @FromGLCode AND @ToGLCode )
	
	CREATE INDEX #IX_COACombineLedTBRptVWTr ON #COACombineLedTBRptVWTr ( SysGLCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
		
	---- shamim
	
	SELECT     GLCode as SysFSFGLCode, GLCode as FSFGLCode, GLRptTitle as FSFGLRptTitle, ControlCode as FSFControlCode, ControlRptTitle as FSFControlRptTitle, GeneralCode as FSFGeneralCode , GeneralRptTitle as FSFGeneralRptTitle, 
		SubSidiaryCode as FSFSubSidiaryCode, SubsidiaryRptTitle as FSFSubsidiaryRptTitle, SubsubCode as FSFSubsubCode, SubSubRptTitle as FSFSubSubRptTitle
	INTO 	#FSFCombineLedTBRptVWTr
	FROM         dbo.GL_GetFSFCombineLedTBRptVW
--MAK
--	WHERE  (dbo.GL_GetFSFCombineLedTBRptVW.GLCode BETWEEN @FromGLCode AND @ToGLCode )
	WHERE  (dbo.GL_GetFSFCombineLedTBRptVW.ControlCode BETWEEN @FromFSFCode AND @ToFSFCode )	
		OR 
		  (dbo.GL_GetFSFCombineLedTBRptVW.GLCode BETWEEN @FromFSFCode AND @ToFSFCode )	
--MAK	
	CREATE INDEX #IX_FSFCombineLedTBRptVWTr ON #FSFCombineLedTBRptVWTr ( SysFSFGLCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
	SELECT     #COACombineLedTBRptVWTr.SysGLCode, #COACombineLedTBRptVWTr.GLCode, #COACombineLedTBRptVWTr.GLRptTitle, #COACombineLedTBRptVWTr.ControlCode, #COACombineLedTBRptVWTr.ControlRptTitle, #COACombineLedTBRptVWTr.GeneralCode, #COACombineLedTBRptVWTr.GeneralRptTitle, 
		#COACombineLedTBRptVWTr.SubSidiaryCode, #COACombineLedTBRptVWTr.SubsidiaryRptTitle, #COACombineLedTBRptVWTr.SubsubCode, #COACombineLedTBRptVWTr.SubSubRptTitle, #COACombineLedTBRptVWTr.SysFSFGLCode ,
		#FSFCombineLedTBRptVWTr.FSFGLCode, #FSFCombineLedTBRptVWTr.FSFGLRptTitle, #FSFCombineLedTBRptVWTr.FSFControlCode, #FSFCombineLedTBRptVWTr.FSFControlRptTitle, #FSFCombineLedTBRptVWTr.FSFGeneralCode , #FSFCombineLedTBRptVWTr.FSFGeneralRptTitle, 
		#FSFCombineLedTBRptVWTr.FSFSubSidiaryCode, #FSFCombineLedTBRptVWTr.FSFSubsidiaryRptTitle, #FSFCombineLedTBRptVWTr.FSFSubsubCode, #FSFCombineLedTBRptVWTr.FSFSubSubRptTitle
	Into #COAAndFSFCombineQuery
	
	From  #COACombineLedTBRptVWTr  INNER JOIN
    #FSFCombineLedTBRptVWTr ON 
    #COACombineLedTBRptVWTr.SysFSFGLCode=#FSFCombineLedTBRptVWTr.SysFSFGLCode
     
	--From  #FSFCombineLedTBRptVWTr  LEFT OUTER JOIN
    --#COACombineLedTBRptVWTr ON #FSFCombineLedTBRptVWTr.SysFSFGLCode= #COACombineLedTBRptVWTr.SysFSFGLCode
		
	
	
	SELECT     NatureCode as SysNatureCode, NatureCode, Nature, Nature AS NatureRptTitle INTO #NatureTABTr
	FROM         dbo.TransactionNatures 
	WHERE ',' + @VoucherNatureCode + ',' LIKE '%,' + CAST( NatureCode as varchar) + ',%' OR @VoucherNatureCode = ''
	
	CREATE INDEX #IX_NatureTABTr ON #NatureTABTr ( NatureCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
	SELECT     #BranchTABTr.BranchCode, #BranchTABTr.BranchRptTitle, #DivisionTABTr.DivisionCode, #DivisionTABTr.DivisionRptTitle, 
	      dbo.VoucherDetails.GLCode, 
	      SUM( dbo.VoucherDetails.Debit ) AS DebitBalance , SUM (dbo.VoucherDetails.Credit ) as CreditBalance 
	INTO #ConsTrans
	FROM 	   dbo.VoucherDetails INNER JOIN
	      #NatureTABTr ON dbo.VoucherDetails.VoucherNature = #NatureTABTr.SysNatureCode INNER JOIN
	      #BranchTABTr ON dbo.VoucherDetails.BranchCode = #BranchTABTr.SysBranchCode INNER JOIN
	      #DivisionTABTr ON dbo.VoucherDetails.DivisionCode = #DivisionTABTr.SysDivisionCode INNER JOIN
	      #COAAndFSFCombineQuery ON dbo.VoucherDetails.GLCode = #COAAndFSFCombineQuery.SysGLCode LEFT OUTER JOIN
	      dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
	      dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
	      dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo
	 WHERE     (dbo.Vouchers.VoucherDate BETWEEN  @FromDate AND @ToDate ) AND 
		      (dbo.Vouchers.Posted = @Posted OR @PostedED = 0 ) 
	GROUP BY #BranchTABTr.BranchCode, #BranchTABTr.BranchRptTitle, #DivisionTABTr.DivisionCode, #DivisionTABTr.DivisionRptTitle, 
		              dbo.VoucherDetails.GLCode
	
	CREATE INDEX #IX_ConsTrans ON #ConsTrans ( GLCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	SELECT     #ConsTrans.BranchCode, #ConsTrans.BranchRptTitle, #ConsTrans.DivisionCode, #ConsTrans.DivisionRptTitle, 
	                      #COAAndFSFCombineQuery.GLCode, #COAAndFSFCombineQuery.GLRptTitle, 
	                      #COAAndFSFCombineQuery.ControlCode, #COAAndFSFCombineQuery.ControlRptTitle, 
	                      #COAAndFSFCombineQuery.GeneralCode, #COAAndFSFCombineQuery.GeneralRptTitle, 
	                      #COAAndFSFCombineQuery.SubSidiaryCode, #COAAndFSFCombineQuery.SubsidiaryRptTitle, 
	                      #COAAndFSFCombineQuery.SubsubCode, #COAAndFSFCombineQuery.SubSubRptTitle ,
	                      
	                      #COAAndFSFCombineQuery.FSFGLCode, #COAAndFSFCombineQuery.FSFGLRptTitle, 
	                      #COAAndFSFCombineQuery.FSFControlCode, #COAAndFSFCombineQuery.FSFControlRptTitle, 
	                      #COAAndFSFCombineQuery.FSFGeneralCode, #COAAndFSFCombineQuery.FSFGeneralRptTitle, 
	                      #COAAndFSFCombineQuery.FSFSubSidiaryCode, #COAAndFSFCombineQuery.FSFSubsidiaryRptTitle, 
	                      #COAAndFSFCombineQuery.FSFSubsubCode, #COAAndFSFCombineQuery.FSFSubSubRptTitle ,0 as OpeningBalance ,
	                      #ConsTrans.DebitBalance, #ConsTrans.CreditBalance
						  
						  INTO TempTransDetailTrialFSF
	FROM         #ConsTrans INNER JOIN
	                     #COAAndFSFCombineQuery ON  #ConsTrans.GLCode = #COAAndFSFCombineQuery.SysGLCode
	END
ELSE IF @nType  = 3		--  GET COA Opening FROM TempTAB
	BEGIN
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempCOAOpening' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		SELECT * FROM TempCOAOpening
		DROP TABLE  TempCOAOpening
		END
	ELSE
		BEGIN
			SELECT     '' AS Error
			WHERE 0 = 1
		END
	END
ELSE IF @nType  = 112		--  GET Trial Balance Consolidate , Subsidiary Wise
	BEGIN
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempTransDetailTrialFSF' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		
		BEGIN
		
		SELECT     '' AS BranchCode, '' AS BranchRptTitle, '' AS DivisionCode, '' AS DivisionRptTitle, '' as GLCode,'' as  GLRptTitle, ControlCode, ControlRptTitle, 
		                      GeneralCode, GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle, FSFGLCode, FSFGLRptTitle, FSFControlCode,
		                      FSFControlRptTitle, FSFGeneralCode, FSFGeneralRptTitle, FSFSubSidiaryCode, FSFSubsidiaryRptTitle,FSFSubsubCode, FSFSubSubRptTitle,
		                      SUM(OpeningBalance) AS OpBalance, SUM(DebitBalance) AS DbBalance, SUM(CreditBalance) AS CrBalance
		FROM         (SELECT     BranchCode, BranchRptTitle, DivisionCode, DivisionRptTitle, GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, 
		                                              GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle,
		                                              
		                                               
	                      FSFGLCode, FSFGLRptTitle, 
	                      FSFControlCode, FSFControlRptTitle, 
	                      FSFGeneralCode, FSFGeneralRptTitle, 
	                      FSFSubSidiaryCode, FSFSubsidiaryRptTitle, 
	                      FSFSubsubCode, FSFSubSubRptTitle,	                                              
		                                              
		                                               OpeningBalance, 0 AS DebitBalance, 
		                                              0 AS CreditBalance
		                       FROM          dbo.TempCOAOpening
		                       UNION ALL
		                       SELECT     BranchCode, BranchRptTitle, DivisionCode, DivisionRptTitle, GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, 
		                                             GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle,
		                  FSFGLCode, FSFGLRptTitle, 
	                      FSFControlCode, FSFControlRptTitle, 
	                      FSFGeneralCode, FSFGeneralRptTitle, 
	                      FSFSubSidiaryCode, FSFSubsidiaryRptTitle, 
	                      FSFSubsubCode, FSFSubSubRptTitle,
		                                             
		                                              OpeningBalance, DebitBalance, CreditBalance
		                       FROM         dbo.TempTransDetailTrialFSF) Balances
		GROUP BY ControlCode, ControlRptTitle, GeneralCode, GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle,FSFGLCode, FSFGLRptTitle, 
	                      FSFControlCode, FSFControlRptTitle, 
	                      FSFGeneralCode, FSFGeneralRptTitle, 
	                      FSFSubSidiaryCode, FSFSubsidiaryRptTitle, 
	                      FSFSubsubCode, FSFSubSubRptTitle
		HAVING ( ABS( SUM(OpeningBalance) ) + 
			     ABS( SUM(DebitBalance) ) + ABS( SUM(CreditBalance) ) <> 0 AND @ReportSD = 'DET' ) 
						OR
				 (  SUM(OpeningBalance) + SUM(DebitBalance) - SUM(CreditBalance)  <> 0 AND @ReportSD = 'SUM' ) 
		END
	ELSE
		BEGIN
			SELECT     '' AS Error
			WHERE 0 = 1
		END
	END
--MAK
--For new report "Notes To Financial Statements "
ELSE IF @nType  = 113		--  GET Trial Balance Branch , Subsidiary Wise
	BEGIN
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempTransDetailTrialFSF' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		SELECT     BranchCode, BranchRptTitle, '' AS DivisionCode, '' AS DivisionRptTitle, '' as GLCode,'' as  GLRptTitle, ControlCode, ControlRptTitle, 
		                      GeneralCode, GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle, 
		                      SUM(OpeningBalance) AS OpBalance, SUM(DebitBalance) AS DbBalance, SUM(CreditBalance) AS CrBalance
, FSFGLCode, FSFGLRptTitle, FSFControlCode,
		                      FSFControlRptTitle, FSFGeneralCode, FSFGeneralRptTitle, FSFSubSidiaryCode, FSFSubsidiaryRptTitle,FSFSubsubCode, FSFSubSubRptTitle
		FROM         (SELECT     BranchCode, BranchRptTitle, DivisionCode, DivisionRptTitle, GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, 
		                                              GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle, OpeningBalance, 0 AS DebitBalance, 
		                                              0 AS CreditBalance
,	                      FSFGLCode, FSFGLRptTitle, 
	                      FSFControlCode, FSFControlRptTitle, 
	                      FSFGeneralCode, FSFGeneralRptTitle, 
	                      FSFSubSidiaryCode, FSFSubsidiaryRptTitle, 
	                      FSFSubsubCode, FSFSubSubRptTitle	                                              
		                       FROM          dbo.TempCOAOpening
		                       UNION ALL
		                       SELECT     BranchCode, BranchRptTitle, DivisionCode, DivisionRptTitle, GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, 
		                                             GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle, OpeningBalance, DebitBalance, CreditBalance
,	                      FSFGLCode, FSFGLRptTitle, 
	                      FSFControlCode, FSFControlRptTitle, 
	                      FSFGeneralCode, FSFGeneralRptTitle, 
	                      FSFSubSidiaryCode, FSFSubsidiaryRptTitle, 
	                      FSFSubsubCode, FSFSubSubRptTitle	                                              
		                       FROM         dbo.TempTransDetailTrialFSF) Balances
		GROUP BY BranchCode, BranchRptTitle, ControlCode, ControlRptTitle, GeneralCode, GeneralRptTitle, SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle
			,FSFGLCode, FSFGLRptTitle, 
			FSFControlCode, FSFControlRptTitle, 
			FSFGeneralCode, FSFGeneralRptTitle, 
			FSFSubSidiaryCode, FSFSubsidiaryRptTitle, 
			FSFSubsubCode, FSFSubSubRptTitle
		HAVING ( ABS( SUM(OpeningBalance) ) + 
			     ABS( SUM(DebitBalance) ) + ABS( SUM(CreditBalance) ) <> 0 AND @ReportSD = 'DET' ) 
						OR
				 (  SUM(OpeningBalance) + SUM(DebitBalance) - SUM(CreditBalance)  <> 0 AND @ReportSD = 'SUM' ) 
		END
	ELSE
		BEGIN
			SELECT     '' AS Error
			WHERE 0 = 1
		END
	END

GO
