Public Class Menu_estructura_multiplescasos
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim n, Num1, Num2, rest, sum, mult, div, Pot1, Pot2 As Single
        Num1 = TextBox1.Text
        Num2 = TextBox2.Text
        n = ListBox1.SelectedIndex
        Select Case n
            Case 0
                Select Case Num2
                    Case 0
                        MsgBox("El segundo numero debe ser distinto a 0")
                    Case Else
                        sum = Num1 + Num2
                        TextBox3.Text = "La suma entre los dos numeros es: " & sum
                End Select
            Case 1
                Select Case Num2
                    Case 0
                        MsgBox("El segundo numero debe ser distinto a 0")
                    Case Else
                        rest = Num1 - Num2
                        TextBox3.Text = "La resta entre los dos numeros es: " & rest
                End Select
            Case 2
                Select Case Num2
                    Case 0
                        MsgBox("El segundo numero debe ser distinto a 0")
                    Case Else
                        mult = Num1 * Num2
                        TextBox3.Text = "La multiplicacion entre los dos numeros es: " & mult
                End Select
            Case 3
                Select Case Num2
                    Case 0
                        MsgBox("El segundo numero debe ser distinto a 0")
                    Case Else
                        div = Num1 / Num2
                        TextBox3.Text = "La division entre los dos numeros es: " & div
                End Select
            Case 4
                Select Case Num2
                    Case 0
                        MsgBox("El segundo numero debe ser distinto a 0")
                    Case Else
                        Pot1 = Num1 ^ 2
                        Pot2 = Num2 ^ 2
                        TextBox3.Text = "La Potenciacion al cuadrado de los dos numeros es: " & Pot1 & "," & Pot2 & "."
                End Select
        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
End Class