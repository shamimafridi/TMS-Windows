USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteDestinationPoints]    Script Date: 27-Jan-18 11:24:03 AM ******/
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
