<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COTATION
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
        Me.BTENRCOT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTANUCOT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBNUMCOT = New System.Windows.Forms.TextBox()
        Me.TBOBJCOT = New System.Windows.Forms.TextBox()
        Me.DateCot = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTENRCOT
        '
        Me.BTENRCOT.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTENRCOT.Location = New System.Drawing.Point(549, 361)
        Me.BTENRCOT.Name = "BTENRCOT"
        Me.BTENRCOT.Size = New System.Drawing.Size(131, 36)
        Me.BTENRCOT.TabIndex = 4
        Me.BTENRCOT.Text = "ENREGISTRER"
        Me.BTENRCOT.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(399, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NUMERO:"
        '
        'BTANUCOT
        '
        Me.BTANUCOT.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANUCOT.Location = New System.Drawing.Point(757, 361)
        Me.BTANUCOT.Name = "BTANUCOT"
        Me.BTANUCOT.Size = New System.Drawing.Size(119, 36)
        Me.BTANUCOT.TabIndex = 5
        Me.BTANUCOT.Text = "ANNULER"
        Me.BTANUCOT.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENREGISTREMENT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "OBJET:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "DATE:"
        '
        'TBNUMCOT
        '
        Me.TBNUMCOT.Location = New System.Drawing.Point(83, 129)
        Me.TBNUMCOT.Name = "TBNUMCOT"
        Me.TBNUMCOT.Size = New System.Drawing.Size(460, 20)
        Me.TBNUMCOT.TabIndex = 1
        '
        'TBOBJCOT
        '
        Me.TBOBJCOT.Location = New System.Drawing.Point(83, 189)
        Me.TBOBJCOT.Name = "TBOBJCOT"
        Me.TBOBJCOT.Size = New System.Drawing.Size(460, 20)
        Me.TBOBJCOT.TabIndex = 2
        '
        'DateCot
        '
        Me.DateCot.Location = New System.Drawing.Point(84, 243)
        Me.DateCot.Name = "DateCot"
        Me.DateCot.Size = New System.Drawing.Size(459, 20)
        Me.DateCot.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.DateCot)
        Me.Panel1.Controls.Add(Me.TBOBJCOT)
        Me.Panel1.Controls.Add(Me.TBNUMCOT)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(406, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 391)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.contrat
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(13, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(380, 376)
        Me.Panel2.TabIndex = 7
        '
        'COTATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(956, 510)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BTANUCOT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTENRCOT)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "COTATION"
        Me.Text = "COTATION"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTENRCOT As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTANUCOT As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBNUMCOT As System.Windows.Forms.TextBox
    Friend WithEvents TBOBJCOT As System.Windows.Forms.TextBox
    Friend WithEvents DateCot As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
