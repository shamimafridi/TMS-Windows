Namespace GeneralLedger
    Public Class COASubSubsidiaries
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
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        Friend WithEvents lblSubsidary As System.Windows.Forms.LinkLabel
        Friend WithEvents TxtSubSubsidiaryCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtSubidiaryDescription As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtSubsidiaryCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents TxtGeneralDescription As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
        Friend WithEvents TxtFSFGLCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtFSFGLDesc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtControlDescription As Infragistics.Win.UltraWinEditors.UltraTextEditor
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COASubSubsidiaries))
            Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.TxtSubSubsidiaryCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpDate = New System.Windows.Forms.DateTimePicker
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.TxtSubidiaryDescription = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtSubsidiaryCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.lblSubsidary = New System.Windows.Forms.LinkLabel
            Me.TxtGeneralDescription = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtControlDescription = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
            Me.TxtFSFGLCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtFSFGLDesc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            CType(Me.TxtSubSubsidiaryCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtSubidiaryDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtSubsidiaryCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtGeneralDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtControlDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtFSFGLCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtFSFGLDesc, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Location = New System.Drawing.Point(92, 221)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(110, 20)
            Me.Label6.TabIndex = 55
            Me.Label6.Text = "Sub Subsidiary"
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.Location = New System.Drawing.Point(92, 197)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(110, 20)
            Me.Label8.TabIndex = 53
            Me.Label8.Text = "Sub Subsidiary Code"
            '
            'TxtSubSubsidiaryCode
            '
            Me.TxtSubSubsidiaryCode.AccessibleDescription = "AUTO"
            Me.TxtSubSubsidiaryCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.TxtSubSubsidiaryCode.Appearance = Appearance1
            Me.TxtSubSubsidiaryCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtSubSubsidiaryCode.Location = New System.Drawing.Point(202, 194)
            Me.TxtSubSubsidiaryCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.SubSubsidiaryCode_Length
            Me.TxtSubSubsidiaryCode.Name = "TxtSubSubsidiaryCode"
            Me.TxtSubSubsidiaryCode.Size = New System.Drawing.Size(125, 21)
            Me.TxtSubSubsidiaryCode.TabIndex = 1
            Me.TxtSubSubsidiaryCode.Tag = "PK.SubSubsidiaryCode"
            '
            'Desc
            '
            Me.Desc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Appearance = Appearance2
            Me.Desc.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Location = New System.Drawing.Point(202, 218)
            Me.Desc.MaxLength = 50
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(510, 21)
            Me.Desc.TabIndex = 2
            Me.Desc.Tag = "IM.SubSubsidiaryDescription"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(92, 245)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 58
            Me.Label1.Text = "Definition Date"
            '
            'dtpDate
            '
            Me.dtpDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
            Me.dtpDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
            Me.dtpDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
            Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDate.Location = New System.Drawing.Point(202, 242)
            Me.dtpDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.dtpDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.dtpDate.Name = "dtpDate"
            Me.dtpDate.Size = New System.Drawing.Size(125, 20)
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
            'TxtSubidiaryDescription
            '
            Me.TxtSubidiaryDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtSubidiaryDescription.Location = New System.Drawing.Point(327, 170)
            Me.TxtSubidiaryDescription.Name = "TxtSubidiaryDescription"
            Me.TxtSubidiaryDescription.Size = New System.Drawing.Size(385, 21)
            Me.TxtSubidiaryDescription.TabIndex = 8
            Me.TxtSubidiaryDescription.TabStop = False
            Me.TxtSubidiaryDescription.Tag = "dd.SubsidiaryDescription"
            '
            'TxtSubsidiaryCode
            '
            Me.TxtSubsidiaryCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance4.BackColor = System.Drawing.SystemColors.Window
            Me.TxtSubsidiaryCode.Appearance = Appearance4
            Me.TxtSubsidiaryCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtSubsidiaryCode.DataBindings.Add(New System.Windows.Forms.Binding("MaxLength", Global.BusinessLeaf.My.MySettings.Default, "SubsidiaryCodeFK_Length", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.TxtSubsidiaryCode.Location = New System.Drawing.Point(202, 170)
            Me.TxtSubsidiaryCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.SubsidiaryCodeFK_Length
            Me.TxtSubsidiaryCode.Name = "TxtSubsidiaryCode"
            Me.TxtSubsidiaryCode.Size = New System.Drawing.Size(125, 21)
            Me.TxtSubsidiaryCode.TabIndex = 0
            Me.TxtSubsidiaryCode.Tag = "PK.SubsidiaryCode1"
            '
            'lblSubsidary
            '
            Me.lblSubsidary.BackColor = System.Drawing.Color.Transparent
            Me.lblSubsidary.ForeColor = System.Drawing.Color.Navy
            Me.lblSubsidary.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lblSubsidary.Location = New System.Drawing.Point(92, 170)
            Me.lblSubsidary.Name = "lblSubsidary"
            Me.lblSubsidary.Size = New System.Drawing.Size(110, 20)
            Me.lblSubsidary.TabIndex = 92
            Me.lblSubsidary.TabStop = True
            Me.lblSubsidary.Text = "Subsidiary"
            '
            'TxtGeneralDescription
            '
            Me.TxtGeneralDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtGeneralDescription.Location = New System.Drawing.Point(202, 146)
            Me.TxtGeneralDescription.Name = "TxtGeneralDescription"
            Me.TxtGeneralDescription.Size = New System.Drawing.Size(510, 21)
            Me.TxtGeneralDescription.TabIndex = 5
            Me.TxtGeneralDescription.TabStop = False
            Me.TxtGeneralDescription.Tag = "dd.GeneralDescription"
            '
            'TxtControlDescription
            '
            Me.TxtControlDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtControlDescription.Location = New System.Drawing.Point(202, 122)
            Me.TxtControlDescription.Name = "TxtControlDescription"
            Me.TxtControlDescription.Size = New System.Drawing.Size(510, 21)
            Me.TxtControlDescription.TabIndex = 4
            Me.TxtControlDescription.TabStop = False
            Me.TxtControlDescription.Tag = "dd.ControlDescription"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Location = New System.Drawing.Point(92, 122)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 95
            Me.Label2.Text = "Control Description"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Location = New System.Drawing.Point(92, 146)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(110, 20)
            Me.Label3.TabIndex = 96
            Me.Label3.Text = "General Description"
            '
            'LinkLabel1
            '
            Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
            Me.LinkLabel1.ForeColor = System.Drawing.Color.Navy
            Me.LinkLabel1.Location = New System.Drawing.Point(92, 271)
            Me.LinkLabel1.Name = "LinkLabel1"
            Me.LinkLabel1.Size = New System.Drawing.Size(110, 20)
            Me.LinkLabel1.TabIndex = 105
            Me.LinkLabel1.TabStop = True
            Me.LinkLabel1.Text = "FSF Code"
            '
            'TxtFSFGLCode
            '
            Me.TxtFSFGLCode.AccessibleDescription = "Last"
            Me.TxtFSFGLCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance3.BackColor = System.Drawing.SystemColors.Window
            Me.TxtFSFGLCode.Appearance = Appearance3
            Me.TxtFSFGLCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtFSFGLCode.Location = New System.Drawing.Point(202, 265)
            Me.TxtFSFGLCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.FSFGLCode
            Me.TxtFSFGLCode.Name = "TxtFSFGLCode"
            Me.TxtFSFGLCode.Size = New System.Drawing.Size(125, 21)
            Me.TxtFSFGLCode.TabIndex = 102
            Me.TxtFSFGLCode.Tag = "FK.FSFGLCode"
            '
            'TxtFSFGLDesc
            '
            Me.TxtFSFGLDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtFSFGLDesc.Location = New System.Drawing.Point(327, 265)
            Me.TxtFSFGLDesc.Name = "TxtFSFGLDesc"
            Me.TxtFSFGLDesc.Size = New System.Drawing.Size(385, 21)
            Me.TxtFSFGLDesc.TabIndex = 104
            Me.TxtFSFGLDesc.TabStop = False
            Me.TxtFSFGLDesc.Tag = "dd.FSFGLDescription"
            '
            'COASubSubsidiaries
            '
            Me.AccessibleName = "COASubSubsidiaries"
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(804, 413)
            Me.Controls.Add(Me.LinkLabel1)
            Me.Controls.Add(Me.TxtFSFGLCode)
            Me.Controls.Add(Me.TxtFSFGLDesc)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.TxtControlDescription)
            Me.Controls.Add(Me.TxtGeneralDescription)
            Me.Controls.Add(Me.lblSubsidary)
            Me.Controls.Add(Me.TxtSubidiaryDescription)
            Me.Controls.Add(Me.TxtSubsidiaryCode)
            Me.Controls.Add(Me.dtpDate)
            Me.Controls.Add(Me.TxtSubSubsidiaryCode)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label8)
            Me.KeyPreview = True
            Me.MinimumSize = Global.BusinessLeaf.My.MySettings.Default.SetupFormMinimumSize
            Me.Name = "COASubSubsidiaries"
            Me.Text = "COA Sub Subsidiary File"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.TxtSubSubsidiaryCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtSubidiaryDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtSubsidiaryCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtGeneralDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtControlDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtFSFGLCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtFSFGLDesc, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private Sub TxtSubsidiaryCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtSubsidiaryCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.SearchParameter = FrmSearch.SearchGridParamType.SearchForChild
                frmser.FillData("COASubsidiaries")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtSubsidiaryCode.Text = frmser.UGSearch.Rows(iRow).Cells("SubsidiaryCode").Value
                Me.TxtSubidiaryDescription.Text = frmser.UGSearch.Rows(iRow).Cells("SubsidiaryDescription").Value
                Me.TxtGeneralDescription.Text = frmser.UGSearch.Rows(iRow).Cells("GeneralCode").Value & " - " & frmser.UGSearch.Rows(iRow).Cells("GeneralDescription").Value
                Me.TxtControlDescription.Text = frmser.UGSearch.Rows(iRow).Cells("ControlCode").Value & " - " & frmser.UGSearch.Rows(iRow).Cells("ControlDescription").Value
                Me.TxtSubsidiaryCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtSubsidiaryCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSubsidiaryCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call TxtSubsidiaryCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub COASubSubsidiaries_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub
        Private Sub BtnFSFGLList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("FSFCombine")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtFSFGLCode.Text = frmser.UGSearch.Rows(iRow).Cells("GLCode").Value
                Me.TxtFSFGLDesc.Text = frmser.UGSearch.Rows(iRow).Cells("GLDescription").Value
                Me.TxtFSFGLCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtSubSubsidiaryCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtSubSubsidiaryCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("COASubSubsidiaries")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtSubSubsidiaryCode.Text = frmser.UGSearch.Rows(iRow).Cells("SubSubsidiaryCode").Value
                Me.TxtSubsidiaryCode.Text = frmser.UGSearch.Rows(iRow).Cells("ControlCode").Value & frmser.UGSearch.Rows(iRow).Cells("GeneralCode").Value & frmser.UGSearch.Rows(iRow).Cells("SubsidiaryCode").Value
                Me.TxtSubidiaryDescription.Text = frmser.UGSearch.Rows(iRow).Cells("GeneralDescription").Value
                Me.TxtGeneralDescription.Text = frmser.UGSearch.Rows(iRow).Cells("GeneralCode").Value & " - " & frmser.UGSearch.Rows(iRow).Cells("GeneralDescription").Value
                Me.TxtControlDescription.Text = frmser.UGSearch.Rows(iRow).Cells("ControlCode").Value & " - " & frmser.UGSearch.Rows(iRow).Cells("ControlDescription").Value
                Me.TxtSubSubsidiaryCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub


        Private Sub TxtFSFGLCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtFSFGLCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("FSFCombine")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtFSFGLCode.Text = frmser.UGSearch.Rows(iRow).Cells("GLCode").Value
                Me.TxtFSFGLDesc.Text = frmser.UGSearch.Rows(iRow).Cells("GLDescription").Value
                Me.TxtFSFGLCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtFSFGLCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFSFGLCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call TxtFSFGLCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub TxtSubSubsidiaryCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSubSubsidiaryCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call TxtSubSubsidiaryCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Private Sub TxtSubsidiaryCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtSubsidiaryCode.Validating
            If Trim(TxtSubsidiaryCode.Text) <> "" Then
                Dim mdi As frmMain
                If Trim(TxtSubsidiaryCode.Text).Length <> TxtSubsidiaryCode.MaxLength Then
                    ErrProvider.SetIconAlignment(TxtSubsidiaryCode, ErrorIconAlignment.MiddleLeft)
                    ErrProvider.SetError(TxtSubsidiaryCode, " Please Enter a Proper length of Code ")
                    Me.Focus()
                    TxtSubsidiaryCode.Focus()
                Else
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader
                    Reader = Acc.GetRecord("SelectCOASubsidiaries", "GeneralCode", Trim(Mid(Me.TxtSubsidiaryCode.Text, 1, My.Settings.GeneralCodeFK_Length)), "SubsidiaryCode ", Trim(Mid(TxtSubsidiaryCode.Text, My.Settings.GeneralCodeFK_Length + 1, My.Settings.SubsidiaryCode_Length)))
                    Try
                        If Reader.HasRows = False Then
                            ErrProvider.SetError(TxtSubsidiaryCode, "Invalid Subsidiary Code")
                            ErrProvider.SetIconAlignment(TxtSubsidiaryCode, ErrorIconAlignment.MiddleLeft)
                            mdi = Me.MdiParent
                            ' mdi.SldSearch.LookForSearch(TxtSubsidiaryCode, TxtSubSubidiaryDescription, TxtSubsidiaryCode.Text, "SubsidiaryCode", "COASubsidiaries")
                            TxtSubidiaryDescription.Text = ""
                            TxtControlDescription.Text = ""
                            TxtGeneralDescription.Text = ""
                            TxtSubsidiaryCode.Focus()

                        Else
                            mdi = Me.MdiParent
                            Reader.Read()
                            TxtSubidiaryDescription.Text = Reader.Item("SubsidiaryDescription")
                            TxtControlDescription.Text = Reader.Item("ControlDescription")
                            TxtGeneralDescription.Text = Reader.Item("GeneralDescription")
                            ErrProvider.SetError(TxtSubsidiaryCode, "")
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                'Else
                '    e.Cancel = True
                '    ErrProvider.SetError(TxtSubsidiaryCode, " Empty Code is not Allowed " & vbCrLf & " Please Enter a Proper length of Code ")
            End If
        End Sub


        Private Sub TxtFSFGLCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFSFGLCode.ValueChanged

        End Sub
    End Class
End Namespace