USE [TMS_ALI]
GO
/****** Object:  View [dbo].[CreditDebitNotEqual]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[CreditDebitNotEqual]
AS
SELECT     BranchCode, VoucherNature, VoucherNo, SUM(Debit) AS Debit, SUM(Credit) AS Credit
FROM         dbo.VoucherDetails
GROUP BY BranchCode, VoucherNature, VoucherNo
HAVING      (SUM(Debit) - SUM(Credit) <> 0)

GO
