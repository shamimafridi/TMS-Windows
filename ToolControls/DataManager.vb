Imports System.Windows.Forms
Imports System.Drawing
Public Class DataManager
    '***********************************************************************
    'The purpose of this control is to manage the data (insert,update,delete ,lock, e.t.c.)
    'we must have to set the following properties of the active form (client entry form).
    '1 )  .Tag =Insert or Edit etc.
    '2 )  .AccissableName=Must have same as table name in database

    '***********************************************************************
    Inherits Windows.Forms.ToolStrip
    Private WithEvents mActiveForm As Form
    Private Const updateProcedurePrefix As String = "Update"
    Private Const deletProcedurePrefix As String = "Delete"
    Private WithEvents comDataModify As AzamTechnologies.Database.DataModify
    Protected Friend PrimaryKey() As DataColumn
    Private rowsAffected As Integer
    Public Event MessageGenerated(ByVal Message As String)
    Public Event Action(ByVal sender As Object, ByVal e As DataActionEveArgs)
    Public Event Print(ByVal sender As Object, ByVal e As PrintActionEventArgs)
    Public disableColor As Drawing.Color = Drawing.SystemColors.Window

#Region " Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub
    'UserControl overrides dispose to clean up the component list.
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtnLock As System.Windows.Forms.ToolStripButton

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(DataManager))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnNew = New System.Windows.Forms.ToolStripButton
        Me.BtnEdit = New System.Windows.Forms.ToolStripButton
        Me.BtnSave = New System.Windows.Forms.ToolStripButton
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton
        Me.BtnUndo = New System.Windows.Forms.ToolStripButton
        Me.BtnLock = New System.Windows.Forms.ToolStripButton
        Me.BtnPrint = New System.Windows.Forms.ToolStripButton
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'BtnNew
        '
        Me.BtnNew.ImageIndex = 10
        Me.BtnNew.ToolTipText = "Insert new record (Ctrl+N)"
        '
        'BtnEdit
        '
        Me.BtnEdit.ImageIndex = 7
        Me.BtnEdit.ToolTipText = "Edit record (Ctrl+E)"
        '
        'BtnSave
        '
        Me.BtnSave.ImageIndex = 1
        Me.BtnSave.ToolTipText = "Save record (Ctrl+S)"
        '
        'BtnDelete
        '
        Me.BtnDelete.ImageIndex = 2
        Me.BtnDelete.ToolTipText = "Delete record (Ctrl+D)"
        '
        'BtnUndo
        '
        Me.BtnUndo.ImageIndex = 9
        Me.BtnUndo.ToolTipText = "Undon changes in record (Ctrl+U)"
        '
        'BtnLock
        '
        Me.BtnLock.ImageIndex = 5
        Me.BtnLock.ToolTipText = "Lock Recod (Ctrl+L)"
        '
        'BtnPrint
        '
        Me.BtnPrint.ImageIndex = 13
        Me.BtnPrint.ToolTipText = "Print record (Ctrl+P)"
        '
        '
        'DataManager
        '
        Me.AllowDrop = True
        Me.Items.AddRange(New System.Windows.Forms.ToolStripButton() {Me.BtnNew, Me.BtnEdit, Me.BtnSave, Me.BtnDelete, Me.BtnUndo, Me.BtnLock, Me.BtnPrint})
        Me.ImageList = Me.ImageList1
        Me.Size = New System.Drawing.Size(176, 28)

    End Sub
#End Region
    Private Enum Buttons1
        StartSeperator
        [New]
        Edit
        Save
        Delete
        Undo
        Locked
        Print
        EndSeparator
    End Enum
    Public Enum DataMode
        Insert
        Inserting
        Edit
        Save
        Saving
        Delete
        Deleting
        Undo
        Locked
        Print
        Printing
        Posted
    End Enum

    Dim ReportDialoge As PrintDialog
    Public Cancel As Boolean
    Private PrimaryKeyControl() As Control
    Dim PkCount As Int16
    Sub SetPrimaryKeysValues()
        Try
            Dim ctr As Control
            PkCount = 0
            ReDim PrimaryKeyControl(0)
            For Each ctr In mActiveForm.Controls
                If TypeOf ctr Is TabControl Then
                    Dim cont As Int16
                    Dim Tab As TabControl = ctr
                    Dim chCtr As Control
                    For cont = 0 To Tab.TabPages.Count - 1
                        For Each chCtr In Tab.TabPages(cont).Controls
                            If Not IsNothing(chCtr.Tag) Then
                                Dim ctrType As String = chCtr.GetType.ToString
                                If Mid(chCtr.Tag, 1, 2) = "PK" Or Mid(chCtr.Tag, 1, 2) = "CK" Then

                                    ReDim Preserve PrimaryKeyControl(PkCount)
                                    PrimaryKeyControl(PkCount) = chCtr
                                    PkCount = PkCount + 1
                                End If
                            End If
                        Next
                    Next

                Else
                    Dim ctrType As String = ctr.GetType.ToString
                    If Mid(ctr.Tag, 1, 2) = "PK" Or Mid(ctr.Tag, 1, 2) = "CK" Then

                        ReDim Preserve PrimaryKeyControl(PkCount)
                        PrimaryKeyControl(PkCount) = ctr
                        PkCount = PkCount + 1

                    End If
                End If

            Next

            IsPrimaryKeysLocked = False
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

