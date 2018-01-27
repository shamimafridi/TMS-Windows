USE [TMS_ALI]
GO
/****** Object:  UserDefinedFunction [dbo].[KeyValue]    Script Date: 27-Jan-18 11:27:48 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE FUNCTION  [dbo].[KeyValue]( @DateValue as varchar(4) , @TransNo as varchar(10)  )  
RETURNS  varchar(10)  AS  
BEGIN 
	DECLARE @ReferenceNo as bigint
	DECLARE @TransactionNo as varchar(10)
		
	SET @ReferenceNo = SUBSTRING ( ISNULL ( @TransNo , '000000' ) , 5 , 6 ) + 1
	SET @TransactionNo = @DateValue + REPLICATE ( '0', 6 - LEN(@ReferenceNo)) + CONVERT(VARCHAR(10),@ReferenceNo)
	SET @TransactionNo = CONVERT (VARCHAR(10),@TransactionNo )
	RETURN @TransactionNo 
END

GO
