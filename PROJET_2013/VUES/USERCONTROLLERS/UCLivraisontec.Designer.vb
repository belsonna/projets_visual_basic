﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCLivraisontec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCLivraisontec))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbrech = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Gridlivret = New System.Windows.Forms.DataGridView()
        Me.Pbimp = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gridlivret, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pbimp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbrech)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.PictureBox7)
        Me.GroupBox2.Location = New System.Drawing.Point(206, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(519, 53)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rechercher"
        '
        'tbrech
        '
        Me.tbrech.Location = New System.Drawing.Point(201, 18)
        Me.tbrech.Name = "tbrech"
        Me.tbrech.Size = New System.Drawing.Size(198, 20)
        Me.tbrech.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "&Entrez le Numero de la commande:"
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.VUES.My.Resources.Resources.Research2
        Me.PictureBox7.Location = New System.Drawing.Point(405, 13)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(33, 26)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 2
        Me.PictureBox7.TabStop = False
        '
        'Gridlivret
        '
        Me.Gridlivret.AllowUserToAddRows = False
        Me.Gridlivret.AllowUserToDeleteRows = False
        Me.Gridlivret.BackgroundColor = System.Drawing.Color.MediumTurquoise
        Me.Gridlivret.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gridlivret.Location = New System.Drawing.Point(184, 137)
        Me.Gridlivret.Name = "Gridlivret"
        Me.Gridlivret.ReadOnly = True
        Me.Gridlivret.Size = New System.Drawing.Size(557, 282)
        Me.Gridlivret.TabIndex = 3
        '
        'Pbimp
        '
        Me.Pbimp.Enabled = False
        Me.Pbimp.Image = CType(resources.GetObject("Pbimp.Image"), System.Drawing.Image)
        Me.Pbimp.Location = New System.Drawing.Point(711, 105)
        Me.Pbimp.Name = "Pbimp"
        Me.Pbimp.Size = New System.Drawing.Size(30, 26)
        Me.Pbimp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbimp.TabIndex = 5
        Me.Pbimp.TabStop = False
        '
        'UCLivraisontec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Pbimp)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Gridlivret)
        Me.Name = "UCLivraisontec"
        Me.Size = New System.Drawing.Size(941, 447)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gridlivret, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pbimp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tbrech As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Gridlivret As System.Windows.Forms.DataGridView
    Friend WithEvents Pbimp As System.Windows.Forms.PictureBox

End Class