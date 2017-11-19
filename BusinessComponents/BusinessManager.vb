Option Explicit On
Imports System.Data.SqlClient
'Imports System.EnterpriseServices
' <Transaction(TransactionOption.RequiresNew), ObjectPooling(True, 5, 10), ComClass(DataModify.ClassId, DataModify.InterfaceId, DataModify.EventsId)> _

Public Class BusinessManager
    '        Inherits ServicedComponent
    '#Region "COM GUIDs"
    '        ' These  GUIDs provide the COM identity for this class 
    '        ' and its COM interfaces. If you change them, existing 
    '        ' clients will no longer be able to access the class.
    '        Public Const ClassId As String = "D74F2167-3EF1-4E28-9439-8CA3B6EB51BE"
    '        Public Const InterfaceId As String = "D232CFA7-E581-4D41-B2F6-3C3E72B7BCBD"
    '        Public Const EventsId As String = "760FF3E3-56FC-471A-AD3A-19E64DCB396E"
    '#End Region
    '        ' A creatable COM class must have a Public Sub New() 
    '        ' with no parameters, otherwise, the class will not be 
    '        ' registered in the COM registry and cannot be created 
    '        ' via CreateObject.
    '        Public Sub New()
    '            MyBase.New()
    '        End Sub
    Const SaleVoucherNature As String = "SV"
    Const JournalVoucherNature As String = "JV"
    Const BankReceiptsVoucherNature As String = "BR"
    Const CashReceiptsVoucherNature As String = "CR"

    Const BankPaymentVoucherNature As String = "BP"
    Const CashPaymentVoucherNature As String = "CP"

    Const ReceiptsTransactionNature As String = "REC"
    Const SaleTransactionNature As String = "INV"
    Const GeneratedFromModuleName As String = "TMS"

    Const VehicleAdjustmentReceiptNature As String = "AR"
    Const VehicleAdjustmentPaymentNature As String = "AP"
    Const VehicleReceiptNature As String = "VR"
    Const VehiclePaymentNature As String = "VP"
    Dim IsVoucherCancelled As Boolean

    Dim DocumentNo As String
    Private m_GeneratedToVoucherNature As String
    Private m_GeneratedFromNature As String
    Private m_FromGeneratedData As DataSet
    Private m_FromGeneratedDetailData As DataSet
    Dim DataModify As AzamTechnologies.Database.DataModify
    Dim Query As String = String.Empty
    Dim SaveMode As AzamTechnologies.Database.DataModify.UpdateMode
    Sub GenerateVoucher(ByRef FromGeneratedData As DataSet, ByVal FromGeneratedDetailData As DataSet, ByVal FromGeneratedNature As String, ByVal GeneratedToVoucherNature As String)
        m_GeneratedToVoucherNature = GeneratedToVoucherNature
        m_GeneratedFromNature = FromGeneratedNature
        m_FromGeneratedData = FromGeneratedData
        m_FromGeneratedDetailData = FromGeneratedDetailData
        DataModify = New AzamTechnologies.Database.DataModify


        Dim dsSVMaster As DataSet = Nothing
        Dim dsSVDetail As DataSet = Nothing
        Dim NewRecord As Boolean = True

        If m_GeneratedFromNature = VehiclePaymentNature Or m_GeneratedFromNature = VehicleReceiptNature Then
            If Trim(FromGeneratedData.Tables(0).Rows(0).Item("Mode")) = "Cash" Then
                m_GeneratedFromNature = FromGeneratedData.Tables(0).Rows(0).Item("TransactionNature")
                If m_GeneratedFromNature = VehicleAdjustmentPaymentNature Or m_GeneratedFromNature = VehicleAdjustmentReceiptNature Then m_GeneratedToVoucherNature = JournalVoucherNature : GoTo ad
                If m_GeneratedFromNature = VehicleReceiptNature Then
                    m_GeneratedToVoucherNature = BankReceiptsVoucherNature
                ElseIf m_GeneratedFromNature = VehiclePaymentNature Then
                    m_GeneratedToVoucherNature = BankPaymentVoucherNature
                End If ''For first removing BR and BP

                DocumentNo = CheckReference() 'If already in Cheque mode so first delete the bank payment of it's reference
                If DocumentNo <> String.Empty Then
                    Query = "EXECUTE DeleteVouchers  @BranchCode='" & FromGeneratedData.Tables(0).Rows(0).Item("BranchCode") & _
                            "' ,@TransactionNature='" & m_GeneratedToVoucherNature & _
                            "' ,@TransactionNo='" & DocumentNo & "'"
                    If DataModify.UpdateExecuteQuery(Query) <> 0 Then
                        Query = "EXECUTE DeleteGeneratedReferences  @GenFrom='" & GeneratedFromModuleName & _
                      "' ,@FormName='" & m_FromGeneratedData.DataSetName & _
                      "' ,@TransactionNature='" & m_GeneratedFromNature & _
                      "' ,@TransactionNo='" & FromGeneratedData.Tables(0).Rows(0).Item("TransactionNo") & _
                      "' ,@BranchCode='" & FromGeneratedData.Tables(0).Rows(0).Item("BranchCode") & _
                      "' ,@DocumentNature='" & m_GeneratedToVoucherNature & _
                      "' ,@DocumentNo='" & DocumentNo & "'"
                        DataModify.UpdateExecuteQuery(Query)
                        'DataModify = Nothing
                    End If
                    'NewRecord = False
                    'GetNextVoucherNo()
                End If
                If m_GeneratedFromNature = VehicleReceiptNature Then
                    m_GeneratedToVoucherNature = CashReceiptsVoucherNature
                ElseIf m_GeneratedFromNature = VehiclePaymentNature Then
                    m_GeneratedToVoucherNature = CashPaymentVoucherNature
                End If 'Then setting the original natures
            Else
                ''If already in Cash mode so first delete the cash payment of it's reference
                m_GeneratedFromNature = FromGeneratedData.Tables(0).Rows(0).Item("TransactionNature")
                If m_GeneratedFromNature = VehicleReceiptNature Then
                    m_GeneratedToVoucherNature = CashReceiptsVoucherNature
                ElseIf m_GeneratedFromNature = VehiclePaymentNature Then
                    m_GeneratedToVoucherNature = CashPaymentVoucherNature
                End If ''For first removing BP and CP

                DocumentNo = CheckReference() 'If already in Cheque mode so first delete the bank payment of it's reference
                If DocumentNo <> String.Empty Then
                    Query = "EXECUTE DeleteVouchers  @BranchCode='" & FromGeneratedData.Tables(0).Rows(0).Item("BranchCode") & _
                            "' ,@TransactionNature='" & m_GeneratedToVoucherNature & _
                            "' ,@TransactionNo='" & DocumentNo & "'"
                    If DataModify.UpdateExecuteQuery(Query) <> 0 Then
                        Query = "EXECUTE DeleteGeneratedReferences  @GenFrom='" & GeneratedFromModuleName & _
                      "' ,@FormName='" & m_FromGeneratedData.DataSetName & _
                      "' ,@TransactionNature='" & m_GeneratedFromNature & _
                      "' ,@TransactionNo='" & FromGeneratedData.Tables(0).Rows(0).Item("TransactionNo") & _
                      "' ,@BranchCode='" & FromGeneratedData.Tables(0).Rows(0).Item("BranchCode") & _
                      "' ,@DocumentNature='" & m_GeneratedToVoucherNature & _
                      "' ,@DocumentNo='" & DocumentNo & "'"
                        DataModify.UpdateExecuteQuery(Query)
                        ' DataModify = Nothing
                    End If
                    'NewRecord = False
                    'GetNextVoucherNo()
                End If

                If m_GeneratedFromNature = VehicleReceiptNature Then
                    m_GeneratedToVoucherNature = BankReceiptsVoucherNature
                ElseIf m_GeneratedFromNature = VehiclePaymentNature Then
                    m_GeneratedToVoucherNature = BankPaymentVoucherNature
                End If 'Then setting the original natures

            End If

        ElseIf m_GeneratedFromNature = VehicleAdjustmentReceiptNature Or m_GeneratedFromNature = VehicleAdjustmentPaymentNature Then
            m_GeneratedFromNature = FromGeneratedData.Tables(0).Rows(0).Item("TransactionNature")


        End If
