<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LIVRAISON_TEC
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
        Me.BTENRLIVT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBNUMLIVT = New System.Windows.Forms.TextBox()
        Me.TBQTELIVT = New System.Windows.Forms.TextBox()
        Me.TBPULIVT = New System.Windows.Forms.TextBox()
        Me.BTANUENRLIVT = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.COMMANDECOTCOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.COMMANDECOTCOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMMANDECOTCOTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.COMMANDECOTCOTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PRODUITBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUITTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.PRODUITTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.COMMANDECOTCOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMMANDECOTCOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUITBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTENRLIVT
        '
        Me.BTENRLIVT.BackColor = System.Drawing.Color.DodgerBlue
        Me.BTENRLIVT.Location = New System.Drawing.Point(498, 389)
        Me.BTENRLIVT.Name = "BTENRLIVT"
        Me.BTENRLIVT.Size = New System.Drawing.Size(106, 49)
        Me.BTENRLIVT.TabIndex = 7
        Me.BTENRLIVT.Text = "ENREGISTRER"
        Me.BTENRLIVT.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-142, -39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENREGISTREMENT DE LA LIVRAISON TEC"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(358, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PO NUMERO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(383, 192)
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
        Me.Label4.Location = New System.Drawing.Point(293, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "NUMERO LIVRAISON:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(375, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "QUANTITE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(337, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "PRIX UNITAIRE:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(412, 339)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "DATE:"
        '
        'TBNUMLIVT
        '
        Me.TBNUMLIVT.Location = New System.Drawing.Point(474, 226)
        Me.TBNUMLIVT.Name = "TBNUMLIVT"
        Me.TBNUMLIVT.Size = New System.Drawing.Size(424, 20)
        Me.TBNUMLIVT.TabIndex = 3
        '
        'TBQTELIVT
        '
        Me.TBQTELIVT.Location = New System.Drawing.Point(474, 266)
        Me.TBQTELIVT.Name = "TBQTELIVT"
        Me.TBQTELIVT.Size = New System.Drawing.Size(424, 20)
        Me.TBQTELIVT.TabIndex = 4
        '
        'TBPULIVT
        '
        Me.TBPULIVT.Location = New System.Drawing.Point(474, 302)
        Me.TBPULIVT.Name = "TBPULIVT"
        Me.TBPULIVT.Size = New System.Drawing.Size(424, 20)
        Me.TBPULIVT.TabIndex = 5
        '
        'BTANUENRLIVT
        '
        Me.BTANUENRLIVT.BackColor = System.Drawing.Color.DodgerBlue
        Me.BTANUENRLIVT.Location = New System.Drawing.Point(791, 387)
        Me.BTANUENRLIVT.Name = "BTANUENRLIVT"
        Me.BTANUENRLIVT.Size = New System.Drawing.Size(105, 49)
        Me.BTANUENRLIVT.TabIndex = 8
        Me.BTANUENRLIVT.Text = "ANNULER"
        Me.BTANUENRLIVT.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.COMMANDECOTCOBindingSource1, "NumPO", True))
        Me.ComboBox1.DataSource = Me.COMMANDECOTCOBindingSource
        Me.ComboBox1.DisplayMember = "NumPO"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(474, 158)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(415, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "NumPO"
        '
        'COMMANDECOTCOBindingSource1
        '
        Me.COMMANDECOTCOBindingSource1.DataMember = "COMMANDECOTCO"
        Me.COMMANDECOTCOBindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'LOCAL_BUYING_HOUSEDataSet1
        '
        Me.LOCAL_BUYING_HOUSEDataSet1.DataSetName = "LOCAL_BUYING_HOUSEDataSet1"
        Me.LOCAL_BUYING_HOUSEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COMMANDECOTCOBindingSource
        '
        Me.COMMANDECOTCOBindingSource.DataMember = "COMMANDECOTCO"
        Me.COMMANDECOTCOBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'COMMANDECOTCOTableAdapter
        '
        Me.COMMANDECOTCOTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PRODUITBindingSource1, "NomPro", True))
        Me.ComboBox2.DataSource = Me.PRODUITBindingSource
        Me.ComboBox2.DisplayMember = "NomPro"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(474, 194)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(415, 21)
        Me.ComboBox2.TabIndex = 2
        Me.ComboBox2.ValueMember = "NomPro"
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(474, 339)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(424, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.livraire
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(12, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(285, 244)
        Me.Panel1.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(503, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(301, 39)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "LIVRAISON  TEC"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LIVRAISON_TEC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(908, 448)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TBPULIVT)
        Me.Controls.Add(Me.TBQTELIVT)
        Me.Controls.Add(Me.TBNUMLIVT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTANUENRLIVT)
        Me.Controls.Add(Me.BTENRLIVT)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "LIVRAISON_TEC"
        Me.Text = "LIVRAISON_TEC"
        CType(Me.COMMANDECOTCOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMMANDECOTCOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUITBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTENRLIVT As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TBNUMLIVT As System.Windows.Forms.TextBox
    Friend WithEvents TBQTELIVT As System.Windows.Forms.TextBox
    Friend WithEvents TBPULIVT As System.Windows.Forms.TextBox
    Friend WithEvents BTANUENRLIVT As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents COMMANDECOTCOTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.COMMANDECOTCOTableAdapter
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents PRODUITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PRODUITTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.PRODUITTableAdapter
    Friend WithEvents PRODUITBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents COMMANDECOTCOBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents COMMANDECOTCOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
