USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteVehicles]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[DeleteVehicles]
@VehicleCode nchar(10)=''
AS
	IF @VehicleCode <> ''
		DELETE FROM Vehicles
		WHERE ( VehicleCode= @VehicleCode)

GO
