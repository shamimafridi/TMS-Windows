USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateDestinationPoints]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateDestinationPoints]
@DestinationPointCode char(3) = ''  ,
@DestinationPointName varchar(100),
@UrduTitle nvarchar(200)='',
@DefinitionDate Datetime='',
@PointNo as numeric=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO DestinationPoints(DestinationPointCode,DestinationPointName,UrduTitle ,DefinitionDate,  PointNo) 
		VALUES  ( @DestinationPointCode, @DestinationPointName,@UrduTitle ,@DefinitionDate,  @PointNo) 
	     END
	ELSE 
	     BEGIN
		UPDATE DestinationPoints
		SET DestinationPointCode=@DestinationPointCode,
		DefinitionDate=@DefinitionDate,
		UrduTitle=@UrduTitle,
		PointNo= @PointNo,
		DestinationPointName = @DestinationPointName
		WHERE  ( DestinationPointCode = @DestinationPointCode  )
 	     END

GO
