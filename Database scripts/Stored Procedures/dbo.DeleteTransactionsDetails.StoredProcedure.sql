USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteTransactionsDetails]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteTransactionsDetails]

@Option as  varchar(3)='',
@TransactionNo as integer =0,
@BranchCode as varchar(10)=' ',
@TransactionNature as  varchar(3)=''
AS

	DELETE FROM TransactionDetails WHERE TransactionNo=@TransactionNo AND TransactionNature=@TransactionNature  and BranchCode=@BranchCode

GO
