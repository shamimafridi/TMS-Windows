Option Strict Off
Option Explicit On
Friend Class clsGLAuditParty
	
    Public PartyCode As String
	Public PartyType As String ' Debitors and Creditors
	Public PartyBalance As Double
	Public PartyPaymentBalance As Double
	
	
	Private mInvoices As New Collection
	Private mPendingPayments As New Collection
	Private mLastInvoicePtr As Integer
	
	Public Sub AddInvoiceRef(ByRef Item As clsGLAuditInvoice, Optional ByRef key As Object = Nothing)
        If IsNothing(key) Or CStr(key) = "" Then
            mInvoices.Add(Item)
        Else
            mInvoices.Add(Item, key)
        End If
	End Sub
	
	Public Sub AddPaymentRef(ByRef Item As clsGLAuditPayment, Optional ByRef key As Object = Nothing)
        If IsNothing(key) Or CStr(key) = "" Then
            mPendingPayments.Add(Item)
        Else
            mPendingPayments.Add(Item, key)
        End If
	End Sub
	
	Public Function CountInvoice() As Short
		CountInvoice = mInvoices.Count()
	End Function
	
	Public Function CountPayment() As Short
		CountPayment = mPendingPayments.Count()
	End Function
	
	Public Function ItemInvoice(ByRef InvoiceNo As String) As clsGLAuditInvoice
		On Error Resume Next
		ItemInvoice = mInvoices.Item(InvoiceNo)
	End Function
	
	Public Function ItemIndexPayment(ByRef Index As Object) As clsGLAuditPayment
		On Error Resume Next
		ItemIndexPayment = mPendingPayments.Item(Index)
	End Function
	
	Public Function ItemIndexInvoice(ByRef Index As Object) As clsGLAuditInvoice
		ItemIndexInvoice = mPendingPayments.Item(Index)
	End Function
	
	Public Sub RemoveInvoice(ByRef InvoiceNo As String)
		mInvoices.Remove(InvoiceNo)
	End Sub
	
	Public Sub RemovePayment(ByRef Index As Object)
		mPendingPayments.Remove(Index)
	End Sub
	
    Public Function AddInvoice(ByRef AbsolutePosition As Integer, ByRef DocumentNo As String, ByRef DocumentNature As String, ByRef DocumentDate As Date, ByRef InvoiceNo As String, ByRef InvoiceAmount As Double, ByRef InvoiceAmountUsed As Double) As clsGLAuditInvoice

        Dim Inv As New clsGLAuditInvoice

        If InvoiceNo = "" Then Err.Raise(CInt("1001"), "Add Invoice", "Invoice No Is Missing")
        Inv.AbsolutePosition = AbsolutePosition
        Inv.DocumentNo = DocumentNo
        Inv.DocumentNature = DocumentNature
        Inv.DocumentDate = DocumentDate

        Inv.InvoiceNo = InvoiceNo
        Inv.Amount = InvoiceAmount
        Me.PartyBalance = Me.PartyBalance + InvoiceAmount - InvoiceAmountUsed
        Inv.AmountUsed = InvoiceAmountUsed

        'Call AdjustPendingPayments
        AddInvoiceRef(Inv, InvoiceNo)
        AddInvoice = Inv

    End Function
	
    Public Sub AddPayment(ByRef AbsolutePosition As Integer, ByRef DocumentNo As String, ByRef DocumentNature As String, ByRef DocumentDate As Date, ByRef InvoiceNo As String, ByRef PaymentAmount As Double)

        Dim Pay As New clsGLAuditPayment
        Pay.AbsolutePosition = AbsolutePosition
        Pay.DocumentNo = DocumentNo
        Pay.DocumentNature = DocumentNature
        Pay.DocumentDate = DocumentDate
        Pay.PaymentAmount = PaymentAmount
        Me.PartyPaymentBalance = Me.PartyPaymentBalance + PaymentAmount

        If UCase(Trim(InvoiceNo)) = "AUTO" Or UCase(Trim(InvoiceNo)) = "" Then
            Pay.InvoiceNo = ""
        Else
            Pay.InvoiceNo = InvoiceNo
        End If
        Call AddPaymentRef(Pay)

    End Sub
	
	'Public Sub AuditPendingInvoice()
	'Dim I As Long
	'Dim PtrPayment As clsAuditPayment
	'Dim HaveDone As Boolean
	'
	'
	'For I = 1 To mPendingPayments.Count
	'    Set PtrPayment = mPendingPayments(I)
	'
	'    HaveDone = False
	'
	'    If PtrPayment.InvoiceNo <> "" Then
	'        HaveDone = AdjustPaymentBillToBill(PtrPayment)
	'    End If
	'
	'    If HaveDone = False Or PtrPayment.PaymentAmount > _
	''        PtrPayment.PaymentAmountUsed Then HaveDone = AdjustPaymentOnFIFO(PtrPayment)
	'
	'Next I
	'
	'End Sub
	
	Public Function AuditPendingPayment(ByRef Index As Object, ByRef ErrorNature As String) As Boolean
        Dim PtrPayment As clsGLAuditPayment
		Dim PtrInv As clsGLAuditInvoice
		
		PtrPayment = mPendingPayments.Item(Index)
		
		If PtrPayment.InvoiceNo <> "" Then
			If isExist(PtrPayment.InvoiceNo) Then
				PtrInv = ItemInvoice((PtrPayment.InvoiceNo))
				If PtrInv.Amount - PtrInv.AmountUsed >= PtrPayment.PaymentAmount - PtrPayment.PaymentAmountUsed Then
					PtrInv.AmountUsed = PtrInv.AmountUsed + PtrPayment.PaymentAmount - PtrPayment.PaymentAmountUsed
					PtrPayment.PaymentAmountUsed = PtrPayment.PaymentAmount
				Else
					ErrorNature = "Payment excess recvd for entered Invoice"
					Exit Function
				End If
				AuditPendingPayment = True
			Else
				ErrorNature = "Payment but Invoice No not found"
				Exit Function
			End If
		Else
			AuditPendingPayment = AdjustPaymentOnFIFO(PtrPayment, ErrorNature)
			Exit Function
		End If
		AuditPendingPayment = True
	End Function
	
	'Private Function AdjustPaymentBillToBill(PtrPayment As clsAuditPayment) As Boolean
	'
	'Dim PtrInv As clsAuditInvoice
	'Dim I As Long
	'
	'If isExist(PtrPayment.InvoiceNo) Then
	'    Set PtrInv = ItemInvoice(PtrPayment.InvoiceNo)
	'    If PtrInv.Amount - PtrInv.AmountUsed >= _
	''        PtrPayment.PaymentAmount - PtrPayment.PaymentAmountUsed Then
	'        PtrInv.AmountUsed = PtrInv.AmountUsed + PtrPayment.PaymentAmount - PtrPayment.PaymentAmountUsed
	'        PtrPayment.PaymentAmountUsed = PtrPayment.PaymentAmount
	'    Else
	'        PtrPayment.PaymentAmountUsed = PtrPayment.PaymentAmountUsed + PtrInv.Amount - PtrInv.AmountUsed
	'        PtrInv.AmountUsed = PtrInv.Amount
	'    End If
	'    AdjustPaymentBillToBill = True
	'Else
	'    AdjustPaymentBillToBill = False
	'End If
	'
	'End Function
	
	Private Function AdjustPaymentOnFIFO(ByRef PtrPayment As clsGLAuditPayment, ByRef ErrorNature As String) As Boolean
		
		Dim PtrInv As clsGLAuditInvoice
		Dim PaymentAmount As Double
		
		PaymentAmount = PtrPayment.PaymentAmount - PtrPayment.PaymentAmountUsed
		
		Do 
			PtrInv = FindNextInvoice()
			If Not (PtrInv Is Nothing) Then
				If PtrInv.Amount - PtrInv.AmountUsed >= PaymentAmount Then
					PtrInv.AmountUsed = PtrInv.AmountUsed + PtrPayment.PaymentAmount - PtrPayment.PaymentAmountUsed
					PtrPayment.PaymentAmountUsed = PtrPayment.PaymentAmount
				Else
					PtrPayment.PaymentAmountUsed = PtrPayment.PaymentAmountUsed + PtrInv.Amount - PtrInv.AmountUsed
					PtrInv.AmountUsed = PtrInv.Amount
				End If
				
				PaymentAmount = PtrPayment.PaymentAmount - PtrPayment.PaymentAmountUsed
			Else
				ErrorNature = "Payment excess recvd for entered Invoice"
				Exit Function
			End If
		Loop While PaymentAmount > 0
		AdjustPaymentOnFIFO = True
		
	End Function
	
	Private Function FindNextInvoice() As clsGLAuditInvoice
		Dim Inv As clsGLAuditInvoice
		Dim I As Integer
		
		For I = mLastInvoicePtr To mInvoices.Count()
			Inv = mInvoices.Item(I)
			If Inv.Amount > Inv.AmountUsed Then
				mLastInvoicePtr = I
				FindNextInvoice = Inv
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