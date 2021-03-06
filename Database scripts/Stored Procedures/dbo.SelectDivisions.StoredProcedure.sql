USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectDivisions]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectDivisions]
@Option as  varchar(20)='',
@DivisionCode as varchar(10) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.Divisions.DivisionCode, dbo.Divisions.Division,DefinitionDate
		FROM        dbo.Divisions 
        ORDER BY DBO.Divisions.DivisionCode
ELSE IF @Option='SRHGRID'
	SELECT     *
		FROM         dbo.Divisions
	ORDER BY DivisionCode
ELSE IF @Option='COMBO'
	SELECT     DivisionCode ,Division
		FROM         dbo.Divisions
	ORDER BY DivisionCode
ELSE
	SELECT * FROM Divisions WHERE DivisionCode=@DivisionCode
    ORDER BY DBO.Divisions.DivisionCode

GO
