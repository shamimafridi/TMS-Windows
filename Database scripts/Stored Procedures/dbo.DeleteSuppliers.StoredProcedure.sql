USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteSuppliers]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteSuppliers]
@SupplierCode char(10)=''
AS
	IF @SupplierCode <> ''
		DELETE From Suppliers Where ( SupplierCode= @SupplierCode)

GO
