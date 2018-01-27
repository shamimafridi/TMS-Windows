USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteFSFSubSubsidiaries]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteFSFSubSubsidiaries]
@ControlCode nchar(5)='',
@GeneralCode nchar(10)='',
@SubsidiaryCode1 nchar(10)='',
@SubSubsidiaryCode nchar(10)=''
AS


Set @ControlCode =LEFT(@SubsidiaryCode1,1)    --  1
Set @GeneralCode =SUBSTRING(@SubsidiaryCode1, 2 ,1)  -- 001
Set @SubsidiaryCode1 =SUBSTRING(@SubsidiaryCode1, 3,5)


	IF @ControlCode <> '' and @GeneralCode<>'' and @SubsidiaryCode1<>'' and @SubSubsidiaryCode <>''
		DELETE FROM FSFSubSubsidiaries
		WHERE ( ControlCode= @ControlCode)  and (GeneralCode=@GeneralCode) and  (SubsidiaryCode=@SubsidiaryCode1) and (SubSubsidiaryCode=@SubSubsidiaryCode)

GO
