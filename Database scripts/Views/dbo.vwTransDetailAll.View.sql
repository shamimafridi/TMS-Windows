USE [TMS_ALI]
GO
/****** Object:  View [dbo].[vwTransDetailAll]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwTransDetailAll]
AS
SELECT        '1' TYPE, I.IsLocalTrip, '' InvoiceRefNo, I.BranchCode, I.Description, 'VP' AS TransactionNature, I.TransactionNo, I.TransactionDate, '12' TransactionTypeCode, Amount AmountReceived, 0 AS AmountPaid, I.RecordNo, 
                         V.VehicleCode
FROM            dbo.Vehicles V LEFT JOIN
                         dbo.Invoices I ON I.VehicleCode = V.VehicleCode
UNION
SELECT        '2' TYPE, 0 AS IsLocalTrip, I.TransactionNo AS InvoiceRefNo, VA.BranchCode, VA.Description, ISNULL(VAD.VehicleAdjustmentNature, 'VP') AS TransactionNature, VAD.VehicleAdjustmentNo AS TransactionNo, 
                         VA.VehicleAdjustmentDate AS TransactionDate, ISNULL(VAD.TransactionTypeCode, '12') TransactionTypeCode, 
                         CASE VAD.VehicleAdjustmentNature WHEN 'CR' THEN VAD.Amount WHEN 'BR' THEN VAD.Amount WHEN 'AR' THEN VAD.Amount WHEN 'VR' THEN VAD.Amount ELSE 0 END AS AmountReceived, 
                         CASE VAD.VehicleAdjustmentNature  WHEN 'FE' THEN VAD.Amount  WHEN 'CP' THEN VAD.Amount WHEN 'BP' THEN VAD.Amount WHEN 'AP' THEN VAD.Amount WHEN 'VP' THEN VAD.Amount ELSE 0 END AS AmountPaid, VA.RecordNo, 
                         Vehicles.VehicleCode
FROM            VehicleAdjustments AS VA INNER JOIN
                         VehicleAdjustmentDetails AS VAD ON VA.BranchCode = VAD.BranchCode AND VA.VehicleAdjustmentNature = VAD.VehicleAdjustmentNature AND VA.VehicleAdjustmentNo = VAD.VehicleAdjustmentNo RIGHT OUTER JOIN
                         Vehicles ON VA.VehicleCode = Vehicles.VehicleCode LEFT OUTER JOIN
                         Invoices AS I ON I.TripAdvanceReference = VA.VehicleAdjustmentNo AND I.VehicleCode = VA.VehicleCode AND VA.VehicleAdjustmentNature='VP'
						 
UNION
SELECT        '3' TYPE, 0 AS IsLocalTrip, I.TransactionNo AS InvoiceRefNo, VA.BranchCode, VA.Description, ISNULL(VAD.VehicleAdjustmentNature, 'VP') AS TransactionNature, VAD.VehicleAdjustmentNo AS TransactionNo, 
                         VA.VehicleAdjustmentDate AS TransactionDate, ISNULL(VAD.TransactionTypeCode, '12') TransactionTypeCode, 
                         CASE VAD.VehicleAdjustmentNature WHEN 'CR' THEN VAD.Amount WHEN 'BR' THEN VAD.Amount WHEN 'AR' THEN VAD.Amount WHEN 'VR' THEN VAD.Amount ELSE 0 END AS AmountReceived, 
                         CASE VAD.VehicleAdjustmentNature  WHEN 'FE' THEN VAD.Amount WHEN 'CP' THEN VAD.Amount WHEN 'BP' THEN VAD.Amount WHEN 'AP' THEN VAD.Amount WHEN 'FE' THEN VAD.Amount WHEN 'AP' THEN VAD.Amount WHEN 'VP' THEN VAD.Amount ELSE 0
                          END AS AmountPaid, VA.RecordNo, Vehicles.VehicleCode
FROM            VehicleAdjustments AS VA INNER JOIN
                         VehicleAdjustmentDetails AS VAD ON VA.BranchCode = VAD.BranchCode AND VA.VehicleAdjustmentNature = VAD.VehicleAdjustmentNature AND VA.VehicleAdjustmentNo = VAD.VehicleAdjustmentNo RIGHT OUTER JOIN
                         Vehicles ON VA.VehicleCode = Vehicles.VehicleCode LEFT OUTER JOIN
                         Invoices AS I ON I.TripAdvanceReference = VA.VehicleAdjustmentNo AND I.VehicleCode = VA.VehicleCode AND VA.VehicleAdjustmentNature='VP'

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[8] 4[4] 2[76] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 14
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTransDetailAll'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTransDetailAll'
GO
