<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONFIRMER
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
        Me.BTENRCON = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBSERCON = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTANUCON = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateCON = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMMANDECOTCOTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.COMMANDECOTCOTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.CLIENTBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.CLIENTTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTENRCON
        '
        Me.BTENRCON.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTENRCON.Location = New System.Drawing.Point(93, 311)
        Me.BTENRCON.Name = "BTENRCON"
        Me.BTENRCON.Size = New System.Drawing.Size(105, 54)
        Me.BTENRCON.TabIndex = 5
        Me.BTENRCON.Text = "ENREGISTRER"
        Me.BTENRCON.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SERVICE ENTRY:"
        '
        'TBSERCON
        '
        Me.TBSERCON.Location = New System.Drawing.Point(157, 111)
        Me.TBSERCON.Name = "TBSERCON"
        Me.TBSERCON.Size = New System.Drawing.Size(317, 20)
        Me.TBSERCON.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(366, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ENREGISTREMENT"
        '
        'BTANUCON
        '
        Me.BTANUCON.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANUCON.Location = New System.Drawing.Point(330, 311)
        Me.BTANUCON.Name = "BTANUCON"
        Me.BTANUCON.Size = New System.Drawing.Size(115, 54)
        Me.BTANUCON.TabIndex = 6
        Me.BTANUCON.Text = "ANNULER"
        Me.BTANUCON.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "PO NO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "CLIENT:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(95, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "DATE:"
        '
        'DateCON
        '
        Me.DateCON.Location = New System.Drawing.Point(157, 217)
        Me.DateCON.Name = "DateCON"
        Me.DateCON.Size = New System.Drawing.Size(317, 20)
        Me.DateCON.TabIndex = 4
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BindingSource2, "NumPO", True))
        Me.ComboBox1.DataSource = Me.BindingSource1
        Me.ComboBox1.DisplayMember = "NumPO"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(157, 136)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(317, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "NumPO"
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "COMMANDECOTCO"
        Me.BindingSource2.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'LOCAL_BUYING_HOUSEDataSet1
        '
        Me.LOCAL_BUYING_HOUSEDataSet1.DataSetName = "LOCAL_BUYING_HOUSEDataSet1"
        Me.LOCAL_BUYING_HOUSEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "COMMANDECOTCO"
        Me.BindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'COMMANDECOTCOTableAdapter
        '
        Me.COMMANDECOTCOTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CLIENTBindingSource3, "NomCli", True))
        Me.ComboBox2.DataSource = Me.CLIENTBindingSource2
        Me.ComboBox2.DisplayMember = "NomCli"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(157, 177)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(317, 21)
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.ValueMember = "NomCli"
        '
        'CLIENTBindingSource3
        '
        Me.CLIENTBindingSource3.DataMember = "CLIENT"
        Me.CLIENTBindingSource3.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'CLIENTBindingSource2
        '
        Me.CLIENTBindingSource2.DataMember = "CLIENT"
        Me.CLIENTBindingSource2.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'CLIENTBindingSource1
        '
        Me.CLIENTBindingSource1.DataMember = "CLIENT"
        Me.CLIENTBindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.DateCON)
        Me.Panel1.Controls.Add(Me.TBSERCON)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BTANUCON)
        Me.Panel1.Controls.Add(Me.BTENRCON)
        Me.Panel1.Location = New System.Drawing.Point(396, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(524, 390)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.apply
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(17, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(358, 365)
        Me.Panel2.TabIndex = 8
        '
        'CONFIRMER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(943, 534)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CONFIRMER"
        Me.Text = "CONFIRMER"
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTENRCON As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBSERCON As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTANUCON As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateCON As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents COMMANDECOTCOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMMANDECOTCOTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.COMMANDECOTCOTableAdapter
    Friend WithEvents COMMANDECOTCOBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents CLIENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.CLIENTTableAdapter
    Friend WithEvents CLIENTBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CLIENTBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTBindingSource2 As System.Windows.Forms.BindingSource
End Class
