USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCOASubsidiaries]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateCOASubsidiaries]
    @ControlCode CHAR(10) = '' ,
    @GeneralCode CHAR(10) = '' ,
    @GeneralDescription VARCHAR(200) ,
    @SubsidiaryCode CHAR(10) = '' ,
    @ControlDescription VARCHAR(100) ,
    @SubsidiaryDescription VARCHAR(100) ,
    @FSFGLCode CHAR(14) = '' ,
    @FSFGLDescription CHAR(14) = '' ,
    @DefinitionDate DATETIME = DATE ,
    @GUID AS BIGINT = 0 ,
    @NewRecord AS BIGINT
AS 
    DECLARE @rtnGlCode AS TINYINT 
    SET @rtnGlCode = dbo.CheckParentLevelExistInTransaction( RTRIM(LTRIM(@GeneralCode)))  
    PRINT @rtnGlCode 
    PRINT @ControlCode + @GeneralCode
    IF @rtnGlcode = 1 
        BEGIN
            RAISERROR ( 'The General Level Code is exist some Transaction therefor can not update the record!',
                                    16, 1, '', '', '' )

            RETURN ( 99 )
        END

    SET @ControlCode = LEFT(@GeneralCode, 2) 
    SET @GeneralCode = SUBSTRING(@GeneralCode, 3, 4) 
    

    IF @NewRecord = 1 
        BEGIN
            INSERT  INTO COASubsidiaries
                    ( ControlCode ,
                      GeneralCode ,
                      SubsidiaryCode ,
                      SubsidiaryDescription ,
                      DefinitionDate ,
                      GUID ,
                      FSFGLCode
                    )
            VALUES  ( @ControlCode ,
                      @GeneralCode ,
                      @SubsidiaryCode ,
                      @SubsidiaryDescription ,
                      @DefinitionDate ,
                      @GUID ,
                      @FSFGLCode
                    ) 
        END
    ELSE 
        BEGIN
            UPDATE  COASubsidiaries
            SET     DefinitionDate = @DefinitionDate ,
                    SubsidiaryDescription = @SubsidiaryDescription ,
                    FSFGLCode = @FSFGLCode
            WHERE   ( SubsidiaryCode = @SubsidiaryCode
                      AND GeneralCode = @GeneralCode
                      AND ControlCode = @ControlCode
                    )
        END

GO
