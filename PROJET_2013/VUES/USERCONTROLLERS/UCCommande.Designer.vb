<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCommande
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCCommande))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBRECH = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.gbaction = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Gbcommande = New System.Windows.Forms.GroupBox()
        Me.Tbnum = New System.Windows.Forms.TextBox()
        Me.tbobjet = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CBprof = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridcommande = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbaction.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbcommande.SuspendLayout()
        CType(Me.gridcommande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBRECH)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Location = New System.Drawing.Point(225, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 59)
        Me.GroupBox1.TabIndex = 1
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
        Me.Label4.Location = New System.Drawing.Point(35, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&Entrez le Numero de la Proforma:"
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
        'gbaction
        '
        Me.gbaction.Controls.Add(Me.PictureBox5)
        Me.gbaction.Controls.Add(Me.PictureBox1)
        Me.gbaction.Controls.Add(Me.PictureBox4)
        Me.gbaction.Controls.Add(Me.PictureBox2)
        Me.gbaction.Location = New System.Drawing.Point(683, 68)
        Me.gbaction.Name = "gbaction"
        Me.gbaction.Size = New System.Drawing.Size(211, 32)
        Me.gbaction.TabIndex = 3
        Me.gbaction.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(74, 7)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VUES.My.Resources.Resources.modifier
        Me.PictureBox1.Location = New System.Drawing.Point(175, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(127, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(17, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Gbcommande
        '
        Me.Gbcommande.Controls.Add(Me.Tbnum)
        Me.Gbcommande.Controls.Add(Me.tbobjet)
        Me.Gbcommande.Controls.Add(Me.Button2)
        Me.Gbcommande.Controls.Add(Me.Button1)
        Me.Gbcommande.Controls.Add(Me.CBprof)
        Me.Gbcommande.Controls.Add(Me.Label3)
        Me.Gbcommande.Controls.Add(Me.Label6)
        Me.Gbcommande.Controls.Add(Me.Label1)
        Me.Gbcommande.Location = New System.Drawing.Point(529, 106)
        Me.Gbcommande.Name = "Gbcommande"
        Me.Gbcommande.Size = New System.Drawing.Size(365, 315)
        Me.Gbcommande.TabIndex = 5
        Me.Gbcommande.TabStop = False
        '
        'Tbnum
        '
        Me.Tbnum.Location = New System.Drawing.Point(79, 32)
        Me.Tbnum.Name = "Tbnum"
        Me.Tbnum.Size = New System.Drawing.Size(256, 20)
        Me.Tbnum.TabIndex = 10
        '
        'tbobjet
        '
        Me.tbobjet.Location = New System.Drawing.Point(79, 165)
        Me.tbobjet.Name = "tbobjet"
        Me.tbobjet.Size = New System.Drawing.Size(256, 91)
        Me.tbobjet.TabIndex = 9
        Me.tbobjet.Text = ""
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.VUES.My.Resources.Resources.enreg3
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(125, 262)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 29)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.VUES.My.Resources.Resources.annuler3
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(252, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CBprof
        '
        Me.CBprof.Enabled = False
        Me.CBprof.FormattingEnabled = True
        Me.CBprof.Location = New System.Drawing.Point(79, 96)
        Me.CBprof.Name = "CBprof"
        Me.CBprof.Size = New System.Drawing.Size(256, 21)
        Me.CBprof.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Objet:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "&Numero:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Proforma:"
        '
        'gridcommande
        '
        Me.gridcommande.AllowUserToAddRows = False
        Me.gridcommande.AllowUserToDeleteRows = False
        Me.gridcommande.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.gridcommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridcommande.GridColor = System.Drawing.Color.White
        Me.gridcommande.Location = New System.Drawing.Point(15, 115)
        Me.gridcommande.Name = "gridcommande"
        Me.gridcommande.ReadOnly = True
        Me.gridcommande.Size = New System.Drawing.Size(508, 306)
        Me.gridcommande.TabIndex = 4
        '
        'UCCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.gbaction)
        Me.Controls.Add(Me.Gbcommande)
        Me.Controls.Add(Me.gridcommande)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCCommande"
        Me.Size = New System.Drawing.Size(941, 447)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbaction.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbcommande.ResumeLayout(False)
        Me.Gbcommande.PerformLayout()
        CType(Me.gridcommande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TBRECH As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents gbaction As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Gbcommande As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gridcommande As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CBprof As System.Windows.Forms.ComboBox
    Friend WithEvents tbobjet As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Tbnum As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
