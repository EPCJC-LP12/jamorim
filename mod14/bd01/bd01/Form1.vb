Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Pilotos' table. You can move, or remove it, as needed.
        Me.PilotosTableAdapter.Fill(Me.Database1DataSet.Pilotos)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Form2.Show()

    End Sub
End Class