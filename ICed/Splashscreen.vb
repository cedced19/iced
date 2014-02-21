Public Class Splashscreen
    Dim seconde = 1

     Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        seconde = seconde + 1
        ProgressBar1.Value = seconde
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Acceuil.Show()
            Me.Close()
        End If
    End Sub
End Class
