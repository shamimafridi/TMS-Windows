USE [TMS_ALI]
GO
/****** Object:  UserDefinedFunction [dbo].[GetFreightGLCode]    Script Date: 27-Jan-18 11:27:48 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE FUNCTION [dbo].[GetFreightGLCode](@FromVehicleCode as varchar(10)='',@ToVehicleCode as varchar(10)='')

RETURNS varchar(8000)

AS
BEGIN

DECLARE @GLCode varchar(8000)

SET @GLCode  = ''


	SELECT @GLCode =

	Case @GLCode  
	WHEN '' THEN ISNULL(FreightGLCode , '')
	ELSE  ISNULL(FreightGLCode,'')  + ',' + ISNULL(@GLCode , '')
	END
	From
	dbo.Vehicles
	WHERE VehicleCode BETWEEN  @FromVehicleCode and @ToVehicleCode



RETURN(@GLCode )

END

GO
