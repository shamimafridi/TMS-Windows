Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class clsGLPosting
	
	Private PtrBranchs As clsGLPostingBranchs
	Private Const DateFormat As String = "MM/dd/yyyy"
	Private Const MTSClassName As String = "AWA_DataAccess.ClsConnection"
	
    Private Shared DebitorsCode As String
    Private Shared CreditorsCode As String
	
	'Private Const StartParameter As String = ""
	'Private Const EndParameter   As String = "ÿ"
	
    Private Const sp_PostingGet As String = "SelectPosting"
    Private Const sp_PostingUpdate As String = "UpdatePosting"
	
	Private MTSServerName As String
	Private mProgress As Short
	
	Private nActionCurrent As String
	
	Private Const nActionGenPayment As String = "GEN_PAYMENT"
	Private Const nActionUpdatePayment As String = "UPDATE_PAYMENT"
	Private Const nActionUpdateBalances As String = "UPDATE_BAL"
	Private Const nActionUpdateFlag As String = "UPDATE_FLAG"
	
    Public Event CurrentProgress(ByRef Value As Short, ByRef FillColor As Integer, ByRef Action As String)
    Public Sub Posting(ByRef PostingDate As Date)
  
        Dim TotalRecord As Integer

        Try

            DebitorsCode = My.Settings.Debtors
            CreditorsCode = My.Settings.Creditors

            ' [START] Posting Detail Trans
            nActionCurrent = ActionGenPayment
            TotalRecord = PostingTrans(PostingDate, 0, 100)
            ' [END]  Saving Trans Data

            ' [START] Saving Trans Data
            nActionCurrent = ActionUpdatePayment
            Call SavingTransData(TotalRecord, 0, 100)
            ' [END]  Saving Trans Data



            'MAKMAK
            ' Execute Post Flag Query
            ' [START] Posting of Master Transaction
            nActionCurrent = ActionUpdateFlag
            Progress = 25
            Call PostingMasterTrans(PostingDate)
            Progress = 100
            ' [END]  Posting of Master Transaction

            '
            ' [START] Genrating Closing Voucher
            Call GenrateClosingVoucher(PostingDate, 0, 100)
            ' [END]  Genrating Closing Voucher
            '
            Dim Rst As SqlClient.SqlDataReader
            Dim LastPDate As Date

            Dim objAcc As New AzamTechnologies.Database.DataAccess
            Rst = objAcc.GetRecord(sp_PostingGet, "nType", 1)

            If Rst.HasRows Then
                Rst.Read()
                LastPDate = IIf(IsDBNull(Rst.Item("ClosingDate")), 0, Rst.Item("ClosingDate"))
            Else
                LastPDate = CDate(My.Settings.CurrentYearStartDate)
            End If
            objAcc = Nothing
            ' [START] Genrating Opening Balance
            'Call GenrateOpeningBalance(PostingDate, 80, 19)
            nActionCurrent = ActionUpdateBalances
            Progress = 25
            Call GenrateOpeningBalance(LastPDate, 0, 100)
            Progress = 100
            ' [END]  Genrating Opening Balance

            Exit Sub
        Catch ex As ExecutionEngineException
            MessageBox.Show("The Following exception has occured during processing..." & vbCrLf & Err.Number & vbTab & ex.Message, "Code : Posting ")
        End Try
    End Sub

    Public Sub Unposting(ByRef UnpostingDate As Date, ByRef ToDocDate As Date, ByRef StationCode As String, ByRef FromDocNo As String, ByRef ToDocNo As String, ByRef DocNature As String)

        Try

            'If FromDocNo = "" Then FromDocNo = StartParameter
            'If ToDocNo = "" Then ToDocNo = EndParameter

            'If DocNature = "" Then
            '    Err.Raise 1001, "Unposting", "You must select at least one Transaction Nature"
            'End If

            ' [START] Posting Detail Trans
            nActionCurrent = ActionGenPayment
            Progress = 25
            Call UnpostingTrans(UnpostingDate)
            Progress = 100
            ' [END]  Saving Trans Data

            ' Execute Post Flag Query
            ' [START] Posting of Master Transaction
            nActionCurrent = ActionUpdateFlag
            Progress = 25
            Call UnpostingMasterTrans(UnpostingDate)
            Progress = 50
            ' [END]  Posting of Master Transaction


            ' [START] Genrating Closing Voucher
            Call GenrateClosingVoucher(DateAdd(DateInterval.Day, -1, UnpostingDate), 0, 100)
            ' [END]  Genrating Closing Voucher



            ' Execute Lock Flag Query
            ' [START] Unlocking of Master Transaction
            Call UnlockMasterTrans(UnpostingDate, ToDocDate, StationCode, FromDocNo, ToDocNo, DocNature)
            Progress = 100
            ' [END]  Posting of Master Transaction

            Dim Rst As SqlClient.SqlDataReader
            Dim LastPDate As Date
            Dim objAcc As New AzamTechnologies.Database.DataAccess
            Rst = objAcc.GetRecord(sp_PostingGet, "nType", 1)

            If Rst.HasRows Then
                Rst.Read()
                LastPDate = IIf(IsDBNull(Rst.Item("ClosingDate")), My.Settings.CurrentYearStartDate, Rst.Item("ClosingDate"))
            Else
                LastPDate = CDate(My.Settings.CurrentYearStartDate)
            End If
            objAcc = Nothing

            ' [START] Genrating Opening Balance
            'Call GenrateOpeningBalance(UnpostingDate - 1, 60, 29)
            nActionCurrent = ActionUpdateBalances
            Progress = 25
            Call GenrateOpeningBalance(LastPDate, 0, 100)
            Progress = 100
            ' [END]  Genrating Opening Balance

            Exit Sub
        Catch ex As Exception
            MessageBox.Show("The Following exception has occured during processing..." & vbCrLf & Err.Number & vbTab & ex.Message)
        End Try
    End Sub

    Private Function ProcessSingleTrans(ByRef RstTransList As SqlClient.SqlDatareader) As Short

        Dim nPaymentAmount As Double
        Dim nInvoiceAmount As Double
        Dim PtrBranch As clsGLPostingBranch
        Dim PtrParty As clsGLPostingParty

        PtrBranch = PtrBranchs.AddBranch(RstTransList.Item("BranchCode"))
        PtrParty = PtrBranch.AddParty(RstTransList.Item("SysGLCode"))

        If Left(RstTransList.Item("GLCode"), Len(DebitorsCode)) = DebitorsCode Then
            If RstTransList.Item("Debit") > 0 Then
                ' Invoice
                nInvoiceAmount = RstTransList.Item("Debit")
                nPaymentAmount = 0
            Else
                ' Payment
                nInvoiceAmount = 0
                nPaymentAmount = RstTransList.Item("Credit")
            End If
        ElseIf Left(RstTransList.Item("GLCode"), Len(CreditorsCode)) = CreditorsCode Then
            If RstTransList.Item("Credit") > 0 Then
                ' Invoice
                nInvoiceAmount = RstTransList.Item("Credit")
                nPaymentAmount = 0
            Else
                ' Payment
                nInvoiceAmount = 0
                nPaymentAmount = RstTransList.Item("Debit")
            End If
        Else
            Err.Raise(CInt("1001"), "Process Single Trans", "Invalid Party Code " & RstTransList.Item("GLCode"))
        End If ' [ END OF If RstTransList!PartyType = Debitors Then ]

        If nInvoiceAmount > 0 Then
            ProcessSingleTrans = 1
            Call PtrParty.AddInvoice(RstTransList.Item("VoucherNo"), RstTransList.Item("VoucherNature"), RstTransList.Item("VoucherDate"), RstTransList.Item("Reference"), nInvoiceAmount, RstTransList.Item("AmountUsed"))
        ElseIf nPaymentAmount > 0 Then
            Call PtrParty.AddPayment(RstTransList.Item("VoucherNo"), RstTransList.Item("VoucherNature"), RstTransList.Item("VoucherDate"), RstTransList.Item("Reference"), nPaymentAmount, RstTransList.Item("AmountUsed"))
        End If

    End Function

    Private Sub PostingMasterTrans(ByRef PostingDate As Date)
        Dim SQLQuery As String

        SQLQuery = "EXECUTE " & sp_PostingUpdate & " @nType = 3,@PostingDate = '" & Format(PostingDate, DateFormat) & "'"
        Call ExecuteQuery(SQLQuery)

    End Sub

    Private Sub UnpostingMasterTrans(ByRef UnpostingDate As Date)
        Dim SQLQuery As String

        SQLQuery = "EXECUTE " & sp_PostingUpdate & " @nType = 4,@PostingDate = '" & Format(UnpostingDate, DateFormat) & "'"
        Call ExecuteQuery(SQLQuery)

    End Sub

    Private Sub UnlockMasterTrans(ByRef UnpostingDate As Date, ByRef ToDate As Date, ByRef StationCode As String, ByRef FromDocNo As String, ByRef ToDocNo As String, ByRef TransactionType As String)
        Dim SQLQuery As String


        SQLQuery = "EXECUTE " & sp_PostingUpdate & " @nType = 8" _
                & ",@BranchCode = '" & StationCode _
                & ",@PostingDate = '" & Format(UnpostingDate, DateFormat) & "'" _
                & ",@ToDate = '" & Format(ToDate, DateFormat) & "'" _
                & ",@FromDocNo = '" & FromDocNo & "'" _
                & ",@ToDocNo = '" & ToDocNo & "'" _
                & ",@TransactionType = '" & TransactionType & "'"

        '  Call ExecuteQuery(SQLQuery) UNLOCK PROCESS IS NOT NECCESSORY IN OR PROJECT AND HAVE SOME BUG IN NTYPE 8

    End Sub

    Private Sub UnpostingTrans(ByRef UnpostingDate As Date)
        Dim SQLQuery As String

        SQLQuery = "EXECUTE " & sp_PostingUpdate & " @nType = 6,@PostingDate = '" & Format(UnpostingDate, DateFormat) & "'"
        Call ExecuteQuery(SQLQuery)

    End Sub

    Private Sub SavingTransData(ByRef TotalRecord As Integer, ByRef ProgressStart As Short, ByRef ProgressMargin As Short)

        Dim QryBuffer As String = String.Empty
        Dim ExeCounter As Short
        Const ExeCount As Short = 50

        Dim BranchIndex As Integer
        Dim PartyIndex As Integer
        Dim InvoiceIndex As Integer
        Dim InvoiceDetailIndex As Integer
        Dim NoOfRecordProcessed As Integer
        Dim SQLQuery As String

        Dim BranchCode As String
        Dim DocumentNature As String
        Dim DocumentNo As String
        Dim DocumentDate As Date
        Dim GLCode As String
        Dim BillNo As String

        NoOfRecordProcessed = 0

        For BranchIndex = 1 To PtrBranchs.Count
            BranchCode = PtrBranchs.ItemIndex(BranchIndex).BranchCode
            For PartyIndex = 1 To PtrBranchs.ItemIndex(BranchIndex).Count

                GLCode = PtrBranchs.ItemIndex(BranchIndex).ItemIndex(PartyIndex).PartyCode

                For InvoiceIndex = 1 To PtrBranchs.ItemIndex(BranchIndex).ItemIndex(PartyIndex).Count

                    With PtrBranchs.ItemIndex(BranchIndex).ItemIndex(PartyIndex).ItemIndex(InvoiceIndex)

                        BillNo = .InvoiceNo
                        DocumentNo = .DocumentNo
                        DocumentNature = .DocumentNature
                        DocumentDate = .DocumentDate

                    End With

                    For InvoiceDetailIndex = 1 To PtrBranchs.ItemIndex(BranchIndex).ItemIndex(PartyIndex).ItemIndex(InvoiceIndex).Count

                        ' Input into Detail Trans Used
                        With PtrBranchs.ItemIndex(BranchIndex).ItemIndex(PartyIndex).ItemIndex(InvoiceIndex).Item(InvoiceDetailIndex)

                            SQLQuery = "EXECUTE " & sp_PostingUpdate & " @BranchCode = " & BranchCode & ",@VoucherNature = " & DocumentNature & ",@VoucherNo = '" & DocumentNo & "'" & ",@VoucherDate = '" & Format(DocumentDate, DateFormat) & "'" & ",@GLCode = " & GLCode & ",@BillNo = '" & BillNo & "'" & ",@RefVoucherNo = '" & .RefDocumentNo & "'" & ",@RefVoucherNature = '" & .RefDocumentNature & "'" & ",@RefVoucherDate = '" & Format(.RefDocumentDate, DateFormat) & "'" & ",@RefBillNo = '" & .RefInvoiceNo & "'" & ",@AmountUsed = " & .AmountUsed & ",@nType = 2"

                        End With

                        'Call ExecuteQuery(SQLQuery)
                        'New Code
                        ExeCounter = ExeCounter + 1
                        QryBuffer = QryBuffer & IIf(QryBuffer = "", "", ";") & SQLQuery

                        If QryBuffer <> "" And ExeCounter > ExeCount Then
                            Call ExecuteQuery(QryBuffer)
                            QryBuffer = ""
                            ExeCounter = 0
                        End If
                    Next InvoiceDetailIndex

                    '###############
                    NoOfRecordProcessed = NoOfRecordProcessed + 1
                    Progress = ProgressStart + (NoOfRecordProcessed * ProgressMargin / TotalRecord)
                    '###############

                Next InvoiceIndex
            Next PartyIndex
        Next BranchIndex

        If QryBuffer <> "" Then
            Call ExecuteQuery(QryBuffer)
            QryBuffer = ""
            ExeCounter = 0
        End If

    End Sub

    Private Function PostingTrans(ByRef PostingDate As Date, ByRef ProgressStart As Short, ByRef ProgressMargin As Short) As Integer

        Dim RstTransList As SqlClient.SqlDataReader

        Dim NoOfRecordProcessed As Integer
        Dim TotalRecord As Integer

        PtrBranchs = New clsGLPostingBranchs

        RstTransList = GetRecordset("EXECUTE " & sp_PostingGet & " @nType = 2,@PostingDate = '" & Format(PostingDate, DateFormat) & "', @Creditors='" & My.Settings.Creditors & "',@Debitors='" & My.Settings.Debtors & "'")
        RstTransList = GetRecordset("EXECUTE " & sp_PostingGet & " @nType = 3,@PostingDate = '" & Format(PostingDate, DateFormat) & "', @Creditors='" & My.Settings.Creditors & "',@Debitors='" & My.Settings.Debtors & "'")

        '###############
        Progress = ProgressStart + 5
        '###############

        Dim BranchIndex As Integer
        Dim PartyIndex As Integer
        If RstTransList.HasRows Then

            TotalRecord = RstTransList.RecordsAffected

            Do While RstTransList.Read
                PostingTrans = PostingTrans + ProcessSingleTrans(RstTransList)
                NoOfRecordProcessed = NoOfRecordProcessed + 1
                '###############
                Progress = (ProgressStart + 5) + (NoOfRecordProcessed * (ProgressMargin - 5) / TotalRecord)
                '###############
            Loop
            For BranchIndex = 1 To PtrBranchs.Count
                For PartyIndex = 1 To PtrBranchs.ItemIndex(BranchIndex).Count

                    With PtrBranchs.ItemIndex(BranchIndex).ItemIndex(PartyIndex)
                        'If .PartyBalance < .PartyPaymentBalance Then
                        '    Err.Raise 1001, "Saving Trans", "Payment of Party is greater than invoice amount"
                        'Else
                        Call .AdjustPendingPayments()
                        'End If
                    End With

                Next PartyIndex
            Next BranchIndex

        End If

    End Function

    Private Function GetRecordset(ByVal SQLQuery As String) As SqlClient.SqlDataReader

        Try
            Dim GetReader As New AzamTechnologies.Database.DataAccess
            Dim Rs As SqlClient.SqlDataReader = Nothing
            'UPGRADE_WARNING: Couldn't resolve default property of object OBJ.GetRecordset. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Rs = GetReader.ExecuteStringQuery(SQLQuery)
            Return Rs
            Exit Function
        Catch EX As SqlClient.SqlException
            MessageBox.Show(EX.Message)
        End Try
        Return Nothing
    End Function

    Private Sub ExecuteQuery(ByVal SQLQuery As String)

        Try
            Dim RecModify As New AzamTechnologies.Database.DataModify
            'UPGRADE_WARNING: Couldn't resolve default property of object OBJ.ExecuteQuery. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Call RecModify.UpdateExecuteQuery(SQLQuery)
            RecModify = Nothing
            Exit Sub
        Catch ex As SqlClient.SqlException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
        End Try
    End Sub


    Private Property Progress() As Short
        Get
            Progress = mProgress
        End Get
        Set(ByVal Value As Short)
            If Value <> mProgress Then
                mProgress = Value
                'RaiseEvent CurrentProgress(NewValue)
                RaiseEvent CurrentProgress(Value, System.Drawing.ColorTranslator.ToOle(System.Drawing.SystemColors.ActiveCaption), nActionCurrent)
            End If
        End Set
    End Property

    Public ReadOnly Property ActionGenPayment() As String
        Get
            ActionGenPayment = nActionGenPayment
        End Get
    End Property

    Public ReadOnly Property ActionUpdatePayment() As String
        Get
            ActionUpdatePayment = nActionUpdatePayment
        End Get
    End Property

    Public ReadOnly Property ActionUpdateBalances() As String
        Get
            ActionUpdateBalances = nActionUpdateBalances
        End Get
    End Property

    Public ReadOnly Property ActionUpdateFlag() As String
        Get
            ActionUpdateFlag = nActionUpdateFlag
        End Get
    End Property


    'Public Function AuditingTrans(AuditDate As Date) As SqlClient.SqlDatareader
    '
    'Dim RstTransList        As SqlClient.SqlDatareader
    'Dim ResultSet           As SqlClient.SqlDatareader
    'Dim NoOfRecordProcessed As Long
    'Dim TotalRecord         As Long
    'Dim AvailableQuantity   As Double
    'Dim ErrorNature         As String
    'Dim Quantity            As Double
    ''###############
    'Progress = 5
    ''###############
    '
    'Set RstTransList = GetRecordset("EXECUTE MM_GetPostingSP @nType = 5,@PostingDate = '" & Format(AuditDate, DateFormat) & "'")
    '
    ''###############
    'Progress = 10
    ''###############
    '
    'If RstTransList.RecordCount > 0 Then
    '    Set ResultSet = GenrateResultset()
    '    Do
    '        If AuditSingleTrans(RstTransList, Quantity, ErrorNature, AvailableQuantity) Then
    '            Call PushAuditResultset(ResultSet, RstTransList, Quantity, ErrorNature, AvailableQuantity)
    '        End If
    '
    '        Progress = 10 + (RstTransList.AbsolutePosition * 89 / RstTransList.RecordCount)
    '        RstTransList.MoveNext
    '    Loop Until RstTransList.EOF
    '    'CreateFieldDefFile RstTransList, App.Path & "\Reports\AuditItemOrderLedger.ttx", 1
    '    'nReportViewer.ShowReport RstTransList, Report_AuditItemOrderLedger, ShowtoWindow, "Audit Date: " & Format(AuditDate, "dd MMM yyyy")
    'End If
    'Set AuditingTrans = ResultSet
    '
    ''###############
    'Progress = 100
    ''###############
    '
    'End Function
    '
    'Private Function GenrateResultset() As SqlClient.SqlDatareader
    'Dim Rs As New SqlClient.SqlDatareader
    '
    'Rs.Fields.Append "ErrorNature", adVarChar, 20
    'Rs.Fields.Append "DocumentDate", adDate
    'Rs.Fields.Append "DocumentNature", adInteger
    'Rs.Fields.Append "DocumentNo", adVarChar, 10
    'Rs.Fields.Append "StationCode", adVarChar, 10
    'Rs.Fields.Append "Station", adVarChar, 50
    'Rs.Fields.Append "PartyCode", adVarChar, 10
    'Rs.Fields.Append "Party", adVarChar, 50
    'Rs.Fields.Append "PONumber", adVarChar, 10
    'Rs.Fields.Append "ItemCode", adVarChar, 10
    'Rs.Fields.Append "Item", adVarChar, 50
    'Rs.Fields.Append "Quantity", adDecimal
    'Rs.Fields.Append "AvailableQuantity", adDecimal
    'Rs.Open
    'Set GenrateResultset = Rs
    'End Function
    '
    'Private Sub PushAuditResultset(RsResult As SqlClient.SqlDatareader, TransList As SqlClient.SqlDatareader, ByVal Quantity As Double, ByVal ErrorNature As String, ByVal AvailableQuantity As Double)
    '
    'RsResult.AddNew
    'RsResult.Fields("ErrorNature") = ErrorNature
    'RsResult.Fields("DocumentDate") = TransList.Fields("TransactionDate")
    'RsResult.Fields("DocumentNature") = TransList.Fields("TransactionNature")
    'RsResult.Fields("DocumentNo") = TransList.Fields("TransactionNo")
    'RsResult.Fields("StationCode") = TransList.Fields("StationCode")
    'RsResult.Fields("Station") = TransList.Fields("Station")
    'RsResult.Fields("PartyCode") = TransList.Fields("PartyCode")
    ''RsResult.Fields("Party") = TransList.Fields("Party")
    'RsResult.Fields("PONumber") = TransList.Fields("PONumber")
    'RsResult.Fields("ItemCode") = TransList.Fields("ItemCode")
    'RsResult.Fields("Item") = TransList.Fields("Item")
    'RsResult.Fields("Quantity") = Quantity
    'RsResult.Fields("AvailableQuantity") = AvailableQuantity
    'RsResult.Update
    '
    'End Sub
    '
    'Private Function AuditSingleTrans(RstTransList As SqlClient.SqlDatareader, ByRef Quantity As Double, ByRef ErrorNature As String, ByRef AvailableQuantity As Double) As Boolean
    '    AuditSingleTrans = True
    '    ErrorNature = "PO"
    '    Quantity = 20
    '    AvailableQuantity = 100
    'End Function

    Private Sub GenrateOpeningBalance(ByRef PostingDate As Date, ByRef ProgressStart As Short, ByRef ProgressMargin As Short)
        Dim SQLQuery As String


        ' DELETE POSTDated Closing Balance
        SQLQuery = "EXECUTE " & sp_PostingUpdate & " @nType = 7,@PostingDate = '" & Format(PostingDate, DateFormat) & "'"
        Call ExecuteQuery(SQLQuery)
        ' Update Closing Balance
        SQLQuery = "EXECUTE " & sp_PostingUpdate & " @nType = 9,@PostingDate = '" & Format(PostingDate, DateFormat) & "'"
        Call ExecuteQuery(SQLQuery)

    End Sub

    Private Sub GenrateClosingVoucher(ByRef PostingDate As Date, ByRef ProgressStart As Short, ByRef ProgressMargin As Short)
        
        Dim SQLQuery As String
        Dim CurrentYearStartDate As Date

        Dim PDate As Date
        Dim ClosingYear As Short
        Dim ClosingMonth As Short


        CurrentYearStartDate = CDate(My.Settings.CurrentYearStartDate)

        If Month(CurrentYearStartDate) = 7 Then
            ClosingMonth = 6
            If Month(PostingDate) < 7 Then
                ClosingYear = Year(PostingDate) - 1
            Else
                ClosingYear = Year(PostingDate)
            End If
        Else
            ClosingMonth = 12
            ClosingYear = Year(PostingDate) - 1
        End If

        PDate = DateSerial(ClosingYear, ClosingMonth, 1)
        PDate = System.DateTime.FromOADate(DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, PDate).ToOADate - 1)

        If VB.Day(PostingDate) = VB.Day(PDate) And Month(PostingDate) = Month(PDate) Then
            PDate = PostingDate
        End If

        'Dim CurrentYear As Integer
        'Dim nPDate As Date
        'Dim IsMonthLastDate As Boolean
        'nPDate = PostingDate + 1
        ' CASE   30 June 2006
        '


        'IsMonthLastDate = IIf(Month(PostingDate + 1) = Month(PostingDate), False, True)
        '
        'If IsMonthLastDate Then
        '    If Month(CurrentYearStartDate) - 1 = Month(PostingDate) Then
        '        nPDate = DateSerial(Year(PostingDate) + 1, Month(CurrentYearStartDate), 1)
        '    Else
        '
        '    End If
        'Else
        '
        'End If
        'Dim nPDate As Date
        'CurrentYearStartDate = Month(CDate(GetSetupProfileValue(AWASystemName, "CurrentYearStartDate")) - 1)
        '        '30 June 2006         1 July 2006 - 1
        '
        'Select Case Month(CurrentYearStartDate)
        '    Case 1 'January
        '        If Day(PostingDate) = 31 And Month(PostingDate) = 12 Then
        '            nPDate = DateSerial(Year(PostingDate) + 1, Month(CurrentYearStartDate), 1) - 1
        '        Else
        '            nPDate = DateSerial(Year(PostingDate), Month(CurrentYearStartDate), 1) - 1
        '        End If
        '    Case Is > 1
        '        If Day(PostingDate) = 31 And Month(PostingDate) = 12 Then
        '            nPDate = DateSerial(Year(PostingDate) + 1, Month(CurrentYearStartDate), 1) - 1
        '        Else
        '            nPDate = DateSerial(Year(PostingDate), Month(CurrentYearStartDate), 1) - 1
        '        End If
        'End Select

        ' DELETE Closing Voucher
        'SQLQuery = "EXECUTE " & "GL_UpdatePostingSP" & " @nType = 11,@PostingDate = '" & Format(PDate, DateFormat) & "'"
        'Call ExecuteQuery(SQLQuery)
        ' Update Closing Balance
        SQLQuery = "EXECUTE " & sp_PostingUpdate & " @nType = 10,@PostingDate = '" & Format(PDate, DateFormat) & "'"
        Call ExecuteQuery(SQLQuery)

    End Sub
End Class