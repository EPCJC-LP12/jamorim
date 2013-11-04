Public Class Form2



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.DataTable1BindingSource.Fillbylivro(Me.Database1DataSet.Livros, Me.ComboBox1.Text)

    End Sub
End Class