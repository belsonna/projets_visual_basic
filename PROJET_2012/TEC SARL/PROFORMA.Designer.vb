<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROFORMA
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
        Me.BTENRPROF = New System.Windows.Forms.Button()
        Me.TBNUMPROF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTANUPROF = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBOBJPROF = New System.Windows.Forms.TextBox()
        Me.Dateprof = New System.Windows.Forms.DateTimePicker()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TYPEPRODUITBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.TYPEPRODUITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.COTATIONBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.COTATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.FOURNISSEURBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FOURNISSEURBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TYPEPRODUITTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.TYPEPRODUITTableAdapter()
        Me.COTATIONTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.COTATIONTableAdapter()
        Me.FOURNISSEURTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.FOURNISSEURTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.TYPEPRODUITBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TYPEPRODUITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COTATIONBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COTATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FOURNISSEURBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FOURNISSEURBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTENRPROF
        '
        Me.BTENRPROF.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTENRPROF.Location = New System.Drawing.Point(344, 330)
        Me.BTENRPROF.Name = "BTENRPROF"
        Me.BTENRPROF.Size = New System.Drawing.Size(104, 36)
        Me.BTENRPROF.TabIndex = 7
        Me.BTENRPROF.Text = "ENREGISTRER"
        Me.BTENRPROF.UseVisualStyleBackColor = False
        '
        'TBNUMPROF
        '
        Me.TBNUMPROF.Location = New System.Drawing.Point(148, 99)
        Me.TBNUMPROF.Name = "TBNUMPROF"
        Me.TBNUMPROF.Size = New System.Drawing.Size(600, 20)
        Me.TBNUMPROF.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(289, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(366, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ENREGISTREMENT"
        '
        'BTANUPROF
        '
        Me.BTANUPROF.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANUPROF.Location = New System.Drawing.Point(544, 330)
        Me.BTANUPROF.Name = "BTANUPROF"
        Me.BTANUPROF.Size = New System.Drawing.Size(94, 36)
        Me.BTANUPROF.TabIndex = 8
        Me.BTANUPROF.Text = "ANNULER"
        Me.BTANUPROF.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "NUMERO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(78, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "OBJET:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "DATE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(80, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "TYPE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "COTATION:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 282)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "FOURNISSEUR:"
        '
        'TBOBJPROF
        '
        Me.TBOBJPROF.Location = New System.Drawing.Point(148, 133)
        Me.TBOBJPROF.Name = "TBOBJPROF"
        Me.TBOBJPROF.Size = New System.Drawing.Size(600, 20)
        Me.TBOBJPROF.TabIndex = 2
        '
        'Dateprof
        '
        Me.Dateprof.Location = New System.Drawing.Point(462, 205)
        Me.Dateprof.Name = "Dateprof"
        Me.Dateprof.Size = New System.Drawing.Size(600, 20)
        Me.Dateprof.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TYPEPRODUITBindingSource1, "Nomtype", True))
        Me.ListBox1.DataSource = Me.TYPEPRODUITBindingSource
        Me.ListBox1.DisplayMember = "NomType"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(148, 199)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(600, 30)
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
        'ListBox2
        '
        Me.ListBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.COTATIONBindingSource1, "NumCot", True))
        Me.ListBox2.DataSource = Me.COTATIONBindingSource
        Me.ListBox2.DisplayMember = "NumCot"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(148, 237)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(600, 30)
        Me.ListBox2.TabIndex = 5
        Me.ListBox2.ValueMember = "NumCot"
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
        'ListBox3
        '
        Me.ListBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FOURNISSEURBindingSource1, "NomFour", True))
        Me.ListBox3.DataSource = Me.FOURNISSEURBindingSource
        Me.ListBox3.DisplayMember = "NomFour"
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(148, 273)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(600, 30)
        Me.ListBox3.TabIndex = 6
        Me.ListBox3.ValueMember = "NomFour"
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
        Me.Panel1.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.contrat1
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(1, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 311)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.ListBox3)
        Me.Panel2.Controls.Add(Me.ListBox2)
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.TBOBJPROF)
        Me.Panel2.Controls.Add(Me.TBNUMPROF)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.BTANUPROF)
        Me.Panel2.Controls.Add(Me.BTENRPROF)
        Me.Panel2.Location = New System.Drawing.Point(314, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(793, 424)
        Me.Panel2.TabIndex = 7
        '
        'PROFORMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1107, 501)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Dateprof)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "PROFORMA"
        Me.Text = "PROFORMA"
        CType(Me.TYPEPRODUITBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TYPEPRODUITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COTATIONBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COTATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FOURNISSEURBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FOURNISSEURBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTENRPROF As System.Windows.Forms.Button
    Friend WithEvents TBNUMPROF As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTANUPROF As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TBOBJPROF As System.Windows.Forms.TextBox
    Friend WithEvents Dateprof As System.Windows.Forms.DateTimePicker
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
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
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