ad:
        Try
            DocumentNo = CheckReference()
            If DocumentNo <> String.Empty Then
                Query = "EXECUTE DeleteVouchers  @BranchCode='" & FromGeneratedData.Tables(0).Rows(0).Item("BranchCode") & _
                        "' ,@TransactionNature='" & m_GeneratedToVoucherNature & _
                        "' ,@TransactionNo='" & DocumentNo & "'"

                If DataModify.UpdateExecuteQuery(Query) <> 0 Then
                End If
                NewRecord = False
                SaveMode = Database.DataModify.UpdateMode.Update
                'GetNextVoucherNo()
            Else
                NewRecord = True
                SaveMode = Database.DataModify.UpdateMode.Insert
                DocumentNo = GetNextVoucherNo()
            End If

            Select Case m_GeneratedToVoucherNature
                Case SaleVoucherNature
                    dsSVMaster = GenerateMasterSaleVouchers()
                    dsSVDetail = GenerateDetailSaleVouchers()
                    If IsVoucherCancelled = False Then
                        If DataModify.UpdateDetailData("UpdateVouchers", "UpdateVouchersDetails", "DeleteVouchersDetails", dsSVMaster, dsSVDetail, SaveMode) <> 0 Then
                            UpdateReference()
                        End If
                    End If

                Case BankReceiptsVoucherNature ' Bank receipt

                    If m_GeneratedFromNature = VehiclePaymentNature Or m_GeneratedFromNature = VehicleReceiptNature Then
                        dsSVMaster = GenerateMasterReceiptVouchers(m_GeneratedToVoucherNature)
                        dsSVDetail = GenerateDetailReceiptVouchers(m_GeneratedToVoucherNature)
                    Else
                        dsSVMaster = GenerateMasterReceiptVouchers()
                        dsSVDetail = GenerateDetailReceiptVouchers()
                    End If
                    If IsVoucherCancelled = False Then
                        If DataModify.UpdateDetailData("UpdateVouchers", "UpdateVouchersDetails", "DeleteVouchersDetails", dsSVMaster, dsSVDetail, SaveMode) <> 0 Then
                            UpdateReference()
                        End If
                    End If
                    DataModify = Nothing
                Case BankPaymentVoucherNature

                    dsSVMaster = GenerateMasterPaymentVouchers(m_GeneratedToVoucherNature)
                    dsSVDetail = GenerateDetailPaymentVouchers(m_GeneratedToVoucherNature)
                    If IsVoucherCancelled = False Then
                        If DataModify.UpdateDetailData("UpdateVouchers", "UpdateVouchersDetails", "DeleteVouchersDetails", dsSVMaster, dsSVDetail, SaveMode) <> 0 Then
                            UpdateReference()
                        End If
                    End If

                Case CashPaymentVoucherNature

                    dsSVMaster = GenerateMasterPaymentVouchers(m_GeneratedToVoucherNature)
                    dsSVDetail = GenerateDetailPaymentVouchers(m_GeneratedToVoucherNature)
                    If IsVoucherCancelled = False Then
                        If DataModify.UpdateDetailData("UpdateVouchers", "UpdateVouchersDetails", "DeleteVouchersDetails", dsSVMaster, dsSVDetail, SaveMode) <> 0 Then
                            UpdateReference()
                        End If
                    End If

                Case JournalVoucherNature
                    If m_GeneratedFromNature = VehicleAdjustmentReceiptNature Then
                        dsSVMaster = GenerateMasterReceiptVouchers(m_GeneratedToVoucherNature)
                        dsSVDetail = GenerateDetailReceiptVouchers(m_GeneratedToVoucherNature)

                    ElseIf m_GeneratedFromNature = VehicleAdjustmentPaymentNature Then
                        dsSVMaster = GenerateMasterPaymentVouchers(m_GeneratedToVoucherNature)
                        dsSVDetail = GenerateDetailPaymentVouchers(m_GeneratedToVoucherNature)
                    End If
                    If IsVoucherCancelled = False Then
                        If DataModify.UpdateDetailData("UpdateVouchers", "UpdateVouchersDetails", "DeleteVouchersDetails", dsSVMaster, dsSVDetail, SaveMode) <> 0 Then
                            UpdateReference()
                        End If
                    End If

                Case CashReceiptsVoucherNature
                    dsSVMaster = GenerateMasterReceiptVouchers(m_GeneratedToVoucherNature)
                    dsSVDetail = GenerateDetailReceiptVouchers(m_GeneratedToVoucherNature)
                    If IsVoucherCancelled = False Then
                        If DataModify.UpdateDetailData("UpdateVouchers", "UpdateVouchersDetails", "DeleteVouchersDetails", dsSVMaster, dsSVDetail, SaveMode) <> 0 Then
                            UpdateReference()
                        End If
                    End If

                Case BankReceiptsVoucherNature
                    dsSVMaster = GenerateMasterReceiptVouchers(m_GeneratedToVoucherNature)
                    dsSVDetail = GenerateDetailReceiptVouchers(m_GeneratedToVoucherNature)
                    If IsVoucherCancelled = False Then
                        If DataModify.UpdateDetailData("UpdateVouchers", "UpdateVouchersDetails", "DeleteVouchersDetails", dsSVMaster, dsSVDetail, SaveMode) <> 0 Then
                            UpdateReference()
                        End If
                    End If

            End Select
            dsSVMaster = Nothing
            dsSVDetail = Nothing
            DataModify = Nothing
            m_FromGeneratedData = Nothing
            m_FromGeneratedDetailData = Nothing


        Catch ex As SqlException
            Throw New Exception("The voucher can'nt be generated " & vbCrLf & ex.Message)
        Catch ex As Exception
            Throw New Exception("The voucher can'nt be generated " & vbCrLf & ex.Message)
        End Try
    End Sub
    Sub UpdateReference()
        Query = "EXECUTE UpdateGeneratedReferences  @GenFrom='" & GeneratedFromModuleName & _
                        "' ,@FormName='" & m_FromGeneratedData.DataSetName & _
                        "' ,@TransactionNature='" & m_GeneratedFromNature & _
                        "' ,@TransactionNo='" & m_FromGeneratedData.Tables(0).Rows(0).Item("TransactionNo") & _
                        "' ,@BranchCode='" & m_FromGeneratedData.Tables(0).Rows(0).Item("BranchCode") & _
                        "' ,@DocumentNature='" & m_GeneratedToVoucherNature & _
                        "' ,@DocumentNo='" & DocumentNo & "'"
        DataModify.UpdateExecuteQuery(Query)
    End Sub
    Sub DeleteVoucher(ByRef FromGeneratedData As DataSet, ByVal FromGeneratedDetailData As DataSet, ByVal FromGeneratedNature As String, ByVal GeneratedToVoucherNature As String)
        Dim Query As String
        m_GeneratedToVoucherNature = GeneratedToVoucherNature
        m_GeneratedFromNature = FromGeneratedNature
        m_FromGeneratedData = FromGeneratedData
        m_FromGeneratedDetailData = FromGeneratedDetailData
        Dim DataModify As New AzamTechnologies.Database.DataModify

        If m_GeneratedFromNature = VehiclePaymentNature Or m_GeneratedFromNature = VehicleReceiptNature Then
            If Trim(FromGeneratedData.Tables(0).Rows(0).Item("Mode")) = "Cash" Then
                m_GeneratedFromNature = FromGeneratedData.Tables(0).Rows(0).Item("TransactionNature")
                If m_GeneratedFromNature = VehicleAdjustmentPaymentNature Or m_GeneratedFromNature = VehicleAdjustmentReceiptNature Then m_GeneratedToVoucherNature = JournalVoucherNature : GoTo ad
                If m_GeneratedFromNature = VehicleReceiptNature Then
                    m_GeneratedToVoucherNature = CashReceiptsVoucherNature
                ElseIf m_GeneratedFromNature = VehiclePaymentNature Then
                    m_GeneratedToVoucherNature = CashPaymentVoucherNature
                End If ''For first removing BR and BP
            ElseIf Trim(FromGeneratedData.Tables(0).Rows(0).Item("Mode")) = "Cheque" Then
                m_GeneratedFromNature = FromGeneratedData.Tables(0).Rows(0).Item("TransactionNature")
                If m_GeneratedFromNature = VehicleReceiptNature Then
                    m_GeneratedToVoucherNature = BankReceiptsVoucherNature
                ElseIf m_GeneratedFromNature = VehiclePaymentNature Then
                    m_GeneratedToVoucherNature = BankPaymentVoucherNature
                End If ''For first removing BR and BP
            End If
        ElseIf m_GeneratedFromNature = VehicleAdjustmentPaymentNature Or m_GeneratedFromNature = VehicleAdjustmentReceiptNature Then
            m_GeneratedFromNature = FromGeneratedData.Tables(0).Rows(0).Item("TransactionNature")
            m_GeneratedToVoucherNature = JournalVoucherNature
        End If

