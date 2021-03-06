USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectProducts]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectProducts]
@Option as  varchar(20)='',
@ProductCode as varchar(10) =''


AS

IF	@Option='ALL' 
		SELECT     dbo.Products.ProductCode, dbo.Products.ProductName,DefinitionDate,UrduTitle
		FROM        dbo.Products 
        ORDER BY DBO.Products.ProductCode 
ELSE IF @Option='SRHGRID'
	SELECT     *
		FROM         dbo.Products
	ORDER BY ProductCode
ELSE
	SELECT * FROM Products WHERE ProductCode=@ProductCode
    ORDER BY DBO.Products.ProductCode

GO
