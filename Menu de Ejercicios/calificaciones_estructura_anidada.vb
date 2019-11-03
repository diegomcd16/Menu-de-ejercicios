Public Class calificaciones_estructura_anidada
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nota As Single
        nota = TextBox1.Text
        If nota <= 20 And nota >= 19 Then
            TextBox2.Text = "Muy satisfactorio"
        ElseIf nota <= 18 And nota >= 17 Then
            TextBox2.Text = "Satisfactorio"
        ElseIf nota <= 16 And nota >= 15 Then
            TextBox2.Text = "Muy Buena"
        ElseIf nota <= 14 And nota >= 13 Then
            TextBox2.Text = "Buena"
        ElseIf nota <= 12 And nota >= 11 Then
            TextBox2.Text = "Regular"
        ElseIf nota <= 10 And nota >= 9 Then
            TextBox2.Text = "Malo"
        ElseIf 0 <= nota And 8 >= nota Then
            TextBox2.Text = "insuficiente"
        ElseIf nota < 0 Or nota > 20 Then
            TextBox2.Text = "Por favor ingrese una nota de 0 a 20 "
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class