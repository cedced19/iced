<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clic))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cliqueur = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label2.Location = New System.Drawing.Point(7, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Deux clics par seconde !"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Button1.Location = New System.Drawing.Point(12, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(470, 53)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Activer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Button2.Location = New System.Drawing.Point(12, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(470, 53)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Désactiver"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label3.Location = New System.Drawing.Point(7, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(421, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Si vous appuyer sur SHIFT, CTRL, ou ALT"
        '
        'Cliqueur
        '
        Me.Cliqueur.Interval = 50
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Button3.Location = New System.Drawing.Point(12, 104)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(470, 30)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Menu Principal"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.CheckBox1.Location = New System.Drawing.Point(12, 77)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(170, 21)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Mettre au premier plan"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Clic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 202)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clic"
        Me.Opacity = 0.7R
        Me.Text = "Clic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cliqueur As System.Windows.Forms.Timer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
