USE [TMS_ALI]
GO
/****** Object:  View [dbo].[GL_GetCOACombineVW]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--drop VIEW dbo.GL_GetCOACombineVW
CREATE VIEW [dbo].[GL_GetCOACombineVW]
AS
SELECT     ControlCode + GeneralCode AS GLCode, GeneralDescription AS GLDescription, dbo.COAGenerals.FSFGLCode AS SysFSFGLCode
FROM         dbo.COAGenerals
UNION ALL
SELECT     dbo.COASubsidiaries.ControlCode + dbo.COASubsidiaries.GeneralCode + dbo.COASubsidiaries.SubsidiaryCode AS GLCode, dbo.COASubsidiaries.SubsidiaryDescription AS GlDescription
	, (CASE ISNULL(dbo.COASubsidiaries.FSFGLCode, 0) 
                      WHEN 0 THEN dbo.COAGenerals.FSFGLCode ELSE dbo.COASubsidiaries.FSFGLCode END) AS SysFSFGLCode
FROM         dbo.COASubsidiaries LEFT OUTER JOIN
                      dbo.COAGenerals ON dbo.COASubsidiaries.GeneralCode = dbo.COAGenerals.GeneralCode AND dbo.COASubsidiaries.ControlCode = dbo.COAGenerals.ControlCode
UNION ALL
SELECT     dbo.COASubSubsidiaries.ControlCode + dbo.COASubSubsidiaries.GeneralCode + dbo.COASubSubsidiaries.SubsidiaryCode + dbo.COASubSubsidiaries.SubSubsidiaryCode AS GLCode, dbo.COASubSubsidiaries.SubSubsidiaryDescription AS GlDescription
		, (CASE ISNULL(dbo.COASubsidiaries.FSFGLCode, 0) 
                      WHEN 0 THEN (CASE ISNULL(dbo.COASubsidiaries.FSFGLCode, 0) WHEN 0 THEN dbo.COAGenerals.FSFGLCode ELSE dbo.COASubsidiaries.FSFGLCode END) 
                      ELSE dbo.COASubSubsidiaries.FSFGLCode END) AS SysFSFGLCode
FROM         dbo.COAGenerals RIGHT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode AND 
                      dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode RIGHT OUTER JOIN
                      dbo.COASubSubsidiaries ON dbo.COASubsidiaries.SubsidiaryCode = dbo.COASubSubsidiaries.SubsidiaryCode AND 
                      dbo.COASubsidiaries.ControlCode = dbo.COASubSubsidiaries.ControlCode AND dbo.COASubsidiaries.GeneralCode = dbo.COASubSubsidiaries.GeneralCode

GO
