USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateReceipts]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateReceipts]
 @TransactionNo varchar(15)=' '  ,
 @ReceiptDate  datetime=' '  ,
 @BranchCode varchar(5)=' '  ,
 @BranchName varchar(5)=' '  ,
 @BillNo varchar(15)=' '  ,
 @CustomerCode varchar(5)=' '  ,
 @CustomerName varchar(5)=' '  ,
 @Description  varchar(200) = '',
 @TaxRate  Decimal(20,5) = 0.00,
 @SaleTaxValue  Decimal(20,5) = 0.00,
 @AmountIncSaleTax  Decimal(20,5) = 0.00,
 @Amount  Decimal(20,5) = 0.00,
 @TotalAmount  Decimal(20,5) = 0.00,
 @Shortage  Decimal(20,5) = 0.00,
 @RecordNo as bigint=0,
@GUID as bigint=0,
@NewRecord as bigint=0
AS

DECLARE @ReceiptNo varchar(10)
DECLARE @DateValue varchar(4)



	IF @NewRecord = 1 
	     BEGIN
		SET @DateValue = dbo.DateToKey( @ReceiptDate ) 
		SELECT  TOP 1   @ReceiptNo = ReceiptNo FROM dbo.Receipts WHERE (BranchCode = @BranchCode ) AND ( LEFT( ReceiptNo , 4 )  = @DateValue ) ORDER BY ReceiptNo DESC
		SET @ReceiptNo = dbo.KeyValue( @DateValue , @ReceiptNo )
		SELECT @ReceiptNo as TransactionNo

			INSERT INTO Receipts ( BranchCode,  ReceiptNo,BillNo ,ReceiptDate,CustomerCode,  Description, TaxRate ,SaleTaxValue ,Amount,AmountIncSaleTax,Shortage, TotalAmount ) 
			VALUES       (@BranchCode, @TransactionNo, @BillNo ,@ReceiptDate,@CustomerCode,@Description, @TaxRate, @SaleTaxValue ,@Amount, @AmountIncSaleTax, @Shortage,  @TotalAmount) 
			

			UPDATE CustomerBills --UPDATE CUSTOMER BILL WILL RECEIPT
			SET
				IsReceipt=1 
			WHERE BillNo=@BillNo
				

	     END
	ELSE 

	     BEGIN
		SELECT @TransactionNo as TransactionNo	
		UPDATE Receipts
			SET	ReceiptNo =@TransactionNo ,
			ReceiptDate=@ReceiptDate,
			CustomerCode=@CustomerCode,
			Billno= @BillNo,
			AmountIncSaleTax=@AmountIncSaleTax  ,
			Amount=@Amount, 
			TaxRate=@TaxRate, 
			SaleTaxValue=@SaleTaxValue, 
			Shortage =@Shortage,
			TotalAmount=@TotalAmount
		--	Narration=@Narration
		WHERE  (ReceiptNo=@TransactionNo )
		AND	(BranchCode =@BranchCode)
		AND	(BranchCode =@BranchCode)
		AND	(BillNo =@BillNo)
 	     END

GO
