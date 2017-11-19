Public Class LogGenerator
    Private Shared Sub CreatingSource()
        If Not EventLog.SourceExists(GetExeConifNodeValue("ApplicationName") & " Log", GetExeConifNodeValue("ServerName")) Then
            'If Not EventLog.SourceExists("MySource", "DotNetServer") Then
            EventLog.CreateEventSource(GetExeConifNodeValue("ApplicationName") & " Log", GetExeConifNodeValue("ApplicationName") & " Log")
            'EventLog.CreateEventSource("MySource", "MyApp", "DotNetServer")
        End If
    End Sub
    Shared Sub CreateLog(ByVal Message As String, ByVal TableSource As String, ByVal ErrorNumber As Integer, ByVal LogType As EventLogEntryType)
        CreatingSource()
        Dim objEventLog As New EventLog
        'Register the App as an Event Source
        Dim strLogName As String
        Dim strSysName As String
        strLogName = GetExeConifNodeValue("ApplicationName") & " Log"
        strSysName = GetExeConifNodeValue("ServerName")
        If Not EventLog.SourceExists(TableSource, strSysName) Then
            System.Diagnostics.EventLog.CreateEventSource(New System.Diagnostics.EventSourceCreationData(TableSource, strLogName))
        End If
        objEventLog.Source = TableSource
        objEventLog.WriteEntry(Message, LogType, ErrorNumber, CShort(7))

    End Sub
    Private Shared Function GetExeConifNodeValue(ByVal NodeName As String) As String

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'PURPOSE:   'The puspose of the sub procedure is to get the Connection string
        '           From the exe eonfig file of the Client application Configuration file
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Dim Asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly
        'Dim strConfigLoc As String
        Dim XMLExeConfigeFile As String = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile
        Dim ConnStr As String = Nothing
        'strConfigLoc = Asm.Location
        ' The config file is located in the application's bin directory, so
        ' you need to remove the file name.
        'Dim strTemp As String
        'strTemp = strConfigLoc
        'strTemp = System.IO.Path.GetDirectoryName(strConfigLoc)

        ' Declare a FileInfo object for the config file.
        Dim FileInfo As System.IO.FileInfo = New System.IO.FileInfo(XMLExeConfigeFile)
        ' Load the config file into the XML DOM.
        Dim XmlDocument As New System.Xml.XmlDocument
        XmlDocument.Load(FileInfo.FullName)

        ' Find the right node and change it to the new value.
        Dim Node As System.Xml.XmlNode
        For Each Node In XmlDocument.Item("configuration").Item("appSettings")
            ' Skip any comments.
            If Node.Name = "add" Then
                If Node.Attributes.GetNamedItem("key").Value = _
                   NodeName Then
                    ConnStr = Node.Attributes.GetNamedItem("value").Value
                End If
            End If
        Next Node
        ' Save the modified config file.
        XmlDocument.Save(FileInfo.FullName)
        Return ConnStr
    End Function
End Class