ad:
        Try
            DocumentNo = CheckReference()
            If DocumentNo <> String.Empty Then
                Query = "EXECUTE DeleteVouchers  @BranchCode='" & FromGeneratedData.Tables(0).Rows(0).Item("BranchCode") & _
                        "' ,@TransactionNature='" & m_GeneratedToVoucherNature & _
                        "' ,@TransactionNo='" & DocumentNo & "'"

                If DataModify.UpdateExecuteQuery(Query) <> 0 Then
                    '    Query = "EXECUTE DeleteGeneratedReferences  @GenFrom='" & GeneratedFromModuleName & _
                    '      "' ,@FormName='" & m_FromGeneratedData.DataSetName & _
                    '      "' ,@TransactionNature='" & m_GeneratedFromNature & _
                    '      "' ,@TransactionNo='" & FromGeneratedData.Tables(0).Rows(0).Item("TransactionNo") & _
                    '      "' ,@BranchCode='" & FromGeneratedData.Tables(0).Rows(0).Item("BranchCode") & _
                    '      "' ,@DocumentNature='" & m_GeneratedToVoucherNature & _
                    '      "' ,@DocumentNo='" & DocumentNo & "'"
                    '    DataModify.UpdateExecuteQuery(Query)
                    '    DataModify = Nothing
                    'Else
                    DataModify = Nothing
                End If
            End If



        Catch ex As SqlException
            Throw New Exception("The voucher can'nt  Deleted " & vbCrLf & ex.Message)
        Catch ex As Exception
            Throw New Exception("The voucher can'nt be Deleted" & vbCrLf & ex.Message)
        End Try
    End Sub
    Function GetNextVoucherNo() As String
        Dim TransDate As Date
        If m_GeneratedFromNature = SaleTransactionNature Or m_GeneratedFromNature = VehicleAdjustmentReceiptNature Or m_GeneratedFromNature = VehicleAdjustmentPaymentNature Then
            TransDate = m_FromGeneratedData.Tables(0).Rows(0).Item("TransactionDate")
        ElseIf m_GeneratedFromNature = ReceiptsTransactionNature Then
            TransDate = m_FromGeneratedData.Tables(0).Rows(0).Item("ReceiptDate")
        ElseIf m_GeneratedFromNature = VehicleReceiptNature Or m_GeneratedFromNature = VehiclePaymentNature Then
            TransDate = m_FromGeneratedData.Tables(0).Rows(0).Item("TransactionDate")
        Else
            Throw New Exception("Transaction Date must be Provided for Nature " & m_GeneratedFromNature & Chr(10) & "Provided Date are ReceiptDate & Sale Voucehr Date")
        End If

        TransDate = CDate(Format(TransDate, MySettingReader.Read("DateFormat", MySettingReader.FieldLevel.ApplicationLevel)))
        Dim dt As New AzamTechnologies.Database.DataAccess
        Dim Reader As SqlDataReader
        Reader = dt.GetRecord("SelectVouchers", "BranchCode", m_FromGeneratedData.Tables(0).Rows(0).Item("BranchCode"), "TransactionNature", Me.m_GeneratedToVoucherNature, "Option", "AUTO", "YearMonth", Format(TransDate, "yy") & Format(TransDate, "MM"))
        If Reader.HasRows Then
            While Reader.Read
                DocumentNo = Reader.Item("TransactionNo")
                DocumentNo = Integer.Parse(DocumentNo) + 1
                If Mid(DocumentNo.Insert(0, "0"), 1, 2) = "09" Then
                    DocumentNo = DocumentNo.Insert(0, "0")
                    ' chCtr.Text = mManager.FormateData.FormatKeyYearMonthValue(chCtr.Text, CType(chCtr, TextBox).MaxLength)
                End If
                ' chCtr.Text = mManager.FormateData.FormatKeyYearMonthValue(chCtr.Text, CType(chCtr, TextBox).MaxLength)
            End While
        Else
            DocumentNo = FormateData.FormatKeyYearMonthValue(DocumentNo, 10, TransDate)

        End If
        Return DocumentNo
        Reader = Nothing
        dt = Nothing
    End Function

    Function CheckReference() As String
        ' Get OLD VoucherNo Document No
        Dim dt As New AzamTechnologies.Database.DataAccess
        Dim Reader As SqlDataReader
        Reader = dt.GetRecord("SelectGeneratedReferences", "GenFrom", GeneratedFromModuleName, _
                "FormName", m_FromGeneratedData.DataSetName, _
                "BranchCode", m_FromGeneratedData.Tables(0).Rows(0).Item("BranchCode"), _
                "TransactionNature", m_GeneratedFromNature, _
                "TransactionNo", m_FromGeneratedData.Tables(0).Rows(0).Item("TransactionNo"), _
                "DocumentNature", m_GeneratedToVoucherNature, "OPTION", "CHECK_IF_EXIST")
        If Reader.Read Then
            DocumentNo = Trim(Reader("DocumentNo"))
            Return DocumentNo
        Else
            Return String.Empty
        End If
        Reader = Nothing
        dt = Nothing
    End Function
