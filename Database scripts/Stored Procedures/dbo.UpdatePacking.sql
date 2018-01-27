USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdatePacking]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdatePacking]
@PackingCode char(3) = ''  ,
@Packing varchar(100),
@ReportTitle varchar(100),
@DefinitionDate DateTime=Date,
@GUID as bigint=0,
@NewRecord as bigint
 AS 
	IF @NewRecord = 1 
	     BEGIN
		INSERT INTO Packing(PackingCode, Packing,DefinitionDate,ReportTitle,GUID) 
		VALUES  ( @PackingCode, @Packing ,@DefinitionDate,@ReportTitle,@GUID) 
	     END
	ELSE 
	     BEGIN
		UPDATE Packing
		SET PackingCode=@PackingCode,
		DefinitionDate=@DefinitionDate,
		Packing = @Packing,
		ReportTitle = @ReportTitle
		WHERE  ( PackingCode = @PackingCode  )
 	     END

GO
