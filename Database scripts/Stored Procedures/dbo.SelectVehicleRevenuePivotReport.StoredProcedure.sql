USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleRevenuePivotReport]    Script Date: 03/31/18 11:46:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SelectVehicleRevenuePivotReport] 
    @FromVehicleCode AS CHAR(12) = '' , 
    @ToVehicleCode AS CHAR(12) = '' , 
    @FromDate AS DATETIME = '' , 
    @ToDate AS DATETIME = '' , 
    @ShowOpening AS TINYINT = 0 ,
	@LstVehicles as VARCHAR(MAX)=''
AS --CALCULATING OPENING BALANCES 
    
        --END OPENING BALANCES 

        SELECT  '12' BranchCode ,  TR.InvoiceRefNo, 
                TR.Type, 
        CASE WHEN TransactionType='Shortage'  THEN '1' 
         ELSE TR.Type 

                 END 
               ReportDetailType , 
                 TR.TransactionNature, 
                ISNULL(TR.TransactionDate,@FromDate) TransactionDate , 
                TR.VehicleCode , 
                abs(ISNULL(TR.AmountReceived,0)) AmountReceived , 
                CASE WHEN TYPE = '2' AND  ISNULL(InvoiceRefNo,'')='' THEN 
         
        0 
        WHEN TYPE = '3' AND  ISNULL(InvoiceRefNo,'')<>'' THEN 
         
        0 
         ELSE ISNULL(TR.AmountPaid,0) END AmountPaid  , 
                CASE WHEN TR.Type = 1 THEN 'Freight' 
                     WHEN TT.TransactionType = 'Shortage' THEN 'Shortage' 
                      
           WHEN TYPE='2' AND ISNULL(InvoiceRefNo,'') ='' THEN '' 
           WHEN TYPE='3' AND ISNULL(InvoiceRefNo,'') <>'' THEN '' 
           ELSE TransactionType 
                END TransactionType 
                --TR.Description , 
        --TR.TransactionNo 
        FROM  GetVehiclesLst(@LstVehicles,'') V LEFT JOIN  
		
		 dbo.vwTransDetailAll TR ON  TR.VehicleCode = V.VehicleCode 
                LEFT JOIN dbo.Branches ON TR.BranchCode = dbo.Branches.BranchCode 
              
                INNER JOIN dbo.TransactionTypes TT ON TR.TransactionTypeCode = TT.TransactionTypeCode

        WHERE   ((ISNULL( TR.TransactionDate,@FromDate)  BETWEEN @FromDate AND @ToDate
                    OR @FromDate = '' 
                    OR @FromDate IS NULL 
                    OR @ToDate = '' 
                    OR @ToDate IS NULL 
                  ) 
                  --AND ( TR.VehicleCode BETWEEN @FromVehicleCode 
                  --                     AND     @ToVehicleCode 
                  --      OR @FromVehicleCode = '' 
                  --      OR @FromVehicleCode IS NULL 
                  --      OR @ToVehicleCode = '' 
                  --      OR @ToVehicleCode IS NULL 
                  --    ) 
                ) 


        ORDER BY ReportDetailType, TR.TransactionNature,TR.TransactionDate , 
                TR.RecordNo