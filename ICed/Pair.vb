Public Class Pair

    Dim ch1 = "a"
    Dim ch2 = "z"
    Dim score
    Dim time

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.BackColor = Color.Blue
        ch1 = "1"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.BackColor = Color.Blue
        ch2 = "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.BackColor = Color.Yellow
        ch1 = "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.BackColor = Color.Yellow
        ch2 = "2"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PictureBox1.BackColor = Color.Red
        ch1 = "3"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox1.BackColor = Color.Red
        ch2 = "3"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PictureBox1.BackColor = Color.Violet
        ch1 = "4"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PictureBox1.BackColor = Color.Violet
        ch2 = "4"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        PictureBox1.BackColor = Color.Silver
        ch2 = "5"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        PictureBox1.BackColor = Color.Pink
        ch1 = "6"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        PictureBox1.BackColor = Color.Silver
        ch1 = "5"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        PictureBox1.BackColor = Color.Pink
        ch2 = "6"
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        PictureBox1.BackColor = Color.Orange
        ch2 = "7"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        PictureBox1.BackColor = Color.Orange
        ch1 = "7"
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        PictureBox1.BackColor = Color.Turquoise
        ch2 = "8"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        PictureBox1.BackColor = Color.Turquoise
        ch1 = "8"
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        PictureBox1.BackColor = Color.Purple
        ch1 = "9"
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        PictureBox1.BackColor = Color.Purple
        ch2 = "9"
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        PictureBox1.BackColor = Color.LightGray
        ch2 = "10"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        PictureBox1.BackColor = Color.LightGray
        ch1 = "10"
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        PictureBox1.BackColor = Color.Maroon
        ch1 = "11"
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        PictureBox1.BackColor = Color.Maroon
        ch2 = "11"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        PictureBox1.BackColor = Color.Olive
        ch1 = "12"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        PictureBox1.BackColor = Color.Olive
        ch2 = "12"
    End Sub

    Private Sub Check_Tick(sender As Object, e As EventArgs) Handles Check.Tick
        Label1.Text = "Vous avez " & score & "/12"
        Select Case ch1 + ch2
            Case "11"
                Button1.Hide()
                Button4.Hide()
            Case "22"
                Button2.Hide()
                Button3.Hide()
            Case "33"
                Button5.Hide()
                Button6.Hide()
            Case "44"
                Button7.Hide()
                Button8.Hide()
            Case "55"
                Button10.Hide()
                Button12.Hide()
            Case "66"
                Button11.Hide()
                Button9.Hide()
            Case "77"
                Button24.Hide()
                Button13.Hide()
            Case "88"
                Button23.Hide()
                Button15.Hide()
            Case "99"
                Button19.Hide()
                Button21.Hide()
            Case "1010"
                Button16.Hide()
                Button22.Hide()
            Case "1111"
                Button20.Hide()
                Button14.Hide()
            Case "1212"
                Button18.Hide()
                Button17.Hide()
        End Select
        If ch1 = ch2 Then
            ch1 = "a"
            ch2 = "z"
            score = score + 1
        End If
        If score = 12 Then
            Temps.Stop()
        End If
    End Sub

    Private Sub Pair_Layout(sender As Object, e As LayoutEventArgs) Handles Me.Layout
        Check.Start()
    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Restart.Click
        Restart.Text = "Recommencer"
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button5.Show()
        Button6.Show()
        Button7.Show()
        Button8.Show()
        Button9.Show()
        Button10.Show()
        Button11.Show()
        Button12.Show()
        Button13.Show()
        Button14.Show()
        Button15.Show()
        Button16.Show()
        Button17.Show()
        Button18.Show()
        Button19.Show()
        Button20.Show()
        Button21.Show()
        Button22.Show()
        Button23.Show()
        Button24.Show()
        score = 0
        time = 0
        ch1 = "a"
        ch2 = "z"
        Temps.Start()
    End Sub

    Private Sub Temps_Tick(sender As Object, e As EventArgs) Handles Temps.Tick
        time = time + 1
        Label2.Text = "Temps : " & time & "s"
    End Sub
End Class
