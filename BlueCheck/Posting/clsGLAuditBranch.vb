Option Strict Off
Option Explicit On
Friend Class clsGLAuditBranch
	
    Public BranchCode As String
	Private sParty As New Collection
	
	Public Sub Add(ByRef Item As clsGLAuditParty, Optional ByRef key As Object = Nothing)
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(key) Then
			sParty.Add(Item)
		Else
			sParty.Add(Item, key)
		End If
	End Sub
	
	Public Function Count() As Short
		Count = sParty.Count()
	End Function
	
    Public Function Item(ByRef PartyCode As String) As clsGLAuditParty
        On Error Resume Next
        Item = sParty.Item(GenrateKeyParty(PartyCode))
    End Function
	
	Public Function ItemIndex(ByRef Index As Integer) As clsGLAuditParty
		ItemIndex = sParty.Item(Index)
	End Function
	
    Public Sub Remove(ByRef PartyCode As String, ByRef SerialNo As String)
        sParty.Remove(GenrateKeyParty(PartyCode))
    End Sub
	
    Public Function AddParty(ByRef PartyCode As String, ByRef PartyType As String) As clsGLAuditParty

        Dim p As New clsGLAuditParty
        If isExist(PartyCode) Then
            AddParty = sParty.Item(GenrateKeyParty(PartyCode))
        Else
            p.PartyCode = PartyCode
            p.PartyType = PartyType
            p.PartyBalance = 0
            Add(p, GenrateKeyParty(PartyCode))
            AddParty = p
        End If

    End Function
	
    Private Function GenrateKeyParty(ByRef PartyCode As String) As String
        GenrateKeyParty = "A" & Format(PartyCode, "0000000000")
    End Function
	
    Private Function isExist(ByVal PartyCode As String) As Boolean
        Dim I As Short
        On Error GoTo ERR_isExist
        Dim obj As Object = sParty.Item(GenrateKeyParty(PartyCode))
        isExist = True
        Exit Function
ERR_isExist:
        isExist = False
        Err.Clear() : Err.Clear()
    End Function
End Class