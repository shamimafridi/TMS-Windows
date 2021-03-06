USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectGeneratedReferences]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[SelectGeneratedReferences]

@GenFrom varchar(3) = '' ,
@FormName varchar(100) = '' ,
@TransactionNature char(3) = 0 ,
@TransactionNo varchar (10) = '',
@BranchCode char(3)  = '' ,
@DocumentNature char(3) = '' ,
@DocumentNo varchar (10) = 0 ,
@ChequeNo as varchar(50) = '',
@BankCode as bigint = 0 ,
@OPTION Varchar(50)='' 
  
AS 


IF @OPTION='CHECK_IF_EXIST'
	BEGIN

	SELECT     dbo.GeneratedReferences.*, dbo.Branches.BranchCode AS BranchCode, dbo.Branches.BranchDescription AS BranchName
	FROM         dbo.GeneratedReferences LEFT OUTER JOIN
	                      dbo.Branches ON dbo.GeneratedReferences.BranchCode = dbo.Branches.BranchCode
	WHERE     (dbo.GeneratedReferences.GenFrom = @GenFrom) AND 
		  (dbo.GeneratedReferences.BranchCode = @BranchCode) AND 
		  (dbo.GeneratedReferences.FormName = @FormName) AND 
		  (dbo.GeneratedReferences.TransactionNature = @TransactionNature) AND 
	          (dbo.GeneratedReferences.TransactionNo = @TransactionNo) AND 
		  (dbo.GeneratedReferences.DocumentNature = @DocumentNature) OR @DocumentNature=''
	END

GO
