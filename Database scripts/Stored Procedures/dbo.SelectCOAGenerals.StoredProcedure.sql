USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectCOAGenerals]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCOAGenerals]
@Option as  varchar(100)='',
@ControlCode as varchar(10) ='',
@GeneralCode as varchar(10) =''

AS
IF 	@Option='ALL' 
		SELECT     dbo.COAGenerals.GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAGenerals.DefinitionDate, dbo.COAGenerals.GUID, dbo.COAControls.ControlCode, 
		                      dbo.COAControls.ControlDescription, dbo.GL_GetFSFCombineTransactionVW.GLCode as FSFGLCode, dbo.GL_GetFSFCombineTransactionVW.GLDescription as FSFGLDescription
		FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
		                      dbo.COAGenerals ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COAGenerals.FSFGLCode LEFT OUTER JOIN
		                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
		ORDER BY        dbo.COAGenerals.ControlCode,dbo.COAGenerals.GeneralCode 
ELSE IF @Option='SRHGRID' 
	SELECT     TOP 100 PERCENT dbo.COAGenerals.ControlCode, dbo.COAControls.ControlDescription, dbo.COAGenerals.GeneralCode AS GeneralCode, 
                      dbo.COAGenerals.GeneralDescription, dbo.COAGenerals.DefinitionDate
	FROM         dbo.COAGenerals LEFT OUTER JOIN
	                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
	ORDER BY dbo.COAGenerals.GeneralCode
ELSE IF @Option='SRHGRIDFORCHILD' 
	SELECT     TOP 100 PERCENT dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription, 
                      dbo.COAGenerals.DefinitionDate, dbo.COAGenerals.ControlCode, dbo.COAControls.ControlDescription
	FROM         dbo.COAGenerals LEFT OUTER JOIN
	                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
	ORDER BY dbo.COAGenerals.GeneralCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 GeneralCode +1 as GeneralCode
		FROM dbo.COAGenerals
	ORDER BY GeneralCode desc
ELSE IF @Option='PKVALIDATION'
 
	SELECT     dbo.COAGenerals.GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAGenerals.DefinitionDate, dbo.COAGenerals.GUID, dbo.COAControls.ControlCode, 
                   	   dbo.COAControls.ControlDescription, dbo.GL_GetFSFCombineTransactionVW.GLCode as FSFGLCode, dbo.GL_GetFSFCombineTransactionVW.GLDescription as FSFGLDescription
	FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
	                      dbo.COAGenerals ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COAGenerals.FSFGLCode LEFT OUTER JOIN
	                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
	WHERE dbo.COAGenerals.GeneralCode=@GeneralCode AND  dbo.COAGenerals.ControlCode=@ControlCode
	ORDER BY        dbo.COAGenerals.ControlCode,dbo.COAGenerals.GeneralCode 
ELSE
	SELECT     dbo.COAGenerals.GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAGenerals.DefinitionDate, dbo.COAGenerals.GUID, dbo.COAControls.ControlCode, 
                     	   dbo.COAControls.ControlDescription, dbo.GL_GetFSFCombineTransactionVW.GLCode as FSFGLCode, dbo.GL_GetFSFCombineTransactionVW.GLDescription as FSFGLDescription
	FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
	                      dbo.COAGenerals ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COAGenerals.FSFGLCode LEFT OUTER JOIN
	                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
	WHERE  dbo.COAGenerals.GeneralCode=@GeneralCode AND  dbo.COAGenerals.ControlCode=@ControlCode
    ORDER BY        dbo.COAGenerals.ControlCode,dbo.COAGenerals.GeneralCode

GO
