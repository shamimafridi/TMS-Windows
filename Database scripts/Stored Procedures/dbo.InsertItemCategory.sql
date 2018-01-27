USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[InsertItemCategory]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertItemCategory]
(
	@ItemCategoryCode nvarchar(1),
	@ItemCategory nvarchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO ItemCategory(ItemCategoryCode, ItemCategory) VALUES (@ItemCategoryCode, @ItemCategory);
	SELECT ItemCategoryCode, ItemCategory FROM ItemCategory WHERE (ItemCategoryCode = @ItemCategoryCode)

GO
