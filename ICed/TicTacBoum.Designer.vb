<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicTacBoum
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicTacBoum))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelMot = New System.Windows.Forms.Label()
        Me.LabelMode = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 517)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(877, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 473)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(877, 38)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Lancer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(583, 329)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 138)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 128.0!)
        Me.Label4.Location = New System.Drawing.Point(11, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(566, 209)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Boum !"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 33)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Règle du jeu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label6.Location = New System.Drawing.Point(43, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(753, 26)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Trouvez tour à tour des mots différents comportant un son imposé avant que "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label7.Location = New System.Drawing.Point(43, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 26)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "la bombe n'explose !"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Button2.Location = New System.Drawing.Point(46, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 40)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Relancer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Button3.Location = New System.Drawing.Point(225, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 40)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Conteur de point"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label8.Location = New System.Drawing.Point(43, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(369, 26)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Celui qui a le plus de points a perdu !"
        '
        'LabelMot
        '
        Me.LabelMot.AutoSize = True
        Me.LabelMot.BackColor = System.Drawing.Color.Transparent
        Me.LabelMot.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMot.Location = New System.Drawing.Point(41, 134)
        Me.LabelMot.Name = "LabelMot"
        Me.LabelMot.Size = New System.Drawing.Size(79, 33)
        Me.LabelMot.TabIndex = 13
        Me.LabelMot.Text = "Mot :"
        '
        'LabelMode
        '
        Me.LabelMode.AutoSize = True
        Me.LabelMode.BackColor = System.Drawing.Color.Transparent
        Me.LabelMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMode.Location = New System.Drawing.Point(42, 167)
        Me.LabelMode.Name = "LabelMode"
        Me.LabelMode.Size = New System.Drawing.Size(103, 33)
        Me.LabelMode.TabIndex = 14
        Me.LabelMode.Text = "Mode :"
        '
        'TicTacBoum
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(899, 551)
        Me.Controls.Add(Me.LabelMode)
        Me.Controls.Add(Me.LabelMot)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TicTacBoum"
        Me.Text = "Tic Tac Boum !!!!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabelMot As System.Windows.Forms.Label
    Friend WithEvents LabelMode As System.Windows.Forms.Label

End Class
