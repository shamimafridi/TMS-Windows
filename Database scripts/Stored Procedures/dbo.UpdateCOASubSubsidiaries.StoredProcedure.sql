USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateCOASubSubsidiaries]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[UpdateCOASubSubsidiaries]
    @ControlCode CHAR(2) = '' ,
    @GeneralCode CHAR(3) = '' ,
    @SubsidiaryCode1 CHAR(9) = '' ,
    @ControlDescription VARCHAR(100) ,
    @GeneralDescription VARCHAR(100) ,
    @SubsidiaryDescription VARCHAR(100) ,
    @SubSubsidiaryCode CHAR(10) = '' ,
    @FSFGLCode CHAR(15) = '' ,
    @FSFGLDescription CHAR(15) = '' ,
    @SubSubsidiaryDescription VARCHAR(100) ,
    @DefinitionDate DATETIME = DATE ,
    @GUID AS BIGINT = 0 ,
    @NewRecord AS BIGINT
AS ------- example @Subsidiarycode1 = 01 01 0001         =9 degit
DECLARE @rtnGlCode AS TINYINT 
    SET @rtnGlCode = dbo.CheckParentLevelExistInTransaction( RTRIM(LTRIM(@SubsidiaryCode1)))  
    PRINT @rtnGlCode 
    PRINT @SubsidiaryCode1
    IF @rtnGlcode = 1 
        BEGIN
            RAISERROR ( 'The Subsidiary Level Code is exist some Transaction therefor can not effected any record!',
                                    16, 1, '', '', '' )

            RETURN ( 99 )
        END


    SET @ControlCode = LEFT(@SubsidiaryCode1, 2)    --  1
    SET @GeneralCode = SUBSTRING(@SubsidiaryCode1, 3, 2)  -- 001
    SET @SubsidiaryCode1 = SUBSTRING(@SubsidiaryCode1, 5, 8)   --- 1 001 00001


    IF @NewRecord = 1 
        BEGIN
            INSERT  INTO COASubSubsidiaries
                    ( ControlCode ,
                      GeneralCode ,
                      SubsidiaryCode ,
                      SubSubsidiaryCode ,
                      SubSubsidiaryDescription ,
                      DefinitionDate ,
                      GUID ,
                      FSFGLCode
                    )
            VALUES  ( @ControlCode ,
                      @GeneralCode ,
                      @SubsidiaryCode1 ,
                      @SubSubsidiaryCode ,
                      @SubSubsidiaryDescription ,
                      @DefinitionDate ,
                      @GUID ,
                      @FSFGLCode
                    ) 
        END
    ELSE 
        BEGIN
            UPDATE  COASubSubsidiaries
            SET     DefinitionDate = @DefinitionDate ,
                    FSFGLCode = @FSFGLCode ,
                    SubSubsidiaryDescription = @SubSubsidiaryDescription
            WHERE   ( SubSubsidiaryCode = @SubSubsidiaryCode
                      AND SubsidiaryCode = @SubsidiaryCode1
                      AND GeneralCode = @GeneralCode
                      AND ControlCode = @ControlCode
                    )
        END

GO
