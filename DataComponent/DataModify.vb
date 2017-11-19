Option Explicit On
Imports System.Data.SqlClient
Imports System.EnterpriseServices
Namespace Database
    ' <Transaction(TransactionOption.RequiresNew), ObjectPooling(True, 5, 10), ComClass(DataModify.ClassId, DataModify.InterfaceId, DataModify.EventsId)> _
    Public Class DataModify
        '        Inherits ServicedComponent
        '#Region "COM GUIDs"
        '        ' These  GUIDs provide the COM identity for this class 
        '        ' and its COM interfaces. If you change them, existing 
        '        ' clients will no longer be able to access the class.
        '        Public Const ClassId As String = "D74F2167-3EF1-4E28-9439-8CA3B6EB51BE"
        '        Public Const InterfaceId As String = "D232CFA7-E581-4D41-B2F6-3C3E72B7BCBD"
        '        Public Const EventsId As String = "760FF3E3-56FC-471A-AD3A-19E64DCB396E"
        '#End Region
        '        ' A creatable COM class must have a Public Sub New() 
        '        ' with no parameters, otherwise, the class will not be 
        '        ' registered in the COM registry and cannot be created 
        '        ' via CreateObject.
        '        Public Sub New()
        '            MyBase.New()
        '        End Sub
        Public Enum UpdateMode
            Insert
            Update
        End Enum
        Public Event MessageGenerated(ByVal Message As String)
        Private WithEvents masterTable As DataTable
        Private WithEvents detailTable As DataTable
