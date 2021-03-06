USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomerBills]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateCustomerBills]
@BillNo char(10) = ''  ,
@CustomerCode varchar(10),
@CustomerName varchar(10),
@BillDate Datetime=null,
@NewRecord as bigint
AS

DECLARE @TransactionNo varchar(10)
DECLARE @DateValue varchar(4)

	IF @NewRecord = 1 
	     BEGIN

		SET @DateValue = dbo.DateToKey( @BillDate ) 
		SELECT  TOP 1   @TransactionNo = BillNo FROM dbo.CustomerBills WHERE ( LEFT( BillNo , 4 )  = @DateValue ) ORDER BY BillNo DESC
		SET @TransactionNo = dbo.KeyValue( @DateValue , @TransactionNo )
		SELECT @TransactionNo as BillNo

		INSERT INTO CustomerBills(BillNo, CustomerCode,BillDate) 
		VALUES  ( @BillNo, @CustomerCode,@BillDate) 
	     END
	ELSE 
	     BEGIN
		SELECT @BillNo as BillNo
		UPDATE CustomerBills
		SET 
		BillNo= @BillNo,
		CustomerCode=@CustomerCode,
		BillDate=@BillDate
		WHERE  ( BillNo = @BillNo  )
 	     END

GO
