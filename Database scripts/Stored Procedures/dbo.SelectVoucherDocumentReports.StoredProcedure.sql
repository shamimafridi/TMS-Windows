USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectVoucherDocumentReports]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SelectVoucherDocumentReports] ( @FromCode varchar(20)= '', @ToCode varchar(20) ='',@StationCode as bigint=0,@FromPartyCode as varchar(10)='0000000',@ToPartyCode as varchar(10)='99999999999',  @FromDate datetime = '1/1/2000' , @ToDate datetime = '12/31/9999',@TransactionNature as varchar(500) = '' ,@FromTransactionNumber as varchar(20)='0000000000',@ToTransactionNumber as varchar(10)='9999999999', @OPTION CHAR(10)='' ) 

AS

	SELECT     dbo.Vouchers.VoucherNature, dbo.Vouchers.VoucherNo, dbo.Vouchers.VoucherDate, dbo.Vouchers.Description, dbo.VoucherDetails.Reference, 
                      dbo.VoucherDetails.Debit, dbo.VoucherDetails.Credit, dbo.VoucherDetails.Narration, dbo.Branches.BranchCode, dbo.Branches.BranchDescription, 
                      dbo.Divisions.DivisionCode, dbo.Divisions.Division, dbo.GL_GetCOACombineTransactionVW.GLCode, dbo.GL_GetCOACombineTransactionVW.GLDescription
	FROM         dbo.VoucherDetails INNER JOIN
	                      dbo.Vouchers ON dbo.VoucherDetails.VoucherNo = dbo.Vouchers.VoucherNo AND dbo.VoucherDetails.VoucherNature = dbo.Vouchers.VoucherNature AND 
	                      dbo.VoucherDetails.BranchCode = dbo.Vouchers.BranchCode INNER JOIN
	                      dbo.GetTransactionNatures(@TransactionNature, 'GL') GetTransactionNatures ON dbo.VoucherDetails.VoucherNature = GetTransactionNatures.NatureCode LEFT OUTER JOIN
	                      dbo.GL_GetCOACombineTransactionVW ON dbo.VoucherDetails.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode LEFT OUTER JOIN
	                      dbo.Branches ON dbo.Vouchers.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
	                      dbo.Divisions ON dbo.VoucherDetails.DivisionCode = dbo.Divisions.DivisionCode
	WHERE dbo.Vouchers.VoucherNo BETWEEN @FromCode AND @ToCode AND
	dbo.Vouchers.VoucherDate BETWEEN @FromDate AND @ToDate

GO
