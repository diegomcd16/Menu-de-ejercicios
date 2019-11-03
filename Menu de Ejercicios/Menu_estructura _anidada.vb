Public Class Menu_estructura__anidada
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim n, Num1, Num2, rest, sum, mult, div, Pot1, Pot2 As Single
        Num1 = TextBox1.Text
        Num2 = TextBox2.Text
        n = ListBox1.SelectedIndex
        If n = 0 Then
            If Num2 = 0 Then
                MsgBox("El segundo numero debe ser distinto a 0")
            Else
                sum = Num1 + Num2
                TextBox3.Text = "La suma entre los dos numeros es: " & sum
            End If
        ElseIf n = 1 Then
            If Num2 = 0 Then
                MsgBox("El segundo numero debe ser distinto a 0")
            Else
                rest = Num1 - Num2
                TextBox3.Text = "La resta entre los dos numeros es: " & rest

            End If
        ElseIf n = 2 Then
            If Num2 = 0 Then
                MsgBox("El segundo numero debe ser distinto a 0")
            Else
                mult = Num1 * Num2
                TextBox3.Text = "La multiplicacion entre los dos numeros es: " & mult

            End If
        ElseIf n = 3 Then
            If Num2 = 0 Then
                MsgBox("El segundo numero debe ser distinto a 0")
            Else
                div = Num1 / Num2
                TextBox3.Text = "La division entre los dos numeros es: " & div

            End If
        ElseIf n = 4 Then
            If Num2 = 0 Then
                MsgBox("El segundo numero debe ser distinto a 0")
            Else
                Pot1 = Num1 ^ 2
                Pot2 = Num2 ^ 2
                TextBox3.Text = "La Potenciacion al cuadrado de los dos numeros es: " & Pot1 & "," & Pot2 & "."

            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
End Class