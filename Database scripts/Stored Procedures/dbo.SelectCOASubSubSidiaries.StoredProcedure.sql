USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectCOASubSubSidiaries]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCOASubSubSidiaries]
@Option as  varchar(100)='',
@ControlCode as varchar(2) ='',
@SubsidiaryCode1 as varchar(20)='',
@SubSubsidiaryCode as varchar(20)='',
@GeneralCode as varchar(18) ='',
@SubsidiaryCode as varchar(20) =''



AS



IF 	@Option='ALL' 
		SELECT     dbo.COAControls.ControlCode + ' - ' + dbo.COAControls.ControlDescription AS ControlDescription, 
		                      dbo.COAGenerals.GeneralCode + ' - ' + dbo.COAGenerals.GeneralDescription AS GeneralDescription, 
		                      dbo.COASubSubsidiaries.ControlCode + dbo.COASubSubsidiaries.GeneralCode + dbo.COASubSubsidiaries.SubsidiaryCode AS SubsidiaryCode1, 
		                      dbo.COASubsidiaries.SubsidiaryDescription, dbo.COASubsidiaries.SubsidiaryDescription AS Expr1, dbo.COASubSubsidiaries.SubSubsidiaryCode, 
		                      dbo.COASubSubsidiaries.SubSubsidiaryDescription, dbo.COASubSubsidiaries.DefinitionDate, dbo.COASubSubsidiaries.GUID, dbo.COAControls.ControlCode, 
		                      dbo.COAGenerals.GeneralCode, dbo.COASubsidiaries.SubsidiaryCode, dbo.GL_GetFSFCombineTransactionVW.GLCode AS fsfglcode, 
		                      dbo.GL_GetFSFCombineTransactionVW.GLDescription AS fsfGLDescription
		FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
		                      dbo.COASubSubsidiaries ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COASubSubsidiaries.FSFGLCode LEFT OUTER JOIN
		                      dbo.COASubsidiaries ON dbo.COASubSubsidiaries.SubsidiaryCode = dbo.COASubsidiaries.SubsidiaryCode AND 
		                      dbo.COASubSubsidiaries.ControlCode = dbo.COASubsidiaries.ControlCode AND 
		                      dbo.COASubSubsidiaries.GeneralCode = dbo.COASubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.COAGenerals ON dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode AND 
		                      dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode LEFT OUTER JOIN
		                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
        ORDER BY dbo.COASubSubsidiaries.ControlCode,dbo.COASubSubsidiaries.GeneralCode,dbo.COASubSubsidiaries.SubsidiaryCode,dbo.COASubSubsidiaries.SubSubsidiaryCode
ELSE IF @Option='SRHGRIDFORCHILD' 
		SELECT     TOP 100 PERCENT dbo.COASubsidiaries.SubsidiaryCode, dbo.COASubsidiaries.SubsidiaryDescription, 
		                      dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COAControls.ControlCode, 
		                      dbo.COAControls.ControlDescription
		FROM         dbo.COAGenerals RIGHT OUTER JOIN
		                      dbo.COASubsidiaries ON dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
ELSE IF @Option='SRHGRID' 
		SELECT     TOP 100 PERCENT dbo.COASubSubsidiaries.SubSubsidiaryCode, dbo.COASubSubsidiaries.SubSubsidiaryDescription, dbo.COAControls.ControlCode, 
                      dbo.COAControls.ControlDescription, dbo.COAGenerals.GeneralCode, dbo.COAGenerals.GeneralDescription, dbo.COASubsidiaries.SubsidiaryCode, 
                      dbo.COASubsidiaries.SubsidiaryDescription, dbo.COASubSubsidiaries.DefinitionDate
		FROM         dbo.COASubsidiaries RIGHT OUTER JOIN
                      dbo.COASubSubsidiaries ON dbo.COASubsidiaries.SubsidiaryCode = dbo.COASubSubsidiaries.SubsidiaryCode AND 
                      dbo.COASubsidiaries.ControlCode = dbo.COASubSubsidiaries.ControlCode AND 
                      dbo.COASubsidiaries.GeneralCode = dbo.COASubSubsidiaries.GeneralCode LEFT OUTER JOIN
                      dbo.COAGenerals ON dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode AND 
                      dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode LEFT OUTER JOIN
                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
		ORDER BY dbo.COASubSubsidiaries.SubSubsidiaryCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 SubSubsidiaryCode +1 as SubSubsidiaryCode
		FROM dbo.COASubSubsidiaries
		ORDER BY dbo.COASubSubsidiaries.SubSubsidiaryCode desc
ELSE IF @Option='COMBO' 
		SELECT GlCode,GlDescription FROM GL_GetCOACombineTransactionVW
		Order By GLCode
