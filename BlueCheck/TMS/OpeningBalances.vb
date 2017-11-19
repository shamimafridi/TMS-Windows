Namespace Inventory
    Public Class OpeningBalances
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
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents TxtItem As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtBranchCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents TextBox3 As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtGLCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
        Friend WithEvents TextBox1 As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtDivisionCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
        Friend WithEvents LblItem As System.Windows.Forms.LinkLabel
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpeningBalances))
            Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.TxtItem = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtBranchCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.LblItem = New System.Windows.Forms.LinkLabel
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.dtpDate = New System.Windows.Forms.DateTimePicker
            Me.TextBox1 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtDivisionCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
            Me.TextBox3 = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtGLCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
            CType(Me.TxtItem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtBranchCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtDivisionCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtGLCode, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(116, 120)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 70
            Me.Label1.Text = "Closing Date"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.ForeColor = System.Drawing.Color.Navy
            Me.Label3.Location = New System.Drawing.Point(116, 219)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(110, 20)
            Me.Label3.TabIndex = 69
            Me.Label3.Text = "Balance "
            '
            'TxtItem
            '
            Me.TxtItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtItem.Location = New System.Drawing.Point(362, 141)
            Me.TxtItem.Name = "TxtItem"
            Me.TxtItem.Size = New System.Drawing.Size(433, 21)
            Me.TxtItem.TabIndex = 68
            Me.TxtItem.TabStop = False
            Me.TxtItem.Tag = "dd.BranchDescription"
            '
            'TxtBranchCode
            '
            Me.TxtBranchCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.TxtBranchCode.Appearance = Appearance1
            Me.TxtBranchCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtBranchCode.Location = New System.Drawing.Point(232, 141)
            Me.TxtBranchCode.Name = "TxtBranchCode"
            Me.TxtBranchCode.Size = New System.Drawing.Size(130, 21)
            Me.TxtBranchCode.TabIndex = 1
            Me.TxtBranchCode.Tag = "PK.BranchCode"
            '
            'LblItem
            '
            Me.LblItem.BackColor = System.Drawing.Color.Transparent
            Me.LblItem.ForeColor = System.Drawing.Color.Navy
            Me.LblItem.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.LblItem.Location = New System.Drawing.Point(116, 144)
            Me.LblItem.Name = "LblItem"
            Me.LblItem.Size = New System.Drawing.Size(110, 20)
            Me.LblItem.TabIndex = 67
            Me.LblItem.TabStop = True
            Me.LblItem.Text = "Branch Code"
            '
            'ErrProvider
            '
            Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
            Me.ErrProvider.ContainerControl = Me
            Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
            Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
            '
            'Desc
            '
            Me.Desc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Desc.Location = New System.Drawing.Point(232, 219)
            Me.Desc.Name = "Desc"
            Me.Desc.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.Desc.Size = New System.Drawing.Size(130, 21)
            Me.Desc.TabIndex = 2
            Me.Desc.Tag = "dd.BalanceAmount"
            '
            'dtpDate
            '
            Me.dtpDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
            Me.dtpDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
            Me.dtpDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
            Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDate.Location = New System.Drawing.Point(232, 114)
            Me.dtpDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.dtpDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.dtpDate.Name = "dtpDate"
            Me.dtpDate.Size = New System.Drawing.Size(130, 20)
            Me.dtpDate.TabIndex = 96
            Me.dtpDate.Tag = "PK.ClosingDate"
            '
            'TextBox1
            '
            Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TextBox1.Location = New System.Drawing.Point(362, 167)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.Size = New System.Drawing.Size(433, 21)
            Me.TextBox1.TabIndex = 100
            Me.TextBox1.TabStop = False
            Me.TextBox1.Tag = "dd.Division"
            '
            'TxtDivisionCode
            '
            Me.TxtDivisionCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance3.BackColor = System.Drawing.SystemColors.Window
            Me.TxtDivisionCode.Appearance = Appearance3
            Me.TxtDivisionCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtDivisionCode.Location = New System.Drawing.Point(232, 167)
            Me.TxtDivisionCode.Name = "TxtDivisionCode"
            Me.TxtDivisionCode.Size = New System.Drawing.Size(130, 21)
            Me.TxtDivisionCode.TabIndex = 98
            Me.TxtDivisionCode.Tag = "PK.DivisionCode"
            '
            'LinkLabel1
            '
            Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
            Me.LinkLabel1.ForeColor = System.Drawing.Color.Navy
            Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.LinkLabel1.Location = New System.Drawing.Point(116, 170)
            Me.LinkLabel1.Name = "LinkLabel1"
            Me.LinkLabel1.Size = New System.Drawing.Size(110, 20)
            Me.LinkLabel1.TabIndex = 99
            Me.LinkLabel1.TabStop = True
            Me.LinkLabel1.Text = "Division Code"
            '
            'TextBox3
            '
            Me.TextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TextBox3.Location = New System.Drawing.Point(362, 193)
            Me.TextBox3.Name = "TextBox3"
            Me.TextBox3.Size = New System.Drawing.Size(433, 21)
            Me.TextBox3.TabIndex = 104
            Me.TextBox3.TabStop = False
            Me.TextBox3.Tag = "dd.GLDescription"
            '
            'TxtGLCode
            '
            Me.TxtGLCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.TxtGLCode.Appearance = Appearance2
            Me.TxtGLCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtGLCode.Location = New System.Drawing.Point(232, 193)
            Me.TxtGLCode.Name = "TxtGLCode"
            Me.TxtGLCode.Size = New System.Drawing.Size(130, 21)
            Me.TxtGLCode.TabIndex = 102
            Me.TxtGLCode.Tag = "PK.GLCode"
            '
            'LinkLabel2
            '
            Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
            Me.LinkLabel2.ForeColor = System.Drawing.Color.Navy
            Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.LinkLabel2.Location = New System.Drawing.Point(116, 196)
            Me.LinkLabel2.Name = "LinkLabel2"
            Me.LinkLabel2.Size = New System.Drawing.Size(110, 20)
            Me.LinkLabel2.TabIndex = 103
            Me.LinkLabel2.TabStop = True
            Me.LinkLabel2.Text = "GL Code"
            '
            'OpeningBalances
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(844, 597)
            Me.Controls.Add(Me.TextBox3)
            Me.Controls.Add(Me.TxtGLCode)
            Me.Controls.Add(Me.LinkLabel2)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.TxtDivisionCode)
            Me.Controls.Add(Me.LinkLabel1)
            Me.Controls.Add(Me.dtpDate)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.TxtItem)
            Me.Controls.Add(Me.TxtBranchCode)
            Me.Controls.Add(Me.LblItem)
            Me.KeyPreview = True
            Me.MinimumSize = New System.Drawing.Size(310, 0)
            Me.Name = "OpeningBalances"
            Me.Text = "Opening Balance File"
            CType(Me.TxtItem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtBranchCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtDivisionCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtGLCode, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private Sub OpeningBalances_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub

        Private Sub TxtBranchCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtBranchCode.Validating
            If Trim(TxtBranchCode.Text) <> "" Then
                Dim mdi As frmMain
                If Trim(TxtBranchCode.Text).Length <> TxtBranchCode.MaxLength Then
                    ErrProvider.SetIconAlignment(TxtBranchCode, ErrorIconAlignment.MiddleLeft)
                    ErrProvider.SetError(TxtBranchCode, " Please Enter a Proper length of Code ")
                    TxtBranchCode.Focus()
                Else
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader
                    Reader = Acc.GetRecord("SelectItems", "ItemCode ", Trim(TxtBranchCode.Text))
                    Try
                        If Reader.HasRows = False Then
                            ErrProvider.SetError(TxtBranchCode, "Invalid Item Code")
                            ErrProvider.SetIconAlignment(TxtBranchCode, ErrorIconAlignment.MiddleLeft)
                            mdi = Me.MdiParent
                            '  mdi.SldSearch.LookForSearch(TxtItemCode, TxtItem, TxtItemCode.Text, "ItemCode", "Items")
                            'mdi.sldGrid.LockSlide = True
                            TxtItem.Text = ""
                            TxtBranchCode.Focus()
                        Else
                            mdi = Me.MdiParent
                            'mdi.sldGrid.LockSlide = False
                            'mdi.sldGrid.HideSlide()
                            Reader.Read()
                            TxtItem.Text = Reader.Item("Item")
                            ErrProvider.SetError(TxtBranchCode, "")
                            Me.SelectNextControl(TxtBranchCode, True, True, False, False)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                'Else
                '    e.Cancel = True
                '    ErrProvider.SetError(TxtItemCode, " Empty Code is not Allowed " & vbCrLf & " Please Enter a Proper length of Code ")
            End If
        End Sub

        Private Sub CmdCityList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub
    End Class
End Namespace