USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteDivisions]    Script Date: 27-Jan-18 11:24:03 AM ******/
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
