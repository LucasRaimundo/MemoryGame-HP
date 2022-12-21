Public Class facil
    Dim clicou As Boolean = False
    Dim imagem1, imagem2 As String

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If clicou = False Then
            clicou = True
            PictureBox1.Image = My.Resources.memoria5
            imagem1 = "memoria5"
            PictureBox1.Enabled = False




        Else
            imagem2 = "memoria5"
            clicou = False
            PictureBox1.Image = My.Resources.memoria5
            verificar()


        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If clicou = False Then
            clicou = True
            PictureBox2.Image = My.Resources.memoria1
            imagem1 = "memoria1"
            PictureBox2.Enabled = False

        Else
            imagem2 = "memoria1"
            clicou = False
            PictureBox2.Image = My.Resources.memoria1
            verificar()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If clicou = False Then
            clicou = True
            PictureBox3.Image = My.Resources.memoria2
            imagem1 = "memoria2"
            PictureBox3.Enabled = False
        Else
            imagem2 = "memoria2"
            clicou = False
            PictureBox3.Image = My.Resources.memoria2
            verificar()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If clicou = False Then
            clicou = True
            PictureBox4.Image = My.Resources.memoria8
            imagem1 = "memoria8"
            PictureBox4.Enabled = False
        Else
            imagem2 = "memoria8"
            clicou = False
            PictureBox4.Image = My.Resources.memoria8
            verificar()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If clicou = False Then
            clicou = True
            PictureBox5.Image = My.Resources.memoria_3
            imagem1 = "memoria3"
            PictureBox5.Enabled = False
        Else
            imagem2 = "memoria3"
            clicou = False
            PictureBox5.Image = My.Resources.memoria_3
            verificar()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If clicou = False Then
            clicou = True
            PictureBox6.Image = My.Resources.memoria7
            imagem1 = "memoria7"
            PictureBox6.Enabled = False
        Else
            imagem2 = "memoria7"
            clicou = False
            PictureBox6.Image = My.Resources.memoria7
            verificar()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If clicou = False Then
            clicou = True
            PictureBox7.Image = My.Resources.memoria4
            imagem1 = "memoria4"
            PictureBox7.Enabled = False
        Else
            imagem2 = "memoria4"
            clicou = False
            PictureBox7.Image = My.Resources.memoria4
            verificar()
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If clicou = False Then
            clicou = True
            PictureBox8.Image = My.Resources.memoria6
            imagem1 = "memoria6"
            PictureBox8.Enabled = False
        Else
            imagem2 = "memoria6"
            clicou = False
            PictureBox8.Image = My.Resources.memoria6
            verificar()
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If clicou = False Then
            clicou = True
            PictureBox9.Image = My.Resources.memoria2
            imagem1 = "memoria2"
            PictureBox9.Enabled = False
        Else
            imagem2 = "memoria2"
            clicou = False
            PictureBox9.Image = My.Resources.memoria2
            verificar()
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If clicou = False Then
            clicou = True
            PictureBox10.Image = My.Resources.memoria8
            imagem1 = "memoria8"
            PictureBox10.Enabled = False
        Else
            imagem2 = "memoria8"
            clicou = False
            PictureBox10.Image = My.Resources.memoria8
            verificar()
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If clicou = False Then
            clicou = True
            PictureBox11.Image = My.Resources.memoria7
            imagem1 = "memoria7"
            PictureBox11.Enabled = False
        Else
            imagem2 = "memoria7"
            clicou = False
            PictureBox11.Image = My.Resources.memoria7
            verificar()
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If clicou = False Then
            clicou = True
            PictureBox12.Image = My.Resources.memoria5
            imagem1 = "memoria5"
            PictureBox12.Enabled = False
        Else
            imagem2 = "memoria5"
            clicou = False
            PictureBox12.Image = My.Resources.memoria5
            verificar()
        End If

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        If clicou = False Then
            clicou = True
            PictureBox13.Image = My.Resources.memoria1
            imagem1 = "memoria1"
            PictureBox13.Enabled = False
        Else
            imagem2 = "memoria1"
            clicou = False
            PictureBox13.Image = My.Resources.memoria1
            verificar()
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If clicou = False Then
            clicou = True
            PictureBox14.Image = My.Resources.memoria6
            imagem1 = "memoria6"
            PictureBox14.Enabled = False
        Else
            imagem2 = "memoria6"
            clicou = False
            PictureBox14.Image = My.Resources.memoria6
            verificar()
        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        If clicou = False Then
            clicou = True
            PictureBox15.Image = My.Resources.memoria_3
            imagem1 = "memoria3"
            PictureBox15.Enabled = False
        Else
            imagem2 = "memoria3"
            clicou = False
            PictureBox15.Image = My.Resources.memoria_3
            verificar()
        End If
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If clicou = False Then
            clicou = True
            PictureBox16.Image = My.Resources.memoria4
            imagem1 = "memoria4"
            PictureBox16.Enabled = False
        Else
            imagem2 = "memoria4"
            clicou = False
            PictureBox16.Image = My.Resources.memoria4
            verificar()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inicio.Show()
        Me.Close()

    End Sub

    Sub verificar()
        If imagem1 = imagem2 Then

            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
            PictureBox9.Enabled = True
            PictureBox10.Enabled = True
            PictureBox11.Enabled = True
            PictureBox12.Enabled = True
            PictureBox13.Enabled = True
            PictureBox14.Enabled = True
            PictureBox15.Enabled = True
            PictureBox16.Enabled = True

            MsgBox("Parabéns, você acertou", MessageBoxIcon.Information)

            If imagem1 = "memoria1" Then
                PictureBox2.Visible = False
                PictureBox13.Visible = False
            ElseIf imagem1 = "memoria2" Then
                PictureBox3.Visible = False
                PictureBox9.Visible = False
            ElseIf imagem1 = "memoria3" Then
                PictureBox5.Visible = False
                PictureBox15.Visible = False
            ElseIf imagem1 = "memoria4" Then
                PictureBox7.Visible = False
                PictureBox16.Visible = False
            ElseIf imagem1 = "memoria5" Then
                PictureBox1.Visible = False
                PictureBox12.Visible = False
            ElseIf imagem1 = "memoria6" Then
                PictureBox8.Visible = False
                PictureBox14.Visible = False
            ElseIf imagem1 = "memoria7" Then
                PictureBox6.Visible = False
                PictureBox11.Visible = False
            ElseIf imagem1 = "memoria8" Then
                PictureBox4.Visible = False
                PictureBox10.Visible = False
            End If
        Else
            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
            PictureBox9.Enabled = True
            PictureBox10.Enabled = True
            PictureBox11.Enabled = True
            PictureBox12.Enabled = True
            PictureBox13.Enabled = True
            PictureBox14.Enabled = True
            PictureBox15.Enabled = True
            PictureBox16.Enabled = True
            MsgBox("Tente novamente", MessageBoxIcon.Error)

            PictureBox1.Image = My.Resources.essa
            PictureBox2.Image = My.Resources.essa
            PictureBox3.Image = My.Resources.essa
            PictureBox4.Image = My.Resources.essa
            PictureBox5.Image = My.Resources.essa
            PictureBox6.Image = My.Resources.essa
            PictureBox7.Image = My.Resources.essa
            PictureBox8.Image = My.Resources.essa
            PictureBox9.Image = My.Resources.essa
            PictureBox10.Image = My.Resources.essa
            PictureBox11.Image = My.Resources.essa
            PictureBox12.Image = My.Resources.essa
            PictureBox13.Image = My.Resources.essa
            PictureBox14.Image = My.Resources.essa
            PictureBox15.Image = My.Resources.essa
            PictureBox16.Image = My.Resources.essa

            PictureBox1.Enabled = True
            PictureBox2.Enabled = True
            PictureBox3.Enabled = True
            PictureBox4.Enabled = True
            PictureBox5.Enabled = True
            PictureBox6.Enabled = True
            PictureBox7.Enabled = True
            PictureBox8.Enabled = True
            PictureBox9.Enabled = True
            PictureBox10.Enabled = True
            PictureBox11.Enabled = True
            PictureBox12.Enabled = True
            PictureBox13.Enabled = True
            PictureBox14.Enabled = True
            PictureBox15.Enabled = True
            PictureBox16.Enabled = True




        End If
    End Sub

End Class