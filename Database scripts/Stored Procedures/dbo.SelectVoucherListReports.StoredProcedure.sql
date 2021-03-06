USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectVoucherListReports]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE  [dbo].[SelectVoucherListReports] ( @FromCode varchar(20)= '', @ToCode varchar(20) ='',@StationCode as bigint=0,@FromDate datetime = '1/1/2000' , @ToDate datetime = '12/31/9999',@VoucherNature as varchar(2000) = '' ,@FromTransactionNumber as varchar(20)='0000000000',@ToTransactionNumber as varchar(10)='9999999999', @OPTION CHAR(10)='',@FromGLCode char(10)='',@ToGLCode char(10)='' ) 

AS

SELECT     dbo.Vouchers.VoucherNature, dbo.Vouchers.VoucherNo, dbo.Vouchers.VoucherDate, dbo.Vouchers.Description, dbo.VoucherDetails.Reference, 
                      dbo.VoucherDetails.Debit, dbo.VoucherDetails.Credit, dbo.VoucherDetails.Narration, dbo.GL_GetCOACombineTransactionVW.GLCode, 
                      dbo.GL_GetCOACombineTransactionVW.GLDescription, dbo.Divisions.DivisionCode, dbo.Divisions.Division, dbo.Branches.BranchCode, 
                      dbo.Branches.BranchDescription, dbo.Vouchers.UrduTitle , dbo.Branches.BranchDescription as BranchName , dbo.Vouchers.VoucherNature as TransactionNature, dbo.Vouchers.VoucherNo as  TransactionNo,  dbo.Vouchers.VoucherDate as TransactionDate,IsAutoGenerated
FROM         dbo.Vouchers INNER JOIN
                      dbo.VoucherDetails ON dbo.Vouchers.VoucherNo = dbo.VoucherDetails.VoucherNo AND dbo.Vouchers.VoucherNature = dbo.VoucherDetails.VoucherNature AND 
                      dbo.Vouchers.BranchCode = dbo.VoucherDetails.BranchCode INNER JOIN
                      dbo.GetTransactionNatures(@VoucherNature,'GL') GetTransactionNatures ON dbo.Vouchers.VoucherNature = GetTransactionNatures.NatureCode LEFT OUTER JOIN
                      dbo.Branches ON dbo.Vouchers.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
                      dbo.Divisions ON dbo.VoucherDetails.DivisionCode = dbo.Divisions.DivisionCode LEFT OUTER JOIN
                      dbo.GL_GetCOACombineTransactionVW ON dbo.VoucherDetails.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode
WHERE dbo.Vouchers.VoucherNo BETWEEN @FromCode AND @ToCode 
	AND dbo.Vouchers.VoucherDate BETWEEN @FromDate AND @ToDate
	AND dbo.VoucherDetails.GLCode BETWEEN @FromGlCode AND @ToGlCode

GO
