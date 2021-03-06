USE [TMS_ALI]
GO
/****** Object:  View [dbo].[GL_GetFSFCombineLedTBRptVW]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TMS
create view  [dbo].[GL_GetFSFCombineLedTBRptVW]
as
SELECT     dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GLCode, dbo.FSFGenerals.GeneralDescription AS GLRptTitle, dbo.FSFControls.ControlCode, 
                      dbo.FSFControls.ControlDescription AS ControlRptTitle, dbo.FSFControls.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, 
                      dbo.FSFGenerals.GeneralDescription AS GeneralRptTitle, '' AS SubSidiaryCode, '' AS SubsidiaryRptTitle, '' AS SubsubCode, '' AS SubSubRptTitle

FROM         dbo.FSFGenerals LEFT OUTER JOIN
                      dbo.FSFControls ON dbo.FSFGenerals.ControlCode = dbo.FSFControls.ControlCode LEFT OUTER JOIN
                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode AND 
                      dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode
WHERE     (dbo.FSFSubsidiaries.SubsidiaryCode IS NULL)
UNION ALL
SELECT     dbo.FSFSubsidiaries.ControlCode + dbo.FSFSubsidiaries.GeneralCode + dbo.FSFSubsidiaries.SubsidiaryCode AS GLCode, 
                      dbo.FSFSubsidiaries.SubsidiaryDescription AS GLRptTitle, dbo.FSFControls.ControlCode, dbo.FSFControls.ControlDescription AS ControlRptTitle, 
                      dbo.FSFControls.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription AS GeneralRptTitle, 
                      dbo.FSFControls.ControlCode + dbo.FSFGenerals.GeneralCode + dbo.FSFSubsidiaries.SubsidiaryCode AS SubSidiaryCode, 
                      dbo.FSFSubsidiaries.SubsidiaryDescription AS SubsidiaryRptTitle, '' AS SubsubCode, '' AS SubSubRptTitle

FROM         dbo.FSFControls RIGHT OUTER JOIN
                      dbo.FSFGenerals RIGHT OUTER JOIN
                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode AND 
                      dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode LEFT OUTER JOIN
                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND 
                      dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode AND dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode ON 
                      dbo.FSFControls.ControlCode = dbo.FSFGenerals.ControlCode
WHERE     dbo.FSFSubsidiaries.SubsidiaryCode IS NOT NULL AND dbo.FSFSubSubsidiaries.SubSubsidiaryCode IS NULL
UNION ALL
SELECT     dbo.FSFSubSubsidiaries.ControlCode + dbo.FSFSubSubsidiaries.GeneralCode + dbo.FSFSubSubsidiaries.SubsidiaryCode + dbo.FSFSubSubsidiaries.SubSubsidiaryCode
                       AS GLCode, dbo.FSFSubSubsidiaries.SubSubsidiaryDescription AS GLRptTitle, dbo.FSFControls.ControlCode, dbo.FSFControls.ControlDescription AS ControlRptTitle, 
                      dbo.FSFControls.ControlCode + dbo.FSFGenerals.GeneralCode AS GeneralCode, dbo.FSFGenerals.GeneralDescription AS GeneralRptTitle, 
                      dbo.FSFControls.ControlCode + dbo.FSFGenerals.GeneralCode + dbo.FSFSubsidiaries.SubsidiaryCode AS SubSidiaryCode, 
                      dbo.FSFSubsidiaries.SubsidiaryDescription AS SubsidiaryRptTitle, 
                      dbo.FSFControls.ControlCode + dbo.FSFGenerals.GeneralCode + dbo.FSFSubsidiaries.SubsidiaryCode + dbo.FSFSubSubsidiaries.SubSubsidiaryCode AS SubsubCode,
                       dbo.FSFSubSubsidiaries.SubSubsidiaryDescription AS GLSubSubRptTitle

FROM         dbo.FSFControls RIGHT OUTER JOIN
                      dbo.FSFGenerals ON dbo.FSFControls.ControlCode = dbo.FSFGenerals.ControlCode RIGHT OUTER JOIN
                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode AND 
                      dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode RIGHT OUTER JOIN
                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode AND 
                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode

GO
