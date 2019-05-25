<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCotation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCCotation))
        Me.gbaction = New System.Windows.Forms.GroupBox()
        Me.Gbcotation = New System.Windows.Forms.GroupBox()
        Me.Tbproj = New System.Windows.Forms.TextBox()
        Me.tblettre = New System.Windows.Forms.RichTextBox()
        Me.Tbnum = New System.Windows.Forms.TextBox()
        Me.Tbmont = New System.Windows.Forms.TextBox()
        Me.tbobjet = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridcotation = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbrech = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cbtaxe = New System.Windows.Forms.ComboBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btadd = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.gbaction.SuspendLayout()
        Me.Gbcotation.SuspendLayout()
        CType(Me.gridcotation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbaction
        '
        Me.gbaction.Controls.Add(Me.PictureBox4)
        Me.gbaction.Controls.Add(Me.PictureBox2)
        Me.gbaction.Location = New System.Drawing.Point(811, 71)
        Me.gbaction.Name = "gbaction"
        Me.gbaction.Size = New System.Drawing.Size(99, 32)
        Me.gbaction.TabIndex = 7
        Me.gbaction.TabStop = False
        '
        'Gbcotation
        '
        Me.Gbcotation.Controls.Add(Me.Cbtaxe)
        Me.Gbcotation.Controls.Add(Me.Label7)
        Me.Gbcotation.Controls.Add(Me.Tbproj)
        Me.Gbcotation.Controls.Add(Me.tblettre)
        Me.Gbcotation.Controls.Add(Me.Tbnum)
        Me.Gbcotation.Controls.Add(Me.Tbmont)
        Me.Gbcotation.Controls.Add(Me.tbobjet)
        Me.Gbcotation.Controls.Add(Me.Button2)
        Me.Gbcotation.Controls.Add(Me.Btadd)
        Me.Gbcotation.Controls.Add(Me.Button1)
        Me.Gbcotation.Controls.Add(Me.Label6)
        Me.Gbcotation.Controls.Add(Me.Label3)
        Me.Gbcotation.Controls.Add(Me.Label5)
        Me.Gbcotation.Controls.Add(Me.Label2)
        Me.Gbcotation.Controls.Add(Me.Label1)
        Me.Gbcotation.Location = New System.Drawing.Point(545, 109)
        Me.Gbcotation.Name = "Gbcotation"
        Me.Gbcotation.Size = New System.Drawing.Size(365, 316)
        Me.Gbcotation.TabIndex = 9
        Me.Gbcotation.TabStop = False
        '
        'Tbproj
        '
        Me.Tbproj.Enabled = False
        Me.Tbproj.Location = New System.Drawing.Point(82, 74)
        Me.Tbproj.Name = "Tbproj"
        Me.Tbproj.Size = New System.Drawing.Size(256, 20)
        Me.Tbproj.TabIndex = 10
        '
        'tblettre
        '
        Me.tblettre.Location = New System.Drawing.Point(80, 237)
        Me.tblettre.Name = "tblettre"
        Me.tblettre.Size = New System.Drawing.Size(258, 24)
        Me.tblettre.TabIndex = 9
        Me.tblettre.Text = ""
        '
        'Tbnum
        '
        Me.Tbnum.Enabled = False
        Me.Tbnum.Location = New System.Drawing.Point(82, 32)
        Me.Tbnum.Name = "Tbnum"
        Me.Tbnum.Size = New System.Drawing.Size(256, 20)
        Me.Tbnum.TabIndex = 10
        '
        'Tbmont
        '
        Me.Tbmont.Enabled = False
        Me.Tbmont.Location = New System.Drawing.Point(242, 198)
        Me.Tbmont.Name = "Tbmont"
        Me.Tbmont.Size = New System.Drawing.Size(71, 20)
        Me.Tbmont.TabIndex = 10
        Me.Tbmont.Text = "0"
        '
        'tbobjet
        '
        Me.tbobjet.Location = New System.Drawing.Point(80, 113)
        Me.tbobjet.Name = "tbobjet"
        Me.tbobjet.Size = New System.Drawing.Size(258, 66)
        Me.tbobjet.TabIndex = 9
        Me.tbobjet.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "&Montant:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Objet:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "&Projet:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Lettre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Numero:"
        '
        'gridcotation
        '
        Me.gridcotation.AllowUserToAddRows = False
        Me.gridcotation.AllowUserToDeleteRows = False
        Me.gridcotation.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.gridcotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridcotation.GridColor = System.Drawing.Color.White
        Me.gridcotation.Location = New System.Drawing.Point(31, 106)
        Me.gridcotation.Name = "gridcotation"
        Me.gridcotation.ReadOnly = True
        Me.gridcotation.Size = New System.Drawing.Size(508, 319)
        Me.gridcotation.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbrech)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Location = New System.Drawing.Point(241, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 59)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Recherche"
        '
        'tbrech
        '
        Me.tbrech.Location = New System.Drawing.Point(203, 19)
        Me.tbrech.Name = "tbrech"
        Me.tbrech.Size = New System.Drawing.Size(198, 20)
        Me.tbrech.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&Entrez le Numero de la Cotation:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "&Taxe:"
        '
        'Cbtaxe
        '
        Me.Cbtaxe.FormattingEnabled = True
        Me.Cbtaxe.Items.AddRange(New Object() {"0.1925", "0.165"})
        Me.Cbtaxe.Location = New System.Drawing.Point(82, 198)
        Me.Cbtaxe.Name = "Cbtaxe"
        Me.Cbtaxe.Size = New System.Drawing.Size(121, 21)
        Me.Cbtaxe.TabIndex = 12
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(59, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.VUES.My.Resources.Resources.enreg3
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(116, 281)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 29)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Btadd
        '
        Me.Btadd.BackgroundImage = CType(resources.GetObject("Btadd.BackgroundImage"), System.Drawing.Image)
        Me.Btadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btadd.Enabled = False
        Me.Btadd.Location = New System.Drawing.Point(314, 197)
        Me.Btadd.Name = "Btadd"
        Me.Btadd.Size = New System.Drawing.Size(24, 20)
        Me.Btadd.TabIndex = 6
        Me.Btadd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.VUES.My.Resources.Resources.annuler3
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(266, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
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
        'UCCotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.gbaction)
        Me.Controls.Add(Me.Gbcotation)
        Me.Controls.Add(Me.gridcotation)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCCotation"
        Me.Size = New System.Drawing.Size(941, 447)
        Me.gbaction.ResumeLayout(False)
        Me.Gbcotation.ResumeLayout(False)
        Me.Gbcotation.PerformLayout()
        CType(Me.gridcotation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbaction As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Gbcotation As System.Windows.Forms.GroupBox
    Friend WithEvents tbobjet As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gridcotation As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbrech As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Tbmont As System.Windows.Forms.TextBox
    Friend WithEvents Btadd As System.Windows.Forms.Button
    Friend WithEvents tblettre As System.Windows.Forms.RichTextBox
    Friend WithEvents Tbnum As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Tbproj As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cbtaxe As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
