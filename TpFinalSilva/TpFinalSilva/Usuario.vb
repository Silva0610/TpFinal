Imports MySql.Data.MySqlClient

Public Class Usuario
    Inherits datos

    Private ReadOnly connectionString As String = "server=localhost;port=3306;user id=root;password=;database=tablafinal"


    Public Sub Guardar(user As Usuario)

        Dim conn As New MySqlConnection(connectionString)
        Dim cmd As MySqlCommand = Nothing

        Try
            conn.Open()


            Dim query As String = "INSERT INTO usuarios (DNI, Usuario, Apellido, Contraseña) VALUES (@dni, @usuario, @apellido, @pass)"

            cmd = New MySqlCommand(query, conn)


            cmd.Parameters.AddWithValue("@dni", user.DNI)
            cmd.Parameters.AddWithValue("@usuario", user.Nombre)
            cmd.Parameters.AddWithValue("@apellido", user.Apellido)
            cmd.Parameters.AddWithValue("@pass", user.Password)

            cmd.ExecuteNonQuery()

        Catch ex As MySqlException
            Throw New Exception("Error de base de datos: " & ex.Message)
        Finally
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try


    End Sub
    Public Function ValidarUsuario(dni As String, password As String) As Boolean

        Dim conn As New MySqlConnection(connectionString)
        Dim cmd As MySqlCommand = Nothing
        Dim resultado As Boolean = False

        Try
            conn.Open()


            Dim query As String = "SELECT COUNT(*) FROM usuarios WHERE DNI = @dni AND Contraseña = @pass"

            cmd = New MySqlCommand(query, conn)


            cmd.Parameters.AddWithValue("@dni", dni)
            cmd.Parameters.AddWithValue("@pass", password)


            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())


            If count = 1 Then
                resultado = True
            End If

        Catch ex As MySqlException

            Throw New Exception("Error no coincide: " & ex.Message)
        Finally

            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try


        Return resultado
    End Function
End Class
