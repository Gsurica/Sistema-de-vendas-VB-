<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Count = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Name = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboProduct = New System.Windows.Forms.ComboBox()
        Me.comboClient = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.stock = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.QuantityField = New System.Windows.Forms.TextBox()
        Me.comboEmployee = New System.Windows.Forms.ComboBox()
        Me.lvl = New System.Windows.Forms.Label()
        Me.SalesField = New System.Windows.Forms.TextBox()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 15)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "ID"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(42, 7)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(48, 23)
        Me.ID.TabIndex = 105
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Location = New System.Drawing.Point(759, 387)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(12, 15)
        Me.Count.TabIndex = 101
        Me.Count.Text = "-"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(710, 387)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(32, 15)
        Me.Total.TabIndex = 100
        Me.Total.Text = "Total"
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(501, 406)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 99
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(394, 406)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 98
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(294, 406)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 97
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CreateButton
        '
        Me.CreateButton.Location = New System.Drawing.Point(183, 406)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(75, 23)
        Me.CreateButton.TabIndex = 96
        Me.CreateButton.Text = "New"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(42, 193)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowTemplate.Height = 25
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(730, 191)
        Me.dg.TabIndex = 95
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Preço"
        '
        'Price
        '
        Me.Price.Enabled = False
        Me.Price.Location = New System.Drawing.Point(274, 135)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(121, 23)
        Me.Price.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(298, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Cliente"
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Location = New System.Drawing.Point(70, 71)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(50, 15)
        Me.Name.TabIndex = 89
        Me.Name.Text = "Produto"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(627, 12)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(161, 23)
        Me.Search.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(566, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Search"
        '
        'comboProduct
        '
        Me.comboProduct.FormattingEnabled = True
        Me.comboProduct.Location = New System.Drawing.Point(137, 68)
        Me.comboProduct.Name = "comboProduct"
        Me.comboProduct.Size = New System.Drawing.Size(121, 23)
        Me.comboProduct.TabIndex = 1
        '
        'comboClient
        '
        Me.comboClient.FormattingEnabled = True
        Me.comboClient.Location = New System.Drawing.Point(348, 68)
        Me.comboClient.Name = "comboClient"
        Me.comboClient.Size = New System.Drawing.Size(121, 23)
        Me.comboClient.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(619, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 15)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Venda:"
        '
        'stock
        '
        Me.stock.Enabled = False
        Me.stock.Location = New System.Drawing.Point(477, 135)
        Me.stock.Name = "stock"
        Me.stock.Size = New System.Drawing.Size(121, 23)
        Me.stock.TabIndex = 109
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(420, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 15)
        Me.Label6.TabIndex = 110
        Me.Label6.Text = "Estoque"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Quantidade"
        '
        'QuantityField
        '
        Me.QuantityField.Location = New System.Drawing.Point(82, 135)
        Me.QuantityField.Name = "QuantityField"
        Me.QuantityField.Size = New System.Drawing.Size(121, 23)
        Me.QuantityField.TabIndex = 4
        '
        'comboEmployee
        '
        Me.comboEmployee.FormattingEnabled = True
        Me.comboEmployee.Location = New System.Drawing.Point(579, 68)
        Me.comboEmployee.Name = "comboEmployee"
        Me.comboEmployee.Size = New System.Drawing.Size(121, 23)
        Me.comboEmployee.TabIndex = 111
        '
        'lvl
        '
        Me.lvl.AutoSize = True
        Me.lvl.Location = New System.Drawing.Point(501, 71)
        Me.lvl.Name = "lvl"
        Me.lvl.Size = New System.Drawing.Size(70, 15)
        Me.lvl.TabIndex = 112
        Me.lvl.Text = "Funcionário"
        '
        'SalesField
        '
        Me.SalesField.Location = New System.Drawing.Point(667, 138)
        Me.SalesField.Name = "SalesField"
        Me.SalesField.Size = New System.Drawing.Size(121, 23)
        Me.SalesField.TabIndex = 113
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SalesField)
        Me.Controls.Add(Me.comboEmployee)
        Me.Controls.Add(Me.lvl)
        Me.Controls.Add(Me.stock)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.comboClient)
        Me.Controls.Add(Me.comboProduct)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.QuantityField)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Label1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents Count As Label
    Friend WithEvents Total As Label
    Friend WithEvents DeleteButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents CreateButton As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Price As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Name As Label
    Friend WithEvents Search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comboProduct As ComboBox
    Friend WithEvents comboClient As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents stock As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents QuantityField As TextBox
    Friend WithEvents comboEmployee As ComboBox
    Friend WithEvents lvl As Label
    Friend WithEvents SalesField As TextBox
End Class
