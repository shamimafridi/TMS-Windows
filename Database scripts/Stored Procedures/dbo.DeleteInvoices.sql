USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteInvoices]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteInvoices]
    @Option AS VARCHAR(3) = '',
    @TransactionNo AS CHAR(10) = '',
    @BranchCode AS VARCHAR(3) = ''
AS 
    DECLARE @RefNo VARCHAR(10)
    DECLARE @AdjNo VARCHAR(10)
        
    BEGIN TRANSACTION

        
    UPDATE  dbo.VehicleAdjustmentDetails
    SET     InvoiceRefNo = ''
    WHERE   InvoiceRefNo = @TransactionNo
            AND BranchCode = @BranchCode
            AND VehicleAdjustmentNature = 'VP'
        
       
    --DELETE  FROM Invoices
    UPDATE  dbo.Invoices
    SET     Description = 'Invoice has been Deleted',
            CustomerReference = '',
            TripAdvanceReference = '',
            TripAdvance = 0,
            Quantity = 0,
            Rate = 0,
            Amount = 0,
            Shortage=0,
            Commission=0,
            ShortageQuantity=0,
            QuantityValue=0
    WHERE   TransactionNo = @TransactionNo
            AND BranchCode = @BranchCode
    COMMIT TRANSACTION

    IF @@error > 0 
        ROLLBACK TRANSACTION

GO
