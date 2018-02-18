Namespace GeneralLedger
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
            Partial Class VehicleAdjustments
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim BevelBorder1 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType1 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType2 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType3 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType4 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType6 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim CurrencyCellType1 As FarPoint.Win.Spread.CellType.CurrencyCellType = New FarPoint.Win.Spread.CellType.CurrencyCellType()
        Dim TextCellType7 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim TextCellType8 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VehicleAdjustments))
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.txtBranchCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.FpVehicleAdjustmentGrid = New FarPoint.Win.Spread.FpSpread()
        Me.mnuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MnuInsertRow = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuDeleteRow = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuClearGrid = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuExportToExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.FpVehicleAdjustmentGrid_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBranch = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.ATUrduTitle = New ATUrduTextBox.UrduTextBox()
        Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTransactionNumber = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.NATURE = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCheque = New System.Windows.Forms.Label()
        Me.TxtChequeNo = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.CmbMode = New Infragistics.Win.UltraWinEditors.UltraComboEditor()
        Me.TxtVehicle = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtVehicleCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        CType(Me.txtBranchCode,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.FpVehicleAdjustmentGrid,System.ComponentModel.ISupportInitialize).BeginInit
        Me.mnuGrid.SuspendLayout
        CType(Me.FpVehicleAdjustmentGrid_Sheet1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtBranch,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ATUrduTitle,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ErrProvider,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtTransactionNumber,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.NATURE,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Desc,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtChequeNo,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CmbMode,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtVehicle,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.TxtVehicleCode,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'txtBranchCode
        '
        Me.txtBranchCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Me.txtBranchCode.Appearance = Appearance1
        Me.txtBranchCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtBranchCode.Location = New System.Drawing.Point(201, 81)
            Me.txtBranchCode.MaxLength = 2
            Me.txtBranchCode.Name = "txtBranchCode"
            Me.txtBranchCode.Size = New System.Drawing.Size(133, 21)
            Me.txtBranchCode.TabIndex = 0
            Me.txtBranchCode.Tag = "PK.BranchCode"
            '
            'FpVehicleAdjustmentGrid
            '
            Me.FpVehicleAdjustmentGrid.AccessibleDescription = "FpVehicleAdjustmentGrid, Sheet1, Row 0, Column 0, "
            Me.FpVehicleAdjustmentGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.FpVehicleAdjustmentGrid.BackColor = System.Drawing.SystemColors.Control
            Me.FpVehicleAdjustmentGrid.ContextMenuStrip = Me.mnuGrid
            Me.FpVehicleAdjustmentGrid.EditModeReplace = True
            Me.FpVehicleAdjustmentGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.FpVehicleAdjustmentGrid.Location = New System.Drawing.Point(90, 262)
            Me.FpVehicleAdjustmentGrid.Name = "FpVehicleAdjustmentGrid"
            Me.FpVehicleAdjustmentGrid.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.FpVehicleAdjustmentGrid.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.FpVehicleAdjustmentGrid_Sheet1})
            Me.FpVehicleAdjustmentGrid.Size = New System.Drawing.Size(913, 379)
            Me.FpVehicleAdjustmentGrid.TabIndex = 8
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
            'FpVehicleAdjustmentGrid_Sheet1
            '
            Me.FpVehicleAdjustmentGrid_Sheet1.Reset()
            Me.FpVehicleAdjustmentGrid_Sheet1.SheetName = "Sheet1"
            'Formulas and custom names must be loaded with R1C1 reference style
            Me.FpVehicleAdjustmentGrid_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
            FpVehicleAdjustmentGrid_Sheet1.ColumnCount = 10
            FpVehicleAdjustmentGrid_Sheet1.RowCount = 10
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnFooter.DefaultStyle.Border = BevelBorder1
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnFooter.DefaultStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnFooter.DefaultStyle.Parent = "ColumnFooterEnhanced"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnFooter.Rows.Get(0).Height = 37.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnFooter.Visible = True
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "BranchCode"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "TransactionNature"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "TransactionNo"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "TypeCode"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "Type"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "UrduDescription"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "Description"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 7).Value = "Amount"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 8).Value = "GLCode"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Cells.Get(0, 9).Value = "GLDescription"
            Me.FpVehicleAdjustmentGrid_Sheet1.ColumnHeader.Rows.Get(0).Height = 19.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(0).CellType = TextCellType1
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(0).Label = "BranchCode"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(0).Visible = False
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(1).CellType = TextCellType2
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(1).Label = "TransactionNature"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(1).Visible = False
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(2).CellType = TextCellType3
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(2).Label = "TransactionNo"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(2).Visible = False
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(3).CellType = TextCellType4
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.General
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(3).Label = "TypeCode"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(3).Width = 56.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(4).CellType = TextCellType5
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(4).Label = "Type"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(4).Width = 176.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(5).CellType = TextCellType6
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(5).Label = "UrduDescription"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(5).Width = 120.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(6).Label = "Description"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(6).Width = 218.0!
            CurrencyCellType1.DecimalPlaces = 2
            CurrencyCellType1.MaximumValue = New Decimal(New Integer() {-727379969, 232, 0, 131072})
            CurrencyCellType1.MinimumValue = New Decimal(New Integer() {0, 0, 0, 0})
            CurrencyCellType1.Separator = ","
            CurrencyCellType1.ShowCurrencySymbol = False
            CurrencyCellType1.ShowSeparator = True
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(7).CellType = CurrencyCellType1
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(7).Label = "Amount"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(7).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(7).Width = 88.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(8).CellType = TextCellType7
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(8).Label = "GLCode"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(8).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(8).Width = 123.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(9).CellType = TextCellType8
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(9).Label = "GLDescription"
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(9).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Bottom
            Me.FpVehicleAdjustmentGrid_Sheet1.Columns.Get(9).Width = 194.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
            Me.FpVehicleAdjustmentGrid_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
            Me.FpVehicleAdjustmentGrid_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
            Me.FpVehicleAdjustmentGrid_Sheet1.RowHeader.Columns.Default.Resizable = False
            Me.FpVehicleAdjustmentGrid_Sheet1.RowHeader.Columns.Get(0).Width = 26.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(0).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(1).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(2).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(3).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(4).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(5).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(6).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(7).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(8).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Rows.Get(9).Height = 21.0!
            Me.FpVehicleAdjustmentGrid_Sheet1.Tag = "VehicleAdjustmentsDetails"
            Me.FpVehicleAdjustmentGrid_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
            Me.Label4.ForeColor = System.Drawing.Color.Navy
            Me.Label4.Location = New System.Drawing.Point(699, 173)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(54, 47)
            Me.Label4.TabIndex = 132
            Me.Label4.Text = "تفصیل"
            '
            'txtBranch
            '
            Me.txtBranch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranch.Appearance = Appearance2
            Me.txtBranch.BackColor = System.Drawing.SystemColors.Window
            Me.txtBranch.Location = New System.Drawing.Point(334, 81)
            Me.txtBranch.Name = "txtBranch"
            Me.txtBranch.Size = New System.Drawing.Size(658, 21)
            Me.txtBranch.TabIndex = 126
            Me.txtBranch.TabStop = False
            Me.txtBranch.Tag = "IM.BranchName"
            '
            'ATUrduTitle
            '
            Me.ATUrduTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
            Me.ATUrduTitle.Location = New System.Drawing.Point(479, 173)
            Me.ATUrduTitle.Multiline = True
            Me.ATUrduTitle.Name = "ATUrduTitle"
            Me.ATUrduTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.ATUrduTitle.Size = New System.Drawing.Size(214, 56)
            Me.ATUrduTitle.TabIndex = 5
            Me.ATUrduTitle.Tag = "dd.UrduTitle"
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
            Me.Label3.Location = New System.Drawing.Point(87, 84)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(95, 20)
            Me.Label3.TabIndex = 131
            Me.Label3.Text = "Branch Code"
            '
            'txtTransactionNumber
            '
            Me.txtTransactionNumber.AcceptsReturn = True
            Me.txtTransactionNumber.Location = New System.Drawing.Point(201, 104)
            Me.txtTransactionNumber.MaxLength = 10
            Me.txtTransactionNumber.Name = "txtTransactionNumber"
            Me.txtTransactionNumber.Size = New System.Drawing.Size(133, 21)
            Me.txtTransactionNumber.TabIndex = 1
            Me.txtTransactionNumber.Tag = "PK.TransactionNo"
            '
            'NATURE
            '
            Me.NATURE.Location = New System.Drawing.Point(506, 55)
            Me.NATURE.Name = "NATURE"
            Me.NATURE.ReadOnly = True
            Me.NATURE.Size = New System.Drawing.Size(128, 21)
            Me.NATURE.TabIndex = 130
            Me.NATURE.TabStop = False
            Me.NATURE.Tag = "PK.TransactionNature"
            Me.NATURE.Visible = False
            '
            'Desc
            '
            Me.Desc.Location = New System.Drawing.Point(201, 172)
            Me.Desc.Multiline = True
            Me.Desc.Name = "Desc"
            Me.Desc.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
            Me.Desc.Size = New System.Drawing.Size(272, 56)
            Me.Desc.TabIndex = 4
            Me.Desc.Tag = "ds.Description"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(87, 173)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 129
            Me.Label2.Text = "Description"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(87, 108)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(83, 20)
            Me.Label1.TabIndex = 128
            Me.Label1.Text = "Document No"
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.Transparent
            Me.Label9.ForeColor = System.Drawing.Color.Navy
            Me.Label9.Location = New System.Drawing.Point(87, 153)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(110, 20)
            Me.Label9.TabIndex = 127
            Me.Label9.Text = "Document Date"
            '
            'TxtDate
            '
            Me.TxtDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
            Me.TxtDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
            Me.TxtDate.CustomFormat = "dd-MMM-yyyy"
            Me.TxtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.TxtDate.Location = New System.Drawing.Point(201, 150)
            Me.TxtDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.TxtDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.TxtDate.Name = "TxtDate"
            Me.TxtDate.Size = New System.Drawing.Size(133, 20)
            Me.TxtDate.TabIndex = 3
            Me.TxtDate.Tag = "dt.TransactionDate"
            '
            'lblCheque
            '
            Me.lblCheque.BackColor = System.Drawing.Color.Transparent
            Me.lblCheque.ForeColor = System.Drawing.Color.Navy
            Me.lblCheque.Location = New System.Drawing.Point(336, 234)
            Me.lblCheque.Name = "lblCheque"
            Me.lblCheque.Size = New System.Drawing.Size(61, 14)
            Me.lblCheque.TabIndex = 137
            Me.lblCheque.Text = "Cheque No"
            '
            'TxtChequeNo
            '
            Me.TxtChequeNo.AcceptsReturn = True
            Me.TxtChequeNo.Location = New System.Drawing.Point(400, 230)
            Me.TxtChequeNo.MaxLength = 10
            Me.TxtChequeNo.Name = "TxtChequeNo"
            Me.TxtChequeNo.Size = New System.Drawing.Size(122, 21)
            Me.TxtChequeNo.TabIndex = 7
            Me.TxtChequeNo.Tag = "DD.ChequeNo"
            '
            'lblMode
            '
            Me.lblMode.BackColor = System.Drawing.Color.Transparent
            Me.lblMode.ForeColor = System.Drawing.Color.Navy
            Me.lblMode.Location = New System.Drawing.Point(87, 235)
            Me.lblMode.Name = "lblMode"
            Me.lblMode.Size = New System.Drawing.Size(40, 20)
            Me.lblMode.TabIndex = 139
            Me.lblMode.Text = "Mode"
            '
            'CmbMode
            '
            ValueListItem1.DataValue = "Cash"
            ValueListItem1.DisplayText = "Cash"
            ValueListItem2.DataValue = "Cheque"
            ValueListItem2.DisplayText = "Cheque"
            Me.CmbMode.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem1, ValueListItem2})
            Me.CmbMode.Location = New System.Drawing.Point(201, 230)
            Me.CmbMode.MRUList = New Object() {CType("ValueListItem0", Object), CType("ValueListItem1", Object)}
            Me.CmbMode.Name = "CmbMode"
            Me.CmbMode.Nullable = False
            Me.CmbMode.NullText = "Cash"
            Me.CmbMode.Size = New System.Drawing.Size(122, 21)
            Me.CmbMode.TabIndex = 6
            Me.CmbMode.TabStop = False
            Me.CmbMode.Tag = "dd.Mode"
            Me.CmbMode.Text = "Cash"
            '
            'TxtVehicle
            '
            Me.TxtVehicle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance3.BackColor = System.Drawing.SystemColors.Window
            Me.TxtVehicle.Appearance = Appearance3
            Me.TxtVehicle.BackColor = System.Drawing.SystemColors.Window
            Me.TxtVehicle.Location = New System.Drawing.Point(334, 127)
            Me.TxtVehicle.Name = "TxtVehicle"
            Me.TxtVehicle.Size = New System.Drawing.Size(658, 21)
            Me.TxtVehicle.TabIndex = 142
            Me.TxtVehicle.TabStop = False
            Me.TxtVehicle.Tag = "dd.VehicleDescription"
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.Transparent
            Me.Label10.ForeColor = System.Drawing.Color.Navy
            Me.Label10.Location = New System.Drawing.Point(87, 132)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(110, 20)
            Me.Label10.TabIndex = 143
            Me.Label10.Text = "Vehicle "
            '
            'TxtVehicleCode
            '
            Me.TxtVehicleCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance4.BackColor = System.Drawing.SystemColors.Window
            Me.TxtVehicleCode.Appearance = Appearance4
            Me.TxtVehicleCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtVehicleCode.Location = New System.Drawing.Point(201, 127)
            Me.TxtVehicleCode.MaxLength = 8
            Me.TxtVehicleCode.Name = "TxtVehicleCode"
            Me.TxtVehicleCode.Size = New System.Drawing.Size(133, 21)
        Me.TxtVehicleCode.TabIndex = 2
        Me.TxtVehicleCode.Tag = "FK.VehicleCode"
        '
        'VehicleAdjustments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.TxtVehicle)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtVehicleCode)
        Me.Controls.Add(Me.txtBranchCode)
        Me.Controls.Add(Me.CmbMode)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.FpVehicleAdjustmentGrid)
        Me.Controls.Add(Me.TxtChequeNo)
        Me.Controls.Add(Me.txtBranch)
        Me.Controls.Add(Me.lblCheque)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ATUrduTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTransactionNumber)
        Me.Controls.Add(Me.NATURE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Desc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtDate)
        Me.KeyPreview = true
        Me.Name = "VehicleAdjustments"
        Me.Text = "VehicleAdjustment"
        CType(Me.txtBranchCode,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.FpVehicleAdjustmentGrid,System.ComponentModel.ISupportInitialize).EndInit
        Me.mnuGrid.ResumeLayout(false)
        CType(Me.FpVehicleAdjustmentGrid_Sheet1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtBranch,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ATUrduTitle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ErrProvider,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtTransactionNumber,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.NATURE,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Desc,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtChequeNo,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CmbMode,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtVehicle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TxtVehicleCode,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
        Friend WithEvents txtBranchCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents FpVehicleAdjustmentGrid As FarPoint.Win.Spread.FpSpread
        Friend WithEvents mnuGrid As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents MnuInsertRow As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MnuDeleteRow As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MnuClearGrid As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents MnuExportToExcel As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents FpVehicleAdjustmentGrid_Sheet1 As FarPoint.Win.Spread.SheetView
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents txtBranch As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents ATUrduTitle As ATUrduTextBox.UrduTextBox
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtTransactionNumber As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Public WithEvents NATURE As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents TxtDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents CmbMode As Infragistics.Win.UltraWinEditors.UltraComboEditor
        Friend WithEvents lblMode As System.Windows.Forms.Label
        Friend WithEvents TxtChequeNo As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents lblCheque As System.Windows.Forms.Label
        Friend WithEvents TxtVehicle As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents TxtVehicleCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    End Class
End Namespace
