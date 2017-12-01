Imports Infragistics.Win.UltraWinEditors

Module ControlFormatter
    Sub InitializedFormat(ByRef Control As Windows.Forms.Control)

        Dim ctrlBorderStyle As Infragistics.Win.UIElementBorderStyle = Infragistics.Win.UIElementBorderStyle.WindowsVista
        If TypeOf Control Is Infragistics.Win.UltraWinEditors.UltraTextEditor Or Control.GetType.ToString = "ATUrduTextBox.UrduTextBox" Then
            Dim UltrCtrl As Infragistics.Win.UltraWinEditors.UltraTextEditor
            UltrCtrl = Control
            UltrCtrl.UseAppStyling = True
            UltrCtrl.BorderStyle = ctrlBorderStyle
            
            If Mid(UltrCtrl.Tag, 1, 2) = "FK" Or Mid(UltrCtrl.Tag, 1, 2) = "PK" Then
                Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
                Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
                EditorButton1.Appearance = Appearance1
                EditorButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
                Appearance1.Image = Global.AzamTechnologies.My.Resources.search
                UltrCtrl.ButtonsRight.Clear()
                UltrCtrl.ButtonsRight.Add(EditorButton1)
                UltrCtrl.BorderStyle = ctrlBorderStyle
            End If
        ElseIf TypeOf Control Is Infragistics.Win.UltraWinEditors.UltraCheckEditor Then
            Dim UltrCtrl As Infragistics.Win.UltraWinEditors.UltraCheckEditor
            UltrCtrl = Control
            UltrCtrl.UseAppStyling = False
        ElseIf TypeOf Control Is Infragistics.Win.UltraWinEditors.UltraComboEditor Then
            Dim UltrCtrl As Infragistics.Win.UltraWinEditors.UltraComboEditor
            UltrCtrl = Control
            UltrCtrl.UseAppStyling = True
            UltrCtrl.BorderStyle = ctrlBorderStyle
            UltrCtrl.UseAppStyling = True
            '

            If Mid(UltrCtrl.Tag, 1, 2) = "FK" Or Mid(UltrCtrl.Tag, 1, 2) = "PK" Then
                Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
                Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
                EditorButton1.Appearance = Appearance1
                EditorButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
                Appearance1.Image = Global.AzamTechnologies.My.Resources.search
                UltrCtrl.ButtonsRight.Clear()
                UltrCtrl.ButtonsRight.Add(EditorButton1)
                UltrCtrl.BorderStyle = Infragistics.Win.UIElementBorderStyle.WindowsVista
            End If
        ElseIf TypeOf Control Is Infragistics.Win.UltraWinGrid.UltraCombo Then
            Dim UltrCtrl As Infragistics.Win.UltraWinGrid.UltraCombo
            UltrCtrl = Control
            UltrCtrl.BorderStyle = ctrlBorderStyle
            UltrCtrl.UseAppStyling = True
            '

            If Mid(UltrCtrl.Tag, 1, 2) = "FK" Or Mid(UltrCtrl.Tag, 1, 2) = "PK" Then
                Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
                Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
                EditorButton1.Appearance = Appearance1
                EditorButton1.ButtonStyle = Infragistics.Win.UIElementButtonStyle.WindowsVistaButton
                Appearance1.Image = Global.AzamTechnologies.My.Resources.search
                UltrCtrl.ButtonsRight.Clear()
                UltrCtrl.ButtonsRight.Add(EditorButton1)
                UltrCtrl.BorderStyle = ctrlBorderStyle
            End If
        ElseIf TypeOf Control Is Infragistics.Win.UltraWinEditors.UltraNumericEditor Then
            Dim UltrCtrl As Infragistics.Win.UltraWinEditors.UltraNumericEditor

            UltrCtrl = Control
            'UltrCtrl.Appearance.BackColor2 = Drawing.Color.White
            UltrCtrl.BorderStyle = ctrlBorderStyle
            UltrCtrl.UseAppStyling = True
            ' UltrCtrl.Appearance.StyleLibraryName = AppDomain.CurrentDomain.BaseDirectory & "\Styles\StyleBlack.isl"
            UltrCtrl.PromptChar = ""
            AddHandler UltrCtrl.BeforeEnterEditMode, AddressOf Generic_Enter
            Select Case UltrCtrl.AccessibleDescription
                Case "NoDecimal"
                    UltrCtrl.NumericType = NumericType.Integer
                    UltrCtrl.MaxValue = 9999999999
                    UltrCtrl.MinValue = 0
                Case "TwoDecimal"
                    UltrCtrl.NumericType = NumericType.Double
                    UltrCtrl.MaxValue = 9999999999
                    UltrCtrl.MinValue = 0
                    UltrCtrl.MaskInput = "{double:9.2}"
                Case Else
                    'UltrCtrl.NumericType = NumericType.Double
                    'UltrCtrl.MaxValue = 9999999999
                    'UltrCtrl.MinValue = 0
                    'UltrCtrl.MaskInput = "{double:9.3}"
            End Select
        End If

    End Sub
    Private Sub Generic_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TypeOf sender Is UltraNumericEditor Then
            Dim Editor As UltraNumericEditor = CType(sender, UltraNumericEditor)
            If Editor IsNot Nothing Then
                Editor.Editor.SelectAll()
            End If
        ElseIf TypeOf sender Is UltraCurrencyEditor Then
            Dim Editor As UltraNumericEditor = CType(sender, UltraNumericEditor)
            If Editor IsNot Nothing Then
                Editor.Editor.SelectAll()
            End If
        End If
    End Sub
End Module
