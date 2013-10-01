Public Class Form1

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim res1 As Double
        Label1.Text = "+"

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res1 = num1 + num2


        TextBox3.Text = res1


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim res1 As Double
        Label1.Text = "-"

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res1 = num1 - num2


        TextBox3.Text = res1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim res1 As Double
        Label1.Text = "x"

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res1 = num1 * num2


        TextBox3.Text = res1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim res1 As Double
        Label1.Text = "/"

        num1 = TextBox1.Text
        num2 = TextBox2.Text
        res1 = num1 / num2


        TextBox3.Text = res1
    End Sub
End Class
