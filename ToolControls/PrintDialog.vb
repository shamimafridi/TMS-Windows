Public Class PrintDialog
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdPreview As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmbReportType As System.Windows.Forms.ComboBox
    Friend WithEvents cmdDetail As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PrintDialog))
        Me.cmbReportType = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdDetail = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdPreview = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbReportType
        '
        Me.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportType.Items.AddRange(New Object() {"Document View", "Summery"})
        Me.cmbReportType.Location = New System.Drawing.Point(128, 64)
        Me.cmbReportType.Name = "cmbReportType"
        Me.cmbReportType.Size = New System.Drawing.Size(112, 21)
        Me.cmbReportType.Sorted = True
        Me.cmbReportType.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(56, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Report Style"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdDetail)
        Me.Panel1.Controls.Add(Me.cmdCancel)
        Me.Panel1.Controls.Add(Me.cmdPrint)
        Me.Panel1.Controls.Add(Me.cmdPreview)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 148)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 32)
        Me.Panel1.TabIndex = 7
        '
        'cmdDetail
        '
        Me.cmdDetail.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.cmdDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDetail.Location = New System.Drawing.Point(4, 4)
        Me.cmdDetail.Name = "cmdDetail"
        Me.cmdDetail.Size = New System.Drawing.Size(100, 24)
        Me.cmdDetail.TabIndex = 10
        Me.cmdDetail.Text = "&Other Reports"
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Location = New System.Drawing.Point(250, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "&Cancel"
        '
        'cmdPrint
        '
        Me.cmdPrint.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Location = New System.Drawing.Point(178, 4)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(72, 24)
        Me.cmdPrint.TabIndex = 8
        Me.cmdPrint.Text = "&Print"
        '
        'cmdPreview
        '
        Me.cmdPreview.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPreview.Location = New System.Drawing.Point(106, 4)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(72, 24)
        Me.cmdPreview.TabIndex = 7
        Me.cmdPreview.Text = "P&review"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(272, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PrintDialog
        '
        Me.AcceptButton = Me.cmdPreview
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(406, 180)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbReportType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintDialog"
        Me.ShowInTaskbar = False
        Me.Text = "Print"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Event ActionPerformed(ByVal sender As Object, ByVal e As ActionEventArgs)
    Private mFileName As String
    Public Property ReportFileName() As String
        Get
            Return mFileName
        End Get
        Set(ByVal Value As String)
            mFileName = Value
        End Set
    End Property
#Region "Report Processing "
    Public ReportStyle As ReportType
    Enum ReportType As Long
        CardView
        Listing
    End Enum
    'Sub ReportProcess(ByVal ReportName As String, ByVal ReportStyle As ReportType)
    '    Try
    '        Dim Acc As DataComponents.Database.DataAccess
    '        Acc = New DataComponents.Database.DataAccess

    '        Dim Ds As DataSet
    '        Ds = Acc.PopulateDataSet(Ds, "Select" & ReportFileName, "OPTION", "ALL")
    '        Ds.DataSetName = ReportFileName
    '        Ds.WriteXmlSchema("..\Reports\" & ReportFileName & ".xsd")

    '        Dim strReportPath As String = "..\Reports\" & ReportFileName & ".rpt"

    '        If Not IO.File.Exists(strReportPath) Then
    '            Throw (New Exception("Unable to locate report file:" & vbCrLf & strReportPath))
    '        End If
    '        'Dim cr As New ReportDocument

    '        'cr.Load(strReportPath)
    '        'cr.SetDataSource(Ds.Tables("Customers"))


    '    Catch ex As SqlClient.SqlException
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
#End Region
    Private Sub cmbReportType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReportType.SelectedIndexChanged
        If cmbReportType.SelectedIndex = 0 Then
            ReportStyle = ReportType.CardView
        Else
            ReportStyle = ReportType.Listing
        End If
    End Sub
    Public Class ActionEventArgs
        Inherits EventArgs
        Public Enum Action
            Preview
            Print
            Detail
        End Enum
        Public Actions As Action
        Public ReportTypes As ReportType
        Public ReportFileName As String
        Sub New(ByVal reportFile As String, ByVal action As Action, ByVal reportType As ReportType)
            Actions = action
            ReportTypes = reportType
            ReportFileName = reportFile
        End Sub
    End Class
    Private Sub PrintDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbReportType.SelectedIndex = 0
    End Sub
End Class
