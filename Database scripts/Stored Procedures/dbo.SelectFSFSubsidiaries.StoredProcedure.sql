USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectFSFSubsidiaries]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectFSFSubsidiaries]
@Option as  varchar(100)='',
@ControlCode as varchar(1) ='',
@GeneralCode  as varchar(10) ='',
@SubsidiaryCode as varchar(8) ='',
@FSFSubsidiary as varchar(5) =''

AS
IF 	@Option='ALL' 
		SELECT     TOP 100 PERCENT dbo.FSFSubsidiaries.SubsidiaryCode, dbo.FSFSubsidiaries.SubsidiaryDescription, 
	                      dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFControls.ControlCode, 
	                      dbo.FSFControls.ControlDescription, dbo.FSFSubsidiaries.DefinitionDate
		FROM         dbo.FSFGenerals LEFT OUTER JOIN
	                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode RIGHT OUTER JOIN
	                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode AND dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode
        ORDER BY dbo.FSFSubsidiaries.ControlCode,dbo.FSFSubsidiaries.GeneralCode,dbo.FSFSubsidiaries.SubsidiaryCode
ELSE IF @Option='SRHGRID' 
		SELECT     TOP 100 PERCENT dbo.FSFSubsidiaries.SubsidiaryCode, dbo.FSFSubsidiaries.SubsidiaryDescription, 
		                      dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFControls.ControlCode, 
		                      dbo.FSFControls.ControlDescription, dbo.FSFSubsidiaries.DefinitionDate
		FROM         dbo.FSFGenerals LEFT OUTER JOIN
		                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode RIGHT OUTER JOIN
		                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode AND dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode
         ORDER BY dbo.FSFSubsidiaries.ControlCode,dbo.FSFSubsidiaries.GeneralCode,dbo.FSFSubsidiaries.SubsidiaryCode
ELSE IF @Option='SRHGRIDFORCHILD' 
		SELECT     TOP 100 PERCENT dbo.FSFSubsidiaries.ControlCode + dbo.FSFSubsidiaries.GeneralCode + dbo.FSFSubsidiaries.SubsidiaryCode AS SubsidiaryCode, 
                      dbo.FSFSubsidiaries.SubsidiaryDescription, dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription, 
                      dbo.FSFControls.ControlCode, dbo.FSFControls.ControlDescription
FROM         dbo.FSFGenerals RIGHT OUTER JOIN
                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode AND 
                      dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode LEFT OUTER JOIN
                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 SubsidiaryCode +1 as SubsidiaryCode
		FROM dbo.FSFSubsidiaries
		ORDER BY dbo.FSFSubsidiaries.SubsidiaryCode desc
ELSE IF @Option='COMBO' 
		SELECT     TOP 100 PERCENT ControlCode + GeneralCode + SubsidiaryCode AS GLCode, SubsidiaryDescription AS GLDescription
		FROM         dbo.FSFSubsidiaries
		ORDER BY SubsidiaryCode
ELSE IF @Option='PKVALIDATION' 
		SELECT     TOP 100 PERCENT dbo.FSFSubsidiaries.SubsidiaryCode, dbo.FSFSubsidiaries.SubsidiaryDescription, 
		              dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFControls.ControlCode, 
		              dbo.FSFControls.ControlDescription, dbo.FSFSubsidiaries.DefinitionDate
		FROM         dbo.FSFGenerals RIGHT OUTER JOIN
		              dbo.FSFSubsidiaries ON dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode AND 
		              dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode LEFT OUTER JOIN
		              dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
		WHERE dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode =@GeneralCode  AND dbo.FSFSubsidiaries.SubsidiaryCode=@SubsidiaryCode
        ORDER BY dbo.FSFSubsidiaries.ControlCode,dbo.FSFSubsidiaries.GeneralCode,dbo.FSFSubsidiaries.SubsidiaryCode

ELSE
		SELECT     TOP 100 PERCENT dbo.FSFSubsidiaries.SubsidiaryCode, dbo.FSFSubsidiaries.SubsidiaryDescription, 
		      dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription, dbo.FSFControls.ControlCode, 
		      dbo.FSFControls.ControlDescription, dbo.FSFSubsidiaries.DefinitionDate
		FROM         dbo.FSFGenerals RIGHT OUTER JOIN
		      dbo.FSFSubsidiaries ON dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode AND 
		      dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode LEFT OUTER JOIN
		      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode
		WHERE dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode =@GeneralCode  AND dbo.FSFSubsidiaries.SubsidiaryCode=@SubsidiaryCode
        ORDER BY dbo.FSFSubsidiaries.ControlCode,dbo.FSFSubsidiaries.GeneralCode,dbo.FSFSubsidiaries.SubsidiaryCode

GO
