<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TYPE_PRODUIT
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.TBNOMTYP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTENRTYP = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBDESTYP = New System.Windows.Forms.TextBox()
        Me.BTANUTYP = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBNOMTYP
        '
        Me.TBNOMTYP.Location = New System.Drawing.Point(124, 120)
        Me.TBNOMTYP.Name = "TBNOMTYP"
        Me.TBNOMTYP.Size = New System.Drawing.Size(346, 20)
        Me.TBNOMTYP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NOM:"
        '
        'BTENRTYP
        '
        Me.BTENRTYP.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTENRTYP.Location = New System.Drawing.Point(124, 305)
        Me.BTENRTYP.Name = "BTENRTYP"
        Me.BTENRTYP.Size = New System.Drawing.Size(114, 36)
        Me.BTENRTYP.TabIndex = 3
        Me.BTENRTYP.Text = "ENREGISTRER"
        Me.BTENRTYP.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(366, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ENREGISTREMENT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(381, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DESIGNATION:"
        '
        'TBDESTYP
        '
        Me.TBDESTYP.Location = New System.Drawing.Point(124, 202)
        Me.TBDESTYP.Name = "TBDESTYP"
        Me.TBDESTYP.Size = New System.Drawing.Size(346, 20)
        Me.TBDESTYP.TabIndex = 1
        '
        'BTANUTYP
        '
        Me.BTANUTYP.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANUTYP.Location = New System.Drawing.Point(319, 305)
        Me.BTANUTYP.Name = "BTANUTYP"
        Me.BTANUTYP.Size = New System.Drawing.Size(115, 36)
        Me.BTANUTYP.TabIndex = 3
        Me.BTANUTYP.Text = "ANNULER"
        Me.BTANUTYP.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.BTANUTYP)
        Me.Panel1.Controls.Add(Me.BTENRTYP)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TBDESTYP)
        Me.Panel1.Controls.Add(Me.TBNOMTYP)
        Me.Panel1.Location = New System.Drawing.Point(370, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 377)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.type_produit
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(20, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 356)
        Me.Panel2.TabIndex = 5
        '
        'TYPE_PRODUIT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(956, 573)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TYPE_PRODUIT"
        Me.Text = "TYPE_PRODUIT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBNOMTYP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTENRTYP As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBDESTYP As System.Windows.Forms.TextBox
    Friend WithEvents BTANUTYP As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
