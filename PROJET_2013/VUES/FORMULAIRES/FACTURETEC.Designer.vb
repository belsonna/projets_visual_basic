<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FACTURETEC
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Tbmont = New System.Windows.Forms.TextBox()
        Me.tbcom = New System.Windows.Forms.TextBox()
        Me.Tbfac = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBLETTRE = New System.Windows.Forms.RichTextBox()
        Me.tbcompte = New System.Windows.Forms.TextBox()
        Me.Tbbank = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.VUES.My.Resources.Resources.annuler3
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(169, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 29)
        Me.Button1.TabIndex = 24
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.VUES.My.Resources.Resources.enreg3
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(91, 322)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 29)
        Me.Button2.TabIndex = 23
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Tbmont
        '
        Me.Tbmont.Location = New System.Drawing.Point(38, 116)
        Me.Tbmont.Name = "Tbmont"
        Me.Tbmont.Size = New System.Drawing.Size(238, 20)
        Me.Tbmont.TabIndex = 21
        '
        'tbcom
        '
        Me.tbcom.Location = New System.Drawing.Point(38, 68)
        Me.tbcom.Name = "tbcom"
        Me.tbcom.Size = New System.Drawing.Size(238, 20)
        Me.tbcom.TabIndex = 22
        '
        'Tbfac
        '
        Me.Tbfac.Location = New System.Drawing.Point(38, 25)
        Me.Tbfac.Name = "Tbfac"
        Me.Tbfac.Size = New System.Drawing.Size(238, 20)
        Me.Tbfac.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(41, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "&Montant:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(35, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "&Commande:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(41, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "&Faccture :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(41, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "&lettre:"
        '
        'TBLETTRE
        '
        Me.TBLETTRE.Location = New System.Drawing.Point(38, 167)
        Me.TBLETTRE.Name = "TBLETTRE"
        Me.TBLETTRE.Size = New System.Drawing.Size(238, 54)
        Me.TBLETTRE.TabIndex = 25
        Me.TBLETTRE.Text = ""
        '
        'tbcompte
        '
        Me.tbcompte.Location = New System.Drawing.Point(38, 296)
        Me.tbcompte.Name = "tbcompte"
        Me.tbcompte.Size = New System.Drawing.Size(238, 20)
        Me.tbcompte.TabIndex = 29
        '
        'Tbbank
        '
        Me.Tbbank.Location = New System.Drawing.Point(38, 246)
        Me.Tbbank.Name = "Tbbank"
        Me.Tbbank.Size = New System.Drawing.Size(238, 20)
        Me.Tbbank.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(35, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "&Numero de Compte:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(35, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "&Banque :"
        '
        'FACTURETEC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VUES.My.Resources.Resources.bgTec
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(327, 363)
        Me.Controls.Add(Me.tbcompte)
        Me.Controls.Add(Me.Tbbank)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBLETTRE)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Tbmont)
        Me.Controls.Add(Me.tbcom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Tbfac)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FACTURETEC"
        Me.Text = "FACTURETEC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Tbmont As System.Windows.Forms.TextBox
    Friend WithEvents tbcom As System.Windows.Forms.TextBox
    Friend WithEvents Tbfac As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBLETTRE As System.Windows.Forms.RichTextBox
    Friend WithEvents tbcompte As System.Windows.Forms.TextBox
    Friend WithEvents Tbbank As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
