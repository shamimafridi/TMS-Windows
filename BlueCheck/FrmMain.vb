Imports BusinessLeaf.Inventory
Imports BusinessLeaf.GeneralLedger
Imports System.Reflection
Public Class frmMain
    Inherits System.Windows.Forms.Form
    Dim CurrentDataSet As DataSet
    Dim CurrentDetailDataSet As DataSet
    Friend WithEvents MnuCOASubSubsidiaries As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuTheme As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGreen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBlue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBlack As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSilver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBranches As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDivision As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBanks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuProductRates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuBillGeneration As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuProductValue As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuVehicleBills As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CashFlowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFSFControl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuFSFGeneral As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuFSFSubsidiaries As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuFSFSubSubsidiaries As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FinancialStatementsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVFreghtStatements As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuFreightAnalysis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuVehicleLedger As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UltraTabbedMdiManager1 As Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager
    Friend WithEvents TransportManagementSystem As Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar
    Friend WithEvents _frmMainAutoHideControl As Infragistics.Win.UltraWinDock.AutoHideControl
    Friend WithEvents UltraDockManager1 As Infragistics.Win.UltraWinDock.UltraDockManager
    Friend WithEvents _frmMainUnpinnedTabAreaTop As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _frmMainUnpinnedTabAreaBottom As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _frmMainUnpinnedTabAreaLeft As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents _frmMainUnpinnedTabAreaRight As Infragistics.Win.UltraWinDock.UnpinnedTabArea
    Friend WithEvents WindowDockingArea1 As Infragistics.Win.UltraWinDock.WindowDockingArea
    Friend WithEvents DockableWindow1 As Infragistics.Win.UltraWinDock.DockableWindow
    Friend WithEvents SldProjectViewer As Slides.Slide
    Friend WithEvents imgList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuVehicleRec As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuVehiclePayment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuVoucherGeneration As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuVehAdjustRec As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuVehAdjPay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuTransactionList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As ToolStripMenuItem
    Private CurrentActiveForm As Form
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
        Me.IcnSystm = Nothing
        Me.UltraDockManager1 = Nothing
        Me.UltraTabbedMdiManager1 = Nothing
        Me.DataDirector1 = Nothing
        Me.DataManager1 = Nothing
        Me.TransportManagementSystem = Nothing 'ultra explorer  
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stpText As System.Windows.Forms.StatusBarPanel
    Friend WithEvents stpDate As System.Windows.Forms.StatusBarPanel
    Friend WithEvents stbMain As System.Windows.Forms.StatusBar
    Friend WithEvents DataDirector1 As AzamTechnologies.DataDirector
    Friend WithEvents DataManager1 As AzamTechnologies.DataManager
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCustomerFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSupplier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVihiclesFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCitiesFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpeningBalaces As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWindows As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProjectViewer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOutPut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGrid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransactions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReceivingRet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInvoice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProdRecDocument As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSaleInvDocument As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRegionsFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItemLedger As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRptTrialBalance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProductsFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVihicleOwnerFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBackup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRestore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPosting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLargeIcon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSmall As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDetail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVehicleListReport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMainExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLogOff As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUserProfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IcnSystm As System.Windows.Forms.NotifyIcon
    Friend WithEvents mnuWindowsArrange As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIcon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCascade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUnPosting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAuditing As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuJournalVouchers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuBankReceiptVoucher As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCOAControls As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCOAGenerals As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCOASubsidiaries As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCashReceiptVoucher As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuBankPaymentVoucher As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCashPaymentVoucher As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuViewLog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCOAReportList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuJeneralVoucherReportDoc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuVoucherReportList As System.Windows.Forms.ToolStripMenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DockAreaPane2 As Infragistics.Win.UltraWinDock.DockAreaPane = New Infragistics.Win.UltraWinDock.DockAreaPane(Infragistics.Win.UltraWinDock.DockedLocation.DockedRight, New System.Guid("24c5bda7-a9a9-48e7-b36b-66f6b783600a"))
        Dim DockableControlPane2 As Infragistics.Win.UltraWinDock.DockableControlPane = New Infragistics.Win.UltraWinDock.DockableControlPane(New System.Guid("9046be86-00ea-4850-8adc-68b4a3722229"), New System.Guid("00000000-0000-0000-0000-000000000000"), -1, New System.Guid("24c5bda7-a9a9-48e7-b36b-66f6b783600a"), -1)
        Me.TransportManagementSystem = New Infragistics.Win.UltraWinExplorerBar.UltraExplorerBar()
        Me.imgList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustomerFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSupplier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVihicleOwnerFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVihiclesFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCitiesFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRegionsFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProductsFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProductRates = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuProductValue = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBranches = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDivision = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBanks = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuCOAControls = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCOAGenerals = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCOASubsidiaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCOASubSubsidiaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFSFControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFSFGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFSFSubsidiaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFSFSubSubsidiaries = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOpeningBalaces = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransactions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInvoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReceivingRet = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuBillGeneration = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuVehAdjustRec = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuVehAdjPay = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuVehicleRec = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuVehiclePayment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuJournalVouchers = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuBankReceiptVoucher = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCashReceiptVoucher = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuBankPaymentVoucher = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCashPaymentVoucher = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCOAReportList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVehicleListReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuVehicleBills = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuTransactionList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVFreghtStatements = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuFreightAnalysis = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuVehicleLedger = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuProdRecDocument = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaleInvDocument = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuJeneralVoucherReportDoc = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuVoucherReportList = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashFlowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuItemLedger = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRptTrialBalance = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinancialStatementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRestore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAuditing = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPosting = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUnPosting = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuVoucherGeneration = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuViewLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuView = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLargeIcon = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSmall = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDetail = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBlack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuWindowsArrange = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIcon = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProjectViewer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOutPut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuGrid = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUserProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogOff = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.stbMain = New System.Windows.Forms.StatusBar()
        Me.stpText = New System.Windows.Forms.StatusBarPanel()
        Me.stpDate = New System.Windows.Forms.StatusBarPanel()
        Me.IcnSystm = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.UltraTabbedMdiManager1 = New Infragistics.Win.UltraWinTabbedMdi.UltraTabbedMdiManager(Me.components)
        Me.DataDirector1 = New AzamTechnologies.DataDirector()
        Me.DataManager1 = New AzamTechnologies.DataManager()
        Me.UltraDockManager1 = New Infragistics.Win.UltraWinDock.UltraDockManager(Me.components)
        Me._frmMainUnpinnedTabAreaLeft = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._frmMainUnpinnedTabAreaRight = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._frmMainUnpinnedTabAreaTop = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._frmMainUnpinnedTabAreaBottom = New Infragistics.Win.UltraWinDock.UnpinnedTabArea()
        Me._frmMainAutoHideControl = New Infragistics.Win.UltraWinDock.AutoHideControl()
        Me.DockableWindow1 = New Infragistics.Win.UltraWinDock.DockableWindow()
        Me.WindowDockingArea1 = New Infragistics.Win.UltraWinDock.WindowDockingArea()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.TransportManagementSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.stpText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stpDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._frmMainAutoHideControl.SuspendLayout()
        Me.DockableWindow1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TransportManagementSystem
        '
        Me.TransportManagementSystem.ImageListSmall = Me.imgList1
        Me.TransportManagementSystem.Location = New System.Drawing.Point(0, 20)
        Me.TransportManagementSystem.Name = "TransportManagementSystem"
        Me.TransportManagementSystem.SaveSettings = True
        Me.TransportManagementSystem.SettingsKey = "frmMain.TransportManagementSystem"
        Me.TransportManagementSystem.Size = New System.Drawing.Size(204, 461)
        Me.TransportManagementSystem.TabIndex = 34
        Me.TransportManagementSystem.UseOsThemes = Infragistics.Win.DefaultableBoolean.[True]
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
        Me.imgList1.Images.SetKeyName(23, "")
        Me.imgList1.Images.SetKeyName(24, "")
        Me.imgList1.Images.SetKeyName(25, "")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMain, Me.mnuTransactions, Me.ToolStripMenuItem9, Me.ToolStripMenuItem2, Me.mnuView, Me.MnuTheme, Me.mnuWindows, Me.ToolStripMenuItem10, Me.ToolStripMenuItem13, Me.mnuMainExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(804, 24)
        Me.MenuStrip1.TabIndex = 32
        '
        'mnuMain
        '
        Me.mnuMain.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCustomerFile, Me.mnuSupplier, Me.mnuVihicleOwnerFile, Me.mnuVihiclesFile, Me.mnuCitiesFile, Me.mnuRegionsFile, Me.ToolStripMenuItem6, Me.mnuProductsFile, Me.mnuProductRates, Me.MnuProductValue, Me.ToolStripMenuItem7, Me.ToolStripSeparator1, Me.mnuBranches, Me.mnuDivision, Me.mnuBanks, Me.ToolStripSeparator5, Me.MnuCOAControls, Me.MnuCOAGenerals, Me.MnuCOASubsidiaries, Me.MnuCOASubSubsidiaries, Me.ToolStripSeparator2, Me.mnuFSFControl, Me.MnuFSFGeneral, Me.MnuFSFSubsidiaries, Me.MnuFSFSubSubsidiaries, Me.ToolStripSeparator4, Me.mnuOpeningBalaces})
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(49, 20)
        Me.mnuMain.Text = "&Setup"
        '
        'mnuCustomerFile
        '
        Me.mnuCustomerFile.Name = "mnuCustomerFile"
        Me.mnuCustomerFile.Size = New System.Drawing.Size(187, 22)
        Me.mnuCustomerFile.Text = "Customers "
        '
        'mnuSupplier
        '
        Me.mnuSupplier.Name = "mnuSupplier"
        Me.mnuSupplier.Size = New System.Drawing.Size(187, 22)
        Me.mnuSupplier.Text = "Suppliers"
        Me.mnuSupplier.Visible = False
        '
        'mnuVihicleOwnerFile
        '
        Me.mnuVihicleOwnerFile.Name = "mnuVihicleOwnerFile"
        Me.mnuVihicleOwnerFile.Size = New System.Drawing.Size(187, 22)
        Me.mnuVihicleOwnerFile.Text = "Vihicle Owners"
        '
        'mnuVihiclesFile
        '
        Me.mnuVihiclesFile.Name = "mnuVihiclesFile"
        Me.mnuVihiclesFile.Size = New System.Drawing.Size(187, 22)
        Me.mnuVihiclesFile.Text = "Vehicles"
        '
        'mnuCitiesFile
        '
        Me.mnuCitiesFile.Name = "mnuCitiesFile"
        Me.mnuCitiesFile.Size = New System.Drawing.Size(187, 22)
        Me.mnuCitiesFile.Text = "Cities"
        '
        'mnuRegionsFile
        '
        Me.mnuRegionsFile.Name = "mnuRegionsFile"
        Me.mnuRegionsFile.Size = New System.Drawing.Size(187, 22)
        Me.mnuRegionsFile.Text = "Station Points"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem6.Text = "Destination Points"
        '
        'mnuProductsFile
        '
        Me.mnuProductsFile.Name = "mnuProductsFile"
        Me.mnuProductsFile.Size = New System.Drawing.Size(187, 22)
        Me.mnuProductsFile.Text = "Products"
        '
        'mnuProductRates
        '
        Me.mnuProductRates.Name = "mnuProductRates"
        Me.mnuProductRates.Size = New System.Drawing.Size(187, 22)
        Me.mnuProductRates.Text = "Product Rates"
        '
        'MnuProductValue
        '
        Me.MnuProductValue.Name = "MnuProductValue"
        Me.MnuProductValue.Size = New System.Drawing.Size(187, 22)
        Me.MnuProductValue.Text = "Product Values"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem7.Text = "Transaction Types"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(184, 6)
        '
        'mnuBranches
        '
        Me.mnuBranches.Name = "mnuBranches"
        Me.mnuBranches.Size = New System.Drawing.Size(187, 22)
        Me.mnuBranches.Text = "Branches"
        '
        'mnuDivision
        '
        Me.mnuDivision.Name = "mnuDivision"
        Me.mnuDivision.Size = New System.Drawing.Size(187, 22)
        Me.mnuDivision.Text = "Divisions"
        '
        'mnuBanks
        '
        Me.mnuBanks.Name = "mnuBanks"
        Me.mnuBanks.Size = New System.Drawing.Size(187, 22)
        Me.mnuBanks.Text = "Banks"
        Me.mnuBanks.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(184, 6)
        Me.ToolStripSeparator5.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'MnuCOAControls
        '
        Me.MnuCOAControls.Name = "MnuCOAControls"
        Me.MnuCOAControls.Size = New System.Drawing.Size(187, 22)
        Me.MnuCOAControls.Text = "COA Controls "
        Me.MnuCOAControls.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'MnuCOAGenerals
        '
        Me.MnuCOAGenerals.Name = "MnuCOAGenerals"
        Me.MnuCOAGenerals.Size = New System.Drawing.Size(187, 22)
        Me.MnuCOAGenerals.Text = "COA Generals "
        Me.MnuCOAGenerals.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'MnuCOASubsidiaries
        '
        Me.MnuCOASubsidiaries.Name = "MnuCOASubsidiaries"
        Me.MnuCOASubsidiaries.Size = New System.Drawing.Size(187, 22)
        Me.MnuCOASubsidiaries.Text = "COA Subsidiaries"
        Me.MnuCOASubsidiaries.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'MnuCOASubSubsidiaries
        '
        Me.MnuCOASubSubsidiaries.Name = "MnuCOASubSubsidiaries"
        Me.MnuCOASubSubsidiaries.Size = New System.Drawing.Size(187, 22)
        Me.MnuCOASubSubsidiaries.Text = "COA Sub Subsidiaries"
        Me.MnuCOASubSubsidiaries.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(184, 6)
        Me.ToolStripSeparator2.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'mnuFSFControl
        '
        Me.mnuFSFControl.Name = "mnuFSFControl"
        Me.mnuFSFControl.Size = New System.Drawing.Size(187, 22)
        Me.mnuFSFControl.Text = "FSF Controls "
        Me.mnuFSFControl.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'MnuFSFGeneral
        '
        Me.MnuFSFGeneral.Name = "MnuFSFGeneral"
        Me.MnuFSFGeneral.Size = New System.Drawing.Size(187, 22)
        Me.MnuFSFGeneral.Text = "FSF Generals "
        Me.MnuFSFGeneral.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'MnuFSFSubsidiaries
        '
        Me.MnuFSFSubsidiaries.Name = "MnuFSFSubsidiaries"
        Me.MnuFSFSubsidiaries.Size = New System.Drawing.Size(187, 22)
        Me.MnuFSFSubsidiaries.Text = "FSF Subsidiaries"
        Me.MnuFSFSubsidiaries.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'MnuFSFSubSubsidiaries
        '
        Me.MnuFSFSubSubsidiaries.Name = "MnuFSFSubSubsidiaries"
        Me.MnuFSFSubSubsidiaries.Size = New System.Drawing.Size(187, 22)
        Me.MnuFSFSubSubsidiaries.Text = "FSF Sub Subsidiaries"
        Me.MnuFSFSubSubsidiaries.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(184, 6)
        Me.ToolStripSeparator4.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'mnuOpeningBalaces
        '
        Me.mnuOpeningBalaces.Name = "mnuOpeningBalaces"
        Me.mnuOpeningBalaces.Size = New System.Drawing.Size(187, 22)
        Me.mnuOpeningBalaces.Text = "Opening Balances"
        '
        'mnuTransactions
        '
        Me.mnuTransactions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInvoice, Me.mnuReceivingRet, Me.MnuBillGeneration, Me.ToolStripSeparator8, Me.MnuVehAdjustRec, Me.MnuVehAdjPay, Me.MnuVehicleRec, Me.MnuVehiclePayment, Me.ToolStripMenuItem1, Me.MnuJournalVouchers, Me.MnuBankReceiptVoucher, Me.MnuCashReceiptVoucher, Me.MnuBankPaymentVoucher, Me.MnuCashPaymentVoucher})
        Me.mnuTransactions.Name = "mnuTransactions"
        Me.mnuTransactions.Size = New System.Drawing.Size(85, 20)
        Me.mnuTransactions.Text = "&Transactions"
        '
        'mnuInvoice
        '
        Me.mnuInvoice.Name = "mnuInvoice"
        Me.mnuInvoice.Size = New System.Drawing.Size(231, 22)
        Me.mnuInvoice.Text = "Invoice"
        '
        'mnuReceivingRet
        '
        Me.mnuReceivingRet.Name = "mnuReceivingRet"
        Me.mnuReceivingRet.Size = New System.Drawing.Size(231, 22)
        Me.mnuReceivingRet.Text = "Receipt"
        '
        'MnuBillGeneration
        '
        Me.MnuBillGeneration.Name = "MnuBillGeneration"
        Me.MnuBillGeneration.Size = New System.Drawing.Size(231, 22)
        Me.MnuBillGeneration.Text = "Bill Generation"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(228, 6)
        '
        'MnuVehAdjustRec
        '
        Me.MnuVehAdjustRec.Name = "MnuVehAdjustRec"
        Me.MnuVehAdjustRec.Size = New System.Drawing.Size(231, 22)
        Me.MnuVehAdjustRec.Text = "Vehicle Adjustment Receipts"
        '
        'MnuVehAdjPay
        '
        Me.MnuVehAdjPay.Name = "MnuVehAdjPay"
        Me.MnuVehAdjPay.Size = New System.Drawing.Size(231, 22)
        Me.MnuVehAdjPay.Text = "Vehicle Adjustment Payments"
        '
        'MnuVehicleRec
        '
        Me.MnuVehicleRec.Name = "MnuVehicleRec"
        Me.MnuVehicleRec.Size = New System.Drawing.Size(231, 22)
        Me.MnuVehicleRec.Text = "Vehicle Receipts"
        '
        'MnuVehiclePayment
        '
        Me.MnuVehiclePayment.Name = "MnuVehiclePayment"
        Me.MnuVehiclePayment.Size = New System.Drawing.Size(231, 22)
        Me.MnuVehiclePayment.Text = "Vehicle Payments"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(228, 6)
        Me.ToolStripMenuItem1.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'MnuJournalVouchers
        '
        Me.MnuJournalVouchers.Name = "MnuJournalVouchers"
        Me.MnuJournalVouchers.Size = New System.Drawing.Size(231, 22)
        Me.MnuJournalVouchers.Text = "Journal Voucher"
        Me.MnuJournalVouchers.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'MnuBankReceiptVoucher
        '
        Me.MnuBankReceiptVoucher.Name = "MnuBankReceiptVoucher"
        Me.MnuBankReceiptVoucher.Size = New System.Drawing.Size(231, 22)
        Me.MnuBankReceiptVoucher.Text = "Bank Receipt Voucher"
        Me.MnuBankReceiptVoucher.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'MnuCashReceiptVoucher
        '
        Me.MnuCashReceiptVoucher.Name = "MnuCashReceiptVoucher"
        Me.MnuCashReceiptVoucher.Size = New System.Drawing.Size(231, 22)
        Me.MnuCashReceiptVoucher.Text = "Cash Receipt Voucher"
        Me.MnuCashReceiptVoucher.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'MnuBankPaymentVoucher
        '
        Me.MnuBankPaymentVoucher.Name = "MnuBankPaymentVoucher"
        Me.MnuBankPaymentVoucher.Size = New System.Drawing.Size(231, 22)
        Me.MnuBankPaymentVoucher.Text = "Bank Payment Voucher"
        Me.MnuBankPaymentVoucher.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'MnuCashPaymentVoucher
        '
        Me.MnuCashPaymentVoucher.Name = "MnuCashPaymentVoucher"
        Me.MnuCashPaymentVoucher.Size = New System.Drawing.Size(231, 22)
        Me.MnuCashPaymentVoucher.Text = "Cash Payment Voucher"
        Me.MnuCashPaymentVoucher.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuCOAReportList, Me.mnuVehicleListReport, Me.ToolStripMenuItem4, Me.MnuVehicleBills, Me.MnuTransactionList, Me.mnuVFreghtStatements, Me.MnuFreightAnalysis, Me.ToolStripMenuItem3, Me.ToolStripMenuItem12, Me.MnuVehicleLedger, Me.ToolStripSeparator7, Me.mnuProdRecDocument, Me.mnuSaleInvDocument, Me.ToolStripMenuItem11, Me.MnuJeneralVoucherReportDoc, Me.MnuVoucherReportList, Me.CashFlowToolStripMenuItem, Me.ToolStripMenuItem8, Me.mnuItemLedger, Me.mnuRptTrialBalance, Me.FinancialStatementsToolStripMenuItem})
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(59, 20)
        Me.ToolStripMenuItem9.Text = "&Reports"
        '
        'MnuCOAReportList
        '
        Me.MnuCOAReportList.Name = "MnuCOAReportList"
        Me.MnuCOAReportList.Size = New System.Drawing.Size(213, 22)
        Me.MnuCOAReportList.Text = "Chart of Account List"
        Me.MnuCOAReportList.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'mnuVehicleListReport
        '
        Me.mnuVehicleListReport.Name = "mnuVehicleListReport"
        Me.mnuVehicleListReport.Size = New System.Drawing.Size(213, 22)
        Me.mnuVehicleListReport.Text = "Vehicle List"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(210, 6)
        '
        'MnuVehicleBills
        '
        Me.MnuVehicleBills.Name = "MnuVehicleBills"
        Me.MnuVehicleBills.Size = New System.Drawing.Size(213, 22)
        Me.MnuVehicleBills.Text = "Vehicle Bills"
        '
        'MnuTransactionList
        '
        Me.MnuTransactionList.Name = "MnuTransactionList"
        Me.MnuTransactionList.Size = New System.Drawing.Size(213, 22)
        Me.MnuTransactionList.Text = "Vehicle Transaction List"
        '
        'mnuVFreghtStatements
        '
        Me.mnuVFreghtStatements.Name = "mnuVFreghtStatements"
        Me.mnuVFreghtStatements.Size = New System.Drawing.Size(213, 22)
        Me.mnuVFreghtStatements.Text = "Vehicle Freight Statements"
        '
        'MnuFreightAnalysis
        '
        Me.MnuFreightAnalysis.Name = "MnuFreightAnalysis"
        Me.MnuFreightAnalysis.Size = New System.Drawing.Size(213, 22)
        Me.MnuFreightAnalysis.Text = "Vehicle Bill Analysis"
        '
        'MnuVehicleLedger
        '
        Me.MnuVehicleLedger.Name = "MnuVehicleLedger"
        Me.MnuVehicleLedger.Size = New System.Drawing.Size(213, 22)
        Me.MnuVehicleLedger.Text = "Vehicle Ledger"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(210, 6)
        '
        'mnuProdRecDocument
        '
        Me.mnuProdRecDocument.Name = "mnuProdRecDocument"
        Me.mnuProdRecDocument.Size = New System.Drawing.Size(213, 22)
        Me.mnuProdRecDocument.Text = "Receipt Documents"
        Me.mnuProdRecDocument.Visible = False
        '
        'mnuSaleInvDocument
        '
        Me.mnuSaleInvDocument.Name = "mnuSaleInvDocument"
        Me.mnuSaleInvDocument.Size = New System.Drawing.Size(213, 22)
        Me.mnuSaleInvDocument.Text = "Invoice Documents"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(210, 6)
        Me.ToolStripMenuItem11.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'MnuJeneralVoucherReportDoc
        '
        Me.MnuJeneralVoucherReportDoc.Name = "MnuJeneralVoucherReportDoc"
        Me.MnuJeneralVoucherReportDoc.Size = New System.Drawing.Size(213, 22)
        Me.MnuJeneralVoucherReportDoc.Text = "Voucher Documents"
        Me.MnuJeneralVoucherReportDoc.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'MnuVoucherReportList
        '
        Me.MnuVoucherReportList.Name = "MnuVoucherReportList"
        Me.MnuVoucherReportList.Size = New System.Drawing.Size(213, 22)
        Me.MnuVoucherReportList.Text = "Voucher List"
        Me.MnuVoucherReportList.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'CashFlowToolStripMenuItem
        '
        Me.CashFlowToolStripMenuItem.Name = "CashFlowToolStripMenuItem"
        Me.CashFlowToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.CashFlowToolStripMenuItem.Text = "Cash Flow Statements"
        Me.CashFlowToolStripMenuItem.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(210, 6)
        Me.ToolStripMenuItem8.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'mnuItemLedger
        '
        Me.mnuItemLedger.Name = "mnuItemLedger"
        Me.mnuItemLedger.Size = New System.Drawing.Size(213, 22)
        Me.mnuItemLedger.Text = "General Ledger"
        Me.mnuItemLedger.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'mnuRptTrialBalance
        '
        Me.mnuRptTrialBalance.Name = "mnuRptTrialBalance"
        Me.mnuRptTrialBalance.Size = New System.Drawing.Size(213, 22)
        Me.mnuRptTrialBalance.Text = "Trial Balance"
        Me.mnuRptTrialBalance.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'FinancialStatementsToolStripMenuItem
        '
        Me.FinancialStatementsToolStripMenuItem.Name = "FinancialStatementsToolStripMenuItem"
        Me.FinancialStatementsToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.FinancialStatementsToolStripMenuItem.Text = "Financial Statements"
        Me.FinancialStatementsToolStripMenuItem.Visible = Global.BusinessLeaf.My.MySettings.Default.IsWithGL
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBackup, Me.mnuRestore, Me.mnuAuditing, Me.mnuPosting, Me.mnuUnPosting, Me.MnuVoucherGeneration, Me.MnuViewLog, Me.mnuOptions})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(127, 20)
        Me.ToolStripMenuItem2.Text = "&Administrative Tools"
        '
        'mnuBackup
        '
        Me.mnuBackup.Name = "mnuBackup"
        Me.mnuBackup.Size = New System.Drawing.Size(178, 22)
        Me.mnuBackup.Text = "Backup"
        '
        'mnuRestore
        '
        Me.mnuRestore.Name = "mnuRestore"
        Me.mnuRestore.Size = New System.Drawing.Size(178, 22)
        Me.mnuRestore.Text = "Restore"
        '
        'mnuAuditing
        '
        Me.mnuAuditing.Name = "mnuAuditing"
        Me.mnuAuditing.Size = New System.Drawing.Size(178, 22)
        Me.mnuAuditing.Text = "Auditing"
        '
        'mnuPosting
        '
        Me.mnuPosting.Name = "mnuPosting"
        Me.mnuPosting.Size = New System.Drawing.Size(178, 22)
        Me.mnuPosting.Text = "Posting"
        '
        'mnuUnPosting
        '
        Me.mnuUnPosting.Name = "mnuUnPosting"
        Me.mnuUnPosting.Size = New System.Drawing.Size(178, 22)
        Me.mnuUnPosting.Text = "Un Posting"
        '
        'MnuVoucherGeneration
        '
        Me.MnuVoucherGeneration.Name = "MnuVoucherGeneration"
        Me.MnuVoucherGeneration.Size = New System.Drawing.Size(178, 22)
        Me.MnuVoucherGeneration.Text = "Voucher Generation"
        '
        'MnuViewLog
        '
        Me.MnuViewLog.Name = "MnuViewLog"
        Me.MnuViewLog.Size = New System.Drawing.Size(178, 22)
        Me.MnuViewLog.Text = "User Activiities Log"
        '
        'mnuOptions
        '
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(178, 22)
        Me.mnuOptions.Text = "Options"
        '
        'mnuView
        '
        Me.mnuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLargeIcon, Me.mnuSmall, Me.mnuList, Me.mnuDetail})
        Me.mnuView.Name = "mnuView"
        Me.mnuView.Size = New System.Drawing.Size(44, 20)
        Me.mnuView.Text = "View"
        Me.mnuView.Visible = False
        '
        'mnuLargeIcon
        '
        Me.mnuLargeIcon.Name = "mnuLargeIcon"
        Me.mnuLargeIcon.Size = New System.Drawing.Size(129, 22)
        Me.mnuLargeIcon.Text = "Large Icon"
        '
        'mnuSmall
        '
        Me.mnuSmall.Name = "mnuSmall"
        Me.mnuSmall.Size = New System.Drawing.Size(129, 22)
        Me.mnuSmall.Text = "Small Icon"
        '
        'mnuList
        '
        Me.mnuList.Name = "mnuList"
        Me.mnuList.Size = New System.Drawing.Size(129, 22)
        Me.mnuList.Text = "List"
        '
        'mnuDetail
        '
        Me.mnuDetail.Name = "mnuDetail"
        Me.mnuDetail.Size = New System.Drawing.Size(129, 22)
        Me.mnuDetail.Text = "Detail"
        '
        'MnuTheme
        '
        Me.MnuTheme.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGreen, Me.mnuBlue, Me.mnuBlack, Me.mnuSilver})
        Me.MnuTheme.Name = "MnuTheme"
        Me.MnuTheme.Size = New System.Drawing.Size(56, 20)
        Me.MnuTheme.Text = "Theme"
        '
        'mnuGreen
        '
        Me.mnuGreen.Name = "mnuGreen"
        Me.mnuGreen.Size = New System.Drawing.Size(105, 22)
        Me.mnuGreen.Text = "Green"
        '
        'mnuBlue
        '
        Me.mnuBlue.Name = "mnuBlue"
        Me.mnuBlue.Size = New System.Drawing.Size(105, 22)
        Me.mnuBlue.Text = "Blue"
        '
        'mnuBlack
        '
        Me.mnuBlack.Name = "mnuBlack"
        Me.mnuBlack.Size = New System.Drawing.Size(105, 22)
        Me.mnuBlack.Text = "Black"
        '
        'mnuSilver
        '
        Me.mnuSilver.Name = "mnuSilver"
        Me.mnuSilver.Size = New System.Drawing.Size(105, 22)
        Me.mnuSilver.Text = "Silver"
        '
        'mnuWindows
        '
        Me.mnuWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuWindowsArrange, Me.mnuProjectViewer, Me.mnuSearch, Me.mnuOutPut, Me.mnuGrid})
        Me.mnuWindows.Name = "mnuWindows"
        Me.mnuWindows.Size = New System.Drawing.Size(68, 20)
        Me.mnuWindows.Text = "&Windows"
        '
        'mnuWindowsArrange
        '
        Me.mnuWindowsArrange.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuIcon, Me.mnuHorizontal, Me.mnuVertical, Me.mnuCascade})
        Me.mnuWindowsArrange.Name = "mnuWindowsArrange"
        Me.mnuWindowsArrange.Size = New System.Drawing.Size(140, 22)
        Me.mnuWindowsArrange.Text = "Arrange"
        '
        'mnuIcon
        '
        Me.mnuIcon.Checked = True
        Me.mnuIcon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuIcon.Name = "mnuIcon"
        Me.mnuIcon.Size = New System.Drawing.Size(129, 22)
        Me.mnuIcon.Text = "Icon"
        '
        'mnuHorizontal
        '
        Me.mnuHorizontal.Name = "mnuHorizontal"
        Me.mnuHorizontal.Size = New System.Drawing.Size(129, 22)
        Me.mnuHorizontal.Text = "Horizontal"
        '
        'mnuVertical
        '
        Me.mnuVertical.Name = "mnuVertical"
        Me.mnuVertical.Size = New System.Drawing.Size(129, 22)
        Me.mnuVertical.Text = "Vertical"
        '
        'mnuCascade
        '
        Me.mnuCascade.Name = "mnuCascade"
        Me.mnuCascade.Size = New System.Drawing.Size(129, 22)
        Me.mnuCascade.Text = "Cascade"
        '
        'mnuProjectViewer
        '
        Me.mnuProjectViewer.Checked = True
        Me.mnuProjectViewer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuProjectViewer.Name = "mnuProjectViewer"
        Me.mnuProjectViewer.Size = New System.Drawing.Size(140, 22)
        Me.mnuProjectViewer.Text = "Files Viewer"
        '
        'mnuSearch
        '
        Me.mnuSearch.Checked = True
        Me.mnuSearch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuSearch.Name = "mnuSearch"
        Me.mnuSearch.Size = New System.Drawing.Size(140, 22)
        Me.mnuSearch.Text = "Search Slide"
        '
        'mnuOutPut
        '
        Me.mnuOutPut.Checked = True
        Me.mnuOutPut.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuOutPut.Name = "mnuOutPut"
        Me.mnuOutPut.Size = New System.Drawing.Size(140, 22)
        Me.mnuOutPut.Text = "Output Slide"
        '
        'mnuGrid
        '
        Me.mnuGrid.Checked = True
        Me.mnuGrid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuGrid.Name = "mnuGrid"
        Me.mnuGrid.Size = New System.Drawing.Size(140, 22)
        Me.mnuGrid.Text = "Search Grid"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUserProfile, Me.mnuLogOff})
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripMenuItem10.Text = "Se&curity"
        '
        'mnuUserProfile
        '
        Me.mnuUserProfile.Name = "mnuUserProfile"
        Me.mnuUserProfile.Size = New System.Drawing.Size(134, 22)
        Me.mnuUserProfile.Text = "User Profile"
        '
        'mnuLogOff
        '
        Me.mnuLogOff.Name = "mnuLogOff"
        Me.mnuLogOff.Size = New System.Drawing.Size(134, 22)
        Me.mnuLogOff.Text = "Log Off"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem14, Me.ToolStripMenuItem17})
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(44, 20)
        Me.ToolStripMenuItem13.Text = "Help"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(149, 22)
        Me.ToolStripMenuItem14.Text = "Dynamic Help"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(149, 22)
        Me.ToolStripMenuItem17.Text = "About TMS"
        '
        'mnuMainExit
        '
        Me.mnuMainExit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuMainExit.Name = "mnuMainExit"
        Me.mnuMainExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuMainExit.Text = "E&xit"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuExit.Text = "Exit"
        '
        'stbMain
        '
        Me.stbMain.Location = New System.Drawing.Point(0, 555)
        Me.stbMain.Name = "stbMain"
        Me.stbMain.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.stpText, Me.stpDate})
        Me.stbMain.ShowPanels = True
        Me.stbMain.Size = New System.Drawing.Size(804, 24)
        Me.stbMain.TabIndex = 18
        Me.stbMain.Text = "stbMain"
        '
        'stpText
        '
        Me.stpText.Name = "stpText"
        Me.stpText.Text = "Ready....."
        Me.stpText.Width = 300
        '
        'stpDate
        '
        Me.stpDate.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.stpDate.Name = "stpDate"
        Me.stpDate.Width = 10
        '
        'IcnSystm
        '
        Me.IcnSystm.Icon = CType(resources.GetObject("IcnSystm.Icon"), System.Drawing.Icon)
        Me.IcnSystm.Visible = True
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(184, 6)
        '
        'UltraTabbedMdiManager1
        '
        Me.UltraTabbedMdiManager1.MdiParent = Me
        Me.UltraTabbedMdiManager1.ViewStyle = Infragistics.Win.UltraWinTabbedMdi.ViewStyle.Office2007
        '
        'DataDirector1
        '
        Me.DataDirector1.ActiveForm = Nothing
        Me.DataDirector1.AllowDrop = True
        Me.DataDirector1.Location = New System.Drawing.Point(0, 49)
        Me.DataDirector1.Name = "DataDirector1"
        Me.DataDirector1.Size = New System.Drawing.Size(804, 25)
        Me.DataDirector1.TabIndex = 30
        Me.DataDirector1.TableName = "Table"
        Me.DataDirector1.TableNature = ""
        Me.DataDirector1.WorkingDate = New Date(CType(0, Long))
        '
        'DataManager1
        '
        Me.DataManager1.ActiveForm = Nothing
        Me.DataManager1.AllowDrop = True
        Me.DataManager1.DisableControlColor = System.Drawing.SystemColors.Menu
        Me.DataManager1.Location = New System.Drawing.Point(0, 24)
        Me.DataManager1.LockControls = False
        Me.DataManager1.Name = "DataManager1"
        Me.DataManager1.Size = New System.Drawing.Size(804, 25)
        Me.DataManager1.TabIndex = 31
        '
        'UltraDockManager1
        '
        DockableControlPane2.Control = Me.TransportManagementSystem
        DockableControlPane2.FlyoutSize = New System.Drawing.Size(204, -1)
        DockableControlPane2.OriginalControlBounds = New System.Drawing.Rectangle(558, 77, 246, 230)
        DockableControlPane2.Pinned = False
        DockableControlPane2.Size = New System.Drawing.Size(100, 100)
        DockableControlPane2.Text = "TMS Files"
        DockAreaPane2.Panes.AddRange(New Infragistics.Win.UltraWinDock.DockablePaneBase() {DockableControlPane2})
        DockAreaPane2.Size = New System.Drawing.Size(224, 481)
        Me.UltraDockManager1.DockAreas.AddRange(New Infragistics.Win.UltraWinDock.DockAreaPane() {DockAreaPane2})
        Me.UltraDockManager1.HostControl = Me
        Me.UltraDockManager1.SplitterBarWidth = 4
        Me.UltraDockManager1.WindowStyle = Infragistics.Win.UltraWinDock.WindowStyle.VisualStudio2008
        '
        '_frmMainUnpinnedTabAreaLeft
        '
        Me._frmMainUnpinnedTabAreaLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me._frmMainUnpinnedTabAreaLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmMainUnpinnedTabAreaLeft.Location = New System.Drawing.Point(0, 74)
        Me._frmMainUnpinnedTabAreaLeft.Name = "_frmMainUnpinnedTabAreaLeft"
        Me._frmMainUnpinnedTabAreaLeft.Owner = Me.UltraDockManager1
        Me._frmMainUnpinnedTabAreaLeft.Size = New System.Drawing.Size(0, 481)
        Me._frmMainUnpinnedTabAreaLeft.TabIndex = 35
        '
        '_frmMainUnpinnedTabAreaRight
        '
        Me._frmMainUnpinnedTabAreaRight.Dock = System.Windows.Forms.DockStyle.Right
        Me._frmMainUnpinnedTabAreaRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmMainUnpinnedTabAreaRight.Location = New System.Drawing.Point(782, 74)
        Me._frmMainUnpinnedTabAreaRight.Name = "_frmMainUnpinnedTabAreaRight"
        Me._frmMainUnpinnedTabAreaRight.Owner = Me.UltraDockManager1
        Me._frmMainUnpinnedTabAreaRight.Size = New System.Drawing.Size(22, 481)
        Me._frmMainUnpinnedTabAreaRight.TabIndex = 36
        '
        '_frmMainUnpinnedTabAreaTop
        '
        Me._frmMainUnpinnedTabAreaTop.Dock = System.Windows.Forms.DockStyle.Top
        Me._frmMainUnpinnedTabAreaTop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmMainUnpinnedTabAreaTop.Location = New System.Drawing.Point(0, 74)
        Me._frmMainUnpinnedTabAreaTop.Name = "_frmMainUnpinnedTabAreaTop"
        Me._frmMainUnpinnedTabAreaTop.Owner = Me.UltraDockManager1
        Me._frmMainUnpinnedTabAreaTop.Size = New System.Drawing.Size(782, 0)
        Me._frmMainUnpinnedTabAreaTop.TabIndex = 37
        '
        '_frmMainUnpinnedTabAreaBottom
        '
        Me._frmMainUnpinnedTabAreaBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._frmMainUnpinnedTabAreaBottom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmMainUnpinnedTabAreaBottom.Location = New System.Drawing.Point(0, 555)
        Me._frmMainUnpinnedTabAreaBottom.Name = "_frmMainUnpinnedTabAreaBottom"
        Me._frmMainUnpinnedTabAreaBottom.Owner = Me.UltraDockManager1
        Me._frmMainUnpinnedTabAreaBottom.Size = New System.Drawing.Size(782, 0)
        Me._frmMainUnpinnedTabAreaBottom.TabIndex = 38
        '
        '_frmMainAutoHideControl
        '
        Me._frmMainAutoHideControl.Controls.Add(Me.DockableWindow1)
        Me._frmMainAutoHideControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._frmMainAutoHideControl.Location = New System.Drawing.Point(574, 74)
        Me._frmMainAutoHideControl.Name = "_frmMainAutoHideControl"
        Me._frmMainAutoHideControl.Owner = Me.UltraDockManager1
        Me._frmMainAutoHideControl.Size = New System.Drawing.Size(208, 481)
        Me._frmMainAutoHideControl.TabIndex = 39
        '
        'DockableWindow1
        '
        Me.DockableWindow1.Controls.Add(Me.TransportManagementSystem)
        Me.DockableWindow1.Location = New System.Drawing.Point(4, 0)
        Me.DockableWindow1.Name = "DockableWindow1"
        Me.DockableWindow1.Owner = Me.UltraDockManager1
        Me.DockableWindow1.Size = New System.Drawing.Size(204, 481)
        Me.DockableWindow1.TabIndex = 42
        '
        'WindowDockingArea1
        '
        Me.WindowDockingArea1.Dock = System.Windows.Forms.DockStyle.Right
        Me.WindowDockingArea1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WindowDockingArea1.Location = New System.Drawing.Point(554, 74)
        Me.WindowDockingArea1.Name = "WindowDockingArea1"
        Me.WindowDockingArea1.Owner = Me.UltraDockManager1
        Me.WindowDockingArea1.Size = New System.Drawing.Size(228, 481)
        Me.WindowDockingArea1.TabIndex = 40
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(213, 22)
        Me.ToolStripMenuItem3.Text = "Vehcile Revenue"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(213, 22)
        Me.ToolStripMenuItem12.Text = "Vehicle Revenue Pivot"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(804, 579)
        Me.Controls.Add(Me._frmMainAutoHideControl)
        Me.Controls.Add(Me.WindowDockingArea1)
        Me.Controls.Add(Me._frmMainUnpinnedTabAreaTop)
        Me.Controls.Add(Me._frmMainUnpinnedTabAreaBottom)
        Me.Controls.Add(Me._frmMainUnpinnedTabAreaLeft)
        Me.Controls.Add(Me._frmMainUnpinnedTabAreaRight)
        Me.Controls.Add(Me.DataDirector1)
        Me.Controls.Add(Me.DataManager1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.stbMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "B-Leaf {Transport Management System}"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TransportManagementSystem, System.Configuration.IPersistComponentSettings).LoadComponentSettings()
        CType(Me.TransportManagementSystem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.stpText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stpDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._frmMainAutoHideControl.ResumeLayout(False)
        Me.DockableWindow1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private Sub frmMain_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles Me.ControlAdded

    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setting()
        loadPicture()
        Me.UltraTabbedMdiManager1.MdiParent = Me
        loadStyle()
    End Sub

    Private Sub loadPicture()
        Try
            Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\BackGround.gif")
        Catch ex As Exception

        End Try


    End Sub
    Private Sub setting()
        Try

            Try

                SldProjectViewer = New Slides.Slide(Slides.Slide.TypeOfSlide.ProjectViewer, Me.TransportManagementSystem)
                stpDate.Text = Now.Date.ToLongDateString
                'SETTING BACKGROUND IMAGE
                Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\images\CompanyLogo.jpg")

                ''''
                Me.Text = ""
            Catch ex As IO.FileNotFoundException

            End Try
        Catch ex As AzamTechnologies.Database.ConnectionException
            AzamTechnologies.LogGenerator.CreateLog(ex.Message, "Login Form", Err.Number, EventLogEntryType.Error)
            MessageBox.Show(ex.Message, My.Settings.ConnectionString, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub frmMain_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
        If Me.ActiveMdiChild Is Nothing Then Exit Sub
        'If Me.MenuStrip1.Items(4).Visible = True Then
        '    Me.MenuStrip1.Items(4).Visible = False
        'End If
        If Me.ActiveMdiChild.Name = "frmGrid" Or Me.ActiveMdiChild.Name = "ReportViewer" _
        Or Me.ActiveMdiChild.Name = "ReportParameters" Or Me.ActiveMdiChild.Name = "FrmOption" Then
            If Me.ActiveMdiChild.Name = "frmGrid" Then
                If CType(Me.ActiveMdiChild, frmGrid).LoadingType = frmGrid.LoadType.Catalog Then
                    Me.MenuStrip1.Items(4).Visible = True
                End If
            Else
                Exit Sub
            End If
        Else
            Me.DataDirector1.WorkingDate = CurrentWorkingDate
            If Me.ActiveMdiChild.Tag = AzamTechnologies.DataManager.DataMode.Edit Then

                Me.DataDirector1.ActiveForm = Me.ActiveMdiChild
                Me.DataDirector1.InitalizeActiveFormComponents()
                Me.DataDirector1.Manager = DataManager1

                Me.DataManager1.ActiveForm = Me.ActiveMdiChild
                Me.DataManager1.Director = DataDirector1

                Me.DataManager1.EnableDisable(False)
            ElseIf Me.ActiveMdiChild.Tag = AzamTechnologies.DataManager.DataMode.Insert Or Me.ActiveMdiChild.Tag = AzamTechnologies.DataManager.DataMode.Inserting _
            Or Me.ActiveMdiChild.Tag = AzamTechnologies.DataManager.DataMode.Locked Then
                Me.DataDirector1.Manager = DataManager1
                Me.DataDirector1.ActiveForm = Me.ActiveMdiChild
                Me.DataManager1.ActiveForm = Me.ActiveMdiChild
                Me.DataDirector1.InitalizeActiveFormComponents()


                Me.DataManager1.Director = DataDirector1

                Me.DataManager1.EnableDisable(False Or DataManager1.IsPosted)
            ElseIf Me.ActiveMdiChild.Tag = AzamTechnologies.DataManager.DataMode.Posted Then
                Me.DataManager1.ActiveForm = Me.ActiveMdiChild
                Me.DataManager1.EnableDisable(True Or DataManager1.IsPosted)
                Me.DataDirector1.Manager = DataManager1
                Me.DataDirector1.InitalizeActiveFormComponents()
                Me.DataManager1.Director = DataDirector1
            End If
        End If
    End Sub
    Public mFormSelectedMode As FormSelectedMode
    Dim mCurrentForm As Form
    Dim ManageType As Management.ManagementType
    Dim MainGrid As frmGrid

    'Private mCurrentTable As String
    Public d As ProjectViewerEventArgs
    Public Sub SelectFile(ByVal e As ProjectViewerEventArgs)

        If Not IsNothing(e.ParentNodeText) Then
            MainGrid = New frmGrid
            MainGrid.LoadingType = frmGrid.LoadType.Catalog
            Dim mdiFrm() As Form = Me.MdiChildren
            Dim i As Integer
            For i = 0 To mdiFrm.Length - 1
                If mdiFrm(i).Name = MainGrid.Name Then
                    mdiFrm(i).Close()
                End If
            Next
            Select Case e.SystemNodeText

                Case InventoryNodeText
                    MainGrid.LoadingSystemType = frmGrid.SystemType.Inventory
                    Select Case e.ParentNodeText
                        Case SystemNodeText
                            'GridForm.LoadingCatalogType = frmGrid.Catalog.System
                            'GridForm.MdiParent = Me
                            'GridForm.Show()
                        Case SetupParentNodeText
                            MainGrid.LoadingCatalogType = frmGrid.Catalog.Setup
                            MainGrid.MdiParent = Me
                            MainGrid.Show()
                        Case TransactionsParentNodeText
                            MainGrid.LoadingCatalogType = frmGrid.Catalog.Transaction
                            MainGrid.MdiParent = Me
                            MainGrid.Show()

                    End Select
                Case TopMostNodeText
                    Select Case e.ParentNodeText
                        Case ManagementNodeText
                            MainGrid.LoadingCatalogType = frmGrid.Catalog.Management
                            MainGrid.MdiParent = Me
                            MainGrid.Show()
                        Case SecurityNodeText
                            MainGrid.LoadingCatalogType = frmGrid.Catalog.Security
                            MainGrid.MdiParent = Me
                            MainGrid.Show()
                    End Select
                Case GeneralLedgerNodeText
                    MainGrid.LoadingSystemType = frmGrid.SystemType.GeneralLedger
                    Select Case e.ParentNodeText
                        Case SystemNodeText
                            'GridForm.LoadingCatalogType = frmGrid.Catalog.System
                            'GridForm.MdiParent = Me
                            'GridForm.Show()
                        Case SetupParentNodeText
                            MainGrid.LoadingCatalogType = frmGrid.Catalog.Setup
                            MainGrid.MdiParent = Me
                            MainGrid.Show()
                        Case TransactionsParentNodeText
                            MainGrid.LoadingCatalogType = frmGrid.Catalog.Transaction
                            MainGrid.MdiParent = Me
                            MainGrid.Show()

                    End Select
                Case TopMostNodeText
                    Select Case e.ParentNodeText
                        Case ManagementNodeText
                            MainGrid.LoadingCatalogType = frmGrid.Catalog.Management
                            MainGrid.MdiParent = Me
                            MainGrid.Show()
                        Case SecurityNodeText
                            MainGrid.LoadingCatalogType = frmGrid.Catalog.Security
                            MainGrid.MdiParent = Me
                            MainGrid.Show()
                    End Select
                Case PayrollNodeText
                    MainGrid.LoadingSystemType = frmGrid.SystemType.Payroll
                    Select Case e.ParentNodeText
                        Case SystemNodeText
                            'GridForm.LoadingCatalogType = frmGrid.Catalog.System
                            'GridForm.MdiParent = Me
                            'GridForm.Show()
                        Case SetupParentNodeText
                            MainGrid.LoadingCatalogType = frmGrid.Catalog.Setup
                            MainGrid.MdiParent = Me
                            MainGrid.Show()
                        Case TransactionsParentNodeText
                            MainGrid.LoadingCatalogType = frmGrid.Catalog.Transaction
                            MainGrid.MdiParent = Me
                            MainGrid.Show()

                    End Select
                Case TopMostNodeText
                    Select Case e.ParentNodeText
                        Case ManagementNodeText
                            MainGrid.LoadingCatalogType = frmGrid.Catalog.Management
                            MainGrid.MdiParent = Me
                            MainGrid.Show()
                        Case SecurityNodeText
                            MainGrid.LoadingCatalogType = frmGrid.Catalog.Security
                            MainGrid.MdiParent = Me
                            MainGrid.Show()
                    End Select
            End Select

        End If
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not IsNothing(e.SelectedTable) Then
                Select Case e.SelectedTable
                    Case Is = "Backup"
                        Dim frm As New Management
                        frm.Owner = Me
                        frm.ManageType = Management.ManagementType.Backup
                        Me.Cursor = Cursors.Default
                        frm.Show()
                        Exit Sub
                    Case Is = "Restore"
                        Dim frm As New Management
                        frm.Owner = Me
                        frm.ManageType = Management.ManagementType.Restore
                        Me.Cursor = Cursors.Default
                        frm.Show()
                        Exit Sub
                    Case Is = "Posting"
                        Dim frm As New Management
                        frm.Owner = Me
                        frm.ManageType = Management.ManagementType.Posting
                        Me.Cursor = Cursors.Default
                        frm.Show()
                        Exit Sub
                    Case Is = "UnPosting"
                        Dim frm As New Management
                        frm.Owner = Me
                        frm.ManageType = Management.ManagementType.UnPosting
                        Me.Cursor = Cursors.Default
                        frm.Show()
                        Exit Sub
                    Case Is = "Auditing"
                        Dim frm As New Management
                        frm.Owner = Me
                        frm.ManageType = Management.ManagementType.Auditing
                        Me.Cursor = Cursors.Default
                        frm.Show()
                        Exit Sub
                End Select

                If e.FormSelectdMode = FormSelectedMode.Grid Then
                    Dim dtAccess As New AzamTechnologies.Database.DataAccess
                    If IsNothing(e.SelectedTableNature) Or e.SelectedTableNature = "" Then
                        dtAccess.PopulateDataSet(CurrentDataSet, SelectProcedurePrefix & e.SelectedTable, "Option", "ALL")
                    Else
                        dtAccess.PopulateDataSet(CurrentDataSet, SelectProcedurePrefix & e.SelectedTable, "Option", "ALL", StrTransactionTerm, e.SelectedTableNature)
                    End If


                    Dim mdiFrm() As Form = Me.MdiChildren
                    Dim i As Integer
                    MainGrid = New frmGrid
                    For i = 0 To mdiFrm.Length - 1
                        If mdiFrm(i).Name = MainGrid.Name Then
                            mdiFrm(i).Close()
                        End If
                    Next
                    MainGrid.LoadingType = frmGrid.LoadType.Grid
                    MainGrid.Director = Me.DataDirector1
                    MainGrid.Manager = Me.DataManager1



                    ''Grid Navigation header Text Setting i.e. to show proper table name
                    CurrentDataSet.DataSetName = e.SelectedTable
                    CurrentDataSet.Tables(0).TableName = e.SelectedTable
                    '''''''''''''''''''''
                    MainGrid.dsData = CurrentDataSet
                    MainGrid.dsDetail = CurrentDetailDataSet
                    MainGrid.strMasterTable = e.SelectedTable
                    MainGrid.strTableNature = e.SelectedTableNature
                    MainGrid.MdiParent = Me
                    MainGrid.WindowState = FormWindowState.Maximized
                    MainGrid.Show()


                Else
                    Dim mdiFrm() As Form = Me.MdiChildren
                    Dim i As Integer

                    If e.SelectedTable <> "Transactions" AndAlso e.SelectedTable <> "Vouchers" AndAlso e.SelectedTable <> "VehicleAdjustments" Then
                        '    Case Is <> "Transactions", Is <> "Vouchers"

                        Dim frmName As String = e.SelectedTable
                        mCurrentForm = FormFunctions.GetFormByName(frmName)
                        For i = 0 To mdiFrm.Length - 1
                            If mdiFrm(i).Name = frmName Then
                                mdiFrm(i).Activate()
                                mdiFrm(i).BringToFront()
                                Exit Try
                            End If
                        Next
                        mCurrentForm.AccessibleName = frmName
                        mCurrentForm.AccessibleDescription = e.SelectedTableNature
                        mCurrentForm.WindowState = FormWindowState.Maximized
                        mCurrentForm.Tag = AzamTechnologies.DataManager.DataMode.Insert
                        mCurrentForm.MdiParent = Me
                        mCurrentForm.Show()

                        '
                        'Transactions()
                        '
                    ElseIf e.SelectedTable = "Transactions" Then
                        If e.SelectedTableNature = SaleInvoiceNature Then
                            mCurrentForm = New Invoices
                            For i = 0 To mdiFrm.Length - 1
                                If mdiFrm(i).Name = mCurrentForm.Name Then
                                    mdiFrm(i).Activate()
                                    mdiFrm(i).BringToFront()
                                    Exit Try
                                End If
                            Next
                            mCurrentForm.MdiParent = Me
                            mCurrentForm.AccessibleName = e.SelectedTable
                            mCurrentForm.AccessibleDescription = e.SelectedTableNature
                            mCurrentForm.WindowState = FormWindowState.Maximized
                            mCurrentForm.Tag = AzamTechnologies.DataManager.DataMode.Insert
                            mCurrentForm.Show()
                        ElseIf e.SelectedTableNature = ReceivingReturnNature Then
                            'mCurrentForm = New ReceivingReturn
                            'For i = 0 To mdiFrm.Length - 1
                            '    If mdiFrm(i).Name = mCurrentForm.Name Then
                            '        mdiFrm(i).Activate()
                            '        mdiFrm(i).BringToFront()
                            '        Exit Try
                            '    End If
                            'Next
                            'mCurrentForm.MdiParent = Me
                            'mCurrentForm.AccessibleName = e.SelectedTable
                            'mCurrentForm.AccessibleDescription = e.SelectedTableNature
                            'mCurrentForm.WindowState = FormWindowState.Maximized
                            'mCurrentForm.Tag = FormDataActionMode.Insert
                            'mCurrentForm.Show()
                        ElseIf e.SelectedTableNature = ReceivingNature Then
                            'mCurrentForm = New ReceivingReturn
                            'For i = 0 To mdiFrm.Length - 1
                            '    If mdiFrm(i).Name = mCurrentForm.Name Then
                            '        mdiFrm(i).Activate()
                            '        mdiFrm(i).BringToFront()
                            '        Exit Try
                            '    End If
                            'Next
                            'mCurrentForm.MdiParent = Me
                            'mCurrentForm.AccessibleName = e.SelectedTable
                            'mCurrentForm.AccessibleDescription = e.SelectedTableNature
                            'mCurrentForm.WindowState = FormWindowState.Maximized
                            'mCurrentForm.Tag = FormDataActionMode.Insert
                            'mCurrentForm.Show()
                        ElseIf e.SelectedTableNature = SaleInvoiceNature Then
                            'mCurrentForm = New SaleInvoice
                            'For i = 0 To mdiFrm.Length - 1
                            '    If mdiFrm(i).Name = mCurrentForm.Name Then
                            '        mdiFrm(i).Activate()
                            '        mdiFrm(i).BringToFront()
                            '        Exit Try
                            '    End If
                            'Next
                            'mCurrentForm.MdiParent = Me
                            'mCurrentForm.AccessibleName = e.SelectedTable
                            'mCurrentForm.AccessibleDescription = e.SelectedTableNature
                            'mCurrentForm.WindowState = FormWindowState.Maximized
                            'mCurrentForm.Tag = FormDataActionMode.Insert
                            'mCurrentForm.Show()
                        ElseIf e.SelectedTableNature = SaleInvoiceReturnNature Then
                            'mCurrentForm = New SaleReturn
                            'For i = 0 To mdiFrm.Length - 1
                            '    If mdiFrm(i).Name = mCurrentForm.Name Then
                            '        mdiFrm(i).Activate()
                            '        mdiFrm(i).BringToFront()
                            '        Exit Try
                            '    End If
                            'Next
                            'mCurrentForm.MdiParent = Me
                            'mCurrentForm.AccessibleName = e.SelectedTable
                            'mCurrentForm.AccessibleDescription = e.SelectedTableNature
                            'mCurrentForm.WindowState = FormWindowState.Maximized
                            'mCurrentForm.Tag = FormDataActionMode.Insert
                            'mCurrentForm.Show()

                            '''''''''''''''GENERAL LEDGER
                        End If

                    ElseIf e.SelectedTable = "Vouchers" Then
                        If e.SelectedTableNature = JournalVoucherNature Then
                            mCurrentForm = New Vouchers
                            CType(mCurrentForm, Vouchers).NATURE.Text = JournalVoucherNature
                            CType(mCurrentForm, Vouchers).Text = "Journal Vouchers"
                            For i = 0 To mdiFrm.Length - 1
                                If mdiFrm(i).Text = mCurrentForm.Text Then
                                    mdiFrm(i).Activate()
                                    mdiFrm(i).BringToFront()
                                    Exit Try
                                End If
                            Next
                            mCurrentForm.MdiParent = Me
                            mCurrentForm.AccessibleName = e.SelectedTable
                            mCurrentForm.AccessibleDescription = e.SelectedTableNature
                            mCurrentForm.WindowState = FormWindowState.Maximized
                            mCurrentForm.Tag = AzamTechnologies.DataManager.DataMode.Insert
                            mCurrentForm.Show()
                        ElseIf e.SelectedTableNature = CashReceiptVoucherNature Then
                            mCurrentForm = New Vouchers
                            CType(mCurrentForm, Vouchers).NATURE.Text = CashReceiptVoucherNature
                            CType(mCurrentForm, Vouchers).Text = "Cash Receipt Vouchers"
                            For i = 0 To mdiFrm.Length - 1
                                If mdiFrm(i).Text = mCurrentForm.Text Then
                                    mdiFrm(i).Activate()
                                    mdiFrm(i).BringToFront()
                                    Exit Try
                                End If
                            Next
                            mCurrentForm.MdiParent = Me
                            mCurrentForm.AccessibleName = e.SelectedTable
                            mCurrentForm.AccessibleDescription = e.SelectedTableNature
                            mCurrentForm.WindowState = FormWindowState.Maximized
                            mCurrentForm.Tag = AzamTechnologies.DataManager.DataMode.Insert
                            mCurrentForm.Show()
                        ElseIf e.SelectedTableNature = CashPaymentVoucherNature Then
                            mCurrentForm = New Vouchers
                            CType(mCurrentForm, Vouchers).NATURE.Text = CashPaymentVoucherNature
                            CType(mCurrentForm, Vouchers).Text = "Cash Payment Vouchers"
                            For i = 0 To mdiFrm.Length - 1
                                If mdiFrm(i).Text = mCurrentForm.Text Then
                                    mdiFrm(i).Activate()
                                    mdiFrm(i).BringToFront()
                                    Exit Try
                                End If
                            Next
                            mCurrentForm.MdiParent = Me
                            mCurrentForm.AccessibleName = e.SelectedTable
                            mCurrentForm.AccessibleDescription = e.SelectedTableNature
                            mCurrentForm.WindowState = FormWindowState.Maximized
                            mCurrentForm.Tag = AzamTechnologies.DataManager.DataMode.Insert
                            mCurrentForm.Show()
                        ElseIf e.SelectedTableNature = BankPaymentVoucherNature Then
                            mCurrentForm = New Vouchers
                            CType(mCurrentForm, Vouchers).NATURE.Text = BankPaymentVoucherNature
                            CType(mCurrentForm, Vouchers).Text = "Bank Payment Vouchers"
                            For i = 0 To mdiFrm.Length - 1
                                If mdiFrm(i).Text = mCurrentForm.Text Then
                                    mdiFrm(i).Activate()
                                    mdiFrm(i).BringToFront()
                                    Exit Try
                                End If
                            Next
                            mCurrentForm.MdiParent = Me
                            mCurrentForm.AccessibleName = e.SelectedTable
                            mCurrentForm.AccessibleDescription = e.SelectedTableNature
                            mCurrentForm.WindowState = FormWindowState.Maximized
                            mCurrentForm.Tag = AzamTechnologies.DataManager.DataMode.Insert
                            mCurrentForm.Show()
                        ElseIf e.SelectedTableNature = BankReceiptVoucherNature Then
                            mCurrentForm = New Vouchers
                            CType(mCurrentForm, Vouchers).NATURE.Text = BankReceiptVoucherNature
                            CType(mCurrentForm, Vouchers).Text = "Bank Receipt Vouchers"
                            For i = 0 To mdiFrm.Length - 1
                                If mdiFrm(i).Text = mCurrentForm.Text Then
                                    mdiFrm(i).Activate()
                                    mdiFrm(i).BringToFront()
                                    Exit Try
                                End If
                            Next
                            mCurrentForm.MdiParent = Me
                            mCurrentForm.AccessibleName = e.SelectedTable
                            mCurrentForm.AccessibleDescription = e.SelectedTableNature
                            mCurrentForm.WindowState = FormWindowState.Maximized
                            mCurrentForm.Tag = AzamTechnologies.DataManager.DataMode.Insert
                            mCurrentForm.Show()

                        End If
                    ElseIf e.SelectedTable = "VehicleAdjustments" Then
                        If e.SelectedTableNature = VehiclePaymentNature Then
                            mCurrentForm = New VehicleAdjustments
                            CType(mCurrentForm, VehicleAdjustments).NATURE.Text = VehiclePaymentNature
                            CType(mCurrentForm, VehicleAdjustments).Text = "Vehicle Payment"
                            For i = 0 To mdiFrm.Length - 1
                                If mdiFrm(i).Text = mCurrentForm.Text Then
                                    mdiFrm(i).Activate()
                                    mdiFrm(i).BringToFront()
                                    Exit Try
                                End If
                            Next
                            mCurrentForm.MdiParent = Me
                            mCurrentForm.AccessibleName = e.SelectedTable
                            mCurrentForm.AccessibleDescription = e.SelectedTableNature
                            mCurrentForm.WindowState = FormWindowState.Maximized
                            mCurrentForm.Tag = AzamTechnologies.DataManager.DataMode.Insert
                            mCurrentForm.Show()
                        ElseIf e.SelectedTableNature = VehicleReceiptNature Then
                            mCurrentForm = New VehicleAdjustments
                            CType(mCurrentForm, VehicleAdjustments).NATURE.Text = VehicleReceiptNature
                            CType(mCurrentForm, VehicleAdjustments).Text = "Vehicle Receipt"
                            For i = 0 To mdiFrm.Length - 1
                                If mdiFrm(i).Text = mCurrentForm.Text Then
                                    mdiFrm(i).Activate()
                                    mdiFrm(i).BringToFront()
                                    Exit Try
                                End If
                            Next
                            mCurrentForm.MdiParent = Me
                            mCurrentForm.AccessibleName = e.SelectedTable
                            mCurrentForm.AccessibleDescription = e.SelectedTableNature
                            mCurrentForm.WindowState = FormWindowState.Maximized
                            mCurrentForm.Tag = AzamTechnologies.DataManager.DataMode.Insert
                            mCurrentForm.Show()
                        ElseIf e.SelectedTableNature = VehicleAdjustmentReceiptNature Then
                            mCurrentForm = New VehicleAdjustments
                            CType(mCurrentForm, VehicleAdjustments).NATURE.Text = VehicleAdjustmentReceiptNature
                            CType(mCurrentForm, VehicleAdjustments).Text = "Vehicle Adjustment Receipt"
                            For i = 0 To mdiFrm.Length - 1
                                If mdiFrm(i).Text = mCurrentForm.Text Then
                                    mdiFrm(i).Activate()
                                    mdiFrm(i).BringToFront()
                                    Exit Try
                                End If
                            Next
                            mCurrentForm.MdiParent = Me
                            mCurrentForm.AccessibleName = e.SelectedTable
                            mCurrentForm.AccessibleDescription = e.SelectedTableNature
                            mCurrentForm.WindowState = FormWindowState.Maximized
                            mCurrentForm.Tag = AzamTechnologies.DataManager.DataMode.Insert
                            mCurrentForm.Show()
                        ElseIf e.SelectedTableNature = VehicleAdjustmentPaymentNature Then
                            mCurrentForm = New VehicleAdjustments
                            CType(mCurrentForm, VehicleAdjustments).NATURE.Text = VehicleAdjustmentPaymentNature
                            CType(mCurrentForm, VehicleAdjustments).Text = "Vehicle Adjustment Payment"
                            For i = 0 To mdiFrm.Length - 1
                                If mdiFrm(i).Text = mCurrentForm.Text Then
                                    mdiFrm(i).Activate()
                                    mdiFrm(i).BringToFront()
                                    Exit Try
                                End If
                            Next
                            mCurrentForm.MdiParent = Me
                            mCurrentForm.AccessibleName = e.SelectedTable
                            mCurrentForm.AccessibleDescription = e.SelectedTableNature
                            mCurrentForm.WindowState = FormWindowState.Maximized
                            mCurrentForm.Tag = AzamTechnologies.DataManager.DataMode.Insert
                            mCurrentForm.Show()
                        End If
                    End If
                End If
            End If
            Dim tab As Infragistics.Win.UltraWinTabbedMdi.MdiTab
            tab = Me.UltraTabbedMdiManager1.TabFromForm(mCurrentForm)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Control And e.KeyCode = Keys.R Then
            'ElseIf e.KeyCode = Keys.Enter Then
            ' SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub frmMain_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Me.IcnSystm.Visible = False
        Application.Exit()
    End Sub
    Private Sub mnuCustomerFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCustomerFile.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Customers", "", Nothing, Nothing))
    End Sub

    Private Sub mnuSupplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSupplier.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Suppliers", "", Nothing, Nothing))
    End Sub

    Private Sub mnuCities_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCitiesFile.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Cities", "", Nothing, Nothing))
    End Sub
    Private Sub mnuVihicles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVihiclesFile.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Vehicles", "", Nothing, Nothing))
    End Sub

    Private Sub mnuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Items", "", Nothing, Nothing))
    End Sub
    Private Sub mnuOpeningBalaces_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpeningBalaces.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "OpeningBalances", "", Nothing, Nothing))
    End Sub

    Private Sub mnuVehicleListReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVehicleListReport.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.VehicleList
        rptForm.Show()
    End Sub
    Private Sub DataManager1_Action(ByVal sender As Object, ByVal e As AzamTechnologies.DataManager.DataActionEveArgs) Handles DataManager1.Action
        SettingMode(e.ActionMode)
        Select Case e.ActionMode
            Case AzamTechnologies.DataManager.DataMode.Locked
                Me.stpText.Text = "Ready..."
                ''''Invoice
                If Me.ActiveMdiChild.Name = "Invoices" Then
                ElseIf Me.ActiveMdiChild.Name = "Vouchers" Then
                    CType(Me.ActiveMdiChild, Vouchers).CalculateTotals()
                End If
            Case AzamTechnologies.DataManager.DataMode.Insert
                Me.stpText.Text = "Inserting Record..."
            Case AzamTechnologies.DataManager.DataMode.Deleting
                Me.stpText.Text = "Deleting Record..."
            Case AzamTechnologies.DataManager.DataMode.Delete

            Case AzamTechnologies.DataManager.DataMode.Save

            Case AzamTechnologies.DataManager.DataMode.Saving
                If Me.ActiveMdiChild.Name = "Vouchers" Then
                    If CType(Me.ActiveMdiChild, Vouchers).ValidateData = False Then
                        DataManager1.Cancel = True
                        Exit Sub
                    Else
                        DataManager1.Cancel = False
                    End If
                    Dim d As New System.ComponentModel.CancelEventArgs
                    CType(Me.ActiveMdiChild, Vouchers).dtpDate_Validating(Me, d)
                    If d.Cancel = True Then
                        DataManager1.Cancel = True
                        Exit Sub
                    Else
                        DataManager1.Cancel = False
                    End If
                ElseIf Me.ActiveMdiChild.Name = "VehicleAdjustments" Then
                    If CType(Me.ActiveMdiChild, VehicleAdjustments).ValidateData = False Then
                        DataManager1.Cancel = True
                        Exit Sub
                    Else
                        DataManager1.Cancel = False
                    End If
                    Dim d As New System.ComponentModel.CancelEventArgs
                    CType(Me.ActiveMdiChild, VehicleAdjustments).dtpDate_Validating(Me, d)
                    If d.Cancel = True Then
                        DataManager1.Cancel = True
                        Exit Sub
                    Else
                        DataManager1.Cancel = False
                    End If
                ElseIf Me.ActiveMdiChild.Name = "Invoices" Then
                    Dim d As New System.ComponentModel.CancelEventArgs
                    CType(Me.ActiveMdiChild, Invoices).dtpDate_Validating(Me, d)
                    If d.Cancel = True Then
                        DataManager1.Cancel = True
                        Exit Sub
                    Else
                        DataManager1.Cancel = False
                    End If
                ElseIf Me.ActiveMdiChild.Name = "Receipts" Then
                    Dim d As New System.ComponentModel.CancelEventArgs
                    CType(Me.ActiveMdiChild, Receipts).dtpDate_Validating(Me, d)
                    If d.Cancel = True Then
                        DataManager1.Cancel = True
                        Exit Sub
                    Else
                        DataManager1.Cancel = False
                    End If
                ElseIf Me.ActiveMdiChild.Name = "CustomerBills" Then
                    Dim d As New System.ComponentModel.CancelEventArgs
                    CType(Me.ActiveMdiChild, CustomerBills).DtpDate_Validating(Me, d)
                    If d.Cancel = True Then
                        DataManager1.Cancel = True
                        Exit Sub
                    Else
                        DataManager1.Cancel = False
                    End If

                    '''''''''User Secrurity
                ElseIf Me.ActiveMdiChild.Name = "UserSecurities" Then
                    If CType(Me.ActiveMdiChild, UserSecurities).ValidateData = False Then
                        DataManager1.Cancel = True
                        Exit Sub
                    Else
                        DataManager1.Cancel = False
                    End If
                End If
            Case AzamTechnologies.DataManager.DataMode.Undo

            Case AzamTechnologies.DataManager.DataMode.Edit
                If Me.ActiveMdiChild.Name = "Vouchers" Then
                    CType(Me.ActiveMdiChild, Vouchers).SetCreditDebitTotal(e.ActionMode)
                End If

            Case AzamTechnologies.DataManager.DataMode.Printing
            Case AzamTechnologies.DataManager.DataMode.Print
        End Select
    End Sub
    'Function GetFormByName(ByVal FormName As String) As Form
    '    Dim T As Type = Type.GetType("B-Leaf.Inventory." & FormName, True, True)
    '    Return CType(Activator.CreateInstance(T), Form)
    'End Function
    Sub SettingMode(ByVal Mode As AzamTechnologies.DataManager.DataMode)
        Select Case Mode
            Case AzamTechnologies.DataManager.DataMode.Insert
                Me.stpText.Text = "Record Inserted.."
            Case AzamTechnologies.DataManager.DataMode.Inserting
                Me.stpText.Text = "Inserting Record .."
            Case AzamTechnologies.DataManager.DataMode.Delete
                Me.stpText.Text = "Record Deleted.."
            Case AzamTechnologies.DataManager.DataMode.Deleting
                Me.stpText.Text = "Deleting Record.."
            Case AzamTechnologies.DataManager.DataMode.Edit
                Me.stpText.Text = "Record Editing.."
            Case AzamTechnologies.DataManager.DataMode.Locked
                Me.stpText.Text = "Ready.."
            Case AzamTechnologies.DataManager.DataMode.Print
                Me.stpText.Text = "Record Printed.."
            Case AzamTechnologies.DataManager.DataMode.Printing
                Me.stpText.Text = "Printing Record.."
            Case AzamTechnologies.DataManager.DataMode.Save
                Me.stpText.Text = "Record Saved.."
            Case AzamTechnologies.DataManager.DataMode.Saving
                Me.stpText.Text = "Saving Record.."
            Case AzamTechnologies.DataManager.DataMode.Undo
                Me.stpText.Text = "Undone Record.."
        End Select

    End Sub
    Private Sub DataManager1_PrintActionPerformed(ByVal sender As Object, ByVal e As AzamTechnologies.DataManager.PrintActionEventArgs) Handles DataManager1.Print
        Dim rpViewer As New ReportViewer
        Me.Cursor = Cursors.WaitCursor
        Try
            If e.ReportAction <> AzamTechnologies.DataManager.PrintActionEventArgs.Actions.Detail Then
                Select Case e.ReportTypes
                    ''''Card View
                    Case AzamTechnologies.DataManager.PrintActionEventArgs.ReportStyle.Document
                        If e.ReportAction = AzamTechnologies.DataManager.PrintActionEventArgs.Actions.Preview Then
                            Dim rpDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
                            StartProcess(e.PrintFileName, e.ReportTypes.ToString, rpDoc, e.PrimaryParameters)
                            rpViewer.SetSource = rpDoc
                            rpViewer.MdiParent = Me
                            rpViewer.Show()
                        ElseIf e.ReportAction = AzamTechnologies.DataManager.PrintActionEventArgs.Actions.Print Then
                            Dim rpDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
                            StartProcess(e.PrintFileName, e.ReportTypes.ToString, rpDoc, e.PrimaryParameters)
                            rpViewer.SetSource = rpDoc
                            rpViewer.MdiParent = Me
                            rpDoc.PrintToPrinter(1, True, 1, 1)
                            MessageBox.Show("printing....... ")

                        End If
                        '''''''Listing
                    Case AzamTechnologies.DataManager.PrintActionEventArgs.ReportStyle.Listing
                        If e.ReportAction = AzamTechnologies.DataManager.PrintActionEventArgs.Actions.Preview Then
                            Dim rpDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
                            StartProcess(e.PrintFileName, e.ReportTypes.ToString, rpDoc)
                            rpViewer.SetSource = rpDoc
                            rpViewer.MdiParent = Me
                            rpViewer.Show()
                        ElseIf e.ReportAction = AzamTechnologies.DataManager.PrintActionEventArgs.Actions.Print Then
                            Dim rpDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument = Nothing
                            StartProcess(e.PrintFileName, e.ReportTypes.ToString, rpDoc, e.PrimaryParameters)
                            rpViewer.SetSource = rpDoc
                            rpViewer.MdiParent = Me
                            rpDoc.PrintToPrinter(1, True, 1, 1)
                            MessageBox.Show("printing....... ")
                        End If
                End Select
            Else
                Dim rptForm As New ReportParameters
                rptForm.MdiParent = Me
                rptForm.Show()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UnderConstructionMessage()
    End Sub

    Private Sub mnuUserProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUserProfile.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "UserSecurities", Nothing, Nothing, Nothing))
    End Sub
    Private Sub MenuLogOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLogOff.Click
        'Application.Exit()
        Dim frmlo As New FrmLogin
        frmlo.ShowDialog(Me)
    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
        UnderConstructionMessage()
    End Sub

    Private Sub ToolStripMenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
        Dim frm As New frmSplash
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        If MessageBox.Show("Are you sure to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub mnuReceiving_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Transactions", ReceivingNature, Nothing, Nothing))
    End Sub

    Private Sub mnuReceivingRet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReceivingRet.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Receipts", Nothing, Nothing, Nothing))
    End Sub

    Private Sub mnuInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInvoice.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Invoices", Nothing, Nothing, Nothing))
    End Sub

    Private Sub mnuInvoiceRet_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Transactions", SaleInvoiceReturnNature, Nothing, Nothing))
    End Sub

    Private Sub mnuProdRecDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProdRecDocument.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.ProductReceiving
        rptForm.Show()
    End Sub

    Private Sub mnuProdRecRetDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.ProductReceivingReturn
        rptForm.Show()
    End Sub

    Private Sub mnuSaleInvDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSaleInvDocument.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.SaleInvoice
        rptForm.Show()
    End Sub

    Private Sub mnuSaleInvRetDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.SaleInvoiceReturn
        rptForm.Show()
    End Sub


    Private Sub mnuRegions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRegionsFile.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "StationPoints", "", Nothing, Nothing))

    End Sub

    Private Sub mnuGeneralLedger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemLedger.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.GeneralLedger
        rptForm.Show()
    End Sub

    Private Sub mnuRptTrialBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRptTrialBalance.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.TrialBalance
        rptForm.Show()
    End Sub

    Private Sub mnuVihicleOwnersFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVihicleOwnerFile.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "VehicleOwners", "", Nothing, Nothing))
    End Sub
    Private Sub mnuPackingFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProductsFile.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Products", "", Nothing, Nothing))
    End Sub


    Private Sub mnuBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBackup.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Backup", "", Nothing, Nothing))
    End Sub

    Private Sub mnuPosting_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuPosting.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Posting", "", Nothing, Nothing))
    End Sub

    Private Sub mnuRestore_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuRestore.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Restore", "", Nothing, Nothing))
    End Sub
    Private Sub mnuLargeIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLargeIcon.Click
        CType(Me.ActiveMdiChild, frmGrid).CatalogView = frmGrid.View.Large
        CType(Me.ActiveMdiChild, frmGrid).ChangeView()
    End Sub

    Private Sub mnuSmall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSmall.Click
        CType(Me.ActiveMdiChild, frmGrid).CatalogView = frmGrid.View.Small
        CType(Me.ActiveMdiChild, frmGrid).ChangeView()
    End Sub

    Private Sub mnuList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuList.Click
        CType(Me.ActiveMdiChild, frmGrid).CatalogView = frmGrid.View.List
        CType(Me.ActiveMdiChild, frmGrid).ChangeView()
    End Sub
    Private Sub mnuDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDetail.Click
        CType(Me.ActiveMdiChild, frmGrid).CatalogView = frmGrid.View.Detail
        CType(Me.ActiveMdiChild, frmGrid).ChangeView()
    End Sub
    Private Sub mnuHorizantal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHorizontal.Click
        For Each mnu As ToolStripMenuItem In Me.mnuWindowsArrange.DropDownItems
            mnu.Checked = False
        Next
        Me.mnuHorizontal.Checked = True
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub
    Private Sub mnuIcon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIcon.Click
        For Each mnu As ToolStripMenuItem In Me.mnuWindowsArrange.DropDownItems
            mnu.Checked = False
        Next
        Me.mnuIcon.Checked = True
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub
    Private Sub mnuVertical_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVertical.Click
        For Each mnu As ToolStripMenuItem In Me.mnuWindowsArrange.DropDownItems
            mnu.Checked = False
        Next
        Me.mnuVertical.Checked = True
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub
    Private Sub mnuCascade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCascade.Click
        For Each mnu As ToolStripMenuItem In Me.mnuWindowsArrange.DropDownItems
            mnu.Checked = False
        Next
        Me.mnuCascade.Checked = True
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub
    Private Sub IcnSystm_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles IcnSystm.DoubleClick
        Me.Activate()
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub stbMain_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles stbMain.DoubleClick
        Dim a As MonthCalendar
        If stbMain.Controls.Count = 0 Then
            a = New MonthCalendar
            a.Left = stbMain.Left + 300
            Me.stbMain.Size = a.Size
            a.Width = stpDate.Width
            Me.stbMain.Controls.Add(a)
            a.Show()
        Else

        End If
    End Sub
    Private Sub stbMain_PanelClick(ByVal sender As Object, ByVal e As System.Windows.Forms.StatusBarPanelClickEventArgs) Handles stbMain.PanelClick
        If stbMain.Controls.Count > 0 Then
            stbMain.Controls.RemoveAt(0)
            Me.stbMain.Height = 24
        End If
    End Sub
    Private Sub mnuAuditing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAuditing.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Auditing", "", Nothing, Nothing))
    End Sub

    Private Sub mnuUnPosting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUnPosting.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "UnPosting", "", Nothing, Nothing))
    End Sub

    Private Sub mnuProfitList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.ProfitListing
        rptForm.Show()
    End Sub

    Private Sub MnuBankReceiptVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuBankReceiptVoucher.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Vouchers", BankReceiptVoucherNature, Nothing, Nothing))
    End Sub

    Private Sub MnuJournalVouchers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuJournalVouchers.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Vouchers", JournalVoucherNature, Nothing, Nothing))
    End Sub

    Private Sub MnuCashReceiptVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCashReceiptVoucher.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Vouchers", CashReceiptVoucherNature, Nothing, Nothing))
    End Sub

    Private Sub MnuBankPaymentVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuBankPaymentVoucher.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Vouchers", BankPaymentVoucherNature, Nothing, Nothing))
    End Sub
    Private Sub MnuCashPaymentVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCashPaymentVoucher.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Vouchers", CashPaymentVoucherNature, Nothing, Nothing))
    End Sub
    Private Sub MnuCOAControls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCOAControls.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "COAControls", Nothing, Nothing, Nothing))
    End Sub

    Private Sub MnuCOAGenerals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCOAGenerals.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "COAGenerals", Nothing, Nothing, Nothing))
    End Sub

    Private Sub MnuCOASubsidiaries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCOASubsidiaries.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "COASubsidiaries", Nothing, Nothing, Nothing))
    End Sub

    Private Sub MnuCOASubSubsidiaries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "COASubSubsidiaries", Nothing, Nothing, Nothing))
    End Sub

    Private Sub MnuViewLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuViewLog.Click
        Dim frmlog As New EventViewer
        frmlog.WindowState = FormWindowState.Maximized
        frmlog.MdiParent = Me
        frmlog.Show()
    End Sub
    Private Sub ChartOfAccountReportList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCOAReportList.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.ChartOfAccountList
        rptForm.Show()
    End Sub

    Private Sub MnuJeneralVoucherReportDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuJeneralVoucherReportDoc.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.VoucherDocuments
        rptForm.Show()
    End Sub

    Private Sub MnuVoucherReportList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuVoucherReportList.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.VoucherList
        rptForm.Show()
    End Sub

    Private Sub MnuCOASubSubsidiaries_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCOASubSubsidiaries.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "COASubSubsidiaries", Nothing, Nothing, Nothing))
    End Sub
    Private Sub mnuSilver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSilver.Click
        My.Settings.Theme = Color.Silver
        loadStyle()
        SetToolBarTheme()
    End Sub
    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBlue.Click
        My.Settings.Theme = Color.Blue
        loadStyle()
        SetToolBarTheme()
    End Sub

    Private Sub mnuGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGreen.Click
        My.Settings.Theme = Color.Green
        loadStyle()
        SetToolBarTheme()
    End Sub

    Private Sub mnuBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBlack.Click
        My.Settings.Theme = Color.Black
        loadStyle()
        SetToolBarTheme()
        ''cc
    End Sub
    Sub SetToolBarTheme()
        If My.Settings.Theme = Color.Green Then
            Me.DataDirector1.BackColor = Color.Honeydew
            Me.DataManager1.BackColor = Color.Honeydew
            Me.MenuStrip1.BackColor = Color.Honeydew
        ElseIf My.Settings.Theme = Color.Blue Then
            'Me.DataDirector1.BackColor = Color.Honeydew
            'Me.DataManager1.BackColor = Color.Honeydew
            'Me.MenuStrip1.BackColor = Color.Honeydew
        ElseIf My.Settings.Theme = Color.Silver Then
            Me.DataDirector1.BackColor = Color.WhiteSmoke
            Me.DataManager1.BackColor = Color.WhiteSmoke
            Me.MenuStrip1.BackColor = Color.WhiteSmoke
        ElseIf My.Settings.Theme = Color.Black Then
            Me.DataDirector1.BackColor = Color.WhiteSmoke
            Me.DataManager1.BackColor = Color.WhiteSmoke
            Me.MenuStrip1.BackColor = Color.WhiteSmoke
        End If
    End Sub
    Private Sub mnuBranches_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBranches.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Branches", Nothing, Nothing, Nothing))
    End Sub

    Private Sub mnuDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDivision.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Divisions", Nothing, Nothing, Nothing))
    End Sub

    Private Sub mnuBanks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBanks.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "Banks", Nothing, Nothing, Nothing))
    End Sub

    Private Sub mnuProductRates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProductRates.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "ProductRates", Nothing, Nothing, Nothing))
    End Sub
    Private Sub MnuBillGeneration_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuBillGeneration.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "CustomerBills", Nothing, Nothing, Nothing))
    End Sub

    Private Sub MnuProductValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuProductValue.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "ProductValues", Nothing, Nothing, Nothing))
    End Sub

    Private Sub MnuVehicleBills_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuVehicleBills.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.VehicleBills
        rptForm.Show()
    End Sub

    Private Sub mnuOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOptions.Click
        Dim frmOpt As New FrmOption
        frmOpt.MdiParent = Me
        frmOpt.Show()
    End Sub
    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "DestinationPoints", "", Nothing, Nothing))
    End Sub

    Private Sub CashFlowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashFlowToolStripMenuItem.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.CashFlowStatements
        rptForm.Show()
    End Sub

    Private Sub mnuFSFControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFSFControl.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "FSFControls", Nothing, Nothing, Nothing))
    End Sub

    Private Sub MnuFSFGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuFSFGeneral.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "FSFGenerals", Nothing, Nothing, Nothing))
    End Sub

    Private Sub MnuFSFSubsidiaries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuFSFSubsidiaries.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "FSFSubsidiaries", Nothing, Nothing, Nothing))
    End Sub

    Private Sub MnuFSFSubSubsidiaries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuFSFSubSubsidiaries.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "FSFSubSubsidiaries", Nothing, Nothing, Nothing))
    End Sub

    Private Sub FinancialStatementsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinancialStatementsToolStripMenuItem.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.BalanceSheet
        rptForm.Show()
    End Sub

    Private Sub mnuVFreghtStatements_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVFreghtStatements.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.FreightStatement
        rptForm.Show()
    End Sub

    Private Sub MnuFreightAnalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuFreightAnalysis.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.VehicleBillAnalysis
        rptForm.Show()
    End Sub

    Private Sub MnuVehicleLedger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuVehicleLedger.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.VehicleLedger
        rptForm.Show()
    End Sub
    Public Enum FormSelectedMode
        Normal
        Grid
    End Enum
    Public Class ProjectViewerEventArgs
        Inherits EventArgs
        Public FormSelectdMode As FormSelectedMode
        Public SelectedTable As String
        Public SelectedTableNature As String
        Public ParentNodeText As String
        Public SystemNodeText As String
        Sub New(ByVal formSelectedMode As FormSelectedMode, ByVal tableName As String, ByVal tableNature As String, ByVal parentNode As String, ByVal system As String)
            FormSelectdMode = formSelectedMode
            SelectedTable = tableName
            SelectedTableNature = tableNature
            ParentNodeText = parentNode
            SystemNodeText = system
        End Sub
    End Class
    Private Sub TransportManagementSystem_ItemClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinExplorerBar.ItemEventArgs) Handles TransportManagementSystem.ItemClick
        Dim selectedTable As String
        Dim i As Integer = InStr(1, e.Item.Tag, ".")
        If i = 0 Then
            selectedTable = e.Item.Text
        Else
            selectedTable = Mid(e.Item.Tag, i + 1)
        End If

        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Grid, selectedTable, e.Item.Key, e.Item.Group.Text, Nothing))
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub mnuProjectViewer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProjectViewer.Click
        mnuProjectViewer.Checked = Not (mnuProjectViewer.Checked)
        Me.TransportManagementSystem.Visible = mnuProjectViewer.Checked
        'Me.TransportManagementSystem.Visible = True
        If mnuProjectViewer.Checked = True Then
            Me.DockableWindow1.Pane.Show()
        Else
            Me.DockableWindow1.Pane.Close()
        End If

    End Sub

    Private Sub UltraDockManager1_PaneHidden(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinDock.PaneHiddenEventArgs) Handles UltraDockManager1.PaneHidden
        If e.Pane.Text = "TMS Files" Then
            Me.mnuProjectViewer.Checked = False
        End If
    End Sub

    Private Sub MnuVehicleRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuVehicleRec.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "VehicleAdjustments", VehicleReceiptNature, Nothing, Nothing))
    End Sub

    Private Sub MnuVehiclePayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuVehiclePayment.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "VehicleAdjustments", VehiclePaymentNature, Nothing, Nothing))
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "TransactionTypes", Nothing, Nothing, Nothing))
    End Sub

    Private Sub MnuVoucherGeneration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuVoucherGeneration.Click
        Dim frm As New Management
        frm.Owner = Me
        frm.ManageType = Management.ManagementType.VoucherGeneration
        Me.Cursor = Cursors.Default
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub MnuVehAdjustRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuVehAdjustRec.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "VehicleAdjustments", VehicleAdjustmentReceiptNature, Nothing, Nothing))
    End Sub

    Private Sub MnuVehAdjPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuVehAdjPay.Click
        SelectFile(New ProjectViewerEventArgs(FormSelectedMode.Normal, "VehicleAdjustments", VehicleAdjustmentPaymentNature, Nothing, Nothing))
    End Sub
    Private Sub MnuTransactionList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuTransactionList.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.TransactionList
        rptForm.Show()
    End Sub

    Private Sub mnuVehicleRevenue_Click(sender As Object, e As EventArgs)
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.VehicleRevenue
        rptForm.Show()
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        Dim rptForm As New ReportParameters
        rptForm.MdiParent = Me
        rptForm.ReportFile = ReportProcess.ReportFiles.VehicleRevenuePivot
        rptForm.Show()
    End Sub
