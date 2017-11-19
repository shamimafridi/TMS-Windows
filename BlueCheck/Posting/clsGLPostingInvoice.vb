Option Strict Off
Option Explicit On
Friend Class clsGLPostingInvoice
	
	Public DocumentNo As String
    Public DocumentNature As String
	Public DocumentDate As Date
	Public InvoiceNo As String
	Public Amount As Double
	Public AmountUsed As Double
	
	Private mInvoiceDetail As New Collection
	
	Public Sub Add(ByRef Item As clsGLPostingInvoiceDetail, Optional ByRef key As Object = Nothing)
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(key) Then
			mInvoiceDetail.Add(Item)
		Else
			mInvoiceDetail.Add(Item, key)
		End If
	End Sub
	
	Public Function Count() As Integer
		Count = mInvoiceDetail.Count()
	End Function
	
	Public Function Item(ByRef Index As Integer) As clsGLPostingInvoiceDetail
		Item = mInvoiceDetail.Item(Index)
	End Function
	
	Public Sub Remove(ByRef Index As Integer)
		mInvoiceDetail.Remove(Index)
	End Sub
	
    Public Function AddInvoiceDetail(ByRef RefDocumentNo As String, ByRef RefDocumentNature As String, ByRef RefDocumentDate As Date, ByRef RefInvoiceNo As String, ByRef AmountUsed As Double) As clsGLPostingInvoiceDetail

        Dim InvD As New clsGLPostingInvoiceDetail

        InvD.RefDocumentNature = RefDocumentNature
        InvD.RefDocumentNo = RefDocumentNo
        InvD.RefDocumentDate = RefDocumentDate
        InvD.RefInvoiceNo = RefInvoiceNo
        InvD.AmountUsed = AmountUsed
        AddInvoiceDetail = InvD
        Add(InvD)

    End Function
End Class