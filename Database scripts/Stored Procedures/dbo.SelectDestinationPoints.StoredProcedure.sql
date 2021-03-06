USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectDestinationPoints]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectDestinationPoints]
@Option as  varchar(20)='',
@DestinationPointCode as varchar(10) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.DestinationPoints.DestinationPointCode, dbo.DestinationPoints.DestinationPointName,DefinitionDate,UrduTitle, PointNo
		FROM        dbo.DestinationPoints 
        ORDER BY  dbo.DestinationPoints.DestinationPointCode
ELSE IF @Option='SRHGRID'
	SELECT     *
		FROM         dbo.DestinationPoints
	ORDER BY DestinationPointCode
ELSE
	SELECT * FROM DestinationPoints 
	WHERE DestinationPointCode=@DestinationPointCode
    ORDER BY dbo.DestinationPoints.DestinationPointCode

GO
