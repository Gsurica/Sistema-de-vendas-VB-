Imports System.Data.SqlClient
Imports System.Net

Public Class Products
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Disable_Fields()
        SaveButton.Enabled = False
        getProducts()
        EditButton.Enabled = False
        DeleteButton.Enabled = False
    End Sub

    Private Sub Disable_Fields()
        ID.Enabled = False
        NameField.Enabled = False
        TotalField.Enabled = False
        Quantity.Enabled = False
        Desc.Enabled = False
        Price.Enabled = False
    End Sub

    Private Sub getProducts()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            OpenConnection()
            da = New SqlDataAdapter("SELECT * FROM itens_venda", Connection.connection)
            da.Fill(dt)
            dg.DataSource = dt

            CountRows()
            FormatDg()
        Catch ex As Exception
            MessageBox.Show("Err, Can't get the data!" + ex.Message)
            CloseConnection()
        End Try
    End Sub

    Private Sub CountRows()
        Dim total As Integer = dg.Rows.Count
        Count.Text = CInt(total)
    End Sub
    Private Sub FormatDg()
        dg.Columns(0).HeaderText = "Código produto"
        dg.Columns(1).HeaderText = "Nome"
        dg.Columns(2).HeaderText = "descrição"
        dg.Columns(3).HeaderText = "Quantidade"
        dg.Columns(4).HeaderText = "preço"
        dg.Columns(5).HeaderText = "Total"
        dg.Columns(6).HeaderText = "Data"

        dg.Columns(0).Width = 140

    End Sub
    Private Sub Enable_fields()
        NameField.Enabled = True
        TotalField.Enabled = True
        Quantity.Enabled = True
        Desc.Enabled = True
        Price.Enabled = True
    End Sub

    Private Sub Clear_fields()
        ID.Text = ""
        NameField.Text = ""
        TotalField.Text = ""
        Quantity.Text = ""
        Desc.Text = ""
        Price.Text = ""
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Enable_fields()
        Clear_fields()
        SaveButton.Enabled = True
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim cmd As SqlCommand
        Try
            OpenConnection()
            cmd = New SqlCommand("sp_createProduct ", Connection.connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@name", NameField.Text)
            cmd.Parameters.AddWithValue("@descriprition", Desc.Text)
            cmd.Parameters.AddWithValue("@quantity", CInt(Quantity.Text))
            cmd.Parameters.AddWithValue("@price", CInt(Price.Text))
            cmd.Parameters.AddWithValue("@total", CInt(TotalField.Text))
            cmd.Parameters.AddWithValue("@data", Now.Date)
            cmd.Parameters.Add("@message", SqlDbType.VarChar, 100).Direction = 2
            cmd.ExecuteNonQuery()
            Dim msg As String = cmd.Parameters("@message").Value.ToString()
            MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            getProducts()
            Clear_fields()

            SaveButton.Enabled = False

        Catch ex As Exception
            CloseConnection()
            MessageBox.Show("Err, Can't save the data" + ex.Message)
        End Try
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        Enable_fields()

        ID.Text = dg.CurrentRow.Cells(0).Value
        NameField.Text = dg.CurrentRow.Cells(1).Value
        Desc.Text = dg.CurrentRow.Cells(2).Value
        TotalField.Text = dg.CurrentRow.Cells(3).Value
        Quantity.Text = dg.CurrentRow.Cells(4).Value
        Price.Text = dg.CurrentRow.Cells(5).Value
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim cmd As SqlCommand
        Try
            OpenConnection()
            cmd = New SqlCommand("sp_editProduct ", Connection.connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@name", NameField.Text)
            cmd.Parameters.AddWithValue("@descriprition", Desc.Text)
            cmd.Parameters.AddWithValue("@quantity", CInt(Quantity.Text))
            cmd.Parameters.AddWithValue("@price", CInt(Price.Text))
            cmd.Parameters.AddWithValue("@total", CInt(TotalField.Text))
            cmd.Parameters.AddWithValue("@id_produto", CInt(ID.Text))
            cmd.Parameters.Add("@message", SqlDbType.VarChar, 100).Direction = 2
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

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim cmd As SqlCommand
        Try
            OpenConnection()
            cmd = New SqlCommand("sp_deleteProduct ", Connection.connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id_produto", CInt(ID.Text))
            cmd.Parameters.Add("@message", SqlDbType.VarChar, 100).Direction = 2
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

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        If Search.Text = "" Then
            getProducts()
        End If
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            OpenConnection()
            da = New SqlDataAdapter("sp_searchProduct", Connection.connection)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@name", Search.Text)
            da.Fill(dt)
            dg.DataSource = dt

            CountRows()
            FormatDg()
        Catch ex As Exception
            MessageBox.Show("Err, Can't get the data! " + ex.Message)
            CloseConnection()
        End Try
    End Sub

    Private Sub Total_Click(sender As Object, e As EventArgs) Handles Total.Click

    End Sub

    Private Sub Count_Click(sender As Object, e As EventArgs) Handles Count.Click

    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Price_TextChanged(sender As Object, e As EventArgs) Handles Price.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Name_Click(sender As Object, e As EventArgs) Handles Name.Click

    End Sub

    Private Sub NameField_TextChanged(sender As Object, e As EventArgs) Handles NameField.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Desc_TextChanged(sender As Object, e As EventArgs) Handles Desc.TextChanged

    End Sub

    Private Sub Quantity_TextChanged(sender As Object, e As EventArgs) Handles Quantity.TextChanged

    End Sub

    Private Sub TotalField_TextChanged(sender As Object, e As EventArgs) Handles TotalField.TextChanged

    End Sub

    Private Sub ID_TextChanged(sender As Object, e As EventArgs) Handles ID.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class