#Region " Update A Single record or rows"
        <AutoComplete(True)> _
        Public Function UpdateData(ByVal storeProcedureName As String, ByRef updatedData As DataSet, ByVal saveMode As UpdateMode) As Integer
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'The purpose of this procedure to update or insert a DataSet in a table throw stored procedure
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            Try
                'Updating Parameters in Command
                If updatedData.HasChanges(DataRowState.Added) Then
                    Dim dsChangedDataSet As DataSet
                    dsChangedDataSet = updatedData.GetChanges(DataRowState.Added)
                    If dsChangedDataSet.HasErrors Then
                        HandleDataSetErrors(dsChangedDataSet)
                    Else
                        'Update the changes in the database.
                        UpdateDataSet(storeProcedureName, dsChangedDataSet, saveMode)
                        updatedData = dsChangedDataSet
                        ''ContextUtil.SetComplete()
                        Return 1
                    End If
                End If

            Catch ex As SqlException
                'ContextUtil.SetAbort()
                If ex.Number = 17 Then
                    Throw New ConnectionException("Connection can't be Established with Server..." & vbCrLf & vbCrLf & "There can be any one of the following problem causes :" & vbCrLf & "-  The Server is busy and not responding." & vbCrLf & "-  There is a problem in accessing network resources." & vbCrLf & "-  The Database / Business Components are not available." & vbCrLf & vbCrLf & "Please contact the System Administrator...")
                Else
                    Throw New UpdatingException(ex.Message)
                End If
                RaiseEvent MessageGenerated(ex.Message)
            Catch exf As FormatException
                'ContextUtil.SetAbort()
                RaiseEvent MessageGenerated(exf.Message)
            End Try
        End Function
        <AutoComplete(True)> _
      Public Function UpdateExecuteQuery(ByVal ExecuteQuery As String) As Integer
            Dim dtConnection As New DataConnection ''Initilizing connectionstring
            Dim updateCmd As SqlCommand
            Dim adapter As SqlDataAdapter
            Dim sqlCon As SqlConnection



            sqlCon = New SqlConnection(dtConnection.ConnectionString) 'Creating instance of SQL Connection throw DataConnection
            updateCmd = New SqlCommand(ExecuteQuery, sqlCon)
            updateCmd.CommandType = CommandType.Text

            Dim ColumnMessage As String = String.Empty

            Try
                sqlCon.Open()

                Return updateCmd.ExecuteNonQuery()
                sqlCon.Close()
                sqlCon = Nothing

                'Return No of row effected
            Catch ex As SqlException
                If ex.Number = 547 Then
                    'MessageBox.Show("Parent File doesn't containe this record that you specified in this File", "Foregin Key Conflict")
                    'ContextUtil.SetAbort()
                    Throw New UpdatingException("Parent File doesn't containe this record that you specified in this File")
                ElseIf ex.Number = 2627 Then
                    MessageBox.Show("You Enter a Code Or Description which is already defined" & vbCrLf & "Please enter other code")
                    'ContextUtil.SetAbort()
                    Throw New UpdatingException("You Enter a Code Or Description which is already defined" & vbCrLf & "Please enter other code")
                ElseIf ex.Number = 17 Then  ''Connection error
                    'ContextUtil.SetAbort()
                    Throw New AzamTechnologies.Database.ConnectionException("Connection can't be Established with Server..." & vbCrLf & vbCrLf & "There can be any one of the following problem causes :" & vbCrLf & "-  The Server is busy and not responding." & vbCrLf & "-  There is a problem in accessing network resources." & vbCrLf & "-  The Database / Business Components are not available." & vbCrLf & vbCrLf & "Please contact the System Administrator...")
                Else
                    'ContextUtil.SetAbort()
                    Throw ex
                End If
            Catch ex As FormatException
                'ContextUtil.SetAbort()
                Throw ex
            Catch ex As Exception
                'ContextUtil.SetAbort()
                Throw ex
            Finally
                sqlCon = Nothing
                adapter = Nothing
                updateCmd = Nothing
                dtConnection = Nothing
            End Try
        End Function
        <AutoComplete(True)> _
        Private Function UpdateDataSet(ByVal storeProcedure As String, ByRef updatedData As DataSet, ByVal saveMode As UpdateMode) As SqlDataReader
            Dim dtConnection As New DataConnection ''Initilizing connectionstring
            Dim updateCmd As SqlCommand
            Dim adapter As SqlDataAdapter
            Dim UpdateParameters As SqlParameter
            Dim sqlCon As SqlConnection
            Dim CountParam As Int16
            Dim rowCount As Integer

            masterTable = updatedData.Tables(0)
            sqlCon = New SqlConnection(dtConnection.ConnectionString) 'Creating instance of SQL Connection throw DataConnection
            adapter = New SqlDataAdapter
            updateCmd = New SqlCommand(storeProcedure, sqlCon)
            updateCmd.CommandType = CommandType.StoredProcedure
            'adapter.InsertCommand = updateCmd

            Dim ColumnMessage As String = String.Empty

            Try
                If saveMode = UpdateMode.Insert Then
                    UpdateParameters = updateCmd.Parameters.AddWithValue("@NewRecord", SqlDbType.Int)
                    UpdateParameters.Value = 1
                Else
                    UpdateParameters = updateCmd.Parameters.AddWithValue("@NewRecord", SqlDbType.Bit)
                    UpdateParameters.Value = 0
                End If
                With masterTable
                    For CountParam = 0 To masterTable.Columns.Count - 1
                        UpdateParameters = updateCmd.Parameters.AddWithValue("@" & masterTable.Columns(CountParam).ToString, masterTable.Columns(CountParam).DataType)

                        ColumnMessage = ColumnMessage & " " & UpdateParameters.ToString

                        For rowCount = 0 To .Rows.Count - 1
                            UpdateParameters.Value = .Rows(rowCount).Item(CountParam)    'Returning the value through the Key 
                            ColumnMessage = ColumnMessage & " = " & .Rows(rowCount).Item(CountParam) & ", "
                        Next
                    Next
                End With

                sqlCon.Open()
                Dim reader As SqlDataReader
                reader = updateCmd.ExecuteReader ''TO GET THE AUTO GENERATED NO'S AFTER UPDATION
                Dim intCnt As Integer
                If Not IsNothing(reader) Then
                    If reader.HasRows Then
                        reader.Read()
                        For intCnt = 0 To updatedData.Tables(0).Rows.Count - 1
                            updatedData.Tables(0).Rows(intCnt).Item(reader.GetName(0)) = reader.GetString(0)
                        Next
                        updatedData.AcceptChanges()
                    End If
                End If

                'LogGenerator.CreateLog(ColumnMessage, masterTable.TableName & saveMode.ToString, 0, EventLogEntryType.Information)
                ' ContextUtil.SetComplete()
                Return reader
                'Return No of row effected
            Catch ex As SqlException
                If ex.Number = 547 Then
                    'MessageBox.Show("Parent File doesn't containe this record that you specified in this File", "Foregin Key Conflict")
                    'ContextUtil.SetAbort()
                    Throw New UpdatingException("Parent File doesn't containe this record that you specified in this File")
                ElseIf ex.Number = 2627 Then
                    MessageBox.Show("You Enter a Code Or Description which is already defined" & vbCrLf & "Please enter other code")
                    'ContextUtil.SetAbort()
                    Throw New UpdatingException("You Enter a Code Or Description which is already defined" & vbCrLf & "Please enter other code")
                ElseIf ex.Number = 17 Then  ''Connection error
                    'ContextUtil.SetAbort()
                    Throw New AzamTechnologies.Database.ConnectionException("Connection can't be Established with Server..." & vbCrLf & vbCrLf & "There can be any one of the following problem causes :" & vbCrLf & "-  The Server is busy and not responding." & vbCrLf & "-  There is a problem in accessing network resources." & vbCrLf & "-  The Database / Business Components are not available." & vbCrLf & vbCrLf & "Please contact the System Administrator...")
                Else
                    'ContextUtil.SetAbort()
                    Throw ex
                End If
            Catch ex As FormatException
                'ContextUtil.SetAbort()
                Throw ex
            Catch ex As Exception
                'ContextUtil.SetAbort()
                Throw ex
            Finally
                sqlCon = Nothing
                adapter = Nothing
                updateCmd = Nothing
                dtConnection = Nothing
            End Try
        End Function
