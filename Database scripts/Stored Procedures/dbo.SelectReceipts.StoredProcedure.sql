USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectReceipts]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectReceipts]

@Option as  varchar(20)='',
@BranchCode as  varchar(20)='',
@TransactionNo as integer =0,
@FromDate AS DATETIME = '',
    @ToDate AS DATETIME = '',
@YearMonth as varchar(4)='',
@CustomerCode as char(10)='',
@BillNo as char(12)=''
AS

	IF @Option='ALL'  
		SELECT     dbo.Receipts.BranchCode, dbo.Receipts.ReceiptNo as TransactionNo, dbo.Receipts.ReceiptDate, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, 
		      dbo.Receipts.Description, dbo.Receipts.Locked, dbo.Receipts.Posted, dbo.Receipts.RecordNo, dbo.Branches.BranchDescription AS BranchName, dbo.Receipts.TotalAmount,
		      dbo.Receipts.Shortage, dbo.Receipts.Amount, dbo.Receipts.BillNo, dbo.Receipts.TaxRate, dbo.Receipts.SaleTaxValue, dbo.Receipts.AmountIncSaleTax
		FROM         dbo.Receipts LEFT OUTER JOIN
		      dbo.Customers ON dbo.Receipts.CustomerCode = dbo.Customers.CustomerCode LEFT OUTER JOIN
		      dbo.Branches ON dbo.Receipts.BranchCode = dbo.Branches.BranchCode
        ORDER BY DBO.Receipts.BranchCode,DBO.Receipts.ReceiptNo
        ELSE 
                IF @Option = 'DateFilter' ---Date Filter for ALL Voucher Generation
                SELECT     dbo.Receipts.BranchCode, dbo.Receipts.ReceiptNo as TransactionNo, dbo.Receipts.ReceiptDate, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, 
		      dbo.Receipts.Description, dbo.Receipts.Locked, dbo.Receipts.Posted, dbo.Receipts.RecordNo, dbo.Branches.BranchDescription AS BranchName, dbo.Receipts.TotalAmount,
		      dbo.Receipts.Shortage, dbo.Receipts.Amount, dbo.Receipts.BillNo, dbo.Receipts.TaxRate, dbo.Receipts.SaleTaxValue, dbo.Receipts.AmountIncSaleTax
		FROM         dbo.Receipts LEFT OUTER JOIN
		      dbo.Customers ON dbo.Receipts.CustomerCode = dbo.Customers.CustomerCode LEFT OUTER JOIN
		      dbo.Branches ON dbo.Receipts.BranchCode = dbo.Branches.BranchCode
		      where dbo.Receipts.Posted=0 and dbo.Receipts.ReceiptDate between @FromDate and @ToDate
        ORDER BY DBO.Receipts.BranchCode,DBO.Receipts.ReceiptNo
                
	ELSE IF @Option='AUTO' 
		SELECT TOP 1 ReceiptNo as TransactionNo FROM Receipts 
			WHERE ( SUBSTRING( CAST( ReceiptNo AS varchar(4) ) ,1,4) = @YearMonth )   AND BranchCode=@BranchCode
			Order By ReceiptNo DESC

	Else IF @Option='SRHGRID'  
			SELECT     dbo.Receipts.BranchCode, dbo.Receipts.ReceiptNo as TransactionNo , dbo.Receipts.ReceiptDate, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, 
		      dbo.Receipts.Description, dbo.Receipts.Locked, dbo.Receipts.Posted, dbo.Receipts.RecordNo, dbo.Branches.BranchDescription AS BranchName, dbo.Receipts.TotalAmount,
		      dbo.Receipts.Shortage, dbo.Receipts.Amount, dbo.Receipts.BillNo, dbo.Receipts.TaxRate, dbo.Receipts.SaleTaxValue, dbo.Receipts.AmountIncSaleTax
		FROM         dbo.Receipts LEFT OUTER JOIN
		      dbo.Customers ON dbo.Receipts.CustomerCode = dbo.Customers.CustomerCode LEFT OUTER JOIN
		      dbo.Branches ON dbo.Receipts.BranchCode = dbo.Branches.BranchCode
        ORDER BY DBO.Receipts.BranchCode,DBO.Receipts.ReceiptNo
			--WHERE dbo.Receipts.PartyCode="CustomerCode"

	ELSE
		SELECT     dbo.Receipts.BranchCode, dbo.Receipts.ReceiptNo as TransactionNo , dbo.Receipts.ReceiptDate, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, 
		      dbo.Receipts.Description, dbo.Receipts.Locked, dbo.Receipts.Posted, dbo.Receipts.RecordNo, dbo.Branches.BranchDescription AS BranchName, dbo.Receipts.TotalAmount,
		      dbo.Receipts.Shortage, dbo.Receipts.Amount, dbo.Receipts.BillNo, dbo.Receipts.TaxRate, dbo.Receipts.SaleTaxValue, dbo.Receipts.AmountIncSaleTax
		FROM         dbo.Receipts LEFT OUTER JOIN
		      dbo.Customers ON dbo.Receipts.CustomerCode = dbo.Customers.CustomerCode LEFT OUTER JOIN
		      dbo.Branches ON dbo.Receipts.BranchCode = dbo.Branches.BranchCode
		WHERE dbo.Receipts.ReceiptNo=@TransactionNo and  dbo.Receipts.BranchCode= @BranchCode
		and  dbo.Receipts.BillNo= @BillNo

GO
