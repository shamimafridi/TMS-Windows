Namespace Inventory
    Public Class Divisions
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
        Friend WithEvents txtDivisionCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Divisions))
            Me.Label2 = New System.Windows.Forms.Label
            Me.dtpDate = New System.Windows.Forms.DateTimePicker
            Me.Label3 = New System.Windows.Forms.Label
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.txtDivisionCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label9 = New System.Windows.Forms.Label
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtDivisionCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(92, 200)
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
            Me.dtpDate.Location = New System.Drawing.Point(202, 198)
            Me.dtpDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.dtpDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.dtpDate.Name = "dtpDate"
            Me.dtpDate.Size = New System.Drawing.Size(130, 20)
            Me.dtpDate.TabIndex = 2
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
            Me.Label3.Text = "Division Code"
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
            Me.Desc.Tag = "FK.Division"
            '
            'txtDivisionCode
            '
            Me.txtDivisionCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.txtDivisionCode.Appearance = Appearance2
            Me.txtDivisionCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtDivisionCode.Location = New System.Drawing.Point(202, 150)
            Me.txtDivisionCode.MaxLength = 3
            Me.txtDivisionCode.Name = "txtDivisionCode"
            Me.txtDivisionCode.Size = New System.Drawing.Size(130, 21)
            Me.txtDivisionCode.TabIndex = 0
            Me.txtDivisionCode.Tag = "PK.DivisionCode"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.ForeColor = System.Drawing.Color.Navy
            Me.Label9.Location = New System.Drawing.Point(92, 176)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(110, 20)
            Me.Label9.TabIndex = 70
            Me.Label9.Text = "Division"
            '
            'ErrProvider
            '
            Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
            Me.ErrProvider.ContainerControl = Me
            Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
            Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
            '
            'Divisions
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(804, 414)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpDate)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.txtDivisionCode)
            Me.Controls.Add(Me.Label9)
            Me.KeyPreview = True
            Me.MinimumSize = Global.BusinessLeaf.My.MySettings.Default.SetupFormMinimumSize
            Me.Name = "Divisions"
            Me.Text = "Division File"
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtDivisionCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private Sub txtDivisionCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtDivisionCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Divisions")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.txtDivisionCode.Text = frmser.UGSearch.Rows(iRow).Cells("DivisionCode").Value
                Me.Desc.Text = frmser.UGSearch.Rows(iRow).Cells("Division").Value
                Me.txtDivisionCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtDivisionCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDivisionCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.txtDivisionCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtDivisionCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDivisionCode.Validating
            If Trim(txtDivisionCode.Text) <> "" Then
                If Trim(txtDivisionCode.Text).Length <> txtDivisionCode.MaxLength Then
                    e.Cancel = True
                    ErrProvider.SetError(txtDivisionCode, " Please Enter a Proper length of Code ")
                End If
            End If

        End Sub
        Private Sub txtDivisionCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDivisionCode.Validated
            ErrProvider.SetError(txtDivisionCode, "")
        End Sub

        Private Sub Divisions_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub

        Private Sub CmdDivisionList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub txtDivisionCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDivisionCode.ValueChanged

        End Sub
    End Class

End Namespace