ELSE IF @Option='PKVALIDATION' 
		SELECT     dbo.COAControls.ControlCode + ' - ' + dbo.COAControls.ControlDescription AS ControlDescription, 
		                      dbo.COAGenerals.GeneralCode + ' - ' + dbo.COAGenerals.GeneralDescription AS GeneralDescription, 
		                      dbo.COASubSubsidiaries.ControlCode + dbo.COASubSubsidiaries.GeneralCode + dbo.COASubSubsidiaries.SubsidiaryCode AS SubsidiaryCode1, 
		                      dbo.COASubsidiaries.SubsidiaryDescription, dbo.COASubsidiaries.SubsidiaryDescription AS Expr1, dbo.COASubSubsidiaries.SubSubsidiaryCode, 
		                      dbo.COASubSubsidiaries.SubSubsidiaryDescription, dbo.COASubSubsidiaries.DefinitionDate, dbo.COASubSubsidiaries.GUID, dbo.COAControls.ControlCode, 
		                      dbo.COAGenerals.GeneralCode, dbo.COASubsidiaries.SubsidiaryCode, dbo.GL_GetFSFCombineTransactionVW.GLCode AS fsfglcode, 
		                      dbo.GL_GetFSFCombineTransactionVW.GLDescription AS fsfGLDescription
		FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
		                      dbo.COASubSubsidiaries ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COASubSubsidiaries.FSFGLCode LEFT OUTER JOIN
		                      dbo.COASubsidiaries ON dbo.COASubSubsidiaries.SubsidiaryCode = dbo.COASubsidiaries.SubsidiaryCode AND 
		                      dbo.COASubSubsidiaries.ControlCode = dbo.COASubsidiaries.ControlCode AND 
		                      dbo.COASubSubsidiaries.GeneralCode = dbo.COASubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.COAGenerals ON dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode AND 
		                      dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode LEFT OUTER JOIN
		                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
	 WHERE  dbo.COASubSubsidiaries.ControlCode + dbo.COAGenerals.GeneralCode + dbo.COASubSubsidiaries.SubsidiaryCode=@SubsidiaryCode1 AND dbo.COASubSubsidiaries.SubSubsidiaryCode=@SubSubsidiaryCode	
     ORDER BY dbo.COASubSubsidiaries.ControlCode,dbo.COASubSubsidiaries.GeneralCode,dbo.COASubSubsidiaries.SubsidiaryCode,dbo.COASubSubsidiaries.SubSubsidiaryCode

ELSE
		SELECT     dbo.COAControls.ControlCode + ' - ' + dbo.COAControls.ControlDescription AS ControlDescription, 
		                      dbo.COAGenerals.GeneralCode + ' - ' + dbo.COAGenerals.GeneralDescription AS GeneralDescription, 
		                      dbo.COASubSubsidiaries.ControlCode + dbo.COASubSubsidiaries.GeneralCode + dbo.COASubSubsidiaries.SubsidiaryCode AS SubsidiaryCode1, 
		                      dbo.COASubsidiaries.SubsidiaryDescription, dbo.COASubsidiaries.SubsidiaryDescription AS Expr1, dbo.COASubSubsidiaries.SubSubsidiaryCode, 
		                      dbo.COASubSubsidiaries.SubSubsidiaryDescription, dbo.COASubSubsidiaries.DefinitionDate, dbo.COASubSubsidiaries.GUID, dbo.COAControls.ControlCode, 
		                      dbo.COAGenerals.GeneralCode, dbo.COASubsidiaries.SubsidiaryCode, dbo.GL_GetFSFCombineTransactionVW.GLCode AS fsfglcode, 
		                      dbo.GL_GetFSFCombineTransactionVW.GLDescription AS fsfGLDescription
		FROM         dbo.GL_GetFSFCombineTransactionVW RIGHT OUTER JOIN
		                      dbo.COASubSubsidiaries ON dbo.GL_GetFSFCombineTransactionVW.GLCode = dbo.COASubSubsidiaries.FSFGLCode LEFT OUTER JOIN
		                      dbo.COASubsidiaries ON dbo.COASubSubsidiaries.SubsidiaryCode = dbo.COASubsidiaries.SubsidiaryCode AND 
		                      dbo.COASubSubsidiaries.ControlCode = dbo.COASubsidiaries.ControlCode AND 
		                      dbo.COASubSubsidiaries.GeneralCode = dbo.COASubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.COAGenerals ON dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode AND 
		                      dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode LEFT OUTER JOIN
		                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode
	 WHERE  dbo.COASubSubsidiaries.ControlCode=@ControlCode AND  dbo.COASubSubsidiaries.GeneralCode=@GeneralCode AND dbo.COASubSubsidiaries.SubsidiaryCode=@SubsidiaryCode1 AND dbo.COASubSubsidiaries.SubSubsidiaryCode=@SubSubsidiaryCode
     ORDER BY dbo.COASubSubsidiaries.ControlCode,dbo.COASubSubsidiaries.GeneralCode,dbo.COASubSubsidiaries.SubsidiaryCode,dbo.COASubSubsidiaries.SubSubsidiaryCode

GO
