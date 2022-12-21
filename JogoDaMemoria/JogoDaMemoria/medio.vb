Public Class medio
    Dim clicou As Boolean = False
    Dim imagem1, imagem2 As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If clicou = False Then
            clicou = True
            PictureBox1.Image = My.Resources.memoria11
            imagem1 = "memoria11"
            PictureBox1.Enabled = False
        Else
            imagem2 = "memoria11"
            clicou = False
            PictureBox1.Image = My.Resources.memoria11
            verificar()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If clicou = False Then
            clicou = True
            PictureBox2.Image = My.Resources.memoria18
            imagem1 = "memoria18"
            PictureBox2.Enabled = False
        Else
            imagem2 = "memoria18"
            clicou = False
            PictureBox2.Image = My.Resources.memoria18

            verificar()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If clicou = False Then
            clicou = True
            PictureBox3.Image = My.Resources.memoria1
            imagem1 = "memoria1"
            PictureBox3.Enabled = False
        Else
            imagem2 = "memoria1"
            clicou = False
            PictureBox3.Image = My.Resources.memoria1
            verificar()

        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If clicou = False Then
            clicou = True
            PictureBox4.Image = My.Resources.memoria17
            imagem1 = "memoria17"
            PictureBox4.Enabled = False
        Else
            imagem2 = "memoria17"
            clicou = False
            PictureBox4.Image = My.Resources.memoria17

            verificar()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If clicou = False Then
            clicou = True
            PictureBox5.Image = My.Resources.memoria15
            imagem1 = "memoria15"
            PictureBox5.Enabled = False
        Else
            imagem2 = "memoria15"
            clicou = False
            PictureBox5.Image = My.Resources.memoria15

            verificar()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If clicou = False Then
            clicou = True
            PictureBox6.Image = My.Resources.memoria_3
            imagem1 = "memoria3"
            PictureBox6.Enabled = False
        Else
            imagem2 = "memoria3"
            clicou = False
            PictureBox6.Image = My.Resources.memoria_3

            verificar()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If clicou = False Then
            clicou = True
            PictureBox7.Image = My.Resources.memoria10
            imagem1 = "memoria10"
            PictureBox7.Enabled = False
        Else
            imagem2 = "memoria10"
            clicou = False
            PictureBox7.Image = My.Resources.memoria10

            verificar()
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If clicou = False Then
            clicou = True
            PictureBox8.Image = My.Resources.memoria9
            imagem1 = "memoria9"
            PictureBox8.Enabled = False
        Else
            imagem2 = "memoria9"
            clicou = False
            PictureBox8.Image = My.Resources.memoria9

            verificar()
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If clicou = False Then
            clicou = True
            PictureBox9.Image = My.Resources.memoria14
            imagem1 = "memoria14"
            PictureBox9.Enabled = False
        Else
            imagem2 = "memoria14"
            clicou = False
            PictureBox9.Image = My.Resources.memoria14

            verificar()
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        If clicou = False Then
            clicou = True
            PictureBox10.Image = My.Resources.memoria7
            imagem1 = "memoria7"
            PictureBox10.Enabled = False
        Else
            imagem2 = "memoria7"
            clicou = False
            PictureBox10.Image = My.Resources.memoria7

            verificar()
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If clicou = False Then
            clicou = True
            PictureBox11.Image = My.Resources.memoria12
            imagem1 = "memoria12"
            PictureBox11.Enabled = False
        Else
            imagem2 = "memoria12"
            clicou = False
            PictureBox11.Image = My.Resources.memoria12

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
            PictureBox13.Image = My.Resources.memoria2
            imagem1 = "memoria2"
            PictureBox13.Enabled = False
        Else
            imagem2 = "memoria2"
            clicou = False
            PictureBox13.Image = My.Resources.memoria2

            verificar()
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If clicou = False Then
            clicou = True
            PictureBox14.Image = My.Resources.memoria8
            imagem1 = "memoria8"
            PictureBox14.Enabled = False
        Else
            imagem2 = "memoria8"
            clicou = False
            PictureBox14.Image = My.Resources.memoria8

            verificar()
        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        If clicou = False Then
            clicou = True
            PictureBox15.Image = My.Resources.memoria13
            imagem1 = "memoria13"
            PictureBox15.Enabled = False
        Else
            imagem2 = "memoria13"
            clicou = False
            PictureBox15.Image = My.Resources.memoria13

            verificar()
        End If
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If clicou = False Then
            clicou = True
            PictureBox16.Image = My.Resources.memoria16
            imagem1 = "memoria16"
            PictureBox16.Enabled = False
        Else
            imagem2 = "memoria16"
            clicou = False
            PictureBox16.Image = My.Resources.memoria16

            verificar()
        End If
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        If clicou = False Then
            clicou = True
            PictureBox17.Image = My.Resources.memoria6
            imagem1 = "memoria6"
            PictureBox17.Enabled = False
        Else
            imagem2 = "memoria6"
            clicou = False
            PictureBox17.Image = My.Resources.memoria6

            verificar()
        End If
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        If clicou = False Then
            clicou = True
            PictureBox18.Image = My.Resources.memoria4
            imagem1 = "memoria4"
            PictureBox18.Enabled = False
        Else
            imagem2 = "memoria4"
            clicou = False
            PictureBox18.Image = My.Resources.memoria4

            verificar()
        End If
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        If clicou = False Then
            clicou = True
            PictureBox19.Image = My.Resources.memoria12
            imagem1 = "memoria12"
            PictureBox19.Enabled = False
        Else
            imagem2 = "memoria12"
            clicou = False
            PictureBox19.Image = My.Resources.memoria12

            verificar()
        End If
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        If clicou = False Then
            clicou = True
            PictureBox20.Image = My.Resources.memoria14
            imagem1 = "memoria14"
            PictureBox20.Enabled = False
        Else
            imagem2 = "memoria14"
            clicou = False
            PictureBox20.Image = My.Resources.memoria14
            verificar()
        End If

    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        If clicou = False Then
            clicou = True
            PictureBox21.Image = My.Resources.memoria18
            imagem1 = "memoria18"
            PictureBox21.Enabled = False
        Else
            imagem2 = "memoria18"
            clicou = False
            PictureBox21.Image = My.Resources.memoria18

            verificar()
        End If
    End Sub

    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        If clicou = False Then
            clicou = True
            PictureBox22.Image = My.Resources.memoria7
            imagem1 = "memoria7"
            PictureBox22.Enabled = False
        Else
            imagem2 = "memoria7"
            clicou = False
            PictureBox22.Image = My.Resources.memoria7

            verificar()
        End If
    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        If clicou = False Then
            clicou = True
            PictureBox23.Image = My.Resources.memoria_3
            imagem1 = "memoria3"
            PictureBox23.Enabled = False
        Else
            imagem2 = "memoria3"
            clicou = False
            PictureBox23.Image = My.Resources.memoria_3
            verificar()

        End If
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        If clicou = False Then
            clicou = True
            PictureBox24.Image = My.Resources.memoria15
            imagem1 = "memoria15"
            PictureBox24.Enabled = False
        Else
            imagem2 = "memoria15"
            clicou = False
            PictureBox24.Image = My.Resources.memoria15
            verificar()

        End If
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        If clicou = False Then
            clicou = True
            PictureBox25.Image = My.Resources.memoria1
            imagem1 = "memoria1"
            PictureBox25.Enabled = False
        Else
            imagem2 = "memoria1"
            clicou = False
            PictureBox25.Image = My.Resources.memoria1

            verificar()
        End If
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        If clicou = False Then
            clicou = True
            PictureBox26.Image = My.Resources.memoria4
            imagem1 = "memoria4"
            PictureBox26.Enabled = False
        Else
            imagem2 = "memoria4"
            clicou = False
            PictureBox26.Image = My.Resources.memoria4
            verificar()
        End If
    End Sub

    Private Sub PictureBox30_Click(sender As Object, e As EventArgs) Handles PictureBox30.Click
        If clicou = False Then
            clicou = True
            PictureBox30.Image = My.Resources.memoria9
            imagem1 = "memoria9"
            PictureBox30.Enabled = False
        Else
            imagem2 = "memoria9"
            clicou = False
            PictureBox30.Image = My.Resources.memoria9
            verificar()
        End If
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        If clicou = False Then
            clicou = True
            PictureBox27.Image = My.Resources.memoria2
            imagem1 = "memoria2"
            PictureBox27.Enabled = False
        Else
            imagem2 = "memoria2"
            clicou = False
            PictureBox27.Image = My.Resources.memoria2

            verificar()
        End If
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        If clicou = False Then
            clicou = True
            PictureBox28.Image = My.Resources.memoria11
            imagem1 = "memoria11"
            PictureBox28.Enabled = False
        Else
            imagem2 = "memoria11"
            clicou = False
            PictureBox28.Image = My.Resources.memoria11

            verificar()
        End If
    End Sub

    Private Sub PictureBox31_Click(sender As Object, e As EventArgs) Handles PictureBox31.Click
        If clicou = False Then
            clicou = True
            PictureBox31.Image = My.Resources.memoria6
            imagem1 = "memoria6"
            PictureBox31.Enabled = False
        Else
            imagem2 = "memoria6"
            clicou = False
            PictureBox31.Image = My.Resources.memoria6
            verificar()

        End If
    End Sub

    Private Sub PictureBox29_Click(sender As Object, e As EventArgs) Handles PictureBox29.Click
        If clicou = False Then
            clicou = True
            PictureBox29.Image = My.Resources.memoria10
            imagem1 = "memoria10"
            PictureBox29.Enabled = False
        Else
            imagem2 = "memoria10"
            clicou = False
            PictureBox29.Image = My.Resources.memoria10

            verificar()
        End If
    End Sub

    Private Sub PictureBox32_Click(sender As Object, e As EventArgs) Handles PictureBox32.Click
        If clicou = False Then
            clicou = True
            PictureBox32.Image = My.Resources.memoria17
            imagem1 = "memoria17"
            PictureBox32.Enabled = False
        Else
            imagem2 = "memoria17"
            clicou = False
            PictureBox32.Image = My.Resources.memoria17

            verificar()
        End If
    End Sub

    Private Sub PictureBox33_Click(sender As Object, e As EventArgs) Handles PictureBox33.Click
        If clicou = False Then
            clicou = True
            PictureBox33.Image = My.Resources.memoria5
            imagem1 = "memoria5"
            PictureBox33.Enabled = False
        Else
            imagem2 = "memoria5"
            clicou = False
            PictureBox33.Image = My.Resources.memoria5

            verificar()
        End If
    End Sub

    Private Sub PictureBox34_Click(sender As Object, e As EventArgs) Handles PictureBox34.Click
        If clicou = False Then
            clicou = True
            PictureBox34.Image = My.Resources.memoria13
            imagem1 = "memoria13"
            PictureBox34.Enabled = False
        Else
            imagem2 = "memoria13"
            clicou = False
            PictureBox34.Image = My.Resources.memoria13
            verificar()

        End If
    End Sub

    Private Sub PictureBox35_Click(sender As Object, e As EventArgs) Handles PictureBox35.Click
        If clicou = False Then
            clicou = True
            PictureBox35.Image = My.Resources.memoria16
            imagem1 = "memoria16"
            PictureBox35.Enabled = False
        Else
            imagem2 = "memoria16"
            clicou = False
            PictureBox35.Image = My.Resources.memoria16

            verificar()
        End If
    End Sub

    Private Sub PictureBox36_Click(sender As Object, e As EventArgs) Handles PictureBox36.Click
        If clicou = False Then
            clicou = True
            PictureBox36.Image = My.Resources.memoria8
            imagem1 = "memoria8"
            PictureBox36.Enabled = False
        Else
            imagem2 = "memoria8"
            clicou = False
            PictureBox36.Image = My.Resources.memoria8

            verificar()
        End If
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
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True
            PictureBox24.Enabled = True
            PictureBox25.Enabled = True
            PictureBox26.Enabled = True
            PictureBox27.Enabled = True
            PictureBox28.Enabled = True
            PictureBox29.Enabled = True
            PictureBox30.Enabled = True
            PictureBox31.Enabled = True
            PictureBox32.Enabled = True
            PictureBox33.Enabled = True
            PictureBox34.Enabled = True
            PictureBox35.Enabled = True
            PictureBox36.Enabled = True

            MsgBox("Parabéns, você acertou", MessageBoxIcon.Information)

            If imagem1 = "memoria1" Then
                PictureBox3.Visible = False
                PictureBox25.Visible = False
            ElseIf imagem1 = "memoria2" Then
                PictureBox13.Visible = False
                PictureBox27.Visible = False
            ElseIf imagem1 = "memoria3" Then
                PictureBox6.Visible = False
                PictureBox23.Visible = False
            ElseIf imagem1 = "memoria4" Then
                PictureBox18.Visible = False
                PictureBox26.Visible = False
            ElseIf imagem1 = "memoria5" Then
                PictureBox12.Visible = False
                PictureBox33.Visible = False
            ElseIf imagem1 = "memoria6" Then
                PictureBox17.Visible = False
                PictureBox31.Visible = False
            ElseIf imagem1 = "memoria7" Then
                PictureBox10.Visible = False
                PictureBox22.Visible = False
            ElseIf imagem1 = "memoria8" Then
                PictureBox14.Visible = False
                PictureBox36.Visible = False
            ElseIf imagem1 = "memoria9" Then
                PictureBox8.Visible = False
                PictureBox30.Visible = False
            ElseIf imagem1 = "memoria10" Then
                PictureBox7.Visible = False
                PictureBox29.Visible = False
            ElseIf imagem1 = "memoria11" Then
                PictureBox1.Visible = False
                PictureBox28.Visible = False
            ElseIf imagem1 = "memoria12" Then
                PictureBox11.Visible = False
                PictureBox19.Visible = False
            ElseIf imagem1 = "memoria13" Then
                PictureBox15.Visible = False
                PictureBox34.Visible = False
            ElseIf imagem1 = "memoria14" Then
                PictureBox9.Visible = False
                PictureBox20.Visible = False
            ElseIf imagem1 = "memoria15" Then
                PictureBox5.Visible = False
                PictureBox24.Visible = False
            ElseIf imagem1 = "memoria16" Then
                PictureBox16.Visible = False
                PictureBox35.Visible = False
            ElseIf imagem1 = "memoria17" Then
                PictureBox4.Visible = False
                PictureBox32.Visible = False
            ElseIf imagem1 = "memoria18" Then
                PictureBox2.Visible = False
                PictureBox21.Visible = False

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
            PictureBox17.Enabled = True
            PictureBox18.Enabled = True
            PictureBox19.Enabled = True
            PictureBox20.Enabled = True
            PictureBox21.Enabled = True
            PictureBox22.Enabled = True
            PictureBox23.Enabled = True
            PictureBox24.Enabled = True
            PictureBox25.Enabled = True
            PictureBox26.Enabled = True
            PictureBox27.Enabled = True
            PictureBox28.Enabled = True
            PictureBox29.Enabled = True
            PictureBox30.Enabled = True
            PictureBox31.Enabled = True
            PictureBox32.Enabled = True
            PictureBox33.Enabled = True
            PictureBox34.Enabled = True
            PictureBox35.Enabled = True
            PictureBox36.Enabled = True
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
            PictureBox17.Image = My.Resources.essa
            PictureBox18.Image = My.Resources.essa
            PictureBox19.Image = My.Resources.essa
            PictureBox20.Image = My.Resources.essa
            PictureBox21.Image = My.Resources.essa
            PictureBox22.Image = My.Resources.essa
            PictureBox23.Image = My.Resources.essa
            PictureBox24.Image = My.Resources.essa
            PictureBox25.Image = My.Resources.essa
            PictureBox26.Image = My.Resources.essa
            PictureBox27.Image = My.Resources.essa
            PictureBox28.Image = My.Resources.essa
            PictureBox29.Image = My.Resources.essa
            PictureBox30.Image = My.Resources.essa
            PictureBox31.Image = My.Resources.essa
            PictureBox32.Image = My.Resources.essa
            PictureBox33.Image = My.Resources.essa
            PictureBox34.Image = My.Resources.essa
            PictureBox35.Image = My.Resources.essa
            PictureBox36.Image = My.Resources.essa

            



        End If
    End Sub
End Class