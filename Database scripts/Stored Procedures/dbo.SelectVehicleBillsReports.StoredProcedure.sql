USE [TMS_ALI]
GO
/****** Object:  StoredProcedure [dbo].[SelectVehicleBillsReports]    Script Date: 03-Feb-18 9:47:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectVehicleBillsReports]
    @FromBranchCode VARCHAR(10) = '',
    @ToBranchCode VARCHAR(10) = '',
    @FromDivisionCode VARCHAR(10) = '',
    @ToDivisionCode VARCHAR(10) = '',
    @FromOwnerCode AS CHAR(10) = '',
    @ToOwnerCode AS CHAR(10) = '',
    @FromGLCode VARCHAR(50) = '',
    @FromVehicleCode AS CHAR(10) = '',
    @ToVehicleCode AS CHAR(10) = '',
    @ToGLCode VARCHAR(50) = '',
    @FromDate DATETIME = NULL,
    @ToDate DATETIME = NULL,
    @nType BIGINT = 0,
    @VoucherNatureCode VARCHAR(100) = '',
    @ReportSD AS VARCHAR(10) = 'DET',
    @Posted BIT = 1,
    @PostedED BIT = 0
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
	
	-- SELECT Division with Filter
            SELECT  DivisionCode AS SysDivisionCode,
                    DivisionCode,
                    Division,
                    Division AS DivisionRptTitle
            INTO    #Divisions
            FROM    dbo.Divisions
	--WHERE	(dbo.Divisions.DivisionCode BETWEEN @FromDivisionCode AND @ToDivisionCode)
	
            CREATE INDEX #IX_Divisions ON #Divisions ( DivisionCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]
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

            SELECT  dbo.Vehicles.VehicleCode,
                    dbo.Vehicles.VehicleDescription,
                    dbo.Vehicles.UrduTitle AS UrduVehicleName,
                    dbo.Vehicles.FreightGLCode,
                    dbo.Vehicles.OwnerCode,
                    dbo.Customers.CustomerCode,
                    dbo.Customers.CustomerName,
                    dbo.Customers.UrduTitle AS UrduCustomerName,
                    dbo.Vehicles.Capacity
            INTO    #VehiclesTAB
            FROM    dbo.Vehicles
                    LEFT OUTER JOIN dbo.Customers ON dbo.Vehicles.CustomerCode = dbo.Customers.CustomerCode
            WHERE   ( dbo.Vehicles.VehicleCode BETWEEN @FromVehicleCode
                                               AND     @ToVehicleCode )
	--WHERE	(dbo.Vehicles.VehicleCode ='LSA 3940')

            CREATE INDEX [#IX_VehiclesT ] ON #VehiclesTAB ( VehicleCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]

            SELECT  OwnerCode,
                    OwnerName,
                    UrduTitle AS UrduOwnerName
            INTO    #VehicleOwners
            FROM    dbo.VehicleOwners
            WHERE   ( dbo.VehicleOwners.OwnerCode BETWEEN @FromOwnerCode
                                                  AND     @ToOwnerCode )

	
            CREATE INDEX #IX_#VehicleOwners ON #VehicleOwners ( OwnerCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]	

	-- SELECT GLAccount with Filter on Vehicle & Owner

            SELECT  dbo.GL_GetCOACombineLedTBRptVW.GLCode,
                    dbo.GL_GetCOACombineLedTBRptVW.GLRptTitle,
                    dbo.GL_GetCOACombineLedTBRptVW.ControlCode,
                    dbo.GL_GetCOACombineLedTBRptVW.ControlRptTitle,
                    dbo.GL_GetCOACombineLedTBRptVW.GeneralCode,
                    dbo.GL_GetCOACombineLedTBRptVW.GeneralRptTitle,
                    dbo.GL_GetCOACombineLedTBRptVW.SubSidiaryCode,
                    dbo.GL_GetCOACombineLedTBRptVW.SubsidiaryRptTitle,
                    dbo.GL_GetCOACombineLedTBRptVW.SubsubCode,
                    dbo.GL_GetCOACombineLedTBRptVW.SubSubRptTitle,
                    dbo.#VehiclesTAB.VehicleCode,
                    dbo.#VehiclesTAB.VehicleDescription,
                    dbo.VehicleOwners.OwnerCode,
                    dbo.VehicleOwners.OwnerName,
                    dbo.VehicleOwners.UrduTitle AS UrduOwnerName,
                    dbo.#VehiclesTAB.CustomerCode,
                    dbo.#VehiclesTAB.CustomerName,
                    dbo.#VehiclesTAB.UrduCustomerName
            INTO    #COACombineLedTBRptVW
            FROM    dbo.GL_GetCOACombineLedTBRptVW
                    INNER JOIN dbo.#VehiclesTAB ON dbo.GL_GetCOACombineLedTBRptVW.GLCode = dbo.#VehiclesTAB.FreightGLCode
                    LEFT OUTER JOIN dbo.VehicleOwners ON dbo.#VehiclesTAB.OwnerCode = dbo.VehicleOwners.OwnerCode
	
            CREATE INDEX #IX_COACombineLedTBRptVW ON #COACombineLedTBRptVW ( GLCode )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]
	
            
            


	-- SELECT Last Closing Date For OpeningBalanceTAB Filter
            SELECT  dbo.OpeningBalances.BranchCode,
                    dbo.OpeningBalances.DivisionCode,
                    dbo.OpeningBalances.GLCode,
                    MAX(dbo.OpeningBalances.ClosingDate) AS ClosingDate
            INTO    #OpeningDate
            FROM    dbo.OpeningBalances
                    INNER JOIN #Branches ON dbo.OpeningBalances.BranchCode = #Branches.BranchCode
                    INNER JOIN #COACombineLedTBRptVW ON dbo.OpeningBalances.GLCode = #COACombineLedTBRptVW.GLCode
                    INNER JOIN #Divisions ON dbo.OpeningBalances.DivisionCode = #Divisions.DivisionCode
            WHERE   ( dbo.OpeningBalances.ClosingDate <= @ToDate )
            GROUP BY dbo.OpeningBalances.BranchCode,
                    dbo.OpeningBalances.DivisionCode,
                    dbo.OpeningBalances.GLCode
            CREATE INDEX #IX_OpeningDate ON #OpeningDate ( BranchCode, DivisionCode, GLCode, ClosingDate )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]
	
	-- SELECT OpeningBalance From OpeningBalanceTAB With ClosingDate Filter
            SELECT  dbo.OpeningBalances.ClosingDate,
                    dbo.OpeningBalances.BranchCode,
                    dbo.OpeningBalances.DivisionCode,
                    dbo.OpeningBalances.GLCode,
                    dbo.OpeningBalances.DebitBalance
                    - dbo.OpeningBalances.CreditBalance AS OpeningBalance
            INTO    #OpeningTAB
            FROM    dbo.OpeningBalances
                    INNER JOIN #OpeningDate ON dbo.OpeningBalances.BranchCode = #OpeningDate.BranchCode
                                               AND dbo.OpeningBalances.ClosingDate = #OpeningDate.ClosingDate
                                               AND dbo.OpeningBalances.DivisionCode = #OpeningDate.DivisionCode
                                               AND dbo.OpeningBalances.GLCode = #OpeningDate.GLCode
	
	-- SELECT Previous Closing Date For Master Transaction Filter
            SELECT  @DocDate = ISNULL(MIN(#OpeningDate.ClosingDate), 0) + 1
            FROM    #OpeningDate
            PRINT @DocDate
	


	-- Select Master Transaction For DetailTransaction Filter
            SELECT  dbo.Vouchers.BranchCode,
                    dbo.Vouchers.VoucherNature,
                    dbo.Vouchers.VoucherNo,
                    dbo.Vouchers.VoucherDate,
                    dbo.Vouchers.RecordNo
            INTO    #TransMasterTAB
            FROM    dbo.Vouchers
                    INNER JOIN #Branches ON dbo.Vouchers.BranchCode = #Branches.BranchCode
            WHERE   ( dbo.Vouchers.VoucherDate BETWEEN @DocDate
                                               AND     @ToDate )
                    AND ( dbo.Vouchers.Posted = @Posted
                          OR @PostedED = 0
                        ) 
            CREATE INDEX #IX_TransMaster ON #TransMasterTAB ( BranchCode, VoucherNature, VoucherNo )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]	
	-- SELECT Detail Transaction With Date
            SELECT  dbo.VoucherDetails.BranchCode,
                    #TransMasterTAB.VoucherDate,
                    dbo.VoucherDetails.GLCode,
                    #TransMasterTAB.RecordNo,
                    dbo.VoucherDetails.DivisionCode AS Division,
                    dbo.VoucherDetails.Debit,
                    dbo.VoucherDetails.Credit
            INTO    #TransDetail
            FROM    #TransMasterTAB
                    INNER JOIN dbo.VoucherDetails ON #TransMasterTAB.BranchCode = dbo.VoucherDetails.BranchCode
                                                     AND #TransMasterTAB.VoucherNature = dbo.VoucherDetails.VoucherNature
                                                     AND #TransMasterTAB.VoucherNo = dbo.VoucherDetails.VoucherNo
                    INNER JOIN #Divisions ON dbo.VoucherDetails.DivisionCode = #Divisions.DivisionCode
	
            CREATE INDEX #IX_TransDetail ON #TransDetail ( BranchCode, VoucherDate, GLCode, Division )
                WITH SORT_IN_TEMPDB
            ON  [PRIMARY]	
	-- Select Transaction Balance
            SELECT  #TransDetail.BranchCode,
                    #TransDetail.Division,
                    #TransDetail.GLCode,
                    SUM(#TransDetail.Debit) - SUM(#TransDetail.Credit) AS TransBalance
            INTO    #TransBalTAB
            FROM    #TransDetail
                    LEFT OUTER JOIN #OpeningDate ON #TransDetail.BranchCode = #OpeningDate.BranchCode
                                                    AND #TransDetail.VoucherDate > #OpeningDate.ClosingDate
                                                    AND #TransDetail.GLCode = #OpeningDate.GLCode
                                                    AND #TransDetail.Division = #OpeningDate.DivisionCode
            GROUP BY #TransDetail.BranchCode,
                    #TransDetail.Division,
                    #TransDetail.GLCode
	
	---   Final Opening Balance 
            SELECT  BranchCode,
                    DivisionCode,
                    GLCode,
                    SUM(OpeningBalance) AS OpeningBalance
            INTO    #TransTAB
            FROM    ( SELECT    BranchCode,
                                DivisionCode,
                                GLCode,
                                OpeningBalance
                      FROM      #OpeningTAB
                      UNION ALL
                      SELECT    BranchCode,
                                Division,
                                GLCode,
                                TransBalance
                      FROM      #TransBalTAB
                    ) TransTAB
            GROUP BY BranchCode,
                    DivisionCode,
                    GLCode
	
	--- Final Opening Balance With Titles
            SELECT  #Branches.BranchCode,
                    #Branches.BranchRptTitle,
                    #Divisions.DivisionCode,
                    #Divisions.DivisionRptTitle,
                    #COACombineLedTBRptVW.GLCode,
                    #COACombineLedTBRptVW.GLRptTitle AS GLDescription,
                    #COACombineLedTBRptVW.VehicleCode,
                    #COACombineLedTBRptVW.UrduCustomerName,
                    #COACombineLedTBRptVW.OwnerCode,
                    #COACombineLedTBRptVW.OwnerName,
                    #COACombineLedTBRptVW.UrduOwnerName,
                    #COACombineLedTBRptVW.CustomerCode,
                    #COACombineLedTBRptVW.CustomerName,
                    #TransTAB.OpeningBalance
            INTO    TempCOAOpening
            FROM    #TransTAB
                    INNER JOIN #Branches ON #TransTAB.BranchCode = #Branches.BranchCode
                    INNER JOIN #Divisions ON #TransTAB.DivisionCode = #Divisions.DivisionCode
                    INNER JOIN #COACombineLedTBRptVW ON #TransTAB.GLCode = #COACombineLedTBRptVW.GLCode
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

                DECLARE @SelectedVehGLCode AS VARCHAR(8000)
                SET @SelectedVehGLCode = dbo.GetFreightGLCode(@FromVehicleCode, @ToVehicleCode)
                SET @SelectedVehGLCode = LTRIM(RTRIM(@SelectedVehGLCode))

		
                SELECT  dbo.Vehicles.VehicleCode,
                        dbo.Vehicles.VehicleDescription,
                        dbo.Vehicles.UrduTitle AS UrduVehicleName,
                        dbo.Vehicles.FreightGLCode,
                        dbo.Vehicles.OwnerCode,
                        dbo.Customers.CustomerCode,
                        dbo.Customers.CustomerName,
                        dbo.Customers.UrduTitle AS UrduCustomerName,
                        dbo.[Vehicles ].Capacity
                INTO    #VehiclesT
                FROM    dbo.Vehicles
                        LEFT OUTER JOIN dbo.Customers ON dbo.Vehicles.CustomerCode = dbo.Customers.CustomerCode
                WHERE   dbo.Vehicles.vehicleCode BETWEEN @FromVehicleCode
                                                 AND     @ToVehicleCode
	



                CREATE INDEX [#IX_VehiclesT ] ON #VehiclesT ( VehicleCode )
                    WITH SORT_IN_TEMPDB
                ON  [PRIMARY]

                SELECT  OwnerCode,
                        OwnerName,
                        UrduTitle AS UrduOwnerName
                INTO    #VehicleOwnersTAB
                FROM    dbo.VehicleOwners
                WHERE   ( dbo.VehicleOwners.OwnerCode BETWEEN @FromOwnerCode
                                                      AND     @ToOwnerCode )

	
	
                CREATE INDEX #IX_#VehicleOwnersTAB ON #VehicleOwnersTAB ( OwnerCode )
                    WITH SORT_IN_TEMPDB
                ON  [PRIMARY]	
	
                SELECT  GLCode,
                        GLRptTitle,
                        ControlCode,
                        ControlRptTitle,
                        GeneralCode,
                        GeneralRptTitle,
                        SubSidiaryCode,
                        SubsidiaryRptTitle,
                        SubsubCode,
                        SubSubRptTitle
                INTO    #COACombineLedTBRptVWT
                FROM    dbo.GL_GetCOACombineLedTBRptVW

                CREATE INDEX #IX_#COACombineLedTBRptVWT ON #COACombineLedTBRptVWT ( GLCode )
                    WITH SORT_IN_TEMPDB
                ON  [PRIMARY]

                SELECT DISTINCT dbo.Vouchers.BranchCode,
                        dbo.Vouchers.VoucherNature,
                        dbo.Vouchers.VoucherNo,
                        dbo.Vouchers.VoucherDate,
                        dbo.Vouchers.UrduTitle,
                        dbo.Vouchers.RecordNo
                INTO    #TransMaster
                FROM    dbo.Vouchers
                        INNER JOIN dbo.Branches ON dbo.Vouchers.BranchCode = dbo.Branches.BranchCode
                WHERE   ( dbo.Vouchers.VoucherDate BETWEEN @FromDate
                                                   AND     @ToDate )
                        AND ( dbo.Vouchers.Posted = @Posted
                              OR @PostedED = 0
                            )
                        AND ( dbo.Vouchers.VoucherNature <> 'SV' )

                CREATE INDEX #IX_TransMaster ON #TransMaster ( BranchCode, VoucherNature, VoucherNo )
                    WITH SORT_IN_TEMPDB
                ON  [PRIMARY]	
	
	
	---SELECT ALL INFORMATION OF SELECTED VEHICLE excluding trips
	

                SELECT   dbo.VoucherDetails.BranchCode,
                        dbo.VoucherDetails.VoucherNature,
                        dbo.VoucherDetails.VoucherNo,
                        dbo.#VehiclesT.VehicleCode,
                        dbo.#VehiclesT.OwnerCode,
                        dbo.#VehicleOwnersTAB.UrduOwnerName,
                        dbo.#VehiclesT.CustomerCode,
                        dbo.#VehiclesT.CustomerName,
                        dbo.#VehiclesT.UrduCustomerName,
                        dbo.#VehiclesT.Capacity
                INTO    #DetailVehicleVouchers
                FROM    dbo.VoucherDetails
                        INNER JOIN dbo.#VehiclesT ON dbo.VoucherDetails.GLCode = dbo.#VehiclesT.FreightGLCode
                        LEFT OUTER JOIN dbo.#VehicleOwnersTAB ON dbo.#VehiclesT.OwnerCode = dbo.#VehicleOwnersTAB.OwnerCode
                        LEFT OUTER JOIN dbo.#TransMaster ON dbo.VoucherDetails.BranchCode = dbo.#TransMaster.BranchCode
                                                           AND dbo.VoucherDetails.VoucherNature = dbo.#TransMaster.VoucherNature
                                                           AND dbo.VoucherDetails.VoucherNo = dbo.#TransMaster.VoucherNo
                WHERE   ( dbo.VoucherDetails.VoucherNature <> 'SV' )



	---SELECTED ALL INFORMATION  vehicle transaction i.e. instalment , trip advance etc
	
                SELECT  dbo.VoucherDetails.BranchCode,
                        dbo.VoucherDetails.VoucherNature,
                        dbo.VoucherDetails.VoucherNo,
                        #DetailVehicleVouchers.VehicleCode,
                        #DetailVehicleVouchers.CustomerCode,
                        #DetailVehicleVouchers.Capacity,
                        dbo.VoucherDetails.Narration,
                        #DetailVehicleVouchers.CustomerName,
                        #DetailVehicleVouchers.UrduCustomerName,
                        #DetailVehicleVouchers.OwnerCode,
                        #DetailVehicleVouchers.UrduOwnerName,
                        dbo.VoucherDetails.Debit,
                        dbo.VoucherDetails.Credit,
                        dbo.VoucherDetails.GLCode
                INTO    #DetailExcVehicleVouchers
                FROM    dbo.VoucherDetails
                        INNER JOIN dbo.#DetailVehicleVouchers ON dbo.VoucherDetails.BranchCode = dbo.#DetailVehicleVouchers.BranchCode
                                                                AND dbo.VoucherDetails.VoucherNature = dbo.#DetailVehicleVouchers.VoucherNature
                                                                AND dbo.VoucherDetails.VoucherNo = dbo.#DetailVehicleVouchers.VoucherNo
                WHERE   dbo.VoucherDetails.GLCode IN ( SELECT   FreightGLCode
                                                       FROM     #VehiclesT )
	--Where   ',' + @SelectedVehGLCode + ','  LIKE '%,' + CAST(  dbo.VoucherDetails.GLCode as varchar) + ',%' OR @SelectedVehGLCode = ''	          
	
--SELECT * FROM #DetailExcVehicleVouchers
	---SELECT ALL TRIP INFORMATION
	
                SELECT  dbo.#VehiclesT.VehicleCode,
                        dbo.#VehiclesT.VehicleDescription,
                        dbo.Invoices.TransactionNo,
                        dbo.Invoices.TransactionDate,
                        dbo.Invoices.CustomerReference,
                        dbo.Invoices.RecordNo,
                        dbo.Invoices.StationPointCode,
                        dbo.Invoices.DestinationPointCode,
                        dbo.Invoices.ProductCode,
                        dbo.Invoices.Quantity,
                        dbo.Invoices.Rate,
                        0 AS Debit,
                        0 AS Credit,
                        dbo.#VehiclesT.UrduCustomerName,
                        dbo.Invoices.Commission,
                        dbo.Invoices.ShortageQuantity,
                        dbo.Invoices.Shortage,
                        dbo.Invoices.QuantityValue,
                        dbo.#VehicleOwnersTAB.OwnerCode,
                        dbo.#VehiclesT.CustomerCode,
                        dbo.#VehiclesT.CustomerName,
                        dbo.#VehicleOwnersTAB.OwnerName,
                        dbo.#VehicleOwnersTAB.UrduOwnerName,
                        dbo.StationPoints.StationPointName,
                        dbo.StationPoints.UrduTitle AS StationPointUrdu,
                        TripAdvance,
                        dbo.DestinationPoints.DestinationPointName,
                        dbo.DestinationPoints.UrduTitle AS DestinationPointUrdu,
                        dbo.Products.UrduTitle AS ProductUrdu,
                        dbo.#VehiclesT.Capacity
                INTO    #VehiclesTrips
                FROM    dbo.StationPoints
                        INNER JOIN dbo.Products
                        INNER JOIN dbo.Invoices ON dbo.Products.ProductCode = dbo.Invoices.ProductCode ON dbo.StationPoints.StationPointCode = dbo.Invoices.StationPointCode
                        INNER JOIN dbo.DestinationPoints ON dbo.Invoices.DestinationPointCode = dbo.DestinationPoints.DestinationPointCode
                        LEFT OUTER JOIN dbo.#VehicleOwnersTAB
                        RIGHT OUTER JOIN dbo.#VehiclesT ON dbo.#VehicleOwnersTAB.OwnerCode = dbo.#VehiclesT.OwnerCode ON dbo.Invoices.VehicleCode = dbo.#VehiclesT.VehicleCode
                WHERE   ( dbo.Invoices.TransactionDate BETWEEN @FromDate
                                                       AND     @ToDate )
                        AND dbo.Invoices.Amount <> 0
	-- select * from #VehiclesTrips



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
                                    Debit,
                                    Credit,
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
                                    '' AS GLCode,
                                    StationPointUrdu + ' - '
                                    + DestinationPointUrdu AS GLDescription,
                                    CustomerCode,
                                    CustomerName,
                                    UrduCustomerName,
                                    Capacity,
                                    '' AS Narration,
                                    TripAdvance
                          FROM      dbo.#VehiclesTrips
                          UNION ALL
                          SELECT    'OTHERS' AS MODE,
                                    dbo.#DetailExcVehicleVouchers.VoucherNo,
                                    dbo.#TransMaster.VoucherDate,
                                    dbo.#TransMaster.RecordNo,
                                    '' AS CustomRef,
                                    #DetailExcVehicleVouchers.VehicleCode,
                                    '' AS StationPointCode,
                                    '' AS DestinationPointCode,
                                    '' AS ProductCode,
                                    0 AS Quantity,
                                    0 AS Rate,
                                    dbo.#DetailExcVehicleVouchers.Debit,
                                    dbo.#DetailExcVehicleVouchers.Credit,
                                    0 AS Commission,
                                    0 AS ShortageQuantity,
                                    0 AS Shortage,
                                    0 AS QuantityValue,
                                    #DetailExcVehicleVouchers.OwnerCode,
                                    '' AS OwnerName,
                                    #DetailExcVehicleVouchers.UrduOwnerName,
                                    '' AS ProductUrdu,
                                    '' AS StationPointName,
                                    '' AS StationPointUrdu,
                                    '' AS DestinationPointName,
                                    '' AS DestinationPointUrdu,
                                    dbo.#COACombineLedTBRptVWT.GLCode,
                                    dbo.#TransMaster.UrduTitle AS GLDescription,
                                    CustomerCode,
                                    CustomerName,
                                    UrduCustomerName,
                                    Capacity,
                                    #DetailExcVehicleVouchers.Narration,
                                    0 AS TripAdvance
                          FROM      dbo.#TransMaster
                                    INNER JOIN dbo.#DetailExcVehicleVouchers ON dbo.#TransMaster.BranchCode = dbo.#DetailExcVehicleVouchers.BranchCode
                                                                               AND dbo.#TransMaster.VoucherNature = dbo.#DetailExcVehicleVouchers.VoucherNature
                                                                               AND dbo.#TransMaster.VoucherNo = dbo.#DetailExcVehicleVouchers.VoucherNo
                                    LEFT OUTER JOIN dbo.#COACombineLedTBRptVWT ON dbo.#DetailExcVehicleVouchers.GLCode = dbo.#COACombineLedTBRptVWT.GLCode
                        ) Bills
                WHERE   ( TransactionDate BETWEEN @FromDate AND @ToDate )
                        AND ( VehicleCode BETWEEN @FromVehicleCode
                                          AND     @ToVehicleCode )
                        AND ( OwnerCode BETWEEN @FromOwnerCode AND @ToOwnerCode )
	--AND  ',' + @SelectedVehGLCode + ','   NOT LIKE '%,' + CAST(  GLCODE as varchar) + ',%' OR @SelectedVehGLCode = ''

          
                
             
             

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
