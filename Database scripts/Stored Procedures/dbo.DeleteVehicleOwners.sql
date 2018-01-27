USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteVehicleOwners]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteVehicleOwners]
@OwnerCode nchar(5)=''
AS
	IF @OwnerCode <> ''
		DELETE From VehicleOwners Where ( OwnerCode= @OwnerCode)

GO
