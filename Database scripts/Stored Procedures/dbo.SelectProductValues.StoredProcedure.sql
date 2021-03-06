USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectProductValues]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectProductValues]
@Option as  varchar(20)='',
@EffectiveDate as datetime='',
@ProductCode as char(5) =''

AS

IF	@Option='ALL' 
		SELECT     dbo.ProductValues.ProductCode, dbo.Products.ProductName, dbo.ProductValues.EffectiveDate, dbo.ProductValues.QuantityValue
		FROM         dbo.ProductValues LEFT OUTER JOIN
		      dbo.Products ON dbo.ProductValues.ProductCode = dbo.Products.ProductCode
ELSE IF @Option='SRHGRID'
		SELECT     dbo.ProductValues.ProductCode, dbo.Products.ProductName, dbo.ProductValues.EffectiveDate, dbo.ProductValues.QuantityValue
		FROM         dbo.ProductValues LEFT OUTER JOIN
		dbo.Products ON dbo.ProductValues.ProductCode = dbo.Products.ProductCode
		ORDER BY dbo.ProductValues.ProductCode
ELSE IF @Option='LASTVALUE'
		SELECT    TOP 1 dbo.ProductValues.QuantityValue
		FROM         dbo.ProductValues 
		ORDER BY dbo.ProductValues.EffectiveDate Desc
ELSE
			SELECT     dbo.ProductValues.ProductCode, dbo.Products.ProductName, dbo.ProductValues.EffectiveDate, dbo.ProductValues.QuantityValue
		FROM         dbo.ProductValues LEFT OUTER JOIN
		      dbo.Products ON dbo.ProductValues.ProductCode = dbo.Products.ProductCode
		WHERE dbo.ProductValues.ProductCode=@ProductCode and
		dbo.ProductValues.EffectiveDate=@EffectiveDate

GO
