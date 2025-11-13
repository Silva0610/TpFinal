Public Class Form3
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Form6.Show()
        Me.Hide()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Hide()
    End Sub
End Class