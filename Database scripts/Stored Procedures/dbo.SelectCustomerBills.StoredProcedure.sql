USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectCustomerBills]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectCustomerBills]

@Option as  varchar(20)='',
@BillNo as char(10) ='',
@CustomerCode as char(10) ='',
@YearMonth as varchar(4)='',
@ToInvoiceNo as varchar(10)='',
@FromInvoiceNo as varchar(10)='',
@FromInvoiceDate as Datetime='',
@ToInvoiceDate as datetime='',
@TransactionNature as varchar(10)=''

AS



	IF @Option='ALL'  
		SELECT     dbo.CustomerBills.BillNo, dbo.CustomerBills.BillDate, dbo.Customers.CustomerCode, dbo.Customers.CustomerName
		FROM         dbo.CustomerBills LEFT OUTER JOIN
			      dbo.Customers ON dbo.CustomerBills.CustomerCode = dbo.Customers.CustomerCode
	ELSE IF @Option='AUTO' 
		SELECT TOP 1 BillNo as BillNo FROM dbo.CustomerBills 
		WHERE ( SUBSTRING( CAST( BillNo AS varchar(4) ) ,1,4) = @YearMonth )
		ORDER BY BillNo DESC
	ELSE IF @Option='FILTERINVOICES'  --FILTER ON BILL GENERATION
		IF @FromInvoiceNo <> '' OR @ToInvoiceNo <> ''
			SELECT   Invoices.CustomerReference AS TokenNo,  dbo.Invoices.BranchCode, dbo.Branches.BranchDescription, dbo.Invoices.BranchCode + ' - ' +  dbo.Branches.BranchDescription as Branch,dbo.Invoices.TransactionNo AS InvoiceNo, dbo.Invoices.TransactionDate AS InvoiceDate, 
				dbo.Invoices.Quantity, dbo.Invoices.Rate, dbo.Invoices.Amount, dbo.Invoices.Shortage,dbo.[Vehicles ].VehicleCode + ' - ' + dbo.[Vehicles ].VehicleDescription AS Vehicle, 
				dbo.Products.ProductCode + ' - ' + dbo.Products.ProductName AS Product,
				DestinationPoints.DestinationPointCode + ' - ' +  DestinationPoints.DestinationPointName AS DestinationPoint, StationPoints.StationPointCode 
                      + ' - ' + StationPoints.StationPointName as StationPoint
FROM         Invoices LEFT OUTER JOIN
                      StationPoints ON Invoices.StationPointCode = StationPoints.StationPointCode AND 
                      Invoices.StationPointCode = StationPoints.StationPointCode LEFT OUTER JOIN
                      DestinationPoints ON Invoices.DestinationPointCode = DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      Products ON Invoices.ProductCode = Products.ProductCode LEFT OUTER JOIN
                      [Vehicles ] ON Invoices.VehicleCode = [Vehicles ].VehicleCode LEFT OUTER JOIN
                      Branches ON Invoices.BranchCode = Branches.BranchCode

			WHERE dbo.Invoices.TransactionNo BETWEEN @FromInvoiceNo AND @ToInvoiceNo AND dbo.Invoices.PArtyCode=@CustomerCode
				AND dbo.Invoices.IsBilled=0
			ORDER BY dbo.Invoices.BranchCode,dbo.Invoices.TransactionDate
		ELSE
			SELECT     Invoices.CustomerReference AS TokenNo,  Invoices.BranchCode, Branches.BranchDescription, Invoices.BranchCode + ' - ' + Branches.BranchDescription AS Branch, 
                      Invoices.TransactionNo AS InvoiceNo, Invoices.TransactionDate AS InvoiceDate, Invoices.Quantity, Invoices.Rate, Invoices.Amount, Invoices.Shortage, 
                      [Vehicles ].VehicleCode + ' - ' + [Vehicles ].VehicleDescription AS Vehicle, Products.ProductCode + ' - ' + Products.ProductName AS Product, 
                      DestinationPoints.DestinationPointCode+ ' - ' +  DestinationPoints.DestinationPointName AS DestinationPoint, StationPoints.StationPointCode 
                      + ' - ' + StationPoints.StationPointName as StationPoint
