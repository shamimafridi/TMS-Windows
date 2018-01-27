USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateUserSecurities]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateUserSecurities]
@UserID varchar(25) = ''  ,
@UserName varchar(100)='',
@Password as varchar(100)='',
@IsAdministrator as bit=0,
@IsActive bit=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO UserSecurities(UserID, UserName,Password,IsAdministrator,IsActive) 
		VALUES  ( @UserID, @UserName,@Password,@IsAdministrator,@IsActive ) 
	     END
	ELSE 
	     BEGIN
		UPDATE UserSecurities
		SET UserName=@UserName,
		IsActive = @IsActive,
Password=@Password,
	IsAdministrator=@IsAdministrator

		WHERE  ( UserID = @UserID  )
 	     END

GO
