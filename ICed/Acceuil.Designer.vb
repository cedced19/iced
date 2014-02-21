<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acceuil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Acceuil))
        Me.Endprocess = New System.Windows.Forms.Button()
        Me.Time = New System.Windows.Forms.Button()
        Me.police = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BulleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ItsARevolutionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Endbox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Bulle = New System.Diagnostics.Process()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Endprocess
        '
        Me.Endprocess.Location = New System.Drawing.Point(1004, 598)
        Me.Endprocess.Name = "Endprocess"
        Me.Endprocess.Size = New System.Drawing.Size(90, 23)
        Me.Endprocess.TabIndex = 4
        Me.Endprocess.Text = "Fin de Tache"
        Me.Endprocess.UseVisualStyleBackColor = True
        '
        'Time
        '
        Me.Time.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Time.Location = New System.Drawing.Point(118, 77)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(102, 59)
        Me.Time.TabIndex = 7
        Me.Time.Text = "Time"
        Me.Time.UseVisualStyleBackColor = True
        '
        'police
        '
        Me.police.Location = New System.Drawing.Point(118, 142)
        Me.police.Name = "police"
        Me.police.Size = New System.Drawing.Size(102, 20)
        Me.police.TabIndex = 8
        Me.police.Text = "Police"
        Me.police.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(908, 598)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Parle"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(1100, 598)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(90, 23)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Execution"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BulleToolStripMenuItem, Me.AProposToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.ToolStripSeparator2, Me.ItsARevolutionToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitterToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(121, 126)
        '
        'BulleToolStripMenuItem
        '
        Me.BulleToolStripMenuItem.Name = "BulleToolStripMenuItem"
        Me.BulleToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BulleToolStripMenuItem.Text = "Bulle"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AProposToolStripMenuItem.Text = "Troll"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(117, 6)
        '
        'ItsARevolutionToolStripMenuItem
        '
        Me.ItsARevolutionToolStripMenuItem.Name = "ItsARevolutionToolStripMenuItem"
        Me.ItsARevolutionToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.ItsARevolutionToolStripMenuItem.Text = "Site Web"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(117, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(226, 77)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 59)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Brush your Teeth"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(334, 77)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 59)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Votes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "ICed"
        Me.NotifyIcon1.Visible = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(442, 77)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 59)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Player"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Checked = Global.ICed.My.MySettings.Default.Lancer
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.ICed.My.MySettings.Default, "Lancer", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(1063, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(127, 17)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Lancer au démarrage"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Endbox
        '
        Me.Endbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Endbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.ICed.My.MySettings.Default, "EndBox", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Endbox.Location = New System.Drawing.Point(908, 550)
        Me.Endbox.Multiline = True
        Me.Endbox.Name = "Endbox"
        Me.Endbox.Size = New System.Drawing.Size(282, 42)
        Me.Endbox.TabIndex = 5
        Me.Endbox.Text = Global.ICed.My.MySettings.Default.EndBox
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(874, 334)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 169)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(550, 77)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 59)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Tic Tac Boum"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(658, 77)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(102, 59)
        Me.Button8.TabIndex = 19
        Me.Button8.Text = "Cliqueur"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Bulle
        '
        Me.Bulle.StartInfo.Arguments = "/c bubbles.scr /p65552"
        Me.Bulle.StartInfo.Domain = ""
        Me.Bulle.StartInfo.FileName = "cmd.exe"
        Me.Bulle.StartInfo.LoadUserProfile = False
        Me.Bulle.StartInfo.Password = Nothing
        Me.Bulle.StartInfo.StandardErrorEncoding = Nothing
        Me.Bulle.StartInfo.StandardOutputEncoding = Nothing
        Me.Bulle.StartInfo.UserName = ""
        Me.Bulle.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        Me.Bulle.SynchronizingObject = Me
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(766, 77)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(102, 59)
        Me.Button9.TabIndex = 20
        Me.Button9.Text = "MC Skin Get"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label1.Location = New System.Drawing.Point(66, 579)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 26)
        Me.Label1.TabIndex = 21
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(874, 77)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(102, 59)
        Me.Button10.TabIndex = 22
        Me.Button10.Text = "No Panic"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(12, 77)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(102, 59)
        Me.Button11.TabIndex = 23
        Me.Button11.Text = "NotePad C"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(226, 142)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 20)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Police"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(982, 77)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(102, 59)
        Me.Button12.TabIndex = 25
        Me.Button12.Text = "Calcul ton voyage"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(1090, 77)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(102, 59)
        Me.Button13.TabIndex = 26
        Me.Button13.Text = "Devine"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Acceuil
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1211, 635)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.police)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.Endbox)
        Me.Controls.Add(Me.Endprocess)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1227, 674)
        Me.MinimumSize = New System.Drawing.Size(1227, 674)
        Me.Name = "Acceuil"
        Me.Text = "ICed"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Endprocess As System.Windows.Forms.Button
    Friend WithEvents Endbox As System.Windows.Forms.TextBox
    Friend WithEvents Time As System.Windows.Forms.Button
    Friend WithEvents police As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItsARevolutionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents DirectorySearcher1 As System.DirectoryServices.DirectorySearcher
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Bulle As System.Diagnostics.Process
    Friend WithEvents BulleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button

End Class