#Region "Sale Voucher"

    Private Function GenerateMasterSaleVouchers() As DataSet
        With Me.m_FromGeneratedData.Tables(0)
            Dim SVM As New MasterVoucher(.Rows(0).Item("BranchCode").ToString, Me.DocumentNo, "SV")
            SVM.Branch = .Rows(0).Item("BranchName")
            SVM.Description = "Vehicle Reference: " & .Rows(0).Item("VehicleCode") & "-" & .Rows(0).Item("VehicleDescription") & " /  Invoice Ref:  " & .Rows(0).Item("TransactionNo")
            SVM.VoucherDate = .Rows(0).Item("TransactionDate")
            SVM.CreateRow()
            Dim MasterDataSet As New DataSet(Me.m_FromGeneratedData.DataSetName)
            MasterDataSet.Tables.Add(SVM.VoucherMasterTable)
            Return MasterDataSet
        End With
    End Function
    Private Function GenerateDetailSaleVouchers() As DataSet
        Dim GLCode As String = ""

        With Me.m_FromGeneratedData.Tables(0)
            Dim SVD As DetailVoucher = Nothing
            SVD = New DetailVoucher(.Rows(0).Item("BranchCode").ToString, Me.DocumentNo, "SV")
            If (.Rows(0).Item("Rate") * .Rows(0).Item("Quantity")) <> 0 Then
                '   Generate Row For Customer Debit
                If (.Rows(0).Item("Rate") * .Rows(0).Item("Quantity")) <> 0 Then
                    SVD.Branch = .Rows(0).Item("BranchName")
                    SVD.GLCode = GetCustomerGLCode(.Rows(0).Item("CustomerCode"))
                    SVD.DivisionCode = MySettingReader.Read("DefaultDivisionCode", MySettingReader.FieldLevel.ApplicationLevel)
                    SVD.Reference = "TMS/INV/" & SVD.BranchCode & " - " & .Rows(0).Item("TransactionNo")
                    SVD.Debit = .Rows(0).Item("Rate") * .Rows(0).Item("Quantity")
                    SVD.Credit = 0
                    SVD.Narration = ""
                    SVD.CreateRow()
                    
                End If
            
                'AppDomain.CurrentDomain.SetupInformation.ConfigurationFile
                '   Generate Row For Vehicle Freight
                If (.Rows(0).Item("Rate") * .Rows(0).Item("Quantity")) <> 0 Then
                    SVD.Branch = .Rows(0).Item("BranchName")
                    SVD.GLCode = GetVehicleFreightGLCode(.Rows(0).Item("VehicleCode"))
                    SVD.DivisionCode = MySettingReader.Read("DefaultDivisionCode", MySettingReader.FieldLevel.ApplicationLevel)
                    SVD.Reference = "TMS/INV/" & SVD.BranchCode & " - " & .Rows(0).Item("TransactionNo")

                    If CDbl(.Rows(0).Item("Quantity")) * CDbl(.Rows(0).Item("Rate")) - (CDbl((.Rows(0).Item("Commission")) + CDbl(.Rows(0).Item("Shortage")))) > 0 Then
                        SVD.Credit = Math.Abs(CDbl(.Rows(0).Item("Quantity")) * CDbl(.Rows(0).Item("Rate")) - (CDbl((.Rows(0).Item("Commission")) + CDbl(.Rows(0).Item("Shortage")))))
                        SVD.Debit = 0
                    Else
                        SVD.Debit = Math.Abs(CDbl(.Rows(0).Item("Quantity")) * CDbl(.Rows(0).Item("Rate")) - (CDbl((.Rows(0).Item("Commission")) + CDbl(.Rows(0).Item("Shortage")))))
                        SVD.Credit = 0
                    End If
                    SVD.Narration = ""
                    SVD.CreateRow()
                End If
                '   Generate Row For Shortage
                If .Rows(0).Item("Shortage") <> 0 Then
                    SVD.Branch = .Rows(0).Item("BranchName")
                    SVD.GLCode = GetCustomerShortageGLCode(.Rows(0).Item("CustomerCode"))
                    SVD.DivisionCode = MySettingReader.Read("DefaultDivisionCode", MySettingReader.FieldLevel.ApplicationLevel)
                    SVD.Reference = "TMS/INV/" & SVD.BranchCode & " - " & .Rows(0).Item("TransactionNo")
                    SVD.Debit = 0
                    SVD.Credit = .Rows(0).Item("Shortage")
                    SVD.Narration = ""
                    SVD.CreateRow()


                End If
                '   Generate Row For Commission
                If .Rows(0).Item("Commission") <> 0 Then
                    SVD.Branch = .Rows(0).Item("BranchName")
                    SVD.GLCode = GetCommissionGLCode(.Rows(0).Item("VehicleCode"))
                    SVD.DivisionCode = MySettingReader.Read("DefaultDivisionCode", MySettingReader.FieldLevel.ApplicationLevel)
                    SVD.Reference = "TMS/INV/" & SVD.BranchCode & " - " & .Rows(0).Item("TransactionNo")
                    SVD.Debit = 0
                    SVD.Credit = .Rows(0).Item("Commission")
                    SVD.Narration = ""
                    SVD.CreateRow()



                End If
                IsVoucherCancelled = False
            Else
                IsVoucherCancelled = True
            End If

            Dim MasterDataSet As New DataSet(Me.m_FromGeneratedData.DataSetName)
            MasterDataSet.Tables.Add(SVD.VoucherDetailTable)
            Return MasterDataSet
        End With
    End Function
