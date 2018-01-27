USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteProducts]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteProducts]
@ProductCode nchar(5)=''
AS
	IF @ProductCode <> ''
		DELETE FROM Products 
		WHERE ( ProductCode= @ProductCode)

GO
