Imports System.Data.SqlClient

Public Class Sales
    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Disable_Fields()
        SaveButton.Enabled = False
        getProducts()
        getClients()
        getEmployees()
        getSales()
        EditButton.Enabled = False
        DeleteButton.Enabled = False
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
    Private Sub getProducts()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            OpenConnection()
            da = New SqlDataAdapter("SELECT * FROM itens_venda", Connection.connection)
            da.Fill(dt)
            comboProduct.DisplayMember = "name"
            comboProduct.ValueMember = "id_produto"
            comboProduct.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Err, Can't get the data! " + ex.Message)
            CloseConnection()
        End Try
    End Sub
    Private Sub getClients()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            OpenConnection()
            da = New SqlDataAdapter("SELECT * FROM clients", Connection.connection)
            da.Fill(dt)
            comboClient.DisplayMember = "name"
            comboClient.ValueMember = "id_client"
            comboClient.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Err, Can't get the data! " + ex.Message)
            CloseConnection()
        End Try
    End Sub

    Private Sub getEmployees()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            OpenConnection()
            da = New SqlDataAdapter("SELECT * FROM employees", Connection.connection)
            da.Fill(dt)
            comboEmployee.DisplayMember = "name"
            comboEmployee.ValueMember = "id_employee"
            comboEmployee.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Err, Can't get the data! " + ex.Message)
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
    Private Sub Enable_fields()
        SalesField.Enabled = True
        comboClient.Enabled = True
        comboProduct.Enabled = True
        QuantityField.Enabled = True
        Price.Enabled = True
    End Sub
    Private Sub Clear_fields()
        ID.Text = ""
        SalesField.Text = ""
        comboClient.Text = ""
        comboProduct.Text = ""
        QuantityField.Text = ""
        Price.Text = ""
    End Sub
    Private Sub Disable_Fields()
        ID.Enabled = False
        SalesField.Enabled = False
        comboClient.Enabled = False
        comboProduct.Enabled = False
        QuantityField.Enabled = False
        Price.Enabled = False
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Enable_fields()
        SaveButton.Enabled = True
        Clear_fields()
    End Sub

    Private Sub comboProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboProduct.SelectedIndexChanged
        Dim cmd As SqlCommand
        Try
            OpenConnection()
            cmd = New SqlCommand("searchValue", Connection.connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_produto", comboProduct.SelectedValue)
            cmd.Parameters.Add("@value", SqlDbType.Decimal).Direction = 2
            cmd.Parameters.Add("@quantity", SqlDbType.Int).Direction = 2
            cmd.ExecuteNonQuery()

            Dim value As Decimal? = cmd.Parameters("@value").Value
            Price.Text = CStr(value)

            Dim quantity As Int32? = cmd.Parameters("@quantity").Value
            stock.Text = CStr(quantity)

        Catch ex As Exception
            MessageBox.Show("Err, Can't get the data! " + ex.Message)
            CloseConnection()
        End Try
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim cmd As SqlCommand

        Dim total As Decimal
        Dim value As Decimal
        Dim quantity As Decimal

        value = Price.Text
        quantity = QuantityField.Text
        total = value * quantity

        Try
            OpenConnection()
            cmd = New SqlCommand("sp_saveSale ", Connection.connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@vendas_clientes", SalesField.Text)
            cmd.Parameters.AddWithValue("@id_produto", comboProduct.SelectedValue)
            cmd.Parameters.AddWithValue("@id_client", comboClient.SelectedValue)
            cmd.Parameters.AddWithValue("@id_employee", comboEmployee.SelectedValue)
            cmd.Parameters.AddWithValue("@price", Result())
            cmd.Parameters.AddWithValue("@quantity", QuantityField.Text)
            cmd.Parameters.AddWithValue("@date", Now.Date)
            cmd.Parameters.Add("@message", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()
            Dim msg As String = cmd.Parameters("@message").Value.ToString()
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            getSales()
            Clear_fields()

            SaveButton.Enabled = False

        Catch ex As Exception
            CloseConnection()
            MessageBox.Show("Err, Can't save the data" + ex.Message)
        End Try
    End Sub

    Private Function Result()
        Dim total As Decimal
        Dim value As Decimal
        Dim quantity As Decimal

        value = Price.Text
        quantity = QuantityField.Text
        total = value * quantity
        Return total
    End Function

    Private Sub comboEmployee_Click(sender As Object, e As EventArgs) Handles lvl.Click

    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim cmd As SqlCommand
        Try
            OpenConnection()
            cmd = New SqlCommand("sp_editSale ", Connection.connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_venda", ID.Text)
            cmd.Parameters.AddWithValue("@vendas_clientes", SalesField.Text)
            cmd.Parameters.AddWithValue("@id_produto", comboProduct.SelectedValue)
            cmd.Parameters.AddWithValue("@price", Result())
            cmd.Parameters.AddWithValue("@quantity", QuantityField.Text)
            cmd.Parameters.AddWithValue("@date", Now.Date)
            cmd.ExecuteNonQuery()
            Dim msg As String = cmd.Parameters("@message").Value.ToString()
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            getProducts()
            Clear_fields()

        Catch ex As Exception
            CloseConnection()
            MessageBox.Show("Err, Can't save the data" + ex.Message)
        End Try
    End Sub
End Class