USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCountries]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCountries]
@CountryCode char(3) = ''  ,
@ItemGroupCode char(4),
@Country varchar(10),
@ItemGroup varchar(10),
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Country(CountryCode, Country) 
		VALUES  ( @CountryCode, @Country ) 
	     END
	ELSE 
	     BEGIN
		UPDATE Country
		SET CountryCode=@CountryCode,
		Country = @Country
		WHERE  ( CountryCode = @CountryCode  )
 	     END

GO
