Public Class MCSkin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Afficher()
    End Sub

    Sub Afficher()
        If TextBox1.Text = "" Then
            MsgBox("Veulliez mettre un nom de skin valide !", MsgBoxStyle.Critical, "Attention")
            Exit Sub
        End If
        PictureBox1.ImageLocation = "http://minecraft.net/skin/" & TextBox1.Text & ".png"
    End Sub

    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click
        SaveFileDialog1.FileName = TextBox1.Text & ".png"
        SaveFileDialog1.ShowDialog()

        PictureBox1.Image.Save(SaveFileDialog1.FileName)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Aether.Show()
        Me.Close()
    End Sub
End Class
