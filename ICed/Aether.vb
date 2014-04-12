Imports System.Net

Public Class Aether 'Est la classe principale.
    Dim Hello
    Dim Now = "2.0"

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


    Private Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Errorbox1()
        Dim ep = CreateObject("sapi.spvoice")
        ep.speak(Endbox.Text)

    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.Click
        Errorbox1()
        If System.IO.File.Exists(Endbox.Text) Then
            Process.Start(Endbox.Text)
        End If
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
        Mot()
    End Sub

    Sub Mot()
        ' Si c'est midi...
        If (Date.Now.Hour = "12") Then
            Hello = "Bonne appétit " & Environment.UserName & " !"
        End If
        ' Si c'est le matin...
        If (Date.Now.Hour < "12") Then
            Hello = "Bonne matiné " & Environment.UserName & ", tu as pris ton petit dejeuner ?"
        End If
        'Si c'est l'aprem...
        If (Date.Now.Hour > "12") Then
            Hello = "Bonne après-midi " & Environment.UserName & " !"
        End If
        'Si c'est le soire...
        If (Date.Now.Hour > "18") Then
            Hello = "Bonne soirée " & Environment.UserName & " !"
        End If
        'Si c'est la nuit...
        If (Date.Now.Hour > "22") Then
            Hello = "Bonne nuit " & Environment.UserName & " !"
        End If
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
        Me.Close()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Calcul.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Devine.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        ChronoC.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Shutdown.Show()
        Me.Close()
    End Sub

    Sub CheckUpdate()
        Dim MAJ As New WebClient
        Dim Last = MAJ.DownloadString("http://cedced19.github.io/notepad/version.txt")
        If Last = Now Then
            Label15.Text = "C'est à jour."
        Else
            Label15.Text = "Il y a une nouvelle version diponible."
            Process.Start("http://cedced19.github.io/notepad/")
        End If
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        CheckUpdate()
    End Sub
End Class


