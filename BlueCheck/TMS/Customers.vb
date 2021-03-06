Imports BusinessLeaf.frmMain

Namespace Inventory
    Public Class Customers
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
        Friend WithEvents TextBox3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents TextBox11 As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TextBox13 As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents TxtCity As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtAddress As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtCityCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents TextBox1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TextBox4 As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtCustomerCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents txtPhone As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        Friend WithEvents LblCity As System.Windows.Forms.LinkLabel
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents ATUrduTitle As ATUrduTextBox.UrduTextBox
        Friend WithEvents TxtFreightGLDesc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtFreightGLCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents LblGLCode As System.Windows.Forms.LinkLabel
        Friend WithEvents TxtShortageGLDescription As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtShortageGLCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents LblGLCommissionGLCode As System.Windows.Forms.LinkLabel
        Friend WithEvents TxtWHTaxGLDescription As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtWHTaxGLCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customers))
            Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Me.TxtCustomerCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.TextBox3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.TxtCity = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtCityCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.txtPhone = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TextBox11 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TextBox13 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label10 = New System.Windows.Forms.Label
            Me.TxtAddress = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label8 = New System.Windows.Forms.Label
            Me.LblCity = New System.Windows.Forms.LinkLabel
            Me.Label6 = New System.Windows.Forms.Label
            Me.dtpDate = New System.Windows.Forms.DateTimePicker
            Me.Label11 = New System.Windows.Forms.Label
            Me.Label12 = New System.Windows.Forms.Label
            Me.Label13 = New System.Windows.Forms.Label
            Me.TextBox1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TextBox4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.Label3 = New System.Windows.Forms.Label
            Me.ATUrduTitle = New ATUrduTextBox.UrduTextBox
            Me.TxtFreightGLDesc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtFreightGLCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.LblGLCode = New System.Windows.Forms.LinkLabel
            Me.TxtShortageGLDescription = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtShortageGLCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.LblGLCommissionGLCode = New System.Windows.Forms.LinkLabel
            Me.TxtWHTaxGLDescription = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtWHTaxGLCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
            CType(Me.TxtCustomerCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCityCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtPhone, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ATUrduTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtFreightGLDesc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtFreightGLCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtShortageGLDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtShortageGLCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtWHTaxGLDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtWHTaxGLCode, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TxtCustomerCode
            '
            Me.TxtCustomerCode.AccessibleDescription = "AUTO"
            Me.TxtCustomerCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCustomerCode.Appearance = Appearance1
            Me.TxtCustomerCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCustomerCode.Location = New System.Drawing.Point(205, 89)
            Me.TxtCustomerCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.CustomerCode_Length
            Me.TxtCustomerCode.Name = "TxtCustomerCode"
            Me.TxtCustomerCode.Size = New System.Drawing.Size(127, 21)
            Me.TxtCustomerCode.TabIndex = 0
            Me.TxtCustomerCode.Tag = "PK.CustomerCode"
            '
            'Desc
            '
            Me.Desc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Appearance = Appearance2
            Me.Desc.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Location = New System.Drawing.Point(205, 113)
            Me.Desc.MinimumSize = New System.Drawing.Size(176, 0)
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(510, 21)
            Me.Desc.TabIndex = 1
            Me.Desc.Tag = "FK.CustomerName"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(95, 89)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Customer Code"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.ForeColor = System.Drawing.Color.Navy
            Me.Label4.Location = New System.Drawing.Point(95, 113)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(110, 20)
            Me.Label4.TabIndex = 12
            Me.Label4.Text = "Name"
            '
            'TextBox3
            '
            Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance3.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox3.Appearance = Appearance3
            Me.TextBox3.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox3.Location = New System.Drawing.Point(205, 227)
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New System.Drawing.Size(176, 21)
            Me.TextBox3.TabIndex = 4
            Me.TextBox3.Tag = "dd.PostalCode"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Location = New System.Drawing.Point(95, 230)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 15
            Me.Label2.Text = "Postal Code"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Location = New System.Drawing.Point(95, 178)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(110, 20)
            Me.Label5.TabIndex = 18
            Me.Label5.Text = "Address"
            '
            'TxtCity
            '
            Me.TxtCity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance4.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCity.Appearance = Appearance4
            Me.TxtCity.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCity.Location = New System.Drawing.Point(332, 251)
            Me.TxtCity.Name = "TxtCity"
            Me.TxtCity.Size = New System.Drawing.Size(383, 21)
            Me.TxtCity.TabIndex = 29
            Me.TxtCity.TabStop = False
            Me.TxtCity.Tag = "dd.City"
            '
            'TxtCityCode
            '
            Me.TxtCityCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance5.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCityCode.Appearance = Appearance5
            Me.TxtCityCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCityCode.Location = New System.Drawing.Point(205, 251)
            Me.TxtCityCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.CityCode_Length
            Me.TxtCityCode.Name = "TxtCityCode"
            Me.TxtCityCode.Size = New System.Drawing.Size(127, 21)
            Me.TxtCityCode.TabIndex = 5
            Me.TxtCityCode.Tag = "FK.CityCode"
            '
            'txtPhone
            '
            Me.txtPhone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance6.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhone.Appearance = Appearance6
            Me.txtPhone.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhone.Location = New System.Drawing.Point(205, 347)
            Me.txtPhone.Name = "txtPhone"
            Me.txtPhone.Size = New System.Drawing.Size(176, 21)
            Me.txtPhone.TabIndex = 9
            Me.txtPhone.Tag = "dd.TelePhone"
            '
            'TextBox11
            '
            Me.TextBox11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance7.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox11.Appearance = Appearance7
            Me.TextBox11.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox11.Location = New System.Drawing.Point(205, 395)
            Me.TextBox11.Name = "TextBox11"
            Me.TextBox11.Size = New System.Drawing.Size(176, 21)
            Me.TextBox11.TabIndex = 11
            Me.TextBox11.Tag = "dd.Email"
            '
            'TextBox13
            '
            Me.TextBox13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance8.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox13.Appearance = Appearance8
            Me.TextBox13.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox13.Location = New System.Drawing.Point(205, 371)
            Me.TextBox13.Name = "TextBox13"
            Me.TextBox13.Size = New System.Drawing.Size(176, 21)
            Me.TextBox13.TabIndex = 10
            Me.TextBox13.Tag = "dd.Fax"
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.Transparent
            Me.Label10.Location = New System.Drawing.Point(95, 395)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(110, 20)
            Me.Label10.TabIndex = 35
            Me.Label10.Text = "Email"
            '
            'TxtAddress
            '
            Me.TxtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance9.BackColor = System.Drawing.SystemColors.Window
            Me.TxtAddress.Appearance = Appearance9
            Me.TxtAddress.BackColor = System.Drawing.SystemColors.Window
            Me.TxtAddress.Location = New System.Drawing.Point(205, 176)
            Me.TxtAddress.MinimumSize = New System.Drawing.Size(176, 0)
            Me.TxtAddress.Multiline = True
            Me.TxtAddress.Name = "TxtAddress"
            Me.TxtAddress.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtAddress.Size = New System.Drawing.Size(272, 48)
            Me.TxtAddress.TabIndex = 3
            Me.TxtAddress.Tag = "IM.Address"
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Location = New System.Drawing.Point(95, 371)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(110, 20)
            Me.Label8.TabIndex = 41
            Me.Label8.Text = "Fax"
            '
            'LblCity
            '
            Me.LblCity.BackColor = System.Drawing.Color.Transparent
            Me.LblCity.ForeColor = System.Drawing.Color.Navy
            Me.LblCity.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.LblCity.Location = New System.Drawing.Point(95, 255)
            Me.LblCity.Name = "LblCity"
            Me.LblCity.Size = New System.Drawing.Size(110, 20)
            Me.LblCity.TabIndex = 42
            Me.LblCity.TabStop = True
            Me.LblCity.Text = "City"
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Location = New System.Drawing.Point(95, 347)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(110, 20)
            Me.Label6.TabIndex = 43
            Me.Label6.Text = "Phone"
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
            Me.dtpDate.Location = New System.Drawing.Point(205, 467)
            Me.dtpDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.dtpDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.dtpDate.Name = "dtpDate"
            Me.dtpDate.Size = New System.Drawing.Size(127, 20)
            Me.dtpDate.TabIndex = 14
            Me.dtpDate.Tag = "dt.DefinitionDate"
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.ForeColor = System.Drawing.Color.Navy
            Me.Label11.Location = New System.Drawing.Point(95, 467)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(110, 20)
            Me.Label11.TabIndex = 98
            Me.Label11.Text = "Definition Date"
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.Transparent
            Me.Label12.Location = New System.Drawing.Point(95, 419)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(110, 20)
            Me.Label12.TabIndex = 103
            Me.Label12.Text = "National Tax No."
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.Transparent
            Me.Label13.Location = New System.Drawing.Point(95, 443)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(110, 20)
            Me.Label13.TabIndex = 102
            Me.Label13.Text = "Sales Tax No."
            '
            'TextBox1
            '
            Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance10.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox1.Appearance = Appearance10
            Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox1.Location = New System.Drawing.Point(205, 443)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(176, 21)
            Me.TextBox1.TabIndex = 13
            Me.TextBox1.Tag = "dd.SalesTaxNumber"
            '
            'TextBox4
            '
            Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance11.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox4.Appearance = Appearance11
            Me.TextBox4.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox4.Location = New System.Drawing.Point(205, 419)
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.Size = New System.Drawing.Size(176, 21)
            Me.TextBox4.TabIndex = 12
            Me.TextBox4.Tag = "dd.NationalTaxNumber"
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
            Me.Label3.Font = Global.BusinessLeaf.My.MySettings.Default.UrduFontType
            Me.Label3.ForeColor = System.Drawing.Color.Navy
            Me.Label3.Location = New System.Drawing.Point(95, 137)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(110, 41)
            Me.Label3.TabIndex = 108
            Me.Label3.Text = "نام"
            '
            'ATUrduTitle
            '
            Me.ATUrduTitle.DataBindings.Add(New System.Windows.Forms.Binding("Font", Global.BusinessLeaf.My.MySettings.Default, "UrduFontType", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.ATUrduTitle.Font = Global.BusinessLeaf.My.MySettings.Default.UrduFontType
            Me.ATUrduTitle.Location = New System.Drawing.Point(205, 137)
            Me.ATUrduTitle.Name = "ATUrduTitle"
            Me.ATUrduTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.ATUrduTitle.Size = New System.Drawing.Size(214, 35)
            Me.ATUrduTitle.TabIndex = 2
            Me.ATUrduTitle.Tag = "dd.UrduTitle"
            '
            'TxtFreightGLDesc
            '
            Me.TxtFreightGLDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance16.BackColor = System.Drawing.SystemColors.Window
            Me.TxtFreightGLDesc.Appearance = Appearance16
            Me.TxtFreightGLDesc.BackColor = System.Drawing.SystemColors.Window
            Me.TxtFreightGLDesc.Location = New System.Drawing.Point(332, 275)
            Me.TxtFreightGLDesc.Name = "TxtFreightGLDesc"
            Me.TxtFreightGLDesc.Size = New System.Drawing.Size(383, 21)
            Me.TxtFreightGLDesc.TabIndex = 118
            Me.TxtFreightGLDesc.TabStop = False
            Me.TxtFreightGLDesc.Tag = "dd.GLDescription"
            '
            'TxtFreightGLCode
            '
            Me.TxtFreightGLCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance17.BackColor = System.Drawing.SystemColors.Window
            Me.TxtFreightGLCode.Appearance = Appearance17
            Me.TxtFreightGLCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtFreightGLCode.Location = New System.Drawing.Point(205, 275)
            Me.TxtFreightGLCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.GLCode_Length
            Me.TxtFreightGLCode.Name = "TxtFreightGLCode"
            Me.TxtFreightGLCode.Size = New System.Drawing.Size(127, 21)
            Me.TxtFreightGLCode.TabIndex = 6
            Me.TxtFreightGLCode.Tag = "FK.GLCode"
            '
            'LblGLCode
            '
            Me.LblGLCode.BackColor = System.Drawing.Color.Transparent
            Me.LblGLCode.ForeColor = System.Drawing.Color.Navy
            Me.LblGLCode.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.LblGLCode.Location = New System.Drawing.Point(95, 278)
            Me.LblGLCode.Name = "LblGLCode"
            Me.LblGLCode.Size = New System.Drawing.Size(110, 20)
            Me.LblGLCode.TabIndex = 119
            Me.LblGLCode.TabStop = True
            Me.LblGLCode.Text = "GL Code"
            '
            'TxtShortageGLDescription
            '
            Me.TxtShortageGLDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance14.BackColor = System.Drawing.SystemColors.Window
            Me.TxtShortageGLDescription.Appearance = Appearance14
            Me.TxtShortageGLDescription.BackColor = System.Drawing.SystemColors.Window
            Me.TxtShortageGLDescription.Location = New System.Drawing.Point(332, 299)
            Me.TxtShortageGLDescription.Name = "TxtShortageGLDescription"
            Me.TxtShortageGLDescription.Size = New System.Drawing.Size(383, 21)
            Me.TxtShortageGLDescription.TabIndex = 122
            Me.TxtShortageGLDescription.TabStop = False
            Me.TxtShortageGLDescription.Tag = "dd.ShortageGLDescription"
            '
            'TxtShortageGLCode
            '
            Me.TxtShortageGLCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance15.BackColor = System.Drawing.SystemColors.Window
            Me.TxtShortageGLCode.Appearance = Appearance15
            Me.TxtShortageGLCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtShortageGLCode.Location = New System.Drawing.Point(205, 299)
            Me.TxtShortageGLCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.GLCode_Length
            Me.TxtShortageGLCode.Name = "TxtShortageGLCode"
            Me.TxtShortageGLCode.Size = New System.Drawing.Size(127, 21)
            Me.TxtShortageGLCode.TabIndex = 7
            Me.TxtShortageGLCode.Tag = "FK.ShortageGLCode"
            '
            'LblGLCommissionGLCode
            '
            Me.LblGLCommissionGLCode.BackColor = System.Drawing.Color.Transparent
            Me.LblGLCommissionGLCode.ForeColor = System.Drawing.Color.Navy
            Me.LblGLCommissionGLCode.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.LblGLCommissionGLCode.Location = New System.Drawing.Point(95, 301)
            Me.LblGLCommissionGLCode.Name = "LblGLCommissionGLCode"
            Me.LblGLCommissionGLCode.Size = New System.Drawing.Size(110, 20)
            Me.LblGLCommissionGLCode.TabIndex = 123
            Me.LblGLCommissionGLCode.TabStop = True
            Me.LblGLCommissionGLCode.Text = "Shortage GL Code"
            '
            'TxtWHTaxGLDescription
            '
            Me.TxtWHTaxGLDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance12.BackColor = System.Drawing.SystemColors.Window
            Me.TxtWHTaxGLDescription.Appearance = Appearance12
            Me.TxtWHTaxGLDescription.BackColor = System.Drawing.SystemColors.Window
            Me.TxtWHTaxGLDescription.Location = New System.Drawing.Point(332, 323)
            Me.TxtWHTaxGLDescription.Name = "TxtWHTaxGLDescription"
            Me.TxtWHTaxGLDescription.Size = New System.Drawing.Size(383, 21)
            Me.TxtWHTaxGLDescription.TabIndex = 126
            Me.TxtWHTaxGLDescription.TabStop = False
            Me.TxtWHTaxGLDescription.Tag = "dd.WHTaxGLDescription"
            '
            'TxtWHTaxGLCode
            '
            Me.TxtWHTaxGLCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance13.BackColor = System.Drawing.SystemColors.Window
            Me.TxtWHTaxGLCode.Appearance = Appearance13
            Me.TxtWHTaxGLCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtWHTaxGLCode.Location = New System.Drawing.Point(205, 323)
            Me.TxtWHTaxGLCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.GLCode_Length
            Me.TxtWHTaxGLCode.Name = "TxtWHTaxGLCode"
            Me.TxtWHTaxGLCode.Size = New System.Drawing.Size(127, 21)
            Me.TxtWHTaxGLCode.TabIndex = 8
            Me.TxtWHTaxGLCode.Tag = "FK.WHTaxGLCode"
            '
            'LinkLabel1
            '
            Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
            Me.LinkLabel1.ForeColor = System.Drawing.Color.Navy
            Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.LinkLabel1.Location = New System.Drawing.Point(95, 324)
            Me.LinkLabel1.Name = "LinkLabel1"
            Me.LinkLabel1.Size = New System.Drawing.Size(110, 20)
            Me.LinkLabel1.TabIndex = 127
            Me.LinkLabel1.TabStop = True
            Me.LinkLabel1.Text = "WH Tax GL Code"
            '
            'Customers
            '
            Me.AccessibleName = ""
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(804, 512)
            Me.Controls.Add(Me.TxtWHTaxGLDescription)
            Me.Controls.Add(Me.TxtWHTaxGLCode)
            Me.Controls.Add(Me.LinkLabel1)
            Me.Controls.Add(Me.TxtShortageGLDescription)
            Me.Controls.Add(Me.TxtShortageGLCode)
            Me.Controls.Add(Me.LblGLCommissionGLCode)
            Me.Controls.Add(Me.TxtFreightGLDesc)
            Me.Controls.Add(Me.TxtFreightGLCode)
            Me.Controls.Add(Me.LblGLCode)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.ATUrduTitle)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.Label13)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.TextBox4)
            Me.Controls.Add(Me.TextBox11)
            Me.Controls.Add(Me.TextBox13)
            Me.Controls.Add(Me.TxtCity)
            Me.Controls.Add(Me.TxtCityCode)
            Me.Controls.Add(Me.txtPhone)
            Me.Controls.Add(Me.TxtAddress)
            Me.Controls.Add(Me.TextBox3)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.TxtCustomerCode)
            Me.Controls.Add(Me.dtpDate)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.LblCity)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label1)
            Me.KeyPreview = True
            Me.MinimumSize = Global.BusinessLeaf.My.MySettings.Default.SetupFormMinimumSize
            Me.Name = "Customers"
            Me.Text = "Customer File"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.TxtCustomerCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCityCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtPhone, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtAddress, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ATUrduTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtFreightGLDesc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtFreightGLCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtShortageGLDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtShortageGLCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtWHTaxGLDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtWHTaxGLCode, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
            If Char.IsLetter(e.KeyChar) = True Then
                e.Handled = True
            End If
        End Sub
        Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
            If Char.IsLetter(e.KeyChar) = True Then
                e.Handled = True
            End If
        End Sub
        Private Sub TextBox13_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox13.KeyPress
            If Char.IsLetter(e.KeyChar) = True Then
                e.Handled = True
            End If
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
                Me.Desc.Text = frmser.UGSearch.Rows(iRow).Cells("CustomerName").Value
                Me.TxtCustomerCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtCustomerCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCustomerCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtCustomerCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCustomerCode.KeyPress
            'If Char.IsDigit(e.KeyChar) = False And e.KeyChar.Then Then
            '    e.Handled = True
            'End If
        End Sub

        Private Sub TxtCustomerID_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtCustomerCode.Validating
            If Trim(TxtCustomerCode.Text) <> "" Then
                If Trim(TxtCustomerCode.Text).Length <> TxtCustomerCode.MaxLength Then
                    e.Cancel = True
                    ErrProvider.SetError(TxtCustomerCode, " Please Enter a Proper length of Code ")
                End If
            End If
        End Sub

        Private Sub TxtCityCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtCityCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Cities")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtCityCode.Text = frmser.UGSearch.Rows(iRow).Cells("CityCode").Value
                Me.TxtCity.Text = frmser.UGSearch.Rows(iRow).Cells("City").Value
                Me.TxtCityCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtCityCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCityCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtCityCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub


        Private Sub cmdCityList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub Customers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub

        Private Sub CmdCustomerList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub BtnFreightGLList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
                    Call Me.TxtCityCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub BtnShortageGLList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub TxtShortageGLCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtShortageGLCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("COACombine")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtShortageGLCode.Text = frmser.UGSearch.Rows(iRow).Cells("GLCode").Value
                Me.TxtShortageGLDescription.Text = frmser.UGSearch.Rows(iRow).Cells("GLDescription").Value
                Me.TxtShortageGLCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtShortageGLCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtShortageGLCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtShortageGLCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
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

        Private Sub TxtCityCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtCityCode.Validated
            ErrProvider.SetError(TxtCityCode, String.Empty)
        End Sub

        Private Sub TxtCityCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtCityCode.Validating
            Try
                If TxtCityCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectCities", "CityCode ", Trim(TxtCityCode.Text))
                    If Reader.HasRows = False Then
                        ErrProvider.SetError(TxtCityCode, "Invalid City Code")
                        ErrProvider.SetIconAlignment(TxtCityCode, ErrorIconAlignment.TopLeft)
                        TxtCityCode.Text = String.Empty
                        TxtCity.Text = String.Empty
                        e.Cancel = True
                    Else
                        Reader.Read()
                        ErrProvider.SetError(TxtCityCode, "")
                        TxtCity.Text = Reader.Item("City")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Private Sub TxtShortageGLCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtShortageGLCode.Validated
            ErrProvider.SetError(TxtShortageGLCode, String.Empty)
        End Sub

        Private Sub TxtShortageGLCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtShortageGLCode.Validating
            Try
                If TxtShortageGLCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader


                    Reader = Acc.GetRecord("SelectCOACombine", "GLCode ", Trim(TxtShortageGLCode.Text))
                    If Reader.HasRows = False Then
                        TxtShortageGLCode.Text = String.Empty
                        TxtShortageGLDescription.Text = String.Empty
                        ErrProvider.SetError(TxtShortageGLCode, "Invalid GL Code")
                        ErrProvider.SetIconAlignment(TxtShortageGLCode, ErrorIconAlignment.TopLeft)
                        e.Cancel = True
                    Else
                        ErrProvider.SetError(TxtShortageGLCode, String.Empty)
                        Reader.Read()
                        TxtShortageGLDescription.Text = Reader.Item("GLDescription")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub LblGLCode_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LblGLCode.LinkClicked
            CType(Me.MdiParent, frmMain).SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "COASubsidiaries", "", Nothing, Nothing))
        End Sub

        Private Sub LblGLCommissionGLCode_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LblGLCommissionGLCode.LinkClicked
            CType(Me.MdiParent, frmMain).SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "COASubsidiaries", "", Nothing, Nothing))
        End Sub


        Private Sub BtnWHTaxGLList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub TxtWHTaxGLCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtWHTaxGLCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("COACombine")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtWHTaxGLCode.Text = frmser.UGSearch.Rows(iRow).Cells("GLCode").Value
                Me.TxtWHTaxGLDescription.Text = frmser.UGSearch.Rows(iRow).Cells("GLDescription").Value
                Me.TxtWHTaxGLCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtWHTaxGLCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtWHTaxGLCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtWHTaxGLCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtWHTaxGLCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtWHTaxGLCode.Validated
            ErrProvider.SetError(TxtWHTaxGLCode, String.Empty)
        End Sub
        Private Sub TxtWHTaxGLCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtWHTaxGLCode.Validating
            Try
                If TxtWHTaxGLCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader


                    Reader = Acc.GetRecord("SelectCOACombine", "GLCode ", Trim(TxtWHTaxGLCode.Text))
                    If Reader.HasRows = False Then
                        TxtWHTaxGLCode.Text = String.Empty
                        TxtWHTaxGLDescription.Text = String.Empty
                        ErrProvider.SetError(TxtWHTaxGLCode, "Invalid GL Code")
                        ErrProvider.SetIconAlignment(TxtWHTaxGLCode, ErrorIconAlignment.TopLeft)
                        e.Cancel = True
                    Else
                        ErrProvider.SetError(TxtWHTaxGLCode, String.Empty)
                        Reader.Read()
                        TxtWHTaxGLDescription.Text = Reader.Item("GLDescription")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub TxtCityCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCityCode.ValueChanged

        End Sub

        Private Sub BtnFreightGLList_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub TxtFreightGLCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFreightGLCode.ValueChanged

        End Sub

        Private Sub TxtShortageGLCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtShortageGLCode.ValueChanged

        End Sub

        Private Sub TxtWHTaxGLCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtWHTaxGLCode.ValueChanged

        End Sub

        Private Sub TxtCustomerCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCustomerCode.ValueChanged

        End Sub
    End Class
End Namespace