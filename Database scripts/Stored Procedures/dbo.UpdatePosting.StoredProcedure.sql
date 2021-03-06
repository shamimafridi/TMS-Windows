USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdatePosting]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
--drop PROCEDURE  UpdatePosting
CREATE PROCEDURE  [dbo].[UpdatePosting]

@BranchCode CHAR(3) = ''  , 
@DivisionCode CHAR(3) = ''  , 
@VoucherNature CHAR(3) = '' , 
@VoucherNo varchar(10) = ''  , 
@VoucherDate datetime = NULL , 
@GLCode bigint = 0 , 
@BillNo varchar(50) = '' , 
@RefVoucherNature char(3) = '' ,
@RefVoucherNo varchar(10) = '' ,
@RefVoucherDate datetime = NULL , 
@RefBillNo as varchar( 50 ) = '' , 
@AmountUsed as decimal( 20 , 5 ) = 0 ,

@DebitBalance  as decimal( 20 , 5 ) = 0 ,
@CreditBalance as decimal( 20 , 5 ) = 0 ,

@nType int = 0 ,
@PostingDate datetime = 0 ,


@ToDate datetime  = NULL ,
@FromDocNo varchar(10) = '' ,
@ToDocNo varchar(10) = '' ,
@TransactionType as varchar( 1000 ) = '0' ,
@GUID as bigint = 0
AS 

IF  @nType = 2		-- INSERTING TRANS USED VALUES
	BEGIN
	INSERT INTO UsedTransactionsDetail
                      	(BranchCode, VoucherNature, VoucherNo, VoucherDate, GLCode, BillNo, RefVoucherNature, 
		RefVoucherNo, RefVoucherDate, RefBillNo, AmountUsed)
	VALUES     (@BranchCode, @VoucherNature, @VoucherNo, @VoucherDate, @GLCode, @BillNo, @RefVoucherNature, 
		@RefVoucherNo, @RefVoucherDate, @RefBillNo, @AmountUsed )
	END
ELSE IF  @nType = 3		-- POSTING OF MASTER TRANS
	BEGIN
	UPDATE    Vouchers
	SET              Locked = 1, Posted = 1
	WHERE  Vouchers.VoucherDate <= @PostingDate  

	UPDATE    PaymentVouchers
	SET              Locked = 1, Posted = 1
	WHERE  PaymentVouchers.VoucherDate <= @PostingDate  

	UPDATE    Invoices
	SET              Locked = 1, Posted = 1
	WHERE  Invoices.TransactionDate <= @PostingDate

	UPDATE    Receipts
	SET              Locked = 1, Posted = 1
	WHERE  Receipts.ReceiptDate <= @PostingDate

	END
ELSE IF  @nType = 4		-- UNPOSTING OF MASTER TRANS
	BEGIN
	UPDATE    Vouchers
	SET              Posted = 0
	WHERE  Vouchers.VoucherDate >= @PostingDate  
	
	UPDATE    PaymentVouchers
	SET              Posted = 0
	WHERE  PaymentVouchers.VoucherDate >= @PostingDate  

	UPDATE    Invoices
	SET              Posted = 0
	WHERE  Invoices.TransactionDate >= @PostingDate 

	UPDATE    Receipts
	SET              Posted = 0
	WHERE  Receipts.ReceiptDate >= @PostingDate 

	END

ELSE IF @nType = 5		-- UPDATING OPENING BALANCE
	BEGIN
		IF EXISTS ( SELECT * FROM OpeningBalances WHERE BranchCode = @BranchCode AND GLCode = @GLCode AND DivisionCode = @DivisionCode AND MONTH( ClosingDate ) = MONTH ( @PostingDate ) AND YEAR ( ClosingDate ) = YEAR( @PostingDate ) )
			BEGIN
				UPDATE OpeningBalances
				SET    ClosingDate = @PostingDate  , DebitBalance = @DebitBalance, CreditBalance = @CreditBalance, GUID = @GUID
				WHERE BranchCode = @BranchCode AND GLCode = @GLCode AND DivisionCode = @DivisionCode AND MONTH( ClosingDate ) = MONTH ( @PostingDate ) AND YEAR ( ClosingDate ) = YEAR( @PostingDate )
			END
		ELSE
			BEGIN			
				INSERT INTO OpeningBalances
				                      (ClosingDate, BranchCode, DivisionCode, GLCode, DebitBalance, CreditBalance, GUID)
				VALUES     (@PostingDate, @BranchCode, @DivisionCode, @GLCode, @DebitBalance, @CreditBalance, @GUID)
			END
	END 
