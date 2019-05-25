<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LIVRAISONTEC
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Ajouter = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Qteliv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBNUMLIV = New System.Windows.Forms.Label()
        Me.LBCOM = New System.Windows.Forms.Label()
        Me.LBPROF = New System.Windows.Forms.Label()
        Me.LBFOUR = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ajouter, Me.Qteliv})
        Me.DataGridView1.Location = New System.Drawing.Point(49, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(523, 233)
        Me.DataGridView1.TabIndex = 0
        '
        'Ajouter
        '
        Me.Ajouter.HeaderText = "Ajouter"
        Me.Ajouter.Name = "Ajouter"
        '
        'Qteliv
        '
        Me.Qteliv.HeaderText = "Quantité livrée"
        Me.Qteliv.Name = "Qteliv"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(50, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "COMMANDE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(52, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PROFORMA:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(333, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "FOURNISSEUR:"
        '
        'LBNUMLIV
        '
        Me.LBNUMLIV.AutoSize = True
        Me.LBNUMLIV.BackColor = System.Drawing.Color.Transparent
        Me.LBNUMLIV.Location = New System.Drawing.Point(533, 60)
        Me.LBNUMLIV.Name = "LBNUMLIV"
        Me.LBNUMLIV.Size = New System.Drawing.Size(39, 13)
        Me.LBNUMLIV.TabIndex = 1
        Me.LBNUMLIV.Text = "Label1"
        Me.LBNUMLIV.Visible = False
        '
        'LBCOM
        '
        Me.LBCOM.AutoSize = True
        Me.LBCOM.BackColor = System.Drawing.Color.Transparent
        Me.LBCOM.Location = New System.Drawing.Point(129, 15)
        Me.LBCOM.Name = "LBCOM"
        Me.LBCOM.Size = New System.Drawing.Size(39, 13)
        Me.LBCOM.TabIndex = 1
        Me.LBCOM.Text = "Label1"
        '
        'LBPROF
        '
        Me.LBPROF.AutoSize = True
        Me.LBPROF.BackColor = System.Drawing.Color.Transparent
        Me.LBPROF.Location = New System.Drawing.Point(129, 39)
        Me.LBPROF.Name = "LBPROF"
        Me.LBPROF.Size = New System.Drawing.Size(39, 13)
        Me.LBPROF.TabIndex = 1
        Me.LBPROF.Text = "Label1"
        '
        'LBFOUR
        '
        Me.LBFOUR.AutoSize = True
        Me.LBFOUR.BackColor = System.Drawing.Color.Transparent
        Me.LBFOUR.Location = New System.Drawing.Point(427, 15)
        Me.LBFOUR.Name = "LBFOUR"
        Me.LBFOUR.Size = New System.Drawing.Size(39, 13)
        Me.LBFOUR.TabIndex = 1
        Me.LBFOUR.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.VUES.My.Resources.Resources.annuler3
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(318, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 29)
        Me.Button1.TabIndex = 14
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.VUES.My.Resources.Resources.enreg3
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(237, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 29)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LIVRAISONTEC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.VUES.My.Resources.Resources.bgTec
        Me.ClientSize = New System.Drawing.Size(627, 356)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LBNUMLIV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LBFOUR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LBPROF)
        Me.Controls.Add(Me.LBCOM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "LIVRAISONTEC"
        Me.Text = "LIVRAISONTEC"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LBNUMLIV As System.Windows.Forms.Label
    Friend WithEvents LBCOM As System.Windows.Forms.Label
    Friend WithEvents LBPROF As System.Windows.Forms.Label
    Friend WithEvents LBFOUR As System.Windows.Forms.Label
    Friend WithEvents Ajouter As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Qteliv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
