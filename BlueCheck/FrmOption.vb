Public Class FrmOption

    Private Sub DtpWorkingDate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpWorkingDate.Validated
        ErrProvider.SetError(DtpWorkingDate, String.Empty)
    End Sub
    Private Sub dtpWorkingDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DtpWorkingDate.Validating

        If CurrentWorkingDate > DtpWorkingDate.Value Then
            ErrProvider.SetError(DtpWorkingDate, "Working date must be greater than the previouse working date value = " & vbCrLf & Format(CurrentWorkingDate, My.Settings.DateFormat))
            ErrProvider.SetIconAlignment(DtpWorkingDate, ErrorIconAlignment.MiddleRight)
            e.Cancel = True
        End If
    End Sub
    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click

        Dim DM As AzamTechnologies.Database.DataModify
        Try
            If CurrentWorkingDate <> Me.DtpWorkingDate.Value Then
                DM = New AzamTechnologies.Database.DataModify
                If DM.UpdateExecuteQuery("UPDATE OPTIONS SET OptionValue='" & Format(DtpWorkingDate.Value, My.Settings.DateFormat) & "' WHERE OptionName='WorkingDate'") > 0 Then
                    If MessageBox.Show("You must restart your application After changes made" & Chr(10) & "Are you sure to restart your application", "Restarting Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Application.Exit()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            DM = Nothing
        End Try
    End Sub

    Private Sub FrmOption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CmbIncrDays.Text = "0"
        Me.DtpWorkingDate.Value = CType(CurrentWorkingDate, Date)
        Me.DtpWorkingDate.Text = CType(CurrentWorkingDate, Date)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub CmbIncrDays_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbIncrDays.SelectedIndexChanged
        Me.DtpWorkingDate.Value = Me.DtpWorkingDate.Value.AddDays(Me.CmbIncrDays.Text)
    End Sub
End Class