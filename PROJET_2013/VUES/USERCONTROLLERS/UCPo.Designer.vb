<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCPo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCPo))
        Me.GbPO = New System.Windows.Forms.GroupBox()
        Me.Cbclient = New System.Windows.Forms.ComboBox()
        Me.Cbcot = New System.Windows.Forms.ComboBox()
        Me.Tbnum = New System.Windows.Forms.TextBox()
        Me.Tbmont = New System.Windows.Forms.TextBox()
        Me.tbobjet = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gridPO = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbrech = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.gbaction = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GbPO.SuspendLayout()
        CType(Me.gridPO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbaction.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbPO
        '
        Me.GbPO.Controls.Add(Me.Cbclient)
        Me.GbPO.Controls.Add(Me.Cbcot)
        Me.GbPO.Controls.Add(Me.Tbnum)
        Me.GbPO.Controls.Add(Me.Tbmont)
        Me.GbPO.Controls.Add(Me.tbobjet)
        Me.GbPO.Controls.Add(Me.Button2)
        Me.GbPO.Controls.Add(Me.Button1)
        Me.GbPO.Controls.Add(Me.Label6)
        Me.GbPO.Controls.Add(Me.Label2)
        Me.GbPO.Controls.Add(Me.Label3)
        Me.GbPO.Controls.Add(Me.Label5)
        Me.GbPO.Controls.Add(Me.Label1)
        Me.GbPO.Location = New System.Drawing.Point(545, 109)
        Me.GbPO.Name = "GbPO"
        Me.GbPO.Size = New System.Drawing.Size(365, 314)
        Me.GbPO.TabIndex = 13
        Me.GbPO.TabStop = False
        '
        'Cbclient
        '
        Me.Cbclient.FormattingEnabled = True
        Me.Cbclient.Location = New System.Drawing.Point(82, 110)
        Me.Cbclient.Name = "Cbclient"
        Me.Cbclient.Size = New System.Drawing.Size(264, 21)
        Me.Cbclient.TabIndex = 11
        '
        'Cbcot
        '
        Me.Cbcot.FormattingEnabled = True
        Me.Cbcot.Location = New System.Drawing.Point(81, 70)
        Me.Cbcot.Name = "Cbcot"
        Me.Cbcot.Size = New System.Drawing.Size(264, 21)
        Me.Cbcot.TabIndex = 11
        '
        'Tbnum
        '
        Me.Tbnum.Enabled = False
        Me.Tbnum.Location = New System.Drawing.Point(81, 31)
        Me.Tbnum.Name = "Tbnum"
        Me.Tbnum.Size = New System.Drawing.Size(264, 20)
        Me.Tbnum.TabIndex = 10
        '
        'Tbmont
        '
        Me.Tbmont.Location = New System.Drawing.Point(80, 244)
        Me.Tbmont.Name = "Tbmont"
        Me.Tbmont.Size = New System.Drawing.Size(266, 20)
        Me.Tbmont.TabIndex = 10
        '
        'tbobjet
        '
        Me.tbobjet.Location = New System.Drawing.Point(82, 159)
        Me.tbobjet.Name = "tbobjet"
        Me.tbobjet.Size = New System.Drawing.Size(264, 66)
        Me.tbobjet.TabIndex = 9
        Me.tbobjet.Text = ""
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.VUES.My.Resources.Resources.enreg3
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(134, 270)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 29)
        Me.Button2.TabIndex = 7
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.VUES.My.Resources.Resources.annuler3
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(260, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(79, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "&Montant:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Client:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Objet:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "&Cotation:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Numero:"
        '
        'gridPO
        '
        Me.gridPO.AllowUserToAddRows = False
        Me.gridPO.AllowUserToDeleteRows = False
        Me.gridPO.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.gridPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPO.GridColor = System.Drawing.Color.White
        Me.gridPO.Location = New System.Drawing.Point(31, 106)
        Me.gridPO.Name = "gridPO"
        Me.gridPO.ReadOnly = True
        Me.gridPO.Size = New System.Drawing.Size(508, 317)
        Me.gridPO.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbrech)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Location = New System.Drawing.Point(241, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 59)
        Me.GroupBox1.TabIndex = 10
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
        Me.gbaction.Controls.Add(Me.PictureBox3)
        Me.gbaction.Controls.Add(Me.PictureBox1)
        Me.gbaction.Controls.Add(Me.PictureBox5)
        Me.gbaction.Controls.Add(Me.PictureBox2)
        Me.gbaction.Location = New System.Drawing.Point(651, 71)
        Me.gbaction.Name = "gbaction"
        Me.gbaction.Size = New System.Drawing.Size(259, 32)
        Me.gbaction.TabIndex = 14
        Me.gbaction.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.VUES.My.Resources.Resources.modifier
        Me.PictureBox3.Location = New System.Drawing.Point(154, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VUES.My.Resources.Resources.icon_32_new
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(106, 7)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(56, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'UCPo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.gbaction)
        Me.Controls.Add(Me.GbPO)
        Me.Controls.Add(Me.gridPO)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCPo"
        Me.Size = New System.Drawing.Size(941, 447)
        Me.GbPO.ResumeLayout(False)
        Me.GbPO.PerformLayout()
        CType(Me.gridPO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbaction.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbPO As System.Windows.Forms.GroupBox
    Friend WithEvents Cbcot As System.Windows.Forms.ComboBox
    Friend WithEvents Tbnum As System.Windows.Forms.TextBox
    Friend WithEvents Tbmont As System.Windows.Forms.TextBox
    Friend WithEvents tbobjet As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gridPO As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbrech As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents gbaction As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Cbclient As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox

End Class
