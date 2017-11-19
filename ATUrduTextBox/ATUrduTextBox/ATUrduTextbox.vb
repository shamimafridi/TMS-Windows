' * */
Imports System
Imports System.Text
Imports System.ComponentModel
Imports Infragistics.Win.UltraWinEditors
Imports System.Windows.Forms
Public Class UrduTextBox
    Inherits UltraTextEditor
    'used to keep track of keystrokes handled by us
    Private handled As Boolean = False

    Private components As System.ComponentModel.Container = Nothing

    Public Sub New()
        InitializeComponent()
        Me.RightToLeft = Windows.Forms.RightToLeft.Yes
    End Sub

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)

        If (disposing) Then
            If (Not IsNothing(components)) Then

                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Component Designer generated code"
    '/ <summary> 
    '/ Required method for Designer support - do not modify 
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'UrduTextBox
        '

    End Sub
#End Region

#Region "Urdutextbox custom code"
    Protected Overrides Sub OnKeyPress(ByVal e As KeyPressEventArgs)

        'Move the caret to the end of text				
        Me.SelectionStart = Me.Text.Length

        e.Handled = handled

        'We handle only the required keys checked in the key down event
        'the rest are passed to the parent
        If (handled <> True) Then
            MyBase.OnKeyPress(e)
        End If
    End Sub

    Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
        If Me.ReadOnly = False Then
            'Set the handled flag only if we are handlign a keystroke
            handled = (e.KeyCode = Keys.Space Or e.KeyCode = Keys.Oemcomma Or e.KeyCode = Keys.Decimal Or e.KeyCode = Keys.OemQuestion Or e.KeyCode = Keys.OemPipe Or e.KeyCode = Keys.OemBackslash Or e.KeyCode = Keys.OemSemicolon Or e.KeyCode = Keys.OemQuotes Or e.KeyCode = Keys.OemOpenBrackets Or e.KeyCode = Keys.OemCloseBrackets) Or _
            (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) Or (e.KeyCode >= Keys.A And e.KeyCode <= Keys.Z)

            'Get the text from our textbox and store it in a string builder
            'StringBuilder sb = New StringBuilder(this.Text)

            Dim sb As StringBuilder
            sb = New StringBuilder(Me.Text)
            'Append appropriate letter to our textbox based on the key pressed
            Select Case (e.KeyCode)

                Case Keys.D0
                    sb.Append(ChrW("&H0660"))
                Case Keys.D1
                    sb.Append(ChrW("&H0661"))
                Case Keys.D2
                    sb.Append(ChrW("&H0662"))
                Case Keys.D3
                    sb.Append(ChrW("&H0663"))
                Case Keys.D4
                    sb.Append(ChrW("&H0664"))
                Case Keys.D5
                    sb.Append(ChrW("&H0665"))
                Case Keys.D6
                    sb.Append(ChrW("&H0666"))
                Case Keys.D7
                    sb.Append(ChrW("&H0667"))
                Case Keys.D8
                    sb.Append(ChrW("&H0668"))
                Case Keys.D9
                    sb.Append(ChrW("&H0669"))
                Case Keys.Space
                    sb.Append(ChrW(" &H200c"))
                Case Keys.A
                    'sb.Append(((e.Shift)?"&H0622":"&H0627")) 					
                    sb.Append(IIf(e.Shift, ChrW("&H0622"), ChrW("&H0627")))
                Case Keys.B
                    'sb.Append(((e.Shift)?"&H0613":"&H0628")) 
                    sb.Append(IIf(e.Shift, ChrW("&H0613"), ChrW("&H0628")))
                Case Keys.C
                    'sb.Append(((e.Shift)?"&H062b":"&H0686")) 					
                    sb.Append(IIf(e.Shift, ChrW("&H062b"), ChrW("&H0686")))
                Case Keys.D
                    'sb.Append(((e.Shift)?"&H0688":"&H062f")) 					
                    sb.Append(IIf(e.Shift, ChrW("&H0688"), ChrW("&H062f")))

                Case Keys.E
                    'sb.Append(((e.Shift)?"&H0610":"&H0639")) 					
                    sb.Append(IIf(e.Shift, ChrW("&H0610"), ChrW("&H0639")))

                Case Keys.F
                    sb.Append(ChrW("&H0641"))
                Case Keys.G
                    'sb.Append(((e.Shift)?"&H063a":"&H06af")) 
                    sb.Append(IIf(e.Shift, ChrW("&H063a"), ChrW("&H06af")))

                Case Keys.H
                    'sb.Append(((e.Shift)?"&H062d":"&H06be")) '0647 also
                    sb.Append(IIf(e.Shift, ChrW("&H062d"), ChrW("&H06be")))

                Case Keys.I
                    sb.Append(ChrW("&H06cc")) '0649 also
                Case Keys.J
                    'sb.Append(((e.Shift)?"&H0636":"&H062c")) 					
                    sb.Append(IIf(e.Shift, ChrW("&H0636"), ChrW("&H062c")))

                Case Keys.K
                    'sb.Append(((e.Shift)?"&H062e":"&H0643")) 
                    sb.Append(IIf(e.Shift, ChrW("&H062e"), ChrW("&H0643")))

                Case Keys.L
                    'sb.Append(((e.Shift)?"&H0612":"&H0644")) 					
                    sb.Append(IIf(e.Shift, ChrW("&H062e"), ChrW("&H0644")))

                Case Keys.M
                    sb.Append(ChrW("&H0645"))


                Case Keys.N
                    'sb.Append(((e.Shift)?"&H06ba":"&H0646")) 					
                    sb.Append(IIf(e.Shift, ChrW("&H06ba"), ChrW("&H0646")))

                Case Keys.O
                    'sb.Append(((e.Shift)?"&H0629":"&H06c1")) 
                    sb.Append(IIf(e.Shift, ChrW("&H06c1"), ChrW("&H06c1")))

                Case Keys.P
                    'sb.Append(((e.Shift)?"&H0645":"&H067e")) 'paish
                    sb.Append(IIf(e.Shift, ChrW("&H0645"), ChrW("&H067e")))
                Case Keys.Q
                    sb.Append(ChrW("&H0642"))
                Case Keys.R
                    'sb.Append(((e.Shift)?"&H0691":"&H0631")) 					
                    sb.Append(IIf(e.Shift, ChrW("&H0691"), ChrW("&H0631")))

                Case Keys.S
                    'sb.Append(((e.Shift)?"&H0635":"&H0633")) 
                    sb.Append(IIf(e.Shift, ChrW("&H0635"), ChrW("&H0633")))
                Case Keys.T
                    'sb.Append(((e.Shift)?"&H0679":"&H062a")) 
                    sb.Append(IIf(e.Shift, ChrW("&H0679"), ChrW("&H062a")))
                Case Keys.U
                    sb.Append(ChrW("&H0621"))
                Case Keys.V
                    'sb.Append(((e.Shift)?"&H0638":"&H0637")) 					
                    sb.Append(IIf(e.Shift, ChrW("&H0638"), ChrW("&H0637")))
                Case Keys.W
                    'sb.Append(((e.Shift)?"&H0635\u0644\u0649\u0020\u0627\u0644\u0644\u0647\u0020\u0639\u0644\u064a\u0647\u0020\u0648\u0633\u0644\u0645":"&H0648")) 
                    sb.Append(IIf(e.Shift, ChrW("&H0635") & ChrW("&H0644") & ChrW("&H0649") & ChrW("&H0020") & ChrW("&H0627") & ChrW("&H0644") & ChrW("&H0644") & ChrW("&H0647") & ChrW("&H0020") & ChrW("&H0639") & ChrW("&H0644") & ChrW("&H064a") & ChrW("&H0647") & ChrW("&H0020") & ChrW("&H0648") & ChrW("&H0633") & ChrW("&H0644") & ChrW("&H0645"), ChrW("&H0648")))
                Case Keys.X
                    'sb.Append(((e.Shift)?"&H0698":"&H0634")) 					
                    sb.Append(IIf(e.Shift, ChrW("&H0698"), ChrW("&H0634")))
                Case Keys.Y
                    sb.Append(ChrW("&H06d2"))

                Case Keys.Z
                    'sb.Append(((e.Shift)?"&H0630":"&H0632")) 
                    sb.Append(IIf(e.Shift, ChrW("&H0630"), ChrW("&H0632")))

                Case Keys.Decimal
                    sb.Append(ChrW("&H06d4"))
                Case Keys.Oemcomma
                    sb.Append(ChrW("&H060c"))
                Case Keys.OemQuestion
                    sb.Append(ChrW("&H061f"))
                Case Keys.OemPipe
                    sb.Append(ChrW("&H06d4"))
                Case Keys.OemBackslash
                    sb.Append(ChrW("&H0602"))
                Case Keys.OemSemicolon
                    sb.Append(ChrW("&H061b"))
                Case Keys.OemQuotes
                    sb.Append(ChrW("&H0022"))
                Case Keys.OemOpenBrackets
                    sb.Append(ChrW("&H007b"))
                Case Keys.OemCloseBrackets
                    sb.Append(ChrW("&H007d"))

            End Select

            'Set the text to our textbox from the string builder
            Me.Text = sb.ToString
        End If
    End Sub
#End Region
End Class

