﻿Public Class Algoritmo_de_dos_numeros
    Private Sub Algoritmo_de_dos_numeros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, suma, mult As Integer


        num1 = TextBox1.Text
        num2 = TextBox2.Text
        suma = num1 + num2
        mult = num1 * num2
        suma = TextBox3.Text
        mult = TextBox4.Text




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class