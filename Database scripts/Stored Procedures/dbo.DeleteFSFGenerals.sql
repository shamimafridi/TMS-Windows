USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteFSFGenerals]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteFSFGenerals]
@ControlCode nchar(5)='',
@GeneralCode nchar(5)=''
AS
	IF @ControlCode <> '' and @GeneralCode<>''
		DELETE FROM FSFGenerals
		WHERE ( ControlCode= @ControlCode)  and (GeneralCode=@GeneralCode)

GO
