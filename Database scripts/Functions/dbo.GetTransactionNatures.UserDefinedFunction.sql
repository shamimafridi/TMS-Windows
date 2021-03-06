USE [TMS_ALI]
GO
/****** Object:  UserDefinedFunction [dbo].[GetTransactionNatures]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetTransactionNatures] ( @NatureCode varchar(2000),@System as Char(10)='' )
RETURNS @TransNatureList TABLE
   (
	Nature  varchar( 100 ) ,
	Term  varchar ( 50 ),
	NatureCode  varchar( 100 ) 
	
   )

AS
BEGIN
	DECLARE @Pattern  as varchar( 2004 )
	SET @Pattern = LTRIM ( RTRIM ( @NatureCode ) )
	
	IF LEFT ( @Pattern  , 1 ) <> ','
		SET @Pattern = ',' + @Pattern
	IF RIGHT (  @Pattern  , 1 ) <> ','
		SET @Pattern = @Pattern + ','
	
	INSERT @TransNatureList 
		SELECT     Nature, Term, NatureCode
			FROM         dbo.TransactionNatures
	                   WHERE @Pattern LIKE '%,' +  LTRIM ( RTRIM ( dbo.TransactionNatures.NatureCode ) )  + ',%' OR @Pattern = ',' AND [System]=@System
	
   RETURN
END

GO
