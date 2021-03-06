USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleLedgerReport]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectVehicleLedgerReport]
    @FromVehicleCode AS CHAR(12) = '' ,
    @ToVehicleCode AS CHAR(12) = '' ,
    @FromDate AS DATETIME = '' ,
    @ToDate AS DATETIME = '' ,
    @ShowOpening AS TINYINT = 0
AS --CALCULATING OPENING BALANCES
   ;
    WITH    opening ( VehicleCode, openR, OpenI, curR, curI )
              AS ( SELECT   VehicleCode ,
                            SUM(CASE WHEN TransactionDate < @FromDate
                                     THEN AmountReceived
                                     ELSE 0
                                END) AS OpenR ,
                            SUM(CASE WHEN TransactionDate < @FromDate
                                     THEN AmountPaid
                                     ELSE 0
                                END) AS OpenI ,
                            SUM(CASE WHEN TransactionDate BETWEEN @FromDate AND @ToDate
                                     THEN AmountReceived
                                     ELSE 0
                                END) AS CurR ,
                            SUM(CASE WHEN TransactionDate BETWEEN @FromDate AND @ToDate
                                     THEN AmountPaid
                                     ELSE 0
                                END) AS CurI
                   FROM     dbo.vwTransDetail
                   WHERE    ( TransactionDate <= @ToDate
                              OR @FromDate IS NULL
                              OR @ToDate IS NULL
                              OR @FromDate = ''
                              OR @ToDate = ''
                            )
                            AND ( VehicleCode BETWEEN @FromVehicleCode
                                              AND     @ToVehicleCode
                                  OR @FromVehicleCode = ''
                                  OR @FromVehicleCode IS NULL
                                  OR @ToVehicleCode = ''
                                  OR @ToVehicleCode IS NULL
                                )
                   GROUP BY VehicleCode
                 )
        --END OPENING BALANCES
        SELECT  TR.BranchCode ,
                TR.TransactionNo ,
                TR.RECORDNO ,
                CASE WHEN TR.Type = 'INV' THEN 'INV'
                     ELSE TR.TransactionNature
                END TransactionNature ,
                TR.TransactionDate ,
                TR.VehicleCode ,
                TR.AmountReceived ,
                TR.AmountPaid ,
                CASE WHEN TR.Type = 'INV' THEN 'TRIP'
                     WHEN TR.Type = 'Shortage' THEN 'Shortage'
                     ELSE TT.TransactionType
                END TransactionType ,
                TR.Description ,
                Opening = CASE WHEN @ShowOpening = 0 THEN 0
                               ELSE o.OpenR - o.OpenI
                          END  
                --(o.OpenR - o.OpenI) + Balance Balance
               -- AmountBal = ( o.OpenR - o.OpenI ) + ( o.curR - o.curI )
        FROM    dbo.vwTransDetail TR
                INNER JOIN dbo.Branches ON TR.BranchCode = dbo.Branches.BranchCode
                INNER JOIN dbo.Vehicles ON TR.VehicleCode = dbo.Vehicles.VehicleCode
                INNER JOIN dbo.TransactionTypes TT ON TR.TransactionTypeCode = TT.TransactionTypeCode
                LEFT OUTER JOIN opening o ON o.VehicleCode = Tr.VehicleCode
        WHERE   ( ( TR.TransactionDate BETWEEN @FromDate AND @ToDate
                    OR @FromDate = ''
                    OR @FromDate IS NULL
                    OR @ToDate = ''
                    OR @ToDate IS NULL
                  )
                  AND ( TR.VehicleCode BETWEEN @FromVehicleCode
                                       AND     @ToVehicleCode
                        OR @FromVehicleCode = ''
                        OR @FromVehicleCode IS NULL
                        OR @ToVehicleCode = ''
                        OR @ToVehicleCode IS NULL
                      )
                )
        ORDER BY TR.TransactionDate ,
                TR.RecordNo

GO
