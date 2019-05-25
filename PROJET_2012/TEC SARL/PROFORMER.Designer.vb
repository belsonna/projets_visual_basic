<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PROFORMER
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
        Me.TBNUMPROFER = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTENRPROFER = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTANUPROFER = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBQTEPROFER = New System.Windows.Forms.TextBox()
        Me.TBPUPROFER = New System.Windows.Forms.TextBox()
        Me.BTPREPROFER = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PROFORMABindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.PROFORMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROFORMATableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.PROFORMATableAdapter()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.PRODUITBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUITTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.PRODUITTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.PROFORMABindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFORMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUITBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBNUMPROFER
        '
        Me.TBNUMPROFER.Location = New System.Drawing.Point(139, 81)
        Me.TBNUMPROFER.Name = "TBNUMPROFER"
        Me.TBNUMPROFER.Size = New System.Drawing.Size(545, 20)
        Me.TBNUMPROFER.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NUMERO:"
        '
        'BTENRPROFER
        '
        Me.BTENRPROFER.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTENRPROFER.Location = New System.Drawing.Point(333, 333)
        Me.BTENRPROFER.Name = "BTENRPROFER"
        Me.BTENRPROFER.Size = New System.Drawing.Size(116, 55)
        Me.BTENRPROFER.TabIndex = 7
        Me.BTENRPROFER.Text = "ENREGISTRER"
        Me.BTENRPROFER.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(491, 42)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ENREGISTRER LES ITEMS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BTANUPROFER
        '
        Me.BTANUPROFER.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANUPROFER.Location = New System.Drawing.Point(530, 333)
        Me.BTANUPROFER.Name = "BTANUPROFER"
        Me.BTANUPROFER.Size = New System.Drawing.Size(125, 55)
        Me.BTANUPROFER.TabIndex = 8
        Me.BTANUPROFER.Text = "ANNULER"
        Me.BTANUPROFER.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PROFORMA NO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "NOM ITEM:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "QUANTITE:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "PRIX UNITAIRE:"
        '
        'TBQTEPROFER
        '
        Me.TBQTEPROFER.Location = New System.Drawing.Point(139, 232)
        Me.TBQTEPROFER.Name = "TBQTEPROFER"
        Me.TBQTEPROFER.Size = New System.Drawing.Size(545, 20)
        Me.TBQTEPROFER.TabIndex = 4
        '
        'TBPUPROFER
        '
        Me.TBPUPROFER.Location = New System.Drawing.Point(139, 288)
        Me.TBPUPROFER.Name = "TBPUPROFER"
        Me.TBPUPROFER.Size = New System.Drawing.Size(545, 20)
        Me.TBPUPROFER.TabIndex = 5
        '
        'BTPREPROFER
        '
        Me.BTPREPROFER.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTPREPROFER.Location = New System.Drawing.Point(128, 333)
        Me.BTPREPROFER.Name = "BTPREPROFER"
        Me.BTPREPROFER.Size = New System.Drawing.Size(116, 55)
        Me.BTPREPROFER.TabIndex = 6
        Me.BTPREPROFER.Text = "PRECEDENT"
        Me.BTPREPROFER.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PROFORMABindingSource1, "NumProf", True))
        Me.ListBox1.DataSource = Me.PROFORMABindingSource
        Me.ListBox1.DisplayMember = "NumProf"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(139, 119)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(545, 30)
        Me.ListBox1.TabIndex = 2
        Me.ListBox1.ValueMember = "NumProf"
        '
        'PROFORMABindingSource1
        '
        Me.PROFORMABindingSource1.DataMember = "PROFORMA"
        Me.PROFORMABindingSource1.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'LOCAL_BUYING_HOUSEDataSet1
        '
        Me.LOCAL_BUYING_HOUSEDataSet1.DataSetName = "LOCAL_BUYING_HOUSEDataSet1"
        Me.LOCAL_BUYING_HOUSEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ListBox2
        '
        Me.ListBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.LOCAL_BUYING_HOUSEDataSet1, "PRODUIT.NomPro", True))
        Me.ListBox2.DataSource = Me.PRODUITBindingSource1
        Me.ListBox2.DisplayMember = "NomPro"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(139, 171)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(545, 30)
        Me.ListBox2.TabIndex = 3
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
        Me.Panel1.Controls.Add(Me.ListBox2)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.BTANUPROFER)
        Me.Panel1.Controls.Add(Me.BTPREPROFER)
        Me.Panel1.Controls.Add(Me.BTENRPROFER)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TBQTEPROFER)
        Me.Panel1.Controls.Add(Me.TBPUPROFER)
        Me.Panel1.Controls.Add(Me.TBNUMPROFER)
        Me.Panel1.Location = New System.Drawing.Point(379, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(696, 431)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.Application_de_commande_online
        Me.Panel2.Location = New System.Drawing.Point(23, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(345, 431)
        Me.Panel2.TabIndex = 6
        '
        'PROFORMER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1090, 504)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PROFORMER"
        Me.Text = "PROFORMER"
        CType(Me.PROFORMABindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFORMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUITBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TBNUMPROFER As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTENRPROFER As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTANUPROFER As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TBQTEPROFER As System.Windows.Forms.TextBox
    Friend WithEvents TBPUPROFER As System.Windows.Forms.TextBox
    Friend WithEvents BTPREPROFER As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents PROFORMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROFORMATableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.PROFORMATableAdapter
    Friend WithEvents PROFORMABindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents PRODUITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PRODUITTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.PRODUITTableAdapter
    Friend WithEvents PRODUITBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
