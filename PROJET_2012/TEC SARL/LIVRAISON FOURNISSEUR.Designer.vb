<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LIVRAISON_FOURNISSEUR
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
        Me.BTENRLIVF = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTANULIVF = New System.Windows.Forms.Button()
        Me.TBNUMLIVF = New System.Windows.Forms.TextBox()
        Me.TBQTELIVF = New System.Windows.Forms.TextBox()
        Me.TBPULIVF = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.COMMANDETECBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.COMMANDETECBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMMANDETECTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.COMMANDETECTableAdapter()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.PRODUITBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUITTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.PRODUITTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.COMMANDETECBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMMANDETECBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUITBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTENRLIVF
        '
        Me.BTENRLIVF.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTENRLIVF.Location = New System.Drawing.Point(201, 242)
        Me.BTENRLIVF.Name = "BTENRLIVF"
        Me.BTENRLIVF.Size = New System.Drawing.Size(142, 38)
        Me.BTENRLIVF.TabIndex = 6
        Me.BTENRLIVF.Text = "ENREGISTRER"
        Me.BTENRLIVF.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "COMMANDE TEC NO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(982, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ENREGISTREMENT DE LA LIVRAISON  FOURNISSEUR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(79, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "PRODUIT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(71, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "QUANTITE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-5, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "NUMERO LIVRAISON:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "PRIX UNITAIRE:"
        '
        'BTANULIVF
        '
        Me.BTANULIVF.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANULIVF.Location = New System.Drawing.Point(398, 242)
        Me.BTANULIVF.Name = "BTANULIVF"
        Me.BTANULIVF.Size = New System.Drawing.Size(142, 38)
        Me.BTANULIVF.TabIndex = 7
        Me.BTANULIVF.Text = "ANNULER"
        Me.BTANULIVF.UseVisualStyleBackColor = False
        '
        'TBNUMLIVF
        '
        Me.TBNUMLIVF.Location = New System.Drawing.Point(176, 129)
        Me.TBNUMLIVF.Name = "TBNUMLIVF"
        Me.TBNUMLIVF.Size = New System.Drawing.Size(364, 20)
        Me.TBNUMLIVF.TabIndex = 3
        '
        'TBQTELIVF
        '
        Me.TBQTELIVF.Location = New System.Drawing.Point(176, 163)
        Me.TBQTELIVF.Name = "TBQTELIVF"
        Me.TBQTELIVF.Size = New System.Drawing.Size(364, 20)
        Me.TBQTELIVF.TabIndex = 4
        '
        'TBPULIVF
        '
        Me.TBPULIVF.Location = New System.Drawing.Point(177, 198)
        Me.TBPULIVF.Name = "TBPULIVF"
        Me.TBPULIVF.Size = New System.Drawing.Size(364, 20)
        Me.TBPULIVF.TabIndex = 5
        '
        'ListBox1
        '
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.COMMANDETECBindingSource1, "NumTec", True))
        Me.ListBox1.DataSource = Me.COMMANDETECBindingSource
        Me.ListBox1.DisplayMember = "NumTec"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(177, 36)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(363, 30)
        Me.ListBox1.TabIndex = 1
        Me.ListBox1.ValueMember = "NumTec"
        '
        'COMMANDETECBindingSource1
        '
        Me.COMMANDETECBindingSource1.DataMember = "COMMANDETEC"
        Me.COMMANDETECBindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'LOCAL_BUYING_HOUSEDataSet1
        '
        Me.LOCAL_BUYING_HOUSEDataSet1.DataSetName = "LOCAL_BUYING_HOUSEDataSet1"
        Me.LOCAL_BUYING_HOUSEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COMMANDETECBindingSource
        '
        Me.COMMANDETECBindingSource.DataMember = "COMMANDETEC"
        Me.COMMANDETECBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'COMMANDETECTableAdapter
        '
        Me.COMMANDETECTableAdapter.ClearBeforeFill = True
        '
        'ListBox2
        '
        Me.ListBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PRODUITBindingSource1, "NomPro", True))
        Me.ListBox2.DataSource = Me.PRODUITBindingSource
        Me.ListBox2.DisplayMember = "NomPro"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(177, 81)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(363, 30)
        Me.ListBox2.TabIndex = 2
        Me.ListBox2.ValueMember = "NomPro"
        '
        'PRODUITBindingSource1
        '
        Me.PRODUITBindingSource1.DataMember = "PRODUIT"
        Me.PRODUITBindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'PRODUITBindingSource
        '
        Me.PRODUITBindingSource.DataMember = "PRODUIT"
        Me.PRODUITBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'PRODUITTableAdapter
        '
        Me.PRODUITTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.livraison1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(-1, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 324)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ListBox2)
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TBPULIVF)
        Me.Panel2.Controls.Add(Me.TBQTELIVF)
        Me.Panel2.Controls.Add(Me.TBNUMLIVF)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BTANULIVF)
        Me.Panel2.Controls.Add(Me.BTENRLIVF)
        Me.Panel2.Location = New System.Drawing.Point(350, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(656, 337)
        Me.Panel2.TabIndex = 6
        '
        'LIVRAISON_FOURNISSEUR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1065, 549)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "LIVRAISON_FOURNISSEUR"
        Me.Text = "LIVRAISON_FOURNISSEUR"
        CType(Me.COMMANDETECBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMMANDETECBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUITBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTENRLIVF As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BTANULIVF As System.Windows.Forms.Button
    Friend WithEvents TBNUMLIVF As System.Windows.Forms.TextBox
    Friend WithEvents TBQTELIVF As System.Windows.Forms.TextBox
    Friend WithEvents TBPULIVF As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents COMMANDETECBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMMANDETECTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.COMMANDETECTableAdapter
    Friend WithEvents COMMANDETECBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents PRODUITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PRODUITTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.PRODUITTableAdapter
    Friend WithEvents PRODUITBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
