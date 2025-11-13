Imports MySql.Data.MySqlClient

Module Conexion

    Dim conexion As New MySqlConnection("server=localhost;port=3306; user id=root;password=;database=tablafinal")
    Dim comando As MySqlCommand
    Dim adaptador As MySqlDataAdapter
    Dim tabla As New DataTable
    Public Sub CargarClientes()

        Dim conexion As New MySqlConnection("server=localhost;port=3306; user id=root;password=;database=tablafinal")
        Dim comando As MySqlCommand
        Dim adaptador As MySqlDataAdapter
        Dim tablaClientes As New DataTable

        Try
            conexion.Open()
            comando = New MySqlCommand("SELECT * FROM clientes", conexion)
            adaptador = New MySqlDataAdapter(comando)

            adaptador.Fill(tablaClientes)

            Form4.DataGridView1.DataSource = tablaClientes

        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
        Finally

            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub


    Public Sub CargarProductos()
        Dim conexion As New MySqlConnection("server=localhost;port=3306; user id=root;password=;database=tablafinal")
        Dim comando As MySqlCommand
        Dim adaptador As MySqlDataAdapter
        Dim tablaProductos As New DataTable

        Try
            conexion.Open()
            comando = New MySqlCommand("SELECT * FROM productos", conexion)
            adaptador = New MySqlDataAdapter(comando)

            adaptador.Fill(tablaProductos)

            Form5.DataGridView2.DataSource = tablaProductos

        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
        Finally
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub

    Public Sub CargarVentas()
        Try
            tabla.Clear()
            conexion.Open()
            comando = New MySqlCommand("SELECT * FROM ventas", conexion)
            adaptador = New MySqlDataAdapter(comando)
            adaptador.Fill(tabla)
            Form6.DataGridView3.DataSource = tabla
        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos" & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub
    Public Sub CargarVentasDetalle()
        Try
            tabla.Clear()
            conexion.Open()
            comando = New MySqlCommand("SELECT * FROM ventasist", conexion)
            adaptador = New MySqlDataAdapter(comando)
            adaptador.Fill(tabla)
            Form7.DataGridView6.DataSource = tabla
        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos" & ex.Message)
        Finally
            conexion.Close()
        End Try
    End Sub

End Module
