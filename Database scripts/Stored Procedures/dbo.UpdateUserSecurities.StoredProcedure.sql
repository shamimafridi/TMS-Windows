USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateUserSecurities]    Script Date: 03-Feb-18 9:47:12 PM ******/
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
