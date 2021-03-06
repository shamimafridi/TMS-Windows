USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleBillsReportsWGL]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
--drop PROCEDURE SelectVehicleBillsReports  
CREATE PROCEDURE [dbo].[SelectVehicleBillsReportsWGL]
    @FromBranchCode VARCHAR(10) = '',
    @ToBranchCode VARCHAR(10) = '',
    @FromDivisionCode VARCHAR(10) = '',
    @ToDivisionCode VARCHAR(10) = '',
    @FromOwnerCode AS CHAR(10) = '',
    @ToOwnerCode AS CHAR(10) = '',
    @FromVehicleCode VARCHAR(50) = '',
    @ToVehicleCode AS CHAR(10) = '',
    @FromDate DATETIME = NULL,
    @ToDate DATETIME = NULL,
    @nType BIGINT = 0,
    @VehicleAdjustmentNatureCode VARCHAR(100) = '',
    @ReportSD AS VARCHAR(10) = 'DET',
    @Posted BIT = 1,
    @PostedED BIT = 0

--Receipt= ReceiptAmount
--Payment=PaymentAmount
AS 
    IF @nType = 0 --OPENING 1
        BEGIN			
            DECLARE @DocDate AS DATETIME
	
            IF EXISTS ( SELECT  *
                        FROM    sysobjects
                        WHERE   ID = OBJECT_ID(N'TempCOAOpening')
                                AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                BEGIN
                    DROP TABLE  TempCOAOpening
                END
	
	-- SELECT Branch with Filter
            SELECT  BranchCode AS SysBranchCode,
                    BranchCode,
                    BranchDescription AS Branch,
                    BranchDescription AS BranchRptTitle
            INTO    #Branches
            FROM    dbo.Branches
	--WHERE (dbo.Branches.BranchCode BETWEEN @FromBranchCode AND @ToBranchCode)
	
            CREATE INDEX #IX_Branches ON #Branches ( BranchCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]

            SELECT  OwnerCode,
                    OwnerName,
                    UrduTitle AS UrduOwnerName
            INTO    #VehicleOwnersT
            FROM    dbo.VehicleOwners
            WHERE   ( dbo.VehicleOwners.OwnerCode BETWEEN @FromOwnerCode
                                                  AND     @ToOwnerCode )

	
            CREATE INDEX #IX_VehicleOwnersT ON #VehicleOwnersT ( OwnerCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]	
            
            SELECT  dbo.Vehicles.VehicleCode,
                    dbo.Vehicles.VehicleDescription,
                    dbo.Vehicles.UrduTitle AS UrduVehicleName,
                    dbo.Vehicles.FreightGlCode,
                    dbo.Vehicles.OwnerCode,
                    dbo.Customers.CustomerCode,
                    dbo.Customers.CustomerName,
                    dbo.Customers.UrduTitle AS UrduCustomerName,
                    dbo.Vehicles.Capacity,
                    #VehicleOwnersT.OwnerName,
                    #VehicleOwnersT.UrduOwnerName
            INTO    #VehicleT
            FROM    dbo.Vehicles
                    LEFT OUTER JOIN #VehicleOwnersT ON dbo.Vehicles.OwnerCode = #VehicleOwnersT.OwnerCode
                    LEFT OUTER JOIN dbo.Customers ON dbo.Vehicles.CustomerCode = dbo.Customers.CustomerCode
            WHERE   ( dbo.Vehicles.VehicleCode BETWEEN @FromVehicleCode
                                               AND     @ToVehicleCode )
	--WHERE	(dbo.Vehicles.VehicleCode ='LSA 3940')

            CREATE INDEX [#IX_VehiclesT ] ON #VehicleT ( VehicleCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]
     


	-- SELECT Last Closing Date For OpeningBalanceTAB Filter
            SELECT  dbo.VehicleOpeningBalances.BranchCode,
                    dbo.VehicleOpeningBalances.VehicleCode,
                    MAX(dbo.VehicleOpeningBalances.ClosingDate) AS ClosingDate
            INTO    #OpeningDate
            FROM    dbo.VehicleOpeningBalances
                    INNER JOIN #Branches ON dbo.VehicleOpeningBalances.BranchCode = #Branches.BranchCode
                    INNER JOIN #VehicleT ON dbo.VehicleOpeningBalances.VehicleCode = #VehicleT.VehicleCode
            WHERE   ( dbo.VehicleOpeningBalances.ClosingDate <= @ToDate )
            GROUP BY dbo.VehicleOpeningBalances.BranchCode,
                    dbo.VehicleOpeningBalances.VehicleCode
            CREATE INDEX #IX_OpeningDate ON #OpeningDate ( BranchCode, VehicleCode, ClosingDate )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]
	
	-- SELECT OpeningBalance From OpeningBalanceTAB With ClosingDate Filter
            SELECT  dbo.VehicleOpeningBalances.ClosingDate,
                    dbo.VehicleOpeningBalances.BranchCode,
                    dbo.VehicleOpeningBalances.VehicleCode,
                    dbo.VehicleOpeningBalances.PaymentBalance
                    - dbo.VehicleOpeningBalances.ReceiptBalance AS OpeningBalance
            INTO    #OpeningTAB
            FROM    dbo.VehicleOpeningBalances
                    INNER JOIN #OpeningDate ON dbo.VehicleOpeningBalances.BranchCode = #OpeningDate.BranchCode
                                               AND dbo.VehicleOpeningBalances.ClosingDate = #OpeningDate.ClosingDate
                                               AND dbo.VehicleOpeningBalances.VehicleCode = #OpeningDate.VehicleCode
	
	-- SELECT Previous Closing Date For Master Transaction Filter
            SELECT  @DocDate = ISNULL(MIN(#OpeningDate.ClosingDate), 0) + 1
            FROM    #OpeningDate
          
	


	-- Select Master Transaction For DetailTransaction Filter
            SELECT  dbo.VehicleAdjustments.BranchCode,
                    dbo.VehicleAdjustments.VehicleAdjustmentNature,
                    dbo.VehicleAdjustments.VehicleAdjustmentNo,
                    dbo.VehicleAdjustments.VehicleAdjustmentDate,
                    dbo.VehicleAdjustments.VehicleCode,
                    dbo.VehicleAdjustments.RecordNo
            INTO    #TransMasterOP
            FROM    dbo.VehicleAdjustments
            WHERE   ( dbo.VehicleAdjustments.VehicleAdjustmentDate BETWEEN @DocDate
                                                                   AND     @ToDate )
                    AND ( dbo.VehicleAdjustments.Posted = @Posted
                          OR @PostedED = 0
                        ) 
            CREATE INDEX #IX_TransMaster ON #TransMasterOP ( BranchCode, VehicleAdjustmentNature, VehicleAdjustmentNo )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]	

	-- SELECT Detail Transaction With Date
            SELECT  dbo.VehicleAdjustmentDetails.BranchCode,
                    #TransMasterOP.VehicleAdjustmentDate,
                    #TransMasterOP.VehicleCode,
                    #TransMasterOP.RecordNo,
                    CASE RIGHT(VehicleAdjustmentDetails.VehicleAdjustmentNature,
                               1)
                      WHEN 'R' THEN dbo.VehicleAdjustmentDetails.Amount
                      ELSE 0
                    END AS ReceiptAmount,
                    CASE RIGHT(VehicleAdjustmentDetails.VehicleAdjustmentNature,
                               1)
                      WHEN 'P' THEN dbo.VehicleAdjustmentDetails.Amount
                      ELSE 0
                    END AS PaymentAmount
            INTO    #TransDetail
            FROM    #TransMasterOP
                    INNER JOIN dbo.VehicleAdjustmentDetails ON #TransMasterOP.BranchCode = dbo.VehicleAdjustmentDetails.BranchCode
                                                               AND #TransMasterOP.VehicleAdjustmentNature = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature
                                                               AND #TransMasterOP.VehicleAdjustmentNo = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo
               
	
            CREATE INDEX #IX_TransDetail ON #TransDetail ( BranchCode, VehicleAdjustmentDate, VehicleCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]	
            
            
            SELECT  BranchCode,
                    TransactionDate,
                    VehicleCode,
                    RecordNo,
                    Amount - ( Commission + Shortage ) AS ReceiptAmount,
                    0 AS PaymentAmount
            INTO    #TransMasterInvOP
            FROM    dbo.Invoices
            WHERE   ( TransactionDate BETWEEN @DocDate AND @ToDate )
                    AND ( Posted = @Posted
                          OR @PostedED = 0
                        )
            CREATE INDEX #TransMasterInvOP ON #TransMasterInvOP ( BranchCode, TransactionDate, VehicleCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY] 
            
            SELECT  *
            INTO #OpCombine
            FROM    ( SELECT    *
                      FROM      #TransDetail
                      UNION ALL
                      SELECT    *
                      FROM      #TransMasterInvOP
                    ) OP
            
	-- Select Transaction Balance
            SELECT  #OpCombine.BranchCode,
                    #OpCombine.VehicleCode,
                    SUM(#OpCombine.PaymentAmount)
                    - SUM(#OpCombine.ReceiptAmount) AS TransBalance
            INTO    #TransBalTAB
            FROM    #OpCombine
                    LEFT OUTER JOIN #OpeningDate ON #OpCombine.BranchCode = #OpeningDate.BranchCode
                                                    AND #OpCombine.VehicleAdjustmentDate > #OpeningDate.ClosingDate
                                                    AND #OpCombine.VehicleCode = #OpeningDate.VehicleCode
            GROUP BY #OpCombine.BranchCode,
                    #OpCombine.VehicleCode
	
	---   Final Opening Balance 
            SELECT  BranchCode,
                    VehicleCode,
                    SUM(OpeningBalance) AS OpeningBalance
            INTO    #TransTAB
            FROM    ( SELECT    BranchCode,
                                VehicleCode,
                                OpeningBalance
                      FROM      #OpeningTAB
                      UNION ALL
                      SELECT    BranchCode,
                                VehicleCode,
                                TransBalance
                      FROM      #TransBalTAB
                    ) TransTAB
            GROUP BY BranchCode,
                    VehicleCode
	
	--- Final Opening Balance With Titles
            SELECT  #Branches.BranchCode,
                    #Branches.BranchRptTitle,
                    #VehicleT.VehicleCode,
                    #VehicleT.UrduCustomerName,
                    #VehicleT.OwnerCode,
                    #VehicleT.OwnerName,
                    #VehicleT.UrduOwnerName,
                    #VehicleT.CustomerCode,
                    #VehicleT.CustomerName,
                    #TransTAB.OpeningBalance
            INTO    TempCOAOpening
            FROM    #TransTAB
                    INNER JOIN #Branches ON #TransTAB.BranchCode = #Branches.BranchCode
                    INNER JOIN #VehicleT ON #TransTAB.VehicleCode = #VehicleT.VehicleCode
            WHERE   #TransTAB.OpeningBalance <> 0
            
          
          
           
            
        END
    ELSE 
        IF @nType = 1			--Vehicle Bills All Transaction
            BEGIN
	
                IF EXISTS ( SELECT  *
                            FROM    sysobjects
                            WHERE   ID = OBJECT_ID(N'TempTransDetailVBill')
                                    AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                    BEGIN
                        DROP TABLE  TempTransDetailVBill
                    END

                --DECLARE @SelectedVehVehicleCode AS VARCHAR(8000)
                --SET @SelectedVehVehicleCode = GetFreightVehicleCode(@FromVehicleCode, @ToVehicleCode)
                --SET @SelectedVehVehicleCode = LTRIM(RTRIM(@SelectedVehVehicleCode))

		
                SELECT  dbo.Vehicles.VehicleCode,
                        dbo.Vehicles.VehicleDescription,
                        dbo.Vehicles.UrduTitle AS UrduVehicleName,
                        dbo.Vehicles.FreightGLCode,
                        dbo.Vehicles.OwnerCode,
                        dbo.Customers.CustomerCode,
                        dbo.Customers.CustomerName,
                        dbo.Customers.UrduTitle AS UrduCustomerName,
                        dbo.[Vehicles ].Capacity
                INTO    #VehicleTAB
                FROM    dbo.Vehicles
                        LEFT OUTER JOIN dbo.Customers ON dbo.Vehicles.CustomerCode = dbo.Customers.CustomerCode
                WHERE   dbo.Vehicles.vehicleCode BETWEEN @FromVehicleCode
                                                 AND     @ToVehicleCode
	



                CREATE INDEX [#IX_VehiclesT ] ON #VehicleTAB ( VehicleCode )
                    WITH SORT_IN_TEMPDB
                ON  [PRIMARY]

                SELECT  OwnerCode,
                        OwnerName,
                        UrduTitle AS UrduOwnerName
                INTO    #VehicleOwnersTAB
                FROM    dbo.VehicleOwners
                WHERE   ( dbo.VehicleOwners.OwnerCode BETWEEN @FromOwnerCode
                                                      AND     @ToOwnerCode )

	
	
                CREATE INDEX #IX_VehicleOwnersT ON #VehicleOwnersTAB ( OwnerCode )
                    WITH SORT_IN_TEMPDB
                ON  [PRIMARY]	
	
                

                SELECT  dbo.VehicleAdjustments.BranchCode,
                        dbo.VehicleAdjustments.VehicleAdjustmentNature,
                        dbo.VehicleAdjustments.VehicleAdjustmentNo,
                        dbo.VehicleAdjustments.VehicleAdjustmentDate,
                        dbo.VehicleAdjustments.VehicleCode,
                        dbo.VehicleAdjustments.UrduTitle,
                        dbo.VehicleAdjustments.RecordNo
                INTO    #TransMasterTAB
                FROM    dbo.VehicleAdjustments
                        INNER JOIN dbo.Branches ON dbo.VehicleAdjustments.BranchCode = dbo.Branches.BranchCode
                WHERE   ( dbo.VehicleAdjustments.VehicleAdjustmentDate BETWEEN @FromDate
                                                                       AND     @ToDate )
                        AND ( dbo.VehicleAdjustments.Posted = @Posted
                              OR @PostedED = 0
                            )
                    

                CREATE INDEX #IX_TransMasterTAB ON #TransMasterTAB ( BranchCode, VehicleAdjustmentNature, VehicleAdjustmentNo )
                    WITH SORT_IN_TEMPDB
                ON  [PRIMARY]	
	
	
	---SELECT ALL INFORMATION OF SELECTED VEHICLE excluding trips
	

                SELECT  dbo.VehicleAdjustmentDetails.BranchCode,
                        dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature,
                        dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo,
                        #VehicleTAB.VehicleCode,
                        #VehicleTAB.OwnerCode,
                        #VehicleOwnersTAB.UrduOwnerName,
                        #VehicleTAB.CustomerCode,
                        #VehicleTAB.CustomerName,
                        #VehicleTAB.UrduCustomerName,
                        #VehicleTAB.Capacity,
                        dbo.VehicleAdjustmentDetails.TransactionTypeCode,
                        CASE RIGHT(VehicleAdjustmentDetails.VehicleAdjustmentNature,
                                   1)
                          WHEN 'R' THEN dbo.VehicleAdjustmentDetails.Amount
                          ELSE 0
                        END AS ReceiptAmount,
                        CASE RIGHT(VehicleAdjustmentDetails.VehicleAdjustmentNature,
                                   1)
                          WHEN 'P' THEN dbo.VehicleAdjustmentDetails.Amount
                          ELSE 0
                        END AS PaymentAmount
                INTO    #DetailVehicleAdjustments
                FROM    #VehicleOwnersTAB
                        RIGHT OUTER JOIN #TransMasterTAB
                        LEFT OUTER JOIN #VehicleTAB ON #TransMasterTAB.VehicleCode = #VehicleTAB.VehicleCode
                        RIGHT OUTER JOIN dbo.VehicleAdjustmentDetails ON #TransMasterTAB.BranchCode = dbo.VehicleAdjustmentDetails.BranchCode
                                                                         AND #TransMasterTAB.VehicleAdjustmentNature = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNature
                                                                         AND #TransMasterTAB.VehicleAdjustmentNo = dbo.VehicleAdjustmentDetails.VehicleAdjustmentNo ON #VehicleOwnersTAB.OwnerCode = #VehicleTAB.OwnerCode
            
	

	---SELECT ALL TRIP INFORMATION
	
                SELECT  #VehicleTAB.VehicleCode,
                        #VehicleTAB.VehicleDescription,
                        dbo.Invoices.TransactionNo,
                        dbo.Invoices.TransactionDate,
                        dbo.Invoices.CustomerReference,
                        dbo.Invoices.RecordNo,
                        dbo.Invoices.StationPointCode,
                        dbo.Invoices.DestinationPointCode,
                        dbo.Invoices.ProductCode,
                        dbo.Invoices.Quantity,
                        dbo.Invoices.Rate,
                        0 AS PaymentAmount,
                        0 AS ReceiptAmount,
                        #VehicleTAB.UrduCustomerName,
                        dbo.Invoices.Commission,
                        dbo.Invoices.ShortageQuantity,
                        dbo.Invoices.Shortage,
                        dbo.Invoices.QuantityValue,
                        #VehicleOwnersTAB.OwnerCode,
                        #VehicleTAB.CustomerCode,
                        #VehicleTAB.CustomerName,
                        #VehicleOwnersTAB.OwnerName,
                        #VehicleOwnersTAB.UrduOwnerName,
                        dbo.StationPoints.StationPointName,
                        dbo.StationPoints.UrduTitle AS StationPointUrdu,
                        TripAdvance,
                        dbo.DestinationPoints.DestinationPointName,
                        dbo.DestinationPoints.UrduTitle AS DestinationPointUrdu,
                        dbo.Products.UrduTitle AS ProductUrdu,
                        #VehicleTAB.Capacity
                INTO    VehicleTrips
                FROM    dbo.StationPoints
                        INNER JOIN dbo.Products
                        INNER JOIN dbo.Invoices ON dbo.Products.ProductCode = dbo.Invoices.ProductCode ON dbo.StationPoints.StationPointCode = dbo.Invoices.StationPointCode
                        INNER JOIN dbo.DestinationPoints ON dbo.Invoices.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode
                        LEFT OUTER JOIN #VehicleOwnersTAB
                        RIGHT OUTER JOIN #VehicleTAB ON #VehicleOwnersTAB.OwnerCode = #VehicleTAB.OwnerCode ON dbo.Invoices.VehicleCode = #VehicleTAB.VehicleCode
                WHERE   ( dbo.Invoices.TransactionDate BETWEEN @FromDate
                                                       AND     @ToDate )
                        AND ( dbo.Invoices.Amount <> 0 )
	-- select * from VehicleTrips



                SELECT  *
                INTO    TempTransDetailVBill
                FROM    ( SELECT    'TRIP' AS MODE,
                                    TransactionNo,
                                    TransactionDate,
                                    RecordNo,
                                    CustomerReference,
                                    VehicleCode,
                                    StationPointCode,
                                    DestinationPointCode,
                                    ProductCode,
                                    Quantity,
                                    Rate,
                                    PaymentAmount,
                                    ReceiptAmount,
                                    Commission,
                                    ShortageQuantity,
                                    Shortage,
                                    QuantityValue,
                                    OwnerCode,
                                    OwnerName,
                                    UrduOwnerName,
                                    ProductUrdu,
                                    StationPointName,
                                    StationPointUrdu,
                                    DestinationPointName,
                                    DestinationPointUrdu,
                                    StationPointUrdu + ' - '
                                    + DestinationPointUrdu AS GLDescription,
                                    CustomerCode,
                                    CustomerName,
                                    UrduCustomerName,
                                    Capacity,
                                    '' AS Narration,
                                    TripAdvance
                          FROM      VehicleTrips
                          UNION ALL
                          SELECT    'OTHERS' AS MODE,
                                    #DetailVehicleAdjustments.VehicleAdjustmentNo,
                                    #TransMasterTAB.VehicleAdjustmentDate,
                                    #TransMasterTAB.RecordNo,
                                    '' AS CustomRef,
                                    #DetailVehicleAdjustments.VehicleCode,
                                    '' AS StationPointCode,
                                    '' AS DestinationPointCode,
                                    '' AS ProductCode,
                                    0 AS Quantity,
                                    0 AS Rate,
                                    #DetailVehicleAdjustments.PaymentAmount,
                                    #DetailVehicleAdjustments.ReceiptAmount,
                                    0 AS Commission,
                                    0 AS ShortageQuantity,
                                    0 AS Shortage,
                                    0 AS QuantityValue,
                                    #DetailVehicleAdjustments.OwnerCode,
                                    '' AS OwnerName,
                                    #DetailVehicleAdjustments.UrduOwnerName,
                                    '' AS ProductUrdu,
                                    '' AS StationPointName,
                                    '' AS StationPointUrdu,
                                    '' AS DestinationPointName,
                                    '' AS DestinationPointUrdu,
                                    #TransMasterTAB.UrduTitle AS GLDescription,
                                    #DetailVehicleAdjustments.CustomerCode,
                                    #DetailVehicleAdjustments.CustomerName,
                                    #DetailVehicleAdjustments.UrduCustomerName,
                                    #DetailVehicleAdjustments.Capacity,
                                    #DetailVehicleAdjustments.TransactionTypeCode AS Narration,
                                    0 AS TripAdvance
                          FROM      #TransMasterTAB
                                    INNER JOIN #DetailVehicleAdjustments ON #TransMasterTAB.BranchCode = #DetailVehicleAdjustments.BranchCode
                                                                           AND #TransMasterTAB.VehicleAdjustmentNature = #DetailVehicleAdjustments.VehicleAdjustmentNature
                                                                           AND #TransMasterTAB.VehicleAdjustmentNo = #DetailVehicleAdjustments.VehicleAdjustmentNo
                                    LEFT OUTER JOIN #VehicleTAB ON #DetailVehicleAdjustments.VehicleCode = #VehicleTAB.VehicleCode
                        ) Bills
                WHERE   ( TransactionDate BETWEEN @FromDate AND @ToDate )
                        AND ( VehicleCode BETWEEN @FromVehicleCode
                                          AND     @ToVehicleCode )
                        AND ( OwnerCode BETWEEN @FromOwnerCode AND @ToOwnerCode )
	--AND  ',' + @SelectedVehVehicleCode + ','   NOT LIKE '%,' + CAST(  VehicleCode as varchar) + ',%' OR @SelectedVehVehicleCode = ''


              
                
             
               
           
                DROP TABLE VehicleTrips

            END
        ELSE 
            IF @nType = 4		--  GET Transaction Detail
                BEGIN
                    IF EXISTS ( SELECT  *
                                FROM    sysobjects
                                WHERE   ID = OBJECT_ID(N'TempTransDetailVBill')
                                        AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                        BEGIN
                            SELECT  *
                            FROM    TempTransDetailVBill
                            ORDER BY TransactionDate,
                                    TransactionNo
		--DROP TABLE  TempTransDetailVBill
                        END
                    ELSE 
                        BEGIN
                            SELECT  '' AS Error
                            WHERE   0 = 1
                        END
                END
            ELSE 
                IF @nType = 3 
                    BEGIN
                        IF EXISTS ( SELECT  *
                                    FROM    sysobjects
                                    WHERE   ID = OBJECT_ID(N'TempCOAOpening')
                                            AND OBJECTPROPERTY(ID, N'IsTable') = 1 ) 
                            BEGIN
                                SELECT  *
                                FROM    TempCOAOpening
                                DROP TABLE  TempCOAOpening
                            END
                        ELSE 
                            BEGIN
                                SELECT  '' AS Error
                                WHERE   0 = 1
                            END
                    END

GO