ELSE IF  @nType = 6		-- DELETING TRANS USED VALUES
	BEGIN
	DELETE FROM UsedTransactionsDetail
	WHERE  RefVoucherDate >= @PostingDate OR VoucherDate >= @PostingDate
	END
ELSE IF  @nType = 7		-- DELETING CLOSING BALANCE OF POST DATED
	BEGIN
	DELETE FROM OpeningBalances 
	WHERE  ClosingDate > @PostingDate 
	END
ELSE IF  @nType = 8		-- UNLOCKING OF MASTER TRANS
	BEGIN
	DECLARE @SQLStr as varchar(8000)
	
	SET @SQLStr = ' UPDATE   Vouchers
	SET            Locked = 0
	WHERE   ( BranchCode = ''' + CAST ( @BranchCode as  varchar(30) )  + ''' ) AND
		( VoucherNature IN ( ' + @TransactionType + ' ) ) AND
		( ( VoucherDate BETWEEN ''' + CAST ( @PostingDate as  varchar(40) )  + ''' AND ''' + CAST ( @ToDate as  varchar(40) ) + ''' ) AND
		( VoucherNo BETWEEN  ''' + @FromDocNo + ''' AND ''' +@ToDocNo + ''' ))'

	EXEC ( @SQLStr )
print @SqlStr

	SET @SQLStr = ' UPDATE   PaymentVouchers
	SET            Locked = 0
	WHERE   ( BranchCode = ''' + CAST ( @BranchCode as  varchar(30) )  + ''' ) AND
		( VoucherNature IN ( ' + @TransactionType + ' ) ) AND
		( ( VoucherDate BETWEEN ''' + CAST ( @PostingDate as  varchar(40) )  + ''' AND ''' + CAST ( @ToDate as  varchar(40) ) + ''' ) AND
		( VoucherNo BETWEEN  ''' + @FromDocNo + ''' AND ''' +@ToDocNo + ''' ))'

	EXEC ( @SQLStr )

	END

ELSE IF @nType = 9
	BEGIN
