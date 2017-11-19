Public Class ATErrorProvider
    Inherits ErrorProvider
    ' Implements System.ComponentModel.IExtenderProvider
    Private originalControlColors As Hashtable = New Hashtable()

    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyBase.New(container)
        Me.blinkCount = blinkCount
        Me.blinkInterval = blinkInterval
        timer.Interval = Me.blinkInterval
        AddHandler timer.Tick, AddressOf OnTimerTick
    End Sub
    Structure BlinkControlDetails
        Public OriginalBackColor As Color
        Public BlinkBackColor As Color
        Public SettleBackColor As Color
        Public ErrorString As String
        Private BlinkCountArray() As Int16
        Public Sub New(ByVal errorString As String, ByVal originalBackColor As Color, ByVal blinkBackColor As Color, ByVal settleBackColor As Color, ByVal blinkCount As Int16)
            Me.ErrorString = errorString
            Me.OriginalBackColor = originalBackColor
            Me.BlinkBackColor = blinkBackColor
            Me.SettleBackColor = settleBackColor
            Me.BlinkCountArray = New Int16() {blinkCount}
        End Sub
        Public Property BlinkCount() As Int16
            Get
                Return Me.BlinkCountArray(0)
            End Get
            Set(ByVal value As Int16)
                Me.BlinkCountArray(0) = value
            End Set
        End Property
    End Structure
    Private blinkCount As Int16 = 3
    Private blinkInterval As Int16 = 300
    Private defaultBlinkColor As Color = Color.Orange
    Private defaultSettleColor As Color = Color.LightPink
    Private timer As Timer = New Timer()
    Public Sub New(ByVal blinkCount As Int16, ByVal blinkInterval As Int16)
        Me.blinkCount = blinkCount
        Me.blinkInterval = blinkInterval
        timer.Interval = Me.blinkInterval
        AddHandler timer.Tick, AddressOf OnTimerTick
    End Sub
    Public Property SettleColor() As Color
        Get
            Return Me.defaultSettleColor
        End Get
        Set(ByVal value As Color)
            Me.defaultSettleColor = value
        End Set
    End Property
    Public Property BlinkColor() As Color
        Get
            Return Me.defaultBlinkColor
        End Get
        Set(ByVal value As Color)
            Me.defaultBlinkColor = value
        End Set
    End Property
    Public Overloads Function CanExtend(ByVal target As Object) As Boolean
        If TypeOf target Is Control Then
            Return True
        End If
        Return False
    End Function
    Public Overloads Sub SetError(ByVal control As Control, ByVal value As String)
        ' MyBase.SetError(control, value)
        SetError(control, value, Me.BlinkColor, Me.blinkCount, Me.SettleColor)
    End Sub

    Public Overloads Sub SetError(ByVal control As Control, ByVal value As String, ByVal blinkColor As Color, ByVal blinkCount As Int16, ByVal settleColor As Color)
        Dim toolTip1 As New ToolTip()
        'if (value == null) 
        If IsNothing(value) Then
            value = String.Empty
        End If

        If (value.Length = 0) Then

            If (Me.originalControlColors.ContainsKey(control)) Then
                control.BackColor = CType(Me.originalControlColors(control), BlinkControlDetails).SettleBackColor
                Me.originalControlColors.Remove(control)
            End If

            If control.Text = String.Empty Then

                control.Invalidate()
            Else
                'IF USER PUT SOME VALID VALUE
                If TypeOf (control) Is TextBox Then
                    If CType(control, TextBox).ReadOnly Then
                        control.BackColor = System.Drawing.SystemColors.Control
                    Else
                        control.BackColor = System.Drawing.SystemColors.Window
                    End If
                Else
                    control.BackColor = System.Drawing.SystemColors.Window
                End If
                toolTip1.Hide(control)
            End If



        Else
            Dim bcd As BlinkControlDetails
            bcd = New BlinkControlDetails(value, control.BackColor, blinkColor, settleColor, blinkCount * 2 - 1)
            If Me.originalControlColors.ContainsKey(control) Then
                Me.originalControlColors.Remove(control)
                Me.originalControlColors.Add(control, bcd)
            Else
                Me.originalControlColors.Add(control, bcd)
            End If




            toolTip1.IsBalloon = True
            toolTip1.ToolTipTitle = "Invalid Data Entry"
            toolTip1.ToolTipIcon = ToolTipIcon.Warning

            toolTip1.Show(value, control, control.Width - 15, control.Height - 95, 4000)
            '
            toolTip1 = Nothing
            'change color immediately once
            control.BackColor = blinkColor
            'control.Invalidate()
            If (Me.timer.Enabled <> True) Then
                Me.timer.Enabled = True
            End If
        End If

    End Sub
    Private Sub OnTimerTick(ByVal myObject As Object, ByVal myEventArgs As EventArgs)

        Dim atLeastOneBlinked As Boolean = False
        For Each c As Control In Me.originalControlColors.Keys

            Dim bcd As BlinkControlDetails = CType(Me.originalControlColors(c), BlinkControlDetails)
            If (bcd.BlinkCount >= 1) Then
                'toggle colors
                If (c.BackColor.Equals(bcd.OriginalBackColor)) Then
                    c.BackColor = bcd.BlinkBackColor
                ElseIf (c.BackColor.Equals(bcd.BlinkBackColor)) Then
                    c.BackColor = bcd.OriginalBackColor
                End If
                bcd.BlinkCount = bcd.BlinkCount - 1
                atLeastOneBlinked = True
            ElseIf (bcd.BlinkCount = 0) Then
                'settle color
                c.BackColor = bcd.SettleBackColor
                bcd.BlinkCount = bcd.BlinkCount - 1
                atLeastOneBlinked = True
            Else
                Continue For
            End If
            c.Invalidate()
        Next
        If (atLeastOneBlinked <> True) Then
            Me.timer.Enabled = False
        End If
    End Sub



End Class






