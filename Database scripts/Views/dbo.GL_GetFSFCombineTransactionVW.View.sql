USE [TMS_ALI]
GO
/****** Object:  View [dbo].[GL_GetFSFCombineTransactionVW]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--TMS
--drop  view GL_GetFSFCombineTransactionVW
create view [dbo].[GL_GetFSFCombineTransactionVW]
as
SELECT     dbo.FSFGenerals.ControlCode + dbo.FSFGenerals.GeneralCode AS GLCode, dbo.FSFGenerals.GeneralDescription AS GLDescription
FROM         dbo.FSFGenerals LEFT OUTER JOIN
                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode AND 
                      dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode
WHERE     (dbo.FSFSubsidiaries.SubsidiaryCode IS NULL)
UNION ALL
SELECT     dbo.FSFSubsidiaries.ControlCode + dbo.FSFSubsidiaries.GeneralCode + dbo.FSFSubsidiaries.SubsidiaryCode AS GLCode, 
                      dbo.FSFSubsidiaries.SubsidiaryDescription AS GLDescription 
FROM         dbo.FSFSubsidiaries LEFT OUTER JOIN
                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND 
                      dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode AND 
                      dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode
WHERE     dbo.FSFSubsidiaries.SubsidiaryCode IS NOT NULL AND dbo.FSFSubSubsidiaries.SubSubsidiaryCode IS NULL
UNION ALL
SELECT     dbo.FSFSubSubsidiaries.ControlCode + dbo.FSFSubSubsidiaries.GeneralCode + dbo.FSFSubSubsidiaries.SubsidiaryCode + dbo.FSFSubSubsidiaries.SubSubsidiaryCode
                       AS GLCode, dbo.FSFSubSubsidiaries.SubSubsidiaryDescription AS GLDescription 
FROM         dbo.FSFSubsidiaries RIGHT OUTER JOIN
                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode AND 
                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode

GO
