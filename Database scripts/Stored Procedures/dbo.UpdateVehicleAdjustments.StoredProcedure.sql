USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateVehicleAdjustments]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateVehicleAdjustments]
    @BranchCode CHAR(2) = '',
    @TransactionNature CHAR(2) = '',
    @BranchName CHAR(2) = '',
    @TransactionNo VARCHAR(15) = ' ',
    @VehicleCode CHAR(15) = ' ',
    @Mode CHAR(15) = ' ',
    @VehicleDescription CHAR(15) = ' ',
    @ChequeNo VARCHAR(15) = ' ',
    @UrduTitle NVARCHAR(500) = ' ',
    @TransactionDate DATETIME = ' ',
    @Description VARCHAR(200) = '',
    @Locked TINYINT = 0,
    @Posted TINYINT = 0,
    @GUID AS INTEGER = 0,
    @NewRecord AS BIGINT = 0
AS 
    DECLARE @VehicleAdjustmentNo VARCHAR(10)
    DECLARE @DateValue VARCHAR(4)



    IF @NewRecord = 1 
        BEGIN
            SET @DateValue = dbo.DateToKey(@TransactionDate) 
            SELECT TOP 1
                    @VehicleAdjustmentNo = VehicleAdjustmentNo
            FROM    dbo.VehicleAdjustments
            WHERE   ( BranchCode = @BranchCode )
                    AND ( VehicleAdjustmentNature = @TransactionNature )
                    AND ( LEFT(VehicleAdjustmentNo, 4) = @DateValue )
            ORDER BY VehicleAdjustmentNo DESC
            SET @VehicleAdjustmentNo = dbo.KeyValue(@DateValue,
                                                    @VehicleAdjustmentNo)
            SELECT  @VehicleAdjustmentNo AS TransactionNo

            INSERT  INTO VehicleAdjustments
                    (
                      BranchCode,
                      VehicleAdjustmentNature,
                      VehicleAdjustmentNo,
                      VehicleAdjustmentDate,
                      Description,
                      Mode,
                      VehicleCode,
                      ChequeNo,
                      UrduTitle,
                      GUID
                    )
            VALUES  (
                      @BranchCode,
                      @TransactionNature,
                      @VehicleAdjustmentNo,
                      @TransactionDate,
                      @Description,
                      @Mode,
                      @VehicleCode,
                      @ChequeNo,
                      @UrduTitle,
                      @GUID
                    ) 
        END
    ELSE 
        BEGIN
            SELECT  @TransactionNo AS TransactionNo
            UPDATE  VehicleAdjustments
            SET     VehicleAdjustmentNature = @TransactionNature,
                    VehicleAdjustmentNo = @TransactionNo,
                    UrduTitle = @UrduTitle,
                    VehicleCode = @VehicleCode,
                    Mode = @Mode,
                    VehicleAdjustmentDate = @TransactionDate,
                    ChequeNo = @ChequeNo,
                    Description = @Description
            WHERE   ( VehicleAdjustmentNature = @TransactionNature
                      AND VehicleAdjustmentNo = @TransactionNo
                      AND BranchCode = @BranchCode
                    )
		
        END

GO
