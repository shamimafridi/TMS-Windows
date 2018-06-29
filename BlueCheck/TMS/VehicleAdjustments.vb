Imports System.Data.SqlClient
Namespace GeneralLedger
    Public Class VehicleAdjustments
        Dim CmbGlCode As FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
        Dim CmbGlDesc As FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
        Dim CmbTrTypeCode As FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
        Dim CmbTrTypeDesc As FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
        Private Dr As SqlDataReader
        Dim FreshMode As Boolean
        Dim LockGrid As Boolean
        Private Enum GridCols
            BranchCode = 0
            VehicleAdjustmentNature = 1
            VehicleAdjustmentNumber = 2
            TypeCode = 3
            Type = 4
            [Date] = 5
            UrduDescription = 6
            Description = 7
            Amount = 8
            GLCode = 9
            GLDescription = 10
        End Enum
        Private Sub JournalVehicleAdjustment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ''''''''''''For just solving the problem of this form when closing then mdi windows handling problum
            CmbGlCode = New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
            CmbGlDesc = New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
            CmbTrTypeCode = New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
            CmbTrTypeDesc = New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
            PainFPGrid(FpVehicleAdjustmentGrid)
            If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                TxtDate.Value = CurrentWorkingDate
            End If
            Try
                ''''''
                SettingGrid()
                ''
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Sub SettingGrid()
            ''''''''''''''''''''''''
            ''''''''''''''''''''''''''

            ''''Combo setting

            'GL Accounts
            ''''''''''''''''''''''''''''''''''''''
            FillCombo(DsGLs, "SelectCOASubSubsidiaries", "OPTION", "COMBO")

            Me.FpVehicleAdjustmentGrid.ButtonDrawMode = FarPoint.Win.Spread.ButtonDrawModes.CurrentCell

            With DsGLs.Tables(0)
                CmbGlCode.DataSourceList = DsGLs
                CmbGlCode.ListOffset = 10
                CmbGlCode.AutoSearch = FarPoint.Win.AutoSearch.MultipleCharacter
                CmbGlCode.ShowColumnHeaders = True
                CmbGlCode.DataMemberList = "Table"

            End With

            CmbGlCode.ListWidth = 300

            With DsGLs.Tables(0)
                CmbGlDesc.DataSourceList = DsGLs
                CmbGlDesc.ListOffset = 10
                CmbGlDesc.AutoSearch = FarPoint.Win.AutoSearch.MultipleCharacter
                CmbGlDesc.ShowColumnHeaders = True
                CmbGlDesc.DataMemberList = "Table"


            End With
            CmbGlDesc.ListWidth = 300

            'Types
            ''''''''''''''''''''''''''''''''''''''
            FillCombo(DsDiv, "SelectTransactionTypes", "OPTION", "COMBO", "NatureCode", Me.NATURE.Text)

            Me.FpVehicleAdjustmentGrid.ButtonDrawMode = FarPoint.Win.Spread.ButtonDrawModes.CurrentCell

            With DsDiv.Tables(0)
                CmbTrTypeCode.DataSourceList = DsDiv
                CmbTrTypeCode.ListOffset = 10
                CmbTrTypeCode.AutoSearch = FarPoint.Win.AutoSearch.MultipleCharacter
                CmbTrTypeCode.ShowColumnHeaders = True
                CmbTrTypeCode.DataMemberList = "Table"

            End With



            With DsDiv.Tables(0)
                CmbTrTypeDesc.DataSourceList = DsDiv
                CmbTrTypeDesc.ListOffset = 10
                CmbTrTypeDesc.AutoSearch = FarPoint.Win.AutoSearch.MultipleCharacter
                CmbTrTypeDesc.ShowColumnHeaders = True
                CmbTrTypeDesc.DataMemberList = "Table"

            End With
            FpVehicleAdjustmentGrid.Sheets(0).Tag = "VehicleAdjustmentsDetails"
            CmbTrTypeDesc.ListWidth = 500

            If Me.NATURE.Text = VehicleAdjustmentPaymentNature Or Me.NATURE.Text = VehicleAdjustmentReceiptNature Then
                Me.lblCheque.Visible = False : Me.CmbMode.Visible = False : Me.lblMode.Visible = False : Me.TxtChequeNo.Visible = False
            Else
                Me.lblCheque.Visible = True : Me.CmbMode.Visible = True : Me.lblMode.Visible = True : Me.TxtChequeNo.Visible = True
            End If



            'TOTAL CELL SETTINGS
            Dim TotalCellType = New FarPoint.Win.Spread.CellType.CurrencyCellType
            TotalCellType.ShowCurrencySymbol = False
            Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Amount - 1).Value = "Total:"

            Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Amount).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right
            Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Amount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right
            Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Amount).CellType = TotalCellType
            Dim r As Integer
            Dim j As Integer
            For r = 0 To Me.FpVehicleAdjustmentGrid.Sheets(0).RowCount
                For j = 0 To Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnCount
                    Me.FpVehicleAdjustmentGrid.Sheets(0).Models.Data.SetValue(r, j, j + r * Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnCount)
                Next j
            Next r
            Dim i As Integer
            i = 0
            Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnFooter.SetAggregationType(0, GridCols.Amount, FarPoint.Win.Spread.Model.AggregationType.Sum)
            Me.FpVehicleAdjustmentGrid.Sheets(0).ColumnFooter.Cells(0, i).Value = "Sum"



        End Sub
        Dim DsVehicle As DataSet
        Dim DsGLs As DataSet
        Dim DsDiv As DataSet

        Public Function ValidateData() As Boolean
            Dim nGridRowCount As Long
            If CheckGridData(nGridRowCount) Then
                If nGridRowCount < 1 Then
                    If MsgBox("You  have specified No valid detail record on this Product JournalVehicleAdjustment Transaction..." & vbCrLf & "This Transaction will be Saved as Cancelled !" & vbCrLf & vbCrLf & "Are you sure you want to Save ?", vbQuestion + vbYesNo + vbDefaultButton2, "No Details specified...") = MsgBoxResult.No Then
                        ValidateData = False
                        FpVehicleAdjustmentGrid.Focus()
                        Exit Function
                    Else
                        ValidateData = True
                    End If
                Else
                    ValidateData = True
                End If
            Else
                ValidateData = False
            End If

        End Function

        Public Function CheckGridData(ByRef nRowCount As Long) As Boolean
            Dim iRow As Long
            Dim StartRow As Long
            Dim TypeCode As String

            Dim MatchingRow As Long

            'For iRow = 0 To FpVehicleAdjustmentGrid.Sheets(0).RowCount - 1
            '    TypeCode = Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(iRow, GridCols.TypeCode))
            '    'PONumber = Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(GridCols.PONo, iRow))
            '    StartRow = iRow
            '    If Trim(TypeCode) <> "" And Val(FpVehicleAdjustmentGrid.Sheets(0).GetText(iRow, GridCols.Amount)) <> 0 Then
            '        TypeCode = FpVehicleAdjustmentGrid.Search(0, TypeCode, False, True, False, False, StartRow + 1, GridCols.TypeCode, MatchingRow, 0)
            '        If Val(MatchingRow) > 0 And MatchingRow <> StartRow Then
            '            ErrProvider.SetError(FpVehicleAdjustmentGrid, "Type Code # " & Trim(TypeCode) & "  has been specified more than once in detail..." & vbCrLf & vbCrLf & "You cannot specify any record more than one times in a single transaction !")
            '            FpVehicleAdjustmentGrid.Sheets(0).SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Row
            '            FpVehicleAdjustmentGrid.Sheets(0).AddSelection(MatchingRow, GridCols.TypeCode, 1, GridCols.GLDescription)

            '            CheckGridData = False
            '            Exit Function
            '        End If

            '        If Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(iRow, GridCols.GLCode)) = String.Empty Or Val(FpVehicleAdjustmentGrid.Sheets(0).GetText(iRow, GridCols.Amount)) = 0 Then
            '            ErrProvider.SetError(FpVehicleAdjustmentGrid, "GLCode  And Amount Can't Be Empty ")
            '            FpVehicleAdjustmentGrid.Sheets(0).SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Row
            '            FpVehicleAdjustmentGrid.Sheets(0).AddSelection(iRow, GridCols.TypeCode, 1, GridCols.GLDescription)
            '            CheckGridData = False
            '            Exit Function
            '        End If
            '        nRowCount = nRowCount + 1
            '    End If
            'Next
            'If CheckTotalBalance() = True Then
            nRowCount = nRowCount + 1
            Return True
            'Else
            '    Return False
            'End If
            CheckGridData = True
            ' Code End
        End Function
        Private Function CheckTotalBalance() As Boolean
            Return True
        End Function
        Private Sub mnuClearGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuClearGrid.Click
            FpVehicleAdjustmentGrid.Sheets(0).ClearRange(0, 0, FpVehicleAdjustmentGrid.Sheets(0).Rows.Count, FpVehicleAdjustmentGrid.Sheets(0).ColumnCount, True)
            FpVehicleAdjustmentGrid.Sheets(0).Cells(0, 0, FpVehicleAdjustmentGrid.Sheets(0).Rows.Count - 1, FpVehicleAdjustmentGrid.Sheets(0).ColumnCount - 1).Tag = String.Empty

        End Sub
        Private Sub mnuDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MnuDeleteRow.Click
            FpVehicleAdjustmentGrid.Sheets(0).ClearRange(FpVehicleAdjustmentGrid.Sheets(0).ActiveRowIndex, 0, 1, FpVehicleAdjustmentGrid.Sheets(0).ColumnCount, True)
            FpVehicleAdjustmentGrid.Sheets(0).Cells(FpVehicleAdjustmentGrid.Sheets(0).ActiveRowIndex, 0, FpVehicleAdjustmentGrid.Sheets(0).ActiveRowIndex, FpVehicleAdjustmentGrid.Sheets(0).ColumnCount - 1).Tag = String.Empty

        End Sub
        Private Sub MnuInsertRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuInsertRow.Click
            FpVehicleAdjustmentGrid.Sheets(0).Rows.Add(FpVehicleAdjustmentGrid.Sheets(0).ActiveRowIndex, 1)
        End Sub

        Private Sub JournalVehicleAdjustment_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Me.ContextMenu = Nothing
            End If
        End Sub
        Private Sub dtpDate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDate.Validated
            ErrProvider.SetError(TxtDate, String.Empty)
        End Sub
        Public Sub dtpDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtDate.Validating
            Try
                Dim DateError As String
                DateError = ValidateTransactionDate(TxtDate.Value, Me.Tag)
                If DateError <> String.Empty Then
                    ErrProvider.SetError(TxtDate, DateError)
                    e.Cancel = True
                    Exit Sub
                End If
                'If txtTransactionNumber.Text <> String.Empty Then
                If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                    txtTransactionNumber.Text = String.Empty
                    KeyGeneration()
                Else
                    If DateSerial(TxtDate.Value.Year, TxtDate.Value.Month, 1) <> DateSerial("20" & Mid(txtTransactionNumber.Text, 1, 2), Mid(txtTransactionNumber.Text, 3, 2), 1) Then
                        e.Cancel = True
                        ErrProvider.SetError(TxtDate, "You cannot change the Month Or Year for this Transaction Date..." & vbCrLf & "Please specify a valid Date within " & MonthName(Mid(txtTransactionNumber.Text, 3, 2)) & ", " & Year(DateSerial("20" & Mid(txtTransactionNumber.Text, 1, 2), 1, 1)))
                        Exit Sub
                    End If

                End If
                'End If
            Catch ex As System.ArgumentException
                e.Cancel = True
                ErrProvider.SetError(TxtDate, "You cannot change the Month Or Year for this Transaction Date..." & vbCrLf & "Please specify a valid Date within " & MonthName(Mid(txtTransactionNumber.Text, 3, 2)) & ", " & Year(DateSerial("20" & Mid(txtTransactionNumber.Text, 1, 2), 1, 1)))
            Catch ex As Exception

            End Try

        End Sub
        Private Sub CmdBranchList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If txtBranchCode.Enabled = False Then Exit Sub
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Branches")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.txtBranchCode.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
                Me.txtBranch.Text = frmser.UGSearch.Rows(iRow).Cells("BranchName").Value
                Me.txtBranchCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtBranchCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtBranchCode.EditorButtonClick
            If txtBranchCode.Enabled = False Then Exit Sub
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Branches")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.txtBranchCode.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
                Me.txtBranch.Text = frmser.UGSearch.Rows(iRow).Cells("BranchName").Value
                Me.txtBranchCode.Focus()
            Catch ex As IndexOutOfRangeException

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub txtBranchCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBranchCode.GotFocus
            If Me.txtBranchCode.Text = String.Empty Then
                Me.txtBranchCode.Text = My.Settings.DefaultBranchCode
            End If
        End Sub
        Private Sub txtBranchCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.txtBranchCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub


        'Public Shared Function FormatKeyYearMonthValue(ByVal DateForFormat As Date, ByVal KeyObjectText As String, ByVal maxTextLen As Integer) As String
        '    Dim a As New System.Text.StringBuilder
        '    Dim dateValue As String = Format(DateForFormat, "yy") & Format(DateForFormat, "MM")

        '    Dim strTemp As String
        '    KeyObjectText = "1"
        '    strTemp = a.Insert(0, "0", maxTextLen - KeyObjectText.Length).ToString
        '    a = New System.Text.StringBuilder(strTemp)
        '    strTemp = a.Replace("0000", dateValue, 0, 4).ToString
        '    a = New System.Text.StringBuilder(strTemp)
        '    strTemp = a.Insert(maxTextLen - KeyObjectText.Length, KeyObjectText, 1).ToString
        '    FormatKeyYearMonthValue = strTemp
        'End Function
        Private Sub FpVehicleAdjustmentGrid_EnterCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.EnterCellEventArgs) Handles FpVehicleAdjustmentGrid.EnterCell
            If e.Column = GridCols.GLCode Then
                CmbGlCode.ColumnEdit = 0
                CmbGlCode.DataColumn = 0
                FpVehicleAdjustmentGrid.Sheets(0).Cells(e.Row, e.Column, e.Row, e.Column).CellType = CmbGlCode
                CmbGlCode.ListWidth = 380
            ElseIf e.Column = GridCols.GLDescription Then
                CmbGlDesc.ColumnEdit = 1
                CmbGlDesc.DataColumn = 1
                FpVehicleAdjustmentGrid.Sheets(0).Cells(e.Row, e.Column, e.Row, e.Column).CellType = CmbGlDesc
                CmbGlDesc.ListWidth = 380
            ElseIf e.Column = GridCols.TypeCode Then
                CmbTrTypeCode.ColumnEdit = 0
                CmbTrTypeCode.DataColumn = 0
                FpVehicleAdjustmentGrid.Sheets(0).Cells(e.Row, e.Column, e.Row, e.Column).CellType = CmbTrTypeCode
                CmbTrTypeCode.ListWidth = 450
            ElseIf e.Column = GridCols.Type Then
                CmbTrTypeDesc.ColumnEdit = 1
                CmbTrTypeDesc.DataColumn = 1
                FpVehicleAdjustmentGrid.Sheets(0).Cells(e.Row, e.Column, e.Row, e.Column).CellType = CmbTrTypeDesc
                CmbTrTypeDesc.ListWidth = 450
            End If
        End Sub
        Private Sub FpVehicleAdjustmentGrid_LeaveCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.LeaveCellEventArgs) Handles FpVehicleAdjustmentGrid.LeaveCell
            Me.Cursor = Cursors.WaitCursor
            ''''''''''''
            Dim ErrString As String = String.Empty
            ''''''''''''
            'SetComboToGrid(NewCol, NewRow)
            If LockGrid = False Then
                Select Case e.Column
                    Case GridCols.GLCode
                        validComboData(GridCols.GLCode, e.Row)
                    Case GridCols.GLDescription
                        validComboData(GridCols.GLDescription, e.Row)
                    Case GridCols.TypeCode
                        validComboData(GridCols.TypeCode, e.Row)
                    Case GridCols.Type
                        validComboData(GridCols.Type, e.Row)


                End Select
                LockGrid = True
                'If Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(GridCols.GLCode, e.row)) = "" And Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(GridCols.PONo, Row)) = "" Then
                If Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(e.Row, GridCols.TypeCode)) = "" Then

                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.VehicleAdjustmentNature, String.Empty)
                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.VehicleAdjustmentNumber, String.Empty)
                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.BranchCode, String.Empty)

                    FpVehicleAdjustmentGrid.Sheets(0).SetTag(e.Row, GridCols.BranchCode, String.Empty)
                    FpVehicleAdjustmentGrid.Sheets(0).SetTag(e.Row, GridCols.VehicleAdjustmentNumber, String.Empty)
                    FpVehicleAdjustmentGrid.Sheets(0).SetTag(e.Row, GridCols.VehicleAdjustmentNature, String.Empty)

                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.GLCode, String.Empty)
                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.GLDescription, String.Empty)

                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.Date, String.Empty)


                Else
                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.VehicleAdjustmentNumber, txtTransactionNumber.Text)
                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.VehicleAdjustmentNature, NATURE.Text)
                    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.BranchCode, txtBranchCode.Text)

                    If (String.IsNullOrEmpty(FpVehicleAdjustmentGrid.Sheets(0).GetValue(e.Row, GridCols.Date))) Then
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.Date, TxtDate.Value)
                    End If



                    FpVehicleAdjustmentGrid.Sheets(0).SetTag(e.Row, GridCols.BranchCode, "BranchCode")
                        FpVehicleAdjustmentGrid.Sheets(0).SetTag(e.Row, GridCols.VehicleAdjustmentNumber, "TransactionNo")
                        FpVehicleAdjustmentGrid.Sheets(0).SetTag(e.Row, GridCols.VehicleAdjustmentNature, "TransactionNature")


                        'If Val(FpVehicleAdjustmentGrid.Sheets(0).GetText(e.Row, GridCols.Amount)) = 0 Then
                        '    FpVehicleAdjustmentGrid.Sheets(0).SetText(e.Row, GridCols.Amount, 0D)
                        'End If
                        If e.NewRow = FpVehicleAdjustmentGrid.Sheets(0).RowCount - 1 Then
                            FpVehicleAdjustmentGrid_Sheet1.AddRows(FpVehicleAdjustmentGrid.Sheets(0).RowCount, 1)
                        End If
                    End If
                    LockGrid = False
            End If
            If LockGrid = False Then
                LockGrid = True

                ' Call VehicleAdjustmentGrid_ButtonClicked(Col, e.row, 0)
                LockGrid = False
            End If
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub TxtVehicleCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtVehicleCode.Validated
            ErrProvider.SetError(TxtVehicleCode, String.Empty)
        End Sub
        Private Sub TxtVehicleCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtVehicleCode.Validating
            Try
                If TxtVehicleCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectVehicles", "VehicleCode ", Trim(TxtVehicleCode.Text))
                    If Reader.HasRows = False Then
                        ErrProvider.SetError(TxtVehicleCode, "Invalid Vehicle Code")
                        ErrProvider.SetIconAlignment(TxtVehicleCode, ErrorIconAlignment.TopLeft)
                        TxtVehicleCode.Text = String.Empty
                        TxtVehicle.Text = String.Empty
                        e.Cancel = True
                    Else
                        Reader.Read()
                        ErrProvider.SetError(TxtVehicleCode, String.Empty)
                        TxtVehicle.Text = Reader.Item("VehicleDescription")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Private Function validComboData(ByVal Col As GridCols, ByVal row As Int16) As Boolean
            If Col = GridCols.GLCode Then
                If Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.GLCode)) <> "" Then
                    Dim dv As New DataView
                    dv.Table = DsGLs.Tables(0)
                    dv.RowFilter = "GLCode='" & Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.GLCode)) & "'"

                    If dv.Count <> 0 Then
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.GLDescription, dv.Item(0).Item("GLDescription"))
                        Return True
                    Else
                        MessageBox.Show("Selected GLCode is not valid." & vbCrLf & "Please Enter an valide Item Code", "Item Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.GLCode, String.Empty)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.GLDescription, String.Empty)
                        Return False
                    End If
                Else
                    Return True
                End If
            ElseIf Col = GridCols.GLDescription Then
                If Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.GLDescription)) <> "" Then
                    Dim dv As New DataView
                    dv.Table = DsGLs.Tables(0)
                    dv.RowFilter = "GLDescription='" & Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.GLDescription)) & "'"

                    If dv.Count <> 0 Then
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.GLCode, dv.Item(0).Item("GLCode"))
                        Return True
                    Else
                        MessageBox.Show("Selected Item is not valid." & vbCrLf & "Please Enter an valide Item Code", "Item Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.GLCode, String.Empty)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.GLDescription, String.Empty)
                        Return False
                    End If
                Else
                    Return True
                End If

            ElseIf Col = GridCols.TypeCode Then
                If Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.TypeCode)) <> "" Then
                    Dim dv As New DataView
                    dv.Table = DsDiv.Tables(0)
                    dv.RowFilter = "TypeCode='" & Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.TypeCode)) & "'"

                    If dv.Count <> 0 Then
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.Type, dv.Item(0).Item("Type"))
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.UrduDescription, IIf(IsDBNull(dv.Item(0).Item("UrduTitle")), "", dv.Item(0).Item("UrduTitle")))
                        Return True
                    Else
                        MessageBox.Show("Selected Type Code is not valid." & vbCrLf & "Please Enter an valide Type Code", "Type Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.TypeCode, String.Empty)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.Type, String.Empty)
                        Return False
                    End If
                Else
                    Return True
                End If
            ElseIf Col = GridCols.Type Then
                If Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.Type)) <> "" Then
                    Dim dv As New DataView
                    dv.Table = DsDiv.Tables(0)
                    dv.RowFilter = "Type='" & Trim(FpVehicleAdjustmentGrid.Sheets(0).GetText(row, GridCols.Type)) & "'"

                    If dv.Count <> 0 Then
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.TypeCode, dv.Item(0).Item("TypeCode"))
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.UrduDescription, IIf(IsDBNull(dv.Item(0).Item("UrduTitle")), "", dv.Item(0).Item("UrduTitle")))
                        Return True
                    Else
                        MessageBox.Show("Selected Type  is not valid." & vbCrLf & "Please Enter an valide Type ", "Type Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.TypeCode, String.Empty)
                        FpVehicleAdjustmentGrid.Sheets(0).SetText(row, GridCols.Type, String.Empty)
                        Return False
                    End If
                Else
                    Return True
                End If
            End If

        End Function
        Private Sub FpVehicleAdjustmentGrid_SubEditorOpening(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.SubEditorOpeningEventArgs) Handles FpVehicleAdjustmentGrid.SubEditorOpening
            If e.SubEditor.ToString = "a7" Then 'multiple combo box
                Dim ss As FarPoint.Win.Spread.FpSpread
                ss = CType(e.SubEditor, FarPoint.Win.Spread.FpSpread)
                ss.Skin = FpVehicleAdjustmentGrid.Skin
                ss.BorderStyle = BorderStyle.FixedSingle
                ss.Sheets(0).Columns(0).AllowAutoSort = True
                ss.Sheets(0).Columns(1).AllowAutoSort = True
                If ss.Sheets(0).Columns.Count = 2 Then
                    ss.Sheets(0).Columns(1).Width = 230
                ElseIf ss.Sheets(0).Columns.Count = 3 Then
                    ss.Sheets(0).Columns(1).Width = 160
                    ss.Sheets(0).Columns(2).Width = 160
                End If
            End If
        End Sub

        Private Sub KeyGeneration()
            If txtTransactionNumber.Text = String.Empty Then

                If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                    Me.CmbMode.Text = "Cash"
                    Dim objAcc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader
                    If Me.txtBranchCode.Text = String.Empty Then
                        Me.txtBranchCode.Text = My.Settings.DefaultBranchCode
                    End If
                    Reader = objAcc.GetRecord("Select" & Me.AccessibleName, "Option", "AUTO", "TransactionNature", Me.NATURE.Text, "YearMonth", Format(TxtDate.Value, "yy") & Format(TxtDate.Value, "MM"), "BranchCode", txtBranchCode.Text)
                    'Auto increment the primary key field when we Add the 
                    ' AccessibleDescription Properties of the Control set to "AUTO"
                    If Reader.HasRows Then
                        While Reader.Read
                            txtTransactionNumber.Text = Reader.Item("TransactionNo")
                            txtTransactionNumber.Text = Integer.Parse(txtTransactionNumber.Text) + 1
                            If Mid(txtTransactionNumber.Text.Insert(0, "0"), 1, 2) = "09" Then
                                txtTransactionNumber.Text = txtTransactionNumber.Text.Insert(0, "0")
                                ' chCtr.Text = mManager.FormateData.FormatKeyYearMonthValue(chCtr.Text, CType(chCtr, TextBox).MaxLength)
                            End If
                        End While
                    Else
                        txtTransactionNumber.Text = FormatKeyYearMonthValue(TxtDate.Value, txtTransactionNumber.Text, CType(txtTransactionNumber, Infragistics.Win.UltraWinEditors.UltraTextEditor).MaxLength)
                    End If
                End If
            End If
        End Sub

        Private Sub txtBranchCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBranchCode.Validated
            ErrProvider.SetError(txtBranchCode, String.Empty)
        End Sub

        Private Sub txtBranchCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBranchCode.Validating
            Try
                If txtBranchCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectBranches", "BranchCode ", Trim(txtBranchCode.Text))
                    If Reader.HasRows = False Then
                        ErrProvider.SetError(txtBranchCode, "Invalid Branch Code")
                        ErrProvider.SetIconAlignment(txtBranchCode, ErrorIconAlignment.TopLeft)
                        txtBranchCode.Text = String.Empty
                        txtBranch.Text = String.Empty
                        e.Cancel = True
                    Else

                        If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                            txtTransactionNumber.Text = String.Empty
                            KeyGeneration()
                        End If

                        Reader.Read()
                        ErrProvider.SetError(txtBranchCode, String.Empty)
                        txtBranch.Text = Reader.Item("BranchName")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub txtBranchCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranchCode.ValueChanged

        End Sub

        Private Sub TxtDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDate.ValueChanged

        End Sub

        Private Sub txtTransactionNumber_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtTransactionNumber.EditorButtonClick
            If txtTransactionNumber.Enabled = False Then Exit Sub
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("VehicleAdjustments", "OPTION", "ALL", "TransactionNature", NATURE.Text)
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.txtBranchCode.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
                Me.txtTransactionNumber.Text = frmser.UGSearch.Rows(iRow).Cells("TransactionNo").Value
                Me.txtTransactionNumber.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtTransactionNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTransactionNumber.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.txtTransactionNumber_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtVehicleCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtVehicleCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Vehicles")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtVehicleCode.Text = frmser.UGSearch.Rows(iRow).Cells("VehicleCode").Value
                Me.TxtVehicle.Text = frmser.UGSearch.Rows(iRow).Cells("VehicleDescription").Value
                Me.TxtVehicleCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtVehicleCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVehicleCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtVehicleCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub UltraComboEditor1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMode.ValueChanged
            If Trim(CmbMode.Text) = "Cash" Then
                Me.TxtChequeNo.Enabled = False
                Me.TxtChequeNo.Text = String.Empty
            ElseIf Trim(CmbMode.Text) = "Cheque" Then
                Me.TxtChequeNo.Enabled = True
            Else
                Me.TxtChequeNo.Enabled = False
                Me.CmbMode.Text = "Cash"
            End If
        End Sub

        Private Sub FpVehicleAdjustmentGrid_CellClick(ByVal sender As System.Object, ByVal e As FarPoint.Win.Spread.CellClickEventArgs) Handles FpVehicleAdjustmentGrid.CellClick

        End Sub
    End Class
End Namespace
