USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateOrdersDetails]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateOrdersDetails]
 @OrderNature nchar(2) = ''  ,
 @OrderNumber varchar(16)=' '  ,
 @ItemCode  varchar(50)=' '  ,
 @Item  varchar(50)=' '  ,
@Quantity decimal=0.00,
@Price decimal=0.00,
@Amount varchar(100)='',
-- @Particuler  varchar(100) = '',
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
	--	DELETE FROM OrderDetails WHERE  ( OrderNature = @OrderNature AND DocumentNo=@DocumentNo ) 

		INSERT INTO OrderDetails ( OrderNature ,OrderNumber, ItemCode,Quantity,Price ) 
		                                         VALUES  ( @OrderNature ,@OrderNumber  ,@ItemCode,@Quantity ,@Price ) 
	     END
	ELSE 
	     BEGIN
		UPDATE OrderDetails
		Set  
			ItemCode=@ItemCode,
			Quantity=@Quantity,
			Price=@Price
--			Amount=@Particuler
		WHERE  ( OrderNature = @OrderNature AND OrderNumber=@OrderNumber ) 
 	     END

GO
