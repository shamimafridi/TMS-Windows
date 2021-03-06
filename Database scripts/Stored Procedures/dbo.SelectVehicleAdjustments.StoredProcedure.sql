USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleAdjustments]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec SelectVehicleAdjustments @VehicleCode = N'PP-0226', @BranchCode = N'01', @TransactionDate = 'Nov  6 2009 12:00AM', @TransactionTypeCode = N'01', @TransactionNo = N'0911000001', @OPTION = N'FILTER_ADVANCE_WithNo'


CREATE  PROCEDURE [dbo].[SelectVehicleAdjustments]
    @Option AS VARCHAR(40) = '',
    @BranchCode AS CHAR(10) = '',
    @TransactionNo AS CHAR(10) = '',
    @TransactionNature AS CHAR(3) = '',
    @TransactionDate AS DATETIME = '',
    @Nature AS CHAR(3) = '',
    @VehicleCode AS CHAR(10) = '',
    @InvoiceNo AS VARCHAR(10) = '',
    @FromDate AS DATETIME = '',
    @ToDate AS DATETIME = '',
    @TransactionTypeCode CHAR(2) = '',
    @YearMonth AS VARCHAR(4) = ''
AS 
    IF @Option = 'ALL' 
        SELECT  dbo.VehicleAdjustments.VehicleAdjustmentNature AS TransactionNature,
                dbo.VehicleAdjustments.VehicleAdjustmentNo AS TransactionNo,
                dbo.VehicleAdjustments.VehicleAdjustmentDate AS TransactionDate,
                dbo.VehicleAdjustments.Description,
                dbo.VehicleAdjustments.UrduTitle,
                dbo.VehicleAdjustments.Locked,
                dbo.VehicleAdjustments.Posted,
                dbo.VehicleAdjustments.RecordNo,
                dbo.VehicleAdjustments.GUID,
                dbo.VehicleAdjustments.BranchCode,
                dbo.Branches.BranchDescription AS BranchName,
                dbo.[Vehicles ].VehicleCode,
                dbo.[Vehicles ].VehicleDescription,
                dbo.VehicleAdjustments.ChequeNo,
                dbo.VehicleAdjustments.Mode
        FROM    dbo.VehicleAdjustments
                LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.VehicleAdjustments.VehicleCode = dbo.[Vehicles ].VehicleCode
                LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustments.BranchCode = dbo.Branches.BranchCode
        WHERE   dbo.VehicleAdjustments.VehicleAdjustmentNature = @TransactionNature
        ORDER BY dbo.VehicleAdjustments.BranchCode,
                dbo.VehicleAdjustments.VehicleAdjustmentNature,
                dbo.VehicleAdjustments.VehicleAdjustmentNo 
    ELSE 
        IF @Option = 'DateFilter' 
            SELECT  dbo.VehicleAdjustments.VehicleAdjustmentNature AS TransactionNature,
                    dbo.VehicleAdjustments.VehicleAdjustmentNo AS TransactionNo,
                    dbo.VehicleAdjustments.VehicleAdjustmentDate AS TransactionDate,
                    dbo.VehicleAdjustments.Description,
                    dbo.VehicleAdjustments.UrduTitle,
                    dbo.VehicleAdjustments.Locked,
                    dbo.VehicleAdjustments.Posted,
                    dbo.VehicleAdjustments.RecordNo,
                    dbo.VehicleAdjustments.GUID,
                    dbo.VehicleAdjustments.BranchCode,
                    dbo.Branches.BranchDescription AS BranchName,
                    dbo.[Vehicles ].VehicleCode,
                    dbo.[Vehicles ].VehicleDescription,
                    dbo.VehicleAdjustments.ChequeNo,
                    dbo.VehicleAdjustments.Mode
            FROM    dbo.VehicleAdjustments
                    LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.VehicleAdjustments.VehicleCode = dbo.[Vehicles ].VehicleCode
                    LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustments.BranchCode = dbo.Branches.BranchCode
            WHERE   dbo.VehicleAdjustments.VehicleAdjustmentNature = @TransactionNature
                    AND dbo.VehicleAdjustments.VehicleAdjustmentDate BETWEEN @fromDate
                                                                     AND     @ToDate
            ORDER BY dbo.VehicleAdjustments.BranchCode,
                    dbo.VehicleAdjustments.VehicleAdjustmentNature,
                    dbo.VehicleAdjustments.VehicleAdjustmentNo 
        ELSE 
            IF @option = 'FILTER_ADVANCE'
			 SELECT        [Vehicles ].VehicleCode, Branches.BranchCode, Branches.BranchDescription AS BranchName, 0 AS Amount, VehicleAdjustments.VehicleAdjustmentNo, VehicleAdjustments.VehicleAdjustmentDate, 
                         VehicleAdjustments.VehicleAdjustmentNature
			FROM            VehicleAdjustments LEFT OUTER JOIN
                         [Vehicles ] ON VehicleAdjustments.VehicleCode = [Vehicles ].VehicleCode LEFT OUTER JOIN
                         Branches ON VehicleAdjustments.BranchCode = Branches.BranchCode
                WHERE   ( dbo.[Vehicles ].VehicleCode = @VehicleCode
                         -- AND dbo.VehicleAdjustmentDetails.TransactionTypeCode = @TransactionTypeCode
                          AND dbo.VehicleAdjustments.BranchCode = @BranchCode
						  AND  ISNULL( dbo.VehicleAdjustments.InvoiceRefNo,'') =''
                         -- AND dbo.VehicleAdjustments.VehicleAdjustmentDate <= @TransactionDate
                         -- AND DBO.VehicleAdjustmentDetails.InvoiceRefNo = ''
                          
                        )
                        --true when new record
                        AND NOT (
                        --FALSE when edit
                                  DBO.VehicleAdjustments.InvoiceRefNo <> @InvoiceNo
                                      AND ISNULL(dbo.VehicleAdjustments.InvoiceRefNo,'') <> ''                       
                                )
    IF @option = 'FILTER_ADVANCE_WithNo' 
        SELECT        [Vehicles ].VehicleCode, Branches.BranchCode, Branches.BranchDescription AS BranchName, VehicleAdjustments.VehicleAdjustmentNature, VehicleAdjustments.VehicleAdjustmentNo, 
                         VehicleAdjustments.VehicleAdjustmentDate, 0 AS Amount
