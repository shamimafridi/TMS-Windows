USE [TMS_ALI]
GO
/****** Object:  View [dbo].[vwTransDetail]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER VIEW [dbo].[vwTransDetail]
AS
	SELECT        '' ProductName, '' StationPointName, '' DestinationPointName, '' TokenNo, '' LongTripRefNo, 0 IsLocalTrip, I.TransactionNo InvoiceRefNo, 'ADJ' TYPE, 
                         VA.BranchCode, VAD.Description, VAD.VehicleAdjustmentNature AS TransactionNature, VAD.VehicleAdjustmentNo AS TransactionNo, 
                         VA.VehicleAdjustmentDate AS TransactionDate, VAD.TransactionTypeCode, 
                         CASE VAD.VehicleAdjustmentNature WHEN 'CR' THEN VAD.Amount WHEN 'BR' THEN VAD.Amount WHEN 'AR' THEN VAD.Amount WHEN 'VR' THEN VAD.Amount ELSE
                          0 END AS AmountReceived, 
                         CASE VAD.VehicleAdjustmentNature WHEN 'FE' THEN VAD.Amount WHEN 'CP' THEN VAD.Amount WHEN 'BP' THEN VAD.Amount WHEN 'AP' THEN VAD.Amount WHEN
                          'VP' THEN VAD.Amount ELSE 0 END AS AmountPaid, VA.RecordNo, VA.VehicleCode
FROM            dbo.VehicleAdjustments AS VA INNER JOIN
                         dbo.VehicleAdjustmentDetails AS VAD ON VA.BranchCode = VAD.BranchCode AND VA.VehicleAdjustmentNature = VAD.VehicleAdjustmentNature AND 
                         VA.VehicleAdjustmentNo = VAD.VehicleAdjustmentNo LEFT OUTER JOIN
                         dbo.Invoices I ON I.TripAdvanceReference = VA.VehicleAdjustmentNo AND I.VehicleCode = VA.VehicleCode
WHERE        VAD.Amount <> 0
UNION ALL
SELECT        P.ProductName, S.StationPointName, D .DestinationPointName, I.CustomerReference, I.LongTripRefNo, I.IsLocalTrip, '' InvoiceRefNo, 'INV' TYPE, I.BranchCode, 
                         I.Description, 'VR' AS TransactionNature, I.TransactionNo, I.TransactionDate, '12', Amount AmountReceived, 0 AS AmountPaid, I.RecordNo, I.VehicleCode
FROM            dbo.Invoices I LEFT JOIN
                         StationPoints S ON I.StationPointCode = S.StationPointCode LEFT JOIN
                         DestinationPoints D ON I.DestinationPointCode = D .DestinationPointCode LEFT JOIN
                         Products P ON I.ProductCode = P.ProductCode
WHERE        I.Description != 'Invoice has been Deleted'
GO