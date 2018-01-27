USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectOpeningBalances]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectOpeningBalances]
@Option as  varchar(20)='',
@BranchCode as varchar(10) ='',
@ClosingDate as datetime=''

AS

IF @Option='ALL' 
		SELECT     dbo.OpeningBalances.ClosingDate,dbo.Divisions.DivisionCode, dbo.Divisions.Division, dbo.Branches.BranchCode, dbo.Branches.BranchDescription, 
                      dbo.GL_GetCOACombineTransactionVW.GLCode, dbo.GL_GetCOACombineTransactionVW.GLDescription, 
                      dbo.OpeningBalances.DebitBalance - dbo.OpeningBalances.CreditBalance AS BalanceAmount
FROM         dbo.OpeningBalances LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW ON dbo.OpeningBalances.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode LEFT OUTER JOIN
                      dbo.Branches ON dbo.OpeningBalances.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
                      dbo.Divisions ON dbo.OpeningBalances.DivisionCode = dbo.Divisions.DivisionCode
ELSE IF @Option='SRHGRID'
	SELECT * FROM OpeningBalances
ELSE
		SELECT     dbo.OpeningBalances.ClosingDate, dbo.Divisions.DivisionCode, dbo.Divisions.Division, dbo.Branches.BranchCode, dbo.Branches.BranchDescription, 
                      dbo.GL_GetCOACombineTransactionVW.GLCode, dbo.GL_GetCOACombineTransactionVW.GLDescription, 
                      dbo.OpeningBalances.DebitBalance - dbo.OpeningBalances.CreditBalance AS BalanceAmount
FROM         dbo.OpeningBalances LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW ON dbo.OpeningBalances.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode LEFT OUTER JOIN
                      dbo.Branches ON dbo.OpeningBalances.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
                      dbo.Divisions ON dbo.OpeningBalances.DivisionCode = dbo.Divisions.DivisionCode
WHERE ClosingDate=@ClosingDate AND dbo.OpeningBalances.Branchcode=@BranchCode

GO
