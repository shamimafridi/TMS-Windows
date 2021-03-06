USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleAdjustmentsDetails]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SelectVehicleAdjustmentsDetails]
    @Option AS VARCHAR(300) = '',
    @TransactionNo AS VARCHAR(10) = '',
    @TransactionNature AS VARCHAR(3) = '',
    @BranchCode AS VARCHAR(10) = '',
    @FromDate AS DATETIME = '',
    @ToDate AS DATETIME = ''
AS 
    IF @Option = 'ALL' 
        SELECT  dbo.VehicleAdjustmentDetails.BranchCode,
                dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature AS TransactionNature,
                dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo AS TransactionNo,
                dbo.VehicleAdjustmentDetails.GLCode,
                dbo.GL_GetCOACombineVW.GLDescription,
                dbo.VehicleAdjustmentDetails.DivisionCode,
				dbo.VehicleAdjustmentDetails.Description,
                dbo.Divisions.Division,
                dbo.TransactionTypes.TransactionTypeCode AS TypeCode,
                dbo.TransactionTypes.TransactionType AS Type,
                dbo.VehicleAdjustmentDetails.Amount,
                dbo.VehicleAdjustmentDetails.UrduDescription
        FROM    dbo.VehicleAdjustmentDetails
                LEFT OUTER JOIN dbo.TransactionTypes ON dbo.VehicleAdjustmentDetails.TransactionTypeCode = dbo.TransactionTypes.TransactionTypeCode
                LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustmentDetails.BranchCode = dbo.Branches.BranchCode
                LEFT OUTER JOIN dbo.Divisions ON dbo.VehicleAdjustmentDetails.DivisionCode = dbo.Divisions.DivisionCode
                LEFT OUTER JOIN dbo.GL_GetCOACombineVW ON dbo.VehicleAdjustmentDetails.GLCode = dbo.GL_GetCOACombineVW.GLCode
    ELSE 
        IF @Option = 'DateFilter' 
            SELECT  VehicleAdjustmentDetails.BranchCode,
                    VehicleAdjustmentDetails.VehicleAdjustmentNature AS TransactionNature,
                    VehicleAdjustmentDetails.VehicleAdjustmentNo AS TransactionNo,
                    VehicleAdjustmentDetails.GLCode,
                    GL_GetCOACombineVW.GLDescription,
                    dbo.VehicleAdjustmentDetails.Description,
				    VehicleAdjustmentDetails.DivisionCode,
                    Divisions.Division,
                    TransactionTypes.TransactionTypeCode AS TypeCode,
                    TransactionTypes.TransactionType AS Type,
                    VehicleAdjustmentDetails.Amount,
                    VehicleAdjustmentDetails.UrduDescription
            FROM    VehicleAdjustmentDetails
                    INNER JOIN VehicleAdjustments ON VehicleAdjustmentDetails.BranchCode = VehicleAdjustments.BranchCode
                                                     AND VehicleAdjustmentDetails.VehicleAdjustmentNature = VehicleAdjustments.VehicleAdjustmentNature
                                                     AND VehicleAdjustmentDetails.VehicleAdjustmentNo = VehicleAdjustments.VehicleAdjustmentNo
                    LEFT OUTER JOIN Branches ON VehicleAdjustmentDetails.BranchCode = Branches.BranchCode
                    LEFT OUTER JOIN TransactionTypes ON VehicleAdjustmentDetails.TransactionTypeCode = TransactionTypes.TransactionTypeCode
                    LEFT OUTER JOIN Divisions ON VehicleAdjustmentDetails.DivisionCode = Divisions.DivisionCode
                    LEFT OUTER JOIN GL_GetCOACombineVW ON VehicleAdjustmentDetails.GLCode = GL_GetCOACombineVW.GLCode
            WHERE   dbo.VehicleAdjustments.VehicleAdjustmentDate BETWEEN @FromDate
                                                                 AND     @ToDate
                    AND dbo.VehicleAdjustments.VehicleAdjustmentNature = @TransactionNature
            ORDER BY dbo.VehicleAdjustments.RecordNo,
                    dbo.VehicleAdjustments.VehicleAdjustmentNature,
                    dbo.VehicleAdjustments.BranchCode,
                    dbo.VehicleAdjustments.VehicleAdjustmentNo
        ELSE 
            SELECT  dbo.VehicleAdjustmentDetails.BranchCode,
                    dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature AS TransactionNature,
                    dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo AS TransactionNo,
                    dbo.VehicleAdjustmentDetails.GLCode,
                    dbo.GL_GetCOACombineVW.GLDescription,
                    dbo.VehicleAdjustmentDetails.DivisionCode,
                    dbo.VehicleAdjustmentDetails.Description,
					dbo.Divisions.Division,
                    dbo.TransactionTypes.TransactionTypeCode AS TypeCode,
                    dbo.TransactionTypes.TransactionType AS Type,
                    dbo.VehicleAdjustmentDetails.Amount,
                    dbo.VehicleAdjustmentDetails.UrduDescription
            FROM    dbo.VehicleAdjustmentDetails
                    LEFT OUTER JOIN dbo.TransactionTypes ON dbo.VehicleAdjustmentDetails.TransactionTypeCode = dbo.TransactionTypes.TransactionTypeCode
                    LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustmentDetails.BranchCode = dbo.Branches.BranchCode
                    LEFT OUTER JOIN dbo.Divisions ON dbo.VehicleAdjustmentDetails.DivisionCode = dbo.Divisions.DivisionCode
                    LEFT OUTER JOIN dbo.GL_GetCOACombineVW ON dbo.VehicleAdjustmentDetails.GLCode = dbo.GL_GetCOACombineVW.GLCode
            WHERE   VehicleAdjustmentNo = @TransactionNo
                    AND VehicleAdjustmentNature = @TransactionNature
                    AND VehicleAdjustmentDetails.BranchCode = @BranchCode

GO
