Option Strict Off
Option Explicit On
Friend Class clsGLPostingBranchs
	Private PostingBranch As New Collection
	
	Public Sub Add(ByRef Item As clsGLPostingBranch, Optional ByRef key As Object = Nothing)
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(key) Then
			PostingBranch.Add(Item)
		Else
			PostingBranch.Add(Item, key)
		End If
	End Sub
	
	Public Function Count() As Short
		Count = PostingBranch.Count()
	End Function
	
    Public Function Item(ByRef BranchCode As String) As clsGLPostingBranch
        Item = PostingBranch.Item(GenrateKeyBranch(BranchCode))
    End Function
	
	Public Function ItemIndex(ByRef Index As Integer) As clsGLPostingBranch
		ItemIndex = PostingBranch.Item(Index)
	End Function
	
	Public Sub Remove(ByRef Index As Integer)
		PostingBranch.Remove(GenrateKeyBranch(Index))
	End Sub
	
    Public Function AddBranch(ByRef BranchCode As String) As clsGLPostingBranch

        Dim S As New clsGLPostingBranch
        If isExist(BranchCode) Then
            AddBranch = PostingBranch.Item(GenrateKeyBranch(BranchCode))
        Else
            S.BranchCode = BranchCode
            Add(S, GenrateKeyBranch(BranchCode))
            AddBranch = S
        End If

    End Function
	
    Private Function GenrateKeyBranch(ByRef BranchCode As String) As String
        GenrateKeyBranch = "A" & Format(BranchCode, "00000")
    End Function
	
    Private Function isExist(ByVal BranchCode As String) As Boolean

        On Error GoTo ERR_isExist
        Dim obj As Object = PostingBranch.Item(GenrateKeyBranch(BranchCode))
        isExist = True
        Exit Function
ERR_isExist:
        isExist = False
        Err.Clear() : Err.Clear()

    End Function
End Class