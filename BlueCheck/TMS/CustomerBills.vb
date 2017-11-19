Imports System.Data.SqlClient
Namespace GeneralLedger
    Public Class CustomerBills
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
        Friend WithEvents DtpFromInvoiceDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents TxtFromTransactionNo As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        Friend WithEvents TxtToTransactionNo As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents DtpToInvoiceDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents TxtCustomer As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents BtnFilter As System.Windows.Forms.Button
        Friend WithEvents TxtBillNo As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents LblBillDate As System.Windows.Forms.Label
        Friend WithEvents DtpBillDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents FpInvoiceGrid As FarPoint.Win.Spread.FpSpread
        Friend WithEvents FpInvoiceGrid_Sheet1 As FarPoint.Win.Spread.SheetView
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents TxtTotals As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents mnuGrid As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents MnuInsertRow As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MnuDeleteRow As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MnuClearGrid As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MnuExportToExcel As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim TextCellType1 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
            Dim TextCellType2 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
            Dim TextCellType3 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
            Dim TextCellType4 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
            Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
            Dim DateTimeCellType1 As FarPoint.Win.Spread.CellType.DateTimeCellType = New FarPoint.Win.Spread.CellType.DateTimeCellType
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerBills))
            Dim TextCellType6 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
            Dim TextCellType7 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType
            Dim CurrencyCellType1 As FarPoint.Win.Spread.CellType.CurrencyCellType = New FarPoint.Win.Spread.CellType.CurrencyCellType
            Dim CurrencyCellType2 As FarPoint.Win.Spread.CellType.CurrencyCellType = New FarPoint.Win.Spread.CellType.CurrencyCellType
            Me.TxtFromTransactionNo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.DtpFromInvoiceDate = New System.Windows.Forms.DateTimePicker
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label9 = New System.Windows.Forms.Label
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.TxtToTransactionNo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.DtpToInvoiceDate = New System.Windows.Forms.DateTimePicker
            Me.TxtCustomer = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label2 = New System.Windows.Forms.Label
            Me.BtnFilter = New System.Windows.Forms.Button
            Me.TxtBillNo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label3 = New System.Windows.Forms.Label
            Me.LblBillDate = New System.Windows.Forms.Label
            Me.DtpBillDate = New System.Windows.Forms.DateTimePicker
            Me.FpInvoiceGrid = New FarPoint.Win.Spread.FpSpread
            Me.mnuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.MnuInsertRow = New System.Windows.Forms.ToolStripMenuItem
            Me.MnuDeleteRow = New System.Windows.Forms.ToolStripMenuItem
            Me.MnuClearGrid = New System.Windows.Forms.ToolStripMenuItem
            Me.MnuExportToExcel = New System.Windows.Forms.ToolStripMenuItem
            Me.FpInvoiceGrid_Sheet1 = New FarPoint.Win.Spread.SheetView
            Me.TxtTotals = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label6 = New System.Windows.Forms.Label
            CType(Me.TxtFromTransactionNo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtToTransactionNo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtBillNo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FpInvoiceGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mnuGrid.SuspendLayout()
            CType(Me.FpInvoiceGrid_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtTotals, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TxtFromTransactionNo
            '
            Me.TxtFromTransactionNo.AcceptsReturn = True
            Me.TxtFromTransactionNo.Location = New System.Drawing.Point(214, 159)
            Me.TxtFromTransactionNo.MaxLength = Global.BusinessLeaf.My.MySettings.Default.TransactionNo
            Me.TxtFromTransactionNo.Name = "TxtFromTransactionNo"
            Me.TxtFromTransactionNo.Size = New System.Drawing.Size(130, 21)
            Me.TxtFromTransactionNo.TabIndex = 3
            '
            'DtpFromInvoiceDate
            '
            Me.DtpFromInvoiceDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
            Me.DtpFromInvoiceDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
            Me.DtpFromInvoiceDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
            Me.DtpFromInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.DtpFromInvoiceDate.Location = New System.Drawing.Point(214, 184)
            Me.DtpFromInvoiceDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.DtpFromInvoiceDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.DtpFromInvoiceDate.Name = "DtpFromInvoiceDate"
            Me.DtpFromInvoiceDate.Size = New System.Drawing.Size(130, 20)
            Me.DtpFromInvoiceDate.TabIndex = 5
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(102, 160)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 76
            Me.Label1.Text = "From Invoice No"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.ForeColor = System.Drawing.Color.Navy
            Me.Label9.Location = New System.Drawing.Point(102, 184)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(110, 20)
            Me.Label9.TabIndex = 74
            Me.Label9.Text = "From Date"
            '
            'ErrProvider
            '
            Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
            Me.ErrProvider.ContainerControl = Me
            Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
            Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
            '
            'TxtToTransactionNo
            '
            Me.TxtToTransactionNo.AcceptsReturn = True
            Me.TxtToTransactionNo.Location = New System.Drawing.Point(482, 159)
            Me.TxtToTransactionNo.MaxLength = Global.BusinessLeaf.My.MySettings.Default.TransactionNo
            Me.TxtToTransactionNo.Name = "TxtToTransactionNo"
            Me.TxtToTransactionNo.Size = New System.Drawing.Size(130, 21)
            Me.TxtToTransactionNo.TabIndex = 4
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.ForeColor = System.Drawing.Color.Navy
            Me.Label4.Location = New System.Drawing.Point(366, 159)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(110, 20)
            Me.Label4.TabIndex = 99
            Me.Label4.Text = "To Invoice No"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.ForeColor = System.Drawing.Color.Navy
            Me.Label5.Location = New System.Drawing.Point(366, 184)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(110, 20)
            Me.Label5.TabIndex = 103
            Me.Label5.Text = "To Date"
            '
            'DtpToInvoiceDate
            '
            Me.DtpToInvoiceDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
            Me.DtpToInvoiceDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
            Me.DtpToInvoiceDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
            Me.DtpToInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.DtpToInvoiceDate.Location = New System.Drawing.Point(482, 184)
            Me.DtpToInvoiceDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.DtpToInvoiceDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.DtpToInvoiceDate.Name = "DtpToInvoiceDate"
            Me.DtpToInvoiceDate.Size = New System.Drawing.Size(130, 20)
            Me.DtpToInvoiceDate.TabIndex = 6
            '
            'TxtCustomer
            '
            Me.TxtCustomer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCustomer.Appearance = Appearance1
            Me.TxtCustomer.BackColor = System.Drawing.SystemColors.Window
            Me.TxtCustomer.Location = New System.Drawing.Point(344, 110)
            Me.TxtCustomer.Name = "TxtCustomer"
            Me.TxtCustomer.Size = New System.Drawing.Size(658, 21)
            Me.TxtCustomer.TabIndex = 106
            Me.TxtCustomer.TabStop = False
            Me.TxtCustomer.Tag = "dd.CustomerName"
            '
            'Desc
            '
            Me.Desc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Appearance = Appearance2
            Me.Desc.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Location = New System.Drawing.Point(214, 110)
            Me.Desc.MaxLength = 5
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(130, 21)
            Me.Desc.TabIndex = 1
            Me.Desc.Tag = "FK.CustomerCode"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(102, 111)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 107
            Me.Label2.Text = "Customer"
            '
            'BtnFilter
            '
            Me.BtnFilter.BackColor = System.Drawing.SystemColors.Window
            Me.BtnFilter.Location = New System.Drawing.Point(214, 215)
            Me.BtnFilter.Name = "BtnFilter"
            Me.BtnFilter.Size = New System.Drawing.Size(130, 29)
            Me.BtnFilter.TabIndex = 7
            Me.BtnFilter.TabStop = False
            Me.BtnFilter.Text = "Filter Invoices"
            Me.BtnFilter.UseVisualStyleBackColor = False
            '
            'TxtBillNo
            '
            Me.TxtBillNo.AccessibleDescription = "YM.AUTO"
            Me.TxtBillNo.Location = New System.Drawing.Point(214, 85)
            Me.TxtBillNo.MaxLength = Global.BusinessLeaf.My.MySettings.Default.TransactionNo
            Me.TxtBillNo.Name = "TxtBillNo"
            Me.TxtBillNo.Size = New System.Drawing.Size(130, 21)
            Me.TxtBillNo.TabIndex = 0
            Me.TxtBillNo.Tag = "PK.BillNo"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.ForeColor = System.Drawing.Color.Navy
            Me.Label3.Location = New System.Drawing.Point(102, 85)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(110, 20)
            Me.Label3.TabIndex = 110
            Me.Label3.Text = "Bill No"
            '
            'LblBillDate
            '
            Me.LblBillDate.BackColor = System.Drawing.Color.Transparent
            Me.LblBillDate.ForeColor = System.Drawing.Color.Navy
            Me.LblBillDate.Location = New System.Drawing.Point(102, 137)
            Me.LblBillDate.Name = "LblBillDate"
            Me.LblBillDate.Size = New System.Drawing.Size(110, 20)
            Me.LblBillDate.TabIndex = 112
            Me.LblBillDate.Text = "Bill Date"
            '
            'DtpBillDate
            '
            Me.DtpBillDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
            Me.DtpBillDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
            Me.DtpBillDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
            Me.DtpBillDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.DtpBillDate.Location = New System.Drawing.Point(214, 135)
            Me.DtpBillDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.DtpBillDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.DtpBillDate.Name = "DtpBillDate"
            Me.DtpBillDate.Size = New System.Drawing.Size(130, 20)
            Me.DtpBillDate.TabIndex = 2
            Me.DtpBillDate.Tag = "FK.BillDate"
            '
            'FpInvoiceGrid
            '
            Me.FpInvoiceGrid.AccessibleDescription = "FpInvoiceGrid, Sheet1, Row 0, Column 0, "
            Me.FpInvoiceGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.FpInvoiceGrid.BackColor = System.Drawing.SystemColors.Control
            Me.FpInvoiceGrid.ContextMenuStrip = Me.mnuGrid
            Me.FpInvoiceGrid.Location = New System.Drawing.Point(77, 250)
            Me.FpInvoiceGrid.Name = "FpInvoiceGrid"
            Me.FpInvoiceGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.FpInvoiceGrid.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.FpInvoiceGrid_Sheet1})
            Me.FpInvoiceGrid.Size = New System.Drawing.Size(884, 289)
            Me.FpInvoiceGrid.TabIndex = 113
            '
            'mnuGrid
            '
            Me.mnuGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuInsertRow, Me.MnuDeleteRow, Me.MnuClearGrid, Me.MnuExportToExcel})
            Me.mnuGrid.Name = "mnuGrid"
            Me.mnuGrid.Size = New System.Drawing.Size(161, 92)
            '
            'MnuInsertRow
            '
            Me.MnuInsertRow.Name = "MnuInsertRow"
            Me.MnuInsertRow.Size = New System.Drawing.Size(160, 22)
            Me.MnuInsertRow.Text = "Insert Row"
            '
            'MnuDeleteRow
            '
            Me.MnuDeleteRow.Name = "MnuDeleteRow"
            Me.MnuDeleteRow.Size = New System.Drawing.Size(160, 22)
            Me.MnuDeleteRow.Text = "Delete Row"
            '
            'MnuClearGrid
            '
            Me.MnuClearGrid.Name = "MnuClearGrid"
            Me.MnuClearGrid.Size = New System.Drawing.Size(160, 22)
            Me.MnuClearGrid.Text = "Clear Grid"
            '
            'MnuExportToExcel
            '
            Me.MnuExportToExcel.Name = "MnuExportToExcel"
            Me.MnuExportToExcel.Size = New System.Drawing.Size(160, 22)
            Me.MnuExportToExcel.Text = "Export To Excel"
            '
            'FpInvoiceGrid_Sheet1
            '
            Me.FpInvoiceGrid_Sheet1.Reset()
            Me.FpInvoiceGrid_Sheet1.SheetName = "Sheet1"
            'Formulas and custom names must be loaded with R1C1 reference style
            Me.FpInvoiceGrid_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
            Me.FpInvoiceGrid_Sheet1.ColumnCount = 12
            Me.FpInvoiceGrid_Sheet1.RowCount = 20
            Me.FpInvoiceGrid_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "BillNo"
            Me.FpInvoiceGrid_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "BranchCode"
            Me.FpInvoiceGrid_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "Branch"
            Me.FpInvoiceGrid_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "InvoiceNo"
            Me.FpInvoiceGrid_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "TokenNo"
            Me.FpInvoiceGrid_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "InvoiceDate"
            Me.FpInvoiceGrid_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "Vehicle"
            Me.FpInvoiceGrid_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "StationPoint"
            Me.FpInvoiceGrid_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "DestinationPoint"
            Me.FpInvoiceGrid_Sheet1.ColumnHeader.Cells.Get(0, 9).Value = "Product"
            Me.FpInvoiceGrid_Sheet1.ColumnHeader.Cells.Get(0, 10).Value = "Amount"
            Me.FpInvoiceGrid_Sheet1.ColumnHeader.Cells.Get(0, 11).Value = "Shortage"
            Me.FpInvoiceGrid_Sheet1.Columns.Get(0).CellType = TextCellType1
            Me.FpInvoiceGrid_Sheet1.Columns.Get(0).Label = "BillNo"
            Me.FpInvoiceGrid_Sheet1.Columns.Get(0).Visible = False
            Me.FpInvoiceGrid_Sheet1.Columns.Get(1).CellType = TextCellType2
            Me.FpInvoiceGrid_Sheet1.Columns.Get(1).Label = "BranchCode"
            Me.FpInvoiceGrid_Sheet1.Columns.Get(1).Visible = False
            Me.FpInvoiceGrid_Sheet1.Columns.Get(2).CellType = TextCellType3
            Me.FpInvoiceGrid_Sheet1.Columns.Get(2).Label = "Branch"
            Me.FpInvoiceGrid_Sheet1.Columns.Get(2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpInvoiceGrid_Sheet1.Columns.Get(2).Width = 109.0!
            Me.FpInvoiceGrid_Sheet1.Columns.Get(3).CellType = TextCellType4
            Me.FpInvoiceGrid_Sheet1.Columns.Get(3).Label = "InvoiceNo"
            Me.FpInvoiceGrid_Sheet1.Columns.Get(3).Locked = True
            Me.FpInvoiceGrid_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpInvoiceGrid_Sheet1.Columns.Get(3).Width = 139.0!
            Me.FpInvoiceGrid_Sheet1.Columns.Get(4).CellType = TextCellType5
            Me.FpInvoiceGrid_Sheet1.Columns.Get(4).Label = "TokenNo"
            Me.FpInvoiceGrid_Sheet1.Columns.Get(4).Locked = True
            Me.FpInvoiceGrid_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpInvoiceGrid_Sheet1.Columns.Get(4).Width = 70.0!
            DateTimeCellType1.Calendar = CType(resources.GetObject("DateTimeCellType1.Calendar"), System.Globalization.Calendar)
            DateTimeCellType1.CalendarSurroundingDaysColor = System.Drawing.SystemColors.GrayText
            DateTimeCellType1.DateDefault = New Date(2010, 5, 30, 18, 31, 44, 0)
            DateTimeCellType1.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.UserDefined
            DateTimeCellType1.TimeDefault = New Date(2010, 5, 30, 18, 31, 44, 0)
            DateTimeCellType1.UserDefinedFormat = "dd-MMM-yyyy"
            Me.FpInvoiceGrid_Sheet1.Columns.Get(5).CellType = DateTimeCellType1
            Me.FpInvoiceGrid_Sheet1.Columns.Get(5).Label = "InvoiceDate"
            Me.FpInvoiceGrid_Sheet1.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpInvoiceGrid_Sheet1.Columns.Get(5).Width = 97.0!
            Me.FpInvoiceGrid_Sheet1.Columns.Get(6).CellType = TextCellType6
            Me.FpInvoiceGrid_Sheet1.Columns.Get(6).Label = "Vehicle"
            Me.FpInvoiceGrid_Sheet1.Columns.Get(6).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpInvoiceGrid_Sheet1.Columns.Get(6).Width = 135.0!
            Me.FpInvoiceGrid_Sheet1.Columns.Get(7).Label = "StationPoint"
            Me.FpInvoiceGrid_Sheet1.Columns.Get(7).Locked = True
            Me.FpInvoiceGrid_Sheet1.Columns.Get(7).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpInvoiceGrid_Sheet1.Columns.Get(7).Width = 149.0!
            Me.FpInvoiceGrid_Sheet1.Columns.Get(8).Label = "DestinationPoint"
            Me.FpInvoiceGrid_Sheet1.Columns.Get(8).Locked = True
            Me.FpInvoiceGrid_Sheet1.Columns.Get(8).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpInvoiceGrid_Sheet1.Columns.Get(8).Width = 157.0!
            Me.FpInvoiceGrid_Sheet1.Columns.Get(9).CellType = TextCellType7
            Me.FpInvoiceGrid_Sheet1.Columns.Get(9).Label = "Product"
            Me.FpInvoiceGrid_Sheet1.Columns.Get(9).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpInvoiceGrid_Sheet1.Columns.Get(9).Width = 163.0!
            CurrencyCellType1.DecimalPlaces = 2
            CurrencyCellType1.ReadOnly = True
            CurrencyCellType1.Separator = ","
            CurrencyCellType1.ShowCurrencySymbol = False
            CurrencyCellType1.ShowSeparator = True
            Me.FpInvoiceGrid_Sheet1.Columns.Get(10).CellType = CurrencyCellType1
            Me.FpInvoiceGrid_Sheet1.Columns.Get(10).Label = "Amount"
            Me.FpInvoiceGrid_Sheet1.Columns.Get(10).Locked = True
            Me.FpInvoiceGrid_Sheet1.Columns.Get(10).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpInvoiceGrid_Sheet1.Columns.Get(10).Width = 105.0!
            CurrencyCellType2.DecimalPlaces = 2
            CurrencyCellType2.MinimumValue = New Decimal(New Integer() {0, 0, 0, 131072})
            CurrencyCellType2.NegativeRed = True
            CurrencyCellType2.ShowCurrencySymbol = False
            Me.FpInvoiceGrid_Sheet1.Columns.Get(11).CellType = CurrencyCellType2
            Me.FpInvoiceGrid_Sheet1.Columns.Get(11).Label = "Shortage"
            Me.FpInvoiceGrid_Sheet1.Columns.Get(11).Locked = True
            Me.FpInvoiceGrid_Sheet1.Columns.Get(11).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpInvoiceGrid_Sheet1.Columns.Get(11).Width = 84.0!
            Me.FpInvoiceGrid_Sheet1.RowHeader.Columns.Default.Resizable = False
            Me.FpInvoiceGrid_Sheet1.RowHeader.Columns.Get(0).Width = 26.0!
            Me.FpInvoiceGrid_Sheet1.Rows.Get(0).Height = 21.0!
            Me.FpInvoiceGrid_Sheet1.Rows.Get(1).Height = 21.0!
            Me.FpInvoiceGrid_Sheet1.Rows.Get(2).Height = 21.0!
            Me.FpInvoiceGrid_Sheet1.Rows.Get(3).Height = 21.0!
            Me.FpInvoiceGrid_Sheet1.Rows.Get(4).Height = 21.0!
            Me.FpInvoiceGrid_Sheet1.Rows.Get(5).Height = 21.0!
            Me.FpInvoiceGrid_Sheet1.Rows.Get(6).Height = 21.0!
            Me.FpInvoiceGrid_Sheet1.Rows.Get(7).Height = 21.0!
            Me.FpInvoiceGrid_Sheet1.Rows.Get(8).Height = 21.0!
            Me.FpInvoiceGrid_Sheet1.Rows.Get(9).Height = 21.0!
            Me.FpInvoiceGrid_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
            '
            'TxtTotals
            '
            Me.TxtTotals.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TxtTotals.Enabled = False
            Me.TxtTotals.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TxtTotals.Location = New System.Drawing.Point(811, 694)
            Me.TxtTotals.Name = "TxtTotals"
            Me.TxtTotals.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.TxtTotals.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
            Me.TxtTotals.Size = New System.Drawing.Size(135, 24)
            Me.TxtTotals.TabIndex = 114
            '
            'Label6
            '
            Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label6.AutoSize = True
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(771, 696)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(34, 15)
            Me.Label6.TabIndex = 115
            Me.Label6.Text = "Total"
            '
            'CustomerBills
            '
            Me.AccessibleName = "CustomerBills"
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(1028, 744)
            Me.Controls.Add(Me.FpInvoiceGrid)
            Me.Controls.Add(Me.LblBillDate)
            Me.Controls.Add(Me.DtpBillDate)
            Me.Controls.Add(Me.TxtBillNo)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.BtnFilter)
            Me.Controls.Add(Me.TxtCustomer)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.DtpToInvoiceDate)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.TxtToTransactionNo)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.TxtFromTransactionNo)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.DtpFromInvoiceDate)
            Me.Controls.Add(Me.TxtTotals)
            Me.Controls.Add(Me.Label6)
            Me.KeyPreview = True
            Me.Name = "CustomerBills"
            Me.Text = "Bill Generation File "
            CType(Me.TxtFromTransactionNo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtToTransactionNo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtCustomer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtBillNo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FpInvoiceGrid, System.ComponentModel.ISupportInitialize).EndInit()
            Me.mnuGrid.ResumeLayout(False)
            CType(Me.FpInvoiceGrid_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtTotals, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
        Private Dr As SqlDataReader
        Dim FreshMode As Boolean
        Dim LockGrid As Boolean
        Private Enum GridCols
            BillNo = 0
            BranchCode = 1
            Branch = 2
            InvoiceNo = 3
            TokenNo = 4
            InvoiceDate = 5
            Vehicle = 6
            StationPoint = 7
            DestinationPoint = 8
            Product = 9
            Amount = 10
            Shortage = 11
        End Enum
        Private Sub CustomerBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try
                ''''''''''''For just solving the problem of this form when closing then mdi windows handling problum
                AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
                PainFPGrid(FpInvoiceGrid)
                If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                    Me.DtpBillDate.Value = CurrentWorkingDate
                End If
                FpInvoiceGrid.Sheets(0).Tag = "CustomerBillsDetails"
                '''''
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub BtnCustomerList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub
        Private Sub BtnFromInvNoList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub BtnToInvNoList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub
        Public Sub CalculateTotals()
            Dim nRow As Long
            Dim Amount As Double
            '  Dim Credit As Double
            For nRow = 0 To FpInvoiceGrid.Sheets(0).RowCount - 1
                If Trim(FpInvoiceGrid.Sheets(0).GetText(nRow, GridCols.BranchCode)) <> "" And Trim(FpInvoiceGrid.Sheets(0).GetText(nRow, GridCols.InvoiceNo)) <> "" Then

                    Amount = Amount + CDbl(FpInvoiceGrid.Sheets(0).GetText(nRow, GridCols.Amount) & "0")
                    'nSalesTax = nSalesTax + GetData(InvoiceNo.SalesTax, nRow)
                    'CreditIncSTax = CreditIncSTax + Trim(GetData(InvoiceNo.AmountIncludeSTax, nRow))
                End If
            Next
            TxtTotals.Text = Amount


        End Sub


        Public Function ValidateData() As Boolean
            Dim nGridRowCount As Long
            If CheckGridData(nGridRowCount) Then
                If nGridRowCount < 1 Then
                    If MsgBox("You  have specified No valid detail record on this Product JournalVoucher Transaction..." & vbCrLf & "This Transaction will be Saved as Cancelled !" & vbCrLf & vbCrLf & "Are you sure you want to Save ?", vbQuestion + vbYesNo + vbDefaultButton2, "No Details specified...") = MsgBoxResult.No Then
                        ValidateData = False
                        FpInvoiceGrid.Focus()
                        Exit Function
                    Else
                        ValidateData = True
                    End If
                Else
                    ValidateData = True
                End If
            Else
                ValidateData = False
            End If

        End Function

        Public Function CheckGridData(ByRef nRowCount As Long) As Boolean
            Dim iRow As Long
            Dim StartRow As Long
            Dim GLCode As String

            Dim MatchingRow As Long

            For iRow = 0 To FpInvoiceGrid.Sheets(0).RowCount - 1
                GLCode = Trim(FpInvoiceGrid.Sheets(0).GetText(iRow, GridCols.InvoiceNo))
                'PONumber = Trim(FpInvoiceGrid.Sheets(0).GetText(GridCols.PONo, iRow))
                StartRow = iRow
                If Trim(GLCode) <> "" And Val(FpInvoiceGrid.Sheets(0).GetText(iRow, GridCols.Amount)) <> 0 <> 0 Then
                    GLCode = FpInvoiceGrid.Search(0, GLCode, False, True, False, False, StartRow + 1, GridCols.InvoiceNo, MatchingRow, 0)
                    If Val(MatchingRow) > 0 And MatchingRow <> StartRow Then
                        ErrProvider.SetError(FpInvoiceGrid, "GL Code # " & Trim(GLCode) & "  has been specified more than once in detail..." & vbCrLf & vbCrLf & "You cannot specify any record more than one times in a single transaction !")
                        FpInvoiceGrid.Sheets(0).SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Row
                        FpInvoiceGrid.Sheets(0).AddSelection(MatchingRow, GridCols.InvoiceNo, 1, GridCols.Shortage)

                        CheckGridData = False
                        Exit Function
                    End If
                    nRowCount = nRowCount + 1
                End If
            Next
            CheckGridData = True
            ' Code End
        End Function

        Public Sub SetCreditamountTotal(ByVal mode As AzamTechnologies.DataManager.DataMode)
            CalculateTotals()
        End Sub
        Private Sub BtnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFilter.Click
            Try
                Dim DS As DataSet = Nothing
                Dim Acc As New AzamTechnologies.Database.DataAccess
                If Desc.Text <> String.Empty And TxtBillNo.Text <> String.Empty Then
                    If TxtFromTransactionNo.Text <> String.Empty Or TxtToTransactionNo.Text <> String.Empty Then
                        Acc.PopulateDataSet(DS, "SelectCustomerBills", "OPTION", "FILTERINVOICES", "FromInvoiceNo", TxtFromTransactionNo.Text, "ToInvoiceNo", TxtToTransactionNo.Text, "CustomerCode", Desc.Text)
                    Else
                        Acc.PopulateDataSet(DS, "SelectCustomerBills", "OPTION", "FILTERINVOICES", "FromInvoiceDate", DtpFromInvoiceDate.Value, "ToInvoiceDate", DtpToInvoiceDate.Value, "CustomerCode", Desc.Text)
                    End If
                Else
                    MessageBox.Show("Please First enter Bill No & Customer Information for Bill Generation")
                    Desc.Focus()
                    Exit Sub
                End If
                Acc = Nothing
                FillCustomerInvoiceGrid(DS)
                CalculateTotals()
            Catch ex As SqlException
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Sub FillCustomerInvoiceGrid(ByVal mDetailData As DataSet)
            Try
                Dim col As Int16
                Dim row As Integer
                EmptyFpInvoiceGrid()
                For row = 0 To mDetailData.Tables(0).Rows.Count - 1
                    If mDetailData.Tables(0).Rows.Count > Me.FpInvoiceGrid.Sheets(0).RowCount Then
                        Me.FpInvoiceGrid.Sheets(0).RowCount = mDetailData.Tables(0).Rows.Count
                    End If
                    For col = 0 To Me.FpInvoiceGrid.Sheets(0).ColumnCount - 1
                        If col = GridCols.BillNo Then
                            FpInvoiceGrid.Sheets(0).SetTag(row, col, "BillNo")
                            FpInvoiceGrid.Sheets(0).SetText(row, col, TxtBillNo.Text)
                        ElseIf col = GridCols.InvoiceNo Then
                            FpInvoiceGrid.Sheets(0).SetTag(row, col, "InvoiceNo")
                        ElseIf col = GridCols.BranchCode Then
                            FpInvoiceGrid.Sheets(0).SetTag(row, col, "BranchCode")
                        End If

                        Dim strColName As String
                        strColName = FpInvoiceGrid.Sheets(0).ColumnHeader.Cells(0, col).Text 'FpInvoiceGrid.Sheets(0) Header text must be the same as Detail table column name
                        If Not IsNothing(mDetailData.Tables(0).Columns(strColName)) Then
                            FpInvoiceGrid.Sheets(0).SetText(row, col, IIf(System.DBNull.Value Is mDetailData.Tables(0).Rows(row).Item(strColName), "", mDetailData.Tables(0).Rows(row).Item(strColName)))
                        End If
                        CalculateTotals()
                        'End If
                    Next
                Next
            Catch ex As SqlClient.SqlException
                MsgBox(ex.Message)
            End Try
        End Sub
        Sub EmptyFpInvoiceGrid()
            FpInvoiceGrid.Sheets(0).ClearRange(0, 0, FpInvoiceGrid.Sheets(0).Rows.Count, FpInvoiceGrid.Sheets(0).ColumnCount, True)
            FpInvoiceGrid.Sheets(0).Cells(0, 0, FpInvoiceGrid.Sheets(0).Rows.Count - 1, FpInvoiceGrid.Sheets(0).ColumnCount - 1).Tag = String.Empty
            CalculateTotals()
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

        Private Sub Desc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Desc.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.Desc_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
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
        Private Sub DtpBillDate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpBillDate.Validated
            ErrProvider.SetError(DtpBillDate, String.Empty)
        End Sub
        Public Sub DtpDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DtpBillDate.Validating

            Dim DateError As String

            DateError = ValidateTransactionDate(DtpBillDate.Value, Me.Tag)
            If DateError <> String.Empty Then
                ErrProvider.SetError(DtpBillDate, DateError)
                e.Cancel = True

            End If
            Try
                'If TxtBillNo.Text <> String.Empty And TxtBillNo.Text.Length = TxtBillNo.MaxLength Then
                If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                    TxtBillNo.Text = String.Empty
                    KeyGeneration()
                Else
                    If DateSerial(DtpBillDate.Value.Year, DtpBillDate.Value.Month, 1) <> DateSerial(Mid(TxtBillNo.Text, 1, 2), Mid(TxtBillNo.Text, 3, 2), 1) Then
                        e.Cancel = True
                        ErrProvider.SetError(DtpBillDate, "You cannot change the Month Or Year for this Transaction Date..." & vbCrLf & "Please specify a valid Date within " & MonthName(Mid(TxtBillNo.Text, 3, 2)) & ", " & Year(DateSerial("20" & Mid(TxtBillNo.Text, 1, 2), 1, 1)))
                        Exit Sub
                    End If
                End If
            Catch ex As System.ArgumentException
                e.Cancel = True
                ErrProvider.SetError(DtpBillDate, "You cannot change the Month Or Year for this Transaction Date..." & vbCrLf & "Please specify a valid Date within " & MonthName(Mid(TxtBillNo.Text, 3, 2)) & ", " & Year(DateSerial("20" & Mid(TxtBillNo.Text, 1, 2), 1, 1)))
            End Try
        End Sub
        Private Sub mnuClearGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuClearGrid.Click
            FpInvoiceGrid.Sheets(0).ClearRange(0, 0, FpInvoiceGrid.Sheets(0).Rows.Count, FpInvoiceGrid.Sheets(0).ColumnCount, True)
            FpInvoiceGrid.Sheets(0).Cells(0, 0, FpInvoiceGrid.Sheets(0).Rows.Count - 1, FpInvoiceGrid.Sheets(0).ColumnCount - 1).Tag = String.Empty
            CalculateTotals()
        End Sub
        Private Sub mnuDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MnuDeleteRow.Click
            FpInvoiceGrid.Sheets(0).ClearRange(FpInvoiceGrid.Sheets(0).ActiveRowIndex, 0, 1, FpInvoiceGrid.Sheets(0).ColumnCount, True)
            FpInvoiceGrid.Sheets(0).Cells(FpInvoiceGrid.Sheets(0).ActiveRowIndex, 0, FpInvoiceGrid.Sheets(0).ActiveRowIndex, FpInvoiceGrid.Sheets(0).ColumnCount - 1).Tag = String.Empty
            CalculateTotals()
        End Sub
        Private Sub MnuInsertRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuInsertRow.Click
            ErrProvider.SetError(FpInvoiceGrid, "Inserting of row in this sheet not allowed")
            ' FpInvoiceGrid.Sheets(0).Rows.Add(FpInvoiceGrid.Sheets(0).ActiveRowIndex, 1)
        End Sub

        Private Sub FpInvoiceGrid_Advance(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.AdvanceEventArgs) Handles FpInvoiceGrid.Advance

        End Sub

        Private Sub FpInvoiceGrid_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FpInvoiceGrid.EnabledChanged
            CalculateTotals()
        End Sub
        Private Sub KeyGeneration()
            If TxtBillNo.Text = String.Empty Then
                If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                    Dim objAcc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader
                    Reader = objAcc.GetRecord("Select" & Me.AccessibleName, "Option", "AUTO", "YearMonth", Format(DtpBillDate.Value, "yy") & Format(DtpBillDate.Value, "MM"))
                    'Auto increment the primary key field when we Add the 
                    ' AccessibleDescription Properties of the Control set to "AUTO"
                    If Reader.HasRows Then
                        While Reader.Read
                            TxtBillNo.Text = Reader.Item("BillNo")
                            TxtBillNo.Text = Integer.Parse(TxtBillNo.Text) + 1
                            If Mid(TxtBillNo.Text.Insert(0, "0"), 1, 2) = "09" Then
                                TxtBillNo.Text = TxtBillNo.Text.Insert(0, "0")
                                ' chCtr.Text = mManager.FormateData.FormatKeyYearMonthValue(chCtr.Text, CType(chCtr, TextBox).MaxLength)
                            End If

                            ' chCtr.Text = mManager.FormateData.FormatKeyYearMonthValue(chCtr.Text, CType(chCtr, TextBox).MaxLength)
                        End While
                    Else
                        TxtBillNo.Text = FormatKeyYearMonthValue(DtpBillDate.Value, TxtBillNo.Text, CType(TxtBillNo, Infragistics.Win.UltraWinEditors.UltraTextEditor).MaxLength)
                    End If
                End If
            End If
        End Sub

        Private Sub Desc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Desc.ValueChanged

        End Sub

        Private Sub TxtFromTransactionNo_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtFromTransactionNo.EditorButtonClick
            If Me.Desc.Text <> String.Empty Then
                Try
                    Dim iRow As Integer
                    Dim frmser As FrmSearch
                    frmser = New FrmSearch
                    frmser.FillData("Invoices", "CustomerCode", Desc.Text, "OPTION", "SRHGRID")
                    frmser.ShowDialog()
                    iRow = frmser.UGSearch.ActiveRow.Index
                    Me.TxtFromTransactionNo.Text = frmser.UGSearch.Rows(iRow).Cells("InvoiceNo").Value
                    Me.TxtFromTransactionNo.Focus()
                Catch ex As IndexOutOfRangeException
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("Please First enter Customer for Bill Generation")
                Me.Desc.Focus()
            End If
        End Sub

        Private Sub TxtFromTransactionNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtFromTransactionNo.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtFromTransactionNo_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtFromTransactionNo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFromTransactionNo.ValueChanged

        End Sub

        Private Sub TxtToTransactionNo_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtToTransactionNo.EditorButtonClick
            If Me.Desc.Text <> String.Empty Then
                Try
                    Dim iRow As Integer
                    Dim frmser As FrmSearch
                    frmser = New FrmSearch
                    frmser.FillData("Invoices", "CustomerCode", Desc.Text, "OPTION", "SRHGRID")
                    frmser.ShowDialog()
                    iRow = frmser.UGSearch.ActiveRow.Index
                    Me.TxtToTransactionNo.Text = frmser.UGSearch.Rows(iRow).Cells("InvoiceNo").Value
                    Me.TxtToTransactionNo.Focus()
                Catch ex As IndexOutOfRangeException
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("Please First enter coustomer for Bill Generation")
                Me.Desc.Focus()
            End If
        End Sub

        Private Sub TxtToTransactionNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtToTransactionNo.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtToTransactionNo_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtBillNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtBillNo.Validating
            If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                KeyGeneration()
            End If
        End Sub

        Private Sub TxtBillNo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBillNo.ValueChanged

        End Sub

        Private Sub DtpBillDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpBillDate.ValueChanged

        End Sub
    End Class
End Namespace