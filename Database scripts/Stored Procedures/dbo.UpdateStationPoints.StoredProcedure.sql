USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateStationPoints]    Script Date: 03-Feb-18 9:47:12 PM ******/
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
