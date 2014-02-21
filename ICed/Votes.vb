Public Class Votes
    Dim Vote = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddVote()
        ProgressBar1.Value += 1
        Label1.Text = "Votes : " & ProgressBar1.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddVote()
        ProgressBar2.Value += 1
        Label2.Text = "Votes : " & ProgressBar2.Value
    End Sub

    Sub AddVote()
        Vote += 1
        ProgressBar1.Maximum = Vote
        ProgressBar2.Maximum = Vote
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Acceuil.Show()
        Me.Close()
    End Sub
End Class
