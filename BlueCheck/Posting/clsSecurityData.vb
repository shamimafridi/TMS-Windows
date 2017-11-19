Option Strict Off
Option Explicit On
Friend Class clsSecurityData
	
	Public ModuleID As Integer
	Public FormID As String
	Public AccessKeyData As Integer
	Public Parent As clsSecuritySetting
	
	Public Enum AccessKeysEnum
		AccessKey = 1
		AddKey = 2
		EditKey = 4
		DeleteKey = 8
		LockKey = 16
		UnLockKey = 32
		PrintKey = 64
	End Enum
	
	Public Function IsAllow(ByRef key As AccessKeysEnum) As Boolean
		
		If IsAdministrator Then
			IsAllow = True
		Else
			IsAllow = ((AccessKeyData And key) <> 0)
		End If
		
	End Function
	
	Public ReadOnly Property IsAdministrator() As Boolean
		Get
			IsAdministrator = Parent.IsModAdmin(ModuleID)
		End Get
	End Property
End Class