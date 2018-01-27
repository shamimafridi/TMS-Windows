USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateProducts]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateProducts]
@ProductCode char(3) = ''  ,
@ProductName varchar(100),
@UrduTitle nVarchar(200),
@DefinitionDate Datetime='',
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Products(ProductCode, ProductName,UrduTitle ,DefinitionDate) 
		VALUES  ( @ProductCode, @ProductName, @UrduTitle ,@DefinitionDate) 
	     END
	ELSE 
	     BEGIN
		UPDATE Products
		SET ProductCode=@ProductCode,
		DefinitionDate=@DefinitionDate,
		UrduTitle=@UrduTitle,
		ProductName = @ProductName
		WHERE  ( ProductCode = @ProductCode  )
 	     END

GO
