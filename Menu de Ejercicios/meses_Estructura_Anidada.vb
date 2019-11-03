Public Class meses_Estructura_Anidada
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""







    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n As Integer
        n = TextBox1.Text
        If n = 1 Then
            TextBox2.Text = "El numero corresponde a Enero"
        ElseIf n = 2 Then
            TextBox2.Text = "El numero corresponde a Febrero"
        ElseIf n = 3 Then
            TextBox2.Text = "El numero corresponde a Marzo"
        ElseIf n = 4 Then
            TextBox2.Text = "El numero corresponde a Abril"
        ElseIf n = 5 Then
            TextBox2.Text = "El numero corresponde a Mayo"
        ElseIf n = 6 Then
            TextBox2.Text = "El numero corresponde a Junio"
        ElseIf n = 7 Then
            TextBox2.Text = "El numero corresponde a Julio"
        ElseIf n = 8 Then
            TextBox2.Text = "El numero corresponde a Agosto"
        ElseIf n = 9 Then
            TextBox2.Text = "El numero corresponde a Septiembre"
        ElseIf n = 10 Then
            TextBox2.Text = "El numero corresponde a Octubre"
        ElseIf n = 11 Then
            TextBox2.Text = "El numero corresponde a Noviembre"
        ElseIf n = 12 Then
            TextBox2.Text = "El numero corresponde a Diciembre"
        ElseIf n <= 0 Or n > 12 Then
            TextBox2.Text = "Dia Incorrecto"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        close
    End Sub
End Class