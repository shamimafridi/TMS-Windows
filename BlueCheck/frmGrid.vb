Imports BusinessLeaf.GeneralLedger
Imports Infragistics.Win

Public Class frmGrid
    Inherits System.Windows.Forms.Form
    Public strSelectDetailProc As String
    Public strMasterTable As String
    Public strTableNature As String
    Public strDetailTable As String
    Public strSelectMasterProc As String
    Public Manager As AzamTechnologies.DataManager
    Public Director As AzamTechnologies.DataDirector
    Public HasRelation As Boolean
    Private frm As Form
    Public dsData As DataSet
    Public dsDetail As DataSet
    Public ReportType As Long
    Public Enum LoadType
        Grid
        Catalog
        ReportToGrid
    End Enum
    Public Enum Catalog
        System
        Setup
        Transaction
        Management
        Security
    End Enum
    Public Enum SystemType
        Inventory
        GeneralLedger
        Payroll
        HR
    End Enum
    Public LoadingType As LoadType
    Public LoadingCatalogType As Catalog
    Friend WithEvents UGSearch As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents BtnExcelExporter As System.Windows.Forms.Button
    Friend WithEvents BtnColumnChooser As System.Windows.Forms.Button

    Public LoadingSystemType As SystemType
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        Bsource = New BindingSource
        InitializeComponent()
        'UGSearch.Sheets(0).DataSource = Bsource
        UGSearch.DataSource = Bsource
        'Add any initialization after the InitializeComponent() call
        Me.Text = strMasterTable
        UGSearch.Text = strMasterTable
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
    Friend WithEvents lstCatalog As System.Windows.Forms.ListView
    Friend WithEvents imgList1 As System.Windows.Forms.ImageList
    Friend Bsource As BindingSource
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrid))
        Me.lstCatalog = New System.Windows.Forms.ListView
        Me.imgList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.UGSearch = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.BtnExcelExporter = New System.Windows.Forms.Button
        Me.BtnColumnChooser = New System.Windows.Forms.Button
        CType(Me.UGSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstCatalog
        '
        Me.lstCatalog.LargeImageList = Me.imgList1
        Me.lstCatalog.Location = New System.Drawing.Point(-8, 32)
        Me.lstCatalog.Name = "lstCatalog"
        Me.lstCatalog.Size = New System.Drawing.Size(224, 232)
        Me.lstCatalog.SmallImageList = Me.imgList1
        Me.lstCatalog.TabIndex = 1
        Me.lstCatalog.UseCompatibleStateImageBehavior = False
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
        Me.UGSearch.Location = New System.Drawing.Point(1, -3)
        Me.UGSearch.Name = "UGSearch"
        Me.UGSearch.Size = New System.Drawing.Size(970, 396)
        Me.UGSearch.TabIndex = 2
        '
        'BtnExcelExporter
        '
        Me.BtnExcelExporter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExcelExporter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExcelExporter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExcelExporter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcelExporter.ImageKey = "Excel1.ico"
        Me.BtnExcelExporter.ImageList = Me.imgList1
        Me.BtnExcelExporter.Location = New System.Drawing.Point(938, -3)
        Me.BtnExcelExporter.Name = "BtnExcelExporter"
        Me.BtnExcelExporter.Size = New System.Drawing.Size(33, 30)
        Me.BtnExcelExporter.TabIndex = 3
        Me.BtnExcelExporter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExcelExporter.UseVisualStyleBackColor = True
        '
        'BtnColumnChooser
        '
        Me.BtnColumnChooser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnColumnChooser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnColumnChooser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnColumnChooser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnColumnChooser.ImageIndex = 22
        Me.BtnColumnChooser.ImageList = Me.imgList1
        Me.BtnColumnChooser.Location = New System.Drawing.Point(908, -3)
        Me.BtnColumnChooser.Name = "BtnColumnChooser"
        Me.BtnColumnChooser.Size = New System.Drawing.Size(33, 30)
        Me.BtnColumnChooser.TabIndex = 4
        Me.BtnColumnChooser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnColumnChooser.UseVisualStyleBackColor = True
        '
        'frmGrid
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(968, 397)
        Me.Controls.Add(Me.BtnColumnChooser)
        Me.Controls.Add(Me.BtnExcelExporter)
        Me.Controls.Add(Me.UGSearch)
        Me.Controls.Add(Me.lstCatalog)
        Me.Name = "frmGrid"
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UGSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SettingCatalog()

    End Sub
    Sub SettingCatalog()
        Dim Sys As String = String.Empty
        If LoadingSystemType = SystemType.Inventory Then
            Sys = "IN"
        ElseIf LoadingSystemType = SystemType.GeneralLedger Then
            Sys = "GL"
        ElseIf LoadingSystemType = SystemType.Payroll Then
            Sys = "PY"
        End If
        Try
            If LoadingType = LoadType.Grid Then
                UGSearch.Dock = DockStyle.Fill
                Bsource.DataSource = dsData
                Me.Text = dsData.Tables(0).TableName
                Bsource.DataMember = dsData.Tables(0).TableName
                lstCatalog.Visible = False
                lstCatalog.SendToBack()
            ElseIf LoadingType = LoadType.ReportToGrid Then
                UGSearch.Dock = DockStyle.Fill
                lstCatalog.SendToBack()
                lstCatalog.Visible = False
                Bsource.DataSource = dsData
                Me.Text = dsData.Tables(0).TableName
                Bsource.DataMember = dsData.Tables(0).TableName
            ElseIf LoadingType = LoadType.Catalog Then
                lstCatalog.Visible = True
                lstCatalog.BringToFront()
                lstCatalog.Dock = DockStyle.Fill
                'UGSearch.Sheets(0).Visible = False
                UGSearch.SendToBack()
                If LoadingCatalogType = Catalog.System Then
                ElseIf LoadingCatalogType = Catalog.Setup Then
                    If Not IsNothing(CreateChildeItems("SU", Sys)) Then
                        lstCatalog.Items.AddRange(CreateChildeItems("SU", Sys))
                    Else

                    End If
                ElseIf LoadingCatalogType = Catalog.Transaction Then
                    If Not IsNothing(CreateChildeItems("TR", Sys)) Then
                        lstCatalog.Items.AddRange(CreateChildeItems("TR", Sys))
                    ElseIf LoadingCatalogType = Catalog.Management Then

                    End If
                ElseIf LoadingCatalogType = Catalog.Management Then
                    If Not IsNothing(CreateChildeItems("TO", "AL")) Then
                        lstCatalog.Items.AddRange(CreateChildeItems("TO", "AL"))
                    Else

                    End If
                ElseIf LoadingCatalogType = Catalog.Security Then
                    If Not IsNothing(CreateChildeItems("SC", "AL")) Then
                        lstCatalog.Items.AddRange(CreateChildeItems("SC", "AL"))
                    Else
                    End If
                End If
            End If
            Me.UGSearch.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False

            ' Enable updating on the root band. This will override the DisplayLayout setting
            Me.UGSearch.DisplayLayout.Bands(0).Override.AllowUpdate = DefaultableBoolean.False
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub frmGrid_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        dsData = Nothing
        frm = Nothing
        If CType(Me.ParentForm, frmMain).MenuStrip1.Items(4).Visible = True Then
            CType(Me.ParentForm, frmMain).MenuStrip1.Items(4).Visible = False
        End If

    End Sub
    Dim back As Boolean
#Region "List View Region"
    Const SetupTableName As String = "ProjectNodesSetup"
    Const SetupFileName As String = "ProjectNodesSetup.Xml"
    Private Const NodesSelectionQuery As String = "Select * from ProjectNodesSetup  Order By SortingOrder for XML Auto"
    Private Function CreateChildeItems(ByVal NodeType As String, ByVal SystemType As String) As ListViewItem()
        ''''''''''''''''''''''''''''''''''''''''''''''
        'PURPOSE::Reading Nodes from xml files and create the nodes of tree view
        ' accourding to the type and nature of the nodes
        ''''''''''''''''''''''''''''''''''''''''''''''
        Dim SetupFilesNodes() As ListViewItem = Nothing
        Dim cnt As Int16 = 0
        Dim ImageIndex As Int16
        ' The config file is located in the application's bin directory, so
        ' you need to remove the file name.
        ' Declare a FileInfo object for the config file.
        Dim FileInfo As System.IO.FileInfo = New System.IO.FileInfo(Application.StartupPath & "/" & SetupFileName)
        ' Load the config file into the XML DOM.
        Dim XmlDocument As New System.Xml.XmlDocument
        XmlDocument.Load(FileInfo.FullName)
        ' Find the right node and change it to the new value.
        Dim Node As System.Xml.XmlNode
        For Each Node In XmlDocument.Item("TransformedSetup")
            ' Skip any comments.
            '                
            If Node.Name = SetupTableName Then 'If Node.Name = "ProjectNodesSetup" Then
                ''''''''''''''''If To xml Node name is "ProjectNodesSetup"
                If Node.Attributes.GetNamedItem("NodeType").Value = NodeType And Node.Attributes.GetNamedItem("SystemType").Value = SystemType Then
                    If Node.Attributes.GetNamedItem("ShowNode").Value <> "0" Then 'If Node.Attributes.GetNamedItem("NodeType").Value = "SU" Then
                        ReDim Preserve SetupFilesNodes(cnt)
                        ImageIndex = Node.Attributes.GetNamedItem("ImageIndex").Value
                        SetupFilesNodes(cnt) = New ListViewItem(Node.Attributes.GetNamedItem("NodeName").Value, ImageIndex)
                        If Trim(Node.Attributes.GetNamedItem("TableNature").Value) = "" Then
                            SetupFilesNodes(cnt).Tag = Node.Attributes.GetNamedItem("TableName").Value
                        Else
                            SetupFilesNodes(cnt).Tag = Trim(Node.Attributes.GetNamedItem("TableNature").Value & "." & Node.Attributes.GetNamedItem("TableName").Value)
                        End If
                        cnt += 1
                    End If
                End If
            End If
        Next Node
        ' Save the modified config file.
        XmlDocument.Save(FileInfo.FullName)
        Return SetupFilesNodes


    End Function
#End Region


    Private Sub lstCatalog_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCatalog.DoubleClick
        Dim dtAccess As New AzamTechnologies.Database.DataAccess
        If Me.LoadingCatalogType = Catalog.Transaction Then
            strTableNature = Mid(lstCatalog.SelectedItems(0).Tag, 1, 2)
            dtAccess.PopulateDataSet(Me.dsData, SelectProcedurePrefix & Trim(Mid(lstCatalog.SelectedItems(0).Tag, InStr(1, lstCatalog.SelectedItems(0).Tag, ".") + 1, Len(lstCatalog.SelectedItems(0).Tag))), "Option", "ALL", "Nature", Mid(lstCatalog.SelectedItems(0).Tag, 1, 2))
        ElseIf Me.LoadingCatalogType = Catalog.Management Then
            Dim frm As Management
            If lstCatalog.SelectedItems(0).Tag = "Backup" Then
                frm = New Management
                frm.ManageType = Management.ManagementType.Backup
                frm.Show()
            ElseIf lstCatalog.SelectedItems(0).Tag = "Posting" Then
                frm = New Management
                frm.ManageType = Management.ManagementType.Posting
                frm.Show()
            ElseIf lstCatalog.SelectedItems(0).Tag = "Restore" Then
                frm = New Management
                frm.ManageType = Management.ManagementType.Restore
                frm.Show()
            End If
        Else
            dtAccess.PopulateDataSet(Me.dsData, SelectProcedurePrefix & lstCatalog.SelectedItems(0).Tag, "Option", "ALL")
        End If


        If LoadingCatalogType = Catalog.Setup Then
            Me.Manager = CType(ActiveForm, frmMain).DataManager1
            Me.Director = CType(ActiveForm, frmMain).DataDirector1
            Me.strMasterTable = lstCatalog.SelectedItems(0).Tag
            'Me.UGSearch_DoubleClick(Me, New System.EventArgs)
            'Me.UGSearch_CellDoubleClick(Me, New FarPoint.Win.Spread.CellClickEventArgs(Nothing, e., 0, 0, 0, Windows.Forms.MouseButtons.Left, False, e.RowPosition))

        ElseIf LoadingCatalogType = Catalog.Transaction Then
            Me.strTableNature = Mid(lstCatalog.SelectedItems(0).Tag, 1, 2)
            Me.Manager = CType(ActiveForm, frmMain).DataManager1
            Me.Director = CType(ActiveForm, frmMain).DataDirector1

            Me.strMasterTable = Trim(Mid(lstCatalog.SelectedItems(0).Tag, InStr(1, lstCatalog.SelectedItems(0).Tag, ".") + 1, Len(lstCatalog.SelectedItems(0).Tag)))
            'Me.UGSearch_DoubleClick(Me, New System.EventArgs)

        End If
        Me.Close()
    End Sub
    Public CatalogView As View
    Enum View
        Large
        Small
        List
        Detail
    End Enum
    Sub ChangeView()
        Select Case CatalogView
            Case View.Large
                Me.lstCatalog.View = System.Windows.Forms.View.LargeIcon
            Case View.Small
                Me.lstCatalog.View = System.Windows.Forms.View.SmallIcon
            Case View.Detail
                Me.lstCatalog.View = System.Windows.Forms.View.Details
                Me.lstCatalog.Columns.Add("", 200, HorizontalAlignment.Center)
            Case View.List
                Me.lstCatalog.View = System.Windows.Forms.View.List
        End Select
    End Sub

    Private Sub UGSearch_AfterRowActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles UGSearch.AfterRowActivate
        If UGSearch.ActiveRow Is UGSearch.Rows.FilterRow Then
            UGSearch.ActiveCell = UGSearch.Rows.FilterRow.Cells(0)
        End If
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
    Private Sub UGSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles UGSearch.DoubleClick
        Dim posted As Boolean
        Try
            If LoadingType = LoadType.Grid Then
                If TypeOf (sender) Is Infragistics.Win.UltraWinGrid.UltraGrid Then
                    RecordPosition = Bsource.Position
                Else
                    RecordPosition = Bsource.Position
                End If
                Dim mdiFrm() As Form = ActiveForm.MdiChildren
                Dim i As Integer
                '''''INVENTORY
                ''''''''''''''
                '
                ' Customer
                '
                frm = FormFunctions.GetFormByName(strMasterTable)
                For i = 0 To mdiFrm.Length - 1
                    If mdiFrm(i).Name = frm.Name Then
                        mdiFrm(i).Activate()
                        mdiFrm(i).Tag = AzamTechnologies.DataManager.DataMode.Locked
                        ' Me.Director.RowPosition = UGSearch.ActiveCell.Row.Index
                        Me.Director.SetData(dsData, RecordPosition)
                        Exit Sub
                    End If
                Next


            Else 'Report To Grid
                frm = FormFunctions.GetFormByName(strMasterTable)
                If TypeOf (frm) Is Vouchers Then
                    Vouchers.FpVoucherGrid_Sheet1.Tag = "VouchersDetails"
                ElseIf TypeOf (frm) Is VehicleAdjustments Then
                    VehicleAdjustments.FpVehicleAdjustmentGrid_Sheet1.Tag = "VehicleAdjustmentsDetails"
                End If
                If Me.UGSearch.Rows(UGSearch.ActiveRow.Index).Cells.Exists("VoucherNature") Then
                    strTableNature = Me.UGSearch.Rows(UGSearch.ActiveRow.Index).Cells("VoucherNature").Value
                ElseIf Me.UGSearch.Rows(UGSearch.ActiveRow.Index).Cells.Exists("NatureCode") Then
                    strTableNature = Me.UGSearch.Rows(UGSearch.ActiveRow.Index).Cells("NatureCode").Value
                End If
                If Me.UGSearch.Rows(UGSearch.ActiveRow.Index).Cells.Exists("IsAutoGenerated") Then
                    If Me.UGSearch.Rows(UGSearch.ActiveRow.Index).Cells("IsAutoGenerated").Value Then
                        posted = True
                    End If
                End If
                RecordPosition = Me.Bsource.Position
            End If

            frm.MdiParent = ActiveForm
            frm.AccessibleName = strMasterTable
            If strTableNature <> String.Empty Then
                frm.Text = GetTextOfNature(strTableNature)
            End If

            frm.AccessibleDescription = strTableNature
            Me.Director.Manager = Me.Manager
            Me.Manager.Director = Me.Director
            'Me.Manager.LockControls = True
            frm.Tag = AzamTechnologies.DataManager.DataMode.Locked
            Me.Director.ActiveForm = frm
            Me.Manager.ActiveForm = frm
            'Me.Director.RowPosition = UGSearch.ActiveCell.Row.Index
            Me.Manager.IsPosted = posted
            Me.Director.SetData(dsData, RecordPosition)
            frm.Show()




        Catch ex As OutOfMemoryException
            MessageBox.Show(ex.Message)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnExcelExporter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExcelExporter.Click
        Try
            UltraGridExcelExporter1.Export(Me.UGSearch, "C:\Test.xls")
            Process.Start("C:\Test.xls")
        Catch ex As System.ComponentModel.Win32Exception
            MessageBox.Show("Microsoft Excel is not install in your windows")
        End Try

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


End Class
