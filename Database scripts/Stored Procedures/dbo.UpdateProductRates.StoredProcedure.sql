USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateProductRates]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateProductRates]
@ProductCode char(3) = ''  ,
@ProductName char(3) = ''  ,
@StationPointCode varchar(3)='',
@StationPointDescription varchar(3)='',
@DestinationPointDescription varchar(3)='',
@DestinationPointCode varchar(3)='',
@EffectiveDate Datetime='',
@Rate as decimal(20,5)=0.00,
@TripAdvanceAmount as Decimal(18,5)=0.00,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO ProductRates(ProductCode, StationPointCode, DestinationPointCode, EffectiveDate, Rate, TripAdvanceAmount) 
				VALUES  ( @ProductCode, @StationPointCode,@DestinationPointCode ,@EffectiveDate,@Rate ,@TripAdvanceAmount )
	     END
	ELSE 
	     BEGIN
		UPDATE ProductRates
		SET ProductCode=@ProductCode,
		StationPointCode=@StationPointCode,
		DestinationPointCode=@DestinationPointCode,
		EffectiveDate=@EffectiveDate,
		Rate=@Rate,
		TripAdvanceAmount=@TripAdvanceAmount

		WHERE  ( ProductCode = @ProductCode  )	AND
			EffectiveDate=@EffectiveDate	AND 
			StationPointCode=@StationPointCode	AND 
			DestinationPointCode=@DestinationPointCode



 	     END

GO
