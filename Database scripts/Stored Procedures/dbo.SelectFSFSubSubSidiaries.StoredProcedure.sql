USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectFSFSubSubSidiaries]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectFSFSubSubSidiaries]
@Option as  varchar(100)='',
@ControlCode as varchar(2) ='',
@SubsidiaryCode1 as varchar(20)='',
@SubSubsidiaryCode as varchar(20)='',
@GeneralCode as varchar(18) ='',
@SubsidiaryCode as varchar(20) =''



AS



IF 	@Option='ALL' 
		SELECT     dbo.FSFControls.ControlCode + ' - ' + dbo.FSFControls.ControlDescription as ControlDescription,dbo.FSFGenerals.GeneralCode + ' - ' +dbo.FSFGenerals.GeneralDescription as GeneralDescription,
			      dbo.FSFSubSubsidiaries.ControlCode + dbo.FSFSubSubsidiaries.GeneralCode + dbo.FSFSubSubsidiaries.SubsidiaryCode AS SubsidiaryCode1,
			      dbo.FSFSubsidiaries.SubsidiaryDescription,dbo.FSFSubsidiaries.SubsidiaryDescription,
		                      dbo.FSFSubSubsidiaries.SubSubsidiaryCode, dbo.FSFSubSubsidiaries.SubSubsidiaryDescription, dbo.FSFSubSubsidiaries.DefinitionDate, 
		                      dbo.FSFSubSubsidiaries.GUID, dbo.FSFControls.ControlCode, dbo.FSFGenerals.GeneralCode, dbo.FSFSubsidiaries.SubsidiaryCode
		FROM         dbo.FSFSubsidiaries RIGHT OUTER JOIN
		                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode AND 
		                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND 
		                      dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.FSFGenerals ON dbo.FSFSubsidiaries.GeneralCode = dbo.FSFGenerals.GeneralCode AND 
		                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFGenerals.ControlCode LEFT OUTER JOIN
		                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
        ORDER BY dbo.FSFSubSubsidiaries.ControlCode,dbo.FSFSubSubsidiaries.GeneralCode,dbo.FSFSubSubsidiaries.SubsidiaryCode,dbo.FSFSubSubsidiaries.SubSubsidiaryCode
ELSE IF @Option='SRHGRIDFORCHILD' 
		SELECT     TOP 100 PERCENT dbo.FSFSubsidiaries.SubsidiaryCode, dbo.FSFSubsidiaries.SubsidiaryDescription, 
		                      dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFControls.ControlCode, 
		                      dbo.FSFControls.ControlDescription
		FROM         dbo.FSFGenerals RIGHT OUTER JOIN
		                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
ELSE IF @Option='SRHGRID' 
		SELECT     TOP 100 PERCENT dbo.FSFSubSubsidiaries.SubSubsidiaryCode, dbo.FSFSubSubsidiaries.SubSubsidiaryDescription, dbo.FSFControls.ControlCode, 
                      dbo.FSFControls.ControlDescription, dbo.FSFGenerals.GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFSubsidiaries.SubsidiaryCode, 
                      dbo.FSFSubsidiaries.SubsidiaryDescription, dbo.FSFSubSubsidiaries.DefinitionDate
		FROM         dbo.FSFSubsidiaries RIGHT OUTER JOIN
                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode AND 
                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND 
                      dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode LEFT OUTER JOIN
                      dbo.FSFGenerals ON dbo.FSFSubsidiaries.GeneralCode = dbo.FSFGenerals.GeneralCode AND 
                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFGenerals.ControlCode LEFT OUTER JOIN
                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
        ORDER BY dbo.FSFSubSubsidiaries.ControlCode,dbo.FSFSubSubsidiaries.GeneralCode,dbo.FSFSubSubsidiaries.SubsidiaryCode,dbo.FSFSubSubsidiaries.SubSubsidiaryCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 SubSubsidiaryCode +1 as SubSubsidiaryCode
		FROM dbo.FSFSubSubsidiaries
		ORDER BY dbo.FSFSubSubsidiaries.SubSubsidiaryCode desc
