USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteVouchers]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteVouchers]
    @Option AS VARCHAR(3) = '',
    @BranchCode AS VARCHAR(3) = '',
    @TransactionNo AS VARCHAR(10) = '',
    @TransactionNature AS VARCHAR(3) = ''
AS 
    BEGIN TRANSACTION
    DELETE  FROM VoucherDetails
    WHERE   VoucherNo = @TransactionNo
            AND VoucherNature = @TransactionNature
            AND BranchCode = @BranchCode


    UPDATE  Vouchers
    SET     Description = 'The Voucher Has been Deleted',
            UrduTitle= ''
            
    WHERE   VoucherNo = @TransactionNo
            AND VoucherNature = @TransactionNature
            AND BranchCode = @BranchCode
    COMMIT TRANSACTION

    IF @@error > 0 
        ROLLBACK TRANSACTION

GO
