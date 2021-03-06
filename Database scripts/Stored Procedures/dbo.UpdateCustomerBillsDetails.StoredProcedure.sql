USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomerBillsDetails]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCustomerBillsDetails]

@BillNo char(10) = ''  ,
@BranchCode varchar(10),
@Branch varchar(10),
@TokenNo varchar(10),
@DestinationPoint varchar(10),
@StationPoint varchar(10),
@InvoiceNo varchar(10),
@InvoiceDate Datetime='',
@Vehicle varchar(10)='',
@Product varchar(10)='',
@Amount decimal(18,5)=0.00,
@Shortage decimal(18,5)=0.00,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO CustomerBillDetails(BillNo,BranchCode, InvoiceNo, Amount,Shortage) 
					VALUES  ( @BillNo, @BranchCode, @InvoiceNo, @Amount, @Shortage) 
		UPDATE Invoices 
			SET
			 IsBilled=1 
				WHERE TransactionNo=@InvoiceNo
				AND BranchCode=@BranchCode
	     END

GO
