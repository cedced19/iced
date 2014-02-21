<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nopanic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nopanic))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.25!)
        Me.Label1.Location = New System.Drawing.Point(37, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Theme :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!)
        Me.Label2.Location = New System.Drawing.Point(41, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 39)
        Me.Label2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.25!)
        Me.Button1.Location = New System.Drawing.Point(12, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(665, 60)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Lancez"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 219)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(678, 35)
        Me.ProgressBar1.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Interval = 400
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.25!)
        Me.Button2.Location = New System.Drawing.Point(12, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(678, 60)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.25!)
        Me.Button3.Location = New System.Drawing.Point(12, 395)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(678, 60)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Relancez"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Label3.Location = New System.Drawing.Point(12, 361)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(561, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Règle : Trouvez trois mots à partir d'un theme"
        '
        'Nopanic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 467)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Nopanic"
        Me.Text = "No Panic !"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
