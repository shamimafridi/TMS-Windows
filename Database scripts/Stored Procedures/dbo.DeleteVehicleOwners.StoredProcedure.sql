USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteVehicleOwners]    Script Date: 03-Feb-18 9:47:12 PM ******/
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
