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
            MessageBox.Show("Error al obtener el detalle inicial de la venta: " & ex.Message, "Error de Lectura")

            Return (0, 0, 0)
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try


        Return (IdVs, IdPr, PrecioU)

    End Function
    Public Function ObtenerPrecioProducto(IdPr As Integer, ByRef conexion As MySqlConnection) As Integer
        Dim precio As Integer = -1
        Dim localConexion As MySqlConnection = conexion


        Dim estuvoAbierta As Boolean = (localConexion IsNot Nothing AndAlso localConexion.State = ConnectionState.Open)

        If localConexion Is Nothing OrElse localConexion.State <> ConnectionState.Open Then
            localConexion = New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tablafinal")
            localConexion.Open()
            estuvoAbierta = False
        End If

        Try
            Dim consulta As String = "SELECT Precio FROM productos WHERE IdPr = @IdPr"
            Dim comando As New MySqlCommand(consulta, localConexion)
            comando.Parameters.AddWithValue("@IdPr", IdPr)

            Dim resultado As Object = comando.ExecuteScalar()

            If resultado IsNot Nothing AndAlso Not IsDBNull(resultado) Then
                precio = CInt(resultado)
            End If

        Catch ex As Exception
            precio = -1
            MessageBox.Show("Error al obtener precio: " & ex.Message)
        Finally
            If Not estuvoAbierta AndAlso localConexion IsNot Nothing AndAlso localConexion.State = ConnectionState.Open Then
                localConexion.Close()
            End If
        End Try
        Return precio
    End Function

    Public Sub ActualizarTotalVenta(ByVal idVenta As Integer)
        Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tablafinal")

        Try
            conexion.Open()
            Dim consultaSuma As String = "SELECT SUM(PrecioT) FROM ventasist WHERE IdVt = @IdVenta"
            Dim comandoSuma As New MySqlCommand(consultaSuma, conexion)
            comandoSuma.Parameters.AddWithValue("@IdVenta", idVenta)

            Dim nuevoTotal As Object = comandoSuma.ExecuteScalar()
            Dim totalNumerico As Integer = 0

            If nuevoTotal IsNot Nothing AndAlso Not IsDBNull(nuevoTotal) Then
                totalNumerico = CInt(nuevoTotal)
            End If

            Dim consultaUpdate As String = "UPDATE ventas SET Total = @Total WHERE IdV = @IdVenta"
            Dim comandoUpdate As New MySqlCommand(consultaUpdate, conexion)
            comandoUpdate.Parameters.AddWithValue("@Total", totalNumerico)
            comandoUpdate.Parameters.AddWithValue("@IdVenta", idVenta)

            comandoUpdate.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar el total de la venta: " & ex.Message, "Error de Suma")
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    Public Sub RegistrarItemVenta(ByVal idVenta As Integer, ByVal dgvDetalle As DataGridView)

        Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tablafinal")
        Dim comando As MySqlCommand

        Dim inputIdPr As String
        Dim inputCantidad As String
        Dim IdPr As Integer
        Dim Cantidad As Integer
        Dim PrecioU As Integer
        Dim PrecioT As Integer

        Try

            inputIdPr = InputBox("Ingrese ID del producto para el ticket:")
            If String.IsNullOrWhiteSpace(inputIdPr) Then Return
            IdPr = CInt(inputIdPr)

            inputCantidad = InputBox("Ingrese la cantidad vendida:")
            If String.IsNullOrWhiteSpace(inputCantidad) Then Return
            Cantidad = CInt(inputCantidad)

            If Cantidad <= 0 Then
                Throw New Exception("ERROR: La cantidad debe ser mayor a cero.")
            End If

            PrecioU = ObtenerPrecioProducto(IdPr, conexion)
            If PrecioU = -1 Then
                MessageBox.Show("ERROR: El ID de Producto no existe.", "Error de Validación")
                Return
            End If
            PrecioT = PrecioU * Cantidad

            conexion.Open()

            Dim consulta As String = "INSERT INTO ventasist (IdPr, IdVt, PrecioU, Cantidad, PrecioT) VALUES(@IdPr, @IdVt, @PrecioU, @Cantidad, @PrecioT)"
            comando = New MySqlCommand(consulta, conexion)

            comando.Parameters.AddWithValue("@IdPr", IdPr)
            comando.Parameters.AddWithValue("@IdVt", idVenta)
            comando.Parameters.AddWithValue("@PrecioU", PrecioU)
            comando.Parameters.AddWithValue("@Cantidad", Cantidad)
            comando.Parameters.AddWithValue("@PrecioT", PrecioT)

            comando.ExecuteNonQuery()

            MessageBox.Show("Ítem registrado en el ticket. Precio Total: $" & PrecioT.ToString())
            ActualizarTotalVenta(idVenta)
            CargarVentasDetalle(dgvDetalle)

        Catch ex As Exception
            MessageBox.Show("Error al registrar ítem: " & ex.Message, "Error")
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
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
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
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
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Function
    Public Sub ActualizarItemVenta(ByVal idVenta As Integer, ByVal dgvDetalle As DataGridView)

        Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tablafinal")

        Try
            Dim datosIniciales As (IdVs As Integer, IdPr As Integer, PrecioU As Integer) = ObtenerDetalleInicial(idVenta)
            Dim IdVs_Actual As Integer = datosIniciales.IdVs
            Dim PrecioU_Actual As Integer = datosIniciales.PrecioU

            ' PEDIR LA CANTIDAD
            Dim inputCantidad As String = InputBox("Venta #" & idVenta.ToString() & " (IdPr: " & datosIniciales.IdPr.ToString() & "). Ingrese la nueva cantidad:")
            If String.IsNullOrWhiteSpace(inputCantidad) Then Return

            Dim NuevaCantidad As Integer = CInt(inputCantidad)
            If NuevaCantidad <= 0 Then Throw New Exception("La cantidad debe ser positiva.")

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
End Class