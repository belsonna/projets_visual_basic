<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FACTURATION_TEC
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
        Me.BTENRFACT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNUMFACT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BTANUFACT = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CLIENTBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.CLIENTBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.CLIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.CLIENTTableAdapter()
        Me.PRODUITBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUITTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.PRODUITTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.COMMANDECOTCOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMMANDECOTCOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillBy1ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FillBy1ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.COMMANDECOTCOTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.COMMANDECOTCOTableAdapter()
        CType(Me.CLIENTBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUITBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.COMMANDECOTCOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMMANDECOTCOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy1ToolStrip.SuspendLayout()
        Me.FillBy1ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTENRFACT
        '
        Me.BTENRFACT.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTENRFACT.Location = New System.Drawing.Point(196, 281)
        Me.BTENRFACT.Name = "BTENRFACT"
        Me.BTENRFACT.Size = New System.Drawing.Size(98, 50)
        Me.BTENRFACT.TabIndex = 5
        Me.BTENRFACT.Text = "ENREGISTRER"
        Me.BTENRFACT.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NUMERO:"
        '
        'TBNUMFACT
        '
        Me.TBNUMFACT.Location = New System.Drawing.Point(148, 100)
        Me.TBNUMFACT.Name = "TBNUMFACT"
        Me.TBNUMFACT.Size = New System.Drawing.Size(408, 20)
        Me.TBNUMFACT.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(844, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ENREGISTREMENT DE LA FACTURATION TEC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "CLIENT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "PO NO:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(86, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "DATE:"
        '
        'BTANUFACT
        '
        Me.BTANUFACT.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANUFACT.Location = New System.Drawing.Point(408, 281)
        Me.BTANUFACT.Name = "BTANUFACT"
        Me.BTANUFACT.Size = New System.Drawing.Size(101, 50)
        Me.BTANUFACT.TabIndex = 6
        Me.BTANUFACT.Text = "ANNULER"
        Me.BTANUFACT.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CLIENTBindingSource3, "NomCli", True))
        Me.ListBox1.DataSource = Me.CLIENTBindingSource2
        Me.ListBox1.DisplayMember = "NomCli"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(148, 155)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(408, 30)
        Me.ListBox1.TabIndex = 3
        Me.ListBox1.ValueMember = "NomCli"
        '
        'CLIENTBindingSource3
        '
        Me.CLIENTBindingSource3.DataMember = "CLIENT"
        Me.CLIENTBindingSource3.DataSource = Me.LOCAL_BUYING_HOUSEDataSet
        '
        'LOCAL_BUYING_HOUSEDataSet
        '
        Me.LOCAL_BUYING_HOUSEDataSet.DataSetName = "LOCAL_BUYING_HOUSEDataSet"
        Me.LOCAL_BUYING_HOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLIENTBindingSource2
        '
        Me.CLIENTBindingSource2.DataMember = "CLIENT"
        Me.CLIENTBindingSource2.DataSource = Me.LOCAL_BUYING_HOUSEDataSet
        '
        'CLIENTBindingSource1
        '
        Me.CLIENTBindingSource1.DataMember = "CLIENT"
        Me.CLIENTBindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'LOCAL_BUYING_HOUSEDataSet1
        '
        Me.LOCAL_BUYING_HOUSEDataSet1.DataSetName = "LOCAL_BUYING_HOUSEDataSet1"
        Me.LOCAL_BUYING_HOUSEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLIENTBindingSource
        '
        Me.CLIENTBindingSource.DataMember = "CLIENT"
        Me.CLIENTBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'CLIENTTableAdapter
        '
        Me.CLIENTTableAdapter.ClearBeforeFill = True
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
        Me.DateTimePicker1.Location = New System.Drawing.Point(148, 206)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(408, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.facture
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(7, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 367)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.BTANUFACT)
        Me.Panel2.Controls.Add(Me.BTENRFACT)
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.TBNUMFACT)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(341, 114)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(654, 367)
        Me.Panel2.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.COMMANDECOTCOBindingSource1, "NumPO", True))
        Me.ComboBox1.DataSource = Me.COMMANDECOTCOBindingSource
        Me.ComboBox1.DisplayMember = "NumPO"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(148, 47)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(408, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "NumPO"
        '
        'COMMANDECOTCOBindingSource1
        '
        Me.COMMANDECOTCOBindingSource1.DataMember = "COMMANDECOTCO"
        Me.COMMANDECOTCOBindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet
        '
        'COMMANDECOTCOBindingSource
        '
        Me.COMMANDECOTCOBindingSource.DataMember = "COMMANDECOTCO"
        Me.COMMANDECOTCOBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(1063, 25)
        Me.FillBy1ToolStrip.TabIndex = 8
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Visible = False
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(45, 22)
        Me.FillBy1ToolStripButton.Text = "FillBy1"
        '
        'FillBy1ToolStrip1
        '
        Me.FillBy1ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy1ToolStripButton1})
        Me.FillBy1ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.FillBy1ToolStrip1.Name = "FillBy1ToolStrip1"
        Me.FillBy1ToolStrip1.Size = New System.Drawing.Size(1063, 25)
        Me.FillBy1ToolStrip1.TabIndex = 9
        Me.FillBy1ToolStrip1.Text = "FillBy1ToolStrip1"
        Me.FillBy1ToolStrip1.Visible = False
        '
        'FillBy1ToolStripButton1
        '
        Me.FillBy1ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton1.Name = "FillBy1ToolStripButton1"
        Me.FillBy1ToolStripButton1.Size = New System.Drawing.Size(45, 22)
        Me.FillBy1ToolStripButton1.Text = "FillBy1"
        '
        'COMMANDECOTCOTableAdapter
        '
        Me.COMMANDECOTCOTableAdapter.ClearBeforeFill = True
        '
        'FACTURATION_TEC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1063, 533)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Controls.Add(Me.FillBy1ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FACTURATION_TEC"
        Me.Text = "FACTURATION_TEC"
        CType(Me.CLIENTBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUITBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.COMMANDECOTCOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMMANDECOTCOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        Me.FillBy1ToolStrip1.ResumeLayout(False)
        Me.FillBy1ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTENRFACT As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBNUMFACT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BTANUFACT As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents CLIENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.CLIENTTableAdapter
    Friend WithEvents CLIENTBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PRODUITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PRODUITTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.PRODUITTableAdapter
    Friend WithEvents PRODUITBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents FillBy1ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillBy1ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents CLIENTBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents FillBy1ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents FillBy1ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents COMMANDECOTCOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMMANDECOTCOTableAdapter As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.COMMANDECOTCOTableAdapter
    Friend WithEvents COMMANDECOTCOBindingSource1 As System.Windows.Forms.BindingSource
End Class