#End Region
#Region " Delete records or rows"
        <AutoComplete(True)> _
        Public Function DeleteDataSet(ByVal deleteStoreProcedureName As String, ByRef dsDeleted As DataSet) As Integer
            Dim dtConnection As DataConnection
            Dim deleteCmd As SqlCommand
            Dim deleteParameter As SqlParameter
            Dim cntParam As Int16 = 0
            Dim rowCount As Integer
            Dim sqlCon As SqlConnection


            Try
                dtConnection = New DataConnection ''Initilizing connectionstring
                sqlCon = New SqlConnection(dtConnection.ConnectionString)
                masterTable = dsDeleted.Tables(0)
                deleteCmd = New SqlCommand(deleteStoreProcedureName, sqlCon)
                deleteCmd.CommandType = CommandType.StoredProcedure
                Dim ColumnMessage As String = String.Empty
                For cntParam = 0 To masterTable.PrimaryKey.Length - 1
                    deleteParameter = deleteCmd.Parameters.AddWithValue("@" & masterTable.PrimaryKey(cntParam).ToString, masterTable.PrimaryKey(cntParam).DataType)
                    ColumnMessage = ColumnMessage & " " & deleteParameter.ToString
                    For rowCount = 0 To masterTable.Rows.Count - 1
                        '    deleteParameter.Value = .Rows(rowCount).Item(CountParam)    'Returning the value through the Key 
                        deleteParameter.Value = masterTable.Rows(rowCount).Item(masterTable.PrimaryKey(cntParam))
                        ColumnMessage = ColumnMessage & " = " & masterTable.Rows(rowCount).Item(masterTable.PrimaryKey(cntParam)) & ", "
                    Next
                Next

                sqlCon.Open()
                ' LogGenerator.CreateLog(ColumnMessage, dsDeleted.Tables(0).TableName & "Delete", 0, EventLogEntryType.Information)
                deleteCmd.ExecuteNonQuery()
                'ContextUtil.SetComplete()
                Return 1 ''Delete succusfully

                'Return adapter.Update(dsDeleted, dsDeleted.Tables(0).TableName)
                'Return No of row effected
            Catch ex As SqlException
                'ContextUtil.SetAbort()
                If ex.Number = 547 Then
                    Throw ex
                ElseIf ex.Number = 17 Then
                    Throw New ConnectionException("Connection can't be Established with Server..." & vbCrLf & vbCrLf & "There can be any one of the following problem causes :" & vbCrLf & "-  The Server is busy and not responding." & vbCrLf & "-  There is a problem in accessing network resources." & vbCrLf & "-  The Database / Business Components are not available." & vbCrLf & vbCrLf & "Please contact the System Administrator...")
                Else
                    Throw ex
                End If
            Catch ex As FormatException
                'ContextUtil.SetAbort()
                Throw ex
            Finally
                sqlCon = Nothing
                deleteCmd = Nothing
                dtConnection = Nothing
            End Try
        End Function
