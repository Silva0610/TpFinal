Public Class Form5
    Public IdVentaActual As Integer = 0
    Dim clsVenta As New Venta()
    Dim clsSistema As New Sistema()
    Private Sub Botonasd_Click(sender As Object, e As EventArgs) Handles asd.Click

        If IdVentaActual = 0 Then
            MessageBox.Show("ERROR: No hay una venta activa para modificar.", "Flujo Incorrecto")
            Return
        End If
        clsSistema.ActualizarItemVenta(Me.IdVentaActual, Me.DataGridView4)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles asd.Click

        If IdVentaActual = 0 Then
            MessageBox.Show("ERROR: Primero debe iniciar la venta con 'Registrar Venta'.", "Flujo Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        clsSistema.RegistrarItemVenta(IdVentaActual, Me.DataGridView4)

    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        clsSistema.CargarVentasDetalle(Me.DataGridView4)
    End Sub

    Private Sub Total_Click(sender As Object, e As EventArgs) Handles Total.Click
        If IdVentaActual > 0 Then
            Dim totalVenta As Integer = clsSistema.ObtenerTotalActualVenta(IdVentaActual)
            MessageBox.Show("Total Acumulado de Venta #" & IdVentaActual.ToString() & ": $" & totalVenta.ToString())
        Else
            MessageBox.Show("No hay una venta activa para mostrar el total.", "Advertencia")
        End If
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
End Class