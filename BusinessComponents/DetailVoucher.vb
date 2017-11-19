Public Class DetailVoucher
    Public VoucherDetailTable As DataTable
    Private Col_BranchCode As DataColumn
    Private Col_VoucherNo As DataColumn
    Private Col_VoucherNature As DataColumn
    Private Col_Reference As DataColumn
    Private Col_DivisionCode As DataColumn
    Private Col_GLCode As DataColumn
    Private Col_Debit As DataColumn
    Private Col_Credit As DataColumn
    Private Col_Narration As DataColumn


    Friend BranchCode As String
    Friend Branch As String
    Friend VoucherNo As String
    Friend VoucherNature As String
    Friend GLCode As String
    Friend Reference As String
    Friend DivisionCode As String
    Friend Debit As Decimal
    Friend Credit As Decimal
    Friend Narration As String

    Sub New(ByVal BranchCode As String, ByVal VoucherNo As String, ByVal VoucherNature As String)
        VoucherDetailTable = New DataTable

        Me.BranchCode = BranchCode
        Me.VoucherNo = VoucherNo
        Me.VoucherNature = VoucherNature
        Me.VoucherNature = VoucherNature

        Me.Col_BranchCode = New DataColumn("BranchCode")
        Me.Col_VoucherNo = New DataColumn("TransactionNo")
        Me.Col_VoucherNature = New DataColumn("TransactionNature")

        Me.Col_GLCode = New DataColumn("GLCode")
        Me.Col_DivisionCode = New DataColumn("DivisionCode")

        Me.Col_Reference = New DataColumn("Reference")
        Me.Col_Debit = New DataColumn("Debit")
        Me.Col_Credit = New DataColumn("Credit")
        Me.Col_Narration = New DataColumn("Narration")


        VoucherDetailTable.Columns.Add(Me.Col_BranchCode)
        VoucherDetailTable.Columns.Add(Me.Col_VoucherNo)
        VoucherDetailTable.Columns.Add(Me.Col_VoucherNature)
        VoucherDetailTable.Columns.Add(Me.Col_GLCode)
        VoucherDetailTable.Columns.Add(Me.Col_Reference)
        VoucherDetailTable.Columns.Add(Me.Col_DivisionCode)
        VoucherDetailTable.Columns.Add(Me.Col_Debit)
        VoucherDetailTable.Columns.Add(Me.Col_Credit)
        VoucherDetailTable.Columns.Add(Me.Col_Narration)

    End Sub
    Public Sub CreateRow()
        Try

            Dim row As DataRow
            row = VoucherDetailTable.NewRow
            VoucherDetailTable.Rows.Add(row)

           

            row.Item(Me.Col_BranchCode) = Me.BranchCode
            row.Item(Me.Col_VoucherNo) = Me.VoucherNo
            row.Item(Me.Col_VoucherNature) = Me.VoucherNature

            row.Item(Me.Col_GLCode) = Me.GLCode
            row.Item(Me.Col_DivisionCode) = Me.DivisionCode
            row.Item(Me.Col_Reference) = Me.Reference
            row.Item(Me.Col_Debit) = Me.Debit
            row.Item(Me.Col_Credit) = Me.Credit
            row.Item(Me.Col_Narration) = Me.Narration

        Catch ex As Exception
            Throw New Exception("Data of Master Voucher can't be created " & vbCrLf & ex.Message)
        End Try
    End Sub

End Class
