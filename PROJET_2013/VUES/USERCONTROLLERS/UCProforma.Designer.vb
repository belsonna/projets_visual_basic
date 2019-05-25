<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCProforma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCProforma))
        Me.gbaction = New System.Windows.Forms.GroupBox()
        Me.Pbcom = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Gbproforma = New System.Windows.Forms.GroupBox()
        Me.Tbmont = New System.Windows.Forms.TextBox()
        Me.tbnum = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbcot = New System.Windows.Forms.ComboBox()
        Me.Cbproj = New System.Windows.Forms.ComboBox()
        Me.Cbfour = New System.Windows.Forms.ComboBox()
        Me.cbtyp = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gridproforma = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cbrech = New System.Windows.Forms.ComboBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.gbaction.SuspendLayout()
        CType(Me.Pbcom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbproforma.SuspendLayout()
        CType(Me.gridproforma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbaction
        '
        Me.gbaction.Controls.Add(Me.Pbcom)
        Me.gbaction.Controls.Add(Me.PictureBox3)
        Me.gbaction.Controls.Add(Me.PictureBox2)
        Me.gbaction.Controls.Add(Me.PictureBox1)
        Me.gbaction.Location = New System.Drawing.Point(684, 71)
        Me.gbaction.Name = "gbaction"
        Me.gbaction.Size = New System.Drawing.Size(226, 32)
        Me.gbaction.TabIndex = 11
        Me.gbaction.TabStop = False
        '
        'Pbcom
        '
        Me.Pbcom.Enabled = False
        Me.Pbcom.Image = Global.VUES.My.Resources.Resources.modifier
        Me.Pbcom.Location = New System.Drawing.Point(191, 6)
        Me.Pbcom.Name = "Pbcom"
        Me.Pbcom.Size = New System.Drawing.Size(30, 26)
        Me.Pbcom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbcom.TabIndex = 1
        Me.Pbcom.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(129, 6)
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
        'Gbproforma
        '
        Me.Gbproforma.Controls.Add(Me.Tbmont)
        Me.Gbproforma.Controls.Add(Me.tbnum)
        Me.Gbproforma.Controls.Add(Me.Button2)
        Me.Gbproforma.Controls.Add(Me.Button1)
        Me.Gbproforma.Controls.Add(Me.cbcot)
        Me.Gbproforma.Controls.Add(Me.Cbproj)
        Me.Gbproforma.Controls.Add(Me.Cbfour)
        Me.Gbproforma.Controls.Add(Me.cbtyp)
        Me.Gbproforma.Controls.Add(Me.Label5)
        Me.Gbproforma.Controls.Add(Me.Label8)
        Me.Gbproforma.Controls.Add(Me.Label6)
        Me.Gbproforma.Controls.Add(Me.Label7)
        Me.Gbproforma.Controls.Add(Me.Label1)
        Me.Gbproforma.Controls.Add(Me.Label2)
        Me.Gbproforma.Location = New System.Drawing.Point(545, 109)
        Me.Gbproforma.Name = "Gbproforma"
        Me.Gbproforma.Size = New System.Drawing.Size(365, 313)
        Me.Gbproforma.TabIndex = 13
        Me.Gbproforma.TabStop = False
        '
        'Tbmont
        '
        Me.Tbmont.Enabled = False
        Me.Tbmont.Location = New System.Drawing.Point(56, 252)
        Me.Tbmont.Name = "Tbmont"
        Me.Tbmont.Size = New System.Drawing.Size(258, 20)
        Me.Tbmont.TabIndex = 10
        '
        'tbnum
        '
        Me.tbnum.Enabled = False
        Me.tbnum.Location = New System.Drawing.Point(56, 35)
        Me.tbnum.Name = "tbnum"
        Me.tbnum.Size = New System.Drawing.Size(258, 20)
        Me.tbnum.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.VUES.My.Resources.Resources.enreg3
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(139, 278)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 29)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.VUES.My.Resources.Resources.annuler3
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(250, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbcot
        '
        Me.cbcot.Enabled = False
        Me.cbcot.FormattingEnabled = True
        Me.cbcot.Location = New System.Drawing.Point(56, 74)
        Me.cbcot.Name = "cbcot"
        Me.cbcot.Size = New System.Drawing.Size(258, 21)
        Me.cbcot.TabIndex = 1
        '
        'Cbproj
        '
        Me.Cbproj.Enabled = False
        Me.Cbproj.FormattingEnabled = True
        Me.Cbproj.Location = New System.Drawing.Point(56, 123)
        Me.Cbproj.Name = "Cbproj"
        Me.Cbproj.Size = New System.Drawing.Size(258, 21)
        Me.Cbproj.TabIndex = 1
        '
        'Cbfour
        '
        Me.Cbfour.Enabled = False
        Me.Cbfour.FormattingEnabled = True
        Me.Cbfour.Location = New System.Drawing.Point(56, 163)
        Me.Cbfour.Name = "Cbfour"
        Me.Cbfour.Size = New System.Drawing.Size(258, 21)
        Me.Cbfour.TabIndex = 1
        '
        'cbtyp
        '
        Me.cbtyp.Enabled = False
        Me.cbtyp.FormattingEnabled = True
        Me.cbtyp.Location = New System.Drawing.Point(56, 212)
        Me.cbtyp.Name = "cbtyp"
        Me.cbtyp.Size = New System.Drawing.Size(258, 21)
        Me.cbtyp.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "&Montant:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(55, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "&Cotation:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "&Projet:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "&Fournisseur:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Numero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&type:"
        '
        'gridproforma
        '
        Me.gridproforma.AllowUserToAddRows = False
        Me.gridproforma.AllowUserToDeleteRows = False
        Me.gridproforma.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.gridproforma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridproforma.GridColor = System.Drawing.Color.White
        Me.gridproforma.Location = New System.Drawing.Point(31, 106)
        Me.gridproforma.Name = "gridproforma"
        Me.gridproforma.ReadOnly = True
        Me.gridproforma.Size = New System.Drawing.Size(508, 316)
        Me.gridproforma.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cbrech)
        Me.GroupBox1.Controls.Add(Me.PictureBox6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Location = New System.Drawing.Point(206, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 59)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Recherche"
        '
        'Cbrech
        '
        Me.Cbrech.FormattingEnabled = True
        Me.Cbrech.Items.AddRange(New Object() {"Non Utilisé", "Utilisé"})
        Me.Cbrech.Location = New System.Drawing.Point(203, 18)
        Me.Cbrech.Name = "Cbrech"
        Me.Cbrech.Size = New System.Drawing.Size(201, 21)
        Me.Cbrech.TabIndex = 7
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(459, 13)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 6
        Me.PictureBox6.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&Entrez le Type:"
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
        'UCProforma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.gbaction)
        Me.Controls.Add(Me.Gbproforma)
        Me.Controls.Add(Me.gridproforma)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCProforma"
        Me.Size = New System.Drawing.Size(941, 447)
        Me.gbaction.ResumeLayout(False)
        CType(Me.Pbcom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbproforma.ResumeLayout(False)
        Me.Gbproforma.PerformLayout()
        CType(Me.gridproforma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbaction As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Gbproforma As System.Windows.Forms.GroupBox
    Friend WithEvents tbnum As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbtyp As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gridproforma As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Tbmont As System.Windows.Forms.TextBox
    Friend WithEvents cbcot As System.Windows.Forms.ComboBox
    Friend WithEvents Cbproj As System.Windows.Forms.ComboBox
    Friend WithEvents Cbfour As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Pbcom As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Cbrech As System.Windows.Forms.ComboBox

End Class
