USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateFSFControls]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateFSFControls]
@ControlCode char(3) = ''  ,
@ControlDescription varchar(100),
@DefinitionDate DateTime=Date,
@GUID as bigint=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO FSFControls(ControlCode, ControlDescription,DefinitionDate,GUID) 
		VALUES  ( @ControlCode, @ControlDescription ,@DefinitionDate,@GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE FSFControls
		SET ControlCode=@ControlCode,
		DefinitionDate=@DefinitionDate,
		ControlDescription = @ControlDescription
		WHERE  (ControlCode = @ControlCode  )
 	     END

GO
