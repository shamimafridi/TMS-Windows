USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectSuppliers]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectSuppliers]
@Option as  varchar(20)='',
@SupplierCode as varchar(10) =''

AS

IF 	@Option='ALL' 
		SELECT     *
		FROM         dbo.Suppliers LEFT OUTER JOIN
                      dbo.Cities ON dbo.Suppliers.CityCode = dbo.Cities.CityCode
ELSE IF @Option='AUTO' 
		SELECT     Top 1 SupplierCode+1 as SupplierCode
		FROM         dbo.Suppliers
		order by SupplierCode desc
ELSE IF @Option='SRHGRID'
	SELECT     *
		FROM         dbo.Suppliers 
ELSE
	SELECT * FROM Suppliers WHERE SupplierCode=@SupplierCode

GO
