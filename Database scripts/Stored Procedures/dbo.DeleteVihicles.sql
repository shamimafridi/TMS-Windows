USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteVihicles]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteVihicles]
@VihicleCode nchar(8)=''
AS
	IF @VihicleCode <> ''
		DELETE FROM Vihicles 
		WHERE ( VihicleCode= @VihicleCode)

GO