End Class

Public Class FormFunctions
    Public Shared Function GetFormByName(ByVal FormName As String) As Form
        Try
            'first try: in case the full namespace has been provided (as it should  ) 
            Dim T As Type = Type.GetType(FormName, False)
            'if not found, search for it 
            If T Is Nothing Then T = FindType(FormName)
            'if still not found, throw exception 
            If T Is Nothing Then Throw New Exception(FormName + " could not be found")
            Return CType(Activator.CreateInstance(T), Form)
        Catch ex As TargetInvocationException
            Throw ex
        Catch ex As Exception
            Throw ex

        End Try
    End Function
#Region "Assemblies and types"
    Public Shared Function GetAllAssemblies() As ArrayList
        Dim al As New ArrayList
        Dim a As [Assembly] = [Assembly].GetEntryAssembly()
        FillAssemblies(a, al)
        Return al
    End Function

    Private Shared Sub FillAssemblies(ByVal a As [Assembly], ByVal al As ArrayList)
        If Not al.Contains(a) Then
            al.Add(a)
            Dim an As AssemblyName
            For Each an In a.GetReferencedAssemblies()
                If Not an.Name.StartsWith("System") Then FillAssemblies([Assembly].Load(an), al)
            Next
        End If
    End Sub

    Public Shared Function GetAllTypes() As ArrayList
        Dim a As [Assembly], t As Type, al As New ArrayList
        For Each a In GetAllAssemblies()
            For Each t In a.GetTypes
                If Not al.Contains(t) Then al.Add(t)
            Next
        Next
        Return al
    End Function

    Public Shared Function FindType(ByVal Name As String) As Type
        Dim T As Type
        For Each T In GetAllTypes()
            If T.Name = Name Then Return T
        Next
        Return Nothing
    End Function
#End Region
End Class

