Public Class Form3

    Private Sub LivrosBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles LivrosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LivrosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Livros' table. You can move, or remove it, as needed.
        Me.LivrosTableAdapter.Fill(Me.Database1DataSet.Livros)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.LivrosTableAdapter.FillByNome(Me.Database1DataSet.Livros, Me.TextBox1.Text)
    End Sub
End Class