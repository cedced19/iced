Public Class Devine

    Dim Yolo
    Dim Result
    Dim Essai = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Random()
        Label3.Text = Result
    End Sub

    Sub Random()

        Essai = Essai + 1

        ' Si c'est le bon...
        If (TextBox1.Text = Yolo) Then
            Result = "Vous avez gagné ! Le nombre mystère était : " & Yolo
            Label4.Text = "Vous avez fais " & Essai & " essais"
            Button2.Show()
        End If
        ' Si c'est trop petit...
        If (TextBox1.Text < Yolo) Then
            Result = "C'est plus."
        End If
        'Si c'est trop grand...
        If (TextBox1.Text > Yolo) Then
            Result = "C'est moin."
        End If

    End Sub


    Private Sub Devine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On choisi un nombre 
        Randomize()
        Yolo = Int((100 * Rnd()) + 1)
        Button2.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Reset
        Essai = 0
        Yolo = 0
        Randomize()
        Yolo = Int((100 * Rnd()) + 1)
        Label3.Text = "Nombre mystère"
        Label4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Acceuil.Show()
        Me.Close()
    End Sub
End Class
