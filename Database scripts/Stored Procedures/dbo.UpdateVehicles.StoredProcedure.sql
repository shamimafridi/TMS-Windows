USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[UpdateVehicles]    Script Date: 3/31/2018 12:04:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[UpdateVehicles]
    @VehicleCode CHAR(10) = '' ,
    @VehicleDescription VARCHAR(100) = '' ,
    @OwnerCode AS VARCHAR(12) = '' ,
    @IsThirdParty AS BIT = 0 ,
    @OwnerName AS VARCHAR(12) = '' ,
    @Capacity AS VARCHAR(20) = '' ,
    @InstallmentGLCode AS VARCHAR(12) = '' ,
    @InstallmentGLDescription AS VARCHAR(12) = '' ,
    @FreightGLCode AS VARCHAR(12) = '' ,
    @FreightGLDescription AS VARCHAR(12) = '' ,
    @LoanGLCode AS VARCHAR(12) = '' ,
    @CustomerCode AS VARCHAR(5) = '' ,
    @Customer AS VARCHAR(12) = '' ,
    @LoanGLDescription AS VARCHAR(12) = '' ,
    @CommissionGLCode AS VARCHAR(12) = '' ,
    @CommissionGLDescription AS VARCHAR(12) = '' ,
    @DefinitionDate DATETIME = '' ,
    @NewRecord AS BIGINT
