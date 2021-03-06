USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectBranches]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectBranches]
@Option as  varchar(20)='',
@BranchCode as varchar(10) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.Branches.BranchCode, dbo.Branches.BranchDescription AS Branchname, dbo.Branches.DefinitionDate, dbo.GL_GetCOACombineVW.GLCode, 
			dbo.GL_GetCOACombineVW.GLDescription
		FROM         dbo.Branches LEFT OUTER JOIN
			dbo.GL_GetCOACombineVW ON dbo.Branches.GLCode = dbo.GL_GetCOACombineVW.GLCode
ELSE IF @Option='SRHGRID'
	SELECT     dbo.Branches.BranchCode, dbo.Branches.BranchDescription AS Branchname, dbo.Branches.DefinitionDate, dbo.GL_GetCOACombineVW.GLCode, 
                      dbo.GL_GetCOACombineVW.GLDescription
	FROM         dbo.Branches LEFT OUTER JOIN
                      dbo.GL_GetCOACombineVW ON dbo.Branches.GLCode = dbo.GL_GetCOACombineVW.GLCode
	ORDER BY dbo.Branches.BranchCode
ELSE
	SELECT     dbo.Branches.BranchCode, dbo.Branches.BranchDescription AS Branchname, dbo.Branches.DefinitionDate, dbo.GL_GetCOACombineVW.GLCode, 
                      dbo.GL_GetCOACombineVW.GLDescription
	FROM         dbo.Branches LEFT OUTER JOIN
                      dbo.GL_GetCOACombineVW ON dbo.Branches.GLCode = dbo.GL_GetCOACombineVW.GLCode
        WHERE dbo.Branches.BranchCode =@BranchCode

GO
