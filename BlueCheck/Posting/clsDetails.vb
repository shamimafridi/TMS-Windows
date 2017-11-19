Option Strict Off
Option Explicit On
Friend Class Details
	Private mDetail As New Collection
	
	Public Sub Add(ByRef Item As Detail, Optional ByRef key As Object = Nothing)
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(key) Then
			mDetail.Add(Item)
		Else
			mDetail.Add(Item, key)
		End If
	End Sub
	
	Public Function Count() As Short
		Count = mDetail.Count()
	End Function
	
	Public Function Item(ByRef Index As Object) As Detail
		Item = mDetail.Item(Index)
	End Function
	
	Public Sub Remove(ByRef Index As Object)
		mDetail.Remove(Index)
	End Sub
	
	Public Function AddDetail(ByRef StoreProcedure As String, Optional ByRef key As Object = Nothing) As Detail
		'        Optional OptionVariable As String = "@OPTION"
		'        Optional ParameterAll As String = "ALL", _
		''
		Dim d As New Detail
		d.StoreProcedure = StoreProcedure
		'    d.ParameterAll = ParameterAll
		'    d.OptionVariable = OptionVariable
		Add(d, key)
		AddDetail = d
	End Function
End Class