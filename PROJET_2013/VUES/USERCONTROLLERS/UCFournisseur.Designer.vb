<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCFournisseur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCFournisseur))
        Me.gbaction = New System.Windows.Forms.GroupBox()
        Me.Gbfournisseur = New System.Windows.Forms.GroupBox()
        Me.CbSec = New System.Windows.Forms.ComboBox()
        Me.TBsiege = New System.Windows.Forms.TextBox()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.TBAdresse = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Gridfournisseur = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBRECHF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.gbaction.SuspendLayout()
        Me.Gbfournisseur.SuspendLayout()
        CType(Me.Gridfournisseur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbaction
        '
        Me.gbaction.Controls.Add(Me.PictureBox4)
        Me.gbaction.Controls.Add(Me.PictureBox3)
        Me.gbaction.Controls.Add(Me.PictureBox2)
        Me.gbaction.Controls.Add(Me.PictureBox1)
        Me.gbaction.Location = New System.Drawing.Point(702, 101)
        Me.gbaction.Name = "gbaction"
        Me.gbaction.Size = New System.Drawing.Size(208, 32)
        Me.gbaction.TabIndex = 11
        Me.gbaction.TabStop = False
        '
        'Gbfournisseur
        '
        Me.Gbfournisseur.Controls.Add(Me.Button2)
        Me.Gbfournisseur.Controls.Add(Me.Button1)
        Me.Gbfournisseur.Controls.Add(Me.CbSec)
        Me.Gbfournisseur.Controls.Add(Me.TBsiege)
        Me.Gbfournisseur.Controls.Add(Me.TBNom)
        Me.Gbfournisseur.Controls.Add(Me.TBAdresse)
        Me.Gbfournisseur.Controls.Add(Me.Label7)
        Me.Gbfournisseur.Controls.Add(Me.Label5)
        Me.Gbfournisseur.Controls.Add(Me.Label3)
        Me.Gbfournisseur.Controls.Add(Me.Label2)
        Me.Gbfournisseur.Location = New System.Drawing.Point(434, 129)
        Me.Gbfournisseur.Name = "Gbfournisseur"
        Me.Gbfournisseur.Size = New System.Drawing.Size(476, 290)
        Me.Gbfournisseur.TabIndex = 14
        Me.Gbfournisseur.TabStop = False
        '
        'CbSec
        '
        Me.CbSec.Enabled = False
        Me.CbSec.FormattingEnabled = True
        Me.CbSec.Location = New System.Drawing.Point(90, 209)
        Me.CbSec.Name = "CbSec"
        Me.CbSec.Size = New System.Drawing.Size(331, 21)
        Me.CbSec.TabIndex = 3
        '
        'TBsiege
        '
        Me.TBsiege.Enabled = False
        Me.TBsiege.Location = New System.Drawing.Point(90, 150)
        Me.TBsiege.Name = "TBsiege"
        Me.TBsiege.Size = New System.Drawing.Size(331, 20)
        Me.TBsiege.TabIndex = 2
        '
        'TBNom
        '
        Me.TBNom.Enabled = False
        Me.TBNom.Location = New System.Drawing.Point(90, 32)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(331, 20)
        Me.TBNom.TabIndex = 2
        '
        'TBAdresse
        '
        Me.TBAdresse.Enabled = False
        Me.TBAdresse.Location = New System.Drawing.Point(90, 86)
        Me.TBAdresse.Name = "TBAdresse"
        Me.TBAdresse.Size = New System.Drawing.Size(331, 20)
        Me.TBAdresse.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(87, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "&Secteur:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(87, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "&Siège Social:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Adresse:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Nom:"
        '
        'Gridfournisseur
        '
        Me.Gridfournisseur.AllowUserToAddRows = False
        Me.Gridfournisseur.AllowUserToDeleteRows = False
        Me.Gridfournisseur.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.Gridfournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gridfournisseur.GridColor = System.Drawing.Color.White
        Me.Gridfournisseur.Location = New System.Drawing.Point(31, 101)
        Me.Gridfournisseur.Name = "Gridfournisseur"
        Me.Gridfournisseur.ReadOnly = True
        Me.Gridfournisseur.Size = New System.Drawing.Size(397, 318)
        Me.Gridfournisseur.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBRECHF)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Location = New System.Drawing.Point(231, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 59)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Recherche"
        '
        'TBRECHF
        '
        Me.TBRECHF.Location = New System.Drawing.Point(167, 19)
        Me.TBRECHF.Name = "TBRECHF"
        Me.TBRECHF.Size = New System.Drawing.Size(198, 20)
        Me.TBRECHF.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&Entrez le Nom:"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(174, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
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
        'Button2
        '
        Me.Button2.BackgroundImage = Global.VUES.My.Resources.Resources.enreg3
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(188, 245)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 29)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.VUES.My.Resources.Resources.annuler3
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(268, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.VUES.My.Resources.Resources.Research2
        Me.PictureBox7.Location = New System.Drawing.Point(371, 14)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'UCFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.gbaction)
        Me.Controls.Add(Me.Gbfournisseur)
        Me.Controls.Add(Me.Gridfournisseur)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCFournisseur"
        Me.Size = New System.Drawing.Size(941, 447)
        Me.gbaction.ResumeLayout(False)
        Me.Gbfournisseur.ResumeLayout(False)
        Me.Gbfournisseur.PerformLayout()
        CType(Me.Gridfournisseur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbaction As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Gbfournisseur As System.Windows.Forms.GroupBox
    Friend WithEvents CbSec As System.Windows.Forms.ComboBox
    Friend WithEvents TBsiege As System.Windows.Forms.TextBox
    Friend WithEvents TBNom As System.Windows.Forms.TextBox
    Friend WithEvents TBAdresse As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Gridfournisseur As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBRECHF As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
