Public Class TicTacBoum2
    Dim Tic = 1
    Dim Yolo
    Dim Moddedejeux
    Dim Mot
    Dim Yolo2
    Dim Yolo3
    Dim Timing

    Sub Launch()
        PictureBox1.Show()
        Timer1.Start()
    End Sub

    Private Sub TicTacBoum_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox1.Hide()
        Label4.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Tic = Tic + 1
        ProgressBar1.Value = Tic
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            PictureBox1.Hide()
            Label4.Show()
            Timer1.Stop()
            Button1.Hide()
        End If
    End Sub

    Sub TicouTac()
        Randomize()
        Yolo = Int((3 * Rnd()) + 1)

        If Yolo = "1" Then Moddedejeux = "Tic = le son au début du mot"
        If Yolo = "2" Then Moddedejeux = "Boum = le son là ou vous voulez dans le mot"
        If Yolo = "3" Then Moddedejeux = "Tac = le son à la fin du mot"
        LabelMode.Text = "Mode : " & Moddedejeux
    End Sub

    Sub Mots()
        Randomize()
        Yolo2 = Int((100 * Rnd()) + 1)

        If Yolo2 = "1" Then Mot = "PRI"
        If Yolo2 = "2" Then Mot = "RE"
        If Yolo2 = "3" Then Mot = "BAL"
        If Yolo2 = "4" Then Mot = "BLA"
        If Yolo2 = "5" Then Mot = "BOU"
        If Yolo2 = "6" Then Mot = "PAN"
        If Yolo2 = "7" Then Mot = "PRE"
        If Yolo2 = "8" Then Mot = "DE"
        If Yolo2 = "9" Then Mot = "CLO"
        If Yolo2 = "10" Then Mot = "NOU"
        If Yolo2 = "11" Then Mot = "CRO"
        If Yolo2 = "12" Then Mot = "BEL"
        If Yolo2 = "13" Then Mot = "CRI"
        If Yolo2 = "14" Then Mot = "DO"
        If Yolo2 = "15" Then Mot = "MIR"
        If Yolo2 = "16" Then Mot = "ON"
        If Yolo2 = "17" Then Mot = "RO"
        If Yolo2 = "18" Then Mot = "DAIN"
        If Yolo2 = "19" Then Mot = "MOI"
        If Yolo2 = "20" Then Mot = "OIR"
        If Yolo2 = "21" Then Mot = "SOU"
        If Yolo2 = "22" Then Mot = "IR"
        If Yolo2 = "23" Then Mot = "FRE"
        If Yolo2 = "24" Then Mot = "LA"
        If Yolo2 = "25" Then Mot = "TRO"
        If Yolo2 = "26" Then Mot = "SEL"
        If Yolo2 = "27" Then Mot = "MI"
        If Yolo2 = "28" Then Mot = "VER"
        If Yolo2 = "29" Then Mot = "SI"
        If Yolo2 = "30" Then Mot = "IB"
        If Yolo2 = "31" Then Mot = "CAR"
        If Yolo2 = "32" Then Mot = "TAIN"
        If Yolo2 = "33" Then Mot = "VAL"
        If Yolo2 = "34" Then Mot = "OUR"
        If Yolo2 = "35" Then Mot = "TER"
        If Yolo2 = "36" Then Mot = "TOUR"
        If Yolo2 = "37" Then Mot = "BAR"
        If Yolo2 = "38" Then Mot = "MON"
        If Yolo2 = "39" Then Mot = "BER"
        If Yolo2 = "40" Then Mot = "FA"
        If Yolo2 = "41" Then Mot = "LU"
        If Yolo2 = "42" Then Mot = "BOR"
        If Yolo2 = "43" Then Mot = "MAR"
        If Yolo2 = "44" Then Mot = "JOU"
        If Yolo2 = "45" Then Mot = "BRI"
        If Yolo2 = "46" Then Mot = "ET"
        If Yolo2 = "47" Then Mot = "COU"
        If Yolo2 = "48" Then Mot = "GI"
        If Yolo2 = "49" Then Mot = "VAN"
        If Yolo2 = "50" Then Mot = "PO"
        If Yolo2 = "51" Then Mot = "TOU"
        If Yolo2 = "52" Then Mot = "CHER"
        If Yolo2 = "53" Then Mot = "PER"
        If Yolo2 = "54" Then Mot = "MO"
        If Yolo2 = "55" Then Mot = "RI"
        If Yolo2 = "56" Then Mot = "RA"
        If Yolo2 = "57" Then Mot = "LI"
        If Yolo2 = "58" Then Mot = "AIL"
        If Yolo2 = "59" Then Mot = "IC"
        If Yolo2 = "60" Then Mot = "GE"
        If Yolo2 = "61" Then Mot = "FOI"
        If Yolo2 = "62" Then Mot = "RU"
        If Yolo2 = "63" Then Mot = "FLE"
        If Yolo2 = "64" Then Mot = "SAN"
        If Yolo2 = "65" Then Mot = "MAL"
        If Yolo2 = "66" Then Mot = "TO"
        If Yolo2 = "67" Then Mot = "SA"
        If Yolo2 = "68" Then Mot = "MAN"
        If Yolo2 = "69" Then Mot = "LAN"
        If Yolo2 = "70" Then Mot = "COR"
        If Yolo2 = "71" Then Mot = "TU"
        If Yolo2 = "72" Then Mot = "DAN"
        If Yolo2 = "73" Then Mot = "SER"
        If Yolo2 = "74" Then Mot = "UL"
        If Yolo2 = "75" Then Mot = "TI"
        If Yolo2 = "76" Then Mot = "SON"
        If Yolo2 = "77" Then Mot = "LE"
        If Yolo2 = "78" Then Mot = "FRO"
        If Yolo2 = "79" Then Mot = "TAN"
        If Yolo2 = "80" Then Mot = "FAN"
        If Yolo2 = "81" Then Mot = "TAR"
        If Yolo2 = "82" Then Mot = "ROU"
        If Yolo2 = "83" Then Mot = "FRI"
        If Yolo2 = "84" Then Mot = "FER"
        If Yolo2 = "85" Then Mot = "CHAR"
        If Yolo2 = "86" Then Mot = "AIR"
        If Yolo2 = "87" Then Mot = "RAN"
        If Yolo2 = "88" Then Mot = "RON"
        If Yolo2 = "89" Then Mot = "PON"
        If Yolo2 = "90" Then Mot = "BON"
        If Yolo2 = "91" Then Mot = "BAM"
        If Yolo2 = "92" Then Mot = "MOR"
        If Yolo2 = "93" Then Mot = "IT"
        If Yolo2 = "94" Then Mot = "GRO"
        If Yolo2 = "95" Then Mot = "GRA"
        If Yolo2 = "96" Then Mot = "MA"
        If Yolo2 = "97" Then Mot = "LOU"
        If Yolo2 = "98" Then Mot = "JAN"
        If Yolo2 = "99" Then Mot = "PI"
        If Yolo2 = "100" Then Mot = "RE"
        LabelMot.Text = "Mot : " & Mot
    End Sub

    Sub Timer()
        Randomize()
        Yolo3 = Int((5 * Rnd()) + 1)

        If Yolo3 = "1" Then Timing = "450"
        If Yolo3 = "2" Then Timing = "300"
        If Yolo3 = "3" Then Timing = "600"
        If Yolo3 = "4" Then Timing = "500"
        If Yolo3 = "5" Then Timing = "350"
        Timer1.Interval = Timing
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TicouTac()
        Mots()
        Timer()
        Launch()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TicTacBoum.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Conteur.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Aether.Show()
        Me.Close()
    End Sub
End Class
