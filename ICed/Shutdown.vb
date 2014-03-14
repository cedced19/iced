Imports System.IO.File

Public Class Shutdown

    Dim file


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' If Exists("C:\Users\" & Environment.UserName & "\Desktop\" & "iced-setup.exe") Then
        ' Dim file = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\ICed\"
        ' Process.Start("C:\Users\" & Environment.UserName & "\Desktop\" & "iced-setup.exe")

        Label4.Text = "Bonjour, " & Environment.UserName
        Label1.Text = "C:\Users\" & Environment.UserName & "\Downloads\"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Setfile()
        Timer1.Start()
    End Sub

    Sub Setfile()
        If TextBox1.Text = "" Then
            MsgBox("Remplisez la case avec un fichier en court de téléchargement", MsgBoxStyle.Information, "Attention")
        Else
            file = "C:\Users\" & Environment.UserName & "\Downloads\" & TextBox1.Text
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Exists(file) Then
            Timer1.Stop()
            Shell("Shutdown -s -t 0")
            MsgBox("L'ordinateur va s'éteindre", MsgBoxStyle.Information, "Attention")
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Aether.Show()
        Me.Hide()
    End Sub
End Class
