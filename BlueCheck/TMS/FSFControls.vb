Namespace GeneralLedger
    Public Class FSFControls
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
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtControlCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider

        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSFControls))
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label9 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpDate = New System.Windows.Forms.DateTimePicker
            Me.Label2 = New System.Windows.Forms.Label
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.TxtControlCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtControlCode, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Desc
            '
            Me.Desc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Desc.Location = New System.Drawing.Point(208, 174)
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(515, 21)
            Me.Desc.TabIndex = 1
            Me.Desc.Tag = "dd.ControlDescription"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.ForeColor = System.Drawing.Color.Navy
            Me.Label9.Location = New System.Drawing.Point(94, 176)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(110, 20)
            Me.Label9.TabIndex = 55
            Me.Label9.Text = "Control "
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(94, 152)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 57
            Me.Label1.Text = "Control Code"
            '
            'dtpDate
            '
            Me.dtpDate.AccessibleDescription = "Last"
            Me.dtpDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
            Me.dtpDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
            Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
            Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDate.Location = New System.Drawing.Point(208, 198)
            Me.dtpDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.dtpDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.dtpDate.Name = "dtpDate"
            Me.dtpDate.Size = New System.Drawing.Size(134, 20)
            Me.dtpDate.TabIndex = 2
            Me.dtpDate.Tag = "dt.DefinitionDate"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(94, 200)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 59
            Me.Label2.Text = "Definition Date"
            '
            'ErrProvider
            '
            Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
            Me.ErrProvider.ContainerControl = Me
            Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
            Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
            '
            'TxtControlCode
            '
            Me.TxtControlCode.AccessibleDescription = "AUTO"
            Me.TxtControlCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.TxtControlCode.Appearance = Appearance1
            Me.TxtControlCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtControlCode.Location = New System.Drawing.Point(208, 150)
            Me.TxtControlCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.FSFControlCode_Length
            Me.TxtControlCode.Name = "TxtControlCode"
            Me.TxtControlCode.Size = New System.Drawing.Size(134, 21)
            Me.TxtControlCode.TabIndex = 0
            Me.TxtControlCode.Tag = "PK.ControlCode"
            '
            'FSFControls
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(817, 350)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpDate)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.TxtControlCode)
            Me.Controls.Add(Me.Label9)
            Me.KeyPreview = True
            Me.MinimumSize = Global.BusinessLeaf.My.MySettings.Default.SetupFormMinimumSize
            Me.Name = "FSFControls"
            Me.Text = "FSF Control File"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtControlCode, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private Sub TxtControlCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtControlCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("FSFControls")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtControlCode.Text = frmser.UGSearch.Rows(iRow).Cells("ControlCode").Value
                Me.Desc.Text = frmser.UGSearch.Rows(iRow).Cells("ControlDescription").Value
                Me.TxtControlCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub


        Private Sub TxtControlCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtControlCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call TxtControlCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtControlCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtControlCode.Validating
            If Trim(TxtControlCode.Text) <> "" Then
                If Trim(TxtControlCode.Text).Length <> TxtControlCode.MaxLength Then
                    e.Cancel = True
                    ErrProvider.SetError(TxtControlCode, " Please Enter a Proper length of Code ")
                End If
            End If
        End Sub
        Private Sub TxtControlCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtControlCode.Validated
            ErrProvider.SetError(TxtControlCode, "")
        End Sub

        Private Sub CmdControlList_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub FSFControls_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub

        Private Sub TxtControlCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtControlCode.ValueChanged

        End Sub
    End Class
End Namespace