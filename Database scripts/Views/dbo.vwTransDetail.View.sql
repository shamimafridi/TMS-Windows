USE [TMS_ALI]
GO
/****** Object:  View [dbo].[vwTransDetail]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vwTransDetail]
AS
SELECT        0 IsLocalTrip, I.TransactionNo InvoiceRefNo, 'ADJ' TYPE, VA.BranchCode, VA.Description, VAD.VehicleAdjustmentNature AS TransactionNature, VAD.VehicleAdjustmentNo AS TransactionNo, 
                         VA.VehicleAdjustmentDate AS TransactionDate, VAD.TransactionTypeCode, 
                         CASE VAD.VehicleAdjustmentNature WHEN 'CR' THEN VAD.Amount WHEN 'BR' THEN VAD.Amount WHEN 'AR' THEN VAD.Amount WHEN 'VR' THEN VAD.Amount ELSE 0 END AS AmountReceived, 
                         CASE VAD.VehicleAdjustmentNature WHEN 'FE' THEN VAD.Amount   WHEN 'CP' THEN VAD.Amount WHEN 'BP' THEN VAD.Amount WHEN 'AP' THEN VAD.Amount WHEN 'VP' THEN VAD.Amount ELSE 0 END AS AmountPaid, VA.RecordNo, VA.VehicleCode
FROM            dbo.VehicleAdjustments AS VA INNER JOIN
                         dbo.VehicleAdjustmentDetails AS VAD ON VA.BranchCode = VAD.BranchCode AND VA.VehicleAdjustmentNature = VAD.VehicleAdjustmentNature AND VA.VehicleAdjustmentNo = VAD.VehicleAdjustmentNo LEFT OUTER JOIN
                         dbo.Invoices I ON I.TripAdvanceReference = VA.VehicleAdjustmentNo AND I.VehicleCode = VA.VehicleCode
WHERE        VAD.Amount <> 0
UNION
SELECT        I.IsLocalTrip, '' InvoiceRefNo, 'INV' TYPE, I.BranchCode, I.Description, 'VR' AS TransactionNature, I.TransactionNo, I.TransactionDate, '12', Amount AmountReceived, 0 AS AmountPaid, I.RecordNo, I.VehicleCode
FROM            dbo.Invoices I
WHERE        AMOUNT <> 0
UNION
SELECT        I.IsLocalTrip, I.TransactionNo InvoiceRefNo, 'Shortage' TYPE, I.BranchCode, I.Description, 'VP' AS TransactionNature, I.TransactionNo, I.TransactionDate, '12', - Shortage AS AmountReceived, 0 AS AmountPaid, I.RecordNo, 
                         I.VehicleCode
FROM            dbo.Invoices I
WHERE        Shortage <> 0

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[31] 4[4] 2[57] 3) )"
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
      Begin ColumnWidths = 12
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3405
         Alias = 1710
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTransDetail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vwTransDetail'
GO
