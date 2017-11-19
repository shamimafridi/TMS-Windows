Imports System.Data.SqlClient
Namespace GeneralLedger
    Public Class Receipts
        Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()
            'This call is required by the Windows Form Designer.
            InitializeComponent()
            'Add any initialization after the InitializeComponent() call
        End Sub
        'Form overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer
        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents TxtReceiptNo As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtDescription As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents TxtBranchCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtBranch As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtCustomer As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents TxtBillNo As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtAmount As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents TxtShortage As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents TxtAmountIncSaleTax As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents TxtSaleTaxValue As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents TxtTotal As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents TxtSaleTax As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receipts))
            Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Me.TxtDescription = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.Label3 = New System.Windows.Forms.Label
            Me.TxtBranch = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtCustomer = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.TxtAmount = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label10 = New System.Windows.Forms.Label
            Me.TxtShortage = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label12 = New System.Windows.Forms.Label
            Me.TxtSaleTax = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label14 = New System.Windows.Forms.Label
            Me.TxtBillNo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtBranchCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtReceiptNo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.dtpDate = New System.Windows.Forms.DateTimePicker
            Me.TxtAmountIncSaleTax = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label5 = New System.Windows.Forms.Label
            Me.TxtSaleTaxValue = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label6 = New System.Windows.Forms.Label
            Me.TxtTotal = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label7 = New System.Windows.Forms.Label
            CType(Me.TxtDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtBranch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtShortage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtSaleTax, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtBillNo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtBranchCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtReceiptNo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtAmountIncSaleTax, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtSaleTaxValue, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtTotal, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TxtDescription
            '
            Me.TxtDescription.Location = New System.Drawing.Point(218, 220)
            Me.TxtDescription.Multiline = True
            Me.TxtDescription.Name = "TxtDescription"
            Me.TxtDescription.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
            Me.TxtDescription.Size = New System.Drawing.Size(272, 56)
            Me.TxtDescription.TabIndex = 8
            Me.TxtDescription.Tag = "ds.Description"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(106, 228)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 77
            Me.Label2.Text = "Description"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(106, 125)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 76
            Me.Label1.Text = "Receipt No"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.ForeColor = System.Drawing.Color.Navy
            Me.Label9.Location = New System.Drawing.Point(106, 196)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(110, 20)
            Me.Label9.TabIndex = 74
            Me.Label9.Text = "Receipt Date"
            '
            'ErrProvider
            '
            Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
            Me.ErrProvider.ContainerControl = Me
            Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
            Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.ForeColor = System.Drawing.Color.Navy
            Me.Label3.Location = New System.Drawing.Point(106, 101)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(110, 20)
            Me.Label3.TabIndex = 97
            Me.Label3.Text = "Branch"
            '
            'TxtBranch
            '
            Me.TxtBranch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance3.BackColor = System.Drawing.SystemColors.Window
            Me.TxtBranch.Appearance = Appearance3
            Me.TxtBranch.BackColor = System.Drawing.SystemColors.Window
            Me.TxtBranch.Location = New System.Drawing.Point(354, 101)
            Me.TxtBranch.Name = "TxtBranch"
            Me.TxtBranch.Size = New System.Drawing.Size(551, 21)
            Me.TxtBranch.TabIndex = 6
            Me.TxtBranch.TabStop = False
            Me.TxtBranch.Tag = "dd.BranchName"
            '
            'TxtCustomer
            '
            Me.TxtCustomer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCustomer.Appearance = Appearance1
            Me.TxtCustomer.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCustomer.Location = New System.Drawing.Point(354, 149)
            Me.TxtCustomer.Name = "TxtCustomer"
            Me.TxtCustomer.Size = New System.Drawing.Size(551, 21)
            Me.TxtCustomer.TabIndex = 100
            Me.TxtCustomer.TabStop = False
            Me.TxtCustomer.Tag = "dd.CustomerName"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.ForeColor = System.Drawing.Color.Navy
            Me.Label4.Location = New System.Drawing.Point(106, 149)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(110, 20)
            Me.Label4.TabIndex = 101
            Me.Label4.Text = "Customer"
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.Transparent
            Me.Label8.ForeColor = System.Drawing.Color.Navy
            Me.Label8.Location = New System.Drawing.Point(106, 173)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(110, 20)
            Me.Label8.TabIndex = 117
            Me.Label8.Text = "Bill No"
            '
            'TxtAmount
            '
            Me.TxtAmount.Enabled = False
            Me.TxtAmount.Location = New System.Drawing.Point(354, 382)
            Me.TxtAmount.Name = "TxtAmount"
            Me.TxtAmount.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtAmount.Size = New System.Drawing.Size(120, 21)
            Me.TxtAmount.TabIndex = 13
            Me.TxtAmount.Tag = "dt.Amount"
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.Transparent
            Me.Label10.ForeColor = System.Drawing.Color.Navy
            Me.Label10.Location = New System.Drawing.Point(244, 384)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(110, 20)
            Me.Label10.TabIndex = 121
            Me.Label10.Text = "Amount"
            '
            'TxtShortage
            '
            Me.TxtShortage.Location = New System.Drawing.Point(354, 474)
            Me.TxtShortage.Name = "TxtShortage"
            Me.TxtShortage.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtShortage.Size = New System.Drawing.Size(120, 21)
            Me.TxtShortage.TabIndex = 12
            Me.TxtShortage.Tag = "dt.Shortage"
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.Transparent
            Me.Label12.ForeColor = System.Drawing.Color.Navy
            Me.Label12.Location = New System.Drawing.Point(244, 476)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(110, 20)
            Me.Label12.TabIndex = 125
            Me.Label12.Text = "Shortage"
            '
            'TxtSaleTax
            '
            Me.TxtSaleTax.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.BusinessLeaf.My.MySettings.Default, "SaleTaxRate", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
            Me.TxtSaleTax.Location = New System.Drawing.Point(354, 405)
            Me.TxtSaleTax.Name = "TxtSaleTax"
            Me.TxtSaleTax.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtSaleTax.Size = New System.Drawing.Size(120, 21)
            Me.TxtSaleTax.TabIndex = 9
            Me.TxtSaleTax.Tag = "dt.TaxRate"
            Me.TxtSaleTax.Value = New Decimal(New Integer() {15, 0, 0, 0})
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.Transparent
            Me.Label14.ForeColor = System.Drawing.Color.Navy
            Me.Label14.Location = New System.Drawing.Point(244, 407)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(110, 20)
            Me.Label14.TabIndex = 127
            Me.Label14.Text = "Sale Tax Rate"
            '
            'TxtBillNo
            '
            Me.TxtBillNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance5.BackColor = System.Drawing.SystemColors.Window
            Me.TxtBillNo.Appearance = Appearance5
            Me.TxtBillNo.BackColor = System.Drawing.SystemColors.Window
            Me.TxtBillNo.Location = New System.Drawing.Point(218, 173)
            Me.TxtBillNo.MaxLength = Global.BusinessLeaf.My.MySettings.Default.TransactionNo
            Me.TxtBillNo.Name = "TxtBillNo"
            Me.TxtBillNo.Size = New System.Drawing.Size(100, 21)
            Me.TxtBillNo.TabIndex = 3
            Me.TxtBillNo.Tag = "PK.BillNo"
            '
            'Desc
            '
            Me.Desc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Appearance = Appearance2
            Me.Desc.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Location = New System.Drawing.Point(218, 149)
            Me.Desc.MaxLength = 5
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(136, 21)
            Me.Desc.TabIndex = 2
            Me.Desc.Tag = "FK.CustomerCode"
            '
            'TxtBranchCode
            '
            Me.TxtBranchCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance4.BackColor = System.Drawing.SystemColors.Window
            Me.TxtBranchCode.Appearance = Appearance4
            Me.TxtBranchCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtBranchCode.Location = New System.Drawing.Point(218, 101)
            Me.TxtBranchCode.MaxLength = 2
            Me.TxtBranchCode.Name = "TxtBranchCode"
            Me.TxtBranchCode.Size = New System.Drawing.Size(136, 21)
            Me.TxtBranchCode.TabIndex = 0
            Me.TxtBranchCode.Tag = "PK.BranchCode"
            '
            'TxtReceiptNo
            '
            Me.TxtReceiptNo.AcceptsReturn = True
            Me.TxtReceiptNo.Location = New System.Drawing.Point(218, 125)
            Me.TxtReceiptNo.MaxLength = 10
            Me.TxtReceiptNo.Name = "TxtReceiptNo"
            Me.TxtReceiptNo.Size = New System.Drawing.Size(136, 21)
            Me.TxtReceiptNo.TabIndex = 1
            Me.TxtReceiptNo.Tag = "PK.TransactionNo"
            '
            'dtpDate
            '
            Me.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
            Me.dtpDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
            Me.dtpDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
            Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDate.Location = New System.Drawing.Point(218, 197)
            Me.dtpDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.dtpDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.dtpDate.Name = "dtpDate"
            Me.dtpDate.Size = New System.Drawing.Size(100, 20)
            Me.dtpDate.TabIndex = 7
            Me.dtpDate.Tag = "dt.ReceiptDate"
            '
            'TxtAmountIncSaleTax
            '
            Me.TxtAmountIncSaleTax.Enabled = False
            Me.TxtAmountIncSaleTax.Location = New System.Drawing.Point(354, 451)
            Me.TxtAmountIncSaleTax.Name = "TxtAmountIncSaleTax"
            Me.TxtAmountIncSaleTax.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtAmountIncSaleTax.Size = New System.Drawing.Size(120, 21)
            Me.TxtAmountIncSaleTax.TabIndex = 128
            Me.TxtAmountIncSaleTax.Tag = "dt.AmountIncSaleTax"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.ForeColor = System.Drawing.Color.Navy
            Me.Label5.Location = New System.Drawing.Point(244, 453)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(110, 20)
            Me.Label5.TabIndex = 129
            Me.Label5.Text = "Amount Including Tax"
            '
            'TxtSaleTaxValue
            '
            Me.TxtSaleTaxValue.Enabled = False
            Me.TxtSaleTaxValue.Location = New System.Drawing.Point(354, 428)
            Me.TxtSaleTaxValue.Name = "TxtSaleTaxValue"
            Me.TxtSaleTaxValue.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtSaleTaxValue.Size = New System.Drawing.Size(120, 21)
            Me.TxtSaleTaxValue.TabIndex = 130
            Me.TxtSaleTaxValue.Tag = "dt.SaleTaxValue"
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.ForeColor = System.Drawing.Color.Navy
            Me.Label6.Location = New System.Drawing.Point(244, 430)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(110, 20)
            Me.Label6.TabIndex = 131
            Me.Label6.Text = "Sale Tax Value"
            '
            'TxtTotal
            '
            Me.TxtTotal.AccessibleDescription = "Last"
            Me.TxtTotal.Enabled = False
            Me.TxtTotal.Location = New System.Drawing.Point(354, 497)
            Me.TxtTotal.Name = "TxtTotal"
            Me.TxtTotal.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtTotal.Size = New System.Drawing.Size(120, 21)
            Me.TxtTotal.TabIndex = 132
            Me.TxtTotal.Tag = "dt.TotalAmount"
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.ForeColor = System.Drawing.Color.Navy
            Me.Label7.Location = New System.Drawing.Point(244, 499)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(110, 20)
            Me.Label7.TabIndex = 133
            Me.Label7.Text = "Total "
            '
            'Receipts
            '
            Me.AccessibleName = "Receipts"
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(964, 612)
            Me.Controls.Add(Me.TxtTotal)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.TxtSaleTaxValue)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.TxtAmountIncSaleTax)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label14)
            Me.Controls.Add(Me.TxtSaleTax)
            Me.Controls.Add(Me.TxtShortage)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.TxtAmount)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.TxtCustomer)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.TxtBranch)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.TxtBranchCode)
            Me.Controls.Add(Me.TxtBillNo)
            Me.Controls.Add(Me.TxtDescription)
            Me.Controls.Add(Me.TxtReceiptNo)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.dtpDate)
            Me.KeyPreview = True
            Me.Name = "Receipts"
            Me.Text = "Receipt File "
            CType(Me.TxtDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtBranch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtAmount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtShortage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtSaleTax, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtBillNo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtBranchCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtReceiptNo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtAmountIncSaleTax, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtSaleTaxValue, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtTotal, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region

        Private Sub dtpDate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDate.Validated
            ErrProvider.SetError(dtpDate, String.Empty)
        End Sub
        Public Sub dtpDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpDate.Validating
            Dim DateError As String
            DateError = ValidateTransactionDate(dtpDate.Value, Me.Tag)
            If DateError <> String.Empty Then
                ErrProvider.SetError(dtpDate, DateError)
                e.Cancel = True
                Exit Sub
            End If
            Try
                'If TxtReceiptNo.Text <> String.Empty And TxtReceiptNo.Text.Length = TxtReceiptNo.MaxLength Then
                If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                    Me.TxtReceiptNo.Text = String.Empty
                    KeyGeneration()
                Else
                    If DateSerial(dtpDate.Value.Year, dtpDate.Value.Month, 1) <> DateSerial(Mid(TxtReceiptNo.Text, 1, 2), Mid(TxtReceiptNo.Text, 3, 2), 1) Then
                        e.Cancel = True
                        ErrProvider.SetError(dtpDate, "You cannot change the Month Or Year for this Transaction Date..." & vbCrLf & "Please specify a valid Date within " & MonthName(Mid(TxtReceiptNo.Text, 3, 2)) & ", " & Year(DateSerial(Mid(TxtReceiptNo.Text, 1, 2), 1, 1)))
                        Exit Sub
                    End If
                End If
                'End If
            Catch ex As System.ArgumentException
                e.Cancel = True
                ErrProvider.SetError(dtpDate, "You cannot change the Month Or Year for this Transaction Date..." & vbCrLf & "Please specify a valid Date within " & MonthName(Mid(TxtReceiptNo.Text, 3, 2)) & ", " & Year(DateSerial("20" & Mid(TxtReceiptNo.Text, 1, 2), 1, 1)))
            End Try

        End Sub

        Private Sub CmdBranchList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub TxtBranchCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtBranchCode.EditorButtonClick
            If TxtBranchCode.Enabled = False Then Exit Sub
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Branches")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtBranchCode.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
                Me.TxtBranch.Text = frmser.UGSearch.Rows(iRow).Cells("BranchName").Value
                Me.TxtBranchCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtBranchCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBranchCode.GotFocus
            If Me.TxtBranchCode.Text = String.Empty Then
                Me.TxtBranchCode.Text = My.Settings.DefaultBranchCode
            End If
        End Sub

        Private Sub TxtBranchCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBranchCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtBranchCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub Desc_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles Desc.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Customers")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.Desc.Text = frmser.UGSearch.Rows(iRow).Cells("CustomerCode").Value
                Me.TxtCustomer.Text = frmser.UGSearch.Rows(iRow).Cells("CustomerName").Value
                Me.Desc.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtCustomerCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Desc.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.Desc_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub Receipts_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
            If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                dtpDate.Value = CurrentWorkingDate
            End If
        End Sub

        Private Sub BtnBillNoList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        End Sub
        Private Sub TxtAmount_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAmount.ValueChanged
            Try
                If TxtSaleTax.Value > 0 Then
                    TxtSaleTaxValue.Value = Me.TxtAmount.Value * (TxtSaleTax.Value / 100)
                    TxtAmountIncSaleTax.Value = TxtSaleTaxValue.Value + TxtAmount.Value
                    TxtTotal.Value = TxtAmount.Value - (TxtSaleTaxValue.Value + TxtShortage.Value)
                End If
            Catch ex As Exception

            End Try
        End Sub
        Private Sub TxtShortage_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtShortage.ValueChanged
            Try
                If TxtAmount.Value <> 0 Then
                    TxtTotal.Value = TxtAmount.Value - (TxtSaleTaxValue.Value + TxtShortage.Value)
                End If
            Catch ex As Exception

            End Try

        End Sub
        Private Sub TxtSaleTax_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSaleTax.ValueChanged
            Try
                TxtSaleTaxValue.Value = Me.TxtAmount.Value * (TxtSaleTax.Value / 100)
                TxtAmountIncSaleTax.Value = TxtSaleTaxValue.Value + TxtAmount.Value
                TxtTotal.Value = TxtAmount.Value - (TxtSaleTaxValue.Value + TxtShortage.Value)
            Catch

            End Try
        End Sub

        Private Sub txtBranchCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBranchCode.Validated
            ErrProvider.SetError(TxtBranchCode, String.Empty)
        End Sub

        Private Sub txtBranchCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtBranchCode.Validating
            Try
                If TxtBranchCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectBranches", "BranchCode ", Trim(TxtBranchCode.Text))
                    If Reader.HasRows = False Then
                        ErrProvider.SetError(TxtBranchCode, "Invalid Branch Code")
                        ErrProvider.SetIconAlignment(TxtBranchCode, ErrorIconAlignment.TopLeft)
                        TxtBranchCode.Text = String.Empty
                        TxtBranch.Text = String.Empty
                        e.Cancel = True
                    Else
                        If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                            TxtReceiptNo.Text = String.Empty
                            KeyGeneration()
                        End If
                        Reader.Read()
                        ErrProvider.SetError(TxtBranchCode, String.Empty)
                        TxtBranch.Text = Reader.Item("BranchName")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Private Sub TxtCustomerCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Desc.Validated
            ErrProvider.SetError(Desc, String.Empty)
        End Sub

        Private Sub TxtCustomerCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Desc.Validating
            Try
                If Desc.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectCustomers", "CustomerCode ", Trim(Desc.Text))
                    If Reader.HasRows = False Then
                        ErrProvider.SetError(Desc, "Invalid Customer Code")
                        ErrProvider.SetIconAlignment(Desc, ErrorIconAlignment.TopLeft)
                        Desc.Text = String.Empty
                        TxtCustomer.Text = String.Empty
                        e.Cancel = True
                    Else
                        Reader.Read()
                        ErrProvider.SetError(Desc, String.Empty)
                        TxtCustomer.Text = Reader.Item("CustomerName")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub TxtBillNo_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtBillNo.EditorButtonClick
            If Me.Desc.Text <> String.Empty Then
                Try
                    Dim iRow As Integer
                    Dim frmser As FrmSearch
                    frmser = New FrmSearch
                    frmser.FillData("CustomerBills", "CustomerCode", Desc.Text, "OPTION", "FILTER_BILL")
                    frmser.ShowDialog()
                    iRow = frmser.UGSearch.ActiveRow.Index
                    Me.TxtBillNo.Text = frmser.UGSearch.Rows(iRow).Cells("BillNo").Value
                    Me.TxtBillNo.Focus()
                    TxtAmount.Value = frmser.UGSearch.Rows(iRow).Cells("Amount").Value
                    TxtShortage.Value = frmser.UGSearch.Rows(iRow).Cells("Shortage").Value
                    TxtSaleTax.Value = My.Settings.SaleTaxRate
                Catch ex As IndexOutOfRangeException
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("Please First enter Customer ")
                Me.Desc.Focus()
            End If
        End Sub

        Private Sub TxtBillNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBillNo.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtBillNo_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtBillNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtBillNo.Validating
            Try
                If TxtBillNo.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectCustomerBills", "BillNo ", Trim(TxtBillNo.Text), "CustomerCode", Desc.Text)
                    If Reader.HasRows = False Then
                        ErrProvider.SetError(TxtBillNo, "Invalid Bill No for Specified Customer ")
                        ErrProvider.SetIconAlignment(TxtBillNo, ErrorIconAlignment.TopLeft)
                        TxtBillNo.Text = String.Empty
                        TxtCustomer.Text = String.Empty
                        e.Cancel = True
                    Else
                        Reader.Read()
                        ErrProvider.SetError(TxtBillNo, String.Empty)
                        ' TxtCustomer.Text = Reader.Item("CustomerName")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Private Sub KeyGeneration()
            If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                Dim objAcc As New AzamTechnologies.Database.DataAccess
                Dim Reader As SqlClient.SqlDataReader
                If Me.TxtBranchCode.Text = String.Empty Then
                    Me.TxtBranchCode.Text = My.Settings.DefaultBranchCode
                End If
                Reader = objAcc.GetRecord("Select" & Me.AccessibleName, "Option", "AUTO", "YearMonth", Format(dtpDate.Value, "yy") & Format(dtpDate.Value, "MM"), "BranchCode", TxtBranchCode.Text)
                'Auto increment the primary key field when we Add the 
                ' AccessibleDescription Properties of the Control set to "AUTO"
                If Reader.HasRows Then
                    While Reader.Read
                        TxtReceiptNo.Text = Reader.Item("TransactionNo")
                        TxtReceiptNo.Text = Integer.Parse(TxtReceiptNo.Text) + 1
                        TxtReceiptNo.Text = TxtReceiptNo.Text.Insert(0, "0")

                        If Mid(TxtReceiptNo.Text.Insert(0, "0"), 1, 2) = "09" Then
                            TxtReceiptNo.Text = TxtReceiptNo.Text.Insert(0, "0")
                            ' chCtr.Text = mManager.FormateData.FormatKeyYearMonthValue(chCtr.Text, CType(chCtr, TextBox).MaxLength)
                        End If
                        ' chCtr.Text = mManager.FormateData.FormatKeyYearMonthValue(chCtr.Text, CType(chCtr, TextBox).MaxLength)
                    End While
                Else
                    TxtReceiptNo.Text = FormatKeyYearMonthValue(dtpDate.Value, TxtReceiptNo.Text, CType(TxtReceiptNo, Infragistics.Win.UltraWinEditors.UltraTextEditor).MaxLength)
                End If
                Reader = Nothing
                objAcc = Nothing
            End If
        End Sub

        Private Sub TxtBranchCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBranchCode.ValueChanged

        End Sub

        Private Sub TxtReceiptNo_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtReceiptNo.EditorButtonClick
            If TxtReceiptNo.Enabled = False Then Exit Sub
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Receipts")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtReceiptNo.Text = frmser.UGSearch.Rows(iRow).Cells("ReceiptNo").Value
                Me.TxtReceiptNo.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtReceiptNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtReceiptNo.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtReceiptNo_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtReceiptNo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtReceiptNo.ValueChanged

        End Sub

        Private Sub Desc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Desc.ValueChanged

        End Sub

        Private Sub BtnCustomerList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub TxtBillNo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBillNo.ValueChanged

        End Sub

        Private Sub dtpDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDate.ValueChanged

        End Sub
    End Class
End Namespace