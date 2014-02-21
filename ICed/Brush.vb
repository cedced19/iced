Public Class Brush

    Dim Secondes
    Dim Minutes
    Dim Closeit

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Hide()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Secondes = Secondes + 1
        Minutes = 180 - Secondes
        Label1.Text = Minutes & " secondes restantes"
        If Secondes = 180 Then
            Label1.Hide()
            Label2.Text = "Tu as gagné(e) !"
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Closeit = Closeit + 1
        If Closeit = 30 Then
            Acceuil.Show()
            Me.Close()
        End If
    End Sub
End Class