FROM         Invoices LEFT OUTER JOIN
                      StationPoints ON Invoices.StationPointCode = StationPoints.StationPointCode AND 
                      Invoices.StationPointCode = StationPoints.StationPointCode LEFT OUTER JOIN
                      DestinationPoints ON Invoices.DestinationPointCode = DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      Products ON Invoices.ProductCode = Products.ProductCode LEFT OUTER JOIN
                      [Vehicles ] ON Invoices.VehicleCode = [Vehicles ].VehicleCode LEFT OUTER JOIN
                      Branches ON Invoices.BranchCode = Branches.BranchCode
			WHERE dbo.Invoices.TransactionDate BETWEEN @FromInvoiceDate AND @ToInvoiceDate AND dbo.Invoices.PArtyCode=@CustomerCode
			AND dbo.Invoices.IsBilled=0
			ORDER BY dbo.Invoices.BranchCode,dbo.Invoices.TransactionDate

		ELSE IF @Option='FILTER_BILL'  --FILTER BILL ON RECEIPT VOUCHER
			SELECT     dbo.CustomerBills.BillNo, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, SUM(dbo.CustomerBillDetails.Amount) AS Amount, 
			      dbo.CustomerBills.BillDate, SUM(dbo.CustomerBillDetails.Shortage) AS Shortage
			FROM         dbo.Customers RIGHT OUTER JOIN
			      dbo.CustomerBills ON dbo.Customers.CustomerCode = dbo.CustomerBills.CustomerCode RIGHT OUTER JOIN
			      dbo.CustomerBillDetails ON dbo.CustomerBills.BillNo = dbo.CustomerBillDetails.BillNo
			WHERE dbo.CustomerBills.IsReceipt=0
			GROUP BY dbo.CustomerBills.BillNo, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, dbo.CustomerBills.BillDate
			HAVING  dbo.Customers.CustomerCode=@CustomerCode
	ELSE IF @Option='REPORT'
		SELECT     dbo.CustomerBillDetails.BillNo, dbo.CustomerBillDetails.BranchCode, dbo.CustomerBillDetails.InvoiceNo, dbo.Branches.BranchDescription, 
                      dbo.CustomerBillDetails.BranchCode + ' - ' + dbo.Branches.BranchDescription AS Branch, dbo.Invoices.TransactionDate AS InvoiceDate, 
                      dbo.[Vehicles ].VehicleCode + ' - ' + dbo.[Vehicles ].VehicleDescription AS Vehicle, dbo.Invoices.Quantity, dbo.Invoices.Rate, dbo.Invoices.Amount, 
                      dbo.Products.ProductCode + ' - ' + dbo.Products.ProductName AS Product, dbo.CustomerBillDetails.Shortage, dbo.Customers.CustomerCode, 
                      dbo.Customers.CustomerName, dbo.Customers.UrduTitle, dbo.Customers.Address, dbo.Customers.NationalTaxNumber, dbo.Customers.SalesTaxNumber, 
                      dbo.Customers.Telephone, dbo.Customers.Fax, dbo.Products.ProductCode, dbo.Products.ProductName, dbo.[Vehicles ].VehicleCode, 
                      dbo.[Vehicles ].VehicleDescription, dbo.DestinationPoints.DestinationPointCode AS DestinationPointCode, dbo.DestinationPoints.DestinationPointName AS Destination,
                       dbo.StationPoints.StationPointCode, dbo.StationPoints.StationPointName, dbo.Invoices.CustomerReference, dbo.Invoices.BranchCode AS InvBranchCode, 
                      dbo.CustomerBills.BillDate
		FROM         dbo.Products RIGHT OUTER JOIN
                      dbo.Invoices LEFT OUTER JOIN
                      dbo.DestinationPoints ON dbo.Invoices.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      dbo.StationPoints ON dbo.Invoices.StationPointCode = dbo.StationPoints.StationPointCode ON 
                      dbo.Products.ProductCode = dbo.Invoices.ProductCode LEFT OUTER JOIN
                      dbo.[Vehicles ] ON dbo.Invoices.VehicleCode = dbo.[Vehicles ].VehicleCode LEFT OUTER JOIN
                      dbo.Branches ON dbo.Invoices.BranchCode = dbo.Branches.BranchCode RIGHT OUTER JOIN
                      dbo.CustomerBills INNER JOIN
                      dbo.Customers ON dbo.CustomerBills.CustomerCode = dbo.Customers.CustomerCode RIGHT OUTER JOIN
                      dbo.CustomerBillDetails ON dbo.CustomerBills.BillNo = dbo.CustomerBillDetails.BillNo ON dbo.Invoices.PartyCode = dbo.Customers.CustomerCode AND 
                      dbo.Invoices.BranchCode = dbo.CustomerBillDetails.BranchCode AND dbo.Invoices.TransactionNo = dbo.CustomerBillDetails.InvoiceNo
		WHERE dbo.CustomerBillDetails.BillNo=@BillNo
	ELSE IF @Option='PKVALIDATION' 
			SELECT     dbo.CustomerBills.BillNo, dbo.CustomerBills.BillDate, dbo.Customers.CustomerCode, dbo.Customers.CustomerName
			FROM         dbo.CustomerBills LEFT OUTER JOIN
			  		dbo.Customers ON dbo.CustomerBills.CustomerCode = dbo.Customers.CustomerCode
			WHERE dbo.CustomerBills.BillNo=@BillNo
	ELSE
		SELECT     dbo.CustomerBills.BillNo, dbo.CustomerBills.BillDate, dbo.Customers.CustomerCode, dbo.Customers.CustomerName
			FROM         dbo.CustomerBills LEFT OUTER JOIN
			dbo.Customers ON dbo.CustomerBills.CustomerCode = dbo.Customers.CustomerCode
			WHERE dbo.CustomerBills.BillNo=@BillNo AND dbo.Customers.CustomerCode=@CustomerCode

GO