/*
	DELETE FROM  OpeningBalances  WHERE MONTH( ClosingDate ) = MONTH ( @PostingDate ) AND YEAR ( ClosingDate ) = YEAR( @PostingDate )

	INSERT INTO OpeningBalances  (ClosingDate, BranchCode, DivisionCode, GLCode, DebitBalance, CreditBalance, GUID)

	SELECT   @PostingDate as ClosingDate,  dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.Division, dbo.VoucherDetails.GLCode, 
	                  SUM(dbo.VoucherDetails.Debit) - SUM(dbo.VoucherDetails.Credit) AS DebitSum , 0 as CreditSum , 0 as GUID
	FROM         dbo.VoucherDetails INNER JOIN
	                      dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
	                      dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
	                      dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo
	WHERE     (dbo.Vouchers.Posted = 1) AND (dbo.Vouchers.VoucherDate <= @PostingDate )
	GROUP BY dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.Division, dbo.VoucherDetails.GLCode
	HAVING     SUM(dbo.VoucherDetails.Debit) - SUM(dbo.VoucherDetails.Credit) > 0
	
	UNION ALL
	
	SELECT   @PostingDate as ClosingDate,  dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.Division, dbo.VoucherDetails.GLCode, 
	                  0 AS DebitSum , SUM(dbo.VoucherDetails.Credit) - SUM(dbo.VoucherDetails.Debit) as CreditSum , 0 as GUID
	FROM         dbo.VoucherDetails INNER JOIN
	                      dbo.Vouchers ON dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode AND 
	                      dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
	                      dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo
	WHERE     (dbo.Vouchers.Posted = 1) AND (dbo.Vouchers.VoucherDate <= @PostingDate )
	GROUP BY dbo.VoucherDetails.BranchCode, dbo.VoucherDetails.Division, dbo.VoucherDetails.GLCode
	HAVING     SUM(dbo.VoucherDetails.Debit) - SUM(dbo.VoucherDetails.Credit) <= 0
*/
	DECLARE @DocDate     as datetime
	BEGIN TRANSACTION
	-- SELECT Last Closing Date For OpeningBalanceTAB Filter

	SELECT     dbo.OpeningBalances.BranchCode, dbo.OpeningBalances.DivisionCode, dbo.OpeningBalances.GLCode, 
	                      MAX(dbo.OpeningBalances.ClosingDate) AS ClosingDate INTO #OpeningDate
	FROM         dbo.OpeningBalances 
	WHERE     (dbo.OpeningBalances.ClosingDate <= @PostingDate )
	GROUP BY dbo.OpeningBalances.BranchCode, dbo.OpeningBalances.DivisionCode, dbo.OpeningBalances.GLCode
	
	-- SELECT OpeningBalance From OpeningBalanceTAB With ClosingDate Filter
	SELECT     dbo.OpeningBalances.ClosingDate, dbo.OpeningBalances.BranchCode, dbo.OpeningBalances.DivisionCode, 
	      dbo.OpeningBalances.GLCode, dbo.OpeningBalances.DebitBalance - dbo.OpeningBalances.CreditBalance AS OpeningBalance INTO #OpeningTAB
	FROM         dbo.OpeningBalances INNER JOIN
	      #OpeningDate ON dbo.OpeningBalances.BranchCode = #OpeningDate.BranchCode AND 
	      dbo.OpeningBalances.ClosingDate = #OpeningDate.ClosingDate AND 
	      dbo.OpeningBalances.DivisionCode = #OpeningDate.DivisionCode AND 
	      dbo.OpeningBalances.GLCode = #OpeningDate.GLCode
	
	-- SELECT Previous Closing Date For Master Transaction Filter
	SELECT @DocDate = ISNULL(MIN(#OpeningDate.ClosingDate) + 1,0) FROM #OpeningDate
	PRINT @DocDate
	
	-- Select Master Transaction For DetailTransaction Filter
	SELECT     dbo.Vouchers.BranchCode, dbo.Vouchers.VoucherNature, dbo.Vouchers.VoucherNo, 
		dbo.Vouchers.VoucherDate INTO #TransMaster
	FROM         dbo.Vouchers 
	WHERE  (dbo.Vouchers.Posted = 1) AND (dbo.Vouchers.VoucherDate BETWEEN @DocDate AND @PostingDate)
	
	-- SELECT Detail Transaction With Date
	SELECT     dbo.VoucherDetails.BranchCode, #TransMaster.VoucherDate, dbo.VoucherDetails.GLCode, 
		      dbo.VoucherDetails.DivisionCode, dbo.VoucherDetails.Debit, dbo.VoucherDetails.Credit INTO #TransDetail
	FROM         #TransMaster INNER JOIN
		      dbo.VoucherDetails ON #TransMaster.BranchCode = dbo.VoucherDetails.BranchCode AND 
		      #TransMaster.VoucherNature = dbo.VoucherDetails.VoucherNature AND 
		      #TransMaster.VoucherNo = dbo.VoucherDetails.VoucherNo 
	
	-- Select Transaction Balance
	SELECT     #TransDetail.BranchCode, #TransDetail.DivisionCode, #TransDetail.GLCode, SUM(#TransDetail.Debit) 
		      - SUM(#TransDetail.Credit) AS TransBalance INTO #TransBalTAB
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

	DELETE FROM  OpeningBalances  WHERE MONTH( ClosingDate ) = MONTH ( @PostingDate ) AND YEAR ( ClosingDate ) = YEAR( @PostingDate )

	INSERT INTO OpeningBalances  (ClosingDate, BranchCode, DivisionCode, GLCode, DebitBalance, CreditBalance, GUID)

	SELECT   @PostingDate as ClosingDate,  BranchCode, DivisionCode, GLCode, 
			OpeningBalance ,  0 as CreditBal , 0 as GUID
	FROM     #TransTAB
	WHERE 	OpeningBalance > 0

	UNION ALL
	
	SELECT   @PostingDate as ClosingDate,  BranchCode, DivisionCode, GLCode, 
			0 as DebitBal , ABS(OpeningBalance) as CreditBal, 0 as GUID
	FROM     #TransTAB
	WHERE 	OpeningBalance <= 0 
	COMMIT TRANSACTION
END

GO
