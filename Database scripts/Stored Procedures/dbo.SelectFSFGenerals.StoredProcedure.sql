USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectFSFGenerals]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectFSFGenerals]
@Option as  varchar(100)='',
@ControlCode as varchar(10) ='',
@GeneralCode as varchar(10) =''

AS
IF 	@Option='ALL' 
		SELECT     dbo.FSFGenerals.GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFGenerals.DefinitionDate, dbo.FSFGenerals.GUID, 
                	      dbo.FSFControls.ControlCode, dbo.FSFControls.ControlDescription
		FROM         dbo.FSFControls RIGHT OUTER JOIN
                      dbo.FSFGenerals ON dbo.FSFControls.ControlCode = dbo.FSFGenerals.ControlCode
        ORDER BY dbo.FSFGenerals.ControlCode,dbo.FSFGenerals.GeneralCode
ELSE IF @Option='SRHGRID' 
	SELECT     TOP 100 PERCENT dbo.FSFGenerals.ControlCode, dbo.FSFControls.ControlDescription, dbo.FSFGenerals.GeneralCode AS GeneralCode, 
                      dbo.FSFGenerals.GeneralDescription, dbo.FSFGenerals.DefinitionDate
	FROM         dbo.FSFGenerals LEFT OUTER JOIN
	                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
	ORDER BY dbo.FSFGenerals.GeneralCode
ELSE IF @Option='SRHGRIDFORCHILD' 
	SELECT     TOP 100 PERCENT dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription, 
                      dbo.FSFGenerals.DefinitionDate, dbo.FSFGenerals.ControlCode, dbo.FSFControls.ControlDescription
	FROM         dbo.FSFGenerals LEFT OUTER JOIN
	                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
	ORDER BY dbo.FSFGenerals.GeneralCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 GeneralCode +1 as GeneralCode
		FROM dbo.FSFGenerals
	ORDER BY GeneralCode desc
ELSE IF @Option='PKVALIDATION'
 
	SELECT     dbo.FSFControls.ControlCode,dbo.FSFGenerals.GeneralCode as GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFGenerals.DefinitionDate, dbo.FSFGenerals.GUID, 
		      dbo.FSFControls.ControlCode, dbo.FSFControls.ControlDescription
	FROM         dbo.FSFControls RIGHT OUTER JOIN
	   	      dbo.FSFGenerals ON dbo.FSFControls.ControlCode = dbo.FSFGenerals.ControlCode
	WHERE dbo.FSFGenerals.GeneralCode=@GeneralCode AND  dbo.FSFGenerals.ControlCode=@ControlCode
    ORDER BY dbo.FSFGenerals.ControlCode,dbo.FSFGenerals.GeneralCode
ELSE
	SELECT     dbo.FSFGenerals.GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFGenerals.DefinitionDate, dbo.FSFGenerals.GUID, 
                	      dbo.FSFControls.ControlCode, dbo.FSFControls.ControlDescription
		FROM         dbo.FSFControls RIGHT OUTER JOIN
                      dbo.FSFGenerals ON dbo.FSFControls.ControlCode = dbo.FSFGenerals.ControlCode
	 WHERE  dbo.FSFGenerals.GeneralCode=@GeneralCode AND  dbo.FSFGenerals.ControlCode=@ControlCode
     ORDER BY dbo.FSFGenerals.ControlCode,dbo.FSFGenerals.GeneralCode

GO
