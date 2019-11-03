Public Class Dos_num_en_forma_descendente
    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        Dim A, B As Integer
        A = TextBox1.Text
        B = TextBox2.Text


        If A < B Then

            Label2.Text = "Este es el orden de los numeros en forma descendente: " & B & "," & A & "."
        Else

            Label2.Text = "Este es el orden de los numeros en forma descendente: " & A & "," & B & "."
        End If

    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        TextBox1.Clear()
        TextBox2.Clear()


    End Sub

    Private Sub btncerrar_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Close()

    End Sub
End Class