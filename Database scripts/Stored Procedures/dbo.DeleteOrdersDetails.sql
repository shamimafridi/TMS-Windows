USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteOrdersDetails]    Script Date: 27-Jan-18 11:24:03 AM ******/
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
