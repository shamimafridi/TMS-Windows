Imports System.Data.SqlClient
Imports System.EnterpriseServices
Namespace Database

    '<ComClass(DataConnection.ClassId, DataConnection.InterfaceId, DataConnection.EventsId)> _
    Public Class DataConnection
        '        Inherits ServicedComponent
        '#Region "COM GUIDs"
        '        ' These  GUIDs provide the COM identity for this class 
        '        ' and its COM interfaces. If you change them, existing 
        '        ' clients will no longer be able to access the class.
        '        Public Const ClassId As String = "864AE863-D83C-4BCE-A284-61C836F36BCF"
        '        Public Const InterfaceId As String = "6CA6BD1B-0A23-47D2-BEB0-7F0E5C7341E3"
        '        Public Const EventsId As String = "0EF2B5DD-425C-405F-8C7A-96AF25EAF8E0"
        '#End Region

        ' A creatable COM class must have a Public Sub New() 
        ' with no parameters, otherwise, the class will not be 
        ' registered in the COM registry and cannot be created 
        ' via CreateObject.
        Private mConString As String
        Public Sub New()
            '  MyBase.New()
            Dim EncryptStrPWD As String = String.Empty

            'EncryptStrPWD = MySettingReader.Read("ConnectionString", MySettingReader.FieldLevel.ApplicationLevel) ''Get Encrypted Conncetion String from App.config file
            ' Dim data() As Byte = Convert.FromBase64String(EncryptStrPWD)  ''Decrypt It
            ' mConString = System.Text.ASCIIEncoding.ASCII.GetString(data)

            'mConString = mConString & "Data Source=" & MySettingReader.Read("ServerName", MySettingReader.FieldLevel.ApplicationLevel)
            mConString = MySettingReader.Read("ConnectionString", MySettingReader.FieldLevel.ApplicationLevel)
        End Sub
        ''''''''''''''''How to Encrypt the Connection string''''
        'Dim data() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes("workstation id=DotNetServer;data source=DotNetServer;initial catalog=BIS;User ID=Abc;Password=AAAAA")
        'Dim str As String = Convert.ToBase64String(Data)
        'Debug.WriteLine(str)
        ''''''''''''''''''''''''''''''''''''''
        Public Function GetConnection() As SqlConnection
            'Return Connection Object 
            Dim sqlCon As SqlConnection
            sqlCon = New SqlConnection(ConnectionString)
            sqlCon.Open()
            Return sqlCon
        End Function
        Public ReadOnly Property ConnectionString() As String
            Get
                Return mConString
            End Get
        End Property
        'Public Sub OpenConnection()
        '    Connection.Open()
        'End Sub
    End Class
    Public Class ConnectionException
        ''''''''''''''''''
        ''''PURPOSE:- TO THROUGH THIS EXCEPTION WHEN SERVER IS NOT AVAILABLE
        ''''''''''''''''''
        Inherits ApplicationException
        Sub New()
            MyBase.New()
        End Sub
        Sub New(ByVal message As String)
            MyBase.New(message)
        End Sub
    End Class
End Namespace



