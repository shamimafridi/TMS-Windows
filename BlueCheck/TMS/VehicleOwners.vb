Namespace Inventory
    Public Class VehicleOwners
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
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents TextBox11 As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents TxtCity As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtAddress As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtCityCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents TxtOwnerCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents txtPhone As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        Friend WithEvents LblCity As System.Windows.Forms.LinkLabel
        Friend WithEvents ATUrduTitle As ATUrduTextBox.UrduTextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VehicleOwners))
            Me.TxtOwnerCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.TxtCity = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtCityCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.txtPhone = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TextBox11 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label10 = New System.Windows.Forms.Label
            Me.TxtAddress = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.LblCity = New System.Windows.Forms.LinkLabel
            Me.Label6 = New System.Windows.Forms.Label
            Me.dtpDate = New System.Windows.Forms.DateTimePicker
            Me.Label11 = New System.Windows.Forms.Label
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.ATUrduTitle = New ATUrduTextBox.UrduTextBox
            Me.Label2 = New System.Windows.Forms.Label
            CType(Me.TxtOwnerCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCityCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtPhone, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtAddress, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ATUrduTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TxtOwnerCode
            '
            Me.TxtOwnerCode.AccessibleDescription = "AUTO"
            Me.TxtOwnerCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.TxtOwnerCode.Appearance = Appearance1
            Me.TxtOwnerCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtOwnerCode.DataBindings.Add(New System.Windows.Forms.Binding("MaxLength", Global.BusinessLeaf.My.MySettings.Default, "VehicleOwnerCode_Length", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.TxtOwnerCode.Location = New System.Drawing.Point(202, 97)
            Me.TxtOwnerCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.VehicleOwnerCode_Length
            Me.TxtOwnerCode.Name = "TxtOwnerCode"
            Me.TxtOwnerCode.Size = New System.Drawing.Size(127, 21)
            Me.TxtOwnerCode.TabIndex = 0
            Me.TxtOwnerCode.Tag = "PK.OwnerCode"
            '
            'Desc
            '
            Me.Desc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Appearance = Appearance2
            Me.Desc.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Location = New System.Drawing.Point(202, 120)
            Me.Desc.MinimumSize = New System.Drawing.Size(176, 0)
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(510, 21)
            Me.Desc.TabIndex = 1
            Me.Desc.Tag = "FK.OwnerName"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(86, 97)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "Owner Code"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.ForeColor = System.Drawing.Color.Navy
            Me.Label4.Location = New System.Drawing.Point(86, 122)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(110, 20)
            Me.Label4.TabIndex = 12
            Me.Label4.Text = "Name"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Location = New System.Drawing.Point(86, 183)
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
            Appearance3.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCity.Appearance = Appearance3
            Me.TxtCity.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCity.Location = New System.Drawing.Point(329, 230)
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
            Appearance4.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCityCode.Appearance = Appearance4
            Me.TxtCityCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCityCode.Location = New System.Drawing.Point(202, 230)
            Me.TxtCityCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.CityCode_Length
            Me.TxtCityCode.Name = "TxtCityCode"
            Me.TxtCityCode.Size = New System.Drawing.Size(127, 21)
            Me.TxtCityCode.TabIndex = 4
            Me.TxtCityCode.Tag = "FK.CityCode"
            '
            'txtPhone
            '
            Me.txtPhone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance5.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhone.Appearance = Appearance5
            Me.txtPhone.BackColor = System.Drawing.SystemColors.Window
            Me.txtPhone.Location = New System.Drawing.Point(202, 253)
            Me.txtPhone.Name = "txtPhone"
            Me.txtPhone.Size = New System.Drawing.Size(176, 21)
            Me.txtPhone.TabIndex = 5
            Me.txtPhone.Tag = "dd.TelePhone"
            '
            'TextBox11
            '
            Me.TextBox11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance6.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox11.Appearance = Appearance6
            Me.TextBox11.BackColor = System.Drawing.SystemColors.Window
            Me.TextBox11.Location = New System.Drawing.Point(202, 276)
            Me.TextBox11.Name = "TextBox11"
            Me.TextBox11.Size = New System.Drawing.Size(176, 21)
            Me.TextBox11.TabIndex = 6
            Me.TextBox11.Tag = "dd.Email"
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.Transparent
            Me.Label10.Location = New System.Drawing.Point(86, 277)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(110, 20)
            Me.Label10.TabIndex = 35
            Me.Label10.Text = "Email"
            '
            'TxtAddress
            '
            Me.TxtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance7.BackColor = System.Drawing.SystemColors.Window
            Me.TxtAddress.Appearance = Appearance7
            Me.TxtAddress.BackColor = System.Drawing.SystemColors.Window
            Me.TxtAddress.Location = New System.Drawing.Point(202, 180)
            Me.TxtAddress.MinimumSize = New System.Drawing.Size(176, 0)
            Me.TxtAddress.Multiline = True
            Me.TxtAddress.Name = "TxtAddress"
            Me.TxtAddress.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtAddress.Size = New System.Drawing.Size(272, 48)
            Me.TxtAddress.TabIndex = 3
            Me.TxtAddress.Tag = "IM.Address"
            '
            'LblCity
            '
            Me.LblCity.BackColor = System.Drawing.Color.Transparent
            Me.LblCity.ForeColor = System.Drawing.Color.Navy
            Me.LblCity.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.LblCity.Location = New System.Drawing.Point(86, 231)
            Me.LblCity.Name = "LblCity"
            Me.LblCity.Size = New System.Drawing.Size(110, 20)
            Me.LblCity.TabIndex = 42
            Me.LblCity.TabStop = True
            Me.LblCity.Text = "City"
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Location = New System.Drawing.Point(86, 257)
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
            Me.dtpDate.Location = New System.Drawing.Point(202, 299)
            Me.dtpDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.dtpDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.dtpDate.Name = "dtpDate"
            Me.dtpDate.Size = New System.Drawing.Size(100, 20)
            Me.dtpDate.TabIndex = 7
            Me.dtpDate.Tag = "dt.DefinitionDate"
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.Transparent
            Me.Label11.ForeColor = System.Drawing.Color.Navy
            Me.Label11.Location = New System.Drawing.Point(86, 300)
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
            'ATUrduTitle
            '
            Me.ATUrduTitle.Font = Global.BusinessLeaf.My.MySettings.Default.UrduFontType
            Me.ATUrduTitle.Location = New System.Drawing.Point(202, 143)
            Me.ATUrduTitle.Name = "ATUrduTitle"
            Me.ATUrduTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.ATUrduTitle.Size = New System.Drawing.Size(214, 35)
            Me.ATUrduTitle.TabIndex = 2
            Me.ATUrduTitle.Tag = "dd.UrduTitle"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = Global.BusinessLeaf.My.MySettings.Default.UrduFontType
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(86, 142)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 36)
            Me.Label2.TabIndex = 106
            Me.Label2.Text = "نام"
            '
            'VehicleOwners
            '
            Me.AccessibleName = ""
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.SystemColors.Control
            Me.ClientSize = New System.Drawing.Size(804, 494)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.ATUrduTitle)
            Me.Controls.Add(Me.TextBox11)
            Me.Controls.Add(Me.TxtCity)
            Me.Controls.Add(Me.TxtCityCode)
            Me.Controls.Add(Me.txtPhone)
            Me.Controls.Add(Me.TxtAddress)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.TxtOwnerCode)
            Me.Controls.Add(Me.dtpDate)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.LblCity)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label1)
            Me.KeyPreview = True
            Me.MinimumSize = Global.BusinessLeaf.My.MySettings.Default.SetupFormMinimumSize
            Me.Name = "VehicleOwners"
            Me.Text = "Owner File"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.TxtOwnerCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCityCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtPhone, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtAddress, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ATUrduTitle, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
            If Char.IsLetter(e.KeyChar) = True Then
                e.Handled = True
            End If
        End Sub
        Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress
            If Char.IsLetter(e.KeyChar) = True Then
                e.Handled = True
            End If
        End Sub
        Private Sub TextBox13_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
            If Char.IsLetter(e.KeyChar) = True Then
                e.Handled = True
            End If
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
                Me.Desc.Text = frmser.UGSearch.Rows(iRow).Cells("OwnerName").Value
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

        Private Sub TxtOwnerID_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtOwnerCode.Validating
            If Trim(TxtOwnerCode.Text) <> String.Empty Then
                If Trim(TxtOwnerCode.Text).Length <> TxtOwnerCode.MaxLength Then
                    e.Cancel = True
                    ErrProvider.SetError(TxtOwnerCode, " Please Enter a Proper length of Code ")
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

        Private Sub VehicleOwners_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub

        Private Sub CmdOwnerList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("VehicleOwners")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtOwnerCode.Text = frmser.UGSearch.Rows(iRow).Cells("OwnerCode").Value
                Me.Desc.Text = frmser.UGSearch.Rows(iRow).Cells("OwnerName").Value
                Me.TxtOwnerCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtOwnerCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOwnerCode.ValueChanged

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
                        Reader = Acc.GetRecord("SelectCities", "CityCode", Trim(TxtCityCode.Text))
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

        Private Sub TxtCityCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCityCode.ValueChanged

        End Sub
    End Class
End Namespace