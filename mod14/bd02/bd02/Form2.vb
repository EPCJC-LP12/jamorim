Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.avaliacoes' table. You can move, or remove it, as needed.
        Me.AvaliacoesTableAdapter.Fill(Me.Database1DataSet.avaliacoes)
        'TODO: This line of code loads data into the 'Database1DataSet.Restaurantes' table. You can move, or remove it, as needed.
        Me.RestaurantesTableAdapter.Fill(Me.Database1DataSet.Restaurantes)

    End Sub
End Class