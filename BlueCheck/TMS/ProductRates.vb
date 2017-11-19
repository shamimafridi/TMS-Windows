Namespace Inventory
    Public Class ProductRates
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
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Desc As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtProduct As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtProductCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents TxtStationPointDescription As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents TxtStationPointCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtDestinationPointDescription As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents TxtDestinationPointCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents txtAmount As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents TxtRate As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductRates))
            Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Me.Label2 = New System.Windows.Forms.Label
            Me.Desc = New System.Windows.Forms.DateTimePicker
            Me.Label3 = New System.Windows.Forms.Label
            Me.txtProduct = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtProductCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.Label1 = New System.Windows.Forms.Label
            Me.TxtStationPointCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtStationPointDescription = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label4 = New System.Windows.Forms.Label
            Me.TxtDestinationPointDescription = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.Label5 = New System.Windows.Forms.Label
            Me.TxtDestinationPointCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtRate = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.txtAmount = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label6 = New System.Windows.Forms.Label
            CType(Me.txtProduct, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtProductCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtStationPointCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtStationPointDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtDestinationPointDescription, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtDestinationPointCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtRate, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(84, 216)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 74
            Me.Label2.Text = "Effective Date"
            '
            'Desc
            '
            Me.Desc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Desc.CalendarTitleBackColor = System.Drawing.SystemColors.Control
            Me.Desc.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
            Me.Desc.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
            Me.Desc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.Desc.Location = New System.Drawing.Point(194, 215)
            Me.Desc.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.Desc.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.Desc.Name = "Desc"
            Me.Desc.Size = New System.Drawing.Size(130, 20)
            Me.Desc.TabIndex = 3
            Me.Desc.Tag = "PK.EffectiveDate"
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.ForeColor = System.Drawing.Color.Navy
            Me.Label3.Location = New System.Drawing.Point(84, 149)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(110, 20)
            Me.Label3.TabIndex = 71
            Me.Label3.Text = "Product"
            '
            'txtProduct
            '
            Me.txtProduct.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance1.BackColor = System.Drawing.SystemColors.Window
            Me.txtProduct.Appearance = Appearance1
            Me.txtProduct.BackColor = System.Drawing.SystemColors.Window
            Me.txtProduct.Location = New System.Drawing.Point(324, 149)
            Me.txtProduct.Name = "txtProduct"
            Me.txtProduct.Size = New System.Drawing.Size(607, 21)
            Me.txtProduct.TabIndex = 1
            Me.txtProduct.TabStop = False
            Me.txtProduct.Tag = "dd.ProductName"
            '
            'TxtProductCode
            '
            Me.TxtProductCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance2.BackColor = System.Drawing.SystemColors.Window
            Me.TxtProductCode.Appearance = Appearance2
            Me.TxtProductCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtProductCode.Location = New System.Drawing.Point(194, 149)
            Me.TxtProductCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.CityCode_Length
            Me.TxtProductCode.Name = "TxtProductCode"
            Me.TxtProductCode.Size = New System.Drawing.Size(130, 21)
            Me.TxtProductCode.TabIndex = 0
            Me.TxtProductCode.Tag = "PK.ProductCode"
            '
            'ErrProvider
            '
            Me.ErrProvider.BlinkColor = System.Drawing.Color.Orange
            Me.ErrProvider.ContainerControl = Me
            Me.ErrProvider.Icon = CType(resources.GetObject("ErrProvider.Icon"), System.Drawing.Icon)
            Me.ErrProvider.SettleColor = System.Drawing.Color.LightPink
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(84, 173)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 98
            Me.Label1.Text = "Station Point"
            '
            'TxtStationPointCode
            '
            Me.TxtStationPointCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance6.BackColor = System.Drawing.SystemColors.Window
            Me.TxtStationPointCode.Appearance = Appearance6
            Me.TxtStationPointCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtStationPointCode.Location = New System.Drawing.Point(194, 171)
            Me.TxtStationPointCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.CityCode_Length
            Me.TxtStationPointCode.Name = "TxtStationPointCode"
            Me.TxtStationPointCode.Size = New System.Drawing.Size(130, 21)
            Me.TxtStationPointCode.TabIndex = 1
            Me.TxtStationPointCode.Tag = "PK.StationPointCode"
            '
            'TxtStationPointDescription
            '
            Me.TxtStationPointDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance5.BackColor = System.Drawing.SystemColors.Window
            Me.TxtStationPointDescription.Appearance = Appearance5
            Me.TxtStationPointDescription.BackColor = System.Drawing.SystemColors.Window
            Me.TxtStationPointDescription.Location = New System.Drawing.Point(324, 171)
            Me.TxtStationPointDescription.Name = "TxtStationPointDescription"
            Me.TxtStationPointDescription.Size = New System.Drawing.Size(607, 21)
            Me.TxtStationPointDescription.TabIndex = 100
            Me.TxtStationPointDescription.TabStop = False
            Me.TxtStationPointDescription.Tag = "dt.StationPointDescription"
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.ForeColor = System.Drawing.Color.Navy
            Me.Label4.Location = New System.Drawing.Point(84, 238)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(110, 20)
            Me.Label4.TabIndex = 102
            Me.Label4.Text = "Rate"
            '
            'TxtDestinationPointDescription
            '
            Me.TxtDestinationPointDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Appearance3.BackColor = System.Drawing.SystemColors.Window
            Me.TxtDestinationPointDescription.Appearance = Appearance3
            Me.TxtDestinationPointDescription.BackColor = System.Drawing.SystemColors.Window
            Me.TxtDestinationPointDescription.Location = New System.Drawing.Point(324, 193)
            Me.TxtDestinationPointDescription.Name = "TxtDestinationPointDescription"
            Me.TxtDestinationPointDescription.Size = New System.Drawing.Size(607, 21)
            Me.TxtDestinationPointDescription.TabIndex = 106
            Me.TxtDestinationPointDescription.TabStop = False
            Me.TxtDestinationPointDescription.Tag = "dt.DestinationPointDescription"
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.ForeColor = System.Drawing.Color.Navy
            Me.Label5.Location = New System.Drawing.Point(84, 194)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(110, 20)
            Me.Label5.TabIndex = 104
            Me.Label5.Text = "Destination Point"
            '
            'TxtDestinationPointCode
            '
            Me.TxtDestinationPointCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Appearance4.BackColor = System.Drawing.SystemColors.Window
            Me.TxtDestinationPointCode.Appearance = Appearance4
            Me.TxtDestinationPointCode.BackColor = System.Drawing.SystemColors.Window
            Me.TxtDestinationPointCode.Location = New System.Drawing.Point(194, 193)
            Me.TxtDestinationPointCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.CityCode_Length
            Me.TxtDestinationPointCode.Name = "TxtDestinationPointCode"
            Me.TxtDestinationPointCode.Size = New System.Drawing.Size(130, 21)
            Me.TxtDestinationPointCode.TabIndex = 2
            Me.TxtDestinationPointCode.Tag = "PK.DestinationPointCode"
            '
            'TxtRate
            '
            Me.TxtRate.AccessibleDescription = "Last"
            Me.TxtRate.Location = New System.Drawing.Point(194, 236)
            Me.TxtRate.Name = "TxtRate"
            Me.TxtRate.Size = New System.Drawing.Size(130, 21)
            Me.TxtRate.TabIndex = 4
            Me.TxtRate.Tag = "dt.Rate"
            '
            'txtAmount
            '
            Me.txtAmount.Location = New System.Drawing.Point(427, 332)
            Me.txtAmount.Name = "txtAmount"
            Me.txtAmount.Size = New System.Drawing.Size(100, 21)
            Me.txtAmount.TabIndex = 5
            Me.txtAmount.Tag = "dt.TripAdvanceAmount"
            Me.txtAmount.Visible = False
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.Transparent
            Me.Label6.ForeColor = System.Drawing.Color.Navy
            Me.Label6.Location = New System.Drawing.Point(317, 332)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(110, 20)
            Me.Label6.TabIndex = 108
            Me.Label6.Text = "Trip Advances"
            Me.Label6.Visible = False
            '
            'ProductRates
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(1020, 568)
            Me.Controls.Add(Me.TxtProductCode)
            Me.Controls.Add(Me.txtAmount)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.TxtRate)
            Me.Controls.Add(Me.TxtDestinationPointDescription)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.TxtDestinationPointCode)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.TxtStationPointDescription)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TxtStationPointCode)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtProduct)
            Me.KeyPreview = True
            Me.MinimumSize = Global.BusinessLeaf.My.MySettings.Default.SetupFormMinimumSize
            Me.Name = "ProductRates"
            Me.Text = "Product Rate File"
            CType(Me.txtProduct, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtProductCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtStationPointCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtStationPointDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtDestinationPointDescription, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtDestinationPointCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtRate, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private Sub TxtProductCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtProductCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Products")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtProductCode.Text = frmser.UGSearch.Rows(iRow).Cells("ProductCode").Value
                Me.txtProduct.Text = frmser.UGSearch.Rows(iRow).Cells("ProductName").Value
                Me.TxtProductCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtCityCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProductCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtProductCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub txtProductCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtProductCode.Validating
            Try
                If TxtProductCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectProducts", "ProductCode", Trim(TxtProductCode.Text))
                    If Reader.HasRows = False Then
                        TxtProductCode.Text = String.Empty
                        txtProduct.Text = String.Empty
                        ErrProvider.SetError(TxtProductCode, "Invalid Product Code")
                        ErrProvider.SetIconAlignment(TxtProductCode, ErrorIconAlignment.TopLeft)
                        e.Cancel = True
                    Else
                        ErrProvider.SetError(TxtProductCode, String.Empty)
                        Reader.Read()
                        txtProduct.Text = Reader.Item("ProductName")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Private Sub txtCityCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProductCode.Validated
            ErrProvider.SetError(TxtProductCode, String.Empty)
        End Sub

        Private Sub ProductRates_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub

        Private Sub CmdProductList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub txtCityCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProductCode.TextChanged

        End Sub

        Private Sub BtnStationPoint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub BtnDestinationPointList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub TxtStationPointCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtStationPointCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Regions")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtStationPointCode.Text = frmser.UGSearch.Rows(iRow).Cells("RegionCode").Value
                Me.TxtStationPointDescription.Text = frmser.UGSearch.Rows(iRow).Cells("RegionName").Value
                Me.TxtStationPointCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtStationPointCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtStationPointCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtStationPointCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtStationPointCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtStationPointCode.TextChanged

        End Sub

        Private Sub TxtStationPointCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtStationPointCode.Validated
            ErrProvider.SetError(TxtStationPointCode, String.Empty)
        End Sub

        Private Sub TxtStationPointCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtStationPointCode.Validating
            Try
                If TxtStationPointCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectStationPoints", "StationPointCode", Trim(TxtStationPointCode.Text))
                    If Reader.HasRows = False Then
                        TxtStationPointCode.Text = String.Empty
                        TxtStationPointDescription.Text = String.Empty
                        ErrProvider.SetError(TxtStationPointCode, "Invalid Station Point Code")
                        ErrProvider.SetIconAlignment(TxtStationPointCode, ErrorIconAlignment.TopLeft)
                        e.Cancel = True
                    Else
                        ErrProvider.SetError(TxtStationPointCode, String.Empty)
                        Reader.Read()
                        TxtStationPointDescription.Text = Reader.Item("StationPointName")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub TxtDestinationPointCode_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles TxtDestinationPointCode.EditorButtonClick
            Try
                Dim iRow As Integer
                Dim frmser As FrmSearch
                frmser = New FrmSearch
                frmser.FillData("Regions")
                frmser.ShowDialog()
                iRow = frmser.UGSearch.ActiveRow.Index
                Me.TxtDestinationPointCode.Text = frmser.UGSearch.Rows(iRow).Cells("RegionCode").Value
                Me.TxtDestinationPointDescription.Text = frmser.UGSearch.Rows(iRow).Cells("RegionName").Value
                Me.TxtDestinationPointCode.Focus()
            Catch ex As IndexOutOfRangeException
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub TxtDestinationPointCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDestinationPointCode.KeyDown
            Try
                If e.KeyCode = Keys.F3 Then
                    Call Me.TxtDestinationPointCode_EditorButtonClick(sender, New Infragistics.Win.UltraWinEditors.EditorButtonEventArgs(Nothing, Nothing))
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Private Sub TxtDestinationPointCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtDestinationPointCode.Validated
            ErrProvider.SetError(TxtDestinationPointCode, String.Empty)
        End Sub

        Private Sub TxtDestinationPointCode_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TxtDestinationPointCode.Validating
            Try
                If TxtDestinationPointCode.Text <> String.Empty Then
                    Dim Acc As New AzamTechnologies.Database.DataAccess
                    Dim Reader As SqlClient.SqlDataReader

                    Reader = Acc.GetRecord("SelectDestinationPoints", "DestinationPointCode", Trim(TxtDestinationPointCode.Text))
                    If Reader.HasRows = False Then
                        TxtDestinationPointCode.Text = String.Empty
                        TxtDestinationPointDescription.Text = String.Empty
                        ErrProvider.SetError(TxtDestinationPointCode, "Invalid Destination Point Code")
                        ErrProvider.SetIconAlignment(TxtDestinationPointCode, ErrorIconAlignment.TopLeft)
                        e.Cancel = True
                    Else
                        ErrProvider.SetError(TxtDestinationPointCode, String.Empty)
                        Reader.Read()
                        TxtDestinationPointDescription.Text = Reader.Item("DestinationPointName")
                        e.Cancel = False
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Private Sub TxtProductCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProductCode.ValueChanged

        End Sub

        Private Sub TxtStationPointCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtStationPointCode.ValueChanged

        End Sub

        Private Sub TxtDestinationPointCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDestinationPointCode.ValueChanged

        End Sub
    End Class

End Namespace