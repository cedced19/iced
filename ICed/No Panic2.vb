Public Class Nopanic2
    Dim Question1
    Dim Question2
    Dim Tic = 1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Question()
        Starttimer()
    End Sub

    Sub Question()
        Randomize()
        Question1 = Int((40 * Rnd()) + 1)

        If Question1 = "1" Then Question2 = "Mots commençant par T"
        If Question1 = "2" Then Question2 = "Mots commençant par B"
        If Question1 = "3" Then Question2 = "Mots commençant par D"
        If Question1 = "4" Then Question2 = "Objets verts"
        If Question1 = "5" Then Question2 = "Objets transparents"
        If Question1 = "6" Then Question2 = "Vetements"
        If Question1 = "7" Then Question2 = "Animaux"
        If Question1 = "8" Then Question2 = "Metiers"
        If Question1 = "9" Then Question2 = "Legumes"
        If Question1 = "10" Then Question2 = "Fleurs"
        If Question1 = "11" Then Question2 = "Parties du corps"
        If Question1 = "12" Then Question2 = "Loisirs"
        If Question1 = "13" Then Question2 = "Outils"
        If Question1 = "14" Then Question2 = "Choses sucrées"
        If Question1 = "15" Then Question2 = "Personnage de science-fiction"
        If Question1 = "16" Then Question2 = "Choses carées"
        If Question1 = "17" Then Question2 = "Animaux de la jungle"
        If Question1 = "18" Then Question2 = "Personnage de dessin aimés"
        If Question1 = "19" Then Question2 = "Matière scolaire"
        If Question1 = "20" Then Question2 = "Mot de 4 lettres"
        If Question1 = "21" Then Question2 = "Objets utile en vacance"
        If Question1 = "22" Then Question2 = "Jeux de fille"
        If Question1 = "23" Then Question2 = "Noël"
        If Question1 = "24" Then Question2 = "Choses rondes"
        If Question1 = "25" Then Question2 = "Formes"
        If Question1 = "26" Then Question2 = "Boissons"
        If Question1 = "27" Then Question2 = "Insecte"
        If Question1 = "28" Then Question2 = "Fruit"
        If Question1 = "29" Then Question2 = "Oiseaux"
        If Question1 = "30" Then Question2 = "Poissons"
        If Question1 = "31" Then Question2 = "Jouets"
        If Question1 = "32" Then Question2 = "Nourriture"
        If Question1 = "33" Then Question2 = "Instrument de musique"
        If Question1 = "34" Then Question2 = "Jeux de garçon"
        If Question1 = "35" Then Question2 = "Contes de fées"
        If Question1 = "36" Then Question2 = "Pays"
        If Question1 = "37" Then Question2 = "Choses coupantes"
        If Question1 = "38" Then Question2 = "Animaux de la ferme"
        If Question1 = "39" Then Question2 = "Jeux"
        If Question1 = "40" Then Question2 = "Mots commençant par A"
        If Question1 = "41" Then Question2 = "Vêtement"
        If Question1 = "42" Then Question2 = "Meubles"
        If Question1 = "43" Then Question2 = "Hero de series télé"
        If Question1 = "44" Then Question2 = "Equipement de sport"
        If Question1 = "45" Then Question2 = "Mots commençant par S"
        If Question1 = "46" Then Question2 = "Commerces"
        If Question1 = "47" Then Question2 = "Metaux"
        If Question1 = "48" Then Question2 = "Choses en verre"
        If Question1 = "49" Then Question2 = "Choses froides"
        If Question1 = "50" Then Question2 = "Monstres célèbres"
        If Question1 = "51" Then Question2 = "Westerns"
        If Question1 = "52" Then Question2 = "Ustensiles de cuisines"
        If Question1 = "53" Then Question2 = "Petit-dejeuner"
        If Question1 = "54" Then Question2 = "Parfums"
        If Question1 = "55" Then Question2 = "Soupes"
        If Question1 = "56" Then Question2 = "Choses qui volent"
        If Question1 = "57" Then Question2 = "Sport"
        If Question1 = "58" Then Question2 = "Notes de musique"
        If Question1 = "59" Then Question2 = "Langues"
        If Question1 = "60" Then Question2 = "Marque de voiture"


        Label2.Text = Question2
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Tic = Tic + 1
        ProgressBar1.Value = Tic
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Stoptimer()
            MsgBox("Vous avez 0 point !", MsgBoxStyle.Information, "Points")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Stoptimer()
        Point()
    End Sub


    Sub Stoptimer()
        Timer1.Stop()
        Button3.Show()
        Button1.Hide()
        Button2.Hide()
    End Sub
    Sub Starttimer()
        Timer1.Start()
        Button2.Show()
        Button1.Hide()
    End Sub

    Sub Point()
        If Tic = 90 Or Tic = 91 Or Tic = 92 Or Tic = 93 Or Tic = 94 Or Tic = 95 Or Tic = 96 Or Tic = 97 Or Tic = 98 Or Tic = 99 Then
            MsgBox("Vous avez 1 point !", MsgBoxStyle.Information, "Points")
        End If

        If Tic = 80 Or Tic = 81 Or Tic = 82 Or Tic = 83 Or Tic = 84 Or Tic = 85 Or Tic = 86 Or Tic = 87 Or Tic = 88 Or Tic = 89 Then
            MsgBox("Vous avez 2 points !", MsgBoxStyle.Information, "Points")
        End If

        If Tic = 70 Or Tic = 71 Or Tic = 72 Or Tic = 73 Or Tic = 74 Or Tic = 75 Or Tic = 76 Or Tic = 77 Or Tic = 78 Or Tic = 79 Then
            MsgBox("Vous avez 3 points !", MsgBoxStyle.Information, "Points")
        End If

        If Tic = 60 Or Tic = 61 Or Tic = 62 Or Tic = 63 Or Tic = 64 Or Tic = 65 Or Tic = 66 Or Tic = 67 Or Tic = 68 Or Tic = 69 Then
            MsgBox("Vous avez 4 points !", MsgBoxStyle.Information, "Points")
        End If

        If Tic = 50 Or Tic = 51 Or Tic = 52 Or Tic = 53 Or Tic = 54 Or Tic = 55 Or Tic = 56 Or Tic = 57 Or Tic = 58 Or Tic = 59 Then
            MsgBox("Vous avez 5 points !", MsgBoxStyle.Information, "Points")
        End If

        If Tic = 40 Or Tic = 41 Or Tic = 42 Or Tic = 43 Or Tic = 44 Or Tic = 45 Or Tic = 46 Or Tic = 47 Or Tic = 48 Or Tic = 49 Then
            MsgBox("Vous avez 6 points !", MsgBoxStyle.Information, "Points")
        End If
        If Tic = 30 Or Tic = 31 Or Tic = 32 Or Tic = 33 Or Tic = 34 Or Tic = 35 Or Tic = 36 Or Tic = 37 Or Tic = 38 Or Tic = 39 Then
            MsgBox("Vous avez 7 points !", MsgBoxStyle.Information, "Points")
        End If

        If Tic = 20 Or Tic = 21 Or Tic = 22 Or Tic = 23 Or Tic = 24 Or Tic = 25 Or Tic = 26 Or Tic = 27 Or Tic = 28 Or Tic = 29 Then
            MsgBox("Vous avez 8 points !", MsgBoxStyle.Information, "Points")
        End If

        If Tic = 10 Or Tic = 11 Or Tic = 12 Or Tic = 13 Or Tic = 14 Or Tic = 15 Or Tic = 16 Or Tic = 17 Or Tic = 18 Or Tic = 19 Then
            MsgBox("Vous avez 9 points !", MsgBoxStyle.Information, "Points")
        End If

        If Tic = 0 Or Tic = 1 Or Tic = 2 Or Tic = 3 Or Tic = 4 Or Tic = 5 Or Tic = 6 Or Tic = 7 Or Tic = 8 Or Tic = 9 Then
            MsgBox("Vous avez 10 points ! Bravo !", MsgBoxStyle.Information, "Points")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Button2.Hide()
        Button3.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Nopanic.Show()
        Me.Close()
    End Sub
End Class
