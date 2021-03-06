USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectCashFlowStatementReports]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
--drop PROCEDURE [dbo].[SelectCashFlowStatementReports]
CREATE PROCEDURE [dbo].[SelectCashFlowStatementReports]   -- ntype 0 3 1 4
@FromBranchCode varchar(10)='',  
@ToBranchCode varchar(10)='' , 
@FromDivisionCode varchar(10)='',  
@ToDivisionCode varchar(10)='' , 
@GLCode varchar(1000)='',  
--@ToGLCode varchar(50)='', 
@FromDate DateTime= NULL ,  
@ToDate DateTime= NULL, 
@nType bigint =0 , 
@VoucherNatureCode   varchar(100) = '' ,
@ReportSD as varchar ( 10 ) = 'DET' ,
@Posted bit = 1,
@PostedED bit = 0
AS
IF @nType = 0 --OPENING 1
	BEGIN			
	DECLARE @DocDate   as datetime
	
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempCOAOpening' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
	BEGIN
		DROP TABLE  TempCOAOpening
	END
	
	-- SELECT Division with Filter
	SELECT     DivisionCode as SysDivisionCode, DivisionCode, Division, Division AS DivisionRptTitle 
	INTO 	#DivisionTAB
	FROM         dbo.Divisions
	WHERE	(dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode AND @ToDivisionCode)
	
	CREATE INDEX #IX_DivisionTAB ON #DivisionTAB ( SysDivisionCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]
	
	
