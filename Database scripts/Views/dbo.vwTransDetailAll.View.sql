USE [TMS_ALI]
GO
/****** Object:  View [dbo].[vwTransDetailAll]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER VIEW [dbo].[vwTransDetailAll]
AS
SELECT        '1' TYPE, I.IsLocalTrip, '' InvoiceRefNo, I.BranchCode, I.Description, 'VP' AS TransactionNature, I.TransactionNo, I.TransactionDate, '12' TransactionTypeCode, 
                         Amount AmountReceived, 0 AS AmountPaid, I.RecordNo, V.VehicleCode
FROM            dbo.Vehicles V LEFT JOIN
                         dbo.Invoices I ON I.VehicleCode = V.VehicleCode
/*WHERE        I.Description != 'Invoice has been Deleted'*/ UNION ALL
SELECT        '2' TYPE, 0 AS IsLocalTrip, I.TransactionNo AS InvoiceRefNo, VA.BranchCode, VAD.Description, ISNULL(VAD.VehicleAdjustmentNature, 'VP') AS TransactionNature, 
                         VAD.VehicleAdjustmentNo AS TransactionNo, VA.VehicleAdjustmentDate AS TransactionDate, ISNULL(VAD.TransactionTypeCode, '12') TransactionTypeCode, 
                         CASE VAD.VehicleAdjustmentNature WHEN 'CR' THEN VAD.Amount WHEN 'BR' THEN VAD.Amount WHEN 'AR' THEN VAD.Amount WHEN 'VR' THEN VAD.Amount ELSE
                          0 END AS AmountReceived, 
                         CASE VAD.VehicleAdjustmentNature WHEN 'FE' THEN VAD.Amount WHEN 'CP' THEN VAD.Amount WHEN 'BP' THEN VAD.Amount WHEN 'AP' THEN VAD.Amount WHEN
                          'VP' THEN VAD.Amount ELSE 0 END AS AmountPaid, VA.RecordNo, Vehicles.VehicleCode
FROM            VehicleAdjustments AS VA INNER JOIN
                         VehicleAdjustmentDetails AS VAD ON VA.BranchCode = VAD.BranchCode AND VA.VehicleAdjustmentNature = VAD.VehicleAdjustmentNature AND 
                         VA.VehicleAdjustmentNo = VAD.VehicleAdjustmentNo RIGHT OUTER JOIN
                         Vehicles ON VA.VehicleCode = Vehicles.VehicleCode LEFT OUTER JOIN
                         Invoices AS I ON I.TripAdvanceReference = VA.VehicleAdjustmentNo AND I.VehicleCode = VA.VehicleCode AND 
                         VA.VehicleAdjustmentNature = 'VP'
/*WHERE        VA.Description != 'Invoice has been Deleted'*/ UNION ALL
SELECT        '3' TYPE, 0 AS IsLocalTrip, I.TransactionNo AS InvoiceRefNo, VA.BranchCode, VAD.Description, ISNULL(VAD.VehicleAdjustmentNature, 'VP') AS TransactionNature, 
                         VAD.VehicleAdjustmentNo AS TransactionNo, VA.VehicleAdjustmentDate AS TransactionDate, ISNULL(VAD.TransactionTypeCode, '12') TransactionTypeCode, 
                         CASE VAD.VehicleAdjustmentNature WHEN 'CR' THEN VAD.Amount WHEN 'BR' THEN VAD.Amount WHEN 'AR' THEN VAD.Amount WHEN 'VR' THEN VAD.Amount ELSE
                          0 END AS AmountReceived, 
                         CASE VAD.VehicleAdjustmentNature WHEN 'FE' THEN VAD.Amount WHEN 'CP' THEN VAD.Amount WHEN 'BP' THEN VAD.Amount WHEN 'AP' THEN VAD.Amount WHEN
                          'FE' THEN VAD.Amount WHEN 'AP' THEN VAD.Amount WHEN 'VP' THEN VAD.Amount ELSE 0 END AS AmountPaid, VA.RecordNo, Vehicles.VehicleCode
FROM            VehicleAdjustments AS VA INNER JOIN
                         VehicleAdjustmentDetails AS VAD ON VA.BranchCode = VAD.BranchCode AND VA.VehicleAdjustmentNature = VAD.VehicleAdjustmentNature AND 
                         VA.VehicleAdjustmentNo = VAD.VehicleAdjustmentNo RIGHT OUTER JOIN
                         Vehicles ON VA.VehicleCode = Vehicles.VehicleCode LEFT OUTER JOIN
                         Invoices AS I ON I.TripAdvanceReference = VA.VehicleAdjustmentNo AND I.VehicleCode = VA.VehicleCode AND VA.VehicleAdjustmentNature = 'VP'
GO