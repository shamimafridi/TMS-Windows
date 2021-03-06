USE [TMS_ALI]
GO
/****** Object:  View [dbo].[GL_GetCOACombineLedTBRptVW]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TMS
create view  [dbo].[GL_GetCOACombineLedTBRptVW]
as
SELECT     dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GLCode, dbo.COAGenerals.GeneralDescription AS GLRptTitle, dbo.COAControls.ControlCode, 
                      dbo.COAControls.ControlDescription AS ControlRptTitle, dbo.COAControls.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, 
                      dbo.COAGenerals.GeneralDescription AS GeneralRptTitle, '' AS SubSidiaryCode, '' AS SubsidiaryRptTitle, '' AS SubsubCode, '' AS SubSubRptTitle,
		      (CASE ISNULL(dbo.COASubsidiaries.FSFGLCode, 0) WHEN 0 THEN dbo.COAGenerals.FSFGLCode ELSE dbo.COASubsidiaries.FSFGLCode END) 
                      AS SysFSFGLCode
FROM         dbo.COAGenerals LEFT OUTER JOIN
                      dbo.COAControls ON dbo.COAGenerals.ControlCode = dbo.COAControls.ControlCode LEFT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode AND 
                      dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode
WHERE     (dbo.COASubsidiaries.SubsidiaryCode IS NULL)
UNION ALL
SELECT     dbo.COASubsidiaries.ControlCode + dbo.COASubsidiaries.GeneralCode + dbo.COASubsidiaries.SubsidiaryCode AS GLCode, 
                      dbo.COASubsidiaries.SubsidiaryDescription AS GLRptTitle, dbo.COAControls.ControlCode, dbo.COAControls.ControlDescription AS ControlRptTitle, 
                      dbo.COAControls.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription AS GeneralRptTitle, 
                      dbo.COAControls.ControlCode + dbo.COAGenerals.GeneralCode + dbo.COASubsidiaries.SubsidiaryCode AS SubSidiaryCode, 
                      dbo.COASubsidiaries.SubsidiaryDescription AS SubsidiaryRptTitle, '' AS SubsubCode, '' AS SubSubRptTitle,
                      (CASE ISNULL(dbo.COASubSubsidiaries.FSFGLCode, 0) WHEN 0 THEN (CASE ISNULL(dbo.COASubsidiaries.FSFGLCode, 0) 
                      WHEN 0 THEN COAGenerals.FSFGLCode ELSE COASubsidiaries.FSFGLCode END) ELSE dbo.COASubSubsidiaries.FSFGLCode END) 
                      AS SysFSFGLCode
FROM         dbo.COAControls RIGHT OUTER JOIN
                      dbo.COAGenerals RIGHT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode AND 
                      dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode LEFT OUTER JOIN
                      dbo.COASubSubsidiaries ON dbo.COASubsidiaries.ControlCode = dbo.COASubSubsidiaries.ControlCode AND 
                      dbo.COASubsidiaries.GeneralCode = dbo.COASubSubsidiaries.GeneralCode AND dbo.COASubsidiaries.SubsidiaryCode = dbo.COASubSubsidiaries.SubsidiaryCode ON 
                      dbo.COAControls.ControlCode = dbo.COAGenerals.ControlCode
WHERE     dbo.COASubsidiaries.SubsidiaryCode IS NOT NULL AND dbo.COASubSubsidiaries.SubSubsidiaryCode IS NULL
UNION ALL
SELECT     dbo.COASubSubsidiaries.ControlCode + dbo.COASubSubsidiaries.GeneralCode + dbo.COASubSubsidiaries.SubsidiaryCode + dbo.COASubSubsidiaries.SubSubsidiaryCode
                       AS GLCode, dbo.COASubSubsidiaries.SubSubsidiaryDescription AS GLRptTitle, dbo.COAControls.ControlCode, dbo.COAControls.ControlDescription AS ControlRptTitle, 
                      dbo.COAControls.ControlCode + dbo.COAGenerals.GeneralCode AS GeneralCode, dbo.COAGenerals.GeneralDescription AS GeneralRptTitle, 
                      dbo.COAControls.ControlCode + dbo.COAGenerals.GeneralCode + dbo.COASubsidiaries.SubsidiaryCode AS SubSidiaryCode, 
                      dbo.COASubsidiaries.SubsidiaryDescription AS SubsidiaryRptTitle, 
                      dbo.COAControls.ControlCode + dbo.COAGenerals.GeneralCode + dbo.COASubsidiaries.SubsidiaryCode + dbo.COASubSubsidiaries.SubSubsidiaryCode AS SubsubCode,
                       dbo.COASubSubsidiaries.SubSubsidiaryDescription AS GLSubSubRptTitle
		     , (CASE ISNULL(dbo.COASubsidiaries.FSFGLCode, 0)  WHEN 0 THEN (CASE ISNULL(COASubsidiaries.FSFGLCode, 0) 
                      WHEN 0 THEN COAGenerals.FSFGLCode ELSE COASubsidiaries.FSFGLCode END) ELSE COASubSubsidiaries.FSFGLCode END) 
                      AS SysFSFGLCode
FROM         dbo.COAControls RIGHT OUTER JOIN
                      dbo.COAGenerals ON dbo.COAControls.ControlCode = dbo.COAGenerals.ControlCode RIGHT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode AND 
                      dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode RIGHT OUTER JOIN
                      dbo.COASubSubsidiaries ON dbo.COASubsidiaries.SubsidiaryCode = dbo.COASubSubsidiaries.SubsidiaryCode AND 
                      dbo.COASubsidiaries.ControlCode = dbo.COASubSubsidiaries.ControlCode AND dbo.COASubsidiaries.GeneralCode = dbo.COASubSubsidiaries.GeneralCode

GO
