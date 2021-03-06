USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectPosting]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[SelectPosting]
@PostingDate  Datetime = '01 Feb 2006' ,
@Debitors as varchar(12)='',
@Creditors as varchar(12)='',
@nType int = 0

AS

DECLARE @DuplicateInvoices	as varchar(50)
DECLARE @EmptyInvoiceNo 	as varchar(50)
DECLARE @PaymentWithoutInvoiceNo	as varchar(50)
DECLARE @PaymentExced	as varchar(50)

SET @PaymentWithoutInvoiceNo = 'Payment Invoice No. doesn''t exist'
SET @EmptyInvoiceNo = 'Empty Invoice No.' 
SET @DuplicateInvoices = 'Duplication of Invoice No.'	
SET @PaymentExced = 'Payment excess from Invoice'  



--SELECT @Debitors = nValue from SetupProfileTAB WHERE FieldName = 'Debitors'
--SELECT @Creditors = nValue from SetupProfileTAB WHERE FieldName = 'Creditors'


IF @nType = 1
	BEGIN
		SELECT     MAX(VoucherDate) AS ClosingDate
		FROM         dbo.Vouchers
		WHERE  Posted = 1
	END
ELSE IF @nType = 2
	BEGIN

-- ######################## START #COACombinePTAB
SELECT     GLCode as SysGLCode, GLCode, GLDescription,  GLDescription as ReportTitle 
INTO 	#COACombinePTAB
FROM       GL_GetCOACombineTransactionVW
WHERE     (GLCode LIKE @Debitors + '%') OR (GLCode LIKE @Creditors + '%')
-- ######################## END

CREATE INDEX #IX_SysCOACombinePTAB ON #COACombinePTAB ( SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

CREATE INDEX #IX_UDCOACombinePTAB ON #COACombinePTAB ( GLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TEMP_PostingResult' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
	BEGIN
	DROP TABLE  TEMP_PostingResult
	END
-- ######################## START #ALL_InvoiceTAB
SELECT     dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.VoucherNature, dbo.VoucherDetails.VoucherNo, 
                      dbo.Vouchers.VoucherDate, dbo.VoucherDetails.Reference, ISNULL(dbo.Vouchers.CreditDays, 0) 
                      AS CreditDays, dbo.Vouchers.Posted, dbo.VoucherDetails.GLCode AS SysGLCode, dbo.VoucherDetails.Debit, 
                      dbo.VoucherDetails.Credit, #COACombinePTAB.GLCode, SUM(ISNULL(dbo.UsedTransactionsDetail.AmountUsed, 
                      0)) AS AmountUsed, dbo.Vouchers.RecordNo 
INTO TEMP_PostingResult
FROM         dbo.VoucherDetails LEFT OUTER JOIN
                      dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
                      dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
                      dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo LEFT OUTER JOIN
                      dbo.UsedTransactionsDetail ON dbo.VoucherDetails.BranchCode = dbo.UsedTransactionsDetail.BranchCode AND 
                      dbo.VoucherDetails.GLCode = dbo.UsedTransactionsDetail.GLCode AND 
                      dbo.VoucherDetails.Reference = dbo.UsedTransactionsDetail.BillNo LEFT OUTER JOIN
                      #COACombinePTAB ON dbo.VoucherDetails.GLCode = #COACombinePTAB.SysGLCode
GROUP BY dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.VoucherNature, dbo.VoucherDetails.VoucherNo, 
                      dbo.Vouchers.VoucherDate, dbo.VoucherDetails.Reference, dbo.Vouchers.CreditDays, 
                      dbo.Vouchers.Posted, dbo.VoucherDetails.GLCode, dbo.VoucherDetails.Debit, 
                      dbo.VoucherDetails.Credit, #COACombinePTAB.GLCode, dbo.Vouchers.RecordNo
