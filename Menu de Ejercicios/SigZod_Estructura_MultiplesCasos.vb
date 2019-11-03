Public Class SigZod_Estructura_MultiplesCasos
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim n As Integer
        n = ListBox1.SelectedIndex
        Select Case n
            Case 0
                TextBox1.Text = "Usted pertenece a la categoria de Fuego."
            Case 1
                TextBox1.Text = "Usted pertenece a la categoria de Fuego."
            Case 2
                TextBox1.Text = "Usted pertenece a la categoria de Fuego."
            Case 3
                TextBox1.Text = "Usted pertenece a la categoria de Tierra."
            Case 4
                TextBox1.Text = "Usted pertenece a la categoria de Tierra."
            Case 5
                TextBox1.Text = "Usted pertenece a la categoria de Tierra."
            Case 6
                TextBox1.Text = "Usted pertenece a la categoria de Aire."
            Case 7
                TextBox1.Text = "Usted pertenece a la categoria de Aire."
            Case 8
                TextBox1.Text = "Usted pertenece a la categoria de Aire."
            Case 9
                TextBox1.Text = "Usted pertenece a la categoria de Agua."
            Case 10
                TextBox1.Text = "Usted pertenece a la categoria de Agua."
            Case 11
                TextBox1.Text = "Usted pertenece a la categoria de Agua."
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()

    End Sub
End Class