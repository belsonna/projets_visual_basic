<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COMMANDE_COTCO
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
        Me.BTENRPO = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNUMPO = New System.Windows.Forms.TextBox()
        Me.BTANUPO = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBOBJPO = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.COMMANDECOTCOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.COTATIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COTATIONTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.COTATIONTableAdapter()
        Me.COMMANDECOTCOTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.COMMANDECOTCOTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TBLETRCOT = New System.Windows.Forms.TextBox()
        Me.TBMONCOT = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.COMMANDECOTCOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COTATIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTENRPO
        '
        Me.BTENRPO.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTENRPO.Location = New System.Drawing.Point(188, 444)
        Me.BTENRPO.Name = "BTENRPO"
        Me.BTENRPO.Size = New System.Drawing.Size(106, 38)
        Me.BTENRPO.TabIndex = 7
        Me.BTENRPO.Text = "ENREGISTRER"
        Me.BTENRPO.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENREGISTREMENT"
        '
        'TBNUMPO
        '
        Me.TBNUMPO.Location = New System.Drawing.Point(135, 106)
        Me.TBNUMPO.Name = "TBNUMPO"
        Me.TBNUMPO.Size = New System.Drawing.Size(489, 20)
        Me.TBNUMPO.TabIndex = 1
        '
        'BTANUPO
        '
        Me.BTANUPO.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANUPO.Location = New System.Drawing.Point(437, 444)
        Me.BTANUPO.Name = "BTANUPO"
        Me.BTANUPO.Size = New System.Drawing.Size(110, 38)
        Me.BTANUPO.TabIndex = 8
        Me.BTANUPO.Text = "ANNULER"
        Me.BTANUPO.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NUMERO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "COTATION NO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "OBJET:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "DATE:"
        '
        'TBOBJPO
        '
        Me.TBOBJPO.Location = New System.Drawing.Point(135, 226)
        Me.TBOBJPO.Name = "TBOBJPO"
        Me.TBOBJPO.Size = New System.Drawing.Size(489, 20)
        Me.TBOBJPO.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.COMMANDECOTCOBindingSource, "NumPO", True))
        Me.ListBox1.DataSource = Me.COTATIONBindingSource
        Me.ListBox1.DisplayMember = "NumCot"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(136, 156)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(488, 30)
        Me.ListBox1.TabIndex = 2
        Me.ListBox1.ValueMember = "NumCot"
        '
        'COMMANDECOTCOBindingSource
        '
        Me.COMMANDECOTCOBindingSource.DataMember = "COMMANDECOTCO"
        Me.COMMANDECOTCOBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'LOCAL_BUYING_HOUSEDataSet1
        '
        Me.LOCAL_BUYING_HOUSEDataSet1.DataSetName = "LOCAL_BUYING_HOUSEDataSet1"
        Me.LOCAL_BUYING_HOUSEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COTATIONBindingSource
        '
        Me.COTATIONBindingSource.DataMember = "COTATION"
        Me.COTATIONBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'COTATIONTableAdapter
        '
        Me.COTATIONTableAdapter.ClearBeforeFill = True
        '
        'COMMANDECOTCOTableAdapter
        '
        Me.COMMANDECOTCOTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(135, 284)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(489, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.commande
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(12, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 392)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.TBLETRCOT)
        Me.Panel2.Controls.Add(Me.TBMONCOT)
        Me.Panel2.Controls.Add(Me.TBOBJPO)
        Me.Panel2.Controls.Add(Me.TBNUMPO)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.BTANUPO)
        Me.Panel2.Controls.Add(Me.BTENRPO)
        Me.Panel2.Location = New System.Drawing.Point(319, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(725, 507)
        Me.Panel2.TabIndex = 7
        '
        'TBLETRCOT
        '
        Me.TBLETRCOT.Location = New System.Drawing.Point(136, 383)
        Me.TBLETRCOT.Name = "TBLETRCOT"
        Me.TBLETRCOT.Size = New System.Drawing.Size(489, 20)
        Me.TBLETRCOT.TabIndex = 6
        '
        'TBMONCOT
        '
        Me.TBMONCOT.Location = New System.Drawing.Point(135, 337)
        Me.TBMONCOT.Name = "TBMONCOT"
        Me.TBMONCOT.Size = New System.Drawing.Size(489, 20)
        Me.TBMONCOT.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 383)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "EN LETTRE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 337)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "MONTANT:"
        '
        'COMMANDE_COTCO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1051, 519)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "COMMANDE_COTCO"
        Me.Text = "COMMANDECOTCO"
        CType(Me.COMMANDECOTCOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COTATIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTENRPO As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBNUMPO As System.Windows.Forms.TextBox
    Friend WithEvents BTANUPO As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBOBJPO As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents COTATIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COTATIONTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.COTATIONTableAdapter
    Friend WithEvents COMMANDECOTCOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMMANDECOTCOTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.COMMANDECOTCOTableAdapter
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBLETRCOT As System.Windows.Forms.TextBox
    Friend WithEvents TBMONCOT As System.Windows.Forms.TextBox
End Class
