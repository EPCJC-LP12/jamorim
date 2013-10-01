Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim gerador As New Random

        Dim num As Integer = gerador.Next(1, 10)

        TextBox1.Text = num

        If (num = 7) Then
            Label1.Text = "Ganhou!!"
        Else
            Label1.Text = "Pouca sorte, Tente outra vez!"
        End If



    End Sub
End Class
