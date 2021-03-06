USE [TMS_ALI]
GO
/****** Object:  UserDefinedFunction [dbo].[GetCOAValidation]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     FUNCTION [dbo].[GetCOAValidation] 
( @COACode AS VARCHAR(50) )
RETURNS TINYINT
AS BEGIN 
      DECLARE @RtnGlCode AS TINYINT

	
      SET @RtnGlCode =  CONVERT( TINYINT,( SELECT  DISTINCT
                                    1 AS GLCode
                         FROM       dbo.VoucherDetails
                         WHERE      GLCode = @COACode
                         UNION
                         SELECT DISTINCT
                                    1 AS GLCode
                         FROM       dbo.[Vehicles]
                         WHERE      InstallmentGLCode = @COACode
                                    OR FreightGLCode = @COACode
                                    OR LoanGLCode = @COACode
                                    OR CommissionGLCode = @COACode
                         UNION
                         SELECT DISTINCT
                                    1 AS GLCode
                         FROM       dbo.Customers
                         WHERE      ShortageGLCode = @COACode
                                    OR WHTaxGLCode = @COACode
                                    OR GLCode = @COACode
                                    
                         UNION
                         SELECT DISTINCT
                                    1 AS GLCode
                         FROM       dbo.PaymentVoucherDetails
                         WHERE      GLCode = @COACode
                         UNION
                         SELECT DISTINCT
                                    1 AS GLCode
                         FROM       dbo.UsedTransactionsDetail
                         WHERE      GLCode = @COACode
                         UNION
                         SELECT DISTINCT
                                    1 AS GLCode
                         FROM       dbo.Branches
                         WHERE      GLCode = @COACode  ) )
                       
	
	
      RETURN    ISNULL( @RtnGlCode,0)
               
   END

GO
