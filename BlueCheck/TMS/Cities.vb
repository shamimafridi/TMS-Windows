Namespace Inventory
    Public Class Cities
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
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents txtCityCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ATUrduTitle As ATUrduTextBox.UrduTextBox
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cities))
            Me.Label2 = New System.Windows.Forms.Label
            Me.dtpDate = New System.Windows.Forms.DateTimePicker
            Me.Label3 = New System.Windows.Forms.Label
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.txtCityCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label9 = New System.Windows.Forms.Label
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.Label1 = New System.Windows.Forms.Label
            Me.ATUrduTitle = New ATUrduTextBox.UrduTextBox
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtCityCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ATUrduTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(94, 237)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 74
            Me.Label2.Text = "Definition Date"
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
            Me.dtpDate.Location = New System.Drawing.Point(204, 236)
            Me.dtpDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.dtpDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.dtpDate.Name = "dtpDate"
            Me.dtpDate.Size = New System.Drawing.Size(100, 20)
            Me.dtpDate.TabIndex = 3
            Me.dtpDate.Tag = "dt.DefinitionDate"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.ForeColor = System.Drawing.Color.Navy
            Me.Label3.Location = New System.Drawing.Point(94, 152)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(110, 20)
            Me.Label3.TabIndex = 71
            Me.Label3.Text = "City Code"
            '
            'Desc
            '
            Me.Desc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Appearance = Appearance1
            Me.Desc.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Location = New System.Drawing.Point(204, 174)
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(510, 21)
            Me.Desc.TabIndex = 1
            Me.Desc.Tag = "IM.City"
            '
            'txtCityCode
            '
            Me.txtCityCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.txtCityCode.Appearance = Appearance2
            Me.txtCityCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtCityCode.Location = New System.Drawing.Point(204, 150)
            Me.txtCityCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.CityCode_Length
            Me.txtCityCode.Name = "txtCityCode"
            Me.txtCityCode.Size = New System.Drawing.Size(131, 21)
            Me.txtCityCode.TabIndex = 0
            Me.txtCityCode.Tag = "PK.CityCode"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.ForeColor = System.Drawing.Color.Navy
            Me.Label9.Location = New System.Drawing.Point(94, 176)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(110, 20)
            Me.Label9.TabIndex = 70
            Me.Label9.Text = "City"
            '
            'ErrProvider
            '
            Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
            Me.ErrProvider.ContainerControl = Me
            Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
            Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = Global.BusinessLeaf.My.MySettings.Default.UrduFontType
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(90, 196)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 37)
            Me.Label1.TabIndex = 112
            Me.Label1.Text = "شہر"
            '
            'ATUrduTitle
            '
            Me.ATUrduTitle.Font = Global.BusinessLeaf.My.MySettings.Default.UrduFontType
            Me.ATUrduTitle.Location = New System.Drawing.Point(204, 198)
            Me.ATUrduTitle.Name = "ATUrduTitle"
            Me.ATUrduTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.ATUrduTitle.Size = New System.Drawing.Size(214, 35)
            Me.ATUrduTitle.TabIndex = 2
            Me.ATUrduTitle.Tag = "dd.UrduTitle"
            '
            'Cities
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(804, 414)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.ATUrduTitle)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpDate)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.txtCityCode)
            Me.Controls.Add(Me.Label9)
            Me.KeyPreview = True
            Me.MinimumSize = Global.BusinessLeaf.My.MySettings.Default.SetupFormMinimumSize
            Me.Name = "Cities"
            Me.Text = "City File"
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtCityCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ATUrduTitle, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private Sub txtCityCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtCityCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Cities")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.txtCityCode.Text = frmser.UGSearch.Rows(iRow).Cells("CityCode").Value()
                Me.Desc.Text = frmser.UGSearch.Rows(iRow).Cells("City").Value
                Me.txtCityCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtCityCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCityCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.txtCityCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtCityCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCityCode.Validating
            If Trim(txtCityCode.Text) <> String.Empty Then
                If Trim(txtCityCode.Text).Length <> txtCityCode.MaxLength Then
                    e.Cancel = True
                    ErrProvider.SetError(txtCityCode, " Please Enter a Proper length of Code ")
                End If
            End If

        End Sub
        Private Sub txtCityCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCityCode.Validated
            ErrProvider.SetError(txtCityCode, "")
        End Sub

        Private Sub Cities_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub

        Private Sub CmdCityList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub UltraTextEditor1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub txtCityCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCityCode.ValueChanged

        End Sub
    End Class

End Namespace