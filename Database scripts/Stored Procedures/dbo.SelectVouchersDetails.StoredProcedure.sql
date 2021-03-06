USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectVouchersDetails]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectVouchersDetails]
@Option as  varchar(3)='',
@TransactionNo as varchar(10) ='',
@TransactionNature as varchar(3) ='',
@BranchCode as varchar(10) =''

AS

IF 	@Option='ALL' 
		SELECT     dbo.VoucherDetails.BranchCode,dbo.VoucherDetails.VoucherNature AS TransactionNature, dbo.VoucherDetails.VoucherNo AS TransactionNo, dbo.VoucherDetails.GLCode, dbo.VoucherDetails.Reference, dbo.VoucherDetails.Debit, 
                      dbo.VoucherDetails.Credit, dbo.VoucherDetails.Narration, dbo.GL_GetCOACombineVW.GLDescription, dbo.VoucherDetails.DivisionCode, dbo.Divisions.Division
		FROM         dbo.VoucherDetails LEFT OUTER JOIN
                      dbo.Branches ON dbo.VoucherDetails.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
                      dbo.Divisions ON dbo.VoucherDetails.DivisionCode = dbo.Divisions.DivisionCode LEFT OUTER JOIN
                      dbo.GL_GetCOACombineVW ON dbo.VoucherDetails.GLCode = dbo.GL_GetCOACombineVW.GLCode
		Order by RecordNo
ELSE
		SELECT     dbo.VoucherDetails.BranchCode,dbo.VoucherDetails.VoucherNature AS TransactionNature, dbo.VoucherDetails.VoucherNo  AS TransactionNo, dbo.VoucherDetails.GLCode, dbo.VoucherDetails.Reference, dbo.VoucherDetails.Debit, 
		                      dbo.VoucherDetails.Credit, dbo.VoucherDetails.Narration, dbo.GL_GetCOACombineVW.GLDescription, dbo.VoucherDetails.DivisionCode, dbo.Divisions.Division
		                      
		FROM         dbo.VoucherDetails LEFT OUTER JOIN
		                      dbo.Branches ON dbo.VoucherDetails.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
		                      dbo.Divisions ON dbo.VoucherDetails.DivisionCode = dbo.Divisions.DivisionCode LEFT OUTER JOIN
		                      dbo.GL_GetCOACombineVW ON dbo.VoucherDetails.GLCode = dbo.GL_GetCOACombineVW.GLCode
		
		WHERE VoucherNo=@TransactionNo AND VoucherNature=@TransactionNature AND VoucherDetails.BranchCode=@BranchCode
		Order by RecordNo

GO
