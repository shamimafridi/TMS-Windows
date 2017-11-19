Imports Infragistics.Win

Public Class FrmSearch
    Inherits System.Windows.Forms.Form
    Friend SearchedTable As DataTable
    Friend RowPosition As Long
    Public txtPK As TextBox
    Friend WithEvents UGSearch As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents imgList1 As System.Windows.Forms.ImageList
    Friend WithEvents BtnColumnChooser As System.Windows.Forms.Button
    Friend WithEvents BtnExcelExporter As System.Windows.Forms.Button
    Public txtPK1 As DateTimePicker
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        Bsource = New BindingSource
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'CType(Me.DataGridFilterExtender1.FilterFactory, AzamTechnologies.ATGridViewFilter.GridFilterFactories.DefaultGridFilterFactory).CreateDistinctGridFilters = True
        UGSearch.DataSource = Bsource
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
    Friend Bsource As BindingSource
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSearch))
        Me.UGSearch = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.imgList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnColumnChooser = New System.Windows.Forms.Button
        Me.BtnExcelExporter = New System.Windows.Forms.Button
        CType(Me.UGSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UGSearch
        '
        Me.UGSearch.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.UGSearch.DisplayLayout.Override.AllowRowSummaries = Infragistics.Win.UltraWinGrid.AllowRowSummaries.[True]
        Me.UGSearch.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow
        Me.UGSearch.DisplayLayout.Override.FixedRowIndicator = Infragistics.Win.UltraWinGrid.FixedRowIndicator.Button
        Me.UGSearch.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UGSearch.DisplayLayout.Override.MergedCellStyle = Infragistics.Win.UltraWinGrid.MergedCellStyle.OnlyWhenSorted
        Me.UGSearch.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.UGSearch.DisplayLayout.UseFixedHeaders = True
        Me.UGSearch.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UGSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UGSearch.Location = New System.Drawing.Point(0, 0)
        Me.UGSearch.Name = "UGSearch"
        Me.UGSearch.Size = New System.Drawing.Size(690, 408)
        Me.UGSearch.TabIndex = 3
        '
        'imgList1
        '
        Me.imgList1.ImageStream = CType(resources.GetObject("imgList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList1.Images.SetKeyName(0, "")
        Me.imgList1.Images.SetKeyName(1, "")
        Me.imgList1.Images.SetKeyName(2, "")
        Me.imgList1.Images.SetKeyName(3, "")
        Me.imgList1.Images.SetKeyName(4, "")
        Me.imgList1.Images.SetKeyName(5, "")
        Me.imgList1.Images.SetKeyName(6, "")
        Me.imgList1.Images.SetKeyName(7, "")
        Me.imgList1.Images.SetKeyName(8, "")
        Me.imgList1.Images.SetKeyName(9, "")
        Me.imgList1.Images.SetKeyName(10, "")
        Me.imgList1.Images.SetKeyName(11, "")
        Me.imgList1.Images.SetKeyName(12, "")
        Me.imgList1.Images.SetKeyName(13, "")
        Me.imgList1.Images.SetKeyName(14, "")
        Me.imgList1.Images.SetKeyName(15, "")
        Me.imgList1.Images.SetKeyName(16, "")
        Me.imgList1.Images.SetKeyName(17, "")
        Me.imgList1.Images.SetKeyName(18, "")
        Me.imgList1.Images.SetKeyName(19, "")
        Me.imgList1.Images.SetKeyName(20, "")
        Me.imgList1.Images.SetKeyName(21, "")
        Me.imgList1.Images.SetKeyName(22, "")
        Me.imgList1.Images.SetKeyName(23, "Excel.ico")
        Me.imgList1.Images.SetKeyName(24, "Excel1.ico")
        '
        'BtnColumnChooser
        '
        Me.BtnColumnChooser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnColumnChooser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnColumnChooser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnColumnChooser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnColumnChooser.ImageIndex = 22
        Me.BtnColumnChooser.ImageList = Me.imgList1
        Me.BtnColumnChooser.Location = New System.Drawing.Point(627, 0)
        Me.BtnColumnChooser.Name = "BtnColumnChooser"
        Me.BtnColumnChooser.Size = New System.Drawing.Size(33, 30)
        Me.BtnColumnChooser.TabIndex = 6
        Me.BtnColumnChooser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnColumnChooser.UseVisualStyleBackColor = True
        '
        'BtnExcelExporter
        '
        Me.BtnExcelExporter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcelExporter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExcelExporter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExcelExporter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcelExporter.ImageKey = "Excel1.ico"
        Me.BtnExcelExporter.ImageList = Me.imgList1
        Me.BtnExcelExporter.Location = New System.Drawing.Point(657, 0)
        Me.BtnExcelExporter.Name = "BtnExcelExporter"
        Me.BtnExcelExporter.Size = New System.Drawing.Size(33, 30)
        Me.BtnExcelExporter.TabIndex = 5
        Me.BtnExcelExporter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcelExporter.UseVisualStyleBackColor = True
        '
        'FrmSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(690, 408)
        Me.Controls.Add(Me.BtnColumnChooser)
        Me.Controls.Add(Me.BtnExcelExporter)
        Me.Controls.Add(Me.UGSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmSearch"
        CType(Me.UGSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Friend SearchParameter As SearchGridParamType = SearchGridParamType.SearchForParent
    Function FillSearchGridData(ByVal SearchingTable As String) As DataSet
        Dim Ds As DataSet = Nothing
        Try

            Dim Acc As New AzamTechnologies.Database.DataAccess
            If Me.SearchParameter = SearchGridParamType.SearchForParent Then
                Acc.PopulateDataSet(Ds, "Select" & SearchingTable, "OPTION", "SRHGRID")
            Else
                Acc.PopulateDataSet(Ds, "Select" & SearchingTable, "OPTION", "SRHGRIDFORCHILD")
            End If
            Return Ds
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Sub FillData(ByVal SearchingTable As String, ByVal ParamArray paramArr() As Object)
        Dim Ds As DataSet = Nothing
        Try
            Dim Acc As New AzamTechnologies.Database.DataAccess
            Acc.PopulateDataSet(Ds, "Select" & SearchingTable, paramArr)
            Me.Bsource.DataSource = Ds
            Me.Bsource.DataMember = Ds.Tables(0).TableName
            Me.UGSearch.DataSource = Bsource
            Acc = Nothing
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub FillData(ByVal TableLookFor As String)
        Try
            Dim ds As DataSet
            ds = FillSearchGridData(TableLookFor)
            SearchedTable = ds.Tables(0)
            Me.Bsource.DataSource = ds
            Me.Bsource.DataMember = ds.Tables(0).TableName
            Me.UGSearch.DataSource = Bsource
        Catch ex As Exception
            Throw New Exception("Please enter the correct table name or parameter for filling search grid")
        End Try
    End Sub
    Enum SearchGridParamType
        SearchForChild
        SearchForParent
    End Enum
    Private Sub FrmSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub TxtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Down Then
            Me.UGSearch.Focus()
        End If
    End Sub

    Private Sub UGSearch_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UGSearch.AfterRowActivate
        If UGSearch.ActiveRow Is UGSearch.Rows.FilterRow Then
            UGSearch.ActiveCell = UGSearch.Rows.FilterRow.Cells(0)
        End If
    End Sub
    Private Sub UGSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles UGSearch.DoubleClick
        Try
            UGSearch.Refresh()
            RowPosition = Bsource.Position
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub BtnExcelExporter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcelExporter.Click
        UltraGridExcelExporter1.Export(Me.UGSearch, "C:\Test.xls")
        Process.Start("C:\Test.xls")
    End Sub

    Private Sub BtnColumnChooser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnColumnChooser.Click
        Dim dlg As New Infragistics.Win.UltraWinGrid.ColumnChooserDialog
        ' Associate an ultra grid to the column chooser dialog.
        dlg.ColumnChooserControl.SourceGrid = Me.UGSearch
        ' Specify the band whose columns to display.
        dlg.ColumnChooserControl.CurrentBand = Me.UGSearch.DisplayLayout.Bands(0)
        dlg.ColumnChooserControl.ColumnDisplayOrder = Infragistics.Win.UltraWinGrid.ColumnDisplayOrder.SameAsGrid
        ' Set the MultipleBandSupport to SingleBandOnly to hide the band selector combo box.
        dlg.ColumnChooserControl.MultipleBandSupport = Infragistics.Win.UltraWinGrid.MultipleBandSupport.SingleBandOnly
        'Set the Owner of the dialog to the form that the UltraGrid is on.
        dlg.Owner = Me

        '// Finally show the dialog.
        dlg.Show()
    End Sub

    Private Sub FrmSearch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.UGSearch.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
        ' Enable updating on the root band. This will override the DisplayLayout setting
        Me.UGSearch.DisplayLayout.Bands(0).Override.AllowUpdate = DefaultableBoolean.False
    End Sub

    Private Sub UGSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UGSearch.KeyDown
        Const FirstRow As Int16 = 2
        If e.KeyCode = Keys.Enter Then
            If UGSearch.ActiveRow Is UGSearch.Rows.FilterRow Then

                UGSearch.ActiveRow = UGSearch.Rows.GetRowAtVisibleIndex(UGSearch.ActiveRow.ListIndex + FirstRow)
            Else
                UGSearch_DoubleClick(Me, New System.EventArgs)
            End If
        End If

    End Sub
End Class
