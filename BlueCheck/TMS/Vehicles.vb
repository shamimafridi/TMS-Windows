Namespace Inventory
    Public Class Vehicles
        Inherits System.Windows.Forms.Form
        Public dsData As DataSet
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
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents TxtVehicleCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        Friend WithEvents TxtFreightGLDesc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtFreightGLCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
        Friend WithEvents TxtInstallementGLDesc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtinstallmentGLCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
        Friend WithEvents TxtLoanGLDesc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtLoanGLCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
        Friend WithEvents TxtOwner As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtOwnerCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
        Friend WithEvents TxtCommissionGLDesc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtCommissionGLCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
        Friend WithEvents TxtCustomer As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtCustomerCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
        Friend WithEvents TextBox1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vehicles))
            Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Me.TxtVehicleCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.dtpDate = New System.Windows.Forms.DateTimePicker
            Me.Label11 = New System.Windows.Forms.Label
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.TxtLoanGLDesc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtLoanGLCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
            Me.TxtInstallementGLDesc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtinstallmentGLCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
            Me.TxtFreightGLDesc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtFreightGLCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
            Me.TxtOwner = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtOwnerCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.LinkLabel5 = New System.Windows.Forms.LinkLabel
            Me.TxtCommissionGLDesc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtCommissionGLCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.LinkLabel4 = New System.Windows.Forms.LinkLabel
            Me.TxtCustomer = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtCustomerCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.LinkLabel6 = New System.Windows.Forms.LinkLabel
            Me.TextBox1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label2 = New System.Windows.Forms.Label
            CType(Me.TxtVehicleCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtLoanGLDesc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtLoanGLCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtInstallementGLDesc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtinstallmentGLCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtFreightGLDesc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtFreightGLCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtOwner, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtOwnerCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCommissionGLDesc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCommissionGLCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TxtVehicleCode
            '
            Me.TxtVehicleCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.TxtVehicleCode.Appearance = Appearance1
            Me.TxtVehicleCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtVehicleCode.DataBindings.Add(New System.Windows.Forms.Binding("MaxLength", Global.BusinessLeaf.My.MySettings.Default, "VehicleCode_Length", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.TxtVehicleCode.Location = New System.Drawing.Point(202, 95)
            Me.TxtVehicleCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.VehicleCode_Length
            Me.TxtVehicleCode.Name = "TxtVehicleCode"
            Me.TxtVehicleCode.Size = New System.Drawing.Size(124, 21)
            Me.TxtVehicleCode.TabIndex = 0
            Me.TxtVehicleCode.Tag = "PK.VehicleCode"
            '
            'Desc
            '
            Me.Desc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Appearance = Appearance2
            Me.Desc.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Location = New System.Drawing.Point(202, 118)
            Me.Desc.MinimumSize = New System.Drawing.Size(176, 0)
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(510, 21)
            Me.Desc.TabIndex = 1
            Me.Desc.Tag = "IM.VehicleDescription"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(92, 95)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Vehicle Code"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.ForeColor = System.Drawing.Color.Navy
            Me.Label4.Location = New System.Drawing.Point(92, 118)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(110, 20)
            Me.Label4.TabIndex = 12
            Me.Label4.Text = "Vehicle Description"
            '
            'dtpDate
            '
            Me.dtpDate.AccessibleDescription = "Last"
            Me.dtpDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
            Me.dtpDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
            Me.dtpDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
            Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDate.Location = New System.Drawing.Point(202, 302)
            Me.dtpDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.dtpDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.dtpDate.Name = "dtpDate"
            Me.dtpDate.Size = New System.Drawing.Size(100, 20)
            Me.dtpDate.TabIndex = 9
            Me.dtpDate.Tag = "dt.DefinitionDate"
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.ForeColor = System.Drawing.Color.Navy
            Me.Label11.Location = New System.Drawing.Point(92, 302)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(110, 20)
            Me.Label11.TabIndex = 98
            Me.Label11.Text = "Definition Date"
            '
            'ErrProvider
            '
            Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
            Me.ErrProvider.ContainerControl = Me
            Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
            Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
            '
            'TxtLoanGLDesc
            '
            Me.TxtLoanGLDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance14.BackColor = System.Drawing.SystemColors.Window
            Me.TxtLoanGLDesc.Appearance = Appearance14
            Me.TxtLoanGLDesc.BackColor = System.Drawing.SystemColors.Window
            Me.TxtLoanGLDesc.Location = New System.Drawing.Point(326, 256)
            Me.TxtLoanGLDesc.Name = "TxtLoanGLDesc"
            Me.TxtLoanGLDesc.ReadOnly = True
            Me.TxtLoanGLDesc.Size = New System.Drawing.Size(386, 21)
            Me.TxtLoanGLDesc.TabIndex = 106
            Me.TxtLoanGLDesc.TabStop = False
            Me.TxtLoanGLDesc.Tag = "dd.LoanGLDescription"
            '
            'TxtLoanGLCode
            '
            Me.TxtLoanGLCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance15.BackColor = System.Drawing.SystemColors.Window
            Me.TxtLoanGLCode.Appearance = Appearance15
            Me.TxtLoanGLCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtLoanGLCode.Location = New System.Drawing.Point(202, 256)
            Me.TxtLoanGLCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.GLCode_Length
            Me.TxtLoanGLCode.Name = "TxtLoanGLCode"
            Me.TxtLoanGLCode.Size = New System.Drawing.Size(124, 21)
            Me.TxtLoanGLCode.TabIndex = 7
            Me.TxtLoanGLCode.Tag = "FK.LoanGLCode"
            '
            'LinkLabel1
            '
            Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
            Me.LinkLabel1.ForeColor = System.Drawing.Color.Navy
            Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.LinkLabel1.Location = New System.Drawing.Point(92, 256)
            Me.LinkLabel1.Name = "LinkLabel1"
            Me.LinkLabel1.Size = New System.Drawing.Size(110, 20)
            Me.LinkLabel1.TabIndex = 107
            Me.LinkLabel1.TabStop = True
            Me.LinkLabel1.Text = "Loan GL Code"
            '
            'TxtInstallementGLDesc
            '
            Me.TxtInstallementGLDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance12.BackColor = System.Drawing.SystemColors.Window
            Me.TxtInstallementGLDesc.Appearance = Appearance12
            Me.TxtInstallementGLDesc.BackColor = System.Drawing.SystemColors.Window
            Me.TxtInstallementGLDesc.Location = New System.Drawing.Point(326, 233)
            Me.TxtInstallementGLDesc.Name = "TxtInstallementGLDesc"
            Me.TxtInstallementGLDesc.ReadOnly = True
            Me.TxtInstallementGLDesc.Size = New System.Drawing.Size(386, 21)
            Me.TxtInstallementGLDesc.TabIndex = 110
            Me.TxtInstallementGLDesc.TabStop = False
            Me.TxtInstallementGLDesc.Tag = "dd.InstallmentGLDescription"
            '
            'TxtinstallmentGLCode
            '
            Me.TxtinstallmentGLCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance13.BackColor = System.Drawing.SystemColors.Window
            Me.TxtinstallmentGLCode.Appearance = Appearance13
            Me.TxtinstallmentGLCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtinstallmentGLCode.Location = New System.Drawing.Point(202, 233)
            Me.TxtinstallmentGLCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.GLCode_Length
            Me.TxtinstallmentGLCode.Name = "TxtinstallmentGLCode"
            Me.TxtinstallmentGLCode.Size = New System.Drawing.Size(124, 21)
            Me.TxtinstallmentGLCode.TabIndex = 6
            Me.TxtinstallmentGLCode.Tag = "FK.InstallmentGLCode"
            '
            'LinkLabel2
            '
            Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
            Me.LinkLabel2.ForeColor = System.Drawing.Color.Navy
            Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.LinkLabel2.Location = New System.Drawing.Point(92, 233)
            Me.LinkLabel2.Name = "LinkLabel2"
            Me.LinkLabel2.Size = New System.Drawing.Size(110, 20)
            Me.LinkLabel2.TabIndex = 111
            Me.LinkLabel2.TabStop = True
            Me.LinkLabel2.Text = "Installment GL Code"
            '
            'TxtFreightGLDesc
            '
            Me.TxtFreightGLDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance10.BackColor = System.Drawing.SystemColors.Window
            Me.TxtFreightGLDesc.Appearance = Appearance10
            Me.TxtFreightGLDesc.BackColor = System.Drawing.SystemColors.Window
            Me.TxtFreightGLDesc.Location = New System.Drawing.Point(326, 210)
            Me.TxtFreightGLDesc.Name = "TxtFreightGLDesc"
            Me.TxtFreightGLDesc.ReadOnly = True
            Me.TxtFreightGLDesc.Size = New System.Drawing.Size(386, 21)
            Me.TxtFreightGLDesc.TabIndex = 114
            Me.TxtFreightGLDesc.TabStop = False
            Me.TxtFreightGLDesc.Tag = "dd.FreightGLDescription"
            '
            'TxtFreightGLCode
            '
            Me.TxtFreightGLCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance11.BackColor = System.Drawing.SystemColors.Window
            Me.TxtFreightGLCode.Appearance = Appearance11
            Me.TxtFreightGLCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtFreightGLCode.Location = New System.Drawing.Point(202, 210)
            Me.TxtFreightGLCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.GLCode_Length
            Me.TxtFreightGLCode.Name = "TxtFreightGLCode"
            Me.TxtFreightGLCode.Size = New System.Drawing.Size(124, 21)
            Me.TxtFreightGLCode.TabIndex = 5
            Me.TxtFreightGLCode.Tag = "FK.FreightGLCode"
            '
            'LinkLabel3
            '
            Me.LinkLabel3.BackColor = System.Drawing.Color.Transparent
            Me.LinkLabel3.ForeColor = System.Drawing.Color.Navy
            Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.LinkLabel3.Location = New System.Drawing.Point(92, 210)
            Me.LinkLabel3.Name = "LinkLabel3"
            Me.LinkLabel3.Size = New System.Drawing.Size(110, 20)
            Me.LinkLabel3.TabIndex = 115
            Me.LinkLabel3.TabStop = True
            Me.LinkLabel3.Text = "Freight GL Code"
            '
            'TxtOwner
            '
            Me.TxtOwner.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance8.BackColor = System.Drawing.SystemColors.Window
            Me.TxtOwner.Appearance = Appearance8
            Me.TxtOwner.BackColor = System.Drawing.SystemColors.Window
            Me.TxtOwner.Location = New System.Drawing.Point(326, 164)
            Me.TxtOwner.Name = "TxtOwner"
            Me.TxtOwner.ReadOnly = True
            Me.TxtOwner.Size = New System.Drawing.Size(386, 21)
            Me.TxtOwner.TabIndex = 122
            Me.TxtOwner.TabStop = False
            Me.TxtOwner.Tag = "dd.OwnerName"
            '
            'TxtOwnerCode
            '
            Me.TxtOwnerCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance9.BackColor = System.Drawing.SystemColors.Window
            Me.TxtOwnerCode.Appearance = Appearance9
            Me.TxtOwnerCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtOwnerCode.Location = New System.Drawing.Point(202, 164)
            Me.TxtOwnerCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.VehicleOwnerCode_Length
            Me.TxtOwnerCode.Name = "TxtOwnerCode"
            Me.TxtOwnerCode.Size = New System.Drawing.Size(124, 21)
            Me.TxtOwnerCode.TabIndex = 3
            Me.TxtOwnerCode.Tag = "FK.OwnerCode"
            '
            'LinkLabel5
            '
            Me.LinkLabel5.BackColor = System.Drawing.Color.Transparent
            Me.LinkLabel5.ForeColor = System.Drawing.Color.Navy
            Me.LinkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.LinkLabel5.Location = New System.Drawing.Point(92, 164)
            Me.LinkLabel5.Name = "LinkLabel5"
            Me.LinkLabel5.Size = New System.Drawing.Size(110, 20)
            Me.LinkLabel5.TabIndex = 123
            Me.LinkLabel5.TabStop = True
            Me.LinkLabel5.Text = "Owner"
            '
            'TxtCommissionGLDesc
            '
            Me.TxtCommissionGLDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance6.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCommissionGLDesc.Appearance = Appearance6
            Me.TxtCommissionGLDesc.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCommissionGLDesc.Location = New System.Drawing.Point(326, 279)
            Me.TxtCommissionGLDesc.Name = "TxtCommissionGLDesc"
            Me.TxtCommissionGLDesc.ReadOnly = True
            Me.TxtCommissionGLDesc.Size = New System.Drawing.Size(386, 21)
            Me.TxtCommissionGLDesc.TabIndex = 126
            Me.TxtCommissionGLDesc.TabStop = False
            Me.TxtCommissionGLDesc.Tag = "dd.CommissionGLDescription"
            '
            'TxtCommissionGLCode
            '
            Me.TxtCommissionGLCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance7.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCommissionGLCode.Appearance = Appearance7
            Me.TxtCommissionGLCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCommissionGLCode.Location = New System.Drawing.Point(202, 279)
            Me.TxtCommissionGLCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.GLCode_Length
            Me.TxtCommissionGLCode.Name = "TxtCommissionGLCode"
            Me.TxtCommissionGLCode.Size = New System.Drawing.Size(124, 21)
            Me.TxtCommissionGLCode.TabIndex = 8
            Me.TxtCommissionGLCode.Tag = "FK.CommissionGLCode"
            '
            'LinkLabel4
            '
            Me.LinkLabel4.BackColor = System.Drawing.Color.Transparent
            Me.LinkLabel4.ForeColor = System.Drawing.Color.Navy
            Me.LinkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.LinkLabel4.Location = New System.Drawing.Point(92, 279)
            Me.LinkLabel4.Name = "LinkLabel4"
            Me.LinkLabel4.Size = New System.Drawing.Size(110, 20)
            Me.LinkLabel4.TabIndex = 127
            Me.LinkLabel4.TabStop = True
            Me.LinkLabel4.Text = "Commission GL Code"
            '
            'TxtCustomer
            '
            Me.TxtCustomer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance4.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCustomer.Appearance = Appearance4
            Me.TxtCustomer.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCustomer.Location = New System.Drawing.Point(326, 187)
            Me.TxtCustomer.Name = "TxtCustomer"
            Me.TxtCustomer.ReadOnly = True
            Me.TxtCustomer.Size = New System.Drawing.Size(386, 21)
            Me.TxtCustomer.TabIndex = 130
            Me.TxtCustomer.TabStop = False
            Me.TxtCustomer.Tag = "dd.Customer"
            '
            'TxtCustomerCode
            '
            Me.TxtCustomerCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance5.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCustomerCode.Appearance = Appearance5
            Me.TxtCustomerCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCustomerCode.Location = New System.Drawing.Point(202, 187)
            Me.TxtCustomerCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.GLCode_Length
            Me.TxtCustomerCode.Name = "TxtCustomerCode"
            Me.TxtCustomerCode.Size = New System.Drawing.Size(124, 21)
            Me.TxtCustomerCode.TabIndex = 4
            Me.TxtCustomerCode.Tag = "FK.CustomerCode"
            '
            'LinkLabel6
            '
            Me.LinkLabel6.BackColor = System.Drawing.Color.Transparent
            Me.LinkLabel6.ForeColor = System.Drawing.Color.Navy
            Me.LinkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.LinkLabel6.Location = New System.Drawing.Point(92, 187)
            Me.LinkLabel6.Name = "LinkLabel6"
            Me.LinkLabel6.Size = New System.Drawing.Size(110, 20)
            Me.LinkLabel6.TabIndex = 131
            Me.LinkLabel6.TabStop = True
            Me.LinkLabel6.Text = "Customer"
            '
            'TextBox1
            '
            Me.TextBox1.AccessibleDescription = "Description"
            Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance3.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox1.Appearance = Appearance3
            Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox1.Location = New System.Drawing.Point(202, 141)
            Me.TextBox1.MinimumSize = New System.Drawing.Size(176, 0)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(510, 21)
            Me.TextBox1.TabIndex = 2
            Me.TextBox1.Tag = "IM.Capacity"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(92, 141)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 134
            Me.Label2.Text = "Capacity"
            '
            'Vehicles
            '
            Me.AccessibleName = ""
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(804, 494)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.TxtCustomer)
            Me.Controls.Add(Me.TxtCustomerCode)
            Me.Controls.Add(Me.LinkLabel6)
            Me.Controls.Add(Me.TxtCommissionGLDesc)
            Me.Controls.Add(Me.TxtCommissionGLCode)
            Me.Controls.Add(Me.LinkLabel4)
            Me.Controls.Add(Me.TxtOwner)
            Me.Controls.Add(Me.TxtOwnerCode)
            Me.Controls.Add(Me.LinkLabel5)
            Me.Controls.Add(Me.TxtFreightGLDesc)
            Me.Controls.Add(Me.TxtFreightGLCode)
            Me.Controls.Add(Me.LinkLabel3)
            Me.Controls.Add(Me.TxtInstallementGLDesc)
            Me.Controls.Add(Me.TxtinstallmentGLCode)
            Me.Controls.Add(Me.LinkLabel2)
            Me.Controls.Add(Me.TxtLoanGLDesc)
            Me.Controls.Add(Me.TxtLoanGLCode)
            Me.Controls.Add(Me.LinkLabel1)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.TxtVehicleCode)
            Me.Controls.Add(Me.dtpDate)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label1)
            Me.KeyPreview = True
            Me.MinimumSize = Global.BusinessLeaf.My.MySettings.Default.SetupFormMinimumSize
            Me.Name = "Vehicles"
            Me.Text = "Vehicle File"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.TxtVehicleCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtLoanGLDesc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtLoanGLCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtInstallementGLDesc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtinstallmentGLCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtFreightGLDesc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtFreightGLCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtOwner, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtOwnerCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCommissionGLDesc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCommissionGLCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region
        Private Sub Vehicles_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub

        Private Sub TxtOwnerCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtOwnerCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("VehicleOwners")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtOwnerCode.Text = frmser.UGSearch.Rows(iRow).Cells("OwnerCode").Value
                Me.TxtOwner.Text = frmser.UGSearch.Rows(iRow).Cells("OwnerName").Value
                Me.TxtOwnerCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtOwnerCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOwnerCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtOwnerCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtFreightGLCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtFreightGLCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("COACombine")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtFreightGLCode.Text = frmser.UGSearch.Rows(iRow).Cells("GLCode").Value
                Me.TxtFreightGLDesc.Text = frmser.UGSearch.Rows(iRow).Cells("GLDescription").Value
                Me.TxtFreightGLCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtFreightGLCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFreightGLCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtFreightGLCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtinstallmentGLCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtinstallmentGLCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("COACombine")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtinstallmentGLCode.Text = frmser.UGSearch.Rows(iRow).Cells("GLCode").Value
                Me.TxtInstallementGLDesc.Text = frmser.UGSearch.Rows(iRow).Cells("GLDescription").Value
                Me.TxtinstallmentGLCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtinstallmentGLCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtinstallmentGLCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtinstallmentGLCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub


        Private Sub TxtLoanGLCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtLoanGLCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("COACombine")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtLoanGLCode.Text = frmser.UGSearch.Rows(iRow).Cells("GLCode").Value
                Me.TxtLoanGLDesc.Text = frmser.UGSearch.Rows(iRow).Cells("GLDescription").Value
                Me.TxtLoanGLCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtLoanGLCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLoanGLCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtLoanGLCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtOwnerCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOwnerCode.Validated
            ErrProvider.SetError(TxtOwnerCode, String.Empty)
        End Sub
        Private Sub TxtOwnerCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtOwnerCode.Validating
            Try
                If TxtOwnerCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectVehicleOwners", "OwnerCode", Trim(TxtOwnerCode.Text))
                    If Reader.HasRows = False Then
                        TxtOwnerCode.Text = String.Empty
                        TxtOwner.Text = String.Empty
                        ErrProvider.SetError(TxtOwnerCode, "Invalid Owner Code")
                        ErrProvider.SetIconAlignment(TxtOwnerCode, ErrorIconAlignment.TopLeft)
                        e.Cancel = True
                    Else
                        ErrProvider.SetError(TxtOwnerCode, String.Empty)
                        Reader.Read()
                        TxtOwner.Text = Reader.Item("OwnerName")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub TxtFreightGLCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtFreightGLCode.Validated
            ErrProvider.SetError(TxtFreightGLCode, String.Empty)
        End Sub

        Private Sub TxtFreightGLCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtFreightGLCode.Validating
            Try
                If TxtFreightGLCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectCOACombine", "GLCode ", Trim(TxtFreightGLCode.Text))
                    If Reader.HasRows = False Then
                        TxtFreightGLCode.Text = String.Empty
                        TxtFreightGLDesc.Text = String.Empty
                        ErrProvider.SetError(TxtFreightGLCode, "Invalid GL Code")
                        ErrProvider.SetIconAlignment(TxtFreightGLCode, ErrorIconAlignment.TopLeft)
                        e.Cancel = True
                    Else
                        ErrProvider.SetError(TxtFreightGLCode, String.Empty)
                        Reader.Read()
                        TxtFreightGLDesc.Text = Reader.Item("GLDescription")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Private Sub TxtinstallmentGLCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtinstallmentGLCode.Validated
            ErrProvider.SetError(TxtinstallmentGLCode, String.Empty)
        End Sub

        Private Sub TxtinstallmentGLCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtinstallmentGLCode.Validating
            Try
                If TxtinstallmentGLCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectCOACombine", "GLCode ", Trim(TxtinstallmentGLCode.Text))
                    If Reader.HasRows = False Then
                        TxtinstallmentGLCode.Text = String.Empty
                        TxtInstallementGLDesc.Text = String.Empty
                        ErrProvider.SetError(TxtinstallmentGLCode, "Invalid GL Code")
                        ErrProvider.SetIconAlignment(TxtinstallmentGLCode, ErrorIconAlignment.TopLeft)
                        e.Cancel = True
                    Else
                        ErrProvider.SetError(TxtinstallmentGLCode, String.Empty)
                        Reader.Read()
                        TxtInstallementGLDesc.Text = Reader.Item("GLDescription")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Private Sub TxtLoanGLCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtLoanGLCode.Validated
            ErrProvider.SetError(TxtLoanGLCode, String.Empty)
        End Sub

        Private Sub TxtLoanGLCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtLoanGLCode.Validating
            Try
                If TxtLoanGLCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectCOACombine", "GLCode ", Trim(TxtLoanGLCode.Text))
                    If Reader.HasRows = False Then
                        TxtLoanGLCode.Text = String.Empty
                        TxtLoanGLDesc.Text = String.Empty
                        ErrProvider.SetError(TxtLoanGLCode, "Invalid GL Code")
                        ErrProvider.SetIconAlignment(TxtLoanGLCode, ErrorIconAlignment.TopLeft)
                        e.Cancel = True
                    Else
                        ErrProvider.SetError(TxtLoanGLCode, String.Empty)
                        Reader.Read()
                        TxtLoanGLDesc.Text = Reader.Item("GLDescription")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub TxtCommissionGLCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtCommissionGLCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("COACombine")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtCommissionGLCode.Text = frmser.UGSearch.Rows(iRow).Cells("GLCode").Value
                Me.TxtCommissionGLDesc.Text = frmser.UGSearch.Rows(iRow).Cells("GLDescription").Value
                Me.TxtCommissionGLCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtCommissionGLCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCommissionGLCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtCommissionGLCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtLoanGLCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLoanGLCode.TextChanged

        End Sub

        Private Sub TxtCommissionGLCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCommissionGLCode.TextChanged

        End Sub
        Private Sub TxtCommissionGLCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtCommissionGLCode.Validating
            Try
                If TxtCommissionGLCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectCOACombine", "GLCode ", Trim(TxtCommissionGLCode.Text))
                    If Reader.HasRows = False Then
                        TxtCommissionGLCode.Text = String.Empty
                        TxtCommissionGLDesc.Text = String.Empty
                        ErrProvider.SetError(TxtCommissionGLCode, "Invalid GL Code")
                        ErrProvider.SetIconAlignment(TxtCommissionGLCode, ErrorIconAlignment.TopLeft)
                        e.Cancel = True
                    Else
                        ErrProvider.SetError(TxtCommissionGLCode, String.Empty)
                        Reader.Read()
                        TxtCommissionGLDesc.Text = Reader.Item("GLDescription")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub TxtCustomerCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtCustomerCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Customers")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtCustomerCode.Text = frmser.UGSearch.Rows(iRow).Cells("CustomerCode").Value
                Me.TxtCustomer.Text = frmser.UGSearch.Rows(iRow).Cells("CustomerName").Value
                Me.TxtCustomerCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtCustomerCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCustomerCode.Validated
            ErrProvider.SetError(TxtOwnerCode, String.Empty)
        End Sub

        Private Sub TxtCustomerCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtCustomerCode.Validating
            Try
                If TxtCustomerCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectCustomers", "CustomerCode", Trim(TxtCustomerCode.Text))
                    If Reader.HasRows = False Then
                        TxtCustomerCode.Text = String.Empty
                        TxtCustomer.Text = String.Empty
                        ErrProvider.SetError(TxtCustomerCode, "Invalid Customer Code")
                        ErrProvider.SetIconAlignment(TxtCustomerCode, ErrorIconAlignment.TopLeft)
                        e.Cancel = True
                    Else
                        ErrProvider.SetError(TxtCustomerCode, String.Empty)
                        Reader.Read()
                        TxtCustomer.Text = Reader.Item("CustomerName")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
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
                Me.Desc.Text = frmser.UGSearch.Rows(iRow).Cells("VehicleDescription").Value
                Me.TxtVehicleCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtOwnerCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOwnerCode.ValueChanged

        End Sub

        Private Sub TxtCustomerCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCustomerCode.ValueChanged

        End Sub

        Private Sub TxtFreightGLCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFreightGLCode.ValueChanged

        End Sub

        Private Sub TxtinstallmentGLCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtinstallmentGLCode.ValueChanged

        End Sub

        Private Sub TxtLoanGLCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLoanGLCode.ValueChanged

        End Sub

        Private Sub TxtCommissionGLCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCommissionGLCode.ValueChanged

        End Sub
    End Class
End Namespace