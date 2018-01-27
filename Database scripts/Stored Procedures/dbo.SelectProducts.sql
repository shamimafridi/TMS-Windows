USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectProducts]    Script Date: 27-Jan-18 11:24:03 AM ******/
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
