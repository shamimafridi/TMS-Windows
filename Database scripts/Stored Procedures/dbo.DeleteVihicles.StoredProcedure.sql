USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteVihicles]    Script Date: 03-Feb-18 9:47:12 PM ******/
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
