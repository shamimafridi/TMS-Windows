USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectCustomerBillsDetails]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCustomerBillsDetails]
@Option as  varchar(3)='',
@BillNo as varchar(10) ='',
@TransactionNature as varchar(3) ='',
@BranchCode as varchar(10) =''

AS

IF 	@Option='ALL' 
		SELECT     CustomerBillDetails.BillNo, CustomerBillDetails.BranchCode, CustomerBillDetails.InvoiceNo, Branches.BranchDescription, 
                      CustomerBillDetails.BranchCode + ' - ' + Branches.BranchDescription AS Branch, Invoices.TransactionDate AS InvoiceDate, 
                      [Vehicles ].VehicleCode + ' - ' + [Vehicles ].VehicleDescription AS Vehicle, Invoices.Quantity, Invoices.Rate, Invoices.Amount, 
                      Products.ProductCode + ' - ' + Products.ProductName AS Product, CustomerBillDetails.Shortage, Invoices.CustomerReference as TokenNo, 
                      StationPoints.StationPointCode + ' - ' + StationPoints.StationPointName as StationPoint, DestinationPoints.DestinationPointCode + ' - ' + 
                      DestinationPoints.DestinationPointName as DestinationPoint
FROM         Invoices LEFT OUTER JOIN
                      StationPoints ON Invoices.StationPointCode = StationPoints.StationPointCode AND 
                      Invoices.StationPointCode = StationPoints.StationPointCode LEFT OUTER JOIN
                      DestinationPoints ON Invoices.DestinationPointCode = DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      Products ON Invoices.ProductCode = Products.ProductCode LEFT OUTER JOIN
                      [Vehicles ] ON Invoices.VehicleCode = [Vehicles ].VehicleCode LEFT OUTER JOIN
                      Branches ON Invoices.BranchCode = Branches.BranchCode RIGHT OUTER JOIN
                      CustomerBillDetails ON Invoices.BranchCode = CustomerBillDetails.BranchCode AND Invoices.TransactionNo = CustomerBillDetails.InvoiceNo
		WHERE dbo.CustomerBillDetails.BillNo=@BillNo
Else
		SELECT     dbo.CustomerBillDetails.BillNo, dbo.CustomerBillDetails.BranchCode, dbo.CustomerBillDetails.InvoiceNo, dbo.Branches.BranchDescription, 
		              dbo.CustomerBillDetails.BranchCode + ' - ' + dbo.Branches.BranchDescription AS Branch, dbo.Invoices.TransactionDate AS InvoiceDate, 
		              dbo.[Vehicles ].VehicleCode + ' - ' + dbo.[Vehicles ].VehicleDescription AS Vehicle, dbo.Invoices.Quantity, dbo.Invoices.Rate, dbo.Invoices.Amount, 
		              dbo.Products.ProductCode + ' - ' + dbo.Products.ProductName AS Product, dbo.CustomerBillDetails.Shortage
		, Invoices.CustomerReference as TokenNo, 
                      StationPoints.StationPointCode + ' - ' + StationPoints.StationPointName as StationPoint, DestinationPoints.DestinationPointCode + ' - ' + 
                      DestinationPoints.DestinationPointName as DestinationPoint
FROM         Invoices LEFT OUTER JOIN
                      StationPoints ON Invoices.StationPointCode = StationPoints.StationPointCode AND 
                      Invoices.StationPointCode = StationPoints.StationPointCode LEFT OUTER JOIN
                      DestinationPoints ON Invoices.DestinationPointCode = DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      Products ON Invoices.ProductCode = Products.ProductCode LEFT OUTER JOIN
                      [Vehicles ] ON Invoices.VehicleCode = [Vehicles ].VehicleCode LEFT OUTER JOIN
                      Branches ON Invoices.BranchCode = Branches.BranchCode RIGHT OUTER JOIN
                      CustomerBillDetails ON Invoices.BranchCode = CustomerBillDetails.BranchCode AND Invoices.TransactionNo = CustomerBillDetails.InvoiceNo
		WHERE dbo.CustomerBillDetails.BillNo=@BillNo

GO
