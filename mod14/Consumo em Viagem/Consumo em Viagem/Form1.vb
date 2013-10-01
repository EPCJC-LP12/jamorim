Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim num1 As Double
        Dim num2 As Double
        Dim num3 As Double
        Dim res1 As Double
        Dim res2 As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        num3 = TextBox3.Text
 

        res1 = num2 * num3 / 100
        TextBox4.Text = res1
        res2 = num1 * res1
        TextBox5.Text = res2


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
