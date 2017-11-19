Public Class FrmLogin
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
        frmMain = Nothing
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TxtUser As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TxtPassword As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
    Friend WithEvents PgbLogin As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.TxtUser = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.TxtPassword = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PgbLogin = New System.Windows.Forms.ProgressBar
        Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
        Me.BtnOk = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtUser
        '
        Me.TxtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUser.Location = New System.Drawing.Point(259, 198)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(229, 22)
        Me.TxtUser.TabIndex = 0
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(259, 225)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtPassword.Size = New System.Drawing.Size(229, 22)
        Me.TxtPassword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'PgbLogin
        '
        Me.PgbLogin.Location = New System.Drawing.Point(259, 333)
        Me.PgbLogin.Name = "PgbLogin"
        Me.PgbLogin.Size = New System.Drawing.Size(229, 15)
        Me.PgbLogin.TabIndex = 6
        Me.PgbLogin.Visible = False
        '
        'ErrProvider
        '
        Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
        Me.ErrProvider.ContainerControl = Me
        Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
        Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
        '
        'BtnOk
        '
        Me.BtnOk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnOk.Location = New System.Drawing.Point(259, 303)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(77, 24)
        Me.BtnOk.TabIndex = 2
        Me.BtnOk.Text = "&Login"
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnCancel.Location = New System.Drawing.Point(347, 303)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(141, 24)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "&Shut Down Application"
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.BtnOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(725, 431)
        Me.ControlBox = False
        Me.Controls.Add(Me.PgbLogin)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim Login_Try As Integer

    Private Sub FrmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Login_Try = 1
        TxtUser.Text = GetSetting(My.Settings.ThisSystemName, "LOGIN", "USERID")
        If Trim(TxtUser.Text) <> "" Then TxtPassword.Select()
    End Sub
    Private Sub Proceed_With_Login()
        CurrentWorkingDate = CDate(GetOptionValue("WorkingDate"))
        Me.Cursor = Windows.Forms.Cursors.WaitCursor
        SaveSetting(My.Settings.ThisSystemName, "LOGIN", "USERID", Trim(TxtUser.Text))
        Me.PgbLogin.Visible = True
        Me.PgbLogin.Value = 100
        frmMain.Show()
        frmMain.SetToolBarTheme()
        Me.Hide()
    End Sub
    Private Sub BtnOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        Try
            ' Dim Position As Integer
            Me.Cursor = Windows.Forms.Cursors.WaitCursor
            If (TxtUser.Text <> String.Empty) Then
                If TxtPassword.Text <> String.Empty Then
                    If Login_Try >= 3 Then
                        Me.PgbLogin.Visible = False
                        MsgBox("SYSTEM ACCESS DENIED" & vbCrLf & vbCrLf & "You cannot Access this software as the LogIn " & vbCrLf & "Process has been Locked..." & vbCrLf & vbCrLf & "Please Contact Your Administrator For Assistance." & vbCrLf & "The System has Generated a Seurity Alert.", vbCritical, " - Login Retry Error...")
                        Me.Cursor = Windows.Forms.Cursors.Default
                        Me.Close()
                        End
                    Else
                        Dim objlogin As New AzamTechnologies.Database.DataAccess
                        Dim reader As SqlClient.SqlDataReader
                        Me.PgbLogin.Visible = True
                        Me.PgbLogin.Value = 20
                        reader = objlogin.GetRecord("SelectUserSecurities", "UserID", TxtUser.Text, "Password", TxtPassword.Text)
                        Me.PgbLogin.Visible = True
                        Me.PgbLogin.Value = 40
                        If reader.HasRows Then
                            reader.Read()
                            Me.PgbLogin.Visible = True
                            If Trim(TxtPassword.Text) = DecodePassword(reader("Password")) Then
                                If IIf(IsDBNull(reader("IsLoggedIn")), 0, reader("IsLoggedIn")) Then
                                    If reader("NormalShutDown") Then
                                        Me.Cursor = Windows.Forms.Cursors.Default
                                        Exit Sub
                                    Else
                                        'MsgBox("You Had Abnormal Shut Down Last Time You Logged In.", vbCritical, "Abnormal Shutdown")
                                        ErrProvider.SetError(TxtUser, "You Had Abnormal Shut Down Last Time You Logged In.")
                                        Me.PgbLogin.Visible = False
                                    End If
                                End If

                                Me.PgbLogin.Visible = True
                                Me.PgbLogin.Value = 70

                                If IIf(IsDBNull(reader("IsActive")), 0, reader("IsActive")) = False Then
                                    Me.PgbLogin.Visible = False
                                    'MsgBox("You Account Is Disabled. Please Contact your Administrator", vbCritical, "Account Disabled")
                                    ErrProvider.SetError(TxtUser, "You Account Is Disabled. Please Contact your Administrator")
                                    Me.Cursor = Windows.Forms.Cursors.Default
                                    Exit Sub
                                End If
                                OperatorID = Trim(reader("UserId"))
                                Me.PgbLogin.Visible = True
                                Me.PgbLogin.Value = 90
                                Call Proceed_With_Login()
                            Else
                                Me.PgbLogin.Visible = False
                                'DataComponents.LogGenerator.CreateLog("Invalid Password specified...", "LoginForm", Err.Number, EventLogEntryType.Error)
                                'MsgBox("Invalid Password specified..." & vbCrLf & "Please specify valid Password in Proper case..." & vbCrLf & vbCrLf & "If you don't remember your Password , Please contact your Administrator !", vbCritical, "Login Error...")
                                ErrProvider.SetError(TxtPassword, "Invalid Password specified..." & vbCrLf & "Please specify valid Password in Proper case")
                                Me.TxtPassword.Text = String.Empty
                                Login_Try = Login_Try + 1
                                Me.Cursor = Windows.Forms.Cursors.Default
                            End If
                        Else
                            Me.PgbLogin.Visible = False
                            'MsgBox("Invalid User Name Or Password specified..." & vbCr & "Please specify valid UserID and Password in Proper case..." & vbCrLf & vbCrLf & "If you don't have a USER ID , Please contact your Administrator !", vbCritical, "Logging..")
                            ErrProvider.SetError(TxtPassword, "Invalid Password specified..." & vbCrLf & "Please specify valid Password in Proper case..." & vbCrLf & vbCrLf & "If you don't remember your Password , Please contact your Administrator !")
                            Login_Try = Login_Try + 1
                            Me.Cursor = Windows.Forms.Cursors.Default
                        End If
                        Exit Sub
                    End If
                    Me.PgbLogin.Visible = False
                    'MsgBox("Password cannot be Blank / Empty..." & vbCrLf & "Please specify a valid Password ! ", vbInformation, "Invalid Password...")
                    ErrProvider.SetError(TxtPassword, "Password cannot be Blank / Empty..." & vbCrLf & "Please specify a valid Password ! ")
                    TxtPassword.Focus()
                Else
                    Me.PgbLogin.Visible = False
                    'MsgBox("User Password can't be blank or Empty..." & vbCrLf & "Please specify a valid User ID !", vbInformation, My.Settings.ConnectionString & " - Invalid User Password...")
                    ErrProvider.SetError(TxtPassword, "User Password can't be blank or Empty..." & vbCrLf & "Please specify a valid User ID !")
                End If
            Else

                Me.PgbLogin.Visible = False
                'MsgBox("Login ID / User ID cannot be Blank / Empty..." & vbCrLf & "Please specify a valid User ID !", vbInformation, "Invalid User ID...")
                ErrProvider.SetError(TxtUser, "Login ID / User ID cannot be Blank / Empty..." & vbCrLf & "Please specify a valid User ID !")
                TxtUser.Focus()
                BtnOk.Enabled = True
            End If
            Me.Cursor = Windows.Forms.Cursors.Default
            Exit Sub
        Catch ex As AzamTechnologies.Database.ConnectionException
            AzamTechnologies.LogGenerator.CreateLog(ex.Message, "Login Form", Err.Number, EventLogEntryType.Error)
            Me.PgbLogin.Visible = False
            MessageBox.Show(ex.Message, My.Settings.ConnectionString, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Me.Cursor = Windows.Forms.Cursors.Default
        Catch ex As Exception
            'DataComponents.LogGenerator.CreateLog(ex.Message, "Login Form", Err.Number, EventLogEntryType.Error)
            Me.PgbLogin.Visible = False
            MessageBox.Show(ex.Message, My.Settings.ConnectionString, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Me.Cursor = Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
        Application.Exit()
    End Sub
    Public Function DecodePassword(ByVal nPasswordStr As String) As String
        Dim data() As Byte = Convert.FromBase64String(Trim(nPasswordStr))
        Return (System.Text.ASCIIEncoding.ASCII.GetString(data))
    End Function

    Private Sub PgbLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PgbLogin.Click

    End Sub

    Private Sub FrmLogin_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim ArrowColor As Color
        Dim BackColor As Color
        If My.Settings.Theme = Color.Green Then
            ArrowColor = Color.YellowGreen
            BackColor = Color.OliveDrab
        ElseIf My.Settings.Theme = Color.Blue Then
            ArrowColor = Color.LightBlue
            BackColor = Color.DeepSkyBlue
        ElseIf My.Settings.Theme = Color.Black Then
            ArrowColor = Color.Gray
            BackColor = Color.Black
        ElseIf My.Settings.Theme = Color.Silver Then
            ArrowColor = Color.Silver
            BackColor = Color.LightSlateGray
        End If


        Dim formGraphics As Graphics = e.Graphics
        Dim gradientBrush As New Drawing2D.LinearGradientBrush(New Point(0, 0), New Point(Width, 0), Color.White, ArrowColor)
        Dim gradientBrushArr As New Drawing2D.LinearGradientBrush(New Point(0, 0), New Point(Width, 0), Color.White, BackColor)


        formGraphics.FillRectangle(gradientBrush, ClientRectangle)

        Dim ArrowPen As New Pen(gradientBrushArr, 150)



        formGraphics.DrawLine(ArrowPen, 0, 0, 1000, 0)
        formGraphics.DrawLine(ArrowPen, 0, 430, 1000, 430)
        formGraphics.DrawString("Welecome", New Font("Arial", 24, FontStyle.Bold, GraphicsUnit.Point), Brushes.AliceBlue, 550, 20)
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
