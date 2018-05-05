Namespace Inventory
    Public Class TransactionTypes
        Private Sub TxtNatureCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtNatureCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("TransactionNatures")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtNatureCode.Text = frmser.UGSearch.Rows(iRow).Cells("NatureCode").Value
                Me.txtNature.Text = frmser.UGSearch.Rows(iRow).Cells("Nature").Value
                Me.TxtNatureCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtCityCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNatureCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtNatureCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtGLCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtGLCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("COACombine")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtGLCode.Text = frmser.UGSearch.Rows(iRow).Cells("GLCode").Value
                Me.TxtGLDesc.Text = frmser.UGSearch.Rows(iRow).Cells("GLDescription").Value
                Me.TxtGLCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtGLCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtGLCode.Validated
            ErrProvider.SetError(TxtGLCode, String.Empty)
        End Sub

        Private Sub TxtGLCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtGLCode.Validating
            Try
                If TxtGLCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectCOACombine", "GLCode ", Trim(TxtGLCode.Text))
                    If Reader.HasRows = False Then
                        TxtGLCode.Text = String.Empty
                        TxtGLDesc.Text = String.Empty
                        ErrProvider.SetError(TxtGLCode, "Invalid GL Code")
                        ErrProvider.SetIconAlignment(TxtGLCode, ErrorIconAlignment.TopLeft)
                        e.Cancel = True
                    Else
                        ErrProvider.SetError(TxtGLCode, String.Empty)
                        Reader.Read()
                        TxtGLDesc.Text = Reader.Item("GLDescription")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub


        Private Sub txtNatureCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtNatureCode.Validating
            Try
                If TxtNatureCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectTransactionNatures", "TransactionNatureCode", Trim(TxtNatureCode.Text), "System", "IN")
                    If Reader.HasRows = False Then
                        TxtNatureCode.Text = String.Empty
                        txtNature.Text = String.Empty
                        ErrProvider.SetError(TxtNatureCode, "Invalid Nature Code")
                        ErrProvider.SetIconAlignment(TxtNatureCode, ErrorIconAlignment.TopLeft)
                        e.Cancel = True
                    Else
                        ErrProvider.SetError(TxtNatureCode, String.Empty)
                        Reader.Read()
                        txtNature.Text = Reader.Item("Nature")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Private Sub txtCityCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtNatureCode.Validated
            ErrProvider.SetError(TxtNatureCode, String.Empty)
        End Sub
        Private Sub NatureRates_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub

        Private Sub TxtTransactionTypeCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtTransactionTypeCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("TransactionTypes")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtTransactionTypeCode.Text = frmser.UGSearch.Rows(iRow).Cells("TransactionTypeCode").Value
                Me.Desc.Text = frmser.UGSearch.Rows(iRow).Cells("TransactionType").Value
                Me.TxtNatureCode.Text = frmser.UGSearch.Rows(iRow).Cells("Nature").Value
                Me.TxtTransactionTypeCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtTransactionTypeCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtTransactionTypeCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtTransactionTypeCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtTransactionTypeCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTransactionTypeCode.TextChanged

        End Sub

        Private Sub TxtTransactionTypeCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTransactionTypeCode.Validated
            ErrProvider.SetError(TxtTransactionTypeCode, String.Empty)
        End Sub

        Private Sub TxtTransactionTypeCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtTransactionTypeCode.Validating
            'Try
            '    If TxtTransactionTypeCode.Text <> String.Empty Then
            '        Dim Acc As New AzamTechnologies.Database.DataAccess
            '        Dim Reader As SqlClient.SqlDataReader

            '        Reader = Acc.GetRecord("SelectTransactionTypes", "TransactionTypeCode", Trim(TxtTransactionTypeCode.Text), Trim(TxtTransactionTypeCode.Text))
            '        If Reader.HasRows = False Then
            '            TxtTransactionTypeCode.Text = String.Empty
            '            TxtTransactionType.Text = String.Empty
            '            ErrProvider.SetError(TxtTransactionTypeCode, "Invalid Station Point Code")
            '            ErrProvider.SetIconAlignment(TxtTransactionTypeCode, ErrorIconAlignment.TopLeft)
            '            e.Cancel = True
            '        Else
            '            ErrProvider.SetError(TxtTransactionTypeCode, String.Empty)
            '            Reader.Read()
            '            TxtTransactionType.Text = Reader.Item("TransactionTypeName")
            '            e.Cancel = False
            '        End If
            '    End If
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try
        End Sub

        Private Sub TxtNatureCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNatureCode.ValueChanged

        End Sub

        Private Sub TxtTransactionTypeCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtTransactionTypeCode.ValueChanged

        End Sub

        Private Sub TxtGLCode_ValueChanged(sender As Object, e As EventArgs) Handles TxtGLCode.ValueChanged

        End Sub
    End Class

End Namespace