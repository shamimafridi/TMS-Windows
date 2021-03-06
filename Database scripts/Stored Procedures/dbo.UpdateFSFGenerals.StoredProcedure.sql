USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateFSFGenerals]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateFSFGenerals]
@ControlCode char(3) = ''  ,
@ControlDescription varchar(100),
@GeneralCode char(4) = ''  ,
@GeneralDescription as  varchar(100)='',
@DefinitionDate DateTime='',
@GUID as bigint=0,
@NewRecord as bigint
 AS 
--set @ControlCode =left(@GeneralCode,1) 
--set @GeneralCode =right(@GeneralCode,3) 
--Select  @GeneralCode as gen
--select @ControlCode as con
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO FSFGenerals(ControlCode,GeneralCode, GeneralDescription,DefinitionDate,GUID) 
				VALUES  ( @ControlCode,@GeneralCode, @GeneralDescription ,@DefinitionDate,@GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE FSFGenerals
		SET 
		DefinitionDate=@DefinitionDate,
		GeneralDescription = @GeneralDescription
		WHERE  (GeneralCode= @GeneralCode and ControlCode=@ControlCode )
 	     END

GO
