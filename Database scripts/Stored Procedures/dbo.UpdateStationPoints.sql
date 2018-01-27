USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateStationPoints]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateStationPoints]
@StationPointCode char(3) = ''  ,
@StationPointName varchar(100),
@UrduTitle nvarchar(200)='',
@DefinitionDate Datetime='',
@PointNo as numeric=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO StationPoints(StationPointCode,StationPointName,UrduTitle ,DefinitionDate,  PointNo) 
		VALUES  ( @StationPointCode, @StationPointName,@UrduTitle ,@DefinitionDate,  @PointNo) 
	     END
	ELSE 
	     BEGIN
		UPDATE StationPoints
		SET StationPointCode=@StationPointCode,
		DefinitionDate=@DefinitionDate,
		UrduTitle=@UrduTitle,
		 PointNo= @PointNo,
		StationPointName = @StationPointName
		WHERE  ( StationPointCode = @StationPointCode  )
 	     END

GO
