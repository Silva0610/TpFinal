Imports MySql.Data.MySqlClient

Imports System.Data

Public Class Venta


    Private _IdV As Integer
    Private _IdCl As Integer
    Private _fecha As Date
    Private _Total As Integer
    Private _IdPr As Integer

    Public Property IdV As Integer
        Get
            Return _IdV
        End Get
        Set(value As Integer)
            If value <= 0 Then
                Throw New Exception("ERROR: ID DE VENTA INVÁLIDO O NEGATIVO")
            Else
                _IdV = value
            End If
        End Set
    End Property

    Public Property IdCl As Integer
        Get
            Return _IdCl
        End Get
        Set(value As Integer)
            If value <= 0 Or value > 200000 Then
                Throw New Exception("ERROR: ID de cliente inválido o fuera de rango.")
            Else
                _IdCl = value
            End If
        End Set
    End Property

    Public Property fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            If value.Date > Now.Date Then
                Throw New Exception("ERROR: La fecha de venta no puede ser futura.")
            Else
                _fecha = value
            End If
        End Set
    End Property

    Public Property IdPr As Integer
        Get
            Return _IdPr
        End Get
        Set(value As Integer)
            If value < 0 Then
                Throw New Exception("ERROR: ID DE PRODUCTO INVÁLIDO O NEGATIVO")
            Else
                _IdPr = value
            End If
        End Set
    End Property

    Public Property Total As Integer
        Get
            Return _Total
        End Get
        Set(value As Integer)
            If value < 0 Then
                Throw New Exception("ERROR: El total de la venta no puede ser negativo.")
            Else
                _Total = value
            End If
        End Set
    End Property
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
    Public Function ExisteRegistro(tabla As String, columnaId As String, id As Integer, conexion As MySqlConnection) As Boolean
        Dim estuvoAbierta As Boolean = (conexion.State = ConnectionState.Open)
        If Not estuvoAbierta Then conexion.Open()

        Dim consulta As String = $"SELECT COUNT(*) FROM {tabla} WHERE {columnaId} = @Id"
        Dim comando As New MySqlCommand(consulta, conexion)
        comando.Parameters.AddWithValue("@Id", id)

        Dim count As Integer = CInt(comando.ExecuteScalar())

        If Not estuvoAbierta AndAlso conexion.State = ConnectionState.Open Then conexion.Close()

        Return count > 0
    End Function

    Public Function RegistrarVenta() As Integer

        Dim nuevaVenta As New Venta()
        Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tablafinal")
        Dim comando As MySqlCommand
        Dim inputIdCl As String
        Dim inputIdPr As String

        Dim inputFechaString As String

        Dim IdV_Generado As Integer = 0
        Dim PrecioUnitario As Integer

        Try
            conexion.Open()

            ' 1. CAPTURAR Y VALIDAR CLIENTE
            inputIdCl = InputBox("Ingrese el ID del Cliente (IdCl):")
            If String.IsNullOrWhiteSpace(inputIdCl) Then Return 0
            If Not ExisteRegistro("clientes", "IdCl", CInt(inputIdCl), conexion) Then
                MessageBox.Show("ERROR: El ID de Cliente no existe.") : Return 0
            End If
            nuevaVenta.IdCl = CInt(inputIdCl)

            ' 2. CAPTURAR Y VALIDAR PRODUCTO
            inputIdPr = InputBox("Ingrese el ID del Producto (IdPr) inicial:")
            If String.IsNullOrWhiteSpace(inputIdPr) Then Return 0
            PrecioUnitario = ObtenerPrecioProducto(CInt(inputIdPr), conexion)
            If PrecioUnitario = -1 Then
                MessageBox.Show("ERROR: El ID de Producto no existe o no tiene precio.") : Return 0
            End If
            nuevaVenta.IdPr = CInt(inputIdPr)
            nuevaVenta.Total = PrecioUnitario

            ' 3. CAPTURA Y VALIDACIÓN DE FECHA (CORREGIDA)
            inputFechaString = InputBox("Ingrese la fecha de venta (AAAA-MM-DD o deja en blanco para hoy):")

            If String.IsNullOrWhiteSpace(inputFechaString) Then

                nuevaVenta.fecha = Now.Date
            Else

                If IsDate(inputFechaString) Then
                    nuevaVenta.fecha = CDate(inputFechaString)
                Else

                    Throw New Exception("ERROR: Formato de fecha inválido. Use AAAA-MM-DD.")
                End If
            End If



            Dim consultaVenta As String = "INSERT INTO ventas (IdCl, IdPr, Fecha, Total) VALUES(@IdCl, @IdPr, @Fecha, @Total)"
            comando = New MySqlCommand(consultaVenta, conexion)

            comando.Parameters.AddWithValue("@IdCl", nuevaVenta.IdCl)
            comando.Parameters.AddWithValue("@IdPr", nuevaVenta.IdPr)
            ' Usar nuevaVenta.fecha, que ya fue validada
            comando.Parameters.AddWithValue("@Fecha", nuevaVenta.fecha)
            comando.Parameters.AddWithValue("@Total", nuevaVenta.Total)
            comando.ExecuteNonQuery()

            comando = New MySqlCommand("SELECT LAST_INSERT_ID();", conexion)
            IdV_Generado = CInt(comando.ExecuteScalar())



            Dim consultaDetalle As String = "INSERT INTO ventasist (IdPr, IdVt, PrecioU, Cantidad, PrecioT) VALUES(@IdPr, @IdVt, @PrecioU, @Cantidad, @PrecioT)"
            comando = New MySqlCommand(consultaDetalle, conexion)
            comando.Parameters.AddWithValue("@IdPr", nuevaVenta.IdPr)
            comando.Parameters.AddWithValue("@IdVt", IdV_Generado)
            comando.Parameters.AddWithValue("@PrecioU", PrecioUnitario)
            comando.Parameters.AddWithValue("@Cantidad", 1)
            comando.Parameters.AddWithValue("@PrecioT", PrecioUnitario)

            comando.ExecuteNonQuery()

            MessageBox.Show("Venta #" & IdV_Generado.ToString() & " iniciada. Total inicial: $" & PrecioUnitario.ToString())
            CargarVentas()
            Return IdV_Generado

        Catch ex As Exception
            MessageBox.Show("Error al registrar venta (Cabecera y Detalle): " & ex.Message, "Error")
            Return 0
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try
    End Function

End Class