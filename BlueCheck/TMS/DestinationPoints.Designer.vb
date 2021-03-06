<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DestinationPoints
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DestinationPoints))
        Me.TxtRate = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ATUrduTitle = New ATUrduTextBox.UrduTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.txtDestinationPointCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Label9 = New System.Windows.Forms.Label
        Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
        CType(Me.TxtRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ATUrduTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDestinationPointCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtRate
        '
        Me.TxtRate.AccessibleDescription = "NoDecimal"
        Me.TxtRate.Location = New System.Drawing.Point(218, 194)
        Me.TxtRate.Name = "TxtRate"
        Me.TxtRate.Size = New System.Drawing.Size(136, 21)
        Me.TxtRate.TabIndex = 116
        Me.TxtRate.Tag = "kk.PointNo"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(108, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 122
        Me.Label4.Text = "Point No"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = Global.BusinessLeaf.My.MySettings.Default.UrduFontType
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(104, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 47)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "علاقہ"
        '
        'ATUrduTitle
        '
        Me.ATUrduTitle.Font = Global.BusinessLeaf.My.MySettings.Default.UrduFontType
        Me.ATUrduTitle.Location = New System.Drawing.Point(218, 156)
        Me.ATUrduTitle.Name = "ATUrduTitle"
        Me.ATUrduTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ATUrduTitle.Size = New System.Drawing.Size(214, 35)
        Me.ATUrduTitle.TabIndex = 115
        Me.ATUrduTitle.Tag = "dd.UrduTitle"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(108, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Definition Date"
        '
        'dtpDate
        '
        Me.dtpDate.AccessibleDescription = "Last"
        Me.dtpDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
        Me.dtpDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
        Me.dtpDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(218, 218)
        Me.dtpDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
        Me.dtpDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(136, 20)
        Me.dtpDate.TabIndex = 117
        Me.dtpDate.Tag = "dt.DefinitionDate"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(108, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "DestinationPoint Code"
        '
        'Desc
        '
        Me.Desc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Me.Desc.Appearance = Appearance1
        Me.Desc.BackColor = System.Drawing.SystemColors.Window
        Me.Desc.Location = New System.Drawing.Point(218, 132)
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(510, 21)
        Me.Desc.TabIndex = 114
        Me.Desc.Tag = "IM.DestinationPointName"
        '
        'txtDestinationPointCode
        '
        Me.txtDestinationPointCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Appearance2.BackColor = System.Drawing.SystemColors.Window
        Me.txtDestinationPointCode.Appearance = Appearance2
        Me.txtDestinationPointCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtDestinationPointCode.Location = New System.Drawing.Point(218, 108)
        Me.txtDestinationPointCode.MaxLength = 3
        Me.txtDestinationPointCode.Name = "txtDestinationPointCode"
        Me.txtDestinationPointCode.Size = New System.Drawing.Size(136, 21)
        Me.txtDestinationPointCode.TabIndex = 113
        Me.txtDestinationPointCode.Tag = "PK.DestinationPointCode"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(108, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 20)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "DestinationPoint"
        '
        'ErrProvider
        '
        Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
        Me.ErrProvider.ContainerControl = Me
        Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
        Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
        '
        'DestinationPoints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 545)
        Me.Controls.Add(Me.TxtRate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ATUrduTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Desc)
        Me.Controls.Add(Me.txtDestinationPointCode)
        Me.Controls.Add(Me.Label9)
        Me.Name = "DestinationPoints"
        Me.Text = "Destination Points"
        Me.TopMost = True
        CType(Me.TxtRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ATUrduTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDestinationPointCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtRate As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ATUrduTitle As ATUrduTextBox.UrduTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents txtDestinationPointCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
End Class
