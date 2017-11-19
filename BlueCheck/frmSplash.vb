Public Class frmSplash
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
    Friend WithEvents LblTrilDays As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblVersion As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LblTrilDays = New System.Windows.Forms.Label
        Me.LblVersion = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LblTrilDays
        '
        Me.LblTrilDays.BackColor = System.Drawing.Color.Transparent
        Me.LblTrilDays.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTrilDays.Location = New System.Drawing.Point(0, 278)
        Me.LblTrilDays.Name = "LblTrilDays"
        Me.LblTrilDays.Size = New System.Drawing.Size(504, 13)
        Me.LblTrilDays.TabIndex = 0
        Me.LblTrilDays.Text = "Trail Days: 30 Days"
        Me.LblTrilDays.Visible = False
        '
        'LblVersion
        '
        Me.LblVersion.BackColor = System.Drawing.Color.Transparent
        Me.LblVersion.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVersion.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblVersion.Location = New System.Drawing.Point(0, 261)
        Me.LblVersion.Name = "LblVersion"
        Me.LblVersion.Size = New System.Drawing.Size(296, 16)
        Me.LblVersion.TabIndex = 2
        Me.LblVersion.Text = "Virsion "
        Me.LblVersion.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 44.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(129, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(586, 78)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Azam Technologies"
        '
        'frmSplash
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(669, 482)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblVersion)
        Me.Controls.Add(Me.LblTrilDays)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)

    End Sub

#End Region
 
    Public Sub MakeTransparent_Example(ByVal e As PaintEventArgs)
        Try
            ' Create a Bitmap object from an image file.
            Dim strPath1 As String = Application.StartupPath & "\Images\" & "BackGround.gif"
            Dim strPath As String = Application.StartupPath & "\Images\" & "logo.gif"
            Dim myBitmap As New Bitmap(strPath)

            ' Draw myBitmap to the screen.
            e.Graphics.DrawImage(myBitmap, 0, 0, myBitmap.Width, _
            myBitmap.Height)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmSplash_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        MakeTransparent_Example(e)
    End Sub
   
End Class
