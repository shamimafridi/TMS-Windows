USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteDestinationPoints]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteDestinationPoints]
@DestinationPointCode nchar(5)=''
AS
	IF @DestinationPointCode <> ''
		DELETE FROM DestinationPoints 
		WHERE ( DestinationPointCode= @DestinationPointCode)

GO
