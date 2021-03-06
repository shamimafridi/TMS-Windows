USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomerBillsDetails]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteCustomerBillsDetails]

@Option as  varchar(3)='',
@BillNo as varchar(10) ='',
@InvoiceNo as varchar(10) ='',
@BranchCode as varchar(10) =''

AS

DECLARE @BCode as char(3)
DECLARE @InNo as char(12)

DECLARE Bill_Cursor CURSOR FOR
SELECT  InvoiceNo, BranchCode FROM CustomerBillDetails
	
OPEN Bill_Cursor
	
FETCH NEXT FROM Bill_Cursor
INTO @InNo, @BCode
WHILE @@FETCH_STATUS = 0
BEGIN
	UPDATE Invoices
		Set IsBilled=0
	WHERE TransactionNo=@InNo
	AND BranchCode=@BCode
   FETCH NEXT FROM Bill_Cursor
   INTO @InNo, @BCode
END
CLOSE Bill_Cursor
DEALLOCATE Bill_Cursor


	
	DELETE FROM CustomerBillDetails  
	WHERE 
	BillNo=@BillNo

GO
