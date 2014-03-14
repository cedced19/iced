<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calcul
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calcul))
        Me.TXT_CONSOMMATION = New System.Windows.Forms.TextBox()
        Me.TXT_NBKM = New System.Windows.Forms.TextBox()
        Me.TXT_PRIXESS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BT_CALCUL = New System.Windows.Forms.Button()
        Me.LBL_ERR = New System.Windows.Forms.Label()
        Me.LBL_COUT = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_CONSOMMATION
        '
        Me.TXT_CONSOMMATION.Location = New System.Drawing.Point(323, 71)
        Me.TXT_CONSOMMATION.Name = "TXT_CONSOMMATION"
        Me.TXT_CONSOMMATION.Size = New System.Drawing.Size(227, 20)
        Me.TXT_CONSOMMATION.TabIndex = 0
        '
        'TXT_NBKM
        '
        Me.TXT_NBKM.Location = New System.Drawing.Point(323, 97)
        Me.TXT_NBKM.Name = "TXT_NBKM"
        Me.TXT_NBKM.Size = New System.Drawing.Size(227, 20)
        Me.TXT_NBKM.TabIndex = 1
        '
        'TXT_PRIXESS
        '
        Me.TXT_PRIXESS.Location = New System.Drawing.Point(323, 123)
        Me.TXT_PRIXESS.Name = "TXT_PRIXESS"
        Me.TXT_PRIXESS.Size = New System.Drawing.Size(227, 20)
        Me.TXT_PRIXESS.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Consommation de la voiture (L/100km)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre de kilomètres (km)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Prix du litre d'essence (€/l)"
        '
        'BT_CALCUL
        '
        Me.BT_CALCUL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.BT_CALCUL.Location = New System.Drawing.Point(210, 225)
        Me.BT_CALCUL.Name = "BT_CALCUL"
        Me.BT_CALCUL.Size = New System.Drawing.Size(107, 37)
        Me.BT_CALCUL.TabIndex = 6
        Me.BT_CALCUL.Text = "Calculer"
        Me.BT_CALCUL.UseVisualStyleBackColor = True
        '
        'LBL_ERR
        '
        Me.LBL_ERR.AutoSize = True
        Me.LBL_ERR.BackColor = System.Drawing.Color.Transparent
        Me.LBL_ERR.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.LBL_ERR.Location = New System.Drawing.Point(143, 185)
        Me.LBL_ERR.Name = "LBL_ERR"
        Me.LBL_ERR.Size = New System.Drawing.Size(287, 25)
        Me.LBL_ERR.TabIndex = 7
        Me.LBL_ERR.Text = "N'écrivez pas n'import quoi !!"
        '
        'LBL_COUT
        '
        Me.LBL_COUT.AutoSize = True
        Me.LBL_COUT.BackColor = System.Drawing.Color.Transparent
        Me.LBL_COUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.LBL_COUT.Location = New System.Drawing.Point(38, 286)
        Me.LBL_COUT.Name = "LBL_COUT"
        Me.LBL_COUT.Size = New System.Drawing.Size(279, 25)
        Me.LBL_COUT.TabIndex = 8
        Me.LBL_COUT.Text = "Le cout du voyage sera de :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(495, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 51)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Calcul
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(562, 350)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LBL_COUT)
        Me.Controls.Add(Me.LBL_ERR)
        Me.Controls.Add(Me.BT_CALCUL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_PRIXESS)
        Me.Controls.Add(Me.TXT_NBKM)
        Me.Controls.Add(Me.TXT_CONSOMMATION)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calcul"
        Me.Text = "Calcules ton voyage"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_CONSOMMATION As System.Windows.Forms.TextBox
    Friend WithEvents TXT_NBKM As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PRIXESS As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BT_CALCUL As System.Windows.Forms.Button
    Friend WithEvents LBL_ERR As System.Windows.Forms.Label
    Friend WithEvents LBL_COUT As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
