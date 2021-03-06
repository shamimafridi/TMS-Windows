USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectRegions]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectRegions]
@Option as  varchar(20)='',
@RegionCode as varchar(10) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.Regions.RegionCode, dbo.Regions.RegionName,DefinitionDate,UrduTitle
		FROM        dbo.Regions 
ELSE IF @Option='SRHGRID'
	SELECT     *
		FROM         dbo.Regions
	ORDER BY RegionCode
ELSE
	SELECT * FROM Regions 
	WHERE RegionCode=@RegionCode

GO
