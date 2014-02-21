<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conteur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Conteur))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!)
        Me.Label1.Location = New System.Drawing.Point(462, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Joueur 1 : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!)
        Me.Label2.Location = New System.Drawing.Point(462, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Joueur 2 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!)
        Me.Label3.Location = New System.Drawing.Point(462, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 38)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Joueur 3 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!)
        Me.Label4.Location = New System.Drawing.Point(462, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 38)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Joueur 4 :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(197, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Ajouter 1 point au joueur n°1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(197, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Ajouter 1 point au joueur n°2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 233)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(197, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Ajouter 1 point au joueur n°3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 357)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(197, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Ajouter 1 point au joueur n°4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Conteur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 392)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Conteur"
        Me.Text = "Conteur de point"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
