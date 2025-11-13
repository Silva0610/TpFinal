Imports System.Linq.Expressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Windows.Win32.System
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim dniIngresado As String = txtdni1.Text
        Dim passIngresada As String = txtcontraseña1.Text


        If String.IsNullOrWhiteSpace(dniIngresado) OrElse String.IsNullOrWhiteSpace(passIngresada) Then
            MessageBox.Show("Por favor, ingrese DNI y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return '
        End If


        Dim db As New Usuario()

        Try

            Dim loginExitoso As Boolean = db.ValidarUsuario(dniIngresado, passIngresada)


            If loginExitoso Then
                Form3.Show()
                Me.Hide()

            Else

                MessageBox.Show("DNI o contraseña incorrectos.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtcontraseña1.Text = ""
        txtdni1.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub


End Class