HAVING   
	(	 --  DEBITORS    
	((dbo.VoucherDetails.Debit > 0)  AND (#COACombinePTAB.GLCode LIKE @Debitors  + '%') )
		--  CREDITORS   
	OR
	((dbo.VoucherDetails.Credit > 0) AND (#COACombinePTAB.GLCode LIKE @Creditors + '%') )
	) 	/*AND  
               ((dbo.VoucherDetails.Debit + dbo.VoucherDetails.Credit ) > SUM(ISNULL(dbo.UsedTransactionsDetail.AmountUsed, 0))) AND 
               ( dbo.Vouchers.VoucherDate <= @PostingDate )*/
-- ######################## END



-- ######################## START #UP_InvoicePaymentTAB
INSERT INTO TEMP_PostingResult
SELECT     dbo.Vouchers.BranchCode, dbo.Vouchers.VoucherNature, dbo.Vouchers.VoucherNo, 
              dbo.Vouchers.VoucherDate, dbo.VoucherDetails.Reference, ISNULL(dbo.Vouchers.CreditDays, 0) 
              AS CreditDays, dbo.Vouchers.Posted, dbo.VoucherDetails.GLCode AS SysGLCode, dbo.VoucherDetails.Debit, 
              dbo.VoucherDetails.Credit, #COACombinePTAB.GLCode, 0 AS AmountUsed, 
              dbo.Vouchers.RecordNo
FROM         dbo.VoucherDetails INNER JOIN
              dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
              dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
              dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo LEFT OUTER JOIN
              #COACombinePTAB ON dbo.VoucherDetails.GLCode = #COACombinePTAB.SysGLCode
WHERE 
	(	 --  DEBITORS    
	((dbo.VoucherDetails.Credit > 0)  AND (#COACombinePTAB.GLCode LIKE @Debitors  + '%') )
		--  CREDITORS   
	OR
	((dbo.VoucherDetails.Debit > 0) AND (#COACombinePTAB.GLCode LIKE @Creditors + '%') )
	) 	AND
            (dbo.Vouchers.VoucherDate <= @PostingDate ) AND (dbo.Vouchers.Posted = 0)
-- ######################## END

-- ######################## START #P_InvoicePaymentTAB
INSERT INTO TEMP_PostingResult
SELECT     dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.VoucherNature, dbo.VoucherDetails.VoucherNo, 
              dbo.Vouchers.VoucherDate, dbo.VoucherDetails.Reference, ISNULL(dbo.Vouchers.CreditDays, 0) 
              AS CreditDays, dbo.Vouchers.Posted, dbo.VoucherDetails.GLCode AS SysGLCode, 
              SUM(dbo.VoucherDetails.Debit) AS Debit, SUM(dbo.VoucherDetails.Credit) AS Credit, 
              #COACombinePTAB.GLCode, DetailTransactionUsed.AmountUsed AS AmountUsed, dbo.Vouchers.RecordNo 
FROM         dbo.VoucherDetails LEFT OUTER JOIN
              dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
              dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
              dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo LEFT OUTER JOIN
                  ( SELECT     BranchCode, RefVoucherNature, RefVoucherNo, GLCode, RefVoucherDate, RefBillNo, SUM(AmountUsed) AS AmountUsed
                    FROM          dbo.UsedTransactionsDetail
                    GROUP BY BranchCode, RefVoucherNature, RefVoucherNo, GLCode, RefVoucherDate, RefBillNo) DetailTransactionUsed ON 
              dbo.VoucherDetails.BranchCode = DetailTransactionUsed.BranchCode AND 
              dbo.VoucherDetails.VoucherNature = DetailTransactionUsed.RefVoucherNature AND 
              dbo.VoucherDetails.VoucherNo = DetailTransactionUsed.RefVoucherNo AND 
              dbo.VoucherDetails.GLCode = DetailTransactionUsed.GLCode AND 
              dbo.VoucherDetails.Reference = DetailTransactionUsed.RefBillNo LEFT OUTER JOIN
              #COACombinePTAB ON dbo.VoucherDetails.GLCode = #COACombinePTAB.SysGLCode
WHERE
	(	 --  DEBITORS    
	((dbo.VoucherDetails.Credit > 0)  AND (#COACombinePTAB.GLCode LIKE @Debitors  + '%') )
		--  CREDITORS   
	OR
	((dbo.VoucherDetails.Debit > 0) AND (#COACombinePTAB.GLCode LIKE @Creditors + '%') )
	) 	AND      (dbo.Vouchers.Posted = 1 ) 
GROUP BY dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.VoucherNature, dbo.VoucherDetails.VoucherNo, 
              dbo.Vouchers.VoucherDate, dbo.VoucherDetails.Reference, ISNULL(dbo.Vouchers.CreditDays, 0), 
              dbo.Vouchers.Posted, dbo.VoucherDetails.GLCode, #COACombinePTAB.GLCode, 
              DetailTransactionUsed.AmountUsed, dbo.Vouchers.RecordNo
HAVING  ( SUM(dbo.VoucherDetails.Debit) + SUM(dbo.VoucherDetails.Credit) > DetailTransactionUsed.AmountUsed )

-- ######################## END

	END

ELSE IF @nType = 3 	-- GET FOR POSTING
	BEGIN

	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TEMP_PostingResult' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		SELECT * FROM TEMP_PostingResult
		ORDER BY BranchCode, GLCode, VoucherDate 
		DROP TABLE  TEMP_PostingResult
		END
	ELSE
		BEGIN
			SELECT      0 AS SysBranchCode, '' AS BranchCode, '' AS Branch, 
				'' AS SysNatureCode, '' AS NatureCode, '' AS Nature, 0 AS DisplayNode, 
				0 AS IsPaymentVoucher, '' AS VoucherNo, '01 Jan 2004' AS VoucherDate, 
				'' AS Reference, 0 AS CrditDays, 0 AS SysGLCode, '' AS GLCode, '' AS GLDescription, 
				'' AS InvoiceAmount, 0 AS PaymentAmount  
			WHERE 0 = 1
		END
	END

ELSE IF @nType = 4 	-- GET AUDIT FOR ALL   -- 	
	BEGIN

	DECLARE @AuditResult TABLE
	   (
		BranchCode  char(3) , 
		VoucherNature  char(10) , 
		VoucherNo  varchar(10),  
		VoucherDate  datetime , 
		Reference  varchar(50), 
		CrditDays  int,
		SysGLCode char (14),
		InvoiceAmount Decimal(20,5),
	 	PaymentAmount Decimal(20,5),
		ErrorDesc varchar(50)
	   )		

/*
CREATE INDEX #IX_AuditResultBranch ON @AuditResult ( BranchCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

CREATE INDEX #IX_AuditResultGLCode ON @AuditResult ( SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

CREATE INDEX #IX_AuditResultNature ON @AuditResult ( VoucherNature )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]
*/

-- ######################## START #COACombineTAB
SELECT     GLCode as SysGLCode, GLCode, GLDescription, GLDescription as ReportTitle INTO #COACombineTAB
FROM       dbo.GL_GetCOACombineTransactionVW
WHERE     (GLCode LIKE @Debitors + '%') OR (GLCode LIKE @Creditors + '%')
-- ######################## END

CREATE INDEX #IX_#SysCOACombineTAB ON #COACombineTAB ( SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

CREATE INDEX #IX_UDCOACombineTAB ON #COACombineTAB ( GLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

-- ######################## START #ALL_InvoiceTAB
SELECT     dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.VoucherNature, dbo.VoucherDetails.VoucherNo, 
              dbo.Vouchers.VoucherDate, dbo.VoucherDetails.Reference, ISNULL(dbo.Vouchers.CreditDays, 0) 
              AS CreditDays, dbo.VoucherDetails.GLCode AS SysGLCode, dbo.VoucherDetails.Debit + 
              dbo.VoucherDetails.Credit AS InvoiceAmount 
INTO 	#ALL_InvoiceTAB
FROM         dbo.VoucherDetails INNER JOIN
              dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
              dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
              dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo LEFT OUTER JOIN
              #COACombineTAB ON dbo.VoucherDetails.GLCode = #COACombineTAB.SysGLCode 
WHERE 
	(	 --  DEBITORS    
	((dbo.VoucherDetails.Debit > 0)  AND (#COACombineTAB.GLCode LIKE @Debitors  + '%') )
		--  CREDITORS   
	OR
	((dbo.VoucherDetails.Credit > 0) AND (#COACombineTAB.GLCode LIKE @Creditors + '%') )
	)	AND 	(dbo.Vouchers.VoucherDate <= @PostingDate ) 

CREATE INDEX #IX_ALL_InvoiceTAB ON #ALL_InvoiceTAB ( BranchCode,  Reference, SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

-- ######################## END


-- ######################## START #UP_InvoicePaymentTAB
SELECT     dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.VoucherNature, dbo.VoucherDetails.VoucherNo, 
	dbo.Vouchers.VoucherDate, dbo.VoucherDetails.Reference, dbo.VoucherDetails.GLCode AS SysGLCode, 
	dbo.VoucherDetails.Debit + dbo.VoucherDetails.Credit AS PaymentAmount 
INTO 	#UP_InvoicePaymentTAB
FROM         dbo.VoucherDetails INNER JOIN
              dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
              dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
              dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo LEFT OUTER JOIN
              #COACombineTAB ON dbo.VoucherDetails.GLCode = #COACombineTAB.SysGLCode 
WHERE 
	(	 --  DEBITORS    
	((dbo.VoucherDetails.Credit > 0)  AND (#COACombineTAB.GLCode LIKE @Debitors  + '%') )
		--  CREDITORS   
	OR
	((dbo.VoucherDetails.Debit > 0) AND (#COACombineTAB.GLCode LIKE @Creditors + '%') )
	)	AND 	(dbo.Vouchers.VoucherDate <= @PostingDate ) 
		AND 	(dbo.Vouchers.Posted = 0 ) 

CREATE INDEX #IX_UP_InvoicePaymentTAB ON #UP_InvoicePaymentTAB ( BranchCode,  Reference, SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]
-- ######################## END


-- ######################## START #Duplicate_InvoiceNoTAB
SELECT BranchCode, Reference, SysGLCode 
INTO 	#Duplicate_InvoiceNoTAB
FROM #ALL_InvoiceTAB
GROUP BY BranchCode, SysGLCode, Reference 
HAVING Count( SysGLCode ) > 1

CREATE INDEX #IX_Duplicate_InvoiceNoTAB ON #Duplicate_InvoiceNoTAB ( BranchCode,  Reference, SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]

-- ######################## END

-- ######################## START #Tot_InvoicePaymentTAB
SELECT     BranchCode, Reference, SysGLCode, SUM(PaymentAmount) AS PaymentAmount 
INTO 	#Tot_InvoicePaymentTAB
FROM (	SELECT     BranchCode, Reference, SysGLCode, SUM(PaymentAmount) AS PaymentAmount
	FROM         #UP_InvoicePaymentTAB
	GROUP BY BranchCode, Reference, SysGLCode
	UNION ALL
	SELECT     BranchCode, BillNo, GLCode, SUM(AmountUsed) AS PaymentAmount
	FROM         dbo.UsedTransactionsDetail
	GROUP BY BranchCode, BillNo, GLCode ) TotPayments
GROUP BY BranchCode, Reference, SysGLCode

CREATE INDEX #IX_Tot_InvoicePaymentTAB ON #Tot_InvoicePaymentTAB ( BranchCode,  Reference, SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]
-- ######################## END

-- ######################## START #AExcess_InvoiceNoTAB
SELECT     #ALL_InvoiceTAB.BranchCode, #ALL_InvoiceTAB.Reference, #ALL_InvoiceTAB.SysGLCode, #ALL_InvoiceTAB.InvoiceAmount 
INTO 	#AExcess_InvoiceNoTAB
FROM    #ALL_InvoiceTAB INNER JOIN
	#Tot_InvoicePaymentTAB ON #ALL_InvoiceTAB.BranchCode = #Tot_InvoicePaymentTAB.BranchCode AND 
	#ALL_InvoiceTAB.Reference = #Tot_InvoicePaymentTAB.Reference AND 
	#ALL_InvoiceTAB.SysGLCode = #Tot_InvoicePaymentTAB.SysGLCode AND 
	#ALL_InvoiceTAB.InvoiceAmount < #Tot_InvoicePaymentTAB.PaymentAmount

CREATE INDEX #IX_AExcess_InvoiceNoTAB ON #AExcess_InvoiceNoTAB ( BranchCode,  Reference, SysGLCode )
WITH   SORT_IN_TEMPDB	
ON [PRIMARY]
-- ######################## END

-- ######################## START 
-- ######################## DUPLICATE INVOICE
INSERT INTO @AuditResult(BranchCode, VoucherNature, VoucherNo, VoucherDate, Reference, CrditDays, SysGLCode,	InvoiceAmount, PaymentAmount, ErrorDesc) 
	SELECT  #ALL_InvoiceTAB.BranchCode, #ALL_InvoiceTAB.VoucherNature, 
		#ALL_InvoiceTAB.VoucherNo, #ALL_InvoiceTAB.VoucherDate, #ALL_InvoiceTAB.Reference, 
		#ALL_InvoiceTAB.CreditDays, #ALL_InvoiceTAB.SysGLCode, #ALL_InvoiceTAB.InvoiceAmount, 
		0 AS PaymentAmount, @DuplicateInvoices as ErrorDesc 
	FROM #ALL_InvoiceTAB INNER JOIN #Duplicate_InvoiceNoTAB ON
		#ALL_InvoiceTAB.BranchCode = #Duplicate_InvoiceNoTAB.BranchCode AND
		#ALL_InvoiceTAB.Reference = #Duplicate_InvoiceNoTAB.Reference AND
		#ALL_InvoiceTAB.SysGLCode = #Duplicate_InvoiceNoTAB.SysGLCode
-- ######################## DUPLICATE INVOICE
-- ######################## END 

-- ######################## START 
-- ######################## EMPTY INVOICE NO
INSERT INTO @AuditResult(BranchCode, VoucherNature, VoucherNo, VoucherDate, Reference, CrditDays, SysGLCode,	InvoiceAmount, PaymentAmount, ErrorDesc) 
	SELECT  #ALL_InvoiceTAB.BranchCode, #ALL_InvoiceTAB.VoucherNature, 
		#ALL_InvoiceTAB.VoucherNo, #ALL_InvoiceTAB.VoucherDate, #ALL_InvoiceTAB.Reference, 
		#ALL_InvoiceTAB.CreditDays, #ALL_InvoiceTAB.SysGLCode, #ALL_InvoiceTAB.InvoiceAmount, 
		0 AS PaymentAmount, @EmptyInvoiceNo  as ErrorDesc 
	FROM #ALL_InvoiceTAB 
	WHERE #ALL_InvoiceTAB.Reference = ''
-- ######################## EMPTY INVOICE NO
-- ######################## END 


-- ######################## START 
-- ######################## PAYMENT INVOICE NO MISMATCH
INSERT INTO @AuditResult(BranchCode, VoucherNature, VoucherNo, VoucherDate, Reference, CrditDays, SysGLCode,	InvoiceAmount, PaymentAmount, ErrorDesc) 
	SELECT     #UP_InvoicePaymentTAB.BranchCode, #UP_InvoicePaymentTAB.VoucherNature, #UP_InvoicePaymentTAB.VoucherNo, #UP_InvoicePaymentTAB.VoucherDate, 
		#UP_InvoicePaymentTAB.Reference, #ALL_InvoiceTAB.CreditDays, #UP_InvoicePaymentTAB.SysGLCode, 0 AS InvoiceAmount, #UP_InvoicePaymentTAB.PaymentAmount,
		@PaymentWithoutInvoiceNo as ErrorDesc 		
	FROM         #ALL_InvoiceTAB RIGHT OUTER JOIN
	                      #UP_InvoicePaymentTAB ON #ALL_InvoiceTAB.SysGLCode = #UP_InvoicePaymentTAB.SysGLCode AND 
	                      #ALL_InvoiceTAB.BranchCode = #UP_InvoicePaymentTAB.BranchCode AND 
	                      #ALL_InvoiceTAB.Reference = #UP_InvoicePaymentTAB.Reference
	WHERE     (#ALL_InvoiceTAB.InvoiceAmount IS NULL) AND (#UP_InvoicePaymentTAB.Reference <> '')
-- ######################## PAYMENT INVOICE NO MISMATCH
-- ######################## END


-- ######################## START 
-- ######################## PAYMENT EXCESS FROM INVOICE
INSERT INTO @AuditResult(BranchCode, VoucherNature, VoucherNo, VoucherDate, Reference, CrditDays, SysGLCode,	InvoiceAmount, PaymentAmount, ErrorDesc) 
	SELECT     #UP_InvoicePaymentTAB.BranchCode, #UP_InvoicePaymentTAB.VoucherNature, #UP_InvoicePaymentTAB.VoucherNo, #UP_InvoicePaymentTAB.VoucherDate, 
		#UP_InvoicePaymentTAB.Reference, 0 as CreditDays, #UP_InvoicePaymentTAB.SysGLCode, #AExcess_InvoiceNoTAB.InvoiceAmount AS InvoiceAmount, #UP_InvoicePaymentTAB.PaymentAmount,
		@PaymentExced as ErrorDesc 		
	FROM  #AExcess_InvoiceNoTAB INNER JOIN
		#UP_InvoicePaymentTAB ON #AExcess_InvoiceNoTAB.SysGLCode = #UP_InvoicePaymentTAB.SysGLCode AND 
		#AExcess_InvoiceNoTAB.Reference = #UP_InvoicePaymentTAB.Reference AND
		#AExcess_InvoiceNoTAB.BranchCode = #UP_InvoicePaymentTAB.BranchCode
	WHERE     (#UP_InvoicePaymentTAB.Reference <> '')
-- ######################## PAYMENT EXCESS FROM INVOICE
-- ######################## END

-- ######################## START AUDIT RESULT

IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TEMP_PostingResult' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
	BEGIN
	DROP TABLE  TEMP_PostingResult
	END

SELECT     AuditResult.ErrorDesc , AuditResult.BranchCode AS SysBranchCode, dbo.Branches.BranchCode, dbo.Branches.BranchDescription as Branch, 
      AuditResult.VoucherNature AS SysNatureCode, dbo.TransactionNatures.NatureCode, dbo.TransactionNatures.Nature, 
      dbo.TransactionNatures.IsPaymentVoucher, AuditResult.VoucherNo, AuditResult.VoucherDate, AuditResult.Reference, 
      AuditResult.CrditDays, AuditResult.SysGLCode, #COACombineTAB.GLCode, 
      #COACombineTAB.GLDescription, AuditResult.InvoiceAmount, AuditResult.PaymentAmount  
INTO TEMP_PostingResult
FROM         @AuditResult AuditResult LEFT OUTER JOIN
      #COACombineTAB ON AuditResult.SysGLCode = #COACombineTAB.SysGLCode LEFT OUTER JOIN
      dbo.TransactionNatures ON AuditResult.VoucherNature = dbo.TransactionNatures.NatureCode LEFT OUTER JOIN
      dbo.Branches ON AuditResult.BranchCode = dbo.Branches.BranchCode 
-- ######################## END AUDIT RESULT


/*
-- TEMP CODE
DROP TABLE #COACombineTAB
DROP TABLE #ALL_InvoiceTAB
DROP TABLE #UP_InvoicePaymentTAB
DROP TABLE #Tot_InvoicePaymentTAB
DROP TABLE #Duplicate_InvoiceNoTAB
DROP TABLE #AExcess_InvoiceNoTAB
*/

	END

ELSE IF @nType  = 5
	BEGIN

	IF EXISTS (SELECT * FROM sysobjects WHERE ID = OBJECT_ID( N'TEMP_PostingResult' ) and OBJECTPROPERTY( ID, N'IsTable') = 1)
		BEGIN
		SELECT * FROM TEMP_PostingResult
		DROP TABLE  TEMP_PostingResult
		END
	ELSE
		BEGIN
			SELECT     '' AS ErrorDesc , 0 AS SysBranchCode, '' AS BranchCode, '' AS Branch, 
				'' AS SysNatureCode, '' AS NatureCode, '' AS Nature, 0 AS DisplayNode, 
				0 AS IsPaymentVoucher, '' AS VoucherNo, '01 Jan 2004' AS VoucherDate, 
				'' AS Reference, 0 AS CrditDays, 0 AS SysGLCode, '' AS GLCode, '' AS GLDescription, 
				'' AS InvoiceAmount, 0 AS PaymentAmount  
			WHERE 0 = 1
		END
	END

ELSE IF @nType  = 6 		-- OPENING BALANCE
	BEGIN
	SELECT     dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.DivisionCode as Division, dbo.VoucherDetails.GLCode, 
	                      SUM(dbo.VoucherDetails.Debit) AS DebitSum, SUM(dbo.VoucherDetails.Credit) AS CreditSum
	FROM         dbo.VoucherDetails INNER JOIN
	                      dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
	                      dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
	                      dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo
	WHERE     (dbo.Vouchers.Posted = 1) AND (dbo.Vouchers.VoucherDate <= @PostingDate )
	GROUP BY dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.DivisionCode, dbo.VoucherDetails.GLCode
	END

GO