ELSE IF @Option='COMBO' 
		SELECT GlCode,GlDescription FROM GL_GetFSFCombineTransactionVW
		Order By GLCode
ELSE IF @Option='PKVALIDATION' 
		SELECT     dbo.FSFControls.ControlCode + ' - ' + dbo.FSFControls.ControlDescription as ControlDescription,dbo.FSFGenerals.GeneralCode + ' - ' +dbo.FSFGenerals.GeneralDescription as GeneralDescription,
			      dbo.FSFSubSubsidiaries.ControlCode + dbo.FSFSubSubsidiaries.GeneralCode + dbo.FSFSubSubsidiaries.SubsidiaryCode AS SubsidiaryCode1,
			      dbo.FSFSubsidiaries.SubsidiaryDescription,dbo.FSFSubsidiaries.SubsidiaryDescription,
		                      dbo.FSFSubSubsidiaries.SubSubsidiaryCode, dbo.FSFSubSubsidiaries.SubSubsidiaryDescription, dbo.FSFSubSubsidiaries.DefinitionDate, 
		                      dbo.FSFSubSubsidiaries.GUID, dbo.FSFControls.ControlCode, dbo.FSFGenerals.GeneralCode, dbo.FSFSubsidiaries.SubsidiaryCode
		FROM         dbo.FSFSubsidiaries RIGHT OUTER JOIN
		                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode AND 
		                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND 
		                      dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.FSFGenerals ON dbo.FSFSubsidiaries.GeneralCode = dbo.FSFGenerals.GeneralCode AND 
		                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFGenerals.ControlCode LEFT OUTER JOIN
		                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
	 WHERE  dbo.FSFSubSubsidiaries.ControlCode + dbo.FSFGenerals.GeneralCode + dbo.FSFSubSubsidiaries.SubsidiaryCode=@SubsidiaryCode1 AND dbo.FSFSubSubsidiaries.SubSubsidiaryCode=@SubSubsidiaryCode	

ELSE
		SELECT     dbo.FSFControls.ControlCode + ' - ' + dbo.FSFControls.ControlDescription as ControlDescription,dbo.FSFGenerals.GeneralCode + ' - ' +dbo.FSFGenerals.GeneralDescription as GeneralDescription,
			      dbo.FSFSubSubsidiaries.ControlCode + dbo.FSFSubSubsidiaries.GeneralCode + dbo.FSFSubSubsidiaries.SubsidiaryCode AS SubsidiaryCode1,
			      dbo.FSFSubsidiaries.SubsidiaryDescription,dbo.FSFSubsidiaries.SubsidiaryDescription,
		                      dbo.FSFSubSubsidiaries.SubSubsidiaryCode, dbo.FSFSubSubsidiaries.SubSubsidiaryDescription, dbo.FSFSubSubsidiaries.DefinitionDate, 
		                      dbo.FSFSubSubsidiaries.GUID, dbo.FSFControls.ControlCode, dbo.FSFGenerals.GeneralCode, dbo.FSFSubsidiaries.SubsidiaryCode
		FROM         dbo.FSFSubsidiaries RIGHT OUTER JOIN
		                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode AND 
		                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND 
		                      dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode LEFT OUTER JOIN
		                      dbo.FSFGenerals ON dbo.FSFSubsidiaries.GeneralCode = dbo.FSFGenerals.GeneralCode AND 
		                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFGenerals.ControlCode LEFT OUTER JOIN
		                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
	 WHERE  dbo.FSFSubSubsidiaries.ControlCode=@ControlCode AND  dbo.FSFSubSubsidiaries.GeneralCode=@GeneralCode AND dbo.FSFSubSubsidiaries.SubsidiaryCode=@SubsidiaryCode1 AND dbo.FSFSubSubsidiaries.SubSubsidiaryCode=@SubSubsidiaryCode

GO
