Public Class Conteur
    Dim player1 = 0
    Dim player2 = 0
    Dim player3 = 0
    Dim player4 = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        player1 = player1 + 1
        Label1.Text = "Joueur 1 : " & player1
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        player2 = player2 + 1
        Label2.Text = "Joueur 2 : " & player2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        player3 = player3 + 1
        Label3.Text = "Joueur 3 : " & player3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        player4 = player4 + 1
        Label4.Text = "Joueur 4 : " & player4
    End Sub
End Class