USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectTransactionsDetails]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectTransactionsDetails]


@Option as  varchar(20)='',
@BranchCode as  varchar(2)='',
@TransactionNo as integer =0,
@TransactionNature as  varchar(3)=''
AS
/*
NOTE : YOU MUST CONTAINS THE SAME NUMBER OF COLUMN SPECIFYING ON THE GRID THE SAME NAME
		WHICH CONTAINS THE CAPTION OF THE APEX GRID COLUMN
	CALCULATING FIELD NAME NOT THE SAME BUT MUST SELECT E.G 0.00 as Amt 
	if you specify 0.00 as Amount then the grid formula will not working. 
*/

	IF @TransactionNature='40' --Invoice
	IF 	@Option='ALL' 

		SELECT     dbo.TransactionDetails.BranchCode, dbo.TransactionDetails.TransactionNature, dbo.TransactionDetails.TransactionNo, 
                      dbo.GL_GetCOACombineTransactionVW.GLCode, dbo.GL_GetCOACombineTransactionVW.GLDescription, dbo.TransactionDetails.Quantity, 
                      dbo.TransactionDetails.Rate, dbo.TransactionDetails.Amount, dbo.Divisions.DivisionCode, dbo.Divisions.Division
		FROM         dbo.Transactions INNER JOIN
		                      dbo.TransactionDetails ON dbo.Transactions.BranchCode = dbo.TransactionDetails.BranchCode AND 
		                      dbo.Transactions.TransactionNo = dbo.TransactionDetails.TransactionNo AND 
		                      dbo.Transactions.TransactionNature = dbo.TransactionDetails.TransactionNature LEFT OUTER JOIN
		                      dbo.Branches ON dbo.TransactionDetails.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
		                      dbo.GL_GetCOACombineTransactionVW ON dbo.TransactionDetails.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode LEFT OUTER JOIN
		                      dbo.Divisions ON dbo.TransactionDetails.DivisionCode = dbo.Divisions.DivisionCode 
	ELSE
	SELECT     dbo.TransactionDetails.BranchCode, dbo.TransactionDetails.TransactionNature, dbo.TransactionDetails.TransactionNo, 
                      dbo.GL_GetCOACombineTransactionVW.GLCode, dbo.GL_GetCOACombineTransactionVW.GLDescription, dbo.TransactionDetails.Quantity, 
                      dbo.TransactionDetails.Rate, dbo.TransactionDetails.Amount, dbo.Divisions.DivisionCode, dbo.Divisions.Division
FROM         dbo.Transactions INNER JOIN
                      dbo.TransactionDetails ON dbo.Transactions.BranchCode = dbo.TransactionDetails.BranchCode AND 
                      dbo.Transactions.TransactionNo = dbo.TransactionDetails.TransactionNo AND 
                      dbo.Transactions.TransactionNature = dbo.TransactionDetails.TransactionNature LEFT OUTER JOIN
                      dbo.Branches ON dbo.TransactionDetails.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW ON dbo.TransactionDetails.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode LEFT OUTER JOIN
                      dbo.Divisions ON dbo.TransactionDetails.DivisionCode = dbo.Divisions.DivisionCode
		WHERE dbo.Transactions.TransactionNo=@TransactionNo AND Transactions.TransactionNature=@TransactionNature and Transactions.BranchCode=@BranchCode

GO