#End Region
#Region " Update A Multiple records or rows"
        <AutoComplete(True)> _
        Public Function UpdateDetailData(ByVal storeProcedureName1 As String, ByVal storeProcedureName2 As String, ByVal deleteStoreProcedureName As String, ByRef updatedData1 As DataSet, ByRef updatedData2 As DataSet, ByVal saveMode As Integer) As Integer
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'The purpose of this procedure to update or master and detail insert a DataSets  throw stored procedure
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            Dim rowsAffected As Integer
            Try
                'Updating Parameters in Command
                If updatedData1.HasChanges(DataRowState.Added) Then
                    Dim dsChangedDataSet As DataSet
                    dsChangedDataSet = updatedData1.GetChanges(DataRowState.Added)
                    If dsChangedDataSet.HasErrors Then
                        HandleDataSetErrors(dsChangedDataSet)
                    Else
                        'Update the changes in the database.
                        Dim reader As SqlDataReader
                        reader = UpdateDataSet(storeProcedureName1, dsChangedDataSet, saveMode)
                        DeleteDataSet(deleteStoreProcedureName, updatedData1)
                        updatedData1 = dsChangedDataSet
                        Dim intCnt As Integer

                        If Not IsNothing(reader) Then
                            If reader.HasRows Then
                                For intCnt = 0 To updatedData2.Tables(0).Rows.Count - 1
                                    updatedData2.Tables(0).Rows(intCnt).Item(reader.GetName(0)) = reader.GetString(0)
                                Next
                                updatedData2.AcceptChanges()
                            End If
                        End If
                        rowsAffected += UpdateDetailDataSet(storeProcedureName1, storeProcedureName2, deleteStoreProcedureName, updatedData2, saveMode)

                        'ContextUtil.SetComplete()
                        Return rowsAffected
                    End If
                End If
            Catch ex As SqlException
                'ContextUtil.SetAbort()
                If ex.Number = 17 Then
                    Throw New ConnectionException("Connection can't be Established with Server..." & vbCrLf & vbCrLf & "There can be any one of the following problem causes :" & vbCrLf & "-  The Server is busy and not responding." & vbCrLf & "-  There is a problem in accessing network resources." & vbCrLf & "-  The Database / Business Components are not available." & vbCrLf & vbCrLf & "Please contact the System Administrator...")
                Else
                    'ContextUtil.SetAbort()
                    Throw New UpdatingException("Data couldn't save, please contact administrator! " & vbCrLf & ex.Message)
                End If
            Catch ex As System.Runtime.InteropServices.COMException
                'ContextUtil.SetAbort()
                Throw New UpdatingException
            Catch ex As FormatException
                'ContextUtil.SetAbort()
                Throw New UpdatingException
            Catch ex As Exception
                'ContextUtil.SetAbort()
                Throw New UpdatingException("Error While Updating Please Contact Administrator" & vbCrLf & ex.Message)
            End Try
        End Function
        Private Function UpdateDetailDataSet(ByVal storeProcedure1 As String, ByVal storeProcedure2 As String, ByVal deleteStoreProcedure As String, ByRef updatedData As DataSet, ByVal saveMode As UpdateMode) As Integer
            Dim dtConnection As New DataConnection ''Initilizing connectionstring
            Dim updateCmd As SqlCommand
            'Dim adapter As SqlDataAdapter
            Dim UpdateParameters As SqlParameter
            Dim CountParam As Int16
            Dim rowCount As Integer
            Dim affRows As Integer
            Dim sqlCon As SqlConnection
            masterTable = updatedData.Tables(0)
            sqlCon = New SqlConnection
            sqlCon.ConnectionString = dtConnection.ConnectionString 'Creating instance of SQL Connection throw DataConnection
            'adapter = New SqlDataAdapter
            updateCmd = New SqlCommand(storeProcedure2, sqlCon)
            updateCmd.CommandType = CommandType.StoredProcedure
            ' adapter.InsertCommand = updateCmd
            Try
                sqlCon.Open()
                With masterTable
                    For rowCount = 0 To .Rows.Count - 1
                        updateCmd.Parameters.Clear()
                        If saveMode = UpdateMode.Insert Then
                            UpdateParameters = updateCmd.Parameters.Add("@NewRecord", SqlDbType.Int)
                            UpdateParameters.Value = 1
                        Else
                            UpdateParameters = updateCmd.Parameters.Add("@NewRecord", SqlDbType.Bit)
                            UpdateParameters.Value = 1
                        End If
                        For CountParam = 0 To .Columns.Count - 1
                            UpdateParameters = updateCmd.Parameters.AddWithValue("@" & .Columns(CountParam).ToString, .Columns(CountParam).DataType)
                            UpdateParameters.Value = .Rows(rowCount).Item(CountParam)    'Returning the value through the Key 
                        Next
                        affRows += updateCmd.ExecuteNonQuery()
                    Next
                End With
                Return affRows
            Catch ex As SqlException
                Throw ex
            Catch ex As FormatException
                Throw ex
            Finally
                sqlCon = Nothing
                updateCmd = Nothing
                dtConnection = Nothing
            End Try
        End Function
#End Region
       
#Region "Handles Errors"
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
        Sub UnhandledExceptionHandler()
            'Display an error to the user.
            MsgBox("An error occurred. Error Number: " & Err.Number & _
            " Description: " & Err.Description & " Source: " & Err.Source)
        End Sub
#End Region
        Protected Overrides Sub Finalize()
            MyBase.Finalize()
            'sqlCon = Nothing
            masterTable = Nothing
            detailTable = Nothing
        End Sub

    End Class
    Public Class UpdatingException

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


