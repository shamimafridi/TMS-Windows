Imports System.Xml
Module mdlFunctions
    Sub FillCombo(ByRef Ds As DataSet, ByVal storeprocedure As String, ByVal ParamArray parameters() As String)
        Try
            Dim Acc As New AzamTechnologies.Database.DataAccess
            Acc.PopulateDataSet(Ds, storeprocedure, parameters)
            Acc = Nothing
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim OptionTable As DataTable
    Function GetOptionValue(ByRef OptionName As String) As String
        Dim OptionView As DataView
        Dim Acc As New AzamTechnologies.Database.DataAccess
        Try
            If OptionTable Is Nothing Then
                OptionTable = Acc.GetTable("OptionValue", "Options")
                OptionView = New DataView
                OptionView.Table = OptionTable
                If OptionView.Count > 0 Then
                    Return OptionView.Item(0).Item("OptionValue")
                End If
            Else
                OptionView = New DataView
                OptionView.Table = OptionTable
                If OptionView.Count > 0 Then
                    Return OptionView.Item(0).Item("OptionValue")
                End If
            End If
            'Dim com As New AzamTechnologies.Database.DataConnection
            'Dim sqlCon As SqlClient.SqlConnection = com.GetConnection

            'sqlCon = Nothing
            'com = Nothing
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Acc = Nothing
        End Try
        Return Nothing
    End Function
    Function GetTextOfNature(ByVal nature As String) As String
        Select Case nature
            Case PurchaseOrderNature
                Return "Purchase Order"
            Case SaleInvoiceNature
                Return "Sale Invoice"
            Case VehicleReceiptNature
                Return "Vehicle Receipt"
            Case ReceivingNature
                Return "Vehicle Receipt"
            Case VehiclePaymentNature
                Return "Vehicle Payment"
            Case VehicleAdjustmentReceiptNature
                Return "Vehicle Adjustment Receipt"
            Case VehicleAdjustmentPaymentNature
                Return "Vehicle Adjustment Payment"
            Case ReceiptNature
                Return "Receipt"
            Case JournalVoucherNature
                Return "Journal Voucher"
            Case CashReceiptVoucherNature
                Return "Cash Receipt Voucher"
            Case CashPaymentVoucherNature
                Return "Cash Payment Voucher"
            Case BankReceiptVoucherNature
                Return "Bank Receipt Voucher"
            Case BankPaymentVoucherNature
                Return "Bank Payment Voucher"
        End Select

    End Function
    Public Function FormatKeyYearMonthValue(ByVal DateForFormat As Date, ByVal KeyObjectText As String, ByVal maxTextLen As Integer) As String
        Dim a As New System.Text.StringBuilder
        Dim dateValue As String = Format(DateForFormat, "yy") & Format(DateForFormat, "MM")

        Dim strTemp As String
        KeyObjectText = "1"
        strTemp = a.Insert(0, "0", maxTextLen - KeyObjectText.Length).ToString
        a = New System.Text.StringBuilder(strTemp)
        strTemp = a.Replace("0000", dateValue, 0, 4).ToString
        a = New System.Text.StringBuilder(strTemp)
        strTemp = a.Insert(maxTextLen - KeyObjectText.Length, KeyObjectText, 1).ToString
        FormatKeyYearMonthValue = strTemp
    End Function
    Sub UnderConstructionMessage()
        MessageBox.Show("This option is under construction.Please contact with administrator.", "Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Sub PainFPGrid(ByVal grid As FarPoint.Win.Spread.FpSpread)
        If My.Settings.Theme = Color.Green Then
            grid.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Shamrock
        ElseIf My.Settings.Theme = Color.Blue Then
            grid.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.ArcticSea
        ElseIf My.Settings.Theme = Color.Silver Then
            grid.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Default
        ElseIf My.Settings.Theme = Color.Black Then
            grid.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Metallic
        End If
    End Sub
    Sub PaintTheForms(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim ArrowColor As Color
        Dim BackColor As Color
        If My.Settings.Theme = Color.Green Then
            ArrowColor = Color.YellowGreen
            BackColor = Color.OliveDrab
        ElseIf My.Settings.Theme = Color.Blue Then
            ArrowColor = Color.LightBlue
            BackColor = Color.DeepSkyBlue
        ElseIf My.Settings.Theme = Color.Black Then
            ArrowColor = Color.Gray
            BackColor = Color.Black
        ElseIf My.Settings.Theme = Color.Silver Then
            ArrowColor = Color.Silver
            BackColor = Color.LightSlateGray
        End If

        Dim formGraphics As Graphics = e.Graphics
        Dim gradientBrush As New Drawing2D.LinearGradientBrush(New Point(0, 0), New Point(My.Computer.Screen.Bounds.Width, 0), Color.White, ArrowColor)
        Dim gradientBrushArr As New Drawing2D.LinearGradientBrush(New Point(0, 0), New Point(My.Computer.Screen.Bounds.Width, 0), Color.White, BackColor)
        Dim gradientBrushArr1 As New Drawing2D.LinearGradientBrush(New Point(0, 0), New Point(0, My.Computer.Screen.Bounds.Height), Color.White, BackColor)

        formGraphics.FillRectangle(gradientBrush, sender.ClientRectangle)

        Dim ArrowPen As New Pen(gradientBrushArr, 150)
        Dim ArrowPen1 As New Pen(gradientBrushArr1, 150)
        ArrowPen.EndCap = Drawing2D.LineCap.ArrowAnchor
        ArrowPen1.EndCap = Drawing2D.LineCap.ArrowAnchor
        formGraphics.DrawLine(ArrowPen, 0, 0, 1000, 0)
        formGraphics.DrawLine(ArrowPen1, 0, 75, 0, 700)
        formGraphics.DrawString(sender.Text, New Font("Arial", 24, FontStyle.Bold, GraphicsUnit.Point), Brushes.AliceBlue, 550, 20)
    End Sub
    Sub loadStyle()
        Try
            If My.Settings.Theme = Color.Green Then
                Infragistics.Win.AppStyling.StyleManager.Load(Application.StartupPath & "\Styles\StyleGreen.isl")
            ElseIf My.Settings.Theme = Color.Blue Then
                Infragistics.Win.AppStyling.StyleManager.Load(Application.StartupPath & "\Styles\StyleBlue.isl")
            ElseIf My.Settings.Theme = Color.Black Then
                Infragistics.Win.AppStyling.StyleManager.Load(Application.StartupPath & "\Styles\StyleBlack.isl")
            ElseIf My.Settings.Theme = Color.Silver Then
                Infragistics.Win.AppStyling.StyleManager.Load(Application.StartupPath & "\Styles\styleSelver.isl")
            End If
        Catch
        End Try
    End Sub
    Public Function ValidateTransactionDate(ByVal TransDate As Date, ByVal TransMode As AzamTechnologies.DataManager.DataMode) As String
        On Error GoTo ERR_ValidateTransactionDate
        Dim LastPostingDate As Date
        Dim DaysForWorking As Integer
        Dim OBJ As New AzamTechnologies.Database.DataAccess
        Dim Rst As SqlClient.SqlDataReader



        Rst = OBJ.GetRecord("SelectPosting", "nType", 1)

        If Rst.HasRows Then
            Rst.Read()
            LastPostingDate = IIf(IsDBNull(Rst("ClosingDate")), DateAdd(DateInterval.Day, -1, My.Settings.CurrentYearStartDate), Rst("ClosingDate"))
        Else
            LastPostingDate = DateAdd(DateInterval.Day, -1, My.Settings.CurrentYearStartDate)
        End If

        OBJ = Nothing
        Rst = Nothing



        If TransMode = AzamTechnologies.DataManager.DataMode.Insert Or TransMode = AzamTechnologies.DataManager.DataMode.Inserting Then
            If TransDate <= LastPostingDate Or TransDate < DateAdd(DateInterval.Day, -My.Settings.DaysForWorking, CurrentWorkingDate) Or TransDate > CurrentWorkingDate Then
                Return "- Transaction date must be greater than last closing date " & Format(LastPostingDate, "dd MMM yyyy") & vbCrLf & vbCrLf _
                                        & "- Transaction date must be greater than or equal to " & Format(DateAdd(DateInterval.Day, -My.Settings.DaysForWorking, CurrentWorkingDate), "dd MMM yyyy") _
                                        & " and less than current working date " & Format(CurrentWorkingDate, "dd MMM yyyy") & vbCrLf & vbCrLf _
                                        & " Please specify a valid Date"
            Else
                Return String.Empty
            End If
        ElseIf TransMode <> AzamTechnologies.DataManager.DataMode.Insert Or TransMode <> AzamTechnologies.DataManager.DataMode.Inserting Then
            If TransDate <= LastPostingDate Or TransDate > CurrentWorkingDate Then
                Return "- Transaction date must be greater than last closing date " & Format(LastPostingDate, "dd MMM yyyy") & vbCrLf & vbCrLf _
                                        & "- Transaction date must be less than current working date " & Format(CurrentWorkingDate, "dd MMM yyyy") & vbCrLf & vbCrLf _
                                        & " Please specify a valid Date"
            Else
                Return String.Empty
            End If
        End If


ERR_ValidateTransactionDate:
        If Err.Number <> -2147418107 Then _
            MsgBox("The Following exception has occured during processing..." & vbCrLf & Err.Number & vbTab & Err.Description, vbInformation, "Code : ValidateTransactionDate ")
        Err.Number = 0 : Err.Clear()
        Return Nothing
    End Function
    Public Function EncodePassword(ByVal nPasswordStr As String) As String
        If nPasswordStr.Length > 0 Then
            Dim data() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes(Trim(nPasswordStr))
            Dim str As String = Convert.ToBase64String(data)
            Return str
        End If
        Return Nothing
    End Function
    Public Sub UpdateKey(ByVal strKey As String, ByVal newValue As String)
        Dim XMLExeConfigeFile As String = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile
        ' Updates a key within the App.config
        'Dim xmlDoc As New XmlDocument
        Try
        
            Dim FileInfo As System.IO.FileInfo = New System.IO.FileInfo(XMLExeConfigeFile)
            ' Load the config file into the XML DOM.
            Dim XmlDocument As New System.Xml.XmlDocument
            XmlDocument.Load(FileInfo.FullName)
            For Each ChildNode As XmlNode In XmlDocument.Item("configuration").Item("appSettings")
                If ChildNode.Name = "add" Then
                    If ChildNode.Attributes("key").Value = strKey Then
                        ChildNode.Attributes("value").Value = newValue
                    End If
                End If
            Next
            'XmlDocument.Save(AppDomain.CurrentDomain.BaseDirectory & "App.config")
            XmlDocument.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
        Catch ex As XmlException
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
