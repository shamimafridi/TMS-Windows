Public Class MasterVoucher
    Public VoucherMasterTable As DataTable
    Private Col_BranchCode As DataColumn
    Private Col_VoucherNo As DataColumn
    Private Col_VoucherNature As DataColumn
    Private Col_VoucherDate As DataColumn
    Private Col_Description As DataColumn
    Private Col_UrduDescription As DataColumn
    Private Col_Locked As DataColumn
    Private Col_Posted As DataColumn
    Private Col_IsAutoGenerated As DataColumn

    Friend BranchCode As String
    Friend Branch As String
    Friend VoucherNo As String
    Friend VoucherNature As String
    Friend Description As String
    Friend UrduDescription As String
    Friend VoucherDate As Date

    Sub New(ByVal BranchCode As String, ByVal VoucherNo As String, ByVal VoucherNature As String)
        VoucherMasterTable = New DataTable

        Me.BranchCode = BranchCode
        Me.VoucherNo = VoucherNo
        Me.VoucherNature = VoucherNature
        Me.VoucherNature = VoucherNature

        Me.Col_BranchCode = New DataColumn("BranchCode")
        Me.Col_VoucherNo = New DataColumn("TransactionNo")
        Me.Col_VoucherNature = New DataColumn("TransactionNature")
        Me.Col_VoucherDate = New DataColumn("TransactionDate")
        Me.Col_Description = New DataColumn("Description")
        Me.Col_UrduDescription = New DataColumn("UrduTitle")
        Me.Col_Locked = New DataColumn("Locked")
        Me.Col_Posted = New DataColumn("Posted")
        Me.Col_IsAutoGenerated = New DataColumn("IsAutoGenerated")

        VoucherMasterTable.Columns.Add(Me.Col_BranchCode)
        VoucherMasterTable.Columns.Add(Me.Col_VoucherNo)
        VoucherMasterTable.Columns.Add(Me.Col_VoucherNature)
        VoucherMasterTable.Columns.Add(Me.Col_VoucherDate)
        VoucherMasterTable.Columns.Add(Me.Col_Description)
        VoucherMasterTable.Columns.Add(Me.Col_UrduDescription)
        VoucherMasterTable.Columns.Add(Me.Col_Locked)
        VoucherMasterTable.Columns.Add(Me.Col_Posted)
        VoucherMasterTable.Columns.Add(Me.Col_IsAutoGenerated)

    End Sub
    Public Sub CreateRow()
        Try

            Dim row As DataRow
            row = VoucherMasterTable.NewRow
            VoucherMasterTable.Rows.Add(row)
            row.Item(Me.Col_BranchCode) = Me.BranchCode
            row.Item(Me.Col_VoucherNo) = Me.VoucherNo
            row.Item(Me.Col_VoucherNature) = Me.VoucherNature
            row.Item(Me.Col_VoucherDate) = Format(Me.VoucherDate, MySettingReader.Read("DateFormat", MySettingReader.FieldLevel.ApplicationLevel))
            row.Item(Me.Col_Description) = Me.Description
            row.Item(Me.Col_UrduDescription) = Me.UrduDescription
            row.Item(Me.Col_Locked) = 0
            row.Item(Me.Col_Posted) = 0
            row.Item(Me.Col_IsAutoGenerated) = 1

            '    VoucherMasterTable.AcceptChanges()

        Catch ex As Exception
            Throw New Exception("Data of Master Voucher can't be created " & vbCrLf & ex.Message)
        End Try
    End Sub

End Class
