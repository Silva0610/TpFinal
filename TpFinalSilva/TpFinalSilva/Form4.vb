Public Class Form4
    Public Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarClientes()
    End Sub
    Public Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAlta.Click
        Dim cliente As New Cliente
        cliente.altas()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnbaja.Click
        Dim cliente As New Cliente


        If cliente.IdCl = -1 Then
            MessageBox.Show("Seleccione un cliente para eliminar.")
            Return
        End If

        cliente.baja(cliente.IdCl)
    End Sub

    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cliente As New Cliente
        cliente.modif(cliente.Cliente, cliente.IdCl, cliente.Correo, cliente.telefono)
    End Sub

    Public Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim cliente As New Cliente
        cliente.buscar()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()

    End Sub
End Class