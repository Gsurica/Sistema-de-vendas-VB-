<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employees
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.NameField = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Sex = New System.Windows.Forms.ComboBox()
        Me.Turn = New System.Windows.Forms.ComboBox()
        Me.HiringDate = New System.Windows.Forms.DateTimePicker()
        Me.Cpf = New System.Windows.Forms.MaskedTextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.phone = New System.Windows.Forms.MaskedTextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Total = New System.Windows.Forms.Label()
        Me.Count = New System.Windows.Forms.Label()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(470, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar"
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(531, 37)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(161, 23)
        Me.Search.TabIndex = 1
        '
        'NameField
        '
        Me.NameField.Location = New System.Drawing.Point(86, 92)
        Me.NameField.Name = "NameField"
        Me.NameField.Size = New System.Drawing.Size(100, 23)
        Me.NameField.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(484, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CPF"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(461, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Telefone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Endereço"
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(86, 153)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(100, 23)
        Me.Address.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(200, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "data da contratação"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Turno"
        '
        'Sex
        '
        Me.Sex.FormattingEnabled = True
        Me.Sex.Items.AddRange(New Object() {"Feminine ", "Masculine"})
        Me.Sex.Location = New System.Drawing.Point(318, 92)
        Me.Sex.Name = "Sex"
        Me.Sex.Size = New System.Drawing.Size(100, 23)
        Me.Sex.TabIndex = 18
        '
        'Turn
        '
        Me.Turn.FormattingEnabled = True
        Me.Turn.Items.AddRange(New Object() {"morning", "afternoon", "night", "dawn"})
        Me.Turn.Location = New System.Drawing.Point(86, 222)
        Me.Turn.Name = "Turn"
        Me.Turn.Size = New System.Drawing.Size(100, 23)
        Me.Turn.TabIndex = 19
        '
        'HiringDate
        '
        Me.HiringDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HiringDate.Location = New System.Drawing.Point(318, 222)
        Me.HiringDate.Name = "HiringDate"
        Me.HiringDate.Size = New System.Drawing.Size(100, 23)
        Me.HiringDate.TabIndex = 20
        '
        'Cpf
        '
        Me.Cpf.Location = New System.Drawing.Point(531, 92)
        Me.Cpf.Mask = "000.000.000-00"
        Me.Cpf.Name = "Cpf"
        Me.Cpf.Size = New System.Drawing.Size(100, 23)
        Me.Cpf.TabIndex = 22
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(75, 288)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.RowTemplate.Height = 25
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(667, 150)
        Me.dg.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(207, 460)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(318, 460)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 25
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(525, 460)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 27
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(418, 460)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 26
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(531, 156)
        Me.phone.Mask = "(00) 00000-0000"
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(100, 23)
        Me.phone.TabIndex = 28
        '
        'Email
        '
        Me.Email.Location = New System.Drawing.Point(318, 156)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(100, 23)
        Me.Email.TabIndex = 29
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(658, 441)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(32, 15)
        Me.Total.TabIndex = 33
        Me.Total.Text = "Total"
        '
        'Count
        '
        Me.Count.AutoSize = True
        Me.Count.Location = New System.Drawing.Point(706, 441)
        Me.Count.Name = "Count"
        Me.Count.Size = New System.Drawing.Size(12, 15)
        Me.Count.TabIndex = 34
        Me.Count.Text = "-"
        '
        'Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 520)
        Me.Controls.Add(Me.Count)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.Cpf)
        Me.Controls.Add(Me.HiringDate)
        Me.Controls.Add(Me.Turn)
        Me.Controls.Add(Me.Sex)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
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
        Me.Name = "Employees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employees"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Search As TextBox
    Friend WithEvents NameField As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Address As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Sex As ComboBox
    Friend WithEvents Turn As ComboBox
    Friend WithEvents HiringDate As DateTimePicker
    Friend WithEvents Cpf As MaskedTextBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents phone As MaskedTextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents Total As Label
    Friend WithEvents Count As Label
End Class