FROM            VehicleAdjustments LEFT OUTER JOIN
                         [Vehicles ] ON VehicleAdjustments.VehicleCode = [Vehicles ].VehicleCode LEFT OUTER JOIN
                         Branches ON VehicleAdjustments.BranchCode = Branches.BranchCode
						 WHERE   dbo.[Vehicles ].VehicleCode = @VehicleCode
               -- AND dbo.VehicleAdjustmentDetails.TransactionTypeCode = @TransactionTypeCode
                AND dbo.VehicleAdjustments.BranchCode = @BranchCode
                --AND dbo.VehicleAdjustments.VehicleAdjustmentDate <= @TransactionDate
                AND dbo.VehicleAdjustments.VehicleAdjustmentNo = @TransactionNo
                AND ISNULL( DBO.VehicleAdjustments.InvoiceRefNo,'') = ''
                AND NOT (
                        --FALSE when edit
                          dbo.VehicleAdjustments.InvoiceRefNo <> @InvoiceNo
                          AND  ISNULL(dbo.VehicleAdjustments.InvoiceRefNo,'') <> ''                        )
    ELSE 
        IF @Option = 'AUTO' 
            SELECT TOP 1
                    VehicleAdjustmentNo AS TransactionNo
            FROM    dbo.VehicleAdjustments
            WHERE   ( SUBSTRING(CAST(VehicleAdjustmentNo AS VARCHAR(4)), 1, 4) = @YearMonth )
                    AND VehicleAdjustmentNature = @TransactionNature
                    AND BranchCode = @BranchCode
            ORDER BY VehicleAdjustmentNo DESC
        ELSE 
            IF @Option = 'REPORT' 
                SELECT  dbo.VehicleAdjustments.VehicleAdjustmentNature,
                        dbo.VehicleAdjustments.VehicleAdjustmentNo,
                        dbo.VehicleAdjustments.VehicleAdjustmentDate,
                        dbo.VehicleAdjustments.Description,
                        dbo.VehicleAdjustmentDetails.UrduDescription,
                        dbo.VehicleAdjustmentDetails.Amount,
                        dbo.Branches.BranchCode,
                        dbo.Branches.BranchDescription,
                        dbo.Divisions.DivisionCode,
                        dbo.Divisions.Division,
                        dbo.GL_GetCOACombineTransactionVW.GLCode,
                        dbo.VehicleAdjustments.Mode,
                        dbo.GL_GetCOACombineTransactionVW.GLDescription,
                        dbo.[Vehicles ].VehicleCode,
                        dbo.[Vehicles ].VehicleDescription,
                        dbo.VehicleAdjustments.ChequeNo
                FROM    dbo.VehicleAdjustmentDetails
                        INNER JOIN dbo.VehicleAdjustments ON dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo = dbo.VehicleAdjustments.VehicleAdjustmentNo
                                                             AND dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature = dbo.VehicleAdjustments.VehicleAdjustmentNature
                        LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.VehicleAdjustments.VehicleCode = dbo.[Vehicles ].VehicleCode
                        LEFT OUTER JOIN dbo.GL_GetCOACombineTransactionVW ON dbo.VehicleAdjustmentDetails.GLCode = dbo.GL_GetCOACombineTransactionVW.GLCode
                        LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustments.BranchCode = dbo.Branches.BranchCode
                        LEFT OUTER JOIN dbo.Divisions ON dbo.VehicleAdjustmentDetails.DivisionCode = dbo.Divisions.DivisionCode
                WHERE   dbo.VehicleAdjustments.VehicleAdjustmentNature = @TransactionNature
                        AND dbo.VehicleAdjustments.VehicleAdjustmentNo = @TransactionNo
                ORDER BY dbo.VehicleAdjustments.BranchCode,
                        dbo.VehicleAdjustments.VehicleAdjustmentNature,
                        dbo.VehicleAdjustments.VehicleAdjustmentNo 
            ELSE 
                SELECT  dbo.VehicleAdjustments.VehicleAdjustmentNature AS TransactionNature,
                        dbo.VehicleAdjustments.VehicleAdjustmentNo AS TransactionNo,
                        dbo.VehicleAdjustments.VehicleAdjustmentDate AS TransactionDate,
                        dbo.VehicleAdjustments.Description,
                        dbo.VehicleAdjustments.UrduTitle,
                        dbo.VehicleAdjustments.Locked,
                        dbo.VehicleAdjustments.Posted,
                        dbo.VehicleAdjustments.RecordNo,
                        dbo.VehicleAdjustments.GUID,
                        dbo.VehicleAdjustments.BranchCode,
                        dbo.Branches.BranchDescription AS BranchName,
                        dbo.VehicleAdjustments.ChequeNo,
                        dbo.VehicleAdjustments.Mode,
                        dbo.[Vehicles ].VehicleCode,
                        dbo.[Vehicles ].VehicleDescription,
                        dbo.VehicleAdjustments.Mode
                FROM    dbo.VehicleAdjustments
                        LEFT OUTER JOIN dbo.[Vehicles ] ON dbo.VehicleAdjustments.VehicleCode = dbo.[Vehicles ].VehicleCode
                        LEFT OUTER JOIN dbo.Branches ON dbo.VehicleAdjustments.BranchCode = dbo.Branches.BranchCode
                WHERE   dbo.VehicleAdjustments.VehicleAdjustmentNature = @TransactionNature
                        AND VehicleAdjustments.VehicleAdjustmentNo = @TransactionNo
                        AND VehicleAdjustments.BranchCode = @BranchCode

GO
