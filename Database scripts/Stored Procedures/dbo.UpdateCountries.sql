USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCountries]    Script Date: 27-Jan-18 11:24:03 AM ******/
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
