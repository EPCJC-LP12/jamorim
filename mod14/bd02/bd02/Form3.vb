Public Class Form3

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.RestaurantesTableAdapter.FillByContacto(Me.Database1DataSet.Restaurantes, TextBox1.Text)

    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Restaurantes' table. You can move, or remove it, as needed.
        Me.RestaurantesTableAdapter.Fill(Me.Database1DataSet.Restaurantes)

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Me.RestaurantesTableAdapter.FillByContacto(Me.Database1DataSet.Restaurantes, TextBox1.Text)
    End Sub
End Class