Public Class calculo_del_Tiempo
    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        Dim V, d, T As Integer
        V = TextBox2.Text
        d = TextBox1.Text
        T = d * V
        TextBox3.Text = T
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Close()
    End Sub
End Class