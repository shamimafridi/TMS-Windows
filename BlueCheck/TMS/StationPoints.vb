Namespace Inventory
    Public Class StationPoints
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
        Friend WithEvents txtStationPointCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ATUrduTitle As ATUrduTextBox.UrduTextBox
        Friend WithEvents TxtRate As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StationPoints))
            Me.Label2 = New System.Windows.Forms.Label
            Me.dtpDate = New System.Windows.Forms.DateTimePicker
            Me.Label3 = New System.Windows.Forms.Label
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.txtStationPointCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label9 = New System.Windows.Forms.Label
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.Label1 = New System.Windows.Forms.Label
            Me.ATUrduTitle = New ATUrduTextBox.UrduTextBox
            Me.TxtRate = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label4 = New System.Windows.Forms.Label
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtStationPointCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ATUrduTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtRate, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(92, 260)
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
            Me.dtpDate.Location = New System.Drawing.Point(202, 260)
            Me.dtpDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.dtpDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.dtpDate.Name = "dtpDate"
            Me.dtpDate.Size = New System.Drawing.Size(138, 20)
            Me.dtpDate.TabIndex = 4
            Me.dtpDate.Tag = "dt.DefinitionDate"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.ForeColor = System.Drawing.Color.Navy
            Me.Label3.Location = New System.Drawing.Point(92, 152)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(110, 20)
            Me.Label3.TabIndex = 71
            Me.Label3.Text = "StationPoint Code"
            '
            'Desc
            '
            Me.Desc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Appearance = Appearance1
            Me.Desc.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Location = New System.Drawing.Point(202, 174)
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(510, 21)
            Me.Desc.TabIndex = 1
            Me.Desc.Tag = "IM.StationPointName"
            '
            'txtStationPointCode
            '
            Me.txtStationPointCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.txtStationPointCode.Appearance = Appearance2
            Me.txtStationPointCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtStationPointCode.Location = New System.Drawing.Point(202, 150)
            Me.txtStationPointCode.MaxLength = 3
            Me.txtStationPointCode.Name = "txtStationPointCode"
            Me.txtStationPointCode.Size = New System.Drawing.Size(138, 21)
            Me.txtStationPointCode.TabIndex = 0
            Me.txtStationPointCode.Tag = "PK.StationPointCode"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.ForeColor = System.Drawing.Color.Navy
            Me.Label9.Location = New System.Drawing.Point(92, 176)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(110, 20)
            Me.Label9.TabIndex = 70
            Me.Label9.Text = "StationPoint"
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
            Me.Label1.Location = New System.Drawing.Point(88, 196)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 47)
            Me.Label1.TabIndex = 110
            Me.Label1.Text = "علاقہ"
            '
            'ATUrduTitle
            '
            Me.ATUrduTitle.Font = Global.BusinessLeaf.My.MySettings.Default.UrduFontType
            Me.ATUrduTitle.Location = New System.Drawing.Point(202, 198)
            Me.ATUrduTitle.Name = "ATUrduTitle"
            Me.ATUrduTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.ATUrduTitle.Size = New System.Drawing.Size(214, 35)
            Me.ATUrduTitle.TabIndex = 2
            Me.ATUrduTitle.Tag = "dd.UrduTitle"
            '
            'TxtRate
            '
            Me.TxtRate.AccessibleDescription = "NoDecimal"
            Me.TxtRate.Location = New System.Drawing.Point(202, 236)
            Me.TxtRate.Name = "TxtRate"
            Me.TxtRate.Size = New System.Drawing.Size(138, 21)
            Me.TxtRate.TabIndex = 3
            Me.TxtRate.Tag = "kk.PointNo"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.ForeColor = System.Drawing.Color.Navy
            Me.Label4.Location = New System.Drawing.Point(92, 237)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(110, 20)
            Me.Label4.TabIndex = 112
            Me.Label4.Text = "Point No"
            '
            'StationPoints
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(804, 414)
            Me.Controls.Add(Me.TxtRate)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.ATUrduTitle)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpDate)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.txtStationPointCode)
            Me.Controls.Add(Me.Label9)
            Me.KeyPreview = True
            Me.MinimumSize = Global.BusinessLeaf.My.MySettings.Default.SetupFormMinimumSize
            Me.Name = "StationPoints"
            Me.Text = "StationPoint File"
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtStationPointCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ATUrduTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtRate, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private Sub txtStationPointCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtStationPointCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("StationPoints")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.txtStationPointCode.Text = frmser.UGSearch.Rows(iRow).Cells("StationPointCode").Value
                Me.Desc.Text = frmser.UGSearch.Rows(iRow).Cells("StationPointName").Value
                Me.txtStationPointCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtStationPointCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStationPointCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.txtStationPointCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub txtStationPointCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtStationPointCode.Validating
            If Trim(txtStationPointCode.Text) <> "" Then
                If Trim(txtStationPointCode.Text).Length <> txtStationPointCode.MaxLength Then
                    e.Cancel = True
                    ErrProvider.SetError(txtStationPointCode, " Please Enter a Proper length of Code ")
                End If
            End If

        End Sub
        Private Sub txtStationPointCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStationPointCode.Validated
            ErrProvider.SetError(txtStationPointCode, "")
        End Sub

        Private Sub StationPoints_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub

        Private Sub CmdStationPointList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub txtStationPointCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStationPointCode.TextChanged

        End Sub

        Private Sub txtStationPointCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStationPointCode.ValueChanged

        End Sub
    End Class

End Namespace