Imports MySql.Data.MySqlClient
Imports System.Data

Public Class Sistema


    Public Function ObtenerDetalleInicial(ByVal idVenta As Integer) As (IdVs As Integer, IdPr As Integer, PrecioU As Integer)

        Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tablafinal")
        Dim IdVs As Integer = 0
        Dim IdPr As Integer = 0
        Dim PrecioU As Integer = 0

        Try
            conexion.Open()

            Dim consulta As String = "SELECT IdVs, IdPr, PrecioU FROM ventasist WHERE IdVt = @IdVenta LIMIT 1"
            Dim comando As New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@IdVenta", idVenta)

            Dim reader As MySqlDataReader = comando.ExecuteReader()

            If reader.Read() Then
                IdVs = CInt(reader("IdVs"))
                IdPr = CInt(reader("IdPr"))
                PrecioU = CInt(reader("PrecioU"))
            End If

            reader.Close()

        Catch ex As Exception
            MessageBox.Show("Error al obtener el detalle inicial: " & ex.Message, "Error de Lectura")
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try

        Return (IdVs, IdPr, PrecioU)

    End Function

    Public Sub ActualizarItemVenta(ByVal idVenta As Integer, ByVal dgvDetalle As DataGridView)

        Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tablafinal")

        Try

            Dim datosIniciales As (IdVs As Integer, IdPr As Integer, PrecioU As Integer) = ObtenerDetalleInicial(idVenta)
            Dim IdVs_Actual As Integer = datosIniciales.IdVs
            Dim PrecioU_Actual As Integer = datosIniciales.PrecioU

            If IdVs_Actual = 0 Then
                Throw New Exception("No se encontró el ítem inicial para esta venta.")
            End If

            Dim inputCantidad As String = InputBox("Venta #" & idVenta.ToString() & " (IdPr: " & datosIniciales.IdPr.ToString() & "). Ingrese la nueva cantidad:")
            If String.IsNullOrWhiteSpace(inputCantidad) Then Return

            Dim NuevaCantidad As Integer = 0
            If Not Integer.TryParse(inputCantidad, NuevaCantidad) OrElse NuevaCantidad <= 0 Then
                Throw New Exception("La cantidad debe ser un número entero positivo.")
            End If
            Dim NuevoPrecioT As Integer = PrecioU_Actual * NuevaCantidad

            conexion.Open()
            Dim consultaUpdateDetalle As String = "UPDATE ventasist SET Cantidad = @Cantidad, PrecioT = @PrecioT WHERE IdVs = @IdVs"
            Dim comandoUpdateDetalle As New MySqlCommand(consultaUpdateDetalle, conexion)
            comandoUpdateDetalle.Parameters.AddWithValue("@Cantidad", NuevaCantidad)
            comandoUpdateDetalle.Parameters.AddWithValue("@PrecioT", NuevoPrecioT)
            comandoUpdateDetalle.Parameters.AddWithValue("@IdVs", IdVs_Actual)
            comandoUpdateDetalle.ExecuteNonQuery()

            Dim consultaUpdateVenta As String = "UPDATE ventas SET Total = @Total WHERE IdV = @IdVenta"
            Dim comandoUpdateVenta As New MySqlCommand(consultaUpdateVenta, conexion)
            comandoUpdateVenta.Parameters.AddWithValue("@Total", NuevoPrecioT)
            comandoUpdateVenta.Parameters.AddWithValue("@IdVenta", idVenta)
            comandoUpdateVenta.ExecuteNonQuery()

            MessageBox.Show("Cantidad y Total actualizados. Nuevo Total: $" & NuevoPrecioT.ToString())

            CargarVentasDetalle(dgvDetalle)

        Catch ex As Exception
            MessageBox.Show("Error al actualizar cantidad: " & ex.Message, "Error")
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try
    End Sub


    Public Sub CargarVentasDetalle(ByVal dgv As DataGridView)
        Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tablafinal")
        Dim comando As MySqlCommand

        Try
            conexion.Open()
            Dim consulta As String = "SELECT VS.IdVs, V.IdCl, VS.IdVt, VS.IdPr, VS.PrecioU, VS.Cantidad, VS.PrecioT FROM ventasist AS VS INNER JOIN ventas AS V ON VS.IdVt = V.IdV ORDER BY VS.IdVs DESC"

            comando = New MySqlCommand(consulta, conexion)

            Dim adaptador As New MySqlDataAdapter(comando)
            Dim tabla As New DataTable()

            adaptador.Fill(tabla)

            dgv.DataSource = tabla

        Catch ex As Exception
            MessageBox.Show("Error al cargar detalles de ventas: " & ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try
    End Sub

    Public Function ObtenerTotalActualVenta(ByVal idVenta As Integer) As Integer
        Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tablafinal")
        Dim total As Integer = 0

        Try
            conexion.Open()
            Dim consulta As String = "SELECT Total FROM ventas WHERE IdV = @IdVenta"
            Dim comando As New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@IdVenta", idVenta)

            Dim resultado As Object = comando.ExecuteScalar()

            If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then
                total = CInt(resultado)
            End If

            Return total
        Catch ex As Exception
            MessageBox.Show("Error al obtener el total: " & ex.Message)
            Return 0
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try
    End Function
    Public Sub FiltrarVentasPorFecha(ByVal dgv As DataGridView, ByVal fechaInicio As String, ByVal fechaFin As String)

        Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tablafinal")
        Dim tablaVentas As New DataTable()

        Try
            conexion.Open()


            Dim consulta As String = "SELECT IdV, IdCl, IdPr, Fecha, Total FROM ventas WHERE Fecha BETWEEN @FechaInicio AND @FechaFin ORDER BY IdV DESC"

            Dim comando As New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@FechaInicio", fechaInicio)
            comando.Parameters.AddWithValue("@FechaFin", fechaFin)

            Dim adaptador As New MySqlDataAdapter(comando)
            adaptador.Fill(tablaVentas)

            dgv.DataSource = tablaVentas

            If tablaVentas.Rows.Count = 0 Then
                MessageBox.Show("No se encontraron ventas en el rango de fechas seleccionado.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al filtrar ventas: " & ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try
    End Sub
End Class