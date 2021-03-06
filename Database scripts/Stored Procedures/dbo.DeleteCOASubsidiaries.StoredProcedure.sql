USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCOASubsidiaries]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE  PROCEDURE [dbo].[DeleteCOASubsidiaries]
      @ControlCode CHAR(5) = '',
      @GeneralCode CHAR(10) = '',
      @SubsidiaryCode1 CHAR(10) = '',
      @SubsidiaryCode CHAR(10) = ''
AS 
      DECLARE @rtnGlCode AS TINYINT
      DECLARE @GLCode AS VARCHAR(50)

      SET @GLCode = RTRIM(@GeneralCode) + @SubsidiaryCode

      SET @ControlCode = LEFT(@GeneralCode, 2)    --  1
      SET @GeneralCode = SUBSTRING(@GeneralCode, 3, 2)  -- 001

      IF @ControlCode <> ''
            AND @GeneralCode <> ''
            AND @SubsidiaryCode <> '' 
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
                              DELETE      FROM COASubsidiaries
                              WHERE       ( ControlCode = @ControlCode )
                                          AND ( GeneralCode = @GeneralCode )
                                          AND ( SubsidiaryCode = @SubsidiaryCode )
                        END 
            END

GO
