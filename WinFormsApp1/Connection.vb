Imports System.Data.SqlClient

Module Connection
    Public connection As New SqlConnection("Server=DESKTOP-BS61M3B\GUILHERMEDB; DataBase=vbsystem; Integrated Security=SSPI")

    Sub OpenConnection()
        If connection.State = 0 Then
            connection.Open()
        End If
    End Sub

    Sub CloseConnection()
        If connection.State = 1 Then
            connection.Close()
        End If
    End Sub

    Public username As String
End Module
