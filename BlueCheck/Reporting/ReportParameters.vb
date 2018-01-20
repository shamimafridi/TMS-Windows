Public Class ReportParameters
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnPreview As System.Windows.Forms.Button
    Friend WithEvents GrpTransactionDocuments As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkGeneralLedgers As System.Windows.Forms.LinkLabel
    Friend WithEvents chkTransactionListing As System.Windows.Forms.LinkLabel
    Friend WithEvents chkSaleRet As System.Windows.Forms.LinkLabel
    Friend WithEvents chkSale As System.Windows.Forms.LinkLabel
    Friend WithEvents chkProductRecRet As System.Windows.Forms.LinkLabel
    Friend WithEvents chkProductRec As System.Windows.Forms.LinkLabel
    Friend WithEvents GrpOtherReports As System.Windows.Forms.Panel
    Friend WithEvents GrpButtons As System.Windows.Forms.Panel
    Friend WithEvents BtnToPartyList As System.Windows.Forms.Button
    Friend WithEvents TxtToPartyCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtToTransactionNumber As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFromPartyList As System.Windows.Forms.Button
    Friend WithEvents TxtFromPartyCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFromTransactionNumber As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblBackToOther As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GrpTransactionList As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbGroupBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TxtDocumentNatureTRL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents BtnChkDocumentNatureListTRL As System.Windows.Forms.Button
    Friend WithEvents cmbToPartyCodeListTRL As System.Windows.Forms.Button
    Friend WithEvents txtToPartyCodeTRL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtToTransactionNoTRL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dtpToTransactionDateTRL As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbFromPartyCodeListTRL As System.Windows.Forms.Button
    Friend WithEvents txtFromPartyCodeTRL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFromTransactionNoTRL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dtpFromTransactionDateTRL As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtToItemCodeTRL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFromItemCodeTRL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents chkPageBreakTRL As System.Windows.Forms.CheckBox
    Friend WithEvents GrpGeneralLedger As System.Windows.Forms.Panel
    Friend WithEvents ChkPageBreakIL As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LstTransactionNatureTRL As System.Windows.Forms.ListView
    Friend WithEvents BtnDocumentNatureListIL As System.Windows.Forms.Button
    Friend WithEvents txtDocumentNatureIL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents cmbGroupIL As System.Windows.Forms.ComboBox
    Friend WithEvents lstTransactionNatureIL As System.Windows.Forms.ListView
    Friend WithEvents txtToBranchCodeIL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFromBranchCodeIL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtToGLCodeIL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtToDivisionIL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtToTrDateIL As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFromGLCodeIL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFromDivisionCodeIL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFromTrDateIL As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkIsHierarchicalView As System.Windows.Forms.CheckBox
    Friend WithEvents chkItemTrialBalance As System.Windows.Forms.LinkLabel
    Friend WithEvents cmbToItemListTRL As System.Windows.Forms.Button
    Friend WithEvents cmbFromItemListTRL As System.Windows.Forms.Button
    Friend WithEvents BtnToBranchListIL As System.Windows.Forms.Button
    Friend WithEvents BtnToGLCodeListIL As System.Windows.Forms.Button
    Friend WithEvents BtnFromGLCodeListIL As System.Windows.Forms.Button
    Friend WithEvents BtnFromBranchListIL As System.Windows.Forms.Button
    Friend WithEvents PnlProgressBare As System.Windows.Forms.Panel
    Friend WithEvents imgProgressBar As System.Windows.Forms.PictureBox
    Friend WithEvents LblOtherReportsTRL As System.Windows.Forms.LinkLabel
    Friend WithEvents lblOtherReportsIL As System.Windows.Forms.LinkLabel
    Friend WithEvents chkItemList As System.Windows.Forms.LinkLabel
    Friend WithEvents GrpVehicleBill As System.Windows.Forms.Panel
    Friend WithEvents BtnToVehicleList As System.Windows.Forms.Button
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LblToDateVB As System.Windows.Forms.Label
    Friend WithEvents lblFromDateVB As System.Windows.Forms.Label
    Friend WithEvents BtnFromVehicleList As System.Windows.Forms.Button
    Friend WithEvents TxtToVehicleCodeVB As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TxtFromVehicleCodeVB As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TxtToTransactionDateVB As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtFromTransactionDateVB As System.Windows.Forms.DateTimePicker
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TxtToGlCodeCOAL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TxtToDefinitionDateCOAL As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtFromGlCodeCOAL As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TxtFromDefinitionDateCOAL As System.Windows.Forms.DateTimePicker
    Friend WithEvents GrpCOAReportList As System.Windows.Forms.Panel
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents CmbLevelsCOAL As System.Windows.Forms.ComboBox
    Friend WithEvents ChkPageBreakCOAL As System.Windows.Forms.CheckBox
    Friend WithEvents GrpVoucherDocuments As System.Windows.Forms.Panel
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtnVoucherTypeListVDO As System.Windows.Forms.Button
    Friend WithEvents TxtVoucherTypesVDO As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TxtToVoucherNoVDO As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents DtpToDefinitionDateVDO As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtFromVoucherNoVDO As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents DtpFromDefinitionDateVDO As System.Windows.Forms.DateTimePicker
    Friend WithEvents LvwVoucherTypesVDO As System.Windows.Forms.ListView
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ChkPageBreakVLT As System.Windows.Forms.CheckBox
    Friend WithEvents BtnToGLCodeListVLT As System.Windows.Forms.Button
    Friend WithEvents BtnVoucherTypesListVLT As System.Windows.Forms.Button
    Friend WithEvents TxtVoucherTypesVLT As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TxtToGLCodeVLT As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TxtFromGLCodeVLT As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TxtToVoucherNoListVLT As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents DtpToVoucherDateVLT As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtFromVoucherNoListVLT As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents DtpFromVoucherDateVLT As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnFromGLCodeListVLT As System.Windows.Forms.Button
    Friend WithEvents CmbGroupedByVLT As System.Windows.Forms.ComboBox
    Friend WithEvents LvwVoucherTypesVLT As System.Windows.Forms.ListView
    Friend WithEvents CmbLedgerTypeIL As System.Windows.Forms.ComboBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents TxtFromOwnerCodeVB As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents BtnFromOwnerList As System.Windows.Forms.Button
    Friend WithEvents BtnToOwnerList As System.Windows.Forms.Button
    Friend WithEvents TxtToOwnerCodeVB As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OptSummary As System.Windows.Forms.RadioButton
    Friend WithEvents OptDetail As System.Windows.Forms.RadioButton
    Friend WithEvents CmbNarrationType As System.Windows.Forms.ComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents GrpCashFlowStatements As System.Windows.Forms.Panel
    Friend WithEvents OptSummaryCFS As System.Windows.Forms.RadioButton
    Friend WithEvents OptDetailCFS As System.Windows.Forms.RadioButton
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ChkShowOpenningCFS As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPageBreakCFS As System.Windows.Forms.CheckBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents BtnCashAccountsCFS As System.Windows.Forms.Button
    Friend WithEvents TxtCashAccountsCFS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TxtToBranchCodeCFS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents TxtFromBranchCodeCFS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents TxtToDivisionCFS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents TxtToDateCFS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents TxtFromDivisionCFS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents TxtFromDateCFS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents BtnFromBranchCodeCFS As System.Windows.Forms.Button
    Friend WithEvents LstCashAccountsCFS As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GrpFinancialStatements As System.Windows.Forms.Panel
    Friend WithEvents BtnToGLCodeListFS As System.Windows.Forms.Button
    Friend WithEvents BtnFrGLCodeListFS As System.Windows.Forms.Button
    Friend WithEvents ChkNotesToFS As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents TxtToGLCodeFS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents TxtToDateFS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents TxtFromGLCodeFS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents TxtFromDateFS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents GrpVehicleFreightStatements As System.Windows.Forms.Panel
    Friend WithEvents CmbReportTypeVFS As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents OptSummaryVFS As System.Windows.Forms.RadioButton
    Friend WithEvents OptDetailVFS As System.Windows.Forms.RadioButton
    Friend WithEvents BtnToVehicleListVFS As System.Windows.Forms.Button
    Friend WithEvents ChkPageBreakVFS As System.Windows.Forms.CheckBox
    Friend WithEvents TxtFromBranchVFS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents CmbOnBasisVFS As System.Windows.Forms.ComboBox
    Friend WithEvents LinkLabel7 As System.Windows.Forms.LinkLabel
    Friend WithEvents DtpToDateVFS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents DtpFromDateVFS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents BtnFromBranchListVFS As System.Windows.Forms.Button
    Friend WithEvents BtnFromVehicleListVFS As System.Windows.Forms.Button
    Friend WithEvents BtnToCustomerListVFS As System.Windows.Forms.Button
    Friend WithEvents TxtToCustomerVFS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TxtToVehicleVFS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents BtnFromCustomerListVFS As System.Windows.Forms.Button
    Friend WithEvents TxtFromCustomerVFS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TxtFromVehicleVFS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents TxtToTransactionNoVFS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TxtFromTransactionNoVFS As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents CmbGroupbyVFS As System.Windows.Forms.ComboBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents GrpSetupList As System.Windows.Forms.Panel
    Friend WithEvents TxtToCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TxtFCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel8 As System.Windows.Forms.LinkLabel
    Friend WithEvents TxtTDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TxtFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents GrpVehicleLedger As System.Windows.Forms.Panel
    Friend WithEvents GrpVehicleRevenue As System.Windows.Forms.Panel
    Friend WithEvents CmbTypeVLR As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TxtBranchCodeVLR As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel9 As System.Windows.Forms.LinkLabel
    Friend WithEvents BtnLstToVehicleVLR As System.Windows.Forms.Button
    Friend WithEvents TxtToVehicleVLR As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents TxtToDateVLR As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents BtnLstFrVehicleVLR As System.Windows.Forms.Button
    Friend WithEvents TxtFrVehicleVLR As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents TxtFrDateVLR As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents BtnLstBranchVLR As System.Windows.Forms.Button
    Friend WithEvents BtnLstToOwnerVLR As System.Windows.Forms.Button
    Friend WithEvents TxtToOwnerVLR As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents BtnLstFrOwnerVLR As System.Windows.Forms.Button
    Friend WithEvents TxtFrOwnerVLR As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents CmbGroupBySU As System.Windows.Forms.ComboBox
    Friend WithEvents LblGroupBySet As System.Windows.Forms.Label
    Friend WithEvents CmbGroupedByVB As System.Windows.Forms.ComboBox
    Friend WithEvents LblGroupByVB As System.Windows.Forms.Label
    Friend WithEvents BtnShowToGrid As System.Windows.Forms.Button
    Friend WithEvents ChkTripWithBill As Infragistics.Win.UltraWinEditors.UltraCheckEditor
    Friend WithEvents RbtSummaryVLR As RadioButton
    Friend WithEvents RbtDetailVLR As RadioButton
    Friend WithEvents ChkShowOpeneing As CheckBox
    Friend WithEvents BtnVehicleLstVR As Button
    Friend WithEvents TxtVehicleLstVR As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label39 As Label
    Friend WithEvents LstVehicleVR As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents DtToVR As DateTimePicker
    Friend WithEvents Label82 As Label
    Friend WithEvents DtFromVR As DateTimePicker
    Friend WithEvents Label85 As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GrpVouchersList As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.GrpButtons = New System.Windows.Forms.Panel()
        Me.BtnShowToGrid = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnPreview = New System.Windows.Forms.Button()
        Me.GrpTransactionDocuments = New System.Windows.Forms.Panel()
        Me.lblBackToOther = New System.Windows.Forms.LinkLabel()
        Me.BtnToPartyList = New System.Windows.Forms.Button()
        Me.TxtToPartyCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtToTransactionNumber = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnFromPartyList = New System.Windows.Forms.Button()
        Me.TxtFromPartyCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFromTransactionNumber = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GrpOtherReports = New System.Windows.Forms.Panel()
        Me.chkItemList = New System.Windows.Forms.LinkLabel()
        Me.chkItemTrialBalance = New System.Windows.Forms.LinkLabel()
        Me.chkGeneralLedgers = New System.Windows.Forms.LinkLabel()
        Me.chkTransactionListing = New System.Windows.Forms.LinkLabel()
        Me.chkSaleRet = New System.Windows.Forms.LinkLabel()
        Me.chkSale = New System.Windows.Forms.LinkLabel()
        Me.chkProductRecRet = New System.Windows.Forms.LinkLabel()
        Me.chkProductRec = New System.Windows.Forms.LinkLabel()
        Me.GrpTransactionList = New System.Windows.Forms.Panel()
        Me.chkPageBreakTRL = New System.Windows.Forms.CheckBox()
        Me.cmbToItemListTRL = New System.Windows.Forms.Button()
        Me.BtnChkDocumentNatureListTRL = New System.Windows.Forms.Button()
        Me.TxtDocumentNatureTRL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtToItemCodeTRL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFromItemCodeTRL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblOtherReportsTRL = New System.Windows.Forms.LinkLabel()
        Me.cmbToPartyCodeListTRL = New System.Windows.Forms.Button()
        Me.txtToPartyCodeTRL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtToTransactionNoTRL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpToTransactionDateTRL = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbFromPartyCodeListTRL = New System.Windows.Forms.Button()
        Me.txtFromPartyCodeTRL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFromTransactionNoTRL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFromTransactionDateTRL = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbFromItemListTRL = New System.Windows.Forms.Button()
        Me.LstTransactionNatureTRL = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmbGroupBy = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GrpGeneralLedger = New System.Windows.Forms.Panel()
        Me.CmbNarrationType = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.OptSummary = New System.Windows.Forms.RadioButton()
        Me.OptDetail = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CmbLedgerTypeIL = New System.Windows.Forms.ComboBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.chkIsHierarchicalView = New System.Windows.Forms.CheckBox()
        Me.ChkPageBreakIL = New System.Windows.Forms.CheckBox()
        Me.BtnToBranchListIL = New System.Windows.Forms.Button()
        Me.BtnDocumentNatureListIL = New System.Windows.Forms.Button()
        Me.txtDocumentNatureIL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtToBranchCodeIL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtFromBranchCodeIL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbGroupIL = New System.Windows.Forms.ComboBox()
        Me.lblOtherReportsIL = New System.Windows.Forms.LinkLabel()
        Me.BtnToGLCodeListIL = New System.Windows.Forms.Button()
        Me.txtToGLCodeIL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtToDivisionIL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtToTrDateIL = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.BtnFromGLCodeListIL = New System.Windows.Forms.Button()
        Me.txtFromGLCodeIL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.txtFromDivisionCodeIL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtFromTrDateIL = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.BtnFromBranchListIL = New System.Windows.Forms.Button()
        Me.lstTransactionNatureIL = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PnlProgressBare = New System.Windows.Forms.Panel()
        Me.imgProgressBar = New System.Windows.Forms.PictureBox()
        Me.GrpVehicleBill = New System.Windows.Forms.Panel()
        Me.ChkTripWithBill = New Infragistics.Win.UltraWinEditors.UltraCheckEditor()
        Me.CmbGroupedByVB = New System.Windows.Forms.ComboBox()
        Me.LblGroupByVB = New System.Windows.Forms.Label()
        Me.BtnToOwnerList = New System.Windows.Forms.Button()
        Me.TxtToOwnerCodeVB = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.BtnFromOwnerList = New System.Windows.Forms.Button()
        Me.TxtFromOwnerCodeVB = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.BtnToVehicleList = New System.Windows.Forms.Button()
        Me.TxtToVehicleCodeVB = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TxtFromVehicleCodeVB = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TxtToTransactionDateVB = New System.Windows.Forms.DateTimePicker()
        Me.LblToDateVB = New System.Windows.Forms.Label()
        Me.TxtFromTransactionDateVB = New System.Windows.Forms.DateTimePicker()
        Me.lblFromDateVB = New System.Windows.Forms.Label()
        Me.BtnFromVehicleList = New System.Windows.Forms.Button()
        Me.GrpCOAReportList = New System.Windows.Forms.Panel()
        Me.ChkPageBreakCOAL = New System.Windows.Forms.CheckBox()
        Me.CmbLevelsCOAL = New System.Windows.Forms.ComboBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtToGlCodeCOAL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TxtToDefinitionDateCOAL = New System.Windows.Forms.DateTimePicker()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TxtFromGlCodeCOAL = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.TxtFromDefinitionDateCOAL = New System.Windows.Forms.DateTimePicker()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.GrpVoucherDocuments = New System.Windows.Forms.Panel()
        Me.BtnVoucherTypeListVDO = New System.Windows.Forms.Button()
        Me.TxtVoucherTypesVDO = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.TxtToVoucherNoVDO = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.DtpToDefinitionDateVDO = New System.Windows.Forms.DateTimePicker()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.TxtFromVoucherNoVDO = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.DtpFromDefinitionDateVDO = New System.Windows.Forms.DateTimePicker()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.LvwVoucherTypesVDO = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GrpVouchersList = New System.Windows.Forms.Panel()
        Me.ChkPageBreakVLT = New System.Windows.Forms.CheckBox()
        Me.BtnToGLCodeListVLT = New System.Windows.Forms.Button()
        Me.BtnVoucherTypesListVLT = New System.Windows.Forms.Button()
        Me.TxtVoucherTypesVLT = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TxtToGLCodeVLT = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.TxtFromGLCodeVLT = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.TxtToVoucherNoListVLT = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.DtpToVoucherDateVLT = New System.Windows.Forms.DateTimePicker()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.TxtFromVoucherNoListVLT = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.DtpFromVoucherDateVLT = New System.Windows.Forms.DateTimePicker()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.BtnFromGLCodeListVLT = New System.Windows.Forms.Button()
        Me.CmbGroupedByVLT = New System.Windows.Forms.ComboBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.LvwVoucherTypesVLT = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GrpCashFlowStatements = New System.Windows.Forms.Panel()
        Me.OptSummaryCFS = New System.Windows.Forms.RadioButton()
        Me.OptDetailCFS = New System.Windows.Forms.RadioButton()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ChkShowOpenningCFS = New System.Windows.Forms.CheckBox()
        Me.ChkPageBreakCFS = New System.Windows.Forms.CheckBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.BtnCashAccountsCFS = New System.Windows.Forms.Button()
        Me.TxtCashAccountsCFS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TxtToBranchCodeCFS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.TxtFromBranchCodeCFS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.TxtToDivisionCFS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.TxtToDateCFS = New System.Windows.Forms.DateTimePicker()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.TxtFromDivisionCFS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.TxtFromDateCFS = New System.Windows.Forms.DateTimePicker()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.BtnFromBranchCodeCFS = New System.Windows.Forms.Button()
        Me.LstCashAccountsCFS = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GrpFinancialStatements = New System.Windows.Forms.Panel()
        Me.BtnToGLCodeListFS = New System.Windows.Forms.Button()
        Me.BtnFrGLCodeListFS = New System.Windows.Forms.Button()
        Me.ChkNotesToFS = New System.Windows.Forms.CheckBox()
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel()
        Me.TxtToGLCodeFS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.TxtToDateFS = New System.Windows.Forms.DateTimePicker()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.TxtFromGLCodeFS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.TxtFromDateFS = New System.Windows.Forms.DateTimePicker()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.GrpVehicleFreightStatements = New System.Windows.Forms.Panel()
        Me.CmbGroupbyVFS = New System.Windows.Forms.ComboBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.TxtToTransactionNoVFS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TxtFromTransactionNoVFS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.CmbReportTypeVFS = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.OptSummaryVFS = New System.Windows.Forms.RadioButton()
        Me.OptDetailVFS = New System.Windows.Forms.RadioButton()
        Me.BtnToVehicleListVFS = New System.Windows.Forms.Button()
        Me.BtnFromVehicleListVFS = New System.Windows.Forms.Button()
        Me.ChkPageBreakVFS = New System.Windows.Forms.CheckBox()
        Me.TxtFromBranchVFS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.CmbOnBasisVFS = New System.Windows.Forms.ComboBox()
        Me.LinkLabel7 = New System.Windows.Forms.LinkLabel()
        Me.BtnToCustomerListVFS = New System.Windows.Forms.Button()
        Me.TxtToCustomerVFS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.TxtToVehicleVFS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.DtpToDateVFS = New System.Windows.Forms.DateTimePicker()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.BtnFromCustomerListVFS = New System.Windows.Forms.Button()
        Me.TxtFromCustomerVFS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.TxtFromVehicleVFS = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.DtpFromDateVFS = New System.Windows.Forms.DateTimePicker()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.BtnFromBranchListVFS = New System.Windows.Forms.Button()
        Me.GrpSetupList = New System.Windows.Forms.Panel()
        Me.CmbGroupBySU = New System.Windows.Forms.ComboBox()
        Me.LblGroupBySet = New System.Windows.Forms.Label()
        Me.TxtToCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TxtFCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.LinkLabel8 = New System.Windows.Forms.LinkLabel()
        Me.TxtTDate = New System.Windows.Forms.DateTimePicker()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TxtFDate = New System.Windows.Forms.DateTimePicker()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.GrpVehicleLedger = New System.Windows.Forms.Panel()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.ChkShowOpeneing = New System.Windows.Forms.CheckBox()
        Me.RbtSummaryVLR = New System.Windows.Forms.RadioButton()
        Me.RbtDetailVLR = New System.Windows.Forms.RadioButton()
        Me.BtnLstToOwnerVLR = New System.Windows.Forms.Button()
        Me.TxtToOwnerVLR = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.BtnLstFrOwnerVLR = New System.Windows.Forms.Button()
        Me.TxtFrOwnerVLR = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.CmbTypeVLR = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TxtBranchCodeVLR = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.LinkLabel9 = New System.Windows.Forms.LinkLabel()
        Me.BtnLstToVehicleVLR = New System.Windows.Forms.Button()
        Me.TxtToVehicleVLR = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.TxtToDateVLR = New System.Windows.Forms.DateTimePicker()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.BtnLstFrVehicleVLR = New System.Windows.Forms.Button()
        Me.TxtFrVehicleVLR = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.TxtFrDateVLR = New System.Windows.Forms.DateTimePicker()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.BtnLstBranchVLR = New System.Windows.Forms.Button()
        Me.GrpVehicleRevenue = New System.Windows.Forms.Panel()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.DtToVR = New System.Windows.Forms.DateTimePicker()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.DtFromVR = New System.Windows.Forms.DateTimePicker()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.BtnVehicleLstVR = New System.Windows.Forms.Button()
        Me.TxtVehicleLstVR = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.LstVehicleVR = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GrpButtons.SuspendLayout()
        Me.GrpTransactionDocuments.SuspendLayout()
        CType(Me.TxtToPartyCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToTransactionNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFromPartyCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromTransactionNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpOtherReports.SuspendLayout()
        Me.GrpTransactionList.SuspendLayout()
        CType(Me.TxtDocumentNatureTRL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToItemCodeTRL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromItemCodeTRL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToPartyCodeTRL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToTransactionNoTRL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromPartyCodeTRL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromTransactionNoTRL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpGeneralLedger.SuspendLayout()
        CType(Me.txtDocumentNatureIL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToBranchCodeIL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromBranchCodeIL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToGLCodeIL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDivisionIL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromGLCodeIL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDivisionCodeIL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlProgressBare.SuspendLayout()
        CType(Me.imgProgressBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpVehicleBill.SuspendLayout()
        CType(Me.ChkTripWithBill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtToOwnerCodeVB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFromOwnerCodeVB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtToVehicleCodeVB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFromVehicleCodeVB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpCOAReportList.SuspendLayout()
        CType(Me.TxtToGlCodeCOAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFromGlCodeCOAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpVoucherDocuments.SuspendLayout()
        CType(Me.TxtVoucherTypesVDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtToVoucherNoVDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFromVoucherNoVDO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpVouchersList.SuspendLayout()
        CType(Me.TxtVoucherTypesVLT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtToGLCodeVLT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFromGLCodeVLT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtToVoucherNoListVLT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFromVoucherNoListVLT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpCashFlowStatements.SuspendLayout()
        CType(Me.TxtCashAccountsCFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtToBranchCodeCFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFromBranchCodeCFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtToDivisionCFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFromDivisionCFS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpFinancialStatements.SuspendLayout()
        CType(Me.TxtToGLCodeFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFromGLCodeFS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpVehicleFreightStatements.SuspendLayout()
        CType(Me.TxtToTransactionNoVFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFromTransactionNoVFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFromBranchVFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtToCustomerVFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtToVehicleVFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFromCustomerVFS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFromVehicleVFS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSetupList.SuspendLayout()
        CType(Me.TxtToCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpVehicleLedger.SuspendLayout()
        CType(Me.TxtToOwnerVLR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFrOwnerVLR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBranchCodeVLR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtToVehicleVLR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFrVehicleVLR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpVehicleRevenue.SuspendLayout()
        CType(Me.TxtVehicleLstVR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpButtons
        '
        Me.GrpButtons.Controls.Add(Me.BtnShowToGrid)
        Me.GrpButtons.Controls.Add(Me.BtnCancel)
        Me.GrpButtons.Controls.Add(Me.BtnPrint)
        Me.GrpButtons.Controls.Add(Me.BtnPreview)
        Me.GrpButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrpButtons.Location = New System.Drawing.Point(0, 551)
        Me.GrpButtons.Name = "GrpButtons"
        Me.GrpButtons.Size = New System.Drawing.Size(804, 32)
        Me.GrpButtons.TabIndex = 0
        '
        'BtnShowToGrid
        '
        Me.BtnShowToGrid.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnShowToGrid.Location = New System.Drawing.Point(229, 3)
        Me.BtnShowToGrid.Name = "BtnShowToGrid"
        Me.BtnShowToGrid.Size = New System.Drawing.Size(96, 25)
        Me.BtnShowToGrid.TabIndex = 10
        Me.BtnShowToGrid.Text = "&Show To Grid"
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(151, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(72, 25)
        Me.BtnCancel.TabIndex = 9
        Me.BtnCancel.Text = "&Cancel"
        '
        'BtnPrint
        '
        Me.BtnPrint.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.BtnPrint.Location = New System.Drawing.Point(78, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(72, 25)
        Me.BtnPrint.TabIndex = 8
        Me.BtnPrint.Text = "&Print"
        '
        'BtnPreview
        '
        Me.BtnPreview.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BtnPreview.Location = New System.Drawing.Point(4, 3)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(72, 25)
        Me.BtnPreview.TabIndex = 7
        Me.BtnPreview.Text = "P&review"
        '
        'GrpTransactionDocuments
        '
        Me.GrpTransactionDocuments.Controls.Add(Me.lblBackToOther)
        Me.GrpTransactionDocuments.Controls.Add(Me.BtnToPartyList)
        Me.GrpTransactionDocuments.Controls.Add(Me.TxtToPartyCode)
        Me.GrpTransactionDocuments.Controls.Add(Me.txtToTransactionNumber)
        Me.GrpTransactionDocuments.Controls.Add(Me.Label4)
        Me.GrpTransactionDocuments.Controls.Add(Me.Label5)
        Me.GrpTransactionDocuments.Controls.Add(Me.dtpToDate)
        Me.GrpTransactionDocuments.Controls.Add(Me.Label6)
        Me.GrpTransactionDocuments.Controls.Add(Me.BtnFromPartyList)
        Me.GrpTransactionDocuments.Controls.Add(Me.TxtFromPartyCode)
        Me.GrpTransactionDocuments.Controls.Add(Me.txtFromTransactionNumber)
        Me.GrpTransactionDocuments.Controls.Add(Me.Label2)
        Me.GrpTransactionDocuments.Controls.Add(Me.Label3)
        Me.GrpTransactionDocuments.Controls.Add(Me.dtpFromDate)
        Me.GrpTransactionDocuments.Controls.Add(Me.Label9)
        Me.GrpTransactionDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpTransactionDocuments.Location = New System.Drawing.Point(0, 0)
        Me.GrpTransactionDocuments.Name = "GrpTransactionDocuments"
        Me.GrpTransactionDocuments.Size = New System.Drawing.Size(804, 583)
        Me.GrpTransactionDocuments.TabIndex = 8
        Me.GrpTransactionDocuments.Tag = "Transaction Document"
        Me.GrpTransactionDocuments.Visible = False
        '
        'lblBackToOther
        '
        Me.lblBackToOther.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblBackToOther.Location = New System.Drawing.Point(10, 35)
        Me.lblBackToOther.Name = "lblBackToOther"
        Me.lblBackToOther.Size = New System.Drawing.Size(75, 20)
        Me.lblBackToOther.TabIndex = 107
        Me.lblBackToOther.TabStop = True
        Me.lblBackToOther.Text = "Other Reports"
        Me.lblBackToOther.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnToPartyList
        '
        Me.BtnToPartyList.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnToPartyList.Location = New System.Drawing.Point(624, 256)
        Me.BtnToPartyList.Name = "BtnToPartyList"
        Me.BtnToPartyList.Size = New System.Drawing.Size(24, 20)
        Me.BtnToPartyList.TabIndex = 106
        Me.BtnToPartyList.TabStop = False
        Me.BtnToPartyList.UseVisualStyleBackColor = False
        '
        'TxtToPartyCode
        '
        Appearance1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtToPartyCode.Appearance = Appearance1
        Me.TxtToPartyCode.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtToPartyCode.Location = New System.Drawing.Point(520, 256)
        Me.TxtToPartyCode.MaxLength = 5
        Me.TxtToPartyCode.Name = "TxtToPartyCode"
        Me.TxtToPartyCode.Size = New System.Drawing.Size(100, 21)
        Me.TxtToPartyCode.TabIndex = 5
        Me.TxtToPartyCode.Tag = "FK.PartyCode"
        '
        'txtToTransactionNumber
        '
        Me.txtToTransactionNumber.AcceptsReturn = True
        Me.txtToTransactionNumber.AccessibleDescription = "YM.AUTO"
        Me.txtToTransactionNumber.Location = New System.Drawing.Point(520, 208)
        Me.txtToTransactionNumber.MaxLength = 10
        Me.txtToTransactionNumber.Name = "txtToTransactionNumber"
        Me.txtToTransactionNumber.Size = New System.Drawing.Size(100, 21)
        Me.txtToTransactionNumber.TabIndex = 1
        Me.txtToTransactionNumber.Tag = "PK.TransactionNo"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(404, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "To"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(404, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 20)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "To"
        '
        'dtpToDate
        '
        Me.dtpToDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpToDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpToDate.Location = New System.Drawing.Point(520, 232)
        Me.dtpToDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.dtpToDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpToDate.TabIndex = 3
        Me.dtpToDate.Tag = "dt.TransactionDate"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(404, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 20)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "To"
        '
        'BtnFromPartyList
        '
        Me.BtnFromPartyList.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFromPartyList.Location = New System.Drawing.Point(344, 256)
        Me.BtnFromPartyList.Name = "BtnFromPartyList"
        Me.BtnFromPartyList.Size = New System.Drawing.Size(24, 20)
        Me.BtnFromPartyList.TabIndex = 99
        Me.BtnFromPartyList.TabStop = False
        Me.BtnFromPartyList.UseVisualStyleBackColor = False
        '
        'TxtFromPartyCode
        '
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtFromPartyCode.Appearance = Appearance2
        Me.TxtFromPartyCode.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtFromPartyCode.Location = New System.Drawing.Point(240, 256)
        Me.TxtFromPartyCode.MaxLength = 5
        Me.TxtFromPartyCode.Name = "TxtFromPartyCode"
        Me.TxtFromPartyCode.Size = New System.Drawing.Size(100, 21)
        Me.TxtFromPartyCode.TabIndex = 4
        Me.TxtFromPartyCode.Tag = "FK.PartyCode"
        '
        'txtFromTransactionNumber
        '
        Me.txtFromTransactionNumber.AcceptsReturn = True
        Me.txtFromTransactionNumber.AccessibleDescription = "YM.AUTO"
        Me.txtFromTransactionNumber.Location = New System.Drawing.Point(240, 208)
        Me.txtFromTransactionNumber.MaxLength = 10
        Me.txtFromTransactionNumber.Name = "txtFromTransactionNumber"
        Me.txtFromTransactionNumber.Size = New System.Drawing.Size(100, 21)
        Me.txtFromTransactionNumber.TabIndex = 0
        Me.txtFromTransactionNumber.Tag = "PK.TransactionNo"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(124, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Transaction No."
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(124, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Party Code"
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpFromDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFromDate.Location = New System.Drawing.Point(240, 232)
        Me.dtpFromDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.dtpFromDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpFromDate.TabIndex = 2
        Me.dtpFromDate.Tag = "dt.TransactionDate"
        Me.dtpFromDate.Value = New Date(2005, 7, 1, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(124, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 20)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "Transaction Date"
        '
        'GrpOtherReports
        '
        Me.GrpOtherReports.Controls.Add(Me.chkItemList)
        Me.GrpOtherReports.Controls.Add(Me.chkItemTrialBalance)
        Me.GrpOtherReports.Controls.Add(Me.chkGeneralLedgers)
        Me.GrpOtherReports.Controls.Add(Me.chkTransactionListing)
        Me.GrpOtherReports.Controls.Add(Me.chkSaleRet)
        Me.GrpOtherReports.Controls.Add(Me.chkSale)
        Me.GrpOtherReports.Controls.Add(Me.chkProductRecRet)
        Me.GrpOtherReports.Controls.Add(Me.chkProductRec)
        Me.GrpOtherReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpOtherReports.Location = New System.Drawing.Point(0, 0)
        Me.GrpOtherReports.Name = "GrpOtherReports"
        Me.GrpOtherReports.Size = New System.Drawing.Size(804, 583)
        Me.GrpOtherReports.TabIndex = 18
        Me.GrpOtherReports.Text = "Other Reports"
        '
        'chkItemList
        '
        Me.chkItemList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkItemList.Location = New System.Drawing.Point(104, 84)
        Me.chkItemList.Name = "chkItemList"
        Me.chkItemList.Size = New System.Drawing.Size(212, 20)
        Me.chkItemList.TabIndex = 20
        Me.chkItemList.TabStop = True
        Me.chkItemList.Text = "Item List"
        '
        'chkItemTrialBalance
        '
        Me.chkItemTrialBalance.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkItemTrialBalance.Location = New System.Drawing.Point(104, 245)
        Me.chkItemTrialBalance.Name = "chkItemTrialBalance"
        Me.chkItemTrialBalance.Size = New System.Drawing.Size(212, 20)
        Me.chkItemTrialBalance.TabIndex = 19
        Me.chkItemTrialBalance.TabStop = True
        Me.chkItemTrialBalance.Text = "Item Trial Balance"
        '
        'chkGeneralLedgers
        '
        Me.chkGeneralLedgers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkGeneralLedgers.Location = New System.Drawing.Point(104, 222)
        Me.chkGeneralLedgers.Name = "chkGeneralLedgers"
        Me.chkGeneralLedgers.Size = New System.Drawing.Size(212, 20)
        Me.chkGeneralLedgers.TabIndex = 18
        Me.chkGeneralLedgers.TabStop = True
        Me.chkGeneralLedgers.Text = "General Ledger"
        '
        'chkTransactionListing
        '
        Me.chkTransactionListing.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkTransactionListing.Location = New System.Drawing.Point(104, 199)
        Me.chkTransactionListing.Name = "chkTransactionListing"
        Me.chkTransactionListing.Size = New System.Drawing.Size(212, 20)
        Me.chkTransactionListing.TabIndex = 17
        Me.chkTransactionListing.TabStop = True
        Me.chkTransactionListing.Text = "Transaction Listing"
        '
        'chkSaleRet
        '
        Me.chkSaleRet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkSaleRet.Location = New System.Drawing.Point(104, 176)
        Me.chkSaleRet.Name = "chkSaleRet"
        Me.chkSaleRet.Size = New System.Drawing.Size(212, 20)
        Me.chkSaleRet.TabIndex = 16
        Me.chkSaleRet.TabStop = True
        Me.chkSaleRet.Text = "Sale Invoice Return"
        '
        'chkSale
        '
        Me.chkSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkSale.Location = New System.Drawing.Point(104, 153)
        Me.chkSale.Name = "chkSale"
        Me.chkSale.Size = New System.Drawing.Size(212, 20)
        Me.chkSale.TabIndex = 15
        Me.chkSale.TabStop = True
        Me.chkSale.Text = "Sale Invoice"
        '
        'chkProductRecRet
        '
        Me.chkProductRecRet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkProductRecRet.Location = New System.Drawing.Point(104, 130)
        Me.chkProductRecRet.Name = "chkProductRecRet"
        Me.chkProductRecRet.Size = New System.Drawing.Size(212, 20)
        Me.chkProductRecRet.TabIndex = 14
        Me.chkProductRecRet.TabStop = True
        Me.chkProductRecRet.Text = "Product Receiving Return Document"
        '
        'chkProductRec
        '
        Me.chkProductRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkProductRec.Location = New System.Drawing.Point(104, 107)
        Me.chkProductRec.Name = "chkProductRec"
        Me.chkProductRec.Size = New System.Drawing.Size(212, 20)
        Me.chkProductRec.TabIndex = 13
        Me.chkProductRec.TabStop = True
        Me.chkProductRec.Text = "Product Receiving "
        '
        'GrpTransactionList
        '
        Me.GrpTransactionList.Controls.Add(Me.chkPageBreakTRL)
        Me.GrpTransactionList.Controls.Add(Me.cmbToItemListTRL)
        Me.GrpTransactionList.Controls.Add(Me.BtnChkDocumentNatureListTRL)
        Me.GrpTransactionList.Controls.Add(Me.TxtDocumentNatureTRL)
        Me.GrpTransactionList.Controls.Add(Me.Label15)
        Me.GrpTransactionList.Controls.Add(Me.txtToItemCodeTRL)
        Me.GrpTransactionList.Controls.Add(Me.Label13)
        Me.GrpTransactionList.Controls.Add(Me.txtFromItemCodeTRL)
        Me.GrpTransactionList.Controls.Add(Me.Label14)
        Me.GrpTransactionList.Controls.Add(Me.LblOtherReportsTRL)
        Me.GrpTransactionList.Controls.Add(Me.cmbToPartyCodeListTRL)
        Me.GrpTransactionList.Controls.Add(Me.txtToPartyCodeTRL)
        Me.GrpTransactionList.Controls.Add(Me.txtToTransactionNoTRL)
        Me.GrpTransactionList.Controls.Add(Me.Label1)
        Me.GrpTransactionList.Controls.Add(Me.Label7)
        Me.GrpTransactionList.Controls.Add(Me.dtpToTransactionDateTRL)
        Me.GrpTransactionList.Controls.Add(Me.Label8)
        Me.GrpTransactionList.Controls.Add(Me.cmbFromPartyCodeListTRL)
        Me.GrpTransactionList.Controls.Add(Me.txtFromPartyCodeTRL)
        Me.GrpTransactionList.Controls.Add(Me.txtFromTransactionNoTRL)
        Me.GrpTransactionList.Controls.Add(Me.Label10)
        Me.GrpTransactionList.Controls.Add(Me.Label11)
        Me.GrpTransactionList.Controls.Add(Me.dtpFromTransactionDateTRL)
        Me.GrpTransactionList.Controls.Add(Me.Label12)
        Me.GrpTransactionList.Controls.Add(Me.cmbFromItemListTRL)
        Me.GrpTransactionList.Controls.Add(Me.LstTransactionNatureTRL)
        Me.GrpTransactionList.Controls.Add(Me.cmbGroupBy)
        Me.GrpTransactionList.Controls.Add(Me.Label16)
        Me.GrpTransactionList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpTransactionList.Location = New System.Drawing.Point(0, 0)
        Me.GrpTransactionList.Name = "GrpTransactionList"
        Me.GrpTransactionList.Size = New System.Drawing.Size(804, 583)
        Me.GrpTransactionList.TabIndex = 20
        Me.GrpTransactionList.Text = "Transaction List"
        Me.GrpTransactionList.Visible = False
        '
        'chkPageBreakTRL
        '
        Me.chkPageBreakTRL.BackColor = System.Drawing.Color.Transparent
        Me.chkPageBreakTRL.Location = New System.Drawing.Point(152, 116)
        Me.chkPageBreakTRL.Name = "chkPageBreakTRL"
        Me.chkPageBreakTRL.Size = New System.Drawing.Size(116, 16)
        Me.chkPageBreakTRL.TabIndex = 121
        Me.chkPageBreakTRL.Text = "Page Break"
        Me.chkPageBreakTRL.UseVisualStyleBackColor = False
        '
        'cmbToItemListTRL
        '
        Me.cmbToItemListTRL.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbToItemListTRL.Location = New System.Drawing.Point(648, 164)
        Me.cmbToItemListTRL.Name = "cmbToItemListTRL"
        Me.cmbToItemListTRL.Size = New System.Drawing.Size(24, 20)
        Me.cmbToItemListTRL.TabIndex = 119
        Me.cmbToItemListTRL.TabStop = False
        Me.cmbToItemListTRL.UseVisualStyleBackColor = False
        '
        'BtnChkDocumentNatureListTRL
        '
        Me.BtnChkDocumentNatureListTRL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnChkDocumentNatureListTRL.Location = New System.Drawing.Point(617, 265)
        Me.BtnChkDocumentNatureListTRL.Name = "BtnChkDocumentNatureListTRL"
        Me.BtnChkDocumentNatureListTRL.Size = New System.Drawing.Size(23, 18)
        Me.BtnChkDocumentNatureListTRL.TabIndex = 9
        Me.BtnChkDocumentNatureListTRL.Text = "--"
        '
        'TxtDocumentNatureTRL
        '
        Me.TxtDocumentNatureTRL.Location = New System.Drawing.Point(260, 264)
        Me.TxtDocumentNatureTRL.Name = "TxtDocumentNatureTRL"
        Me.TxtDocumentNatureTRL.Size = New System.Drawing.Size(382, 21)
        Me.TxtDocumentNatureTRL.TabIndex = 116
        Me.TxtDocumentNatureTRL.Text = " All Selected"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(152, 264)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 20)
        Me.Label15.TabIndex = 114
        Me.Label15.Text = "Transaction Type"
        '
        'txtToItemCodeTRL
        '
        Me.txtToItemCodeTRL.AcceptsReturn = True
        Me.txtToItemCodeTRL.AccessibleDescription = "YM.AUTO"
        Me.txtToItemCodeTRL.Location = New System.Drawing.Point(544, 164)
        Me.txtToItemCodeTRL.MaxLength = 10
        Me.txtToItemCodeTRL.Name = "txtToItemCodeTRL"
        Me.txtToItemCodeTRL.Size = New System.Drawing.Size(100, 21)
        Me.txtToItemCodeTRL.TabIndex = 2
        Me.txtToItemCodeTRL.Tag = "dd.ItemCode1"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(432, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 20)
        Me.Label13.TabIndex = 113
        Me.Label13.Text = "To "
        '
        'txtFromItemCodeTRL
        '
        Me.txtFromItemCodeTRL.AcceptsReturn = True
        Me.txtFromItemCodeTRL.AccessibleDescription = ""
        Me.txtFromItemCodeTRL.Location = New System.Drawing.Point(260, 168)
        Me.txtFromItemCodeTRL.MaxLength = 10
        Me.txtFromItemCodeTRL.Name = "txtFromItemCodeTRL"
        Me.txtFromItemCodeTRL.Size = New System.Drawing.Size(100, 21)
        Me.txtFromItemCodeTRL.TabIndex = 1
        Me.txtFromItemCodeTRL.Tag = "dd.ItemCode1"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(152, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 20)
        Me.Label14.TabIndex = 111
        Me.Label14.Text = "Customer"
        '
        'LblOtherReportsTRL
        '
        Me.LblOtherReportsTRL.BackColor = System.Drawing.Color.Transparent
        Me.LblOtherReportsTRL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblOtherReportsTRL.Location = New System.Drawing.Point(10, 35)
        Me.LblOtherReportsTRL.Name = "LblOtherReportsTRL"
        Me.LblOtherReportsTRL.Size = New System.Drawing.Size(75, 20)
        Me.LblOtherReportsTRL.TabIndex = 107
        Me.LblOtherReportsTRL.TabStop = True
        Me.LblOtherReportsTRL.Text = "Other Reports"
        Me.LblOtherReportsTRL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbToPartyCodeListTRL
        '
        Me.cmbToPartyCodeListTRL.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbToPartyCodeListTRL.Location = New System.Drawing.Point(648, 240)
        Me.cmbToPartyCodeListTRL.Name = "cmbToPartyCodeListTRL"
        Me.cmbToPartyCodeListTRL.Size = New System.Drawing.Size(24, 20)
        Me.cmbToPartyCodeListTRL.TabIndex = 106
        Me.cmbToPartyCodeListTRL.TabStop = False
        Me.cmbToPartyCodeListTRL.UseVisualStyleBackColor = False
        '
        'txtToPartyCodeTRL
        '
        Appearance3.BackColor = System.Drawing.SystemColors.Window
        Me.txtToPartyCodeTRL.Appearance = Appearance3
        Me.txtToPartyCodeTRL.BackColor = System.Drawing.SystemColors.Window
        Me.txtToPartyCodeTRL.Location = New System.Drawing.Point(544, 240)
        Me.txtToPartyCodeTRL.MaxLength = 8
        Me.txtToPartyCodeTRL.Name = "txtToPartyCodeTRL"
        Me.txtToPartyCodeTRL.Size = New System.Drawing.Size(100, 21)
        Me.txtToPartyCodeTRL.TabIndex = 8
        Me.txtToPartyCodeTRL.Tag = "FK.PartyCode"
        '
        'txtToTransactionNoTRL
        '
        Me.txtToTransactionNoTRL.AcceptsReturn = True
        Me.txtToTransactionNoTRL.AccessibleDescription = "YM.AUTO"
        Me.txtToTransactionNoTRL.Location = New System.Drawing.Point(544, 192)
        Me.txtToTransactionNoTRL.MaxLength = 10
        Me.txtToTransactionNoTRL.Name = "txtToTransactionNoTRL"
        Me.txtToTransactionNoTRL.Size = New System.Drawing.Size(100, 21)
        Me.txtToTransactionNoTRL.TabIndex = 4
        Me.txtToTransactionNoTRL.Tag = "PK.TransactionNo"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(432, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "To"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(432, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 20)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "To "
        '
        'dtpToTransactionDateTRL
        '
        Me.dtpToTransactionDateTRL.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpToTransactionDateTRL.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.dtpToTransactionDateTRL.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.dtpToTransactionDateTRL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToTransactionDateTRL.Location = New System.Drawing.Point(544, 216)
        Me.dtpToTransactionDateTRL.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.dtpToTransactionDateTRL.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.dtpToTransactionDateTRL.Name = "dtpToTransactionDateTRL"
        Me.dtpToTransactionDateTRL.Size = New System.Drawing.Size(100, 20)
        Me.dtpToTransactionDateTRL.TabIndex = 6
        Me.dtpToTransactionDateTRL.Tag = "dt.TransactionDate"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(432, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 20)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "To"
        '
        'cmbFromPartyCodeListTRL
        '
        Me.cmbFromPartyCodeListTRL.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbFromPartyCodeListTRL.Location = New System.Drawing.Point(364, 240)
        Me.cmbFromPartyCodeListTRL.Name = "cmbFromPartyCodeListTRL"
        Me.cmbFromPartyCodeListTRL.Size = New System.Drawing.Size(24, 20)
        Me.cmbFromPartyCodeListTRL.TabIndex = 99
        Me.cmbFromPartyCodeListTRL.TabStop = False
        Me.cmbFromPartyCodeListTRL.UseVisualStyleBackColor = False
        '
        'txtFromPartyCodeTRL
        '
        Appearance4.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromPartyCodeTRL.Appearance = Appearance4
        Me.txtFromPartyCodeTRL.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromPartyCodeTRL.Location = New System.Drawing.Point(260, 240)
        Me.txtFromPartyCodeTRL.MaxLength = 8
        Me.txtFromPartyCodeTRL.Name = "txtFromPartyCodeTRL"
        Me.txtFromPartyCodeTRL.Size = New System.Drawing.Size(100, 21)
        Me.txtFromPartyCodeTRL.TabIndex = 7
        Me.txtFromPartyCodeTRL.Tag = "FK.PartyCode"
        '
        'txtFromTransactionNoTRL
        '
        Me.txtFromTransactionNoTRL.AcceptsReturn = True
        Me.txtFromTransactionNoTRL.AccessibleDescription = "YM.AUTO"
        Me.txtFromTransactionNoTRL.Location = New System.Drawing.Point(260, 192)
        Me.txtFromTransactionNoTRL.MaxLength = 10
        Me.txtFromTransactionNoTRL.Name = "txtFromTransactionNoTRL"
        Me.txtFromTransactionNoTRL.Size = New System.Drawing.Size(100, 21)
        Me.txtFromTransactionNoTRL.TabIndex = 3
        Me.txtFromTransactionNoTRL.Tag = "PK.TransactionNo"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(152, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 20)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Transaction No."
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(152, 244)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 20)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = "Vehicle Code"
        '
        'dtpFromTransactionDateTRL
        '
        Me.dtpFromTransactionDateTRL.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpFromTransactionDateTRL.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.dtpFromTransactionDateTRL.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.dtpFromTransactionDateTRL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromTransactionDateTRL.Location = New System.Drawing.Point(260, 216)
        Me.dtpFromTransactionDateTRL.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.dtpFromTransactionDateTRL.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.dtpFromTransactionDateTRL.Name = "dtpFromTransactionDateTRL"
        Me.dtpFromTransactionDateTRL.Size = New System.Drawing.Size(100, 20)
        Me.dtpFromTransactionDateTRL.TabIndex = 5
        Me.dtpFromTransactionDateTRL.Tag = "dt.TransactionDate"
        Me.dtpFromTransactionDateTRL.Value = New Date(2005, 7, 1, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(152, 220)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 20)
        Me.Label12.TabIndex = 96
        Me.Label12.Text = "Transaction Date"
        '
        'cmbFromItemListTRL
        '
        Me.cmbFromItemListTRL.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbFromItemListTRL.Location = New System.Drawing.Point(364, 168)
        Me.cmbFromItemListTRL.Name = "cmbFromItemListTRL"
        Me.cmbFromItemListTRL.Size = New System.Drawing.Size(24, 20)
        Me.cmbFromItemListTRL.TabIndex = 120
        Me.cmbFromItemListTRL.TabStop = False
        Me.cmbFromItemListTRL.UseVisualStyleBackColor = False
        '
        'LstTransactionNatureTRL
        '
        Me.LstTransactionNatureTRL.CheckBoxes = True
        Me.LstTransactionNatureTRL.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.LstTransactionNatureTRL.Location = New System.Drawing.Point(260, 148)
        Me.LstTransactionNatureTRL.Name = "LstTransactionNatureTRL"
        Me.LstTransactionNatureTRL.Size = New System.Drawing.Size(380, 116)
        Me.LstTransactionNatureTRL.TabIndex = 115
        Me.LstTransactionNatureTRL.UseCompatibleStateImageBehavior = False
        Me.LstTransactionNatureTRL.View = System.Windows.Forms.View.Details
        Me.LstTransactionNatureTRL.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Document Types"
        Me.ColumnHeader1.Width = 192
        '
        'cmbGroupBy
        '
        Me.cmbGroupBy.Items.AddRange(New Object() {"None", "Vehicle", "Transaction Date", "GL  ", "Type"})
        Me.cmbGroupBy.Location = New System.Drawing.Point(260, 144)
        Me.cmbGroupBy.Name = "cmbGroupBy"
        Me.cmbGroupBy.Size = New System.Drawing.Size(108, 21)
        Me.cmbGroupBy.TabIndex = 0
        Me.cmbGroupBy.Text = "None"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(152, 148)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 20)
        Me.Label16.TabIndex = 118
        Me.Label16.Text = "Grouped By"
        '
        'GrpGeneralLedger
        '
        Me.GrpGeneralLedger.Controls.Add(Me.CmbNarrationType)
        Me.GrpGeneralLedger.Controls.Add(Me.Label37)
        Me.GrpGeneralLedger.Controls.Add(Me.OptSummary)
        Me.GrpGeneralLedger.Controls.Add(Me.OptDetail)
        Me.GrpGeneralLedger.Controls.Add(Me.Button1)
        Me.GrpGeneralLedger.Controls.Add(Me.Button3)
        Me.GrpGeneralLedger.Controls.Add(Me.CmbLedgerTypeIL)
        Me.GrpGeneralLedger.Controls.Add(Me.Label57)
        Me.GrpGeneralLedger.Controls.Add(Me.chkIsHierarchicalView)
        Me.GrpGeneralLedger.Controls.Add(Me.ChkPageBreakIL)
        Me.GrpGeneralLedger.Controls.Add(Me.BtnToBranchListIL)
        Me.GrpGeneralLedger.Controls.Add(Me.BtnDocumentNatureListIL)
        Me.GrpGeneralLedger.Controls.Add(Me.txtDocumentNatureIL)
        Me.GrpGeneralLedger.Controls.Add(Me.Label17)
        Me.GrpGeneralLedger.Controls.Add(Me.txtToBranchCodeIL)
        Me.GrpGeneralLedger.Controls.Add(Me.Label18)
        Me.GrpGeneralLedger.Controls.Add(Me.txtFromBranchCodeIL)
        Me.GrpGeneralLedger.Controls.Add(Me.Label19)
        Me.GrpGeneralLedger.Controls.Add(Me.cmbGroupIL)
        Me.GrpGeneralLedger.Controls.Add(Me.lblOtherReportsIL)
        Me.GrpGeneralLedger.Controls.Add(Me.BtnToGLCodeListIL)
        Me.GrpGeneralLedger.Controls.Add(Me.txtToGLCodeIL)
        Me.GrpGeneralLedger.Controls.Add(Me.txtToDivisionIL)
        Me.GrpGeneralLedger.Controls.Add(Me.Label20)
        Me.GrpGeneralLedger.Controls.Add(Me.Label21)
        Me.GrpGeneralLedger.Controls.Add(Me.txtToTrDateIL)
        Me.GrpGeneralLedger.Controls.Add(Me.Label22)
        Me.GrpGeneralLedger.Controls.Add(Me.BtnFromGLCodeListIL)
        Me.GrpGeneralLedger.Controls.Add(Me.txtFromGLCodeIL)
        Me.GrpGeneralLedger.Controls.Add(Me.txtFromDivisionCodeIL)
        Me.GrpGeneralLedger.Controls.Add(Me.Label23)
        Me.GrpGeneralLedger.Controls.Add(Me.Label24)
        Me.GrpGeneralLedger.Controls.Add(Me.txtFromTrDateIL)
        Me.GrpGeneralLedger.Controls.Add(Me.Label25)
        Me.GrpGeneralLedger.Controls.Add(Me.Label26)
        Me.GrpGeneralLedger.Controls.Add(Me.BtnFromBranchListIL)
        Me.GrpGeneralLedger.Controls.Add(Me.lstTransactionNatureIL)
        Me.GrpGeneralLedger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpGeneralLedger.Location = New System.Drawing.Point(0, 0)
        Me.GrpGeneralLedger.Name = "GrpGeneralLedger"
        Me.GrpGeneralLedger.Size = New System.Drawing.Size(804, 583)
        Me.GrpGeneralLedger.TabIndex = 2
        Me.GrpGeneralLedger.Text = "General Ledger"
        Me.GrpGeneralLedger.Visible = False
        '
        'CmbNarrationType
        '
        Me.CmbNarrationType.Items.AddRange(New Object() {"Main", "Detail"})
        Me.CmbNarrationType.Location = New System.Drawing.Point(523, 144)
        Me.CmbNarrationType.Name = "CmbNarrationType"
        Me.CmbNarrationType.Size = New System.Drawing.Size(108, 21)
        Me.CmbNarrationType.TabIndex = 130
        Me.CmbNarrationType.Text = "Main"
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.ForeColor = System.Drawing.Color.Navy
        Me.Label37.Location = New System.Drawing.Point(420, 144)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(88, 20)
        Me.Label37.TabIndex = 131
        Me.Label37.Text = "Narration"
        '
        'OptSummary
        '
        Me.OptSummary.AutoSize = True
        Me.OptSummary.BackColor = System.Drawing.Color.Transparent
        Me.OptSummary.Location = New System.Drawing.Point(320, 327)
        Me.OptSummary.Name = "OptSummary"
        Me.OptSummary.Size = New System.Drawing.Size(68, 17)
        Me.OptSummary.TabIndex = 129
        Me.OptSummary.Text = "Summary"
        Me.OptSummary.UseVisualStyleBackColor = False
        Me.OptSummary.Visible = False
        '
        'OptDetail
        '
        Me.OptDetail.AutoSize = True
        Me.OptDetail.BackColor = System.Drawing.Color.Transparent
        Me.OptDetail.Checked = True
        Me.OptDetail.Location = New System.Drawing.Point(251, 327)
        Me.OptDetail.Name = "OptDetail"
        Me.OptDetail.Size = New System.Drawing.Size(52, 17)
        Me.OptDetail.TabIndex = 128
        Me.OptDetail.TabStop = True
        Me.OptDetail.Text = "Detail"
        Me.OptDetail.UseVisualStyleBackColor = False
        Me.OptDetail.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(636, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 20)
        Me.Button1.TabIndex = 126
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(364, 220)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(24, 20)
        Me.Button3.TabIndex = 127
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = False
        '
        'CmbLedgerTypeIL
        '
        Me.CmbLedgerTypeIL.Items.AddRange(New Object() {"Branch Wise", "Consolidate", "Division Wise", "GL Code Wise"})
        Me.CmbLedgerTypeIL.Location = New System.Drawing.Point(523, 169)
        Me.CmbLedgerTypeIL.Name = "CmbLedgerTypeIL"
        Me.CmbLedgerTypeIL.Size = New System.Drawing.Size(108, 21)
        Me.CmbLedgerTypeIL.TabIndex = 124
        Me.CmbLedgerTypeIL.Text = "Branch Wise"
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.ForeColor = System.Drawing.Color.Navy
        Me.Label57.Location = New System.Drawing.Point(420, 171)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(88, 20)
        Me.Label57.TabIndex = 125
        Me.Label57.Text = "Type"
        '
        'chkIsHierarchicalView
        '
        Me.chkIsHierarchicalView.BackColor = System.Drawing.Color.Transparent
        Me.chkIsHierarchicalView.Location = New System.Drawing.Point(248, 144)
        Me.chkIsHierarchicalView.Name = "chkIsHierarchicalView"
        Me.chkIsHierarchicalView.Size = New System.Drawing.Size(116, 16)
        Me.chkIsHierarchicalView.TabIndex = 123
        Me.chkIsHierarchicalView.Text = "Hierarchical View"
        Me.chkIsHierarchicalView.UseVisualStyleBackColor = False
        '
        'ChkPageBreakIL
        '
        Me.ChkPageBreakIL.BackColor = System.Drawing.Color.Transparent
        Me.ChkPageBreakIL.Location = New System.Drawing.Point(140, 144)
        Me.ChkPageBreakIL.Name = "ChkPageBreakIL"
        Me.ChkPageBreakIL.Size = New System.Drawing.Size(116, 16)
        Me.ChkPageBreakIL.TabIndex = 121
        Me.ChkPageBreakIL.Text = "Page Break"
        Me.ChkPageBreakIL.UseVisualStyleBackColor = False
        '
        'BtnToBranchListIL
        '
        Me.BtnToBranchListIL.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnToBranchListIL.Location = New System.Drawing.Point(636, 190)
        Me.BtnToBranchListIL.Name = "BtnToBranchListIL"
        Me.BtnToBranchListIL.Size = New System.Drawing.Size(24, 20)
        Me.BtnToBranchListIL.TabIndex = 119
        Me.BtnToBranchListIL.TabStop = False
        Me.BtnToBranchListIL.UseVisualStyleBackColor = False
        '
        'BtnDocumentNatureListIL
        '
        Me.BtnDocumentNatureListIL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDocumentNatureListIL.Location = New System.Drawing.Point(608, 293)
        Me.BtnDocumentNatureListIL.Name = "BtnDocumentNatureListIL"
        Me.BtnDocumentNatureListIL.Size = New System.Drawing.Size(23, 18)
        Me.BtnDocumentNatureListIL.TabIndex = 117
        Me.BtnDocumentNatureListIL.Text = "--"
        '
        'txtDocumentNatureIL
        '
        Me.txtDocumentNatureIL.Location = New System.Drawing.Point(248, 292)
        Me.txtDocumentNatureIL.Name = "txtDocumentNatureIL"
        Me.txtDocumentNatureIL.Size = New System.Drawing.Size(384, 21)
        Me.txtDocumentNatureIL.TabIndex = 116
        Me.txtDocumentNatureIL.Text = "All Selected"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(140, 296)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(110, 20)
        Me.Label17.TabIndex = 114
        Me.Label17.Text = "Transaction Type"
        '
        'txtToBranchCodeIL
        '
        Me.txtToBranchCodeIL.AcceptsReturn = True
        Me.txtToBranchCodeIL.AccessibleDescription = "YM.AUTO"
        Me.txtToBranchCodeIL.Location = New System.Drawing.Point(524, 192)
        Me.txtToBranchCodeIL.MaxLength = 10
        Me.txtToBranchCodeIL.Name = "txtToBranchCodeIL"
        Me.txtToBranchCodeIL.Size = New System.Drawing.Size(108, 21)
        Me.txtToBranchCodeIL.TabIndex = 2
        Me.txtToBranchCodeIL.Tag = "dd.ItemCode1"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(420, 192)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 20)
        Me.Label18.TabIndex = 113
        Me.Label18.Text = "To "
        '
        'txtFromBranchCodeIL
        '
        Me.txtFromBranchCodeIL.AcceptsReturn = True
        Me.txtFromBranchCodeIL.AccessibleDescription = ""
        Me.txtFromBranchCodeIL.Location = New System.Drawing.Point(248, 196)
        Me.txtFromBranchCodeIL.MaxLength = 10
        Me.txtFromBranchCodeIL.Name = "txtFromBranchCodeIL"
        Me.txtFromBranchCodeIL.Size = New System.Drawing.Size(108, 21)
        Me.txtFromBranchCodeIL.TabIndex = 1
        Me.txtFromBranchCodeIL.Tag = "dd.ItemCode1"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(140, 196)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(110, 20)
        Me.Label19.TabIndex = 111
        Me.Label19.Text = "Branch Code"
        '
        'cmbGroupIL
        '
        Me.cmbGroupIL.Items.AddRange(New Object() {"Controls", "Generals", "Subsidiaries", "Sub Subsidiaries"})
        Me.cmbGroupIL.Location = New System.Drawing.Point(248, 172)
        Me.cmbGroupIL.Name = "cmbGroupIL"
        Me.cmbGroupIL.Size = New System.Drawing.Size(108, 21)
        Me.cmbGroupIL.TabIndex = 0
        Me.cmbGroupIL.Text = "Sub Subsidiaries"
        '
        'lblOtherReportsIL
        '
        Me.lblOtherReportsIL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblOtherReportsIL.Location = New System.Drawing.Point(10, 35)
        Me.lblOtherReportsIL.Name = "lblOtherReportsIL"
        Me.lblOtherReportsIL.Size = New System.Drawing.Size(75, 20)
        Me.lblOtherReportsIL.TabIndex = 107
        Me.lblOtherReportsIL.TabStop = True
        Me.lblOtherReportsIL.Text = "Other Reports"
        Me.lblOtherReportsIL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnToGLCodeListIL
        '
        Me.BtnToGLCodeListIL.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnToGLCodeListIL.Location = New System.Drawing.Point(636, 270)
        Me.BtnToGLCodeListIL.Name = "BtnToGLCodeListIL"
        Me.BtnToGLCodeListIL.Size = New System.Drawing.Size(24, 20)
        Me.BtnToGLCodeListIL.TabIndex = 106
        Me.BtnToGLCodeListIL.TabStop = False
        Me.BtnToGLCodeListIL.UseVisualStyleBackColor = False
        '
        'txtToGLCodeIL
        '
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Me.txtToGLCodeIL.Appearance = Appearance5
        Me.txtToGLCodeIL.BackColor = System.Drawing.SystemColors.Window
        Me.txtToGLCodeIL.Location = New System.Drawing.Point(523, 268)
        Me.txtToGLCodeIL.MaxLength = 12
        Me.txtToGLCodeIL.Name = "txtToGLCodeIL"
        Me.txtToGLCodeIL.Size = New System.Drawing.Size(109, 21)
        Me.txtToGLCodeIL.TabIndex = 8
        Me.txtToGLCodeIL.Tag = "FK.PartyCode"
        '
        'txtToDivisionIL
        '
        Me.txtToDivisionIL.AcceptsReturn = True
        Me.txtToDivisionIL.AccessibleDescription = "YM.AUTO"
        Me.txtToDivisionIL.Location = New System.Drawing.Point(524, 220)
        Me.txtToDivisionIL.MaxLength = 10
        Me.txtToDivisionIL.Name = "txtToDivisionIL"
        Me.txtToDivisionIL.Size = New System.Drawing.Size(108, 21)
        Me.txtToDivisionIL.TabIndex = 4
        Me.txtToDivisionIL.Tag = "PK.TransactionNo"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(420, 220)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 20)
        Me.Label20.TabIndex = 105
        Me.Label20.Text = "To"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(420, 268)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 20)
        Me.Label21.TabIndex = 104
        Me.Label21.Text = "To "
        '
        'txtToTrDateIL
        '
        Me.txtToTrDateIL.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.txtToTrDateIL.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.txtToTrDateIL.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.txtToTrDateIL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtToTrDateIL.Location = New System.Drawing.Point(524, 244)
        Me.txtToTrDateIL.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.txtToTrDateIL.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.txtToTrDateIL.Name = "txtToTrDateIL"
        Me.txtToTrDateIL.Size = New System.Drawing.Size(108, 20)
        Me.txtToTrDateIL.TabIndex = 6
        Me.txtToTrDateIL.Tag = "dt.TransactionDate"
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(420, 244)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(112, 20)
        Me.Label22.TabIndex = 103
        Me.Label22.Text = "To"
        '
        'BtnFromGLCodeListIL
        '
        Me.BtnFromGLCodeListIL.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFromGLCodeListIL.Location = New System.Drawing.Point(364, 268)
        Me.BtnFromGLCodeListIL.Name = "BtnFromGLCodeListIL"
        Me.BtnFromGLCodeListIL.Size = New System.Drawing.Size(24, 20)
        Me.BtnFromGLCodeListIL.TabIndex = 99
        Me.BtnFromGLCodeListIL.TabStop = False
        Me.BtnFromGLCodeListIL.UseVisualStyleBackColor = False
        '
        'txtFromGLCodeIL
        '
        Appearance6.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromGLCodeIL.Appearance = Appearance6
        Me.txtFromGLCodeIL.BackColor = System.Drawing.SystemColors.Window
        Me.txtFromGLCodeIL.Location = New System.Drawing.Point(248, 268)
        Me.txtFromGLCodeIL.MaxLength = 12
        Me.txtFromGLCodeIL.Name = "txtFromGLCodeIL"
        Me.txtFromGLCodeIL.Size = New System.Drawing.Size(110, 21)
        Me.txtFromGLCodeIL.TabIndex = 7
        Me.txtFromGLCodeIL.Tag = "FK.PartyCode"
        '
        'txtFromDivisionCodeIL
        '
        Me.txtFromDivisionCodeIL.AcceptsReturn = True
        Me.txtFromDivisionCodeIL.AccessibleDescription = "YM.AUTO"
        Me.txtFromDivisionCodeIL.Location = New System.Drawing.Point(248, 220)
        Me.txtFromDivisionCodeIL.MaxLength = 10
        Me.txtFromDivisionCodeIL.Name = "txtFromDivisionCodeIL"
        Me.txtFromDivisionCodeIL.Size = New System.Drawing.Size(108, 21)
        Me.txtFromDivisionCodeIL.TabIndex = 3
        Me.txtFromDivisionCodeIL.Tag = "PK.TransactionNo"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.ForeColor = System.Drawing.Color.Navy
        Me.Label23.Location = New System.Drawing.Point(140, 224)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(110, 20)
        Me.Label23.TabIndex = 98
        Me.Label23.Text = "Division Code"
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(140, 272)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(110, 20)
        Me.Label24.TabIndex = 97
        Me.Label24.Text = "GL Code"
        '
        'txtFromTrDateIL
        '
        Me.txtFromTrDateIL.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.txtFromTrDateIL.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFromTrDateIL.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.txtFromTrDateIL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtFromTrDateIL.Location = New System.Drawing.Point(248, 244)
        Me.txtFromTrDateIL.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.txtFromTrDateIL.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.txtFromTrDateIL.Name = "txtFromTrDateIL"
        Me.txtFromTrDateIL.Size = New System.Drawing.Size(108, 20)
        Me.txtFromTrDateIL.TabIndex = 5
        Me.txtFromTrDateIL.Tag = "dt.TransactionDate"
        Me.txtFromTrDateIL.Value = New Date(2005, 7, 1, 0, 0, 0, 0)
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(140, 248)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(132, 20)
        Me.Label25.TabIndex = 96
        Me.Label25.Text = "Transaction Date"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(140, 176)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(88, 20)
        Me.Label26.TabIndex = 118
        Me.Label26.Text = "Level"
        '
        'BtnFromBranchListIL
        '
        Me.BtnFromBranchListIL.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFromBranchListIL.Location = New System.Drawing.Point(364, 194)
        Me.BtnFromBranchListIL.Name = "BtnFromBranchListIL"
        Me.BtnFromBranchListIL.Size = New System.Drawing.Size(24, 20)
        Me.BtnFromBranchListIL.TabIndex = 120
        Me.BtnFromBranchListIL.TabStop = False
        Me.BtnFromBranchListIL.UseVisualStyleBackColor = False
        '
        'lstTransactionNatureIL
        '
        Me.lstTransactionNatureIL.CheckBoxes = True
        Me.lstTransactionNatureIL.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.lstTransactionNatureIL.Location = New System.Drawing.Point(248, 148)
        Me.lstTransactionNatureIL.Name = "lstTransactionNatureIL"
        Me.lstTransactionNatureIL.Size = New System.Drawing.Size(384, 144)
        Me.lstTransactionNatureIL.TabIndex = 0
        Me.lstTransactionNatureIL.UseCompatibleStateImageBehavior = False
        Me.lstTransactionNatureIL.View = System.Windows.Forms.View.Details
        Me.lstTransactionNatureIL.Visible = False
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Document Types"
        Me.ColumnHeader2.Width = 185
        '
        'PnlProgressBare
        '
        Me.PnlProgressBare.Controls.Add(Me.imgProgressBar)
        Me.PnlProgressBare.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlProgressBare.Location = New System.Drawing.Point(0, 521)
        Me.PnlProgressBare.Name = "PnlProgressBare"
        Me.PnlProgressBare.Size = New System.Drawing.Size(804, 30)
        Me.PnlProgressBare.TabIndex = 22
        '
        'imgProgressBar
        '
        Me.imgProgressBar.Location = New System.Drawing.Point(28, 8)
        Me.imgProgressBar.Name = "imgProgressBar"
        Me.imgProgressBar.Size = New System.Drawing.Size(90, 20)
        Me.imgProgressBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imgProgressBar.TabIndex = 20
        Me.imgProgressBar.TabStop = False
        Me.imgProgressBar.Visible = False
        '
        'GrpVehicleBill
        '
        Me.GrpVehicleBill.Controls.Add(Me.ChkTripWithBill)
        Me.GrpVehicleBill.Controls.Add(Me.CmbGroupedByVB)
        Me.GrpVehicleBill.Controls.Add(Me.LblGroupByVB)
        Me.GrpVehicleBill.Controls.Add(Me.BtnToOwnerList)
        Me.GrpVehicleBill.Controls.Add(Me.TxtToOwnerCodeVB)
        Me.GrpVehicleBill.Controls.Add(Me.BtnFromOwnerList)
        Me.GrpVehicleBill.Controls.Add(Me.TxtFromOwnerCodeVB)
        Me.GrpVehicleBill.Controls.Add(Me.Label51)
        Me.GrpVehicleBill.Controls.Add(Me.BtnToVehicleList)
        Me.GrpVehicleBill.Controls.Add(Me.TxtToVehicleCodeVB)
        Me.GrpVehicleBill.Controls.Add(Me.Label35)
        Me.GrpVehicleBill.Controls.Add(Me.TxtFromVehicleCodeVB)
        Me.GrpVehicleBill.Controls.Add(Me.Label36)
        Me.GrpVehicleBill.Controls.Add(Me.LinkLabel1)
        Me.GrpVehicleBill.Controls.Add(Me.TxtToTransactionDateVB)
        Me.GrpVehicleBill.Controls.Add(Me.LblToDateVB)
        Me.GrpVehicleBill.Controls.Add(Me.TxtFromTransactionDateVB)
        Me.GrpVehicleBill.Controls.Add(Me.lblFromDateVB)
        Me.GrpVehicleBill.Controls.Add(Me.BtnFromVehicleList)
        Me.GrpVehicleBill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpVehicleBill.Location = New System.Drawing.Point(0, 0)
        Me.GrpVehicleBill.Name = "GrpVehicleBill"
        Me.GrpVehicleBill.Size = New System.Drawing.Size(804, 583)
        Me.GrpVehicleBill.TabIndex = 23
        Me.GrpVehicleBill.Text = "Vehicle Bills"
        Me.GrpVehicleBill.Visible = False
        '
        'ChkTripWithBill
        '
        Me.ChkTripWithBill.BackColor = System.Drawing.Color.Transparent
        Me.ChkTripWithBill.BackColorInternal = System.Drawing.Color.Transparent
        Me.ChkTripWithBill.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
        Me.ChkTripWithBill.Checked = True
        Me.ChkTripWithBill.CheckState = System.Windows.Forms.CheckState.Checked
        Appearance16.BackColor = System.Drawing.Color.Transparent
        Appearance16.BackColor2 = System.Drawing.Color.Transparent
        Me.ChkTripWithBill.HotTrackingAppearance = Appearance16
        Me.ChkTripWithBill.Location = New System.Drawing.Point(259, 262)
        Me.ChkTripWithBill.Name = "ChkTripWithBill"
        Me.ChkTripWithBill.Size = New System.Drawing.Size(299, 16)
        Me.ChkTripWithBill.TabIndex = 136
        Me.ChkTripWithBill.Text = "Show Trip Advance with Trip"
        '
        'CmbGroupedByVB
        '
        Me.CmbGroupedByVB.Items.AddRange(New Object() {"None", "Customer", "Owner"})
        Me.CmbGroupedByVB.Location = New System.Drawing.Point(259, 158)
        Me.CmbGroupedByVB.Name = "CmbGroupedByVB"
        Me.CmbGroupedByVB.Size = New System.Drawing.Size(140, 21)
        Me.CmbGroupedByVB.TabIndex = 134
        Me.CmbGroupedByVB.Text = "None"
        Me.CmbGroupedByVB.Visible = False
        '
        'LblGroupByVB
        '
        Me.LblGroupByVB.BackColor = System.Drawing.Color.Transparent
        Me.LblGroupByVB.ForeColor = System.Drawing.Color.Navy
        Me.LblGroupByVB.Location = New System.Drawing.Point(151, 158)
        Me.LblGroupByVB.Name = "LblGroupByVB"
        Me.LblGroupByVB.Size = New System.Drawing.Size(88, 20)
        Me.LblGroupByVB.TabIndex = 135
        Me.LblGroupByVB.Text = "Grouped by"
        Me.LblGroupByVB.Visible = False
        '
        'BtnToOwnerList
        '
        Me.BtnToOwnerList.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnToOwnerList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnToOwnerList.Location = New System.Drawing.Point(647, 185)
        Me.BtnToOwnerList.Name = "BtnToOwnerList"
        Me.BtnToOwnerList.Size = New System.Drawing.Size(24, 20)
        Me.BtnToOwnerList.TabIndex = 125
        Me.BtnToOwnerList.TabStop = False
        Me.BtnToOwnerList.UseVisualStyleBackColor = False
        '
        'TxtToOwnerCodeVB
        '
        Me.TxtToOwnerCodeVB.AcceptsReturn = True
        Me.TxtToOwnerCodeVB.AccessibleDescription = ""
        Me.TxtToOwnerCodeVB.Location = New System.Drawing.Point(542, 185)
        Me.TxtToOwnerCodeVB.MaxLength = Global.BusinessLeaf.My.MySettings.Default.VehicleOwnerCode_Length
        Me.TxtToOwnerCodeVB.Name = "TxtToOwnerCodeVB"
        Me.TxtToOwnerCodeVB.Size = New System.Drawing.Size(100, 21)
        Me.TxtToOwnerCodeVB.TabIndex = 124
        Me.TxtToOwnerCodeVB.Tag = "dd.ItemCode1"
        '
        'BtnFromOwnerList
        '
        Me.BtnFromOwnerList.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFromOwnerList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnFromOwnerList.Location = New System.Drawing.Point(364, 185)
        Me.BtnFromOwnerList.Name = "BtnFromOwnerList"
        Me.BtnFromOwnerList.Size = New System.Drawing.Size(24, 20)
        Me.BtnFromOwnerList.TabIndex = 123
        Me.BtnFromOwnerList.TabStop = False
        Me.BtnFromOwnerList.UseVisualStyleBackColor = False
        '
        'TxtFromOwnerCodeVB
        '
        Me.TxtFromOwnerCodeVB.AcceptsReturn = True
        Me.TxtFromOwnerCodeVB.AccessibleDescription = ""
        Me.TxtFromOwnerCodeVB.Location = New System.Drawing.Point(259, 185)
        Me.TxtFromOwnerCodeVB.MaxLength = Global.BusinessLeaf.My.MySettings.Default.VehicleOwnerCode_Length
        Me.TxtFromOwnerCodeVB.Name = "TxtFromOwnerCodeVB"
        Me.TxtFromOwnerCodeVB.Size = New System.Drawing.Size(100, 21)
        Me.TxtFromOwnerCodeVB.TabIndex = 121
        Me.TxtFromOwnerCodeVB.Tag = "dd.ItemCode1"
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.ForeColor = System.Drawing.Color.Navy
        Me.Label51.Location = New System.Drawing.Point(151, 186)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(110, 20)
        Me.Label51.TabIndex = 122
        Me.Label51.Text = "Owner"
        '
        'BtnToVehicleList
        '
        Me.BtnToVehicleList.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnToVehicleList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnToVehicleList.Location = New System.Drawing.Point(647, 211)
        Me.BtnToVehicleList.Name = "BtnToVehicleList"
        Me.BtnToVehicleList.Size = New System.Drawing.Size(24, 20)
        Me.BtnToVehicleList.TabIndex = 119
        Me.BtnToVehicleList.TabStop = False
        Me.BtnToVehicleList.UseVisualStyleBackColor = False
        '
        'TxtToVehicleCodeVB
        '
        Me.TxtToVehicleCodeVB.AcceptsReturn = True
        Me.TxtToVehicleCodeVB.AccessibleDescription = "YM.AUTO"
        Me.TxtToVehicleCodeVB.Location = New System.Drawing.Point(543, 211)
        Me.TxtToVehicleCodeVB.MaxLength = Global.BusinessLeaf.My.MySettings.Default.VehicleCode_Length
        Me.TxtToVehicleCodeVB.Name = "TxtToVehicleCodeVB"
        Me.TxtToVehicleCodeVB.Size = New System.Drawing.Size(100, 21)
        Me.TxtToVehicleCodeVB.TabIndex = 2
        Me.TxtToVehicleCodeVB.Tag = "dd.ItemCode1"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.Transparent
        Me.Label35.ForeColor = System.Drawing.Color.Navy
        Me.Label35.Location = New System.Drawing.Point(431, 211)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(112, 20)
        Me.Label35.TabIndex = 113
        Me.Label35.Text = "To "
        '
        'TxtFromVehicleCodeVB
        '
        Me.TxtFromVehicleCodeVB.AcceptsReturn = True
        Me.TxtFromVehicleCodeVB.AccessibleDescription = ""
        Me.TxtFromVehicleCodeVB.Location = New System.Drawing.Point(259, 211)
        Me.TxtFromVehicleCodeVB.MaxLength = 10
        Me.TxtFromVehicleCodeVB.Name = "TxtFromVehicleCodeVB"
        Me.TxtFromVehicleCodeVB.Size = New System.Drawing.Size(100, 21)
        Me.TxtFromVehicleCodeVB.TabIndex = 1
        Me.TxtFromVehicleCodeVB.Tag = "dd.ItemCode1"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Transparent
        Me.Label36.ForeColor = System.Drawing.Color.Navy
        Me.Label36.Location = New System.Drawing.Point(151, 211)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(110, 20)
        Me.Label36.TabIndex = 111
        Me.Label36.Text = "Vehicle No"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LinkLabel1.Location = New System.Drawing.Point(10, 35)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(75, 20)
        Me.LinkLabel1.TabIndex = 107
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Other Reports"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtToTransactionDateVB
        '
        Me.TxtToTransactionDateVB.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.TxtToTransactionDateVB.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtToTransactionDateVB.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.TxtToTransactionDateVB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtToTransactionDateVB.Location = New System.Drawing.Point(545, 236)
        Me.TxtToTransactionDateVB.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.TxtToTransactionDateVB.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.TxtToTransactionDateVB.Name = "TxtToTransactionDateVB"
        Me.TxtToTransactionDateVB.Size = New System.Drawing.Size(100, 20)
        Me.TxtToTransactionDateVB.TabIndex = 6
        Me.TxtToTransactionDateVB.Tag = "dt.TransactionDate"
        '
        'LblToDateVB
        '
        Me.LblToDateVB.BackColor = System.Drawing.Color.Transparent
        Me.LblToDateVB.ForeColor = System.Drawing.Color.Navy
        Me.LblToDateVB.Location = New System.Drawing.Point(433, 236)
        Me.LblToDateVB.Name = "LblToDateVB"
        Me.LblToDateVB.Size = New System.Drawing.Size(112, 20)
        Me.LblToDateVB.TabIndex = 103
        Me.LblToDateVB.Text = "To"
        '
        'TxtFromTransactionDateVB
        '
        Me.TxtFromTransactionDateVB.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.TxtFromTransactionDateVB.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtFromTransactionDateVB.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.TxtFromTransactionDateVB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtFromTransactionDateVB.Location = New System.Drawing.Point(259, 236)
        Me.TxtFromTransactionDateVB.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.TxtFromTransactionDateVB.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.TxtFromTransactionDateVB.Name = "TxtFromTransactionDateVB"
        Me.TxtFromTransactionDateVB.Size = New System.Drawing.Size(100, 20)
        Me.TxtFromTransactionDateVB.TabIndex = 5
        Me.TxtFromTransactionDateVB.Tag = "dt.TransactionDate"
        Me.TxtFromTransactionDateVB.Value = New Date(2010, 4, 21, 0, 0, 0, 0)
        '
        'lblFromDateVB
        '
        Me.lblFromDateVB.BackColor = System.Drawing.Color.Transparent
        Me.lblFromDateVB.ForeColor = System.Drawing.Color.Navy
        Me.lblFromDateVB.Location = New System.Drawing.Point(151, 240)
        Me.lblFromDateVB.Name = "lblFromDateVB"
        Me.lblFromDateVB.Size = New System.Drawing.Size(132, 20)
        Me.lblFromDateVB.TabIndex = 96
        Me.lblFromDateVB.Text = "From Date"
        '
        'BtnFromVehicleList
        '
        Me.BtnFromVehicleList.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFromVehicleList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnFromVehicleList.Location = New System.Drawing.Point(363, 211)
        Me.BtnFromVehicleList.Name = "BtnFromVehicleList"
        Me.BtnFromVehicleList.Size = New System.Drawing.Size(24, 20)
        Me.BtnFromVehicleList.TabIndex = 120
        Me.BtnFromVehicleList.TabStop = False
        Me.BtnFromVehicleList.UseVisualStyleBackColor = False
        '
        'GrpCOAReportList
        '
        Me.GrpCOAReportList.Controls.Add(Me.ChkPageBreakCOAL)
        Me.GrpCOAReportList.Controls.Add(Me.CmbLevelsCOAL)
        Me.GrpCOAReportList.Controls.Add(Me.Label43)
        Me.GrpCOAReportList.Controls.Add(Me.LinkLabel2)
        Me.GrpCOAReportList.Controls.Add(Me.Button2)
        Me.GrpCOAReportList.Controls.Add(Me.TxtToGlCodeCOAL)
        Me.GrpCOAReportList.Controls.Add(Me.Label34)
        Me.GrpCOAReportList.Controls.Add(Me.TxtToDefinitionDateCOAL)
        Me.GrpCOAReportList.Controls.Add(Me.Label44)
        Me.GrpCOAReportList.Controls.Add(Me.Button6)
        Me.GrpCOAReportList.Controls.Add(Me.TxtFromGlCodeCOAL)
        Me.GrpCOAReportList.Controls.Add(Me.Label45)
        Me.GrpCOAReportList.Controls.Add(Me.TxtFromDefinitionDateCOAL)
        Me.GrpCOAReportList.Controls.Add(Me.Label47)
        Me.GrpCOAReportList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpCOAReportList.Location = New System.Drawing.Point(0, 0)
        Me.GrpCOAReportList.Name = "GrpCOAReportList"
        Me.GrpCOAReportList.Size = New System.Drawing.Size(804, 583)
        Me.GrpCOAReportList.TabIndex = 24
        Me.GrpCOAReportList.Tag = "Transaction Document"
        Me.GrpCOAReportList.Visible = False
        '
        'ChkPageBreakCOAL
        '
        Me.ChkPageBreakCOAL.BackColor = System.Drawing.Color.Transparent
        Me.ChkPageBreakCOAL.Location = New System.Drawing.Point(240, 152)
        Me.ChkPageBreakCOAL.Name = "ChkPageBreakCOAL"
        Me.ChkPageBreakCOAL.Size = New System.Drawing.Size(116, 16)
        Me.ChkPageBreakCOAL.TabIndex = 123
        Me.ChkPageBreakCOAL.Text = "Page Break"
        Me.ChkPageBreakCOAL.UseVisualStyleBackColor = False
        '
        'CmbLevelsCOAL
        '
        Me.CmbLevelsCOAL.Items.AddRange(New Object() {"Control", "General", "Subsidiary", "SubSubsidiary", "Chart Of Account"})
        Me.CmbLevelsCOAL.Location = New System.Drawing.Point(240, 176)
        Me.CmbLevelsCOAL.Name = "CmbLevelsCOAL"
        Me.CmbLevelsCOAL.Size = New System.Drawing.Size(102, 21)
        Me.CmbLevelsCOAL.TabIndex = 121
        Me.CmbLevelsCOAL.Text = "Chart Of Account"
        '
        'Label43
        '
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.ForeColor = System.Drawing.Color.Navy
        Me.Label43.Location = New System.Drawing.Point(124, 184)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(88, 20)
        Me.Label43.TabIndex = 122
        Me.Label43.Text = "Levels"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LinkLabel2.Location = New System.Drawing.Point(10, 35)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(75, 20)
        Me.LinkLabel2.TabIndex = 107
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Other Reports"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(624, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(24, 20)
        Me.Button2.TabIndex = 106
        Me.Button2.TabStop = False
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TxtToGlCodeCOAL
        '
        Me.TxtToGlCodeCOAL.AcceptsReturn = True
        Me.TxtToGlCodeCOAL.Location = New System.Drawing.Point(520, 208)
        Me.TxtToGlCodeCOAL.MaxLength = Global.BusinessLeaf.My.MySettings.Default.GLCode_Length
        Me.TxtToGlCodeCOAL.Name = "TxtToGlCodeCOAL"
        Me.TxtToGlCodeCOAL.Size = New System.Drawing.Size(100, 21)
        Me.TxtToGlCodeCOAL.TabIndex = 1
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.ForeColor = System.Drawing.Color.Navy
        Me.Label34.Location = New System.Drawing.Point(404, 208)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(110, 20)
        Me.Label34.TabIndex = 105
        Me.Label34.Text = "To"
        '
        'TxtToDefinitionDateCOAL
        '
        Me.TxtToDefinitionDateCOAL.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.TxtToDefinitionDateCOAL.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtToDefinitionDateCOAL.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.TxtToDefinitionDateCOAL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtToDefinitionDateCOAL.Location = New System.Drawing.Point(520, 232)
        Me.TxtToDefinitionDateCOAL.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.TxtToDefinitionDateCOAL.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.TxtToDefinitionDateCOAL.Name = "TxtToDefinitionDateCOAL"
        Me.TxtToDefinitionDateCOAL.Size = New System.Drawing.Size(100, 20)
        Me.TxtToDefinitionDateCOAL.TabIndex = 3
        Me.TxtToDefinitionDateCOAL.Tag = "dt.TransactionDate"
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.ForeColor = System.Drawing.Color.Navy
        Me.Label44.Location = New System.Drawing.Point(404, 232)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(132, 20)
        Me.Label44.TabIndex = 103
        Me.Label44.Text = "To"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button6.Location = New System.Drawing.Point(344, 208)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(24, 20)
        Me.Button6.TabIndex = 99
        Me.Button6.TabStop = False
        Me.Button6.UseVisualStyleBackColor = False
        '
        'TxtFromGlCodeCOAL
        '
        Me.TxtFromGlCodeCOAL.AcceptsReturn = True
        Me.TxtFromGlCodeCOAL.AccessibleDescription = "YM.AUTO"
        Me.TxtFromGlCodeCOAL.Location = New System.Drawing.Point(240, 208)
        Me.TxtFromGlCodeCOAL.MaxLength = Global.BusinessLeaf.My.MySettings.Default.GLCode_Length
        Me.TxtFromGlCodeCOAL.Name = "TxtFromGlCodeCOAL"
        Me.TxtFromGlCodeCOAL.Size = New System.Drawing.Size(100, 21)
        Me.TxtFromGlCodeCOAL.TabIndex = 0
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(124, 212)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(110, 20)
        Me.Label45.TabIndex = 98
        Me.Label45.Text = "GL Code"
        '
        'TxtFromDefinitionDateCOAL
        '
        Me.TxtFromDefinitionDateCOAL.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.TxtFromDefinitionDateCOAL.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtFromDefinitionDateCOAL.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.TxtFromDefinitionDateCOAL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtFromDefinitionDateCOAL.Location = New System.Drawing.Point(240, 232)
        Me.TxtFromDefinitionDateCOAL.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.TxtFromDefinitionDateCOAL.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.TxtFromDefinitionDateCOAL.Name = "TxtFromDefinitionDateCOAL"
        Me.TxtFromDefinitionDateCOAL.Size = New System.Drawing.Size(100, 20)
        Me.TxtFromDefinitionDateCOAL.TabIndex = 2
        Me.TxtFromDefinitionDateCOAL.Tag = "dt.TransactionDate"
        Me.TxtFromDefinitionDateCOAL.Value = New Date(2005, 7, 1, 0, 0, 0, 0)
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.ForeColor = System.Drawing.Color.Navy
        Me.Label47.Location = New System.Drawing.Point(124, 236)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(132, 20)
        Me.Label47.TabIndex = 96
        Me.Label47.Text = "Definition Date"
        '
        'GrpVoucherDocuments
        '
        Me.GrpVoucherDocuments.Controls.Add(Me.BtnVoucherTypeListVDO)
        Me.GrpVoucherDocuments.Controls.Add(Me.TxtVoucherTypesVDO)
        Me.GrpVoucherDocuments.Controls.Add(Me.Label46)
        Me.GrpVoucherDocuments.Controls.Add(Me.LinkLabel3)
        Me.GrpVoucherDocuments.Controls.Add(Me.TxtToVoucherNoVDO)
        Me.GrpVoucherDocuments.Controls.Add(Me.Label50)
        Me.GrpVoucherDocuments.Controls.Add(Me.DtpToDefinitionDateVDO)
        Me.GrpVoucherDocuments.Controls.Add(Me.Label53)
        Me.GrpVoucherDocuments.Controls.Add(Me.TxtFromVoucherNoVDO)
        Me.GrpVoucherDocuments.Controls.Add(Me.Label54)
        Me.GrpVoucherDocuments.Controls.Add(Me.DtpFromDefinitionDateVDO)
        Me.GrpVoucherDocuments.Controls.Add(Me.Label56)
        Me.GrpVoucherDocuments.Controls.Add(Me.LvwVoucherTypesVDO)
        Me.GrpVoucherDocuments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpVoucherDocuments.Location = New System.Drawing.Point(0, 0)
        Me.GrpVoucherDocuments.Name = "GrpVoucherDocuments"
        Me.GrpVoucherDocuments.Size = New System.Drawing.Size(804, 521)
        Me.GrpVoucherDocuments.TabIndex = 25
        Me.GrpVoucherDocuments.Text = "Transaction List"
        Me.GrpVoucherDocuments.Visible = False
        '
        'BtnVoucherTypeListVDO
        '
        Me.BtnVoucherTypeListVDO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVoucherTypeListVDO.Location = New System.Drawing.Point(621, 240)
        Me.BtnVoucherTypeListVDO.Name = "BtnVoucherTypeListVDO"
        Me.BtnVoucherTypeListVDO.Size = New System.Drawing.Size(23, 18)
        Me.BtnVoucherTypeListVDO.TabIndex = 9
        Me.BtnVoucherTypeListVDO.Text = "--"
        '
        'TxtVoucherTypesVDO
        '
        Me.TxtVoucherTypesVDO.Location = New System.Drawing.Point(260, 239)
        Me.TxtVoucherTypesVDO.Name = "TxtVoucherTypesVDO"
        Me.TxtVoucherTypesVDO.Size = New System.Drawing.Size(385, 21)
        Me.TxtVoucherTypesVDO.TabIndex = 116
        Me.TxtVoucherTypesVDO.Text = " All Selected"
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.ForeColor = System.Drawing.Color.Navy
        Me.Label46.Location = New System.Drawing.Point(152, 241)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(110, 20)
        Me.Label46.TabIndex = 114
        Me.Label46.Text = "Voucher Types"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LinkLabel3.Location = New System.Drawing.Point(10, 35)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(75, 20)
        Me.LinkLabel3.TabIndex = 107
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Other Reports"
        Me.LinkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtToVoucherNoVDO
        '
        Me.TxtToVoucherNoVDO.AcceptsReturn = True
        Me.TxtToVoucherNoVDO.AccessibleDescription = "YM.AUTO"
        Me.TxtToVoucherNoVDO.Location = New System.Drawing.Point(544, 192)
        Me.TxtToVoucherNoVDO.MaxLength = 10
        Me.TxtToVoucherNoVDO.Name = "TxtToVoucherNoVDO"
        Me.TxtToVoucherNoVDO.Size = New System.Drawing.Size(100, 21)
        Me.TxtToVoucherNoVDO.TabIndex = 4
        Me.TxtToVoucherNoVDO.Tag = "PK.TransactionNo"
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.ForeColor = System.Drawing.Color.Navy
        Me.Label50.Location = New System.Drawing.Point(432, 192)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(112, 20)
        Me.Label50.TabIndex = 105
        Me.Label50.Text = "To"
        '
        'DtpToDefinitionDateVDO
        '
        Me.DtpToDefinitionDateVDO.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.DtpToDefinitionDateVDO.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.DtpToDefinitionDateVDO.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.DtpToDefinitionDateVDO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpToDefinitionDateVDO.Location = New System.Drawing.Point(544, 216)
        Me.DtpToDefinitionDateVDO.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.DtpToDefinitionDateVDO.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DtpToDefinitionDateVDO.Name = "DtpToDefinitionDateVDO"
        Me.DtpToDefinitionDateVDO.Size = New System.Drawing.Size(100, 20)
        Me.DtpToDefinitionDateVDO.TabIndex = 6
        Me.DtpToDefinitionDateVDO.Tag = "dt.TransactionDate"
        '
        'Label53
        '
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.ForeColor = System.Drawing.Color.Navy
        Me.Label53.Location = New System.Drawing.Point(432, 216)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(112, 20)
        Me.Label53.TabIndex = 103
        Me.Label53.Text = "To"
        '
        'TxtFromVoucherNoVDO
        '
        Me.TxtFromVoucherNoVDO.AcceptsReturn = True
        Me.TxtFromVoucherNoVDO.AccessibleDescription = "YM.AUTO"
        Me.TxtFromVoucherNoVDO.Location = New System.Drawing.Point(260, 192)
        Me.TxtFromVoucherNoVDO.MaxLength = 10
        Me.TxtFromVoucherNoVDO.Name = "TxtFromVoucherNoVDO"
        Me.TxtFromVoucherNoVDO.Size = New System.Drawing.Size(100, 21)
        Me.TxtFromVoucherNoVDO.TabIndex = 3
        Me.TxtFromVoucherNoVDO.Tag = "PK.TransactionNo"
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.ForeColor = System.Drawing.Color.Navy
        Me.Label54.Location = New System.Drawing.Point(152, 196)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(110, 20)
        Me.Label54.TabIndex = 98
        Me.Label54.Text = "Document No."
        '
        'DtpFromDefinitionDateVDO
        '
        Me.DtpFromDefinitionDateVDO.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.DtpFromDefinitionDateVDO.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.DtpFromDefinitionDateVDO.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.DtpFromDefinitionDateVDO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFromDefinitionDateVDO.Location = New System.Drawing.Point(260, 216)
        Me.DtpFromDefinitionDateVDO.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.DtpFromDefinitionDateVDO.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DtpFromDefinitionDateVDO.Name = "DtpFromDefinitionDateVDO"
        Me.DtpFromDefinitionDateVDO.Size = New System.Drawing.Size(100, 20)
        Me.DtpFromDefinitionDateVDO.TabIndex = 5
        Me.DtpFromDefinitionDateVDO.Tag = "dt.TransactionDate"
        Me.DtpFromDefinitionDateVDO.Value = New Date(2005, 7, 1, 0, 0, 0, 0)
        '
        'Label56
        '
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.ForeColor = System.Drawing.Color.Navy
        Me.Label56.Location = New System.Drawing.Point(152, 220)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(132, 20)
        Me.Label56.TabIndex = 96
        Me.Label56.Text = "Voucher Date"
        '
        'LvwVoucherTypesVDO
        '
        Me.LvwVoucherTypesVDO.CheckBoxes = True
        Me.LvwVoucherTypesVDO.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3})
        Me.LvwVoucherTypesVDO.Location = New System.Drawing.Point(260, 100)
        Me.LvwVoucherTypesVDO.Name = "LvwVoucherTypesVDO"
        Me.LvwVoucherTypesVDO.Size = New System.Drawing.Size(383, 140)
        Me.LvwVoucherTypesVDO.TabIndex = 115
        Me.LvwVoucherTypesVDO.UseCompatibleStateImageBehavior = False
        Me.LvwVoucherTypesVDO.View = System.Windows.Forms.View.Details
        Me.LvwVoucherTypesVDO.Visible = False
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Document Types"
        Me.ColumnHeader3.Width = 192
        '
        'GrpVouchersList
        '
        Me.GrpVouchersList.Controls.Add(Me.ChkPageBreakVLT)
        Me.GrpVouchersList.Controls.Add(Me.BtnToGLCodeListVLT)
        Me.GrpVouchersList.Controls.Add(Me.BtnVoucherTypesListVLT)
        Me.GrpVouchersList.Controls.Add(Me.TxtVoucherTypesVLT)
        Me.GrpVouchersList.Controls.Add(Me.Label48)
        Me.GrpVouchersList.Controls.Add(Me.TxtToGLCodeVLT)
        Me.GrpVouchersList.Controls.Add(Me.Label49)
        Me.GrpVouchersList.Controls.Add(Me.TxtFromGLCodeVLT)
        Me.GrpVouchersList.Controls.Add(Me.Label52)
        Me.GrpVouchersList.Controls.Add(Me.LinkLabel4)
        Me.GrpVouchersList.Controls.Add(Me.TxtToVoucherNoListVLT)
        Me.GrpVouchersList.Controls.Add(Me.Label55)
        Me.GrpVouchersList.Controls.Add(Me.DtpToVoucherDateVLT)
        Me.GrpVouchersList.Controls.Add(Me.Label58)
        Me.GrpVouchersList.Controls.Add(Me.TxtFromVoucherNoListVLT)
        Me.GrpVouchersList.Controls.Add(Me.Label59)
        Me.GrpVouchersList.Controls.Add(Me.DtpFromVoucherDateVLT)
        Me.GrpVouchersList.Controls.Add(Me.Label61)
        Me.GrpVouchersList.Controls.Add(Me.BtnFromGLCodeListVLT)
        Me.GrpVouchersList.Controls.Add(Me.CmbGroupedByVLT)
        Me.GrpVouchersList.Controls.Add(Me.Label62)
        Me.GrpVouchersList.Controls.Add(Me.LvwVoucherTypesVLT)
        Me.GrpVouchersList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpVouchersList.Location = New System.Drawing.Point(0, 0)
        Me.GrpVouchersList.Name = "GrpVouchersList"
        Me.GrpVouchersList.Size = New System.Drawing.Size(804, 521)
        Me.GrpVouchersList.TabIndex = 26
        Me.GrpVouchersList.Text = "Vouchers List"
        Me.GrpVouchersList.Visible = False
        '
        'ChkPageBreakVLT
        '
        Me.ChkPageBreakVLT.Location = New System.Drawing.Point(152, 140)
        Me.ChkPageBreakVLT.Name = "ChkPageBreakVLT"
        Me.ChkPageBreakVLT.Size = New System.Drawing.Size(116, 16)
        Me.ChkPageBreakVLT.TabIndex = 121
        Me.ChkPageBreakVLT.Text = "Page Break"
        '
        'BtnToGLCodeListVLT
        '
        Me.BtnToGLCodeListVLT.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnToGLCodeListVLT.Location = New System.Drawing.Point(648, 188)
        Me.BtnToGLCodeListVLT.Name = "BtnToGLCodeListVLT"
        Me.BtnToGLCodeListVLT.Size = New System.Drawing.Size(24, 20)
        Me.BtnToGLCodeListVLT.TabIndex = 119
        Me.BtnToGLCodeListVLT.TabStop = False
        Me.BtnToGLCodeListVLT.UseVisualStyleBackColor = False
        '
        'BtnVoucherTypesListVLT
        '
        Me.BtnVoucherTypesListVLT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVoucherTypesListVLT.Location = New System.Drawing.Point(617, 265)
        Me.BtnVoucherTypesListVLT.Name = "BtnVoucherTypesListVLT"
        Me.BtnVoucherTypesListVLT.Size = New System.Drawing.Size(23, 18)
        Me.BtnVoucherTypesListVLT.TabIndex = 9
        Me.BtnVoucherTypesListVLT.Text = "--"
        '
        'TxtVoucherTypesVLT
        '
        Me.TxtVoucherTypesVLT.Location = New System.Drawing.Point(260, 264)
        Me.TxtVoucherTypesVLT.Name = "TxtVoucherTypesVLT"
        Me.TxtVoucherTypesVLT.Size = New System.Drawing.Size(382, 21)
        Me.TxtVoucherTypesVLT.TabIndex = 116
        Me.TxtVoucherTypesVLT.Text = " All Selected"
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.ForeColor = System.Drawing.Color.Navy
        Me.Label48.Location = New System.Drawing.Point(152, 264)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(110, 20)
        Me.Label48.TabIndex = 114
        Me.Label48.Text = "Document Types"
        '
        'TxtToGLCodeVLT
        '
        Me.TxtToGLCodeVLT.AcceptsReturn = True
        Me.TxtToGLCodeVLT.AccessibleDescription = "YM.AUTO"
        Me.TxtToGLCodeVLT.Location = New System.Drawing.Point(544, 188)
        Me.TxtToGLCodeVLT.MaxLength = 22
        Me.TxtToGLCodeVLT.Name = "TxtToGLCodeVLT"
        Me.TxtToGLCodeVLT.Size = New System.Drawing.Size(100, 21)
        Me.TxtToGLCodeVLT.TabIndex = 2
        Me.TxtToGLCodeVLT.Tag = "dd.ItemCode1"
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.ForeColor = System.Drawing.Color.Navy
        Me.Label49.Location = New System.Drawing.Point(432, 188)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(112, 20)
        Me.Label49.TabIndex = 113
        Me.Label49.Text = "To "
        '
        'TxtFromGLCodeVLT
        '
        Me.TxtFromGLCodeVLT.AcceptsReturn = True
        Me.TxtFromGLCodeVLT.AccessibleDescription = ""
        Me.TxtFromGLCodeVLT.Location = New System.Drawing.Point(260, 192)
        Me.TxtFromGLCodeVLT.MaxLength = 22
        Me.TxtFromGLCodeVLT.Name = "TxtFromGLCodeVLT"
        Me.TxtFromGLCodeVLT.Size = New System.Drawing.Size(100, 21)
        Me.TxtFromGLCodeVLT.TabIndex = 1
        Me.TxtFromGLCodeVLT.Tag = "dd.ItemCode1"
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.ForeColor = System.Drawing.Color.Navy
        Me.Label52.Location = New System.Drawing.Point(152, 192)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(110, 20)
        Me.Label52.TabIndex = 111
        Me.Label52.Text = "GL Code"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LinkLabel4.Location = New System.Drawing.Point(10, 35)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(75, 20)
        Me.LinkLabel4.TabIndex = 107
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Other Reports"
        Me.LinkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtToVoucherNoListVLT
        '
        Me.TxtToVoucherNoListVLT.AcceptsReturn = True
        Me.TxtToVoucherNoListVLT.AccessibleDescription = "YM.AUTO"
        Me.TxtToVoucherNoListVLT.Location = New System.Drawing.Point(544, 216)
        Me.TxtToVoucherNoListVLT.MaxLength = 10
        Me.TxtToVoucherNoListVLT.Name = "TxtToVoucherNoListVLT"
        Me.TxtToVoucherNoListVLT.Size = New System.Drawing.Size(100, 21)
        Me.TxtToVoucherNoListVLT.TabIndex = 4
        Me.TxtToVoucherNoListVLT.Tag = "PK.TransactionNo"
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.ForeColor = System.Drawing.Color.Navy
        Me.Label55.Location = New System.Drawing.Point(432, 216)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(112, 20)
        Me.Label55.TabIndex = 105
        Me.Label55.Text = "To"
        '
        'DtpToVoucherDateVLT
        '
        Me.DtpToVoucherDateVLT.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.DtpToVoucherDateVLT.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.DtpToVoucherDateVLT.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.DtpToVoucherDateVLT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpToVoucherDateVLT.Location = New System.Drawing.Point(544, 240)
        Me.DtpToVoucherDateVLT.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.DtpToVoucherDateVLT.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DtpToVoucherDateVLT.Name = "DtpToVoucherDateVLT"
        Me.DtpToVoucherDateVLT.Size = New System.Drawing.Size(100, 20)
        Me.DtpToVoucherDateVLT.TabIndex = 6
        Me.DtpToVoucherDateVLT.Tag = "dt.TransactionDate"
        '
        'Label58
        '
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.ForeColor = System.Drawing.Color.Navy
        Me.Label58.Location = New System.Drawing.Point(432, 240)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(112, 20)
        Me.Label58.TabIndex = 103
        Me.Label58.Text = "To"
        '
        'TxtFromVoucherNoListVLT
        '
        Me.TxtFromVoucherNoListVLT.AcceptsReturn = True
        Me.TxtFromVoucherNoListVLT.AccessibleDescription = "YM.AUTO"
        Me.TxtFromVoucherNoListVLT.Location = New System.Drawing.Point(260, 216)
        Me.TxtFromVoucherNoListVLT.MaxLength = 10
        Me.TxtFromVoucherNoListVLT.Name = "TxtFromVoucherNoListVLT"
        Me.TxtFromVoucherNoListVLT.Size = New System.Drawing.Size(100, 21)
        Me.TxtFromVoucherNoListVLT.TabIndex = 3
        Me.TxtFromVoucherNoListVLT.Tag = "PK.TransactionNo"
        '
        'Label59
        '
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.ForeColor = System.Drawing.Color.Navy
        Me.Label59.Location = New System.Drawing.Point(152, 220)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(110, 20)
        Me.Label59.TabIndex = 98
        Me.Label59.Text = "Document No."
        '
        'DtpFromVoucherDateVLT
        '
        Me.DtpFromVoucherDateVLT.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.DtpFromVoucherDateVLT.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.DtpFromVoucherDateVLT.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.DtpFromVoucherDateVLT.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFromVoucherDateVLT.Location = New System.Drawing.Point(260, 240)
        Me.DtpFromVoucherDateVLT.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.DtpFromVoucherDateVLT.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DtpFromVoucherDateVLT.Name = "DtpFromVoucherDateVLT"
        Me.DtpFromVoucherDateVLT.Size = New System.Drawing.Size(100, 20)
        Me.DtpFromVoucherDateVLT.TabIndex = 5
        Me.DtpFromVoucherDateVLT.Tag = "dt.TransactionDate"
        Me.DtpFromVoucherDateVLT.Value = New Date(2005, 7, 1, 0, 0, 0, 0)
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.Color.Transparent
        Me.Label61.ForeColor = System.Drawing.Color.Navy
        Me.Label61.Location = New System.Drawing.Point(152, 244)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(132, 20)
        Me.Label61.TabIndex = 96
        Me.Label61.Text = "Document Date"
        '
        'BtnFromGLCodeListVLT
        '
        Me.BtnFromGLCodeListVLT.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFromGLCodeListVLT.Location = New System.Drawing.Point(364, 192)
        Me.BtnFromGLCodeListVLT.Name = "BtnFromGLCodeListVLT"
        Me.BtnFromGLCodeListVLT.Size = New System.Drawing.Size(24, 20)
        Me.BtnFromGLCodeListVLT.TabIndex = 120
        Me.BtnFromGLCodeListVLT.TabStop = False
        Me.BtnFromGLCodeListVLT.UseVisualStyleBackColor = False
        '
        'CmbGroupedByVLT
        '
        Me.CmbGroupedByVLT.Items.AddRange(New Object() {"None", "Document No.", "Document Date", "GL Code"})
        Me.CmbGroupedByVLT.Location = New System.Drawing.Point(260, 168)
        Me.CmbGroupedByVLT.Name = "CmbGroupedByVLT"
        Me.CmbGroupedByVLT.Size = New System.Drawing.Size(108, 21)
        Me.CmbGroupedByVLT.TabIndex = 0
        Me.CmbGroupedByVLT.Text = "None"
        '
        'Label62
        '
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.ForeColor = System.Drawing.Color.Navy
        Me.Label62.Location = New System.Drawing.Point(152, 172)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(88, 20)
        Me.Label62.TabIndex = 118
        Me.Label62.Text = "Grouped By"
        '
        'LvwVoucherTypesVLT
        '
        Me.LvwVoucherTypesVLT.CheckBoxes = True
        Me.LvwVoucherTypesVLT.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.LvwVoucherTypesVLT.Location = New System.Drawing.Point(260, 130)
        Me.LvwVoucherTypesVLT.Name = "LvwVoucherTypesVLT"
        Me.LvwVoucherTypesVLT.Size = New System.Drawing.Size(380, 135)
        Me.LvwVoucherTypesVLT.TabIndex = 115
        Me.LvwVoucherTypesVLT.UseCompatibleStateImageBehavior = False
        Me.LvwVoucherTypesVLT.View = System.Windows.Forms.View.Details
        Me.LvwVoucherTypesVLT.Visible = False
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Document Types"
        Me.ColumnHeader4.Width = 192
        '
        'GrpCashFlowStatements
        '
        Me.GrpCashFlowStatements.Controls.Add(Me.OptSummaryCFS)
        Me.GrpCashFlowStatements.Controls.Add(Me.OptDetailCFS)
        Me.GrpCashFlowStatements.Controls.Add(Me.Button4)
        Me.GrpCashFlowStatements.Controls.Add(Me.Button5)
        Me.GrpCashFlowStatements.Controls.Add(Me.ChkShowOpenningCFS)
        Me.GrpCashFlowStatements.Controls.Add(Me.ChkPageBreakCFS)
        Me.GrpCashFlowStatements.Controls.Add(Me.Button7)
        Me.GrpCashFlowStatements.Controls.Add(Me.BtnCashAccountsCFS)
        Me.GrpCashFlowStatements.Controls.Add(Me.TxtCashAccountsCFS)
        Me.GrpCashFlowStatements.Controls.Add(Me.Label41)
        Me.GrpCashFlowStatements.Controls.Add(Me.TxtToBranchCodeCFS)
        Me.GrpCashFlowStatements.Controls.Add(Me.Label60)
        Me.GrpCashFlowStatements.Controls.Add(Me.TxtFromBranchCodeCFS)
        Me.GrpCashFlowStatements.Controls.Add(Me.Label63)
        Me.GrpCashFlowStatements.Controls.Add(Me.LinkLabel5)
        Me.GrpCashFlowStatements.Controls.Add(Me.TxtToDivisionCFS)
        Me.GrpCashFlowStatements.Controls.Add(Me.Label64)
        Me.GrpCashFlowStatements.Controls.Add(Me.TxtToDateCFS)
        Me.GrpCashFlowStatements.Controls.Add(Me.Label66)
        Me.GrpCashFlowStatements.Controls.Add(Me.TxtFromDivisionCFS)
        Me.GrpCashFlowStatements.Controls.Add(Me.Label67)
        Me.GrpCashFlowStatements.Controls.Add(Me.TxtFromDateCFS)
        Me.GrpCashFlowStatements.Controls.Add(Me.Label69)
        Me.GrpCashFlowStatements.Controls.Add(Me.BtnFromBranchCodeCFS)
        Me.GrpCashFlowStatements.Controls.Add(Me.LstCashAccountsCFS)
        Me.GrpCashFlowStatements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpCashFlowStatements.Location = New System.Drawing.Point(0, 0)
        Me.GrpCashFlowStatements.Name = "GrpCashFlowStatements"
        Me.GrpCashFlowStatements.Size = New System.Drawing.Size(804, 583)
        Me.GrpCashFlowStatements.TabIndex = 27
        Me.GrpCashFlowStatements.Text = "Cash Flow Statements"
        Me.GrpCashFlowStatements.Visible = False
        '
        'OptSummaryCFS
        '
        Me.OptSummaryCFS.AutoSize = True
        Me.OptSummaryCFS.Location = New System.Drawing.Point(320, 296)
        Me.OptSummaryCFS.Name = "OptSummaryCFS"
        Me.OptSummaryCFS.Size = New System.Drawing.Size(68, 17)
        Me.OptSummaryCFS.TabIndex = 129
        Me.OptSummaryCFS.Text = "Summary"
        Me.OptSummaryCFS.UseVisualStyleBackColor = True
        '
        'OptDetailCFS
        '
        Me.OptDetailCFS.AutoSize = True
        Me.OptDetailCFS.Checked = True
        Me.OptDetailCFS.Location = New System.Drawing.Point(251, 296)
        Me.OptDetailCFS.Name = "OptDetailCFS"
        Me.OptDetailCFS.Size = New System.Drawing.Size(52, 17)
        Me.OptDetailCFS.TabIndex = 128
        Me.OptDetailCFS.TabStop = True
        Me.OptDetailCFS.Text = "Detail"
        Me.OptDetailCFS.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Location = New System.Drawing.Point(636, 222)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 20)
        Me.Button4.TabIndex = 126
        Me.Button4.TabStop = False
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(364, 220)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 20)
        Me.Button5.TabIndex = 127
        Me.Button5.TabStop = False
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ChkShowOpenningCFS
        '
        Me.ChkShowOpenningCFS.BackColor = System.Drawing.Color.Transparent
        Me.ChkShowOpenningCFS.Checked = True
        Me.ChkShowOpenningCFS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkShowOpenningCFS.Location = New System.Drawing.Point(248, 138)
        Me.ChkShowOpenningCFS.Name = "ChkShowOpenningCFS"
        Me.ChkShowOpenningCFS.Size = New System.Drawing.Size(116, 24)
        Me.ChkShowOpenningCFS.TabIndex = 123
        Me.ChkShowOpenningCFS.Text = "Show Opening"
        Me.ChkShowOpenningCFS.UseVisualStyleBackColor = False
        '
        'ChkPageBreakCFS
        '
        Me.ChkPageBreakCFS.BackColor = System.Drawing.Color.Transparent
        Me.ChkPageBreakCFS.Location = New System.Drawing.Point(140, 138)
        Me.ChkPageBreakCFS.Name = "ChkPageBreakCFS"
        Me.ChkPageBreakCFS.Size = New System.Drawing.Size(116, 24)
        Me.ChkPageBreakCFS.TabIndex = 121
        Me.ChkPageBreakCFS.Text = "Page Break"
        Me.ChkPageBreakCFS.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button7.Location = New System.Drawing.Point(636, 190)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(24, 20)
        Me.Button7.TabIndex = 119
        Me.Button7.TabStop = False
        Me.Button7.UseVisualStyleBackColor = False
        '
        'BtnCashAccountsCFS
        '
        Me.BtnCashAccountsCFS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCashAccountsCFS.Location = New System.Drawing.Point(608, 269)
        Me.BtnCashAccountsCFS.Name = "BtnCashAccountsCFS"
        Me.BtnCashAccountsCFS.Size = New System.Drawing.Size(23, 18)
        Me.BtnCashAccountsCFS.TabIndex = 117
        Me.BtnCashAccountsCFS.Text = "--"
        '
        'TxtCashAccountsCFS
        '
        Me.TxtCashAccountsCFS.Location = New System.Drawing.Point(248, 268)
        Me.TxtCashAccountsCFS.Name = "TxtCashAccountsCFS"
        Me.TxtCashAccountsCFS.Size = New System.Drawing.Size(384, 21)
        Me.TxtCashAccountsCFS.TabIndex = 116
        Me.TxtCashAccountsCFS.Text = "All Selected"
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.ForeColor = System.Drawing.Color.Navy
        Me.Label41.Location = New System.Drawing.Point(140, 272)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(110, 20)
        Me.Label41.TabIndex = 114
        Me.Label41.Text = "Cash Accounts"
        '
        'TxtToBranchCodeCFS
        '
        Me.TxtToBranchCodeCFS.AcceptsReturn = True
        Me.TxtToBranchCodeCFS.AccessibleDescription = "YM.AUTO"
        Me.TxtToBranchCodeCFS.Location = New System.Drawing.Point(524, 192)
        Me.TxtToBranchCodeCFS.MaxLength = 10
        Me.TxtToBranchCodeCFS.Name = "TxtToBranchCodeCFS"
        Me.TxtToBranchCodeCFS.Size = New System.Drawing.Size(108, 21)
        Me.TxtToBranchCodeCFS.TabIndex = 2
        Me.TxtToBranchCodeCFS.Tag = "dd.ItemCode1"
        '
        'Label60
        '
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.ForeColor = System.Drawing.Color.Navy
        Me.Label60.Location = New System.Drawing.Point(420, 192)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(112, 20)
        Me.Label60.TabIndex = 113
        Me.Label60.Text = "To "
        '
        'TxtFromBranchCodeCFS
        '
        Me.TxtFromBranchCodeCFS.AcceptsReturn = True
        Me.TxtFromBranchCodeCFS.AccessibleDescription = ""
        Me.TxtFromBranchCodeCFS.Location = New System.Drawing.Point(248, 196)
        Me.TxtFromBranchCodeCFS.MaxLength = 10
        Me.TxtFromBranchCodeCFS.Name = "TxtFromBranchCodeCFS"
        Me.TxtFromBranchCodeCFS.Size = New System.Drawing.Size(108, 21)
        Me.TxtFromBranchCodeCFS.TabIndex = 1
        Me.TxtFromBranchCodeCFS.Tag = "dd.ItemCode1"
        '
        'Label63
        '
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.ForeColor = System.Drawing.Color.Navy
        Me.Label63.Location = New System.Drawing.Point(140, 196)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(110, 20)
        Me.Label63.TabIndex = 111
        Me.Label63.Text = "Branch Code"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LinkLabel5.Location = New System.Drawing.Point(10, 35)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(75, 20)
        Me.LinkLabel5.TabIndex = 107
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Other Reports"
        Me.LinkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtToDivisionCFS
        '
        Me.TxtToDivisionCFS.AcceptsReturn = True
        Me.TxtToDivisionCFS.AccessibleDescription = "YM.AUTO"
        Me.TxtToDivisionCFS.Location = New System.Drawing.Point(524, 220)
        Me.TxtToDivisionCFS.MaxLength = 10
        Me.TxtToDivisionCFS.Name = "TxtToDivisionCFS"
        Me.TxtToDivisionCFS.Size = New System.Drawing.Size(108, 21)
        Me.TxtToDivisionCFS.TabIndex = 4
        Me.TxtToDivisionCFS.Tag = "PK.TransactionNo"
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.ForeColor = System.Drawing.Color.Navy
        Me.Label64.Location = New System.Drawing.Point(420, 220)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(112, 20)
        Me.Label64.TabIndex = 105
        Me.Label64.Text = "To"
        '
        'TxtToDateCFS
        '
        Me.TxtToDateCFS.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.TxtToDateCFS.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtToDateCFS.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.TxtToDateCFS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtToDateCFS.Location = New System.Drawing.Point(524, 244)
        Me.TxtToDateCFS.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.TxtToDateCFS.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.TxtToDateCFS.Name = "TxtToDateCFS"
        Me.TxtToDateCFS.Size = New System.Drawing.Size(108, 20)
        Me.TxtToDateCFS.TabIndex = 6
        Me.TxtToDateCFS.Tag = "dt.TransactionDate"
        '
        'Label66
        '
        Me.Label66.BackColor = System.Drawing.Color.Transparent
        Me.Label66.ForeColor = System.Drawing.Color.Navy
        Me.Label66.Location = New System.Drawing.Point(420, 244)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(112, 20)
        Me.Label66.TabIndex = 103
        Me.Label66.Text = "To"
        '
        'TxtFromDivisionCFS
        '
        Me.TxtFromDivisionCFS.AcceptsReturn = True
        Me.TxtFromDivisionCFS.AccessibleDescription = "YM.AUTO"
        Me.TxtFromDivisionCFS.Location = New System.Drawing.Point(248, 220)
        Me.TxtFromDivisionCFS.MaxLength = 10
        Me.TxtFromDivisionCFS.Name = "TxtFromDivisionCFS"
        Me.TxtFromDivisionCFS.Size = New System.Drawing.Size(108, 21)
        Me.TxtFromDivisionCFS.TabIndex = 3
        Me.TxtFromDivisionCFS.Tag = "PK.TransactionNo"
        '
        'Label67
        '
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.ForeColor = System.Drawing.Color.Navy
        Me.Label67.Location = New System.Drawing.Point(140, 224)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(110, 20)
        Me.Label67.TabIndex = 98
        Me.Label67.Text = "Division Code"
        '
        'TxtFromDateCFS
        '
        Me.TxtFromDateCFS.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.TxtFromDateCFS.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtFromDateCFS.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.TxtFromDateCFS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtFromDateCFS.Location = New System.Drawing.Point(248, 244)
        Me.TxtFromDateCFS.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.TxtFromDateCFS.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.TxtFromDateCFS.Name = "TxtFromDateCFS"
        Me.TxtFromDateCFS.Size = New System.Drawing.Size(108, 20)
        Me.TxtFromDateCFS.TabIndex = 5
        Me.TxtFromDateCFS.Tag = "dt.TransactionDate"
        Me.TxtFromDateCFS.Value = New Date(2005, 7, 1, 0, 0, 0, 0)
        '
        'Label69
        '
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.ForeColor = System.Drawing.Color.Navy
        Me.Label69.Location = New System.Drawing.Point(140, 248)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(132, 20)
        Me.Label69.TabIndex = 96
        Me.Label69.Text = "Document Date"
        '
        'BtnFromBranchCodeCFS
        '
        Me.BtnFromBranchCodeCFS.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFromBranchCodeCFS.Location = New System.Drawing.Point(364, 194)
        Me.BtnFromBranchCodeCFS.Name = "BtnFromBranchCodeCFS"
        Me.BtnFromBranchCodeCFS.Size = New System.Drawing.Size(24, 20)
        Me.BtnFromBranchCodeCFS.TabIndex = 120
        Me.BtnFromBranchCodeCFS.TabStop = False
        Me.BtnFromBranchCodeCFS.UseVisualStyleBackColor = False
        '
        'LstCashAccountsCFS
        '
        Me.LstCashAccountsCFS.CheckBoxes = True
        Me.LstCashAccountsCFS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5})
        Me.LstCashAccountsCFS.Location = New System.Drawing.Point(248, 124)
        Me.LstCashAccountsCFS.Name = "LstCashAccountsCFS"
        Me.LstCashAccountsCFS.ShowItemToolTips = True
        Me.LstCashAccountsCFS.Size = New System.Drawing.Size(384, 144)
        Me.LstCashAccountsCFS.TabIndex = 0
        Me.LstCashAccountsCFS.UseCompatibleStateImageBehavior = False
        Me.LstCashAccountsCFS.View = System.Windows.Forms.View.Details
        Me.LstCashAccountsCFS.Visible = False
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Cash & Bank Accounts"
        Me.ColumnHeader5.Width = 185
        '
        'GrpFinancialStatements
        '
        Me.GrpFinancialStatements.Controls.Add(Me.BtnToGLCodeListFS)
        Me.GrpFinancialStatements.Controls.Add(Me.BtnFrGLCodeListFS)
        Me.GrpFinancialStatements.Controls.Add(Me.ChkNotesToFS)
        Me.GrpFinancialStatements.Controls.Add(Me.LinkLabel6)
        Me.GrpFinancialStatements.Controls.Add(Me.TxtToGLCodeFS)
        Me.GrpFinancialStatements.Controls.Add(Me.Label68)
        Me.GrpFinancialStatements.Controls.Add(Me.TxtToDateFS)
        Me.GrpFinancialStatements.Controls.Add(Me.Label70)
        Me.GrpFinancialStatements.Controls.Add(Me.TxtFromGLCodeFS)
        Me.GrpFinancialStatements.Controls.Add(Me.Label71)
        Me.GrpFinancialStatements.Controls.Add(Me.TxtFromDateFS)
        Me.GrpFinancialStatements.Controls.Add(Me.Label72)
        Me.GrpFinancialStatements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpFinancialStatements.Location = New System.Drawing.Point(0, 0)
        Me.GrpFinancialStatements.Name = "GrpFinancialStatements"
        Me.GrpFinancialStatements.Size = New System.Drawing.Size(804, 583)
        Me.GrpFinancialStatements.TabIndex = 28
        Me.GrpFinancialStatements.Text = "Financial Statements"
        Me.GrpFinancialStatements.Visible = False
        '
        'BtnToGLCodeListFS
        '
        Me.BtnToGLCodeListFS.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnToGLCodeListFS.Location = New System.Drawing.Point(636, 219)
        Me.BtnToGLCodeListFS.Name = "BtnToGLCodeListFS"
        Me.BtnToGLCodeListFS.Size = New System.Drawing.Size(24, 20)
        Me.BtnToGLCodeListFS.TabIndex = 126
        Me.BtnToGLCodeListFS.TabStop = False
        Me.BtnToGLCodeListFS.UseVisualStyleBackColor = False
        Me.BtnToGLCodeListFS.Visible = False
        '
        'BtnFrGLCodeListFS
        '
        Me.BtnFrGLCodeListFS.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFrGLCodeListFS.Location = New System.Drawing.Point(364, 220)
        Me.BtnFrGLCodeListFS.Name = "BtnFrGLCodeListFS"
        Me.BtnFrGLCodeListFS.Size = New System.Drawing.Size(24, 20)
        Me.BtnFrGLCodeListFS.TabIndex = 127
        Me.BtnFrGLCodeListFS.TabStop = False
        Me.BtnFrGLCodeListFS.UseVisualStyleBackColor = False
        Me.BtnFrGLCodeListFS.Visible = False
        '
        'ChkNotesToFS
        '
        Me.ChkNotesToFS.BackColor = System.Drawing.Color.Transparent
        Me.ChkNotesToFS.Location = New System.Drawing.Point(143, 192)
        Me.ChkNotesToFS.Name = "ChkNotesToFS"
        Me.ChkNotesToFS.Size = New System.Drawing.Size(182, 24)
        Me.ChkNotesToFS.TabIndex = 121
        Me.ChkNotesToFS.Text = "Notes To Financial Statements"
        Me.ChkNotesToFS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkNotesToFS.UseVisualStyleBackColor = False
        '
        'LinkLabel6
        '
        Me.LinkLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LinkLabel6.Location = New System.Drawing.Point(10, 35)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(75, 20)
        Me.LinkLabel6.TabIndex = 107
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Other Reports"
        Me.LinkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtToGLCodeFS
        '
        Me.TxtToGLCodeFS.AcceptsReturn = True
        Me.TxtToGLCodeFS.AccessibleDescription = "YM.AUTO"
        Me.TxtToGLCodeFS.Location = New System.Drawing.Point(524, 220)
        Me.TxtToGLCodeFS.MaxLength = 10
        Me.TxtToGLCodeFS.Name = "TxtToGLCodeFS"
        Me.TxtToGLCodeFS.Size = New System.Drawing.Size(108, 21)
        Me.TxtToGLCodeFS.TabIndex = 4
        Me.TxtToGLCodeFS.Tag = "PK.TransactionNo"
        Me.TxtToGLCodeFS.Visible = False
        '
        'Label68
        '
        Me.Label68.BackColor = System.Drawing.Color.Transparent
        Me.Label68.ForeColor = System.Drawing.Color.Navy
        Me.Label68.Location = New System.Drawing.Point(420, 220)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(112, 20)
        Me.Label68.TabIndex = 105
        Me.Label68.Text = "To"
        Me.Label68.Visible = False
        '
        'TxtToDateFS
        '
        Me.TxtToDateFS.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.TxtToDateFS.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtToDateFS.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.TxtToDateFS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtToDateFS.Location = New System.Drawing.Point(524, 244)
        Me.TxtToDateFS.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.TxtToDateFS.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.TxtToDateFS.Name = "TxtToDateFS"
        Me.TxtToDateFS.Size = New System.Drawing.Size(108, 20)
        Me.TxtToDateFS.TabIndex = 6
        Me.TxtToDateFS.Tag = "dt.TransactionDate"
        '
        'Label70
        '
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.ForeColor = System.Drawing.Color.Navy
        Me.Label70.Location = New System.Drawing.Point(420, 244)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(112, 20)
        Me.Label70.TabIndex = 103
        Me.Label70.Text = "To"
        '
        'TxtFromGLCodeFS
        '
        Me.TxtFromGLCodeFS.AcceptsReturn = True
        Me.TxtFromGLCodeFS.AccessibleDescription = "YM.AUTO"
        Me.TxtFromGLCodeFS.Location = New System.Drawing.Point(248, 220)
        Me.TxtFromGLCodeFS.MaxLength = 10
        Me.TxtFromGLCodeFS.Name = "TxtFromGLCodeFS"
        Me.TxtFromGLCodeFS.Size = New System.Drawing.Size(108, 21)
        Me.TxtFromGLCodeFS.TabIndex = 3
        Me.TxtFromGLCodeFS.Tag = "PK.TransactionNo"
        Me.TxtFromGLCodeFS.Visible = False
        '
        'Label71
        '
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.ForeColor = System.Drawing.Color.Navy
        Me.Label71.Location = New System.Drawing.Point(140, 224)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(110, 20)
        Me.Label71.TabIndex = 98
        Me.Label71.Text = "GL Code"
        Me.Label71.Visible = False
        '
        'TxtFromDateFS
        '
        Me.TxtFromDateFS.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.TxtFromDateFS.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtFromDateFS.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.TxtFromDateFS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtFromDateFS.Location = New System.Drawing.Point(248, 244)
        Me.TxtFromDateFS.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.TxtFromDateFS.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.TxtFromDateFS.Name = "TxtFromDateFS"
        Me.TxtFromDateFS.Size = New System.Drawing.Size(108, 20)
        Me.TxtFromDateFS.TabIndex = 5
        Me.TxtFromDateFS.Tag = "dt.TransactionDate"
        Me.TxtFromDateFS.Value = New Date(2005, 7, 1, 0, 0, 0, 0)
        '
        'Label72
        '
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.ForeColor = System.Drawing.Color.Navy
        Me.Label72.Location = New System.Drawing.Point(140, 248)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(132, 20)
        Me.Label72.TabIndex = 96
        Me.Label72.Text = "Document Date"
        '
        'GrpVehicleFreightStatements
        '
        Me.GrpVehicleFreightStatements.Controls.Add(Me.CmbGroupbyVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.Label73)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.TxtToTransactionNoVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.Label40)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.TxtFromTransactionNoVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.Label65)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.CmbReportTypeVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.Label38)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.OptSummaryVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.OptDetailVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.BtnToVehicleListVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.BtnFromVehicleListVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.ChkPageBreakVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.TxtFromBranchVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.Label74)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.CmbOnBasisVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.LinkLabel7)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.BtnToCustomerListVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.TxtToCustomerVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.TxtToVehicleVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.Label75)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.Label76)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.DtpToDateVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.Label77)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.BtnFromCustomerListVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.TxtFromCustomerVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.TxtFromVehicleVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.Label78)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.Label79)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.DtpFromDateVFS)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.Label80)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.Label81)
        Me.GrpVehicleFreightStatements.Controls.Add(Me.BtnFromBranchListVFS)
        Me.GrpVehicleFreightStatements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpVehicleFreightStatements.Location = New System.Drawing.Point(0, 0)
        Me.GrpVehicleFreightStatements.Name = "GrpVehicleFreightStatements"
        Me.GrpVehicleFreightStatements.Size = New System.Drawing.Size(804, 583)
        Me.GrpVehicleFreightStatements.TabIndex = 29
        Me.GrpVehicleFreightStatements.Text = "Vehicle Freight Statements"
        Me.GrpVehicleFreightStatements.Visible = False
        '
        'CmbGroupbyVFS
        '
        Me.CmbGroupbyVFS.Items.AddRange(New Object() {"None", "Date", "Customer", "Vehicle", "Branch"})
        Me.CmbGroupbyVFS.Location = New System.Drawing.Point(524, 171)
        Me.CmbGroupbyVFS.Name = "CmbGroupbyVFS"
        Me.CmbGroupbyVFS.Size = New System.Drawing.Size(108, 21)
        Me.CmbGroupbyVFS.TabIndex = 2
        Me.CmbGroupbyVFS.Text = "None"
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.ForeColor = System.Drawing.Color.Navy
        Me.Label73.Location = New System.Drawing.Point(420, 173)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(88, 20)
        Me.Label73.TabIndex = 138
        Me.Label73.Text = "Grouped By"
        '
        'TxtToTransactionNoVFS
        '
        Appearance8.BackColor = System.Drawing.SystemColors.Window
        Me.TxtToTransactionNoVFS.Appearance = Appearance8
        Me.TxtToTransactionNoVFS.BackColor = System.Drawing.SystemColors.Window
        Me.TxtToTransactionNoVFS.Location = New System.Drawing.Point(523, 268)
        Me.TxtToTransactionNoVFS.MaxLength = 12
        Me.TxtToTransactionNoVFS.Name = "TxtToTransactionNoVFS"
        Me.TxtToTransactionNoVFS.Size = New System.Drawing.Size(109, 21)
        Me.TxtToTransactionNoVFS.TabIndex = 9
        Me.TxtToTransactionNoVFS.Tag = "FK.PartyCode"
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.ForeColor = System.Drawing.Color.Navy
        Me.Label40.Location = New System.Drawing.Point(420, 268)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(112, 20)
        Me.Label40.TabIndex = 136
        Me.Label40.Text = "To "
        '
        'TxtFromTransactionNoVFS
        '
        Appearance9.BackColor = System.Drawing.SystemColors.Window
        Me.TxtFromTransactionNoVFS.Appearance = Appearance9
        Me.TxtFromTransactionNoVFS.BackColor = System.Drawing.SystemColors.Window
        Me.TxtFromTransactionNoVFS.Location = New System.Drawing.Point(248, 268)
        Me.TxtFromTransactionNoVFS.MaxLength = 12
        Me.TxtFromTransactionNoVFS.Name = "TxtFromTransactionNoVFS"
        Me.TxtFromTransactionNoVFS.Size = New System.Drawing.Size(110, 21)
        Me.TxtFromTransactionNoVFS.TabIndex = 8
        Me.TxtFromTransactionNoVFS.Tag = "FK.PartyCode"
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.Color.Transparent
        Me.Label65.ForeColor = System.Drawing.Color.Navy
        Me.Label65.Location = New System.Drawing.Point(140, 272)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(110, 20)
        Me.Label65.TabIndex = 134
        Me.Label65.Text = "Invoice No"
        '
        'CmbReportTypeVFS
        '
        Me.CmbReportTypeVFS.Items.AddRange(New Object() {"Freight Statements", "Freight Summary"})
        Me.CmbReportTypeVFS.Location = New System.Drawing.Point(248, 147)
        Me.CmbReportTypeVFS.Name = "CmbReportTypeVFS"
        Me.CmbReportTypeVFS.Size = New System.Drawing.Size(140, 21)
        Me.CmbReportTypeVFS.TabIndex = 0
        Me.CmbReportTypeVFS.Text = "Freight Statements"
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.ForeColor = System.Drawing.Color.Navy
        Me.Label38.Location = New System.Drawing.Point(140, 147)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(88, 20)
        Me.Label38.TabIndex = 131
        Me.Label38.Text = "Report Type"
        '
        'OptSummaryVFS
        '
        Me.OptSummaryVFS.AutoSize = True
        Me.OptSummaryVFS.BackColor = System.Drawing.Color.Transparent
        Me.OptSummaryVFS.Location = New System.Drawing.Point(320, 327)
        Me.OptSummaryVFS.Name = "OptSummaryVFS"
        Me.OptSummaryVFS.Size = New System.Drawing.Size(68, 17)
        Me.OptSummaryVFS.TabIndex = 129
        Me.OptSummaryVFS.Text = "Summary"
        Me.OptSummaryVFS.UseVisualStyleBackColor = False
        '
        'OptDetailVFS
        '
        Me.OptDetailVFS.AutoSize = True
        Me.OptDetailVFS.BackColor = System.Drawing.Color.Transparent
        Me.OptDetailVFS.Checked = True
        Me.OptDetailVFS.Location = New System.Drawing.Point(251, 327)
        Me.OptDetailVFS.Name = "OptDetailVFS"
        Me.OptDetailVFS.Size = New System.Drawing.Size(52, 17)
        Me.OptDetailVFS.TabIndex = 128
        Me.OptDetailVFS.TabStop = True
        Me.OptDetailVFS.Text = "Detail"
        Me.OptDetailVFS.UseVisualStyleBackColor = False
        '
        'BtnToVehicleListVFS
        '
        Me.BtnToVehicleListVFS.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnToVehicleListVFS.Location = New System.Drawing.Point(636, 219)
        Me.BtnToVehicleListVFS.Name = "BtnToVehicleListVFS"
        Me.BtnToVehicleListVFS.Size = New System.Drawing.Size(24, 20)
        Me.BtnToVehicleListVFS.TabIndex = 126
        Me.BtnToVehicleListVFS.TabStop = False
        Me.BtnToVehicleListVFS.UseVisualStyleBackColor = False
        '
        'BtnFromVehicleListVFS
        '
        Me.BtnFromVehicleListVFS.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFromVehicleListVFS.Location = New System.Drawing.Point(364, 220)
        Me.BtnFromVehicleListVFS.Name = "BtnFromVehicleListVFS"
        Me.BtnFromVehicleListVFS.Size = New System.Drawing.Size(24, 20)
        Me.BtnFromVehicleListVFS.TabIndex = 127
        Me.BtnFromVehicleListVFS.TabStop = False
        Me.BtnFromVehicleListVFS.UseVisualStyleBackColor = False
        '
        'ChkPageBreakVFS
        '
        Me.ChkPageBreakVFS.BackColor = System.Drawing.Color.Transparent
        Me.ChkPageBreakVFS.Location = New System.Drawing.Point(523, 327)
        Me.ChkPageBreakVFS.Name = "ChkPageBreakVFS"
        Me.ChkPageBreakVFS.Size = New System.Drawing.Size(116, 16)
        Me.ChkPageBreakVFS.TabIndex = 121
        Me.ChkPageBreakVFS.Text = "Page Break"
        Me.ChkPageBreakVFS.UseVisualStyleBackColor = False
        '
        'TxtFromBranchVFS
        '
        Me.TxtFromBranchVFS.AcceptsReturn = True
        Me.TxtFromBranchVFS.AccessibleDescription = ""
        Me.TxtFromBranchVFS.Location = New System.Drawing.Point(248, 196)
        Me.TxtFromBranchVFS.MaxLength = 10
        Me.TxtFromBranchVFS.Name = "TxtFromBranchVFS"
        Me.TxtFromBranchVFS.Size = New System.Drawing.Size(108, 21)
        Me.TxtFromBranchVFS.TabIndex = 3
        Me.TxtFromBranchVFS.Tag = "dd.ItemCode1"
        '
        'Label74
        '
        Me.Label74.BackColor = System.Drawing.Color.Transparent
        Me.Label74.ForeColor = System.Drawing.Color.Navy
        Me.Label74.Location = New System.Drawing.Point(140, 198)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(110, 20)
        Me.Label74.TabIndex = 111
        Me.Label74.Text = "Branch Code"
        '
        'CmbOnBasisVFS
        '
        Me.CmbOnBasisVFS.Items.AddRange(New Object() {"Branch Wise", "Consolidate"})
        Me.CmbOnBasisVFS.Location = New System.Drawing.Point(248, 172)
        Me.CmbOnBasisVFS.Name = "CmbOnBasisVFS"
        Me.CmbOnBasisVFS.Size = New System.Drawing.Size(140, 21)
        Me.CmbOnBasisVFS.TabIndex = 1
        Me.CmbOnBasisVFS.Text = "Branch Wise"
        '
        'LinkLabel7
        '
        Me.LinkLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LinkLabel7.Location = New System.Drawing.Point(10, 35)
        Me.LinkLabel7.Name = "LinkLabel7"
        Me.LinkLabel7.Size = New System.Drawing.Size(75, 20)
        Me.LinkLabel7.TabIndex = 107
        Me.LinkLabel7.TabStop = True
        Me.LinkLabel7.Text = "Other Reports"
        Me.LinkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnToCustomerListVFS
        '
        Me.BtnToCustomerListVFS.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnToCustomerListVFS.Location = New System.Drawing.Point(636, 245)
        Me.BtnToCustomerListVFS.Name = "BtnToCustomerListVFS"
        Me.BtnToCustomerListVFS.Size = New System.Drawing.Size(24, 20)
        Me.BtnToCustomerListVFS.TabIndex = 106
        Me.BtnToCustomerListVFS.TabStop = False
        Me.BtnToCustomerListVFS.UseVisualStyleBackColor = False
        '
        'TxtToCustomerVFS
        '
        Appearance10.BackColor = System.Drawing.SystemColors.Window
        Me.TxtToCustomerVFS.Appearance = Appearance10
        Me.TxtToCustomerVFS.BackColor = System.Drawing.SystemColors.Window
        Me.TxtToCustomerVFS.Location = New System.Drawing.Point(523, 245)
        Me.TxtToCustomerVFS.MaxLength = 12
        Me.TxtToCustomerVFS.Name = "TxtToCustomerVFS"
        Me.TxtToCustomerVFS.Size = New System.Drawing.Size(109, 21)
        Me.TxtToCustomerVFS.TabIndex = 7
        Me.TxtToCustomerVFS.Tag = "FK.PartyCode"
        '
        'TxtToVehicleVFS
        '
        Me.TxtToVehicleVFS.AcceptsReturn = True
        Me.TxtToVehicleVFS.AccessibleDescription = "YM.AUTO"
        Me.TxtToVehicleVFS.Location = New System.Drawing.Point(524, 220)
        Me.TxtToVehicleVFS.MaxLength = 10
        Me.TxtToVehicleVFS.Name = "TxtToVehicleVFS"
        Me.TxtToVehicleVFS.Size = New System.Drawing.Size(108, 21)
        Me.TxtToVehicleVFS.TabIndex = 5
        Me.TxtToVehicleVFS.Tag = "PK.TransactionNo"
        '
        'Label75
        '
        Me.Label75.BackColor = System.Drawing.Color.Transparent
        Me.Label75.ForeColor = System.Drawing.Color.Navy
        Me.Label75.Location = New System.Drawing.Point(420, 220)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(112, 20)
        Me.Label75.TabIndex = 105
        Me.Label75.Text = "To"
        '
        'Label76
        '
        Me.Label76.BackColor = System.Drawing.Color.Transparent
        Me.Label76.ForeColor = System.Drawing.Color.Navy
        Me.Label76.Location = New System.Drawing.Point(420, 245)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(112, 20)
        Me.Label76.TabIndex = 104
        Me.Label76.Text = "To "
        '
        'DtpToDateVFS
        '
        Me.DtpToDateVFS.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.DtpToDateVFS.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.DtpToDateVFS.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.DtpToDateVFS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpToDateVFS.Location = New System.Drawing.Point(524, 291)
        Me.DtpToDateVFS.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.DtpToDateVFS.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DtpToDateVFS.Name = "DtpToDateVFS"
        Me.DtpToDateVFS.Size = New System.Drawing.Size(108, 20)
        Me.DtpToDateVFS.TabIndex = 11
        Me.DtpToDateVFS.Tag = "dt.TransactionDate"
        '
        'Label77
        '
        Me.Label77.BackColor = System.Drawing.Color.Transparent
        Me.Label77.ForeColor = System.Drawing.Color.Navy
        Me.Label77.Location = New System.Drawing.Point(420, 291)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(112, 20)
        Me.Label77.TabIndex = 103
        Me.Label77.Text = "To"
        '
        'BtnFromCustomerListVFS
        '
        Me.BtnFromCustomerListVFS.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFromCustomerListVFS.Location = New System.Drawing.Point(364, 245)
        Me.BtnFromCustomerListVFS.Name = "BtnFromCustomerListVFS"
        Me.BtnFromCustomerListVFS.Size = New System.Drawing.Size(24, 20)
        Me.BtnFromCustomerListVFS.TabIndex = 99
        Me.BtnFromCustomerListVFS.TabStop = False
        Me.BtnFromCustomerListVFS.UseVisualStyleBackColor = False
        '
        'TxtFromCustomerVFS
        '
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Me.TxtFromCustomerVFS.Appearance = Appearance11
        Me.TxtFromCustomerVFS.BackColor = System.Drawing.SystemColors.Window
        Me.TxtFromCustomerVFS.Location = New System.Drawing.Point(248, 245)
        Me.TxtFromCustomerVFS.MaxLength = 12
        Me.TxtFromCustomerVFS.Name = "TxtFromCustomerVFS"
        Me.TxtFromCustomerVFS.Size = New System.Drawing.Size(110, 21)
        Me.TxtFromCustomerVFS.TabIndex = 6
        Me.TxtFromCustomerVFS.Tag = "FK.PartyCode"
        '
        'TxtFromVehicleVFS
        '
        Me.TxtFromVehicleVFS.AcceptsReturn = True
        Me.TxtFromVehicleVFS.AccessibleDescription = "YM.AUTO"
        Me.TxtFromVehicleVFS.Location = New System.Drawing.Point(248, 220)
        Me.TxtFromVehicleVFS.MaxLength = 10
        Me.TxtFromVehicleVFS.Name = "TxtFromVehicleVFS"
        Me.TxtFromVehicleVFS.Size = New System.Drawing.Size(108, 21)
        Me.TxtFromVehicleVFS.TabIndex = 4
        Me.TxtFromVehicleVFS.Tag = "PK.TransactionNo"
        '
        'Label78
        '
        Me.Label78.BackColor = System.Drawing.Color.Transparent
        Me.Label78.ForeColor = System.Drawing.Color.Navy
        Me.Label78.Location = New System.Drawing.Point(140, 224)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(110, 20)
        Me.Label78.TabIndex = 98
        Me.Label78.Text = "Vehicle"
        '
        'Label79
        '
        Me.Label79.BackColor = System.Drawing.Color.Transparent
        Me.Label79.ForeColor = System.Drawing.Color.Navy
        Me.Label79.Location = New System.Drawing.Point(140, 249)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(110, 20)
        Me.Label79.TabIndex = 97
        Me.Label79.Text = "Customer"
        '
        'DtpFromDateVFS
        '
        Me.DtpFromDateVFS.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.DtpFromDateVFS.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.DtpFromDateVFS.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.DtpFromDateVFS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFromDateVFS.Location = New System.Drawing.Point(248, 291)
        Me.DtpFromDateVFS.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.DtpFromDateVFS.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DtpFromDateVFS.Name = "DtpFromDateVFS"
        Me.DtpFromDateVFS.Size = New System.Drawing.Size(108, 20)
        Me.DtpFromDateVFS.TabIndex = 10
        Me.DtpFromDateVFS.Tag = "dt.TransactionDate"
        Me.DtpFromDateVFS.Value = New Date(2005, 7, 1, 0, 0, 0, 0)
        '
        'Label80
        '
        Me.Label80.BackColor = System.Drawing.Color.Transparent
        Me.Label80.ForeColor = System.Drawing.Color.Navy
        Me.Label80.Location = New System.Drawing.Point(140, 295)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(132, 20)
        Me.Label80.TabIndex = 96
        Me.Label80.Text = "Transaction Date"
        '
        'Label81
        '
        Me.Label81.BackColor = System.Drawing.Color.Transparent
        Me.Label81.ForeColor = System.Drawing.Color.Navy
        Me.Label81.Location = New System.Drawing.Point(140, 175)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(88, 20)
        Me.Label81.TabIndex = 118
        Me.Label81.Text = "On Basis"
        '
        'BtnFromBranchListVFS
        '
        Me.BtnFromBranchListVFS.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnFromBranchListVFS.Location = New System.Drawing.Point(364, 194)
        Me.BtnFromBranchListVFS.Name = "BtnFromBranchListVFS"
        Me.BtnFromBranchListVFS.Size = New System.Drawing.Size(24, 20)
        Me.BtnFromBranchListVFS.TabIndex = 120
        Me.BtnFromBranchListVFS.TabStop = False
        Me.BtnFromBranchListVFS.UseVisualStyleBackColor = False
        '
        'GrpSetupList
        '
        Me.GrpSetupList.Controls.Add(Me.CmbGroupBySU)
        Me.GrpSetupList.Controls.Add(Me.LblGroupBySet)
        Me.GrpSetupList.Controls.Add(Me.TxtToCode)
        Me.GrpSetupList.Controls.Add(Me.Label28)
        Me.GrpSetupList.Controls.Add(Me.TxtFCode)
        Me.GrpSetupList.Controls.Add(Me.Label29)
        Me.GrpSetupList.Controls.Add(Me.LinkLabel8)
        Me.GrpSetupList.Controls.Add(Me.TxtTDate)
        Me.GrpSetupList.Controls.Add(Me.Label30)
        Me.GrpSetupList.Controls.Add(Me.TxtFDate)
        Me.GrpSetupList.Controls.Add(Me.Label31)
        Me.GrpSetupList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpSetupList.Location = New System.Drawing.Point(0, 0)
        Me.GrpSetupList.Name = "GrpSetupList"
        Me.GrpSetupList.Size = New System.Drawing.Size(804, 583)
        Me.GrpSetupList.TabIndex = 30
        Me.GrpSetupList.Visible = False
        '
        'CmbGroupBySU
        '
        Me.CmbGroupBySU.Items.AddRange(New Object() {"None", "Customer", "Owner"})
        Me.CmbGroupBySU.Location = New System.Drawing.Point(259, 181)
        Me.CmbGroupBySU.Name = "CmbGroupBySU"
        Me.CmbGroupBySU.Size = New System.Drawing.Size(140, 21)
        Me.CmbGroupBySU.TabIndex = 132
        Me.CmbGroupBySU.Text = "None"
        Me.CmbGroupBySU.Visible = False
        '
        'LblGroupBySet
        '
        Me.LblGroupBySet.BackColor = System.Drawing.Color.Transparent
        Me.LblGroupBySet.ForeColor = System.Drawing.Color.Navy
        Me.LblGroupBySet.Location = New System.Drawing.Point(151, 181)
        Me.LblGroupBySet.Name = "LblGroupBySet"
        Me.LblGroupBySet.Size = New System.Drawing.Size(88, 20)
        Me.LblGroupBySet.TabIndex = 133
        Me.LblGroupBySet.Text = "Grouped by"
        Me.LblGroupBySet.Visible = False
        '
        'TxtToCode
        '
        Me.TxtToCode.AcceptsReturn = True
        Me.TxtToCode.AccessibleDescription = "YM.AUTO"
        Me.TxtToCode.Location = New System.Drawing.Point(543, 211)
        Me.TxtToCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.VehicleCode_Length
        Me.TxtToCode.Name = "TxtToCode"
        Me.TxtToCode.Size = New System.Drawing.Size(100, 21)
        Me.TxtToCode.TabIndex = 2
        Me.TxtToCode.Tag = "dd.ItemCode1"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(431, 211)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(112, 20)
        Me.Label28.TabIndex = 113
        Me.Label28.Text = "To "
        '
        'TxtFCode
        '
        Me.TxtFCode.AcceptsReturn = True
        Me.TxtFCode.AccessibleDescription = ""
        Me.TxtFCode.Location = New System.Drawing.Point(259, 211)
        Me.TxtFCode.MaxLength = 10
        Me.TxtFCode.Name = "TxtFCode"
        Me.TxtFCode.Size = New System.Drawing.Size(100, 21)
        Me.TxtFCode.TabIndex = 1
        Me.TxtFCode.Tag = "dd.ItemCode1"
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.ForeColor = System.Drawing.Color.Navy
        Me.Label29.Location = New System.Drawing.Point(151, 211)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(110, 20)
        Me.Label29.TabIndex = 111
        Me.Label29.Text = "From Code"
        '
        'LinkLabel8
        '
        Me.LinkLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LinkLabel8.Location = New System.Drawing.Point(10, 35)
        Me.LinkLabel8.Name = "LinkLabel8"
        Me.LinkLabel8.Size = New System.Drawing.Size(75, 20)
        Me.LinkLabel8.TabIndex = 107
        Me.LinkLabel8.TabStop = True
        Me.LinkLabel8.Text = "Other Reports"
        Me.LinkLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTDate
        '
        Me.TxtTDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.TxtTDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtTDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.TxtTDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtTDate.Location = New System.Drawing.Point(545, 236)
        Me.TxtTDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.TxtTDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.TxtTDate.Name = "TxtTDate"
        Me.TxtTDate.Size = New System.Drawing.Size(100, 20)
        Me.TxtTDate.TabIndex = 6
        Me.TxtTDate.Tag = "dt.TransactionDate"
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.Transparent
        Me.Label30.ForeColor = System.Drawing.Color.Navy
        Me.Label30.Location = New System.Drawing.Point(433, 236)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(112, 20)
        Me.Label30.TabIndex = 103
        Me.Label30.Text = "To"
        '
        'TxtFDate
        '
        Me.TxtFDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.TxtFDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtFDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.TxtFDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtFDate.Location = New System.Drawing.Point(259, 236)
        Me.TxtFDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.TxtFDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.TxtFDate.Name = "TxtFDate"
        Me.TxtFDate.Size = New System.Drawing.Size(100, 20)
        Me.TxtFDate.TabIndex = 5
        Me.TxtFDate.Tag = "dt.TransactionDate"
        Me.TxtFDate.Value = New Date(2005, 7, 1, 0, 0, 0, 0)
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.ForeColor = System.Drawing.Color.Navy
        Me.Label31.Location = New System.Drawing.Point(151, 240)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(132, 20)
        Me.Label31.TabIndex = 96
        Me.Label31.Text = "From Date"
        '
        'GrpVehicleLedger
        '
        Me.GrpVehicleLedger.Controls.Add(Me.Label39)
        Me.GrpVehicleLedger.Controls.Add(Me.ChkShowOpeneing)
        Me.GrpVehicleLedger.Controls.Add(Me.RbtSummaryVLR)
        Me.GrpVehicleLedger.Controls.Add(Me.RbtDetailVLR)
        Me.GrpVehicleLedger.Controls.Add(Me.BtnLstToOwnerVLR)
        Me.GrpVehicleLedger.Controls.Add(Me.TxtToOwnerVLR)
        Me.GrpVehicleLedger.Controls.Add(Me.Label27)
        Me.GrpVehicleLedger.Controls.Add(Me.BtnLstFrOwnerVLR)
        Me.GrpVehicleLedger.Controls.Add(Me.TxtFrOwnerVLR)
        Me.GrpVehicleLedger.Controls.Add(Me.Label33)
        Me.GrpVehicleLedger.Controls.Add(Me.CmbTypeVLR)
        Me.GrpVehicleLedger.Controls.Add(Me.Label32)
        Me.GrpVehicleLedger.Controls.Add(Me.TxtBranchCodeVLR)
        Me.GrpVehicleLedger.Controls.Add(Me.Label42)
        Me.GrpVehicleLedger.Controls.Add(Me.LinkLabel9)
        Me.GrpVehicleLedger.Controls.Add(Me.BtnLstToVehicleVLR)
        Me.GrpVehicleLedger.Controls.Add(Me.TxtToVehicleVLR)
        Me.GrpVehicleLedger.Controls.Add(Me.Label83)
        Me.GrpVehicleLedger.Controls.Add(Me.TxtToDateVLR)
        Me.GrpVehicleLedger.Controls.Add(Me.Label84)
        Me.GrpVehicleLedger.Controls.Add(Me.BtnLstFrVehicleVLR)
        Me.GrpVehicleLedger.Controls.Add(Me.TxtFrVehicleVLR)
        Me.GrpVehicleLedger.Controls.Add(Me.Label86)
        Me.GrpVehicleLedger.Controls.Add(Me.TxtFrDateVLR)
        Me.GrpVehicleLedger.Controls.Add(Me.Label87)
        Me.GrpVehicleLedger.Controls.Add(Me.BtnLstBranchVLR)
        Me.GrpVehicleLedger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpVehicleLedger.Location = New System.Drawing.Point(0, 0)
        Me.GrpVehicleLedger.Name = "GrpVehicleLedger"
        Me.GrpVehicleLedger.Size = New System.Drawing.Size(804, 521)
        Me.GrpVehicleLedger.TabIndex = 31
        Me.GrpVehicleLedger.Text = "Vehicle Revenue"
        Me.GrpVehicleLedger.Visible = False
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.ForeColor = System.Drawing.Color.Navy
        Me.Label39.Location = New System.Drawing.Point(137, 317)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(110, 20)
        Me.Label39.TabIndex = 140
        Me.Label39.Text = "Vehicles"
        '
        'ChkShowOpeneing
        '
        Me.ChkShowOpeneing.AutoSize = True
        Me.ChkShowOpeneing.BackColor = System.Drawing.Color.Transparent
        Me.ChkShowOpeneing.Location = New System.Drawing.Point(423, 190)
        Me.ChkShowOpeneing.Name = "ChkShowOpeneing"
        Me.ChkShowOpeneing.Size = New System.Drawing.Size(96, 17)
        Me.ChkShowOpeneing.TabIndex = 138
        Me.ChkShowOpeneing.Text = "Show Opening"
        Me.ChkShowOpeneing.UseVisualStyleBackColor = False
        '
        'RbtSummaryVLR
        '
        Me.RbtSummaryVLR.AutoSize = True
        Me.RbtSummaryVLR.BackColor = System.Drawing.Color.Transparent
        Me.RbtSummaryVLR.Location = New System.Drawing.Point(468, 349)
        Me.RbtSummaryVLR.Name = "RbtSummaryVLR"
        Me.RbtSummaryVLR.Size = New System.Drawing.Size(68, 17)
        Me.RbtSummaryVLR.TabIndex = 137
        Me.RbtSummaryVLR.Text = "Summary"
        Me.RbtSummaryVLR.UseVisualStyleBackColor = False
        '
        'RbtDetailVLR
        '
        Me.RbtDetailVLR.AutoSize = True
        Me.RbtDetailVLR.BackColor = System.Drawing.Color.Transparent
        Me.RbtDetailVLR.Checked = True
        Me.RbtDetailVLR.Location = New System.Drawing.Point(331, 349)
        Me.RbtDetailVLR.Name = "RbtDetailVLR"
        Me.RbtDetailVLR.Size = New System.Drawing.Size(52, 17)
        Me.RbtDetailVLR.TabIndex = 136
        Me.RbtDetailVLR.TabStop = True
        Me.RbtDetailVLR.Text = "Detail"
        Me.RbtDetailVLR.UseVisualStyleBackColor = False
        '
        'BtnLstToOwnerVLR
        '
        Me.BtnLstToOwnerVLR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLstToOwnerVLR.Location = New System.Drawing.Point(636, 293)
        Me.BtnLstToOwnerVLR.Name = "BtnLstToOwnerVLR"
        Me.BtnLstToOwnerVLR.Size = New System.Drawing.Size(24, 20)
        Me.BtnLstToOwnerVLR.TabIndex = 135
        Me.BtnLstToOwnerVLR.TabStop = False
        Me.BtnLstToOwnerVLR.UseVisualStyleBackColor = False
        '
        'TxtToOwnerVLR
        '
        Appearance12.BackColor = System.Drawing.SystemColors.Window
        Me.TxtToOwnerVLR.Appearance = Appearance12
        Me.TxtToOwnerVLR.BackColor = System.Drawing.SystemColors.Window
        Me.TxtToOwnerVLR.Location = New System.Drawing.Point(523, 291)
        Me.TxtToOwnerVLR.MaxLength = 12
        Me.TxtToOwnerVLR.Name = "TxtToOwnerVLR"
        Me.TxtToOwnerVLR.Size = New System.Drawing.Size(109, 21)
        Me.TxtToOwnerVLR.TabIndex = 131
        Me.TxtToOwnerVLR.Tag = "FK.PartyCode"
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(420, 291)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(112, 20)
        Me.Label27.TabIndex = 134
        Me.Label27.Text = "To "
        '
        'BtnLstFrOwnerVLR
        '
        Me.BtnLstFrOwnerVLR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLstFrOwnerVLR.Location = New System.Drawing.Point(364, 291)
        Me.BtnLstFrOwnerVLR.Name = "BtnLstFrOwnerVLR"
        Me.BtnLstFrOwnerVLR.Size = New System.Drawing.Size(24, 20)
        Me.BtnLstFrOwnerVLR.TabIndex = 133
        Me.BtnLstFrOwnerVLR.TabStop = False
        Me.BtnLstFrOwnerVLR.UseVisualStyleBackColor = False
        '
        'TxtFrOwnerVLR
        '
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Me.TxtFrOwnerVLR.Appearance = Appearance13
        Me.TxtFrOwnerVLR.BackColor = System.Drawing.SystemColors.Window
        Me.TxtFrOwnerVLR.Location = New System.Drawing.Point(248, 291)
        Me.TxtFrOwnerVLR.MaxLength = 12
        Me.TxtFrOwnerVLR.Name = "TxtFrOwnerVLR"
        Me.TxtFrOwnerVLR.Size = New System.Drawing.Size(110, 21)
        Me.TxtFrOwnerVLR.TabIndex = 130
        Me.TxtFrOwnerVLR.Tag = "FK.PartyCode"
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(140, 295)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(110, 20)
        Me.Label33.TabIndex = 132
        Me.Label33.Text = "Owner"
        '
        'CmbTypeVLR
        '
        Me.CmbTypeVLR.Items.AddRange(New Object() {"Branch Wise", "Consolidate", "Division Wise", "GL Code Wise"})
        Me.CmbTypeVLR.Location = New System.Drawing.Point(248, 190)
        Me.CmbTypeVLR.Name = "CmbTypeVLR"
        Me.CmbTypeVLR.Size = New System.Drawing.Size(139, 21)
        Me.CmbTypeVLR.TabIndex = 124
        Me.CmbTypeVLR.Text = "Branch Wise"
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.Transparent
        Me.Label32.ForeColor = System.Drawing.Color.Navy
        Me.Label32.Location = New System.Drawing.Point(140, 193)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 20)
        Me.Label32.TabIndex = 125
        Me.Label32.Text = "Type"
        '
        'TxtBranchCodeVLR
        '
        Me.TxtBranchCodeVLR.AcceptsReturn = True
        Me.TxtBranchCodeVLR.AccessibleDescription = ""
        Me.TxtBranchCodeVLR.Location = New System.Drawing.Point(248, 219)
        Me.TxtBranchCodeVLR.MaxLength = 10
        Me.TxtBranchCodeVLR.Name = "TxtBranchCodeVLR"
        Me.TxtBranchCodeVLR.Size = New System.Drawing.Size(108, 21)
        Me.TxtBranchCodeVLR.TabIndex = 1
        Me.TxtBranchCodeVLR.Tag = "dd.ItemCode1"
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.ForeColor = System.Drawing.Color.Navy
        Me.Label42.Location = New System.Drawing.Point(140, 219)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(110, 20)
        Me.Label42.TabIndex = 111
        Me.Label42.Text = "Branch Code"
        '
        'LinkLabel9
        '
        Me.LinkLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LinkLabel9.Location = New System.Drawing.Point(10, 35)
        Me.LinkLabel9.Name = "LinkLabel9"
        Me.LinkLabel9.Size = New System.Drawing.Size(75, 20)
        Me.LinkLabel9.TabIndex = 107
        Me.LinkLabel9.TabStop = True
        Me.LinkLabel9.Text = "Other Reports"
        Me.LinkLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnLstToVehicleVLR
        '
        Me.BtnLstToVehicleVLR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLstToVehicleVLR.Location = New System.Drawing.Point(636, 270)
        Me.BtnLstToVehicleVLR.Name = "BtnLstToVehicleVLR"
        Me.BtnLstToVehicleVLR.Size = New System.Drawing.Size(24, 20)
        Me.BtnLstToVehicleVLR.TabIndex = 106
        Me.BtnLstToVehicleVLR.TabStop = False
        Me.BtnLstToVehicleVLR.UseVisualStyleBackColor = False
        '
        'TxtToVehicleVLR
        '
        Appearance14.BackColor = System.Drawing.SystemColors.Window
        Me.TxtToVehicleVLR.Appearance = Appearance14
        Me.TxtToVehicleVLR.BackColor = System.Drawing.SystemColors.Window
        Me.TxtToVehicleVLR.Location = New System.Drawing.Point(523, 268)
        Me.TxtToVehicleVLR.MaxLength = 12
        Me.TxtToVehicleVLR.Name = "TxtToVehicleVLR"
        Me.TxtToVehicleVLR.Size = New System.Drawing.Size(109, 21)
        Me.TxtToVehicleVLR.TabIndex = 8
        Me.TxtToVehicleVLR.Tag = "FK.PartyCode"
        '
        'Label83
        '
        Me.Label83.BackColor = System.Drawing.Color.Transparent
        Me.Label83.ForeColor = System.Drawing.Color.Navy
        Me.Label83.Location = New System.Drawing.Point(420, 268)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(112, 20)
        Me.Label83.TabIndex = 104
        Me.Label83.Text = "To "
        '
        'TxtToDateVLR
        '
        Me.TxtToDateVLR.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.TxtToDateVLR.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtToDateVLR.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.TxtToDateVLR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtToDateVLR.Location = New System.Drawing.Point(524, 244)
        Me.TxtToDateVLR.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.TxtToDateVLR.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.TxtToDateVLR.Name = "TxtToDateVLR"
        Me.TxtToDateVLR.Size = New System.Drawing.Size(108, 20)
        Me.TxtToDateVLR.TabIndex = 6
        Me.TxtToDateVLR.Tag = "dt.TransactionDate"
        '
        'Label84
        '
        Me.Label84.BackColor = System.Drawing.Color.Transparent
        Me.Label84.ForeColor = System.Drawing.Color.Navy
        Me.Label84.Location = New System.Drawing.Point(420, 244)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(112, 20)
        Me.Label84.TabIndex = 103
        Me.Label84.Text = "To"
        '
        'BtnLstFrVehicleVLR
        '
        Me.BtnLstFrVehicleVLR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLstFrVehicleVLR.Location = New System.Drawing.Point(364, 268)
        Me.BtnLstFrVehicleVLR.Name = "BtnLstFrVehicleVLR"
        Me.BtnLstFrVehicleVLR.Size = New System.Drawing.Size(24, 20)
        Me.BtnLstFrVehicleVLR.TabIndex = 99
        Me.BtnLstFrVehicleVLR.TabStop = False
        Me.BtnLstFrVehicleVLR.UseVisualStyleBackColor = False
        '
        'TxtFrVehicleVLR
        '
        Appearance15.BackColor = System.Drawing.SystemColors.Window
        Me.TxtFrVehicleVLR.Appearance = Appearance15
        Me.TxtFrVehicleVLR.BackColor = System.Drawing.SystemColors.Window
        Me.TxtFrVehicleVLR.Location = New System.Drawing.Point(248, 268)
        Me.TxtFrVehicleVLR.MaxLength = 12
        Me.TxtFrVehicleVLR.Name = "TxtFrVehicleVLR"
        Me.TxtFrVehicleVLR.Size = New System.Drawing.Size(110, 21)
        Me.TxtFrVehicleVLR.TabIndex = 7
        Me.TxtFrVehicleVLR.Tag = "FK.PartyCode"
        '
        'Label86
        '
        Me.Label86.BackColor = System.Drawing.Color.Transparent
        Me.Label86.ForeColor = System.Drawing.Color.Navy
        Me.Label86.Location = New System.Drawing.Point(140, 272)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(110, 20)
        Me.Label86.TabIndex = 97
        Me.Label86.Text = "Vehicle "
        '
        'TxtFrDateVLR
        '
        Me.TxtFrDateVLR.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.TxtFrDateVLR.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtFrDateVLR.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.TxtFrDateVLR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtFrDateVLR.Location = New System.Drawing.Point(248, 244)
        Me.TxtFrDateVLR.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.TxtFrDateVLR.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.TxtFrDateVLR.Name = "TxtFrDateVLR"
        Me.TxtFrDateVLR.Size = New System.Drawing.Size(108, 20)
        Me.TxtFrDateVLR.TabIndex = 5
        Me.TxtFrDateVLR.Tag = "dt.TransactionDate"
        Me.TxtFrDateVLR.Value = New Date(2005, 7, 1, 0, 0, 0, 0)
        '
        'Label87
        '
        Me.Label87.BackColor = System.Drawing.Color.Transparent
        Me.Label87.ForeColor = System.Drawing.Color.Navy
        Me.Label87.Location = New System.Drawing.Point(140, 248)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(132, 20)
        Me.Label87.TabIndex = 96
        Me.Label87.Text = "Transaction Date"
        '
        'BtnLstBranchVLR
        '
        Me.BtnLstBranchVLR.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLstBranchVLR.Location = New System.Drawing.Point(362, 219)
        Me.BtnLstBranchVLR.Name = "BtnLstBranchVLR"
        Me.BtnLstBranchVLR.Size = New System.Drawing.Size(24, 20)
        Me.BtnLstBranchVLR.TabIndex = 120
        Me.BtnLstBranchVLR.TabStop = False
        Me.BtnLstBranchVLR.UseVisualStyleBackColor = False
        '
        'GrpVehicleRevenue
        '
        Me.GrpVehicleRevenue.Controls.Add(Me.RadioButton1)
        Me.GrpVehicleRevenue.Controls.Add(Me.RadioButton2)
        Me.GrpVehicleRevenue.Controls.Add(Me.Label88)
        Me.GrpVehicleRevenue.Controls.Add(Me.DtToVR)
        Me.GrpVehicleRevenue.Controls.Add(Me.Label82)
        Me.GrpVehicleRevenue.Controls.Add(Me.DtFromVR)
        Me.GrpVehicleRevenue.Controls.Add(Me.Label85)
        Me.GrpVehicleRevenue.Controls.Add(Me.BtnVehicleLstVR)
        Me.GrpVehicleRevenue.Controls.Add(Me.TxtVehicleLstVR)
        Me.GrpVehicleRevenue.Controls.Add(Me.LstVehicleVR)
        Me.GrpVehicleRevenue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpVehicleRevenue.Location = New System.Drawing.Point(0, 0)
        Me.GrpVehicleRevenue.Name = "GrpVehicleRevenue"
        Me.GrpVehicleRevenue.Size = New System.Drawing.Size(804, 521)
        Me.GrpVehicleRevenue.TabIndex = 31
        Me.GrpVehicleRevenue.Text = "Vehicle Revenue"
        Me.GrpVehicleRevenue.Visible = False
        '
        'Label88
        '
        Me.Label88.BackColor = System.Drawing.Color.Transparent
        Me.Label88.ForeColor = System.Drawing.Color.Navy
        Me.Label88.Location = New System.Drawing.Point(141, 314)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(99, 20)
        Me.Label88.TabIndex = 147
        Me.Label88.Text = "Vehicles"
        '
        'DtToVR
        '
        Me.DtToVR.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.DtToVR.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.DtToVR.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.DtToVR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtToVR.Location = New System.Drawing.Point(529, 285)
        Me.DtToVR.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.DtToVR.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DtToVR.Name = "DtToVR"
        Me.DtToVR.Size = New System.Drawing.Size(100, 20)
        Me.DtToVR.TabIndex = 144
        Me.DtToVR.Tag = "dt.TransactionDate"
        '
        'Label82
        '
        Me.Label82.BackColor = System.Drawing.Color.Transparent
        Me.Label82.ForeColor = System.Drawing.Color.Navy
        Me.Label82.Location = New System.Drawing.Point(417, 285)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(112, 20)
        Me.Label82.TabIndex = 146
        Me.Label82.Text = "To"
        '
        'DtFromVR
        '
        Me.DtFromVR.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.DtFromVR.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.DtFromVR.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.DtFromVR.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtFromVR.Location = New System.Drawing.Point(245, 285)
        Me.DtFromVR.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.DtFromVR.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DtFromVR.Name = "DtFromVR"
        Me.DtFromVR.Size = New System.Drawing.Size(100, 20)
        Me.DtFromVR.TabIndex = 143
        Me.DtFromVR.Tag = "dt.TransactionDate"
        Me.DtFromVR.Value = New Date(2005, 7, 1, 0, 0, 0, 0)
        '
        'Label85
        '
        Me.Label85.BackColor = System.Drawing.Color.Transparent
        Me.Label85.ForeColor = System.Drawing.Color.Navy
        Me.Label85.Location = New System.Drawing.Point(141, 285)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(99, 20)
        Me.Label85.TabIndex = 145
        Me.Label85.Text = "Document Date"
        '
        'BtnVehicleLstVR
        '
        Me.BtnVehicleLstVR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnVehicleLstVR.Location = New System.Drawing.Point(606, 316)
        Me.BtnVehicleLstVR.Name = "BtnVehicleLstVR"
        Me.BtnVehicleLstVR.Size = New System.Drawing.Size(23, 18)
        Me.BtnVehicleLstVR.TabIndex = 139
        Me.BtnVehicleLstVR.Text = "--"
        '
        'TxtVehicleLstVR
        '
        Me.TxtVehicleLstVR.Location = New System.Drawing.Point(245, 315)
        Me.TxtVehicleLstVR.Name = "TxtVehicleLstVR"
        Me.TxtVehicleLstVR.Size = New System.Drawing.Size(385, 21)
        Me.TxtVehicleLstVR.TabIndex = 142
        Me.TxtVehicleLstVR.Text = " All Selected"
        '
        'LstVehicleVR
        '
        Me.LstVehicleVR.CheckBoxes = True
        Me.LstVehicleVR.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6})
        Me.LstVehicleVR.Location = New System.Drawing.Point(245, 176)
        Me.LstVehicleVR.Name = "LstVehicleVR"
        Me.LstVehicleVR.Size = New System.Drawing.Size(383, 140)
        Me.LstVehicleVR.TabIndex = 141
        Me.LstVehicleVR.UseCompatibleStateImageBehavior = False
        Me.LstVehicleVR.View = System.Windows.Forms.View.Details
        Me.LstVehicleVR.Visible = False
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Vehicles"
        Me.ColumnHeader6.Width = 192
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Location = New System.Drawing.Point(430, 349)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton1.TabIndex = 149
        Me.RadioButton1.Text = "Summary"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(293, 349)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(52, 17)
        Me.RadioButton2.TabIndex = 148
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Detail"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'ReportParameters
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(804, 583)
        Me.Controls.Add(Me.GrpVehicleRevenue)
        Me.Controls.Add(Me.GrpVehicleLedger)
        Me.Controls.Add(Me.GrpVouchersList)
        Me.Controls.Add(Me.GrpVoucherDocuments)
        Me.Controls.Add(Me.PnlProgressBare)
        Me.Controls.Add(Me.GrpButtons)
        Me.Controls.Add(Me.GrpVehicleBill)
        Me.Controls.Add(Me.GrpTransactionDocuments)
        Me.Controls.Add(Me.GrpCOAReportList)
        Me.Controls.Add(Me.GrpSetupList)
        Me.Controls.Add(Me.GrpFinancialStatements)
        Me.Controls.Add(Me.GrpCashFlowStatements)
        Me.Controls.Add(Me.GrpVehicleFreightStatements)
        Me.Controls.Add(Me.GrpTransactionList)
        Me.Controls.Add(Me.GrpGeneralLedger)
        Me.Controls.Add(Me.GrpOtherReports)
        Me.KeyPreview = True
        Me.Name = "ReportParameters"
        Me.ShowInTaskbar = False
        Me.Text = "Print"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GrpButtons.ResumeLayout(False)
        Me.GrpTransactionDocuments.ResumeLayout(False)
        Me.GrpTransactionDocuments.PerformLayout()
        CType(Me.TxtToPartyCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToTransactionNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFromPartyCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromTransactionNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpOtherReports.ResumeLayout(False)
        Me.GrpTransactionList.ResumeLayout(False)
        Me.GrpTransactionList.PerformLayout()
        CType(Me.TxtDocumentNatureTRL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToItemCodeTRL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromItemCodeTRL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToPartyCodeTRL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToTransactionNoTRL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromPartyCodeTRL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromTransactionNoTRL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpGeneralLedger.ResumeLayout(False)
        Me.GrpGeneralLedger.PerformLayout()
        CType(Me.txtDocumentNatureIL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToBranchCodeIL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromBranchCodeIL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToGLCodeIL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDivisionIL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromGLCodeIL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDivisionCodeIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlProgressBare.ResumeLayout(False)
        Me.PnlProgressBare.PerformLayout()
        CType(Me.imgProgressBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpVehicleBill.ResumeLayout(False)
        Me.GrpVehicleBill.PerformLayout()
        CType(Me.ChkTripWithBill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtToOwnerCodeVB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFromOwnerCodeVB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtToVehicleCodeVB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFromVehicleCodeVB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpCOAReportList.ResumeLayout(False)
        Me.GrpCOAReportList.PerformLayout()
        CType(Me.TxtToGlCodeCOAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFromGlCodeCOAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpVoucherDocuments.ResumeLayout(False)
        Me.GrpVoucherDocuments.PerformLayout()
        CType(Me.TxtVoucherTypesVDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtToVoucherNoVDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFromVoucherNoVDO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpVouchersList.ResumeLayout(False)
        Me.GrpVouchersList.PerformLayout()
        CType(Me.TxtVoucherTypesVLT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtToGLCodeVLT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFromGLCodeVLT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtToVoucherNoListVLT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFromVoucherNoListVLT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpCashFlowStatements.ResumeLayout(False)
        Me.GrpCashFlowStatements.PerformLayout()
        CType(Me.TxtCashAccountsCFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtToBranchCodeCFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFromBranchCodeCFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtToDivisionCFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFromDivisionCFS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpFinancialStatements.ResumeLayout(False)
        Me.GrpFinancialStatements.PerformLayout()
        CType(Me.TxtToGLCodeFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFromGLCodeFS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpVehicleFreightStatements.ResumeLayout(False)
        Me.GrpVehicleFreightStatements.PerformLayout()
        CType(Me.TxtToTransactionNoVFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFromTransactionNoVFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFromBranchVFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtToCustomerVFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtToVehicleVFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFromCustomerVFS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFromVehicleVFS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSetupList.ResumeLayout(False)
        Me.GrpSetupList.PerformLayout()
        CType(Me.TxtToCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpVehicleLedger.ResumeLayout(False)
        Me.GrpVehicleLedger.PerformLayout()
        CType(Me.TxtToOwnerVLR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFrOwnerVLR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBranchCodeVLR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtToVehicleVLR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFrVehicleVLR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpVehicleRevenue.ResumeLayout(False)
        Me.GrpVehicleRevenue.PerformLayout()
        CType(Me.TxtVehicleLstVR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private mFileName As String
    Public Property ReportFileName() As String
        Get
            Return mFileName
        End Get
        Set(ByVal Value As String)
            mFileName = Value
        End Set
    End Property
    Friend ReportFile As ReportFiles
    Private Sub BtnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPreview.Click
        TargetControl = ReportTargetControl.ReportViewer
        If Me.ReportFile = ReportFiles.FreightStatement Then
            If CmbReportTypeVFS.SelectedIndex = 0 Then
                Me.ReportFile = ReportFiles.FreightStatement
            End If
        End If
        Cursor = Cursors.WaitCursor
        imgProgressBar.Visible = True
        If ReportFile = ReportProcess.ReportFiles.TransactionList Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            TargetControl = ReportTargetControl.ReportViewer
            If TransactionListProcess(ReportFile, Trim(txtFromTransactionNoTRL.Text), Trim(txtToTransactionNoTRL.Text), dtpFromTransactionDateTRL.Value, dtpToTransactionDateTRL.Value, Trim(txtFromPartyCodeTRL.Text), Trim(txtToPartyCodeTRL.Text), Trim(txtFromItemCodeTRL.Text), Trim(txtToItemCodeTRL.Text), GetDocumentTypeCode(LstTransactionNatureTRL), reportDoc, cmbGroupBy.SelectedIndex, chkPageBreakTRL.Checked) = True Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Transaction List [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
            ''
            '' Cash Flow Statements
            ''
        ElseIf ReportFile = ReportProcess.ReportFiles.CashFlowStatements Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            If CashFlowStatementsProcess(ReportFiles.CashFlowStatements, TxtFromDateCFS.Text, TxtToDateCFS.Text, TxtFromBranchCodeCFS.Text, TxtToBranchCodeCFS.Text, TxtFromDivisionCFS.Text, TxtToDivisionCFS.Text, GetDocumentTypeCode(LstCashAccountsCFS), IIf(OptSummaryCFS.Checked, True, False), "", reportDoc, Nothing, 0, 0, "", ChkPageBreakCFS.Checked, CBool(ChkShowOpenningCFS.Checked)) Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Cash Flow Statement [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
            ''
            '' Vehicle Freight Statements
            ''
        ElseIf ReportFile = ReportProcess.ReportFiles.FreightStatement Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            If FetchVehicleFreightStatements(ReportFiles.FreightStatement, Trim(TxtFromBranchVFS.Text), TxtFromTransactionNoVFS.Text, TxtToTransactionNoVFS.Text, DtpFromDateVFS.Value, DtpToDateVFS.Value, Trim(TxtFromVehicleVFS.Text), Trim(TxtToVehicleVFS.Text), TxtFromCustomerVFS.Text, TxtToCustomerVFS.Text, "1", "", "", reportDoc, Nothing, CmbGroupbyVFS.SelectedIndex, 0, ChkPageBreakVFS.Checked) Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Vehicle Freight Statements [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
            ''
            '' Vehicle Freight Statements Detail
            ''
        ElseIf ReportFile = ReportProcess.ReportFiles.FreightStatementDetail Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            If FetchVehicleFreightStatements(ReportFiles.FreightStatementDetail, Trim(TxtFromBranchVFS.Text), TxtFromTransactionNoVFS.Text, TxtToTransactionNoVFS.Text, DtpFromDateVFS.Value, DtpToDateVFS.Value, Trim(TxtFromVehicleVFS.Text), Trim(TxtToVehicleVFS.Text), TxtFromCustomerVFS.Text, TxtToCustomerVFS.Text, "1", "", "", reportDoc, Nothing, CmbGroupbyVFS.SelectedIndex, CmbOnBasisVFS.SelectedIndex, ChkPageBreakVFS.Checked) Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Vehicle Freight Statements [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
            ''
            '' Vehicle Freight Statements Summary
            ''
        ElseIf ReportFile = ReportProcess.ReportFiles.FreightStatementSummary Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            If FetchVehicleFreightStatements(ReportFiles.FreightStatementSummary, Trim(TxtFromBranchVFS.Text), TxtFromTransactionNoVFS.Text, TxtToTransactionNoVFS.Text, DtpFromDateVFS.Value, DtpToDateVFS.Value, Trim(TxtFromVehicleVFS.Text), Trim(TxtToVehicleVFS.Text), TxtFromCustomerVFS.Text, TxtToCustomerVFS.Text, "1", "", "", reportDoc, Nothing, CmbGroupbyVFS.SelectedIndex, CmbOnBasisVFS.SelectedIndex, ChkPageBreakVFS.Checked) Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Vehicle Freight Statements [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
            ''
            ''Ledger
            ''

        ElseIf ReportFile = ReportProcess.ReportFiles.GeneralLedger Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            If GeneralLedgerProcess(ReportFiles.GeneralLedger, txtFromTrDateIL.Value, txtToTrDateIL.Value, txtFromBranchCodeIL.Text, txtToBranchCodeIL.Text, txtFromDivisionCodeIL.Text, txtToDivisionIL.Text, txtFromGLCodeIL.Text, txtToGLCodeIL.Text, GetDocumentTypeCode(lstTransactionNatureIL), "", reportDoc, Nothing, ReportType, chkIsHierarchicalView.Checked, CmbNarrationType.Text, ChkPageBreakIL.Checked) = True Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "General Ledger [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
            ''
            ''Financial Statements
            ''

        ElseIf ReportFile = ReportProcess.ReportFiles.BalanceSheet Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            Dim FSFFrom As String
            Dim FSFTo As String
            FSFFrom = My.Settings.FSFBalanceSheetStart
            FSFTo = My.Settings.FSFBalanceSheetEnd

            If FinancialStatementsProcess(ReportFiles.BalanceSheet, TxtFromDateFS.Value, TxtToDateFS.Value, "", "", "", "", TxtFromGLCodeFS.Text, TxtToGLCodeFS.Text, FSFFrom, FSFTo, "", "", 12, "", 1, reportDoc, "Balance Sheet") = True Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Balance Sheet [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
            FSFFrom = My.Settings.FSFIncomeStatementStart
            FSFTo = My.Settings.FSFIncomeStatementEnd
            If FinancialStatementsProcess(ReportFiles.IncomeStatement, TxtFromDateFS.Value, TxtToDateFS.Value, "", "", "", "", TxtFromGLCodeFS.Text, TxtToGLCodeFS.Text, FSFFrom, FSFTo, "", "", 12, "", 1, reportDoc, "Income Statements") = True Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Income Statements [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
            ''
            ''Vehicle Bills
            ''

        ElseIf ReportFile = ReportProcess.ReportFiles.VehicleBills Then
            If My.Settings.IsWithGL = True Then
                Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
                If VehicleBillsProcess(ReportFiles.VehicleBills, TxtFromTransactionDateVB.Value, TxtToTransactionDateVB.Value, TxtFromVehicleCodeVB.Text, TxtToVehicleCodeVB.Text, TxtFromOwnerCodeVB.Text, TxtToOwnerCodeVB.Text, reportDoc, Nothing, ReportType, chkIsHierarchicalView.Checked, "", ChkPageBreakIL.Checked, ChkTripWithBill.Checked) = True Then
                    Dim rpViewer As New ReportViewer
                    rpViewer.SetSource = reportDoc
                    rpViewer.MdiParent = Me.MdiParent
                    rpViewer.Text = "Vehicle Bill [Report]"
                    rpViewer.Show()
                    rpViewer.BringToFront()
                    Cursor = Cursors.Default
                    imgProgressBar.Visible = False
                End If
            Else
                Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
                If VehicleBillsProcessWGL(ReportFiles.VehicleBills, TxtFromTransactionDateVB.Value, TxtToTransactionDateVB.Value, TxtFromVehicleCodeVB.Text, TxtToVehicleCodeVB.Text, TxtFromOwnerCodeVB.Text, TxtToOwnerCodeVB.Text, reportDoc, Nothing, ReportType, chkIsHierarchicalView.Checked, "", ChkPageBreakIL.Checked, ChkTripWithBill.Checked) = True Then
                    Dim rpViewer As New ReportViewer
                    rpViewer.SetSource = reportDoc
                    rpViewer.MdiParent = Me.MdiParent
                    rpViewer.Text = "Vehicle Bill [Report]"
                    rpViewer.Show()
                    rpViewer.BringToFront()
                    Cursor = Cursors.Default
                    imgProgressBar.Visible = False
                End If
            End If

            ''
            ''Vehicle Bill Analysis
            ''
        ElseIf ReportFile = ReportProcess.ReportFiles.VehicleBillAnalysis Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            If VehicleBillsProcess(ReportFiles.VehicleBillAnalysis, Format(TxtFromTransactionDateVB.Value, "1-MMM-yyyy"), CDate(Format(TxtFromTransactionDateVB.Value.AddMonths(1), "1-MMM-yyyy")).AddDays(-1), TxtFromVehicleCodeVB.Text, TxtToVehicleCodeVB.Text, TxtFromOwnerCodeVB.Text, TxtToOwnerCodeVB.Text, reportDoc, Nothing, ReportType, CmbGroupedByVB.SelectedIndex, "", ChkPageBreakIL.Checked) = True Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Vehicle Bill Analysis [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
            ''
            ''Vehicle Ledger
            ''
        ElseIf ReportFile = ReportProcess.ReportFiles.VehicleLedger Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            If VehicleLedgerProcess(ReportFiles.VehicleLedger, ChkShowOpeneing.Checked, RbtSummaryVLR.Checked, TxtFrDateVLR.Value, TxtToDateVLR.Value, TxtFrVehicleVLR.Text, TxtToVehicleVLR.Text, TxtFrOwnerVLR.Text, TxtToOwnerVLR.Text, reportDoc, Nothing, 0, CmbTypeVLR.SelectedIndex) = True Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Vehicle Ledger [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
            ''
            ''Vehicle Revenue
            ''
        ElseIf ReportFile = ReportProcess.ReportFiles.VehicleRevenue Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            If VehicleRevenueProcess(ReportFiles.VehicleRevenue, ChkShowOpeneing.Checked, RbtSummaryVLR.Checked, TxtFrDateVLR.Value, TxtToDateVLR.Value, TxtFrVehicleVLR.Text, TxtToVehicleVLR.Text, TxtFrOwnerVLR.Text, TxtToOwnerVLR.Text, reportDoc, Nothing, 0, CmbTypeVLR.SelectedIndex) = True Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Vehicle Revenue [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
            ''
            ''Vehicle Revenue Pivot
            ''
        ElseIf ReportFile = ReportProcess.ReportFiles.VehicleRevenuePivot Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            '  If VehicleRevenuePivotProcess(ReportFiles.VehicleRevenue, GetDocumentTypeCode(LstVehicleVR), ChkShowOpeneing.Checked, RbtSummaryVLR.Checked, DtFromVR.Value, DtToVR.Value, TxtFrVehicleVLR.Text, TxtToVehicleVLR.Text, TxtFrOwnerVLR.Text, TxtToOwnerVLR.Text, reportDoc, Nothing, 0, CmbTypeVLR.SelectedIndex) = True Then
            If VehicleRevenuePivotProcess(ReportFiles.VehicleRevenue, GetDocumentTypeCode(LstVehicleVR), False, False, DtFromVR.Value, DtToVR.Value, String.Empty, String.Empty, String.Empty, String.Empty, reportDoc, Nothing, 0, CmbTypeVLR.SelectedIndex) = True Then

                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Vehicle Revenue Pivot [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If

            ''
            ''Vehicle List
            ''
        ElseIf ReportFile = ReportProcess.ReportFiles.VehicleList Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            If VehicleListProcess(Trim(TxtFCode.Text), Trim(TxtToCode.Text), TxtFDate.Value, TxtTDate.Value, CmbGroupBySU.SelectedIndex, reportDoc, False) = True Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Vehicle List [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
            ''
            ''Trial Balance
            ''
        ElseIf ReportFile = ReportProcess.ReportFiles.TrialBalance Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            'If GeneralLedgerProcess(ReportFiles.GeneralLedger, txtFromTrDateIL.Value, txtToTrDateIL.Value, txtFromBranchCodeIL.Text, txtToBranchCodeIL.Text, txtFromDivisionCodeIL.Text, txtToDivisionIL.Text, txtFromGLCodeIL.Text, txtToGLCodeIL.Text, GetDocumentTypeCode(lstTransactionNatureIL), "", reportDoc, Nothing, ReportType, chkIsHierarchicalView.Checked, "", ChkPageBreakIL.Checked) = True Then
            'If TrialBalanceProcess(ReportFiles.TrialBalance, DtFrom, DtTo, TxtBranchFrom, TxtBranchTo, TxtDivisionFrom, TxtDivisionTo, TxtGLFrom, TxtGLTo, GetDocumentNatureCode, GetReportParameterRangeString, Result, PBIndicator, ReportType, nReportName, ChkHrchlView.Value) Then
            If TrialBalanceProcess(ReportFiles.TrialBalance, txtFromTrDateIL.Value, txtToTrDateIL.Value, txtFromBranchCodeIL.Text, txtToBranchCodeIL.Text, txtFromDivisionCodeIL.Text, txtToDivisionIL.Text, txtFromGLCodeIL.Text, txtToGLCodeIL.Text, GetDocumentTypeCode(lstTransactionNatureIL), "", reportDoc, Nothing, ReportType, ChkPageBreakIL.Checked, nReportName, chkIsHierarchicalView.Checked) = True Then

                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Trial Balance [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
            '''''''''''
            '''''''''''ACCOUNT REPORTS''''''''''''''
            ''''''''''''

            'CHART OF ACCOUNT
        ElseIf ReportFile = ReportProcess.ReportFiles.ChartOfAccountList Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            If ChartOfAccountList(ReportFile, Trim(TxtFromGlCodeCOAL.Text), Trim(TxtToGlCodeCOAL.Text), TxtFromDefinitionDateCOAL.Value, TxtToDefinitionDateCOAL.Value, reportDoc, CmbLevelsCOAL.SelectedIndex, ChkPageBreakCOAL.Checked) = True Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Chart Of Account [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
            'VOUCHER DOCUMENTS
        ElseIf ReportFile = ReportProcess.ReportFiles.VoucherDocuments Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            If VoucherDocumentsProcess(ReportFile, Trim(TxtFromVoucherNoVDO.Text), Trim(TxtToVoucherNoVDO.Text), DtpFromDefinitionDateVDO.Value, DtpToDefinitionDateVDO.Value, GetDocumentTypeCode(LvwVoucherTypesVDO), reportDoc) = True Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Voucher Document [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
            'VOUCHER LIST
        ElseIf ReportFile = ReportProcess.ReportFiles.VoucherList Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            If VoucherListProcess(ReportFile, Trim(TxtFromVoucherNoListVLT.Text), Trim(TxtToVoucherNoListVLT.Text), DtpFromVoucherDateVLT.Value, DtpToVoucherDateVLT.Value, Trim(TxtFromGLCodeVLT.Text), Trim(TxtToGLCodeVLT.Text), GetDocumentTypeCode(LvwVoucherTypesVLT), reportDoc, CmbGroupedByVLT.SelectedIndex, ChkPageBreakVLT.Checked) = True Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Voucher List [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
        Else
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            If TransactionDocumentsProcess(ReportFile, Trim(txtFromTransactionNumber.Text), Trim(txtToTransactionNumber.Text), dtpFromDate.Value, dtpToDate.Value, Trim(TxtFromPartyCode.Text), Trim(TxtToPartyCode.Text), reportDoc) = True Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Text = "Vehicle Transaction List [Report]"
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If

        End If
        Cursor = Cursors.Default
        imgProgressBar.Visible = False
    End Sub
    Private Function nReportName() As String
        If UCase(CmbLedgerTypeIL.Text) = UCase("GL Code Wise") Then
            If OptDetail.Checked = True Then
                Return "TrialBalanceGLCode"
            ElseIf OptSummary.Checked = True Then
                Return "TrialBalanceGLCodeSummary"
            End If
        Else
            If OptDetail.Checked = True Then
                Return "TrialBalance"
            ElseIf OptSummary.Checked = True Then
                Return "TrialBalanceSummary"
            End If
        End If
        Return ""
    End Function
    Private Sub ReportParameters_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SettingReport()
    End Sub
    Sub SettingReport()
        imgProgressBar.Image = Image.FromFile(Application.StartupPath & "\Images\Wait.gif")
        Select Case ReportFile
            Case ReportProcess.ReportFiles.ProductReceiving
                AddHandler GrpTransactionDocuments.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpOtherReports.Visible = False
                GrpTransactionDocuments.Visible = True
                Me.Text = "Product Receiving Document"
                GrpButtons.Visible = True
            Case ReportProcess.ReportFiles.VehicleBills
                ChkTripWithBill.Checked = True
                GrpOtherReports.Visible = True
                GrpOtherReports.Visible = False
                GrpVehicleBill.Visible = True
                Me.Text = "Vehicle Bill Document"
                AddHandler GrpVehicleBill.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpButtons.Visible = True
            Case ReportProcess.ReportFiles.VehicleLedger
                GrpOtherReports.Visible = False
                GrpVehicleLedger.Visible = True
                Me.Text = "Vehicle Ledger"
                AddHandler GrpVehicleLedger.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpButtons.Visible = True
            Case ReportProcess.ReportFiles.VehicleRevenue
                GrpOtherReports.Visible = False
                GrpVehicleLedger.Visible = True
                Me.Text = "Vehicle Revenue"
                AddHandler GrpVehicleLedger.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpButtons.Visible = True

                FillVehicleList(LstVehicleVR, "COMBO")
            Case ReportProcess.ReportFiles.VehicleRevenuePivot
                GrpOtherReports.Visible = False
                GrpVehicleRevenue.Visible = True
                Me.Text = "Vehicle Revenue Pivot"
                FillVehicleList(LstVehicleVR, "COMBO")
                AddHandler GrpVehicleRevenue.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpButtons.Visible = True

            Case ReportProcess.ReportFiles.VehicleBillAnalysis
                ChkTripWithBill.Visible = False
                ChkTripWithBill.Checked = False
                GrpOtherReports.Visible = False
                GrpVehicleBill.Visible = True
                LblGroupByVB.Visible = True
                CmbGroupedByVB.Visible = True
                Me.Text = "Vehicle Bill Analysis"
                AddHandler GrpVehicleBill.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpButtons.Visible = True
                lblFromDateVB.Text = "Month"
                TxtFromTransactionDateVB.Format = DateTimePickerFormat.Custom
                TxtFromTransactionDateVB.CustomFormat = "MMM-yyyy"
                TxtToTransactionDateVB.Visible = False
                LblToDateVB.Visible = False
            Case ReportProcess.ReportFiles.ProductReceivingReturn
                GrpOtherReports.Visible = False
                GrpTransactionDocuments.Visible = True
                Me.Text = "Product Receiving  Return Document"
                AddHandler GrpTransactionDocuments.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpButtons.Visible = True
            Case ReportProcess.ReportFiles.SaleInvoice
                GrpOtherReports.Visible = False
                GrpTransactionDocuments.Visible = True
                Me.Text = "Sale Invoice Document"
                AddHandler GrpTransactionDocuments.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpButtons.Visible = True
            Case ReportProcess.ReportFiles.SaleInvoiceReturn
                GrpOtherReports.Visible = False
                GrpTransactionDocuments.Visible = True
                Me.Text = "Sale Return Document"
                AddHandler GrpTransactionDocuments.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpButtons.Visible = True
            Case ReportProcess.ReportFiles.TransactionList
                AddHandler GrpTransactionList.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpOtherReports.Visible = False
                GrpTransactionList.Visible = True
                Me.Text = "Transaction List"
                AddHandler GrpTransactionDocuments.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpButtons.Visible = True
                FillDocTypeList(LstTransactionNatureTRL, "INVENTORY")
            Case ReportProcess.ReportFiles.ProfitListing
                GrpOtherReports.Visible = False
                GrpVehicleBill.Visible = True
                Me.Text = "Profit List"
                AddHandler GrpTransactionDocuments.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpButtons.Visible = True
            Case ReportProcess.ReportFiles.VehicleList
                GrpOtherReports.Visible = False
                LblGroupBySet.Visible = True
                CmbGroupBySU.Visible = True
                Me.Text = "Vehicle List"
                GrpSetupList.Visible = True
                Me.GrpSetupList.Text = "Vehicle List"
                GrpButtons.Visible = True
                AddHandler GrpSetupList.Paint, AddressOf mdlFunctions.PaintTheForms

                ''''''''''''''Accounting Reports

            Case ReportProcess.ReportFiles.GeneralLedger
                GrpOtherReports.Visible = False
                GrpGeneralLedger.Visible = True
                Me.Text = "General Ledger "
                AddHandler GrpGeneralLedger.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpButtons.Visible = True
                FillDocTypeList(lstTransactionNatureIL, "GENERALLEDGER")
            Case ReportProcess.ReportFiles.CashFlowStatements
                GrpOtherReports.Visible = False
                GrpCashFlowStatements.Visible = True
                Me.Text = "Cash Flow Statements "
                AddHandler GrpCashFlowStatements.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpButtons.Visible = True
                FillCOAList(LstCashAccountsCFS, "CASHFLOW")
            Case ReportProcess.ReportFiles.FreightStatement
                GrpOtherReports.Visible = False
                GrpVehicleFreightStatements.Visible = True
                Me.Text = "Vehicle Freight Statements "
                AddHandler GrpVehicleFreightStatements.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpButtons.Visible = True
            Case ReportProcess.ReportFiles.TrialBalance
                GrpOtherReports.Visible = False
                GrpGeneralLedger.Visible = True
                OptSummary.Visible = True
                OptDetail.Visible = True
                Me.Text = "Trial Balance "
                AddHandler GrpGeneralLedger.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpButtons.Visible = True
                FillDocTypeList(lstTransactionNatureIL, "GENERALLEDGER")
            Case ReportProcess.ReportFiles.ChartOfAccountList
                GrpOtherReports.Visible = False
                GrpCOAReportList.Visible = True
                Me.Text = "Chart Of Account List"
                GrpButtons.Visible = True
                AddHandler GrpCOAReportList.Paint, AddressOf mdlFunctions.PaintTheForms
            Case ReportProcess.ReportFiles.VoucherDocuments
                AddHandler GrpVoucherDocuments.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpOtherReports.Visible = False
                GrpVoucherDocuments.Visible = True
                Me.Text = "Voucher Documents"
                GrpButtons.Visible = True
                FillDocTypeList(LvwVoucherTypesVDO, "GENERALLEDGER")
            Case ReportProcess.ReportFiles.VoucherList
                AddHandler GrpVouchersList.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpOtherReports.Visible = False
                GrpVouchersList.Visible = True
                Me.Text = "Voucher List"
                GrpButtons.Visible = True
                FillDocTypeList(LvwVoucherTypesVLT, "GENERALLEDGER")
            Case ReportProcess.ReportFiles.BalanceSheet
                AddHandler GrpFinancialStatements.Paint, AddressOf mdlFunctions.PaintTheForms
                GrpOtherReports.Visible = False
                GrpFinancialStatements.Visible = True
                Me.Text = "Finanicial Statements"
                GrpButtons.Visible = True
            Case Else
                'load from other forms
                GrpButtons.Visible = False
        End Select
    End Sub
    Private Function ReportType() As Integer
        If UCase(cmbGroupIL.Text) = UCase("Controls") Then
            ReportType = 1
        ElseIf UCase(cmbGroupIL.Text) = UCase("Generals") Then
            ReportType = 4
        ElseIf UCase(cmbGroupIL.Text) = UCase("Subsidiaries") Then
            ReportType = 8
        ElseIf UCase(cmbGroupIL.Text) = UCase("Sub Subsidiaries") Then
            ReportType = 12
        End If

        If UCase(CmbLedgerTypeIL.Text) = UCase("Consolidate") Then
            ReportType = ReportType + 0
        ElseIf UCase(CmbLedgerTypeIL.Text) = UCase("Branch Wise") Then
            ReportType = ReportType + 1
        ElseIf UCase(CmbLedgerTypeIL.Text) = UCase("Division Wise") Then
            ReportType = ReportType + 2
        ElseIf UCase(CmbLedgerTypeIL.Text) = UCase("GL Code Wise") Then
            ReportType = ReportType + 20
        End If

        ' 21 24 28 32
    End Function

    Private Sub chkProductRec_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles chkProductRec.LinkClicked
        ReportFile = ReportProcess.ReportFiles.ProductReceiving
        GrpOtherReports.Visible = False
        GrpTransactionDocuments.Visible = True
        GrpButtons.Visible = True
    End Sub
    Private Sub lblBackToOther_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblBackToOther.LinkClicked
        GrpTransactionDocuments.Visible = False
        GrpOtherReports.Visible = True
        GrpButtons.Visible = False
    End Sub
    Private Sub chkProductRecRet_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles chkProductRecRet.LinkClicked
        ReportFile = ReportProcess.ReportFiles.ProductReceivingReturn
        GrpOtherReports.Visible = False
        GrpTransactionDocuments.Visible = True
        GrpButtons.Visible = True
    End Sub
    Private Sub chkSale_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles chkSale.LinkClicked
        ReportFile = ReportProcess.ReportFiles.SaleInvoice
        GrpOtherReports.Visible = False
        GrpTransactionDocuments.Visible = True
        GrpButtons.Visible = True
    End Sub
    Private Sub chkSaleRet_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles chkSaleRet.LinkClicked
        ReportFile = ReportProcess.ReportFiles.SaleInvoiceReturn
        GrpOtherReports.Visible = False
        GrpTransactionDocuments.Visible = True
        GrpButtons.Visible = True
    End Sub
    Private Sub BtnChkDocumentNatureListTRL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChkDocumentNatureListTRL.Click
        Call DocumentTypeText(TxtDocumentNatureTRL, LstTransactionNatureTRL)
        If LstTransactionNatureTRL.Visible = True Then
            LstTransactionNatureTRL.Visible = False
        ElseIf LstTransactionNatureTRL.Visible = False Then
            LstTransactionNatureTRL.Visible = True
            LstTransactionNatureTRL.BringToFront()
            LstTransactionNatureTRL.Focus()
        End If
    End Sub
#Region "List View Procedures"
    Private Function GetDocumentTypeCode(ByRef lstView As ListView) As String
        Dim retunString As String = String.Empty
        Dim b As ListViewItem
        For Each b In lstView.CheckedItems
            retunString = IIf(retunString = "", "'" & Trim(CType(b, ListViewItem).Tag) & "'", retunString & "," & "'" & Trim(CType(b, ListViewItem).Tag) & "'")
        Next
        GetDocumentTypeCode = Replace(retunString, "'", "")
        Return GetDocumentTypeCode
    End Function
    Private Sub FillDocTypeList(ByRef lstVew As ListView, Optional ByVal Terms As String = "")
        Dim nRst As SqlClient.SqlDataReader
        Dim Acc As AzamTechnologies.Database.DataAccess
        Dim OPTIONS As String = String.Empty
        Dim SYSTEM As String = String.Empty
        'Get All Term For Making Condition
        '<zee>

        Select Case Terms

            Case "TR", "PRR"
                OPTIONS = ""
            Case "INVENTORY"
                OPTIONS = "ALL"
                SYSTEM = "IN"
            Case "GENERALLEDGER"
                OPTIONS = "ALL"
                SYSTEM = "GL"

        End Select
        '</zee>
        Dim lstSub As New ListViewItem.ListViewSubItem
        Acc = New AzamTechnologies.Database.DataAccess
        nRst = Acc.GetRecord("SelectTransactionNatures", "OPTION", OPTIONS, "System", SYSTEM)
        If nRst.HasRows Then
            While nRst.Read()
                'nRst.Sort = "TransactionNature, TransactionType"
                ' if 
                Dim lstItem As New ListViewItem
                lstItem.Text = nRst("Nature")
                lstItem.Tag = nRst("NatureCode")
                lstItem.Checked = True
                lstVew.Items.Add(lstItem)
                'Else
                '    lstSub.Text = nRst("GLCode") & "-" & nRst("GLDescription")
                '    lstSub.Tag = nRst("GLCode")
                '    lstItem.SubItems.Add(lstSub)
                'End If
            End While
        End If
        Acc = Nothing
        nRst = Nothing
    End Sub

    Private Sub FillVehicleList(ByRef lstVew As ListView, Optional ByVal Terms As String = "")
        Dim nRst As SqlClient.SqlDataReader
        Dim Acc As AzamTechnologies.Database.DataAccess
        Dim OPTIONS As String = String.Empty
        Dim SYSTEM As String = String.Empty
        'Get All Term For Making Condition
        '<zee>
        '</zee>
        Dim lstSub As New ListViewItem.ListViewSubItem
        Acc = New AzamTechnologies.Database.DataAccess
        nRst = Acc.GetRecord("[SelectVehicles]", "OPTION", "COMBO")
        If nRst.HasRows Then
            While nRst.Read()
                'nRst.Sort = "TransactionNature, TransactionType"
                ' if 
                Dim lstItem As New ListViewItem
                lstItem.Text = nRst("VehicleCode")
                lstItem.Tag = nRst("VehicleCode")
                lstItem.Checked = True
                lstVew.Items.Add(lstItem)
                'Else
                '    lstSub.Text = nRst("GLCode") & "-" & nRst("GLDescription")
                '    lstSub.Tag = nRst("GLCode")
                '    lstItem.SubItems.Add(lstSub)
                'End If
            End While
        End If
        Acc = Nothing
        nRst = Nothing
    End Sub

    Private Sub FillCOAList(ByVal lstVew As ListView, ByVal parameterOption As String)
        Dim nRst As SqlClient.SqlDataReader
        Dim Acc As AzamTechnologies.Database.DataAccess
        Dim OPTIONS As String = String.Empty
        Dim SYSTEM As String = String.Empty
        'Get All Term For Making Condition
        '<zee>

        Acc = New AzamTechnologies.Database.DataAccess
        nRst = Acc.GetRecord("SelectCOACombine", "OPTION", parameterOption, "GLCode", My.Settings.CashAndBankGLCode)
        If nRst.HasRows Then
            While nRst.Read()

                'nRst.Sort = "TransactionNature, TransactionType"
                Dim lstItem As New ListViewItem
                Dim lstSub As New ListViewItem.ListViewSubItem
                ' If Trim(nRst("GLCode")).ToString.Length = Val(My.Settings.ControlCode_Length + My.Settings.GeneralCode_Length) Then
                lstItem.Text = nRst("GLCode") & "-" & nRst("GLDescription")
                lstItem.Tag = nRst("GLCode")
                lstItem.Checked = True
                lstItem.Font = New Font("Arial", 8, FontStyle.Bold)
                'Else
                '    lstSub.Text = nRst("GLCode") & "-" & nRst("GLDescription")
                '    lstSub.Tag = nRst("GLCode")
                '    lstItem.SubItems.Add(lstSub)
                'End If
                lstVew.Items.Add(lstItem)

            End While

        End If
        Acc = Nothing
        nRst = Nothing





    End Sub
    Private Sub DocumentTypeText(ByRef TxtBox As Infragistics.Win.UltraWinEditors.UltraTextEditor, ByRef lstView As ListView)
        If lstView.Items.Count = lstView.CheckedItems.Count Then
            TxtBox.Text = "All Selected"
        ElseIf lstView.CheckedItems.Count = 1 Then
            TxtBox.Text = " " & lstView.CheckedItems(0).Text
        ElseIf lstView.CheckedItems.Count = 0 Then
            TxtBox.Text = "None"
        ElseIf lstView.CheckedItems.Count > 1 Then
            TxtBox.Text = "Variouse Selected"
        End If
    End Sub
#End Region
    Private Sub chkTransactionListing_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles chkTransactionListing.LinkClicked
        ReportFile = ReportProcess.ReportFiles.TransactionList
        GrpOtherReports.Visible = False
        GrpTransactionList.Visible = True
        GrpButtons.Visible = True
        If LstTransactionNatureTRL.Items.Count = 0 Then
            FillDocTypeList(LstTransactionNatureTRL)
        End If
    End Sub
    Private Sub LstTransactionTypeCodeTRL_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles LstTransactionNatureTRL.ColumnClick
        Dim item As ListViewItem
        If LstTransactionNatureTRL.CheckedItems.Count = LstTransactionNatureTRL.Items.Count Then
            For Each item In LstTransactionNatureTRL.Items
                item.Checked = False
            Next
        ElseIf LstTransactionNatureTRL.CheckedItems.Count >= 0 Then
            For Each item In LstTransactionNatureTRL.Items
                item.Checked = True
            Next

        End If
    End Sub
    Private Sub chkItemTrialBalance_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles chkItemTrialBalance.LinkClicked
        ReportFile = ReportProcess.ReportFiles.TrialBalance
        GrpOtherReports.Visible = False
        GrpGeneralLedger.Visible = True
        GrpButtons.Visible = True
        If LstTransactionNatureTRL.Items.Count = 0 Then
            FillDocTypeList(lstTransactionNatureIL)
        End If
    End Sub

    Private Sub lblOtherReportIL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblOtherReportsIL.LinkClicked
        GrpGeneralLedger.Visible = False
        GrpOtherReports.Visible = True
        GrpButtons.Visible = False
    End Sub

    Private Sub BtnDocumentNatureListIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDocumentNatureListIL.Click
        Call DocumentTypeText(txtDocumentNatureIL, lstTransactionNatureIL)
        If lstTransactionNatureIL.Visible = True Then
            lstTransactionNatureIL.Visible = False
        ElseIf lstTransactionNatureIL.Visible = False Then
            lstTransactionNatureIL.Visible = True
            lstTransactionNatureIL.BringToFront()
            lstTransactionNatureIL.Focus()
        End If
    End Sub

    Private Sub ReportParameters_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub


    Private Sub LblOtherReportsTRL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LblOtherReportsTRL.LinkClicked
        GrpTransactionList.Visible = False
        GrpOtherReports.Visible = True
        GrpButtons.Visible = False
    End Sub



    Private Sub chkGeneralLedgers_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles chkGeneralLedgers.LinkClicked
        ReportFile = ReportProcess.ReportFiles.GeneralLedger
        GrpOtherReports.Visible = False
        GrpGeneralLedger.Visible = True
        GrpButtons.Visible = True
        If lstTransactionNatureIL.Items.Count = 0 Then
            FillDocTypeList(lstTransactionNatureIL)
        End If
    End Sub
    Private Sub lstTransactionNatureIL_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstTransactionNatureIL.ColumnClick
        Dim item As ListViewItem
        If lstTransactionNatureIL.CheckedItems.Count = lstTransactionNatureIL.Items.Count Then
            For Each item In lstTransactionNatureIL.Items
                item.Checked = False
            Next
        ElseIf lstTransactionNatureIL.CheckedItems.Count >= 0 Then
            For Each item In lstTransactionNatureIL.Items
                item.Checked = True
            Next
        End If
    End Sub
    Private Sub BtnVoucherTypeListVDO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVoucherTypeListVDO.Click
        Call DocumentTypeText(TxtVoucherTypesVDO, LvwVoucherTypesVDO)
        If LvwVoucherTypesVDO.Visible = True Then
            LvwVoucherTypesVDO.Visible = False
        ElseIf LvwVoucherTypesVDO.Visible = False Then
            LvwVoucherTypesVDO.Visible = True
            LvwVoucherTypesVDO.BringToFront()
            LvwVoucherTypesVDO.Focus()
        End If
    End Sub
    Private Sub BtnVoucherTypesListVLT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVoucherTypesListVLT.Click
        Call DocumentTypeText(TxtVoucherTypesVLT, LvwVoucherTypesVLT)
        If LvwVoucherTypesVLT.Visible = True Then
            LvwVoucherTypesVLT.Visible = False
        ElseIf LvwVoucherTypesVLT.Visible = False Then
            LvwVoucherTypesVLT.Visible = True
            LvwVoucherTypesVLT.BringToFront()
            LvwVoucherTypesVLT.Focus()
        End If
    End Sub
    Private Sub BtnVehicleLstVR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVehicleLstVR.Click
        Call DocumentTypeText(TxtVehicleLstVR, LstVehicleVR)
        If LstVehicleVR.Visible = True Then
            LstVehicleVR.Visible = False
        ElseIf LstVehicleVR.Visible = False Then
            LstVehicleVR.Visible = True
            LstVehicleVR.BringToFront()
            LstVehicleVR.Focus()
        End If
    End Sub

    Private Sub LvwVoucherTypesVLT_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles LvwVoucherTypesVLT.ColumnClick
        Dim item As ListViewItem
        If LvwVoucherTypesVLT.CheckedItems.Count = LvwVoucherTypesVLT.Items.Count Then
            For Each item In LvwVoucherTypesVLT.Items
                item.Checked = False
            Next
        ElseIf LvwVoucherTypesVLT.CheckedItems.Count >= 0 Then
            For Each item In LvwVoucherTypesVLT.Items
                item.Checked = True
            Next
        End If
    End Sub
    Private Sub LstVehicleLstVR_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles LstVehicleVR.ColumnClick
        Dim item As ListViewItem
        If LstVehicleVR.CheckedItems.Count = LstVehicleVR.Items.Count Then
            For Each item In LstVehicleVR.Items
                item.Checked = False
            Next
        ElseIf LstVehicleVR.CheckedItems.Count >= 0 Then
            For Each item In LstVehicleVR.Items
                item.Checked = True
            Next
        End If
    End Sub
    Private Sub LvwVoucherTypesVDO_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles LvwVoucherTypesVDO.ColumnClick
        Dim item As ListViewItem
        If LvwVoucherTypesVDO.CheckedItems.Count = LvwVoucherTypesVDO.Items.Count Then
            For Each item In LvwVoucherTypesVDO.Items
                item.Checked = False
            Next
        ElseIf LvwVoucherTypesVDO.CheckedItems.Count >= 0 Then
            For Each item In LvwVoucherTypesVDO.Items
                item.Checked = True
            Next
        End If
    End Sub


    Private Sub ToOwnerList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnToOwnerList.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("VehicleOwners")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtToOwnerCodeVB.Text = frmser.UGSearch.Rows(iRow).Cells("OwnerCode").Value
            Me.TxtToOwnerCodeVB.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnFromVehicleList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFromVehicleList.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Vehicles")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtFromVehicleCodeVB.Text = frmser.UGSearch.Rows(iRow).Cells("VehicleCode").Value
            Me.TxtFromVehicleCodeVB.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnToVehicleList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnToVehicleList.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Vehicles")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtToVehicleCodeVB.Text = frmser.UGSearch.Rows(iRow).Cells("VehicleCode").Value
            Me.TxtToVehicleCodeVB.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnFromOwnerList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFromOwnerList.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("VehicleOwners")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtFromOwnerCodeVB.Text = frmser.UGSearch.Rows(iRow).Cells("OwnerCode").Value
            Me.TxtFromOwnerCodeVB.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnFromGLCodeListVLT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFromGLCodeListVLT.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("COACombine")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtFromGLCodeVLT.Text = frmser.UGSearch.Rows(iRow).Cells("GLCode").Value
            Me.TxtFromGLCodeVLT.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnToGLCodeListVLT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnToGLCodeListVLT.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("COACombine")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtToGLCodeVLT.Text = frmser.UGSearch.Rows(iRow).Cells("GLCode").Value
            Me.TxtToGLCodeVLT.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LvwVoucherTypesVLT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LvwVoucherTypesVLT.SelectedIndexChanged

    End Sub

    Private Sub BtnFromGLCodeListIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFromGLCodeListIL.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("COACombine")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.txtFromGLCodeIL.Text = frmser.UGSearch.Rows(iRow).Cells("GLCode").Value
            Me.txtFromGLCodeIL.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnToGLCodeListIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnToGLCodeListIL.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("COACombine")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.txtToGLCodeIL.Text = frmser.UGSearch.Rows(iRow).Cells("GLCode").Value
            Me.txtToGLCodeIL.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnFromBranchListIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFromBranchListIL.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Branches")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.txtFromBranchCodeIL.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
            Me.txtFromBranchCodeIL.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnToBranchListIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnToBranchListIL.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Branches")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.txtToBranchCodeIL.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
            Me.txtToBranchCodeIL.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnDivisionListIL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Divisions")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.txtFromDivisionCodeIL.Text = frmser.UGSearch.Rows(iRow).Cells("DivisionCode").Value
            Me.txtFromDivisionCodeIL.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Divisions")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.txtToDivisionIL.Text = frmser.UGSearch.Rows(iRow).Cells("DivisionCode").Value
            Me.txtToDivisionIL.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnCashAccountsCFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCashAccountsCFS.Click
        Call DocumentTypeText(TxtCashAccountsCFS, LstCashAccountsCFS)
        If LstCashAccountsCFS.Visible = True Then
            LstCashAccountsCFS.Visible = False
        ElseIf LstCashAccountsCFS.Visible = False Then
            LstCashAccountsCFS.Visible = True
            LstCashAccountsCFS.BringToFront()
            LstCashAccountsCFS.Focus()
        End If
    End Sub

    Private Sub imgProgressBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imgProgressBar.Click

    End Sub

    Private Sub BtnFromBranchCodeCFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFromBranchCodeCFS.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Branches")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtFromBranchCodeCFS.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
            Me.TxtFromBranchCodeCFS.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Divisions")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtFromDivisionCFS.Text = frmser.UGSearch.Rows(iRow).Cells("DivisionCode").Value
            Me.TxtFromDivisionCFS.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Divisions")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtToDivisionCFS.Text = frmser.UGSearch.Rows(iRow).Cells("DivisionCode").Value
            Me.TxtToDivisionCFS.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Branches")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtToBranchCodeCFS.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
            Me.TxtToBranchCodeCFS.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnFrGLCodeListFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFrGLCodeListFS.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("COACombine")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtFromGLCodeFS.Text = frmser.UGSearch.Rows(iRow).Cells("GLCode").Value
            Me.TxtFromGLCodeFS.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnToGLCodeListFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnToGLCodeListFS.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("COACombine")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtToGLCodeFS.Text = frmser.UGSearch.Rows(iRow).Cells("GLCode").Value
            Me.TxtToGLCodeFS.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CmbReportTypeVFS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbReportTypeVFS.SelectedIndexChanged
        If CmbReportTypeVFS.SelectedIndex = 0 Then
            ReportFile = ReportFiles.FreightStatement
        Else
            If OptDetailVFS.Checked Then
                ReportFile = ReportFiles.FreightStatementDetail
            Else
                ReportFile = ReportFiles.FreightStatementSummary
            End If
        End If
    End Sub
    Private Sub OptSummaryVFS_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptSummaryVFS.Validated
        If OptSummaryVFS.Checked = True Then
            Me.ReportFile = ReportFiles.FreightStatementSummary
        Else
            Me.ReportFile = ReportFiles.FreightStatementDetail
        End If
    End Sub
    Private Sub OptDetailVFS_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptDetailVFS.Validated
        If OptDetailVFS.Checked = True Then
            Me.ReportFile = ReportFiles.FreightStatementDetail
        Else
            Me.ReportFile = ReportFiles.FreightStatementSummary
        End If
    End Sub

    Private Sub BtnFromBranchListVFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFromBranchListVFS.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Branches")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtFromBranchVFS.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
            Me.TxtFromBranchVFS.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnFromVehicleListVFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFromVehicleListVFS.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Vehicles")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtFromVehicleVFS.Text = frmser.UGSearch.Rows(iRow).Cells("VehicleCode").Value
            Me.TxtFromVehicleVFS.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnToVehicleListVFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnToVehicleListVFS.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Vehicles")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtToVehicleVFS.Text = frmser.UGSearch.Rows(iRow).Cells("VehicleCode").Value
            Me.TxtToVehicleVFS.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnFromCustomerListVFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFromCustomerListVFS.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Customers")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtFromCustomerVFS.Text = frmser.UGSearch.Rows(iRow).Cells("CustomerCode").Value
            Me.TxtFromCustomerVFS.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnToCustomerListVFS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnToCustomerListVFS.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Customers")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtToCustomerVFS.Text = frmser.UGSearch.Rows(iRow).Cells("CustomerCode").Value
            Me.TxtToCustomerVFS.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnShowToGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShowToGrid.Click
        If ReportFile = ReportProcess.ReportFiles.VoucherList Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            TargetControl = ReportTargetControl.Grid 'To Specify either on crystal report or grid
            If VoucherListProcess(ReportFile, Trim(TxtFromVoucherNoListVLT.Text), Trim(TxtToVoucherNoListVLT.Text), DtpFromVoucherDateVLT.Value, DtpToVoucherDateVLT.Value, Trim(TxtFromGLCodeVLT.Text), Trim(TxtToGLCodeVLT.Text), GetDocumentTypeCode(LvwVoucherTypesVLT), reportDoc, CmbGroupedByVLT.SelectedIndex, ChkPageBreakVLT.Checked) = True Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If
        ElseIf ReportFile = ReportProcess.ReportFiles.TransactionList Then
            Dim reportDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
            TargetControl = ReportTargetControl.Grid 'To Specify either on crystal report or grid
            If TransactionListProcess(ReportFile, Trim(txtFromTransactionNoTRL.Text), Trim(txtToTransactionNoTRL.Text), dtpFromTransactionDateTRL.Value, dtpToTransactionDateTRL.Value, Trim(txtFromPartyCodeTRL.Text), Trim(txtToPartyCodeTRL.Text), Trim(txtFromItemCodeTRL.Text), Trim(txtToItemCodeTRL.Text), GetDocumentTypeCode(LstTransactionNatureTRL), reportDoc, cmbGroupBy.SelectedIndex, chkPageBreakTRL.Checked) = True Then
                Dim rpViewer As New ReportViewer
                rpViewer.SetSource = reportDoc
                rpViewer.MdiParent = Me.MdiParent
                rpViewer.Show()
                rpViewer.BringToFront()
                Cursor = Cursors.Default
                imgProgressBar.Visible = False
            End If

        End If
    End Sub

    Private Sub cmbFromItemListTRL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFromItemListTRL.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Customers")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.txtFromItemCodeTRL.Text = frmser.UGSearch.Rows(iRow).Cells("CustomerCode").Value
            Me.txtFromItemCodeTRL.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbToItemListTRL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbToItemListTRL.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Customers")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.txtToItemCodeTRL.Text = frmser.UGSearch.Rows(iRow).Cells("CustomerCode").Value
            Me.txtToItemCodeTRL.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbFromPartyCodeListTRL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFromPartyCodeListTRL.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Vehicles")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.txtFromPartyCodeTRL.Text = frmser.UGSearch.Rows(iRow).Cells("VehicleCode").Value
            Me.txtFromPartyCodeTRL.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmbToPartyCodeListTRL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbToPartyCodeListTRL.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Vehicles")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.txtToPartyCodeTRL.Text = frmser.UGSearch.Rows(iRow).Cells("VehicleCode").Value
            Me.txtToPartyCodeTRL.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ChkTripWithBill_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkTripWithBill.CheckedChanged

    End Sub

    Private Sub GrpVehicleRevenue_Paint(sender As Object, e As PaintEventArgs) Handles GrpVehicleRevenue.Paint

    End Sub
End Class
