USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[InsertItemCategory]    Script Date: 03-Feb-18 9:47:12 PM ******/
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
