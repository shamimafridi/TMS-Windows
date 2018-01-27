USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCOAGenerals]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateCOAGenerals]
@ControlCode char(3) = ''  ,
@ControlDescription varchar(100),
@GeneralCode char(4) = ''  ,
@GeneralDescription as  varchar(100)='',
@DefinitionDate DateTime='',
@FSFGLCode char(14) = ''  ,
@FSFGLDescription char(14) = ''  ,
@GUID as bigint=0,
@NewRecord as bigint
 AS 
--set @ControlCode =left(@GeneralCode,1) 
--set @GeneralCode =right(@GeneralCode,3) 
--Select  @GeneralCode as gen
--select @ControlCode as con
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO COAGenerals(ControlCode,GeneralCode, GeneralDescription,DefinitionDate,GUID,FSFGLCode) 
				VALUES  ( @ControlCode,@GeneralCode, @GeneralDescription ,@DefinitionDate,@GUID,@FSFGLCode) 
	     END
	ELSE 
	     BEGIN
		UPDATE COAGenerals
		SET 
		DefinitionDate=@DefinitionDate,
		GeneralDescription = @GeneralDescription,
		FSFGLCode=@FSFGLCode
		WHERE  (GeneralCode= @GeneralCode and ControlCode=@ControlCode )
 	     END

GO
