USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateOpeningBalances]    Script Date: 5/5/2018 9:17:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateOpeningBalances]
@ClosingDate Datetime='',
@GLCode char(12)='',
@GLDescription char(1)='',
@BranchCode char(12)='',
@BranchDescription char(1)='',

@BalanceAmount float=0,
@DivisionCode char(12)='',
@Division char(1)='',

@NewRecord as bigint
 AS 

 declare @debit as float=0
 declare @credit as float=0;
 
 if @BalanceAmount<0   
    begin
	 set  @credit = ABS( @BalanceAmount)
    end
    else
    begin
	   set @debit=ABS( @BalanceAmount)
   end
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO OpeningBalances(ClosingDate, BranchCode, DebitBalance, CreditBalance , GLCode,DivisionCode,GUID) 
				VALUES  ( @ClosingDate, @BranchCode, @debit,@credit ,@GLCode,@DivisionCode,'')
	     END
	ELSE 
	     BEGIN
		UPDATE OpeningBalances
		SET @ClosingDate=@ClosingDate,
		DebitBalance=@debit ,
		CreditBalance =@credit ,
		GLCode=@GLCode,
		DivisionCode=@DivisionCode

		WHERE  ( GLCode = @GLCode )	AND
			DivisionCode=@DivisionCode

 	     END
GO