--select * from #TemCashCOAWithDetailTrans
/*
SELECT     VoucherDetails.VoucherNature, VoucherDetails.VoucherNo, VoucherDetails.Debit AS Expr5, 
                      VoucherDetails.Credit AS Expr6
FROM         VoucherDetails INNER JOIN
                      TempcashAccnts ON VoucherDetails.VoucherNature = TempcashAccnts.VoucherNature AND 
                      VoucherDetails.VoucherNo = TempcashAccnts.VoucherNo
ORDER BY VoucherDetails.VoucherNo */
	-- SELECT Branch with Filter
	SELECT     BranchCode as SysBranchCode, BranchCode, BranchDescription, BranchDescription AS BranchRptTitle 
	INTO #BranchTAB
	FROM         dbo.Branches
	WHERE (dbo.Branches.BranchCode BETWEEN @FromBranchCode AND @ToBranchCode)
	
	CREATE INDEX #IX_BranchTAB ON #BranchTAB ( SysBranchCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]
	-- SELECT GLAccount with Filter
	SELECT     GLCode as SysGLCode , GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, GeneralRptTitle, 
		SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle 
	INTO 	#COACombineLedTBRptVW
	FROM          dbo.GL_GetCOACombineLedTBRptVW
	--( ',' + @SupplierTypeCode + ',' LIKE '%,' + CAST( SupplierTypeCode  as varchar) + ',%' OR @SupplierTypeCode = '' )
	WHERE ',' + @GLCode + ',' LIKE '%,' + CAST(  dbo.GL_GetCOACombineLedTBRptVW.GLCode  as varchar) + ',%' OR @GLCode = ''     
	  
	CREATE INDEX #IX_COACombineLedTBRptVW ON #COACombineLedTBRptVW ( SysGLCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	-- SELECT Last Closing Date For dbo.OpeningBalances Filter
	SELECT      dbo.OpeningBalances.BranchCode,  dbo.OpeningBalances.DivisionCode,  dbo.OpeningBalances.GLCode, 
	                      MAX( dbo.OpeningBalances.ClosingDate) AS ClosingDate 
	INTO #OpeningDate
	FROM          dbo.OpeningBalances INNER JOIN
	                      #BranchTAB ON  dbo.OpeningBalances.BranchCode = #BranchTAB.SysBranchCode INNER JOIN
	                      #COACombineLedTBRptVW ON  dbo.OpeningBalances.GLCode = #COACombineLedTBRptVW.SysGLCode INNER JOIN
	                      #DivisionTAB ON  dbo.OpeningBalances.DivisionCode = #DivisionTAB.SysDivisionCode
	WHERE     ( dbo.OpeningBalances.ClosingDate <= @ToDate )
	GROUP BY  dbo.OpeningBalances.BranchCode,  dbo.OpeningBalances.DivisionCode,  dbo.OpeningBalances.GLCode
	CREATE INDEX #IX_OpeningDate ON #OpeningDate ( BranchCode, DivisionCode, GLCode, ClosingDate )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
	-- SELECT OpeningBalance From dbo.OpeningBalances With ClosingDate Filter
	SELECT      dbo.OpeningBalances.ClosingDate,  dbo.OpeningBalances.BranchCode,  dbo.OpeningBalances.DivisionCode, 
	       dbo.OpeningBalances.GLCode,  dbo.OpeningBalances.DebitBalance -  dbo.OpeningBalances.CreditBalance AS OpeningBalance 
	INTO #OpeningTAB
	FROM          dbo.OpeningBalances INNER JOIN
	      #OpeningDate ON  dbo.OpeningBalances.BranchCode = #OpeningDate.BranchCode AND 
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
	SELECT     #TransDetail.BranchCode, #TransDetail.DivisionCode, #TransDetail.GLCode, #TransDetail.Debit ,
		      #TransDetail.Credit, #TransDetail.Debit 
		      - #TransDetail.Credit AS TransBalance 
	INTO #TransBalTAB
	FROM         #TransDetail LEFT OUTER JOIN
		      #OpeningDate ON #TransDetail.BranchCode = #OpeningDate.BranchCode AND 
		      #TransDetail.VoucherDate > #OpeningDate.ClosingDate AND 
		      #TransDetail.GLCode = #OpeningDate.GLCode AND #TransDetail.DivisionCode = #OpeningDate.DivisionCode
	--GROUP BY #TransDetail.BranchCode, #TransDetail.Division, #TransDetail.GLCode
	
	---   Final Opening Balance 
	SELECT     BranchCode, DivisionCode, GLCode, SUM(OpeningBalance) AS OpeningBalance INTO #TransTAB
	FROM         (SELECT     BranchCode, DivisionCode, GLCode, OpeningBalance
	                       FROM          #OpeningTAB
	                       UNION ALL
	                       SELECT     BranchCode, DivisionCode, GLCode, TransBalance
	                       FROM         #TransBalTAB) TransTAB
	GROUP BY BranchCode, DivisionCode, GLCode
	
	--- Final Opening Balance With Titles
	SELECT     #BranchTAB.BranchCode, #BranchTAB.BranchRptTitle, #DivisionTAB.DivisionCode, 
		      #DivisionTAB.DivisionRptTitle, #COACombineLedTBRptVW.GLCode, #COACombineLedTBRptVW.GLRptTitle, 
		      #COACombineLedTBRptVW.ControlCode, #COACombineLedTBRptVW.ControlRptTitle, 
		      #COACombineLedTBRptVW.GeneralCode, #COACombineLedTBRptVW.GeneralRptTitle, 
		      #COACombineLedTBRptVW.SubSidiaryCode, #COACombineLedTBRptVW.SubsidiaryRptTitle, 
		      #COACombineLedTBRptVW.SubsubCode, #COACombineLedTBRptVW.SubSubRptTitle, 
		      #TransTAB.OpeningBalance INTO TempCOAOpening
	FROM         #TransTAB INNER JOIN
		      #BranchTAB ON #TransTAB.BranchCode = #BranchTAB.SysBranchCode INNER JOIN
		      #DivisionTAB ON #TransTAB.DivisionCode = #DivisionTAB.SysDivisionCode INNER JOIN
		      #COACombineLedTBRptVW ON #TransTAB.GLCode = #COACombineLedTBRptVW.SysGLCode
	WHERE     #TransTAB.OpeningBalance <> 0
	END
ELSE IF @nType =1			--Account Ledger ALL Transaction 
	BEGIN
	
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempTransDetailCF' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		DROP TABLE  TempTransDetailCF
		END
	SELECT     DivisionCode as SysDivisionCode, DivisionCode, Division, Division AS DivisionRptTitle 
	INTO 	#DivisionTABT
	FROM         dbo.Divisions
	WHERE	(dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode AND @ToDivisionCode)
	
	CREATE INDEX [#IX_DivisionTABT ] ON #DivisionTABT ( SysDivisionCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]
	SELECT    BranchCode as  SysBranchCode, BranchCode, BranchDescription, BranchDescription AS BranchRptTitle INTO #BranchTABT
	FROM         dbo.Branches
	WHERE (dbo.Branches.BranchCode BETWEEN @FromBranchCode AND @ToBranchCode)
	
	CREATE INDEX #IX_BranchTABT ON #BranchTABT ( SysBranchCode )
	WITH   SORT_IN_TEMPDB
	ON [PRIMARY]	
	
	SELECT    GLCode as  SysGLCode, GLCode, GLRptTitle, ControlCode, ControlRptTitle, GeneralCode, GeneralRptTitle, '1' as  ApplyGrouping,
		SubSidiaryCode, SubsidiaryRptTitle, SubsubCode, SubSubRptTitle INTO #COACombineLedTBRptVWT
	FROM          dbo.GL_GetCOACombineLedTBRptVW
	
	
	--WHERE ',' + @GLCode + ',' LIKE '%,' + CAST(  GetCOACombineLedTBRptVW.GLCode  as varchar) + ',%' OR @GLCode = ''     
	
	CREATE INDEX #IX_COACombineLedTBRptVWT ON #COACombineLedTBRptVWT ( SysGLCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	
	SELECT    NatureCode as  SysNatureCode, NatureCode, Nature, Nature  AS NatureRptTitle INTO #NatureTABT
	FROM          dbo.TransactionNatures 
	WHERE ',' + @VoucherNatureCode + ',' LIKE '%,' + CAST( NatureCode as varchar) + ',%' OR @VoucherNatureCode = ''
	CREATE INDEX #IX_NatureTABT ON #NatureTABT ( NatureCode )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	SELECT     dbo.Vouchers.BranchCode, dbo.Vouchers.VoucherNature, dbo.Vouchers.VoucherNo, 
		dbo.Vouchers.VoucherDate, dbo.Vouchers.Description as Narration, dbo.Vouchers.RecordNo, dbo.Vouchers.OldRef ,
		dbo.Vouchers.Posted, dbo.Vouchers.Locked 
	INTO #TransMasterT
	FROM         dbo.Vouchers INNER JOIN
		#BranchTABT ON dbo.Vouchers.BranchCode = #BranchTABT.SysBranchCode
	WHERE     (dbo.Vouchers.VoucherDate BETWEEN @FromDate AND @ToDate ) AND 
		      (dbo.Vouchers.Posted = @Posted OR @PostedED = 0 ) 
	
	CREATE INDEX #IX_TransMasterT ON #TransMasterT ( BranchCode, VoucherNature, VoucherNo )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
-----Shamim
	SELECT     VoucherDetails.BranchCode, VoucherDetails.VoucherNature, VoucherDetails.VoucherNo
                      
INTO #TemCashCOAWithDetailTrans
FROM         VoucherDetails LEFT OUTER JOIN
                      #COACombineLedTBRptVWT ON VoucherDetails.GLCode = #COACombineLedTBRptVWT.SysGLCode
--WHERE     (#COACombineLedTBRptVWT.GLCode LIKE  '1501%')
 
 WHERE ',' + @GLCode  + ',' LIKE '%,' + CAST( #COACombineLedTBRptVWT.GLCode  as varchar) + ',%' 
 
 CREATE INDEX #IX_TemCashCOAWithDetailTrans ON #TemCashCOAWithDetailTrans( BranchCode, VoucherNature, VoucherNo )
	WITH   SORT_IN_TEMPDB	
	ON [PRIMARY]
	SELECT     #BranchTABT.BranchCode, #BranchTABT.BranchRptTitle, #DivisionTABT.DivisionCode, #DivisionTABT.DivisionRptTitle, 
		#COACombineLedTBRptVWT.GLCode, #COACombineLedTBRptVWT.GLRptTitle, #NatureTABT.NatureCode, 
		#NatureTABT.NatureRptTitle, #TransMasterT.VoucherDate, dbo.VoucherDetails.VoucherNo, #TransMasterT.OldRef , 
		dbo.VoucherDetails.Narration, #TransMasterT.Narration AS NarrationMain, #TransMasterT.RecordNo, 
		dbo.VoucherDetails.Reference, dbo.VoucherDetails.Debit, dbo.VoucherDetails.Credit, 
		#COACombineLedTBRptVWT.ControlCode, #COACombineLedTBRptVWT.ControlRptTitle, 
		#COACombineLedTBRptVWT.GeneralCode, #COACombineLedTBRptVWT.GeneralRptTitle, 
		#COACombineLedTBRptVWT.SubSidiaryCode, #COACombineLedTBRptVWT.SubsidiaryRptTitle, 
		#COACombineLedTBRptVWT.SubsubCode, #COACombineLedTBRptVWT.SubSubRptTitle, #COACombineLedTBRptVWT.ApplyGrouping, #TransMasterT.Posted, 
		#TransMasterT.Locked, dbo.VoucherDetails.RecordNo AS DetailRecordNo
	INTO TempTransDetailCF
	FROM         dbo.VoucherDetails INNER JOIN
		      #NatureTABT ON dbo.VoucherDetails.VoucherNature = #NatureTABT.SysNatureCode INNER JOIN
		      #BranchTABT ON dbo.VoucherDetails.BranchCode = #BranchTABT.SysBranchCode INNER JOIN
		      #DivisionTABT ON dbo.VoucherDetails.DivisionCode = #DivisionTABT.SysDivisionCode INNER JOIN
		      #COACombineLedTBRptVWT ON dbo.VoucherDetails.GLCode = #COACombineLedTBRptVWT.SysGLCode INNER JOIN
		      #TransMasterT ON dbo.VoucherDetails.BranchCode = #TransMasterT.BranchCode AND 
		      dbo.VoucherDetails.VoucherNature = #TransMasterT.VoucherNature AND 
		      dbo.VoucherDetails.VoucherNo = #TransMasterT.VoucherNo INNER JOIN
              #TemCashCOAWithDetailTrans ON VoucherDetails.VoucherNature = #TemCashCOAWithDetailTrans.VoucherNature AND 
              VoucherDetails.VoucherNo = #TemCashCOAWithDetailTrans.VoucherNo and VoucherDetails.BranchCode = #TemCashCOAWithDetailTrans.BranchCode
	--select * from TempTransDetail	
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
ELSE IF @nType  = 4		--  GET Transaction Detail
	BEGIN
	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TempTransDetailCF' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		SELECT * FROM TempTransDetailCF 
		ORDER BY BranchCode, GLCode, VoucherDate, RecordNo 
		--DROP TABLE  TempTransDetailCF
		END
   
	ELSE
		BEGIN
			SELECT     '' AS Error
			WHERE 0 = 1
		END
	END
	ELSE
		BEGIN
			SELECT     '' AS Error
			WHERE 0 = 1
		END

GO
