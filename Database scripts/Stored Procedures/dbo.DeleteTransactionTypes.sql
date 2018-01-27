USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteTransactionTypes]    Script Date: 27-Jan-18 11:24:03 AM ******/
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
