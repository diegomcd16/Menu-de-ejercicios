Public Class Perimetro_de_un_Terreno
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B, C, Atri, Arec, AreaT As Single
        A = TextBox1.Text
        B = TextBox2.Text
        C = TextBox3.Text
        Atri = (B * (A - C)) / 2
        Arec = B * C
        AreaT = Atri + Arec
        TextBox4.Text = AreaT
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub
End Class