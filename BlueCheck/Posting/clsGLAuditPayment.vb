Option Strict Off
Option Explicit On
Friend Class clsGLAuditPayment
	
	Public AbsolutePosition As Integer
	Public DocumentNo As String
    Public DocumentNature As String
	Public DocumentDate As Date
	Public InvoiceNo As String
	Public PaymentAmount As Double
	Public PaymentAmountUsed As Double
	Public Autoable As Boolean
End Class