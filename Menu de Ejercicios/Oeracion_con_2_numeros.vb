Public Class Oeracion_con_2_numeros
    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        Dim A, B, mult, rest, sum As Single
        A = TextBox1.Text
        B = TextBox2.Text
        If A = B Then
            mult = A * B
            Label2.Text = "los numeros son iguales y este es el resultado de su producto: " & mult & "."
        ElseIf A > B Then
            rest = A - B
            Label2.Text = "El primer numero  " & A & " resulto ser mayor al segundo numero " & B & " y este es el resultado de su resta: " & rest & "."
        Else
            sum = A + B
            Label2.Text = "El primer numero  " & A & " resulto ser menor al segundo numero " & B & " y este es el resultado de su suma: " & sum & "."
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