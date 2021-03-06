USE [TMS_ALI]
GO
/****** Object:  View [dbo].[GL_GetFSFCombineVW]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GL_GetFSFCombineVW]
AS
SELECT     ControlCode + GeneralCode AS GLCode, GeneralDescription AS GLDescription
FROM         dbo.FSFGenerals
UNION ALL
SELECT     dbo.FSFSubsidiaries.ControlCode + dbo.FSFSubsidiaries.GeneralCode + dbo.FSFSubsidiaries.SubsidiaryCode AS GLCode, dbo.FSFSubsidiaries.SubsidiaryDescription AS GlDescription

FROM         dbo.FSFSubsidiaries LEFT OUTER JOIN
                      dbo.FSFGenerals ON dbo.FSFSubsidiaries.GeneralCode = dbo.FSFGenerals.GeneralCode AND dbo.FSFSubsidiaries.ControlCode = dbo.FSFGenerals.ControlCode
UNION ALL
SELECT     dbo.FSFSubSubsidiaries.ControlCode + dbo.FSFSubSubsidiaries.GeneralCode + dbo.FSFSubSubsidiaries.SubsidiaryCode + dbo.FSFSubSubsidiaries.SubSubsidiaryCode AS GLCode, dbo.FSFSubSubsidiaries.SubSubsidiaryDescription AS GlDescription

FROM         dbo.FSFGenerals RIGHT OUTER JOIN
                      dbo.FSFSubsidiaries ON dbo.FSFGenerals.GeneralCode = dbo.FSFSubsidiaries.GeneralCode AND 
                      dbo.FSFGenerals.ControlCode = dbo.FSFSubsidiaries.ControlCode RIGHT OUTER JOIN
                      dbo.FSFSubSubsidiaries ON dbo.FSFSubsidiaries.SubsidiaryCode = dbo.FSFSubSubsidiaries.SubsidiaryCode AND 
                      dbo.FSFSubsidiaries.ControlCode = dbo.FSFSubSubsidiaries.ControlCode AND dbo.FSFSubsidiaries.GeneralCode = dbo.FSFSubSubsidiaries.GeneralCode

GO
