Public Class Form1

    Private Sub RestaurantesBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles RestaurantesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RestaurantesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Restaurantes' table. You can move, or remove it, as needed.
        Me.RestaurantesTableAdapter.Fill(Me.Database1DataSet.Restaurantes)

    End Sub
End Class
