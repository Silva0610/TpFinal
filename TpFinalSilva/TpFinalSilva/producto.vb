Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class producto
    Private _Nom As String
    Private _IdPr As Integer
    Private _Precio As Integer
    Private _Cat As String


    Public Property Nombre As String
        Get
            Return _Nom
        End Get
        Set(value As String)
            If IsNumeric(value) Then
                Throw New Exception("ERROR: EL NOMBRE NO PUEDE SER NUMERICO")
            Else
                _Nom = value
            End If
        End Set
    End Property

    Public Property IdPr As Integer
        Get
            Return _IdPr
        End Get
        Set(value As Integer)
            If value <= 0 Then
                Throw New Exception("ERROR: NO EXISTE UN PRODUCTO CON ID NEGATIVO O CERO")
            Else
                _IdPr = value
            End If
        End Set
    End Property

    Public Property Precio As Integer
        Get
            Return _Precio
        End Get
        Set(value As Integer)
            If value < 50 Then
                Throw New Exception("ERROR: PRECIO MUY BAJO (Mínimo $50)")
            ElseIf value > 9999 Then
                Throw New Exception("ERROR: PRECIO MUY ALTO (Máximo $9999)")
            Else
                _Precio = value
            End If
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _Cat
        End Get
        Set(value As String)
            If IsNumeric(value) Then
                Throw New Exception("ERROR: CATEGORIA INEXISTENTE (No puede ser numérica)")
            Else
                _Cat = value
            End If
        End Set
    End Property


    Public Sub Altapr()

        Dim nuevoProducto As New producto()
        Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tablafinal")
        Dim comando As MySqlCommand
        Dim inputNombre As String
        Dim inputIdPr As String
        Dim inputPrecio As String
        Dim inputCategoria As String
        Try
            inputNombre = InputBox("Ingrese nombre del producto")
            If String.IsNullOrWhiteSpace(inputNombre) Then Return
            nuevoProducto.Nombre = inputNombre
            inputIdPr = InputBox("Ingrese ID del producto")
            If String.IsNullOrWhiteSpace(inputIdPr) Then Return
            nuevoProducto.IdPr = CInt(inputIdPr)
            inputPrecio = InputBox("Ingrese precio")
            If String.IsNullOrWhiteSpace(inputPrecio) Then Return
            nuevoProducto.Precio = CInt(inputPrecio)
            inputCategoria = InputBox("Ingrese categoría")
            If String.IsNullOrWhiteSpace(inputCategoria) Then Return
            nuevoProducto.Categoria = inputCategoria
            conexion.Open()
            Dim consulta As String = "INSERT INTO productos (Nombre, IdPr, Precio, Categoria) VALUES(@Nombre, @IdPr, @Precio, @Categoria)"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@Nombre", nuevoProducto.Nombre)
            comando.Parameters.AddWithValue("@IdPr", nuevoProducto.IdPr)
            comando.Parameters.AddWithValue("@Precio", nuevoProducto.Precio)
            comando.Parameters.AddWithValue("@Categoria", nuevoProducto.Categoria)
            comando.ExecuteNonQuery()
            MessageBox.Show("Producto agregado.")
            CargarProductos()

        Catch ex As Exception

            MessageBox.Show("Error al insertar: " & ex.Message, "Error de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub
    Public Sub baja(IdPr As Integer)
        Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tablafinal")
        Dim comando As MySqlCommand

        Dim inputIdPr As String = InputBox("Ingrese el Id a eliminar")

        If String.IsNullOrWhiteSpace(inputIdPr) Then
            Return
        End If

        Try
            conexion.Open()

            IdPr = CInt(inputIdPr)

            Dim consultaExistencia As String = "SELECT COUNT(*) FROM productos WHERE IdPr = @IdPr"
            Dim comandoExistencia As New MySqlCommand(consultaExistencia, conexion)
            comandoExistencia.Parameters.AddWithValue("@IdPr", IdPr)

            Dim count As Integer = CInt(comandoExistencia.ExecuteScalar())

            If count = 0 Then
                MessageBox.Show("ERROR: El ID de producto ingresado no existe.", "ID Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim consultaEliminar As String = "DELETE FROM productos WHERE IdPr = @IdPr"
            comando = New MySqlCommand(consultaEliminar, conexion)
            comando.Parameters.AddWithValue("@IdPr", IdPr)

            comando.ExecuteNonQuery()

            MessageBox.Show("Producto eliminado.")

            CargarProductos()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    Public Sub modif(Nombre As String, IdPr As Integer, Precio As Integer, categoria As String)
        Dim conexion As New MySqlConnection("server=localhost;port=3306; user id=root;password=;database=tablafinal")
        Dim comando As MySqlCommand
        Try
            conexion.Open()
            IdPr = Form5.DataGridView2.CurrentRow.Cells("IdPr").Value

            Dim consulta As String = "UPDATE productos SET Nombre=@Nombre, Precio=@Precio, Categoria=@Categoria WHERE IdPr=@IdPr"

            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@Nombre", Form5.DataGridView2.CurrentRow.Cells("Nombre").Value)
            comando.Parameters.AddWithValue("@IdPr", IdPr)
            comando.Parameters.AddWithValue("@Precio", Form5.DataGridView2.CurrentRow.Cells("Precio").Value)
            comando.Parameters.AddWithValue("@Categoria", Form5.DataGridView2.CurrentRow.Cells("Categoria").Value)

            comando.ExecuteNonQuery()

            MessageBox.Show("Producto actualizado.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conexion.Close()
        End Try

    End Sub
    Public Sub buscarpr()
        Dim conexion As New MySqlConnection("server=localhost;port=3306; user id=root;password=;database=tablafinal")
        Dim filtro As String = Form5.TxtPr.Text.Trim()

        Try
            conexion.Open()

            Dim consulta As String
            Dim comando As New MySqlCommand()
            comando.Connection = conexion

            If IsNumeric(filtro) AndAlso filtro <> "" Then


                consulta = "SELECT * FROM productos WHERE IdPr = @filtroNumerico " &
                           "OR Precio = @filtroNumerico OR Nombre LIKE @filtroTexto OR Categoria LIKE @filtroTexto"

                comando.CommandText = consulta

                comando.Parameters.AddWithValue("@filtroTexto", "%" & filtro & "%")

                comando.Parameters.AddWithValue("@filtroNumerico", CDec(filtro))

            ElseIf filtro <> "" Then





                consulta = "SELECT * FROM productos WHERE Nombre LIKE @filtroTexto OR IdPr LIKE @filtroTexto OR Precio LIKE @filtroTexto OR Categoria LIKE @filtroTexto"

                comando.CommandText = consulta

                comando.Parameters.AddWithValue("@filtroTexto", "%" & filtro & "%")

            Else

                consulta = "SELECT * FROM productos"
                comando.CommandText = consulta
            End If

            Dim adaptador As New MySqlDataAdapter(comando)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)


            If tabla.Rows.Count > 0 Then
                Form5.DataGridView2.DataSource = tabla
            Else
                Form5.DataGridView2.DataSource = Nothing
                MessageBox.Show("No se encontraron productos que coincidan con el filtro.", "Búsqueda Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Conexion.Close()
        End Try
    End Sub
End Class
