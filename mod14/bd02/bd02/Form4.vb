Public Class Form4



    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.DataTable1TableAdapter.Fillbyclassi(Me.Database1DataSet.DataTable1, TextBox1.Text)
    End Sub
End Class