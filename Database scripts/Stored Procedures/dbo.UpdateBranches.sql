USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateBranches]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateBranches]
@BranchCode char(3) = ''  ,
@BranchName varchar(100),
@DefinitionDate Datetime='',
@GLCode  char(14)='',
@GLDescription  char(14)='',
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Branches(BranchCode, BranchDescription,DefinitionDate, GLCode) 
		VALUES  ( @BranchCode, @BranchName ,@DefinitionDate, @GLCode) 
	     END
	ELSE 
	     BEGIN
		UPDATE Branches
		SET BranchCode=@BranchCode,
		DefinitionDate=@DefinitionDate,
		BranchDescription = @BranchName,
		GLCode=@GLCode
		WHERE  ( BranchCode = @BranchCode  )
 	     END

GO
