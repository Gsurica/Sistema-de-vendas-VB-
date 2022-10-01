<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients
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
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Phone = New System.Windows.Forms.MaskedTextBox()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Sex = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameField = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Location = New System.Drawing.Point(701, 392)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(12, 15)
        Me.Count.TabIndex = 59
        Me.Count.Text = "-"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(653, 392)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(32, 15)
        Me.Total.TabIndex = 58
        Me.Total.Text = "Total"
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(356, 145)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(100, 23)
        Me.Email.TabIndex = 57
        '
        'Phone
        '
        Me.Phone.Location = New System.Drawing.Point(569, 145)
        Me.Phone.Mask = "(00) 00000-0000"
        Me.Phone.Name = "Phone"
        Me.Phone.Size = New System.Drawing.Size(100, 23)
        Me.Phone.TabIndex = 56
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(520, 411)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 55
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(413, 411)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 54
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(313, 411)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 53
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CreateButton
        '
        Me.CreateButton.Location = New System.Drawing.Point(202, 411)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(75, 23)
        Me.CreateButton.TabIndex = 52
        Me.CreateButton.Text = "New"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(70, 239)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowTemplate.Height = 25
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(667, 150)
        Me.dg.TabIndex = 51
        '
        'Cpf
        '
        Me.Cpf.Location = New System.Drawing.Point(569, 81)
        Me.Cpf.Mask = "000.000.000-00"
        Me.Cpf.Name = "Cpf"
        Me.Cpf.Size = New System.Drawing.Size(100, 23)
        Me.Cpf.TabIndex = 50
        '
        'Sex
        '
        Me.Sex.FormattingEnabled = True
        Me.Sex.Items.AddRange(New Object() {"Feminine ", "Masculine"})
        Me.Sex.Location = New System.Drawing.Point(356, 81)
        Me.Sex.Name = "Sex"
        Me.Sex.Size = New System.Drawing.Size(100, 23)
        Me.Sex.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(512, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Telefone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(301, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(54, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Endereço"
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(124, 142)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(100, 23)
        Me.Address.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(535, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "CPF"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(319, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Sexo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Nome"
        '
        'NameField
        '
        Me.NameField.Location = New System.Drawing.Point(124, 81)
        Me.NameField.Name = "NameField"
        Me.NameField.Size = New System.Drawing.Size(100, 23)
        Me.NameField.TabIndex = 37
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(569, 26)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(161, 23)
        Me.Search.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(508, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Buscar"
        '
        'Clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 498)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Phone)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Cpf)
        Me.Controls.Add(Me.Sex)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameField)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Clients"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clients"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Count As Label
    Friend WithEvents Total As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents Phone As MaskedTextBox
    Friend WithEvents DeleteButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents CreateButton As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents Cpf As MaskedTextBox
    Friend WithEvents Sex As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Address As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NameField As TextBox
    Friend WithEvents Search As TextBox
    Friend WithEvents Label1 As Label
End Class
