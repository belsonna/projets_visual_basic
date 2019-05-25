<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCCorbeille
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCCorbeille))
        Me.gridcorbeille = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Cbrech = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btrestaure = New System.Windows.Forms.Button()
        CType(Me.gridcorbeille, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridcorbeille
        '
        Me.gridcorbeille.AllowUserToAddRows = False
        Me.gridcorbeille.AllowUserToDeleteRows = False
        Me.gridcorbeille.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.gridcorbeille.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridcorbeille.GridColor = System.Drawing.Color.White
        Me.gridcorbeille.Location = New System.Drawing.Point(202, 112)
        Me.gridcorbeille.Name = "gridcorbeille"
        Me.gridcorbeille.ReadOnly = True
        Me.gridcorbeille.Size = New System.Drawing.Size(593, 306)
        Me.gridcorbeille.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Cbrech)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(303, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 59)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "&Recherche"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(297, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "&OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cbrech
        '
        Me.Cbrech.FormattingEnabled = True
        Me.Cbrech.Items.AddRange(New Object() {"CLIENT", "FOURNISSEUR", "EMPLOYE"})
        Me.Cbrech.Location = New System.Drawing.Point(139, 18)
        Me.Cbrech.Name = "Cbrech"
        Me.Cbrech.Size = New System.Drawing.Size(152, 21)
        Me.Cbrech.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Choisissez une categorie:"
        '
        'btrestaure
        '
        Me.btrestaure.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btrestaure.BackgroundImage = CType(resources.GetObject("btrestaure.BackgroundImage"), System.Drawing.Image)
        Me.btrestaure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btrestaure.Enabled = False
        Me.btrestaure.Location = New System.Drawing.Point(744, 71)
        Me.btrestaure.Name = "btrestaure"
        Me.btrestaure.Size = New System.Drawing.Size(51, 35)
        Me.btrestaure.TabIndex = 11
        Me.btrestaure.UseVisualStyleBackColor = False
        '
        'UCCorbeille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.btrestaure)
        Me.Controls.Add(Me.gridcorbeille)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UCCorbeille"
        Me.Size = New System.Drawing.Size(941, 447)
        CType(Me.gridcorbeille, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridcorbeille As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cbrech As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btrestaure As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
