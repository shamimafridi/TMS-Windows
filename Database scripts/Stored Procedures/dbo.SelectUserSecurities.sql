USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectUserSecurities]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SelectUserSecurities] (  @UserName varchar(100) = ''  , @Password varchar(50) = ''  , @EmpCode varchar(10) = ''  , @IsLoggedIn bit = 0  , @IsAdministrator bit = 0  , @NormalShutDown bit = 0  , @IsActive bit = 0  , @S_Account varchar(3) = ''  , @T_Order varchar(3) = ''  , @R_RecVoucher bit = 0  , @Option as  varchar(20)='',@UserID as varchar(25) ='')
 AS 

IF 	@Option='ALL' 
		SELECT     *
		FROM         dbo.UserSecurities
ELSE IF @Option='SRHGRID' 
	SELECT * FROM dbo.UserSecurities
	ORDER BY UserID
ELSE
	SELECT     UserID, UserName, IsLoggedIn, IsAdministrator,Password,IsActive
	FROM         dbo.UserSecurities WHERE UserID=@UserID

GO
