USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteProductValues]    Script Date: 03-Feb-18 9:47:12 PM ******/
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
