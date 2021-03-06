USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectInvoices]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter  PROCEDURE [dbo].[SelectInvoices]
    @Option AS VARCHAR(20) = '',
    @BranchCode AS VARCHAR(2) = '',
    @TransactionNo AS VARCHAR(10) = '',
    @YearMonth AS VARCHAR(4) = '',
    @FromDate AS DATETIME = '',
    @ToDate AS DATETIME = '',
    @CustomerCode AS CHAR(10) = '',
	@VehicleNo as char(10)=''
AS 
    IF @Option = 'ALL' 
        SELECT  dbo.Invoices.BranchCode,
                dbo.Invoices.TransactionNo,
                dbo.Invoices.TransactionDate,
                dbo.Invoices.CustomerReference,
                dbo.Invoices.VehicleCode,
                dbo.[Vehicles ].VehicleDescription,
                dbo.Customers.CustomerCode,
                dbo.Customers.CustomerName,
                dbo.Invoices.StationPointCode,
                dbo.StationPoints.StationPointName AS StationPointName,
                dbo.Invoices.DestinationPointCode,
                dbo.DestinationPoints.DestinationPointName AS DestinationPointName,
                dbo.Invoices.DueDate,
                dbo.Invoices.ProductCode,
                dbo.Products.ProductName,
                dbo.Invoices.Description,
				dbo.Invoices.LongTripRefNo,
                dbo.Invoices.Locked,
                dbo.Invoices.Posted,
                dbo.Invoices.RecordNo,
                dbo.Invoices.IsTripCanceled,
                dbo.Invoices.IsTripCanceled AS Expr1,
                dbo.Branches.BranchDescription AS BranchName,
                dbo.Invoices.Quantity,
                dbo.Invoices.Rate,
                dbo.Invoices.Commission,
                dbo.Invoices.CommissionRate ,
                dbo.Invoices.Shortage,
                dbo.Invoices.ShortageQuantity,
                dbo.Invoices.QuantityValue,
                dbo.Invoices.Amount,
                dbo.Invoices.TripAdvanceReference,
                dbo.Invoices.TripAdvance,
				dbo.Invoices.IsLocalTrip
        FROM    dbo.Invoices
                LEFT OUTER JOIN dbo.Customers ON dbo.Invoices.PartyCode = dbo.Customers.CustomerCode
                LEFT OUTER JOIN dbo.Products ON dbo.Invoices.ProductCode = dbo.Products.ProductCode
                LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.Invoices.VehicleCode = dbo.[Vehicles ].VehicleCode
                LEFT OUTER JOIN dbo.Branches ON dbo.Invoices.BranchCode = dbo.Branches.BranchCode
                LEFT OUTER JOIN dbo.DestinationPoints ON dbo.Invoices.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode
                LEFT OUTER JOIN dbo.StationPoints ON dbo.Invoices.StationPointCode = dbo.StationPoints.StationPointCode
        WHERE   dbo.Invoices.Posted = 0
        ORDER BY dbo.Invoices.BranchCode,
                dbo.Invoices.TransactionNo

    ELSE 
        IF @Option = 'AUTO' 
            SELECT TOP 1
                    TransactionNo
            FROM    Invoices
            WHERE   ( SUBSTRING(CAST(TransactionNo AS VARCHAR(4)), 1, 4) = @YearMonth )
                    AND BranchCode = @BranchCode
            ORDER BY TransactionNo DESC
		IF @Option = 'LONGTRIPVALIDATE' 
            SELECT TOP 1 *
                    
            FROM    Invoices I
            WHERE  I.VehicleCode=@VehicleNo AND I.IsLocalTrip=0 AND I.TransactionNo=@TransactionNo
            ORDER BY TransactionNo DESC
		IF @Option = 'SEARCHLONGTRIP' 
            SELECT *
                    
            FROM    Invoices I
            WHERE  I.VehicleCode=@VehicleNo AND I.IsLocalTrip=0
            ORDER BY TransactionNo DESC

        ELSE 
            IF @Option = 'SRHGRID' 
                SELECT  dbo.Invoices.BranchCode,
                        dbo.Invoices.TransactionNo AS InvoiceNo,
                        dbo.Invoices.TransactionDate AS InvoiceDate,
                        dbo.Customers.CustomerCode,
                        dbo.Customers.CustomerName,
                        dbo.Invoices.Description,
                        dbo.Invoices.Amount,
                        dbo.Invoices.ShortageQuantity,
                        dbo.Invoices.QuantityValue
                FROM    dbo.Invoices
                        LEFT OUTER JOIN dbo.Branches ON dbo.Invoices.BranchCode = dbo.Branches.BranchCode
                        LEFT OUTER JOIN dbo.Customers ON dbo.Invoices.PartyCode = dbo.Customers.CustomerCode
                WHERE   dbo.Invoices.PartyCode = @CustomerCode
                        AND dbo.Invoices.IsBilled = 0
			
            ELSE 
                IF @Option = 'DateFilter' ---Date Filter for ALL Voucher Generation
                    SELECT  dbo.Invoices.BranchCode,
                            dbo.Invoices.TransactionNo,
                            dbo.Invoices.TransactionDate,
                            dbo.Invoices.CustomerReference,
                            dbo.Invoices.VehicleCode,
                            dbo.[Vehicles ].VehicleDescription,
                            dbo.Customers.CustomerCode,
                            dbo.Customers.CustomerName,
                            dbo.Invoices.StationPointCode,
                            dbo.StationPoints.StationPointName AS StationPointName,
                            dbo.Invoices.DestinationPointCode,
                            dbo.DestinationPoints.DestinationPointName AS DestinationPointName,
                            dbo.Invoices.DueDate,
                            dbo.Invoices.ProductCode,
                            dbo.Products.ProductName,
                            dbo.Invoices.Description,
							dbo.Invoices.LongTripRefNo,
                            dbo.Invoices.Locked,
                            dbo.Invoices.Posted,
                            dbo.Invoices.RecordNo,
                            dbo.Invoices.IsTripCanceled,
                            dbo.Invoices.IsTripCanceled AS Expr1,
                            dbo.Branches.BranchDescription AS BranchName,
                            dbo.Invoices.Quantity,
                            dbo.Invoices.Rate,
                            dbo.Invoices.Commission,
                            dbo.Invoices.Shortage,
                            dbo.Invoices.ShortageQuantity,
                            dbo.Invoices.QuantityValue,
                            dbo.Invoices.Amount,
                            dbo.Invoices.TripAdvanceReference,
                            dbo.Invoices.TripAdvance,
							dbo.Invoices.IsLocalTrip
                    FROM    dbo.Invoices
                            LEFT OUTER JOIN dbo.Customers ON dbo.Invoices.PartyCode = dbo.Customers.CustomerCode
                            LEFT OUTER JOIN dbo.Products ON dbo.Invoices.ProductCode = dbo.Products.ProductCode
                            LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.Invoices.VehicleCode = dbo.[Vehicles ].VehicleCode
                            LEFT OUTER JOIN dbo.Branches ON dbo.Invoices.BranchCode = dbo.Branches.BranchCode
                            LEFT OUTER JOIN dbo.DestinationPoints ON dbo.Invoices.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode
                            LEFT OUTER JOIN dbo.StationPoints ON dbo.Invoices.StationPointCode = dbo.StationPoints.StationPointCode
                    WHERE   dbo.Invoices.Posted = 0
                    ORDER BY DBO.Invoices.RecordNo,
                            dbo.Invoices.BranchCode,
                            dbo.Invoices.TransactionNo
                            
                ELSE 
                    SELECT  dbo.Invoices.BranchCode,
                            dbo.Invoices.TransactionNo,
                            dbo.Invoices.TransactionDate,
                            dbo.Invoices.CustomerReference,
                            dbo.Invoices.VehicleCode,
                            dbo.[Vehicles ].VehicleDescription,
                            dbo.Customers.CustomerCode,
                            dbo.Customers.CustomerName,
                            dbo.Invoices.StationPointCode,
                            dbo.StationPoints.StationPointName AS StationPointName,
                            dbo.Invoices.DestinationPointCode,
                            dbo.DestinationPoints.DestinationPointName AS DestinationPointName,
					        dbo.Invoices.LongTripRefNo,
						    dbo.Invoices.DueDate,
                            dbo.Invoices.ProductCode,
                            dbo.Products.ProductName,
                            dbo.Invoices.Description,
                            dbo.Invoices.Locked,
                            dbo.Invoices.Posted,
                            dbo.Invoices.RecordNo,
                            dbo.Invoices.IsTripCanceled,
                            dbo.Invoices.IsTripCanceled AS Expr1,
                            dbo.Branches.BranchDescription AS BranchName,
                            dbo.Invoices.Quantity,
                            dbo.Invoices.Rate,
                            dbo.Invoices.Commission,
                            dbo.Invoices.CommissionRate ,
                            dbo.Invoices.Shortage,
                            dbo.Invoices.ShortageQuantity,
                            dbo.Invoices.QuantityValue,
                            dbo.Invoices.Amount,
                            dbo.Invoices.TripAdvanceReference,
                            dbo.Invoices.TripAdvance,
							dbo.Invoices.IsLocalTrip
                    FROM    dbo.Invoices
                            LEFT OUTER JOIN dbo.Customers ON dbo.Invoices.PartyCode = dbo.Customers.CustomerCode
                            LEFT OUTER JOIN dbo.Products ON dbo.Invoices.ProductCode = dbo.Products.ProductCode
                            LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.Invoices.VehicleCode = dbo.[Vehicles ].VehicleCode
                            LEFT OUTER JOIN dbo.Branches ON dbo.Invoices.BranchCode = dbo.Branches.BranchCode
                            LEFT OUTER JOIN dbo.DestinationPoints ON dbo.Invoices.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode
                            LEFT OUTER JOIN dbo.StationPoints ON dbo.Invoices.StationPointCode = dbo.StationPoints.StationPointCode
                    WHERE   dbo.Invoices.TransactionNo = @TransactionNo
                            AND dbo.Invoices.BranchCode = @BranchCode
                            AND dbo.Invoices.Posted = 0
                    ORDER BY dbo.Invoices.BranchCode,
                            dbo.Invoices.TransactionNo

GO
