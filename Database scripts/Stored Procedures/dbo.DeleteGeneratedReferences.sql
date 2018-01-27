USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteGeneratedReferences]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteGeneratedReferences]

@GenFrom varchar(10) = '' ,
@FormName varchar(50) = '' ,
@TransactionNature char(3) = '' ,
@TransactionNo varchar (10) = '',
@BranchCode char(3)  = '' ,
@DocumentNature char(10) = '' ,
@DocumentNo varchar (10) = '' 

AS 
	IF  EXISTS ( SELECT * FROM  GeneratedReferences  WHERE  GenFrom = @GenFrom AND
			   FormName = @FormName AND  
			   TransactionNature = @TransactionNature AND 
			   BranchCode = @BranchCode and
			   TransactionNo = @TransactionNo AND 
			   DocumentNature = @DocumentNature )
		
	     BEGIN
		--print 'Exist'
		Delete   from  GeneratedReferences
		WHERE  GenFrom = @GenFrom AND  
			   FormName = @FormName AND  
			   TransactionNature = @TransactionNature AND 
			   TransactionNo = @TransactionNo AND 
			   BranchCode = @BranchCode and
			   DocumentNature = @DocumentNature
 	     END

GO
