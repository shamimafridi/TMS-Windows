USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteProducts]    Script Date: 03-Feb-18 9:47:12 PM ******/
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
