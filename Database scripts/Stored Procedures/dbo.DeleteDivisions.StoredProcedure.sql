USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteDivisions]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteDivisions]
@DivisionCode nchar(10)=''
AS
	IF @DivisionCode <> ''
		DELETE FROM Divisions 
		WHERE ( DivisionCode= @DivisionCode)

GO
