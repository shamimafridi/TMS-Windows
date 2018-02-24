USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteVehicles]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
alter  PROCEDURE [dbo].[DeleteVehicles]
@VehicleCode nchar(10)=''
AS
	IF @VehicleCode <> ''
		BEGIN
			DELETE FROM Vehicles
			WHERE ( VehicleCode= @VehicleCode);
		
			DELETE FROM Divisions 
			WHERE ( DivisionCode= @VehicleCode)
		
		END

GO
