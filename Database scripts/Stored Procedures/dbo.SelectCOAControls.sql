USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectCOAControls]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCOAControls]
@Option as  varchar(20)='',
@ControlCode as varchar(10) =''

AS
IF 	@Option='ALL' 
		SELECT     *
		FROM         dbo.COAControls
        ORDER BY dbo.COAControls.ControlCode
ELSE IF @Option='SRHGRID' 
	SELECT     TOP 100 PERCENT ControlCode, ControlDescription, DefinitionDate
	FROM         dbo.COAControls
	ORDER BY ControlCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 ControlCode+1 as ControlCode
		 FROM dbo.COAControls
	ORDER BY ControlCode desc
ELSE
	SELECT * FROM COAControls WHERE ControlCode=@ControlCode
    ORDER BY dbo.COAControls.ControlCode

GO
