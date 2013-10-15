Public Class Form2

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.classificacao' table. You can move, or remove it, as needed.
        Me.ClassificacaoTableAdapter.Fill(Me.Database1DataSet.classificacao)
        'TODO: This line of code loads data into the 'Database1DataSet.Corridas' table. You can move, or remove it, as needed.
        Me.CorridasTableAdapter.Fill(Me.Database1DataSet.Corridas)
        'TODO: This line of code loads data into the 'Database1DataSet.Pilotos' table. You can move, or remove it, as needed.
        Me.PilotosTableAdapter.Fill(Me.Database1DataSet.Pilotos)

    End Sub
End Class