USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCOAGenerals]    Script Date: 27-Jan-18 11:24:03 AM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE  PROCEDURE [dbo].[DeleteCOAGenerals]
      @ControlCode NCHAR(5) = '',
      @GeneralCode NCHAR(5) = ''
AS 
      DECLARE @rtnGlCode AS TINYINT
      DECLARE @GLCode AS VARCHAR(50)

      SET @GLCode = RTRIM(@ControlCode) + @GeneralCode
      
      IF @ControlCode <> ''
            AND @GeneralCode <> '' 
            BEGIN
                  SET @rtnGlCode = dbo.GetCOAValidation(@GLCode)  
      
                  IF @rtnGlcode = 1 
                        BEGIN
                              RAISERROR ( 'The COA Code is exist already in some Transaction therefor can not deleted',
                                    16, 1, '', '', '' )

                              RETURN ( 99 )
                        END
                  ELSE 
                        BEGIN	
                              DELETE      FROM COAGenerals
                              WHERE       ( ControlCode = @ControlCode )
                                          AND ( GeneralCode = @GeneralCode )
                        END
            END

GO
