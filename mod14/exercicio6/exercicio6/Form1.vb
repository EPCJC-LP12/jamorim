Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim palpite As Integer
        Dim gerador As New Random
        Dim num As Integer

        TextBox1.Text = 0



        If (CheckBox1.Checked = True And CheckBox2.Checked = False) Then
            num = gerador.Next(1, 101)

            While (palpite <> num)

                palpite = InputBox("Qual o seu palpite?")
                TextBox1.Text = TextBox1.Text + 1

                If (palpite < num) Then
                    MessageBox.Show("Palpite baixo!")
                ElseIf (palpite > num) Then
                    MessageBox.Show("Palpite alto!")
                Else
                    MessageBox.Show("Acertou!")
                End If



            End While

        ElseIf (CheckBox1.Checked = False And CheckBox2.Checked = True) Then
            num = gerador.Next(1, 1001)

            While (palpite <> num)

                palpite = InputBox("Qual o seu palpite?")
                TextBox1.Text = TextBox1.Text + 1

                If (palpite < num) Then
                    MessageBox.Show("Palpite baixo!")
                ElseIf (palpite > num) Then
                    MessageBox.Show("Palpite alto!")
                Else
                    MessageBox.Show("Acertou!")


                End If
            End While

        End If
    End Sub
End Class
