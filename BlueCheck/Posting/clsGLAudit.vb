Option Strict Off
Option Explicit On
Friend Class clsGLAuditing
	
	Private PtrBranchs As clsGLAuditBranchs
	Private Const DateFormat As String = "MM/dd/yyyy"
    Private DebitorsCode As String
	Private CreditorsCode As String
	Private MTSServerName As String
	Private mProgress As Short
	Private IsAuditFound As Boolean
	
	Public Event CurrentProgress(ByRef Value As Short, ByRef FillColor As Integer)
	
    Public Function AuditingTrans(ByRef AuditDate As Date) As DataTable
        Dim RstTransList As DataTable
        Dim ResultSet As DataTable
        Dim ProgressStart As Short
        Try

            DebitorsCode = My.Settings.Debtors
            CreditorsCode = My.Settings.Creditors

            Progress = 1
            ProgressStart = Progress

            ResultSet = GenrateResultset()

            PtrBranchs = New clsGLAuditBranchs
            RstTransList = GetRecordset("EXECUTE SelectPosting @nType = 4,@PostingDate = '" & Format(AuditDate, DateFormat) & "', @Creditors='" & My.Settings.Creditors & "',@Debitors='" & My.Settings.Debtors & "'")
            RstTransList = GetRecordset("EXECUTE SelectPosting @nType = 5,@PostingDate = '" & Format(AuditDate, DateFormat) & "', @Creditors='" & My.Settings.Creditors & "',@Debitors='" & My.Settings.Debtors & "'")
            Progress = ProgressStart + 49
            ProgressStart = Progress

            Return RstTransList
            Progress = 100
            Exit Function
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Private Function AuditSingleTrans(ByRef RstTransList As SqlClient.SqlDatareader, ByRef ErrNature As String, ByRef InvoiceAmount As Double, ByRef PaymentAmount As Double, ByRef nAbsolutePosition As Integer, ByRef pPaymentAmount As Double) As Boolean

        'Dim nPaymentAmount As Double
        'Dim nInvoiceAmount As Double
        'Dim PtrBranch As clsGLAuditBranch
        'Dim PtrParty As clsGLAuditParty
        'Dim PtrInvoice As clsGLAuditInvoice
        'Dim TransNatureValue As Short

        'PtrBranch = PtrBranchs.AddBranch(RstTransList.Fields("BranchCode").Value)
        'PtrParty = PtrBranch.AddParty(RstTransList.Fields("SysGLCode").Value, RstTransList.Fields("PartyType").Value)

        'If Left(RstTransList.Fields("GLCode").Value, Len(DebitorsCode)) = DebitorsCode Then
        '    If RstTransList.Fields("Debit").Value > 0 Then
        '        ' Invoice
        '        nInvoiceAmount = RstTransList.Fields("Debit").Value
        '        nPaymentAmount = 0
        '    Else
        '        ' Payment
        '        nInvoiceAmount = 0
        '        nPaymentAmount = RstTransList.Fields("Credit").Value
        '    End If
        'ElseIf Left(RstTransList.Fields("GLCode").Value, Len(CreditorsCode)) = CreditorsCode Then
        '    If RstTransList.Fields("Credit").Value > 0 Then
        '        ' Invoice
        '        nInvoiceAmount = RstTransList.Fields("Credit").Value
        '        nPaymentAmount = 0
        '    Else
        '        ' Payment
        '        nInvoiceAmount = 0
        '        nPaymentAmount = RstTransList.Fields("Debit").Value
        '    End If
        'Else
        '    Err.Raise(CInt("1001"), "Process Single Trans", "Invalid Party Code " & RstTransList.Fields("GLCode").Value)
        'End If ' [ END OF If RstTransList!PartyType = Debitors Then ]


        'If nInvoiceAmount > 0 Then

        '    If RstTransList.Fields("InvoiceNo").Value = "" Then
        '        nAbsolutePosition = 0
        '        ErrNature = "Invoice Without No"
        '        InvoiceAmount = nInvoiceAmount
        '        PaymentAmount = nPaymentAmount
        '        AuditSingleTrans = False
        '        Exit Function
        '    End If

        '    If PtrParty.isExist(RstTransList.Fields("InvoiceNo").Value) Then
        '        nAbsolutePosition = PtrParty.ItemInvoice(RstTransList.Fields("InvoiceNo").Value).AbsolutePosition
        '        pPaymentAmount = PtrParty.ItemInvoice(RstTransList.Fields("InvoiceNo").Value).Amount
        '        ErrNature = "Duplication of Invoice No"
        '        InvoiceAmount = nInvoiceAmount
        '        PaymentAmount = nPaymentAmount
        '        AuditSingleTrans = False
        '        Exit Function
        '    End If

        '    Call PtrParty.AddInvoice((RstTransList.AbsolutePosition), RstTransList.Fields("DocumentNo").Value, RstTransList.Fields("DocumentNature").Value, RstTransList.Fields("DocumentDate").Value, RstTransList.Fields("InvoiceNo").Value, nInvoiceAmount, RstTransList.Fields("AmountUsed").Value)
        'ElseIf nPaymentAmount > 0 Then
        '    Call PtrParty.AddPayment((RstTransList.AbsolutePosition), RstTransList.Fields("DocumentNo").Value, RstTransList.Fields("DocumentNature").Value, RstTransList.Fields("DocumentDate").Value, RstTransList.Fields("InvoiceNo").Value, nPaymentAmount)
        'End If

        'AuditSingleTrans = True

    End Function

    Private Function GetRecordset(ByVal SQLQuery As String) As DataTable
        Try
            Dim OBJ As New AzamTechnologies.Database.DataAccess
            Return OBJ.ExecuteTableQuery(SQLQuery)
            OBJ = Nothing
            Exit Function
        Catch ex As SqlClient.SqlException
            MessageBox.Show(ex.Message)
        End Try
        Return Nothing
    End Function

    Private Sub ExecuteQuery(ByVal SQLQuery As String)
        Dim AWASystemName As Object
        On Error GoTo E
        Dim Updater As New AzamTechnologies.Database.DataModify
        Call Updater.UpdateExecuteQuery(SQLQuery)
        Updater = Nothing
        Exit Sub