AS 
    BEGIN TRANSACTION
    BEGIN TRY
	 
	 --work for freght coa auto generation
	 --there should be a HEAD OPEN WITH SAME ID IN SUBSIDARY
	 
        DECLARE @SubSubIdForFreghtCode VARCHAR(10)
        DECLARE @SubSubIdForCommissionCode VARCHAR(10)
        DECLARE @SubsidoryCodeForFreghtCode VARCHAR(10)
        DECLARE @SubsidoryCodeForCommission VARCHAR(10)
        IF @IsThirdParty = 1 
            BEGIN
                SELECT  @SubSubIdForFreghtCode = MAX(SubSubsidiaryCode)
                FROM    dbo.COASubSubsidiaries
                WHERE   ControlCode = '02'
                        AND GeneralCode = '01'
                        AND SubsidiaryCode = RIGHT(@CustomerCode, 4)

                SELECT  @SubSubIdForFreghtCode = ISNULL(@SubSubIdForFreghtCode,
                                                        '0000');
		
                SET @SubsidoryCodeForFreghtCode = CAST('0201' AS VARCHAR(4))
                    + RIGHT(@CustomerCode, 4)	

                SELECT  @SubSubIdForFreghtCode = RIGHT('0000'
                                                       + ISNULL(CAST(@SubSubIdForFreghtCode
                                                              + 1 AS VARCHAR(10)),
                                                              0), 4)		 	
                SELECT  @SubSubIdForCommissionCode = MAX(SubSubsidiaryCode)
                FROM    dbo.COASubSubsidiaries
                WHERE   ControlCode = '05'
                        AND GeneralCode = '02'
                        AND SubsidiaryCode = RIGHT(@CustomerCode, 4)
		 
		
                SELECT  @SubSubIdForCommissionCode = ISNULL(@SubSubIdForCommissionCode,
                                                            '0000');
		
                SELECT  @SubSubIdForCommissionCode = RIGHT('0000'
                                                           + ISNULL(CAST(@SubSubIdForCommissionCode
                                                              + 1 AS VARCHAR(10)),
                                                              0), 4)
                SET @SubsidoryCodeForCommission = CAST('0502' AS VARCHAR(4))
                    + RIGHT(@CustomerCode, 4)	 
			 
		
            END
        ELSE 
            BEGIN
                SELECT  @SubSubIdForFreghtCode = MAX(SubSubsidiaryCode)
                FROM    dbo.COASubSubsidiaries
                WHERE   ControlCode = '05'
                        AND GeneralCode = '01'
                        AND SubsidiaryCode = RIGHT(@CustomerCode, 4)
                SELECT  @SubSubIdForFreghtCode = ISNULL(@SubSubIdForFreghtCode,
                                                        '0000');
                SELECT  @SubSubIdForFreghtCode = RIGHT('0000'
                                                       + ISNULL(CAST(@SubSubIdForFreghtCode
                                                              + 1 AS VARCHAR(10)),
                                                              0), 4)

                SET @SubsidoryCodeForFreghtCode = CAST('0501' AS VARCHAR(4))
                    + RIGHT(@CustomerCode, 4)	
		--work for commission coa auto generation

       


                SELECT  @SubSubIdForCommissionCode = MAX(SubSubsidiaryCode)
                FROM    dbo.COASubSubsidiaries
                WHERE   ControlCode = '05'
                        AND GeneralCode = '02'
                        AND SubsidiaryCode = RIGHT(@CustomerCode, 4)
        
                SELECT  @SubSubIdForCommissionCode = ISNULL(@SubSubIdForCommissionCode,
                                                            '0000');
		
                SELECT  @SubSubIdForCommissionCode = RIGHT('0000'
                                                           + ( CAST(@SubSubIdForCommissionCode
                                                              + 1 AS VARCHAR(10)) ),
                                                           4)
                SET @SubsidoryCodeForCommission = CAST('0502' AS VARCHAR(4))
                    + RIGHT(@CustomerCode, 4)	 
                PRINT @SubsidoryCodeForCommission
            END
        IF @NewRecord = 1 
            BEGIN		
                PRINT @SubSubIdForCommissionCode
		 
                EXEC UpdateCOASubSubsidiaries @NewRecord = 1, @FSFGLCode = N'',
                    @FSFGLDescription = '', @ControlDescription = '',
                    @GeneralDescription = '', @SubsidiaryDescription = '',
                    @SubsidiaryCode1 = @SubsidoryCodeForFreghtCode,
                    @DefinitionDate = @DefinitionDate,
                    @SubSubsidiaryCode = @SubSubIdForFreghtCode,
                    @SubSubsidiaryDescription = @VehicleCode
	    
                EXEC UpdateCOASubSubsidiaries @NewRecord = 1, @FSFGLCode = N'',
                    @FSFGLDescription = '', @ControlDescription = '',
                    @GeneralDescription = '', @SubsidiaryDescription = '',
                    @SubsidiaryCode1 = @SubsidoryCodeForCommission,
                    @DefinitionDate = @DefinitionDate,
                    @SubSubsidiaryCode = @SubSubIdForCommissionCode,
                    @SubSubsidiaryDescription = @VehicleCode
	    
		
                INSERT  INTO dbo.Vehicles
                        ( VehicleCode ,
                          VehicleDescription ,
                          DefinitionDate ,
                          OwnerCode ,
                          InstallmentGLCode ,
                          FreightGLCode ,
                          LoanGLCode ,
                          CommissionGLCode ,
                          CustomerCode ,
                          Capacity ,
                          IsThirdParty
                        )
                VALUES  ( @VehicleCode ,
                          @VehicleDescription ,
                          @DefinitionDate ,
                          @OwnerCode ,
                          @InstallmentGLCode ,
                          @FreightGLCode ,
                          @LoanGLCode ,
                          @CommissionGLCode ,
                          @CustomerCode ,
                          @Capacity ,
                          @IsThirdParty 
                        ) 
	    
				EXECUTE dbo.UpdateDivisions @DivisionCode =@VehicleCode , -- char(3)
				    @Division = @VehicleCode, -- varchar(100)
				    @DefinitionDate = @DefinitionDate, -- datetime
				    @NewRecord = 1 -- bigint
				
                UPDATE  dbo.[Vehicles ]
                SET     FreightGLCode = @SubsidoryCodeForFreghtCode
                        + @SubSubIdForFreghtCode ,
                        CommissionGLCode = @SubsidoryCodeForCommission
                        + @SubSubIdForCommissionCode
                WHERE   VehicleCode = @VehicleCode
		
	     
            END
        ELSE 
            BEGIN
	     
                IF ( @FreightGLCode = ''
                     OR @FreightGLCode IS NULL
                   )
	                BEGIN
                        EXEC UpdateCOASubSubsidiaries @NewRecord = 1,
                            @FSFGLCode = N'', @FSFGLDescription = '',
                            @ControlDescription = '', @GeneralDescription = '',
                            @SubsidiaryDescription = '',
                            @SubsidiaryCode1 = @SubsidoryCodeForFreghtCode,
                            @DefinitionDate = @DefinitionDate,
                            @SubSubsidiaryCode = @SubSubIdForFreghtCode,
                            @SubSubsidiaryDescription = @VehicleCode
                        SET @FreightGLCode = @SubsidoryCodeForFreghtCode
                            + @SubSubIdForFreghtCode
                        PRINT @FreightGLCode
                    END
	     
                IF ( @CommissionGLCode = ''
                     OR @CommissionGLCode IS NULL
                   ) 
                    BEGIN
	    ---- print @SubSubIdForFreghtCode
	    
                        EXEC UpdateCOASubSubsidiaries @NewRecord = 1,
                            @FSFGLCode = N'', @FSFGLDescription = '',
                            @ControlDescription = '', @GeneralDescription = '',
                            @SubsidiaryDescription = '',
                            @SubsidiaryCode1 = @SubsidoryCodeForCommission,
                            @DefinitionDate = @DefinitionDate,
                            @SubSubsidiaryCode = @SubSubIdForCommissionCode,
                            @SubSubsidiaryDescription = @VehicleCode
				
	    
                        SET @CommissionGLCode = @SubsidoryCodeForCommission
                            + @SubSubIdForCommissionCode
                    END
		
		
                UPDATE  Vehicles
                SET     VehicleCode = @VehicleCode ,
                        DefinitionDate = @DefinitionDate ,
                        VehicleDescription = @VehicleDescription ,
                        OwnerCode = @OwnerCode ,
                        InstallmentGLCode = @InstallmentGLCode ,
                        FreightGLCode = @FreightGLCode ,
                        IsThirdParty = @IsThirdParty ,
                        CustomerCode = @CustomerCode ,
                        LoanGLCode = @LoanGLCode ,
                        CommissionGLCode = @CommissionGLCode ,
                        Capacity = @Capacity
                WHERE   ( VehicleCode = @VehicleCode )
                IF NOT EXISTS(SELECT TOP (1) * FROM dbo.Divisions WHERE DivisionCode=@VehicleCode)
                BEGIN
                EXECUTE dbo.UpdateDivisions @DivisionCode =@VehicleCode , 
				    @Division = @VehicleCode, 
				    @DefinitionDate = @DefinitionDate, 
				    @NewRecord = 1 
				
                END 
            END
        COMMIT
    END TRY
    BEGIN CATCH
        DECLARE @MSG VARCHAR(500)
        SET @MSG = ERROR_MESSAGE()
        PRINT @MSG
        RAISERROR ( @MSG, 12,1);
        ROLLBACK TRANSACTION
    END CATCH
