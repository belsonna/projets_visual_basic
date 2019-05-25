<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MISAJOURCLIENT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MISAJOURCLIENT))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CLIENTBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.CLIENTBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTTableAdapter = New LOCAL_BUYING_HOUSEDataSet1TableAdapters.CLIENTTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBNOMMISCLI = New System.Windows.Forms.TextBox()
        Me.TBADRMISCLI = New System.Windows.Forms.TextBox()
        Me.TBSIEMISCLI = New System.Windows.Forms.TextBox()
        Me.BTOKMISCLI = New System.Windows.Forms.Button()
        Me.BTANUMISCLI = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.CLIENTBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(363, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MIS A JOUR CLIENT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(133, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOM DU CLIENT:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CLIENTBindingSource3, "NomCli", True))
        Me.ComboBox1.DataSource = Me.CLIENTBindingSource2
        Me.ComboBox1.DisplayMember = "NomCli"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(276, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(484, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.ValueMember = "NomCli"
        '
        'CLIENTBindingSource3
        '
        Me.CLIENTBindingSource3.DataMember = "CLIENT"
        Me.CLIENTBindingSource3.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'LOCAL_BUYING_HOUSEDataSet1
        '
        Me.LOCAL_BUYING_HOUSEDataSet1.DataSetName = "LOCAL_BUYING_HOUSEDataSet1"
        Me.LOCAL_BUYING_HOUSEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Location = New System.Drawing.Point(795, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 49)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "MODIFIER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Location = New System.Drawing.Point(795, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 45)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "SUPPRIMER"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(341, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "REMPLACER PAR:"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(200, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NOM:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(174, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ADRESSE:"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(152, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "SIEGE SOCIAL:"
        Me.Label6.Visible = False
        '
        'TBNOMMISCLI
        '
        Me.TBNOMMISCLI.Location = New System.Drawing.Point(242, 82)
        Me.TBNOMMISCLI.Name = "TBNOMMISCLI"
        Me.TBNOMMISCLI.ReadOnly = True
        Me.TBNOMMISCLI.Size = New System.Drawing.Size(333, 20)
        Me.TBNOMMISCLI.TabIndex = 6
        Me.TBNOMMISCLI.Visible = False
        '
        'TBADRMISCLI
        '
        Me.TBADRMISCLI.Location = New System.Drawing.Point(241, 115)
        Me.TBADRMISCLI.Name = "TBADRMISCLI"
        Me.TBADRMISCLI.Size = New System.Drawing.Size(333, 20)
        Me.TBADRMISCLI.TabIndex = 6
        Me.TBADRMISCLI.Visible = False
        '
        'TBSIEMISCLI
        '
        Me.TBSIEMISCLI.Location = New System.Drawing.Point(241, 145)
        Me.TBSIEMISCLI.Name = "TBSIEMISCLI"
        Me.TBSIEMISCLI.Size = New System.Drawing.Size(333, 20)
        Me.TBSIEMISCLI.TabIndex = 6
        Me.TBSIEMISCLI.Visible = False
        '
        'BTOKMISCLI
        '
        Me.BTOKMISCLI.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTOKMISCLI.Location = New System.Drawing.Point(255, 198)
        Me.BTOKMISCLI.Name = "BTOKMISCLI"
        Me.BTOKMISCLI.Size = New System.Drawing.Size(75, 40)
        Me.BTOKMISCLI.TabIndex = 7
        Me.BTOKMISCLI.Text = "OK"
        Me.BTOKMISCLI.UseVisualStyleBackColor = False
        Me.BTOKMISCLI.Visible = False
        '
        'BTANUMISCLI
        '
        Me.BTANUMISCLI.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANUMISCLI.Location = New System.Drawing.Point(428, 198)
        Me.BTANUMISCLI.Name = "BTANUMISCLI"
        Me.BTANUMISCLI.Size = New System.Drawing.Size(75, 40)
        Me.BTANUMISCLI.TabIndex = 7
        Me.BTANUMISCLI.Text = "CANCEL"
        Me.BTANUMISCLI.UseVisualStyleBackColor = False
        Me.BTANUMISCLI.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.BTANUMISCLI)
        Me.Panel1.Controls.Add(Me.BTOKMISCLI)
        Me.Panel1.Controls.Add(Me.TBSIEMISCLI)
        Me.Panel1.Controls.Add(Me.TBADRMISCLI)
        Me.Panel1.Controls.Add(Me.TBNOMMISCLI)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(62, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(939, 391)
        Me.Panel1.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(737, 332)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 34)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "RESTAURE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.vide_poubelle_icone_8363_128
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(698, 173)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(166, 153)
        Me.Panel2.TabIndex = 8
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1033, 25)
        Me.FillByToolStrip.TabIndex = 10
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'MISAJOURCLIENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1033, 516)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "MISAJOURCLIENT"
        Me.Text = "MISAJOURCLIENT"
        CType(Me.CLIENTBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents CLIENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.CLIENTTableAdapter
    Friend WithEvents CLIENTBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TBNOMMISCLI As System.Windows.Forms.TextBox
    Friend WithEvents TBADRMISCLI As System.Windows.Forms.TextBox
    Friend WithEvents TBSIEMISCLI As System.Windows.Forms.TextBox
    Friend WithEvents BTOKMISCLI As System.Windows.Forms.Button
    Friend WithEvents BTANUMISCLI As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CLIENTBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
