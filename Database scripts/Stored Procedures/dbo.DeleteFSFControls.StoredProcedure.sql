USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteFSFControls]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteFSFControls]
@ControlCode nchar(5)=''
AS
	IF @ControlCode <> ''
		DELETE FROM FSFControls
		WHERE ( ControlCode= @ControlCode)

GO
