USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCustomers]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateCustomers] 

@CustomerCode varchar(5) = ''  ,
@CustomerName varchar(100)=' '  ,
@UrduTitle nVarchar(200)='',
@Address  varchar(200) = '',
@NIC  varchar(30) = '',
@PostalCode  varchar(50) = '',
@City varchar(10)='',
@CityCode char(3)='',
@GLCode char(14)='',
@GLDescription char(14),
@ShortageGLCode char(14)='',
@WHTaxGLCode char(14),
@WHTaxGLDescription char(14)='',
@ShortageGLDescription char(14)='',
@Fax varchar(50)='',
@Email varchar(100)='',
@TelePhone varchar(100),
@NationalTaxNumber varchar(100),
@SalesTaxNumber varchar(30),
@DefinitionDate varchar(100)='',
@GUID as bigint=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Customers( CustomerCode ,CustomerName, UrduTitle ,Address, CityCode,TelePhone,Fax,NationalTaxNumber,SalesTaxNumber,PostalCode,DefinitionDate, ShortageGLCode,   GLCode,WHTaxGLCode, GUID) 
		VALUES  ( @CustomerCode ,@CustomerName,@UrduTitle ,@Address, @CityCode,@TelePhone,@Fax,@NationalTaxNumber,@SalesTaxNumber,@PostalCode,@DefinitionDate, @ShortageGLCode ,@GLCode,@WHTaxGLCode, @GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE Customers
		SET
		CustomerName=@CustomerName,
 		CityCode=@CityCode,
		Fax=@Fax,
		ShortageGLCode=@ShortageGLCode,
		GLCode=@GLCode,
		UrduTitle=@UrduTitle,
		Email=@Email,
		WHTaxGLCode=@WHTaxGLCode,
		Address=@Address,
		TelePhone=@TelePhone,
		NationalTaxNumber=	@NationalTaxNumber,
		SalesTaxNumber=@SalesTaxNumber,
		PostalCode=@PostalCode,
		DefinitionDate=@DefinitionDate
		 
		WHERE  ( CustomerCode = @CustomerCode )
 	     END

GO
