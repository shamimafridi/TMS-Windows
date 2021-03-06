Imports System.Data.SqlClient
Namespace GeneralLedger
    Public Class Vouchers
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
        Friend WithEvents TxtDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents txtTransactionNumber As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents mnuGrid As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtBranchCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents txtBranch As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents ATUrduTitle As ATUrduTextBox.UrduTextBox
        Friend WithEvents FpVoucherGrid As FarPoint.Win.Spread.FpSpread
        Friend WithEvents FpVoucherGrid_Sheet1 As FarPoint.Win.Spread.SheetView
        Friend WithEvents MnuInsertRow As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MnuDeleteRow As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MnuClearGrid As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MnuExportToExcel As System.Windows.Forms.ToolStripMenuItem
        Public WithEvents NATURE As Infragistics.Win.UltraWinEditors.UltraTextEditor
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vouchers))
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
            Dim TextCellType1 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim TextCellType2 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim TextCellType3 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim TextCellType4 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim TextCellType6 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim TextCellType7 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim TextCellType8 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
            Dim CurrencyCellType1 As FarPoint.Win.Spread.CellType.CurrencyCellType = New FarPoint.Win.Spread.CellType.CurrencyCellType()
            Dim CurrencyCellType2 As FarPoint.Win.Spread.CellType.CurrencyCellType = New FarPoint.Win.Spread.CellType.CurrencyCellType()
            Me.txtTransactionNumber = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.TxtDate = New System.Windows.Forms.DateTimePicker()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.NATURE = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.mnuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.MnuInsertRow = New System.Windows.Forms.ToolStripMenuItem()
            Me.MnuDeleteRow = New System.Windows.Forms.ToolStripMenuItem()
            Me.MnuClearGrid = New System.Windows.Forms.ToolStripMenuItem()
            Me.MnuExportToExcel = New System.Windows.Forms.ToolStripMenuItem()
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.Label3 = New System.Windows.Forms.Label()
            Me.txtBranchCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.txtBranch = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.ATUrduTitle = New ATUrduTextBox.UrduTextBox()
            Me.FpVoucherGrid = New FarPoint.Win.Spread.FpSpread()
            Me.FpVoucherGrid_Sheet1 = New FarPoint.Win.Spread.SheetView()
            CType(Me.txtTransactionNumber, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.NATURE, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mnuGrid.SuspendLayout()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtBranchCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtBranch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ATUrduTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FpVoucherGrid, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FpVoucherGrid_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'txtTransactionNumber
            '
            Me.txtTransactionNumber.AcceptsReturn = True
            Me.txtTransactionNumber.Location = New System.Drawing.Point(191, 102)
            Me.txtTransactionNumber.MaxLength = Global.BusinessLeaf.My.MySettings.Default.TransactionNo
            Me.txtTransactionNumber.Name = "txtTransactionNumber"
            Me.txtTransactionNumber.Size = New System.Drawing.Size(133, 21)
            Me.txtTransactionNumber.TabIndex = 1
            Me.txtTransactionNumber.Tag = "PK.TransactionNo"
            '
            'Desc
            '
            Me.Desc.Location = New System.Drawing.Point(191, 149)
            Me.Desc.Multiline = True
            Me.Desc.Name = "Desc"
            Me.Desc.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
            Me.Desc.Size = New System.Drawing.Size(272, 56)
            Me.Desc.TabIndex = 3
            Me.Desc.Tag = "ds.Description"
            '
            'TxtDate
            '
            Me.TxtDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
            Me.TxtDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
            Me.TxtDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
            Me.TxtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.TxtDate.Location = New System.Drawing.Point(191, 126)
            Me.TxtDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.TxtDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.TxtDate.Name = "TxtDate"
            Me.TxtDate.Size = New System.Drawing.Size(133, 20)
            Me.TxtDate.TabIndex = 2
            Me.TxtDate.Tag = "dt.TransactionDate"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(77, 149)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 77
            Me.Label2.Text = "Description"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(77, 105)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(83, 20)
            Me.Label1.TabIndex = 76
            Me.Label1.Text = "Document No"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.ForeColor = System.Drawing.Color.Navy
            Me.Label9.Location = New System.Drawing.Point(77, 129)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(110, 20)
            Me.Label9.TabIndex = 74
            Me.Label9.Text = "Document Date"
            '
            'NATURE
            '
            Me.NATURE.Location = New System.Drawing.Point(496, 52)
            Me.NATURE.Name = "NATURE"
            Me.NATURE.ReadOnly = True
            Me.NATURE.Size = New System.Drawing.Size(128, 21)
            Me.NATURE.TabIndex = 87
            Me.NATURE.TabStop = False
            Me.NATURE.Tag = "PK.TransactionNature"
            Me.NATURE.Visible = False
            '
            'mnuGrid
            '
            Me.mnuGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuInsertRow, Me.MnuDeleteRow, Me.MnuClearGrid, Me.MnuExportToExcel})
            Me.mnuGrid.Name = "mnuGrid"
            Me.mnuGrid.Size = New System.Drawing.Size(153, 92)
            '
            'MnuInsertRow
            '
            Me.MnuInsertRow.Name = "MnuInsertRow"
            Me.MnuInsertRow.Size = New System.Drawing.Size(152, 22)
            Me.MnuInsertRow.Text = "Insert Row"
            '
            'MnuDeleteRow
            '
            Me.MnuDeleteRow.Name = "MnuDeleteRow"
            Me.MnuDeleteRow.Size = New System.Drawing.Size(152, 22)
            Me.MnuDeleteRow.Text = "Delete Row"
            '
            'MnuClearGrid
            '
            Me.MnuClearGrid.Name = "MnuClearGrid"
            Me.MnuClearGrid.Size = New System.Drawing.Size(152, 22)
            Me.MnuClearGrid.Text = "Clear Grid"
            '
            'MnuExportToExcel
            '
            Me.MnuExportToExcel.Name = "MnuExportToExcel"
            Me.MnuExportToExcel.Size = New System.Drawing.Size(152, 22)
            Me.MnuExportToExcel.Text = "Export To Excel"
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
            Me.Label3.Location = New System.Drawing.Point(77, 81)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(95, 20)
            Me.Label3.TabIndex = 97
            Me.Label3.Text = "Branch Code"
            '
            'txtBranchCode
            '
            Me.txtBranchCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchCode.Appearance = Appearance1
            Me.txtBranchCode.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranchCode.Location = New System.Drawing.Point(191, 78)
            Me.txtBranchCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.BranchCode_Length
            Me.txtBranchCode.Name = "txtBranchCode"
            Me.txtBranchCode.Size = New System.Drawing.Size(133, 21)
            Me.txtBranchCode.TabIndex = 0
            Me.txtBranchCode.Tag = "PK.BranchCode"
            '
            'txtBranch
            '
            Me.txtBranch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranch.Appearance = Appearance2
            Me.txtBranch.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranch.Location = New System.Drawing.Point(324, 78)
            Me.txtBranch.Name = "txtBranch"
            Me.txtBranch.Size = New System.Drawing.Size(658, 21)
            Me.txtBranch.TabIndex = 6
            Me.txtBranch.TabStop = False
            Me.txtBranch.Tag = "IM.BranchName"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = Global.BusinessLeaf.My.MySettings.Default.UrduFontType
            Me.Label4.ForeColor = System.Drawing.Color.Navy
            Me.Label4.Location = New System.Drawing.Point(689, 149)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(54, 47)
            Me.Label4.TabIndex = 110
            Me.Label4.Text = "تفصیل"
            '
            'ATUrduTitle
            '
            Me.ATUrduTitle.Font = Global.BusinessLeaf.My.MySettings.Default.UrduFontType
            Me.ATUrduTitle.Location = New System.Drawing.Point(469, 149)
            Me.ATUrduTitle.Multiline = True
            Me.ATUrduTitle.Name = "ATUrduTitle"
            Me.ATUrduTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.ATUrduTitle.Size = New System.Drawing.Size(214, 56)
            Me.ATUrduTitle.TabIndex = 4
            Me.ATUrduTitle.Tag = "dd.UrduTitle"
            '
            'FpVoucherGrid
            '
            Me.FpVoucherGrid.AccessibleDescription = "FpVoucherGrid, Sheet1, Row 0, Column 0, "
            Me.FpVoucherGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.FpVoucherGrid.BackColor = System.Drawing.SystemColors.Control
            Me.FpVoucherGrid.ContextMenuStrip = Me.mnuGrid
            Me.FpVoucherGrid.EditModeReplace = True
            Me.FpVoucherGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.FpVoucherGrid.Location = New System.Drawing.Point(80, 211)
            Me.FpVoucherGrid.Name = "FpVoucherGrid"
            Me.FpVoucherGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.FpVoucherGrid.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.FpVoucherGrid_Sheet1})
            Me.FpVoucherGrid.Size = New System.Drawing.Size(913, 435)
            Me.FpVoucherGrid.TabIndex = 5
            '
            'FpVoucherGrid_Sheet1
            '
            Me.FpVoucherGrid_Sheet1.Reset()
            Me.FpVoucherGrid_Sheet1.SheetName = "Sheet1"
            'Formulas and custom names must be loaded with R1C1 reference style
            Me.FpVoucherGrid_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
            FpVoucherGrid_Sheet1.ColumnCount = 11
            FpVoucherGrid_Sheet1.RowCount = 10
            Me.FpVoucherGrid_Sheet1.ColumnFooter.Rows.Get(0).Height = 53.0!
            Me.FpVoucherGrid_Sheet1.ColumnFooter.Visible = True
            Me.FpVoucherGrid_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "BranchCode"
            Me.FpVoucherGrid_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "TransactionNature"
            Me.FpVoucherGrid_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "TransactionNo"
            Me.FpVoucherGrid_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "GLCode"
            Me.FpVoucherGrid_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "GLDescription"
            Me.FpVoucherGrid_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "DivisionCode"
            Me.FpVoucherGrid_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "Division"
            Me.FpVoucherGrid_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "Reference"
            Me.FpVoucherGrid_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "Debit"
            Me.FpVoucherGrid_Sheet1.ColumnHeader.Cells.Get(0, 9).Value = "Credit"
            Me.FpVoucherGrid_Sheet1.ColumnHeader.Cells.Get(0, 10).Value = "Narration"
            Me.FpVoucherGrid_Sheet1.Columns.Get(0).CellType = TextCellType1
            Me.FpVoucherGrid_Sheet1.Columns.Get(0).Label = "BranchCode"
            Me.FpVoucherGrid_Sheet1.Columns.Get(0).Visible = False
            Me.FpVoucherGrid_Sheet1.Columns.Get(1).CellType = TextCellType2
            Me.FpVoucherGrid_Sheet1.Columns.Get(1).Label = "TransactionNature"
            Me.FpVoucherGrid_Sheet1.Columns.Get(1).Visible = False
            Me.FpVoucherGrid_Sheet1.Columns.Get(2).CellType = TextCellType3
            Me.FpVoucherGrid_Sheet1.Columns.Get(2).Label = "TransactionNo"
            Me.FpVoucherGrid_Sheet1.Columns.Get(2).Visible = False
            Me.FpVoucherGrid_Sheet1.Columns.Get(3).CellType = TextCellType4
            Me.FpVoucherGrid_Sheet1.Columns.Get(3).Label = "GLCode"
            Me.FpVoucherGrid_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVoucherGrid_Sheet1.Columns.Get(3).Width = 106.0!
            Me.FpVoucherGrid_Sheet1.Columns.Get(4).CellType = TextCellType5
            Me.FpVoucherGrid_Sheet1.Columns.Get(4).Label = "GLDescription"
            Me.FpVoucherGrid_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVoucherGrid_Sheet1.Columns.Get(4).Width = 190.0!
            Me.FpVoucherGrid_Sheet1.Columns.Get(5).CellType = TextCellType6
            Me.FpVoucherGrid_Sheet1.Columns.Get(5).Label = "DivisionCode"
            Me.FpVoucherGrid_Sheet1.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVoucherGrid_Sheet1.Columns.Get(5).Width = 71.0!
            Me.FpVoucherGrid_Sheet1.Columns.Get(6).CellType = TextCellType7
            Me.FpVoucherGrid_Sheet1.Columns.Get(6).Label = "Division"
            Me.FpVoucherGrid_Sheet1.Columns.Get(6).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVoucherGrid_Sheet1.Columns.Get(6).Width = 103.0!
            Me.FpVoucherGrid_Sheet1.Columns.Get(7).CellType = TextCellType8
            Me.FpVoucherGrid_Sheet1.Columns.Get(7).Label = "Reference"
            Me.FpVoucherGrid_Sheet1.Columns.Get(7).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVoucherGrid_Sheet1.Columns.Get(7).Width = 105.0!
            CurrencyCellType1.DecimalPlaces = 2
            CurrencyCellType1.MaximumValue = New Decimal(New Integer() {-727379969, 232, 0, 131072})
            CurrencyCellType1.MinimumValue = New Decimal(New Integer() {0, 0, 0, 131072})
            CurrencyCellType1.NegativeRed = True
            CurrencyCellType1.Separator = ","
            CurrencyCellType1.ShowCurrencySymbol = False
            CurrencyCellType1.ShowSeparator = True
            Me.FpVoucherGrid_Sheet1.Columns.Get(8).CellType = CurrencyCellType1
            Me.FpVoucherGrid_Sheet1.Columns.Get(8).Label = "Debit"
            Me.FpVoucherGrid_Sheet1.Columns.Get(8).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVoucherGrid_Sheet1.Columns.Get(8).Width = 84.0!
            CurrencyCellType2.DecimalPlaces = 2
            CurrencyCellType2.MaximumValue = New Decimal(New Integer() {-727379969, 232, 0, 131072})
            CurrencyCellType2.MinimumValue = New Decimal(New Integer() {0, 0, 0, 131072})
            CurrencyCellType2.NegativeRed = True
            CurrencyCellType2.Separator = ","
            CurrencyCellType2.ShowCurrencySymbol = False
            CurrencyCellType2.ShowSeparator = True
            Me.FpVoucherGrid_Sheet1.Columns.Get(9).CellType = CurrencyCellType2
            Me.FpVoucherGrid_Sheet1.Columns.Get(9).Label = "Credit"
            Me.FpVoucherGrid_Sheet1.Columns.Get(9).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVoucherGrid_Sheet1.Columns.Get(9).Width = 92.0!
            Me.FpVoucherGrid_Sheet1.Columns.Get(10).Label = "Narration"
            Me.FpVoucherGrid_Sheet1.Columns.Get(10).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVoucherGrid_Sheet1.Columns.Get(10).Width = 300.0!
            Me.FpVoucherGrid_Sheet1.RowHeader.Columns.Default.Resizable = False
            Me.FpVoucherGrid_Sheet1.RowHeader.Columns.Get(0).Width = 26.0!
            Me.FpVoucherGrid_Sheet1.Rows.Get(0).Height = 21.0!
            Me.FpVoucherGrid_Sheet1.Rows.Get(1).Height = 21.0!
            Me.FpVoucherGrid_Sheet1.Rows.Get(2).Height = 21.0!
            Me.FpVoucherGrid_Sheet1.Rows.Get(3).Height = 21.0!
            Me.FpVoucherGrid_Sheet1.Rows.Get(4).Height = 21.0!
            Me.FpVoucherGrid_Sheet1.Rows.Get(5).Height = 21.0!
            Me.FpVoucherGrid_Sheet1.Rows.Get(6).Height = 21.0!
            Me.FpVoucherGrid_Sheet1.Rows.Get(7).Height = 21.0!
            Me.FpVoucherGrid_Sheet1.Rows.Get(8).Height = 21.0!
            Me.FpVoucherGrid_Sheet1.Rows.Get(9).Height = 21.0!
            Me.FpVoucherGrid_Sheet1.Tag = "VouchersDetails"
            Me.FpVoucherGrid_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
            '
            'Vouchers
            '
            Me.AccessibleName = "Vouchers"
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(1028, 746)
            Me.Controls.Add(Me.txtBranchCode)
            Me.Controls.Add(Me.FpVoucherGrid)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.ATUrduTitle)
            Me.Controls.Add(Me.txtBranch)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.NATURE)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.txtTransactionNumber)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.TxtDate)
            Me.KeyPreview = True
            Me.Name = "Vouchers"
            Me.Text = "Voucher File "
            CType(Me.txtTransactionNumber, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.NATURE, System.ComponentModel.ISupportInitialize).EndInit()
            Me.mnuGrid.ResumeLayout(False)
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtBranchCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtBranch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ATUrduTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FpVoucherGrid, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FpVoucherGrid_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region
        Dim CmbGlCode As FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
        Dim CmbGlDesc As FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
        Dim CmbDivCode As FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
        Dim CmbDivDesc As FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
        Private Dr As SqlDataReader
        Dim FreshMode As Boolean
        Dim LockGrid As Boolean
        Private Enum GridCols
            BranchCode = 0
            VoucherNature = 1
            VoucherNumber = 2
            GLCode = 3
            GLDescription = 4
            DivisionCode = 5
            Division = 6
            Reference = 7
            Debit = 8
            Credit = 9
            Narration = 10
        End Enum

        Private Sub Vouchers_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
            DsGLs = Nothing
            DsDiv = Nothing
            Dr = Nothing
            CmbGlCode = Nothing
            CmbGlDesc = Nothing
            CmbDivCode = Nothing
            CmbDivDesc = Nothing
        End Sub
        Private Sub JournalVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ''''''''''''For just solving the problem of this form when closing then mdi windows handling problum
            CmbGlCode = New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
            CmbGlDesc = New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
            CmbDivCode = New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType
            CmbDivDesc = New FarPoint.Win.Spread.CellType.MultiColumnComboBoxCellType

            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
            If (My.Settings.ShowDivision = False) Then
                FpVoucherGrid_Sheet1.Columns.Get(GridCols.DivisionCode).Visible = False
                FpVoucherGrid_Sheet1.Columns.Get(GridCols.Division).Visible = False
            End If
            PainFPGrid(FpVoucherGrid)

            Try
                ''''''
                SettingGrid()
                ''
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Sub SettingGrid()
            ''''''''''''''''''''''''
            ''''''''''''''''''''''''''

            ''''Combo setting

            'GL Accounts
            ''''''''''''''''''''''''''''''''''''''

            FillCombo(DsGLs, "SelectCOASubSubsidiaries", "OPTION", "COMBO")

            Me.FpVoucherGrid.ButtonDrawMode = FarPoint.Win.Spread.ButtonDrawModes.CurrentCell

            With DsGLs.Tables(0)
                CmbGlCode.DataSourceList = DsGLs
                CmbGlCode.ListOffset = 10
                CmbGlCode.AutoSearch = FarPoint.Win.AutoSearch.MultipleCharacter
                CmbGlCode.ShowColumnHeaders = True
                CmbGlCode.DataMemberList = "Table"

            End With

            CmbGlCode.ListWidth = 300

            With DsGLs.Tables(0)
                CmbGlDesc.DataSourceList = DsGLs
                CmbGlDesc.ListOffset = 10
                CmbGlDesc.AutoSearch = FarPoint.Win.AutoSearch.MultipleCharacter
                CmbGlDesc.ShowColumnHeaders = True
                CmbGlDesc.DataMemberList = "Table"


            End With
            CmbGlDesc.ListWidth = 300

            'Divisions
            ''''''''''''''''''''''''''''''''''''''
            FillCombo(DsDiv, "SelectDivisions", "OPTION", "COMBO")

            Me.FpVoucherGrid.ButtonDrawMode = FarPoint.Win.Spread.ButtonDrawModes.CurrentCell

            With DsDiv.Tables(0)
                CmbDivCode.DataSourceList = DsDiv
                CmbDivCode.ListOffset = 10
                CmbDivCode.AutoSearch = FarPoint.Win.AutoSearch.MultipleCharacter
                CmbDivCode.ShowColumnHeaders = True
                CmbDivCode.DataMemberList = "Table"

            End With



            With DsDiv.Tables(0)
                CmbDivDesc.DataSourceList = DsDiv
                CmbDivDesc.ListOffset = 10
                CmbDivDesc.AutoSearch = FarPoint.Win.AutoSearch.MultipleCharacter
                CmbDivDesc.ShowColumnHeaders = True
                CmbDivDesc.DataMemberList = "Table"

            End With
            CmbDivDesc.ListWidth = 450
            FpVoucherGrid.Sheets(0).Tag = "VouchersDetails"
            If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                TxtDate.Value = CurrentWorkingDate
            End If
            'TOTAL CELL SETTINGS
            Dim TotalCellType = New FarPoint.Win.Spread.CellType.CurrencyCellType
            TotalCellType.ShowCurrencySymbol = False
            ' Me.FpVoucherGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Amount - 1).Value = "Total:"

            Me.FpVoucherGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Debit).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right
            Me.FpVoucherGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Debit - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right
            Me.FpVoucherGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Debit).CellType = TotalCellType

            Me.FpVoucherGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Credit).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right
            Me.FpVoucherGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Credit - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right
            Me.FpVoucherGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Credit).CellType = TotalCellType

            Dim r As Integer
            Dim j As Integer
            For r = 0 To Me.FpVoucherGrid.Sheets(0).RowCount
                For j = 0 To Me.FpVoucherGrid.Sheets(0).ColumnCount
                    Me.FpVoucherGrid.Sheets(0).Models.Data.SetValue(r, j, j + r * Me.FpVoucherGrid.Sheets(0).ColumnCount)
                Next j
            Next r
            Dim i As Integer
            i = 0
            Me.FpVoucherGrid.Sheets(0).ColumnFooter.SetAggregationType(0, GridCols.Credit, FarPoint.Win.Spread.Model.AggregationType.Sum)

            Me.FpVoucherGrid.Sheets(0).ColumnFooter.SetAggregationType(0, GridCols.Debit, FarPoint.Win.Spread.Model.AggregationType.Sum)
            Me.FpVoucherGrid.Sheets(0).ColumnFooter.Cells(0, i).Value = "Sum"


        End Sub
        Dim DsGLs As DataSet
        Dim DsDiv As DataSet

        Public Function ValidateData() As Boolean
            Dim nGridRowCount As Long
            If CheckGridData(nGridRowCount) Then
                If nGridRowCount < 1 Then
                    If MsgBox("You  have specified No valid detail record on this Product JournalVoucher Transaction..." & vbCrLf & "This Transaction will be Saved as Cancelled !" & vbCrLf & vbCrLf & "Are you sure you want to Save ?", vbQuestion + vbYesNo + vbDefaultButton2, "No Details specified...") = MsgBoxResult.No Then
                        ValidateData = False
                        FpVoucherGrid.Focus()
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

            'For iRow = 0 To FpVoucherGrid.Sheets(0).RowCount - 1
            '    GLCode = Trim(FpVoucherGrid.Sheets(0).GetText(iRow, GridCols.GLCode))
            '    'PONumber = Trim(FpVoucherGrid.Sheets(0).GetText(GridCols.PONo, iRow))
            '    StartRow = iRow
            '    If Trim(GLCode) <> "" And Val(FpVoucherGrid.Sheets(0).GetValue(iRow, GridCols.Credit)) <> 0 Or Val(FpVoucherGrid.Sheets(0).GetValue(iRow, GridCols.Debit)) <> 0 Then
            '        GLCode = FpVoucherGrid.Search(0, GLCode, False, True, False, False, StartRow + 1, GridCols.GLCode, MatchingRow, 0)
            '        If Val(MatchingRow) > 0 And MatchingRow <> StartRow Then
            '            ErrProvider.SetError(FpVoucherGrid, "GL Code # " & Trim(GLCode) & "  has been specified more than once in detail..." & vbCrLf & vbCrLf & "You cannot specify any record more than one times in a single transaction !")
            '            FpVoucherGrid.Sheets(0).SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Row
            '            FpVoucherGrid.Sheets(0).AddSelection(MatchingRow, GridCols.GLCode, 1, GridCols.Narration)

            '            CheckGridData = False
            '            Exit Function
            '        End If
            '        nRowCount = nRowCount + 1
            '    End If
            'Next
            If CheckTotalBalance() = True Then
                nRowCount = nRowCount + 1
                Return True
            Else
                Return False
            End If
            CheckGridData = True
            ' Code End
        End Function
        Private Function CheckTotalBalance() As Boolean

            If FpVoucherGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Debit).Text <> FpVoucherGrid.Sheets(0).ColumnFooter.Cells(0, GridCols.Credit).Text Then
                ErrProvider.SetError(FpVoucherGrid, "Credit and Debit amount must be balanced")
                Return False
            Else
                ErrProvider.SetError(FpVoucherGrid, "")
                Return True
            End If
        End Function
        Private Sub mnuClearGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuClearGrid.Click
            FpVoucherGrid.Sheets(0).ClearRange(0, 0, FpVoucherGrid.Sheets(0).Rows.Count, FpVoucherGrid.Sheets(0).ColumnCount, True)
            FpVoucherGrid.Sheets(0).Cells(0, 0, FpVoucherGrid.Sheets(0).Rows.Count - 1, FpVoucherGrid.Sheets(0).ColumnCount - 1).Tag = String.Empty
        End Sub
        Private Sub mnuDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MnuDeleteRow.Click
            FpVoucherGrid.Sheets(0).ClearRange(FpVoucherGrid.Sheets(0).ActiveRowIndex, 0, 1, FpVoucherGrid.Sheets(0).ColumnCount, True)
            FpVoucherGrid.Sheets(0).Cells(FpVoucherGrid.Sheets(0).ActiveRowIndex, 0, FpVoucherGrid.Sheets(0).ActiveRowIndex, FpVoucherGrid.Sheets(0).ColumnCount - 1).Tag = String.Empty
        End Sub
        Private Sub MnuInsertRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuInsertRow.Click
            FpVoucherGrid.Sheets(0).Rows.Add(FpVoucherGrid.Sheets(0).ActiveRowIndex, 1)
        End Sub

        Private Sub JournalVoucher_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
            If e.Button = Windows.Forms.MouseButtons.Right Then
                Me.ContextMenu = Nothing
            End If
        End Sub
        Private Sub dtpDate_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDate.Validated
            ErrProvider.SetError(TxtDate, String.Empty)
        End Sub
        Public Sub dtpDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtDate.Validating
            Try
                Dim DateError As String
                DateError = ValidateTransactionDate(TxtDate.Value, Me.Tag)
                If DateError <> String.Empty Then
                    ErrProvider.SetError(TxtDate, DateError)
                    e.Cancel = True
                    Exit Sub
                End If
                'If txtTransactionNumber.Text <> String.Empty Then
                If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                    txtTransactionNumber.Text = String.Empty
                    KeyGeneration()
                Else
                    If DateSerial(TxtDate.Value.Year, TxtDate.Value.Month, 1) <> DateSerial("20" & Mid(txtTransactionNumber.Text, 1, 2), Mid(txtTransactionNumber.Text, 3, 2), 1) Then
                        e.Cancel = True
                        ErrProvider.SetError(TxtDate, "You cannot change the Month Or Year for this Transaction Date..." & vbCrLf & "Please specify a valid Date within " & MonthName(Mid(txtTransactionNumber.Text, 3, 2)) & ", " & Year(DateSerial("20" & Mid(txtTransactionNumber.Text, 1, 2), 1, 1)))
                        Exit Sub
                    End If

                End If
                'End If
            Catch ex As System.ArgumentException
                e.Cancel = True
                ErrProvider.SetError(TxtDate, "You cannot change the Month Or Year for this Transaction Date..." & vbCrLf & "Please specify a valid Date within " & MonthName(Mid(txtTransactionNumber.Text, 3, 2)) & ", " & Year(DateSerial("20" & Mid(txtTransactionNumber.Text, 1, 2), 1, 1)))
            End Try

        End Sub
        Public Sub SetCreditDebitTotal(ByVal mode As AzamTechnologies.DataManager.DataMode)
        End Sub
        Private Sub CmdBranchList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If txtBranchCode.Enabled = False Then Exit Sub
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Branches")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.txtBranchCode.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
                Me.txtBranch.Text = frmser.UGSearch.Rows(iRow).Cells("BranchName").Value
                Me.txtBranchCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtBranchCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtBranchCode.EditorButtonClick
            If txtBranchCode.Enabled = False Then Exit Sub
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Branches")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.txtBranchCode.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
                Me.txtBranch.Text = frmser.UGSearch.Rows(iRow).Cells("BranchName").Value
                Me.txtBranchCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub txtBranchCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBranchCode.GotFocus
            If Me.txtBranchCode.Text = String.Empty Then
                Me.txtBranchCode.Text = My.Settings.DefaultBranchCode
            End If
        End Sub
        Private Sub txtBranchCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranchCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.txtBranchCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub


        'Public Shared Function FormatKeyYearMonthValue(ByVal DateForFormat As Date, ByVal KeyObjectText As String, ByVal maxTextLen As Integer) As String
        '    Dim a As New System.Text.StringBuilder
        '    Dim dateValue As String = Format(DateForFormat, "yy") & Format(DateForFormat, "MM")

        '    Dim strTemp As String
        '    KeyObjectText = "1"
        '    strTemp = a.Insert(0, "0", maxTextLen - KeyObjectText.Length).ToString
        '    a = New System.Text.StringBuilder(strTemp)
        '    strTemp = a.Replace("0000", dateValue, 0, 4).ToString
        '    a = New System.Text.StringBuilder(strTemp)
        '    strTemp = a.Insert(maxTextLen - KeyObjectText.Length, KeyObjectText, 1).ToString
        '    FormatKeyYearMonthValue = strTemp
        'End Function
        Private Sub FpVoucherGrid_EnterCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.EnterCellEventArgs) Handles FpVoucherGrid.EnterCell
            If e.Column = GridCols.GLCode Then
                CmbGlCode.ColumnEdit = 0
                CmbGlCode.DataColumn = 0
                FpVoucherGrid.Sheets(0).Cells(e.Row, e.Column, e.Row, e.Column).CellType = CmbGlCode
                CmbGlCode.ListWidth = 380
            ElseIf e.Column = GridCols.GLDescription Then
                CmbGlDesc.ColumnEdit = 1
                CmbGlDesc.DataColumn = 1

                FpVoucherGrid.Sheets(0).Cells(e.Row, e.Column, e.Row, e.Column).CellType = CmbGlDesc
                CmbGlDesc.ListWidth = 380
            ElseIf e.Column = GridCols.DivisionCode Then
                CmbDivCode.ColumnEdit = 0
                CmbDivCode.DataColumn = 0
                FpVoucherGrid.Sheets(0).Cells(e.Row, e.Column, e.Row, e.Column).CellType = CmbDivCode
                CmbDivCode.ListWidth = 380
            ElseIf e.Column = GridCols.Division Then
                CmbDivDesc.ColumnEdit = 1
                CmbDivDesc.DataColumn = 1
                FpVoucherGrid.Sheets(0).Cells(e.Row, e.Column, e.Row, e.Column).CellType = CmbDivDesc
                CmbDivDesc.ListWidth = 380
            End If
        End Sub
        Private Sub FpVoucherGrid_LeaveCell(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.LeaveCellEventArgs) Handles FpVoucherGrid.LeaveCell
            Me.Cursor = Cursors.WaitCursor
            ''''''''''''
            Dim ErrString As String = String.Empty
            ''''''''''''
            'SetComboToGrid(NewCol, NewRow)
            If LockGrid = False Then
                Select Case e.Column
                    Case GridCols.GLCode
                        validComboData(GridCols.GLCode, e.Row)
                    Case GridCols.GLDescription
                        validComboData(GridCols.GLDescription, e.Row)
                    Case GridCols.DivisionCode
                        validComboData(GridCols.DivisionCode, e.Row)
                    Case GridCols.Division
                        validComboData(GridCols.Division, e.Row)
                    Case GridCols.Debit
                        If Val(FpVoucherGrid.Sheets(0).GetText(e.Row, GridCols.Debit)) > 0 Then
                            FpVoucherGrid.Sheets(0).SetText(e.Row, GridCols.Credit, 0D)
                        End If
                    Case GridCols.Credit
                        If Val(FpVoucherGrid.Sheets(0).GetText(e.Row, GridCols.Credit)) > 0 Then
                            FpVoucherGrid.Sheets(0).SetText(e.Row, GridCols.Debit, 0D)
                        End If
                End Select
                LockGrid = True
                'If Trim(FpVoucherGrid.Sheets(0).GetText(GridCols.GLCode, e.row)) = "" And Trim(FpVoucherGrid.Sheets(0).GetText(GridCols.PONo, Row)) = "" Then
                If Trim(FpVoucherGrid.Sheets(0).GetText(e.Row, GridCols.GLCode)) = "" Then

                    FpVoucherGrid.Sheets(0).SetText(e.Row, GridCols.VoucherNature, String.Empty)
                    FpVoucherGrid.Sheets(0).SetText(e.Row, GridCols.VoucherNumber, String.Empty)
                    FpVoucherGrid.Sheets(0).SetText(e.Row, GridCols.BranchCode, String.Empty)

                    FpVoucherGrid.Sheets(0).SetTag(e.Row, GridCols.BranchCode, String.Empty)
                    FpVoucherGrid.Sheets(0).SetTag(e.Row, GridCols.VoucherNumber, String.Empty)
                    FpVoucherGrid.Sheets(0).SetTag(e.Row, GridCols.VoucherNature, String.Empty)

                    FpVoucherGrid.Sheets(0).SetText(e.Row, GridCols.GLCode, String.Empty)
                    FpVoucherGrid.Sheets(0).SetText(e.Row, GridCols.GLDescription, String.Empty)


                Else
                    FpVoucherGrid.Sheets(0).SetText(e.Row, GridCols.VoucherNumber, txtTransactionNumber.Text)
                    FpVoucherGrid.Sheets(0).SetText(e.Row, GridCols.VoucherNature, NATURE.Text)
                    FpVoucherGrid.Sheets(0).SetText(e.Row, GridCols.BranchCode, txtBranchCode.Text)

                    FpVoucherGrid.Sheets(0).SetTag(e.Row, GridCols.BranchCode, "BranchCode")
                    FpVoucherGrid.Sheets(0).SetTag(e.Row, GridCols.VoucherNumber, "TransactionNo")
                    FpVoucherGrid.Sheets(0).SetTag(e.Row, GridCols.VoucherNature, "TransactionNature")


                    If Val(FpVoucherGrid.Sheets(0).GetText(e.Row, GridCols.Debit)) = 0 Then
                        FpVoucherGrid.Sheets(0).SetText(e.Row, GridCols.Debit, 0D)
                    End If
                    If Val(FpVoucherGrid.Sheets(0).GetText(e.Row, GridCols.Credit)) = 0 Then
                        FpVoucherGrid.Sheets(0).SetText(e.Row, GridCols.Credit, 0D)
                    End If
                    If e.NewRow = FpVoucherGrid.Sheets(0).RowCount - 1 Then
                        FpVoucherGrid_Sheet1.AddRows(FpVoucherGrid.Sheets(0).RowCount, 1)
                    End If
                End If
                LockGrid = False
            End If
            If LockGrid = False Then
                LockGrid = True
                ' Call VoucherGrid_ButtonClicked(Col, e.row, 0)
                LockGrid = False
            End If
            Me.Cursor = Cursors.Default
        End Sub
        Private Function validComboData(ByVal Col As GridCols, ByVal row As Int16) As Boolean
            If Col = GridCols.GLCode Then
                If Trim(FpVoucherGrid.Sheets(0).GetText(row, GridCols.GLCode)) <> "" Then
                    Dim dv As New DataView
                    dv.Table = DsGLs.Tables(0)
                    dv.RowFilter = "GLCode='" & Trim(FpVoucherGrid.Sheets(0).GetText(row, GridCols.GLCode)) & "'"

                    If dv.Count <> 0 Then
                        FpVoucherGrid.Sheets(0).SetText(row, GridCols.GLDescription, dv.Item(0).Item("GLDescription"))
                        Return True
                    Else
                        MessageBox.Show("Selected GLCode is not valid." & vbCrLf & "Please Enter an valide Item Code", "Item Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        FpVoucherGrid.Sheets(0).SetText(row, GridCols.GLCode, String.Empty)
                        FpVoucherGrid.Sheets(0).SetText(row, GridCols.GLDescription, String.Empty)
                        Return False
                    End If
                Else
                    Return True
                End If
            ElseIf Col = GridCols.GLDescription Then
                If Trim(FpVoucherGrid.Sheets(0).GetText(row, GridCols.GLDescription)) <> "" Then
                    Dim dv As New DataView
                    dv.Table = DsGLs.Tables(0)
                    dv.RowFilter = "GLDescription='" & Trim(FpVoucherGrid.Sheets(0).GetText(row, GridCols.GLDescription)) & "'"

                    If dv.Count <> 0 Then
                        FpVoucherGrid.Sheets(0).SetText(row, GridCols.GLCode, dv.Item(0).Item("GLCode"))
                        Return True
                    Else
                        MessageBox.Show("Selected Item is not valid." & vbCrLf & "Please Enter an valide Item Code", "Item Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        FpVoucherGrid.Sheets(0).SetText(row, GridCols.GLCode, String.Empty)
                        FpVoucherGrid.Sheets(0).SetText(row, GridCols.GLDescription, String.Empty)
                        Return False
                    End If
                Else
                    Return True
                End If

            ElseIf Col = GridCols.DivisionCode Then
                If Trim(FpVoucherGrid.Sheets(0).GetText(row, GridCols.DivisionCode)) <> "" Then
                    Dim dv As New DataView
                    dv.Table = DsDiv.Tables(0)
                    dv.RowFilter = "DivisionCode='" & Trim(FpVoucherGrid.Sheets(0).GetText(row, GridCols.DivisionCode)) & "'"

                    If dv.Count <> 0 Then
                        FpVoucherGrid.Sheets(0).SetText(row, GridCols.Division, dv.Item(0).Item("Division"))
                        Return True
                    Else
                        MessageBox.Show("Selected Division Code is not valid." & vbCrLf & "Please Enter an valide Division Code", "Division Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        FpVoucherGrid.Sheets(0).SetText(row, GridCols.DivisionCode, String.Empty)
                        FpVoucherGrid.Sheets(0).SetText(row, GridCols.Division, String.Empty)
                        Return False
                    End If
                Else
                    Return True
                End If
            ElseIf Col = GridCols.Division Then
                If Trim(FpVoucherGrid.Sheets(0).GetText(row, GridCols.Division)) <> "" Then
                    Dim dv As New DataView
                    dv.Table = DsDiv.Tables(0)
                    dv.RowFilter = "Division='" & Trim(FpVoucherGrid.Sheets(0).GetText(row, GridCols.Division)) & "'"

                    If dv.Count <> 0 Then
                        FpVoucherGrid.Sheets(0).SetText(row, GridCols.DivisionCode, dv.Item(0).Item("DivisionCode"))
                        Return True
                    Else
                        MessageBox.Show("Selected Division  is not valid." & vbCrLf & "Please Enter an valide Division ", "Division Validation", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        FpVoucherGrid.Sheets(0).SetText(row, GridCols.DivisionCode, String.Empty)
                        FpVoucherGrid.Sheets(0).SetText(row, GridCols.Division, String.Empty)
                        Return False
                    End If
                Else
                    Return True
                End If
            End If

        End Function
        Private Sub FpVoucherGrid_SubEditorOpening(ByVal sender As Object, ByVal e As FarPoint.Win.Spread.SubEditorOpeningEventArgs) Handles FpVoucherGrid.SubEditorOpening
            If e.SubEditor.ToString = "a7" Then 'multiple combo box
                Dim ss As FarPoint.Win.Spread.FpSpread
                ss = CType(e.SubEditor, FarPoint.Win.Spread.FpSpread)
                ss.Skin = FpVoucherGrid.Skin
                ss.BorderStyle = BorderStyle.FixedSingle
                'ss.Sheets(0).Columns(0).AllowAutoSort = True
                'ss.Sheets(0).Columns(1).AllowAutoSort = True
                If ss.Sheets(0).Columns.Count = 2 Then
                    ss.Sheets(0).Columns(1).Width = 230
                    ' ss.Sheets(0).Columns(1).AutoSortIndex = 1
                ElseIf ss.Sheets(0).Columns.Count = 3 Then
                    ss.Sheets(0).Columns(1).Width = 160
                    ss.Sheets(0).Columns(2).Width = 160
                End If

                If e.Column = GridCols.GLCode Then
                    '''''SORT FALSE AND THEN SORT TRUE 
                    ss.Sheets(0).SetColumnAllowAutoSort(0, False)
                    ss.Sheets(0).SetColumnShowSortIndicator(0, False)
                    ss.Sheets(0).AutoSortColumn(1)
                    ''''''''''''''''''''''''''''''''

                    ss.Sheets(0).SetColumnAllowAutoSort(1, False)
                    ss.Sheets(0).SetColumnAllowAutoSort(0, True)
                    ss.Sheets(0).SetColumnShowSortIndicator(0, True)
                    ss.Sheets(0).AutoSortColumn(0)
                ElseIf e.Column = GridCols.GLDescription Then
                    '''''SORT FALSE AND THEN SORT TRUE 
                    ss.Sheets(0).SetColumnAllowAutoSort(1, False)
                    ss.Sheets(0).SetColumnShowSortIndicator(1, False)
                    ss.Sheets(0).AutoSortColumn(0)
                    ''''''''''''''''''''''''''''''''

                    ss.Sheets(0).SetColumnAllowAutoSort(0, False)
                    ss.Sheets(0).SetColumnAllowAutoSort(1, True)
                    ss.Sheets(0).SetColumnShowSortIndicator(1, True)
                    ss.Sheets(0).AutoSortColumn(1)

                End If
            End If
        End Sub

        Private Sub BtnLst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            If txtTransactionNumber.Enabled = False Then Exit Sub
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Vouchers", "OPTION", "ALL", "TransactionNature", NATURE.Text)
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.txtBranchCode.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
                Me.txtTransactionNumber.Text = frmser.UGSearch.Rows(iRow).Cells("TransactionNo").Value
                Me.txtTransactionNumber.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub KeyGeneration()
            If txtTransactionNumber.Text = String.Empty Then
                If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                    Dim objAcc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    If Me.txtBranchCode.Text = String.Empty Then
                        Me.txtBranchCode.Text = My.Settings.DefaultBranchCode
                    End If
                    Reader = objAcc.GetRecord("Select" & Me.AccessibleName, "Option", "AUTO", "TransactionNature", Me.NATURE.Text, "YearMonth", Format(TxtDate.Value, "yy") & Format(TxtDate.Value, "MM"), "BranchCode", txtBranchCode.Text)
                    'Auto increment the primary key field when we Add the 
                    ' AccessibleDescription Properties of the Control set to "AUTO"
                    If Reader.HasRows Then
                        While Reader.Read
                            txtTransactionNumber.Text = Reader.Item("TransactionNo")
                            txtTransactionNumber.Text = Integer.Parse(txtTransactionNumber.Text) + 1
                            If Mid(txtTransactionNumber.Text.Insert(0, "0"), 1, 2) = "09" Then
                                txtTransactionNumber.Text = txtTransactionNumber.Text.Insert(0, "0")
                                ' chCtr.Text = mManager.FormateData.FormatKeyYearMonthValue(chCtr.Text, CType(chCtr, TextBox).MaxLength)
                            End If
                            ' chCtr.Text = mManager.FormateData.FormatKeyYearMonthValue(chCtr.Text, CType(chCtr, TextBox).MaxLength)
                        End While
                    Else
                        txtTransactionNumber.Text = FormatKeyYearMonthValue(TxtDate.Value, txtTransactionNumber.Text, CType(txtTransactionNumber, Infragistics.Win.UltraWinEditors.UltraTextEditor).MaxLength)
                    End If
                End If
            End If
        End Sub

        Private Sub txtBranchCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBranchCode.Validated
            ErrProvider.SetError(txtBranchCode, String.Empty)
        End Sub

        Private Sub txtBranchCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtBranchCode.Validating
            Try
                If txtBranchCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectBranches", "BranchCode ", Trim(txtBranchCode.Text))
                    If Reader.HasRows = False Then
                        ErrProvider.SetError(txtBranchCode, "Invalid Branch Code")
                        ErrProvider.SetIconAlignment(txtBranchCode, ErrorIconAlignment.TopLeft)
                        txtBranchCode.Text = String.Empty
                        txtBranch.Text = String.Empty
                        e.Cancel = True
                    Else
                        If Me.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.Tag = AzamTechnologies.DataManager.DataMode.Inserting Then
                            txtTransactionNumber.Text = String.Empty
                            KeyGeneration()
                        End If
                        Reader.Read()
                        ErrProvider.SetError(txtBranchCode, String.Empty)
                        txtBranch.Text = Reader.Item("BranchName")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub txtBranchCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBranchCode.ValueChanged

        End Sub

        Private Sub TxtDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDate.ValueChanged

        End Sub

        Private Sub txtTransactionNumber_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtTransactionNumber.EditorButtonClick
            If txtTransactionNumber.Enabled = False Then Exit Sub
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Vouchers", "OPTION", "ALL", "TransactionNature", NATURE.Text)
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.txtBranchCode.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
                Me.txtTransactionNumber.Text = frmser.UGSearch.Rows(iRow).Cells("TransactionNo").Value
                Me.txtTransactionNumber.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtTransactionNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTransactionNumber.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.txtTransactionNumber_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

    End Class
End Namespace