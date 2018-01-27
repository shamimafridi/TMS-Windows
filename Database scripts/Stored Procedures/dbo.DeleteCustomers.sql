USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomers]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteCustomers]
@CustomerCode nchar(5)=''
AS
	IF @CustomerCode <> ''
		DELETE From Customers Where ( CustomerCode= @CustomerCode)

GO