E:
        Err.Raise(1002, "ExecuteQuery", Err.Description)
    End Sub


    Private Property Progress() As Short
        Get
            Progress = mProgress
        End Get
        Set(ByVal Value As Short)
            If Value <> mProgress Then
                mProgress = Value
                If IsAuditFound Then
                    RaiseEvent CurrentProgress(Value, System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red))
                Else
                    RaiseEvent CurrentProgress(Value, System.Drawing.ColorTranslator.ToOle(System.Drawing.SystemColors.ActiveCaption))
                End If
            End If
        End Set
    End Property

    Private Function GenrateResultset() As DataTable
        Dim Rs As New DataTable


        Rs.Columns.Add("ErrorNature")
        Rs.Columns.Add("DocumentDate")
        Rs.Columns.Add("DocumentNatureCode")
        Rs.Columns.Add("DocumentNature")
        Rs.Columns.Add("DisplayNode")
        Rs.Columns.Add("IsPaymentVoucher")
        Rs.Columns.Add("DocumentNo")
        Rs.Columns.Add("SysBranchCode")
        Rs.Columns.Add("BranchCode")
        Rs.Columns.Add("Branch")
        Rs.Columns.Add("SysPartyCode")
        Rs.Columns.Add("PartyCode")
        Rs.Columns.Add("Party")
        Rs.Columns.Add("InvoiceNo")

        Rs.Columns.Add("InvoiceAmount")
        Rs.Columns.Add("PaymentAmount")
        'Rs.Open()

        GenrateResultset = Rs
    End Function

    'Private Sub PushAuditResultset(RsResult As SqlClient.SqlDatareader, TransList As SqlClient.SqlDatareader, ErrNature As String, InvoiceAmount As Double, PaymentAmount As Double)
    Private Sub PushAuditResultset(ByRef RsResult As DataTable, ByRef TransList As DataTable, ByVal rowPos As Integer)
        IsAuditFound = True

        Dim row As DataRow
        row = RsResult.NewRow

        row.Item("ErroNature") = TransList.Rows(rowPos).Item("ErrorDesc")
        row.Item("ErrorNature") = TransList.Rows(rowPos).Item("ErrorDesc")
        row.Item("DocumentDate") = TransList.Rows(rowPos).Item("VoucherDate")
        row.Item("DocumentNatureCode") = TransList.Rows(rowPos).Item("SysNatureCode")
        row.Item("DocumentNature") = TransList.Rows(rowPos).Item("NatureCode")
        row.Item("IsPaymentVoucher") = TransList.Rows(rowPos).Item("IsPaymentVoucher")
        row.Item("DisplayNode") = TransList.Rows(rowPos).Item("DisplayNode")
        row.Item("DocumentNo") = TransList.Rows(rowPos).Item("VoucherNo")
        row.Item("SysBranchCode") = TransList.Rows(rowPos).Item("SysBranchCode")
        row.Item("BranchCode") = TransList.Rows(rowPos).Item("BranchCode")
        row.Item("Branch") = TransList.Rows(rowPos).Item("Branch")
        row.Item("SysPartyCode") = TransList.Rows(rowPos).Item("SysGLCode")
        row.Item("PartyCode") = TransList.Rows(rowPos).Item("GLCode")
        row.Item("Party") = TransList.Rows(rowPos).Item("GLDescription")
        row.Item("InvoiceNo") = TransList.Rows(rowPos).Item("Reference")


        'If Left(TransList!GLCode, Len(DebitorsCode)) = DebitorsCode Then
        '    If TransList.Rows(rowPos).Item("Debit") > 0 Then
        '        ' Invoice
        '        nInvoiceAmount = TransList.Rows(rowPos).Item("Debit")
        '        nPaymentAmount = 0
        '    Else
        '        ' Payment
        '        nInvoiceAmount = TransList.Rows(rowPos).Item("InvoiceAmount")
        '        nPaymentAmount = TransList.Rows(rowPos).Item("Credit")
        '    End If
        'ElseIf Left(TransList!GLCode, Len(CreditorsCode)) = CreditorsCode Then
        '    If TransList.Rows(rowPos).Item("Credit") > 0 Then
        '        ' Invoice
        '        nInvoiceAmount = TransList.Rows(rowPos).Item("Credit")
        '        nPaymentAmount = 0
        '    Else
        '        ' Payment
        '        nInvoiceAmount = TransList.Rows(rowPos).Item("InvoiceAmount")
        '        nPaymentAmount = TransList.Rows(rowPos).Item("Debit")
        '    End If
        'Else
        '    Err.Raise "1001", "Process Single Trans", "Invalid Party Code " & TransList!GLCode
        'End If ' [ END OF If RstTransList!PartyType = Debitors Then ]

        row.Item("InvoiceAmount") = TransList.Rows(rowPos).Item("InvoiceAmount")
        row.Item("PaymentAmount") = TransList.Rows(rowPos).Item("PaymentAmount")
        row.AcceptChanges()

    End Sub
    Public Sub New()
        MyBase.New()
    End Sub
End Class