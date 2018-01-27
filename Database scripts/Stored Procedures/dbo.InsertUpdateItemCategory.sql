USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[InsertUpdateItemCategory]    Script Date: 27-Jan-18 11:24:03 AM ******/
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
