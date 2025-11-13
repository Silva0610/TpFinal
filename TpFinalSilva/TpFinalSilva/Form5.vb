Public Class Form5
    Public Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Public Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles BtnAltapr.Click
        Dim pr As New producto
        pr.Altapr()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnbajapr.Click
        Dim pr As New producto
        If pr.IdPr = -1 Then
            MessageBox.Show("Seleccione un Producto para eliminar.")
            Return
        End If

        pr.baja(pr.IdPr)
    End Sub

    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim pr As New producto
        pr.modif(pr.Nombre, pr.IdPr, pr.Precio, pr.Categoria)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BuscarPr.Click
        Dim pr As New producto
        pr.buscarpr()
    End Sub
End Class