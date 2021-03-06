USE [TMS_ALI]
GO
/****** Object:  View [dbo].[QryOtherAmountExcInvoice]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[QryOtherAmountExcInvoice]
AS
SELECT     VoucherDetails_1.VoucherNature, VoucherDetails_1.Debit, VoucherDetails_1.Credit, VoucherDetails_1.GLCode, dbo.GL_GetCOACombineTransactionVW.GLDescription,
                       dbo.GL_GetCOACombineTransactionVW.GLCode AS Expr1, dbo.Vouchers.VoucherDate
FROM         dbo.GL_GetCOACombineTransactionVW INNER JOIN
                      dbo.VoucherDetails VoucherDetails_1 ON dbo.GL_GetCOACombineTransactionVW.GLCode = VoucherDetails_1.GLCode INNER JOIN
                      dbo.Vouchers ON VoucherDetails_1.BranchCode = dbo.Vouchers.BranchCode AND VoucherDetails_1.VoucherNature = dbo.Vouchers.VoucherNature AND 
                      VoucherDetails_1.VoucherNo = dbo.Vouchers.VoucherNo LEFT OUTER JOIN
                      dbo.VoucherDetails VoucherDetails_2 ON VoucherDetails_1.VoucherNo = VoucherDetails_2.VoucherNo AND 
                      VoucherDetails_1.BranchCode = VoucherDetails_2.BranchCode AND VoucherDetails_1.VoucherNature = VoucherDetails_2.VoucherNature
WHERE     (dbo.GL_GetCOACombineTransactionVW.GLCode <> '020100010001') AND (VoucherDetails_2.GLCode = '020100010001') AND 
                      (dbo.GL_GetCOACombineTransactionVW.GLCode <> '010100010001')

GO
