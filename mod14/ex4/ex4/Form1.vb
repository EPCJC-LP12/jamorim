Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gerador As New Random
        Dim num1 As Integer
        Dim num2 As Integer
        Dim num3 As Integer
        num1 = gerador.Next(1, 10)
        num2 = gerador.Next(1, 10)
        num3 = gerador.Next(1, 10)

        TextBox1.Text = num1
        TextBox2.Text = num2
        TextBox3.Text = num3

        If (num1 = 7 Or num2 = 7 Or num3 = 7) Then
            Label2.Text = "Parabéns, Ganhou! "
        Else
            Label2.Text = "Tente de novo! "
        End If





    End Sub
End Class
