USE [TMS_ALI]
GO
/****** Object:  View [dbo].[GL_GetCOACombineTransactionVW]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TMS
--drop  view GL_GetCOACombineTransactionVW
create view [dbo].[GL_GetCOACombineTransactionVW]
as
SELECT     dbo.COAGenerals.ControlCode + dbo.COAGenerals.GeneralCode AS GLCode, dbo.COAGenerals.GeneralDescription AS GLDescription, dbo.COAGenerals.FSFGLCode
FROM         dbo.COAGenerals LEFT OUTER JOIN
                      dbo.COASubsidiaries ON dbo.COAGenerals.GeneralCode = dbo.COASubsidiaries.GeneralCode AND 
                      dbo.COAGenerals.ControlCode = dbo.COASubsidiaries.ControlCode
WHERE     (dbo.COASubsidiaries.SubsidiaryCode IS NULL)
UNION ALL
SELECT     dbo.COASubsidiaries.ControlCode + dbo.COASubsidiaries.GeneralCode + dbo.COASubsidiaries.SubsidiaryCode AS GLCode, 
                      dbo.COASubsidiaries.SubsidiaryDescription AS GLDescription ,COASubsidiaries.FSFGLCode
FROM         dbo.COASubsidiaries LEFT OUTER JOIN
                      dbo.COASubSubsidiaries ON dbo.COASubsidiaries.ControlCode = dbo.COASubSubsidiaries.ControlCode AND 
                      dbo.COASubsidiaries.GeneralCode = dbo.COASubSubsidiaries.GeneralCode AND 
                      dbo.COASubsidiaries.SubsidiaryCode = dbo.COASubSubsidiaries.SubsidiaryCode
WHERE     dbo.COASubsidiaries.SubsidiaryCode IS NOT NULL AND dbo.COASubSubsidiaries.SubSubsidiaryCode IS NULL
UNION ALL
SELECT     dbo.COASubSubsidiaries.ControlCode + dbo.COASubSubsidiaries.GeneralCode + dbo.COASubSubsidiaries.SubsidiaryCode + dbo.COASubSubsidiaries.SubSubsidiaryCode
                       AS GLCode, dbo.COASubSubsidiaries.SubSubsidiaryDescription AS GLDescription ,dbo.COASubSubsidiaries.FSFGLCode
FROM         dbo.COASubsidiaries RIGHT OUTER JOIN
                      dbo.COASubSubsidiaries ON dbo.COASubsidiaries.SubsidiaryCode = dbo.COASubSubsidiaries.SubsidiaryCode AND 
                      dbo.COASubsidiaries.ControlCode = dbo.COASubSubsidiaries.ControlCode AND dbo.COASubsidiaries.GeneralCode = dbo.COASubSubsidiaries.GeneralCode

GO
