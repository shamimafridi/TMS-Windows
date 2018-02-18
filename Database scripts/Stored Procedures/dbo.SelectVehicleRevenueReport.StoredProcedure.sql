USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleRevenueReport]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[SelectVehicleRevenueReport]
    @FromVehicleCode AS CHAR(12) = '' ,
    @ToVehicleCode AS CHAR(12) = '' ,
    @FromDate AS DATETIME = '' ,
    @ToDate AS DATETIME = '' ,
    @ShowOpening AS TINYINT = 0
AS --CALCULATING OPENING BALANCES
   
        --END OPENING BALANCES
        SELECT  TR.BranchCode ,  TR.InvoiceRefNo,                 
                TR.RECORDNO ,
				CASE WHEN TR.Type = 'INV' THEN '1'
                WHEN ISNULL( TR.InvoiceRefNo,'') != '' THEN '2'
				ELSE '3'
                END ReportDetailType ,
                CASE WHEN TR.Type = 'INV' THEN 'INV'
                     ELSE TR.TransactionNature
                END TransactionNature ,
                TR.TransactionDate ,
                TR.VehicleCode ,
                abs(TR.AmountReceived) AmountReceived ,
                TR.AmountPaid ,
                CASE WHEN TR.Type = 'INV' THEN 'TRIP'
                     WHEN TR.Type = 'Shortage' THEN 'Shortage'
                     ELSE TT.TransactionType
                END TransactionType ,
                TR.Description ,-- THE NEXT CASE IS LOGIC WHEN THE TRIP IS LOCAL THEN GET NEXT ROW TRANSACTION NUMBER
				CASE WHEN TR.IsLocalTrip=1  THEN -- IF THERE IS TWO LOCAL TRIP BEFOR LONG TRIP THEN QUERY SHOULD CHANGE
				    CASE WHEN LEAD(TR.IsLocalTrip,1) OVER ( PARTITION BY TR.VehicleCode ORDER BY TR.TransactionNature,TR.TransactionDate , TR.RecordNo ) =1 -- IF NEXT TRIP IS ALSO LOCAL THEN
				        THEN 
							LEAD(TR.TransactionNo,2) OVER ( PARTITION BY TR.VehicleCode ORDER BY TR.TransactionNature,TR.TransactionDate , TR.RecordNo ) 
				        ELSE
							LEAD(TR.TransactionNo,1) OVER ( PARTITION BY TR.VehicleCode ORDER BY TR.TransactionNature,TR.TransactionDate , TR.RecordNo ) 
						END	  
				ELSE
				TR.TransactionNo END AS TransactionNo
        FROM    dbo.vwTransDetail TR
                INNER JOIN dbo.Branches ON TR.BranchCode = dbo.Branches.BranchCode
                INNER JOIN dbo.Vehicles ON TR.VehicleCode = dbo.Vehicles.VehicleCode
                INNER JOIN dbo.TransactionTypes TT ON TR.TransactionTypeCode = TT.TransactionTypeCode				

        WHERE   ( ( TR.TransactionDate BETWEEN @FromDate AND @ToDate
                    OR @FromDate = ''
                    OR @FromDate IS NULL
                    OR @ToDate = ''
                    OR @ToDate IS NULL
                  )
                  AND (TR.VehicleCode BETWEEN @FromVehicleCode
                                       AND     @ToVehicleCode
                        OR @FromVehicleCode = ''
                        OR @FromVehicleCode IS NULL
                        OR @ToVehicleCode = ''
                        OR @ToVehicleCode IS NULL
                      )
                )

        ORDER BY ReportDetailType, TR.TransactionNature,TR.TransactionDate , 
                TR.RecordNo

GO
