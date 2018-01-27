USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteBranches]    Script Date: 27-Jan-18 11:24:03 AM ******/
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
