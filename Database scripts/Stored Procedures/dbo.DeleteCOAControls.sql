USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCOAControls]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteCOAControls]
@ControlCode nchar(5)=''
AS
	IF @ControlCode <> ''
		DELETE FROM COAControls
		WHERE ( ControlCode= @ControlCode)

GO
