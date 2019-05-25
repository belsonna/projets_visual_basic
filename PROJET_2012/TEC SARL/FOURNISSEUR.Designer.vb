<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FOURNISSEUR
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNOMFOU = New System.Windows.Forms.TextBox()
        Me.BTENRFOUR = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBADRFOU = New System.Windows.Forms.TextBox()
        Me.TBSIEFOU = New System.Windows.Forms.TextBox()
        Me.BTANUFOUR = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TYPEPRODUITBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.TYPEPRODUITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TYPEPRODUITTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.TYPEPRODUITTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.TYPEPRODUITBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TYPEPRODUITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NOM:"
        '
        'TBNOMFOU
        '
        Me.TBNOMFOU.Location = New System.Drawing.Point(139, 121)
        Me.TBNOMFOU.Name = "TBNOMFOU"
        Me.TBNOMFOU.Size = New System.Drawing.Size(342, 20)
        Me.TBNOMFOU.TabIndex = 1
        '
        'BTENRFOUR
        '
        Me.BTENRFOUR.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTENRFOUR.Location = New System.Drawing.Point(139, 333)
        Me.BTENRFOUR.Name = "BTENRFOUR"
        Me.BTENRFOUR.Size = New System.Drawing.Size(124, 39)
        Me.BTENRFOUR.TabIndex = 5
        Me.BTENRFOUR.Text = "ENREGISTRER"
        Me.BTENRFOUR.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(366, 42)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ENREGISTREMENT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ADRESSE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "SIEGE SOCIAL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(79, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "TYPE:"
        '
        'TBADRFOU
        '
        Me.TBADRFOU.Location = New System.Drawing.Point(139, 178)
        Me.TBADRFOU.Name = "TBADRFOU"
        Me.TBADRFOU.Size = New System.Drawing.Size(342, 20)
        Me.TBADRFOU.TabIndex = 2
        '
        'TBSIEFOU
        '
        Me.TBSIEFOU.Location = New System.Drawing.Point(139, 221)
        Me.TBSIEFOU.Name = "TBSIEFOU"
        Me.TBSIEFOU.Size = New System.Drawing.Size(342, 20)
        Me.TBSIEFOU.TabIndex = 3
        '
        'BTANUFOUR
        '
        Me.BTANUFOUR.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANUFOUR.Location = New System.Drawing.Point(369, 333)
        Me.BTANUFOUR.Name = "BTANUFOUR"
        Me.BTANUFOUR.Size = New System.Drawing.Size(112, 39)
        Me.BTANUFOUR.TabIndex = 6
        Me.BTANUFOUR.Text = "ANNULER"
        Me.BTANUFOUR.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TYPEPRODUITBindingSource1, "Nomtype", True))
        Me.ListBox1.DataSource = Me.TYPEPRODUITBindingSource
        Me.ListBox1.DisplayMember = "NomType"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(139, 262)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(341, 30)
        Me.ListBox1.TabIndex = 4
        Me.ListBox1.ValueMember = "NomType"
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
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.BTANUFOUR)
        Me.Panel1.Controls.Add(Me.BTENRFOUR)
        Me.Panel1.Controls.Add(Me.TBSIEFOU)
        Me.Panel1.Controls.Add(Me.TBADRFOU)
        Me.Panel1.Controls.Add(Me.TBNOMFOU)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(377, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 429)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.rocla_oyj_france_preparateur_de_commande_306276
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(-5, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(382, 428)
        Me.Panel2.TabIndex = 6
        '
        'FOURNISSEUR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1039, 541)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FOURNISSEUR"
        Me.Text = "FOURNISSEUR"
        CType(Me.TYPEPRODUITBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TYPEPRODUITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBNOMFOU As System.Windows.Forms.TextBox
    Friend WithEvents BTENRFOUR As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBADRFOU As System.Windows.Forms.TextBox
    Friend WithEvents TBSIEFOU As System.Windows.Forms.TextBox
    Friend WithEvents BTANUFOUR As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents TYPEPRODUITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TYPEPRODUITTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.TYPEPRODUITTableAdapter
    Friend WithEvents TYPEPRODUITBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
