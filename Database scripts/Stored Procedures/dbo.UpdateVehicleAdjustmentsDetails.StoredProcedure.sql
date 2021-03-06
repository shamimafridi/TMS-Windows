USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateVehicleAdjustmentsDetails]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
ALTER PROCEDURE [dbo].[UpdateVehicleAdjustmentsDetails]

@TransactionNature char(2) = ''  ,
@BranchCode char(2) = ''  ,
@TransactionNo varchar(16)=' '  ,
@GLCode  varchar(50)=' '  ,
@GLDescription  varchar(50)=' '  ,
@Amount decimal(20,5)=0.00,
@TypeCode char(5) = '' ,
@Type char(5) = '' ,

@Description varchar(2000) = '' ,
@DivisionCode char(5) = '' ,
@Division varchar(5) = '',
@Mode  varchar(100) = '',
@UrduDescription  nvarchar(200) = '',
@NewRecord as bigint=0
 AS 
if @DivisionCode =''
begin
set @DivisionCode ='001'
end
	


	IF @NewRecord = 1 
	     BEGIN
	
		INSERT INTO VehicleAdjustmentDetails (BranchCode, VehicleAdjustmentNature ,VehicleAdjustmentNo, TransactionTypeCode,  GLCode,  DivisionCode,Amount  , UrduDescription,Description) 
		              VALUES  (@BranchCode, @TransactionNature ,@TransactionNo , @TypeCode,   @GLCode ,@DivisionCode , @Amount,  @UrduDescription,@Description) 
	
	     END
/*
	ELSE 
	     BEGIN
		UPDATE VehicleAdjustmentDetails
		Set  
			GLCode=@GLCode,
			Debit=@Debit,
			Credit=@Credit,
			Particuler=@Particuler
		WHERE  ( VehicleAdjustmentNature = @VehicleAdjustmentNature AND DocumentNo=@DocumentNo ) 
 	     END*/

GO
