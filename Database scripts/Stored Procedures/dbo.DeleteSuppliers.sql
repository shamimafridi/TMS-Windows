USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteSuppliers]    Script Date: 27-Jan-18 11:24:03 AM ******/
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
