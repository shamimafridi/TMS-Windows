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
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Friend WithEvents TxtDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtTransactionNumber As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents txtDescription As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtBranchCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents txtBranch As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtProduct As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents TxtProductCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtDestinationPoint As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents TxtDestinationPointCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtStationPoint As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents TxtStationPointCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtCustomer As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtVehicle As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents TxtVehicleCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents txtAmount As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents TxtRate As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents TxtShortage As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents TxtCommission As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents TxtTokenNo As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents TxtShortageQuantity As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents TxtQuantityValue As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents TxtAdvanceReferenceNo As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtTripAdvance As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents TxtCommissionRate As Infragistics.Win.UltraWinEditors.UltraComboEditor
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents TxtQuantity As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoices))
            Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
            Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
            Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
            Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
            Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
            Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
            Dim ValueListItem7 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
            Dim ValueListItem8 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
            Dim ValueListItem9 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
            Dim ValueListItem10 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
            Dim ValueListItem11 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
            Me.txtDescription = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.Label3 = New System.Windows.Forms.Label
            Me.txtBranch = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtCustomer = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label4 = New System.Windows.Forms.Label
            Me.TxtStationPoint = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label5 = New System.Windows.Forms.Label
            Me.TxtDestinationPoint = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label6 = New System.Windows.Forms.Label
            Me.TxtProduct = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label7 = New System.Windows.Forms.Label
            Me.TxtVehicle = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label8 = New System.Windows.Forms.Label
            Me.txtAmount = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label10 = New System.Windows.Forms.Label
            Me.TxtRate = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label11 = New System.Windows.Forms.Label
            Me.TxtShortage = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label12 = New System.Windows.Forms.Label
            Me.Label13 = New System.Windows.Forms.Label
            Me.TxtQuantity = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label14 = New System.Windows.Forms.Label
            Me.TxtCommission = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.TxtVehicleCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtDestinationPointCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtStationPointCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.txtBranchCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.txtTransactionNumber = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtDate = New System.Windows.Forms.DateTimePicker
            Me.TxtTokenNo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label15 = New System.Windows.Forms.Label
            Me.TxtProductCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtShortageQuantity = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label16 = New System.Windows.Forms.Label
            Me.Label17 = New System.Windows.Forms.Label
            Me.TxtQuantityValue = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label18 = New System.Windows.Forms.Label
            Me.Label19 = New System.Windows.Forms.Label
            Me.Label20 = New System.Windows.Forms.Label
            Me.TxtAdvanceReferenceNo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtTripAdvance = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.TxtCommissionRate = New Infragistics.Win.UltraWinEditors.UltraComboEditor
            Me.Label21 = New System.Windows.Forms.Label
            Me.Label22 = New System.Windows.Forms.Label
            CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtBranch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtStationPoint, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtDestinationPoint, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtProduct, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtVehicle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtRate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtShortage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCommission, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtVehicleCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtDestinationPointCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtStationPointCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtBranchCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtTransactionNumber, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtTokenNo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtProductCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtShortageQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtQuantityValue, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtAdvanceReferenceNo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtTripAdvance, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCommissionRate, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtDescription
            '
            Me.txtDescription.Location = New System.Drawing.Point(152, 272)
            Me.txtDescription.Multiline = True
            Me.txtDescription.Name = "txtDescription"
            Me.txtDescription.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
            Me.txtDescription.Size = New System.Drawing.Size(272, 56)
            Me.txtDescription.TabIndex = 8
            Me.txtDescription.Tag = "ds.Description"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(40, 281)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 77
            Me.Label2.Text = "Description"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(40, 103)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 76
            Me.Label1.Text = "Document No"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.ForeColor = System.Drawing.Color.Navy
            Me.Label9.Location = New System.Drawing.Point(40, 249)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(110, 20)
            Me.Label9.TabIndex = 74
            Me.Label9.Text = "Document Date"
            '
            'ErrProvider
            '
            Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
            Me.ErrProvider.ContainerControl = Me
            Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
            Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.ForeColor = System.Drawing.Color.Navy
            Me.Label3.Location = New System.Drawing.Point(40, 79)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(110, 20)
            Me.Label3.TabIndex = 97
            Me.Label3.Text = "Branch"
            '
            'txtBranch
            '
            Me.txtBranch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance11.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranch.Appearance = Appearance11
            Me.txtBranch.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranch.Location = New System.Drawing.Point(290, 79)
            Me.txtBranch.Name = "txtBranch"
            Me.txtBranch.Size = New System.Drawing.Size(628, 21)
            Me.txtBranch.TabIndex = 6
            Me.txtBranch.TabStop = False
            Me.txtBranch.Tag = "dd.BranchName"
            '
            'TxtCustomer
            '
            Me.TxtCustomer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance9.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCustomer.Appearance = Appearance9
            Me.TxtCustomer.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCustomer.Location = New System.Drawing.Point(290, 127)
            Me.TxtCustomer.Name = "TxtCustomer"
            Me.TxtCustomer.Size = New System.Drawing.Size(628, 21)
            Me.TxtCustomer.TabIndex = 100
            Me.TxtCustomer.TabStop = False
            Me.TxtCustomer.Tag = "dd.CustomerName"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.ForeColor = System.Drawing.Color.Navy
            Me.Label4.Location = New System.Drawing.Point(40, 127)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(110, 20)
            Me.Label4.TabIndex = 101
            Me.Label4.Text = "Customer"
            '
            'TxtStationPoint
            '
            Me.TxtStationPoint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance7.BackColor = System.Drawing.SystemColors.Window
            Me.TxtStationPoint.Appearance = Appearance7
            Me.TxtStationPoint.BackColor = System.Drawing.SystemColors.Window
            Me.TxtStationPoint.Enabled = False
            Me.TxtStationPoint.Location = New System.Drawing.Point(290, 199)
            Me.TxtStationPoint.Name = "TxtStationPoint"
            Me.TxtStationPoint.Size = New System.Drawing.Size(628, 21)
            Me.TxtStationPoint.TabIndex = 104
            Me.TxtStationPoint.TabStop = False
            Me.TxtStationPoint.Tag = "dd.StationPointName"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.ForeColor = System.Drawing.Color.Navy
            Me.Label5.Location = New System.Drawing.Point(40, 199)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(110, 20)
            Me.Label5.TabIndex = 105
            Me.Label5.Text = "Station Point"
            '
            'TxtDestinationPoint
            '
            Me.TxtDestinationPoint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance5.BackColor = System.Drawing.SystemColors.Window
            Me.TxtDestinationPoint.Appearance = Appearance5
            Me.TxtDestinationPoint.BackColor = System.Drawing.SystemColors.Window
            Me.TxtDestinationPoint.Enabled = False
            Me.TxtDestinationPoint.Location = New System.Drawing.Point(290, 223)
            Me.TxtDestinationPoint.Name = "TxtDestinationPoint"
            Me.TxtDestinationPoint.Size = New System.Drawing.Size(628, 21)
            Me.TxtDestinationPoint.TabIndex = 108
            Me.TxtDestinationPoint.TabStop = False
            Me.TxtDestinationPoint.Tag = "dd.DestinationPointName"
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.ForeColor = System.Drawing.Color.Navy
            Me.Label6.Location = New System.Drawing.Point(40, 223)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(110, 20)
            Me.Label6.TabIndex = 109
            Me.Label6.Text = "Destination Point"
            '
            'TxtProduct
            '
            Me.TxtProduct.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance3.BackColor = System.Drawing.SystemColors.Window
            Me.TxtProduct.Appearance = Appearance3
            Me.TxtProduct.BackColor = System.Drawing.SystemColors.Window
            Me.TxtProduct.Location = New System.Drawing.Point(290, 175)
            Me.TxtProduct.Name = "TxtProduct"
            Me.TxtProduct.Size = New System.Drawing.Size(628, 21)
            Me.TxtProduct.TabIndex = 112
            Me.TxtProduct.TabStop = False
            Me.TxtProduct.Tag = "dd.ProductName"
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.ForeColor = System.Drawing.Color.Navy
            Me.Label7.Location = New System.Drawing.Point(40, 173)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(110, 20)
            Me.Label7.TabIndex = 113
            Me.Label7.Text = "Product"
            '
            'TxtVehicle
            '
            Me.TxtVehicle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.TxtVehicle.Appearance = Appearance1
            Me.TxtVehicle.BackColor = System.Drawing.SystemColors.Window
            Me.TxtVehicle.Location = New System.Drawing.Point(290, 151)
            Me.TxtVehicle.Name = "TxtVehicle"
            Me.TxtVehicle.Size = New System.Drawing.Size(628, 21)
            Me.TxtVehicle.TabIndex = 116
            Me.TxtVehicle.TabStop = False
            Me.TxtVehicle.Tag = "dd.VehicleDescription"
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.ForeColor = System.Drawing.Color.Navy
            Me.Label8.Location = New System.Drawing.Point(40, 151)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(110, 20)
            Me.Label8.TabIndex = 117
            Me.Label8.Text = "Vehicle "
            '
            'txtAmount
            '
            Me.txtAmount.Location = New System.Drawing.Point(412, 512)
            Me.txtAmount.MaxValue = CType(21474836471222, Long)
            Me.txtAmount.Name = "txtAmount"
            Me.txtAmount.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.txtAmount.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.txtAmount.Size = New System.Drawing.Size(120, 21)
            Me.txtAmount.TabIndex = 12
            Me.txtAmount.Tag = "dt.Amount"
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.Transparent
            Me.Label10.ForeColor = System.Drawing.Color.Navy
            Me.Label10.Location = New System.Drawing.Point(302, 512)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(110, 20)
            Me.Label10.TabIndex = 121
            Me.Label10.Text = "Amount"
            '
            'TxtRate
            '
            Me.TxtRate.Location = New System.Drawing.Point(412, 440)
            Me.TxtRate.MinValue = CType(-21474836489999, Long)
            Me.TxtRate.Name = "TxtRate"
            Me.TxtRate.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtRate.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtRate.Size = New System.Drawing.Size(120, 21)
            Me.TxtRate.TabIndex = 11
            Me.TxtRate.Tag = "dt.Rate"
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.ForeColor = System.Drawing.Color.Navy
            Me.Label11.Location = New System.Drawing.Point(302, 445)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(110, 20)
            Me.Label11.TabIndex = 120
            Me.Label11.Text = "Rate"
            '
            'TxtShortage
            '
            Me.TxtShortage.AccessibleDescription = "Last"
            Me.TxtShortage.Location = New System.Drawing.Point(711, 461)
            Me.TxtShortage.Name = "TxtShortage"
            Me.TxtShortage.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtShortage.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtShortage.Size = New System.Drawing.Size(120, 21)
            Me.TxtShortage.TabIndex = 15
            Me.TxtShortage.Tag = "dt.Shortage"
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.Transparent
            Me.Label12.ForeColor = System.Drawing.Color.Navy
            Me.Label12.Location = New System.Drawing.Point(601, 461)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(110, 20)
            Me.Label12.TabIndex = 125
            Me.Label12.Text = "Shortage"
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.Transparent
            Me.Label13.ForeColor = System.Drawing.Color.Navy
            Me.Label13.Location = New System.Drawing.Point(302, 489)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(110, 20)
            Me.Label13.TabIndex = 124
            Me.Label13.Text = "Commission"
            '
            'TxtQuantity
            '
            Me.TxtQuantity.Location = New System.Drawing.Point(412, 416)
            Me.TxtQuantity.Name = "TxtQuantity"
            Me.TxtQuantity.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtQuantity.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtQuantity.Size = New System.Drawing.Size(120, 21)
            Me.TxtQuantity.TabIndex = 10
            Me.TxtQuantity.Tag = "dt.Quantity"
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.Transparent
            Me.Label14.ForeColor = System.Drawing.Color.Navy
            Me.Label14.Location = New System.Drawing.Point(302, 416)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(110, 20)
            Me.Label14.TabIndex = 127
            Me.Label14.Text = "Quantity"
            '
            'TxtCommission
            '
            Me.TxtCommission.Enabled = False
            Me.TxtCommission.Location = New System.Drawing.Point(412, 488)
            Me.TxtCommission.Name = "TxtCommission"
            Me.TxtCommission.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtCommission.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtCommission.ReadOnly = True
            Me.TxtCommission.Size = New System.Drawing.Size(120, 21)
            Me.TxtCommission.TabIndex = 20
            Me.TxtCommission.Tag = "dt.Commission"
            '
            'TxtVehicleCode
            '
            Me.TxtVehicleCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance13.BackColor = System.Drawing.SystemColors.Window
            Me.TxtVehicleCode.Appearance = Appearance13
            Me.TxtVehicleCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtVehicleCode.Location = New System.Drawing.Point(152, 151)
            Me.TxtVehicleCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.VehicleCode_Length
            Me.TxtVehicleCode.Name = "TxtVehicleCode"
            Me.TxtVehicleCode.Size = New System.Drawing.Size(138, 21)
            Me.TxtVehicleCode.TabIndex = 3
            Me.TxtVehicleCode.Tag = "FK.VehicleCode"
            '
            'TxtDestinationPointCode
            '
            Me.TxtDestinationPointCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance6.BackColor = System.Drawing.SystemColors.Window
            Me.TxtDestinationPointCode.Appearance = Appearance6
            Me.TxtDestinationPointCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtDestinationPointCode.Location = New System.Drawing.Point(152, 223)
            Me.TxtDestinationPointCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.RegionCode_Length
            Me.TxtDestinationPointCode.Name = "TxtDestinationPointCode"
            Me.TxtDestinationPointCode.Size = New System.Drawing.Size(138, 21)
            Me.TxtDestinationPointCode.TabIndex = 6
            Me.TxtDestinationPointCode.Tag = "FK.DestinationPointCode"
            '
            'TxtStationPointCode
            '
            Me.TxtStationPointCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance8.BackColor = System.Drawing.SystemColors.Window
            Me.TxtStationPointCode.Appearance = Appearance8
            Me.TxtStationPointCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtStationPointCode.Location = New System.Drawing.Point(152, 199)
            Me.TxtStationPointCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.RegionCode_Length
            Me.TxtStationPointCode.Name = "TxtStationPointCode"
            Me.TxtStationPointCode.Size = New System.Drawing.Size(138, 21)
            Me.TxtStationPointCode.TabIndex = 5
            Me.TxtStationPointCode.Tag = "FK.StationPointCode"
            '
            'Desc
            '
            Me.Desc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance10.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Appearance = Appearance10
            Me.Desc.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Location = New System.Drawing.Point(152, 127)
            Me.Desc.MaxLength = 5
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(138, 21)
            Me.Desc.TabIndex = 2
            Me.Desc.Tag = "FK.CustomerCode"
            '
            'txtBranchCode
            '
            Me.txtBranchCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance12.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchCode.Appearance = Appearance12
            Me.txtBranchCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchCode.Location = New System.Drawing.Point(152, 79)
            Me.txtBranchCode.MaxLength = 2
            Me.txtBranchCode.Name = "txtBranchCode"
            Me.txtBranchCode.Size = New System.Drawing.Size(138, 21)
            Me.txtBranchCode.TabIndex = 0
            Me.txtBranchCode.Tag = "PK.BranchCode"
            '
            'txtTransactionNumber
            '
            Me.txtTransactionNumber.AcceptsReturn = True
            Me.txtTransactionNumber.Location = New System.Drawing.Point(152, 103)
            Me.txtTransactionNumber.MaxLength = 10
            Me.txtTransactionNumber.Name = "txtTransactionNumber"
            Me.txtTransactionNumber.Size = New System.Drawing.Size(138, 21)
            Me.txtTransactionNumber.TabIndex = 1
            Me.txtTransactionNumber.Tag = "PK.TransactionNo"
            '
            'TxtDate
            '
            Me.TxtDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
            Me.TxtDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
            Me.TxtDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
            Me.TxtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.TxtDate.Location = New System.Drawing.Point(152, 248)
            Me.TxtDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.TxtDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.TxtDate.Name = "TxtDate"
            Me.TxtDate.Size = New System.Drawing.Size(100, 20)
            Me.TxtDate.TabIndex = 7
            Me.TxtDate.Tag = "dt.TransactionDate"
            '
            'TxtTokenNo
            '
            Me.TxtTokenNo.Location = New System.Drawing.Point(412, 102)
            Me.TxtTokenNo.MaxLength = 10
            Me.TxtTokenNo.Name = "TxtTokenNo"
            Me.TxtTokenNo.Size = New System.Drawing.Size(120, 21)
            Me.TxtTokenNo.TabIndex = 2
            Me.TxtTokenNo.Tag = "IM.CustomerReference"
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.Transparent
            Me.Label15.ForeColor = System.Drawing.Color.Navy
            Me.Label15.Location = New System.Drawing.Point(330, 105)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(82, 20)
            Me.Label15.TabIndex = 129
            Me.Label15.Text = "Token No"
            '
            'TxtProductCode
            '
            Me.TxtProductCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance4.BackColor = System.Drawing.SystemColors.Window
            Me.TxtProductCode.Appearance = Appearance4
            Me.TxtProductCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtProductCode.Location = New System.Drawing.Point(152, 175)
            Me.TxtProductCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.ProductCode_Length
            Me.TxtProductCode.Name = "TxtProductCode"
            Me.TxtProductCode.Size = New System.Drawing.Size(138, 21)
            Me.TxtProductCode.TabIndex = 4
            Me.TxtProductCode.Tag = "FK.ProductCode"
            '
            'TxtShortageQuantity
            '
            Me.TxtShortageQuantity.Location = New System.Drawing.Point(711, 416)
            Me.TxtShortageQuantity.Name = "TxtShortageQuantity"
            Me.TxtShortageQuantity.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtShortageQuantity.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtShortageQuantity.Size = New System.Drawing.Size(120, 21)
            Me.TxtShortageQuantity.TabIndex = 13
            Me.TxtShortageQuantity.Tag = "dt.ShortageQuantity"
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.Color.Transparent
            Me.Label16.ForeColor = System.Drawing.Color.Navy
            Me.Label16.Location = New System.Drawing.Point(601, 416)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(110, 20)
            Me.Label16.TabIndex = 131
            Me.Label16.Text = "Shortage Quantity"
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.Transparent
            Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label17.Font = New System.Drawing.Font("Courier New", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label17.ForeColor = System.Drawing.Color.Purple
            Me.Label17.Location = New System.Drawing.Point(591, 379)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(258, 171)
            Me.Label17.TabIndex = 132
            Me.Label17.Text = "Shortage"
            '
            'TxtQuantityValue
            '
            Me.TxtQuantityValue.Location = New System.Drawing.Point(711, 438)
            Me.TxtQuantityValue.Name = "TxtQuantityValue"
            Me.TxtQuantityValue.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtQuantityValue.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtQuantityValue.Size = New System.Drawing.Size(120, 21)
            Me.TxtQuantityValue.TabIndex = 14
            Me.TxtQuantityValue.Tag = "dt.QuantityValue"
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.Color.Transparent
            Me.Label18.ForeColor = System.Drawing.Color.Navy
            Me.Label18.Location = New System.Drawing.Point(601, 438)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(110, 20)
            Me.Label18.TabIndex = 134
            Me.Label18.Text = "Quantity Value"
            '
            'Label19
            '
            Me.Label19.BackColor = System.Drawing.Color.Transparent
            Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label19.Font = New System.Drawing.Font("Courier New", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label19.ForeColor = System.Drawing.Color.Purple
            Me.Label19.Location = New System.Drawing.Point(288, 379)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(258, 171)
            Me.Label19.TabIndex = 135
            Me.Label19.Text = "Total"
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.Transparent
            Me.Label20.ForeColor = System.Drawing.Color.Navy
            Me.Label20.Location = New System.Drawing.Point(40, 333)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(110, 20)
            Me.Label20.TabIndex = 137
            Me.Label20.Text = "Trip Advance Reference"
            '
            'TxtAdvanceReferenceNo
            '
            Me.TxtAdvanceReferenceNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.TxtAdvanceReferenceNo.Appearance = Appearance2
            Me.TxtAdvanceReferenceNo.BackColor = System.Drawing.SystemColors.Window
            Me.TxtAdvanceReferenceNo.Location = New System.Drawing.Point(152, 332)
            Me.TxtAdvanceReferenceNo.MaxLength = Global.BusinessLeaf.My.MySettings.Default.VehicleCode_Length
            Me.TxtAdvanceReferenceNo.Name = "TxtAdvanceReferenceNo"
            Me.TxtAdvanceReferenceNo.Size = New System.Drawing.Size(138, 21)
            Me.TxtAdvanceReferenceNo.TabIndex = 9
            Me.TxtAdvanceReferenceNo.Tag = "FK.TripAdvanceReference"
            '
            'TxtTripAdvance
            '
            Me.TxtTripAdvance.Location = New System.Drawing.Point(290, 332)
            Me.TxtTripAdvance.Name = "TxtTripAdvance"
            Me.TxtTripAdvance.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtTripAdvance.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtTripAdvance.ReadOnly = True
            Me.TxtTripAdvance.Size = New System.Drawing.Size(120, 21)
            Me.TxtTripAdvance.TabIndex = 138
            Me.TxtTripAdvance.Tag = "dt.TripAdvance"
            '
            'TxtCommissionRate
            '
            Me.TxtCommissionRate.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
            ValueListItem1.DataValue = "5"
            ValueListItem1.DisplayText = "5"
            ValueListItem2.DataValue = "6"
            ValueListItem2.DisplayText = "6"
            ValueListItem3.DataValue = "7"
            ValueListItem3.DisplayText = "7"
            ValueListItem4.DataValue = "8"
            ValueListItem4.DisplayText = "8"
            ValueListItem5.DataValue = "9"
            ValueListItem5.DisplayText = "9"
            ValueListItem6.DataValue = "10"
            ValueListItem6.DisplayText = "10"
            ValueListItem7.DataValue = "11"
            ValueListItem7.DisplayText = "11"
            ValueListItem8.DataValue = "12"
            ValueListItem8.DisplayText = "12"
            ValueListItem9.DataValue = "13"
            ValueListItem9.DisplayText = "13"
            ValueListItem10.DataValue = "14"
            ValueListItem10.DisplayText = "14"
            ValueListItem11.DataValue = "15"
            ValueListItem11.DisplayText = "15"
            Me.TxtCommissionRate.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2, ValueListItem3, ValueListItem4, ValueListItem5, ValueListItem6, ValueListItem7, ValueListItem8, ValueListItem9, ValueListItem10, ValueListItem11})
            Me.TxtCommissionRate.Location = New System.Drawing.Point(412, 464)
            Me.TxtCommissionRate.Name = "TxtCommissionRate"
            Me.TxtCommissionRate.NullText = "10"
            Me.TxtCommissionRate.Size = New System.Drawing.Size(38, 21)
            Me.TxtCommissionRate.TabIndex = 16
            Me.TxtCommissionRate.TabStop = False
            Me.TxtCommissionRate.Tag = "dd.CommissionRate"
            Me.TxtCommissionRate.Text = "10"
            '
            'Label21
            '
            Me.Label21.BackColor = System.Drawing.Color.Transparent
            Me.Label21.ForeColor = System.Drawing.Color.Navy
            Me.Label21.Location = New System.Drawing.Point(302, 464)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(110, 20)
            Me.Label21.TabIndex = 140
            Me.Label21.Text = "Commission Rate"
            '
            'Label22
            '
            Me.Label22.BackColor = System.Drawing.Color.Transparent
            Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
            Me.Label22.Location = New System.Drawing.Point(456, 466)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(69, 20)
            Me.Label22.TabIndex = 141
            Me.Label22.Text = "%"
            '
            'Invoices
            '
            Me.AccessibleName = "Invoices"
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(964, 617)
            Me.Controls.Add(Me.Label22)
            Me.Controls.Add(Me.Label21)
            Me.Controls.Add(Me.TxtCommissionRate)
            Me.Controls.Add(Me.TxtTripAdvance)
            Me.Controls.Add(Me.Label20)
            Me.Controls.Add(Me.TxtAdvanceReferenceNo)
            Me.Controls.Add(Me.TxtQuantityValue)
            Me.Controls.Add(Me.Label18)
            Me.Controls.Add(Me.TxtShortageQuantity)
            Me.Controls.Add(Me.Label16)
            Me.Controls.Add(Me.TxtTokenNo)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.Label14)
            Me.Controls.Add(Me.TxtQuantity)
            Me.Controls.Add(Me.TxtShortage)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.TxtCommission)
            Me.Controls.Add(Me.Label13)
            Me.Controls.Add(Me.txtAmount)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.TxtRate)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.TxtVehicle)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.TxtVehicleCode)
            Me.Controls.Add(Me.TxtProduct)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.TxtProductCode)
            Me.Controls.Add(Me.TxtDestinationPoint)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.TxtDestinationPointCode)
            Me.Controls.Add(Me.TxtStationPoint)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.TxtStationPointCode)
            Me.Controls.Add(Me.TxtCustomer)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.txtBranch)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtBranchCode)
            Me.Controls.Add(Me.txtDescription)
            Me.Controls.Add(Me.txtTransactionNumber)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.TxtDate)
            Me.Controls.Add(Me.Label17)
            Me.Controls.Add(Me.Label19)
            Me.KeyPreview = True
            Me.Name = "Invoices"
            Me.Text = "Invoice File "
            CType(Me.txtDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtBranch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtStationPoint, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtDestinationPoint, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtProduct, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtVehicle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtRate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtShortage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtQuantity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCommission, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtVehicleCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtDestinationPointCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtStationPointCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtBranchCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtTransactionNumber, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtTokenNo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtProductCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtShortageQuantity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtQuantityValue, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtAdvanceReferenceNo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtTripAdvance, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCommissionRate, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region


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
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtTripAdvance.Text = frmser.UGSearch.Rows(iRow).Cells("Amount").Value
                Me.TxtAdvanceReferenceNo.Text = frmser.UGSearch.Rows(iRow).Cells("VehicleAdjustmentNo").Value
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
                If TxtAdvanceReferenceNo.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader
                    Reader = Acc.GetRecord("SelectVehicleAdjustments", "VehicleCode", TxtVehicleCode.Text, "BranchCode", txtBranchCode.Text, "TransactionDate", Me.TxtDate.Value, "TransactionTypeCode", My.Settings.TripAdvanceCode, "TransactionNo", Me.TxtAdvanceReferenceNo.Text, "OPTION", "FILTER_ADVANCE_WithNo", "InvoiceNo", Trim(Me.txtTransactionNumber.Text))
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
    End Class
End Namespace