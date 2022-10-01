Imports System.Data.SqlClient

Public Class Clients
    Private Sub Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Desable_fields()
        SaveButton.Enabled = False
        getClients()
        EditButton.Enabled = False
        DeleteButton.Enabled = False
    End Sub
    Private Sub Desable_fields()
        NameField.Enabled = False
        Sex.Enabled = False
        Cpf.Enabled = False
        Address.Enabled = False
        Email.Enabled = False
        Phone.Enabled = False
    End Sub
    Private Sub getClients()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            OpenConnection()
            da = New SqlDataAdapter("SELECT * FROM clients", Connection.connection)
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
        dg.Columns(0).Visible = False
        dg.Columns(1).HeaderText = "Name"
        dg.Columns(2).HeaderText = "Sex"
        dg.Columns(3).HeaderText = "Cpf"
        dg.Columns(4).HeaderText = "Address"
        dg.Columns(5).HeaderText = "Phone"
        dg.Columns(6).HeaderText = "Email"
        dg.Columns(7).HeaderText = "Data"

        dg.Columns(6).Width = 140
        dg.Columns(7).Width = 130

    End Sub
    Private Sub Enable_fields()
        NameField.Enabled = True
        Sex.Enabled = True
        Cpf.Enabled = True
        Address.Enabled = True
        Email.Enabled = True
        Phone.Enabled = True
    End Sub

    Private Sub Clear_fields()
        NameField.Text = ""
        Sex.Text = ""
        Cpf.Text = ""
        Address.Text = ""
        Email.Text = ""
        Phone.Text = ""
        Search.Text = ""
    End Sub

    Private Sub CreateButton_Click(sender As Object, e As EventArgs) Handles CreateButton.Click
        Enable_fields()
        Clear_fields()
        SaveButton.Enabled = True
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim cmd As SqlCommand
        If Cpf.Text <> "" And NameField.Text <> "" Then
            Try
                OpenConnection()
                cmd = New SqlCommand("sp_saveClient", Connection.connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", NameField.Text)
                cmd.Parameters.AddWithValue("@sexo", Sex.Text)
                cmd.Parameters.AddWithValue("@cpf", Cpf.Text)
                cmd.Parameters.AddWithValue("@address", Address.Text)
                cmd.Parameters.AddWithValue("@phone", Phone.Text)
                cmd.Parameters.AddWithValue("@email", Email.Text)
                cmd.Parameters.AddWithValue("@data", Now.Date)
                cmd.Parameters.Add("@message", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()
                Dim msg As String = cmd.Parameters("@message").Value.ToString()
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                getClients()
                Clear_fields()

                SaveButton.Enabled = False

            Catch ex As Exception
                MessageBox.Show("Err, Can't save the data" + ex.Message)
            End Try
        End If
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        Enable_fields()
        Cpf.Enabled = False

        NameField.Text = dg.CurrentRow.Cells(1).Value
        Sex.Text = dg.CurrentRow.Cells(2).Value
        Cpf.Text = dg.CurrentRow.Cells(3).Value
        Address.Text = dg.CurrentRow.Cells(4).Value
        Phone.Text = dg.CurrentRow.Cells(5).Value
        Email.Text = dg.CurrentRow.Cells(6).Value
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        Dim cmd As SqlCommand
        If Cpf.Text <> "" And NameField.Text <> "" Then
            Try
                OpenConnection()
                cmd = New SqlCommand("sp_editClient", Connection.connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@name", NameField.Text)
                cmd.Parameters.AddWithValue("@sexo", Sex.Text)
                cmd.Parameters.AddWithValue("@cpf", Cpf.Text)
                cmd.Parameters.AddWithValue("@address", Address.Text)
                cmd.Parameters.AddWithValue("@phone", Phone.Text)
                cmd.Parameters.AddWithValue("@email", Email.Text)
                cmd.Parameters.AddWithValue("@data", Now.Date)
                cmd.Parameters.Add("@message", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()
                Dim msg As String = cmd.Parameters("@message").Value.ToString()
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                getClients()
                Clear_fields()


            Catch ex As Exception
                MessageBox.Show("Err, Can't save the data" + ex.Message)
            End Try
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim cmd As SqlCommand
        If Cpf.Text <> "" Then
            Try
                OpenConnection()
                cmd = New SqlCommand("sp_deleteClient", Connection.connection)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@cpf", Cpf.Text)
                cmd.Parameters.Add("@message", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()
                Dim msg As String = cmd.Parameters("@message").Value.ToString()
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                getClients()
                Clear_fields()

                DeleteButton.Enabled = False
                EditButton.Enabled = False
            Catch ex As Exception
                MessageBox.Show("Err, Can't get the data! " + ex.Message)
                CloseConnection()
            End Try
        End If
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        If Search.Text = "" Then
            getClients()
        End If
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            OpenConnection()
            da = New SqlDataAdapter("sp_searchClient", Connection.connection)
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
End Class