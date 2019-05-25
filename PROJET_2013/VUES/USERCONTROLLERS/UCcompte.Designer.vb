<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCcompte
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCcompte))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBRECH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Gbcompte = New System.Windows.Forms.GroupBox()
        Me.Btenreg = New System.Windows.Forms.Button()
        Me.Cbpri = New System.Windows.Forms.ComboBox()
        Me.cbpro = New System.Windows.Forms.ComboBox()
        Me.tbpass = New System.Windows.Forms.TextBox()
        Me.Pbanuler = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbaction = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gridcompte = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbcompte.SuspendLayout()
        CType(Me.Pbanuler, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbaction.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridcompte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBRECH)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Location = New System.Drawing.Point(228, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 59)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Recherche"
        '
        'TBRECH
        '
        Me.TBRECH.Location = New System.Drawing.Point(203, 19)
        Me.TBRECH.Name = "TBRECH"
        Me.TBRECH.Size = New System.Drawing.Size(198, 20)
        Me.TBRECH.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&Entrez le Nom du Proprietaire:"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.VUES.My.Resources.Resources.Research2
        Me.PictureBox7.Location = New System.Drawing.Point(410, 14)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'Gbcompte
        '
        Me.Gbcompte.Controls.Add(Me.Btenreg)
        Me.Gbcompte.Controls.Add(Me.Cbpri)
        Me.Gbcompte.Controls.Add(Me.cbpro)
        Me.Gbcompte.Controls.Add(Me.tbpass)
        Me.Gbcompte.Controls.Add(Me.Pbanuler)
        Me.Gbcompte.Controls.Add(Me.Label3)
        Me.Gbcompte.Controls.Add(Me.Label2)
        Me.Gbcompte.Controls.Add(Me.Label1)
        Me.Gbcompte.Enabled = False
        Me.Gbcompte.Location = New System.Drawing.Point(381, 127)
        Me.Gbcompte.Name = "Gbcompte"
        Me.Gbcompte.Size = New System.Drawing.Size(526, 285)
        Me.Gbcompte.TabIndex = 2
        Me.Gbcompte.TabStop = False
        '
        'Btenreg
        '
        Me.Btenreg.BackgroundImage = Global.VUES.My.Resources.Resources.enreg3
        Me.Btenreg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btenreg.Location = New System.Drawing.Point(176, 229)
        Me.Btenreg.Name = "Btenreg"
        Me.Btenreg.Size = New System.Drawing.Size(45, 29)
        Me.Btenreg.TabIndex = 6
        Me.Btenreg.UseVisualStyleBackColor = True
        '
        'Cbpri
        '
        Me.Cbpri.Enabled = False
        Me.Cbpri.FormattingEnabled = True
        Me.Cbpri.Items.AddRange(New Object() {"Administrateur", "Utilisateur"})
        Me.Cbpri.Location = New System.Drawing.Point(96, 181)
        Me.Cbpri.Name = "Cbpri"
        Me.Cbpri.Size = New System.Drawing.Size(268, 21)
        Me.Cbpri.TabIndex = 3
        '
        'cbpro
        '
        Me.cbpro.DisplayMember = "Nom"
        Me.cbpro.Enabled = False
        Me.cbpro.FormattingEnabled = True
        Me.cbpro.Location = New System.Drawing.Point(96, 52)
        Me.cbpro.Name = "cbpro"
        Me.cbpro.Size = New System.Drawing.Size(268, 21)
        Me.cbpro.TabIndex = 1
        Me.cbpro.ValueMember = "Nom"
        '
        'tbpass
        '
        Me.tbpass.Enabled = False
        Me.tbpass.Location = New System.Drawing.Point(96, 122)
        Me.tbpass.Name = "tbpass"
        Me.tbpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbpass.Size = New System.Drawing.Size(268, 20)
        Me.tbpass.TabIndex = 2
        '
        'Pbanuler
        '
        Me.Pbanuler.Enabled = False
        Me.Pbanuler.Image = Global.VUES.My.Resources.Resources.annuler3
        Me.Pbanuler.Location = New System.Drawing.Point(294, 229)
        Me.Pbanuler.Name = "Pbanuler"
        Me.Pbanuler.Size = New System.Drawing.Size(38, 29)
        Me.Pbanuler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbanuler.TabIndex = 4
        Me.Pbanuler.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Privilege:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(93, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Proprietaite:"
        '
        'gbaction
        '
        Me.gbaction.Controls.Add(Me.PictureBox3)
        Me.gbaction.Controls.Add(Me.PictureBox2)
        Me.gbaction.Controls.Add(Me.PictureBox1)
        Me.gbaction.Location = New System.Drawing.Point(750, 99)
        Me.gbaction.Name = "gbaction"
        Me.gbaction.Size = New System.Drawing.Size(157, 32)
        Me.gbaction.TabIndex = 0
        Me.gbaction.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.VUES.My.Resources.Resources.icon_32_remove
        Me.PictureBox3.Location = New System.Drawing.Point(120, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(71, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VUES.My.Resources.Resources.icon_32_new
        Me.PictureBox1.Location = New System.Drawing.Point(18, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'gridcompte
        '
        Me.gridcompte.AllowUserToAddRows = False
        Me.gridcompte.AllowUserToDeleteRows = False
        Me.gridcompte.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.gridcompte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridcompte.GridColor = System.Drawing.Color.White
        Me.gridcompte.Location = New System.Drawing.Point(28, 98)
        Me.gridcompte.Name = "gridcompte"
        Me.gridcompte.ReadOnly = True
        Me.gridcompte.Size = New System.Drawing.Size(347, 314)
        Me.gridcompte.TabIndex = 3
        '
        'UCcompte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.gridcompte)
        Me.Controls.Add(Me.gbaction)
        Me.Controls.Add(Me.Gbcompte)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCcompte"
        Me.Size = New System.Drawing.Size(941, 447)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbcompte.ResumeLayout(False)
        Me.Gbcompte.PerformLayout()
        CType(Me.Pbanuler, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbaction.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridcompte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Gbcompte As System.Windows.Forms.GroupBox
    Friend WithEvents gbaction As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Cbpri As System.Windows.Forms.ComboBox
    Friend WithEvents cbpro As System.Windows.Forms.ComboBox
    Friend WithEvents tbpass As System.Windows.Forms.TextBox
    Friend WithEvents Pbanuler As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBRECH As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents gridcompte As System.Windows.Forms.DataGridView
    Friend WithEvents Btenreg As System.Windows.Forms.Button

End Class
