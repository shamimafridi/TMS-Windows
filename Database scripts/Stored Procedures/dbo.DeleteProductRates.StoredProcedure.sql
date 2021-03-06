USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteProductRates]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteProductRates]

@ProductCode as char(5)='',
@FromRegionCode as char(3)='',
@ToRegionCode as  char(3)='',
@EffectiveDate as  Datetime=''
AS

	IF @ProductCode <> '' AND @EffectiveDate <>'' AND @FromRegionCode <>'' AND @ToRegionCode <>''
		DELETE FROM ProductRates 
		WHERE dbo.ProductRates.ProductCode=@ProductCode and
			dbo.ProductRates.EffectiveDate=@EffectiveDate and
			 dbo.ProductRates.StationPointCode=@FromRegionCode and
			 dbo.ProductRates.DestinationPointCode=@ToRegionCode

GO
