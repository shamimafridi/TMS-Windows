Option Strict Off
Option Explicit On
Friend Class clsSecuritySetting
	
	Public UserID As String
	
	'Private IsSetted As Boolean
	Private nSecSetting As New Collection
	Public Assistants As New clsSecurityAssistants
	Private colIsModAdmin As New Collection
	
	Public Sub Add(ByRef Item As clsSecurityData, Optional ByRef key As Object = Nothing)
		'UPGRADE_NOTE: IsMissing() was changed to IsNothing(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="8AE1CB93-37AB-439A-A4FF-BE3B6760BB23"'
		If IsNothing(key) Then
			nSecSetting.Add(Item)
		Else
			nSecSetting.Add(Item, key)
		End If
	End Sub
	
	Public Function Count() As Short
		Count = nSecSetting.Count()
	End Function
	
	Public Function ItemIndex(ByRef Index As Integer) As clsSecurityData
		ItemIndex = nSecSetting.Item(Index)
	End Function
	
	Public Function Item(ByRef nModuleID As Integer, ByRef nFormID As Integer) As clsSecurityData
		Item = nSecSetting.Item(GenrateKey(nModuleID, nFormID))
	End Function
	
	Public Sub Remove(ByRef nModuleID As Integer, ByRef nFormID As Integer)
		nSecSetting.Remove(GenrateKey(nModuleID, nFormID))
	End Sub
	
    Public Sub AddSecData(ByRef nModuleID As Integer, ByRef nFormID As Integer, ByRef nAccessKey As String)
        Dim oneSecData As New clsSecurityData

        If isExist(nModuleID, nFormID) Then
            oneSecData = nSecSetting.Item(GenrateKey(nModuleID, nFormID))
            oneSecData.AccessKeyData = (nAccessKey Or oneSecData.AccessKeyData)
        Else
            oneSecData.ModuleID = nModuleID
            oneSecData.FormID = CStr(nFormID)
            oneSecData.AccessKeyData = CInt(nAccessKey)
            oneSecData.Parent = Me
            Add(oneSecData, GenrateKey(nModuleID, nFormID))
        End If
    End Sub
	
	Private Function GenrateKey(ByRef ModuleID As Integer, ByRef FormID As Integer) As String
		GenrateKey = "A" & ModuleID & "-" & FormID
	End Function
	
	Private Function GenrateKeyModAdmin(ByRef ModuleID As Integer) As String
		GenrateKeyModAdmin = "A" & ModuleID
	End Function
	
	Public Function isExist(ByRef nModuleID As Integer, ByRef nFormID As Integer) As Boolean
		On Error GoTo ERR_isExist
		
        Dim obj As Object = nSecSetting.Item(GenrateKey(nModuleID, nFormID))
		isExist = True
		
		Exit Function
