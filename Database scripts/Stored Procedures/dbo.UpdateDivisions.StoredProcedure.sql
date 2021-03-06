USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateDivisions]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateDivisions]
@DivisionCode char(10) = ''  ,
@Division varchar(100),
@DefinitionDate Datetime='',
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Divisions(DivisionCode, Division,DefinitionDate) 
		VALUES  ( @DivisionCode, @Division ,@DefinitionDate) 
	     END
	ELSE 
	     BEGIN
		UPDATE Divisions
		SET DivisionCode=@DivisionCode,
		DefinitionDate=@DefinitionDate,
		Division = @Division
		WHERE  ( DivisionCode = @DivisionCode  )
 	     END

GO
