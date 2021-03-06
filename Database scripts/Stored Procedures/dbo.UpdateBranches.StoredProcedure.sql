USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateBranches]    Script Date: 03-Feb-18 9:47:12 PM ******/
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
