Imports System.ComponentModel
Imports System.Data.SqlClient
Namespace GeneralLedger
    Public Class Invoices
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
        Friend WithEvents UltraTabControl1 As Infragistics.Win.UltraWinTabControl.UltraTabControl
        Friend WithEvents UltraTabSharedControlsPage1 As Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage
        Friend WithEvents UltraTabPageControl1 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Friend WithEvents TxtCommissionRate As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents ChkIsLocalTrip As CheckBox
        Friend WithEvents Label22 As Label
        Friend WithEvents Label21 As Label
        Friend WithEvents TxtTripAdvance As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label20 As Label
        Friend WithEvents TxtAdvanceReferenceNo As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtQuantityValue As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label18 As Label
        Friend WithEvents TxtShortageQuantity As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label16 As Label
        Friend WithEvents TxtTokenNo As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label15 As Label
        Friend WithEvents Label14 As Label
        Friend WithEvents TxtQuantity As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents TxtShortage As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label12 As Label
        Friend WithEvents TxtCommission As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label13 As Label
        Friend WithEvents txtAmount As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label10 As Label
        Friend WithEvents TxtRate As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label11 As Label
        Friend WithEvents TxtVehicle As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label8 As Label
        Friend WithEvents TxtVehicleCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtProduct As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label7 As Label
        Friend WithEvents TxtProductCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtDestinationPoint As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label6 As Label
        Friend WithEvents TxtDestinationPointCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtStationPoint As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label5 As Label
        Friend WithEvents TxtStationPointCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtCustomer As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label4 As Label
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents txtBranch As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label3 As Label
        Friend WithEvents txtBranchCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents txtDescription As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents txtTransactionNumber As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents TxtDate As DateTimePicker
        Friend WithEvents Label19 As Label
        Friend WithEvents Label17 As Label
        Friend WithEvents Label26 As Label
        Friend WithEvents TxtLongTripRefNo As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents UltraTabPageControl2 As Infragistics.Win.UltraWinTabControl.UltraTabPageControl
        Friend WithEvents FpVehicleAdjustmentGrid As FarPoint.Win.Spread.FpSpread
        Friend WithEvents FpVehicleAdjustmentGrid_Sheet1 As FarPoint.Win.Spread.SheetView
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim BevelBorder1 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
            Dim TextCellType1 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim TextCellType2 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim TextCellType3 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim TextCellType4 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim DateTimeCellType1 As FarPoint.Win.Spread.CellType.DateTimeCellType = New FarPoint.Win.Spread.CellType.DateTimeCellType()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoices))
            Dim TextCellType6 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim CurrencyCellType1 As FarPoint.Win.Spread.CellType.CurrencyCellType = New FarPoint.Win.Spread.CellType.CurrencyCellType()
            Dim TextCellType7 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim TextCellType8 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim UltraTab3 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
            Dim UltraTab1 As Infragistics.Win.UltraWinTabControl.UltraTab = New Infragistics.Win.UltraWinTabControl.UltraTab()
            Me.UltraTabPageControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
            Me.Label26 = New System.Windows.Forms.Label()
            Me.TxtLongTripRefNo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.TxtCommissionRate = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
            Me.ChkIsLocalTrip = New System.Windows.Forms.CheckBox()
            Me.Label22 = New System.Windows.Forms.Label()
            Me.Label21 = New System.Windows.Forms.Label()
            Me.TxtTripAdvance = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
            Me.Label20 = New System.Windows.Forms.Label()
            Me.TxtAdvanceReferenceNo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.TxtQuantityValue = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
            Me.Label18 = New System.Windows.Forms.Label()
            Me.TxtShortageQuantity = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.TxtTokenNo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label14 = New System.Windows.Forms.Label()
            Me.TxtQuantity = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
            Me.TxtShortage = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.TxtCommission = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
            Me.Label13 = New System.Windows.Forms.Label()
            Me.txtAmount = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.TxtRate = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
            Me.Label11 = New System.Windows.Forms.Label()
            Me.TxtVehicle = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.TxtVehicleCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.TxtProduct = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.TxtProductCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.TxtDestinationPoint = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.TxtDestinationPointCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.TxtStationPoint = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.TxtStationPointCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.TxtCustomer = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.txtBranch = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtBranchCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.txtDescription = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.txtTransactionNumber = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.TxtDate = New System.Windows.Forms.DateTimePicker()
            Me.Label19 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.UltraTabPageControl2 = New Infragistics.Win.UltraWinTabControl.UltraTabPageControl()
            Me.FpVehicleAdjustmentGrid = New FarPoint.Win.Spread.FpSpread()
            Me.FpVehicleAdjustmentGrid_Sheet1 = New FarPoint.Win.Spread.SheetView()
            Me.UltraTabControl1 = New Infragistics.Win.UltraWinTabControl.UltraTabControl()
            Me.UltraTabSharedControlsPage1 = New Infragistics.Win.UltraWinTabControl.UltraTabSharedControlsPage()
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.UltraTabPageControl1.SuspendLayout()
            CType(Me.TxtLongTripRefNo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCommissionRate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtTripAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtAdvanceReferenceNo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtQuantityValue, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtShortageQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtTokenNo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtShortage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCommission, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtRate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtVehicle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtVehicleCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtProduct, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtProductCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtDestinationPoint, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtDestinationPointCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtStationPoint, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtStationPointCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtBranch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtBranchCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtTransactionNumber, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.UltraTabPageControl2.SuspendLayout()
            CType(Me.FpVehicleAdjustmentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FpVehicleAdjustmentGrid_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.UltraTabControl1.SuspendLayout()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'UltraTabPageControl1
            '
            Me.UltraTabPageControl1.Controls.Add(Me.Label26)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtLongTripRefNo)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtCommissionRate)
            Me.UltraTabPageControl1.Controls.Add(Me.ChkIsLocalTrip)
            Me.UltraTabPageControl1.Controls.Add(Me.Label22)
            Me.UltraTabPageControl1.Controls.Add(Me.Label21)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtTripAdvance)
            Me.UltraTabPageControl1.Controls.Add(Me.Label20)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtAdvanceReferenceNo)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtQuantityValue)
            Me.UltraTabPageControl1.Controls.Add(Me.Label18)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtShortageQuantity)
            Me.UltraTabPageControl1.Controls.Add(Me.Label16)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtTokenNo)
            Me.UltraTabPageControl1.Controls.Add(Me.Label15)
            Me.UltraTabPageControl1.Controls.Add(Me.Label14)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtQuantity)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtShortage)
            Me.UltraTabPageControl1.Controls.Add(Me.Label12)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtCommission)
            Me.UltraTabPageControl1.Controls.Add(Me.Label13)
            Me.UltraTabPageControl1.Controls.Add(Me.txtAmount)
            Me.UltraTabPageControl1.Controls.Add(Me.Label10)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtRate)
            Me.UltraTabPageControl1.Controls.Add(Me.Label11)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtVehicle)
            Me.UltraTabPageControl1.Controls.Add(Me.Label8)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtVehicleCode)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtProduct)
            Me.UltraTabPageControl1.Controls.Add(Me.Label7)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtProductCode)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtDestinationPoint)
            Me.UltraTabPageControl1.Controls.Add(Me.Label6)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtDestinationPointCode)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtStationPoint)
            Me.UltraTabPageControl1.Controls.Add(Me.Label5)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtStationPointCode)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtCustomer)
            Me.UltraTabPageControl1.Controls.Add(Me.Label4)
            Me.UltraTabPageControl1.Controls.Add(Me.Desc)
            Me.UltraTabPageControl1.Controls.Add(Me.txtBranch)
            Me.UltraTabPageControl1.Controls.Add(Me.Label3)
            Me.UltraTabPageControl1.Controls.Add(Me.txtBranchCode)
            Me.UltraTabPageControl1.Controls.Add(Me.txtDescription)
            Me.UltraTabPageControl1.Controls.Add(Me.txtTransactionNumber)
            Me.UltraTabPageControl1.Controls.Add(Me.Label2)
            Me.UltraTabPageControl1.Controls.Add(Me.Label1)
            Me.UltraTabPageControl1.Controls.Add(Me.Label9)
            Me.UltraTabPageControl1.Controls.Add(Me.TxtDate)
            Me.UltraTabPageControl1.Controls.Add(Me.Label19)
            Me.UltraTabPageControl1.Controls.Add(Me.Label17)
            Me.UltraTabPageControl1.Location = New System.Drawing.Point(-10000, -10000)
            Me.UltraTabPageControl1.Name = "UltraTabPageControl1"
            Me.UltraTabPageControl1.Size = New System.Drawing.Size(960, 591)
            '
            'Label26
            '
            Me.Label26.BackColor = System.Drawing.Color.Transparent
            Me.Label26.ForeColor = System.Drawing.Color.Navy
            Me.Label26.Location = New System.Drawing.Point(41, 261)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(110, 20)
            Me.Label26.TabIndex = 242
            Me.Label26.Text = "Long Trip Ref. No"
            '
            'TxtLongTripRefNo
            '
            Me.TxtLongTripRefNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.TxtLongTripRefNo.Appearance = Appearance1
            Me.TxtLongTripRefNo.BackColor = System.Drawing.SystemColors.Window
            Me.TxtLongTripRefNo.Location = New System.Drawing.Point(153, 260)
            Me.TxtLongTripRefNo.MaxLength = 10
            Me.TxtLongTripRefNo.Name = "TxtLongTripRefNo"
            Me.TxtLongTripRefNo.Size = New System.Drawing.Size(138, 21)
            Me.TxtLongTripRefNo.TabIndex = 204
            Me.TxtLongTripRefNo.Tag = "FK.LongTripRefNo"
            '
            'TxtCommissionRate
            '
            Me.TxtCommissionRate.Location = New System.Drawing.Point(415, 445)
            Me.TxtCommissionRate.MinValue = CType(-21474836489999, Long)
            Me.TxtCommissionRate.Name = "TxtCommissionRate"
            Me.TxtCommissionRate.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtCommissionRate.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtCommissionRate.Size = New System.Drawing.Size(120, 21)
            Me.TxtCommissionRate.TabIndex = 207
            Me.TxtCommissionRate.Tag = "dt.CommissionRate"
            '
            'ChkIsLocalTrip
            '
            Me.ChkIsLocalTrip.AutoSize = True
            Me.ChkIsLocalTrip.BackColor = System.Drawing.Color.Transparent
            Me.ChkIsLocalTrip.Location = New System.Drawing.Point(297, 263)
            Me.ChkIsLocalTrip.Name = "ChkIsLocalTrip"
            Me.ChkIsLocalTrip.Size = New System.Drawing.Size(73, 17)
            Me.ChkIsLocalTrip.TabIndex = 203
            Me.ChkIsLocalTrip.Tag = "dd.IsLocalTrip"
            Me.ChkIsLocalTrip.Text = "Local Trip"
            Me.ChkIsLocalTrip.UseVisualStyleBackColor = False
            '
            'Label22
            '
            Me.Label22.BackColor = System.Drawing.Color.Transparent
            Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label22.Location = New System.Drawing.Point(459, 447)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(69, 20)
            Me.Label22.TabIndex = 239
            Me.Label22.Text = "%"
            '
            'Label21
            '
            Me.Label21.BackColor = System.Drawing.Color.Transparent
            Me.Label21.ForeColor = System.Drawing.Color.Navy
            Me.Label21.Location = New System.Drawing.Point(305, 445)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(110, 20)
            Me.Label21.TabIndex = 238
            Me.Label21.Text = "Commission Rate"
            '
            'TxtTripAdvance
            '
            Me.TxtTripAdvance.Location = New System.Drawing.Point(291, 235)
            Me.TxtTripAdvance.Name = "TxtTripAdvance"
            Me.TxtTripAdvance.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtTripAdvance.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtTripAdvance.ReadOnly = True
            Me.TxtTripAdvance.Size = New System.Drawing.Size(120, 21)
            Me.TxtTripAdvance.TabIndex = 237
            Me.TxtTripAdvance.Tag = "dt.TripAdvance"
            Me.TxtTripAdvance.Visible = False
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.Transparent
            Me.Label20.ForeColor = System.Drawing.Color.Navy
            Me.Label20.Location = New System.Drawing.Point(41, 237)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(110, 20)
            Me.Label20.TabIndex = 236
            Me.Label20.Text = "Expences Reference"
            '
            'TxtAdvanceReferenceNo
            '
            Me.TxtAdvanceReferenceNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.TxtAdvanceReferenceNo.Appearance = Appearance2
            Me.TxtAdvanceReferenceNo.BackColor = System.Drawing.SystemColors.Window
            Me.TxtAdvanceReferenceNo.Location = New System.Drawing.Point(153, 235)
            Me.TxtAdvanceReferenceNo.MaxLength = 10
            Me.TxtAdvanceReferenceNo.Name = "TxtAdvanceReferenceNo"
            Me.TxtAdvanceReferenceNo.Size = New System.Drawing.Size(138, 21)
            Me.TxtAdvanceReferenceNo.TabIndex = 202
            Me.TxtAdvanceReferenceNo.Tag = "FK.TripAdvanceReference"
            '
            'TxtQuantityValue
            '
            Me.TxtQuantityValue.Location = New System.Drawing.Point(714, 419)
            Me.TxtQuantityValue.Name = "TxtQuantityValue"
            Me.TxtQuantityValue.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtQuantityValue.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtQuantityValue.Size = New System.Drawing.Size(120, 21)
            Me.TxtQuantityValue.TabIndex = 209
            Me.TxtQuantityValue.Tag = "dt.QuantityValue"
            Me.TxtQuantityValue.Visible = False
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.Color.Transparent
            Me.Label18.ForeColor = System.Drawing.Color.Navy
            Me.Label18.Location = New System.Drawing.Point(604, 419)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(110, 20)
            Me.Label18.TabIndex = 234
            Me.Label18.Text = "Quantity Value"
            Me.Label18.Visible = False
            '
            'TxtShortageQuantity
            '
            Me.TxtShortageQuantity.Location = New System.Drawing.Point(714, 397)
            Me.TxtShortageQuantity.Name = "TxtShortageQuantity"
            Me.TxtShortageQuantity.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtShortageQuantity.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtShortageQuantity.Size = New System.Drawing.Size(120, 21)
            Me.TxtShortageQuantity.TabIndex = 208
            Me.TxtShortageQuantity.Tag = "dt.ShortageQuantity"
            Me.TxtShortageQuantity.Visible = False
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.Color.Transparent
            Me.Label16.ForeColor = System.Drawing.Color.Navy
            Me.Label16.Location = New System.Drawing.Point(604, 397)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(110, 20)
            Me.Label16.TabIndex = 232
            Me.Label16.Text = "Shortage Quantity"
            Me.Label16.Visible = False
            '
            'TxtTokenNo
            '
            Me.TxtTokenNo.Location = New System.Drawing.Point(413, 66)
            Me.TxtTokenNo.MaxLength = 10
            Me.TxtTokenNo.Name = "TxtTokenNo"
            Me.TxtTokenNo.Size = New System.Drawing.Size(120, 21)
            Me.TxtTokenNo.TabIndex = 195
            Me.TxtTokenNo.Tag = "IM.CustomerReference"
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.Transparent
            Me.Label15.ForeColor = System.Drawing.Color.Navy
            Me.Label15.Location = New System.Drawing.Point(331, 69)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(82, 20)
            Me.Label15.TabIndex = 231
            Me.Label15.Text = "Token No"
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.Transparent
            Me.Label14.ForeColor = System.Drawing.Color.Navy
            Me.Label14.Location = New System.Drawing.Point(305, 397)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(110, 20)
            Me.Label14.TabIndex = 230
            Me.Label14.Text = "Quantity"
            '
            'TxtQuantity
            '
            Me.TxtQuantity.Location = New System.Drawing.Point(415, 397)
            Me.TxtQuantity.Name = "TxtQuantity"
            Me.TxtQuantity.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtQuantity.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtQuantity.Size = New System.Drawing.Size(120, 21)
            Me.TxtQuantity.TabIndex = 206
            Me.TxtQuantity.Tag = "dt.Quantity"
            '
            'TxtShortage
            '
            Me.TxtShortage.AccessibleDescription = "Last"
            Me.TxtShortage.Location = New System.Drawing.Point(714, 442)
            Me.TxtShortage.Name = "TxtShortage"
            Me.TxtShortage.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtShortage.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtShortage.Size = New System.Drawing.Size(120, 21)
            Me.TxtShortage.TabIndex = 210
            Me.TxtShortage.Tag = "dt.Shortage"
            Me.TxtShortage.Visible = False
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.Transparent
            Me.Label12.ForeColor = System.Drawing.Color.Navy
            Me.Label12.Location = New System.Drawing.Point(604, 442)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(110, 20)
            Me.Label12.TabIndex = 229
            Me.Label12.Text = "Shortage"
            Me.Label12.Visible = False
            '
            'TxtCommission
            '
            Me.TxtCommission.Enabled = False
            Me.TxtCommission.Location = New System.Drawing.Point(415, 469)
            Me.TxtCommission.Name = "TxtCommission"
            Me.TxtCommission.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtCommission.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtCommission.ReadOnly = True
            Me.TxtCommission.Size = New System.Drawing.Size(120, 21)
            Me.TxtCommission.TabIndex = 211
            Me.TxtCommission.Tag = "dt.Commission"
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.Transparent
            Me.Label13.ForeColor = System.Drawing.Color.Navy
            Me.Label13.Location = New System.Drawing.Point(305, 470)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(110, 20)
            Me.Label13.TabIndex = 228
            Me.Label13.Text = "Commission"
            '
            'txtAmount
            '
            Me.txtAmount.Location = New System.Drawing.Point(415, 493)
            Me.txtAmount.MaxValue = CType(21474836471222, Long)
            Me.txtAmount.Name = "txtAmount"
            Me.txtAmount.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.txtAmount.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.txtAmount.Size = New System.Drawing.Size(120, 21)
            Me.txtAmount.TabIndex = 208
            Me.txtAmount.Tag = "dt.Amount"
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.Transparent
            Me.Label10.ForeColor = System.Drawing.Color.Navy
            Me.Label10.Location = New System.Drawing.Point(305, 493)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(110, 20)
            Me.Label10.TabIndex = 227
            Me.Label10.Text = "Amount"
            '
            'TxtRate
            '
            Me.TxtRate.Location = New System.Drawing.Point(415, 421)
            Me.TxtRate.MinValue = CType(-21474836489999, Long)
            Me.TxtRate.Name = "TxtRate"
            Me.TxtRate.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtRate.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtRate.Size = New System.Drawing.Size(120, 21)
            Me.TxtRate.TabIndex = 206
            Me.TxtRate.Tag = "dt.Rate"
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.ForeColor = System.Drawing.Color.Navy
            Me.Label11.Location = New System.Drawing.Point(305, 426)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(110, 20)
            Me.Label11.TabIndex = 226
            Me.Label11.Text = "Rate"
            '
            'TxtVehicle
            '
            Me.TxtVehicle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance3.BackColor = System.Drawing.SystemColors.Window
            Me.TxtVehicle.Appearance = Appearance3
            Me.TxtVehicle.BackColor = System.Drawing.SystemColors.Window
            Me.TxtVehicle.Location = New System.Drawing.Point(291, 115)
            Me.TxtVehicle.Name = "TxtVehicle"
            Me.TxtVehicle.Size = New System.Drawing.Size(628, 21)
            Me.TxtVehicle.TabIndex = 224
            Me.TxtVehicle.TabStop = False
            Me.TxtVehicle.Tag = "dd.VehicleDescription"
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.ForeColor = System.Drawing.Color.Navy
            Me.Label8.Location = New System.Drawing.Point(41, 115)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(110, 20)
            Me.Label8.TabIndex = 225
            Me.Label8.Text = "Vehicle "
            '
            'TxtVehicleCode
            '
            Me.TxtVehicleCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance4.BackColor = System.Drawing.SystemColors.Window
            Me.TxtVehicleCode.Appearance = Appearance4
            Me.TxtVehicleCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtVehicleCode.Location = New System.Drawing.Point(153, 115)
            Me.TxtVehicleCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.VehicleCode_Length
            Me.TxtVehicleCode.Name = "TxtVehicleCode"
            Me.TxtVehicleCode.Size = New System.Drawing.Size(138, 21)
            Me.TxtVehicleCode.TabIndex = 196
            Me.TxtVehicleCode.Tag = "FK.VehicleCode"
            '
            'TxtProduct
            '
            Me.TxtProduct.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance5.BackColor = System.Drawing.SystemColors.Window
            Me.TxtProduct.Appearance = Appearance5
            Me.TxtProduct.BackColor = System.Drawing.SystemColors.Window
            Me.TxtProduct.Location = New System.Drawing.Point(291, 139)
            Me.TxtProduct.Name = "TxtProduct"
            Me.TxtProduct.Size = New System.Drawing.Size(628, 21)
            Me.TxtProduct.TabIndex = 222
            Me.TxtProduct.TabStop = False
            Me.TxtProduct.Tag = "dd.ProductName"
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.ForeColor = System.Drawing.Color.Navy
            Me.Label7.Location = New System.Drawing.Point(41, 137)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(110, 20)
            Me.Label7.TabIndex = 223
            Me.Label7.Text = "Product"
            '
            'TxtProductCode
            '
            Me.TxtProductCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance6.BackColor = System.Drawing.SystemColors.Window
            Me.TxtProductCode.Appearance = Appearance6
            Me.TxtProductCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtProductCode.Location = New System.Drawing.Point(153, 139)
            Me.TxtProductCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.ProductCode_Length
            Me.TxtProductCode.Name = "TxtProductCode"
            Me.TxtProductCode.Size = New System.Drawing.Size(138, 21)
            Me.TxtProductCode.TabIndex = 197
            Me.TxtProductCode.Tag = "FK.ProductCode"
            '
            'TxtDestinationPoint
            '
            Me.TxtDestinationPoint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance7.BackColor = System.Drawing.SystemColors.Window
            Me.TxtDestinationPoint.Appearance = Appearance7
            Me.TxtDestinationPoint.BackColor = System.Drawing.SystemColors.Window
            Me.TxtDestinationPoint.Enabled = False
            Me.TxtDestinationPoint.Location = New System.Drawing.Point(291, 187)
            Me.TxtDestinationPoint.Name = "TxtDestinationPoint"
            Me.TxtDestinationPoint.Size = New System.Drawing.Size(628, 21)
            Me.TxtDestinationPoint.TabIndex = 220
            Me.TxtDestinationPoint.TabStop = False
            Me.TxtDestinationPoint.Tag = "dd.DestinationPointName"
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.ForeColor = System.Drawing.Color.Navy
            Me.Label6.Location = New System.Drawing.Point(41, 187)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(110, 20)
            Me.Label6.TabIndex = 221
            Me.Label6.Text = "Destination Point"
            '
            'TxtDestinationPointCode
            '
            Me.TxtDestinationPointCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance8.BackColor = System.Drawing.SystemColors.Window
            Me.TxtDestinationPointCode.Appearance = Appearance8
            Me.TxtDestinationPointCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtDestinationPointCode.Location = New System.Drawing.Point(153, 187)
            Me.TxtDestinationPointCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.RegionCode_Length
            Me.TxtDestinationPointCode.Name = "TxtDestinationPointCode"
            Me.TxtDestinationPointCode.Size = New System.Drawing.Size(138, 21)
            Me.TxtDestinationPointCode.TabIndex = 199
            Me.TxtDestinationPointCode.Tag = "FK.DestinationPointCode"
            '
            'TxtStationPoint
            '
            Me.TxtStationPoint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance9.BackColor = System.Drawing.SystemColors.Window
            Me.TxtStationPoint.Appearance = Appearance9
            Me.TxtStationPoint.BackColor = System.Drawing.SystemColors.Window
            Me.TxtStationPoint.Enabled = False
            Me.TxtStationPoint.Location = New System.Drawing.Point(291, 163)
            Me.TxtStationPoint.Name = "TxtStationPoint"
            Me.TxtStationPoint.Size = New System.Drawing.Size(628, 21)
            Me.TxtStationPoint.TabIndex = 218
            Me.TxtStationPoint.TabStop = False
            Me.TxtStationPoint.Tag = "dd.StationPointName"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.ForeColor = System.Drawing.Color.Navy
            Me.Label5.Location = New System.Drawing.Point(41, 163)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(110, 20)
            Me.Label5.TabIndex = 219
            Me.Label5.Text = "Station Point"
            '
            'TxtStationPointCode
            '
            Me.TxtStationPointCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance10.BackColor = System.Drawing.SystemColors.Window
            Me.TxtStationPointCode.Appearance = Appearance10
            Me.TxtStationPointCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtStationPointCode.Location = New System.Drawing.Point(153, 163)
            Me.TxtStationPointCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.RegionCode_Length
            Me.TxtStationPointCode.Name = "TxtStationPointCode"
            Me.TxtStationPointCode.Size = New System.Drawing.Size(138, 21)
            Me.TxtStationPointCode.TabIndex = 198
            Me.TxtStationPointCode.Tag = "FK.StationPointCode"
            '
            'TxtCustomer
            '
            Me.TxtCustomer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance11.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCustomer.Appearance = Appearance11
            Me.TxtCustomer.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCustomer.Location = New System.Drawing.Point(291, 91)
            Me.TxtCustomer.Name = "TxtCustomer"
            Me.TxtCustomer.Size = New System.Drawing.Size(628, 21)
            Me.TxtCustomer.TabIndex = 216
            Me.TxtCustomer.TabStop = False
            Me.TxtCustomer.Tag = "dd.CustomerName"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.ForeColor = System.Drawing.Color.Navy
            Me.Label4.Location = New System.Drawing.Point(41, 91)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(110, 20)
            Me.Label4.TabIndex = 217
            Me.Label4.Text = "Customer"
            '
            'Desc
            '
            Me.Desc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance12.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Appearance = Appearance12
            Me.Desc.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Location = New System.Drawing.Point(153, 91)
            Me.Desc.MaxLength = 5
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(138, 21)
            Me.Desc.TabIndex = 194
            Me.Desc.Tag = "FK.CustomerCode"
            '
            'txtBranch
            '
            Me.txtBranch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance13.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranch.Appearance = Appearance13
            Me.txtBranch.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranch.Location = New System.Drawing.Point(291, 43)
            Me.txtBranch.Name = "txtBranch"
            Me.txtBranch.Size = New System.Drawing.Size(628, 21)
            Me.txtBranch.TabIndex = 200
            Me.txtBranch.TabStop = False
            Me.txtBranch.Tag = "dd.BranchName"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.ForeColor = System.Drawing.Color.Navy
            Me.Label3.Location = New System.Drawing.Point(41, 43)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(110, 20)
            Me.Label3.TabIndex = 215
            Me.Label3.Text = "Branch"
            '
            'txtBranchCode
            '
            Me.txtBranchCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance14.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchCode.Appearance = Appearance14
            Me.txtBranchCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchCode.Location = New System.Drawing.Point(153, 43)
            Me.txtBranchCode.MaxLength = 2
            Me.txtBranchCode.Name = "txtBranchCode"
            Me.txtBranchCode.Size = New System.Drawing.Size(138, 21)
            Me.txtBranchCode.TabIndex = 192
            Me.txtBranchCode.Tag = "PK.BranchCode"
            '
            'txtDescription
            '
            Me.txtDescription.Location = New System.Drawing.Point(153, 285)
            Me.txtDescription.Multiline = True
            Me.txtDescription.Name = "txtDescription"
            Me.txtDescription.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDescription.Size = New System.Drawing.Size(272, 56)
            Me.txtDescription.TabIndex = 205
            Me.txtDescription.Tag = "ds.Description"
            '
            'txtTransactionNumber
            '
            Me.txtTransactionNumber.AcceptsReturn = True
            Me.txtTransactionNumber.Location = New System.Drawing.Point(153, 67)
            Me.txtTransactionNumber.MaxLength = 10
            Me.txtTransactionNumber.Name = "txtTransactionNumber"
            Me.txtTransactionNumber.Size = New System.Drawing.Size(138, 21)
            Me.txtTransactionNumber.TabIndex = 193
            Me.txtTransactionNumber.Tag = "PK.TransactionNo"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(41, 288)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 214
            Me.Label2.Text = "Description"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(41, 67)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 213
            Me.Label1.Text = "Document No"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.ForeColor = System.Drawing.Color.Navy
            Me.Label9.Location = New System.Drawing.Point(41, 213)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(110, 20)
            Me.Label9.TabIndex = 212
            Me.Label9.Text = "Document Date"
            '
            'TxtDate
            '
            Me.TxtDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
            Me.TxtDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
            Me.TxtDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
            Me.TxtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.TxtDate.Location = New System.Drawing.Point(153, 212)
            Me.TxtDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.TxtDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.TxtDate.Name = "TxtDate"
            Me.TxtDate.Size = New System.Drawing.Size(100, 20)
            Me.TxtDate.TabIndex = 201
            Me.TxtDate.Tag = "dt.TransactionDate"
            '
            'Label19
            '
            Me.Label19.BackColor = System.Drawing.Color.Transparent
            Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label19.Font = New System.Drawing.Font("Courier New", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.ForeColor = System.Drawing.Color.Purple
            Me.Label19.Location = New System.Drawing.Point(291, 360)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(258, 171)
            Me.Label19.TabIndex = 235
            Me.Label19.Text = "Total"
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.Transparent
            Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label17.Font = New System.Drawing.Font("Courier New", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.ForeColor = System.Drawing.Color.Purple
            Me.Label17.Location = New System.Drawing.Point(594, 360)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(258, 171)
            Me.Label17.TabIndex = 233
            Me.Label17.Text = "Shortage"
            Me.Label17.Visible = False
            '
            'UltraTabPageControl2
            '
            Me.UltraTabPageControl2.Controls.Add(Me.FpVehicleAdjustmentGrid)
            Me.UltraTabPageControl2.Location = New System.Drawing.Point(1, 23)
            Me.UltraTabPageControl2.Name = "UltraTabPageControl2"
            Me.UltraTabPageControl2.Size = New System.Drawing.Size(960, 591)
            '
            'FpVehicleAdjustmentGrid
            '
            Me.FpVehicleAdjustmentGrid.AccessibleDescription = "FpVehicleAdjustmentGrid, Sheet1, Row 0, Column 0, "
            Me.FpVehicleAdjustmentGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.FpVehicleAdjustmentGrid.BackColor = System.Drawing.SystemColors.Control
            Me.FpVehicleAdjustmentGrid.EditModeReplace = True
            Me.FpVehicleAdjustmentGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.FpVehicleAdjustmentGrid.Location = New System.Drawing.Point(24, 106)
            Me.FpVehicleAdjustmentGrid.Name = "FpVehicleAdjustmentGrid"
            Me.FpVehicleAdjustmentGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.FpVehicleAdjustmentGrid.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.FpVehicleAdjustmentGrid_Sheet1})
            Me.FpVehicleAdjustmentGrid.Size = New System.Drawing.Size(913, 488)
            Me.FpVehicleAdjustmentGrid.TabIndex = 9
            '
            'FpVehicleAdjustmentGrid_Sheet1
            '
            Me.FpVehicleAdjustmentGrid_Sheet1.Reset()
            Me.FpVehicleAdjustmentGrid_Sheet1.SheetName = "Sheet1"
            'Formulas and custom names must be loaded with R1C1 reference style
            Me.FpVehicleAdjustmentGrid_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
            FpVehicleAdjustmentGrid_Sheet1.ColumnCount = 11
            FpVehicleAdjustmentGrid_Sheet1.RowCount = 10
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnFooter.DefaultStyle.Border = BevelBorder1
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnFooter.DefaultStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnFooter.DefaultStyle.Parent = "ColumnFooterEnhanced"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnFooter.Rows.Get(0).Height = 37.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnFooter.Visible = True
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "BranchCode"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "TransactionNature"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "TransactionNo"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "TypeCode"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "Type"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "Date"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "UrduDescription"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "Description"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "Amount"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 9).Value = "GLCode"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 10).Value = "GLDescription"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Rows.Get(0).Height = 19.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(0).CellType = TextCellType1
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(0).Label = "BranchCode"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(0).Visible = False
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(1).CellType = TextCellType2
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(1).Label = "TransactionNature"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(1).Visible = False
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(2).CellType = TextCellType3
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(2).Label = "TransactionNo"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(2).Visible = False
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(3).CellType = TextCellType4
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(3).Label = "TypeCode"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(3).Width = 56.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(4).CellType = TextCellType5
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(4).Label = "Type"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(4).Width = 176.0!
            DateTimeCellType1.Calendar = CType(resources.GetObject("DateTimeCellType1.Calendar"), System.Globalization.Calendar)
            DateTimeCellType1.CalendarSurroundingDaysColor = System.Drawing.SystemColors.GrayText
            DateTimeCellType1.DateDefault = New Date(2018, 5, 12, 9, 21, 1, 0)
            DateTimeCellType1.DropDownButton = True
            DateTimeCellType1.MaximumTime = System.TimeSpan.Parse("23:59:59.9999999")
            DateTimeCellType1.SimpleEdit = True
            DateTimeCellType1.SpinButton = True
            DateTimeCellType1.TimeDefault = New Date(2018, 5, 12, 9, 21, 1, 0)
            DateTimeCellType1.UserDefinedFormat = "DD/MMM/YYYY"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(5).CellType = DateTimeCellType1
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(5).Label = "Date"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(5).Locked = False
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(5).Width = 85.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(6).CellType = TextCellType6
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(6).Label = "UrduDescription"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(6).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(6).Width = 120.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(7).Label = "Description"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(7).Width = 218.0!
            CurrencyCellType1.DecimalPlaces = 2
            CurrencyCellType1.MaximumValue = New Decimal(New Integer() {-727379969, 232, 0, 131072})
            CurrencyCellType1.MinimumValue = New Decimal(New Integer() {1215752191, 23, 0, -2147352576})
            CurrencyCellType1.NegativeRed = True
            CurrencyCellType1.Separator = ","
            CurrencyCellType1.ShowCurrencySymbol = False
            CurrencyCellType1.ShowSeparator = True
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(8).CellType = CurrencyCellType1
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(8).Label = "Amount"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(8).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(8).Width = 88.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(9).CellType = TextCellType7
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(9).Label = "GLCode"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(9).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(9).Width = 123.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(10).CellType = TextCellType8
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(10).Label = "GLDescription"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(10).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(10).Width = 194.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
            Me.FpVehicleAdjustmentGrid_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
            Me.FpVehicleAdjustmentGrid_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
            Me.FpVehicleAdjustmentGrid_Sheet1.RowHeader.Columns.Default.Resizable = False
            Me.FpVehicleAdjustmentGrid_Sheet1.RowHeader.Columns.Get(0).Width = 26.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(0).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(1).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(2).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(3).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(4).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(5).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(6).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(7).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(8).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(9).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Tag = "VehicleAdjustmentsDetails"
            Me.FpVehicleAdjustmentGrid_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
            '
            'UltraTabControl1
            '
            Me.UltraTabControl1.Controls.Add(Me.UltraTabSharedControlsPage1)
            Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl1)
            Me.UltraTabControl1.Controls.Add(Me.UltraTabPageControl2)
            Me.UltraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UltraTabControl1.Location = New System.Drawing.Point(0, 0)
            Me.UltraTabControl1.Name = "UltraTabControl1"
            Me.UltraTabControl1.SharedControlsPage = Me.UltraTabSharedControlsPage1
            Me.UltraTabControl1.Size = New System.Drawing.Size(964, 617)
            Me.UltraTabControl1.TabIndex = 0
            Me.UltraTabControl1.TabOrientation = Infragistics.Win.UltraWinTabs.TabOrientation.TopRight
            UltraTab3.TabPage = Me.UltraTabPageControl1
            UltraTab3.Text = "Freight"
            UltraTab1.TabPage = Me.UltraTabPageControl2
            UltraTab1.Text = "Freight Expences"
            Me.UltraTabControl1.Tabs.AddRange(New Infragistics.Win.UltraWinTabControl.UltraTab() {UltraTab3, UltraTab1})
            '
            'UltraTabSharedControlsPage1
            '
            Me.UltraTabSharedControlsPage1.Location = New System.Drawing.Point(-10000, -10000)
            Me.UltraTabSharedControlsPage1.Name = "UltraTabSharedControlsPage1"
            Me.UltraTabSharedControlsPage1.Size = New System.Drawing.Size(960, 591)
            '
            'ErrProvider
            '
            Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
            Me.ErrProvider.ContainerControl = Me
            Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
            Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
            '
            'Invoices
            '
            Me.AccessibleName = "Invoices"
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(964, 617)
            Me.Controls.Add(Me.UltraTabControl1)
            Me.KeyPreview = True
            Me.Name = "Invoices"
            Me.Text = "Invoice File "
            Me.UltraTabPageControl1.ResumeLayout(False)
            Me.UltraTabPageControl1.PerformLayout()
            CType(Me.TxtLongTripRefNo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCommissionRate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtTripAdvance, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtAdvanceReferenceNo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtQuantityValue, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtShortageQuantity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtTokenNo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtQuantity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtShortage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCommission, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtRate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtVehicle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtVehicleCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtProduct, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtProductCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtDestinationPoint, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtDestinationPointCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtStationPoint, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtStationPointCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtBranch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtBranchCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtTransactionNumber, System.ComponentModel.ISupportInitialize).EndInit()
            Me.UltraTabPageControl2.ResumeLayout(False)
            CType(Me.FpVehicleAdjustmentGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FpVehicleAdjustmentGrid_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.UltraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.UltraTabControl1.ResumeLayout(False)
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        Dim CmbGlCode As FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
        Dim CmbGlDesc As FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
        Dim CmbDivCode As FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
        Dim CmbDivDesc As FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
        Private Dr As SqlDataReader
        Dim FreshMode As Boolean
        Dim LockGrid As Boolean
        Dim DsVehicle As DataSet
        Dim DsGLs As DataSet
        Dim DsDiv As DataSet
        Private Enum GridCols
            BranchCode = 0
            VehicleAdjustmentNature = 1
            VehicleAdjustmentNumber = 2
            TypeCode = 3
            Type = 4
            FreightDate = 5
            UrduDescription = 6
            Description = 7
            Amount = 8
            GLCode = 9
            GLDescription = 10
        End Enum
        Private Sub JournalVehicleAdjustment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ''''''''''''For just solving the problem of this form when closing then mdi windows handling problum
            CmbGlCode = New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
            CmbGlDesc = New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
            CmbDivCode = New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
            CmbDivDesc = New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
            PainFPGrid(FpVehicleAdjustmentGrid)
            keychange()
            If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                TxtDate.Value = CurrentWorkingDate
            End If
            Try
                ''''''
                SettingGrid()
                ''
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Sub SettingGrid()
            ''''''''''''''''''''''''
            ''''''''''''''''''''''''''

            ''''Combo setting

            'GL Accounts
            ''''''''''''''''''''''''''''''''''''''
            FillCombo(DsGLs, "SelectCOASubSubsidiaries", "OPTION", "COMBO")

            Me.FpVehicleAdjustmentGrid.ButtonDrawMode = FarPoint.Win.Spread.ButtonDrawModes.CurrentCell

            With DsGLs.Tables(0)
                CmbGlCode.DataSourceList = DsGLs
                CmbGlCode.ListOffset = 10
                CmbGlCode.AutoSearch = FarPoint.Win.AutoSearch.MultipleCharacter
                CmbGlCode.ShowColumnHeaders = True
                CmbGlCode.DataMemberList = "Table"

            End With

            CmbGlCode.ListWidth = 300

            With DsGLs.Tables(0)
                CmbGlDesc.DataSourceList = DsGLs
                CmbGlDesc.ListOffset = 10
                CmbGlDesc.AutoSearch = FarPoint.Win.AutoSearch.MultipleCharacter
                CmbGlDesc.ShowColumnHeaders = True
                CmbGlDesc.DataMemberList = "Table"


            End With
            CmbGlDesc.ListWidth = 300

            'Types
            ''''''''''''''''''''''''''''''''''''''
            FillCombo(DsDiv, "SelectTransactionTypes", "OPTION", "COMBO", "NatureCode", VehiclePaymentNature)

            Me.FpVehicleAdjustmentGrid.ButtonDrawMode = FarPoint.Win.Spread.ButtonDrawModes.CurrentCell

            With DsDiv.Tables(0)
                CmbDivCode.DataSourceList = DsDiv
                CmbDivCode.ListOffset = 10
                CmbDivCode.AutoSearch = FarPoint.Win.AutoSearch.MultipleCharacter
                CmbDivCode.ShowColumnHeaders = True
                CmbDivCode.DataMemberList = "Table"

            End With



            With DsDiv.Tables(0)
                CmbDivDesc.DataSourceList = DsDiv
                CmbDivDesc.ListOffset = 10
                CmbDivDesc.AutoSearch = FarPoint.Win.AutoSearch.MultipleCharacter
                CmbDivDesc.ShowColumnHeaders = True
                CmbDivDesc.DataMemberList = "Table"

            End With
            FpVehicleAdjustmentGrid.Sheets(0).Tag = "VehicleAdjustmentsDetails"
            CmbDivDesc.ListWidth = 500

            'If Me.NATURE.Text = VehicleAdjustmentPaymentNature Or Me.NATURE.Text = VehicleAdjustmentReceiptNature Then
            '    Me.lblCheque.Visible = False : Me.CmbMode.Visible = False : Me.lblMode.Visible = False : Me.TxtChequeNo.Visible = False
            'Else
            '    Me.lblCheque.Visible = True : Me.CmbMode.Visible = True : Me.lblMode.Visible = True : Me.TxtChequeNo.Visible = True
            'End If



            'TOTAL CELL SETTINGS
            Dim TotalCellType = New FarPoint.Win.Spread.CellType.CurrencyCellType
            TotalCellType.ShowCurrencySymbol = False
            Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Amount - 1).Value = "Total:"

            Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Amount).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right
            Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Amount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right
            Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Amount).CellType = TotalCellType
            Dim r As Integer
            Dim j As Integer
            For r = 0 To Me.FpVehicleAdjustmentGrid.Sheets(0).RowCount
                For j = 0 To Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnCount
                    Me.FpVehicleAdjustmentGrid.Sheets(0).Models.Data.SetValue(r, j, j + r * Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnCount)
                Next j
            Next r
            Dim i As Integer
            i = 0
            Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnFooter.SetAggregationType(0, GridCols.Amount, FarPoint.Win.Spread.Model.AggregationType.Sum)
            Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnFooter.Cells(0, i).Value = "Sum"



        End Sub
        Sub keychange()
            Dim im As New FarPoint.Win.Spread.InputMap
            ' Define the operation of pressing Enter key in cells not beingedited as "Move to the next row".
            im = FpVehicleAdjustmentGrid.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused)
            im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
            ' Define the operation of pressing Enter key in cells being editedas "Move to the next row".
            im = FpVehicleAdjustmentGrid.GetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused)
            im.Put(New FarPoint.Win.Spread.Keystroke(Keys.Enter, Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        End Sub
        Private Sub FpVehicleAdjustmentGrid_LeaveCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.LeaveCellEventArgs) Handles FpVehicleAdjustmentGrid.LeaveCell
            Me.Cursor = Cursors.WaitCursor
            ''''''''''''
            Dim ErrString As String = String.Empty
            ''''''''''''
            'SetComboToGrid(NewCol, NewRow)
            If LockGrid = False Then
                Select Case e.Column
                    Case GridCols.GLCode
                        validComboData(GridCols.GLCode, e.Row)
                    Case GridCols.GLDescription
                        validComboData(GridCols.GLDescription, e.Row)
                    Case GridCols.TypeCode
                        validComboData(GridCols.TypeCode, e.Row)
                    Case GridCols.Type
                        validComboData(GridCols.Type, e.Row)


                End Select
                LockGrid = True
                'If Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(GridCols.GLCode, e.row)) = "" And Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(GridCols.PONo, Row)) = "" Then
                If Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(e.Row, GridCols.TypeCode)) = "" Then

                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.VehicleAdjustmentNature, String.Empty)
                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.VehicleAdjustmentNumber, String.Empty)
                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.BranchCode, String.Empty)

                    FpVehicleAdjustmentGrid.Sheets(0).SetTag(e.Row, GridCols.BranchCode, String.Empty)
                    FpVehicleAdjustmentGrid.Sheets(0).SetTag(e.Row, GridCols.VehicleAdjustmentNumber, String.Empty)
                    FpVehicleAdjustmentGrid.Sheets(0).SetTag(e.Row, GridCols.VehicleAdjustmentNature, String.Empty)

                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.GLCode, String.Empty)
                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.GLDescription, String.Empty)


                Else
                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.VehicleAdjustmentNumber, txtTransactionNumber.Text)
                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.VehicleAdjustmentNature, VehiclePaymentNature)
                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.BranchCode, txtBranchCode.Text)

                    FpVehicleAdjustmentGrid.Sheets(0).SetTag(e.Row, GridCols.BranchCode, "BranchCode")
                    FpVehicleAdjustmentGrid.Sheets(0).SetTag(e.Row, GridCols.VehicleAdjustmentNumber, "TransactionNo")
                    FpVehicleAdjustmentGrid.Sheets(0).SetTag(e.Row, GridCols.VehicleAdjustmentNature, "TransactionNature")


                    'If Val(FpVehicleAdjustmentGrid.Sheets(0).GetText(e.Row, GridCols.Amount)) = 0 Then
                    '    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.Amount, 0D)
                    'End If
                    If e.NewRow = FpVehicleAdjustmentGrid.Sheets(0).RowCount - 1 Then
                        FpVehicleAdjustmentGrid_Sheet1.AddRows(FpVehicleAdjustmentGrid.Sheets(0).RowCount, 1)
                    End If
                End If
                LockGrid = False
            End If
            If LockGrid = False Then
                LockGrid = True

                ' Call VehicleAdjustmentGrid_ButtonClicked(Col, e.row, 0)
                LockGrid = False
            End If
            Me.Cursor = Cursors.Default
        End Sub

        Private Sub FpVehicleAdjustmentGrid_EnterCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.EnterCellEventArgs) Handles FpVehicleAdjustmentGrid.EnterCell
            If e.Column = GridCols.GLCode Then
                CmbGlCode.ColumnEdit = 0
                CmbGlCode.DataColumn = 0
                FpVehicleAdjustmentGrid.Sheets(0).Cells(e.Row, e.Column, e.Row, e.Column).CellType = CmbGlCode
                CmbGlCode.ListWidth = 380
            ElseIf e.Column = GridCols.GLDescription Then
                CmbGlDesc.ColumnEdit = 1
                CmbGlDesc.DataColumn = 1
                FpVehicleAdjustmentGrid.Sheets(0).Cells(e.Row, e.Column, e.Row, e.Column).CellType = CmbGlDesc
                CmbGlDesc.ListWidth = 380
            ElseIf e.Column = GridCols.TypeCode Then
                CmbDivCode.ColumnEdit = 0
                CmbDivCode.DataColumn = 0
                FpVehicleAdjustmentGrid.Sheets(0).Cells(e.Row, e.Column, e.Row, e.Column).CellType = CmbDivCode
                CmbDivCode.ListWidth = 450
            ElseIf e.Column = GridCols.Type Then
                CmbDivDesc.ColumnEdit = 1
                CmbDivDesc.DataColumn = 1
                FpVehicleAdjustmentGrid.Sheets(0).Cells(e.Row, e.Column, e.Row, e.Column).CellType = CmbDivDesc
                CmbDivDesc.ListWidth = 450
            End If
        End Sub

        Private Sub dtpDate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDate.Validated
            ErrProvider.SetError(TxtDate, String.Empty)
        End Sub
        Public Sub dtpDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtDate.Validating
            Dim DateError As String
            DateError = ValidateTransactionDate(TxtDate.Value, Me.Tag)
            If DateError <> String.Empty Then
                ErrProvider.SetError(TxtDate, DateError)
                e.Cancel = True
                Exit Sub
            End If
            Try
                'If txtTransactionNumber.Text <> String.Empty And txtTransactionNumber.Text.Length = txtTransactionNumber.MaxLength Then
                If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                    txtTransactionNumber.Text = String.Empty
                    KeyGeneration()
                Else
                    If DateSerial(TxtDate.Value.Year, TxtDate.Value.Month, 1) <> DateSerial("20" & Mid(txtTransactionNumber.Text, 1, 2), Mid(txtTransactionNumber.Text, 3, 2), 1) Then
                        e.Cancel = True
                        ErrProvider.SetError(TxtDate, "You cannot change the Month Or Year for this Transaction Date..." & vbCrLf & "Please specify a valid Date within " & MonthName(Mid(txtTransactionNumber.Text, 3, 2)) & ", " & Year(DateSerial(Mid(txtTransactionNumber.Text, 1, 2), 1, 1)))
                        Exit Sub
                    End If

                End If
                'End If
            Catch ex As System.ArgumentException
                e.Cancel = True
                ErrProvider.SetError(TxtDate, "You cannot change the Month Or Year for this Transaction Date..." & vbCrLf & "Please specify a valid Date within " & MonthName(Mid(txtTransactionNumber.Text, 3, 2)) & ", " & Year(DateSerial(Mid(txtTransactionNumber.Text, 1, 2), 1, 1)))
            End Try
        End Sub
        Private Function validComboData(ByVal Col As GridCols, ByVal row As Int16) As Boolean
            If Col = GridCols.GLCode Then
                If Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.GLCode)) <> "" Then
                    Dim dv As New DataView
                    dv.Table = DsGLs.Tables(0)
                    dv.RowFilter = "GLCode='" & Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.GLCode)) & "'"

                    If dv.Count <> 0 Then
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.GLDescription, dv.Item(0).Item("GLDescription"))
                        Return True
                    Else
                        MessageBox.Show("Selected GLCode is not valid." & vbCrLf & "Please Enter an valide Item Code", "Item Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.GLCode, String.Empty)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.GLDescription, String.Empty)
                        Return False
                    End If
                Else
                    Return True
                End If
            ElseIf Col = GridCols.GLDescription Then
                If Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.GLDescription)) <> "" Then
                    Dim dv As New DataView
                    dv.Table = DsGLs.Tables(0)
                    dv.RowFilter = "GLDescription='" & Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.GLDescription)) & "'"

                    If dv.Count <> 0 Then
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.GLCode, dv.Item(0).Item("GLCode"))
                        Return True
                    Else
                        MessageBox.Show("Selected Item is not valid." & vbCrLf & "Please Enter an valide Item Code", "Item Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.GLCode, String.Empty)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.GLDescription, String.Empty)
                        Return False
                    End If
                Else
                    Return True
                End If

            ElseIf Col = GridCols.TypeCode Then
                If Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.TypeCode)) <> "" Then
                    Dim dv As New DataView
                    dv.Table = DsDiv.Tables(0)
                    dv.RowFilter = "TypeCode='" & Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.TypeCode)) & "'"

                    If dv.Count <> 0 Then
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.Type, dv.Item(0).Item("Type"))
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.UrduDescription, IIf(IsDBNull(dv.Item(0).Item("UrduTitle")), "", dv.Item(0).Item("UrduTitle")))
                        Return True
                    Else
                        MessageBox.Show("Selected Type Code is not valid." & vbCrLf & "Please Enter an valide Type Code", "Type Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.TypeCode, String.Empty)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.Type, String.Empty)
                        Return False
                    End If
                Else
                    Return True
                End If
            ElseIf Col = GridCols.Type Then
                If Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.Type)) <> "" Then
                    Dim dv As New DataView
                    dv.Table = DsDiv.Tables(0)
                    dv.RowFilter = "Type='" & Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.Type)) & "'"

                    If dv.Count <> 0 Then
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.TypeCode, dv.Item(0).Item("TypeCode"))
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.UrduDescription, IIf(IsDBNull(dv.Item(0).Item("UrduTitle")), "", dv.Item(0).Item("UrduTitle")))
                        Return True
                    Else
                        MessageBox.Show("Selected Type  is not valid." & vbCrLf & "Please Enter an valide Type ", "Type Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.TypeCode, String.Empty)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.Type, String.Empty)
                        Return False
                    End If
                Else
                    Return True
                End If
            End If

        End Function
        Private Sub FpVehicleAdjustmentGrid_SubEditorOpening(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.SubEditorOpeningEventArgs) Handles FpVehicleAdjustmentGrid.SubEditorOpening
            If e.SubEditor.ToString = "a7" Then 'multiple combo box
                Dim ss As FarPoint.Win.Spread.FpSpread
                ss = CType(e.SubEditor, FarPoint.Win.Spread.FpSpread)
                ss.Skin = FpVehicleAdjustmentGrid.Skin
                ss.BorderStyle = BorderStyle.FixedSingle
                ss.Sheets(0).Columns(0).AllowAutoSort = True
                ss.Sheets(0).Columns(1).AllowAutoSort = True
                If ss.Sheets(0).Columns.Count = 2 Then
                    ss.Sheets(0).Columns(1).Width = 230
                ElseIf ss.Sheets(0).Columns.Count = 3 Then
                    ss.Sheets(0).Columns(1).Width = 160
                    ss.Sheets(0).Columns(2).Width = 160
                End If
            End If
        End Sub

        Private Sub txtBranchCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtBranchCode.EditorButtonClick
            If txtBranchCode.Enabled = False Then Exit Sub
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Branches")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.txtBranchCode.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
                Me.txtBranch.Text = frmser.UGSearch.Rows(iRow).Cells("BranchName").Value
                Me.txtBranchCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtBranchCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBranchCode.GotFocus
            If Me.txtBranchCode.Text = String.Empty Then
                Me.txtBranchCode.Text = My.Settings.DefaultBranchCode
            End If
        End Sub

        Private Sub txtBranchCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.txtBranchCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub


        Private Sub Desc_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles Desc.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Customers")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.Desc.Text = frmser.UGSearch.Rows(iRow).Cells("CustomerCode").Value
                Me.TxtCustomer.Text = frmser.UGSearch.Rows(iRow).Cells("CustomerName").Value
                Me.Desc.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtCustomerCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Desc.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.Desc_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtVehicleCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtVehicleCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Vehicles")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtVehicleCode.Text = frmser.UGSearch.Rows(iRow).Cells("VehicleCode").Value
                Me.TxtVehicle.Text = frmser.UGSearch.Rows(iRow).Cells("VehicleDescription").Value
                Me.TxtVehicleCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtVehicleCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVehicleCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtVehicleCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtProductCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtProductCode.EditorButtonClick
            Try
                'Dim iRow As Integer
                'Dim frmser As FrmSearch
                'frmser = New FrmSearch
                'frmser.FillData("ProductRates")
                'frmser.ShowDialog()
                'iRow = frmser.UGSearch.ActiveRow.Index
                'Me.TxtProductCode.Text = frmser.UGSearch.Rows(iRow).Cells("ProductCode").Value
                'Me.TxtProduct.Text = frmser.UGSearch.Rows(iRow).Cells("ProductName").Value
                'Me.TxtStationPointCode.Text = frmser.UGSearch.Rows(iRow).Cells("StationPointCode").Value
                'Me.TxtStationPoint.Text = frmser.UGSearch.Rows(iRow).Cells("StationPointDescription").Value
                'Me.TxtDestinationPointCode.Text = frmser.UGSearch.Rows(iRow).Cells("DestinationPointCode").Value
                'Me.TxtDestinationPoint.Text = frmser.UGSearch.Rows(iRow).Cells("DestinationPointDescription").Value
                'Me.TxtProductCode.Focus()

                'Me.TxtRate.Value = frmser.UGSearch.Rows(iRow).Cells("Rate").Value
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Products")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtProductCode.Text = frmser.UGSearch.Rows(iRow).Cells("ProductCode").Value
                Me.TxtProduct.Text = frmser.UGSearch.Rows(iRow).Cells("ProductName").Value
                Me.TxtProductCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtProductCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProductCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtProductCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub NumericQuantity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQuantity.ValueChanged
            Try
                If TxtCommissionRate.Text = String.Empty Then
                    TxtCommissionRate.Text = TxtCommissionRate.NullText
                End If
                Me.TxtCommission.Value = Val(TxtCommissionRate.Text) / 100 * (Me.TxtQuantity.Value * Me.TxtRate.Value)
                Me.txtAmount.Value = (Me.TxtQuantity.Value * Me.TxtRate.Value)
            Catch ex As Exception
            End Try
        End Sub

        Private Sub Invoices_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                Me.TxtDate.Value = CurrentWorkingDate
            End If
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub
        Private Sub TxtProductCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtProductCode.Validating

            Try
                If TxtProductCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlDataReader
                    Reader = Acc.GetRecord("SelectProducts", "ProductCode ", Trim(TxtProductCode.Text))
                    If Reader.HasRows = False Then
                        ErrProvider.SetError(TxtProductCode, "Invalid Product Code")
                        ErrProvider.SetIconAlignment(TxtProductCode, ErrorIconAlignment.TopLeft)
                        TxtProductCode.Text = String.Empty
                        TxtProduct.Text = String.Empty
                        e.Cancel = True
                    Else
                        Reader.Read()
                        ErrProvider.SetError(TxtProductCode, String.Empty)
                        TxtProduct.Text = Reader.Item("ProductName")
                        Reader = Nothing
                        Reader = Acc.GetRecord("SelectProductValues", "OPTION", "LASTVALUE", "ProductCode", TxtProductCode.Text)
                        If Reader.HasRows Then
                            Reader.Read()
                            TxtQuantityValue.Value = Reader!QuantityValue
                        End If
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End Sub
        Private Sub TxtShortageQuantity_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtShortageQuantity.ValueChanged
            TxtShortage.Value = TxtShortageQuantity.Value * TxtQuantityValue.Value
        End Sub
        Private Sub TxtQuantityValue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtQuantityValue.ValueChanged
            TxtShortage.Value = TxtShortageQuantity.Value * TxtQuantityValue.Value
        End Sub

        Private Sub TxtCustomerCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Desc.Validated
            ErrProvider.SetError(Desc, String.Empty)
        End Sub

        Private Sub TxtCustomerCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Desc.Validating
            Try
                If Desc.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectCustomers", "CustomerCode ", Trim(Desc.Text))
                    If Reader.HasRows = False Then
                        ErrProvider.SetError(Desc, "Invalid Customer Code")
                        ErrProvider.SetIconAlignment(Desc, ErrorIconAlignment.TopLeft)
                        Desc.Text = String.Empty
                        TxtCustomer.Text = String.Empty
                        e.Cancel = True
                    Else
                        Reader.Read()
                        ErrProvider.SetError(Desc, String.Empty)
                        TxtCustomer.Text = Reader.Item("CustomerName")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub TxtVehicleCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtVehicleCode.Validated
            ErrProvider.SetError(TxtVehicleCode, String.Empty)
        End Sub

        Private Sub TxtVehicleCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtVehicleCode.Validating
            Try
                If TxtVehicleCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectVehicles", "VehicleCode ", Trim(TxtVehicleCode.Text))
                    If Reader.HasRows = False Then
                        ErrProvider.SetError(TxtVehicleCode, "Invalid Vehicle Code")
                        ErrProvider.SetIconAlignment(TxtVehicleCode, ErrorIconAlignment.TopLeft)
                        TxtVehicleCode.Text = String.Empty
                        TxtVehicle.Text = String.Empty
                        e.Cancel = True
                    Else
                        Reader.Read()
                        ErrProvider.SetError(TxtVehicleCode, String.Empty)
                        TxtVehicle.Text = Reader.Item("VehicleDescription")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Private Sub txtBranchCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBranchCode.Validated
            ErrProvider.SetError(txtBranchCode, String.Empty)
        End Sub

        Private Sub txtBranchCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBranchCode.Validating
            Try
                If txtBranchCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectBranches", "BranchCode ", Trim(txtBranchCode.Text))
                    If Reader.HasRows = False Then
                        ErrProvider.SetError(txtBranchCode, "Invalid Branch Code")
                        ErrProvider.SetIconAlignment(txtBranchCode, ErrorIconAlignment.TopLeft)
                        txtBranchCode.Text = String.Empty
                        txtBranch.Text = String.Empty
                        e.Cancel = True
                    Else
                        If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                            txtTransactionNumber.Text = String.Empty
                            KeyGeneration()
                        End If
                        Reader.Read()
                        ErrProvider.SetError(txtBranchCode, String.Empty)
                        txtBranch.Text = Reader.Item("BranchName")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub TxtStationPointCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtStationPointCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("StationPoints")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtStationPointCode.Text = frmser.UGSearch.Rows(iRow).Cells("StationPointCode").Value
                Me.TxtStationPoint.Text = frmser.UGSearch.Rows(iRow).Cells("StationPointName").Value
                Me.TxtStationPointCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtStationPointCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtStationPointCode.KeyDown

        End Sub
        Private Sub TxtStationPointCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtStationPointCode.Validated
            ErrProvider.SetError(TxtStationPointCode, String.Empty)
        End Sub

        Private Sub TxtStationPointCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtStationPointCode.Validating
            Try
                If TxtStationPointCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectStationPoints", "StationPointCode", Trim(TxtStationPointCode.Text))
                    If Reader.HasRows = False Then
                        TxtStationPointCode.Text = String.Empty
                        TxtStationPoint.Text = String.Empty
                        ErrProvider.SetError(TxtStationPointCode, "Invalid StationPoint Code")
                        ErrProvider.SetIconAlignment(TxtStationPointCode, ErrorIconAlignment.TopLeft)
                        e.Cancel = True
                    Else
                        ErrProvider.SetError(TxtStationPointCode, String.Empty)
                        Reader.Read()
                        TxtStationPoint.Text = Reader.Item("StationPointName")
                        Reader = Nothing
                        e.Cancel = False



                        ''''Code start for getting lattest Rates
                        Reader = Acc.GetRecord("SelectProductRates", "OPTION", "LASTVALUE", "StationPointCode", Trim(TxtStationPointCode.Text), "DestinationPointCode", Trim(TxtDestinationPointCode.Text), "ProductCode", TxtProductCode.Text)
                        If Reader.HasRows Then
                            Reader.Read()
                            TxtRate.Value = Reader("Rate")
                        Else
                            TxtRate.Value = 0D
                        End If

                        '''''END
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub TxtDestinationPointCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtDestinationPointCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("DestinationPoints")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtDestinationPointCode.Text = frmser.UGSearch.Rows(iRow).Cells("DestinationPointCode").Value
                Me.TxtDestinationPoint.Text = frmser.UGSearch.Rows(iRow).Cells("DestinationPointName").Value
                Me.TxtDestinationPointCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtDestinationPointCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDestinationPointCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtDestinationPointCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtDestinationPointCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDestinationPointCode.Validated
            ErrProvider.SetError(TxtDestinationPointCode, String.Empty)
        End Sub

        Private Sub TxtDestinationPointCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtDestinationPointCode.Validating
            Try
                If TxtDestinationPointCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectDestinationPoints", "DestinationPointCode", Trim(TxtDestinationPointCode.Text))
                    If Reader.HasRows = False Then
                        TxtDestinationPointCode.Text = String.Empty
                        TxtDestinationPoint.Text = String.Empty
                        ErrProvider.SetError(TxtDestinationPointCode, "Invalid DestinationPoint Code")
                        ErrProvider.SetIconAlignment(TxtDestinationPointCode, ErrorIconAlignment.TopLeft)
                        e.Cancel = True
                    Else
                        ErrProvider.SetError(TxtDestinationPointCode, String.Empty)
                        Reader.Read()
                        TxtDestinationPoint.Text = Reader.Item("DestinationPointName")
                        Reader = Nothing
                        e.Cancel = False



                        ''''Code start for getting lattest Rates
                        Reader = Acc.GetRecord("SelectProductRates", "OPTION", "LASTVALUE", "StationPointCode", Trim(TxtStationPointCode.Text), "DestinationPointCode", Trim(TxtDestinationPointCode.Text), "ProductCode", TxtProductCode.Text)
                        If Reader.HasRows Then
                            Reader.Read()
                            TxtRate.Value = Reader("Rate")
                        Else
                            TxtRate.Value = 0D
                        End If

                        '''''END
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Private Sub TxtRate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtRate.ValueChanged
            Try
                If TxtCommissionRate.Text = String.Empty Then
                    TxtCommissionRate.Text = TxtCommissionRate.NullText
                End If

                Me.TxtCommission.Value = Val(TxtCommissionRate.Text) / 100 * (Me.TxtQuantity.Value * Me.TxtRate.Value)
                Me.txtAmount.Value = (Me.TxtQuantity.Value * Me.TxtRate.Value)
            Catch ex As Exception

            End Try
        End Sub
        Private Sub KeyGeneration()
            If txtTransactionNumber.Text = String.Empty Then
                If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                    Dim objAcc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader
                    If Me.txtBranchCode.Text = String.Empty Then
                        Me.txtBranchCode.Text = My.Settings.DefaultBranchCode
                    End If
                    Reader = objAcc.GetRecord("Select" & Me.AccessibleName, "Option", "AUTO", "YearMonth", Format(TxtDate.Value, "yy") & Format(TxtDate.Value, "MM"), "BranchCode", txtBranchCode.Text)
                    'Auto increment the primary key field when we Add the 
                    ' AccessibleDescription Properties of the Control set to "AUTO"
                    If Reader.HasRows Then
                        While Reader.Read
                            txtTransactionNumber.Text = Reader.Item("TransactionNo")
                            txtTransactionNumber.Text = Integer.Parse(txtTransactionNumber.Text) + 1
                            If Mid(txtTransactionNumber.Text.Insert(0, "0"), 1, 2) = "09" Then
                                txtTransactionNumber.Text = txtTransactionNumber.Text.Insert(0, "0")
                                ' chCtr.Text = mManager.FormateData.FormatKeyYearMonthValue(chCtr.Text, CType(chCtr, TextBox).MaxLength)
                            End If
                            ' chCtr.Text = mManager.FormateData.FormatKeyYearMonthValue(chCtr.Text, CType(chCtr, TextBox).MaxLength)
                        End While
                    Else
                        txtTransactionNumber.Text = FormatKeyYearMonthValue(TxtDate.Value, txtTransactionNumber.Text, CType(txtTransactionNumber, Infragistics.Win.UltraWinEditors.UltraTextEditor).MaxLength)
                    End If
                    Reader = Nothing
                    objAcc = Nothing
                End If
            End If
        End Sub
        Private Sub txtTransactionNumber_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtTransactionNumber.EditorButtonClick
            If txtTransactionNumber.Enabled = False Then Exit Sub
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Invoices", "OPTION", "ALL")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.txtBranchCode.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
                Me.txtTransactionNumber.Text = frmser.UGSearch.Rows(iRow).Cells("TransactionNo").Value
                Me.TxtTokenNo.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub txtLocalTrip1_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtLongTripRefNo.EditorButtonClick
            If TxtLongTripRefNo.Enabled = False Then Exit Sub
            Try

                If Me.TxtVehicleCode.Text = String.Empty Or Me.txtBranchCode.Text = String.Empty Then
                    Me.ErrProvider.SetError(Me.TxtVehicleCode, "Please Enter First Vehicle Code and Branch Code")
                    Exit Sub
                End If
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Invoices", "OPTION", "SEARCHLONGTRIP", "VehicleNo", TxtVehicleCode.Text)
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.txtBranchCode.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
                Me.TxtLongTripRefNo.Text = frmser.UGSearch.Rows(iRow).Cells("TransactionNo").Value
                Me.TxtLongTripRefNo.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try


        End Sub

        Private Sub UltraTextEditor1_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtAdvanceReferenceNo.EditorButtonClick
            Try
                If Me.TxtVehicleCode.Text = String.Empty Or Me.txtBranchCode.Text = String.Empty Then
                    Me.ErrProvider.SetError(Me.TxtVehicleCode, "Please Enter First Vehicle Code and Branch Code")
                    Exit Sub
                End If
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("VehicleAdjustments", "VehicleCode", TxtVehicleCode.Text, "BranchCode", txtBranchCode.Text, "TransactionDate", Me.TxtDate.Value, "TransactionTypeCode", My.Settings.TripAdvanceCode, "OPTION", "FILTER_ADVANCE", "InvoiceNo", Trim(Me.txtTransactionNumber.Text))
                frmser.ShowDialog()
                If Not IsNothing(frmser.UGSearch.ActiveRow) Then
                    iRow = frmser.UGSearch.ActiveRow.Index
                    Me.TxtTripAdvance.Text = frmser.UGSearch.Rows(iRow).Cells("Amount").Value
                    Me.TxtAdvanceReferenceNo.Text = frmser.UGSearch.Rows(iRow).Cells("VehicleAdjustmentNo").Value

                End If
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtAdvanceReferenceNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtAdvanceReferenceNo.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.UltraTextEditor1_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtAdvanceReferenceNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtAdvanceReferenceNo.Validated
            ErrProvider.SetError(TxtAdvanceReferenceNo, String.Empty)
        End Sub

        Private Sub TxtAdvanceReferenceNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtAdvanceReferenceNo.Validating
            Try
                If TxtAdvanceReferenceNo.Text.Trim <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader
                    Reader = Acc.GetRecord("SelectVehicleAdjustments", "VehicleCode", Trim(TxtVehicleCode.Text), "BranchCode", txtBranchCode.Text, "TransactionDate", Me.TxtDate.Value, "TransactionTypeCode", My.Settings.TripAdvanceCode, "TransactionNo", Me.TxtAdvanceReferenceNo.Text, "OPTION", "FILTER_ADVANCE_WithNo", "InvoiceNo", Trim(Me.txtTransactionNumber.Text))
                    If Reader.HasRows = False Then
                        TxtTripAdvance.Value = 0D
                        ErrProvider.SetError(TxtAdvanceReferenceNo, "Invalid Trip Advance No")
                        ErrProvider.SetIconAlignment(TxtAdvanceReferenceNo, ErrorIconAlignment.TopLeft)
                        TxtAdvanceReferenceNo.Text = String.Empty
                        TxtCustomer.Text = String.Empty
                        e.Cancel = True
                    Else
                        Reader.Read()
                        ErrProvider.SetError(TxtAdvanceReferenceNo, String.Empty)
                        TxtAdvanceReferenceNo.Text = Reader.Item("VehicleAdjustmentNo")
                        TxtTripAdvance.Value = Reader.Item("Amount")
                        e.Cancel = False
                    End If
                Else
                    TxtTripAdvance.Value = 0D
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Private Sub txtAmount_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.ValueChanged
            Try
                If TxtCommissionRate.Text = String.Empty Then
                    TxtCommissionRate.Text = TxtCommissionRate.NullText
                End If
                Me.TxtRate.Value = (Me.txtAmount.Value / Me.TxtQuantity.Value)
                Me.TxtCommission.Value = Val(TxtCommissionRate.Text) / 100 * (Me.TxtQuantity.Value * Me.TxtRate.Value)
            Catch ex As Exception

            End Try
        End Sub

        Private Sub TxtShortage_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtShortage.ValueChanged
            Try
                TxtQuantityValue.Value = TxtShortage.Value / TxtShortageQuantity.Value
            Catch ex As Exception

            End Try
        End Sub

        Private Sub TxtAdvanceReferenceNo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAdvanceReferenceNo.ValueChanged

        End Sub

        Private Sub txtBranchCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranchCode.ValueChanged

        End Sub

        Private Sub TxtCommissionRate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCommissionRate.ValueChanged
            Try
                'Me.TxtRate.Value = (Me.txtAmount.Value / Me.TxtQuantity.Value)
                'Me.txtAmount.Value = (Me.TxtQuantity.Value * Me.TxtRate.Value)

                Me.TxtCommission.Value = Val(TxtCommissionRate.Text) / 100 * (Me.TxtQuantity.Value * Me.TxtRate.Value)
            Catch ex As Exception

            End Try
        End Sub

        Private Sub ChkIsThirdparty_CheckedChanged(sender As Object, e As EventArgs) Handles ChkIsLocalTrip.CheckedChanged
            If ChkIsLocalTrip.Checked Then
                ' TxtLongTripRefNo.Text = String.Empty
                TxtLongTripRefNo.Enabled = True
            Else
                TxtLongTripRefNo.Text = String.Empty
                TxtLongTripRefNo.Enabled = False

            End If
        End Sub

        Private Sub TxtLongTripRefNo_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtLongTripRefNo.KeyDown

            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.txtLocalTrip1_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtLongTripRefNo_Validated(sender As Object, e As EventArgs) Handles TxtLongTripRefNo.Validated
            If TxtLongTripRefNo.Text.Length > 0 Then
                ChkIsLocalTrip.Checked = True
            End If
        End Sub

        Private Sub TxtLongTripRefNo_Validating(sender As Object, e As CancelEventArgs) Handles TxtLongTripRefNo.Validating
            Try
                If TxtLongTripRefNo.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlDataReader
                    Reader = Acc.GetRecord("SelectInvoices", "VehicleNo", Trim(TxtVehicleCode.Text), "Option", "LONGTRIPVALIDATE", "TransactionNo", TxtLongTripRefNo.Text)
                    If Reader.HasRows = False Then
                        ErrProvider.SetError(TxtProductCode, "Invalid Trip No")
                        ErrProvider.SetIconAlignment(TxtProductCode, ErrorIconAlignment.TopLeft)
                        TxtLongTripRefNo.Text = String.Empty
                        e.Cancel = True
                    Else
                        Reader.Read()
                        ErrProvider.SetError(TxtLongTripRefNo, String.Empty)
                        TxtLongTripRefNo.Text = Reader.Item("TransactionNo")

                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
    End Class
End Namespace