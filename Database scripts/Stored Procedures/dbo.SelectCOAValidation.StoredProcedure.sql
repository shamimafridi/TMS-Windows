USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectCOAValidation]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCOAValidation]
    @TableName NCHAR(50) = '',
    @COACode NCHAR(50) = '',
    @ValidationType NCHAR(50) = '',
    @rtnGLCode  TINYINT
AS 
    IF @ValidationType = 'DELETE' 
	BEGIN
		SET @rtnGlCode= dbo.GetCOAValidation((@COACode)) 
		IF @rtnGlcode=1 
		RETURN(99)
		print 'The COA Code is exist already in some Transaction therefor can not deleted'
	
	
	end

GO
