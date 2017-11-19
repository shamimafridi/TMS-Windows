Imports System.Management
Module StartApplication
    Public TrailDays As Int16
    Sub main()
        Try
            '''''Checking piracy
            If checkDriveInfo() = False Then
                MessageBox.Show("You are using invalid type of Hard Drive Media" & vbCrLf & "Please contact with Administrator")
                Exit Sub
            End If

            '''''Checking Trial time
            If checkTrialTime() = False Then
                MessageBox.Show("There is a seriouse piracy issue in your software copy ")
                Exit Sub
            End If

            Dim frmlogin As New FrmLogin
            Dim frmsplash As New frmSplash
            Dim frmmain As New frmMain

            frmsplash.ShowDialog()
            'frmlogin.ShowDialog()
            Application.Run(frmmain)

        Catch ex As ObjectDisposedException
            MsgBox(ex.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function checkTrialTime() As Boolean
        Dim expDate As Date = My.Settings.SoftwareExpireDate
        Dim strDate As Date = My.Settings.ModuleStartDate
        Dim yr As Int16 = expDate.Year
        Dim dr As TimeSpan = expDate.Subtract(Now.Date)  'return the days defference between thes two dates
        TrailDays = dr.Days
        If TrailDays <= 0 Then
            MessageBox.Show("Your Trail version of this software has been expired", "Piracy Check", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function
    Private Function checkDriveInfo() As Boolean
        Dim drives As New ArrayList

        Dim query As New ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive ")

        Dim Drinfo As New DriveInfo
        For Each wmiDrive As ManagementObject In query.Get()

            Drinfo.Model = wmiDrive("Model").ToString()
            Drinfo.Type = wmiDrive("InterfaceType").ToString()
            drives.Add(Drinfo)
        Next

        query = New ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia ")

        Dim i As Integer = 0
        For Each wmiDrive As ManagementObject In query.Get()
            ' Get the hard drive from collection using index.
            Dim info As DriveInfo = CType(drives(i), DriveInfo)
            ' Get the hardware serial number.
            If wmiDrive("SerialNumber") Is Nothing Then
                info.SerialNumber = "None"
            Else
                info.SerialNumber = wmiDrive("SerialNumber").ToString()
            End If
            i += 1
        Next

        Dim SrNo As String
        Try
            If IO.File.Exists(Application.StartupPath & "\Disk.bat") Then
                Dim read As IO.StreamReader = IO.File.OpenText(Application.StartupPath & "\Disk.bat")
                read.ReadLine()
                read.ReadLine()
                SrNo = Mid(read.ReadLine, "Serial No.:".Length + 1)
                If Trim(SrNo) <> Trim(Drinfo.SerialNumber) Then
                    MessageBox.Show("You have an illegal copy of this software.", "Piracy Check", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return False
                Else
                    Return True
                End If

            Else

                ' Display available hard drives.
                Dim FileWr As New IO.StreamWriter(Application.StartupPath & "\Disk.bat")

                For Each info As DriveInfo In drives
                    FileWr.WriteLine("Model:" + Trim(info.Model))
                    FileWr.WriteLine("Type:" + Trim(info.Type))
                    FileWr.WriteLine("Serial No.:" + Trim(info.SerialNumber))
                    FileWr.WriteLine()
                    FileWr.Close()
                Next
                Dim str As String = InputBox("Password", "Piracy Check")
                If Trim(Drinfo.SerialNumber) & "SHA" <> str Then
                    MessageBox.Show("Password do not match", "Piracy Check", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    IO.File.Delete(Application.StartupPath & "\Disk.bat")
                    Return False
                Else
                    Return True
                End If

            End If
        Catch ex As Exception
            IO.File.Delete(Application.StartupPath & "\Disk.bat")
            Return False
        End Try

    End Function

End Module


Class DriveInfo

    Private _model As String
    Private _type As String
    Private _serialNumber As String

    Public Property Model() As String
        Get
            Return _model
        End Get
        Set(ByVal Value As String)
            _model = Value
        End Set
    End Property

    Public Property Type() As String
        Get
            Return _type
        End Get
        Set(ByVal Value As String)
            _type = Value
        End Set
    End Property

    Public Property SerialNumber() As String
        Get
            Return _serialNumber
        End Get
        Set(ByVal Value As String)
            _serialNumber = Value
        End Set
    End Property
End Class

