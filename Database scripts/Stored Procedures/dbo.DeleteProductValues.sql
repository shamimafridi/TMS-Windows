USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteProductValues]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteProductValues]

@ProductCode as char(5)='',
@EffectiveDate as  Datetime=''
AS

	IF @ProductCode <> '' AND @EffectiveDate <>'' 
		DELETE FROM ProductValues 
		WHERE dbo.ProductValues.ProductCode=@ProductCode and
			dbo.ProductValues.EffectiveDate=@EffectiveDate

GO
