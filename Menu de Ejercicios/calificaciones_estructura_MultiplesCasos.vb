Public Class calificaciones_estructura_MultiplesCasos
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nota As Single
        nota = TextBox1.Text
        Select Case nota
            Case nota <= 20 And nota >= 19
                TextBox2.Text = "Muy satisfactorio"
            Case nota <= 18 And nota >= 17
                TextBox2.Text = "Satisfactorio"
            Case nota <= 16 And nota >= 15
                TextBox2.Text = "Muy Buena"
            Case nota <= 14 And nota >= 13
                TextBox2.Text = "Buena"
            Case nota <= 12 And nota >= 11
                TextBox2.Text = "Regular"
            Case nota <= 10 And nota >= 9
                TextBox2.Text = "Malo"
            Case 0 <= nota And 8 >= nota
                TextBox2.Text = "insuficiente"
            Case Else
                TextBox2.Text = "Por favor ingrese una nota de 0 a 20 "

        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class