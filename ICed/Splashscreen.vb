Public Class Splashscreen
    Dim seconde = 0

     Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        seconde = seconde + 1
        If seconde = 20 Then
            Aether.Show()
            Me.Close()
        End If
    End Sub
End Class
