USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectTransactionNatures]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectTransactionNatures]  ( @SelectedTransNatureCode as varchar(1000)='',@OPTION as Varchar(100)='',@System as Char(10)='',@TransactionNatureCode as char(10)='')
AS
	IF @OPTION='TRL'
		SELECT     *
		FROM         dbo.GetTransactionNatures(@SelectedTransNatureCode,@System) GetTransactionNatures
	ELSE IF @OPTION='ALL'
		SELECT * 
		FROM TransactionNatures
		WHERE [SYSTEM]=@System
		ELSE IF @OPTION='SRHGRID'
		SELECT * 
		FROM TransactionNatures
		WHERE [SYSTEM]='IN'
		ELSE 
		SELECT * 
		FROM TransactionNatures
		WHERE [SYSTEM]=@System and 
		TransactionNatures.NatureCode =@TransactionNatureCode

GO
