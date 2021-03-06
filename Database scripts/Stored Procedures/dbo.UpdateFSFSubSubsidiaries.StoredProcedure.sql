USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateFSFSubSubsidiaries]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateFSFSubSubsidiaries]
@ControlCode char(2) = ''  ,
@GeneralCode char(3) = '' ,
@SubsidiaryCode1   char(9) = ''  ,
@ControlDescription varchar(100),
@GeneralDescription varchar(100),
@SubsidiaryDescription varchar(100),
@SubSubsidiaryCode char(10) = ''  ,
@SubSubsidiaryDescription varchar(100),
@DefinitionDate DateTime=Date,
@GUID as bigint=0,
@NewRecord as bigint

 AS 
                            ------- example @Subsidiarycode1 = 01 01 0001         =9 degit
Set @ControlCode =LEFT(@SubsidiaryCode1,1)    --  1
Set @GeneralCode =SUBSTRING(@SubsidiaryCode1, 2 ,1)  -- 001
Set @SubsidiaryCode1 =SUBSTRING(@SubsidiaryCode1, 3,5)   --- 1 001 00001
--print @SubsidiaryCode1
--print @GeneralCode
--print @ControlCode



	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO FSFSubSubsidiaries(ControlCode,GeneralCode,SubsidiaryCode,SubSubsidiaryCode,SubSubsidiaryDescription,DefinitionDate,GUID) 
				         VALUES  ( @ControlCode,@GeneralCode, @SubsidiaryCode1, @SubSubsidiaryCode, @SubSubsidiaryDescription ,@DefinitionDate,@GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE FSFSubSubsidiaries
		SET 
		DefinitionDate=@DefinitionDate,
		SubSubsidiaryDescription = @SubSubsidiaryDescription
		WHERE  (SubSubsidiaryCode=@SubSubsidiaryCode AND SubsidiaryCode=@SubsidiaryCode1 AND GeneralCode= @GeneralCode AND ControlCode=@ControlCode  )
 	     END

GO
