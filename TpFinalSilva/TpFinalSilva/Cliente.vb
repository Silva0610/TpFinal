Imports MySql.Data.MySqlClient
Public Class Cliente
    Private _Cl As String
    Private _Id As Integer
    Private _Correo As String
    Private _tel As Integer

    Public Property Cliente As String
        Get
            Return _Cl
        End Get
        Set(value As String)
            If IsNumeric(value) Then
                Throw New Exception("ERROR DE VALIDACIÓN: Un nombre no puede contener números.")
            Else
                _Cl = value
            End If
        End Set
    End Property

    Public Property IdCl As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)

            If value <= 0 Or value > 200000 Then
                Throw New Exception("ERROR: ID de cliente inválido o fuera de rango.")
            Else
                _Id = value
            End If
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            If String.IsNullOrWhiteSpace(value) Then
                Throw New Exception("ERROR: Ingrese un correo electrónico.")
            Else
                _Correo = value
            End If
        End Set
    End Property

    Public Property telefono As Integer
        Get
            Return _tel
        End Get
        Set(value As Integer)

            If value <= 0 Then
                Throw New Exception("ERROR: Ingrese un teléfono válido.")
            Else
                _tel = value
            End If
        End Set
    End Property


    Public Sub altas()
        Dim nuevoCliente As New Cliente()
        Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tablafinal")
        Dim comando As MySqlCommand

        Dim inputNombre As String
        Dim inputIdCl As String
        Dim inputCorreo As String
        Dim inputTelefono As String

        Try

            inputNombre = InputBox("ingrese nombre")
            If String.IsNullOrWhiteSpace(inputNombre) Then Return
            nuevoCliente.Cliente = inputNombre

            inputIdCl = InputBox("ingrese id")
            If String.IsNullOrWhiteSpace(inputIdCl) Then Return
            nuevoCliente.IdCl = CInt(inputIdCl)

            inputCorreo = InputBox("ingrese correo electronico")
            If String.IsNullOrWhiteSpace(inputCorreo) Then Return
            nuevoCliente.Correo = inputCorreo

            inputTelefono = InputBox("ingrese Telefono")
            If String.IsNullOrWhiteSpace(inputTelefono) Then Return
            nuevoCliente.telefono = CInt(inputTelefono)

            conexion.Open()
            Dim consulta As String = "INSERT INTO clientes (Cliente, IdCl, Correo, Telefono) VALUES(@Cliente, @IdCl, @Correo, @Telefono)"
            comando = New MySqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@Cliente", nuevoCliente.Cliente)
            comando.Parameters.AddWithValue("@IdCl", nuevoCliente.IdCl)
            comando.Parameters.AddWithValue("@Correo", nuevoCliente.Correo)
            comando.Parameters.AddWithValue("@Telefono", nuevoCliente.telefono)
            comando.ExecuteNonQuery()

            MessageBox.Show("cliente agregado.")
            CargarClientes()

        Catch ex As Exception
            MessageBox.Show("Error al insertar: " & ex.Message, "Error de Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub
    Public Sub baja(IdCl As Integer)
        Dim conexion As New MySqlConnection("server=localhost;port=3306;user id=root;password=;database=tablafinal")
        Dim comando As MySqlCommand

        Dim inputIdCl As String = InputBox("Ingrese el Id a eliminar")

        If String.IsNullOrWhiteSpace(inputIdCl) Then
            Return
        End If

        Try
            conexion.Open()
            IdCl = CInt(inputIdCl)
            Dim consultaExistencia As String = "SELECT COUNT(*) FROM clientes WHERE IdCl = @IdCl"
            Dim comandoExistencia As New MySqlCommand(consultaExistencia, conexion)
            comandoExistencia.Parameters.AddWithValue("@IdCl", IdCl)
            Dim count As Integer = CInt(comandoExistencia.ExecuteScalar())
            If count = 0 Then

                MessageBox.Show("ERROR: El ID de cliente ingresado no existe.", "ID Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim consultaEliminar As String = "DELETE  FROM clientes WHERE IdCl = @IdCl"
            comando = New MySqlCommand(consultaEliminar, conexion)
            comando.Parameters.AddWithValue("@IdCl", IdCl)

            comando.ExecuteNonQuery()

            MessageBox.Show("cliente eliminado.")

            CargarClientes()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub
    Public Sub modif(Cliente As String, IdCl As String, Correo As String, Telefono As Integer)
        Dim conexion As New MySqlConnection("server=localhost;port=3306; user id=root;password=;database=tablafinal")
        Dim comando As MySqlCommand
        Try
            Conexion.Open()
            IdCl = Form2.DataGridView1.CurrentRow.Cells("IdCl").Value

            Dim consulta As String = "UPDATE clientes SET Cliente=@Cliente, Correo=@Correo, Telefono=@Telefono WHERE IdCl=@IdCl"

            comando = New MySqlCommand(consulta, Conexion)
            comando.Parameters.AddWithValue("@Cliente", Form2.DataGridView1.CurrentRow.Cells("Cliente").Value)
            comando.Parameters.AddWithValue("@IdCl", IdCl)
            comando.Parameters.AddWithValue("@Correo", Form2.DataGridView1.CurrentRow.Cells("Correo").Value)
            comando.Parameters.AddWithValue("@Telefono", Form2.DataGridView1.CurrentRow.Cells("Telefono").Value)

            comando.ExecuteNonQuery()

            MessageBox.Show("Cliente actualizado.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
    Public Sub buscar()
        Dim conexion As New MySqlConnection("server=localhost;port=3306; user id=root;password=;database=tablafinal")
        Dim filtro As String = Form2.TxtBuscar.Text.Trim()

        Try
            conexion.Open()

            Dim consulta As String
            Dim comando As New MySqlCommand()
            comando.Connection = conexion


            If IsNumeric(filtro) AndAlso filtro <> "" Then


                consulta = "SELECT * FROM clientes WHERE IdCl = @filtroNumerico " &
                       "OR Cliente LIKE @filtroTexto OR Correo LIKE @filtroTexto OR Telefono = @filtroNumerico"

                comando.CommandText = consulta
                comando.Parameters.AddWithValue("@filtroTexto", "%" & filtro & "%")

                comando.Parameters.AddWithValue("@filtroNumerico", CInt(filtro))
            ElseIf filtro <> "" Then
                consulta = "SELECT * FROM clientes WHERE Cliente LIKE @filtroTexto OR IdCl LIKE @filtroTexto OR Correo LIKE @filtroTexto OR Telefono LIKE @filtroTexto"
                comando.CommandText = consulta
                comando.Parameters.AddWithValue("@filtroTexto", "%" & filtro & "%")
            Else

                consulta = "SELECT * FROM clientes"
                comando.CommandText = consulta
            End If

            Dim adaptador As New MySqlDataAdapter(comando)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)

            If tabla.Rows.Count > 0 Then
                Form2.DataGridView1.DataSource = tabla
            Else
                Form2.DataGridView1.DataSource = Nothing
                MessageBox.Show("No se encontraron clientes que coincidan con el filtro.", "Búsqueda Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
End Class