#End Region
#Region "Receipt Voucher"
    Private Overloads Function GenerateMasterReceiptVouchers(ByVal ToGenNature As String) As DataSet
        ''For vehicle Receipt Voucher
        With Me.m_FromGeneratedData.Tables(0)
            Dim SVM As New MasterVoucher(.Rows(0).Item("BranchCode").ToString, Me.DocumentNo, ToGenNature)
            SVM.Branch = .Rows(0).Item("BranchName")
            SVM.Description = " Vehicle Reference: " & .Rows(0).Item("VehicleCode") & _
                            vbCrLf & "Transaction No: " & .Rows(0).Item("TransactionNo") & "[ " & m_GeneratedFromNature & "]"
            SVM.UrduDescription = .Rows(0).Item("UrduTitle")
            SVM.VoucherDate = .Rows(0).Item("TransactionDate")
            SVM.CreateRow()
            Dim MasterDataSet As New DataSet(Me.m_FromGeneratedData.DataSetName)
            MasterDataSet.Tables.Add(SVM.VoucherMasterTable)
            Return MasterDataSet
        End With
    End Function
    Private Overloads Function GenerateMasterPaymentVouchers(ByVal ToGenNature As String) As DataSet
        ''For vehicle Receipt Voucher
        With Me.m_FromGeneratedData.Tables(0)
            Dim SVM As New MasterVoucher(.Rows(0).Item("BranchCode").ToString, Me.DocumentNo, ToGenNature)
            SVM.Branch = .Rows(0).Item("BranchName")
            SVM.Description = " Vehicle Reference: " & .Rows(0).Item("VehicleCode") & _
                            vbCrLf & "Transaction No: " & .Rows(0).Item("TransactionNo") & " [" & m_GeneratedFromNature & "]"
            SVM.UrduDescription = .Rows(0).Item("UrduTitle")
            SVM.VoucherDate = .Rows(0).Item("TransactionDate")
            SVM.CreateRow()
            Dim MasterDataSet As New DataSet(Me.m_FromGeneratedData.DataSetName)
            MasterDataSet.Tables.Add(SVM.VoucherMasterTable)
            Return MasterDataSet
        End With
    End Function
    Private Overloads Function GenerateDetailReceiptVouchers(ByVal ToGenNature As String) As DataSet
        ''For vehicle Receipt Voucher
        Dim GLCode As String = ""
        Dim Amount As Double = 0
        Dim IsTripAdvanceExist As Boolean = False
        ''VEHICLE CODE BE DEBIT WHEN PAYMENT TO VEHICLE BY CASH OR BANK
        'AND VEHICLE CODE WILL CREDIT WHEN CASH RECEIPT BY CHEQE OR CASH
        With Me.m_FromGeneratedDetailData.Tables(0)

            Dim SVD As DetailVoucher = Nothing
            Dim iRow As Int16
            SVD = New DetailVoucher(.Rows(0).Item("BranchCode").ToString, Me.DocumentNo, ToGenNature)

            'If Me.m_GeneratedFromNature = VehicleReceiptNature Or Me.m_GeneratedFromNature = VehicleAdjustmentReceiptNature Then
            For iRow = 0 To Me.m_FromGeneratedDetailData.Tables(0).Rows.Count - 1
                '   Generate Row For Debit Against Vehicle While Vehicle must be credit Done
                '   
                If .Rows(iRow).Item("Amount") <> 0 Then
                    'Generate Row For GLCode Credit Done
                    SVD.Branch = Me.m_FromGeneratedData.Tables(0).Rows(0).Item("BranchName")
                    SVD.GLCode = Trim(.Rows(iRow).Item("GLCode"))
                    SVD.DivisionCode = MySettingReader.Read("DefaultDivisionCode", MySettingReader.FieldLevel.ApplicationLevel)
                    SVD.Reference = "" '"TMS/REC/" & SVD.BranchCode & " - " & .Rows(irow).Item("TransactionNo")
                    SVD.Debit = CDbl(.Rows(iRow).Item("Amount"))
                    SVD.Credit = 0D
                    SVD.Narration = ""
                    Amount = Amount + .Rows(iRow).Item("Amount")
                    SVD.CreateRow()
                End If

            Next

            If Amount > 0 And Amount <> 0 Then
                SVD.Branch = Me.m_FromGeneratedData.Tables(0).Rows(0).Item("BranchName")
                SVD.GLCode = GetVehicleFreightGLCode(Me.m_FromGeneratedData.Tables(0).Rows(0).Item("VehicleCode"))
                SVD.DivisionCode = MySettingReader.Read("DefaultDivisionCode", MySettingReader.FieldLevel.ApplicationLevel)
                SVD.Reference = "" ' "TMS/REC/" & SVD.BranchCode & " - " & .Rows(irow).Item("TransactionNo")
                SVD.Debit = 0D
                SVD.Credit = Math.Abs(Amount)
                SVD.Narration = ""
                SVD.CreateRow()
                IsVoucherCancelled = False
            Else
                IsVoucherCancelled = True
            End If
            'End If
            Dim MasterDataSet As New DataSet(Me.m_FromGeneratedData.DataSetName)
            MasterDataSet.Tables.Add(SVD.VoucherDetailTable)
            Return MasterDataSet
        End With
    End Function
    Private Overloads Function GenerateDetailPaymentVouchers(ByVal ToGenNature As String) As DataSet
        ''For vehicle Receipt Voucher
        Dim GLCode As String = ""
        Dim Amount As Double = 0
        Dim IsTripAdvanceExist As Boolean = False
        ''VEHICLE CODE BE DEBIT WHEN PAYMENT TO VEHICLE BY CASH OR BANK
        'AND VEHICLE CODE WILL CREDIT WHEN CASH RECEIPT BY CHEQE OR CASH
        With Me.m_FromGeneratedDetailData.Tables(0)

            Dim SVD As DetailVoucher = Nothing
            Dim iRow As Int16
            SVD = New DetailVoucher(.Rows(0).Item("BranchCode").ToString, Me.DocumentNo, ToGenNature)
            ' If Me.m_GeneratedFromNature = VehiclePaymentNature Then
            For iRow = 0 To Me.m_FromGeneratedDetailData.Tables(0).Rows.Count - 1
                If .Rows(iRow).Item("TypeCode") = "01" Then
                    IsTripAdvanceExist = True
                End If
                '   Generate Row For Vehicle Debit Done
                '   
                If .Rows(iRow).Item("Amount") <> 0 Then
                    'Generate Row For GLCode Credit Done
                    SVD.Branch = Me.m_FromGeneratedData.Tables(0).Rows(0).Item("BranchName")
                    SVD.GLCode = Trim(.Rows(iRow).Item("GLCode"))
                    SVD.DivisionCode = MySettingReader.Read("DefaultDivisionCode", MySettingReader.FieldLevel.ApplicationLevel)
                    SVD.Reference = "" '"TMS/REC/" & SVD.BranchCode & " - " & .Rows(irow).Item("TransactionNo")
                    SVD.Credit = CDbl(.Rows(iRow).Item("Amount"))
                    SVD.Debit = 0D
                    SVD.Narration = ""
                    Amount = Amount + .Rows(iRow).Item("Amount")
                    SVD.CreateRow()
                End If
            Next

            If Amount <> 0 Then
                SVD.Branch = Me.m_FromGeneratedData.Tables(0).Rows(0).Item("BranchName")
                SVD.GLCode = GetVehicleFreightGLCode(Me.m_FromGeneratedData.Tables(0).Rows(0).Item("VehicleCode"))
                SVD.DivisionCode = MySettingReader.Read("DefaultDivisionCode", MySettingReader.FieldLevel.ApplicationLevel)
                SVD.Reference = "" ' "TMS/REC/" & SVD.BranchCode & " - " & .Rows(irow).Item("TransactionNo")
                SVD.Debit = Amount
                SVD.Credit = 0D
                If IsTripAdvanceExist = True Then
                    SVD.Narration = "Trip Advance"
                Else
                    SVD.Narration = ""
                End If
                SVD.CreateRow()
                IsVoucherCancelled = False
            Else
                IsVoucherCancelled = True
            End If
            'End If
            Dim MasterDataSet As New DataSet(Me.m_FromGeneratedData.DataSetName)
            MasterDataSet.Tables.Add(SVD.VoucherDetailTable)
            Return MasterDataSet
        End With
    End Function



    Private Overloads Function GenerateMasterReceiptVouchers() As DataSet
        With Me.m_FromGeneratedData.Tables(0)
            Dim SVM As New MasterVoucher(.Rows(0).Item("BranchCode").ToString, Me.DocumentNo, "BR")
            SVM.Branch = .Rows(0).Item("BranchName")
            SVM.Description = " Customer Reference: " & .Rows(0).Item("CustomerCode") & "-" & .Rows(0).Item("CustomerName") & _
                            vbCrLf & "Bill No: " & .Rows(0).Item("BillNo")
            SVM.VoucherDate = .Rows(0).Item("ReceiptDate")
            SVM.CreateRow()
            Dim MasterDataSet As New DataSet(Me.m_FromGeneratedData.DataSetName)
            MasterDataSet.Tables.Add(SVM.VoucherMasterTable)
            Return MasterDataSet
        End With
    End Function
    Private Overloads Function GenerateDetailReceiptVouchers() As DataSet
        Dim GLCode As String = ""

        With Me.m_FromGeneratedData.Tables(0)
            Dim SVD As DetailVoucher = Nothing
            SVD = New DetailVoucher(.Rows(0).Item("BranchCode").ToString, Me.DocumentNo, "BR")
            '   Debit Compony Bank Account Removing Shortage and Sale Tax
            If .Rows(0).Item("Amount") <> 0 Then
                SVD.Branch = .Rows(0).Item("BranchName")
                SVD.GLCode = GetBranchGLCode(.Rows(0).Item("BranchCode"))
                SVD.DivisionCode = MySettingReader.Read("DefaultDivisionCode", MySettingReader.FieldLevel.ApplicationLevel)
                SVD.Reference = "" '"TMS/REC/" & SVD.BranchCode & " - " & .Rows(0).Item("TransactionNo")
                SVD.Credit = 0D
                SVD.Debit = CDbl(.Rows(0).Item("Amount")) - CDbl(.Rows(0).Item("SaleTaxValue")) - CDbl(.Rows(0).Item("Shortage"))
                SVD.Narration = ""
                SVD.CreateRow()
            End If
            '   Generate Row For Shortage
            If .Rows(0).Item("Shortage") <> 0 Then
                SVD.Branch = .Rows(0).Item("BranchName")
                SVD.GLCode = GetCustomerShortageGLCode(.Rows(0).Item("CustomerCode"))
                SVD.DivisionCode = MySettingReader.Read("DefaultDivisionCode", MySettingReader.FieldLevel.ApplicationLevel)
                SVD.Reference = "" ' "TMS/REC/" & SVD.BranchCode & " - " & .Rows(0).Item("TransactionNo")
                SVD.Debit = .Rows(0).Item("Shortage")
                SVD.Credit = 0
                SVD.Narration = ""
                SVD.CreateRow()
            End If
            '   Generate Row For SaleTax
            If .Rows(0).Item("SaleTaxValue") <> 0 Then
                SVD.Branch = .Rows(0).Item("BranchName")
                SVD.GLCode = GetCustomerWHTaxGLCode(.Rows(0).Item("CustomerCode")) ' MySettingReader.Read("WHTaxGLCode", MySettingReader.FieldLevel.ApplicationLevel)
                SVD.DivisionCode = MySettingReader.Read("DefaultDivisionCode", MySettingReader.FieldLevel.ApplicationLevel)
                SVD.Reference = "" '"TMS/REC/" & SVD.BranchCode & " - " & .Rows(0).Item("TransactionNo")
                SVD.Debit = .Rows(0).Item("SaleTaxValue")
                SVD.Credit = 0
                SVD.Narration = ""
                SVD.CreateRow()

            End If
            If (.Rows(0).Item("Amount")) <> 0 Then
                '   Generate Row For Customer Credit Done
                If (.Rows(0).Item("Amount")) <> 0 Then
                    SVD.Branch = .Rows(0).Item("BranchName")
                    SVD.GLCode = GetCustomerGLCode(.Rows(0).Item("CustomerCode"))
                    SVD.DivisionCode = MySettingReader.Read("DefaultDivisionCode", MySettingReader.FieldLevel.ApplicationLevel)
                    SVD.Reference = "" ' "TMS/REC/" & SVD.BranchCode & " - " & .Rows(0).Item("TransactionNo")
                    SVD.Debit = 0
                    SVD.Credit = CDbl(.Rows(0).Item("Amount"))
                    SVD.Narration = ""
                    SVD.CreateRow()
                End If
                IsVoucherCancelled = False
            Else
                IsVoucherCancelled = True
            End If

            Dim MasterDataSet As New DataSet(Me.m_FromGeneratedData.DataSetName)
            MasterDataSet.Tables.Add(SVD.VoucherDetailTable)
            Return MasterDataSet
        End With
    End Function
