Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            Dim user As New Usuario()
            user.DNI = txtdni2.Text
            user.Nombre = txtnombre2.Text
            user.Apellido = txtapellido2.Text
            user.Password = txtcontraseña2.Text


            Dim db As New Usuario()
            db.Guardar(user)


            MessageBox.Show("Datos guardados correctamente ✔", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Form3.Show()
            Me.Hide()
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


End Class