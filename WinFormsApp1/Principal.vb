Imports System.Data.SqlClient

Public Class Principal
    Private Sub VendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendasToolStripMenuItem.Click

    End Sub

    Private Sub ListasVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListasVendasToolStripMenuItem.Click

    End Sub

    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub RegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosToolStripMenuItem.Click

    End Sub

    Private Sub employeeTab_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click, employeeTab.Click
        Dim form = New Employees
        form.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim form = New Clients
        form.ShowDialog()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        Dim form = New Products
        form.ShowDialog()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        usernameLabel.Text = username
        If username = "Admin" Then
            employeeTab.Enabled = True
        End If
        getSales()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelHour.Text = Now.ToLongTimeString()
        labelDate.Text = Now.ToShortDateString()
    End Sub

    Private Sub getSales()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            OpenConnection()
            da = New SqlDataAdapter("SELECT * FROM vendas", Connection.connection)
            da.Fill(dt)
            dg.DataSource = dt

            FormatDg()
        Catch ex As Exception
            MessageBox.Show("Err, Can't get the data!" + ex.Message)
            CloseConnection()
        End Try
    End Sub

    Private Sub FormatDg()
        dg.Columns(0).Visible = False

        dg.Columns(1).HeaderText = "Número de vendas"
        dg.Columns(2).HeaderText = "Produto"
        dg.Columns(3).HeaderText = "Cliente"
        dg.Columns(4).HeaderText = "Funcionário"
        dg.Columns(6).HeaderText = "preço total"
        dg.Columns(5).HeaderText = "quantidade"
        dg.Columns(7).HeaderText = "Data da venda"

    End Sub

    Private Sub RegistrarVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarVendaToolStripMenuItem.Click
        Dim form = New Sales
        form.ShowDialog()
    End Sub
End Class