Public Class UserSecurities
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtConfirmPassowrd As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TxtPassword As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TxtUserID As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TxtUserName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtEncryptPassword As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtConfirmPassowrd = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.TxtPassword = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.TxtUserID = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.TxtUserName = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtEncryptPassword = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(104, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 20)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Confirm Password"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(104, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 20)
        Me.Label10.TabIndex = 93
        Me.Label10.Text = "Password"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(104, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 20)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "User Name"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(104, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "User ID"
        '
        'TxtConfirmPassowrd
        '
        Me.TxtConfirmPassowrd.BackColor = System.Drawing.SystemColors.Window
        Me.TxtConfirmPassowrd.Location = New System.Drawing.Point(208, 196)
        Me.TxtConfirmPassowrd.Name = "TxtConfirmPassowrd"
        Me.TxtConfirmPassowrd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtConfirmPassowrd.Size = New System.Drawing.Size(100, 20)
        Me.TxtConfirmPassowrd.TabIndex = 98
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPassword.Location = New System.Drawing.Point(208, 172)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtPassword.Size = New System.Drawing.Size(100, 20)
        Me.TxtPassword.TabIndex = 97
        '
        'TxtUserID
        '
        Me.TxtUserID.BackColor = System.Drawing.SystemColors.Window
        Me.TxtUserID.Location = New System.Drawing.Point(208, 124)
        Me.TxtUserID.MaxLength = 100
        Me.TxtUserID.Name = "TxtUserID"
        Me.TxtUserID.Size = New System.Drawing.Size(100, 20)
        Me.TxtUserID.TabIndex = 95
        Me.TxtUserID.Tag = "PK.UserID"
        '
        'TxtUserName
        '
        Me.TxtUserName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUserName.BackColor = System.Drawing.SystemColors.Window
        Me.TxtUserName.Location = New System.Drawing.Point(208, 148)
        Me.TxtUserName.MaxLength = 50
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(510, 20)
        Me.TxtUserName.TabIndex = 96
        Me.TxtUserName.Tag = "FK.UserName"
        '
        'txtEncryptPassword
        '
        Me.txtEncryptPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtEncryptPassword.Location = New System.Drawing.Point(364, 226)
        Me.txtEncryptPassword.MaxLength = 10
        Me.txtEncryptPassword.Name = "txtEncryptPassword"
        Me.txtEncryptPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtEncryptPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtEncryptPassword.TabIndex = 99
        Me.txtEncryptPassword.Tag = "FK.Password"
        Me.txtEncryptPassword.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(320, 126)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(192, 16)
        Me.CheckBox1.TabIndex = 100
        Me.CheckBox1.Tag = "FK.IsActive"
        Me.CheckBox1.Text = "Active User"
        '
        'UserSecurities
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(761, 390)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtEncryptPassword)
        Me.Controls.Add(Me.TxtConfirmPassowrd)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUserID)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.MinimumSize = New System.Drawing.Size(310, 0)
        Me.Name = "UserSecurities"
        Me.Text = "Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub TxtPassword_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtPassword.Validating
        txtEncryptPassword.Text = EncodePassword(TxtPassword.Text)
        e.Cancel = False
    End Sub
    Public Function ValidateData() As Boolean
        If TxtPassword.Text.Length <> TxtConfirmPassowrd.Text.Length Then
            MsgBox("Password do not match")
            Return False
        Else
            If TxtPassword.Text <> TxtConfirmPassowrd.Text Then
                MsgBox("Password do not match")
                Return False

            Else
                Return True
            End If
        End If
    End Function

    Private Sub UserSecurities_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
    End Sub
End Class
