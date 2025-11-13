Public Class Form6
    Dim clsVenta As New Venta()
    Public IdVentaActiva As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Public Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles BtnRegistro.Click

        IdVentaActiva = clsVenta.RegistrarVenta
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarVentas()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        If IdVentaActiva = 0 Then
            MessageBox.Show("Debe iniciar una venta antes de ir al detalle.", "Advertencia")
            Return
        End If

        Dim formDetalle As New Form7
        formDetalle.IdVentaActual = IdVentaActiva
        formDetalle.Show()
    End Sub


End Class