#Region "Deletion  Process"
    Sub DeleteRow()
        Try
            Me.comDataModify = New AzamTechnologies.Database.DataModify
            Dim deletedRow As DataRow
            Dim table As New DataTable(Me.mDirector.TableName)
            deletedRow = table.NewRow
            deletedRow = mDirector.CreateRow(table)
            table.Rows.Add(deletedRow)
            PrimaryKey = table.PrimaryKey

            dsData = New DataSet(mDirector.TableName)
            table.TableName = Me.mDirector.TableName
            dsData.Tables.Add(table)

            rowsAffected = Me.comDataModify.DeleteDataSet(deletProcedurePrefix & mDirector.TableName, dsData)
            If rowsAffected <= 0 Then
                finalActionMessage = startupMessage & " table: " & mDirector.TableName & ", Process: " & DataMode.Delete.ToString & _
                                    middleMessage & vbCrLf & "Delete row(s): Deleting record failed,  No Record Found for Deletion "
            Else
                finalActionMessage = startupMessage & " table: " & mDirector.TableName & ", Process: " & DataMode.Delete.ToString & _
                        middleMessage & vbCrLf & "Delete row(s): " & rowsAffected & " succeeded, 0 failed, 0 skipped"
                DeleteReferenceProcess(table.TableName)
            End If

            RaiseEvent MessageGenerated(finalActionMessage)
            dsData.AcceptChanges()
        Catch ex As SqlClient.SqlException
            If ex.Number = 547 Then
                MessageBox.Show("The COA Code is exist already in some Transaction therefor can not deleted", "Deleting Record", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show(ex.Message, "Deleting Record", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If

        End Try

    End Sub
#End Region

    Private Sub DataManager_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If IsPosted = True Then Exit Sub
        If e.Control = True And e.KeyCode = Keys.S Then
            BtnSave_Click(sender, e)
        ElseIf e.Control = True And e.KeyCode = Keys.N Then
            BtnNew_Click(sender, e)
        ElseIf e.Control = True And e.KeyCode = Keys.L Then
            BtnLock_Click(sender, e)
        ElseIf e.Control = True And e.KeyCode = Keys.E Then
            BtnEdit_Click(sender, e)
        ElseIf e.Control = True And e.KeyCode = Keys.D Then
            BtnDelete_Click(sender, e)
        ElseIf e.Control = True And e.KeyCode = Keys.P Then
            BtnPrint_Click(sender, e)
        ElseIf e.Control = True And e.KeyCode = Keys.U Then
            BtnUndo_Click(sender, e)
        End If
        mDirector.DataDirector_KeyDown(sender, e)
    End Sub
    Public IsPosted As Boolean = False
    Sub EnableDisable(ByVal posted As Boolean)
        IsPosted = posted
        If posted = True Then
            BtnEdit.Enabled = False
            BtnDelete.Enabled = False
            BtnSave.Enabled = False
            BtnUndo.Enabled = False
            BtnLock.Enabled = False
            Me.ActiveForm.Tag = DataManager.DataMode.Posted
        Else
            BtnEdit.Enabled = True
            BtnDelete.Enabled = True
            BtnSave.Enabled = True
            BtnUndo.Enabled = True
            BtnLock.Enabled = True
            If Me.ActiveForm.Tag <> DataManager.DataMode.Locked Then
                Me.ActiveForm.Tag = DataManager.DataMode.Inserting
            End If
        End If
    End Sub
    Public Property ActiveForm() As Form
        Get
            Return mActiveForm
        End Get
        Set(ByVal Value As Form)
            If Not IsNothing(Value) Then
                mActiveForm = Value
            End If
        End Set
    End Property
#Region "Locked and Unlocked controls"
    Friend Sub LockControl(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        e.Handled = True
    End Sub
    Friend Sub LockControl(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub
    Public Property DisableControlColor() As Drawing.Color
        Get
            Return Me.disableColor
        End Get
        Set(ByVal value As Drawing.Color)
            Me.disableColor = value
        End Set
    End Property

    Dim IsPrimaryKeysLocked As Boolean
    Friend Sub UnlockControls(ByVal action As DataMode)
        ''''''''''Initialized the controls for new adding records'''''''''''''''''
        Try
            Dim ctrType As String
            Dim ctr As Control

            For Each ctr In mActiveForm.Controls
                If TypeOf ctr Is TabControl Then

                    ''''''''Tab control found
                    Dim tab As TabControl = ctr
                    Dim chCtr As Control
                    Dim cont As Int16
                    For cont = 0 To tab.TabPages.Count - 1
                        For Each chCtr In tab.TabPages(cont).Controls
                            ctrType = chCtr.GetType.ToString
                            If Not IsNothing(chCtr.Tag) Or ctrType = "FarPoint.Win.Spread.FpSpread" Then
                                If ctrType = "Infragistics.Win.UltraWinEditors.UltraTextEditor" Or ctrType = "System.Windows.Forms.ComboBox" _
                                          Or ctrType = "System.Windows.Forms.ListBox" Or ctrType = "ATUrduTextBox.UrduTextBox" Or ctrType = "Infragistics.Win.UltraWinGrid.UltraCombo" Then
                                    chCtr.BackColor = Drawing.SystemColors.Control
                                    ctr.Enabled = True
                                ElseIf ctrType = "System.Windows.Forms.RadioButton" Then
                                    ctr.Enabled = True
                                ElseIf ctrType = "Infragistics.Win.UltraWinEditors.UltraCheckEditor" Then
                                    ctr.Enabled = True
                                ElseIf ctrType = "System.Windows.Forms.CheckBox" Then
                                    ctr.Enabled = True
                                ElseIf ctrType = "System.Windows.Forms.NumericUpDown" Then
                                    chCtr.BackColor = Me.DisableControlColor
                                    CType(chCtr, NumericUpDown).Enabled = True
                                ElseIf ctrType = "FarPoint.Win.Spread.FpSpread" Then
                                    CType(chCtr, FarPoint.Win.Spread.FpSpread).Enabled = True
                                ElseIf ctrType = "System.Windows.Forms.DateTimePicker" Then
                                    chCtr.Enabled = True
                                Else
                                    chCtr.Enabled = True

                                End If
                            End If
                        Next
                    Next


                Else

                    ctrType = ctr.GetType.ToString
                    If Not IsNothing(ctr.Tag) Or ctrType = "FarPoint.Win.Spread.FpSpread" Then

                        If ctrType = "Infragistics.Win.UltraWinEditors.UltraTextEditor" Or ctrType = "System.Windows.Forms.ComboBox" _
                                  Or ctrType = "System.Windows.Forms.ListBox" Or ctrType = "ATUrduTextBox.UrduTextBox" Or ctrType = "Infragistics.Win.UltraWinGrid.UltraCombo" Then
                            ctr.BackColor = Drawing.SystemColors.Window
                            ctr.Enabled = True
                        ElseIf ctrType = "System.Windows.Forms.RadioButton" Then
                            ctr.Enabled = True
                        ElseIf ctrType = "System.Windows.Forms.CheckBox" Then
                            ctr.Enabled = True
                        ElseIf ctrType = "Infragistics.Win.UltraWinEditors.UltraCheckEditor" Then
                            ctr.Enabled = True
                        ElseIf ctrType = "System.Windows.Forms.NumericUpDown" Then
                            ctr.BackColor = Drawing.SystemColors.Window
                            CType(ctr, NumericUpDown).Enabled = True
                        ElseIf ctrType = "FarPoint.Win.Spread.FpSpread" Then
                            'CType(ctr, FarPoint.Win.Spread.FpSpread).Enabled = True
                            Dim iSheet As Integer
                            For iSheet = 0 To CType(ctr, FarPoint.Win.Spread.FpSpread).Sheets.Count - 1
                                CType(ctr, FarPoint.Win.Spread.FpSpread).Sheets(iSheet).OperationMode = FarPoint.Win.Spread.OperationMode.Normal
                            Next
                        ElseIf ctrType = "System.Windows.Forms.DateTimePicker" Then
                            ctr.Enabled = True
                            'RemoveHandler ctr.KeyPress, AddressOf LockControl
                            'RemoveHandler ctr.KeyDown, AddressOf LockControl
                        Else
                            ctr.Enabled = True
                        End If
                        If action = DataMode.Edit Then
                            If Mid(ctr.Tag, 1, 2) = "PK" Or Mid(ctr.Tag, 1, 2) = "CK" Then
                                ctr.Enabled = False
                                ctr.BackColor = Me.DisableControlColor
                                IsPrimaryKeysLocked = True
                            End If
                        End If
                End If
                    End If

            Next
            LockControls = False
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
    Friend Sub UnlockPrimaryKeyControls()
        ''''''''''Initialized the controls for new adding records'''''''''''''''''
        Try
            Dim ctr As Control

            For Each ctr In mActiveForm.Controls
                If TypeOf ctr Is TabControl Then
                    Dim cont As Int16
                    Dim Tab As TabControl = ctr
                    Dim chCtr As Control
                    For cont = 0 To Tab.TabPages.Count - 1
                        For Each chCtr In Tab.TabPages(cont).Controls
                            If Not IsNothing(chCtr.Tag) Then
                                Dim ctrType As String = chCtr.GetType.ToString
                                If Mid(chCtr.Tag, 1, 2) = "PK" Or Mid(chCtr.Tag, 1, 2) = "CK" Then
                                    chCtr.Enabled = True
                                    IsPrimaryKeysLocked = True
                                End If
                            End If
                        Next
                    Next

                Else
                    Dim ctrType As String = ctr.GetType.ToString
                    If Mid(ctr.Tag, 1, 2) = "PK" Or Mid(ctr.Tag, 1, 2) = "CK" Then
                        ctr.Enabled = True
                        IsPrimaryKeysLocked = True
                    End If
                End If

            Next

            IsPrimaryKeysLocked = False
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
    Friend mLockedControl As Boolean
    Public Property LockControls() As Boolean
        Get
            Return mLockedControl
        End Get
        Set(ByVal Value As Boolean)
            mLockedControl = Value
        End Set
    End Property
    Friend Sub LockedControls()
        ''''''''''Initialized the controls for new adding records'''''''''''''''''
        Dim ctrType As String
        Try
            Dim ctr As Control
            For Each ctr In mActiveForm.Controls
                If TypeOf ctr Is TabControl Then
                    ''''''''Tab control found
                    Dim tab As TabControl = ctr
                    Dim chCtr As Control
                    Dim cont As Int16
                    For cont = 0 To tab.TabPages.Count - 1
                        For Each chCtr In tab.TabPages(cont).Controls
                            ctrType = ctr.GetType.ToString
                            If Not IsNothing(chCtr.Tag) Or ctrType = "FarPoint.Win.Spread.FpSpread" Then
                                If ctrType = "Infragistics.Win.UltraWinEditors.UltraTextEditor" Or ctrType = "System.Windows.Forms.ComboBox" _
                                          Or ctrType = "System.Windows.Forms.ListBox" Or ctrType = "ATUrduTextBox.UrduTextBox" Or ctrType = "Infragistics.Win.UltraWinGrid.UltraCombo" Then
                                    ctr.BackColor = Me.DisableControlColor
                                    ctr.Enabled = False
                                ElseIf ctrType = "System.Windows.Forms.RadioButton" Then
                                    ctr.Enabled = False
                                ElseIf ctrType = "System.Windows.Forms.CheckBox" Then
                                    ctr.Enabled = False
                                ElseIf ctrType = "Infragistics.Win.UltraWinEditors.UltraCheckEditor" Then
                                    ctr.Enabled = False
                                ElseIf ctrType = "System.Windows.Forms.NumericUpDown" Then
                                    ctr.BackColor = Me.DisableControlColor
                                    CType(ctr, NumericUpDown).Enabled = True
                                ElseIf ctrType = "FarPoint.Win.Spread.FpSpread" Then
                                    CType(chCtr, FarPoint.Win.Spread.FpSpread).Enabled = False
                                ElseIf ctrType = "System.Windows.Forms.DateTimePicker" Then
                                    chCtr.Enabled = False
                                Else
                                    chCtr.Enabled = False
                                    'AddHandler chCtr.KeyPress, AddressOf LockControl
                                    'AddHandler chCtr.KeyDown, AddressOf LockControl
                                End If
                            End If
                        Next
                    Next
                Else
                    ctrType = ctr.GetType.ToString
                    If Not IsNothing(ctr.Tag) Or ctrType = "FarPoint.Win.Spread.FpSpread" Then

                        If ctrType = "Infragistics.Win.UltraWinEditors.UltraTextEditor" Or ctrType = "System.Windows.Forms.ComboBox" _
                                  Or ctrType = "System.Windows.Forms.ListBox" Or ctrType = "ATUrduTextBox.UrduTextBox" Or ctrType = "Infragistics.Win.UltraWinGrid.UltraCombo" Then
                            ctr.BackColor = Me.DisableControlColor
                            ctr.Enabled = False
                            If ctrType = "Infragistics.Win.UltraWinEditors.UltraTextEditor" Then

                                CType(ctr, Infragistics.Win.UltraWinEditors.UltraTextEditor).UseAppStyling = False

                            End If
                        ElseIf ctrType = "System.Windows.Forms.RadioButton" Then
                            ctr.Enabled = False
                        ElseIf ctrType = "System.Windows.Forms.CheckBox" Then
                            ctr.Enabled = False
                        ElseIf ctrType = "Infragistics.Win.UltraWinEditors.UltraCheckEditor" Then
                            ctr.Enabled = False
                        ElseIf ctrType = "System.Windows.Forms.NumericUpDown" Then
                            ctr.BackColor = Me.DisableControlColor
                            CType(ctr, NumericUpDown).Enabled = False
                        ElseIf ctrType = "FarPoint.Win.Spread.FpSpread" Then
                            'CType(ctr, FarPoint.Win.Spread.FpSpread).Enabled = False 'Horizontal & Verticalscroll bar not working when it disable
                            Dim iSheet As Integer
                            For iSheet = 0 To CType(ctr, FarPoint.Win.Spread.FpSpread).Sheets.Count - 1
                                CType(ctr, FarPoint.Win.Spread.FpSpread).Sheets(iSheet).OperationMode = FarPoint.Win.Spread.OperationMode.ReadOnly
                            Next
                        ElseIf ctrType = "System.Windows.Forms.DateTimePicker" Then
                            ctr.Enabled = False
                        Else
                            ctr.Enabled = False
                            'AddHandler ctr.KeyPress, AddressOf LockControl
                            'AddHandler ctr.KeyDown, AddressOf LockControl
                        End If

                    End If
                End If
            Next
            Me.ActiveForm.Tag = DataManager.DataMode.Locked
            LockControls = True
            'RaiseEvent Action(Me, New DataActionEveArgs(DataMode.Locked))
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
#End Region
    Private startupMessage As String = "------ Process started:"
    Private finalActionMessage As String
    Private Const middleMessage As String = vbCrLf & vbCrLf & vbCrLf & "Making connection with database..." & vbCrLf & "Checking rows..." & vbCrLf & "Performing main action.... " & vbCrLf & "---------------------- Done ---------------------- "
    Private newRow As DataRow
    Private dsData As DataSet
    Private dsDetailData As DataSet
    Private mTable As DataTable
    Private mDirector As DataDirector
#Region "Updating Records"
    '  find  if mdirector.mdetaildata is nothing then save just setup master record
    '   else save both master and detail
    '

    'UpdateProcess
    Public Sub UpdateProcess()
        Try
            mTable = New DataTable(mDirector.TableName)
            dsData = New DataSet()
            dsData.DataSetName = mDirector.TableName
            newRow = mTable.NewRow
            comDataModify = New AzamTechnologies.Database.DataModify

            'Validating rows
            Dim validation As New DataValidation(mActiveForm)
            Dim InvalidDataControl As Control = Nothing
            validation.CheckRows()
            '''''''''''''''''''''
            'Creating freshrows and dsData
            newRow = mDirector.CreateRow(mTable)
            mTable.Rows.Add(newRow)
            dsData.Tables.Add(mTable)

            dsDetailData = New DataSet
            dsDetailData = mDirector.FillDetailDataFromGrid()
            If mDirector.mDetailData Is Nothing Then ''Single record saving process
                If UpdateRow() <> 0 Then
                    GenerateReferenceProcess(dsData.DataSetName)
                End If

            Else
                dsDetailData.AcceptChanges()
                'validation.CheckDetailRows(dsDetailData)
                '   setColumnCaption()
                'addPrimaryRowsToDetail()
                ''Add primary keys rows to detail
                If UpdateRows() <> 0 Then
                    GenerateReferenceProcess(dsData.DataSetName)
                End If

            End If
            Me.mActiveForm.Activate()
            Me.mDirector.DefaultPrimaryKeyControl.Focus()
            mTable = Nothing
            newRow = Nothing
            dsData = Nothing

        Catch ex As AzamTechnologies.Database.UpdatingException
            Throw ex
        Catch ex As SqlClient.SqlException
            Throw ex
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Friend Sub DeleteReferenceProcess(ByVal FormName As String)
        Dim Reader As New Xml.XmlTextReader(AppDomain.CurrentDomain.BaseDirectory.ToString & "\GLReferences.xml")
        Reader.ReadToFollowing("GLReferences")
        Do
            If FormName = Reader.GetAttribute("GeneratedFrom") Then
                Dim BusinessMgr As New AzamTechnologies.BusinessManager
                BusinessMgr.DeleteVoucher(dsData, dsDetailData, Reader.GetAttribute("FromGeneratedNature"), Reader.GetAttribute("GeneratedTo"))
                BusinessMgr = Nothing
            End If
        Loop While Reader.ReadToNextSibling("GLReferences")
    End Sub
    Friend Sub GenerateReferenceProcess(ByVal FormName As String)
        Dim Reader As New Xml.XmlTextReader(AppDomain.CurrentDomain.BaseDirectory.ToString & "\GLReferences.xml")
        Reader.ReadToFollowing("GLReferences")
        Do
            If FormName = Reader.GetAttribute("GeneratedFrom") Then
                Dim BusinessMgr As New AzamTechnologies.BusinessManager
                BusinessMgr.GenerateVoucher(dsData, dsDetailData, Reader.GetAttribute("FromGeneratedNature"), Reader.GetAttribute("GeneratedTo"))
                BusinessMgr = Nothing
            End If
        Loop While Reader.ReadToNextSibling("GLReferences")
    End Sub
    Private Sub setColumnCaption()
        'Dim col As DataColumn
        'For Each col In dsDetailData.Tables(0).Columns
        '    If col.ColumnName = "S.No." Then
        '        col.ColumnName = "SNo"
        '    End If
        'Next
    End Sub

    Sub addPrimaryRowsToDetail()
        Dim cnt As Integer
        Dim rnt As Integer
        For cnt = 0 To dsData.Tables(0).PrimaryKey.Length - 1
            For rnt = 0 To dsDetailData.Tables(0).Rows.Count - 1
                'dsDetailData.Tables(0).Rows(rnt).Item(cnt) = dsData.Tables(0).Rows(rnt).Item(cnt)
                dsDetailData.Tables(0).Rows(rnt).Item(dsData.Tables(0).PrimaryKey(cnt).ToString) = dsData.Tables(0).Rows(0).Item(dsData.Tables(0).PrimaryKey(cnt).ToString)
            Next
        Next
    End Sub
    Function UpdateRow() As Integer

        ''Call single row function
        Try
            If Me.mActiveForm.Tag = DataMode.Insert Or Me.mActiveForm.Tag = DataMode.Inserting Then
                rowsAffected = comDataModify.UpdateData(updateProcedurePrefix & mDirector.TableName, dsData, AzamTechnologies.Database.DataModify.UpdateMode.Insert)
                finalActionMessage = startupMessage & " table: " & mDirector.TableName & ", Process: " & DataMode.Insert.ToString & _
                            middleMessage & vbCrLf & "Save All: " & rowsAffected & " succeeded, 0 failed, 0 skipped"

                RaiseEvent MessageGenerated(finalActionMessage)
                'If rowsAffected <> 0 Then 'if not any error occurs
                '    Me.mActiveForm.Tag = DataMode.Locked
                '    Me.LockedControls()
                'End If
            ElseIf Me.mActiveForm.Tag = DataMode.Edit Then
                rowsAffected = comDataModify.UpdateData(updateProcedurePrefix & mDirector.TableName, dsData, AzamTechnologies.Database.DataModify.UpdateMode.Update)
                finalActionMessage = startupMessage & " table: " & mDirector.TableName & ", Process: " & DataMode.Insert.ToString & _
                            middleMessage & vbCrLf & "Save All: " & rowsAffected & " succeeded, 0 failed, 0 skipped"
                RaiseEvent MessageGenerated(finalActionMessage)
            End If

            'dsData.AcceptChanges()
            'mDirector.FillDataSet(dsData) '''Refresh the record when save
            'mDirector.SetData(dsData)   'Showing fresh record on the Form
            '''''''mDirector.oldRow = newRow
            '**************
            'PROBLEM IN REFRESHING WHEN ON NEW INSERT MODE
            '**************
            comDataModify = Nothing
            Return rowsAffected

        Catch ex As AzamTechnologies.Database.ConnectionException
            Throw ex
        Catch ex As AzamTechnologies.Database.UpdatingException
            ' DataComponents.LogGenerator.CreateLog(ex.Message, Me.ActiveForm.Name & "Saving", 0, EventLogEntryType.Error)
            Throw ex
        Catch ex As Exception
            ' DataComponents.LogGenerator.CreateLog(ex.Message, Me.ActiveForm.Name & "Saving", 0, EventLogEntryType.Error)
            Throw ex
        End Try
        '''''Using in Task Slides
        '''''''''Important
        mTable = Nothing
        dsData = Nothing
        comDataModify = Nothing
    End Function
    Friend Function UpdateRows() As Integer
        'comDataModify.UpdateData 
        ''Call single row function
        Try
            If Me.mActiveForm.Tag = DataMode.Insert Or Me.mActiveForm.Tag = DataMode.Inserting Then
                rowsAffected = comDataModify.UpdateDetailData(updateProcedurePrefix & mDirector.TableName, updateProcedurePrefix & mDirector.TableName & "Details", deletProcedurePrefix & mDirector.TableName & "Details", dsData, dsDetailData, AzamTechnologies.Database.DataModify.UpdateMode.Insert)
                finalActionMessage = startupMessage & " table: " & mDirector.TableName & ", Process: " & DataMode.Insert.ToString & _
                            middleMessage & vbCrLf & "Save All: " & rowsAffected & " succeeded, 0 failed, 0 skipped"
                RaiseEvent MessageGenerated(finalActionMessage)
                'If rowsAffected <> 0 Then ''if not any error occure
                '    Me.mActiveForm.Tag = DataMode.Locked
                '    Me.LockedControls()
                'End If
            ElseIf Me.mActiveForm.Tag = DataMode.Edit Then
                rowsAffected = comDataModify.UpdateDetailData(updateProcedurePrefix & mDirector.TableName, updateProcedurePrefix & mDirector.TableName & "Details", deletProcedurePrefix & mDirector.TableName & "Details", dsData, dsDetailData, AzamTechnologies.Database.DataModify.UpdateMode.Update)
                finalActionMessage = startupMessage & " table: " & mDirector.TableName & ", Process: " & DataMode.Insert.ToString & _
                            middleMessage & vbCrLf & "Save All: " & rowsAffected & " succeeded, 0 failed, 0 skipped"
                RaiseEvent MessageGenerated(finalActionMessage)
                'Me.LockedControls()
            End If
            'dsData.AcceptChanges()
            'mDirector.FillDataSet(dsData) '''Refresh the record when save
            'mDirector.SetData(dsData)   'Showing fresh record on the Form
            'mDirector.oldRow = newRow
            '**************
            'PROBLEM IN REFRESHING WHEN ON NEW INSERT MODE
            '**************
            Return rowsAffected
        Catch ex As AzamTechnologies.Database.UpdatingException
            Throw ex
        Catch ex As SqlClient.SqlException
            ' DataComponents.LogGenerator.CreateLog(ex.Message, Me.ActiveForm.Name & "SavingDetail", 0, EventLogEntryType.Error)
            MessageBox.Show(ex.Message, "Saving Data", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            RaiseEvent MessageGenerated(startupMessage & " table: " & mDirector.TableName & ", Process: " & DataMode.Insert.ToString & _
                    middleMessage & vbCrLf & ex.Message)
            Throw ex
        Catch ex As Exception
            Throw ex
        End Try
        '''''Using in Task Slides
        '''''''''Important
        mTable = Nothing
        dsData = Nothing
        comDataModify = Nothing
    End Function
#End Region
    Public WriteOnly Property Director() As DataDirector
        Set(ByVal Value As DataDirector)
            mDirector = Value
        End Set
    End Property
    Private Sub mActiveForm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles mActiveForm.Closed
        newRow = Nothing
        mDirector = Nothing
        comDataModify = Nothing
        mLockedControl = Nothing
        mActiveForm = Nothing
    End Sub
    ''''''''''''''''''''''
#Region "Data Validataion Class"
    Friend Class DataValidation
        Private WithEvents mActiveForm As Form
        Sub New(ByRef activeForm As Form)
            mActiveForm = activeForm
        End Sub
        Friend Sub CheckRows()
            Dim ctr As Control
            For Each ctr In mActiveForm.Controls
                If TypeOf ctr Is TabControl Then
                    Dim tabCantrol As TabControl = ctr
                    Dim cont As Int16
                    Dim chCtr As Control
                    For cont = 0 To CType(ctr, TabControl).TabPages.Count - 1
                        For Each chCtr In tabCantrol.TabPages(cont).Controls
                            Dim ctrType As String = ctr.GetType.ToString
                            If ctr.Tag <> "" Or Not IsNothing(ctr.Tag) Then
                                If Mid(ctr.Tag, 1, 2).ToUpper = "IM" Or Mid(ctr.Tag, 1, 2).ToUpper = "PK" Or Mid(ctr.Tag, 1, 2).ToUpper = "CK" Then
                                    If ctrType = "System.Windows.Forms.TextBox" Or ctrType = "System.Windows.Forms.ComboBox" Or ctrType = "ATUrduTextBox.UrduTextBox" Or ctrType = "Infragistics.Win.UltraWinEditors.UltraTextEditor" _
                                            Or ctrType = "Infragistics.Win.UltraWinEditors.UltraComboEditor" Then
                                        If ctr.Text Is Nothing Or Trim(ctr.Text) = "" Then
                                            'If some one enter empty data
                                            mActiveForm.ActiveControl = ctr
                                            Throw New InvalidDataEntryInformation(" Please Enter a valid " & Mid(ctr.Tag, 4, Len(ctr.Tag)))
                                        End If
                                    End If
                                ElseIf Mid(ctr.Tag, 1, 2).ToUpper = "PK" Or Mid(ctr.Tag, 1, 2).ToUpper = "CK" Then
                                    If ctrType = "System.Windows.Forms.TextBox" Or ctrType = "System.Windows.Forms.ComboBox" Or ctrType = "ATUrduTextBox.UrduTextBox" Or ctrType = "Infragistics.Win.UltraWinEditors.UltraTextEditor" _
                                            Or ctrType = "Infragistics.Win.UltraWinEditors.UltraComboEditor" Then
                                        If ctr.Text.Length <> CType(ctr, TextBox).MaxLength Then
                                            'If some one not provide proper length code
                                            Throw New InvalidDataEntryInformation(" Please Enter a valid length code for " & Mid(ctr.Name, 4, Len(ctr.Name)) & vbCrLf & " Valid length is " & CType(ctr, TextBox).MaxLength.ToString)
                                        End If
                                    End If
                                End If
                            End If
                        Next
                    Next
                Else
                    Dim ctrType As String = ctr.GetType.ToString
                    If ctr.Tag <> "" Or Not IsNothing(ctr.Tag) Then
                        If Mid(ctr.Tag, 1, 2).ToUpper = "IM" Or Mid(ctr.Tag, 1, 2).ToUpper = "PK" Or Mid(ctr.Tag, 1, 2).ToUpper = "CK" Then
                            If ctrType = "System.Windows.Forms.TextBox" Or ctrType = "System.Windows.Forms.ComboBox" Or ctrType = "ATUrduTextBox.UrduTextBox" Or ctrType = "Infragistics.Win.UltraWinEditors.UltraTextEditor" _
                                            Or ctrType = "Infragistics.Win.UltraWinEditors.UltraComboEditor" Then
                                If ctr.Text Is Nothing Or Trim(ctr.Text) = "" Then
                                    'If some one enter empty data
                                    mActiveForm.ActiveControl = ctr
                                    Throw New InvalidDataEntryInformation(" Please Enter a valid " & Mid(ctr.Tag, 4, Len(ctr.Tag)))
                                End If
                            End If
                        ElseIf Mid(ctr.Tag, 1, 2).ToUpper = "PK" Or Mid(ctr.Tag, 1, 2).ToUpper = "CK" Then
                            If ctrType = "System.Windows.Forms.TextBox" Or ctrType = "System.Windows.Forms.ComboBox" Or ctrType = "ATUrduTextBox.UrduTextBox" Or ctrType = "Infragistics.Win.UltraWinEditors.UltraTextEditor" _
                                            Or ctrType = "Infragistics.Win.UltraWinEditors.UltraComboEditor" Then
                                If ctr.Text.Length <> CType(ctr, TextBox).MaxLength Then
                                    'If some one not provide proper length code
                                    Throw New InvalidDataEntryInformation(" Please Enter a valid length code for " & Mid(ctr.Name, 4, Len(ctr.Name)) & vbCrLf & " Valid length is " & CType(ctr, TextBox).MaxLength.ToString)
                                End If
                            End If
                        End If
                    End If
                End If
            Next
        End Sub
        Friend Sub CheckDetailRows(ByRef detailData As DataSet)
            Dim col As DataColumn
            Dim row As DataRow

            With detailData.Tables(0)
                For Each row In .Rows
                    Dim intRow As Integer
                    For Each col In .Columns
                        If (.Columns(col.ToString).AllowDBNull = False) And (.Rows(intRow).Item(col).ToString = String.Empty Or Trim(.Rows(intRow).Item(col).ToString) = "") Then
                            Throw New InvalidDataEntryInformation(" Please Enter a valid " & Mid(col.ToString, 1, Len(col.ToString)))
                        End If
                    Next
                    intRow += 1
                Next

            End With
        End Sub
        Public Class InvalidDataEntryInformation
            Inherits System.ApplicationException
            Sub New()
                MyBase.New()
            End Sub
            Sub New(ByVal message As String)
                MyBase.New(message)
            End Sub
        End Class
    End Class
#End Region
    ''''''''''''''''''''''''
    'Private Sub comDataModify_MessageGenerated(ByVal Message As String) Handles comDataModify.MessageGenerated
    '    RaiseEvent MessageGenerated(Message)
    'End Sub
#Region "Shortcut for clint form to use save,new,lock of data"
    Private Sub mActiveForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mActiveForm.KeyDown
        If IsPosted = True Then Exit Sub
        If e.Control = True And e.KeyCode = Keys.S Then
            BtnSave_Click(sender, e)
        ElseIf e.Control = True And e.KeyCode = Keys.N Then
            BtnNew_Click(sender, e)
        ElseIf e.Control = True And e.KeyCode = Keys.L Then
            BtnLock_Click(sender, e)
        ElseIf e.Control = True And e.KeyCode = Keys.E Then
            BtnEdit_Click(sender, e)
        ElseIf e.Control = True And e.KeyCode = Keys.D Then
            BtnDelete_Click(sender, e)
        ElseIf e.Control = True And e.KeyCode = Keys.P Then
            BtnPrint_Click(sender, e)
        ElseIf e.Control = True And e.KeyCode = Keys.U Then
            BtnUndo_Click(sender, e)
        End If

    End Sub
#End Region
#Region "Button Clicks"
    Public Sub BtnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        If Not IsNothing(mDirector) Then
            RaiseEvent Action(Me, New DataActionEveArgs(DataMode.Insert))
            If IsPrimaryKeysLocked = True Then UnlockPrimaryKeyControls()
            If LockControls = True Then
                UnlockControls(DataMode.Insert)
            End If
            Me.ActiveForm.Tag = DataMode.Insert
            mDirector.InitalizeActiveFormComponents()
            Me.ActiveForm.Activate()
        End If
    End Sub
    Public Sub BtnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If Not IsNothing(Me.ActiveForm) Then
            If Me.ActiveForm.Tag = DataMode.Insert Or Me.ActiveForm.Tag = DataMode.Inserting Then Exit Sub ''INVALID OPERATION BY USER IN INSERTING MODE HE WANT TO EDIT
            RaiseEvent Action(Me, New DataActionEveArgs(DataMode.Edit))
            Me.ActiveForm.Tag = DataMode.Edit
            'If LockControls = True Then
            UnlockControls(DataMode.Edit)
            'End If

            If Me.ActiveForm.Controls.Find("Desc", True).Length > 0 Then
                Dim DescControl As Control = Me.ActiveForm.Controls.Find("Desc", True)(0)
                LockControls = True
                'If Me.mDirector.DescriptionControl.Enabled = True Then Me.mDirector.DescriptionControl.Focus()
                If DescControl.Enabled Then DescControl.Focus()
                LockControls = False
            End If
        End If

    End Sub

    Public Sub BtnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If Not IsNothing(Me.ActiveForm) Then
            Me.mActiveForm.Cursor = Cursors.WaitCursor
            RaiseEvent Action(Me, New DataActionEveArgs(DataMode.Deleting))
            If MsgBox("Are You sure to delete record(s)?", MsgBoxStyle.YesNo, "Deleting Record") = MsgBoxResult.Yes Then
                If Cancel = True Then Exit Sub
                DeleteRow()
                mActiveForm.Tag = DataManager.DataMode.Insert
                mDirector.InitalizeActiveFormComponents()
                If Me.LockControls = True Then UnlockControls(DataMode.Insert)
                RaiseEvent Action(Me, New DataActionEveArgs(DataMode.Delete))
            End If
            Me.mActiveForm.Cursor = Cursors.Default

        End If
    End Sub

    Public Sub BtnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            If Not IsNothing(Me.mActiveForm) Then
                Me.mActiveForm.Cursor = Cursors.WaitCursor
                If mActiveForm.Tag = DataManager.DataMode.Edit Or mActiveForm.Tag = DataManager.DataMode.Inserting Or mActiveForm.Tag = DataManager.DataMode.Insert Then
                    RaiseEvent Action(Me, New DataActionEveArgs(DataMode.Saving))
                    If Cancel = True Then Me.mActiveForm.Cursor = Cursors.Default : Exit Sub
                    Me.UpdateProcess()
                    mActiveForm.Tag = DataManager.DataMode.Insert
                    mDirector.InitalizeActiveFormComponents()
                    Me.UnlockControls(DataMode.Insert)
                    Me.mDirector.DefaultPrimaryKeyControl.Focus()
                    If Not IsNothing(Me.mDirector.DetailControl) Then
                        Me.mDirector.DetailControl.ActiveSheet = Me.mDirector.DetailControl.Sheets(0)
                    End If
                    RaiseEvent Action(Me, New DataActionEveArgs(DataMode.Save))
                End If
                Me.mActiveForm.Cursor = Cursors.Default
            End If

        Catch ex As SqlClient.SqlException
            Me.mActiveForm.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Saving Record Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Catch ex As AzamTechnologies.Database.UpdatingException
            MessageBox.Show(ex.Message, "Saving Record Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.mActiveForm.Cursor = Cursors.Default
        Catch ex As Exception
            Me.mActiveForm.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Saving Record Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub BtnLock_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLock.Click
        If Not IsNothing(Me.ActiveForm) Then
            If LockControls = False Then
                mActiveForm.Tag = DataManager.DataMode.Locked
                LockedControls()
            End If
            RaiseEvent Action(Me, New DataActionEveArgs(DataMode.Locked))
        End If
    End Sub

    Public Sub BtnUndo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnUndo.Click
        If Not IsNothing(Me.mDirector) Then
            mDirector.FillDataSet(dsData)
            Me.mDirector.SetData(dsData)
            RaiseEvent Action(Me, New DataActionEveArgs(DataMode.Undo))
        End If

    End Sub

    Public Sub BtnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        If Not IsNothing(mDirector) Then

            SetPrimaryKeysValues()

            RaiseEvent Action(Me, New DataActionEveArgs(DataMode.Printing))
            Me.ReportDialoge = New PrintDialog
            Me.ReportDialoge.ReportFileName = mDirector.TableName
            Me.ReportDialoge.ShowDialog()
            If ReportDialoge.DialogResult = DialogResult.Yes Then
                ''Print
                RaiseEvent Print(Me, New PrintActionEventArgs(Me.mDirector.TableName, Me.ReportDialoge.ReportStyle, PrintActionEventArgs.Actions.Print, PrimaryKeyControl))
            ElseIf ReportDialoge.DialogResult = DialogResult.OK Then
                'Preview
                RaiseEvent Print(Me, New PrintActionEventArgs(Me.mDirector.TableName, Me.ReportDialoge.ReportStyle, PrintActionEventArgs.Actions.Preview, PrimaryKeyControl))
            ElseIf ReportDialoge.DialogResult = DialogResult.Abort Then
                'Other reports
                RaiseEvent Print(Me, New PrintActionEventArgs(Me.mDirector.TableName, Me.ReportDialoge.ReportStyle, PrintActionEventArgs.Actions.Detail))
            End If
            RaiseEvent Action(Me, New DataActionEveArgs(DataMode.Printing))
        End If

    End Sub
#End Region
#Region " Action Performed events arguments "
    Public Class DataActionEveArgs
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'this class is used for using in arguments in events of search slide
        ' and the main arguments is a Dataview. when record is searched then the data view
        ' arguments is passed to the events
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Inherits EventArgs
        Public ActionMode As DataMode
        Sub New(ByVal action As DataMode)
            ActionMode = action
        End Sub
    End Class
#End Region
#Region " Print events arguments "
    Public Class PrintActionEventArgs
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'this class is used for sending print events arguments
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Inherits EventArgs
        Public Enum ReportStyle
            Document
            Listing
        End Enum
        Public Enum Actions
            Preview
            Print
            Detail
        End Enum
        Public PrintFileName As String
        Public ReportTypes As ReportStyle
        Public ReportAction As Actions
        Public PrimaryParameters() As Control
        Sub New(ByVal printFile As String, ByVal reportType As ReportStyle, ByVal actions As Actions, ByVal ParamArray paramControl() As Control)
            PrintFileName = printFile
            ReportTypes = reportType
            ReportAction = actions
            PrimaryParameters = paramControl
        End Sub
    End Class
#End Region
#Region " Formate Class"
    Class FormateData
        Public Shared Function FormatKeyValue(ByVal KeyObjectText As String, ByVal maxTextLen As Integer) As String

            Dim a As New System.Text.StringBuilder
            Dim strTemp As String
            If Trim(KeyObjectText) = "" Then KeyObjectText = "1"

            Dim vala As Int16
            vala = Math.Abs(Val(KeyObjectText))
            If maxTextLen = 1 Then Return KeyObjectText

            If maxTextLen - vala.ToString.Length = 0 Then
                strTemp = vala
            Else
                strTemp = a.Insert(0, "0", maxTextLen - vala.ToString.Length).ToString
                strTemp = strTemp.Insert(maxTextLen - vala.ToString.Length, vala.ToString)
            End If

            'Dim d = strTemp.Remove(maxTextLen - vala.ToString.Length, 1)
            Return strTemp

        End Function
        Public Shared Function FormatKeyYearMonthValue(ByVal KeyObjectText As String, ByVal maxTextLen As Integer, Optional ByVal dtWorkingDate As Date = Nothing) As String
            If IsNothing(dtWorkingDate) Then
                dtWorkingDate = Now
            End If
            Dim a As New System.Text.StringBuilder
            Dim dateValue As String = Format(Now, "yy") & Format(dtWorkingDate, "MM")

            Dim strTemp As String
            KeyObjectText = "1"
            strTemp = a.Insert(0, "0", maxTextLen - KeyObjectText.Length).ToString
            a = New System.Text.StringBuilder(strTemp)
            strTemp = a.Replace("0000", dateValue, 0, 4).ToString
            a = New System.Text.StringBuilder(strTemp)
            strTemp = a.Insert(maxTextLen - KeyObjectText.Length, KeyObjectText, 1).ToString
            FormatKeyYearMonthValue = strTemp
        End Function
    End Class
#End Region

End Class
