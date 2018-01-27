USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteStationPoints]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteStationPoints]
@StationPointCode nchar(5)=''
AS
	IF @StationPointCode <> ''
		DELETE FROM StationPoints 
		WHERE ( StationPointCode= @StationPointCode)

GO
