Namespace Inventory
    Public Class Desc
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
        Friend WithEvents cmdCityList As System.Windows.Forms.Button
        Friend WithEvents TxtSupplierCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents txtPhone As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        Friend WithEvents LblCity As System.Windows.Forms.LinkLabel
        Friend WithEvents CmdSupplierList As System.Windows.Forms.Button
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents ATUrduTitle As ATUrduTextBox.UrduTextBox
        Friend WithEvents TxtSupplier As Infragistics.Win.UltraWinEditors.UltraTextEditor
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desc))
            Me.TxtSupplierCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtSupplier = New Infragistics.Win.UltraWinEditors.UltraTextEditor
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
            Me.cmdCityList = New System.Windows.Forms.Button
            Me.dtpDate = New System.Windows.Forms.DateTimePicker
            Me.Label11 = New System.Windows.Forms.Label
            Me.Label12 = New System.Windows.Forms.Label
            Me.Label13 = New System.Windows.Forms.Label
            Me.TextBox1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TextBox4 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.CmdSupplierList = New System.Windows.Forms.Button
            Me.Label3 = New System.Windows.Forms.Label
            Me.ATUrduTitle = New ATUrduTextBox.UrduTextBox
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TxtSupplierCode
            '
            Me.TxtSupplierCode.AccessibleDescription = "AUTO"
            Me.TxtSupplierCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.TxtSupplierCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtSupplierCode.Location = New System.Drawing.Point(150, 84)
            Me.TxtSupplierCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.SupplierCode_Length
            Me.TxtSupplierCode.Name = "TxtSupplierCode"
            Me.TxtSupplierCode.Size = New System.Drawing.Size(100, 20)
            Me.TxtSupplierCode.TabIndex = 0
            Me.TxtSupplierCode.Tag = "PK.SupplierCode"
            '
            'TxtSupplier
            '
            Me.TxtSupplier.AccessibleDescription = "Description"
            Me.TxtSupplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtSupplier.BackColor = System.Drawing.SystemColors.Window
            Me.TxtSupplier.Location = New System.Drawing.Point(150, 108)
            Me.TxtSupplier.MinimumSize = New System.Drawing.Size(176, 0)
            Me.TxtSupplier.Name = "TxtSupplier"
            Me.TxtSupplier.Size = New System.Drawing.Size(510, 20)
            Me.TxtSupplier.TabIndex = 1
            Me.TxtSupplier.Tag = "FK.SupplierName"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(40, 84)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Supplier Code"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.ForeColor = System.Drawing.Color.Navy
            Me.Label4.Location = New System.Drawing.Point(40, 108)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(110, 20)
            Me.Label4.TabIndex = 12
            Me.Label4.Text = "Name"
            '
            'TextBox3
            '
            Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.TextBox3.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox3.Location = New System.Drawing.Point(150, 235)
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New System.Drawing.Size(176, 20)
            Me.TextBox3.TabIndex = 4
            Me.TextBox3.Tag = "dd.PostalCode"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Location = New System.Drawing.Point(40, 235)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 15
            Me.Label2.Text = "Postal Code"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Location = New System.Drawing.Point(40, 183)
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
            Me.TxtCity.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCity.Location = New System.Drawing.Point(281, 259)
            Me.TxtCity.Name = "TxtCity"
            Me.TxtCity.Size = New System.Drawing.Size(379, 20)
            Me.TxtCity.TabIndex = 29
            Me.TxtCity.TabStop = False
            Me.TxtCity.Tag = "dd.City"
            '
            'TxtCityCode
            '
            Me.TxtCityCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.TxtCityCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCityCode.Location = New System.Drawing.Point(150, 259)
            Me.TxtCityCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.CityCode_Length
            Me.TxtCityCode.Name = "TxtCityCode"
            Me.TxtCityCode.Size = New System.Drawing.Size(100, 20)
            Me.TxtCityCode.TabIndex = 5
            Me.TxtCityCode.Tag = "FK.CityCode"
            '
            'txtPhone
            '
            Me.txtPhone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.txtPhone.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhone.Location = New System.Drawing.Point(150, 283)
            Me.txtPhone.Name = "txtPhone"
            Me.txtPhone.Size = New System.Drawing.Size(176, 20)
            Me.txtPhone.TabIndex = 6
            Me.txtPhone.Tag = "dd.TelePhone"
            '
            'TextBox11
            '
            Me.TextBox11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.TextBox11.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox11.Location = New System.Drawing.Point(150, 331)
            Me.TextBox11.Name = "TextBox11"
            Me.TextBox11.Size = New System.Drawing.Size(176, 20)
            Me.TextBox11.TabIndex = 8
            Me.TextBox11.Tag = "dd.Email"
            '
            'TextBox13
            '
            Me.TextBox13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.TextBox13.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox13.Location = New System.Drawing.Point(150, 307)
            Me.TextBox13.Name = "TextBox13"
            Me.TextBox13.Size = New System.Drawing.Size(176, 20)
            Me.TextBox13.TabIndex = 7
            Me.TextBox13.Tag = "dd.Fax"
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.Transparent
            Me.Label10.Location = New System.Drawing.Point(40, 332)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(110, 20)
            Me.Label10.TabIndex = 35
            Me.Label10.Text = "Email"
            '
            'TxtAddress
            '
            Me.TxtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtAddress.BackColor = System.Drawing.SystemColors.Window
            Me.TxtAddress.Location = New System.Drawing.Point(150, 183)
            Me.TxtAddress.MinimumSize = New System.Drawing.Size(176, 0)
            Me.TxtAddress.Multiline = True
            Me.TxtAddress.Name = "TxtAddress"
            Me.TxtAddress.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtAddress.Size = New System.Drawing.Size(272, 48)
            Me.TxtAddress.TabIndex = 3
            Me.TxtAddress.Tag = "FK.Address"
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Location = New System.Drawing.Point(40, 307)
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
            Me.LblCity.Location = New System.Drawing.Point(40, 260)
            Me.LblCity.Name = "LblCity"
            Me.LblCity.Size = New System.Drawing.Size(110, 20)
            Me.LblCity.TabIndex = 42
            Me.LblCity.TabStop = True
            Me.LblCity.Text = "City"
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Location = New System.Drawing.Point(40, 283)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(110, 20)
            Me.Label6.TabIndex = 43
            Me.Label6.Text = "Phone"
            '
            'cmdCityList
            '
            Me.cmdCityList.BackColor = System.Drawing.SystemColors.Window
            Me.cmdCityList.Image = CType(resources.GetObject("cmdCityList.Image"), System.Drawing.Image)
            Me.cmdCityList.Location = New System.Drawing.Point(253, 259)
            Me.cmdCityList.Name = "cmdCityList"
            Me.cmdCityList.Size = New System.Drawing.Size(24, 20)
            Me.cmdCityList.TabIndex = 70
            Me.cmdCityList.TabStop = False
            Me.cmdCityList.UseVisualStyleBackColor = False
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
            Me.dtpDate.Location = New System.Drawing.Point(150, 403)
            Me.dtpDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.dtpDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.dtpDate.Name = "dtpDate"
            Me.dtpDate.Size = New System.Drawing.Size(100, 20)
            Me.dtpDate.TabIndex = 11
            Me.dtpDate.Tag = "dt.DefinitionDate"
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.ForeColor = System.Drawing.Color.Navy
            Me.Label11.Location = New System.Drawing.Point(40, 403)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(110, 20)
            Me.Label11.TabIndex = 98
            Me.Label11.Text = "Definition Date"
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.Transparent
            Me.Label12.Location = New System.Drawing.Point(40, 356)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(110, 20)
            Me.Label12.TabIndex = 103
            Me.Label12.Text = "National Tax No."
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.Transparent
            Me.Label13.Location = New System.Drawing.Point(40, 381)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(110, 20)
            Me.Label13.TabIndex = 102
            Me.Label13.Text = "Sales Tax No."
            '
            'TextBox1
            '
            Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox1.Location = New System.Drawing.Point(150, 379)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(176, 20)
            Me.TextBox1.TabIndex = 10
            Me.TextBox1.Tag = "dd.SalesTaxNumber"
            '
            'TextBox4
            '
            Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.TextBox4.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox4.Location = New System.Drawing.Point(150, 355)
            Me.TextBox4.Name = "TextBox4"
            Me.TextBox4.Size = New System.Drawing.Size(176, 20)
            Me.TextBox4.TabIndex = 9
            Me.TextBox4.Tag = "dd.NationalTaxNumber"
            '
            'ErrProvider
            '
            Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
            Me.ErrProvider.ContainerControl = Me
            Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
            Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
            '
            'CmdSupplierList
            '
            Me.CmdSupplierList.BackColor = System.Drawing.SystemColors.Window
            Me.CmdSupplierList.Image = CType(resources.GetObject("CmdSupplierList.Image"), System.Drawing.Image)
            Me.CmdSupplierList.Location = New System.Drawing.Point(253, 84)
            Me.CmdSupplierList.Name = "CmdSupplierList"
            Me.CmdSupplierList.Size = New System.Drawing.Size(24, 20)
            Me.CmdSupplierList.TabIndex = 104
            Me.CmdSupplierList.TabStop = False
            Me.CmdSupplierList.UseVisualStyleBackColor = False
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Urdu_Emad_Nastaliq", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.Navy
            Me.Label3.Location = New System.Drawing.Point(36, 132)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(110, 47)
            Me.Label3.TabIndex = 108
            Me.Label3.Text = "نام"
            '
            'ATUrduTitle
            '
            Me.ATUrduTitle.Font = New System.Drawing.Font("Urdu_Emad_Nastaliq", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Me.ATUrduTitle.Location = New System.Drawing.Point(150, 132)
            Me.ATUrduTitle.Name = "ATUrduTitle"
            Me.ATUrduTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.ATUrduTitle.Size = New System.Drawing.Size(214, 47)
            Me.ATUrduTitle.TabIndex = 2
            Me.ATUrduTitle.Tag = "dd.UrduTitle"
            '
            'Desc
            '
            Me.AccessibleName = ""
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(804, 494)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.ATUrduTitle)
            Me.Controls.Add(Me.CmdSupplierList)
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
            Me.Controls.Add(Me.TxtSupplier)
            Me.Controls.Add(Me.TxtSupplierCode)
            Me.Controls.Add(Me.dtpDate)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.cmdCityList)
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
            Me.Name = "Desc"
            Me.Text = "Supplier File"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
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
        Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSupplierCode.KeyPress
            'If Char.IsDigit(e.KeyChar) = False And e.KeyChar.Then Then
            '    e.Handled = True
            'End If
        End Sub

        Private Sub TxtSupplierID_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtSupplierCode.Validating
            If Trim(TxtSupplierCode.Text) <> "" Then
                If Trim(TxtSupplierCode.Text).Length <> TxtSupplierCode.MaxLength Then
                    e.Cancel = True
                    ErrProvider.SetError(TxtSupplierCode, " Please Enter a Proper length of Code ")
                End If
            End If
        End Sub

        Private Sub TxtCityCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCityCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.cmdCityList_Click(sender, New System.EventArgs)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        

        Private Sub cmdCityList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCityList.Click
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

        Private Sub Suppliers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub

        Private Sub CmdSupplierList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSupplierList.Click
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Suppliers")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtSupplierCode.Text = frmser.UGSearch.Rows(iRow).Cells("SupplierCode").Value
                Me.TxtSupplier.Text = frmser.UGSearch.Rows(iRow).Cells("SupplierName").Value
                Me.TxtSupplierCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtCityCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCityCode.TextChanged

        End Sub

        Private Sub TxtSupplierCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSupplierCode.TextChanged

        End Sub

        Private Sub TxtCityCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtCityCode.Validating
            If Trim(TxtCityCode.Text) <> "" Then
                Dim mdi As frmMain
                If Trim(TxtCityCode.Text).Length <> TxtCityCode.MaxLength Then
                    ErrProvider.SetIconAlignment(TxtCityCode, ErrorIconAlignment.MiddleLeft)
                    ErrProvider.SetError(TxtCityCode, " Please Enter a Proper length of Code ")
                    TxtCityCode.Focus()
                Else
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader
                    Try
                        Reader = Acc.GetRecord("SelectCities", "CityCode ", Trim(TxtCityCode.Text))
                        If Reader.HasRows = False Then
                            ErrProvider.SetError(TxtCityCode, "Invalid City Code")
                            ErrProvider.SetIconAlignment(TxtCityCode, ErrorIconAlignment.MiddleLeft)
                            mdi = Me.MdiParent
                            ' mdi.SldSearch.LookForSearch(TxtCityCode, TxtCity, TxtCityCode.Text, "CityCode", "Cities")
                            'mdi.sldGrid.LockSlide = True
                            TxtCityCode.Focus()
                            TxtCity.Text = ""
                        Else
                            ErrProvider.SetError(TxtCityCode, "")
                            mdi = Me.MdiParent
                            'mdi.sldGrid.LockSlide = False
                            'mdi.sldGrid.HideSlide()
                            Reader.Read()
                            TxtCity.Text = Reader.Item("City")
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                'Else
                '    e.Cancel = True
                '    ErrProvider.SetError(TxtCityCode, " Empty Code is not Allowed " & vbCrLf & " Please Enter a Proper length of Code ")
            End If
        End Sub
    End Class
End Namespace