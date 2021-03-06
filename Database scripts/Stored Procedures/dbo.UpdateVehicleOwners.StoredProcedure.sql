USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateVehicleOwners]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateVehicleOwners] 

@OwnerCode varchar(5) = ''  ,
@OwnerName varchar(100)=' '  ,
@UrduTitle nVarchar(500)=' '  ,
@Address  varchar(200) = '',
@NIC  varchar(30) = '',
@PostalCode  varchar(50) = '',
@City varchar(10)='',
@CityCode char(3),
@Email varchar(100)='',
@TelePhone varchar(100),
@DefinitionDate varchar(100)='',
@GUID as bigint=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO VehicleOwners( OwnerCode ,OwnerName ,UrduTitle,Address, CityCode,TelePhone,DefinitionDate,GUID) 
		VALUES  ( @OwnerCode ,@OwnerName,@UrduTitle ,@Address, @CityCode,@TelePhone, @DefinitionDate,@GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE VehicleOwners
		SET
		OwnerName=@OwnerName,
 		CityCode=@CityCode,
		UrduTitle=@UrduTitle,
	 	Email=@Email,
		Address=@Address,
		TelePhone=@TelePhone,
		DefinitionDate=@DefinitionDate
		 
		WHERE  ( OwnerCode = @OwnerCode )
 	     END

GO
