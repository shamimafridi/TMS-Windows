USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteUserSecurities]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteUserSecurities]
(
	@UserID char(100)
	
)
AS
	
	DELETE FROM UserSecurities
	WHERE (UserID = @UserID)

GO
