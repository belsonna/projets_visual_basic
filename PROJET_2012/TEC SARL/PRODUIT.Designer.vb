<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRODUIT
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
        Me.components = New System.ComponentModel.Container()
        Me.BTENRPRO = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBNOMPRO = New System.Windows.Forms.TextBox()
        Me.BTANUPRO = New System.Windows.Forms.Button()
        Me.LBSSECPRO = New System.Windows.Forms.ListBox()
        Me.TYPEPRODUITBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.TYPEPRODUITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TYPEPRODUITTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.TYPEPRODUITTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.TYPEPRODUITBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TYPEPRODUITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTENRPRO
        '
        Me.BTENRPRO.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTENRPRO.Location = New System.Drawing.Point(102, 262)
        Me.BTENRPRO.Name = "BTENRPRO"
        Me.BTENRPRO.Size = New System.Drawing.Size(110, 34)
        Me.BTENRPRO.TabIndex = 0
        Me.BTENRPRO.Text = "ENREGISTRER"
        Me.BTENRPRO.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENREGISTREMENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOM:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "SECTEUR:"
        '
        'TBNOMPRO
        '
        Me.TBNOMPRO.Location = New System.Drawing.Point(102, 122)
        Me.TBNOMPRO.Name = "TBNOMPRO"
        Me.TBNOMPRO.Size = New System.Drawing.Size(317, 20)
        Me.TBNOMPRO.TabIndex = 2
        '
        'BTANUPRO
        '
        Me.BTANUPRO.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANUPRO.Location = New System.Drawing.Point(296, 262)
        Me.BTANUPRO.Name = "BTANUPRO"
        Me.BTANUPRO.Size = New System.Drawing.Size(106, 34)
        Me.BTANUPRO.TabIndex = 0
        Me.BTANUPRO.Text = "ANNULER"
        Me.BTANUPRO.UseVisualStyleBackColor = False
        '
        'LBSSECPRO
        '
        Me.LBSSECPRO.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TYPEPRODUITBindingSource1, "Nomtype", True))
        Me.LBSSECPRO.DataSource = Me.TYPEPRODUITBindingSource
        Me.LBSSECPRO.DisplayMember = "NomType"
        Me.LBSSECPRO.FormattingEnabled = True
        Me.LBSSECPRO.Location = New System.Drawing.Point(113, 175)
        Me.LBSSECPRO.Name = "LBSSECPRO"
        Me.LBSSECPRO.Size = New System.Drawing.Size(306, 30)
        Me.LBSSECPRO.TabIndex = 4
        Me.LBSSECPRO.ValueMember = "NomType"
        '
        'TYPEPRODUITBindingSource1
        '
        Me.TYPEPRODUITBindingSource1.DataMember = "TYPEPRODUIT"
        Me.TYPEPRODUITBindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'LOCAL_BUYING_HOUSEDataSet1
        '
        Me.LOCAL_BUYING_HOUSEDataSet1.DataSetName = "LOCAL_BUYING_HOUSEDataSet1"
        Me.LOCAL_BUYING_HOUSEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TYPEPRODUITBindingSource
        '
        Me.TYPEPRODUITBindingSource.DataMember = "TYPEPRODUIT"
        Me.TYPEPRODUITBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'TYPEPRODUITTableAdapter
        '
        Me.TYPEPRODUITTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.prod
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(13, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 211)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.LBSSECPRO)
        Me.Panel2.Controls.Add(Me.TBNOMPRO)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BTANUPRO)
        Me.Panel2.Controls.Add(Me.BTENRPRO)
        Me.Panel2.Location = New System.Drawing.Point(334, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(491, 338)
        Me.Panel2.TabIndex = 6
        '
        'PRODUIT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(849, 519)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PRODUIT"
        Me.Text = "PRODUIT"
        CType(Me.TYPEPRODUITBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TYPEPRODUITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTENRPRO As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBNOMPRO As System.Windows.Forms.TextBox
    Friend WithEvents BTANUPRO As System.Windows.Forms.Button
    Friend WithEvents LBSSECPRO As System.Windows.Forms.ListBox
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents TYPEPRODUITTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.TYPEPRODUITTableAdapter
    Friend WithEvents TYPEPRODUITBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TYPEPRODUITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
