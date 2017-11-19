Namespace GeneralLedger
    Public Class FSFSubsidiaries
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
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        Friend WithEvents lblGeneral As System.Windows.Forms.LinkLabel
        Friend WithEvents TxtGeneral As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtGeneralCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents txtSubsidiaryCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TxtControlDescription As Infragistics.Win.UltraWinEditors.UltraTextEditor
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FSFSubsidiaries))
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpDate = New System.Windows.Forms.DateTimePicker
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.lblGeneral = New System.Windows.Forms.LinkLabel
            Me.TxtGeneral = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtControlDescription = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label2 = New System.Windows.Forms.Label
            Me.TxtGeneralCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.txtSubsidiaryCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtControlDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtGeneralCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtSubsidiaryCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Location = New System.Drawing.Point(92, 187)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(110, 20)
            Me.Label6.TabIndex = 55
            Me.Label6.Text = "Subsidiary"
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Location = New System.Drawing.Point(92, 164)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(110, 20)
            Me.Label8.TabIndex = 53
            Me.Label8.Text = "Subsidiary Code"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(92, 210)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 58
            Me.Label1.Text = "Definition Date"
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
            Me.dtpDate.Location = New System.Drawing.Point(202, 210)
            Me.dtpDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.dtpDate.MaximumSize = New System.Drawing.Size(100, 20)
            Me.dtpDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.dtpDate.Name = "dtpDate"
            Me.dtpDate.Size = New System.Drawing.Size(100, 20)
            Me.dtpDate.TabIndex = 3
            Me.dtpDate.Tag = "dt.DefinitionDate"
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
            Me.lblGeneral.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lblGeneral.Location = New System.Drawing.Point(92, 142)
            Me.lblGeneral.Name = "lblGeneral"
            Me.lblGeneral.Size = New System.Drawing.Size(110, 20)
            Me.lblGeneral.TabIndex = 88
            Me.lblGeneral.TabStop = True
            Me.lblGeneral.Text = "General"
            '
            'TxtGeneral
            '
            Me.TxtGeneral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtGeneral.Location = New System.Drawing.Point(327, 142)
            Me.TxtGeneral.Name = "TxtGeneral"
            Me.TxtGeneral.Size = New System.Drawing.Size(583, 21)
            Me.TxtGeneral.TabIndex = 7
            Me.TxtGeneral.TabStop = False
            Me.TxtGeneral.Tag = "dd.GeneralDescription"
            '
            'TxtControlDescription
            '
            Me.TxtControlDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtControlDescription.Location = New System.Drawing.Point(202, 116)
            Me.TxtControlDescription.MaxLength = 100
            Me.TxtControlDescription.Name = "TxtControlDescription"
            Me.TxtControlDescription.Size = New System.Drawing.Size(714, 21)
            Me.TxtControlDescription.TabIndex = 4
            Me.TxtControlDescription.TabStop = False
            Me.TxtControlDescription.Tag = "dd.ControlDescription"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Location = New System.Drawing.Point(92, 119)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 90
            Me.Label2.Text = "Control Description"
            '
            'TxtGeneralCode
            '
            Me.TxtGeneralCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.TxtGeneralCode.Appearance = Appearance1
            Me.TxtGeneralCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtGeneralCode.DataBindings.Add(New System.Windows.Forms.Binding("MaxLength", Global.BusinessLeaf.My.MySettings.Default, "FSFGeneralCodeFK_Length", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.TxtGeneralCode.Location = New System.Drawing.Point(202, 142)
            Me.TxtGeneralCode.MaximumSize = New System.Drawing.Size(200, 20)
            Me.TxtGeneralCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.FSFGeneralCodeFK_Length
            Me.TxtGeneralCode.Name = "TxtGeneralCode"
            Me.TxtGeneralCode.Size = New System.Drawing.Size(125, 20)
            Me.TxtGeneralCode.TabIndex = 0
            Me.TxtGeneralCode.Tag = "PK.GeneralCode"
            '
            'txtSubsidiaryCode
            '
            Me.txtSubsidiaryCode.AccessibleDescription = "AUTO"
            Me.txtSubsidiaryCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.txtSubsidiaryCode.Appearance = Appearance2
            Me.txtSubsidiaryCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtSubsidiaryCode.Location = New System.Drawing.Point(202, 164)
            Me.txtSubsidiaryCode.MaximumSize = New System.Drawing.Size(200, 20)
            Me.txtSubsidiaryCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.FSFSubSubsidiaryCode_Length
            Me.txtSubsidiaryCode.Name = "txtSubsidiaryCode"
            Me.txtSubsidiaryCode.Size = New System.Drawing.Size(125, 20)
            Me.txtSubsidiaryCode.TabIndex = 1
            Me.txtSubsidiaryCode.Tag = "PK.SubsidiaryCode"
            '
            'Desc
            '
            Me.Desc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance3.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Appearance = Appearance3
            Me.Desc.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Location = New System.Drawing.Point(202, 187)
            Me.Desc.MaxLength = 50
            Me.Desc.MinimumSize = Global.BusinessLeaf.My.MySettings.Default.SetupFormMinimumSize
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(714, 21)
            Me.Desc.TabIndex = 2
            Me.Desc.Tag = "FK.SubsidiaryDescription"
            '
            'FSFSubsidiaries
            '
            Me.AccessibleName = "FSFSubsidiaries"
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(1008, 413)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.TxtControlDescription)
            Me.Controls.Add(Me.lblGeneral)
            Me.Controls.Add(Me.TxtGeneral)
            Me.Controls.Add(Me.TxtGeneralCode)
            Me.Controls.Add(Me.txtSubsidiaryCode)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.dtpDate)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label8)
            Me.KeyPreview = True
            Me.MinimumSize = New System.Drawing.Size(310, 0)
            Me.Name = "FSFSubsidiaries"
            Me.Text = "FSF Subsidiary Files"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtGeneral, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtControlDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtGeneralCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtSubsidiaryCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private Sub txtSubsidiaryCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtSubsidiaryCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("FSFSubsidiaries")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.txtSubsidiaryCode.Text = frmser.UGSearch.Rows(iRow).Cells("SubsidiaryCode").Value
                Me.TxtGeneralCode.Text = frmser.UGSearch.Rows(iRow).Cells("GeneralCode").Value
                Me.TxtGeneral.Text = frmser.UGSearch.Rows(iRow).Cells("GeneralDescription").Value
                Me.TxtControlDescription.Text = frmser.UGSearch.Rows(iRow).Cells("ControlCode").Value & " - " & frmser.UGSearch.Rows(iRow).Cells("ControlDescription").Value
                Me.txtSubsidiaryCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtSubsidiaryCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSubsidiaryCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.txtSubsidiaryCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub txtItemCode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubsidiaryCode.Validated
            'ErrProvider.SetError(txtItemCode, "")
        End Sub

        Private Sub TxtGeneralCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtGeneralCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.SearchParameter = FrmSearch.SearchGridParamType.SearchForChild
                frmser.FillData("FSFGenerals")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtGeneralCode.Text = frmser.UGSearch.Rows(iRow).Cells("GeneralCode").Value
                Me.TxtGeneral.Text = frmser.UGSearch.Rows(iRow).Cells("GeneralDescription").Value
                Me.TxtControlDescription.Text = frmser.UGSearch.Rows(iRow).Cells("ControlCode").Value & " - " & frmser.UGSearch.Rows(iRow).Cells("ControlDescription").Value
                Me.TxtGeneralCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtGeneralCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtGeneralCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtGeneralCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub


        Private Sub CmdGeneralList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub
        Private Sub CmdSubsidiaryList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub FSFSubsidiaries_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub

        Private Sub TxtGeneralCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtGeneralCode.Validating
            If Trim(TxtGeneralCode.Text) <> "" Then
                Dim mdi As frmMain
                If Trim(TxtGeneralCode.Text).Length <> TxtGeneralCode.MaxLength Then
                    ErrProvider.SetIconAlignment(TxtGeneralCode, ErrorIconAlignment.MiddleLeft)
                    ErrProvider.SetError(TxtGeneralCode, " Please Enter a Proper length of Code ")
                    Me.Focus()
                    TxtGeneralCode.Focus()
                Else
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader
                    'Reader = Acc.GetRecord("SelectFSFGenerals", "GeneralCode ", Trim(TxtGeneralCode.Text))
                    Reader = Acc.GetRecord("SelectFSFGenerals", "ControlCode", Trim(Mid(Me.TxtGeneralCode.Text, 1, My.Settings.FSFControlCode_Length)), "GeneralCode", Trim(Mid(Me.TxtGeneralCode.Text, My.Settings.FSFControlCode_Length + 1, My.Settings.FSFGeneralCode_Length + 1)))
                    Try
                        If Reader.HasRows = False Then
                            ErrProvider.SetError(TxtGeneralCode, "Invalid General Code")
                            ErrProvider.SetIconAlignment(TxtGeneralCode, ErrorIconAlignment.MiddleLeft)
                            mdi = Me.MdiParent
                            ' mdi.SldSearch.LookForSearch(TxtGeneralCode, TxtGeneral, TxtGeneralCode.Text, "GeneralCode", "FSFGenerals")
                            TxtGeneral.Text = ""
                            TxtControlDescription.Text = ""
                            TxtGeneralCode.Focus()
                        Else
                            mdi = Me.MdiParent
                            Reader.Read()
                            TxtControlDescription.Text() = Reader.Item("ControlDescription")
                            TxtGeneral.Text = Reader.Item("GeneralDescription")
                            ErrProvider.SetError(TxtGeneralCode, "")
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                'Else
                '    e.Cancel = True
                '    ErrProvider.SetError(TxtGeneralCode, " Empty Code is not Allowed " & vbCrLf & " Please Enter a Proper length of Code ")
            End If
        End Sub

        Private Sub TxtGeneralCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtGeneralCode.ValueChanged

        End Sub

        Private Sub txtSubsidiaryCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubsidiaryCode.ValueChanged

        End Sub
    End Class
End Namespace