USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteRegions]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[DeleteRegions]
@RegionCode nchar(5)=''
AS
	IF @RegionCode <> ''
		DELETE FROM Regions 
		WHERE ( RegionCode= @RegionCode)

GO
