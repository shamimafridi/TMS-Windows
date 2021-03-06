USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectCOASubsidiaries]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCOASubsidiaries]
@Option as  varchar(100)='',
@ControlCode as varchar(1) ='',
@GeneralCode  as varchar(10) ='',
@SubsidiaryCode as varchar(8) ='',
@COASubsidiary as varchar(5) =''

AS
IF 	@Option='ALL' 
        SELECT     TOP 100 PERCENT dbo.COASubsidiaries.SubsidiaryCode, dbo.COASubsidiaries.SubsidiaryDescription, 
                      dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAControls.ControlCode, 
                      dbo.COAControls.ControlDescription, dbo.COASubsidiaries.DefinitionDate, dbo.GL_GetFSFCombineTransactionVW.GLCode as FSFGLCode, 
                      dbo.GL_GetFSFCombineTransactionVW.GLDescription as FSFGLDescription
        FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COASubsidiaries.FSFGLCode LEFT OUTER JOIN
                      dbo.COAGenerals LEFT OUTER JOIN
                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode ON dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode AND 
                      dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode
		ORDER BY  dbo.COASubsidiaries.ControlCode, dbo.COASubsidiaries.GeneralCode, dbo.COASubsidiaries.SubsidiaryCode
ELSE IF @Option='SRHGRID' 
		SELECT     TOP 100 PERCENT dbo.COASubsidiaries.SubsidiaryCode, dbo.COASubsidiaries.SubsidiaryDescription, 
		                      dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAControls.ControlCode, 
		                      dbo.COAControls.ControlDescription, dbo.COASubsidiaries.DefinitionDate
		FROM         dbo.COAGenerals LEFT OUTER JOIN
		                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode RIGHT OUTER JOIN
		                      dbo.COASubsidiaries ON dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode AND dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode
ELSE IF @Option='SRHGRIDFORCHILD' 
		SELECT     TOP 100 PERCENT dbo.COASubsidiaries.ControlCode + dbo.COASubsidiaries.GeneralCode + dbo.COASubsidiaries.SubsidiaryCode AS SubsidiaryCode, 
                      dbo.COASubsidiaries.SubsidiaryDescription, dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription, 
                      dbo.COAControls.ControlCode, dbo.COAControls.ControlDescription
FROM         dbo.COAGenerals RIGHT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode AND 
                      dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode LEFT OUTER JOIN
                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 SubsidiaryCode +1 as SubsidiaryCode
		FROM dbo.COASubsidiaries
		ORDER BY dbo.COASubsidiaries.SubsidiaryCode desc
ELSE IF @Option='COMBO' 
		SELECT     TOP 100 PERCENT ControlCode + GeneralCode + SubsidiaryCode AS GLCode, SubsidiaryDescription AS GLDescription
		FROM         dbo.COASubsidiaries
		ORDER BY SubsidiaryCode
ELSE IF @Option='PKVALIDATION' 
		SELECT     TOP 100 PERCENT dbo.COASubsidiaries.SubsidiaryCode, dbo.COASubsidiaries.SubsidiaryDescription, 
                      dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAControls.ControlCode, 
                      dbo.COAControls.ControlDescription, dbo.COASubsidiaries.DefinitionDate, dbo.GL_GetFSFCombineTransactionVW.GLCode as FSFGLCode, 
                      dbo.GL_GetFSFCombineTransactionVW.GLDescription as FSFGLDescription
		FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COASubsidiaries.FSFGLCode LEFT OUTER JOIN
                      dbo.COAGenerals LEFT OUTER JOIN
                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode ON dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode AND 
                      dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode
		WHERE dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode =@GeneralCode  AND dbo.COASubsidiaries.SubsidiaryCode=@SubsidiaryCode
        ORDER BY  dbo.COASubsidiaries.ControlCode, dbo.COASubsidiaries.GeneralCode, dbo.COASubsidiaries.SubsidiaryCode

ELSE
			SELECT     TOP 100 PERCENT dbo.COASubsidiaries.SubsidiaryCode, dbo.COASubsidiaries.SubsidiaryDescription, 
                      dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAControls.ControlCode, 
                      dbo.COAControls.ControlDescription, dbo.COASubsidiaries.DefinitionDate, dbo.GL_GetFSFCombineTransactionVW.GLCode as FSFGLCode, 
                      dbo.GL_GetFSFCombineTransactionVW.GLDescription as FSFGLDescription
	FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COASubsidiaries.FSFGLCode LEFT OUTER JOIN
                      dbo.COAGenerals LEFT OUTER JOIN
                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode ON dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode AND 
                      dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode
		WHERE dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode =@GeneralCode  AND dbo.COASubsidiaries.SubsidiaryCode=@SubsidiaryCode
        ORDER BY  dbo.COASubsidiaries.ControlCode, dbo.COASubsidiaries.GeneralCode, dbo.COASubsidiaries.SubsidiaryCode

GO
