USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteSuppliersDetails]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteSuppliersDetails]

@Option as  varchar(3)='',
@SupplierCode as varchar(10) ='',
@ItemCode as varchar(7)=''
AS

IF 	@Option='ALL' 
	DELETE  FROM TransactionDetails 
ELSE
	DELETE FROM ItemSuppliers WHERE SupplierCode=@SupplierCode

GO
