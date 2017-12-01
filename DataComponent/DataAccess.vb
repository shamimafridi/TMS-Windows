Imports System.Data
Imports System.Data.SqlClient
Imports System.EnterpriseServices
Namespace Database
    ' <ComClass(DataAccess.ClassId, DataAccess.InterfaceId, DataAccess.EventsId)> _
    Public Enum DataBases
        Security
        GeneralLedger
        Inventory
        Sale
        MMS
        [Default]
        Current

    End Enum
    Public Class DataAccess
        Private _dataBase As DataBases
        Dim sqlCon As SqlConnection
        Public Sub New(Optional ByVal dataBase As DataBases = DataBases.Current)
            Me.DataBases = dataBase
        End Sub

        '        Inherits EnterpriseServices.ServicedComponent
        '#Region "COM GUIDs"
        '        ' These  GUIDs provide the COM identity for this class 
        '        ' and its COM interfaces. If you change them, existing 
        '        ' clients will no longer be able to access the class.
        '        Public Const ClassId As String = "43DD6641-F0A7-4D23-A9BD-FA2CA43E0B0B"
        '        Public Const InterfaceId As String = "DC2E23BF-D28D-4A52-88CE-3ED4AA160E5C"
        '        Public Const EventsId As String = "5BB23DB8-F202-467A-AD66-79298EDA87ED"
        '#End Region

        '        ' A creatable COM class must have a Public Sub New() 
        '        ' with no parameters, otherwise, the class will not be 
        '        ' registered in the COM registry and cannot be created 
        '        ' via CreateObject.
        '        Public Sub New()
        '            MyBase.New()
        '        End Sub
        ' A creatable COM class must have a Public Sub New() 
        ' with no parameters, otherwise, the class will not be 
        ' registered in the COM registry and cannot be created 
        ' via CreateObject.
        <AutoComplete()> _
        Overloads Sub PopulateDataSet(ByRef data As DataSet, ByVal storedProcedure As String, ByVal ParamArray Parameters() As Object)
            '****************************************************************
            'Create a table in the DataSet and fill it with the specified
            'table in the database from calling a stored procedure or
            'executing a SQL statement (depending on whether
            'blnStoredProcedure is true or false; if true - run stored
            'procedure; if false, run SQL statement).
            '****************************************************************
            data = New DataSet
            Dim con As New Database.DataConnection(Me.DataBases)
            sqlCon = New SqlConnection
            Dim Adapter As SqlDataAdapter
            sqlCon.ConnectionString = con.ConnectionString
            Dim sqlCmd As SqlCommand

            Try
                sqlCmd = New SqlCommand(storedProcedure)
                sqlCmd.CommandType = CommandType.StoredProcedure
                Adapter = New SqlDataAdapter(sqlCmd)
                sqlCmd.Connection = sqlCon
                sqlCmd.Connection.Open()

                Dim Cnt As Integer
                For Cnt = 1 To UBound(Parameters) + 1
                    'If Parameters(Cnt).GetType.ToString = "System.Integer" Then
                    'sqlCmd.Parameters.Add(CType("@" & Parameters(Cnt - 1), String), Parameters(Cnt), SqlDbType.BigInt)
                    sqlCmd.Parameters.AddWithValue(CType("@" & Parameters(Cnt - 1), String), Parameters(Cnt))
                    Cnt += 1
                Next
                Adapter.Fill(data, "Table")
            Catch ex As SqlException
                If ex.Number = 17 Then
                    Throw New ConnectionException("Connection can't be Established with Server..." & vbCrLf & vbCrLf & "There can be any one of the following problem causes :" & vbCrLf & "-  The Server is busy and not responding." & vbCrLf & "-  There is a problem in accessing network resources." & vbCrLf & "-  The Database / Business Components are not available." & vbCrLf & vbCrLf & "Please contact the System Administrator...")
                Else
                    Throw ex
                End If
            Catch ex As DataAccessingException
                Throw ex
            End Try
        End Sub
        Overloads Sub PopulateDataSet(ByRef data As DataSet, ByVal storedProcedure As String, ByRef masterTable As DataTable)
            '****************************************************************
            'Create a table in the DataSet and fill it with the specified
            'table in the database from calling a stored procedure or
            'executing a SQL statement (depending on whether
            'blnStoredProcedure is true or false; if true - run stored
            'procedure; if false, run SQL statement).
            '****************************************************************
            data = New DataSet
            Dim con As New Database.DataConnection(Me.DataBases)
            sqlCon = New SqlConnection
            Dim Adapter As SqlDataAdapter
            sqlCon.ConnectionString = con.ConnectionString
            Dim sqlCmd As SqlCommand

            Try
                sqlCmd = New SqlCommand(storedProcedure)
                sqlCmd.CommandType = CommandType.StoredProcedure
                Adapter = New SqlDataAdapter(sqlCmd)
                sqlCmd.Connection = sqlCon
                sqlCmd.Connection.Open()

                Dim Cnt As Integer
                With masterTable
                    For Cnt = 1 To UBound(masterTable.PrimaryKey) + 1
                        'If Parameters(Cnt).GetType.ToString = "System.Integer" Then
                        'sqlCmd.Parameters.Add(CType("@" & Parameters(Cnt - 1), String), Parameters(Cnt), SqlDbType.BigInt)
                        sqlCmd.Parameters.AddWithValue(CType("@" & .PrimaryKey(Cnt - 1).ToString, String), .Rows(0).Item(.PrimaryKey(Cnt - 1)))
                    Next
                End With
                Adapter.Fill(data)
            Catch ex As SqlException
                If ex.Number = 17 Then
                    Throw New ConnectionException("Connection can't be Established with Server..." & vbCrLf & vbCrLf & "There can be any one of the following problem causes :" & vbCrLf & "-  The Server is busy and not responding." & vbCrLf & "-  There is a problem in accessing network resources." & vbCrLf & "-  The Database / Business Components are not available." & vbCrLf & vbCrLf & "Please contact the System Administrator...")
                Else
                    Throw New DataAccessingException(ex.Message)
                End If
            Finally
                sqlCmd.Connection.Close()
                sqlCmd = Nothing
                sqlCon = Nothing

            End Try

        End Sub
        Sub UnhandledExceptionHandler()
            'Display an error to the user.
            MsgBox("An error occurred. Error Number: " & Err.Number & _
            " Description: " & Err.Description & " Source: " & Err.Source)
        End Sub
        Public Function ExecuteTableQuery(ByVal ExecuteQuery As String) As DataTable
            Dim dtConnection As New DataConnection(Me.DataBases) ''Initializing connection string
            Dim GetCmd As SqlCommand
            Dim adapter As SqlDataAdapter

            sqlCon = New SqlConnection(dtConnection.ConnectionString) 'Creating instance of SQL Connection throw DataConnection
            GetCmd = New SqlCommand(ExecuteQuery, sqlCon)
            GetCmd.CommandType = CommandType.Text



            Dim ColumnMessage As String = String.Empty

            Try
                sqlCon.Open()
                adapter = New SqlDataAdapter(GetCmd)
                Dim table As New DataTable
                adapter.Fill(table)
                Return table
                sqlCon.Close()
                sqlCon = Nothing

                'Return No of row effected
            Catch ex As SqlException
                Throw ex
            Catch ex As FormatException
                'ContextUtil.SetAbort()
                Throw ex
            Catch ex As Exception
                'ContextUtil.SetAbort()
                Throw ex
            Finally
                sqlCon.Close()
                sqlCon = Nothing
                adapter = Nothing
                GetCmd = Nothing
                dtConnection = Nothing
            End Try
        End Function
        Public Function ExecuteStringQuery(ByVal ExecuteQuery As String) As SqlDataReader
            Dim dtConnection As New Database.DataConnection(Me.DataBases) ''Initilizing connectionstring
            Dim GetCmd As SqlCommand
            Dim adapter As SqlDataAdapter




            sqlCon = New SqlConnection(dtConnection.ConnectionString) 'Creating instance of SQL Connection throw DataConnection
            GetCmd = New SqlCommand(ExecuteQuery, sqlCon)
            GetCmd.CommandType = CommandType.Text


            Dim ColumnMessage As String = String.Empty

            Try
                sqlCon.Open()

                Return GetCmd.ExecuteReader
                'sqlCon.Close()
                'sqlCon = Nothing

                'Return No of row effected
            Catch ex As SqlException
                Throw ex
            Catch ex As FormatException
                'ContextUtil.SetAbort()
                Throw ex
            Catch ex As Exception
                'ContextUtil.SetAbort()
                Throw ex
            Finally
                'sqlCon.Close()
                'sqlCon = Nothing
                'adapter = Nothing
                GetCmd = Nothing
                dtConnection = Nothing
            End Try
        End Function
        'Overloads Function GetTable(ByVal fields As String, ByVal tablename As String, Optional ByVal critaria As String = "", Optional ByVal crivalue As String = "") As DataTable
        '    sqlCon = New SqlConnection
        '    Dim sqlCmd As SqlCommand
        '    Try
        '        Dim table As New DataTable
        '        Dim ConStr As String
        '        Dim DataComConnection As New AzamTechnologies.Database.DataConnection
        '        ConStr = DataComConnection.ConnectionString
        '        sqlCon = New SqlConnection(ConStr)
        '        sqlCmd = New SqlCommand
        '        sqlCmd.Connection = sqlCon
        '        sqlCmd.Connection.Open()
        '        Dim adpSearch As New SqlDataAdapter(sqlCmd)
        '        If critaria = "" Then
        '            sqlCmd.CommandText = "SELECT " & fields & " FROM " & tablename
        '        Else
        '            sqlCmd.CommandText = "SELECT " & fields & " FROM " & tablename & " WHERE " & critaria & " = " & crivalue
        '        End If
        '        table.TableName = tablename
        '        adpSearch.Fill(table)

        '        DataComConnection = Nothing
        '        sqlCmd = Nothing
        '        sqlCon = Nothing
        '        Return table
        '    Catch ex As SqlException
        '        If ex.Number = 17 Then
        '            Throw New ConnectionException("Connection can't be Established with Server..." & vbCrLf & vbCrLf & "There can be any one of the following problem causes :" & vbCrLf & "-  The Server is busy and not responding." & vbCrLf & "-  There is a problem in accessing network resources." & vbCrLf & "-  The Database / Business Components are not available." & vbCrLf & vbCrLf & "Please contact the System Administrator...")
        '        Else
        '            UnhandledExceptionHandler()
        '            Return Nothing
        '        End If
        '    End Try
        'End Function
        'Overloads Function GetRecord(ByVal fields As String, ByVal tablename As String, Optional ByVal critaria As String = "", Optional ByVal crivalue As String = "") As SqlDataReader
        '    Dim dReader As SqlClient.SqlDataReader
        '    Dim sqlConCompany As New SqlConnection
        '    Dim sqlCmdComp As SqlCommand
        '    Dim DataComConnection As New Database.DataConnection(Me.DataBases)

        '    Try
        '        sqlCmdComp = New SqlCommand
        '        sqlCmdComp.Connection = New SqlConnection(DataComConnection.ConnectionString)
        '        sqlCmdComp.Connection.Open()
        '        If critaria = "" Then
        '            sqlCmdComp.CommandText = "SELECT " & fields & " FROM " & tablename
        '        Else
        '            sqlCmdComp.CommandText = "SELECT " & fields & " FROM " & tablename & " WHERE " & critaria & " = " & crivalue
        '        End If
        '        '            Dim dd As String = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'"

        '        dReader = sqlCmdComp.ExecuteReader
        '        Return dReader
        '    Catch ex As SqlException
        '        Throw ex
        '    Catch ex As DataAccessingException
        '        Throw New DataAccessingException(ex.Message)
        '    Finally
        '        'sqlCon = Nothing
        '    End Try

        'End Function
        Overloads Function GetRecord(ByVal storedProcedure As String, ByVal ParamArray Parameters() As Object) As SqlDataReader
            Dim dReader As SqlClient.SqlDataReader
            Dim con As New Database.DataConnection(Me.DataBases)
            sqlCon = New SqlConnection
            sqlCon.ConnectionString = con.ConnectionString
            Dim sqlCmd As SqlCommand

            Try
                sqlCmd = New SqlCommand(storedProcedure)
                sqlCmd.CommandType = CommandType.StoredProcedure
                sqlCmd.Connection = sqlCon
                sqlCmd.Connection.Open()
                Dim Cnt As Integer
                For Cnt = 1 To UBound(Parameters) + 1
                    'If Parameters(Cnt).GetType.ToString = "System.Integer" Then
                    'sqlCmd.Parameters.Addwithvalue(CType("@" & Parameters(Cnt - 1), String), Parameters(Cnt), SqlDbType.BigInt)
                    sqlCmd.Parameters.AddWithValue(CType("@" & Parameters(Cnt - 1), String), Parameters(Cnt))
                    Cnt += 1
                Next

                dReader = sqlCmd.ExecuteReader
                Return dReader
                Dim table As New DataTable
                table.Load(table)

            Catch ex As SqlException
                If ex.Number = 17 Then
                    Throw New ConnectionException("Connection can't be Established with Server..." & vbCrLf & vbCrLf & "There can be any one of the following problem causes :" & vbCrLf & "-  The Server is busy and not responding." & vbCrLf & "-  There is a problem in accessing network resources." & vbCrLf & "-  The Database / Business Components are not available." & vbCrLf & vbCrLf & "Please contact the System Administrator...")
                Else
                    UnhandledExceptionHandler()
                    Return Nothing
                End If

            Finally
                sqlCon = Nothing

            End Try



        End Function
        Function GetTable(ByVal fields As String, ByVal tablename As String, Optional ByVal critaria As String = "", Optional ByVal crivalue As String = "") As DataTable
            Dim sqlCon As SqlConnection
            Dim sqlCmd As SqlCommand
            Try
                Dim table As New DataTable
                Dim ConStr As String
                Dim DataComConnection As New AzamTechnologies.Database.DataConnection
                ConStr = DataComConnection.ConnectionString
                sqlCon = New SqlConnection(ConStr)
                sqlCmd = New SqlCommand
                sqlCmd.Connection = sqlCon
                sqlCmd.Connection.Open()
                Dim adpSearch As New SqlDataAdapter(sqlCmd)
                If critaria = "" Then
                    sqlCmd.CommandText = "SELECT " & fields & " FROM " & tablename
                Else
                    sqlCmd.CommandText = "SELECT " & fields & " FROM " & tablename & " WHERE " & critaria & " = " & crivalue
                End If
                table.TableName = tablename
                adpSearch.Fill(table)

                DataComConnection = Nothing
                sqlCmd = Nothing
                sqlCon = Nothing
                Return table
            Catch ex As SqlException
                If ex.Number = 17 Then
                    Throw New ConnectionException("Connection can't be Established with Server..." & vbCrLf & vbCrLf & "There can be any one of the following problem causes :" & vbCrLf & "-  The Server is busy and not responding." & vbCrLf & "-  There is a problem in accessing network resources." & vbCrLf & "-  The Database / Business Components are not available." & vbCrLf & vbCrLf & "Please contact the System Administrator...")
                Else
                    UnhandledExceptionHandler()
                    Return Nothing
                End If
            End Try
        End Function
        Sub HandleDataSetErrors(ByVal dsChanged As DataSet)
            Try
                'Invoke the geterrors method to return an array of DataRow
                'objects with errors.
                Dim ErrorRows() As DataRow
                ErrorRows = GetAllErrors(dsChanged)
                'On each DataRow, examine the RowError property.
                Dim i As Integer
                Dim strError As String
                strError = "The following errors occurred - "
                For i = 0 To ErrorRows.GetUpperBound(0)
                    strError = strError & " Row Error: " & _
                                        ErrorRows(i).RowError()
                Next
                Err.Raise(-5000, , strError)
            Catch
                'Error handling goes here.
                UnhandledExceptionHandler()
            End Try
        End Sub
        Function GetAllErrors(ByVal rsChanges As DataSet) As DataRow()
            Try
                Dim rowsInError() As DataRow = Nothing
                Dim myTable As DataTable
                For Each myTable In rsChanges.Tables
                    ' See if the table has errors. If not, skip it.
                    If myTable.HasErrors Then
                        ' Get an array of all rows with errors.
                        rowsInError = myTable.GetErrors()
                    End If
                Next
                Return rowsInError
            Catch
                'Error handling goes here.
                UnhandledExceptionHandler()
                Return Nothing
            End Try
        End Function
        Public Sub SendProcedureParameters(ByVal StoreProcedureName As String, ByVal UpdateDataSet As DataSet, ByVal SaveMode As Integer, ByVal CurrentRow As Integer)
            Dim Connection As New DataConnection(Me.DataBases)
            'Dim CommandUpdate As New SqlCommand("INSERT INTO Unit(UnitCode,Unit) VALUES(@UnitCode,@Unit)", Connection.GetConnection)
            Dim CommandUpdate As New SqlCommand("InsertUpdateUnit", Connection.GetConnection)
            CommandUpdate.CommandType = CommandType.StoredProcedure
            Dim CountParam As Integer = 0
            Dim ProcedureParamer As SqlParameter
            'Updating Parameters in Command
            If UpdateDataSet.HasChanges Then
                UpdateDataSet = UpdateDataSet.GetChanges
            End If


            Try
                If SaveMode = 0 Then
                    ProcedureParamer = CommandUpdate.Parameters.AddWithValue("@NewRecord", SqlDbType.Int)
                    ProcedureParamer.Value = 1
                Else
                    ProcedureParamer = CommandUpdate.Parameters.AddWithValue("@NewRecord", SqlDbType.Bit)
                    ProcedureParamer.Value = 1
                End If
                With UpdateDataSet.Tables(0)
                    For CountParam = 0 To .Columns.Count - 1

                        ProcedureParamer = CommandUpdate.Parameters.AddWithValue("@" & .Columns(CountParam).ToString, .Rows(CurrentRow).Item(CountParam).GetType)
                        ProcedureParamer.Value = "RRRR"
                    Next

                    Connection.GetConnection.Open()
                    CommandUpdate.ExecuteNonQuery()
                End With
            Catch ex As SqlException
                UnhandledExceptionHandler()
            End Try
        End Sub


        Protected Overrides Sub Finalize()
            If Not IsNothing(sqlCon) Then
                If sqlCon.State = ConnectionState.Open Then
                    sqlCon = Nothing
                End If
                sqlCon = Nothing
            End If

            MyBase.Finalize()

        End Sub
        Public Property DataBases() As DataBases
            Get
                Return _dataBase
            End Get
            Set(ByVal value As DataBases)
                _dataBase = value
            End Set
        End Property
    End Class
    Public Class DataAccessingException
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



