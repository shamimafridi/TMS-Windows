USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteBranches]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteBranches]
@BranchCode nchar(5)=''
AS
	IF @BranchCode <> ''
		DELETE FROM Branches 
		WHERE ( BranchCode= @BranchCode)

GO
