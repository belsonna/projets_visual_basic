<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MISAJOURfournisseur
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.FOURNISSEURBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.FOURNISSEURBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FOURNISSEURBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FOURNISSEURBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBNOMMISFOUR = New System.Windows.Forms.TextBox()
        Me.TBADRMISFOUR = New System.Windows.Forms.TextBox()
        Me.TBSIEMISFOUR = New System.Windows.Forms.TextBox()
        Me.FOURNISSEURTableAdapter = New LOCAL_BUYING_HOUSEDataSet1TableAdapters.FOURNISSEURTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TYPEPRODUITBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TYPEPRODUITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TYPEPRODUITTableAdapter = New LOCAL_BUYING_HOUSEDataSet1TableAdapters.TYPEPRODUITTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.FOURNISSEURBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FOURNISSEURBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FOURNISSEURBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FOURNISSEURBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TYPEPRODUITBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TYPEPRODUITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FOURNISSEURBindingSource3, "NomFour", True))
        Me.ComboBox1.DataSource = Me.FOURNISSEURBindingSource2
        Me.ComboBox1.DisplayMember = "NomFour"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(160, 70)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(435, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "NomFour"
        '
        'FOURNISSEURBindingSource3
        '
        Me.FOURNISSEURBindingSource3.DataMember = "FOURNISSEUR"
        Me.FOURNISSEURBindingSource3.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'LOCAL_BUYING_HOUSEDataSet1
        '
        Me.LOCAL_BUYING_HOUSEDataSet1.DataSetName = "LOCAL_BUYING_HOUSEDataSet1"
        Me.LOCAL_BUYING_HOUSEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FOURNISSEURBindingSource2
        '
        Me.FOURNISSEURBindingSource2.DataMember = "FOURNISSEUR"
        Me.FOURNISSEURBindingSource2.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'FOURNISSEURBindingSource1
        '
        Me.FOURNISSEURBindingSource1.DataMember = "FOURNISSEUR"
        Me.FOURNISSEURBindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'FOURNISSEURBindingSource
        '
        Me.FOURNISSEURBindingSource.DataMember = "FOURNISSEUR"
        Me.FOURNISSEURBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Location = New System.Drawing.Point(646, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "SUPPRIMER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Location = New System.Drawing.Point(646, 102)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 41)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "MODIFIER"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.Location = New System.Drawing.Point(264, 274)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "OK"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button4.Location = New System.Drawing.Point(389, 274)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "CANCEL"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(511, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MIS A JOUR FOURNISSEUR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "REMPLACER PAR:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(180, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NOM:"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(157, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ADRESSE:"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(180, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "SIEGE:"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(180, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "TYPE:"
        Me.Label6.Visible = False
        '
        'TBNOMMISFOUR
        '
        Me.TBNOMMISFOUR.Location = New System.Drawing.Point(225, 143)
        Me.TBNOMMISFOUR.Name = "TBNOMMISFOUR"
        Me.TBNOMMISFOUR.ReadOnly = True
        Me.TBNOMMISFOUR.Size = New System.Drawing.Size(310, 20)
        Me.TBNOMMISFOUR.TabIndex = 3
        Me.TBNOMMISFOUR.Visible = False
        '
        'TBADRMISFOUR
        '
        Me.TBADRMISFOUR.Location = New System.Drawing.Point(225, 170)
        Me.TBADRMISFOUR.Name = "TBADRMISFOUR"
        Me.TBADRMISFOUR.Size = New System.Drawing.Size(310, 20)
        Me.TBADRMISFOUR.TabIndex = 4
        Me.TBADRMISFOUR.Visible = False
        '
        'TBSIEMISFOUR
        '
        Me.TBSIEMISFOUR.Location = New System.Drawing.Point(225, 198)
        Me.TBSIEMISFOUR.Name = "TBSIEMISFOUR"
        Me.TBSIEMISFOUR.Size = New System.Drawing.Size(310, 20)
        Me.TBSIEMISFOUR.TabIndex = 4
        Me.TBSIEMISFOUR.Visible = False
        '
        'FOURNISSEURTableAdapter
        '
        Me.FOURNISSEURTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TYPEPRODUITBindingSource1, "Nomtype", True))
        Me.ComboBox2.DataSource = Me.TYPEPRODUITBindingSource
        Me.ComboBox2.DisplayMember = "Nomtype"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(225, 229)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(310, 21)
        Me.ComboBox2.TabIndex = 5
        Me.ComboBox2.ValueMember = "Nomtype"
        Me.ComboBox2.Visible = False
        '
        'TYPEPRODUITBindingSource1
        '
        Me.TYPEPRODUITBindingSource1.DataMember = "TYPEPRODUIT"
        Me.TYPEPRODUITBindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(119, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "NOM:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.TBSIEMISFOUR)
        Me.Panel1.Controls.Add(Me.TBADRMISFOUR)
        Me.Panel1.Controls.Add(Me.TBNOMMISFOUR)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Location = New System.Drawing.Point(41, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 399)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.vide_poubelle_icone_8363_128
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Location = New System.Drawing.Point(691, 150)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(182, 191)
        Me.Panel2.TabIndex = 6
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button5.Location = New System.Drawing.Point(20, 168)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(159, 23)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "RESTAURER"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'MISAJOURfournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.img_0314
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1012, 476)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "MISAJOURfournisseur"
        Me.Text = "MISAJOURFOURNISSEUR"
        CType(Me.FOURNISSEURBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FOURNISSEURBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FOURNISSEURBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FOURNISSEURBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TYPEPRODUITBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TYPEPRODUITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBNOMMISFOUR As System.Windows.Forms.TextBox
    Friend WithEvents TBADRMISFOUR As System.Windows.Forms.TextBox
    Friend WithEvents TBSIEMISFOUR As System.Windows.Forms.TextBox
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents FOURNISSEURBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FOURNISSEURTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.FOURNISSEURTableAdapter
    Friend WithEvents FOURNISSEURBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TYPEPRODUITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TYPEPRODUITTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.TYPEPRODUITTableAdapter
    Friend WithEvents TYPEPRODUITBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FOURNISSEURBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents FOURNISSEURBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
