USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteTransactionTypes]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteTransactionTypes]
@NatureCode nchar(5)='',
@TransactionTypeCode nchar(5)=''
AS
	IF @TransactionTypeCode <> '' 
		DELETE FROM dbo.TransactionTypes
		WHERE ( dbo.TransactionTypes.TransactionTypeCode= @TransactionTypeCode)

GO
