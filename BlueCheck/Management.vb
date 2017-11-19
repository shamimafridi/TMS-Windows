Imports System.Data.SqlClient
Imports AzamTechnologies.Database
Imports BusinessLeaf.Inventory
Public Class Management
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
    Friend WithEvents LblLabel As System.Windows.Forms.Label
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents imgManageType As System.Windows.Forms.PictureBox
    Friend WithEvents pnlBackup As System.Windows.Forms.Panel
    Friend WithEvents txtBackupLocation As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PnlRestore As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBrowsBackup As System.Windows.Forms.Button
    Friend WithEvents dtLastBackupDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtCurrentBackupDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtCurrentRestoreDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnBrowsRestore As System.Windows.Forms.Button
    Friend WithEvents txtRestoreLocation As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents fdbOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents fdbFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents pgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpLastPostingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCurrentPostingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PnlPosting As System.Windows.Forms.Panel
    Friend WithEvents PnlAuditing As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PnlUnposting As System.Windows.Forms.Panel
    Friend WithEvents dtpLastPostingdateUp As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmdChkDocumentNatureList As System.Windows.Forms.Button
    Friend WithEvents TxtDocumentNature As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtToTransactionNo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtFromTransactionNo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dtpToPostingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromPostingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents LstTransactionNature As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TxtBranchCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblBranchCode As System.Windows.Forms.Label
    Friend WithEvents CmdBranchList As System.Windows.Forms.Button
    Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
    Friend WithEvents PnlVoucherGeneration As System.Windows.Forms.Panel
    Friend WithEvents CmbTransactionNature As Infragistics.Win.UltraWinEditors.UltraComboEditor
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DtpToDateVG As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents DtpFromDateVG As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtLastBackupDateRt As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Management))
        Dim ValueListItem3 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem4 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem6 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem5 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem1 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Dim ValueListItem2 As Infragistics.Win.ValueListItem = New Infragistics.Win.ValueListItem
        Me.imgManageType = New System.Windows.Forms.PictureBox
        Me.LblLabel = New System.Windows.Forms.Label
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.pgBar = New System.Windows.Forms.ProgressBar
        Me.pnlBackup = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtCurrentBackupDate = New System.Windows.Forms.DateTimePicker
        Me.dtLastBackupDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBrowsBackup = New System.Windows.Forms.Button
        Me.txtBackupLocation = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.PnlRestore = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtCurrentRestoreDate = New System.Windows.Forms.DateTimePicker
        Me.dtLastBackupDateRt = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnBrowsRestore = New System.Windows.Forms.Button
        Me.txtRestoreLocation = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label4 = New System.Windows.Forms.Label
        Me.fdbOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.fdbFolder = New System.Windows.Forms.FolderBrowserDialog
        Me.PnlPosting = New System.Windows.Forms.Panel
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpCurrentPostingDate = New System.Windows.Forms.DateTimePicker
        Me.dtpLastPostingDate = New System.Windows.Forms.DateTimePicker
        Me.PnlAuditing = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.PnlUnposting = New System.Windows.Forms.Panel
        Me.CmdBranchList = New System.Windows.Forms.Button
        Me.lblBranchCode = New System.Windows.Forms.Label
        Me.CmdChkDocumentNatureList = New System.Windows.Forms.Button
        Me.TxtDocumentNature = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtToTransactionNo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtpToPostingDate = New System.Windows.Forms.DateTimePicker
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtFromTransactionNo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpFromPostingDate = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.dtpLastPostingdateUp = New System.Windows.Forms.DateTimePicker
        Me.TxtBranchCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.LstTransactionNature = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
        Me.PnlVoucherGeneration = New System.Windows.Forms.Panel
        Me.CmbTransactionNature = New Infragistics.Win.UltraWinEditors.UltraComboEditor
        Me.Label18 = New System.Windows.Forms.Label
        Me.DtpToDateVG = New System.Windows.Forms.DateTimePicker
        Me.Label20 = New System.Windows.Forms.Label
        Me.DtpFromDateVG = New System.Windows.Forms.DateTimePicker
        Me.Label22 = New System.Windows.Forms.Label
        CType(Me.imgManageType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBackup.SuspendLayout()
        CType(Me.txtBackupLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlRestore.SuspendLayout()
        CType(Me.txtRestoreLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlPosting.SuspendLayout()
        Me.PnlAuditing.SuspendLayout()
        Me.PnlUnposting.SuspendLayout()
        CType(Me.TxtDocumentNature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToTransactionNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromTransactionNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtBranchCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlVoucherGeneration.SuspendLayout()
        CType(Me.CmbTransactionNature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgManageType
        '
        Me.imgManageType.Image = CType(resources.GetObject("imgManageType.Image"), System.Drawing.Image)
        Me.imgManageType.Location = New System.Drawing.Point(459, 44)
        Me.imgManageType.Name = "imgManageType"
        Me.imgManageType.Size = New System.Drawing.Size(166, 183)
        Me.imgManageType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgManageType.TabIndex = 12
        Me.imgManageType.TabStop = False
        '
        'LblLabel
        '
        Me.LblLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLabel.Location = New System.Drawing.Point(-3, 9)
        Me.LblLabel.Name = "LblLabel"
        Me.LblLabel.Size = New System.Drawing.Size(276, 20)
        Me.LblLabel.TabIndex = 13
        Me.LblLabel.Text = "Backup Database"
        '
        'cmdOk
        '
        Me.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOk.Location = New System.Drawing.Point(22, 259)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(72, 24)
        Me.cmdOk.TabIndex = 0
        Me.cmdOk.Text = "&Ok"
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdCancel.Location = New System.Drawing.Point(102, 259)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(72, 24)
        Me.cmdCancel.TabIndex = 14
        Me.cmdCancel.Text = "&Cancel"
        '
        'pgBar
        '
        Me.pgBar.Location = New System.Drawing.Point(22, 295)
        Me.pgBar.Name = "pgBar"
        Me.pgBar.Size = New System.Drawing.Size(152, 16)
        Me.pgBar.TabIndex = 16
        '
        'pnlBackup
        '
        Me.pnlBackup.Controls.Add(Me.Label3)
        Me.pnlBackup.Controls.Add(Me.Label2)
        Me.pnlBackup.Controls.Add(Me.dtCurrentBackupDate)
        Me.pnlBackup.Controls.Add(Me.dtLastBackupDate)
        Me.pnlBackup.Controls.Add(Me.Label1)
        Me.pnlBackup.Controls.Add(Me.txtBrowsBackup)
        Me.pnlBackup.Controls.Add(Me.txtBackupLocation)
        Me.pnlBackup.Location = New System.Drawing.Point(12, 73)
        Me.pnlBackup.Name = "pnlBackup"
        Me.pnlBackup.Size = New System.Drawing.Size(384, 95)
        Me.pnlBackup.TabIndex = 17
        Me.pnlBackup.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Current Backup Date"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Backup Date"
        '
        'dtCurrentBackupDate
        '
        Me.dtCurrentBackupDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCurrentBackupDate.Location = New System.Drawing.Point(122, 36)
        Me.dtCurrentBackupDate.Name = "dtCurrentBackupDate"
        Me.dtCurrentBackupDate.Size = New System.Drawing.Size(104, 20)
        Me.dtCurrentBackupDate.TabIndex = 1
        '
        'dtLastBackupDate
        '
        Me.dtLastBackupDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtLastBackupDate.Location = New System.Drawing.Point(122, 8)
        Me.dtLastBackupDate.Name = "dtLastBackupDate"
        Me.dtLastBackupDate.Size = New System.Drawing.Size(104, 20)
        Me.dtLastBackupDate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Backup Location"
        '
        'txtBrowsBackup
        '
        Me.txtBrowsBackup.Location = New System.Drawing.Point(330, 60)
        Me.txtBrowsBackup.Name = "txtBrowsBackup"
        Me.txtBrowsBackup.Size = New System.Drawing.Size(20, 20)
        Me.txtBrowsBackup.TabIndex = 1
        Me.txtBrowsBackup.Text = "--"
        '
        'txtBackupLocation
        '
        Me.txtBackupLocation.Location = New System.Drawing.Point(122, 61)
        Me.txtBackupLocation.Name = "txtBackupLocation"
        Me.txtBackupLocation.ReadOnly = True
        Me.txtBackupLocation.Size = New System.Drawing.Size(204, 21)
        Me.txtBackupLocation.TabIndex = 0
        '
        'PnlRestore
        '
        Me.PnlRestore.Controls.Add(Me.Label5)
        Me.PnlRestore.Controls.Add(Me.dtCurrentRestoreDate)
        Me.PnlRestore.Controls.Add(Me.dtLastBackupDateRt)
        Me.PnlRestore.Controls.Add(Me.Label6)
        Me.PnlRestore.Controls.Add(Me.btnBrowsRestore)
        Me.PnlRestore.Controls.Add(Me.txtRestoreLocation)
        Me.PnlRestore.Controls.Add(Me.Label4)
        Me.PnlRestore.Location = New System.Drawing.Point(15, 74)
        Me.PnlRestore.Name = "PnlRestore"
        Me.PnlRestore.Size = New System.Drawing.Size(384, 95)
        Me.PnlRestore.TabIndex = 18
        Me.PnlRestore.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Last Restore Date"
        '
        'dtCurrentRestoreDate
        '
        Me.dtCurrentRestoreDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCurrentRestoreDate.Location = New System.Drawing.Point(122, 36)
        Me.dtCurrentRestoreDate.Name = "dtCurrentRestoreDate"
        Me.dtCurrentRestoreDate.Size = New System.Drawing.Size(104, 20)
        Me.dtCurrentRestoreDate.TabIndex = 4
        '
        'dtLastBackupDateRt
        '
        Me.dtLastBackupDateRt.Enabled = False
        Me.dtLastBackupDateRt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtLastBackupDateRt.Location = New System.Drawing.Point(122, 8)
        Me.dtLastBackupDateRt.Name = "dtLastBackupDateRt"
        Me.dtLastBackupDateRt.Size = New System.Drawing.Size(104, 20)
        Me.dtLastBackupDateRt.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Restore Location"
        '
        'btnBrowsRestore
        '
        Me.btnBrowsRestore.Location = New System.Drawing.Point(330, 60)
        Me.btnBrowsRestore.Name = "btnBrowsRestore"
        Me.btnBrowsRestore.Size = New System.Drawing.Size(20, 20)
        Me.btnBrowsRestore.TabIndex = 1
        Me.btnBrowsRestore.Text = "--"
        '
        'txtRestoreLocation
        '
        Me.txtRestoreLocation.Location = New System.Drawing.Point(122, 61)
        Me.txtRestoreLocation.Name = "txtRestoreLocation"
        Me.txtRestoreLocation.ReadOnly = True
        Me.txtRestoreLocation.Size = New System.Drawing.Size(204, 21)
        Me.txtRestoreLocation.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Current Restore Date"
        '
        'fdbOpenFile
        '
        Me.fdbOpenFile.Filter = "Database backup file |*.bak;"
        '
        'PnlPosting
        '
        Me.PnlPosting.Controls.Add(Me.Label7)
        Me.PnlPosting.Controls.Add(Me.Label8)
        Me.PnlPosting.Controls.Add(Me.dtpCurrentPostingDate)
        Me.PnlPosting.Controls.Add(Me.dtpLastPostingDate)
        Me.PnlPosting.Location = New System.Drawing.Point(12, 80)
        Me.PnlPosting.Name = "PnlPosting"
        Me.PnlPosting.Size = New System.Drawing.Size(384, 95)
        Me.PnlPosting.TabIndex = 19
        Me.PnlPosting.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Current Posting Date"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(12, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Last Posting Date"
        '
        'dtpCurrentPostingDate
        '
        Me.dtpCurrentPostingDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.dtpCurrentPostingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCurrentPostingDate.Location = New System.Drawing.Point(122, 36)
        Me.dtpCurrentPostingDate.Name = "dtpCurrentPostingDate"
        Me.dtpCurrentPostingDate.Size = New System.Drawing.Size(104, 20)
        Me.dtpCurrentPostingDate.TabIndex = 1
        Me.dtpCurrentPostingDate.Value = New Date(2010, 11, 26, 0, 0, 0, 0)
        '
        'dtpLastPostingDate
        '
        Me.dtpLastPostingDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.dtpLastPostingDate.Enabled = False
        Me.dtpLastPostingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLastPostingDate.Location = New System.Drawing.Point(122, 8)
        Me.dtpLastPostingDate.Name = "dtpLastPostingDate"
        Me.dtpLastPostingDate.Size = New System.Drawing.Size(104, 20)
        Me.dtpLastPostingDate.TabIndex = 2
        '
        'PnlAuditing
        '
        Me.PnlAuditing.Controls.Add(Me.Label9)
        Me.PnlAuditing.Controls.Add(Me.Label10)
        Me.PnlAuditing.Controls.Add(Me.DateTimePicker1)
        Me.PnlAuditing.Controls.Add(Me.DateTimePicker2)
        Me.PnlAuditing.Location = New System.Drawing.Point(12, 68)
        Me.PnlAuditing.Name = "PnlAuditing"
        Me.PnlAuditing.Size = New System.Drawing.Size(384, 95)
        Me.PnlAuditing.TabIndex = 20
        Me.PnlAuditing.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(12, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Current Posting Date"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(12, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Last Posting Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(122, 36)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(122, 8)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'PnlUnposting
        '
        Me.PnlUnposting.Controls.Add(Me.CmdBranchList)
        Me.PnlUnposting.Controls.Add(Me.lblBranchCode)
        Me.PnlUnposting.Controls.Add(Me.CmdChkDocumentNatureList)
        Me.PnlUnposting.Controls.Add(Me.TxtDocumentNature)
        Me.PnlUnposting.Controls.Add(Me.Label15)
        Me.PnlUnposting.Controls.Add(Me.txtToTransactionNo)
        Me.PnlUnposting.Controls.Add(Me.Label11)
        Me.PnlUnposting.Controls.Add(Me.dtpToPostingDate)
        Me.PnlUnposting.Controls.Add(Me.Label13)
        Me.PnlUnposting.Controls.Add(Me.txtFromTransactionNo)
        Me.PnlUnposting.Controls.Add(Me.Label14)
        Me.PnlUnposting.Controls.Add(Me.dtpFromPostingDate)
        Me.PnlUnposting.Controls.Add(Me.Label16)
        Me.PnlUnposting.Controls.Add(Me.Label12)
        Me.PnlUnposting.Controls.Add(Me.dtpLastPostingdateUp)
        Me.PnlUnposting.Controls.Add(Me.TxtBranchCode)
        Me.PnlUnposting.Controls.Add(Me.LstTransactionNature)
        Me.PnlUnposting.Location = New System.Drawing.Point(22, 44)
        Me.PnlUnposting.Name = "PnlUnposting"
        Me.PnlUnposting.Size = New System.Drawing.Size(431, 183)
        Me.PnlUnposting.TabIndex = 21
        Me.PnlUnposting.Visible = False
        '
        'CmdBranchList
        '
        Me.CmdBranchList.BackColor = System.Drawing.SystemColors.Window
        Me.CmdBranchList.Image = CType(resources.GetObject("CmdBranchList.Image"), System.Drawing.Image)
        Me.CmdBranchList.Location = New System.Drawing.Point(187, 24)
        Me.CmdBranchList.Name = "CmdBranchList"
        Me.CmdBranchList.Size = New System.Drawing.Size(24, 20)
        Me.CmdBranchList.TabIndex = 132
        Me.CmdBranchList.TabStop = False
        Me.CmdBranchList.UseVisualStyleBackColor = False
        '
        'lblBranchCode
        '
        Me.lblBranchCode.BackColor = System.Drawing.Color.Transparent
        Me.lblBranchCode.ForeColor = System.Drawing.Color.Navy
        Me.lblBranchCode.Location = New System.Drawing.Point(9, 28)
        Me.lblBranchCode.Name = "lblBranchCode"
        Me.lblBranchCode.Size = New System.Drawing.Size(110, 20)
        Me.lblBranchCode.TabIndex = 131
        Me.lblBranchCode.Text = "Branch Code"
        '
        'CmdChkDocumentNatureList
        '
        Me.CmdChkDocumentNatureList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdChkDocumentNatureList.Location = New System.Drawing.Point(340, 125)
        Me.CmdChkDocumentNatureList.Name = "CmdChkDocumentNatureList"
        Me.CmdChkDocumentNatureList.Size = New System.Drawing.Size(23, 18)
        Me.CmdChkDocumentNatureList.TabIndex = 6
        Me.CmdChkDocumentNatureList.Text = "--"
        '
        'TxtDocumentNature
        '
        Me.TxtDocumentNature.Location = New System.Drawing.Point(121, 124)
        Me.TxtDocumentNature.Name = "TxtDocumentNature"
        Me.TxtDocumentNature.Size = New System.Drawing.Size(244, 21)
        Me.TxtDocumentNature.TabIndex = 128
        Me.TxtDocumentNature.Text = " All Selected"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(9, 128)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 20)
        Me.Label15.TabIndex = 127
        Me.Label15.Text = "Document Type"
        '
        'txtToTransactionNo
        '
        Me.txtToTransactionNo.AcceptsReturn = True
        Me.txtToTransactionNo.AccessibleDescription = "YM.AUTO"
        Me.txtToTransactionNo.Location = New System.Drawing.Point(263, 76)
        Me.txtToTransactionNo.MaxLength = 10
        Me.txtToTransactionNo.Name = "txtToTransactionNo"
        Me.txtToTransactionNo.Size = New System.Drawing.Size(100, 21)
        Me.txtToTransactionNo.TabIndex = 3
        Me.txtToTransactionNo.Tag = "PK.TransactionNo"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(237, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 20)
        Me.Label11.TabIndex = 126
        Me.Label11.Text = "To"
        '
        'dtpToPostingDate
        '
        Me.dtpToPostingDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpToPostingDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.dtpToPostingDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.dtpToPostingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpToPostingDate.Location = New System.Drawing.Point(263, 100)
        Me.dtpToPostingDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.dtpToPostingDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.dtpToPostingDate.Name = "dtpToPostingDate"
        Me.dtpToPostingDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpToPostingDate.TabIndex = 5
        Me.dtpToPostingDate.Tag = "dt.TransactionDate"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(237, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 20)
        Me.Label13.TabIndex = 125
        Me.Label13.Text = "To"
        '
        'txtFromTransactionNo
        '
        Me.txtFromTransactionNo.AcceptsReturn = True
        Me.txtFromTransactionNo.AccessibleDescription = "YM.AUTO"
        Me.txtFromTransactionNo.Location = New System.Drawing.Point(121, 76)
        Me.txtFromTransactionNo.MaxLength = 10
        Me.txtFromTransactionNo.Name = "txtFromTransactionNo"
        Me.txtFromTransactionNo.Size = New System.Drawing.Size(106, 21)
        Me.txtFromTransactionNo.TabIndex = 2
        Me.txtFromTransactionNo.Tag = "PK.TransactionNo"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(9, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 20)
        Me.Label14.TabIndex = 124
        Me.Label14.Text = "Document No."
        '
        'dtpFromPostingDate
        '
        Me.dtpFromPostingDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpFromPostingDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.dtpFromPostingDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.dtpFromPostingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFromPostingDate.Location = New System.Drawing.Point(121, 100)
        Me.dtpFromPostingDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.dtpFromPostingDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.dtpFromPostingDate.Name = "dtpFromPostingDate"
        Me.dtpFromPostingDate.Size = New System.Drawing.Size(106, 20)
        Me.dtpFromPostingDate.TabIndex = 4
        Me.dtpFromPostingDate.Tag = "dt.TransactionDate"
        Me.dtpFromPostingDate.Value = Global.BusinessLeaf.My.MySettings.Default.CurrentYearStartDate
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(9, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 20)
        Me.Label16.TabIndex = 123
        Me.Label16.Text = "Document Date"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(9, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 16)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Last Posting Date"
        '
        'dtpLastPostingdateUp
        '
        Me.dtpLastPostingdateUp.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.dtpLastPostingdateUp.Enabled = False
        Me.dtpLastPostingdateUp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLastPostingdateUp.Location = New System.Drawing.Point(121, 52)
        Me.dtpLastPostingdateUp.Name = "dtpLastPostingdateUp"
        Me.dtpLastPostingdateUp.Size = New System.Drawing.Size(106, 20)
        Me.dtpLastPostingdateUp.TabIndex = 1
        '
        'TxtBranchCode
        '
        Me.TxtBranchCode.AcceptsReturn = True
        Me.TxtBranchCode.AccessibleDescription = "YM.AUTO"
        Me.TxtBranchCode.Location = New System.Drawing.Point(121, 24)
        Me.TxtBranchCode.MaxLength = 10
        Me.TxtBranchCode.Name = "TxtBranchCode"
        Me.TxtBranchCode.Size = New System.Drawing.Size(60, 21)
        Me.TxtBranchCode.TabIndex = 0
        Me.TxtBranchCode.Tag = "PK.TransactionNo"
        '
        'LstTransactionNature
        '
        Me.LstTransactionNature.CheckBoxes = True
        Me.LstTransactionNature.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.LstTransactionNature.Location = New System.Drawing.Point(121, 17)
        Me.LstTransactionNature.Name = "LstTransactionNature"
        Me.LstTransactionNature.Size = New System.Drawing.Size(242, 106)
        Me.LstTransactionNature.TabIndex = 129
        Me.LstTransactionNature.UseCompatibleStateImageBehavior = False
        Me.LstTransactionNature.View = System.Windows.Forms.View.Details
        Me.LstTransactionNature.Visible = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Document Types"
        Me.ColumnHeader1.Width = 192
        '
        'ErrProvider
        '
        Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
        Me.ErrProvider.ContainerControl = Me
        Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
        Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
        '
        'PnlVoucherGeneration
        '
        Me.PnlVoucherGeneration.Controls.Add(Me.CmbTransactionNature)
        Me.PnlVoucherGeneration.Controls.Add(Me.Label18)
        Me.PnlVoucherGeneration.Controls.Add(Me.DtpToDateVG)
        Me.PnlVoucherGeneration.Controls.Add(Me.Label20)
        Me.PnlVoucherGeneration.Controls.Add(Me.DtpFromDateVG)
        Me.PnlVoucherGeneration.Controls.Add(Me.Label22)
        Me.PnlVoucherGeneration.Location = New System.Drawing.Point(27, 44)
        Me.PnlVoucherGeneration.Name = "PnlVoucherGeneration"
        Me.PnlVoucherGeneration.Size = New System.Drawing.Size(431, 183)
        Me.PnlVoucherGeneration.TabIndex = 134
        Me.PnlVoucherGeneration.Visible = False
        '
        'CmbTransactionNature
        '
        Me.CmbTransactionNature.DropDownStyle = Infragistics.Win.DropDownStyle.DropDownList
        ValueListItem3.DataValue = "Invoices"
        ValueListItem3.Tag = "INV"
        ValueListItem4.DataValue = "Customer Receipts"
        ValueListItem4.Tag = "REC"
        ValueListItem6.DataValue = "Vehicle Adjustment Receipt"
        ValueListItem6.Tag = "AR"
        ValueListItem5.DataValue = "Vehicle Adjustment Payment"
        ValueListItem5.Tag = "AP"
        ValueListItem1.DataValue = "Vehicle Payments"
        ValueListItem1.Tag = "VP"
        ValueListItem2.DataValue = "Vehicle Receipts"
        ValueListItem2.Tag = "VR"
        Me.CmbTransactionNature.Items.AddRange(New Infragistics.Win.ValueListItem() {ValueListItem3, ValueListItem4, ValueListItem6, ValueListItem5, ValueListItem1, ValueListItem2})
        Me.CmbTransactionNature.Location = New System.Drawing.Point(121, 126)
        Me.CmbTransactionNature.Name = "CmbTransactionNature"
        Me.CmbTransactionNature.Size = New System.Drawing.Size(242, 21)
        Me.CmbTransactionNature.TabIndex = 128
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(9, 128)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(110, 20)
        Me.Label18.TabIndex = 127
        Me.Label18.Text = "Document Type"
        '
        'DtpToDateVG
        '
        Me.DtpToDateVG.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.DtpToDateVG.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.DtpToDateVG.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.DtpToDateVG.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpToDateVG.Location = New System.Drawing.Point(263, 100)
        Me.DtpToDateVG.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.DtpToDateVG.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DtpToDateVG.Name = "DtpToDateVG"
        Me.DtpToDateVG.Size = New System.Drawing.Size(100, 20)
        Me.DtpToDateVG.TabIndex = 5
        Me.DtpToDateVG.Tag = "dt.TransactionDate"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(237, 103)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(112, 20)
        Me.Label20.TabIndex = 125
        Me.Label20.Text = "To"
        '
        'DtpFromDateVG
        '
        Me.DtpFromDateVG.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.DtpFromDateVG.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.DtpFromDateVG.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.DtpFromDateVG.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFromDateVG.Location = New System.Drawing.Point(121, 100)
        Me.DtpFromDateVG.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.DtpFromDateVG.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DtpFromDateVG.Name = "DtpFromDateVG"
        Me.DtpFromDateVG.Size = New System.Drawing.Size(106, 20)
        Me.DtpFromDateVG.TabIndex = 4
        Me.DtpFromDateVG.Tag = "dt.TransactionDate"
        Me.DtpFromDateVG.Value = Global.BusinessLeaf.My.MySettings.Default.CurrentYearStartDate
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(9, 104)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(132, 20)
        Me.Label22.TabIndex = 123
        Me.Label22.Text = "Document Date"
        '
        'Management
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(656, 332)
        Me.Controls.Add(Me.PnlVoucherGeneration)
        Me.Controls.Add(Me.PnlUnposting)
        Me.Controls.Add(Me.pgBar)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.LblLabel)
        Me.Controls.Add(Me.imgManageType)
        Me.Controls.Add(Me.PnlAuditing)
        Me.Controls.Add(Me.PnlPosting)
        Me.Controls.Add(Me.pnlBackup)
        Me.Controls.Add(Me.PnlRestore)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Management"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TMS Management"
        CType(Me.imgManageType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBackup.ResumeLayout(False)
        Me.pnlBackup.PerformLayout()
        CType(Me.txtBackupLocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlRestore.ResumeLayout(False)
        Me.PnlRestore.PerformLayout()
        CType(Me.txtRestoreLocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlPosting.ResumeLayout(False)
        Me.PnlAuditing.ResumeLayout(False)
        Me.PnlUnposting.ResumeLayout(False)
        Me.PnlUnposting.PerformLayout()
        CType(Me.TxtDocumentNature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToTransactionNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromTransactionNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtBranchCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlVoucherGeneration.ResumeLayout(False)
        Me.PnlVoucherGeneration.PerformLayout()
        CType(Me.CmbTransactionNature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim IsConnected As Boolean
    Dim nBkupRstrFilePath As String
    Dim mm As String
    Dim yy As String
    Dim mPay_Date As Date
    Dim mnth As String
    Dim mDys As Long
    Public ManageType As ManagementType
    Enum ManagementType
        Posting
        UnPosting
        Backup
        Restore
        Auditing
        VoucherGeneration
    End Enum
    Private Sub frmDatabaseManagement_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ManagementSetup(ManageType)
    End Sub
    Const BackupFileName As String = "TMS"
    Dim FileName As String
    Private Sub ManagementSetup(ByVal manageType As ManagementType)
        Select Case manageType
            Case ManagementType.Backup
                pnlBackup.Visible = True
                LblLabel.Text = "Backup Database"
                imgManageType.Image = Image.FromFile(Application.StartupPath & "\Icons\Backup.ico")
                FileName = dtCurrentBackupDate.Value.Day & "-" & dtCurrentBackupDate.Value.Month & "-" & dtCurrentBackupDate.Value.Year
                txtBackupLocation.Text = Application.StartupPath & "\" & BackupFileName & FileName & ".Bak"
            Case ManagementType.Restore
                PnlRestore.Visible = True
                'txtRestoreLocation.Text = Application.StartupPath
                LblLabel.Text = "Restore Database"
                imgManageType.Image = Image.FromFile(Application.StartupPath & "\Icons\Restore.ico")
                FileName = BackupFileName & dtCurrentRestoreDate.Value.Day & "-" & dtCurrentBackupDate.Value.Month & "-" & dtCurrentBackupDate.Value.Year
                'txtRestoreLocation.Text = Application.StartupPath & "\" & BackupFileName & FileName & ".Bak"
            Case ManagementType.Posting
                LblLabel.Text = "TMS Posting"
                PnlPosting.Visible = True
                imgManageType.Image = Image.FromFile(Application.StartupPath & "\Icons\Posting.ico")
                'dtpLastPostingDate.Value = My.Settings.LastPostingDate
                SetLastPostingDate()
            Case ManagementType.UnPosting
                LblLabel.Text = "TMS Unposting"
                PnlUnposting.Visible = True
                FillDocTypeList(LstTransactionNature, "GENERALLEDGER")
                imgManageType.Image = Image.FromFile(Application.StartupPath & "\Icons\UnPosting.ico")
                'dtpLastPostingdateUp.Value = My.Settings.LastPostingDate
                SetLastPostingDate()
            Case ManagementType.Auditing
                LblLabel.Text = "TMS Auditing"
                PnlAuditing.Visible = True
                imgManageType.Image = Image.FromFile(Application.StartupPath & "\Icons\Auditing.ico")
            Case ManagementType.VoucherGeneration
                LblLabel.Text = "TMS Voucher Generation"
                PnlVoucherGeneration.Visible = True
                imgManageType.Image = Image.FromFile(Application.StartupPath & "\Icons\Posting1.ico")
                PnlVoucherGeneration.BringToFront()
        End Select

        fdbOpenFile.InitialDirectory = Application.StartupPath
        fdbOpenFile.CheckFileExists = False
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Me.Cursor = Cursors.WaitCursor
        Process(ManageType)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Process(ByVal manageType As ManagementType)
        Try
            Select Case manageType
                ''''''''
                'BACKUP DATABASE
                ''''''''
                Case ManagementType.Backup
                    If BackupProcess() = True Then
                        MessageBox.Show("Database Backup Process has been Completed")
                        Me.Close()
                    Else
                        MessageBox.Show("Error in Process")
                    End If
                    ''''''''
                    'RESTORE DATABASE
                    ''''''''
                Case ManagementType.Restore
                    If RestoreProcess() = True Then
                        MessageBox.Show("Database Restore Process has been Completed")
                    Else
                        MessageBox.Show("Error in Process")
                    End If
                    ''''''''
                    'POSTING
                    ''''''''
                Case ManagementType.Posting
                    If PostingProcess() = True Then
                        MessageBox.Show("Posting Process has been Completed")
                    Else
                        MessageBox.Show("Some Account have some Un Balance Amounts See the grid")
                    End If
                    ''''''''
                    'UN POSTING
                    ''''''''
                Case ManagementType.UnPosting
                    If UnpostingProcess() = True Then
                        MessageBox.Show("Un Posting Process has been Completed")
                    Else
                        MessageBox.Show("Some Account have some Un Balance Amounts See the grid")
                    End If
                    ''''''''
                    'AUDITING
                    ''''''''
                Case ManagementType.Auditing
                    If AuditTrans() = True Then
                        MessageBox.Show("Auditing Process has been Completed")
                    Else
                        MessageBox.Show("Auding Complete, some quantity auditing problem see the grid")
                    End If
                Case ManagementType.VoucherGeneration
                    If GenerateVoucher(Trim(CmbTransactionNature.SelectedItem.Tag)) = True Then
                        MessageBox.Show("Generation of Voucher  Process has been Completed")
                    Else
                        MessageBox.Show("Generation of Voucher Incomplete")
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Function UnpostingProcess() As Boolean
        Dim initDate As Date
        Try

            If dtpFromPostingDate.Value > dtpToPostingDate.Value Then
                MsgBox("To Date must be greater than or equalto from date", vbInformation, "Posting Date Error")
                Exit Function
            End If

            If dtpLastPostingdateUp.Value < dtpToPostingDate.Value Then
                MsgBox("To Date must be less than or equalto last posting date", vbInformation, "Posting Date Error")
                Exit Function
            End If

            initDate = My.Settings.CurrentYearStartDate
            If initDate > dtpFromPostingDate.Value Then
                MsgBox("From Date must be greater than or equalto Current Year Start date (" & Format(initDate, "dd MMM yyyy") & ")", vbInformation, "Posting Date Error")
                Exit Function
            End If


            If GetDocumentTypeCode(LstTransactionNature) = String.Empty Then
                MsgBox("You must select at least one Transaction Nature", vbInformation, "Posting Parameter Error")
            End If
            Dim clsp As clsGLPosting
            clsp = New clsGLPosting
            Call clsp.Unposting(dtpFromPostingDate.Value, dtpToPostingDate.Value, TxtBranchCode.Text, txtFromTransactionNo.Text, txtToTransactionNo.Text, GetDocumentTypeCode(LstTransactionNature))

            Call SetLastPostingDate()
            Return True

            Exit Function
        Catch ex As Exception
            MessageBox.Show("The Following exception has occured during processing..." & vbCrLf & Err.Number & vbTab & ex.Message)
        End Try
    End Function
    Private Function GetDocumentTypeCode(ByRef lstView As ListView) As String
        Dim retunString As String = String.Empty
        Dim b As ListViewItem
        For Each b In lstView.CheckedItems
            retunString = IIf(retunString = "", "'" & CType(b, ListViewItem).Tag & "'", retunString & "," & "'" & CType(b, ListViewItem).Tag & "'")
        Next
        GetDocumentTypeCode = Replace(retunString, "'", "")
        Return GetDocumentTypeCode
    End Function
    Private Sub FillDocTypeList(ByRef lstVew As ListView, Optional ByVal Terms As String = "")
        Dim nRst As SqlClient.SqlDataReader
        Dim Acc As AzamTechnologies.Database.DataAccess
        Dim OPTIONS As String = String.Empty
        Dim SYSTEM As String = String.Empty
        'Get All Term For Making Condition
        '<zee>

        Select Case Terms
            Case "TR", "PRR"
                OPTIONS = ""
            Case "INVENTORY"
                OPTIONS = "ALL"
                SYSTEM = "IN"
            Case "GENERALLEDGER"
                OPTIONS = "ALL"
                SYSTEM = "GL"

        End Select
        '</zee>
        Acc = New AzamTechnologies.Database.DataAccess
        nRst = Acc.GetRecord("SelectTransactionNatures", "OPTION", OPTIONS, "System", SYSTEM)
        If nRst.HasRows Then
            While nRst.Read()
                'nRst.Sort = "TransactionNature, TransactionType"
                Dim lstItem As New ListViewItem
                lstItem.Text = nRst("Nature")
                lstItem.Tag = nRst("NatureCode")
                lstItem.Checked = True
                lstVew.Items.Add(lstItem)
            End While
        End If
    End Sub
    Private Sub DocumentTypeText(ByRef TxtBox As Infragistics.Win.UltraWinEditors.UltraTextEditor, ByRef lstView As ListView)
        If lstView.Items.Count = lstView.CheckedItems.Count Then
            TxtBox.Text = "All Selected"
        ElseIf lstView.CheckedItems.Count = 1 Then
            TxtBox.Text = " " & lstView.CheckedItems(0).Text
        ElseIf lstView.CheckedItems.Count = 0 Then
            TxtBox.Text = "None"
        ElseIf lstView.CheckedItems.Count > 1 Then
            TxtBox.Text = "Variouse Selected"
        End If
    End Sub
    Private Function BackupProcess() As Boolean
        If txtBackupLocation.Text.Length = 0 Then
            Throw New Exception("Please enter Backup File Name")
            Return False
        Else
            Try
                If BackupDatabase(txtBackupLocation.Text) = True Then
                    BackupProcess = True
                Else
                    BackupProcess = False
                End If
                'Me.Cursor = Cursors.WaitCursor
                'Dim srv As New SQLDMO.SQLServerClass
                'Dim a As New SQLDMO.Login
                'srv.LoginSecure = True
                'srv.Connect(My.Settings.ServerName, "", "")
                'bak = New SQLDMO.BackupClass
                'bak.Devices = bak.Files
                'bak.Files = Trim(txtBackupLocation.Text)
                'bak.Database = "TMS"
                'bak.SQLBackup(srv)
                'Cursor = Cursors.Default
                'SettingDate()
                'srv = Nothing
                'Return True
            Catch ex As Exception
                Cursor = Cursors.Default
                Throw ex
                Return False
            End Try
        End If
    End Function
    'Friend WithEvents res As SQLDMO.RestoreClass
    'Friend WithEvents bak As SQLDMO.BackupClass
    'Dim nSQLServer As SQLDMO.SQLServer
    Private Function RestoreProcess() As Boolean
        'Dim nRestore As New SQLDMO.Restore
        If TextValidate() = False Then
            Throw New Exception("Please enter Backup File Name")
            Return False
        Else
            Try
                If RestoreDatabase(txtRestoreLocation.Text) = True Then
                    Return True
                Else
                    Return False
                End If
                'nSQLServer = New SQLDMO.SQLServer
                'Me.Cursor = Cursors.WaitCursor
                'Dim srv As New SQLDMO.SQLServerClass
                'srv.LoginSecure = True
                'srv.Connect("(Local)", "", "")
                'res = New SQLDMO.RestoreClass
                'res.Devices = res.Files
                'res.Files = Me.txtRestoreLocation.Text
                'res.Database = "TMS"
                'res.ReplaceDatabase = True
                'res.SQLRestore(srv)
                'SettingDate()
                'Me.Cursor = Cursors.Default
                'Return True
            Catch ex As Exception
                Cursor = Cursors.Default
                Throw ex
                Return False
            End Try

            'Dim Reader As SqlClient.SqlDataReader
            'Reader = Acc.GetRecord("RestoreDatabase", "FileName", Trim(txtRestoreLocation.Text))
            'If Reader Is Nothing Then
            '    Return False
            'Else
            'Return True
            'End If
        End If
    End Function
    Private Sub TxtPath_Validate(ByVal Cancel As Boolean)
        If Trim(txtRestoreLocation.Text) <> "" Then
            '    If TextValidate() = True Then
            If Len(Dir(txtRestoreLocation.Text)) > 0 Then
                Dim DLength As Double
                DLength = Format(FileLen(txtRestoreLocation.Text) / 1024, "###,###,###.000")
                'TxtDesc = "Data File Size  :  " & DLength & " KB.  =  " & Format(DLength / 1024, "###,###,###.000") & " MB." & vbCrLf & "File Created at:  " & FileDateTime(TxtPath)
                'txtName = Mid(txtRestoreLocation.Text , InStrRev(Trim(txtRestoreLocation.Text), "\", Len(txtRestoreLocation.Text)) + 1, Len(txtRestoreLocation.Text))
                Cancel = False
            Else
                MsgBox("Please specify a valid Backup File Source Path..." & vbCrLf & "The specifed path causes an Access error !", vbExclamation)
                '        UserInteraction True
                Cancel = True
            End If
        End If
    End Sub
    Private Function PostingProcess() As Boolean
        Try

            If dtpLastPostingDate.Value >= dtpCurrentPostingDate.Value Then
                MsgBox("Posting Date must be greater than last posting date", vbInformation, "Posting Date Error")
                Exit Function
            End If

            If AuditTrans() = False Then Return False : Exit Function

            ''Stop to validate MM & WSL Last Posting Date 'Temp
            ''################
            'Set Rst = Nothing
            'Set OBJ = CreateObject(prgID_clsDataModify, MTS_ServerName)
            'Call OBJ.GetModify(Material_Management, Rst, "MM_GetPostingSP", "nType", 10)
            '
            'If Rst.RecordCount > 0 Then
            '    MM_LastPostingDate = IIf(IsNull(Rst.Fields("ClosingDate")), 0, Rst.Fields("ClosingDate"))
            'Else
            '    MM_LastPostingDate = CDate(GetSetupProfileValue(AWASystemName, "InitialDate")) - 1
            'End If
            '
            'If MM_LastPostingDate < TxtPostingDate Then
            '    MsgBox "Posting Date must be less than or equal to Material Management last posting date", vbInformation, "Posting Date Error"
            '    Exit Sub
            'End If
            '
            'Set Rst = Nothing
            'Set OBJ = CreateObject(prgID_clsDataModify, MTS_ServerName)
            'Call OBJ.GetModify(WireHarness_Sales, Rst, "WSL_GetPostingSP", "nType", 10)
            '
            'If Rst.RecordCount > 0 Then
            '    WSL_LastPostingDate = IIf(IsNull(Rst.Fields("ClosingDate")), 0, Rst.Fields("ClosingDate"))
            'Else
            '    WSL_LastPostingDate = CDate(GetSetupProfileValue(AWASystemName, "InitialDate")) - 1
            'End If
            '
            'If WSL_LastPostingDate < TxtPostingDate Then
            '    MsgBox "Posting Date must be less than or equal to WireHarness Sales last posting date", vbInformation, "Posting Date Error"
            '    Exit Sub
            'End If
            ''Stop to validate MM & WSL Last Posting Date 'Temp
            ''/################

            Dim clsP As New clsGLPosting
            Call clsP.Posting(dtpCurrentPostingDate.Value)
            SettingDate()
            Return True

            Exit Function

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Private Sub SettingDate()
        Try
            If Me.ManageType = ManagementType.Posting Then
                'UpdateKey("LastPostingDate", dtpCurrentPostingDate.Value)
                SetLastPostingDate()
                'My.Settings.Save()
            ElseIf Me.ManageType = ManagementType.UnPosting Then
                'UpdateKey("LastPostingDate", dtpLastPostingdateUp.Value) 'Closing Date
                'UpdateKey("ModuleStartDate", DateAdd(DateInterval.Day, +1, dtCurrentBackupDate.Value))  'Opening Date
            ElseIf Me.ManageType = ManagementType.Backup Then
                UpdateKey("LastBackupDate", dtCurrentBackupDate.Value)
            ElseIf Me.ManageType = ManagementType.Restore Then
                UpdateKey("LastBackupDate", dtLastBackupDateRt.Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SetLastPostingDate()

        Dim Rst As SqlClient.SqlDataReader
        Dim objAcc As New AzamTechnologies.Database.DataAccess
        Rst = objAcc.GetRecord("SelectPosting", "nType", 1)

        If Rst.HasRows Then
            Rst.Read()
            dtpLastPostingDate.Value = IIf(IsDBNull(Rst("ClosingDate")), DateAdd(DateInterval.Day, -2, My.Settings.CurrentYearStartDate), Rst("ClosingDate"))
            dtpLastPostingdateUp.Value = IIf(IsDBNull(Rst("ClosingDate")), DateAdd(DateInterval.Day, -2, My.Settings.CurrentYearStartDate), Rst("ClosingDate"))
        Else
            dtpLastPostingDate.Value = DateAdd(DateInterval.Day, -1, My.Settings.CurrentYearStartDate)
            dtpLastPostingdateUp.Value = DateAdd(DateInterval.Day, -1, My.Settings.CurrentYearStartDate)
        End If
        objAcc = Nothing

        dtpCurrentPostingDate.Value = Now.Date

        If Me.ManageType = ManagementType.Posting Then
            dtpCurrentPostingDate.Value = Now.Date
        Else
            dtpLastPostingdateUp.Value = dtpLastPostingdateUp.Value
            dtpToPostingDate.Value = dtpLastPostingdateUp.Value
        End If
        Rst = Nothing
        Exit Sub
ERR_SetLastPostingDate:
        If Err.Number <> -2147418107 Then _
            MsgBox("The Following exception has occured during processing..." & vbCrLf & Err.Number & vbTab & Err.Description, vbInformation, "Code : SetLastPostingDate ")
        Err.Number = 0 : Err.Clear()

    End Sub

    Private Function GenerateVoucher(ByVal FromGenerationType As String) As Boolean
        ProgressValue(0)
        Dim rstAuditResult As DataTable = Nothing
        Dim ds As New DataSet
        Try

            Select Case FromGenerationType
                Case SaleInvoiceNature
                    GenerateVoucherProcess("Invoices", SaleInvoiceNature, SaleVoucherNature, False)
                Case VehicleAdjustmentReceiptNature
                    GenerateVoucherProcess("VehicleAdjustments", VehicleAdjustmentReceiptNature, JournalVoucherNature, True)
                Case VehicleAdjustmentPaymentNature
                    GenerateVoucherProcess("VehicleAdjustments", VehicleAdjustmentPaymentNature, JournalVoucherNature, True)
                Case VehiclePaymentNature
                    GenerateVoucherProcess("VehicleAdjustments", VehiclePaymentNature, BankPaymentVoucherNature, True)
                Case VehicleReceiptNature
                    GenerateVoucherProcess("VehicleAdjustments", VehicleReceiptNature, BankPaymentVoucherNature, True)
                Case ReceiptNature
                    GenerateVoucherProcess("Receipts", ReceiptNature, BankReceiptVoucherNature, False)

            End Select
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Friend Sub GenerateVoucherProcess(ByVal FormName As String, ByVal FromNature As String, ByVal ToNature As String, ByVal IsNatureExist As Boolean)
        Dim dsData As DataSet = Nothing
        Dim dsDetailData As DataSet = Nothing
        Dim DsMasterRetrieved As New DataSet(FormName)
        Dim TbMasterRetrieved As DataTable = Nothing
        Dim DsDetailRetrieved As New DataSet()
        Dim TbDetailRetrieved As DataTable = Nothing
        Dim nRow As Long = 0
        Dim Acc As New DataAccess
        Dim dvData As New DataView

        If FromNature = ReceiptNature Or FromNature = SaleInvoiceNature Then
            Acc.PopulateDataSet(dsData, "Select" & FormName, "FromDate", DtpFromDateVG.Value, "ToDate", DtpToDateVG.Value, "OPTION", "DateFilter")
        Else
            Acc.PopulateDataSet(dsData, "Select" & FormName, "FromDate", DtpFromDateVG.Value, "ToDate", DtpToDateVG.Value, "OPTION", "DateFilter", "TransactionNature", FromNature)
            Acc.PopulateDataSet(dsDetailData, "Select" & FormName & "Details", "FromDate", DtpFromDateVG.Value, "ToDate", DtpToDateVG.Value, "OPTION", "DateFilter", "TransactionNature", FromNature)
        End If

        For nRow = 0 To dsData.Tables(0).Rows.Count - 1
            dvData.Table = dsData.Tables(0)
            If IsNatureExist = False Then
                dvData.RowFilter = "BranchCode='" & dsData.Tables(0).Rows(nRow).Item("BranchCode") & "' AND TransactionNo='" & _
                dsData.Tables(0).Rows(nRow).Item("TransactionNo") & "'"
                TbMasterRetrieved = dvData.ToTable()
                If TbMasterRetrieved.Rows.Count > 1 Then
                    MsgBox("Duplicate Entry")
                End If

                DsMasterRetrieved.Tables.Clear()
                DsMasterRetrieved.Tables.Add(TbMasterRetrieved)
            Else
                dvData.RowFilter = "BranchCode='" & dsData.Tables(0).Rows(nRow).Item("BranchCode") & "' AND TransactionNo='" & _
                    dsData.Tables(0).Rows(nRow).Item("TransactionNo") & "' AND TransactionNature='" & _
                    dsData.Tables(0).Rows(nRow).Item("TransactionNature") & "'"
                TbMasterRetrieved = dvData.ToTable()
                DsMasterRetrieved.Tables.Clear()
                DsMasterRetrieved.Tables.Add(TbMasterRetrieved)
            End If
            ''NATURE MUST EXIST WHEN DETAIL
            If IsNothing(dsDetailData) And IsNatureExist = False Then
                dvData = Nothing
                dvData = New DataView
                dvData.Table = dsData.Tables(0)
                dvData.RowFilter = "BranchCode='" & dsData.Tables(0).Rows(nRow).Item("BranchCode") & "' AND TransactionNo='" & _
                    dsData.Tables(0).Rows(nRow).Item("TransactionNo") & "' "

                TbMasterRetrieved = dvData.ToTable()
                DsMasterRetrieved.Tables.Clear()
                DsMasterRetrieved.Tables.Add(TbMasterRetrieved)

            Else

                dvData = Nothing
                dvData = New DataView
                dvData.Table = dsDetailData.Tables(0)
                dvData.RowFilter = "BranchCode='" & dsData.Tables(0).Rows(nRow).Item("BranchCode") & "' AND TransactionNo='" & _
                    dsData.Tables(0).Rows(nRow).Item("TransactionNo") & "' AND TransactionNature='" & _
                    dsData.Tables(0).Rows(nRow).Item("TransactionNature") & "'"
                TbDetailRetrieved = dvData.ToTable()
                DsDetailRetrieved.Tables.Clear()
                DsDetailRetrieved.Tables.Add(TbDetailRetrieved)
            End If


            Dim BusinessMgr As New AzamTechnologies.BusinessManager
            If IsNatureExist = True Then
                If DsDetailRetrieved.Tables(0).Rows.Count <> 0 Then
                    BusinessMgr.GenerateVoucher(DsMasterRetrieved, DsDetailRetrieved, FromNature, ToNature)
                End If
            Else
                BusinessMgr.GenerateVoucher(DsMasterRetrieved, DsDetailRetrieved, FromNature, ToNature)
            End If

            Dim val As Integer
            If nRow <> 0 Then
                val = nRow / (dsData.Tables(0).Rows.Count - 1) * 100
            End If
            ProgressValue(val)
        Next
        'BusinessMgr = Nothing
        Acc = Nothing
        dvData = Nothing
        DsMasterRetrieved = Nothing
        TbMasterRetrieved = Nothing
        DsDetailRetrieved = Nothing
        TbDetailRetrieved = Nothing
    End Sub
    Sub ProgressValue(ByVal value As Integer)
        If value > 100 Then
            pgBar.Value = 100
        Else
            pgBar.Value = value

        End If
    End Sub

    Private Function AuditTrans() As Boolean

        Dim rstAuditResult As DataTable = Nothing
        Dim ds As New DataSet
        On Error GoTo ERR_AuditTrans

        pgBar.Value = 0

        If dtpLastPostingDate.Value > dtpCurrentPostingDate.Value Then
            MsgBox("Audit Date must be greater than last posting date", vbInformation, "Posting Date Error")
            Exit Function
        End If

        Dim clsA As New clsGLAuditing
        rstAuditResult = clsA.AuditingTrans(dtpCurrentPostingDate.Value)
        ds.Tables.Add(rstAuditResult)
        If rstAuditResult.Rows.Count > 0 Then
            'AUDIT EXIST IN DATA
            Call UpdateHistory(ds) 'Not working 
            Dim frmgrd As New frmGrid
            frmgrd.dsData = ds
            frmgrd.MdiParent = Me.Owner
            frmgrd.Show()
            Return False

        Else
            AuditTrans = True
            'MsgBox "No Error Found", vbInformation
        End If


        Exit Function
ERR_AuditTrans:

        MsgBox("The Following exception has occured during processing..." & vbCrLf & Err.Number & vbTab & Err.Description, vbInformation, "Code : AuditTrans ")
        Err.Number = 0 : Err.Clear()
        ' Resume Next
    End Function
    Private Function TextValidate() As Boolean
        If Trim(txtRestoreLocation.Text) = "" Then
            MsgBox("Please specify a valid Backup File Source Path...", vbExclamation)
            TextValidate = False
            '    TxtPath.SetFocus
        Else
            TxtPath_Validate(False)
            nBkupRstrFilePath = "C:\TMS 1-4-2006.Bak"
            TextValidate = True
        End If
    End Function
    Private Sub btnBrowsRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsRestore.Click
        If fdbOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtRestoreLocation.Text = fdbOpenFile.FileName
        End If
    End Sub
    Private Sub txtBrowsBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBrowsBackup.Click
        If fdbFolder.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtBackupLocation.Text = fdbFolder.SelectedPath & "\" & BackupFileName & FileName & ".Bak"
        End If
    End Sub
    'Private Sub bak_PercentComplete(ByVal Message As String, ByVal Percent As Integer) Handles bak.PercentComplete
    '    pgBar.Value = Percent
    'End Sub

    'Private Sub res_PercentComplete(ByVal Message As String, ByVal Percent As Integer) Handles res.PercentComplete
    '    pgBar.Value = Percent
    'End Sub
    Private Sub UpdateHistory(ByVal rstAuditResult As DataSet)
        'Dim obj As Object
        'Dim SaveRecordset As SqlDataReader
        'Dim SaveRecordset1 As SqlDataReader

        'rstAuditResult.MoveFirst()
        'SaveRecordset = New SqlDataReader
        'SaveRecordset("UserID", adVarChar, 50, adFldKeyColumn)
        'SaveRecordset.Fields.Append("ComputerID", adVarChar, 50, adFldKeyColumn)
        'SaveRecordset.Fields.Append("ProcessDateTime", adDate, adFldKeyColumn)
        'SaveRecordset.Fields.Append("Error", adVarChar, 50)
        'SaveRecordset.Fields.Append("DocumentDate", adDate)
        'SaveRecordset.Fields.Append("StationCode", adBigInt)
        'SaveRecordset.Fields.Append("DocumentNature", adVarChar, 50)
        'SaveRecordset.Fields.Append("DocumentNo", adVarChar, 50)
        'SaveRecordset.Fields.Append("PartyCode", adBigInt)
        'SaveRecordset.Fields.Append("PONature", adVarChar, 50)
        'SaveRecordset.Fields.Append("PONumber", adVarChar, 50)
        'SaveRecordset.Fields.Append("ItemCode", adBigInt)
        'SaveRecordset.Fields.Append("Quantity", adDecimal)
        'SaveRecordset.Fields.Append("AvailableQuantity", adDecimal)
        'SaveRecordset.Fields.Append("BalanceQuantity", adDecimal)
        'SaveRecordset.Fields.Append("POAvailableQuantity", adDecimal)
        'SaveRecordset.Fields.Append("POBalanceQuantity", adDecimal)
        'SaveRecordset.Fields.Append("GUID", adBigInt)
        'SaveRecordset.Open()
        'SaveRecordset.AddNew()
        'SaveRecordset!UserID = OperatorID
        'SaveRecordset!ComputerID = MachineID
        'SaveRecordset!ProcessDateTime = Date
        'SaveRecordset!Error = rstAuditResult!ErrorNature
        'SaveRecordset!DocumentDate = rstAuditResult!DocumentDate
        'SaveRecordset!StationCode = rstAuditResult!SysStationCode
        'SaveRecordset!DocumentNature = rstAuditResult!DocumentNature
        'SaveRecordset!DocumentNo = rstAuditResult!DocumentNo
        'SaveRecordset!PartyCode = rstAuditResult!SysPartyCode
        'SaveRecordset!PONature = rstAuditResult!PONature
        'SaveRecordset!PONumber = rstAuditResult!PONumber
        'SaveRecordset!ItemCode = rstAuditResult!SysItemCode
        'SaveRecordset!Quantity = rstAuditResult!Quantity
        'SaveRecordset!AvailableQuantity = rstAuditResult!AvailableQuantity
        'SaveRecordset!BalanceQuantity = rstAuditResult!BalanceQuantity
        'SaveRecordset!POAvailableQuantity = rstAuditResult!POAvailableQuantity
        'SaveRecordset!POBalanceQuantity = rstAuditResult!POBalanceQuantity
        'SaveRecordset!GUID = 0
        'SaveRecordset.Update()
        '''''''
        'SaveRecordset1 = New SqlClient.SqlDatareader
        'SaveRecordset1.Fields.Append("UserID", adVarChar, 50, adFldKeyColumn)
        'SaveRecordset1.Fields.Append("ComputerID", adVarChar, 50, adFldKeyColumn)
        'SaveRecordset1.Fields.Append("ProcessDateTime", adDate, adFldKeyColumn)
        'SaveRecordset1.Fields.Append("Error", adVarChar, 50)
        'SaveRecordset1.Fields.Append("DocumentDate", adDate)
        'SaveRecordset1.Fields.Append("StationCode", adBigInt)
        'SaveRecordset1.Fields.Append("DocumentNature", adVarChar, 50)
        'SaveRecordset1.Fields.Append("DocumentNo", adVarChar, 50)
        'SaveRecordset1.Fields.Append("PartyCode", adBigInt)
        'SaveRecordset1.Fields.Append("PONature", adVarChar, 50)
        'SaveRecordset1.Fields.Append("PONumber", adVarChar, 50)
        'SaveRecordset1.Fields.Append("ItemCode", adBigInt)
        'SaveRecordset1.Fields.Append("Quantity", adDecimal)
        'SaveRecordset1.Fields.Append("AvailableQuantity", adDecimal)
        'SaveRecordset1.Fields.Append("BalanceQuantity", adDecimal)
        'SaveRecordset1.Fields.Append("POAvailableQuantity", adDecimal)
        'SaveRecordset1.Fields.Append("POBalanceQuantity", adDecimal)
        'SaveRecordset1.Fields.Append("GUID", adBigInt)
        'SaveRecordset1.Open()
        'rstAuditResult.MoveFirst()
        'While Not rstAuditResult.EOF
        '    SaveRecordset1.AddNew()
        '    SaveRecordset1!UserID = OperatorID
        '    SaveRecordset1!ComputerID = MachineID
        '    SaveRecordset1!ProcessDateTime = Now
        '    SaveRecordset1!Error = rstAuditResult!ErrorNature
        '    SaveRecordset1!DocumentDate = rstAuditResult!DocumentDate
        '    SaveRecordset1!StationCode = rstAuditResult!SysStationCode
        '    SaveRecordset1!DocumentNature = rstAuditResult!DocumentNature
        '    SaveRecordset1!DocumentNo = rstAuditResult!DocumentNo
        '    SaveRecordset1!PartyCode = rstAuditResult!SysPartyCode
        '    SaveRecordset1!PONature = rstAuditResult!PONature
        '    SaveRecordset1!PONumber = rstAuditResult!PONumber
        '    SaveRecordset1!ItemCode = rstAuditResult!SysItemCode
        '    SaveRecordset1!Quantity = rstAuditResult!Quantity
        '    SaveRecordset1!AvailableQuantity = rstAuditResult!AvailableQuantity
        '    SaveRecordset1!BalanceQuantity = rstAuditResult!BalanceQuantity
        '    SaveRecordset1!POAvailableQuantity = rstAuditResult!POAvailableQuantity
        '    SaveRecordset1!POBalanceQuantity = rstAuditResult!POBalanceQuantity
        '    SaveRecordset1!GUID = 0
        '    SaveRecordset1.Update()
        '    rstAuditResult.MoveNext()
        'End While

        'obj = CreateObject(prgID_clsBusinessService, MTS_ServerName)
        'Call obj.SaveMasterDetailData(AWASystemName, SaveRecordset, SaveRecordset1, "MM_UpdateMasterHistoryTransactionAuditSP", "MM_UpdateDetailHistoryTransactionAuditSP", "MM_DeleteHistoryTransactionAuditSP", 1, True, GetSystemOperatorID)
        Dim modif As New DataModify
        'modif.UpdateDetailData("MM_UpdateMasterHistoryTransactionAuditSP", "MM_UpdateDetailHistoryTransactionAuditSP", "MM_DeleteHistoryTransactionAuditSP", dsdata,)
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub CmdChkDocumentNatureList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdChkDocumentNatureList.Click
        Call DocumentTypeText(TxtDocumentNature, LstTransactionNature)
        If LstTransactionNature.Visible = True Then
            LstTransactionNature.Visible = False
        ElseIf LstTransactionNature.Visible = False Then
            LstTransactionNature.Visible = True
            LstTransactionNature.BringToFront()
            LstTransactionNature.Focus()
        End If
    End Sub

    Private Sub CmdBranchList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBranchList.Click
        Try
            Dim iRow As Integer
            Dim frmser As FrmSearch
            frmser = New FrmSearch
            frmser.FillData("Branches")
            frmser.ShowDialog()
            iRow = frmser.UGSearch.ActiveRow.Index
            Me.TxtBranchCode.Text = frmser.UGSearch.Rows(iRow).Cells("BranchCode").Value
            Me.TxtBranchCode.Focus()
        Catch ex As IndexOutOfRangeException
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TxtBranchCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtBranchCode.TextChanged

    End Sub

    Private Sub TxtBranchCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtBranchCode.Validated
        ErrProvider.SetError(TxtBranchCode, "")
    End Sub

    Private Sub TxtBranchCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtBranchCode.Validating
        Try
            If TxtBranchCode.Text <> String.Empty Then
                Dim Acc As New AzamTechnologies.Database.DataAccess
                Dim Reader As SqlClient.SqlDataReader

                Reader = Acc.GetRecord("SelectBranches", "BranchCode ", Trim(TxtBranchCode.Text))
                If Reader.HasRows = False Then
                    ErrProvider.SetError(TxtBranchCode, "Invalid Branch Code")
                    ErrProvider.SetIconAlignment(TxtBranchCode, ErrorIconAlignment.TopLeft)
                    TxtBranchCode.Text = String.Empty
                    e.Cancel = True
                Else
                    Reader.Read()
                    ErrProvider.SetError(TxtBranchCode, String.Empty)
                    e.Cancel = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function BackupDatabase(ByVal FileName As String) As Boolean

        'Dim dbBackup As New Microsoft.SqlServer.Management.Smo.Backup
        'Dim con As DataConnection = New DataConnection
        'Dim servercon As New Microsoft.SqlServer.Management.Common.ServerConnection(con.GetConnection)
        'Dim dbServer As New Microsoft.SqlServer.Management.Smo.Server(servercon)
        'Dim BackupFolder As String

        Try
            '    pgBar.Maximum = 100
            '    pgBar.Value = 0

            '    BackupFolder = Microsoft.VisualBasic.Left(FileName, InStrRev(FileName, "\") - 1)
            '    If IO.Directory.Exists(BackupFolder) = False Then
            '        IO.Directory.CreateDirectory(BackupFolder)
            '    End If
            '    dbBackup.Action = Microsoft.SqlServer.Management.Smo.BackupActionType.Database
            '    dbBackup.Database = My.Settings.DatabaseName
            '    dbBackup.Devices.AddDevice(FileName, Microsoft.SqlServer.Management.Smo.DeviceType.File)
            '    dbBackup.BackupSetName = "AWAPayhrms Database Backup"
            '    dbBackup.BackupSetDescription = "AWAPayhrms DataBase Backup:" & DateTime.Now.ToShortDateString()

            'AddHandler dbBackup.PercentComplete, AddressOf ProgressStatusEvent

            'dbBackup.SqlBackup(dbServer)
            'BackupDatabase = True

            'dbServer = Nothing
            'dbBackup = Nothing
            'con = Nothing
            'servercon.Disconnect()
            'servercon = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message & " " & ex.InnerException.ToString, "Backup Database", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BackupDatabase = False
            'dbServer = Nothing
            'dbBackup = Nothing
            'con = Nothing
            'servercon.Disconnect()
            'servercon = Nothing
        End Try


    End Function

    'Private Sub ProgressStatusEvent(ByVal sender As Object, ByVal e As Microsoft.SqlServer.Management.Smo.PercentCompleteEventArgs)
    '    pgBar.Value = e.Percent
    'End Sub
    Function RestoreDatabase(ByVal filename As String) As Boolean

        'Dim dbRestore As New Microsoft.SqlServer.Management.Smo.Restore
        'Dim con As DataConnection = New DataConnection
        'Dim servercon As New Microsoft.SqlServer.Management.Common.ServerConnection(con.GetConnection)
        'Dim dbServer As New Microsoft.SqlServer.Management.Smo.Server(servercon)

        'Try
        '    pgBar.Maximum = 100
        '    pgBar.Value = 0

        '    dbRestore.Action = Microsoft.SqlServer.Management.Smo.RestoreActionType.Database
        '    dbRestore.Database = My.Settings.DatabaseName
        '    dbRestore.Devices.AddDevice(filename, Microsoft.SqlServer.Management.Smo.DeviceType.File)

        '    dbRestore.ReplaceDatabase = True
        '    AddHandler dbRestore.PercentComplete, AddressOf ProgressStatusEvent

        '    dbServer.KillAllProcesses(My.Settings.DatabaseName)

        '    dbRestore.SqlRestore(dbServer)

        '    RestoreDatabase = True

        '    dbServer = Nothing
        '    dbRestore = Nothing
        '    con = Nothing
        '    servercon.Disconnect()
        '    servercon = Nothing

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message & " " & ex.InnerException.ToString(), "Restore Database", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    RestoreDatabase = False
        '    dbServer = Nothing
        '    dbRestore = Nothing
        '    con = Nothing
        '    servercon.Disconnect()
        '    servercon = Nothing
        'End Try

    End Function
    Private Sub LstTransactionNature_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles LstTransactionNature.ColumnClick
        Dim item As ListViewItem
        If LstTransactionNature.CheckedItems.Count = LstTransactionNature.Items.Count Then
            For Each item In LstTransactionNature.Items
                item.Checked = False
            Next
        ElseIf LstTransactionNature.CheckedItems.Count >= 0 Then
            For Each item In LstTransactionNature.Items
                item.Checked = True
            Next
        End If
    End Sub

End Class
