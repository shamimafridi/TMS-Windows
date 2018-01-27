USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectFSFControls]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectFSFControls]
@Option as  varchar(20)='',
@ControlCode as varchar(10) =''

AS
IF 	@Option='ALL' 
		SELECT     *
		FROM         dbo.FSFControls
ELSE IF @Option='SRHGRID' 
	SELECT     TOP 100 PERCENT ControlCode, ControlDescription, DefinitionDate
	FROM         dbo.FSFControls
    ORDER BY ControlCode

ELSE IF @Option='AUTO' 
		SELECT     Top 1 ControlCode+1 as ControlCode
		 FROM dbo.FSFControls
	ORDER BY ControlCode desc
ELSE
	SELECT * FROM FSFControls WHERE ControlCode=@ControlCode
    ORDER BY ControlCode

GO
