<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROFORMER
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
        Me.gridproformer = New System.Windows.Forms.DataGridView()
        Me.Ajouter = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbnumprof = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBTYP = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBFOUR = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Lbnom = New System.Windows.Forms.Label()
        Me.LBNUM = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.gridproformer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridproformer
        '
        Me.gridproformer.AllowUserToAddRows = False
        Me.gridproformer.AllowUserToDeleteRows = False
        Me.gridproformer.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.gridproformer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridproformer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ajouter, Me.Quantite, Me.pu})
        Me.gridproformer.Location = New System.Drawing.Point(17, 73)
        Me.gridproformer.Name = "gridproformer"
        Me.gridproformer.Size = New System.Drawing.Size(464, 224)
        Me.gridproformer.TabIndex = 0
        '
        'Ajouter
        '
        Me.Ajouter.HeaderText = "Ajouter"
        Me.Ajouter.Name = "Ajouter"
        '
        'Quantite
        '
        Me.Quantite.HeaderText = "Quantité"
        Me.Quantite.Name = "Quantite"
        '
        'pu
        '
        Me.pu.HeaderText = "Prix Unitaire"
        Me.pu.Name = "pu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(53, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&PROFORMA:"
        '
        'lbnumprof
        '
        Me.lbnumprof.AutoSize = True
        Me.lbnumprof.BackColor = System.Drawing.Color.Transparent
        Me.lbnumprof.Location = New System.Drawing.Point(130, 20)
        Me.lbnumprof.Name = "lbnumprof"
        Me.lbnumprof.Size = New System.Drawing.Size(0, 13)
        Me.lbnumprof.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(323, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&TYPE:"
        '
        'LBTYP
        '
        Me.LBTYP.AutoSize = True
        Me.LBTYP.BackColor = System.Drawing.Color.Transparent
        Me.LBTYP.Location = New System.Drawing.Point(361, 20)
        Me.LBTYP.Name = "LBTYP"
        Me.LBTYP.Size = New System.Drawing.Size(0, 13)
        Me.LBTYP.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(150, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "&FOURNISSEUR:"
        '
        'LBFOUR
        '
        Me.LBFOUR.AutoSize = True
        Me.LBFOUR.BackColor = System.Drawing.Color.Transparent
        Me.LBFOUR.Location = New System.Drawing.Point(238, 46)
        Me.LBFOUR.Name = "LBFOUR"
        Me.LBFOUR.Size = New System.Drawing.Size(0, 13)
        Me.LBFOUR.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.VUES.My.Resources.Resources.enreg3
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(174, 303)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 29)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Lbnom
        '
        Me.Lbnom.AutoSize = True
        Me.Lbnom.Location = New System.Drawing.Point(458, 13)
        Me.Lbnom.Name = "Lbnom"
        Me.Lbnom.Size = New System.Drawing.Size(0, 13)
        Me.Lbnom.TabIndex = 10
        '
        'LBNUM
        '
        Me.LBNUM.AutoSize = True
        Me.LBNUM.Location = New System.Drawing.Point(424, 30)
        Me.LBNUM.Name = "LBNUM"
        Me.LBNUM.Size = New System.Drawing.Size(0, 13)
        Me.LBNUM.TabIndex = 11
        Me.LBNUM.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.VUES.My.Resources.Resources.annuler3
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(255, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 29)
        Me.Button1.TabIndex = 12
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PROFORMER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.VUES.My.Resources.Resources.bgTec
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(504, 339)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LBNUM)
        Me.Controls.Add(Me.Lbnom)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LBTYP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbnumprof)
        Me.Controls.Add(Me.LBFOUR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridproformer)
        Me.DoubleBuffered = True
        Me.Name = "PROFORMER"
        Me.Text = "PROFORMER"
        CType(Me.gridproformer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridproformer As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbnumprof As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBTYP As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LBFOUR As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Lbnom As System.Windows.Forms.Label
    Friend WithEvents LBNUM As System.Windows.Forms.Label
    Friend WithEvents Ajouter As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Quantite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
