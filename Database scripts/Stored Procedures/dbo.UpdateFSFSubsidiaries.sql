USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateFSFSubsidiaries]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateFSFSubsidiaries]
@ControlCode char(10) = ''  ,
@GeneralCode char(10) = ''  ,
@GeneralDescription varchar(200),
@SubsidiaryCode char(10) = ''  ,
@ControlDescription varchar(100),
@SubsidiaryDescription varchar(100),
@DefinitionDate DateTime=Date,
@GUID as bigint=0,
@NewRecord as bigint

 AS 

Set @ControlCode =LEFT(@GeneralCode,1) 
Set @GeneralCode =substring(@GeneralCode,2, 1 ) 


	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO FSFSubsidiaries(ControlCode,GeneralCode,SubsidiaryCode,SubsidiaryDescription,DefinitionDate,GUID) 
				         VALUES  ( @ControlCode,@GeneralCode, @SubsidiaryCode,@SubsidiaryDescription ,@DefinitionDate,@GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE FSFSubsidiaries
		SET 
		DefinitionDate=@DefinitionDate,
		SubsidiaryDescription = @SubsidiaryDescription
		WHERE  (SubsidiaryCode=@SubsidiaryCode AND GeneralCode= @GeneralCode AND ControlCode=@ControlCode  )
 	     END

GO
