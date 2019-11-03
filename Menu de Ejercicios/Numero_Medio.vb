Public Class Numero_Medio
    Private Sub Numero_Medio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim A, B, C As Integer
        A = InputBox("ingrese el primer numero")
        B = InputBox("ingrese el segundo numero")
        C = InputBox("ingrese el tercer numero")
        If A > B Or B < C Then
            TextBox1.Text = B & " es el numero medio."
        ElseIf B > A Or A < C Then
            TextBox1.Text = A & " es el numero medio."
        Else
            TextBox1.Text = C & " es el numero medio."
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
End Class