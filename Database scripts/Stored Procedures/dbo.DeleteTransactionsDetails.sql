USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteTransactionsDetails]    Script Date: 27-Jan-18 11:24:03 AM ******/
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
