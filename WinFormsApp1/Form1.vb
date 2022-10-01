Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim textUser As String = User.Text
        Dim textpass As String = Pass.Text
        Dim cmd As SqlCommand

        If textUser = "" Or textpass = "" Then
            MsgBox("Preencha os campos!")
        Else
            Try
                OpenConnection()
                cmd = New SqlCommand("sp_login", Connection.connection)
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .AddWithValue("@name", textUser)
                    .AddWithValue("@cpf", textpass)
                    .Add("@message", SqlDbType.VarChar, 100).Direction = 2
                    cmd.ExecuteNonQuery()
                End With

                username = User.Text

                Dim msg As String = cmd.Parameters("@message").Value.ToString()
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If msg = "Dados incorretos" Then
                    textUser = ""
                    textpass = ""
                Else
                    Dim form = New Principal
                    Me.Hide()
                    form.ShowDialog()
                End If

            Catch ex As Exception

            End Try
        End If


    End Sub
End Class
