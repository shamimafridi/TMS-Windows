USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteUserSecurities]    Script Date: 27-Jan-18 11:24:03 AM ******/
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
