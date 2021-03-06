USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateTransactionsDetails]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateTransactionsDetails]

@BranchCode char(2) = ''  ,
@TransactionNature char(2) = ''  ,
@TransactionNo varchar(16)=' '  ,
@GLCode as  varchar(12)=''  ,
@GLDescription as  varchar(12)=''  ,
@DivisionCode  char(5) ='' ,
@Division  varchar(15) ='' ,
@Quantity decimal=0.00,
@Rate decimal=0.00,
@Amount decimal=0.00,
@NewRecord as bigint

 AS 



 IF @TransactionNature='30' or  @TransactionNature='40' 
		INSERT INTO TransactionDetails (BranchCode, TransactionNature ,TransactionNo, GLCode,DivisionCode, Quantity , Rate, Amount) 
		                       VALUES  (@BranchCode, @TransactionNature ,@TransactionNo  ,@GLCode, @DivisionCode,@Quantity,@Rate, @Amount)

GO
