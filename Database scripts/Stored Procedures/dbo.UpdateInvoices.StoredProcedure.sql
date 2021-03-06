USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateInvoices]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER  PROCEDURE [dbo].[UpdateInvoices]
    @TransactionNo VARCHAR(15) = ' ',
    @BranchCode VARCHAR(5) = ' ',
    @BranchName VARCHAR(5) = ' ',
    @CustomerCode VARCHAR(5) = ' ',
    @CustomerName VARCHAR(5) = ' ',
    @CustomerReference VARCHAR(50) = ' ',
    @VehicleCode VARCHAR(15) = ' ',
    @VehicleDescription VARCHAR(15) = ' ',
    @StationPointCode VARCHAR(15) = ' ',
    @StationPointName VARCHAR(15) = ' ',
    @DestinationPointCode VARCHAR(15) = ' ',
    @DestinationPointName VARCHAR(15) = ' ',
    @ProductCode VARCHAR(15) = ' ',
    @ProductName VARCHAR(15) = ' ',
    @TransactionDate DATETIME = ' ',
    @SupplierCode VARCHAR(10) = ' ',
    @SupplierName VARCHAR(10) = ' ',
    @Description VARCHAR(200) = '',
    @Rate DECIMAL(20, 5) = 0.00,
    @TripAdvanceReference CHAR(10) = '',
    @TripAdvance DECIMAL(20, 5) = 0.00,
    @Quantity NUMERIC(20, 5) = 0.00,
    @Amount DECIMAL(20, 5) = 0.00,
    @Commission DECIMAL(20, 5) = 0.00,
    @CommissionRate DECIMAL(2, 0) = 0,
    @ShortageQuantity DECIMAL(20, 5) = 0.00,
    @QuantityValue DECIMAL(20, 5) = 0.00,
    @Shortage DECIMAL(20, 5) = 0.00,
    @RecordNo AS BIGINT = 0,
    @GUID AS BIGINT = 0,
    @NewRecord AS BIGINT = 0,
	@LongTripRefNo as nchar(10)='',	
	@IsLocalTrip BIT = 0
AS 
    DECLARE @InvoiceNo VARCHAR(10)
    DECLARE @RefNo VARCHAR(10)
    DECLARE @AdjNo VARCHAR(10)
    DECLARE @DateValue VARCHAR(4)
   
   
      --Getting Invoice No if already exist in Vehicel Adjustment
    SELECT  @RefNo = InvoiceRefNo,
            @AdjNo = VehicleAdjustmentNo
    FROM    dbo.VehicleAdjustments
    WHERE   InvoiceRefNo = @TransactionNo
            AND BranchCode = @BranchCode
            AND VehicleAdjustmentNature = 'VP'
    IF  ISNULL(@RefNo,'') <> ''  
       
            UPDATE  dbo.VehicleAdjustments
            SET     InvoiceRefNo = ''
            WHERE   VehicleAdjustmentNo = @AdjNo
                    AND BranchCode = @BranchCode
                    AND VehicleAdjustmentNature = 'VP'
   
     
    
    UPDATE  dbo.VehicleAdjustments
    SET     InvoiceRefNo = @TransactionNo
    WHERE   VehicleAdjustmentNo = @TripAdvanceReference
            AND BranchCode = @BranchCode
            AND VehicleAdjustmentNature = 'VP'
    
  --(Invoice)	
    IF @NewRecord = 1 
        BEGIN

            SET @DateValue = dbo.DateToKey(@TransactionDate) 
            SELECT TOP 1
                    @InvoiceNo = TransactionNo
            FROM    dbo.Invoices
            WHERE   ( BranchCode = @BranchCode )
                    AND ( LEFT(TransactionNo, 4) = @DateValue )
            ORDER BY TransactionNo DESC
            SET @InvoiceNo = dbo.KeyValue(@DateValue, @InvoiceNo)
            SELECT  @InvoiceNo AS TransactionNo


            INSERT  INTO Invoices
                    (
                      BranchCode,
                      TransactionNo,
                      TransactionDate,
                      PartyCode,
                      VehicleCode,
                      StationPointCode,
                      DestinationPointCode,
                      ProductCode,
                      CustomerReference,
                      Description,
                      Rate,
                      Quantity,
                      Amount,
                      TripAdvanceReference,
                      TripAdvance,
                      Commission,
                      CommissionRate,
                      Shortage,
                      QuantityValue,
                      ShortageQuantity,
                      GUID,
					  IsLocalTrip,
					  LongTripRefNo
					          
                    )
            VALUES  (
                      @BranchCode,
                      @TransactionNo,
                      @TransactionDate,
                      @CustomerCode,
                      @VehicleCode,
                      @StationPointCode,
                      @DestinationPointCode,
                      @ProductCode,
                      @CustomerReference,
                      @Description,
                      @Rate,
                      @Quantity,
                      @Amount,
                      @TripAdvanceReference,
                      @TripAdvance,
                      @Commission,
                      @CommissionRate,
                      @Shortage,
                      @QuantityValue,
                      @ShortageQuantity,
                      @GUID,
                      @IsLocalTrip  ,					  
					  @LongTripRefNo
					  
                    ) 

        END
    ELSE 
        BEGIN
            SELECT  @TransactionNo AS TransactionNo
            UPDATE  Invoices
            SET     TransactionNo = @TransactionNo,
                    TransactionDate = @TransactionDate,
                    PartyCode = @CustomerCode,
                    VehicleCode = @VehicleCode,
                    StationPointCode = @StationPointCode,
                    DestinationPointCode = @DestinationPointCode,
                    ProductCode = @ProductCode,
                    TripAdvanceReference = @TripAdvanceReference,
                    TripAdvance = @TripAdvance,
                    Quantity = @Quantity,
					Description=@Description,
                    CustomerReference = @CustomerReference,
                    Amount = @Amount,
                    Rate = @Rate,
                    Commission = @Commission,
                    CommissionRate=@CommissionRate,
                    Shortage = @Shortage,
                    QuantityValue = @QuantityValue,
                    ShortageQuantity = @ShortageQuantity,
					IsLocalTrip = @IsLocalTrip,					
					LongTripRefNo=@LongTripRefNo
				
		--	Narration=@Narration
            WHERE   ( TransactionNo = @TransactionNo
                      AND BranchCode = @BranchCode
                    )
                   

        END

GO
