USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteOrdersDetails]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteOrdersDetails]

@Option as  varchar(3)='',
@OrderNumber as integer =0,
@OrderNature as  varchar(3)=''
AS

IF 	@Option='ALL' 
	DELETE  FROM OrderDetails 
ELSE
	DELETE FROM OrderDetails WHERE OrderNumber=@OrderNumber AND OrderNature=@OrderNature

GO
