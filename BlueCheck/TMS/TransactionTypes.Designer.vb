Namespace Inventory
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class TransactionTypes
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
            Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionTypes))
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.txtNature = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label4 = New System.Windows.Forms.Label
            Me.ATUrduTitle = New ATUrduTextBox.UrduTextBox
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.TxtNatureCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtTransactionTypeCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.DtDate = New System.Windows.Forms.DateTimePicker
            Me.Label5 = New System.Windows.Forms.Label
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtNature, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ATUrduTitle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtNatureCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtTransactionTypeCode, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Desc
            '
            Me.Desc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance5.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Appearance = Appearance5
            Me.Desc.BackColor = System.Drawing.SystemColors.Window
            Me.Desc.Location = New System.Drawing.Point(236, 215)
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(665, 21)
            Me.Desc.TabIndex = 2
            Me.Desc.TabStop = False
            Me.Desc.Tag = "dt.TransactionType"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(106, 193)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(119, 20)
            Me.Label1.TabIndex = 115
            Me.Label1.Text = "Transaction Type Code"
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(106, 275)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 114
            Me.Label2.Text = "Effective Date"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.ForeColor = System.Drawing.Color.Navy
            Me.Label3.Location = New System.Drawing.Point(106, 169)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(110, 20)
            Me.Label3.TabIndex = 113
            Me.Label3.Text = "Nature"
            '
            'txtNature
            '
            Me.txtNature.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.txtNature.Appearance = Appearance1
            Me.txtNature.BackColor = System.Drawing.SystemColors.Window
            Me.txtNature.Location = New System.Drawing.Point(366, 169)
            Me.txtNature.Name = "txtNature"
            Me.txtNature.Size = New System.Drawing.Size(535, 21)
            Me.txtNature.TabIndex = 108
            Me.txtNature.TabStop = False
            Me.txtNature.Tag = "dd.Nature"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = Global.BusinessLeaf.My.MySettings.Default.UrduFontType
            Me.Label4.ForeColor = System.Drawing.Color.Navy
            Me.Label4.Location = New System.Drawing.Point(106, 231)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(110, 30)
            Me.Label4.TabIndex = 118
            Me.Label4.Text = "شہر"
            '
            'ATUrduTitle
            '
            Me.ATUrduTitle.Font = Global.BusinessLeaf.My.MySettings.Default.UrduFontType
            Me.ATUrduTitle.Location = New System.Drawing.Point(236, 238)
            Me.ATUrduTitle.Name = "ATUrduTitle"
            Me.ATUrduTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.ATUrduTitle.Size = New System.Drawing.Size(214, 35)
            Me.ATUrduTitle.TabIndex = 3
            Me.ATUrduTitle.Tag = "dd.UrduTitle"
            '
            'ErrProvider
            '
            Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
            Me.ErrProvider.ContainerControl = Me
            Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
            Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
            '
            'TxtNatureCode
            '
            Me.TxtNatureCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.TxtNatureCode.Appearance = Appearance2
            Me.TxtNatureCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtNatureCode.Location = New System.Drawing.Point(236, 169)
            Me.TxtNatureCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.TransactionTypeCode_Length
            Me.TxtNatureCode.Name = "TxtNatureCode"
            Me.TxtNatureCode.Size = New System.Drawing.Size(130, 21)
            Me.TxtNatureCode.TabIndex = 0
            Me.TxtNatureCode.Tag = "PK.NatureCode"
            '
            'TxtTransactionTypeCode
            '
            Me.TxtTransactionTypeCode.AccessibleDescription = "AUTO"
            Me.TxtTransactionTypeCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance6.BackColor = System.Drawing.SystemColors.Window
            Me.TxtTransactionTypeCode.Appearance = Appearance6
            Me.TxtTransactionTypeCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtTransactionTypeCode.Location = New System.Drawing.Point(236, 192)
            Me.TxtTransactionTypeCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.TransactionTypeCode_Length
            Me.TxtTransactionTypeCode.Name = "TxtTransactionTypeCode"
            Me.TxtTransactionTypeCode.Size = New System.Drawing.Size(130, 21)
            Me.TxtTransactionTypeCode.TabIndex = 1
            Me.TxtTransactionTypeCode.Tag = "PK.TransactionTypeCode"
            '
            'DtDate
            '
            Me.DtDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.DtDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
            Me.DtDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
            Me.DtDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
            Me.DtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.DtDate.Location = New System.Drawing.Point(236, 275)
            Me.DtDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.DtDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.DtDate.Name = "DtDate"
            Me.DtDate.Size = New System.Drawing.Size(130, 20)
            Me.DtDate.TabIndex = 4
            Me.DtDate.Tag = "dd.DefinitionDate"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.ForeColor = System.Drawing.Color.Navy
            Me.Label5.Location = New System.Drawing.Point(106, 214)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(110, 20)
            Me.Label5.TabIndex = 119
            Me.Label5.Text = "Transaction Type"
            '
            'TransactionTypes
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1028, 635)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.ATUrduTitle)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TxtNatureCode)
            Me.Controls.Add(Me.TxtTransactionTypeCode)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.DtDate)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtNature)
            Me.KeyPreview = True
            Me.Name = "TransactionTypes"
            Me.Text = "TransactionTypes"
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtNature, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ATUrduTitle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtNatureCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtTransactionTypeCode, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TxtNatureCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TxtTransactionTypeCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents DtDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtNature As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents ATUrduTitle As ATUrduTextBox.UrduTextBox
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        Friend WithEvents Label5 As System.Windows.Forms.Label
    End Class
End Namespace
