USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteFSFSubsidiaries]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteFSFSubsidiaries]
@ControlCode char(5)='',
@GeneralCode char(10)='',
@SubsidiaryCode1 char(10)='',
@SubsidiaryCode char(10)='',
@SubSubsidiaryCode char(10)=''
AS


Set @ControlCode =LEFT(@GeneralCode, 1)    --  1
Set @GeneralCode =SUBSTRING(@GeneralCode, 2 ,1)  -- 001
--Set @SubsidiaryCode1 =SUBSTRING(@SubsidiaryCode1, 5,8)


	IF @ControlCode <> '' and @GeneralCode<>'' and @SubsidiaryCode<>'' 
		DELETE FROM FSFSubsidiaries
		WHERE ( ControlCode= @ControlCode)  and (GeneralCode=@GeneralCode) and  (SubsidiaryCode=@SubsidiaryCode)

GO
