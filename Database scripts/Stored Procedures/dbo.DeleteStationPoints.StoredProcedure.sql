USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteStationPoints]    Script Date: 03-Feb-18 9:47:12 PM ******/
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
