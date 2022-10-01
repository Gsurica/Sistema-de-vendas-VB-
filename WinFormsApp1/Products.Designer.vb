<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Me.Count = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Name = New System.Windows.Forms.Label()
        Me.NameField = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Desc = New System.Windows.Forms.TextBox()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.TotalField = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Location = New System.Drawing.Point(698, 387)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(12, 15)
        Me.Count.TabIndex = 80
        Me.Count.Text = "-"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(650, 387)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(32, 15)
        Me.Total.TabIndex = 79
        Me.Total.Text = "Total"
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(517, 406)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 76
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(410, 406)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 75
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(310, 406)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 74
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CreateButton
        '
        Me.CreateButton.Location = New System.Drawing.Point(199, 406)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(75, 23)
        Me.CreateButton.TabIndex = 73
        Me.CreateButton.Text = "New"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(67, 234)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowTemplate.Height = 25
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(667, 150)
        Me.dg.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(293, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 15)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(67, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 15)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Preço"
        '
        'Price
        '
        Me.Price.Location = New System.Drawing.Point(121, 132)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(100, 23)
        Me.Price.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(491, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Quantidade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(267, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Descrição"
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Location = New System.Drawing.Point(67, 79)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(40, 15)
        Me.Name.TabIndex = 63
        Me.Name.Text = "Nome"
        '
        'NameField
        '
        Me.NameField.Location = New System.Drawing.Point(121, 76)
        Me.NameField.Name = "NameField"
        Me.NameField.Size = New System.Drawing.Size(100, 23)
        Me.NameField.TabIndex = 62
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(566, 21)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(161, 23)
        Me.Search.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(505, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Buscar"
        '
        'Desc
        '
        Me.Desc.Location = New System.Drawing.Point(353, 79)
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(100, 23)
        Me.Desc.TabIndex = 81
        '
        'Quantity
        '
        Me.Quantity.Location = New System.Drawing.Point(566, 76)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(100, 23)
        Me.Quantity.TabIndex = 82
        '
        'TotalField
        '
        Me.TotalField.Location = New System.Drawing.Point(353, 132)
        Me.TotalField.Name = "TotalField"
        Me.TotalField.Size = New System.Drawing.Size(100, 23)
        Me.TotalField.TabIndex = 83
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(121, 21)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(48, 23)
        Me.ID.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 15)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "ID"
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.TotalField)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.Desc)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Name)
        Me.Controls.Add(Me.NameField)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Label1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Count As Label
    Friend WithEvents Total As Label
    Friend WithEvents DeleteButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents CreateButton As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Price As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Name As Label
    Friend WithEvents NameField As TextBox
    Friend WithEvents Search As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Desc As TextBox
    Friend WithEvents Quantity As TextBox
    Friend WithEvents TotalField As TextBox
    Friend WithEvents ID As TextBox
    Friend WithEvents Label2 As Label
End Class
