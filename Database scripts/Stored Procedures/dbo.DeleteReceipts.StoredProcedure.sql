USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteReceipts]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteReceipts]
    @Option AS VARCHAR(3) = '',
    @TransactionNo AS VARCHAR(12) = '',
    @BranchCode AS VARCHAR(3) = '',
    @BillNo AS VARCHAR(12) = ''
AS 
    BEGIN TRANSACTION

--DELETE FROM Receipts 
    UPDATE  Receipts
    SET     Amount = 0,
            AmountIncSaleTax = 0,
            Shortage = 0,
            Description = 'This Receipt has been Deleted',
            TaxRate = 0,
            TotalAmount = 0
    WHERE   ReceiptNo = @TransactionNo
            AND BranchCode = @BranchCode
            AND BillNo = @BillNo

    UPDATE  dbo.CustomerBills
    SET     IsReceipt = 0
    WHERE   BillNo = @BillNo
    COMMIT TRANSACTION

    IF @@error > 0 
        ROLLBACK TRANSACTION

GO