ERR_isExist: 
		isExist = False
		Err.Clear() : Err.Clear()
	End Function
	
	Public Sub LoadSecSetting()
        'Dim GetSetupProfileValue As Object
        'Dim AWA_SecuritySettings As Object
        'Dim MTS_ServerName As Object
        'Dim prgID_clsDataModify As Object
        ''If IsSetted Then Exit Sub
        '      Dim nRst As SqlClient.SqlDatareader
        'Dim I As Integer
        'Dim OBJ As Object
        'Dim PreviousValue As Boolean

        'OBJ = CreateObject(prgID_clsDataModify, MTS_ServerName)
        ''UPGRADE_WARNING: Couldn't resolve default property of object OBJ.GetModify. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Call OBJ.GetModify(AWA_SecuritySettings, nRst, "SEC_GetUserAccessRightSP", "UserID", Trim(UserID), "nType", 1)

        '      If nRst.HasRows Then
        '          Do Until nRst.Read
        '              Call AddSecData(nRst.Item("ModuleID").Value, nRst.Item("FormID").Value, nRst.Item("AccessKey").Value)
        '          Loop
        '      End If

        '      'UPGRADE_NOTE: Object nRst may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        '      nRst = Nothing
        '      OBJ = CreateObject(prgID_clsDataModify, MTS_ServerName)
        '      'UPGRADE_WARNING: Couldn't resolve default property of object OBJ.GetModify. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '      Call OBJ.GetModify(AWA_SecuritySettings, nRst, "SEC_GetGroupAccessRightSP", "UserID", Trim(UserID), "nType", 1)

        '      If nRst.HasRows Then
        '          Do Until nRst.Read
        '              Call AddSecData(nRst.Item("ModuleID").Value, nRst.Item("FormID").Value, nRst.Item("AccessKey").Value)

        '              If isExistModAdmin(nRst.Item("ModuleID").Value) Then
        '                  'UPGRADE_WARNING: Couldn't resolve default property of object colIsModAdmin.Item(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '                  PreviousValue = colIsModAdmin.Item(GenrateKeyModAdmin(nRst.Item("ModuleID").Value))
        '                  colIsModAdmin.Remove((GenrateKeyModAdmin(nRst.Item("ModuleID").Value)))
        '                  'UPGRADE_WARNING: Couldn't resolve default property of object GetSetupProfileValue(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '                  colIsModAdmin.Add(PreviousValue Or Trim(nRst.Item("GroupID").Value) = Trim(GetSetupProfileValue(AWA_SecuritySettings, "AdministratorGroup")), GenrateKeyModAdmin(nRst.Item("ModuleID").Value))
        '                  'colIsModAdmin.Item(GenrateKeyModAdmin(nRst.item("ModuleID"))) = CBool(colIsModAdmin.Item(GenrateKeyModAdmin(nRst.item("ModuleID"))) Or (Trim(nRst!GroupID) = Trim(GetSetupProfileValue(AWA_SecuritySettings, "AdministratorGroup"))))
        '              Else
        '                  'UPGRADE_WARNING: Couldn't resolve default property of object GetSetupProfileValue(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '                  colIsModAdmin.Add(Trim(nRst.Item("GroupID").Value) = Trim(GetSetupProfileValue(AWA_SecuritySettings, "AdministratorGroup")), GenrateKeyModAdmin(nRst.Item("ModuleID").Value))
        '              End If
        '          Loop
        '      End If

        '      'UPGRADE_NOTE: Object nRst may not be destroyed until it is garbage collected. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6E35BFF6-CD74-4B09-9689-3E1A43DF8969"'
        '      nRst = Nothing
        '      OBJ = CreateObject(prgID_clsDataModify, MTS_ServerName)
        '      'UPGRADE_WARNING: Couldn't resolve default property of object OBJ.GetModify. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '      Call OBJ.GetModify(AWA_SecuritySettings, nRst, "SEC_GetUserSP", "UserID", Trim(UserID), "nType", 3)

        '      If nRst.HasRows  Then
        '          Do Until nRst.Read
        '              Call Assistants.AddAssistant(Trim(nRst.Item("UserID").Value & ""), Trim(nRst.Item("UserName").Value & ""), Trim(nRst.Item("Manager").Value & ""))
        '          Loop
        '      End If
		
	End Sub
	
	Public Function isExistModAdmin(ByRef nModuleID As Integer) As Boolean
		On Error GoTo ERR_isExistModAdmin
		
        Dim obj As Object = colIsModAdmin.Item(GenrateKeyModAdmin(nModuleID))
		isExistModAdmin = True
		
		Exit Function
ERR_isExistModAdmin: 
		isExistModAdmin = False
		Err.Clear() : Err.Clear()
	End Function
	
	Public Function IsModAdmin(ByRef nModuleID As Integer) As Boolean
		
		If isExistModAdmin(nModuleID) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object colIsModAdmin.Item(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			IsModAdmin = colIsModAdmin.Item(GenrateKeyModAdmin(nModuleID))
		Else
			IsModAdmin = False
		End If
		
	End Function
End Class