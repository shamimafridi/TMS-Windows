USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectStationPoints]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectStationPoints]
@Option as  varchar(20)='',
@StationPointCode as varchar(10) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.StationPoints.StationPointCode, dbo.StationPoints.StationPointName,DefinitionDate,UrduTitle, PointNo
		FROM        dbo.StationPoints 
        ORDER BY dbo.StationPoints.StationPointCode
ELSE IF @Option='SRHGRID'
	SELECT     *
		FROM         dbo.StationPoints
	ORDER BY StationPointCode
ELSE
	SELECT * FROM StationPoints 
	WHERE StationPointCode=@StationPointCode

GO
