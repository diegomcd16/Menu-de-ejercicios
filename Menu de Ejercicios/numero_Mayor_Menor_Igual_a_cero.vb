Public Class numero_Mayor_Menor_Igual_a_cero
    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        Dim A As Integer
        A = TextBox1.Text
        If A > 0 Then
            Label2.Text = "El numero " & A & " es mayor a cero."
        ElseIf A < 0 Then

            Label2.Text = "El numero " & A & " es menor a cero."
        Else
            Label2.Text = "El numero " & A & " es igual a cero."
        End If
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        TextBox1.Clear()

    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Close()

    End Sub
End Class