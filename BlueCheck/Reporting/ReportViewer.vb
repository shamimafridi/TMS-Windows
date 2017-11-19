Imports CrystalDecisions.CrystalReports.Engine

Public Class ReportViewer
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
    Friend WithEvents rptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.rptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'rptViewer
        '
        Me.rptViewer.ActiveViewIndex = -1
        Me.rptViewer.DisplayGroupTree = False
        Me.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rptViewer.Location = New System.Drawing.Point(0, 0)
        Me.rptViewer.Name = "rptViewer"
        Me.rptViewer.ReportSource = Nothing
        Me.rptViewer.ShowCloseButton = False
        Me.rptViewer.ShowGotoPageButton = False
        Me.rptViewer.ShowGroupTreeButton = False
        Me.rptViewer.ShowRefreshButton = False
        Me.rptViewer.Size = New System.Drawing.Size(292, 266)
        Me.rptViewer.TabIndex = 0
        '
        'ReportViewer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.rptViewer)
        Me.Name = "ReportViewer"
        Me.Text = "ReportViewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public WriteOnly Property SetSource() As ReportDocument

        Set(ByVal Value As ReportDocument)
            rptViewer.ReportSource = Value
        End Set
    End Property

End Class
