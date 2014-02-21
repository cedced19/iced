Public Class Timeced
    Dim Day1 = Date.Now.DayOfWeek
    Dim Day2

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        DofWeek()
        Time()
        Day()
    End Sub


    Sub DofWeek()
            If Day1 = "1" Then Day2 = "1"
            If Day1 = "2" Then Day2 = "2"
            If Day1 = "3" Then Day2 = "3"
            If Day1 = "4" Then Day2 = "4"
            If Day1 = "5" Then Day2 = "5"
            If Day1 = "6" Then Day2 = "6"
            If Day1 = "0" Then Day2 = "7"
    End Sub




    Sub Time()
        Label1.Text = Date.Now.ToLongTimeString & ":" & Date.Now.Millisecond
    End Sub

    Sub Day()
        Label3.Text = Date.Now.ToLongDateString & " 21° siecle"
        Label4.Text = "Jour de la semaine : " & Day2
        Label5.Text = "Jour de l'annee : " & Date.Now.DayOfYear
    End Sub

    Private Sub Label2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.Click
        Process.Start("timedate.cpl")
    End Sub

    Private Sub Timeced_Click(sender As Object, e As EventArgs) Handles Me.Click
        MonthCalendar1.Hide()
        Label7.Show()
    End Sub



    Private Sub Time_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MonthCalendar1.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Acceuil.Show()
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        MonthCalendar1.Show()
        Label7.Hide()
    End Sub
End Class
