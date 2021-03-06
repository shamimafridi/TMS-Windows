USE [TMS_ALI]
GO
/****** Object:  UserDefinedFunction [dbo].[CheckParentLevelExistInTransaction]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[CheckParentLevelExistInTransaction] --(owner_name.)function_name
    ( @COACode AS VARCHAR(50) )
RETURNS TINYINT
AS 
    BEGIN 
        DECLARE @RtnGlCode AS TINYINT
		
        IF LEN(@COACode) = 4 
            BEGIN
                SET @RtnGlCode = CONVERT(TINYINT, ( SELECT  DISTINCT
                                                            1 AS GLCode
                                                    FROM    dbo.VoucherDetails
                                                    WHERE   LEFT(GLCode, 4) = @COACode
                                                            AND LEN(GLCode) = 4
                                                    UNION
                                                    SELECT DISTINCT
                                                            1 AS GLCode
                                                    FROM    dbo.[Vehicles]
                                                    WHERE   ( LEFT(InstallmentGLCode,
                                                              4) = @COACode
                                                              AND LEN(InstallmentGLCode) = 4
                                                            )
                                                            OR ( LEFT(FreightGLCode,
                                                              4) = @COACode
                                                              AND LEN(FreightGLCode) = 4
                                                              )
                                                            OR ( LEFT(LoanGLCode,
                                                              4) = @COACode
                                                              AND LEN(LoanGLCode) = 4
                                                              )
                                                            OR ( LEFT(CommissionGLCode,
                                                              4) = @COACode
                                                              AND LEN(CommissionGLCode) = 4
                                                              )
                                                    UNION
                                                    SELECT DISTINCT
                                                            1 AS GLCode
                                                    FROM    dbo.Customers
                                                    WHERE   ( LEFT(ShortageGLCode,
                                                              4) = @COACode
                                                              AND LEN(ShortageGLCode) = 4
                                                            )
                                                            OR ( LEFT(WHTaxGLCode,
                                                              4) = @COACode
                                                              AND LEN(WHTaxGLCode) = 4
                                                              )
                                                            OR ( LEFT(GLCode,
                                                              4) = @COACode
                                                              AND LEN(GLCode) = 4
                                                              )
                                                    UNION
                                                    SELECT DISTINCT
                                                            1 AS GLCode
                                                    FROM    dbo.PaymentVoucherDetails
                                                    WHERE   LEFT(GLCode, 4) = @COACode
                                                            AND LEN(GLCode) = 4
                                                    UNION
                                                    SELECT DISTINCT
                                                            1 AS GLCode
                                                    FROM    dbo.UsedTransactionsDetail
                                                    WHERE   LEFT(GLCode, 4) = @COACode
                                                            AND LEN(GLCode) = 4
                                                    UNION
                                                    SELECT DISTINCT
                                                            1 AS GLCode
                                                    FROM    dbo.Branches
                                                    WHERE   LEFT(GLCode, 4) = @COACode
                                                            AND LEN(GLCode) = 4
                                                  ))
                
            END
        ELSE 
            IF LEN(@COACode) = 8 
                BEGIN 
                  
                    SET @RtnGlCode = CONVERT(TINYINT, ( SELECT  DISTINCT
                                                              1 AS GLCode
                                                        FROM  dbo.VoucherDetails
                                                        WHERE LEFT(GLCode, 8) = @COACode
                                                              AND LEN(GLCode) = 8
                                                        UNION
                                                        SELECT DISTINCT
                                                              1 AS GLCode
                                                        FROM  dbo.[Vehicles]
                                                        WHERE ( LEFT(InstallmentGLCode,
                                                              8) = @COACode
                                                              AND LEN(InstallmentGLCode) = 8
                                                              )
                                                              OR ( LEFT(FreightGLCode,
                                                              8) = @COACode
                                                              AND LEN(FreightGLCode) = 8
                                                              )
                                                              OR ( LEFT(LoanGLCode,
                                                              8) = @COACode
                                                              AND LEN(LoanGLCode) = 8
                                                              )
                                                              OR ( LEFT(CommissionGLCode,
                                                              8) = @COACode
                                                              AND LEN(CommissionGLCode) = 8
                                                              )
                                                        UNION
                                                        SELECT DISTINCT
                                                              1 AS GLCode
                                                        FROM  dbo.Customers
                                                        WHERE ( LEFT(ShortageGLCode,
                                                              8) = @COACode
                                                              AND LEN(ShortageGLCode) = 8
                                                              )
                                                              OR ( LEFT(WHTaxGLCode,
                                                              8) = @COACode
                                                              AND LEN(WHTaxGLCode) = 8
                                                              )
                                                              OR ( LEFT(GLCode,
                                                              8) = @COACode
                                                              AND LEN(GLCode) = 8
                                                              )
                                                        UNION
                                                        SELECT DISTINCT
                                                              1 AS GLCode
                                                        FROM  dbo.PaymentVoucherDetails
                                                        WHERE LEFT(GLCode, 8) = @COACode
                                                              AND LEN(GLCode) = 8
                                                        UNION
                                                        SELECT DISTINCT
                                                              1 AS GLCode
                                                        FROM  dbo.UsedTransactionsDetail
                                                        WHERE LEFT(GLCode, 8) = @COACode
                                                              AND LEN(GLCode) = 8
                                                        UNION
                                                        SELECT DISTINCT
                                                              1 AS GLCode
                                                        FROM  dbo.Branches
                                                        WHERE LEFT(GLCode, 8) = @COACode
                                                              AND LEN(GLCode) = 8
                                                      ))
                
                END
        RETURN    ISNULL( @RtnGlCode,0)
               
    END

GO
