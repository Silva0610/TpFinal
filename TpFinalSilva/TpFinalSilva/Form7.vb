Public Class Form7
    Public IdVentaActual As Integer = 0
    Dim clsVenta As New Venta()
    Dim clsSistema As New Sistema()
    Private Sub Botonasd_Click(sender As Object, e As EventArgs) Handles asd.Click

        If IdVentaActual = 0 Then
            MessageBox.Show("ERROR: No hay una venta activa para modificar.", "Flujo Incorrecto")
            Return
        End If

        clsSistema.ActualizarItemVenta(IdVentaActual, DataGridView6)

    End Sub
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        clsSistema.CargarVentasDetalle(Me.DataGridView6)
    End Sub

    Private Sub Total_Click(sender As Object, e As EventArgs) Handles Total.Click
        If IdVentaActual > 0 Then
            Dim totalVenta = clsSistema.ObtenerTotalActualVenta(IdVentaActual)
            MessageBox.Show("Total Acumulado de Venta #" & IdVentaActual.ToString & ": $" & totalVenta.ToString)
        Else
            MessageBox.Show("No hay una venta activa para mostrar el total.", "Advertencia")
        End If
    End Sub
    Public Sub BtnBuscarFecha_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        If String.IsNullOrWhiteSpace(TxtFecha1.Text) Or String.IsNullOrWhiteSpace(TxtFecha2.Text) Then
            MessageBox.Show("Debe ingresar las fechas de inicio y fin para filtrar.", "Fechas Requeridas", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim clsSistema As New Sistema

        Try

            Dim fechaInicio = Date.Parse(TxtFecha1.Text).ToString("yyyy-MM-dd")
            Dim fechaFin = Date.Parse(TxtFecha2.Text).ToString("yyyy-MM-dd")

            clsSistema.FiltrarVentasPorFecha(DataGridView6, fechaInicio, fechaFin)

        Catch ex As FormatException
            MessageBox.Show("Formato de fecha inválido. Utilice un formato de fecha reconocido (ej. DD/MM/AAAA).", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error al buscar: " & ex.Message)
        End Try

    End Sub
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form6.Show()
        Me.Hide()
    End Sub
End Class