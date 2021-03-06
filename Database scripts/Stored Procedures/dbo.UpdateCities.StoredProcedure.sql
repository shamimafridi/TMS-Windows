USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCities]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCities]
@CityCode char(3) = ''  ,
@City varchar(100),
@UrduTitle nvarchar(200)='',
@DefinitionDate Datetime='',
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Cities(CityCode, City, UrduTitle, DefinitionDate) 
		VALUES  ( @CityCode, @City,@UrduTitle ,@DefinitionDate) 
	     END
	ELSE 
	     BEGIN
		UPDATE Cities
		SET CityCode=@CityCode,
		UrduTitle=@UrduTitle,
		DefinitionDate=@DefinitionDate,
		City = @City
		WHERE  ( CityCode = @CityCode  )
 	     END

GO
