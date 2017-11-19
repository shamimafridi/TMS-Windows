Namespace GeneralLedger
    Public Class FSFGenerals
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
        Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        Friend WithEvents lblGeneral As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TxtControl As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents lblControl As System.Windows.Forms.LinkLabel
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtControlCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtGeneralCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSFGenerals))
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Me.dtpDate = New System.Windows.Forms.DateTimePicker
            Me.Label2 = New System.Windows.Forms.Label
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.lblGeneral = New System.Windows.Forms.Label
            Me.TxtControl = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtControlCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtGeneralCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label1 = New System.Windows.Forms.Label
            Me.lblControl = New System.Windows.Forms.LinkLabel
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtControlCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtGeneralCode, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            Me.dtpDate.Location = New System.Drawing.Point(204, 198)
            Me.dtpDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.dtpDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.dtpDate.Name = "dtpDate"
            Me.dtpDate.Size = New System.Drawing.Size(100, 20)
            Me.dtpDate.TabIndex = 3
            Me.dtpDate.Tag = "dt.DefinitionDate"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(91, 197)
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
            'lblGeneral
            '
            Me.lblGeneral.BackColor = System.Drawing.Color.Transparent
            Me.lblGeneral.ForeColor = System.Drawing.Color.Navy
            Me.lblGeneral.Location = New System.Drawing.Point(91, 173)
            Me.lblGeneral.Name = "lblGeneral"
            Me.lblGeneral.Size = New System.Drawing.Size(110, 20)
            Me.lblGeneral.TabIndex = 94
            Me.lblGeneral.TabStop = True
            Me.lblGeneral.Text = "General"
            '
            'TxtControl
            '
            Me.TxtControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtControl.Location = New System.Drawing.Point(329, 124)
            Me.TxtControl.Name = "TxtControl"
            Me.TxtControl.Size = New System.Drawing.Size(379, 21)
            Me.TxtControl.TabIndex = 6
            Me.TxtControl.TabStop = False
            Me.TxtControl.Tag = "dd.ControlDescription"
            '
            'Desc
            '
            Me.Desc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Appearance = Appearance2
            Me.Desc.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Location = New System.Drawing.Point(204, 174)
            Me.Desc.MinimumSize = Global.BusinessLeaf.My.MySettings.Default.SetupFormMinimumSize
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(510, 21)
            Me.Desc.TabIndex = 2
            Me.Desc.Tag = "DD.GeneralDescription"
            '
            'TxtControlCode
            '
            Me.TxtControlCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.TxtControlCode.Appearance = Appearance1
            Me.TxtControlCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtControlCode.Location = New System.Drawing.Point(204, 124)
            Me.TxtControlCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.FSFControlCode_Length
            Me.TxtControlCode.Name = "TxtControlCode"
            Me.TxtControlCode.Size = New System.Drawing.Size(125, 21)
            Me.TxtControlCode.TabIndex = 0
            Me.TxtControlCode.Tag = "PK.ControlCode"
            '
            'TxtGeneralCode
            '
            Me.TxtGeneralCode.AccessibleDescription = "AUTO"
            Me.TxtGeneralCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.TxtGeneralCode.Location = New System.Drawing.Point(204, 150)
            Me.TxtGeneralCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.FSFGeneralCode_Length
            Me.TxtGeneralCode.Name = "TxtGeneralCode"
            Me.TxtGeneralCode.Size = New System.Drawing.Size(125, 21)
            Me.TxtGeneralCode.TabIndex = 1
            Me.TxtGeneralCode.TabStop = False
            Me.TxtGeneralCode.Tag = "PK.GeneralCode"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(91, 153)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 96
            Me.Label1.Text = "General Code"
            '
            'lblControl
            '
            Me.lblControl.BackColor = System.Drawing.Color.Transparent
            Me.lblControl.ForeColor = System.Drawing.Color.Navy
            Me.lblControl.Location = New System.Drawing.Point(91, 127)
            Me.lblControl.Name = "lblControl"
            Me.lblControl.Size = New System.Drawing.Size(110, 20)
            Me.lblControl.TabIndex = 97
            Me.lblControl.TabStop = True
            Me.lblControl.Text = "Control"
            '
            'FSFGenerals
            '
            Me.AccessibleName = "FSFGenerals"
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(804, 494)
            Me.Controls.Add(Me.lblControl)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TxtControlCode)
            Me.Controls.Add(Me.TxtGeneralCode)
            Me.Controls.Add(Me.lblGeneral)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.TxtControl)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpDate)
            Me.KeyPreview = True
            Me.MinimumSize = Global.BusinessLeaf.My.MySettings.Default.SetupFormMinimumSize
            Me.Name = "FSFGenerals"
            Me.Text = "FSF General File"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtControlCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtGeneralCode, System.ComponentModel.ISupportInitialize).EndInit()
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
                Me.TxtControl.Text = frmser.UGSearch.Rows(iRow).Cells("ControlDescription").Value
                Me.TxtControlCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtControlCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtControlCode.KeyDown

            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtControlCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End Sub
        Private Sub CmdControlList_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub CmdGeneralCodeList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub TxtGeneralCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtGeneralCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData(Me.Name)
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtGeneralCode.Text = frmser.UGSearch.Rows(iRow).Cells("GeneralCode").Value
                Me.TxtControlCode.Text = frmser.UGSearch.Rows(iRow).Cells("ControlCode").Value
                Me.TxtControl.Text = frmser.UGSearch.Rows(iRow).Cells("ControlDescription").Value
                Me.TxtGeneralCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtGeneralCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtGeneralCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtControlCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub FSFGenerals_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub

        Private Sub TxtControlCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtControlCode.TextChanged

        End Sub

        Private Sub TxtControlCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtControlCode.Validating
            If Trim(TxtControlCode.Text) <> "" Then
                Dim mdi As frmMain
                If Trim(TxtControlCode.Text).Length <> TxtControlCode.MaxLength Then
                    ErrProvider.SetIconAlignment(TxtControlCode, ErrorIconAlignment.MiddleLeft)
                    ErrProvider.SetError(TxtControlCode, " Please Enter a Proper length of Code ")
                    Me.Focus()
                    TxtControlCode.Focus()
                Else
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader
                    Reader = Acc.GetRecord("SelectFSFControls", "ControlCode", Trim(TxtControlCode.Text))
                    Try
                        If Reader.HasRows = False Then
                            ErrProvider.SetError(TxtControlCode, "Invalid Control Code")
                            ErrProvider.SetIconAlignment(TxtControlCode, ErrorIconAlignment.MiddleLeft)
                            mdi = Me.MdiParent
                            ' mdi.SldSearch.LookForSearch(TxtControlCode, TxtControl, TxtControlCode.Text, "ControlCode", "FSFControls")
                            TxtControl.Text = ""
                            TxtControlCode.Focus()
                        Else
                            mdi = Me.MdiParent
                            Reader.Read()
                            TxtControl.Text = Reader.Item("ControlDescription")
                            ErrProvider.SetError(TxtControlCode, "")
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                'Else
                '    e.Cancel = True
                '    ErrProvider.SetError(TxtControlCode, " Empty Code is not Allowed " & vbCrLf & " Please Enter a Proper length of Code ")
            End If
        End Sub

        Private Sub TxtControlCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtControlCode.ValueChanged

        End Sub

        Private Sub CmdGeneralCodeList_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub TxtGeneralCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtGeneralCode.ValueChanged

        End Sub
    End Class
End Namespace