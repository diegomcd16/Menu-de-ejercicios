Public Class elMayor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B As Integer
        A = TextBox1.Text
        B = TextBox2.Text

        If A < B Then

            Label2.Text = "El numero mayor es: " & B & "."
        Else

            Label2.Text = "El numero mayor es: " & A & "."
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub

    Private Sub elMayor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class