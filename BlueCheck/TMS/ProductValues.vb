Namespace Inventory
    Public Class ProductValues
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
        Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents txtProduct As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents TxtProductCode As Infragistics.Win.UltraWinEditors.UltraTextEditor
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Desc As Infragistics.Win.UltraWinEditors.UltraNumericEditor
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents ErrProvider As AzamTechnologies.ATErrorProvider
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductValues))
            Me.Label2 = New System.Windows.Forms.Label
            Me.dtpDate = New System.Windows.Forms.DateTimePicker
            Me.Label3 = New System.Windows.Forms.Label
            Me.txtProduct = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.TxtProductCode = New Infragistics.Win.UltraWinEditors.UltraTextEditor
            Me.ErrProvider = New AzamTechnologies.ATErrorProvider(Me.components)
            Me.Label4 = New System.Windows.Forms.Label
            Me.Desc = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
            Me.Label1 = New System.Windows.Forms.Label
            CType(Me.txtProduct, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtProductCode, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.ForeColor = System.Drawing.Color.Navy
            Me.Label2.Location = New System.Drawing.Point(84, 175)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(110, 20)
            Me.Label2.TabIndex = 74
            Me.Label2.Text = "Effective Date"
            '
            'dtpDate
            '
            Me.dtpDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.Control
            Me.dtpDate.CalendarTitleForeColor = System.Drawing.SystemColors.WindowText
            Me.dtpDate.CustomFormat = Global.BusinessLeaf.My.MySettings.Default.DateFormat
            Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
            Me.dtpDate.Location = New System.Drawing.Point(194, 175)
            Me.dtpDate.MaxDate = New Date(2060, 12, 31, 0, 0, 0, 0)
            Me.dtpDate.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
            Me.dtpDate.Name = "dtpDate"
            Me.dtpDate.Size = New System.Drawing.Size(100, 20)
            Me.dtpDate.TabIndex = 3
            Me.dtpDate.Tag = "PK.EffectiveDate"
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
            Me.txtProduct.Location = New System.Drawing.Point(324, 150)
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
            Me.TxtProductCode.Location = New System.Drawing.Point(194, 150)
            Me.TxtProductCode.MaxLength = Global.BusinessLeaf.My.MySettings.Default.ProductCode_Length
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
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.ForeColor = System.Drawing.Color.Navy
            Me.Label4.Location = New System.Drawing.Point(84, 200)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(110, 20)
            Me.Label4.TabIndex = 102
            Me.Label4.Text = "Quantity Value"
            '
            'Desc
            '
            Me.Desc.Location = New System.Drawing.Point(194, 199)
            Me.Desc.Name = "Desc"
            Me.Desc.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Double]
            Me.Desc.Size = New System.Drawing.Size(100, 21)
            Me.Desc.TabIndex = 4
            Me.Desc.Tag = "FK.QuantityValue"
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.ForeColor = System.Drawing.Color.Navy
            Me.Label1.Location = New System.Drawing.Point(300, 201)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(110, 20)
            Me.Label1.TabIndex = 103
            Me.Label1.Text = "/ Ltr"
            '
            'ProductValues
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(1020, 414)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.TxtProductCode)
            Me.Controls.Add(Me.Desc)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpDate)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.txtProduct)
            Me.KeyPreview = True
            Me.MinimumSize = Global.BusinessLeaf.My.MySettings.Default.SetupFormMinimumSize
            Me.Name = "ProductValues"
            Me.Text = "Product Value File"
            CType(Me.txtProduct, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtProductCode, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ErrProvider, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Desc, System.ComponentModel.ISupportInitialize).EndInit()
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

        Private Sub txtProductCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtProductCode.KeyDown
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
        Private Sub txtProductCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtProductCode.Validated
            ErrProvider.SetError(TxtProductCode, "")
        End Sub

        Private Sub ProductValues_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            AddHandler Me.Paint, AddressOf mdlFunctions.PaintTheForms
        End Sub

        Private Sub CmdProductList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        End Sub

        Private Sub txtProductCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProductCode.TextChanged

        End Sub


        Private Sub TxtProductCode_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProductCode.ValueChanged

        End Sub
    End Class

End Namespace