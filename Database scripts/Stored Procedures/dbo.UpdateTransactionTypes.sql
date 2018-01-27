USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateTransactionTypes]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateTransactionTypes]
@TransactionTypeCode char(3) = ''  ,
@TransactionType varchar(100) = ''  ,
@NatureCode varchar(3)='',
@Nature varchar(3)='',
@UrduTitle nvarchar(100)='',
@DefinitionDate Datetime='',
@GLCode char(12)='',
@GLDescription char(1)='',
@NewRecord as bigint
 AS 



	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO TransactionTypes(TransactionTypeCode, Nature, TransactionType, UrduTitle , DefinitionDate,GLCode ) 
				VALUES  ( @TransactionTypeCode, @NatureCode, @TransactionType,@UrduTitle ,@DefinitionDate,@GLCode)
	     END
	ELSE 
	     BEGIN
		UPDATE TransactionTypes
		SET TransactionTypeCode=@TransactionTypeCode,
		TransactionType=@TransactionType ,
		UrduTitle =@UrduTitle ,
		GLCode=@GLCode,
		DefinitionDate=@DefinitionDate

		WHERE  ( TransactionTypeCode = @TransactionTypeCode  )	AND
			Nature=@NatureCode

 	     END

GO
