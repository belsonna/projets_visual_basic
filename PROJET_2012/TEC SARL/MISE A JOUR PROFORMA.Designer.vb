<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MISE_A_JOUR_PROFORMA
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PROFORMABindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.PROFORMABindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROFORMABindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROFORMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTMODMISPROF = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BTSUPMISPROF = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BTOKMISPROF = New System.Windows.Forms.Button()
        Me.BTANUMISPROF = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PROFORMATableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.PROFORMATableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TYPEPRODUITBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TYPEPRODUITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.COTATIONBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.COTATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.FOURNISSEURBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FOURNISSEURBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TYPEPRODUITTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.TYPEPRODUITTableAdapter()
        Me.COTATIONTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.COTATIONTableAdapter()
        Me.FOURNISSEURTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.FOURNISSEURTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.PROFORMABindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFORMABindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFORMABindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFORMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TYPEPRODUITBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TYPEPRODUITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COTATIONBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COTATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FOURNISSEURBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FOURNISSEURBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(286, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(481, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MISE A JOUR PROFORMA"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PROFORMABindingSource3, "NumProf", True))
        Me.ComboBox1.DataSource = Me.PROFORMABindingSource2
        Me.ComboBox1.DisplayMember = "NumProf"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(360, 34)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(344, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "NumProf"
        '
        'PROFORMABindingSource3
        '
        Me.PROFORMABindingSource3.DataMember = "PROFORMA"
        Me.PROFORMABindingSource3.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'LOCAL_BUYING_HOUSEDataSet1
        '
        Me.LOCAL_BUYING_HOUSEDataSet1.DataSetName = "LOCAL_BUYING_HOUSEDataSet1"
        Me.LOCAL_BUYING_HOUSEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROFORMABindingSource2
        '
        Me.PROFORMABindingSource2.DataMember = "PROFORMA"
        Me.PROFORMABindingSource2.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'PROFORMABindingSource1
        '
        Me.PROFORMABindingSource1.DataMember = "PROFORMA"
        Me.PROFORMABindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'PROFORMABindingSource
        '
        Me.PROFORMABindingSource.DataMember = "PROFORMA"
        Me.PROFORMABindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'BTMODMISPROF
        '
        Me.BTMODMISPROF.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTMODMISPROF.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTMODMISPROF.Location = New System.Drawing.Point(765, 8)
        Me.BTMODMISPROF.Name = "BTMODMISPROF"
        Me.BTMODMISPROF.Size = New System.Drawing.Size(128, 47)
        Me.BTMODMISPROF.TabIndex = 2
        Me.BTMODMISPROF.Text = "MODIFIER"
        Me.BTMODMISPROF.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(322, 131)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(382, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(452, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "REMPLACER PAR:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(257, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "NUMERO:"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(274, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "OBJET:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(274, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "DATE:"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(274, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "TYPE:"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(232, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "COTATION NO:"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(227, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "FOURNISSEUR:"
        Me.Label8.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(322, 159)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(382, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Visible = False
        '
        'BTSUPMISPROF
        '
        Me.BTSUPMISPROF.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTSUPMISPROF.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTSUPMISPROF.Location = New System.Drawing.Point(765, 64)
        Me.BTSUPMISPROF.Name = "BTSUPMISPROF"
        Me.BTSUPMISPROF.Size = New System.Drawing.Size(128, 47)
        Me.BTSUPMISPROF.TabIndex = 2
        Me.BTSUPMISPROF.Text = "SUPPRIMER"
        Me.BTSUPMISPROF.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(195, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "NUMERO DE LA PRO FORMA:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BTOKMISPROF
        '
        Me.BTOKMISPROF.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTOKMISPROF.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTOKMISPROF.Location = New System.Drawing.Point(334, 325)
        Me.BTOKMISPROF.Name = "BTOKMISPROF"
        Me.BTOKMISPROF.Size = New System.Drawing.Size(128, 47)
        Me.BTOKMISPROF.TabIndex = 2
        Me.BTOKMISPROF.Text = "OK"
        Me.BTOKMISPROF.UseVisualStyleBackColor = False
        Me.BTOKMISPROF.Visible = False
        '
        'BTANUMISPROF
        '
        Me.BTANUMISPROF.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANUMISPROF.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTANUMISPROF.Location = New System.Drawing.Point(509, 325)
        Me.BTANUMISPROF.Name = "BTANUMISPROF"
        Me.BTANUMISPROF.Size = New System.Drawing.Size(128, 47)
        Me.BTANUMISPROF.TabIndex = 2
        Me.BTANUMISPROF.Text = "CANCEL"
        Me.BTANUMISPROF.UseVisualStyleBackColor = False
        Me.BTANUMISPROF.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(322, 190)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(382, 20)
        Me.DateTimePicker1.TabIndex = 4
        Me.DateTimePicker1.Visible = False
        '
        'PROFORMATableAdapter
        '
        Me.PROFORMATableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TYPEPRODUITBindingSource1, "Nomtype", True))
        Me.ComboBox2.DataSource = Me.TYPEPRODUITBindingSource
        Me.ComboBox2.DisplayMember = "Nomtype"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(322, 221)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(382, 21)
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
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.COTATIONBindingSource1, "NumCot", True))
        Me.ComboBox3.DataSource = Me.COTATIONBindingSource
        Me.ComboBox3.DisplayMember = "NumCot"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(322, 252)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(382, 21)
        Me.ComboBox3.TabIndex = 5
        Me.ComboBox3.ValueMember = "NumCot"
        Me.ComboBox3.Visible = False
        '
        'COTATIONBindingSource1
        '
        Me.COTATIONBindingSource1.DataMember = "COTATION"
        Me.COTATIONBindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'COTATIONBindingSource
        '
        Me.COTATIONBindingSource.DataMember = "COTATION"
        Me.COTATIONBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FOURNISSEURBindingSource1, "NomFour", True))
        Me.ComboBox4.DataSource = Me.FOURNISSEURBindingSource
        Me.ComboBox4.DisplayMember = "NomFour"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(321, 283)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(382, 21)
        Me.ComboBox4.TabIndex = 5
        Me.ComboBox4.ValueMember = "NomFour"
        Me.ComboBox4.Visible = False
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
        'TYPEPRODUITTableAdapter
        '
        Me.TYPEPRODUITTableAdapter.ClearBeforeFill = True
        '
        'COTATIONTableAdapter
        '
        Me.COTATIONTableAdapter.ClearBeforeFill = True
        '
        'FOURNISSEURTableAdapter
        '
        Me.FOURNISSEURTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ComboBox4)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.BTANUMISPROF)
        Me.Panel1.Controls.Add(Me.BTOKMISPROF)
        Me.Panel1.Controls.Add(Me.BTSUPMISPROF)
        Me.Panel1.Controls.Add(Me.BTMODMISPROF)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(13, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1336, 392)
        Me.Panel1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(765, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 27)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "RESTAURER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.vide_poubelle_icone_8363_128
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(754, 159)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(186, 196)
        Me.Panel2.TabIndex = 6
        '
        'MISE_A_JOUR_PROFORMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.img_031
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(946, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MISE_A_JOUR_PROFORMA"
        Me.Text = "MISE_A_JOUR_PROFORMA"
        CType(Me.PROFORMABindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFORMABindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFORMABindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFORMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TYPEPRODUITBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TYPEPRODUITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COTATIONBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COTATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FOURNISSEURBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FOURNISSEURBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BTMODMISPROF As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents BTSUPMISPROF As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BTOKMISPROF As System.Windows.Forms.Button
    Friend WithEvents BTANUMISPROF As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents PROFORMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROFORMATableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.PROFORMATableAdapter
    Friend WithEvents PROFORMABindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents TYPEPRODUITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TYPEPRODUITTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.TYPEPRODUITTableAdapter
    Friend WithEvents TYPEPRODUITBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents COTATIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COTATIONTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.COTATIONTableAdapter
    Friend WithEvents COTATIONBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents FOURNISSEURBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FOURNISSEURTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.FOURNISSEURTableAdapter
    Friend WithEvents FOURNISSEURBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PROFORMABindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents PROFORMABindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
