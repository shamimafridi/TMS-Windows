USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCities]    Script Date: 03-Feb-18 9:47:12 PM ******/
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
