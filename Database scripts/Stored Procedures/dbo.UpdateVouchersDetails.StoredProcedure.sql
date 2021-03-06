USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateVouchersDetails]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateVouchersDetails]
    @TransactionNature CHAR(2) = '' ,
    @BranchCode CHAR(2) = '' ,
    @TransactionNo VARCHAR(16) = ' ' ,
    @GLCode VARCHAR(50) = ' ' ,
    @GLDescription VARCHAR(50) = ' ' ,
    @Debit DECIMAL(20, 5) = 0.00 ,
    @Credit DECIMAL(20, 5) = 0.00 ,
    @DivisionCode CHAR(10) = '' ,
    @Division VARCHAR(5) = '' ,
    @Narration VARCHAR(100) = '' ,
    @Reference VARCHAR(100) = '' ,
    @NewRecord AS BIGINT = 0
AS 
    IF @DivisionCode = '' 
        BEGIN
            SET @DivisionCode = '001'
        END
	


    IF @NewRecord = 1 
        BEGIN
	
            INSERT  INTO VoucherDetails
                    ( BranchCode ,
                      VoucherNature ,
                      VoucherNo ,
                      GLCode ,
                      DivisionCode ,
                      Debit ,
                      Credit ,
                      Reference ,
                      Narration
                    )
            VALUES  ( @BranchCode ,
                      @TransactionNature ,
                      @TransactionNo ,
                      @GLCode ,
                      @DivisionCode ,
                      @Debit ,
                      @Credit ,
                      @Reference ,
                      @Narration
                    ) 
	
        END
/*
	ELSE 
	     BEGIN
		UPDATE VoucherDetails
		Set  
			GLCode=@GLCode,
			Debit=@Debit,
			Credit=@Credit,
			Particuler=@Particuler
		WHERE  ( VoucherNature = @VoucherNature AND DocumentNo=@DocumentNo ) 
 	     END*/

GO
