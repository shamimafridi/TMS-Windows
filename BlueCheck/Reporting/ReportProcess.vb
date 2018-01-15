Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Module ReportProcess
    Sub StartProcess(ByVal File As String, ByVal ReportType As String, ByRef reportDoc As ReportDocument, ByVal ParamArray PrimaryControls() As Control)

        Try
            Dim TrNature As String = String.Empty
            Dim TrFound As Boolean
            Dim a As Int16
            For a = 0 To PrimaryControls.Length - 1
                If Mid(PrimaryControls(a).Tag, 4, Len(PrimaryControls(a).Tag)) = "TransactionNature" Then
                    TrNature = PrimaryControls(a).Text
                    TrFound = True
                    Select Case TrNature
                        Case Is = "10"
                            TrNature = "Receiving Document"
                        Case Is = "20"
                            TrNature = "Sale Return"
                        Case Is = "30"
                            TrNature = "Receiving Return"
                        Case Is = "40"
                            TrNature = "Sale Invoice"
                        Case Is = "JV"
                            TrNature = "Jornal Voucher"
                        Case Is = "CR"
                            TrNature = "Cash Receipt Voucher"
                        Case Is = "CP"
                            TrNature = "Cash Payment Voucher"
                        Case Is = "BP"
                            TrNature = "Bank Payment Voucher"
                        Case Is = "BR"
                            TrNature = "Bank Receipt Voucher"
                    End Select
                End If
            Next
            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess

            Dim Ds As DataSet = Nothing
            Dim Access As New AzamTechnologies.Database.DataAccess

            If PrimaryControls.Length = 1 Then
                If PrimaryControls(0).Text.Length = 0 Then Exit Sub
                Acc.PopulateDataSet(Ds, "Select" & File, "OPTION", "REPORT", Mid(PrimaryControls(0).Tag, 4), PrimaryControls(0).Text)

            ElseIf PrimaryControls.Length = 2 Then
                If PrimaryControls(0).Text.Length = 0 Or PrimaryControls(1).Text.Length = 0 Then Exit Sub
                Acc.PopulateDataSet(Ds, "Select" & File, "OPTION", "REPORT", Mid(PrimaryControls(0).Tag, 4), PrimaryControls(0).Text, Mid(PrimaryControls(1).Tag, 4), PrimaryControls(1).Text)

            ElseIf PrimaryControls.Length = 3 Then
                If PrimaryControls(0).Text.Length = 0 Or PrimaryControls(1).Text.Length = 0 Or PrimaryControls(2).Text.Length = 0 Then Exit Sub
                Acc.PopulateDataSet(Ds, "Select" & File, "OPTION", "REPORT", Mid(PrimaryControls(0).Tag, 4), PrimaryControls(0).Text, Mid(PrimaryControls(1).Tag, 4), PrimaryControls(1).Text, Mid(PrimaryControls(2).Tag, 4), PrimaryControls(2).Text)
            End If
            '''''''''''''''''''''

            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\" & File & ".xsd")
            'Dim i As Integer
            'For i = 0 To Ds.Tables(0).Rows.Count
            '    'If Ds.Tables(0).Rows(i).Item("434") = "$#" Then
            'Next
            Dim strReportPath As String = Application.StartupPath & "\Reports\" & File & ReportType & ".rpt"
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If
            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))
            Dim strReporTitle As String

            If ReportType = AzamTechnologies.DataManager.PrintActionEventArgs.ReportStyle.Document.ToString Then
                strReporTitle = File & " Card"
            Else
                strReporTitle = File & " Listing"
            End If
            If TrFound Then
                strReporTitle = TrNature
            End If
            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            SetParameter(paramFields, "User", OperatorID)

        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Enum ReportFiles
        ProductReceiving = 1
        ProductReceivingReturn = 2
        SaleInvoice = 3
        SaleInvoiceReturn = 4
        TransactionList = 5
        GeneralLedger = 6
        TrialBalance = 7
        VehicleList = 8
        ProfitListing = 10
        ChartOfAccountList = 11
        VoucherDocuments = 12
        VoucherList = 13
        VehicleBills = 14
        CashFlowStatements = 15
        BalanceSheet = 16
        IncomeStatement = 17
        FreightStatement = 18
        FreightStatementDetail = 19
        FreightStatementSummary = 20
        VehicleBillAnalysis = 21
        VehicleLedger = 22
        VehicleRevenue = 23
        VehicleRevenuePivot = 24
    End Enum
    Public Const StartParameter As String = ""
    Public Const EndParameter As String = "zzzzzzzzzzzzzzzzzzz"
    Const DocumentReportFileName As String = "TransactionsDocument"
    Const VoucherReportFileName As String = "VouchersDocument"
    Const DocumentListReportFileName As String = "TransactionList"
    Const GeneralLedgerReportFileName As String = "GeneralLedger"
    Const VehicleBillReportFileName As String = "VehicleBill"
    Const TrialBalanceReportFileName As String = "ItemTrialBalance"
    Const ItemListReportFileName As String = "ItemList"
    Const ProfitListReportFileName As String = "ProfitListing"
    Const ChartOfAccountReportFileName As String = "ChartOfAccountList"
    Const VoucherListReportFileName As String = "VoucherDetailListing"
    Enum ReportTargetControl
        ReportViewer
        Grid
    End Enum
    Public TargetControl As ReportTargetControl
    ' Dim Reports As ReportFiles
    Function TransactionDocumentsProcess(ByVal File As ReportFiles, ByVal FromCode As String, ByVal ToCode As String, _
      ByVal FromDate As Date, ByVal ToDate As Date, ByVal FromPartyCode As String, ByVal ToPartyCode As String, ByRef reportDoc As ReportDocument) As Boolean

        Dim TransNature As String = String.Empty
        Dim strReporTitle As String = String.Empty


        If FromCode = "" Then FromCode = StartParameter
        If ToCode = "" Then ToCode = EndParameter
        If FromPartyCode = "" Then FromPartyCode = StartParameter
        If ToPartyCode = "" Then ToPartyCode = EndParameter
        If ToDate = Nothing Then ToDate = Now.Date

        Try

            Select Case File
                Case ReportFiles.ProductReceiving
                    TransNature = "10"
                    strReporTitle = "Product Receiving Document"
                Case ReportFiles.ProductReceivingReturn
                    TransNature = "30"
                    strReporTitle = "Product Receiving Return Document"
                Case ReportFiles.SaleInvoice
                    TransNature = "40"
                    strReporTitle = "Sale Invoice"
                Case ReportFiles.SaleInvoiceReturn
                    TransNature = "20"
                    strReporTitle = "Sale Return Invoice"
            End Select

            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            Acc.PopulateDataSet(Ds, "SelectTransactionDocumentReports", "OPTION", "", _
            "TransactionNature", TransNature, "FromCode", FromCode, "ToCode", ToCode, "FromDate", FromDate, "ToDate", ToDate, "FromPartyCode", FromPartyCode, "ToPartyCode", ToPartyCode)

            If Ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No record found within the specified conditions..." & vbCrLf & vbCrLf & "Please specify valid parameters and " & vbCrLf & "Make sure that the records exists !", "Report Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If
            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\" & DocumentReportFileName & ".xsd")

            Dim strReportPath As String = Application.StartupPath & "\Reports\" & DocumentReportFileName & ".rpt"
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If
            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))

            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            SetParameter(paramFields, "User", OperatorID)
            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
#Region "General Ledger Reports"
    Public Function ChartOfAccountList(ByVal File As ReportFiles, ByVal FromCode As String, ByVal ToCode As String, _
      ByVal FromDate As Date, ByVal ToDate As Date, ByRef reportDoc As ReportDocument, Optional ByVal nGroupedBy As Integer = 0, Optional ByVal PageBreak As Boolean = False) As Boolean

        Dim strReporTitle As String = String.Empty
        Dim StrOption As String = String.Empty

        If FromCode = "" Then FromCode = StartParameter
        If ToCode = "" Then ToCode = EndParameter
        If ToDate = Nothing Then ToDate = Now.Date

        'Select Case nGroupedBy
        '    Case Is = 0 'CONTROL
        '        StrOption = "CONTROLLIST"
        '    Case Is = 1 'GENERAL
        '        StrOption = "GENERALLIST"
        '    Case Is = 2 'SUBISDIARY
        '        StrOption = "SUBSIDIARYLIST"
        '    Case Is = 3 'CHAROFACCOUNT
        '        StrOption = "SUBSUBSIDIARYLIST"
        '    Case Is = 4 'CHAROFACCOUNT
        '        StrOption = "COAList"
        'End Select
        StrOption = "COAList"
        Try

            strReporTitle = "Chart Of Account List"
            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            Acc.PopulateDataSet(Ds, "SelectCOAListReports", "OPTION", StrOption, _
            "FromCode", FromCode, "ToCode", ToCode, "FromDate", FromDate, "ToDate", ToDate)

            If Ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No record found within the specified conditions..." & vbCrLf & vbCrLf & "Please specify valid parameters and " & vbCrLf & "Make sure that the records exists !", "Report Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If
            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\" & ChartOfAccountReportFileName & ".xsd")

            Dim strReportPath As String = Application.StartupPath & "\Reports\" & ChartOfAccountReportFileName & ".rpt"
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))
            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            SetParameter(paramFields, "ReportType", nGroupedBy + 1)
            SetParameter(paramFields, "PageBreak", PageBreak)
            SetParameter(paramFields, "UserInfo", OperatorID)
            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    ' Dim Reports As ReportFiles
    Function VoucherDocumentsProcess(ByVal File As ReportFiles, ByVal FromCode As String, ByVal ToCode As String, _
      ByVal FromDate As Date, ByVal ToDate As Date, ByVal VoucherTypes As String, ByRef reportDoc As ReportDocument) As Boolean

        Dim TransNature As String = String.Empty
        Dim strReporTitle As String = String.Empty


        If FromCode = "" Then FromCode = StartParameter
        If ToCode = "" Then ToCode = EndParameter
        If ToDate = Nothing Then ToDate = Now.Date

        Try

            Select Case File
                Case ReportFiles.ProductReceiving
                    TransNature = "10"
                    strReporTitle = "Product Receiving Document"
                Case ReportFiles.ProductReceivingReturn
                    TransNature = "30"
                    strReporTitle = "Product Receiving Return Document"
                Case ReportFiles.SaleInvoice
                    TransNature = "40"
                    strReporTitle = "Sale Invoice"
                Case ReportFiles.SaleInvoiceReturn
                    TransNature = "20"
                    strReporTitle = "Sale Return Invoice"
            End Select

            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            Acc.PopulateDataSet(Ds, "SelectVoucherDocumentReports", "OPTION", "", _
            "TransactionNature", VoucherTypes, "FromCode", FromCode, "ToCode", ToCode, "FromDate", FromDate, "ToDate", ToDate)

            If Ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No record found within the specified conditions..." & vbCrLf & vbCrLf & "Please specify valid parameters and " & vbCrLf & "Make sure that the records exists !", "Report Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If
            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\" & VoucherReportFileName & ".xsd")

            Dim strReportPath As String = Application.StartupPath & "\Reports\" & VoucherReportFileName & ".rpt"
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If
            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))

            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            SetParameter(paramFields, "User", OperatorID)
            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
#End Region

    Public Function FetchVehicleFreightStatements(ByVal File As ReportFiles, ByVal StationCode As String, ByVal FromCode As String, ByVal ToCode As String, ByVal fromDate As Date, ByVal ToDate As Date, ByVal FromVehicle As String, ByVal ToVehicle As String, ByVal FromPartyCode As String, ByVal ToPartyCode As String, ByVal TransactionNature As String, ByVal DocumentType As String, ByVal nParametersRange As String, ByRef reportDoc As ReportDocument, Optional ByVal Progress As Object = Nothing, Optional ByVal nGroupedBy As Integer = 0, Optional ByVal ShowSubTotal As Integer = False, Optional ByVal PageBreak As Boolean = False) As Boolean
        Dim strReporTitle As String = String.Empty
        If FromCode = "" Then FromCode = StartParameter
        If ToCode = "" Then ToCode = EndParameter
        If FromPartyCode = "" Then FromPartyCode = StartParameter
        If ToPartyCode = "" Then ToPartyCode = EndParameter
        If FromVehicle = "" Then FromVehicle = StartParameter
        If ToVehicle = "" Then ToVehicle = EndParameter
        If ToDate = Nothing Then ToDate = Now.Date

        Try
            If File = ReportFiles.FreightStatement Then
                strReporTitle = "Vehicle Freight Statements"
            ElseIf File = ReportFiles.FreightStatementDetail Then
                strReporTitle = "Vehicle Freight Statements Detail"
            ElseIf File = ReportFiles.FreightStatementSummary Then
                strReporTitle = "Vehicle Freight Statements Summary"
            End If
            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            Acc.PopulateDataSet(Ds, "SelectVehicleFreightStatementsReports", "OPTION", "", _
            "BranchCode", StationCode, "FromCode", FromCode, "ToCode", ToCode, "FromDate", fromDate, "ToDate", ToDate, "FromPartyCode", FromPartyCode, "ToPartyCode", ToPartyCode, "FromVehicleCode", FromVehicle, "ToVehicleCode", ToVehicle)

            If Ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No record found within the specified conditions..." & vbCrLf & vbCrLf & "Please specify valid parameters and " & vbCrLf & "Make sure that the records exists !", "Report Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If
            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\FreightStatement.xsd")
            Dim strReportPath As String = String.Empty

            If File = ReportFiles.FreightStatement Then
                strReportPath = Application.StartupPath & "\Reports\FreightStatement.rpt"
            ElseIf File = ReportFiles.FreightStatementDetail Then
                strReportPath = Application.StartupPath & "\Reports\FreightStatementDetail.rpt"
            ElseIf File = ReportFiles.FreightStatementSummary Then
                strReportPath = Application.StartupPath & "\Reports\FreightStatementSummary.rpt"
            End If

            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))
            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "SystemName", "")
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            SetParameter(paramFields, "ReportType", nGroupedBy)
            SetParameter(paramFields, "ReportType1", ShowSubTotal)
            SetParameter(paramFields, "PageBreak", PageBreak)
            SetParameter(paramFields, "UserInfo", OperatorID)
            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        End Try
    End Function


    Public Function TransactionListProcess(ByVal File As ReportFiles, ByVal FromCode As String, ByVal ToCode As String, _
      ByVal FromDate As Date, ByVal ToDate As Date, ByVal FromPartyCode As String, ByVal ToPartyCode As String, ByVal FromItemCode As String, ByVal ToItemCode As String, ByVal TransactionNature As String, ByRef reportDoc As ReportDocument, Optional ByVal nGroupedBy As Integer = 0, Optional ByVal PageBreak As Boolean = False) As Boolean

        Dim strReporTitle As String


        If FromCode = "" Then FromCode = StartParameter
        If ToCode = "" Then ToCode = EndParameter
        If FromPartyCode = "" Then FromPartyCode = StartParameter
        If ToPartyCode = "" Then ToPartyCode = EndParameter
        If FromItemCode = "" Then FromItemCode = StartParameter
        If ToItemCode = "" Then ToItemCode = EndParameter
        If ToDate = Nothing Then ToDate = Now.Date

        Try

            strReporTitle = "Transaction List"
            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            Acc.PopulateDataSet(Ds, "SelectTransactionListReports", "OPTION", "", _
            "TransactionNature", TransactionNature, "FromCode", FromCode, "ToCode", ToCode, "FromDate", FromDate, "ToDate", ToDate, "FromVehicleCode", FromPartyCode, "ToVehicleCode", ToPartyCode, "FromItemCode", FromItemCode, "ToItemCode", ToItemCode)

            If Ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No record found within the specified conditions..." & vbCrLf & vbCrLf & "Please specify valid parameters and " & vbCrLf & "Make sure that the records exists !", "Report Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If
            If TargetControl = ReportTargetControl.Grid Then
                SettingReportToGrid(ReportFiles.TransactionList, Ds)
                Exit Function
            End If
            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\" & DocumentListReportFileName & ".xsd")

            Dim strReportPath As String = Application.StartupPath & "\Reports\" & DocumentListReportFileName & ".rpt"
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))
            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            SetParameter(paramFields, "PageBreak", PageBreak)
            SetParameter(paramFields, "GroupedBy", nGroupedBy)
            SetParameter(paramFields, "User", OperatorID)
            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function VoucherListProcess(ByVal File As ReportFiles, ByVal FromCode As String, ByVal ToCode As String, _
      ByVal FromDate As Date, ByVal ToDate As Date, ByVal FromGLCode As String, ByVal ToGLCode As String, ByVal VoucherNature As String, ByRef reportDoc As ReportDocument, Optional ByVal nGroupedBy As Integer = 0, Optional ByVal PageBreak As Boolean = False) As Boolean

        Dim strReporTitle As String


        If FromCode = "" Then FromCode = StartParameter
        If ToCode = "" Then ToCode = EndParameter
        If FromGLCode = "" Then FromGLCode = StartParameter
        If ToGLCode = "" Then ToGLCode = EndParameter
        If ToDate = Nothing Then ToDate = Now.Date

        Try

            strReporTitle = "Voucher List"
            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            Acc.PopulateDataSet(Ds, "SelectVoucherListReports", "OPTION", "", _
            "VoucherNature", VoucherNature, "FromCode", FromCode, "ToCode", ToCode, "FromDate", FromDate, "ToDate", ToDate, "FromGLCode", FromGLCode, "ToGLCode", ToGLCode)

            If Ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No record found within the specified conditions..." & vbCrLf & vbCrLf & "Please specify valid parameters and " & vbCrLf & "Make sure that the records exists !", "Report Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If
            If TargetControl = ReportTargetControl.Grid Then
                SettingReportToGrid(ReportFiles.VoucherList, Ds)
                Exit Function
            End If
            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\" & VoucherListReportFileName & ".xsd")

            Dim strReportPath As String = Application.StartupPath & "\Reports\" & VoucherListReportFileName & ".rpt"
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))
            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            SetParameter(paramFields, "PageBreak", PageBreak)
            SetParameter(paramFields, "GroupedBy", nGroupedBy)
            SetParameter(paramFields, "UserInfo", OperatorID)
            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function ProfitListProcess(ByVal File As ReportFiles, ByVal FromCode As String, ByVal ToCode As String,
      ByVal FromDate As Date, ByVal ToDate As Date, ByVal FromPartyCode As String, ByVal ToPartyCode As String, ByVal FromItemCode As String, ByVal ToItemCode As String, ByRef reportDoc As ReportDocument, Optional ByVal nGroupedBy As Integer = 0, Optional ByVal PageBreak As Boolean = False) As Boolean

        Dim strReporTitle As String


        If FromCode = "" Then FromCode = StartParameter
        If ToCode = "" Then ToCode = EndParameter
        If FromPartyCode = "" Then FromPartyCode = StartParameter
        If ToPartyCode = "" Then ToPartyCode = EndParameter
        If FromItemCode = "" Then FromItemCode = StartParameter
        If ToItemCode = "" Then ToItemCode = EndParameter
        If ToDate = Nothing Then ToDate = Now.Date

        Try

            strReporTitle = "Profit List"
            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            Acc.PopulateDataSet(Ds, "SelectProfitListReports", "OPTION", "",
            "FromCode", FromCode, "ToCode", ToCode, "FromDate", FromDate, "ToDate", ToDate, "FromPartyCode", FromPartyCode, "ToPartyCode", ToPartyCode)

            If Ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No record found within the specified conditions..." & vbCrLf & vbCrLf & "Please specify valid parameters and " & vbCrLf & "Make sure that the records exists !", "Report Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If
            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\" & ProfitListReportFileName & ".xsd")

            Dim strReportPath As String = Application.StartupPath & "\Reports\" & ProfitListReportFileName & ".rpt"
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))
            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            SetParameter(paramFields, "PageBreak", PageBreak)
            SetParameter(paramFields, "GroupedBy", nGroupedBy)
            SetParameter(paramFields, "User", OperatorID)
            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function VehicleLedgerProcess(ByVal ReportType As ReportFiles, ByVal IsShowOpeinging As Boolean, ByVal IsSummaryReport As Boolean, ByVal FromDate As Date, ByVal ToDate As Date, ByVal FromCode As String, ByVal ToCode As String, ByVal FromOwnerCode As String, ByVal ToOwnerCode As String, ByRef reportDoc As ReportDocument, Optional ByVal Progress As Object = Nothing, Optional ByVal nGroupBy As Integer = 0, Optional ByVal nReportType As Integer = 0, Optional ByVal IsDetail As Boolean = True) As Boolean
        Dim strReporTitle As String


        If FromCode = "" Then FromCode = StartParameter
        If ToCode = "" Then ToCode = EndParameter
        If ToDate = Nothing Then ToDate = Now.Date

        Try

            strReporTitle = "Vehicle Ledger"
            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            Acc.PopulateDataSet(Ds, "[SelectVehicleLedgerReport]",
            "FromVehicleCode", FromCode, "ToVehicleCode", ToCode, "FromDate", FromDate, "ToDate", ToDate, "ShowOpening", IsShowOpeinging)

            If Ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No record found within the specified conditions..." & vbCrLf & vbCrLf & "Please specify valid parameters and " & vbCrLf & "Make sure that the records exists !", "Report Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If
            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\VehicleLedgerReport.xsd")
            Dim strReportPath As String = Application.StartupPath & "\Reports\VehicleLedger.rpt"

            If IsSummaryReport Then
                strReportPath = Application.StartupPath & "\Reports\VehicleLedgerSummary.rpt"

                strReporTitle = "Vehicle Ledger Summary"
            End If
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))
            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            '  SetParameter(paramFields, "GroupedBy", nGroupedBy)
            SetParameter(paramFields, "UserInfo", OperatorID)
            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function VehicleRevenueProcess(ByVal ReportType As ReportFiles, ByVal IsShowOpeinging As Boolean, ByVal IsSummaryReport As Boolean, ByVal FromDate As Date, ByVal ToDate As Date, ByVal FromCode As String, ByVal ToCode As String, ByVal FromOwnerCode As String, ByVal ToOwnerCode As String, ByRef reportDoc As ReportDocument, Optional ByVal Progress As Object = Nothing, Optional ByVal nGroupBy As Integer = 0, Optional ByVal nReportType As Integer = 0, Optional ByVal IsDetail As Boolean = True) As Boolean
        Dim strReporTitle As String


        If FromCode = "" Then FromCode = StartParameter
        If ToCode = "" Then ToCode = EndParameter
        If ToDate = Nothing Then ToDate = Now.Date

        Try
            Dim strReportPath As String = String.Empty
            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing

            if(IsSummaryReport) 
                Acc.PopulateDataSet(Ds, "[SelectVehicleRevenueSummaryReport]",
                    "FromVehicleCode", FromCode, "ToVehicleCode", ToCode, "FromDate", FromDate, "ToDate", ToDate, "ShowOpening", IsShowOpeinging)

                strReporTitle = "Vehicle Revenue Summary"
                strReportPath = Application.StartupPath & "\Reports\VehicleRevenueSummary.rpt"
            Else 
                Acc.PopulateDataSet(Ds, "[SelectVehicleRevenueReport]",
                    "FromVehicleCode", FromCode, "ToVehicleCode", ToCode, "FromDate", FromDate, "ToDate", ToDate, "ShowOpening", IsShowOpeinging)

                strReporTitle = "Vehicle Revenue"
                strReportPath = Application.StartupPath & "\Reports\VehicleRevenue.rpt"
            End If

            If Ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No record found within the specified conditions..." & vbCrLf & vbCrLf & "Please specify valid parameters and " & vbCrLf & "Make sure that the records exists !", "Report Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If
            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\VehicleRevenueReport.xsd")
            
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))
            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            '  SetParameter(paramFields, "GroupedBy", nGroupedBy)
            SetParameter(paramFields, "UserInfo", OperatorID)
            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function VehicleRevenuePivotProcess(ByVal ReportType As ReportFiles, ByVal IsShowOpeinging As Boolean, ByVal IsSummaryReport As Boolean, ByVal FromDate As Date, ByVal ToDate As Date, ByVal FromCode As String, ByVal ToCode As String, ByVal FromOwnerCode As String, ByVal ToOwnerCode As String, ByRef reportDoc As ReportDocument, Optional ByVal Progress As Object = Nothing, Optional ByVal nGroupBy As Integer = 0, Optional ByVal nReportType As Integer = 0, Optional ByVal IsDetail As Boolean = True) As Boolean
        Dim strReporTitle As String


        If FromCode = "" Then FromCode = StartParameter
        If ToCode = "" Then ToCode = EndParameter
        If ToDate = Nothing Then ToDate = Now.Date

        Try

            strReporTitle = "Vehicle Revenue Pivot"
            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            Acc.PopulateDataSet(Ds, "[SelectVehicleRevenuePivotReport]",
            "FromVehicleCode", FromCode, "ToVehicleCode", ToCode, "FromDate", FromDate, "ToDate", ToDate, "ShowOpening", IsShowOpeinging)

            If Ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No record found within the specified conditions..." & vbCrLf & vbCrLf & "Please specify valid parameters and " & vbCrLf & "Make sure that the records exists !", "Report Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If
            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\VehicleRevenueReport.xsd")
            Dim strReportPath As String = Application.StartupPath & "\Reports\VehicleRevenuePivot.rpt"

            If IsSummaryReport Then
                strReportPath = Application.StartupPath & "\Reports\VehicleRevenuePivotSummary.rpt"

                strReporTitle = "Vehicle Ledger Summary"
            End If
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))
            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            '  SetParameter(paramFields, "GroupedBy", nGroupedBy)
            SetParameter(paramFields, "UserInfo", OperatorID)
            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function VehicleListProcess(ByVal FromCode As String, ByVal ToCode As String,
  ByVal FromDate As Date, ByVal ToDate As Date, ByVal nGroupedBy As Integer, ByRef reportDoc As ReportDocument, ByVal PageBreak As Boolean) As Boolean

        Dim strReporTitle As String


        If FromCode = "" Then FromCode = StartParameter
        If ToCode = "" Then ToCode = EndParameter
        If ToDate = Nothing Then ToDate = Now.Date

        Try

            strReporTitle = "Vehicle List"
            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            Acc.PopulateDataSet(Ds, "SelectListReports", "OPTION", "VehicleList",
            "FromCode", FromCode, "ToCode", ToCode, "FromDate", FromDate, "ToDate", ToDate)

            If Ds.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("No record found within the specified conditions..." & vbCrLf & vbCrLf & "Please specify valid parameters and " & vbCrLf & "Make sure that the records exists !", "Report Process", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
                Exit Function
            End If
            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\VehicleList.xsd")

            Dim strReportPath As String = Application.StartupPath & "\Reports\VehicleList.rpt"
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If

            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))
            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            SetParameter(paramFields, "GroupedBy", nGroupedBy)
            SetParameter(paramFields, "UserInfo", OperatorID)
            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Sub SetParameter(ByVal paramDef As ParameterFieldDefinitions, ByVal paramName As String, ByVal paramValue As Object)
        Try
            Dim crParameterFieldDefinition As ParameterFieldDefinition = paramDef.Item(paramName)
            Dim crParameterValues As ParameterValues = crParameterFieldDefinition.CurrentValues
            Dim crParameterDiscreteValue As New ParameterDiscreteValue

            crParameterDiscreteValue.Value = paramValue
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
        Catch ex As CrystalDecisions.CrystalReports.Engine.ParameterFieldException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function CashFlowStatementsProcess(ByVal ReportType As ReportFiles, ByVal FromDate As Date, ByVal ToDate As Date, ByVal FromBranchCode As String, ByVal ToBranchCode As String, ByVal FromDivisionCode As String, ByVal ToDivisionCode As String, ByVal GLCode As String, ByVal IsSummary As Boolean, ByVal nParametersRange As String, ByRef reportDoc As ReportDocument, Optional ByVal Progress As Object = Nothing, Optional ByVal nReportType As Integer = 0, Optional ByVal ChkGroupLevel As Integer = 0, Optional ByVal nNarration As String = "", Optional ByVal nPageBreak As Boolean = False, Optional ByVal ShowOpening As Boolean = False) As Boolean

        If Trim(FromBranchCode) = "" Then FromBranchCode = StartParameter
        If Trim(ToBranchCode) = "" Then ToBranchCode = EndParameter
        If Trim(FromDivisionCode) = "" Then FromDivisionCode = StartParameter
        If Trim(ToDivisionCode) = "" Then ToDivisionCode = EndParameter
        'If Trim(FromGLCode) = "" Then FromGLCode = StartParameter
        'If Trim(GLCode) = "" Then ToGLCode = EndParameter

        Try
            If Trim(GLCode) = String.Empty Then
                MsgBox("No record found within the specified conditions..." & vbCrLf & vbCrLf & "Please specify valid parameters and " & vbCrLf & "Make sure that the records exists !", vbExclamation, " Report Result - No record found...")
                Exit Function
            End If


            Dim nRstGetOpBal As SqlDataReader = Nothing


            Dim strReporTitle As String

            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            createILedgDs(Ds)
            If ShowOpening = True Then
                Call GetOpeningBalanceForCashFlow(Trim(FromBranchCode), Trim(ToBranchCode), Trim(FromDivisionCode), Trim(ToDivisionCode), GLCode, Now.Date, DateAdd("D", -1, FromDate), "", nRstGetOpBal, False, False, False)

                ''
                ''Getting OpeningBalance
                ''

                While nRstGetOpBal.Read
                    Dim Row As DataRow
                    Row = Ds.Tables(0).NewRow

                    Row.Item("BranchCode") = Trim(nRstGetOpBal!BranchCode)
                    Row.Item("Branch") = Trim(nRstGetOpBal!BranchRptTitle)
                    Row.Item("DivisionCode") = Trim(nRstGetOpBal!DivisionCode)
                    Row.Item("Division") = Trim(nRstGetOpBal!DivisionRptTitle)
                    Row.Item("GLCode") = Trim(nRstGetOpBal!GLCode)
                    Row.Item("GLDescription") = Trim(nRstGetOpBal!GLRptTitle)
                    Row.Item("TransactionDate") = DateAdd("D", -1, FromDate)
                    Row.Item("DocumentNature") = "Opening"
                    Row.Item("DocumentNo") = ""
                    Row.Item("Reference") = ""
                    Row.Item("Narration") = ""
                    Row.Item("Debit") = IIf(nRstGetOpBal!OpeningBalance > 0, nRstGetOpBal!OpeningBalance, 0) 'IIf((nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance) >= 0, (nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance), 0)
                    Row.Item("Credit") = IIf(nRstGetOpBal!OpeningBalance < 0, Math.Abs(nRstGetOpBal!OpeningBalance), 0) 'IIf((nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance) < 0, (nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance), 0)
                    Row.Item("ControlCode") = Trim(nRstGetOpBal!ControlCode)
                    Row.Item("Control") = Trim(nRstGetOpBal!ControlRptTitle)
                    Row.Item("GeneralCode") = Trim(nRstGetOpBal!GeneralCode)
                    Row.Item("General") = Trim(nRstGetOpBal!GeneralRptTitle)
                    Row.Item("SubsidiaryCode") = Trim(nRstGetOpBal!SubsidiaryCode)
                    Row.Item("Subsidiary") = Trim(nRstGetOpBal!SubsidiaryRptTitle)
                    Row.Item("Subsubcode") = Trim(nRstGetOpBal!Subsubcode)
                    Row.Item("SubSub") = Trim(nRstGetOpBal!SubSubRptTitle)
                    Row.Item("OldRef") = "" 'Trim(nRstGetOpBal!OldRef & "")
                    Row.Item("RecordNo") = 0 'Val(nRstGetOpBal!RecordNo & "")
                    Row.Item("DetailRecordNo") = 0
                    Row.Item("DocumentStatus") = ""

                    Ds.Tables(0).Rows.Add(Row)

                End While
                Ds.AcceptChanges()
            End If

            Dim DataReader As SqlDataReader



            Call Acc.GetRecord("SelectCashFlowStatementReports", "FromDate", FromDate, "ToDate", ToDate, "FromBranchCode", Trim(FromBranchCode), "ToBranchCode", Trim(ToBranchCode), "FromDivisionCode", Trim(FromDivisionCode), "ToDivisionCode", Trim(ToDivisionCode), "GLCode", GLCode, "Posted", False And 1, "PostedED", False And 1, "nType", 1)
            DataReader = Acc.GetRecord("SelectCashFlowStatementReports", "FromDate", FromDate, "ToDate", ToDate, "FromBranchCode", Trim(FromBranchCode), "ToBranchCode", Trim(ToBranchCode), "FromDivisionCode", Trim(FromDivisionCode), "ToDivisionCode", Trim(ToDivisionCode), "GLCode", Trim(GLCode), "Posted", False And 1, "PostedED", False And 1, "nType", 4)


            'If Not (Progress Is Nothing) Then Progress.Limit = DataReader.RecordCount + 10






            If DataReader.HasRows Then
                'If Not (Progress Is Nothing) Then Progress.Limit = DataReader.RecordCount + 10
                While DataReader.Read
                    Dim Row As DataRow
                    Row = Ds.Tables(0).NewRow
                    If My.Settings.CashAndBankGLCode <> Left(Trim(DataReader!GLCode), My.Settings.CashAndBankGLCode.Length) Then
                        Row.Item("BranchCode") = Trim(DataReader!BranchCode)
                        Row.Item("Branch") = Trim(DataReader!BranchRptTitle)
                        Row.Item("DivisionCode") = Trim(DataReader!DivisionCode)
                        Row.Item("Division") = Trim(DataReader!DivisionRptTitle)
                        Row.Item("GLCode") = Trim(DataReader!GLCode)
                        Row.Item("GLDescription") = Trim(DataReader!GLRptTitle)
                        Row.Item("TransactionDate") = Trim(DataReader!VoucherDate) 'DateAdd("D", -1, FromDate)
                        Row.Item("DocumentNature") = Trim(DataReader!NatureCode)
                        Row.Item("DocumentNo") = Trim(DataReader!VoucherNo)
                        Row.Item("Reference") = Trim(DataReader!Reference)
                        If nNarration = "Main" Then
                            Row.Item("Narration") = IIf(IsDBNull(Trim(DataReader!NarrationMain)), "", Trim(DataReader!NarrationMain))
                        Else
                            Row.Item("Narration") = IIf(IsDBNull(Trim(DataReader!Narration)), "", Trim(DataReader!Narration))
                        End If

                        Row.Item("Debit") = (DataReader!Debit)
                        Row.Item("Credit") = (DataReader!Credit)
                        Row.Item("ControlCode") = Trim(DataReader!ControlCode)
                        Row.Item("Control") = Trim(DataReader!ControlRptTitle)
                        Row.Item("GeneralCode") = Trim(DataReader!GeneralCode)
                        Row.Item("General") = Trim(DataReader!GeneralRptTitle)
                        Row.Item("SubsidiaryCode") = Trim(DataReader!SubsidiaryCode)
                        Row.Item("Subsidiary") = Trim(DataReader!SubsidiaryRptTitle)
                        Row.Item("Subsubcode") = Trim(DataReader!Subsubcode)
                        Row.Item("SubSub") = Trim(DataReader!SubSubRptTitle)
                        Row.Item("OldRef") = Trim(DataReader!OldRef & "")
                        Row.Item("RecordNo") = Val(DataReader!RecordNo & "")
                        Row.Item("DetailRecordNo") = Val(DataReader!DetailRecordNo & "")
                        Row.Item("DocumentStatus") = IIf(IsDBNull(DataReader!Posted), False, DataReader!Posted)
                        Row.Item("DocumentStatus") = IIf(Row.Item("DocumentStatus") = True, "P", IIf(IsDBNull(DataReader!Locked) = True, "U", IIf(IsDBNull(DataReader!Locked) = True, "U", "L")))
                        Ds.Tables(0).Rows.Add(Row)

                        Ds.AcceptChanges()
                    End If
                End While
            End If

            ''
            ''
            Dim strReportPath As String
            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\CashFlowStatement.xsd")

            If IsSummary = False Then
                strReporTitle = "Cash Flow Statement"
                strReportPath = Application.StartupPath & "\Reports\CashFlowStatement.rpt"
            Else
                strReporTitle = "Cash Flow Summary"
                strReportPath = Application.StartupPath & "\Reports\CashFlowStatementSummary.rpt"
            End If

            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If
            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))

            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "SystemName", "")
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            SetParameter(paramFields, "ReportType", nReportType)
            SetParameter(paramFields, "ParametersRange", "")
            SetParameter(paramFields, "PageBreak", nPageBreak)
            SetParameter(paramFields, "UserInfo", OperatorID)


            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function GeneralLedgerProcess(ByVal ReportType As ReportFiles, ByVal FromDate As Date, ByVal ToDate As Date, ByVal FromBranchCode As String, ByVal ToBranchCode As String, ByVal FromDivisionCode As String, ByVal ToDivisionCode As String, ByVal FromGLCode As String, ByVal ToGLCode As String, ByVal nDocumentNature As String, ByVal nParametersRange As String, _
    ByRef reportDoc As ReportDocument, Optional ByVal Progress As Object = Nothing, Optional ByVal nReportType As Integer = 0, Optional ByVal nReportType1 As Integer = 0, Optional ByVal nNarration As String = "", Optional ByVal nPageBreak As Boolean = False) As Boolean



        If Trim(FromBranchCode) = "" Then FromBranchCode = StartParameter
        If Trim(ToBranchCode) = "" Then ToBranchCode = EndParameter
        If Trim(FromDivisionCode) = "" Then FromDivisionCode = StartParameter
        If Trim(ToDivisionCode) = "" Then ToDivisionCode = EndParameter
        If Trim(FromGLCode) = "" Then FromGLCode = StartParameter
        If Trim(ToGLCode) = "" Then ToGLCode = EndParameter
        Dim nTypeValue As Integer = 0

        Dim nRstGetOpBal As SqlDataReader = Nothing
        Try

            Dim strReporTitle As String = "General Ledger"
            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            createILedgDs(Ds)
            GetOpeningBalance(Trim(FromBranchCode), Trim(ToBranchCode), Trim(FromDivisionCode), Trim(ToDivisionCode), Trim(FromGLCode), Trim(ToGLCode), Now.Date, DateAdd("D", -1, FromDate), "", nRstGetOpBal, False, False, False)

            ''
            ''Getting OpeningBalance
            ''

            While nRstGetOpBal.Read
                Dim Row As DataRow
                Row = Ds.Tables(0).NewRow

                Row.Item("BranchCode") = Trim(nRstGetOpBal!BranchCode)
                Row.Item("Branch") = Trim(nRstGetOpBal!BranchRptTitle)
                Row.Item("DivisionCode") = Trim(nRstGetOpBal!DivisionCode)
                Row.Item("Division") = Trim(nRstGetOpBal!DivisionRptTitle)
                Row.Item("GLCode") = Trim(nRstGetOpBal!GLCode)
                Row.Item("GLDescription") = Trim(nRstGetOpBal!GLRptTitle)
                Row.Item("TransactionDate") = DateAdd("D", -1, FromDate)
                Row.Item("DocumentNature") = "Opening"
                Row.Item("DocumentNo") = ""
                Row.Item("Reference") = ""
                Row.Item("Narration") = ""
                Row.Item("Debit") = IIf(nRstGetOpBal!OpeningBalance > 0, nRstGetOpBal!OpeningBalance, 0) 'IIf((nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance) >= 0, (nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance), 0)
                Row.Item("Credit") = IIf(nRstGetOpBal!OpeningBalance < 0, Math.Abs(nRstGetOpBal!OpeningBalance), 0) 'IIf((nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance) < 0, (nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance), 0)
                Row.Item("ControlCode") = Trim(nRstGetOpBal!ControlCode)
                Row.Item("Control") = Trim(nRstGetOpBal!ControlRptTitle)
                Row.Item("GeneralCode") = Trim(nRstGetOpBal!GeneralCode)
                Row.Item("General") = Trim(nRstGetOpBal!GeneralRptTitle)
                Row.Item("SubsidiaryCode") = Trim(nRstGetOpBal!SubsidiaryCode)
                Row.Item("Subsidiary") = Trim(nRstGetOpBal!SubsidiaryRptTitle)
                Row.Item("Subsubcode") = Trim(nRstGetOpBal!Subsubcode)
                Row.Item("SubSub") = Trim(nRstGetOpBal!SubSubRptTitle)
                Row.Item("OldRef") = "" 'Trim(nRstGetOpBal!OldRef & "")
                Row.Item("RecordNo") = 0 'Val(nRstGetOpBal!RecordNo & "")
                Row.Item("DetailRecordNo") = 0
                Row.Item("DocumentStatus") = ""

                Ds.Tables(0).Rows.Add(Row)

            End While
            Ds.AcceptChanges()


            Dim DataReader As SqlDataReader


            Call Acc.GetRecord("SelectGeneralLedgerReports", "FromDate", FromDate, "ToDate", ToDate, "FromBranchCode", Trim(FromBranchCode), "ToBranchCode", Trim(ToBranchCode), "FromDivisionCode", Trim(FromDivisionCode), "ToDivisionCode", Trim(ToDivisionCode), "FromGLCode", Trim(FromGLCode), "ToGLCode", Trim(ToGLCode), "VoucherNatureCode", nDocumentNature, "Posted", False And 1, "PostedED", False And 1, "nType", 1)
            DataReader = Acc.GetRecord("SelectGeneralLedgerReports", "FromDate", FromDate, "ToDate", ToDate, "FromBranchCode", Trim(FromBranchCode), "ToBranchCode", Trim(ToBranchCode), "FromDivisionCode", Trim(FromDivisionCode), "ToDivisionCode", Trim(ToDivisionCode), "FromGLCode", Trim(FromGLCode), "ToGLCode", Trim(ToGLCode), "VoucherNatureCode", nDocumentNature, "Posted", False And 1, "PostedED", False And 1, "nType", 4)

            If DataReader.HasRows Then
                'If Not (Progress Is Nothing) Then Progress.Limit = DataReader.RecordCount + 10
                While DataReader.Read
                    Dim Row As DataRow
                    Row = Ds.Tables(0).NewRow

                    Row.Item("BranchCode") = Trim(DataReader!BranchCode)
                    Row.Item("Branch") = Trim(DataReader!BranchRptTitle)
                    Row.Item("DivisionCode") = Trim(DataReader!DivisionCode)
                    Row.Item("Division") = Trim(DataReader!DivisionRptTitle)
                    Row.Item("GLCode") = Trim(DataReader!GLCode)
                    Row.Item("GLDescription") = Trim(DataReader!GLRptTitle)
                    Row.Item("TransactionDate") = Trim(DataReader!VoucherDate) 'DateAdd("D", -1, FromDate)
                    Row.Item("DocumentNature") = Trim(DataReader!NatureCode)
                    Row.Item("DocumentNo") = Trim(DataReader!VoucherNo)
                    Row.Item("Reference") = Trim(DataReader!Reference)
                    If nNarration = "Main" Then
                        Row.Item("Narration") = IIf(IsDBNull(Trim(DataReader!NarrationMain)), "", Trim(DataReader!NarrationMain))
                    Else
                        Row.Item("Narration") = IIf(IsDBNull(Trim(DataReader!Narration)), "", Trim(DataReader!Narration))
                    End If

                    Row.Item("Debit") = (DataReader!Debit)
                    Row.Item("Credit") = (DataReader!Credit)
                    Row.Item("ControlCode") = Trim(DataReader!ControlCode)
                    Row.Item("Control") = Trim(DataReader!ControlRptTitle)
                    Row.Item("GeneralCode") = Trim(DataReader!GeneralCode)
                    Row.Item("General") = Trim(DataReader!GeneralRptTitle)
                    Row.Item("SubsidiaryCode") = Trim(DataReader!SubsidiaryCode)
                    Row.Item("Subsidiary") = Trim(DataReader!SubsidiaryRptTitle)
                    Row.Item("Subsubcode") = Trim(DataReader!Subsubcode)
                    Row.Item("SubSub") = Trim(DataReader!SubSubRptTitle)
                    Row.Item("OldRef") = Trim(DataReader!OldRef & "")
                    Row.Item("RecordNo") = Val(DataReader!RecordNo & "")
                    Row.Item("DetailRecordNo") = Val(DataReader!DetailRecordNo & "")
                    Row.Item("DocumentStatus") = IIf(IsDBNull(DataReader!Posted), False, DataReader!Posted)
                    Row.Item("DocumentStatus") = IIf(Row.Item("DocumentStatus") = True, "P", IIf(IsDBNull(DataReader!Locked) = True, "U", IIf(IsDBNull(DataReader!Locked) = True, "U", "L")))
                    Ds.Tables(0).Rows.Add(Row)
                End While
            End If
            Ds.AcceptChanges()
            ''
            ''

            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\" & GeneralLedgerReportFileName & ".xsd")
            Dim strReportPath As String = Application.StartupPath & "\Reports\" & GeneralLedgerReportFileName & ".rpt"
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If
            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))

            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "SystemName", "")
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            SetParameter(paramFields, "ReportType", nReportType)
            SetParameter(paramFields, "ReportType1", nReportType1)
            SetParameter(paramFields, "ParametersRange", "")
            ' SetParameter(paramFields, "HierarchicalView", 1)
            SetParameter(paramFields, "PageBreak", nPageBreak)
            SetParameter(paramFields, "User", OperatorID)


            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function FinancialStatementsProcess(ByVal ReportType As ReportFiles, ByVal FromDate As Date, ByVal ToDate As Date, ByVal FromBranchCode As String, ByVal ToBranchCode As String, ByVal FromDivisionCode As String, ByVal ToDivisionCode As String, ByVal FromGLCode As String, ByVal ToGLCode As String, ByVal FromFSFCode As String, ByVal ToFSFCode As String, ByVal nDocumentNature As String, ByVal nParametersRange As String, Optional ByVal nReportType As Integer = 0, Optional ByVal nReportName As String = "", Optional ByVal nReportType1 As Integer = 0, _
        Optional ByRef reportDoc As ReportDocument = Nothing, Optional ByVal nReportFor As String = "", Optional ByVal Progress As Object = Nothing, Optional ByVal nNarration As String = "", Optional ByVal nPageBreak As Boolean = False) As Boolean

        If Trim(FromBranchCode) = "" Then FromBranchCode = StartParameter
        If Trim(ToBranchCode) = "" Then ToBranchCode = EndParameter
        If Trim(FromDivisionCode) = "" Then FromDivisionCode = StartParameter
        If Trim(ToDivisionCode) = "" Then ToDivisionCode = EndParameter
        If Trim(FromGLCode) = "" Then FromGLCode = StartParameter
        If Trim(ToGLCode) = "" Then ToGLCode = EndParameter

        If Trim(FromFSFCode) = "" Then FromFSFCode = StartParameter
        If Trim(ToFSFCode) = "" Then ToFSFCode = EndParameter


        'If InStr(1, UCase(nReportName), "SUMMARY") > 0 Then
        '    ReportSD = "SUM"
        'Else
        '    ReportSD = "DET"
        'End If

        Dim FSFExpenseAccount As Integer
        Dim FSFIncomeAccount As Integer
        Dim FSFLiabilityAccount As Integer
        Dim FSFAssetsAccount As Integer

        FSFExpenseAccount = My.Settings.FSFExpenseAccount
        FSFAssetsAccount = My.Settings.FSFAssetsAccount
        FSFIncomeAccount = My.Settings.FSFIncomeAccount
        FSFLiabilityAccount = My.Settings.FSFLiabilityAccount




        Dim nTypeValue As Integer = 0

        Dim nRstGetOpBal As SqlDataReader = Nothing
        Dim nRstGetTrialBalance As SqlDataReader = Nothing
        Try

            Dim strReporTitle As String = "General Ledger"
            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            createFSFDs(Ds)
            Call GetOpeningBalanceForFSF(Trim(FromBranchCode), Trim(ToBranchCode), Trim(FromDivisionCode), Trim(ToDivisionCode), Trim(FromGLCode), Trim(ToGLCode), Trim(FromFSFCode), Trim(ToFSFCode), Now.Date, FromDate.AddDays(-1), "", nRstGetOpBal, True, True, True)
            'Call GetAccumulateTransBalancesForFSF(Trim(FromBranchCode), Trim(ToBranchCode), Trim(FromDivisionCode), Trim(ToDivisionCode), Trim(FromGLCode), Trim(ToGLCode), Trim(FromFSFCode), Trim(ToFSFCode), FromDate, ToDate, nDocumentNature, nRstGetTrialBalance, 112, "DET",  True, True)

            'UNCOMMENT THE ABOVE LINE ORIGNAL CODE FOR POSTED RECORDS BELOW IS FOR UNPOSTED
            Call GetAccumulateTransBalancesForFSF(Trim(FromBranchCode), Trim(ToBranchCode), Trim(FromDivisionCode), Trim(ToDivisionCode), Trim(FromGLCode), Trim(ToGLCode), Trim(FromFSFCode), Trim(ToFSFCode), FromDate, ToDate, nDocumentNature, nRstGetTrialBalance, 112, "DET", Not My.Settings.ShowPostedData, True)
            ''
            ''Getting OpeningBalance
            ''

            While nRstGetTrialBalance.Read
                Dim Row As DataRow
                Row = Ds.Tables(0).NewRow

                If ReportType = ReportFiles.BalanceSheet Then
                    strReporTitle = "Balance Sheet"
                    Row.Item("RptType") = "BalanceSheet"
                Else
                    Row.Item("RptType") = "IncomeStatement"
                    strReporTitle = "Income Statements"
                End If

                Row.Item("BranchCode") = IIf(IsDBNull(Trim(nRstGetTrialBalance!BranchCode)), "", Trim(nRstGetTrialBalance!BranchCode))
                Row.Item("Branch") = IIf(IsDBNull(Trim(nRstGetTrialBalance!BranchRptTitle)), "", Trim(nRstGetTrialBalance!BranchRptTitle))
                Row.Item("DivisionCode") = IIf(IsDBNull(Trim(nRstGetTrialBalance!DivisionCode)), "", Trim(nRstGetTrialBalance!DivisionCode))
                Row.Item("Division") = IIf(IsDBNull(Trim(nRstGetTrialBalance!DivisionRptTitle)), "", Trim(nRstGetTrialBalance!DivisionRptTitle))
                Row.Item("OpeningDebit") = IIf(nRstGetTrialBalance!OpBalance >= 0, nRstGetTrialBalance!OpBalance, 0)
                Row.Item("OpeningCredit") = IIf(nRstGetTrialBalance!OpBalance < 0, Math.Abs(nRstGetTrialBalance!OpBalance), 0)

                '                    Row.Item("OpeningDebit = 0
                '                    Row.Item("OpeningCredit = 0
                Row.Item("CurrentDebit") = nRstGetTrialBalance!DBBalance 'nRstGetTrialBalance!DebitBalance
                Row.Item("CurrentCredit") = nRstGetTrialBalance!CrBalance


                '' ENABLE THIS FOR NEW REPORT
                Row.Item("ControlCode") = IIf(IsDBNull(Trim(nRstGetTrialBalance!ControlCode)), "", Trim(nRstGetTrialBalance!ControlCode))
                Row.Item("GLCode") = IIf(IsDBNull(Trim(nRstGetTrialBalance!GLCode)), "", Trim(nRstGetTrialBalance!GLCode))
                Row.Item("GLDescription") = IIf(IsDBNull(Trim(nRstGetTrialBalance!GLRptTitle)), "", Trim(nRstGetTrialBalance!GLRptTitle))
                Row.Item("Control") = IIf(IsDBNull(Trim(nRstGetTrialBalance!ControlRptTitle)), "", Trim(nRstGetTrialBalance!ControlRptTitle))
                Row.Item("GeneralCode") = IIf(IsDBNull(Trim(nRstGetTrialBalance!GeneralCode)), "", Trim(nRstGetTrialBalance!GeneralCode))
                Row.Item("General") = IIf(IsDBNull(Trim(nRstGetTrialBalance!GeneralRptTitle)), "", Trim(nRstGetTrialBalance!GeneralRptTitle))
                Row.Item("SubsidiaryCode") = IIf(IsDBNull(Trim(nRstGetTrialBalance!SubsidiaryCode)), "", Trim(nRstGetTrialBalance!SubsidiaryCode))
                Row.Item("Subsidiary") = IIf(IsDBNull(Trim(nRstGetTrialBalance!SubsidiaryRptTitle)), "", Trim(nRstGetTrialBalance!SubsidiaryRptTitle))
                Row.Item("Subsubcode") = IIf(IsDBNull(Trim(nRstGetTrialBalance!Subsubcode)), "", Trim(nRstGetTrialBalance!Subsubcode))
                Row.Item("SubSub") = IIf(IsDBNull(Trim(nRstGetTrialBalance!SubSubRptTitle)), "", Trim(nRstGetTrialBalance!SubSubRptTitle))

                '
                Row.Item("CurrentDebit") = nRstGetTrialBalance!DBBalance 'nRstGetTrialBalance!DebitBalance
                Row.Item("CurrentCredit") = nRstGetTrialBalance!CrBalance
                Row.Item("FSFGLCode") = IIf(IsDBNull(Trim(nRstGetTrialBalance!FSFGLCode)), "", Trim(nRstGetTrialBalance!FSFGLCode))
                Row.Item("FSFGLDescription") = IIf(IsDBNull(Trim(nRstGetTrialBalance!FSFGLRptTitle)), "", Trim(nRstGetTrialBalance!FSFGLRptTitle))
                Row.Item("FSFControlCode") = IIf(IsDBNull(Trim(nRstGetTrialBalance!FSFControlCode)), "", Trim(nRstGetTrialBalance!FSFControlCode))

                Row.Item("FSFControl") = IIf(IsDBNull(Trim(nRstGetTrialBalance!FSFControlRptTitle)), "", Trim(nRstGetTrialBalance!FSFControlRptTitle))
                Row.Item("FSFGeneralCode") = IIf(IsDBNull(Trim(nRstGetTrialBalance!FSFGeneralCode)), "", Trim(nRstGetTrialBalance!FSFGeneralCode))
                Row.Item("FSFGeneral") = IIf(IsDBNull(Trim(nRstGetTrialBalance!FSFGeneralRptTitle)), "", Trim(nRstGetTrialBalance!FSFGeneralRptTitle))
                Row.Item("FSFSubsidiaryCode") = IIf(IsDBNull(Trim(nRstGetTrialBalance!FSFSubsidiaryCode)), "", Trim(nRstGetTrialBalance!FSFSubsidiaryCode))
                Row.Item("FSFSubsidiary") = IIf(IsDBNull(Trim(nRstGetTrialBalance!FSFSubsidiaryRptTitle)), "", Trim(nRstGetTrialBalance!FSFSubsidiaryRptTitle))
                Row.Item("FSFSubsubcode") = IIf(IsDBNull(Trim(nRstGetTrialBalance!FSFSubsubcode)), "", Trim(nRstGetTrialBalance!FSFSubsubcode))
                Row.Item("FSFSubSub") = IIf(IsDBNull(Trim(nRstGetTrialBalance!FSFSubSubRptTitle)), "", Trim(nRstGetTrialBalance!FSFSubSubRptTitle))

                Row.Item("FSFExpenseAccount") = FSFExpenseAccount
                Row.Item("FSFIncomeAccount") = FSFIncomeAccount
                Row.Item("FSFLiabilityAccount") = FSFLiabilityAccount
                Row.Item("FSFAssetsAccount") = FSFAssetsAccount

                Ds.Tables(0).Rows.Add(Row)

            End While
            Ds.AcceptChanges()



            ''
            ''

            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\FinancialStatements.xsd")
            Dim strReportPath As String = Application.StartupPath & "\Reports\FinancialStatements.rpt"
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If
            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))

            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "SystemName", "")
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            SetParameter(paramFields, "ReportType", nReportType)
            SetParameter(paramFields, "ReportType1", nReportType1)
            SetParameter(paramFields, "ParametersRange", "")
            ' SetParameter(paramFields, "HierarchicalView", 1)
            SetParameter(paramFields, "PageBreak", nPageBreak)
            SetParameter(paramFields, "UserInfo", OperatorID)


            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function TrialBalanceProcess(ByVal ReportType As ReportFiles, ByVal FromDate As Date, ByVal ToDate As Date, ByVal FromBranchCode As String, ByVal ToBranchCode As String, ByVal FromDivisionCode As String, ByVal ToDivisionCode As String, ByVal FromGLCode As String, ByVal ToGLCode As String, ByVal nDocumentNature As String, ByVal nParametersRange As String, ByRef reportDoc As ReportDocument, Optional ByVal Progress As Object = Nothing, Optional ByVal nReportType As Integer = 0, Optional ByVal nPageBreak As Boolean = False, Optional ByVal nReportName As String = "", Optional ByVal nReportType1 As Integer = 0) As Boolean


        Dim strReporTitle As String = "Trial Balance"
        Dim ReportSD As String

        If Trim(FromBranchCode) = "" Then FromBranchCode = StartParameter
        If Trim(ToBranchCode) = "" Then ToBranchCode = EndParameter
        If Trim(FromDivisionCode) = "" Then FromDivisionCode = StartParameter
        If Trim(ToDivisionCode) = "" Then ToDivisionCode = EndParameter
        If Trim(FromGLCode) = "" Then FromGLCode = StartParameter
        If Trim(ToGLCode) = "" Then ToGLCode = EndParameter
        Dim nTypeValue As Integer = 0

        If InStr(1, UCase(nReportName), "SUMMARY") > 0 Then
            ReportSD = "SUM"
            strReporTitle = "Trial Balance Summary"
        Else
            ReportSD = "DET"
        End If



        Dim nRstGetOpBal As SqlDataReader = Nothing
        Dim nRstGetTrialBalance As SqlDataReader = Nothing
        Try


            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            createTrialBalanceDs(Ds)

            Call GetOpeningBalance(Trim(FromBranchCode), Trim(ToBranchCode), Trim(FromDivisionCode), Trim(ToDivisionCode), Trim(FromGLCode), Trim(ToGLCode), Now.Date, DateAdd("D", -1, FromDate), "", nRstGetOpBal, True, False, False)
            Call GetAccumulateTransBalances(Trim(FromBranchCode), Trim(ToBranchCode), Trim(FromDivisionCode), Trim(ToDivisionCode), Trim(FromGLCode), Trim(ToGLCode), FromDate, ToDate, nDocumentNature, nRstGetTrialBalance, 100 + nReportType, ReportSD, My.Settings.ShowPostedData, False)
            ''
            ''Getting OpeningBalance
            ''

            While nRstGetTrialBalance.Read
                Dim Row As DataRow
                Row = Ds.Tables(0).NewRow

                Row.Item("BranchCode") = Trim(nRstGetTrialBalance!BranchCode)
                Row.Item("Branch") = Trim(nRstGetTrialBalance!BranchRptTitle)
                Row.Item("DivisionCode") = Trim(nRstGetTrialBalance!DivisionCode)
                Row.Item("Division") = Trim(nRstGetTrialBalance!DivisionRptTitle)
                Row.Item("GLCode") = Trim(nRstGetTrialBalance!GLCode)
                Row.Item("GLDescription") = Trim(nRstGetTrialBalance!GLRptTitle)
                Row.Item("OpeningDebit") = IIf(nRstGetTrialBalance!OpBalance >= 0, nRstGetTrialBalance!OpBalance, 0)
                Row.Item("OpeningCredit") = IIf(nRstGetTrialBalance!OpBalance < 0, Math.Abs(nRstGetTrialBalance!OpBalance), 0)
                Row.Item("CurrentDebit") = nRstGetTrialBalance!DBBalance 'nRstGetTrialBalance!DebitBalance
                Row.Item("CurrentCredit") = nRstGetTrialBalance!CrBalance
                Row.Item("ControlCode") = Trim(nRstGetTrialBalance!ControlCode)
                Row.Item("Control") = Trim(nRstGetTrialBalance!ControlRptTitle)
                Row.Item("GeneralCode") = Trim(nRstGetTrialBalance!GeneralCode)
                Row.Item("General") = Trim(nRstGetTrialBalance!GeneralRptTitle)
                Row.Item("SubsidiaryCode") = Trim(nRstGetTrialBalance!SubsidiaryCode)
                Row.Item("Subsidiary") = Trim(nRstGetTrialBalance!SubsidiaryRptTitle)
                Row.Item("Subsubcode") = Trim(nRstGetTrialBalance!Subsubcode)
                Row.Item("SubSub") = Trim(nRstGetTrialBalance!SubSubRptTitle)

                Ds.Tables(0).Rows.Add(Row)

            End While
            Ds.AcceptChanges()
            ''
            ''

            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\" & nReportName & ".xsd")
            Dim strReportPath As String = Application.StartupPath & "\Reports\" & nReportName & ".rpt"
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If
            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))



            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "SystemName", "")
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            SetParameter(paramFields, "ReportType", nReportType)
            SetParameter(paramFields, "ReportType1", nReportType1)
            SetParameter(paramFields, "ParametersRange", "")
            ' SetParameter(paramFields, "HierarchicalView", 1)
            SetParameter(paramFields, "PageBreak", nPageBreak)
            SetParameter(paramFields, "UserInfo", OperatorID)




            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Public Function VehicleBillsProcess(ByVal ReportType As ReportFiles, ByVal FromDate As Date, ByVal ToDate As Date, ByVal FromVehicleCode As String, ByVal ToVehicleCode As String, ByVal FromOwnerCode As String, ByVal ToOwnerCode As String, ByRef reportDoc As ReportDocument, Optional ByVal Progress As Object = Nothing, Optional ByVal nReportType As Integer = 0, Optional ByVal nGroupBy As Integer = 0, Optional ByVal nNarration As String = "", Optional ByVal nPageBreak As Boolean = False, Optional ByVal ShowAdvancesInFrontOfTrip As Boolean = True) As Boolean



        If Trim(FromVehicleCode) = String.Empty Then FromVehicleCode = StartParameter
        If Trim(ToVehicleCode) = String.Empty Then ToVehicleCode = EndParameter
        If Trim(FromOwnerCode) = String.Empty Then FromOwnerCode = StartParameter
        If Trim(ToOwnerCode) = String.Empty Then ToOwnerCode = EndParameter

        Dim nTypeValue As Integer = 0

        Dim nRstGetOpBal As SqlDataReader = Nothing
        Try

            Dim strReporTitle As String = "Vehicle Monthly Bill"
            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            createVehicleBillsDs(Ds)
            GetOpeningBalanceForVehicleBills(Trim(FromVehicleCode), Trim(ToVehicleCode), Trim(FromOwnerCode), Trim(ToOwnerCode), "", "", Now.Date, DateAdd("D", -1, FromDate), "", nRstGetOpBal, False, False, False)

            ''
            ''Getting OpeningBalance
            ''

            While nRstGetOpBal.Read
                Dim Row As DataRow
                Row = Ds.Tables(0).NewRow

                Row.Item("VehicleCode") = Trim(nRstGetOpBal!VehicleCode)
                Row.Item("CustomerCode") = IIf(IsDBNull(nRstGetOpBal!CustomerCode), "", (nRstGetOpBal!CustomerCode))
                Row.Item("CustomerName") = IIf(IsDBNull(nRstGetOpBal!CustomerName), "", (nRstGetOpBal!CustomerName))
                Row.Item("CustomerUrduName") = IIf(IsDBNull(nRstGetOpBal!UrduCustomerName), "", (nRstGetOpBal!UrduCustomerName))
                Row.Item("OwnerName") = Trim(nRstGetOpBal!OwnerName)
                Row.Item("OwnerNameUrdu") = Trim(nRstGetOpBal!UrduOwnerName)
                Row.Item("GLCode") = Trim(nRstGetOpBal!GLCode)
                Row.Item("GLDescription") = Trim(nRstGetOpBal!GLDescription)
                Row.Item("TransactionDate") = DateAdd("D", -1, FromDate)
                Row.Item("Mode") = "Opening"
                Row.Item("Debit") = IIf(nRstGetOpBal!OpeningBalance > 0, nRstGetOpBal!OpeningBalance, 0) 'IIf((nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance) >= 0, (nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance), 0)
                Row.Item("Credit") = IIf(nRstGetOpBal!OpeningBalance < 0, Math.Abs(nRstGetOpBal!OpeningBalance), 0) 'IIf((nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance) < 0, (nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance), 0)
                Row.Item("RecordNo") = 0

                Ds.Tables(0).Rows.Add(Row)

            End While
            Ds.AcceptChanges()


            Dim DataReader As SqlDataReader


            Call Acc.GetRecord("SelectVehicleBillsReports", "FromDate", FromDate, "ToDate", ToDate, "FromVehicleCode", Trim(FromVehicleCode), "ToVehicleCode", Trim(ToVehicleCode), "FromOwnerCode", Trim(FromOwnerCode), "ToOwnerCode", Trim(ToOwnerCode), "FromGLCode", "", "ToGLCode", "", "VoucherNatureCode", "", "Posted", False And 1, "PostedED", False And 1, "nType", 1)
            DataReader = Acc.GetRecord("SelectVehicleBillsReports", "FromDate", FromDate, "ToDate", ToDate, "FromVehicleCode", Trim(FromVehicleCode), "ToVehicleCode", Trim(ToVehicleCode), "FromOwnerCode", Trim(FromOwnerCode), "ToOwnerCode", Trim(ToOwnerCode), "FromGLCode", "", "ToGLCode", "", "VoucherNatureCode", "", "Posted", False And 1, "PostedED", False And 1, "nType", 4)

            If DataReader.HasRows Then
                'If Not (Progress Is Nothing) Then Progress.Limit = DataReader.RecordCount + 10
                While DataReader.Read
                    Dim Row As DataRow
                    Row = Ds.Tables(0).NewRow
                    Row.Item("Mode") = Trim(DataReader!Mode)
                    Row.Item("TransactionNo") = Trim(DataReader!TransactionNo)
                    Row.Item("TransactionDate") = Trim(DataReader!TransactionDate)
                    Row.Item("TokenNo") = Trim(DataReader!CustomerReference)
                    Row.Item("VehicleCode") = Trim(DataReader!VehicleCode)
                    Row.Item("StationPointUrdu") = Trim(DataReader!StationPointUrdu)
                    Row.Item("DestinationPointUrdu") = Trim(DataReader!DestinationPointUrdu)
                    Row.Item("ProductUrdu") = Trim(DataReader!ProductUrdu) 'DateAdd("D", -1, FromDate)
                    Row.Item("Quantity") = DataReader!Quantity
                    Row.Item("Rate") = DataReader!Rate
                    Row.Item("Amount") = DataReader!Quantity * DataReader!Rate
                    Row.Item("Commission") = DataReader!Commission
                    Row.Item("ShortageQuantity") = DataReader!ShortageQuantity
                    Row.Item("Shortage") = DataReader!Shortage
                    Row.Item("OwnerNameUrdu") = IIf(IsDBNull(DataReader!UrduOwnerName), "", DataReader!UrduOwnerName)
                    Row.Item("OwnerName") = IIf(IsDBNull(DataReader!OwnerName), "", DataReader!OwnerName)
                    Row.Item("OwnerCode") = IIf(IsDBNull(DataReader!OwnerCode), "", DataReader!OwnerCode)
                    If IsDBNull(DataReader!GLCode) Then
                        Row.Item("GLCode") = ""
                    Else
                        Row.Item("GLCode") = Trim(DataReader!GLCode)
                    End If
                    If IsDBNull(DataReader!GLDescription) Then
                        Row.Item("GLDescription") = ""
                    Else
                        Row.Item("GLDescription") = Trim(DataReader!GLDescription)
                    End If
                    'Row.Item("GLCode") = IIf(IsDBNull(DataReader!GLCode), "", Trim(DataReader!GLCode))
                    'Row.Item("GLDescription") = IIf(IsDBNull(DataReader!GLDescription), "", Trim(DataReader!GLDescription))
                    Row.Item("CustomerCode") = IIf(IsDBNull(DataReader!CustomerCode), "", DataReader!CustomerCode)
                    Row.Item("CustomerName") = IIf(IsDBNull(DataReader!CustomerName), "", DataReader!CustomerName)
                    Row.Item("CustomerUrduName") = IIf(IsDBNull(DataReader!UrduCustomerName), "", DataReader!UrduCustomerName)
                    Row.Item("Capacity") = IIf(IsDBNull(DataReader!Capacity), "", DataReader!Capacity)
                    Row.Item("Narration") = IIf(IsDBNull(DataReader!Narration), "", DataReader!Narration)
                    'Row.Item("Debit") = (DataReader!Debit)
                    'Row.Item("Credit") = (DataReader!Credit)
                    Row.Item("Debit") = (DataReader!Credit) 'Trick to resolve the problum
                    Row.Item("Credit") = (DataReader!Debit)

                    If ReportType = ReportFiles.VehicleBills Then
                        Row.Item("TripAdvance") = IIf(IsDBNull(DataReader!TripAdvance), 0D, DataReader!TripAdvance)
                        If Trim(Row.Item("Narration")) = "Trip Advance" And ShowAdvancesInFrontOfTrip = True Then
                            ''giving option the user to see the advances in front of trips
                            Row.Item("Mode") = "Opening" ''Suppress in report
                            Row.Item("Debit") = 0
                            Row.Item("Credit") = 0
                        Else
                            If ShowAdvancesInFrontOfTrip = False Then
                                Row.Item("TripAdvance") = 0
                            End If
                        End If
                    Else
                        Row.Item("Debit") = (DataReader!Debit)
                        Row.Item("Credit") = (DataReader!Credit)
                    End If
                    Row.Item("RecordNo") = (DataReader!RecordNo)
                    Ds.Tables(0).Rows.Add(Row)
                End While
            End If
            Ds.AcceptChanges()
            ''
            ''
            Dim strReportPath As String
            If ReportType = ReportFiles.VehicleBills Then
                Ds.WriteXmlSchema(Application.StartupPath & "\Reports\" & VehicleBillReportFileName & ".xsd")
                strReportPath = Application.StartupPath & "\Reports\" & VehicleBillReportFileName & ".rpt"
                'strReporTitle = "Vehicle Monthly Bill"
            Else
                Ds.WriteXmlSchema(Application.StartupPath & "\Reports\VehicleBillAnalysis.xsd")
                strReportPath = Application.StartupPath & "\Reports\VehicleBillAnalysis.rpt"
                strReporTitle = "Vehicle Bill Analysis"
            End If
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If


            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))

            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "SystemName", "")
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            If ReportType = ReportFiles.VehicleBills Then
                SetParameter(paramFields, "MonthName", FromDate)
            End If
            SetParameter(paramFields, "GroupBy", nGroupBy)
            SetParameter(paramFields, "User", OperatorID)


            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function
    Public Function VehicleBillsProcessWGL(ByVal ReportType As ReportFiles, ByVal FromDate As Date, ByVal ToDate As Date, ByVal FromVehicleCode As String, ByVal ToVehicleCode As String, ByVal FromOwnerCode As String, ByVal ToOwnerCode As String, ByRef reportDoc As ReportDocument, Optional ByVal Progress As Object = Nothing, Optional ByVal nReportType As Integer = 0, Optional ByVal nGroupBy As Integer = 0, Optional ByVal nNarration As String = "", Optional ByVal nPageBreak As Boolean = False, Optional ByVal ShowAdvancesInFrontOfTrip As Boolean = True) As Boolean



        If Trim(FromVehicleCode) = String.Empty Then FromVehicleCode = StartParameter
        If Trim(ToVehicleCode) = String.Empty Then ToVehicleCode = EndParameter
        If Trim(FromOwnerCode) = String.Empty Then FromOwnerCode = StartParameter
        If Trim(ToOwnerCode) = String.Empty Then ToOwnerCode = EndParameter

        Dim nTypeValue As Integer = 0

        Dim nRstGetOpBal As SqlDataReader = Nothing
        Try

            Dim strReporTitle As String = "Vehicle Monthly Bill"
            Dim Acc As AzamTechnologies.Database.DataAccess
            Acc = New AzamTechnologies.Database.DataAccess
            Dim Ds As DataSet = Nothing
            createVehicleBillsDs(Ds)
            GetOpeningBalanceForVehicleBillsWGL(Trim(FromVehicleCode), Trim(ToVehicleCode), Trim(FromOwnerCode), Trim(ToOwnerCode), "", "", Now.Date, DateAdd("D", -1, FromDate), "", nRstGetOpBal, False, False, False)

            ''
            ''Getting OpeningBalance
            ''

            While nRstGetOpBal.Read
                Dim Row As DataRow
                Row = Ds.Tables(0).NewRow

                Row.Item("VehicleCode") = Trim(nRstGetOpBal!VehicleCode)
                Row.Item("CustomerCode") = IIf(IsDBNull(nRstGetOpBal!CustomerCode), "", (nRstGetOpBal!CustomerCode))
                Row.Item("CustomerName") = IIf(IsDBNull(nRstGetOpBal!CustomerName), "", (nRstGetOpBal!CustomerName))
                Row.Item("CustomerUrduName") = IIf(IsDBNull(nRstGetOpBal!UrduCustomerName), "", (nRstGetOpBal!UrduCustomerName))
                Row.Item("OwnerName") = Trim(nRstGetOpBal!OwnerName)
                Row.Item("OwnerNameUrdu") = Trim(nRstGetOpBal!UrduOwnerName)
                Row.Item("GLCode") = Trim(nRstGetOpBal!VehicleCode)
                ' Row.Item("GLDescription") = Trim(nRstGetOpBal!VehicleDescription)
                Row.Item("TransactionDate") = DateAdd("D", -1, FromDate)
                Row.Item("Mode") = "Opening"
                Row.Item("Debit") = IIf(nRstGetOpBal!OpeningBalance > 0, nRstGetOpBal!OpeningBalance, 0) 'IIf((nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance) >= 0, (nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance), 0)
                Row.Item("Credit") = IIf(nRstGetOpBal!OpeningBalance < 0, Math.Abs(nRstGetOpBal!OpeningBalance), 0) 'IIf((nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance) < 0, (nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance), 0)
                Row.Item("RecordNo") = 0

                Ds.Tables(0).Rows.Add(Row)

            End While
            Ds.AcceptChanges()


            Dim DataReader As SqlDataReader


            Call Acc.GetRecord("SelectVehicleBillsReportsWGL", "FromDate", FromDate, "ToDate", ToDate, "FromVehicleCode", Trim(FromVehicleCode), "ToVehicleCode", Trim(ToVehicleCode), "FromOwnerCode", Trim(FromOwnerCode), "ToOwnerCode", Trim(ToOwnerCode), "Posted", False And 1, "PostedED", False And 1, "nType", 1)
            DataReader = Acc.GetRecord("SelectVehicleBillsReportsWGL", "FromDate", FromDate, "ToDate", ToDate, "FromVehicleCode", Trim(FromVehicleCode), "ToVehicleCode", Trim(ToVehicleCode), "FromOwnerCode", Trim(FromOwnerCode), "ToOwnerCode", Trim(ToOwnerCode), "Posted", False And 1, "PostedED", False And 1, "nType", 4)

            If DataReader.HasRows Then
                'If Not (Progress Is Nothing) Then Progress.Limit = DataReader.RecordCount + 10
                While DataReader.Read
                    Dim Row As DataRow
                    Row = Ds.Tables(0).NewRow
                    Row.Item("Mode") = Trim(DataReader!Mode)
                    Row.Item("TransactionNo") = Trim(DataReader!TransactionNo)
                    Row.Item("TransactionDate") = Trim(DataReader!TransactionDate)
                    Row.Item("TokenNo") = Trim(DataReader!CustomerReference)
                    Row.Item("VehicleCode") = Trim(DataReader!VehicleCode)
                    Row.Item("StationPointUrdu") = Trim(DataReader!StationPointUrdu)
                    Row.Item("DestinationPointUrdu") = Trim(DataReader!DestinationPointUrdu)
                    Row.Item("ProductUrdu") = Trim(DataReader!ProductUrdu) 'DateAdd("D", -1, FromDate)
                    Row.Item("Quantity") = DataReader!Quantity
                    Row.Item("Rate") = DataReader!Rate
                    Row.Item("Amount") = DataReader!Quantity * DataReader!Rate
                    Row.Item("Commission") = DataReader!Commission
                    Row.Item("ShortageQuantity") = DataReader!ShortageQuantity
                    Row.Item("Shortage") = DataReader!Shortage
                    Row.Item("OwnerNameUrdu") = IIf(IsDBNull(DataReader!UrduOwnerName), "", DataReader!UrduOwnerName)
                    Row.Item("OwnerName") = IIf(IsDBNull(DataReader!OwnerName), "", DataReader!OwnerName)
                    Row.Item("OwnerCode") = IIf(IsDBNull(DataReader!OwnerCode), "", DataReader!OwnerCode)
                    'If IsDBNull(DataReader!VehicleCode) Then
                    ' Row.Item("VehicleCode") = ""
                    'Else
                    Row.Item("VehicleCode") = Trim(DataReader!VehicleCode)
                    'End If
                    'If IsDBNull(DataReader!GLDescription) Then
                    ' Row.Item("GLDescription") = ""
                    'Else
                    'Row.Item("GLDescription") = Trim(DataReader!GLDescription)
                    'End If
                    'Row.Item("GLCode") = IIf(IsDBNull(DataReader!GLCode), "", Trim(DataReader!GLCode))
                    Row.Item("GLDescription") = IIf(IsDBNull(DataReader!GLDescription), "", Trim(DataReader!GLDescription))
                    Row.Item("CustomerCode") = IIf(IsDBNull(DataReader!CustomerCode), "", DataReader!CustomerCode)
                    Row.Item("CustomerName") = IIf(IsDBNull(DataReader!CustomerName), "", DataReader!CustomerName)
                    Row.Item("CustomerUrduName") = IIf(IsDBNull(DataReader!UrduCustomerName), "", DataReader!UrduCustomerName)
                    Row.Item("Capacity") = IIf(IsDBNull(DataReader!Capacity), "", DataReader!Capacity)
                    Row.Item("Narration") = IIf(IsDBNull(DataReader!Narration), "", DataReader!Narration)
                    Row.Item("TripAdvance") = IIf(IsDBNull(DataReader!TripAdvance), 0D, DataReader!TripAdvance)
                    'Row.Item("Debit") = (DataReader!Debit)
                    'Row.Item("Credit") = (DataReader!Credit)
                    Row.Item("Debit") = (DataReader!ReceiptAmount) 'Trick to resolve the problum
                    Row.Item("Credit") = (DataReader!PaymentAmount)
                    Row.Item("RecordNo") = (DataReader!RecordNo)
                    If Trim(Row.Item("Narration")) = My.Settings.TripAdvanceCode And ShowAdvancesInFrontOfTrip Then
                        ''giving option the user to see the advances in front of trips
                        Row.Item("Mode") = "Opening" ''Suppress in report
                        Row.Item("Debit") = 0
                        Row.Item("Credit") = 0
                    Else
                        If ShowAdvancesInFrontOfTrip = False Then
                            Row.Item("TripAdvance") = 0
                        End If
                    End If

                    Ds.Tables(0).Rows.Add(Row)
                End While
            End If
            Ds.AcceptChanges()
            ''
            ''
            Dim strReportPath As String
            If ReportType = ReportFiles.VehicleBills Then
                Ds.WriteXmlSchema(Application.StartupPath & "\Reports\VehicleBillWGL.xsd")
                strReportPath = Application.StartupPath & "\Reports\VehicleBillWGL.rpt"
                'strReporTitle = "Vehicle Monthly Bill"
            Else
                Ds.WriteXmlSchema(Application.StartupPath & "\Reports\VehicleBillAnalysis.xsd")
                strReportPath = Application.StartupPath & "\Reports\VehicleBillAnalysis.rpt"
                strReporTitle = "Vehicle Bill Analysis"
            End If
            If Not IO.File.Exists(strReportPath) Then
                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
            End If


            reportDoc = New ReportDocument
            reportDoc.Load(strReportPath)
            reportDoc.SetDataSource(Ds.Tables(0))

            ''
            ''Setting Parameters
            Dim paramFields As ParameterFieldDefinitions
            paramFields = reportDoc.DataDefinition.ParameterFields
            SetParameter(paramFields, "ReportTitle", strReporTitle)
            SetParameter(paramFields, "SystemName", "")
            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
            SetParameter(paramFields, "GroupBy", nGroupBy)
            SetParameter(paramFields, "User", OperatorID)


            Return True
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return False
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    '    Public Function VehicleLedgerProcess(ByVal ReportType As ReportFiles, ByVal FromDate As Date, ByVal ToDate As Date, ByVal FromVehicleCode As String, ByVal ToVehicleCode As String, ByVal FromOwnerCode As String, ByVal ToOwnerCode As String, ByRef reportDoc As ReportDocument, Optional ByVal Progress As Object = Nothing, Optional ByVal nGroupBy As Integer = 0, Optional ByVal nReportType As Integer = 0, Optional ByVal IsDetail As Boolean = True) As Boolean

    '        If Trim(FromVehicleCode) = String.Empty Then FromVehicleCode = StartParameter
    '        If Trim(ToVehicleCode) = String.Empty Then ToVehicleCode = EndParameter
    '        If Trim(FromOwnerCode) = String.Empty Then FromOwnerCode = StartParameter
    '        If Trim(ToOwnerCode) = String.Empty Then ToOwnerCode = EndParameter

    '        Dim nTypeValue As Integer = 0

    '        Dim nRstGetOpBal As SqlDataReader = Nothing
    '        Try

    '            Dim strReporTitle As String = "Vehicle Ledger"
    '            Dim Acc As AzamTechnologies.Database.DataAccess
    '            Acc = New AzamTechnologies.Database.DataAccess
    '            Dim Ds As DataSet = Nothing
    '            createVehicleBillsDs(Ds)
    '            GetOpeningBalanceForVehicleBills(Trim(FromVehicleCode), Trim(ToVehicleCode), Trim(FromOwnerCode), Trim(ToOwnerCode), "", "", Now.Date, DateAdd("D", -1, FromDate), "", nRstGetOpBal, False, False, False)

    '            ''
    '            ''Getting OpeningBalance
    '            ''

    '            While nRstGetOpBal.Read
    '                Dim Row As DataRow
    '                Row = Ds.Tables(0).NewRow

    '                Row.Item("VehicleCode") = Trim(nRstGetOpBal!VehicleCode)
    '                Row.Item("OwnerName") = Trim(nRstGetOpBal!OwnerName)
    '                Row.Item("CustomerCode") = IIf(IsDBNull(nRstGetOpBal!CustomerCode), "", (nRstGetOpBal!CustomerCode))
    '                Row.Item("CustomerName") = IIf(IsDBNull(nRstGetOpBal!CustomerName), "", (nRstGetOpBal!CustomerName))
    '                Row.Item("CustomerUrduName") = IIf(IsDBNull(nRstGetOpBal!UrduCustomerName), "", (nRstGetOpBal!UrduCustomerName))
    '                Row.Item("OwnerNameUrdu") = Trim(nRstGetOpBal!UrduOwnerName)
    '                Row.Item("GLCode") = Trim(nRstGetOpBal!GLCode)
    '                Row.Item("GLDescription") = Trim(nRstGetOpBal!GLDescription)
    '                Row.Item("TransactionDate") = DateAdd("D", -1, FromDate)
    '                Row.Item("Mode") = "Opening"
    '                Row.Item("Debit") = IIf(nRstGetOpBal!OpeningBalance > 0, nRstGetOpBal!OpeningBalance, 0) 'IIf((nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance) >= 0, (nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance), 0)
    '                Row.Item("Credit") = IIf(nRstGetOpBal!OpeningBalance < 0, Math.Abs(nRstGetOpBal!OpeningBalance), 0) 'IIf((nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance) < 0, (nRstGetOpBal!DebitBalance + nRstGetAccumulateTransBal!DebitBalance) - (nRstGetOpBal!CreditBalance + nRstGetAccumulateTransBal!CreditBalance), 0)
    '                Row.Item("RecordNo") = 0

    '                Ds.Tables(0).Rows.Add(Row)

    '            End While
    '            Ds.AcceptChanges()


    '            Dim DataReader As SqlDataReader


    '            Call Acc.GetRecord("SelectVehicleLedgerReports", "FromDate", FromDate, "ToDate", ToDate, "FromVehicleCode", Trim(FromVehicleCode), "ToVehicleCode", Trim(ToVehicleCode), "FromOwnerCode", Trim(FromOwnerCode), "ToOwnerCode", Trim(ToOwnerCode), "FromGLCode", "", "ToGLCode", "", "VoucherNatureCode", "", "Posted", False And 1, "PostedED", False And 1, "nType", 1)
    '            DataReader = Acc.GetRecord("SelectVehicleLedgerReports", "FromDate", FromDate, "ToDate", ToDate, "FromVehicleCode", Trim(FromVehicleCode), "ToVehicleCode", Trim(ToVehicleCode), "FromOwnerCode", Trim(FromOwnerCode), "ToOwnerCode", Trim(ToOwnerCode), "FromGLCode", "", "ToGLCode", "", "VoucherNatureCode", "", "Posted", False And 1, "PostedED", False And 1, "nType", 4)

    '            If DataReader.HasRows Then
    '                'If Not (Progress Is Nothing) Then Progress.Limit = DataReader.RecordCount + 10
    'NextRecord:     While DataReader.Read
    '                    'If Trim(DataReader!VehicleCode) = "C-1031" And Trim(DataReader!TransactionNature) = "SV" Then
    '                    '    MsgBox("DD")
    '                    'End If
    '                    If Trim(DataReader!TransactionNature) = "SV" And _
    '                    My.Settings.ShortageGLCode <> Left(Trim(DataReader!GLCode), My.Settings.GeneralCodeFK_Length) And My.Settings.CommissionGLCode <> Left(Trim(DataReader!GLCode), My.Settings.GeneralCodeFK_Length) Then
    '                        GoTo NextRecord
    '                    End If

    '                    ''FOR KEEP DEBIT CREDIT BALANCE EQUAL UNCOMMENT THE FOLLOWING
    '                    'If My.Settings.Debtors = Left(Trim(DataReader!GLCode), My.Settings.FSFSubsidiaryCodeFK_Length + My.Settings.GeneralCodeFK_Length) Then
    '                    '    GoTo NextRecord
    '                    'End If

    '                    Dim Row As DataRow
    '                    Row = Ds.Tables(0).NewRow

    '                    Row.Item("Mode") = Trim(DataReader!Mode)
    '                    Row.Item("TransactionNo") = Trim(DataReader!TransactionNo)
    '                    Row.Item("TransactionNature") = Trim(DataReader!TransactionNature)
    '                    Row.Item("TransactionDate") = Trim(DataReader!TransactionDate)
    '                    Row.Item("TokenNo") = Trim(DataReader!CustomerReference)
    '                    Row.Item("VehicleCode") = Trim(DataReader!VehicleCode)
    '                    Row.Item("StationPointUrdu") = Trim(DataReader!StationPointUrdu)
    '                    Row.Item("DestinationPointUrdu") = Trim(DataReader!DestinationPointUrdu)
    '                    Row.Item("ProductUrdu") = Trim(DataReader!ProductUrdu) 'DateAdd("D", -1, FromDate)
    '                    Row.Item("Quantity") = DataReader!Quantity
    '                    Row.Item("Rate") = DataReader!Rate
    '                    Row.Item("Amount") = DataReader!Quantity * DataReader!Rate
    '                    Row.Item("Commission") = DataReader!Commission
    '                    Row.Item("ShortageQuantity") = DataReader!ShortageQuantity
    '                    Row.Item("Shortage") = DataReader!Shortage
    '                    Row.Item("OwnerNameUrdu") = IIf(IsDBNull(DataReader!UrduOwnerName), "", DataReader!UrduOwnerName)
    '                    Row.Item("OwnerName") = IIf(IsDBNull(DataReader!OwnerName), "", DataReader!OwnerName)
    '                    Row.Item("OwnerCode") = IIf(IsDBNull(DataReader!OwnerCode), "", DataReader!OwnerCode)
    '                    Row.Item("GLCode") = Trim(DataReader!GLCode)
    '                    Row.Item("GLDescription") = Trim(DataReader!GLDescription)
    '                    Row.Item("Debit") = (DataReader!Debit)
    '                    Row.Item("Credit") = (DataReader!Credit)
    '                    Row.Item("RecordNo") = (DataReader!RecordNo)
    '                    Row.Item("CustomerCode") = IIf(IsDBNull(DataReader!CustomerCode), "", DataReader!CustomerCode)
    '                    Row.Item("CustomerName") = IIf(IsDBNull(DataReader!CustomerName), "", DataReader!CustomerName)
    '                    Row.Item("CustomerUrduName") = IIf(IsDBNull(DataReader!UrduCustomerName), "", DataReader!UrduCustomerName)

    '                    Ds.Tables(0).Rows.Add(Row)

    '                End While
    '            End If
    '            Ds.AcceptChanges()
    '            ''
    '            ''
    '            Ds.WriteXmlSchema(Application.StartupPath & "\Reports\VehicleLedger.xsd")
    '            Dim strReportPath As String
    '            If IsDetail = True Then
    '                strReportPath = Application.StartupPath & "\Reports\VehicleLedger.rpt"
    '                strReporTitle = "Vehicle Ledger"
    '            Else
    '                strReportPath = Application.StartupPath & "\Reports\VehicleLedgerSummary.rpt"
    '                strReporTitle = "Vehicle Ledger Summary"
    '            End If
    '            If Not IO.File.Exists(strReportPath) Then
    '                Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
    '            End If


    '            reportDoc = New ReportDocument
    '            reportDoc.Load(strReportPath)
    '            reportDoc.SetDataSource(Ds.Tables(0))

    '            ''
    '            ''Setting Parameters
    '            Dim paramFields As ParameterFieldDefinitions
    '            paramFields = reportDoc.DataDefinition.ParameterFields
    '            SetParameter(paramFields, "ReportTitle", strReporTitle)
    '            SetParameter(paramFields, "SystemName", "")
    '            SetParameter(paramFields, "GroupBy", nGroupBy)
    '            SetParameter(paramFields, "CompanyName", My.Settings.CompanyName)
    '            SetParameter(paramFields, "User", OperatorID)


    '            Return True
    '        Catch ex As SqlClient.SqlException
    '            MsgBox(ex.Message)
    '            Return False
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '            Return False
    '        End Try

    '    End Function
    Sub createVehicleBillsDs(ByRef dataset As DataSet)
        dataset = New DataSet
        Dim Table As New DataTable
        Table.Columns.Add("Mode", System.Type.GetType("System.String"))
        Table.Columns.Add("TransactionNo", System.Type.GetType("System.String"))
        Table.Columns.Add("TransactionDate", System.Type.GetType("System.DateTime"))
        Table.Columns.Add("TokenNo", System.Type.GetType("System.String"))
        Table.Columns.Add("Capacity", System.Type.GetType("System.String"))
        Table.Columns.Add("VehicleCode", System.Type.GetType("System.String"))
        Table.Columns.Add("OwnerCode", System.Type.GetType("System.String"))
        Table.Columns.Add("OwnerName", System.Type.GetType("System.String"))
        Table.Columns.Add("OwnerNameUrdu", System.Type.GetType("System.String"))
        Table.Columns.Add("ProductUrdu", System.Type.GetType("System.String"))
        Table.Columns.Add("StationPointUrdu", System.Type.GetType("System.String"))
        Table.Columns.Add("DestinationPointUrdu", System.Type.GetType("System.String"))
        Table.Columns.Add("Quantity", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("Rate", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("Amount", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("Commission", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("Shortage", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("ShortageQuantity", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("Debit", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("Credit", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("RecordNo", System.Type.GetType("System.Int64"))
        Table.Columns.Add("GLCode", System.Type.GetType("System.String"))
        Table.Columns.Add("GLDescription", System.Type.GetType("System.String"))
        Table.Columns.Add("CustomerCode", System.Type.GetType("System.String"))
        Table.Columns.Add("CustomerName", System.Type.GetType("System.String"))
        Table.Columns.Add("TransactionNature", System.Type.GetType("System.String"))
        Table.Columns.Add("CustomerUrduName", System.Type.GetType("System.String"))
        Table.Columns.Add("Narration", System.Type.GetType("System.String"))
        Table.Columns.Add("TripAdvance", System.Type.GetType("System.Decimal"))
        dataset.Tables.Add(Table)

    End Sub
    Public Function GetAccumulateTransBalances(ByVal nFromBranchCode As String, ByVal nToBranchCode As String, ByVal nFromDivisionCode As String, ByVal nToDivisionCode As String, ByVal nFromGLCode As String, ByVal nToGLCode As String, ByVal nFromDate As Date, ByVal nToDate As Date, ByVal nDocumentNature As String, ByRef nRstDataAccTransBal As SqlDataReader, ByVal nType As Integer, ByVal ReportSD As String, ByVal Posted As Boolean, ByVal PostedED As Boolean) As Boolean
        Dim Acc As New AzamTechnologies.Database.DataAccess
        Dim RstDataAccTransBal As SqlClient.SqlDataReader
        'Call nOBJ.GetModify(AWASystemName, RstDataAccTransBal, "GL_RptLedgerSP", "FromBranchCode", Trim(nFromBranchCode), "ToBranchCode", Trim(nToBranchCode), "FromDivisionCode", Trim(nFromDivisionCode), "ToDivisionCode", Trim(nToDivisionCode), "FromGLCode", Trim(nFromGLCode), "ToGLCode", Trim(nToGLCode), "FromDate", nFromDate, "ToDate", nToDate, "DocumentNatureCode", nDocumentNature, "nType", 0)
        RstDataAccTransBal = Acc.GetRecord("SelectGeneralLedgerReports", "FromBranchCode", Trim(nFromBranchCode), "ToBranchCode", Trim(nToBranchCode), "FromDivisionCode", Trim(nFromDivisionCode), "ToDivisionCode", Trim(nToDivisionCode), "FromGLCode", Trim(nFromGLCode), "ToGLCode", Trim(nToGLCode), "FromDate", nFromDate, "ToDate", nToDate, "VoucherNatureCode", nDocumentNature, "Posted", (Posted And 1), "PostedED", (PostedED And 1), "ReportSD", ReportSD, "nType", 2)
        RstDataAccTransBal = Acc.GetRecord("SelectGeneralLedgerReports", "FromBranchCode", Trim(nFromBranchCode), "ToBranchCode", Trim(nToBranchCode), "FromDivisionCode", Trim(nFromDivisionCode), "ToDivisionCode", Trim(nToDivisionCode), "FromGLCode", Trim(nFromGLCode), "ToGLCode", Trim(nToGLCode), "FromDate", nFromDate, "ToDate", nToDate, "VoucherNatureCode", nDocumentNature, "Posted", (Posted And 1), "PostedED", (PostedED And 1), "ReportSD", ReportSD, "nType", nType)
        nRstDataAccTransBal = RstDataAccTransBal
    End Function
    Public Function GetOpeningBalance(ByVal nFromBranchCode As String, ByVal nToBranchCode As String, ByVal nFromDivisionCode As String, ByVal nToDivisionCode As String, ByVal nFromGLCode As String, ByVal nToGLCode As String, ByVal nFromDate As Date, ByVal nToDate As Date, ByVal nDocumentNature As String, ByRef RstDataOpeningBal As SqlClient.SqlDataReader, ByVal IsGenrate As Boolean, ByVal Posted As Boolean, ByVal PostedED As Boolean) As Boolean
        Dim Acc As New AzamTechnologies.Database.DataAccess
        Dim RstDataAccTransBal As SqlClient.SqlDataReader
        RstDataOpeningBal = Acc.GetRecord("SelectGeneralLedgerReports", "FromBranchCode", Trim(nFromBranchCode), "ToBranchCode", Trim(nToBranchCode), "FromDivisionCode", Trim(nFromDivisionCode), "ToDivisionCode", Trim(nToDivisionCode), "FromGLCode", Trim(nFromGLCode), "ToGLCode", Trim(nToGLCode), "FromDate", nFromDate, "ToDate", nToDate, "VoucherNatureCode", nDocumentNature, "Posted", (Posted And 1), "PostedED", (PostedED And 1), "nType", 0)

        If IsGenrate = False Then
            RstDataAccTransBal = Acc.GetRecord("SelectGeneralLedgerReports", "FromBranchCode", Trim(nFromBranchCode), "ToBranchCode", Trim(nToBranchCode), "FromDivisionCode", Trim(nFromDivisionCode), "ToDivisionCode", Trim(nToDivisionCode), "FromGLCode", Trim(nFromGLCode), "ToGLCode", Trim(nToGLCode), "FromDate", nFromDate, "ToDate", nToDate, "VoucherNatureCode", nDocumentNature, "Posted", (Posted And 1), "PostedED", (PostedED And 1), "nType", 3)
            RstDataOpeningBal = RstDataAccTransBal
            'RstDataOpeningBal = RstDataAccTransBal.clone
        End If

    End Function
    Public Function GetAccumulateTransBalancesForFSF(ByVal nFromBranchCode As String, ByVal nToBranchCode As String, ByVal nFromDivisionCode As String, ByVal nToDivisionCode As String, ByVal nFromGLCode As String, ByVal nToGLCode As String, ByVal nFromFSFCode As String, ByVal nToFSFCode As String, ByVal nFromDate As Date, ByVal nToDate As Date, ByVal nDocumentNature As String, ByRef nRstDataAccTransBal As SqlClient.SqlDataReader, ByVal nType As Integer, ByVal ReportSD As String, ByVal Posted As Boolean, ByVal PostedED As Boolean) As Boolean
        Dim Acc As New AzamTechnologies.Database.DataAccess
        Dim RstDataAccTransBal As SqlClient.SqlDataReader
        RstDataAccTransBal = Acc.GetRecord("SelectFinancialStatementReports", "FromBranchCode", Trim(nFromBranchCode), "ToBranchCode", Trim(nToBranchCode), "FromDivisionCode", Trim(nFromDivisionCode), "ToDivisionCode", Trim(nToDivisionCode), "FromGLCode", Trim(nFromGLCode), "ToGLCode", Trim(nToGLCode), "FromFSFCode", Trim(nFromFSFCode), "ToFSFCode", Trim(nToFSFCode), "FromDate", nFromDate, "ToDate", nToDate, "VoucherNatureCode", nDocumentNature, "Posted", (Posted And 1), "PostedED", (PostedED And 1), "ReportSD", ReportSD, "nType", 2)
        RstDataAccTransBal = Acc.GetRecord("SelectFinancialStatementReports", "FromBranchCode", Trim(nFromBranchCode), "ToBranchCode", Trim(nToBranchCode), "FromDivisionCode", Trim(nFromDivisionCode), "ToDivisionCode", Trim(nToDivisionCode), "FromGLCode", Trim(nFromGLCode), "ToGLCode", Trim(nToGLCode), "FromFSFCode", Trim(nFromFSFCode), "ToFSFCode", Trim(nToFSFCode), "FromDate", nFromDate, "ToDate", nToDate, "VoucherNatureCode", nDocumentNature, "Posted", (Posted And 1), "PostedED", (PostedED And 1), "ReportSD", ReportSD, "nType", nType)
        nRstDataAccTransBal = RstDataAccTransBal
    End Function
    Public Function GetOpeningBalanceForFSF(ByVal nFromBranchCode As String, ByVal nToBranchCode As String, ByVal nFromDivisionCode As String, ByVal nToDivisionCode As String, ByVal nFromGLCode As String, ByVal nToGLCode As String, ByVal nFromFSFCode As String, ByVal nToFSFCode As String, ByVal nFromDate As Date, ByVal nToDate As Date, ByVal nDocumentNature As String, ByVal RstDataOpeningBal As SqlClient.SqlDataReader, ByVal IsGenrate As Boolean, ByVal Posted As Boolean, ByVal PostedED As Boolean) As Boolean
        Dim Acc As New AzamTechnologies.Database.DataAccess
        Dim RstDataAccTransBal As SqlClient.SqlDataReader
        RstDataOpeningBal = Acc.GetRecord("SelectFinancialStatementReports", "FromBranchCode", Trim(nFromBranchCode), "ToBranchCode", Trim(nToBranchCode), "FromDivisionCode", Trim(nFromDivisionCode), "ToDivisionCode", Trim(nToDivisionCode), "FromGLCode", Trim(nFromGLCode), "ToGLCode", Trim(nToGLCode), "FromFSFCode", Trim(nFromFSFCode), "ToFSFCode", Trim(nToFSFCode), "FromDate", nFromDate, "ToDate", nToDate, "VoucherNatureCode", nDocumentNature, "Posted", (Posted And 1), "PostedED", (PostedED And 1), "nType", 0)

        If IsGenrate = False Then
            RstDataAccTransBal = Acc.GetRecord("SelectFinancialStatementReports", "FromBranchCode", Trim(nFromBranchCode), "ToBranchCode", Trim(nToBranchCode), "FromDivisionCode", Trim(nFromDivisionCode), "ToDivisionCode", Trim(nToDivisionCode), "FromGLCode", Trim(nFromGLCode), "ToGLCode", Trim(nToGLCode), "FromFSFCode", Trim(nFromFSFCode), "ToFSFCode", Trim(nToFSFCode), "FromDate", nFromDate, "ToDate", nToDate, "VoucherNatureCode", nDocumentNature, "Posted", (Posted And 1), "PostedED", (PostedED And 1), "nType", 3)
            RstDataOpeningBal = RstDataAccTransBal
            'RstDataOpeningBal = RstDataAccTransBal.clone
        End If


    End Function
    Public Function GetOpeningBalanceForCashFlow(ByVal nFromBranchCode As String, ByVal nToBranchCode As String, ByVal nFromDivisionCode As String, ByVal nToDivisionCode As String, ByVal GLCode As String, ByVal nFromDate As Date, ByVal nToDate As Date, ByVal nDocumentNature As String, ByRef RstDataOpeningBal As SqlClient.SqlDataReader, ByVal IsGenrate As Boolean, ByVal Posted As Boolean, ByVal PostedED As Boolean) As Boolean
        Dim Acc As New AzamTechnologies.Database.DataAccess
        Dim RstDataAccTransBal As SqlClient.SqlDataReader = Nothing
        RstDataAccTransBal = Acc.GetRecord("SelectCashFlowStatementReports", "FromBranchCode", Trim(nFromBranchCode), "ToBranchCode", Trim(nToBranchCode), "FromDivisionCode", Trim(nFromDivisionCode), "ToDivisionCode", Trim(nToDivisionCode), "GLCode", GLCode, "FromDate", nFromDate, "ToDate", nToDate, "VoucherNatureCode", nDocumentNature, "Posted", (Posted And 1), "PostedED", (PostedED And 1), "nType", 0)
        If IsGenrate = False Then
            RstDataAccTransBal = Acc.GetRecord("SelectCashFlowStatementReports", "FromBranchCode", Trim(nFromBranchCode), "ToBranchCode", Trim(nToBranchCode), "FromDivisionCode", Trim(nFromDivisionCode), "ToDivisionCode", Trim(nToDivisionCode), "GLCode", GLCode, "FromDate", nFromDate, "ToDate", nToDate, "VoucherNatureCode", nDocumentNature, "Posted", (Posted And 1), "PostedED", (PostedED And 1), "nType", 3)
            RstDataOpeningBal = RstDataAccTransBal
        End If

    End Function
    Public Function GetOpeningBalanceForVehicleBills(ByVal nFromVehicleCode As String, ByVal nToVehicleCode As String, ByVal nFromOwnerCode As String, ByVal nToOwnerCode As String, ByVal nFromGLCode As String, ByVal nToGLCode As String, ByVal nFromDate As Date, ByVal nToDate As Date, ByVal nDocumentNature As String, ByRef RstDataOpeningBal As SqlClient.SqlDataReader, ByVal IsGenrate As Boolean, ByVal Posted As Boolean, ByVal PostedED As Boolean) As Boolean
        Dim Acc As New AzamTechnologies.Database.DataAccess
        Dim RstDataAccTransBal As SqlClient.SqlDataReader
        RstDataOpeningBal = Acc.GetRecord("SelectVehicleBillsReports", "FromVehicleCode", Trim(nFromVehicleCode), "ToVehicleCode", Trim(nToVehicleCode), "FromOwnerCode", Trim(nFromOwnerCode), "ToOwnerCode", Trim(nToOwnerCode), "FromGLCode", Trim(nFromGLCode), "ToGLCode", Trim(nToGLCode), "FromDate", nFromDate, "ToDate", nToDate, "VoucherNatureCode", nDocumentNature, "Posted", (Posted And 1), "PostedED", (PostedED And 1), "nType", 0)

        If IsGenrate = False Then
            RstDataAccTransBal = Acc.GetRecord("SelectVehicleBillsReports", "FromVehicleCode", Trim(nFromVehicleCode), "ToVehicleCode", Trim(nToVehicleCode), "FromOwnerCode", Trim(nFromOwnerCode), "ToOwnerCode", Trim(nToOwnerCode), "FromGLCode", Trim(nFromGLCode), "ToGLCode", Trim(nToGLCode), "FromDate", nFromDate, "ToDate", nToDate, "VoucherNatureCode", nDocumentNature, "Posted", (Posted And 1), "PostedED", (PostedED And 1), "nType", 3)
            RstDataOpeningBal = RstDataAccTransBal
            'RstDataOpeningBal = RstDataAccTransBal.clone
        End If

    End Function
    Public Function GetOpeningBalanceForVehicleBillsWGL(ByVal nFromVehicleCode As String, ByVal nToVehicleCode As String, ByVal nFromOwnerCode As String, ByVal nToOwnerCode As String, ByVal nFromGLCode As String, ByVal nToGLCode As String, ByVal nFromDate As Date, ByVal nToDate As Date, ByVal nDocumentNature As String, ByRef RstDataOpeningBal As SqlClient.SqlDataReader, ByVal IsGenrate As Boolean, ByVal Posted As Boolean, ByVal PostedED As Boolean) As Boolean
        Dim Acc As New AzamTechnologies.Database.DataAccess
        Dim RstDataAccTransBal As SqlClient.SqlDataReader
        RstDataOpeningBal = Acc.GetRecord("SelectVehicleBillsReportsWGL", "FromVehicleCode", Trim(nFromVehicleCode), "ToVehicleCode", Trim(nToVehicleCode), "FromOwnerCode", Trim(nFromOwnerCode), "ToOwnerCode", Trim(nToOwnerCode), "FromDate", nFromDate, "ToDate", nToDate, "Posted", (Posted And 1), "PostedED", (PostedED And 1), "nType", 0)

        If IsGenrate = False Then
            RstDataAccTransBal = Acc.GetRecord("SelectVehicleBillsReportsWGL", "FromVehicleCode", Trim(nFromVehicleCode), "ToVehicleCode", Trim(nToVehicleCode), "FromOwnerCode", Trim(nFromOwnerCode), "ToOwnerCode", Trim(nToOwnerCode), "FromDate", nFromDate, "ToDate", nToDate, "Posted", (Posted And 1), "PostedED", (PostedED And 1), "nType", 3)
            RstDataOpeningBal = RstDataAccTransBal
            'RstDataOpeningBal = RstDataAccTransBal.clone
        End If

    End Function
    Sub createILedgDs(ByRef dataset As DataSet)
        dataset = New DataSet
        Dim Table As New DataTable
        Table.Columns.Add("BranchCode", System.Type.GetType("System.String"))
        Table.Columns.Add("Branch", System.Type.GetType("System.String"))
        Table.Columns.Add("DivisionCode", System.Type.GetType("System.String"))
        Table.Columns.Add("Division", System.Type.GetType("System.String"))
        Table.Columns.Add("GLCode", System.Type.GetType("System.String"))
        Table.Columns.Add("GLDescription", System.Type.GetType("System.String"))
        Table.Columns.Add("DocumentNo", System.Type.GetType("System.String"))
        Table.Columns.Add("DocumentNature", System.Type.GetType("System.String"))
        Table.Columns.Add("TransactionDate", System.Type.GetType("System.DateTime"))
        Table.Columns.Add("Reference", System.Type.GetType("System.String"))
        Table.Columns.Add("Narration", System.Type.GetType("System.String"))

        Table.Columns.Add("ControlCode", System.Type.GetType("System.String"))
        Table.Columns.Add("Control", System.Type.GetType("System.String"))
        Table.Columns.Add("GeneralCode", System.Type.GetType("System.String"))
        Table.Columns.Add("General", System.Type.GetType("System.String"))
        Table.Columns.Add("SubsidiaryCode", System.Type.GetType("System.String"))
        Table.Columns.Add("Subsidiary", System.Type.GetType("System.String"))
        Table.Columns.Add("SubSubCode", System.Type.GetType("System.String"))
        Table.Columns.Add("SubSub", System.Type.GetType("System.String"))
        Table.Columns.Add("Debit", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("Credit", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("OldRef", System.Type.GetType("System.String"))
        Table.Columns.Add("RecordNo", System.Type.GetType("System.Int64"))
        Table.Columns.Add("DetailRecordNo", System.Type.GetType("System.Int64"))
        Table.Columns.Add("DocumentStatus", System.Type.GetType("System.String"))
        dataset.Tables.Add(Table)

    End Sub
    Sub createFSFDs(ByRef dataset As DataSet)
        dataset = New DataSet
        Dim Table As New DataTable
        Table.Columns.Add("BranchCode", System.Type.GetType("System.String"))
        Table.Columns.Add("Branch", System.Type.GetType("System.String"))
        Table.Columns.Add("DivisionCode", System.Type.GetType("System.String"))
        Table.Columns.Add("Division", System.Type.GetType("System.String"))
        Table.Columns.Add("OpeningCredit", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("OpeningDebit", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("CurrentDebit", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("CurrentCredit", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("CurrentBudgetAmount", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("CummulativeBudgetAmount", System.Type.GetType("System.Decimal"))

        Table.Columns.Add("GLCode", System.Type.GetType("System.String"))
        Table.Columns.Add("GLDescription", System.Type.GetType("System.String"))
        Table.Columns.Add("ControlCode", System.Type.GetType("System.String"))
        Table.Columns.Add("Control", System.Type.GetType("System.String"))
        Table.Columns.Add("GeneralCode", System.Type.GetType("System.String"))
        Table.Columns.Add("General", System.Type.GetType("System.String"))
        Table.Columns.Add("SubsidiaryCode", System.Type.GetType("System.String"))
        Table.Columns.Add("Subsidiary", System.Type.GetType("System.String"))
        Table.Columns.Add("SubSubCode", System.Type.GetType("System.String"))
        Table.Columns.Add("SubSub", System.Type.GetType("System.String"))

        Table.Columns.Add("FSFGLCode", System.Type.GetType("System.String"))
        Table.Columns.Add("FSFGLDescription", System.Type.GetType("System.String"))
        Table.Columns.Add("FSFControlCode", System.Type.GetType("System.String"))
        Table.Columns.Add("FSFControl", System.Type.GetType("System.String"))
        Table.Columns.Add("FSFGeneralCode", System.Type.GetType("System.String"))
        Table.Columns.Add("FSFGeneral", System.Type.GetType("System.String"))
        Table.Columns.Add("FSFSubsidiaryCode", System.Type.GetType("System.String"))
        Table.Columns.Add("FSFSubsidiary", System.Type.GetType("System.String"))
        Table.Columns.Add("FSFSubSubCode", System.Type.GetType("System.String"))
        Table.Columns.Add("FSFSubSub", System.Type.GetType("System.String"))

        Table.Columns.Add("RptType", System.Type.GetType("System.String"))

        Table.Columns.Add("FSFExpenseAccount", System.Type.GetType("System.String"))
        Table.Columns.Add("FSFAssetsAccount", System.Type.GetType("System.String"))
        Table.Columns.Add("FSFLiabilityAccount", System.Type.GetType("System.String"))
        Table.Columns.Add("FSFIncomeAccount", System.Type.GetType("System.String"))
        dataset.Tables.Add(Table)

    End Sub
    Sub createTrialBalanceDs(ByRef dataset As DataSet)
        dataset = New DataSet
        Dim Table As New DataTable
        Table.Columns.Add("BranchCode", System.Type.GetType("System.String"))
        Table.Columns.Add("Branch", System.Type.GetType("System.String"))
        Table.Columns.Add("DivisionCode", System.Type.GetType("System.String"))
        Table.Columns.Add("Division", System.Type.GetType("System.String"))
        Table.Columns.Add("GLCode", System.Type.GetType("System.String"))
        Table.Columns.Add("GLDescription", System.Type.GetType("System.String"))
        Table.Columns.Add("OpeningDebit", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("OpeningCredit", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("CurrentDebit", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("CurrentCredit", System.Type.GetType("System.Decimal"))
        Table.Columns.Add("DocumentNature", System.Type.GetType("System.String"))
        Table.Columns.Add("ControlCode", System.Type.GetType("System.String"))
        Table.Columns.Add("Control", System.Type.GetType("System.String"))
        Table.Columns.Add("GeneralCode", System.Type.GetType("System.String"))
        Table.Columns.Add("General", System.Type.GetType("System.String"))
        Table.Columns.Add("SubsidiaryCode", System.Type.GetType("System.String"))
        Table.Columns.Add("Subsidiary", System.Type.GetType("System.String"))
        Table.Columns.Add("SubSubCode", System.Type.GetType("System.String"))
        Table.Columns.Add("SubSub", System.Type.GetType("System.String"))

        dataset.Tables.Add(Table)
    End Sub
    Private Sub SettingReportToGrid(ByVal File As ReportFiles, ByVal FillingDataSet As DataSet)
        Dim mainGrid As frmGrid
        mainGrid = New frmGrid
        If File = ReportFiles.VoucherList Then
            mainGrid.strMasterTable = "Vouchers"
        ElseIf File = ReportFiles.TransactionList Then
            mainGrid.strMasterTable = "VehicleAdjustments"
        End If

        mainGrid.LoadingType = frmGrid.LoadType.ReportToGrid
        mainGrid.Director = frmMain.DataDirector1
        mainGrid.Manager = frmMain.DataManager1
        ''Grid Navigation header Text Setting i.e. to show proper table name
        'FillingDataSet.DataSetName = e.SelectedTable
        'FillingDataSet.Tables(0).TableName = e.SelectedTable
        '''''''''''''''''''''
        mainGrid.LoadingType = frmGrid.LoadType.ReportToGrid
        mainGrid.dsData = FillingDataSet
        mainGrid.dsDetail = FillingDataSet
        mainGrid.MdiParent = frmMain
        mainGrid.WindowState = FormWindowState.Maximized
        mainGrid.Show()

    End Sub


End Module
