Public Class Player

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Acceuil.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.URL = "http://streaming.radio.rtl2.fr/rtl2-1-44-128"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer1.URL = "http://95.81.147.3/nrj/all/nrj_113225.mp3"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AxWindowsMediaPlayer1.URL = "http://vipicecast.yacast.net/europe1"
    End Sub
End Class