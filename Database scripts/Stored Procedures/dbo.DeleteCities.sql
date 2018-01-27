USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCities]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteCities]
@CityCode nchar(5)=''
AS
	IF @CityCode <> ''
		DELETE FROM Cities 
		WHERE ( CityCode= @CityCode)

GO