#End Region
    Function GetCustomerGLCode(ByVal CustomerCode As String) As String
        Dim DataAccess As New AzamTechnologies.Database.DataAccess
        Dim Reader As SqlDataReader
        Reader = DataAccess.GetRecord("SelectCustomers", "CustomerCode", CustomerCode)
        If Reader.Read Then
            Return IIf(IsDBNull(Reader.Item("GLCode")), String.Empty, Reader.Item("GLCode"))
        End If
        Reader = Nothing
        DataAccess = Nothing
        Return String.Empty
    End Function
    Function GetCommissionGLCode(ByVal VehicleCode As String) As String
        Dim DataAccess As New AzamTechnologies.Database.DataAccess
        Dim Reader As SqlDataReader
        Reader = DataAccess.GetRecord("SelectVehicles", "VehicleCode", VehicleCode)
        If Reader.Read Then
            Return IIf(IsDBNull(Reader.Item("CommissionGLCode")), String.Empty, Reader.Item("CommissionGLCode"))
        End If
        Reader = Nothing
        DataAccess = Nothing
        Return String.Empty
    End Function
    Function GetVehicleFreightGLCode(ByVal VehicleCode As String) As String
        Dim DataAccess As New AzamTechnologies.Database.DataAccess
        Dim Reader As SqlDataReader
        Reader = DataAccess.GetRecord("SelectVehicles", "VehicleCode", VehicleCode)
        If Reader.Read Then
            Return IIf(IsDBNull(Reader.Item("FreightGLCode")), String.Empty, Reader.Item("FreightGLCode"))
        End If

        Reader = Nothing
        DataAccess = Nothing
        Return String.Empty
    End Function
    Function GetCustomerShortageGLCode(ByVal CustomerCode As String) As String
        Dim DataAccess As New AzamTechnologies.Database.DataAccess
        Dim Reader As SqlDataReader
        Reader = DataAccess.GetRecord("SelectCustomers", "CustomerCode", CustomerCode)
        If Reader.Read Then
            Return IIf(IsDBNull(Reader.Item("ShortageGLCode")), String.Empty, Reader.Item("ShortageGLCode"))
        End If
        Reader = Nothing
        DataAccess = Nothing
        Return String.Empty
    End Function
    Function GetCustomerWHTaxGLCode(ByVal CustomerCode As String) As String
        Dim DataAccess As New AzamTechnologies.Database.DataAccess
        Dim Reader As SqlDataReader
        Reader = DataAccess.GetRecord("SelectCustomers", "CustomerCode", CustomerCode)
        If Reader.Read Then
            Return IIf(IsDBNull(Reader.Item("WHTaxGLCode")), String.Empty, Reader.Item("WHTaxGLCode"))
        End If
        Reader = Nothing
        DataAccess = Nothing
        Return String.Empty
    End Function
    Function GetBranchGLCode(ByVal BranchCode As String) As String
        Dim DataAccess As New AzamTechnologies.Database.DataAccess
        Dim Reader As SqlDataReader
        Reader = DataAccess.GetRecord("SelectBranches", "BranchCode", BranchCode)
        If Reader.Read Then
            Return IIf(IsDBNull(Reader.Item("GLCode")), String.Empty, Reader.Item("GLCode"))
        End If
        Reader = Nothing
        DataAccess = Nothing
        Return String.Empty
    End Function
End Class
#Region " Formate Class"
Class FormateData
    Public Shared Function FormatKeyYearMonthValue(ByVal KeyObjectText As String, ByVal maxTextLen As Integer, ByVal TrDate As Date) As String
        Dim a As New Text.StringBuilder
        Dim dateValue As String = Format(TrDate, "yy") & Format(TrDate, "MM")

        Dim strTemp As String
        KeyObjectText = "1"
        strTemp = a.Insert(0, "0", maxTextLen - KeyObjectText.Length).ToString
        a = New Text.StringBuilder(strTemp)
        strTemp = a.Replace("0000", dateValue, 0, 4).ToString
        a = New Text.StringBuilder(strTemp)
        strTemp = a.Insert(maxTextLen - KeyObjectText.Length, KeyObjectText, 1).ToString
        FormatKeyYearMonthValue = strTemp
    End Function
End Class
#End Region




