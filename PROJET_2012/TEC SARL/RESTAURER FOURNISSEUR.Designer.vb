<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RESTAURER_FOURNISSEUR
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
        Me.FOURNISSEURBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.FOURNISSEURBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FOURNISSEURTableAdapter = New LOCAL_BUYING_HOUSEDataSet1TableAdapters.FOURNISSEURTableAdapter()
        CType(Me.FOURNISSEURBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FOURNISSEURBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FOURNISSEURBindingSource1, "NomFour", True))
        Me.ComboBox1.DataSource = Me.FOURNISSEURBindingSource
        Me.ComboBox1.DisplayMember = "NomFour"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(349, 179)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(350, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "NomFour"
        '
        'FOURNISSEURBindingSource1
        '
        Me.FOURNISSEURBindingSource1.DataMember = "FOURNISSEUR"
        Me.FOURNISSEURBindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet
        '
        'LOCAL_BUYING_HOUSEDataSet
        '
        Me.LOCAL_BUYING_HOUSEDataSet.DataSetName = "LOCAL_BUYING_HOUSEDataSet"
        Me.LOCAL_BUYING_HOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FOURNISSEURBindingSource
        '
        Me.FOURNISSEURBindingSource.DataMember = "FOURNISSEUR"
        Me.FOURNISSEURBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(430, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 62)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "GACHTEC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "recycle"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(286, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOM:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(425, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "RESTAURER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FOURNISSEURTableAdapter
        '
        Me.FOURNISSEURTableAdapter.ClearBeforeFill = True
        '
        'RESTAURER_FOURNISSEUR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.img_031
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(865, 501)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "RESTAURER_FOURNISSEUR"
        Me.Text = "RESTAURER_FOURNISSEUR"
        CType(Me.FOURNISSEURBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FOURNISSEURBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents FOURNISSEURBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FOURNISSEURTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.FOURNISSEURTableAdapter
    Friend WithEvents FOURNISSEURBindingSource1 As System.Windows.Forms.BindingSource
End Class
