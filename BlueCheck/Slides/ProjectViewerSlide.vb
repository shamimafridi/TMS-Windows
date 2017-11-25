Imports Infragistics.Win.UltraWinExplorerBar
Imports System.Data.SqlClient
Imports System.Xml
Imports System.IO
Namespace Slides
    Public Class ProjectViewerSlide
        Implements IDisposable
        Dim Ds As DataSet
        Dim counter As Integer
        Const SetupTableName As String = "ProjectNodesSetup"
        Const SetupFileName As String = "ProjectNodesSetup.Xml"
        Private Const NodesSelectionQuery As String = "Select * from ProjectNodesSetup  Order By SortingOrder for XML Auto"
        Public MainControl As UltraExplorerBar
#Region "Creating Nodes For Projects files"
        Dim ndTopLevelGroup As UltraExplorerBarGroup
        Friend Sub CreateNodes()
            MainControl.Groups.Clear()
            MainControl.Name = My.Settings.ModuleLongName
            CreatingConfigXmlFile()
            'TvwProjectViewer.Nodes.Add(CreateTopLevelNode)
            CreateTopLevelNode()
        End Sub
        Private Function CreateTopLevelNode() As UltraExplorerBarGroup

            Dim grp2 As New UltraExplorerBarGroup
            grp2.Text = "Setup Files (TMS)"
            grp2.Items.AddRange(CreateChildeNodes("SU", "IN"))
            MainControl.Groups.Add(grp2)

            Dim grp1 As New UltraExplorerBarGroup
            grp1.Text = "Transaction Fiels (TMS)"
            grp1.Items.AddRange(CreateChildeNodes("TR", "IN"))
            MainControl.Groups.Add(grp1)


            Dim grp3 As New UltraExplorerBarGroup
            grp3.Text = "Setup Files (GL)"
            grp3.Items.AddRange(CreateChildeNodes("SU", "GL"))
            MainControl.Groups.Add(grp3)

            Dim grp4 As New UltraExplorerBarGroup
            grp4.Text = "Transaction Fiels (GL)"
            grp4.Items.AddRange(CreateChildeNodes("TR", "GL"))
            MainControl.Groups.Add(grp4)

            Return ndTopLevelGroup
        End Function
        Private Function CreateChildeNodes(ByVal NodeType As String, ByVal SystemType As String) As UltraExplorerBarItem()
            ''''''''''''''''''''''''''''''''''''''''''''''
            'PURPOSE::Reading Nodes from xml files and create the nodes of tree view
            ' accourding to the type and nature of the nodes
            ''''''''''''''''''''''''''''''''''''''''''''''
            Dim SetupFilesNodes() As UltraExplorerBarItem = Nothing
            Dim cnt As Int16 = 0
            Dim ImageIndex As Integer
            ' The config file is located in the application's bin directory, so
            ' you need to remove the file name.
            ' Declare a FileInfo object for the config file.
            Dim FileInfo As System.IO.FileInfo = New System.IO.FileInfo(Application.StartupPath & "\" & SetupFileName)
            ' Load the config file into the XML DOM.
            Dim XmlDocument As New System.Xml.XmlDocument
            XmlDocument.Load(FileInfo.FullName)
            ' Find the right node and change it to the new value.
            Dim Node As System.Xml.XmlNode
            For Each Node In XmlDocument.Item("TransformedSetup")
                ' Skip any comments.
                '        
                If Node.Name = SetupTableName Then 'If Node.Name = "ProjectNodesSetup" Then
                    ''''''''''''''''If To xml Node name is "ProjectNodesSetup"
                    If Node.Attributes.GetNamedItem("NodeType").Value = NodeType And Node.Attributes.GetNamedItem("SystemType").Value = SystemType Then   'If Node.Attributes.GetNamedItem("NodeType").Value = "SU" Then
                        If Node.Attributes.GetNamedItem("ShowNode").Value <> "0" Then 'If Node.Attributes.GetNamedItem("NodeType").Value = "SU" Then
                            ReDim Preserve SetupFilesNodes(cnt)
                            ImageIndex = Node.Attributes.GetNamedItem("ImageIndex").Value
                            SetupFilesNodes(cnt) = New UltraExplorerBarItem(Node.Attributes.GetNamedItem("NodeName").Value)
                            If Trim(Node.Attributes.GetNamedItem("TableNature").Value) = "" Then
                                SetupFilesNodes(cnt).Text = Node.Attributes.GetNamedItem("TableName").Value
                                SetupFilesNodes(cnt).Key = Nothing
                                SetupFilesNodes(cnt).ToolTipText = Node.Attributes.GetNamedItem("NodeName").Value
                                SetupFilesNodes(cnt).Settings.AppearancesSmall.Appearance.Image = Node.Attributes.GetNamedItem("ImageIndex").Value
                            Else
                                SetupFilesNodes(cnt).Tag = Trim(Node.Attributes.GetNamedItem("TableNature").Value & "." & Node.Attributes.GetNamedItem("TableName").Value)
                                'Tag use for Nature Example: vouchers table name (key) nature SV (tag)
                                SetupFilesNodes(cnt).Key = Trim(Node.Attributes.GetNamedItem("TableNature").Value)
                                'Key use for orignal table selection example: vouchers table name (key)
                                SetupFilesNodes(cnt).Text = Node.Attributes.GetNamedItem("NodeName").Value
                                SetupFilesNodes(cnt).ToolTipText = Node.Attributes.GetNamedItem("NodeName").Value
                                SetupFilesNodes(cnt).Settings.AppearancesSmall.Appearance.Image = Node.Attributes.GetNamedItem("ImageIndex").Value

                            End If
                            cnt += 1
                        End If
                    End If
                End If
            Next Node
            ' Save the modified config file.
            XmlDocument.Save(FileInfo.FullName)
            'If SetupFilesNodes Is Nothing Then
            'ReDim Preserve SetupFilesNodes(1)
            'Return SetupFilesNodes
            'Else
            Return SetupFilesNodes
            'End If

        End Function
#End Region
        Dim Nature As String
        Dim selectedTable As String
        Sub CreatingConfigXmlFile()
            Try
                Dim Asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly
                Dim strConfigLoc As String
                strConfigLoc = Asm.Location
                Dim mConnectionString As String
                ' The config file is located in the application's bin directory, so
                ' you need to remove the file name.
                Dim strTemp As String
                strTemp = strConfigLoc
                strTemp = System.IO.Path.GetDirectoryName(strConfigLoc)

                ' Declare a FileInfo object for the config file.
                'Dim FileInfo As System.IO.FileInfo = New System.IO.FileInfo(strTemp & "\" & XMLExeConfigeFile)
                ' Load the config file into the XML DOM.
                'Dim XmlDocument As New System.Xml.XmlDocument
                'XmlDocument.Load(FileInfo.FullName)

                Dim DataComConnection As New AzamTechnologies.Database.DataConnection
                mConnectionString = DataComConnection.ConnectionString


                Dim sr As StreamWriter
                If Not File.Exists(strTemp & "\" & SetupFileName) Then
                    sr = New StreamWriter(SetupFileName)

                    ' Add the XML prolog and Root element
                    sr.WriteLine("<?xml version='1.0' standalone='yes' ?>")
                    sr.WriteLine("<TransformedSetup>")

                    ' Connect to the database
                    Dim cn As SqlConnection = New SqlConnection(mConnectionString)
                    cn.Open()

                    ' Use the For XML Auto clause
                    Dim cmd As New SqlCommand(NodesSelectionQuery, cn)

                    ' Declare the DataReader to read the data
                    Dim dr As SqlDataReader = cmd.ExecuteReader

                    ' Loop thru the DataReader, writing out the file
                    While dr.Read
                        ' Get each chunk of XML as the reader reads it
                        sr.Write(dr(0))
                    End While

                    ' Write the End Element
                    sr.WriteLine("</TransformedSetup>")

                    ' Flush and Close the Stream
                    sr.Flush()
                    sr.Close()
                End If
            Catch ex As FormatException
                Throw New AzamTechnologies.Database.ConnectionException("Connection can't be Established with Server..." & vbCrLf & vbCrLf & "There can be any one of the following problem causes :" & vbCrLf & "-  The Server is busy and not responding." & vbCrLf & "-  There is a problem in accessing network resources." & vbCrLf & "-  The Database / Business Components are not available." & vbCrLf & vbCrLf & "Please contact the System Administrator...")
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Overloads Sub Dispose() Implements IDisposable.Dispose
            ' write ytour clean up code here
            GC.SuppressFinalize(Me)
            Me.MainControl = Nothing
        End Sub
        Protected Overrides Sub Finalize()
            Dispose()
        End Sub
    End Class
End Namespace

