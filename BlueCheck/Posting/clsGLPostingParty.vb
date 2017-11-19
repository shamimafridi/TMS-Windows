Option Strict Off
Option Explicit On
Friend Class clsGLPostingParty
	
    Public PartyCode As String
	'Public PartyType            As String   ' Debitors and Creditors
	Public PartyBalance As Double
	Public PartyPaymentBalance As Double
	
	
	Private mInvoices As New Collection
	Private mPendingPayments As New Collection
	Private mLastInvoicePtr As Integer
	
	Public Sub Add(ByRef Item As clsGLPostingInvoice, Optional ByRef key As Object = Nothing)
		'UPGRADE_WARNING: Couldn't resolve default property of object key. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(key) Or key = "" Then
			mInvoices.Add(Item)
		Else
			mInvoices.Add(Item, key)
		End If
	End Sub
	
	Public Function Count() As Short
		Count = mInvoices.Count()
	End Function
	
	Public Function Item(ByRef InvoiceNo As String) As clsGLPostingInvoice
		On Error Resume Next
		Item = mInvoices.Item(InvoiceNo)
	End Function
	
	Public Function ItemIndex(ByRef Index As Object) As clsGLPostingInvoice
		ItemIndex = mInvoices.Item(Index)
	End Function
	
	Public Sub Remove(ByRef InvoiceNo As String)
		mInvoices.Remove(InvoiceNo)
	End Sub
	
    Public Function AddInvoice(ByRef DocumentNo As String, ByRef DocumentNature As String, ByRef DocumentDate As Date, ByRef InvoiceNo As String, ByRef InvoiceAmount As Double, ByRef InvoiceAmountUsed As Double) As clsGLPostingInvoice

        Dim Inv As New clsGLPostingInvoice

        If InvoiceNo = "" Then Err.Raise(CInt("1001"), "Add Invoice", "Invoice No Is Missing")
        If isExist(InvoiceNo) Then Err.Raise(CInt("1001"), "Add Invoice", "Invoice No " & InvoiceNo & " Dulplication Error")

        Inv.DocumentNo = DocumentNo
        Inv.DocumentNature = DocumentNature
        Inv.DocumentDate = DocumentDate

        Inv.InvoiceNo = InvoiceNo
        Inv.Amount = InvoiceAmount
        Me.PartyBalance = Me.PartyBalance + InvoiceAmount - InvoiceAmountUsed
        Inv.AmountUsed = InvoiceAmountUsed

        'Call AdjustPendingPayments

        Add(Inv, InvoiceNo)
        AddInvoice = Inv

    End Function
	
    Public Sub AddPayment(ByRef DocumentNo As String, ByRef DocumentNature As String, ByRef DocumentDate As Date, ByRef InvoiceNo As String, ByRef PaymentAmount As Double, ByRef PaymentAmountUsed As Double)

        Dim Pay As New clsGLPostingPayment
        'Dim nInvoiceNo As String

        'If PaymentAmount <= Me.PartyBalance Then
        '    If UCase(Trim(InvoiceNo)) = "AUTO" Or UCase(Trim(InvoiceNo)) = "" Then
        '        nInvoiceNo = ""
        '    Else
        '        nInvoiceNo = InvoiceNo
        '    End If
        '    Call AdjustPayment(DocumentNo, DocumentNature, DocumentDate, nInvoiceNo, PaymentAmount)
        'Else

        Pay.DocumentNo = DocumentNo
        Pay.DocumentNature = DocumentNature
        Pay.DocumentDate = DocumentDate
        Pay.PaymentAmount = PaymentAmount
        Me.PartyPaymentBalance = Me.PartyPaymentBalance + PaymentAmount - PaymentAmountUsed
        Pay.PaymentAmountUsed = PaymentAmountUsed

        If UCase(Trim(InvoiceNo)) = "AUTO" Or UCase(Trim(InvoiceNo)) = "" Then
            Pay.InvoiceNo = ""
        Else
            Pay.InvoiceNo = InvoiceNo
        End If
        Call mPendingPayments.Add(Pay)
        'End If
    End Sub
	
	Public Sub AdjustPendingPayments()
		Dim I As Integer
		Dim PtrPayment As clsGLPostingPayment
		Dim HaveDone As Boolean
		
		
		For I = 1 To mPendingPayments.Count()
			PtrPayment = mPendingPayments.Item(I)
			
			If PtrPayment.InvoiceNo <> "" Then
				Call AdjustPaymentBillToBill(PtrPayment)
			End If
			
		Next I
		
		For I = 1 To mPendingPayments.Count()
			PtrPayment = mPendingPayments.Item(I)
			
			If PtrPayment.PaymentAmount > PtrPayment.PaymentAmountUsed Then HaveDone = AdjustPaymentOnFIFO(PtrPayment)
			
		Next I
		
	End Sub
	
	Private Function AdjustPaymentBillToBill(ByRef PtrPayment As clsGLPostingPayment) As Boolean
		
		Dim PtrInv As clsGLPostingInvoice

		If isExist(PtrPayment.InvoiceNo) Then
			PtrInv = Item((PtrPayment.InvoiceNo))
			If PtrInv.Amount - PtrInv.AmountUsed >= PtrPayment.PaymentAmount - PtrPayment.PaymentAmountUsed Then
				Call PtrInv.AddInvoiceDetail((PtrPayment.DocumentNo), (PtrPayment.DocumentNature), (PtrPayment.DocumentDate), (PtrPayment.InvoiceNo), PtrPayment.PaymentAmount - PtrPayment.PaymentAmountUsed)
				PtrInv.AmountUsed = PtrInv.AmountUsed + PtrPayment.PaymentAmount - PtrPayment.PaymentAmountUsed
				PtrPayment.PaymentAmountUsed = PtrPayment.PaymentAmount
			Else
				Call PtrInv.AddInvoiceDetail((PtrPayment.DocumentNo), (PtrPayment.DocumentNature), (PtrPayment.DocumentDate), (PtrPayment.InvoiceNo), PtrInv.Amount - PtrInv.AmountUsed)
				PtrPayment.PaymentAmountUsed = PtrPayment.PaymentAmountUsed + PtrInv.Amount - PtrInv.AmountUsed
				PtrInv.AmountUsed = PtrInv.Amount
			End If
			AdjustPaymentBillToBill = True
		Else
			AdjustPaymentBillToBill = False
		End If
		
	End Function
	
	Private Function AdjustPaymentOnFIFO(ByRef PtrPayment As clsGLPostingPayment) As Boolean
		
		Dim PtrInv As clsGLPostingInvoice
		Dim PaymentAmount As Double
		
		PaymentAmount = PtrPayment.PaymentAmount - PtrPayment.PaymentAmountUsed
		
		Do 
			PtrInv = FindNextInvoice()
			If Not (PtrInv Is Nothing) Then
				If PtrInv.Amount - PtrInv.AmountUsed >= PaymentAmount Then
					Call PtrInv.AddInvoiceDetail((PtrPayment.DocumentNo), (PtrPayment.DocumentNature), (PtrPayment.DocumentDate), (PtrPayment.InvoiceNo), PtrPayment.PaymentAmount - PtrPayment.PaymentAmountUsed)
					PtrInv.AmountUsed = PtrInv.AmountUsed + PtrPayment.PaymentAmount - PtrPayment.PaymentAmountUsed
					PtrPayment.PaymentAmountUsed = PtrPayment.PaymentAmount
				Else
					Call PtrInv.AddInvoiceDetail((PtrPayment.DocumentNo), (PtrPayment.DocumentNature), (PtrPayment.DocumentDate), (PtrPayment.InvoiceNo), PtrInv.Amount - PtrInv.AmountUsed)
					PtrPayment.PaymentAmountUsed = PtrPayment.PaymentAmountUsed + PtrInv.Amount - PtrInv.AmountUsed
					PtrInv.AmountUsed = PtrInv.Amount
				End If
				PaymentAmount = PtrPayment.PaymentAmount - PtrPayment.PaymentAmountUsed
			Else
				Exit Do
			End If
		Loop While PaymentAmount > 0
		
	End Function
	
	Private Function FindNextInvoice() As clsGLPostingInvoice
		Dim Inv As clsGLPostingInvoice
		Dim I As Integer
		
		For I = mLastInvoicePtr To mInvoices.Count()
			Inv = mInvoices.Item(I)
			If Inv.Amount > Inv.AmountUsed Then
				FindNextInvoice = Inv
				mLastInvoicePtr = I
				Exit Function
			End If
		Next I
		'UPGRADE_NOTE: Object FindNextInvoice may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
		FindNextInvoice = Nothing
		
	End Function
	
	Public Function isExist(ByVal InvoiceNo As String) As Boolean
		Dim I As Short
		On Error GoTo ERR_isExist
        Dim obj As Object = mInvoices.Item(InvoiceNo)
		isExist = True
		Exit Function
ERR_isExist: 
		isExist = False
		Err.Clear() : Err.Clear()
	End Function
	
	'UPGRADE_NOTE: Class_Initialize was upgraded to Class_Initialize_Renamed. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub Class_Initialize_Renamed()
		mLastInvoicePtr = 1
	End Sub
	Public Sub New()
		MyBase.New()
		Class_Initialize_Renamed()
	End Sub
End Class