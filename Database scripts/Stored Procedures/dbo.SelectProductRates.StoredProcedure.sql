USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectProductRates]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectProductRates]
@Option as  varchar(20)='',
@EffectiveDate as datetime='',
@StationPointCode as char(3)='',
@DestinationPointCode as char(3)='',
@ProductCode as char(5) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.ProductRates.ProductCode, dbo.Products.ProductName, dbo.ProductRates.EffectiveDate, dbo.ProductRates.StationPointCode, 
                      dbo.StationPoints.StationPointName AS StationPointDescription, dbo.ProductRates.DestinationPointCode, dbo.DestinationPoints.DestinationPointName AS DestinationPointDescription, 
                      dbo.ProductRates.TripAdvanceAmount, dbo.ProductRates.Rate
		FROM         dbo.ProductRates INNER JOIN
                      dbo.StationPoints ON dbo.ProductRates.StationPointCode = dbo.StationPoints.StationPointCode INNER JOIN
                      dbo.DestinationPoints ON dbo.ProductRates.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      dbo.Products ON dbo.ProductRates.ProductCode = dbo.Products.ProductCode
ELSE IF @Option='SRHGRID'
		SELECT     TOP 100 PERCENT dbo.ProductRates.ProductCode, dbo.Products.ProductName, dbo.ProductRates.EffectiveDate, dbo.ProductRates.StationPointCode, 
                      dbo.StationPoints.StationPointName AS StationPointDescription, dbo.ProductRates.DestinationPointCode, 
                      dbo.DestinationPoints.DestinationPointName AS DestinationPointDescription, dbo.ProductRates.TripAdvanceAmount, dbo.ProductRates.Rate
		FROM         dbo.ProductRates INNER JOIN
                      dbo.StationPoints ON dbo.ProductRates.StationPointCode = dbo.StationPoints.StationPointCode INNER JOIN
                      dbo.DestinationPoints ON dbo.ProductRates.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      dbo.Products ON dbo.ProductRates.ProductCode = dbo.Products.ProductCode
		ORDER BY dbo.ProductRates.ProductCode , dbo.ProductRates.EffectiveDate desc
ELSE IF @Option='LASTVALUE'
		SELECT     TOP 1 Rate
	FROM         dbo.ProductRates
		WHERE dbo.ProductRates.ProductCode=@ProductCode and
			dbo.ProductRates.StationPointCode=@StationPointCode and
			 dbo.ProductRates.DestinationPointCode=@DestinationPointCode
		ORDER BY dbo.ProductRates.EffectiveDate desc
		
ELSE
	SELECT     dbo.ProductRates.ProductCode, dbo.Products.ProductName, dbo.ProductRates.EffectiveDate, dbo.ProductRates.StationPointCode, 
                      dbo.StationPoints.StationPointName AS StationPointDescription, dbo.ProductRates.DestinationPointCode, dbo.DestinationPoints.DestinationPointName AS DestinationPointDescription, 
                      dbo.ProductRates.TripAdvanceAmount, dbo.ProductRates.Rate
FROM         dbo.ProductRates INNER JOIN
                      dbo.StationPoints ON dbo.ProductRates.StationPointCode = dbo.StationPoints.StationPointCode INNER JOIN
                      dbo.DestinationPoints ON dbo.ProductRates.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode LEFT OUTER JOIN
                      dbo.Products ON dbo.ProductRates.ProductCode = dbo.Products.ProductCode
		WHERE dbo.ProductRates.ProductCode=@ProductCode and
		dbo.ProductRates.EffectiveDate=@EffectiveDate and
		 dbo.ProductRates.StationPointCode=@StationPointCode and
		 dbo.ProductRates.DestinationPointCode=@DestinationPointCode

GO
