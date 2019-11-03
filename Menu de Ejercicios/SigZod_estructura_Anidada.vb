Public Class SigZod_estructura_Anidada
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim n As Integer
        n = ListBox1.SelectedIndex
        If n = 0 Then
            TextBox1.Text = "Usted pertenece a la categoria de Fuego."
        ElseIf n = 1 Then
            TextBox1.Text = "Usted pertenece a la categoria de Fuego."
        ElseIf n = 2 Then
            TextBox1.Text = "Usted pertenece a la categoria de Fuego."
        ElseIf n = 3 Then
            TextBox1.Text = "Usted pertenece a la categoria de Tierra."
        ElseIf n = 4 Then
            TextBox1.Text = "Usted pertenece a la categoria de Tierra."
        ElseIf n = 5 Then
            TextBox1.Text = "Usted pertenece a la categoria de Tierra."
        ElseIf n = 6 Then
            TextBox1.Text = "Usted pertenece a la categoria de Aire."
        ElseIf n = 7 Then
            TextBox1.Text = "Usted pertenece a la categoria de Aire."
        ElseIf n = 8 Then
            TextBox1.Text = "Usted pertenece a la categoria de Aire."
        ElseIf n = 9 Then
            TextBox1.Text = "Usted pertenece a la categoria de Agua."
        ElseIf n = 10 Then
            TextBox1.Text = "Usted pertenece a la categoria de Agua."
        ElseIf n = 11 Then
            TextBox1.Text = "Usted pertenece a la categoria de Agua."
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
End Class