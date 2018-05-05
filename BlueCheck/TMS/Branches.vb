Namespace GeneralLedger
    Public Class Branches
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
        Friend WithEvents txtBranchCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtFreightGLDesc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtFreightGLCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.dtpDate = New System.Windows.Forms.DateTimePicker()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.txtBranchCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.TxtFreightGLDesc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.TxtFreightGLCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtBranchCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtFreightGLDesc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtFreightGLCode, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(40, 219)
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
            Me.dtpDate.Location = New System.Drawing.Point(150, 217)
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
            Me.Label3.Location = New System.Drawing.Point(40, 152)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(110, 20)
            Me.Label3.TabIndex = 71
            Me.Label3.Text = "Branch Code"
            '
            'Desc
            '
            Me.Desc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Appearance = Appearance1
            Me.Desc.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Location = New System.Drawing.Point(150, 174)
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(510, 21)
            Me.Desc.TabIndex = 1
            Me.Desc.Tag = "FK.BranchName"
            '
            'txtBranchCode
            '
            Me.txtBranchCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchCode.Appearance = Appearance2
            Me.txtBranchCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchCode.Location = New System.Drawing.Point(150, 150)
            Me.txtBranchCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.BranchCode_Length
            Me.txtBranchCode.Name = "txtBranchCode"
            Me.txtBranchCode.Size = New System.Drawing.Size(132, 21)
            Me.txtBranchCode.TabIndex = 0
            Me.txtBranchCode.Tag = "PK.BranchCode"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.ForeColor = System.Drawing.Color.Navy
            Me.Label9.Location = New System.Drawing.Point(40, 176)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(110, 20)
            Me.Label9.TabIndex = 70
            Me.Label9.Text = "Branch"
            '
            'ErrProvider
            '
            Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
            Me.ErrProvider.ContainerControl = Me
            Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
            '
            'TxtFreightGLDesc
            '
            Me.TxtFreightGLDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance3.BackColor = System.Drawing.SystemColors.Window
            Me.TxtFreightGLDesc.Appearance = Appearance3
            Me.TxtFreightGLDesc.BackColor = System.Drawing.SystemColors.Window
            Me.TxtFreightGLDesc.Location = New System.Drawing.Point(282, 196)
            Me.TxtFreightGLDesc.Name = "TxtFreightGLDesc"
            Me.TxtFreightGLDesc.Size = New System.Drawing.Size(378, 21)
            Me.TxtFreightGLDesc.TabIndex = 122
            Me.TxtFreightGLDesc.TabStop = False
            Me.TxtFreightGLDesc.Tag = "dd.GLDescription"
            '
            'TxtFreightGLCode
            '
            Me.TxtFreightGLCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance4.BackColor = System.Drawing.SystemColors.Window
            Me.TxtFreightGLCode.Appearance = Appearance4
            Me.TxtFreightGLCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtFreightGLCode.Location = New System.Drawing.Point(150, 196)
            Me.TxtFreightGLCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.GLCode_Length
            Me.TxtFreightGLCode.Name = "TxtFreightGLCode"
            Me.TxtFreightGLCode.Size = New System.Drawing.Size(132, 21)
            Me.TxtFreightGLCode.TabIndex = 2
            Me.TxtFreightGLCode.Tag = "FK.GLCode"
            '
            'LinkLabel3
            '
            Me.LinkLabel3.BackColor = System.Drawing.Color.Transparent
            Me.LinkLabel3.ForeColor = System.Drawing.Color.Navy
            Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.LinkLabel3.Location = New System.Drawing.Point(40, 196)
            Me.LinkLabel3.Name = "LinkLabel3"
            Me.LinkLabel3.Size = New System.Drawing.Size(110, 20)
            Me.LinkLabel3.TabIndex = 123
            Me.LinkLabel3.TabStop = True
            Me.LinkLabel3.Text = "GL Code"
            '
            'Branches
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(804, 414)
            Me.Controls.Add(Me.TxtFreightGLDesc)
            Me.Controls.Add(Me.TxtFreightGLCode)
            Me.Controls.Add(Me.LinkLabel3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpDate)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.txtBranchCode)
            Me.Controls.Add(Me.Label9)
            Me.KeyPreview = True
            Me.MinimumSize = Global.BusinessLeaf.My.MySettings.Default.SetupFormMinimumSize
            Me.Name = "Branches"
            Me.Text = "Branch File"
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtBranchCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtFreightGLDesc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtFreightGLCode, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private Sub txtBranchCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtBranchCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Branches")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.txtBranchCode.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
                Me.Desc.Text = frmser.UGSearch.Rows(iRow).Cells("BranchName").Value
                Me.txtBranchCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtBranchCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.txtBranchCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtBranchCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBranchCode.Validating
            If Trim(txtBranchCode.Text) <> "" Then
                If Trim(txtBranchCode.Text).Length <> txtBranchCode.MaxLength Then
                    e.Cancel = True

                    ErrProvider.SetError(txtBranchCode, " Please Enter a Proper length of Code ")
                End If
            End If

        End Sub
        Private Sub txtBranchCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBranchCode.Validated
            ErrProvider.SetError(txtBranchCode, "")
        End Sub

        Private Sub Branches_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
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
                    Call Me.TxtFreightGLCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
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

        Private Sub txtBranchCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranchCode.ValueChanged

        End Sub

        Private Sub TxtFreightGLCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFreightGLCode.ValueChanged

        End Sub
    End Class

End Namespace