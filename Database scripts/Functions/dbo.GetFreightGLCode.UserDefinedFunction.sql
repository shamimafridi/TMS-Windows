USE [TMS_ALI]
GO
/****** Object:  UserDefinedFunction [dbo].[GetFreightGLCode]    Script Date: 03-Feb-18 9:47:12 PM ******/
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
