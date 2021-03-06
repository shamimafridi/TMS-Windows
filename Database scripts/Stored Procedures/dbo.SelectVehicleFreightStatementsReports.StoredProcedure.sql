USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleFreightStatementsReports]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectVehicleFreightStatementsReports]  
@BranchCode varchar(10)='',  
@FromPartyCode varchar(10)='',  
@ToPartyCode varchar(10)='' , 
@FromCode varchar(10)='',  
@ToCode varchar(10)='' , 
@FromVehicleCode as char(10)='',
@ToVehicleCode as char(10)='',
@FromDate DateTime= NULL, 
@ToDate DateTime= NULL, 
@OPTION AS varchar(100)='',
@nType bigint =0 

AS

IF @BranchCode=''
	BEGIN
SELECT     Branches.BranchCode, Branches.BranchDescription AS Branch, Invoices.TransactionNo, Invoices.TransactionDate, 
                      Invoices.CustomerReference AS TokenNo, Customers.CustomerCode, Customers.CustomerName, DestinationPoints.DestinationPointCode, 
                      DestinationPoints.DestinationPointName, StationPoints.StationPointCode, StationPoints.StationPointName, Products.ProductCode, 
                      Products.ProductName, Invoices.Quantity, Invoices.Rate, Invoices.Commission, Invoices.ShortageQuantity, Invoices.QuantityValue, Invoices.Shortage, 
                      Invoices.Amount, Invoices.IsBilled, [Vehicles ].VehicleCode, [Vehicles ].VehicleDescription, '' AS BillNo
FROM         Invoices LEFT OUTER JOIN
                      Products ON Invoices.ProductCode = Products.ProductCode LEFT OUTER JOIN
                      StationPoints ON Invoices.StationPointCode = StationPoints.StationPointCode AND 
                      Invoices.StationPointCode = StationPoints.StationPointCode LEFT OUTER JOIN
                      DestinationPoints ON Invoices.DestinationPointCode = DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      Branches ON Invoices.BranchCode = Branches.BranchCode LEFT OUTER JOIN
                      [Vehicles ] ON Invoices.VehicleCode = [Vehicles ].VehicleCode LEFT OUTER JOIN
                      Customers ON Invoices.PartyCode = Customers.CustomerCode
	WHERE dbo.Customers.CustomerCode BETWEEN @FromPartyCode AND	@ToPartyCode 
		AND dbo.Invoices.VehicleCode BETWEEN @FromVehicleCode AND @ToVehicleCode
		AND dbo.Invoices.TransactionNo BETWEEN @FromCode AND @ToCode
		AND dbo.Invoices.TransactionDate BETWEEN @FromDate AND @ToDate
	END
ELSE
	BEGIN
	SELECT     dbo.Branches.BranchCode, dbo.Branches.BranchDescription AS Branch, dbo.Invoices.TransactionNo, dbo.Invoices.TransactionDate, 
	                      dbo.Invoices.CustomerReference AS TokenNo, dbo.Customers.CustomerCode, dbo.Customers.CustomerName, dbo.DestinationPoints.DestinationPointCode, 
	                      dbo.DestinationPoints.DestinationPointName, dbo.StationPoints.StationPointCode, dbo.StationPoints.StationPointName, dbo.Products.ProductCode, 
	                      dbo.Products.ProductName, dbo.Invoices.Quantity, dbo.Invoices.Rate, dbo.Invoices.Commission, dbo.Invoices.ShortageQuantity, dbo.Invoices.QuantityValue, 
	                      dbo.Invoices.Shortage, dbo.Invoices.Amount, dbo.Invoices.IsBilled, dbo.[Vehicles ].VehicleCode, dbo.[Vehicles ].VehicleDescription, 
	                      dbo.CustomerBillDetails.BillNo
	FROM         dbo.Invoices LEFT OUTER JOIN
	                      dbo.CustomerBillDetails ON dbo.Invoices.BranchCode = dbo.CustomerBillDetails.BranchCode AND 
	                      dbo.Invoices.TransactionNo = dbo.CustomerBillDetails.InvoiceNo LEFT OUTER JOIN
	                      dbo.Products ON dbo.Invoices.ProductCode = dbo.Products.ProductCode LEFT OUTER JOIN
	                      dbo.StationPoints ON dbo.Invoices.StationPointCode = dbo.StationPoints.StationPointCode AND 
	                      dbo.Invoices.StationPointCode = dbo.StationPoints.StationPointCode LEFT OUTER JOIN
	                      dbo.DestinationPoints ON dbo.Invoices.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode LEFT OUTER JOIN
	                      dbo.Branches ON dbo.Invoices.BranchCode = dbo.Branches.BranchCode LEFT OUTER JOIN
	                      dbo.[Vehicles ] ON dbo.Invoices.VehicleCode = dbo.[Vehicles ].VehicleCode LEFT OUTER JOIN
	                      dbo.Customers ON dbo.Invoices.PartyCode = dbo.Customers.CustomerCode
	WHERE  dbo.Branches.BranchCode=@BranchCode
		AND  dbo.Customers.CustomerCode BETWEEN @FromPartyCode AND	@ToPartyCode 
		AND dbo.Invoices.VehicleCode BETWEEN @FromVehicleCode AND @ToVehicleCode
		AND dbo.Invoices.TransactionNo BETWEEN @FromCode AND @ToCode
		AND dbo.Invoices.TransactionDate BETWEEN @FromDate AND @ToDate
	END

GO
