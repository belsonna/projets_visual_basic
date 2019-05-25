<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCProjet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCProjet))
        Me.gbaction = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Gbprojet = New System.Windows.Forms.GroupBox()
        Me.tbnum = New System.Windows.Forms.TextBox()
        Me.tbdescription = New System.Windows.Forms.RichTextBox()
        Me.Datecre = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbcli = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gridprojet = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tbrech = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Pbcom = New System.Windows.Forms.PictureBox()
        Me.gbaction.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbprojet.SuspendLayout()
        CType(Me.gridprojet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pbcom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbaction
        '
        Me.gbaction.Controls.Add(Me.Pbcom)
        Me.gbaction.Controls.Add(Me.PictureBox5)
        Me.gbaction.Controls.Add(Me.PictureBox3)
        Me.gbaction.Controls.Add(Me.PictureBox2)
        Me.gbaction.Controls.Add(Me.PictureBox1)
        Me.gbaction.Location = New System.Drawing.Point(651, 71)
        Me.gbaction.Name = "gbaction"
        Me.gbaction.Size = New System.Drawing.Size(259, 32)
        Me.gbaction.TabIndex = 7
        Me.gbaction.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(175, 7)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.VUES.My.Resources.Resources.icon_32_remove
        Me.PictureBox3.Location = New System.Drawing.Point(118, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
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
        'Gbprojet
        '
        Me.Gbprojet.Controls.Add(Me.tbnum)
        Me.Gbprojet.Controls.Add(Me.tbdescription)
        Me.Gbprojet.Controls.Add(Me.Datecre)
        Me.Gbprojet.Controls.Add(Me.Button2)
        Me.Gbprojet.Controls.Add(Me.Button1)
        Me.Gbprojet.Controls.Add(Me.cbcli)
        Me.Gbprojet.Controls.Add(Me.Label5)
        Me.Gbprojet.Controls.Add(Me.Label3)
        Me.Gbprojet.Controls.Add(Me.Label1)
        Me.Gbprojet.Controls.Add(Me.Label2)
        Me.Gbprojet.Location = New System.Drawing.Point(545, 109)
        Me.Gbprojet.Name = "Gbprojet"
        Me.Gbprojet.Size = New System.Drawing.Size(365, 308)
        Me.Gbprojet.TabIndex = 9
        Me.Gbprojet.TabStop = False
        '
        'tbnum
        '
        Me.tbnum.Enabled = False
        Me.tbnum.Location = New System.Drawing.Point(87, 36)
        Me.tbnum.Name = "tbnum"
        Me.tbnum.Size = New System.Drawing.Size(253, 20)
        Me.tbnum.TabIndex = 10
        '
        'tbdescription
        '
        Me.tbdescription.Enabled = False
        Me.tbdescription.Location = New System.Drawing.Point(87, 84)
        Me.tbdescription.Name = "tbdescription"
        Me.tbdescription.Size = New System.Drawing.Size(252, 91)
        Me.tbdescription.TabIndex = 9
        Me.tbdescription.Text = ""
        '
        'Datecre
        '
        Me.Datecre.Enabled = False
        Me.Datecre.Location = New System.Drawing.Point(84, 234)
        Me.Datecre.Name = "Datecre"
        Me.Datecre.Size = New System.Drawing.Size(252, 20)
        Me.Datecre.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.VUES.My.Resources.Resources.enreg3
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(137, 260)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 29)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.VUES.My.Resources.Resources.annuler3
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(266, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbcli
        '
        Me.cbcli.Enabled = False
        Me.cbcli.FormattingEnabled = True
        Me.cbcli.Location = New System.Drawing.Point(87, 194)
        Me.cbcli.Name = "cbcli"
        Me.cbcli.Size = New System.Drawing.Size(249, 21)
        Me.cbcli.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "&Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Numero:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Client:"
        '
        'gridprojet
        '
        Me.gridprojet.AllowUserToAddRows = False
        Me.gridprojet.AllowUserToDeleteRows = False
        Me.gridprojet.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.gridprojet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridprojet.GridColor = System.Drawing.Color.White
        Me.gridprojet.Location = New System.Drawing.Point(31, 106)
        Me.gridprojet.Name = "gridprojet"
        Me.gridprojet.ReadOnly = True
        Me.gridprojet.Size = New System.Drawing.Size(508, 311)
        Me.gridprojet.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.Tbrech)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Location = New System.Drawing.Point(241, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 59)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Recherche"
        '
        'Tbrech
        '
        Me.Tbrech.Location = New System.Drawing.Point(203, 19)
        Me.Tbrech.Name = "Tbrech"
        Me.Tbrech.Size = New System.Drawing.Size(198, 20)
        Me.Tbrech.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&Entrez  le nom du client:"
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
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(460, 13)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'Pbcom
        '
        Me.Pbcom.Image = Global.VUES.My.Resources.Resources.modifier
        Me.Pbcom.Location = New System.Drawing.Point(229, 7)
        Me.Pbcom.Name = "Pbcom"
        Me.Pbcom.Size = New System.Drawing.Size(30, 26)
        Me.Pbcom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbcom.TabIndex = 10
        Me.Pbcom.TabStop = False
        '
        'UCProjet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.gbaction)
        Me.Controls.Add(Me.Gbprojet)
        Me.Controls.Add(Me.gridprojet)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCProjet"
        Me.Size = New System.Drawing.Size(941, 447)
        Me.gbaction.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbprojet.ResumeLayout(False)
        Me.Gbprojet.PerformLayout()
        CType(Me.gridprojet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pbcom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbaction As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Gbprojet As System.Windows.Forms.GroupBox
    Friend WithEvents tbnum As System.Windows.Forms.TextBox
    Friend WithEvents tbdescription As System.Windows.Forms.RichTextBox
    Friend WithEvents Datecre As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbcli As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gridprojet As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Tbrech As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Pbcom As System.Windows.Forms.PictureBox

End Class
