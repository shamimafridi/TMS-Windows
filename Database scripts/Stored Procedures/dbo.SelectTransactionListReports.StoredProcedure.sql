USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectTransactionListReports]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectTransactionListReports]
    (
      @FromCode VARCHAR(20) = '',
      @ToCode VARCHAR(20) = '',
      @StationCode AS BIGINT = 0,
      @FromVehicleCode AS VARCHAR(10) = '0000000',
      @ToVehicleCode AS VARCHAR(10) = '99999999999',
      @FromDate DATETIME = '1/1/2000',
      @ToDate DATETIME = '12/31/9999',
      @TransactionNature AS VARCHAR(2000) = '',
      @FromTransactionNumber AS VARCHAR(20) = '0000000000',
      @ToTransactionNumber AS VARCHAR(10) = '9999999999',
      @OPTION CHAR(10) = '',
      @FromItemCode CHAR(10) = '',
      @ToItemCode CHAR(10) = '' 
    )
AS 
    SELECT  dbo.TransactionNatures.NatureCode,
            dbo.TransactionNatures.Nature,
            dbo.Branches.BranchCode,
            dbo.Branches.BranchDescription AS BranchName,
            dbo.[Vehicles ].VehicleCode,
            [Vehicles ].VehicleDescription,
            dbo.TransactionTypes.TransactionTypeCode,
            dbo.TransactionTypes.TransactionType,
            dbo.VehicleAdjustments.VehicleAdjustmentNature AS TransactionNature,
            dbo.VehicleAdjustments.VehicleAdjustmentNo AS TransactionNo,
            dbo.VehicleAdjustments.VehicleAdjustmentDate AS TransactionDate,
            dbo.VehicleAdjustments.Description,
            dbo.VehicleAdjustments.Mode,
            dbo.VehicleAdjustments.UrduTitle,
            dbo.VehicleAdjustments.ChequeNo,
            dbo.VehicleAdjustmentDetails.Amount,
            dbo.GL_GetCOACombineLedTBRptVW.GLCode,
            dbo.GL_GetCOACombineLedTBRptVW.GLRptTitle
    FROM    dbo.TransactionNatures
            LEFT OUTER JOIN dbo.GetTransactionNatures(@TransactionNature, 'IN')
            AS GetTransactionNatures_1 ON dbo.TransactionNatures.NatureCode = GetTransactionNatures_1.NatureCode
            RIGHT OUTER JOIN dbo.VehicleAdjustments
            INNER JOIN dbo.VehicleAdjustmentDetails ON dbo.VehicleAdjustments.BranchCode = dbo.VehicleAdjustmentDetails.BranchCode
                                                       AND dbo.VehicleAdjustments.VehicleAdjustmentNature = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature
                                                       AND dbo.VehicleAdjustments.VehicleAdjustmentNo = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo
            INNER JOIN dbo.TransactionTypes ON dbo.VehicleAdjustmentDetails.TransactionTypeCode = dbo.TransactionTypes.TransactionTypeCode
                                               AND dbo.VehicleAdjustmentDetails.TransactionTypeCode = dbo.TransactionTypes.TransactionTypeCode
            LEFT OUTER JOIN dbo.GL_GetCOACombineLedTBRptVW ON dbo.VehicleAdjustmentDetails.GLCode = dbo.GL_GetCOACombineLedTBRptVW.GLCode
            LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.VehicleAdjustments.VehicleCode = dbo.[Vehicles ].VehicleCode
            LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustments.BranchCode = dbo.Branches.BranchCode ON dbo.TransactionNatures.NatureCode = dbo.TransactionTypes.Nature
    WHERE   dbo.VehicleAdjustments.VehicleAdjustmentNo BETWEEN @FromCode
                                                       AND     @ToCode
            AND dbo.VehicleAdjustments.VehicleAdjustmentDate BETWEEN @FromDate
                                                             AND     @ToDate
                                                             AND
                                                             dbo.VehicleAdjustments.VehicleCode BETWEEN @FromVehicleCode AND @ToVehicleCode
    ORDER BY dbo.VehicleAdjustments.BranchCode,
            dbo.VehicleAdjustments.VehicleAdjustmentNo

GO
