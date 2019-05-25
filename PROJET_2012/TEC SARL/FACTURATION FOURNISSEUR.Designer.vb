<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FACTURATION_FOURNISSEUR
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
        Me.BTENREGFACF = New System.Windows.Forms.Button()
        Me.BTANUFACF = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBNUMFAC = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.COMMANDETECBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.COMMANDETECBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PERSONNELBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERSONNELBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERSONNELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUITBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROFORMABindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROFORMABindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMMANDETECTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.COMMANDETECTableAdapter()
        Me.PROFORMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROFORMATableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.PROFORMATableAdapter()
        Me.PROFORMABindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERSONNELTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.PERSONNELTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PRODUITTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.PRODUITTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.COMMANDETECBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMMANDETECBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONNELBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONNELBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONNELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUITBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFORMABindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFORMABindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFORMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFORMABindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTENREGFACF
        '
        Me.BTENREGFACF.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTENREGFACF.Location = New System.Drawing.Point(310, 313)
        Me.BTENREGFACF.Name = "BTENREGFACF"
        Me.BTENREGFACF.Size = New System.Drawing.Size(98, 52)
        Me.BTENREGFACF.TabIndex = 5
        Me.BTENREGFACF.Text = "ENREGISTRER"
        Me.BTENREGFACF.UseVisualStyleBackColor = False
        '
        'BTANUFACF
        '
        Me.BTANUFACF.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANUFACF.Location = New System.Drawing.Point(495, 313)
        Me.BTANUFACF.Name = "BTANUFACF"
        Me.BTANUFACF.Size = New System.Drawing.Size(100, 52)
        Me.BTANUFACF.TabIndex = 6
        Me.BTANUFACF.Text = "ANNULER"
        Me.BTANUFACF.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(189, 0)
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
        Me.Label2.Location = New System.Drawing.Point(79, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NUMERO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-4, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "COMMANDE TEC NO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-23, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "NUMERO PERSONNEL:"
        '
        'TBNUMFAC
        '
        Me.TBNUMFAC.Location = New System.Drawing.Point(169, 75)
        Me.TBNUMFAC.Name = "TBNUMFAC"
        Me.TBNUMFAC.Size = New System.Drawing.Size(503, 20)
        Me.TBNUMFAC.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.COMMANDETECBindingSource1, "NumTec", True))
        Me.ComboBox1.DataSource = Me.COMMANDETECBindingSource
        Me.ComboBox1.DisplayMember = "NumTec"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(169, 136)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(503, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "NumTec"
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
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PERSONNELBindingSource1, "NumPer", True))
        Me.ComboBox2.DataSource = Me.PERSONNELBindingSource2
        Me.ComboBox2.DisplayMember = "NumPer"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(169, 199)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(503, 21)
        Me.ComboBox2.TabIndex = 3
        Me.ComboBox2.ValueMember = "NumPer"
        '
        'PERSONNELBindingSource1
        '
        Me.PERSONNELBindingSource1.DataMember = "PERSONNEL"
        Me.PERSONNELBindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'PERSONNELBindingSource2
        '
        Me.PERSONNELBindingSource2.DataMember = "PERSONNEL"
        Me.PERSONNELBindingSource2.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'PERSONNELBindingSource
        '
        Me.PERSONNELBindingSource.DataMember = "PERSONNEL"
        Me.PERSONNELBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
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
        'PROFORMABindingSource3
        '
        Me.PROFORMABindingSource3.DataMember = "PROFORMA"
        Me.PROFORMABindingSource3.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'PROFORMABindingSource2
        '
        Me.PROFORMABindingSource2.DataMember = "PROFORMA"
        Me.PROFORMABindingSource2.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'COMMANDETECTableAdapter
        '
        Me.COMMANDETECTableAdapter.ClearBeforeFill = True
        '
        'PROFORMABindingSource
        '
        Me.PROFORMABindingSource.DataMember = "PROFORMA"
        Me.PROFORMABindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'PROFORMATableAdapter
        '
        Me.PROFORMATableAdapter.ClearBeforeFill = True
        '
        'PROFORMABindingSource1
        '
        Me.PROFORMABindingSource1.DataMember = "PROFORMA"
        Me.PROFORMABindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'PERSONNELTableAdapter
        '
        Me.PERSONNELTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.TBNUMFAC)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BTANUFACF)
        Me.Panel1.Controls.Add(Me.BTENREGFACF)
        Me.Panel1.Location = New System.Drawing.Point(271, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 385)
        Me.Panel1.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(170, 244)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(502, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(107, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "DATE:"
        '
        'PRODUITTableAdapter
        '
        Me.PRODUITTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.facture
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(-3, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(272, 380)
        Me.Panel2.TabIndex = 6
        '
        'FACTURATION_FOURNISSEUR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1059, 499)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FACTURATION_FOURNISSEUR"
        Me.Text = "FACTURATION_FOURNISSEUR"
        CType(Me.COMMANDETECBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMMANDETECBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONNELBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONNELBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONNELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUITBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFORMABindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFORMABindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFORMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFORMABindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTENREGFACF As System.Windows.Forms.Button
    Friend WithEvents BTANUFACF As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TBNUMFAC As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents COMMANDETECBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMMANDETECTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.COMMANDETECTableAdapter
    Friend WithEvents COMMANDETECBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PROFORMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROFORMATableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.PROFORMATableAdapter
    Friend WithEvents PROFORMABindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PERSONNELBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PERSONNELTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.PERSONNELTableAdapter
    Friend WithEvents PERSONNELBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PROFORMABindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents PROFORMABindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PRODUITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PRODUITTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.PRODUITTableAdapter
    Friend WithEvents PRODUITBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PERSONNELBindingSource2 As System.Windows.Forms.BindingSource
End Class
