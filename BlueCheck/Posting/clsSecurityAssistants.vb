Option Strict Off
Option Explicit On
Friend Class clsSecurityAssistants
	Private SecurityAssistant As New Collection
	
	Public Sub Add(ByRef Item As clsSecurityAssistant, Optional ByRef key As Object = Nothing)
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(key) Then
			SecurityAssistant.Add(Item)
		Else
			SecurityAssistant.Add(Item, key)
		End If
	End Sub
	
	Public Function Count() As Short
		Count = SecurityAssistant.Count()
	End Function
	
	Public Function Item(ByRef UserID As String) As clsSecurityAssistant
		Item = SecurityAssistant.Item(UserID)
	End Function
	
	Public Function ItemIndex(ByRef Index As Integer) As clsSecurityAssistant
		ItemIndex = SecurityAssistant.Item(Index)
	End Function
	
	Public Sub Remove(ByRef Index As Integer)
		Call SecurityAssistant.Remove(Index)
	End Sub
	
	Public Function AddAssistant(ByRef UserID As String, ByRef UserName As String, ByRef Manager As String) As clsSecurityAssistant
		Dim S As New clsSecurityAssistant
		
		If isExist(UserID) Then
			AddAssistant = SecurityAssistant.Item(UserID)
		Else
			S.UserID = UserID
			S.UserName = UserName
			S.Manager = Manager
			Add(S, UserID)
			AddAssistant = S
		End If
		
	End Function
	
	Public Function isExist(ByVal UserID As String) As Boolean
		
		On Error GoTo ERR_isExist
        Dim obj As Object = SecurityAssistant.Item(UserID)
		isExist = True
		Exit Function
ERR_isExist: 
		isExist = False
		Err.Clear() : Err.Clear()
		
	End Function
End Class