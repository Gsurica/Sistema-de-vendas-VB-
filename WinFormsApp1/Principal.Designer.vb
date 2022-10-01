<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.employeeTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarVendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListasVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.labelUser = New System.Windows.Forms.Label()
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.labelDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.labelHour = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Vendas = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrosToolStripMenuItem, Me.VendasToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.employeeTab, Me.ClientesToolStripMenuItem})
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'employeeTab
        '
        Me.employeeTab.Enabled = False
        Me.employeeTab.Name = "employeeTab"
        Me.employeeTab.Size = New System.Drawing.Size(142, 22)
        Me.employeeTab.Text = "Funcionários"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProdutosToolStripMenuItem, Me.RegistrarVendaToolStripMenuItem, Me.ListasVendasToolStripMenuItem})
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.VendasToolStripMenuItem.Text = "Vendas"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'RegistrarVendaToolStripMenuItem
        '
        Me.RegistrarVendaToolStripMenuItem.Name = "RegistrarVendaToolStripMenuItem"
        Me.RegistrarVendaToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.RegistrarVendaToolStripMenuItem.Text = "Registrar venda"
        '
        'ListasVendasToolStripMenuItem
        '
        Me.ListasVendasToolStripMenuItem.Name = "ListasVendasToolStripMenuItem"
        Me.ListasVendasToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ListasVendasToolStripMenuItem.Text = "Listar vendas"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem1})
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(93, 22)
        Me.SairToolStripMenuItem1.Text = "Sair"
        '
        'labelUser
        '
        Me.labelUser.AutoSize = True
        Me.labelUser.Location = New System.Drawing.Point(648, 41)
        Me.labelUser.Name = "labelUser"
        Me.labelUser.Size = New System.Drawing.Size(72, 15)
        Me.labelUser.TabIndex = 1
        Me.labelUser.Text = "Bem-vindo: "
        '
        'usernameLabel
        '
        Me.usernameLabel.AutoSize = True
        Me.usernameLabel.Location = New System.Drawing.Point(717, 41)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(12, 15)
        Me.usernameLabel.TabIndex = 2
        Me.usernameLabel.Text = "-"
        '
        'labelDate
        '
        Me.labelDate.AutoSize = True
        Me.labelDate.Location = New System.Drawing.Point(648, 426)
        Me.labelDate.Name = "labelDate"
        Me.labelDate.Size = New System.Drawing.Size(41, 15)
        Me.labelDate.TabIndex = 3
        Me.labelDate.Text = "Label1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'labelHour
        '
        Me.labelHour.AutoSize = True
        Me.labelHour.Location = New System.Drawing.Point(727, 426)
        Me.labelHour.Name = "labelHour"
        Me.labelHour.Size = New System.Drawing.Size(41, 15)
        Me.labelHour.TabIndex = 4
        Me.labelHour.Text = "Label1"
        '
        'dg
        '
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(57, 108)
        Me.dg.Name = "dg"
        Me.dg.RowTemplate.Height = 25
        Me.dg.Size = New System.Drawing.Size(702, 250)
        Me.dg.TabIndex = 5
        '
        'Vendas
        '
        Me.Vendas.AutoSize = True
        Me.Vendas.Location = New System.Drawing.Point(57, 53)
        Me.Vendas.Name = "Vendas"
        Me.Vendas.Size = New System.Drawing.Size(47, 15)
        Me.Vendas.TabIndex = 6
        Me.Vendas.Text = "Vendas:"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Vendas)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.labelHour)
        Me.Controls.Add(Me.labelDate)
        Me.Controls.Add(Me.usernameLabel)
        Me.Controls.Add(Me.labelUser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarVendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListasVendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents labelUser As Label
    Friend WithEvents usernameLabel As Label
    Friend WithEvents labelDate As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents labelHour As Label
    Friend WithEvents employeeTab As ToolStripMenuItem
    Friend WithEvents dg As DataGridView
    Friend WithEvents Vendas As Label
End Class
