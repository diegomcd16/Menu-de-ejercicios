Public Class Area_de_una_circunferencia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r, Acir As Single
        Dim pi = 3.14
        r = TextBox1.Text
        Acir = pi * r ^ 2
        TextBox2.Text = Acir

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub
End Class