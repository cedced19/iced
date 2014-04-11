Public Class Brush

    Dim Secondes
    Dim Minutes
    Dim Closeit
    Dim NewPoint As New System.Drawing.Point
    Dim X, Y As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.Y -= (Y)
            NewPoint.X -= (X)
            Me.Location = NewPoint
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Timer3.Start()
        Button1.Hide()
        PictureBox1.Hide()
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
        Timer3.Stop()
        If Closeit = 30 Then
            Aether.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Aether.Show()
        Me.Hide()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Minutes = "0" Then
            Dim ep = CreateObject("sapi.spvoice")
            ep.speak("Fini")
        End If
    End Sub
End Class
