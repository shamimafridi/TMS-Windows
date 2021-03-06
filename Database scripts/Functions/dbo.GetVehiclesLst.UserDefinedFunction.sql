USE [TMS_ALI]
GO
/****** Object:  UserDefinedFunction [dbo].[GetVehiclesLst]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetVehiclesLst] ( @VehicleCode varchar(max),@System as Char(10)='' )
RETURNS @VehicleCodeList TABLE
   (
	VehicleCode  varchar( max ) 
	
   )

AS
BEGIN
	DECLARE @Pattern  as varchar( max )
	SET @Pattern = LTRIM ( RTRIM ( @VehicleCode ) )
	
	IF LEFT ( @Pattern  , 1 ) <> ','
		SET @Pattern = ',' + @Pattern
	IF RIGHT (  @Pattern  , 1 ) <> ','
		SET @Pattern = @Pattern + ','
	
	INSERT @VehicleCodeList 
		SELECT     VehicleCode
			FROM         dbo.Vehicles
	                   WHERE @Pattern LIKE '%,' +  LTRIM ( RTRIM ( dbo.Vehicles.VehicleCode ) )  + ',%' OR @Pattern = ',' 
	
   RETURN
END

GO
