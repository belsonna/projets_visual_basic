<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCEmploye
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCEmploye))
        Me.gbaction = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GbEmploye = New System.Windows.Forms.GroupBox()
        Me.BTAnu = New System.Windows.Forms.Button()
        Me.BTEnreg = New System.Windows.Forms.Button()
        Me.DPNaiss = New System.Windows.Forms.DateTimePicker()
        Me.CbSer = New System.Windows.Forms.ComboBox()
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.TBCNI = New System.Windows.Forms.TextBox()
        Me.TBAdresse = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridEmploye = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tbrech = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.gbaction.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbEmploye.SuspendLayout()
        CType(Me.GridEmploye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbaction
        '
        Me.gbaction.Controls.Add(Me.PictureBox5)
        Me.gbaction.Controls.Add(Me.PictureBox4)
        Me.gbaction.Controls.Add(Me.PictureBox3)
        Me.gbaction.Controls.Add(Me.PictureBox2)
        Me.gbaction.Controls.Add(Me.PictureBox1)
        Me.gbaction.Location = New System.Drawing.Point(641, 90)
        Me.gbaction.Name = "gbaction"
        Me.gbaction.Size = New System.Drawing.Size(274, 32)
        Me.gbaction.TabIndex = 3
        Me.gbaction.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.VUES.My.Resources.Resources.modifier
        Me.PictureBox5.Location = New System.Drawing.Point(227, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
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
        'GbEmploye
        '
        Me.GbEmploye.Controls.Add(Me.BTAnu)
        Me.GbEmploye.Controls.Add(Me.BTEnreg)
        Me.GbEmploye.Controls.Add(Me.DPNaiss)
        Me.GbEmploye.Controls.Add(Me.CbSer)
        Me.GbEmploye.Controls.Add(Me.TBEmail)
        Me.GbEmploye.Controls.Add(Me.TBNom)
        Me.GbEmploye.Controls.Add(Me.TBCNI)
        Me.GbEmploye.Controls.Add(Me.TBAdresse)
        Me.GbEmploye.Controls.Add(Me.Label7)
        Me.GbEmploye.Controls.Add(Me.Label6)
        Me.GbEmploye.Controls.Add(Me.Label5)
        Me.GbEmploye.Controls.Add(Me.Label3)
        Me.GbEmploye.Controls.Add(Me.Label2)
        Me.GbEmploye.Controls.Add(Me.Label1)
        Me.GbEmploye.Enabled = False
        Me.GbEmploye.Location = New System.Drawing.Point(503, 128)
        Me.GbEmploye.Name = "GbEmploye"
        Me.GbEmploye.Size = New System.Drawing.Size(456, 294)
        Me.GbEmploye.TabIndex = 6
        Me.GbEmploye.TabStop = False
        '
        'BTAnu
        '
        Me.BTAnu.Image = Global.VUES.My.Resources.Resources.annuler3
        Me.BTAnu.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTAnu.Location = New System.Drawing.Point(209, 246)
        Me.BTAnu.Name = "BTAnu"
        Me.BTAnu.Size = New System.Drawing.Size(88, 42)
        Me.BTAnu.TabIndex = 7
        Me.BTAnu.Text = "&Annuler"
        Me.BTAnu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTAnu.UseVisualStyleBackColor = True
        '
        'BTEnreg
        '
        Me.BTEnreg.Image = Global.VUES.My.Resources.Resources.enreg3
        Me.BTEnreg.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTEnreg.Location = New System.Drawing.Point(108, 246)
        Me.BTEnreg.Name = "BTEnreg"
        Me.BTEnreg.Size = New System.Drawing.Size(98, 42)
        Me.BTEnreg.TabIndex = 7
        Me.BTEnreg.Text = "&Enregistrer"
        Me.BTEnreg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTEnreg.UseVisualStyleBackColor = True
        '
        'DPNaiss
        '
        Me.DPNaiss.Location = New System.Drawing.Point(57, 180)
        Me.DPNaiss.Name = "DPNaiss"
        Me.DPNaiss.Size = New System.Drawing.Size(259, 20)
        Me.DPNaiss.TabIndex = 5
        '
        'CbSer
        '
        Me.CbSer.DisplayMember = "Proprietaire"
        Me.CbSer.Enabled = False
        Me.CbSer.FormattingEnabled = True
        Me.CbSer.Items.AddRange(New Object() {"Achat", "Employe", "Commercial", "Secretariat", "Technique"})
        Me.CbSer.Location = New System.Drawing.Point(59, 219)
        Me.CbSer.Name = "CbSer"
        Me.CbSer.Size = New System.Drawing.Size(257, 21)
        Me.CbSer.TabIndex = 3
        Me.CbSer.ValueMember = "Proprietaire"
        '
        'TBEmail
        '
        Me.TBEmail.Enabled = False
        Me.TBEmail.Location = New System.Drawing.Point(57, 141)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(259, 20)
        Me.TBEmail.TabIndex = 2
        '
        'TBNom
        '
        Me.TBNom.Enabled = False
        Me.TBNom.Location = New System.Drawing.Point(57, 66)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(256, 20)
        Me.TBNom.TabIndex = 2
        '
        'TBCNI
        '
        Me.TBCNI.Enabled = False
        Me.TBCNI.Location = New System.Drawing.Point(57, 27)
        Me.TBCNI.Name = "TBCNI"
        Me.TBCNI.Size = New System.Drawing.Size(256, 20)
        Me.TBCNI.TabIndex = 2
        '
        'TBAdresse
        '
        Me.TBAdresse.Enabled = False
        Me.TBAdresse.Location = New System.Drawing.Point(57, 102)
        Me.TBAdresse.Name = "TBAdresse"
        Me.TBAdresse.Size = New System.Drawing.Size(259, 20)
        Me.TBAdresse.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "&Service:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "&Date de Naissance:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "&Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Adresse:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Nom:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&CNI:"
        '
        'GridEmploye
        '
        Me.GridEmploye.AllowUserToAddRows = False
        Me.GridEmploye.AllowUserToDeleteRows = False
        Me.GridEmploye.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.GridEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridEmploye.GridColor = System.Drawing.Color.White
        Me.GridEmploye.Location = New System.Drawing.Point(31, 101)
        Me.GridEmploye.Name = "GridEmploye"
        Me.GridEmploye.ReadOnly = True
        Me.GridEmploye.Size = New System.Drawing.Size(466, 321)
        Me.GridEmploye.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tbrech)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Location = New System.Drawing.Point(231, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 59)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Recherche"
        '
        'Tbrech
        '
        Me.Tbrech.Location = New System.Drawing.Point(167, 19)
        Me.Tbrech.Name = "Tbrech"
        Me.Tbrech.Size = New System.Drawing.Size(198, 20)
        Me.Tbrech.TabIndex = 1
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
        'UCEmploye
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.gbaction)
        Me.Controls.Add(Me.GbEmploye)
        Me.Controls.Add(Me.GridEmploye)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCEmploye"
        Me.Size = New System.Drawing.Size(941, 447)
        Me.gbaction.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbEmploye.ResumeLayout(False)
        Me.GbEmploye.PerformLayout()
        CType(Me.GridEmploye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbaction As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GbEmploye As System.Windows.Forms.GroupBox
    Friend WithEvents CbSer As System.Windows.Forms.ComboBox
    Friend WithEvents TBAdresse As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridEmploye As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Tbrech As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents DPNaiss As System.Windows.Forms.DateTimePicker
    Friend WithEvents TBEmail As System.Windows.Forms.TextBox
    Friend WithEvents TBNom As System.Windows.Forms.TextBox
    Friend WithEvents TBCNI As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BTAnu As System.Windows.Forms.Button
    Friend WithEvents BTEnreg As System.Windows.Forms.Button

End Class
