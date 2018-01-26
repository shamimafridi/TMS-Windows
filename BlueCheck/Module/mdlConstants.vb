
Module mdlConstants
    Public Const SystemCompanyTitle As String = "Azam Technologies"
    Public Const ReportsCompanyTitle As String = "Azam Technologies (PVT) Limited."
    Public Const ReportsModuleName As String = "Customer Realation Management"
    Public Const UpdateProcedurePrefix As String = "Update"
    Public Const SelectProcedurePrefix As String = "Select"
    Public Const DeletProcedurePrefix As String = "Delete"
    Public Const DeteilTableProcedurePostFix As String = "Details"
    ' DCOM Class object references for Data Accessing.

    '
    Public RecordPosition As Integer
    Public FormDataActionMode As AzamTechnologies.DataManager.DataMode
    Public OperatorID As String = "Administrator"
    Public MachineID As String
    Public ServerName As String
    Public CurrentWorkingDate As Date
    ''''Natures 
    Public Const PurchaseOrderNature As String = "PO"
    Public Const ReceivingNature As String = "10"
    Public Const ReceivingReturnNature As String = "30"
    Public Const SaleOrderNature As String = "SO"
    Public Const SaleInvoiceNature As String = "INV"
    Public Const SaleInvoiceReturnNature As String = "20"
    Public Const VehicleReceiptNature As String = "VR"
    Public Const VehiclePaymentNature As String = "VP"
    Public Const VehicleFinancialExpenceNature As String = "FE"
    Public Const VehicleAdjustmentReceiptNature As String = "AR"
    Public Const VehicleAdjustmentPaymentNature As String = "AP"
    Public Const ReceiptNature As String = "REC"




    Public Const JournalVoucherNature As String = "JV"
    Public Const BankReceiptVoucherNature As String = "BR"
    Public Const CashReceiptVoucherNature As String = "CR"
    Public Const BankPaymentVoucherNature As String = "BP"
    Public Const CashPaymentVoucherNature As String = "CP"
    Public Const SaleVoucherNature As String = "SV"

    Public Const SetupParentNodeText As String = "Setup Files"
    Public Const TransactionsParentNodeText As String = "Transaction Files"
    Public Const ManagementNodeText As String = "Management Files"
    Public Const SecurityNodeText As String = "Security Files"
    Public Const SystemNodeText As String = "Business Intelligence System"
    Public Const InventoryNodeText As String = "Inventory"
    Public Const PayrollNodeText As String = "Payroll"
    Public Const GeneralLedgerNodeText As String = "General Ledger"
    Public Const TopMostNodeText As String = "Business Intelligence System"
    Public Const StrTransactionTerm As String = "TransactionNature"
    Function GetConnectionString() As SqlClient.SqlConnection
        Dim ConnString As String = String.Empty
        Dim clsConnString As New AzamTechnologies.Database.DataConnection
        Dim con As New SqlClient.SqlConnection
        con = clsConnString.GetConnection
        Return con
    End Function
    Dim configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
    'Function GetValue(ByVal variablSender As String) As Object
    '    Try
    '        '''Getting Profiles values which is defined in App file
    '        Return configurationAppSettings.GetValue(variablSender, GetType(System.String))
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Function
    'Function GetRecordStatus(ByVal StatusNumber As Int16)
    '    Dim st As New frmMain
    '    Select Case StatusNumber
    '        Case Is = 1
    '            st.stbMain.Text = "Ready......"
    '            'st.stbMain.Panels(0).Icon =c:\"
    '        Case Is = 2
    '            st.stbMain.Text = "Deletion......"
    '            'st.stbMain.Panels(0).Icon =c:\"
    '    End Select
    'End Function


End Module
