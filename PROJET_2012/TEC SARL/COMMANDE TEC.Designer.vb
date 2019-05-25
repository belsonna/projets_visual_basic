<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COMMANDE_TEC
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
        Me.BTENRTEC = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBNUMTEC = New System.Windows.Forms.TextBox()
        Me.TBOBJTEC = New System.Windows.Forms.TextBox()
        Me.BTANUTEC = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PROFORMABindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.PROFORMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROFORMATableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.PROFORMATableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFORMABindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFORMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTENRTEC
        '
        Me.BTENRTEC.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTENRTEC.Location = New System.Drawing.Point(222, 318)
        Me.BTENRTEC.Name = "BTENRTEC"
        Me.BTENRTEC.Size = New System.Drawing.Size(114, 50)
        Me.BTENRTEC.TabIndex = 5
        Me.BTENRTEC.Text = "ENREGISTRER"
        Me.BTENRTEC.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(515, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENREGISTREMENT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TEC_SARL.My.Resources.Resources.commande
        Me.PictureBox1.Location = New System.Drawing.Point(-4, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(344, 313)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(130, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(535, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 46)
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
        Me.Label3.Location = New System.Drawing.Point(0, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "PROFORMA NO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 193)
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
        Me.Label5.Location = New System.Drawing.Point(68, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "DATE:"
        '
        'TBNUMTEC
        '
        Me.TBNUMTEC.Location = New System.Drawing.Point(130, 46)
        Me.TBNUMTEC.Name = "TBNUMTEC"
        Me.TBNUMTEC.Size = New System.Drawing.Size(535, 20)
        Me.TBNUMTEC.TabIndex = 1
        '
        'TBOBJTEC
        '
        Me.TBOBJTEC.Location = New System.Drawing.Point(130, 193)
        Me.TBOBJTEC.Name = "TBOBJTEC"
        Me.TBOBJTEC.Size = New System.Drawing.Size(535, 20)
        Me.TBOBJTEC.TabIndex = 3
        '
        'BTANUTEC
        '
        Me.BTANUTEC.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANUTEC.Location = New System.Drawing.Point(396, 318)
        Me.BTANUTEC.Name = "BTANUTEC"
        Me.BTANUTEC.Size = New System.Drawing.Size(114, 50)
        Me.BTANUTEC.TabIndex = 6
        Me.BTANUTEC.Text = "ANNULER"
        Me.BTANUTEC.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PROFORMABindingSource1, "NumProf", True))
        Me.ListBox1.DataSource = Me.PROFORMABindingSource
        Me.ListBox1.DisplayMember = "NumProf"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(131, 114)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(534, 30)
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(136, 265)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(529, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.TBOBJTEC)
        Me.Panel1.Controls.Add(Me.TBNUMTEC)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BTANUTEC)
        Me.Panel1.Controls.Add(Me.BTENRTEC)
        Me.Panel1.Location = New System.Drawing.Point(346, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(677, 371)
        Me.Panel1.TabIndex = 6
        '
        'COMMANDE_TEC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1023, 507)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "COMMANDE_TEC"
        Me.Text = "COMMANDE_TEC"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFORMABindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFORMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTENRTEC As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TBNUMTEC As System.Windows.Forms.TextBox
    Friend WithEvents TBOBJTEC As System.Windows.Forms.TextBox
    Friend WithEvents BTANUTEC As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents PROFORMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROFORMATableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.PROFORMATableAdapter
    Friend WithEvents PROFORMABindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
