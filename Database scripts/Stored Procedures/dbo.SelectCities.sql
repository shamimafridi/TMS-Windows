USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectCities]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCities]
@Option as  varchar(20)='',
@CityCode as varchar(10) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.Cities.CityCode, dbo.Cities.City,DefinitionDate,UrduTitle
		FROM        dbo.Cities 
ELSE IF @Option='SRHGRID'
	SELECT     *
		FROM         dbo.Cities
	ORDER BY CityCode
ELSE
	SELECT * FROM Cities WHERE CityCode=@CityCode

GO
