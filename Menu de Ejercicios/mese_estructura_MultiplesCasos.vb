Public Class mese_estructura_MultiplesCasos
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n As Integer
        n = TextBox1.Text
        Select Case n
            Case 1
                TextBox2.Text = "El numero corresponde a Enero"
            Case 2
                TextBox2.Text = "El numero corresponde a Febrero"
            Case 3
                TextBox2.Text = "El numero corresponde a Marzo"
            Case 4
                TextBox2.Text = "El numero corresponde a Abril"
            Case 5
                TextBox2.Text = "El numero corresponde a Mayo"
            Case 6
                TextBox2.Text = "El numero corresponde a Junio"
            Case 7
                TextBox2.Text = "El numero corresponde a Julio"
            Case 8
                TextBox2.Text = "El numero corresponde a Agosto"
            Case 9
                TextBox2.Text = "El numero corresponde a Septiembre"
            Case 10
                TextBox2.Text = "El numero corresponde a Octubre"
            Case 11
                TextBox2.Text = "El numero corresponde a Noviembre"
            Case 12
                TextBox2.Text = "El numero corresponde a Diciembre"
            Case Else
                TextBox2.Text = "Dia Incorrecto"
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