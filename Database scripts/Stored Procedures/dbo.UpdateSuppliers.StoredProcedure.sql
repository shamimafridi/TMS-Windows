USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateSuppliers]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateSuppliers] 

@SupplierCode varchar(5) = ''  ,
@SupplierName varchar(100)=' '  ,
@UrduTitle nVarchar(500)=' '  ,
@Address  varchar(200) = '',
@NIC  varchar(30) = '',
@PostalCode  varchar(50) = '',
@City varchar(10)='',
@CityCode char(3),
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
		INSERT INTO Suppliers( SupplierCode ,SupplierName,UrduTitle  ,Address, CityCode,TelePhone,Fax,NationalTaxNumber,SalesTaxNumber,PostalCode,DefinitionDate,GUID) 
		VALUES  ( @SupplierCode ,@SupplierName,@UrduTitle ,@Address, @CityCode,@TelePhone,@Fax,@NationalTaxNumber,@SalesTaxNumber,@PostalCode,@DefinitionDate,@GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE Suppliers
		SET
		SupplierName=@SupplierName,
 		CityCode=@CityCode,
		UrduTitle=@UrduTitle,
		Fax=@Fax,
		Email=@Email,
		Address=@Address,
		TelePhone=@TelePhone,
		NationalTaxNumber=	@NationalTaxNumber,
		SalesTaxNumber=@SalesTaxNumber,
		PostalCode=@PostalCode,
		DefinitionDate=@DefinitionDate
		 
		WHERE  ( SupplierCode = @SupplierCode )
 	     END

GO
