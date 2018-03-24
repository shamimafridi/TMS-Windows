Imports Infragistics.Win.UltraWinEditors

Public Class DestinationPoints

    Private Sub txtDestinationPointCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDestinationPointCode.KeyDown
        Try
            If e.KeyCode = Keys.F3 Then
                Call Me.CmdDestinationPointList_Click(sender, New System.EventArgs)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtDestinationPointCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtDestinationPointCode.Validating
        If Trim(txtDestinationPointCode.Text) <> "" Then
            If Trim(txtDestinationPointCode.Text).Length <> txtDestinationPointCode.MaxLength Then
                e.Cancel = True
                ErrProvider.SetError(txtDestinationPointCode, " Please Enter a Proper length of Code ")
            End If
        End If

    End Sub
    Private Sub txtDestinationPointCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDestinationPointCode.Validated
        ErrProvider.SetError(txtDestinationPointCode, "")
    End Sub

    Private Sub DestinationPoints_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
    End Sub
    Private Sub CmdDestinationPointList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("DestinationPoints")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.txtDestinationPointCode.Text = frmser.UGSearch.Rows(iRow).Cells("DestinationPointCode").Value
            Me.Desc.Text = frmser.UGSearch.Rows(iRow).Cells("DestinationPointName").Value
            Me.txtDestinationPointCode.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtDestinationPointCode_EditorButtonClick(sender As Object, e As EditorButtonEventArgs) Handles txtDestinationPointCode.EditorButtonClick
        Call Me.CmdDestinationPointList_Click(sender, New System.EventArgs)
    End Sub
End Class
