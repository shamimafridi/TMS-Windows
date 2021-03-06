USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateProductValues]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateProductValues]
@ProductCode char(3) = ''  ,
@ProductName char(3) = ''  ,
@EffectiveDate Datetime='',
@QuantityValue as decimal(20,5)=0.00,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO ProductValues(ProductCode, EffectiveDate, QuantityValue ) 
				VALUES  ( @ProductCode, @EffectiveDate,@QuantityValue )
	     END
	ELSE 
	     BEGIN
		UPDATE ProductValues
		SET ProductCode=@ProductCode,
		EffectiveDate=@EffectiveDate,
		QuantityValue=@QuantityValue
		
		WHERE  ( ProductCode = @ProductCode  )	AND
			EffectiveDate=@EffectiveDate	



 	     END

GO
