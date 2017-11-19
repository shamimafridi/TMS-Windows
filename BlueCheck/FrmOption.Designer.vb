<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOption
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOption))
        Me.TbOption = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.CmbIncrDays = New System.Windows.Forms.ComboBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.DtpWorkingDate = New System.Windows.Forms.DateTimePicker
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnOK = New System.Windows.Forms.Button
        Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
        Me.TbOption.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbOption
        '
        Me.TbOption.Controls.Add(Me.TabPage1)
        Me.TbOption.Dock = System.Windows.Forms.DockStyle.Top
        Me.TbOption.Location = New System.Drawing.Point(0, 0)
        Me.TbOption.Name = "TbOption"
        Me.TbOption.SelectedIndex = 0
        Me.TbOption.Size = New System.Drawing.Size(491, 296)
        Me.TbOption.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CmbIncrDays)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.DtpWorkingDate)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(483, 270)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CmbIncrDays
        '
        Me.CmbIncrDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIncrDays.FormatString = "N0"
        Me.CmbIncrDays.FormattingEnabled = True
        Me.CmbIncrDays.Items.AddRange(New Object() {"1", "2"})
        Me.CmbIncrDays.Location = New System.Drawing.Point(320, 103)
        Me.CmbIncrDays.MaxDropDownItems = 3
        Me.CmbIncrDays.Name = "CmbIncrDays"
        Me.CmbIncrDays.Size = New System.Drawing.Size(30, 21)
        Me.CmbIncrDays.TabIndex = 80
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBox1.Checked = Global.BusinessLeaf.My.MySettings.Default.ShowPostedData
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.BusinessLeaf.My.MySettings.Default, "ShowPostedData", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(101, 129)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(127, 17)
        Me.CheckBox1.TabIndex = 79
        Me.CheckBox1.Text = "Show Posted Record"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(98, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 20)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Working Date"
        '
        'DtpWorkingDate
        '
        Me.DtpWorkingDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.DtpWorkingDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.DtpWorkingDate.Checked = False
        Me.DtpWorkingDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.DtpWorkingDate.Enabled = False
        Me.DtpWorkingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpWorkingDate.Location = New System.Drawing.Point(214, 103)
        Me.DtpWorkingDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.DtpWorkingDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DtpWorkingDate.Name = "DtpWorkingDate"
        Me.DtpWorkingDate.Size = New System.Drawing.Size(100, 20)
        Me.DtpWorkingDate.TabIndex = 77
        Me.DtpWorkingDate.Tag = "dt.TransactionDate"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(232, 298)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 79
        Me.BtnCancel.Text = "&Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(151, 298)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 23)
        Me.BtnOK.TabIndex = 80
        Me.BtnOK.Text = "&Apply"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'ErrProvider
        '
        Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
        Me.ErrProvider.ContainerControl = Me
        Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
        Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
        '
        'FrmOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 385)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TbOption)
        Me.Name = "FrmOption"
        Me.Text = "FrmOption"
        Me.TbOption.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TbOption As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DtpWorkingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CmbIncrDays As System.Windows.Forms.ComboBox
End Class
