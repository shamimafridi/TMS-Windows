USE [TMS_ALI]
GO
/****** Object:  UserDefinedFunction [dbo].[DateToKey]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE FUNCTION  [dbo].[DateToKey] ( @DateValue as datetime )  
RETURNS varchar(4)  
AS  
BEGIN 
	DECLARE @ReturnValue as varchar( 4 )
	SET @ReturnValue = Right( Year(@DateValue) , 2 ) + REPLICATE( '0' , 2 - LEN( Month(@DateValue) ) ) + CONVERT( Varchar(10), Month(@DateValue) )
	RETURN @ReturnValue
END

GO
