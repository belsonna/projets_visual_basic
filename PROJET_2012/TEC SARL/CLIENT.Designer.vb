<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CLIENT
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
        Me.TBNOMCLI = New System.Windows.Forms.TextBox()
        Me.BTENRCLI = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBADRCLI = New System.Windows.Forms.TextBox()
        Me.TBSIECLI = New System.Windows.Forms.TextBox()
        Me.BTANUCLI = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBNOMCLI
        '
        Me.TBNOMCLI.Location = New System.Drawing.Point(144, 109)
        Me.TBNOMCLI.Name = "TBNOMCLI"
        Me.TBNOMCLI.Size = New System.Drawing.Size(356, 20)
        Me.TBNOMCLI.TabIndex = 1
        '
        'BTENRCLI
        '
        Me.BTENRCLI.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTENRCLI.Location = New System.Drawing.Point(153, 352)
        Me.BTENRCLI.Name = "BTENRCLI"
        Me.BTENRCLI.Size = New System.Drawing.Size(113, 39)
        Me.BTENRCLI.TabIndex = 4
        Me.BTENRCLI.Text = "ENREGISTRER"
        Me.BTENRCLI.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 42)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ENREGISTREMENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SIEGE SOCIAL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ADRESSE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(89, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NOM:"
        '
        'TBADRCLI
        '
        Me.TBADRCLI.Location = New System.Drawing.Point(144, 193)
        Me.TBADRCLI.Name = "TBADRCLI"
        Me.TBADRCLI.Size = New System.Drawing.Size(356, 20)
        Me.TBADRCLI.TabIndex = 2
        '
        'TBSIECLI
        '
        Me.TBSIECLI.Location = New System.Drawing.Point(144, 267)
        Me.TBSIECLI.Name = "TBSIECLI"
        Me.TBSIECLI.Size = New System.Drawing.Size(356, 20)
        Me.TBSIECLI.TabIndex = 3
        '
        'BTANUCLI
        '
        Me.BTANUCLI.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANUCLI.Location = New System.Drawing.Point(364, 352)
        Me.BTANUCLI.Name = "BTANUCLI"
        Me.BTANUCLI.Size = New System.Drawing.Size(109, 39)
        Me.BTANUCLI.TabIndex = 5
        Me.BTANUCLI.Text = "ANNULER"
        Me.BTANUCLI.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.client
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(18, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 323)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BTANUCLI)
        Me.Panel2.Controls.Add(Me.BTENRCLI)
        Me.Panel2.Controls.Add(Me.TBSIECLI)
        Me.Panel2.Controls.Add(Me.TBADRCLI)
        Me.Panel2.Controls.Add(Me.TBNOMCLI)
        Me.Panel2.Location = New System.Drawing.Point(347, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(520, 430)
        Me.Panel2.TabIndex = 5
        '
        'CLIENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(886, 592)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CLIENT"
        Me.Text = "CLIENT"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TBNOMCLI As System.Windows.Forms.TextBox
    Friend WithEvents BTENRCLI As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBADRCLI As System.Windows.Forms.TextBox
    Friend WithEvents TBSIECLI As System.Windows.Forms.TextBox
    Friend WithEvents BTANUCLI As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
