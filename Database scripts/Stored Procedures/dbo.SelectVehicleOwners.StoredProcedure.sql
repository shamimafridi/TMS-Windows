USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleOwners]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectVehicleOwners]
@Option as  varchar(20)='',
@OwnerCode as varchar(10) =''

AS

IF 	@Option='ALL' 
		SELECT     *
		FROM         dbo.VehicleOwners LEFT OUTER JOIN
                      dbo.Cities ON dbo.VehicleOwners.CityCode = dbo.Cities.CityCode
        ORDER BY dbo.VehicleOwners.OwnerCode
 ELSE IF @Option='AUTO' 
		SELECT     Top 1 OwnerCode+1 as OwnerCode
		FROM         dbo.VehicleOwners
		order by OwnerCode desc
ELSE IF @Option='SRHGRID'
		SELECT     TOP 100 PERCENT *, dbo.Cities.City AS Expr1
		FROM         dbo.VehicleOwners LEFT OUTER JOIN
		                      dbo.Cities ON dbo.VehicleOwners.CityCode = dbo.Cities.CityCode
		ORDER BY dbo.VehicleOwners.OwnerCode

ELSE
	SELECT     *
	FROM         dbo.VehicleOwners LEFT OUTER JOIN
        dbo.Cities ON dbo.VehicleOwners.CityCode = dbo.Cities.CityCode 
	WHERE OwnerCode=@OwnerCode

GO
