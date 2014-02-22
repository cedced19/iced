Imports System.Net

Public Class Acceuil

    Dim Yolo
    Dim Hello


    Sub KillProcess(ByVal ProcessName As String)
        Dim svc As Object
        Dim sQuery As String
        Dim oproc
        svc = GetObject("winmgmts:root\cimv2")
        sQuery = "select * from win32_process where name='" & ProcessName & "'"
        For Each oproc In svc.execquery(sQuery)
            oproc.Terminate()
        Next
        svc = Nothing
    End Sub

    Private Sub Endprocess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Endprocess.Click
        Errorbox1()
        KillProcess(Endbox.Text)
    End Sub

    Private Sub police_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles police.Click
            Process.Start("time.ttf")
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If System.IO.File.Exists("C:\iced\Aether.jar") = True Then
            Process.Start("C:\iced\Aether.jar")
        End If
        End
    End Sub


    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Errorbox1()
        Dim ep = CreateObject("sapi.spvoice")
        ep.speak(Endbox.Text)

    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.Click
        Errorbox1()
        If System.IO.File.Exists(Endbox.Text) = True Then
            Process.Start(Endbox.Text)
        End If
    End Sub

    Private Sub ItsARevolutionToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ItsARevolutionToolStripMenuItem.Click
        Process.Start("https://cedced19.wordpress.com")
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        If MsgBox("Souhaitez-vous vraiment quitter ce magnifique programme ?", 36, "Quitter") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Sub Errorbox1()
        ErrorProvider1.Clear()
        If Endbox.Text = "" Then
            ErrorProvider1.SetError(Endbox, "Rien est écrit")
        End If
    End Sub

    Sub AddStartup()
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Run").SetValue("ICed", Application.ExecutablePath)
    End Sub

    Sub RemoveStartup()
        My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue("ICed")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            AddStartup()
        Else
            RemoveStartup()
        End If
    End Sub

    Private Sub Acceuil_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox1.Hide()
        Mot()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        Process.Start("https://www.dropbox.com/s/tx9dqck6k4iqxau/ICed.exe")
    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        PictureBox1.Show()
    End Sub

    Sub Mot()
        Randomize()
        Yolo = Int((5 * Rnd()) + 1)

        If Yolo = "1" Then Hello = "Bonjour " & Environment.UserName & ", jouer à tic tac boum tu dois, jeune padawan"
        If Yolo = "2" Then Hello = "Bonjour " & Environment.UserName & ", it's a revolution"
        If Yolo = "3" Then Hello = "Bonjour " & Environment.UserName & ", temps tu as maintenant grâce à ICed"
        If Yolo = "4" Then Hello = "Bonjour " & Environment.UserName & ", time you have now because... ICed !"
        If Yolo = "5" Then Hello = "Bonjour " & Environment.UserName & ", que la force soit avec toi !"
        Label1.Text = Hello

    End Sub


    Private Sub BulleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BulleToolStripMenuItem.Click
        Bulle.Start()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("NotePad C.exe")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Timeced.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Brush.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Votes.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Player.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        TicTacBoum.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Clic.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        MCSkin.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Nopanic.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Calcul.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Devine.Show()
        Me.Hide()
    End Sub

End Class


