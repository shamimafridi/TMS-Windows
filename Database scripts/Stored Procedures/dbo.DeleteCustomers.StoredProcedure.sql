USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCustomers]    Script Date: 03-Feb-18 9:47:12 PM ******/
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
