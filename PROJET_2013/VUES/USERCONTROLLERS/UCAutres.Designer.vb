<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCAutres
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCAutres))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Gbtype = New System.Windows.Forms.GroupBox()
        Me.Btenrgty = New System.Windows.Forms.Button()
        Me.Btanutyp = New System.Windows.Forms.Button()
        Me.TBcode = New System.Windows.Forms.TextBox()
        Me.TBinti = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbaction = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GridType = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Tbrechtyp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gbpro = New System.Windows.Forms.GroupBox()
        Me.Btenregpro = New System.Windows.Forms.Button()
        Me.Btanupro = New System.Windows.Forms.Button()
        Me.Cbtypepro = New System.Windows.Forms.ComboBox()
        Me.Tbpro = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.GridProduit = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Tbrechpro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.Gbtype.SuspendLayout()
        Me.gbaction.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbpro.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Gbtype)
        Me.GroupBox1.Controls.Add(Me.gbaction)
        Me.GroupBox1.Controls.Add(Me.GridType)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 402)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Gestion Type Produit"
        '
        'Gbtype
        '
        Me.Gbtype.Controls.Add(Me.Btenrgty)
        Me.Gbtype.Controls.Add(Me.Btanutyp)
        Me.Gbtype.Controls.Add(Me.TBcode)
        Me.Gbtype.Controls.Add(Me.TBinti)
        Me.Gbtype.Controls.Add(Me.Label3)
        Me.Gbtype.Controls.Add(Me.Label1)
        Me.Gbtype.Enabled = False
        Me.Gbtype.Location = New System.Drawing.Point(219, 203)
        Me.Gbtype.Name = "Gbtype"
        Me.Gbtype.Size = New System.Drawing.Size(206, 193)
        Me.Gbtype.TabIndex = 11
        Me.Gbtype.TabStop = False
        '
        'Btenrgty
        '
        Me.Btenrgty.BackgroundImage = Global.VUES.My.Resources.Resources.enreg3
        Me.Btenrgty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btenrgty.Location = New System.Drawing.Point(54, 149)
        Me.Btenrgty.Name = "Btenrgty"
        Me.Btenrgty.Size = New System.Drawing.Size(45, 29)
        Me.Btenrgty.TabIndex = 7
        Me.Btenrgty.UseVisualStyleBackColor = True
        '
        'Btanutyp
        '
        Me.Btanutyp.BackgroundImage = Global.VUES.My.Resources.Resources.annuler3
        Me.Btanutyp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btanutyp.Location = New System.Drawing.Point(128, 149)
        Me.Btanutyp.Name = "Btanutyp"
        Me.Btanutyp.Size = New System.Drawing.Size(45, 29)
        Me.Btanutyp.TabIndex = 6
        Me.Btanutyp.UseVisualStyleBackColor = True
        '
        'TBcode
        '
        Me.TBcode.Enabled = False
        Me.TBcode.Location = New System.Drawing.Point(26, 55)
        Me.TBcode.Name = "TBcode"
        Me.TBcode.Size = New System.Drawing.Size(168, 20)
        Me.TBcode.TabIndex = 2
        '
        'TBinti
        '
        Me.TBinti.Enabled = False
        Me.TBinti.Location = New System.Drawing.Point(26, 123)
        Me.TBinti.Name = "TBinti"
        Me.TBinti.Size = New System.Drawing.Size(168, 20)
        Me.TBinti.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Intitulé:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Code:"
        '
        'gbaction
        '
        Me.gbaction.Controls.Add(Me.PictureBox4)
        Me.gbaction.Controls.Add(Me.PictureBox5)
        Me.gbaction.Location = New System.Drawing.Point(329, 137)
        Me.gbaction.Name = "gbaction"
        Me.gbaction.Size = New System.Drawing.Size(84, 32)
        Me.gbaction.TabIndex = 15
        Me.gbaction.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(56, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.VUES.My.Resources.Resources.icon_32_new
        Me.PictureBox5.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'GridType
        '
        Me.GridType.AllowUserToAddRows = False
        Me.GridType.AllowUserToDeleteRows = False
        Me.GridType.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.GridType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridType.Location = New System.Drawing.Point(6, 128)
        Me.GridType.Name = "GridType"
        Me.GridType.ReadOnly = True
        Me.GridType.Size = New System.Drawing.Size(213, 268)
        Me.GridType.TabIndex = 14
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Tbrechtyp)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.PictureBox2)
        Me.GroupBox5.Location = New System.Drawing.Point(40, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(345, 59)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "&Recherche"
        '
        'Tbrechtyp
        '
        Me.Tbrechtyp.Location = New System.Drawing.Point(97, 24)
        Me.Tbrechtyp.Name = "Tbrechtyp"
        Me.Tbrechtyp.Size = New System.Drawing.Size(198, 20)
        Me.Tbrechtyp.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Entrez le Nom:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VUES.My.Resources.Resources.Research2
        Me.PictureBox2.Location = New System.Drawing.Point(301, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gbpro)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GridProduit)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(468, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 402)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Gestion produit"
        '
        'gbpro
        '
        Me.gbpro.Controls.Add(Me.Btenregpro)
        Me.gbpro.Controls.Add(Me.Btanupro)
        Me.gbpro.Controls.Add(Me.Cbtypepro)
        Me.gbpro.Controls.Add(Me.Tbpro)
        Me.gbpro.Controls.Add(Me.Label5)
        Me.gbpro.Controls.Add(Me.Label6)
        Me.gbpro.Enabled = False
        Me.gbpro.Location = New System.Drawing.Point(225, 183)
        Me.gbpro.Name = "gbpro"
        Me.gbpro.Size = New System.Drawing.Size(206, 213)
        Me.gbpro.TabIndex = 11
        Me.gbpro.TabStop = False
        '
        'Btenregpro
        '
        Me.Btenregpro.BackgroundImage = Global.VUES.My.Resources.Resources.enreg3
        Me.Btenregpro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btenregpro.Location = New System.Drawing.Point(54, 149)
        Me.Btenregpro.Name = "Btenregpro"
        Me.Btenregpro.Size = New System.Drawing.Size(45, 29)
        Me.Btenregpro.TabIndex = 7
        Me.Btenregpro.UseVisualStyleBackColor = True
        '
        'Btanupro
        '
        Me.Btanupro.BackgroundImage = Global.VUES.My.Resources.Resources.annuler3
        Me.Btanupro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btanupro.Location = New System.Drawing.Point(137, 149)
        Me.Btanupro.Name = "Btanupro"
        Me.Btanupro.Size = New System.Drawing.Size(45, 29)
        Me.Btanupro.TabIndex = 6
        Me.Btanupro.UseVisualStyleBackColor = True
        '
        'Cbtypepro
        '
        Me.Cbtypepro.DisplayMember = "Code"
        Me.Cbtypepro.FormattingEnabled = True
        Me.Cbtypepro.Location = New System.Drawing.Point(25, 122)
        Me.Cbtypepro.Name = "Cbtypepro"
        Me.Cbtypepro.Size = New System.Drawing.Size(169, 21)
        Me.Cbtypepro.TabIndex = 5
        Me.Cbtypepro.ValueMember = "Code"
        '
        'Tbpro
        '
        Me.Tbpro.Enabled = False
        Me.Tbpro.Location = New System.Drawing.Point(25, 48)
        Me.Tbpro.Name = "Tbpro"
        Me.Tbpro.Size = New System.Drawing.Size(169, 20)
        Me.Tbpro.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "&Nom:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox6)
        Me.GroupBox4.Controls.Add(Me.PictureBox9)
        Me.GroupBox4.Controls.Add(Me.PictureBox10)
        Me.GroupBox4.Location = New System.Drawing.Point(279, 137)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(152, 32)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(124, 6)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(71, 6)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 0
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = Global.VUES.My.Resources.Resources.icon_32_new
        Me.PictureBox10.Location = New System.Drawing.Point(18, 6)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 0
        Me.PictureBox10.TabStop = False
        '
        'GridProduit
        '
        Me.GridProduit.AllowUserToAddRows = False
        Me.GridProduit.AllowUserToDeleteRows = False
        Me.GridProduit.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.GridProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridProduit.Location = New System.Drawing.Point(6, 128)
        Me.GridProduit.Name = "GridProduit"
        Me.GridProduit.ReadOnly = True
        Me.GridProduit.Size = New System.Drawing.Size(213, 268)
        Me.GridProduit.TabIndex = 14
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Tbrechpro)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.PictureBox7)
        Me.GroupBox3.Location = New System.Drawing.Point(34, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(345, 59)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "&Recherche"
        '
        'Tbrechpro
        '
        Me.Tbrechpro.Location = New System.Drawing.Point(97, 24)
        Me.Tbrechpro.Name = "Tbrechpro"
        Me.Tbrechpro.Size = New System.Drawing.Size(198, 20)
        Me.Tbrechpro.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&Entrez le Nom:"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.VUES.My.Resources.Resources.Research2
        Me.PictureBox7.Location = New System.Drawing.Point(301, 18)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'UCAutres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCAutres"
        Me.Size = New System.Drawing.Size(941, 447)
        Me.GroupBox1.ResumeLayout(False)
        Me.Gbtype.ResumeLayout(False)
        Me.Gbtype.PerformLayout()
        Me.gbaction.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbpro.ResumeLayout(False)
        Me.gbpro.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridProduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Tbrechtyp As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Tbrechpro As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents GridType As System.Windows.Forms.DataGridView
    Friend WithEvents GridProduit As System.Windows.Forms.DataGridView
    Friend WithEvents gbaction As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents Gbtype As System.Windows.Forms.GroupBox
    Friend WithEvents TBcode As System.Windows.Forms.TextBox
    Friend WithEvents TBinti As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbpro As System.Windows.Forms.GroupBox
    Friend WithEvents Tbpro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cbtypepro As System.Windows.Forms.ComboBox
    Friend WithEvents Btenrgty As System.Windows.Forms.Button
    Friend WithEvents Btanutyp As System.Windows.Forms.Button
    Friend WithEvents Btenregpro As System.Windows.Forms.Button
    Friend WithEvents Btanupro As System.Windows.Forms.Button

End Class
