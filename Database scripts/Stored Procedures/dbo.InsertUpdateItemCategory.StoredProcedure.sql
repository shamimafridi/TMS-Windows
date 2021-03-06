USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateItemCategory]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[InsertUpdateItemCategory]

	@NewRecord bit=0,
	@ItemCategoryCode nvarchar(1),
	@ItemCategory nvarchar(50)


AS
	IF @NewRecord=1 
		BEGIN
		INSERT INTO ItemCategory (ItemCategoryCode,ItemCategory) 
			values(@itemCategoryCode,@ItemCategory)
		END
	ELSE
		BEGIN	
		UPDATE ItemCategory SET 
			ItemCategoryCode = @ItemCategoryCode, 
			ItemCategory = @ItemCategory 
			WHERE (ItemCategoryCode = @ItemCategoryCode) AND (ItemCategory = @ItemCategory)
		END

GO
