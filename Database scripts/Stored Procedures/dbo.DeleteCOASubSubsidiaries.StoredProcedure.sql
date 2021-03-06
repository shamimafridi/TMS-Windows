USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCOASubSubsidiaries]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[DeleteCOASubSubsidiaries]
      @ControlCode NCHAR(5) = '',
      @GeneralCode NCHAR(10) = '',
      @SubsidiaryCode1 NCHAR(10) = '',
      @SubSubsidiaryCode NCHAR(10) = ''
AS 
      DECLARE @rtnGlCode AS TINYINT
      DECLARE @GLCode AS VARCHAR(50)

      SET @GLCode = RTRIM(@SubsidiaryCode1) + @SubSubsidiaryCode
      SET @ControlCode = LEFT(@SubsidiaryCode1, 2)    --  1
      SET @GeneralCode = SUBSTRING(@SubsidiaryCode1, 3, 2)  -- 001
      SET @SubsidiaryCode1 = SUBSTRING(@SubsidiaryCode1, 5, 8)

	
      IF @ControlCode <> ''
            AND @GeneralCode <> ''
            AND @SubsidiaryCode1 <> ''
            AND @SubSubsidiaryCode <> '' 
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
                              DELETE      FROM COASubSubsidiaries
                              WHERE       ( ControlCode = @ControlCode )
                                          AND ( GeneralCode = @GeneralCode )
                                          AND ( SubsidiaryCode = @SubsidiaryCode1 )
                                          AND ( SubSubsidiaryCode = @SubSubsidiaryCode )

                        END
            END

GO
