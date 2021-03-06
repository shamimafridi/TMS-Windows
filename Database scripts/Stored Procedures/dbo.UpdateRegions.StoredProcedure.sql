USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateRegions]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateRegions]
@RegionCode char(3) = ''  ,
@RegionName varchar(100),
@UrduTitle nvarchar(200)='',
@DefinitionDate Datetime='',
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Regions(RegionCode,RegionName,UrduTitle ,DefinitionDate) 
		VALUES  ( @RegionCode, @RegionName,@UrduTitle ,@DefinitionDate) 
	     END
	ELSE 
	     BEGIN
		UPDATE Regions
		SET RegionCode=@RegionCode,
		DefinitionDate=@DefinitionDate,
		UrduTitle=@UrduTitle,
		RegionName = @RegionName
		WHERE  ( RegionCode = @RegionCode  )
 	     END

GO
