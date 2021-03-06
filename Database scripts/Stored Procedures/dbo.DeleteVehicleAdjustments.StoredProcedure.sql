USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteVehicleAdjustments]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[DeleteVehicleAdjustments]
    @Option AS VARCHAR(3) = '',
    @BranchCode AS VARCHAR(3) = '',
    @TransactionNo AS VARCHAR(10) = '',
    @TransactionNature AS VARCHAR(3) = ''
AS 
    DECLARE @RefNo AS CHAR(10)
    

    SELECT TOP 1
            @RefNo = ISNULL( TripAdvanceReference,'')
    FROM    dbo.Invoices
    WHERE   BranchCode = @BranchCode
            AND TripAdvanceReference = @TransactionNo AND @TransactionNature='VP'
	
    IF  ISNULL(@RefNo,'') <> '' 
        BEGIN
            
            RAISERROR ( 'The Adjustment Code is exist already in some Invoices therefor can not deleted',
                16, 1, '', '', '' )

            RETURN ( 99 )	
             
        END
    ELSE 
        BEGIN 
            BEGIN TRANSACTION
            DELETE  FROM VehicleAdjustmentDetails
            
            WHERE   VehicleAdjustmentNo = @TransactionNo
                    AND VehicleAdjustmentNature = @TransactionNature
                    AND BranchCode = @BranchCode
                    
                    
            --DELETE  FROM VehicleAdjustments
            UPDATE dbo.VehicleAdjustments
            SET
            Description='This Document has been Deleted',
            UrduTitle=''
            
            WHERE   VehicleAdjustmentNo = @TransactionNo
                    AND VehicleAdjustmentNature = @TransactionNature
                    AND BranchCode = @BranchCode
            COMMIT TRANSACTION
        END

    

    IF @@error > 0 
        ROLLBACK TRANSACTION

GO
