<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MIS_A_JOUR_PERSONNEL
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PERSONNELBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERSONNELBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERSONNELBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCALBUYINGHOUSEDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCALBUYINGHOUSEDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCALBUYINGHOUSEDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBoxMISPER = New System.Windows.Forms.ComboBox()
        Me.PERSONNELBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.PERSONNELBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERSONNELBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERSONNELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBNUMMISPER = New System.Windows.Forms.TextBox()
        Me.TBNOMMISPER = New System.Windows.Forms.TextBox()
        Me.TBADRMISPER = New System.Windows.Forms.TextBox()
        Me.TBSERMISPER = New System.Windows.Forms.TextBox()
        Me.TBENTMISPER = New System.Windows.Forms.TextBox()
        Me.TBLOGMISPER = New System.Windows.Forms.TextBox()
        Me.BTOKMISPER = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BTCANMISPER = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PERSONNELBindingSource8 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERSONNELBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PERSONNELTableAdapter = New LOCAL_BUYING_HOUSEDataSet1TableAdapters.PERSONNELTableAdapter()
        Me.FillBy4ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBy4ToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.PERSONNELBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONNELBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONNELBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCALBUYINGHOUSEDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCALBUYINGHOUSEDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCALBUYINGHOUSEDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONNELBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONNELBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONNELBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONNELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PERSONNELBindingSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERSONNELBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy4ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(535, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MIS A JOUR DU PERSONNEL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOM DU PERSONNEL:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Location = New System.Drawing.Point(597, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 46)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "MODIFIER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Location = New System.Drawing.Point(597, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 42)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "SUPRIMER"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PERSONNELBindingSource1
        '
        Me.PERSONNELBindingSource1.DataMember = "PERSONNEL"
        '
        'PERSONNELBindingSource2
        '
        Me.PERSONNELBindingSource2.DataMember = "PERSONNEL"
        '
        'PERSONNELBindingSource3
        '
        Me.PERSONNELBindingSource3.DataMember = "PERSONNEL"
        '
        'ComboBoxMISPER
        '
        Me.ComboBoxMISPER.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PERSONNELBindingSource6, "NomPer", True))
        Me.ComboBoxMISPER.DataSource = Me.PERSONNELBindingSource5
        Me.ComboBoxMISPER.DisplayMember = "NomPer"
        Me.ComboBoxMISPER.FormattingEnabled = True
        Me.ComboBoxMISPER.Location = New System.Drawing.Point(196, 69)
        Me.ComboBoxMISPER.Name = "ComboBoxMISPER"
        Me.ComboBoxMISPER.Size = New System.Drawing.Size(356, 21)
        Me.ComboBoxMISPER.TabIndex = 4
        Me.ComboBoxMISPER.ValueMember = "NomPer"
        '
        'PERSONNELBindingSource6
        '
        Me.PERSONNELBindingSource6.DataMember = "PERSONNEL"
        Me.PERSONNELBindingSource6.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'LOCAL_BUYING_HOUSEDataSet1
        '
        Me.LOCAL_BUYING_HOUSEDataSet1.DataSetName = "LOCAL_BUYING_HOUSEDataSet"
        Me.LOCAL_BUYING_HOUSEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PERSONNELBindingSource5
        '
        Me.PERSONNELBindingSource5.DataMember = "PERSONNEL"
        Me.PERSONNELBindingSource5.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'PERSONNELBindingSource4
        '
        Me.PERSONNELBindingSource4.DataMember = "PERSONNEL"
        '
        'PERSONNELBindingSource
        '
        Me.PERSONNELBindingSource.DataMember = "PERSONNEL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(66, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "NUMERO:"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(85, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NOM:"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(63, 203)
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
        Me.Label6.Location = New System.Drawing.Point(68, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "SERVICE:"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(48, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "ENTREPRISE"
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(51, 284)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "PASSWORD:"
        Me.Label8.Visible = False
        '
        'TBNUMMISPER
        '
        Me.TBNUMMISPER.Location = New System.Drawing.Point(130, 150)
        Me.TBNUMMISPER.Name = "TBNUMMISPER"
        Me.TBNUMMISPER.Size = New System.Drawing.Size(269, 20)
        Me.TBNUMMISPER.TabIndex = 6
        Me.TBNUMMISPER.Visible = False
        '
        'TBNOMMISPER
        '
        Me.TBNOMMISPER.Location = New System.Drawing.Point(130, 173)
        Me.TBNOMMISPER.Name = "TBNOMMISPER"
        Me.TBNOMMISPER.ReadOnly = True
        Me.TBNOMMISPER.Size = New System.Drawing.Size(269, 20)
        Me.TBNOMMISPER.TabIndex = 6
        Me.TBNOMMISPER.Visible = False
        '
        'TBADRMISPER
        '
        Me.TBADRMISPER.Location = New System.Drawing.Point(130, 196)
        Me.TBADRMISPER.Name = "TBADRMISPER"
        Me.TBADRMISPER.Size = New System.Drawing.Size(269, 20)
        Me.TBADRMISPER.TabIndex = 6
        Me.TBADRMISPER.Visible = False
        '
        'TBSERMISPER
        '
        Me.TBSERMISPER.Location = New System.Drawing.Point(130, 221)
        Me.TBSERMISPER.Name = "TBSERMISPER"
        Me.TBSERMISPER.Size = New System.Drawing.Size(269, 20)
        Me.TBSERMISPER.TabIndex = 6
        Me.TBSERMISPER.Visible = False
        '
        'TBENTMISPER
        '
        Me.TBENTMISPER.Location = New System.Drawing.Point(130, 251)
        Me.TBENTMISPER.Name = "TBENTMISPER"
        Me.TBENTMISPER.Size = New System.Drawing.Size(269, 20)
        Me.TBENTMISPER.TabIndex = 6
        Me.TBENTMISPER.Visible = False
        '
        'TBLOGMISPER
        '
        Me.TBLOGMISPER.Location = New System.Drawing.Point(130, 277)
        Me.TBLOGMISPER.Name = "TBLOGMISPER"
        Me.TBLOGMISPER.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBLOGMISPER.Size = New System.Drawing.Size(269, 20)
        Me.TBLOGMISPER.TabIndex = 6
        Me.TBLOGMISPER.Visible = False
        '
        'BTOKMISPER
        '
        Me.BTOKMISPER.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTOKMISPER.Location = New System.Drawing.Point(145, 303)
        Me.BTOKMISPER.Name = "BTOKMISPER"
        Me.BTOKMISPER.Size = New System.Drawing.Size(86, 46)
        Me.BTOKMISPER.TabIndex = 3
        Me.BTOKMISPER.Text = "OK"
        Me.BTOKMISPER.UseVisualStyleBackColor = False
        Me.BTOKMISPER.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(193, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "REMPLACER PAR:"
        Me.Label9.Visible = False
        '
        'BTCANMISPER
        '
        Me.BTCANMISPER.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTCANMISPER.Location = New System.Drawing.Point(297, 303)
        Me.BTCANMISPER.Name = "BTCANMISPER"
        Me.BTCANMISPER.Size = New System.Drawing.Size(86, 46)
        Me.BTCANMISPER.TabIndex = 3
        Me.BTCANMISPER.Text = "CANCEL"
        Me.BTCANMISPER.UseVisualStyleBackColor = False
        Me.BTCANMISPER.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TBLOGMISPER)
        Me.Panel1.Controls.Add(Me.TBENTMISPER)
        Me.Panel1.Controls.Add(Me.TBSERMISPER)
        Me.Panel1.Controls.Add(Me.TBADRMISPER)
        Me.Panel1.Controls.Add(Me.TBNOMMISPER)
        Me.Panel1.Controls.Add(Me.TBNUMMISPER)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboBoxMISPER)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.BTCANMISPER)
        Me.Panel1.Controls.Add(Me.BTOKMISPER)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(7, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(779, 411)
        Me.Panel1.TabIndex = 8
        '
        'PERSONNELBindingSource8
        '
        Me.PERSONNELBindingSource8.DataMember = "PERSONNEL"
        Me.PERSONNELBindingSource8.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'PERSONNELBindingSource7
        '
        Me.PERSONNELBindingSource7.DataMember = "PERSONNEL"
        Me.PERSONNELBindingSource7.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(628, 354)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 27)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "RESTAURER"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.vide_poubelle_icone_8363_128
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(607, 230)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(136, 118)
        Me.Panel2.TabIndex = 8
        '
        'PERSONNELTableAdapter
        '
        Me.PERSONNELTableAdapter.ClearBeforeFill = True
        '
        'FillBy4ToolStrip
        '
        Me.FillBy4ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy4ToolStripButton})
        Me.FillBy4ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy4ToolStrip.Name = "FillBy4ToolStrip"
        Me.FillBy4ToolStrip.Size = New System.Drawing.Size(827, 25)
        Me.FillBy4ToolStrip.TabIndex = 9
        Me.FillBy4ToolStrip.Text = "FillBy4ToolStrip"
        '
        'FillBy4ToolStripButton
        '
        Me.FillBy4ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy4ToolStripButton.Name = "FillBy4ToolStripButton"
        Me.FillBy4ToolStripButton.Size = New System.Drawing.Size(45, 22)
        Me.FillBy4ToolStripButton.Text = "FillBy4"
        '
        'MIS_A_JOUR_PERSONNEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.img_0313
        Me.ClientSize = New System.Drawing.Size(827, 497)
        Me.Controls.Add(Me.FillBy4ToolStrip)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "MIS_A_JOUR_PERSONNEL"
        Me.Text = "MIS_A_JOUR_PERSONNEL"
        CType(Me.PERSONNELBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONNELBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONNELBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCALBUYINGHOUSEDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCALBUYINGHOUSEDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCALBUYINGHOUSEDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONNELBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONNELBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONNELBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONNELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PERSONNELBindingSource8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERSONNELBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy4ToolStrip.ResumeLayout(False)
        Me.FillBy4ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PERSONNELBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PERSONNELBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PERSONNELBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents LOCALBUYINGHOUSEDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCALBUYINGHOUSEDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCALBUYINGHOUSEDataSetBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBoxMISPER As System.Windows.Forms.ComboBox
    Friend WithEvents PERSONNELBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PERSONNELBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TBNUMMISPER As System.Windows.Forms.TextBox
    Friend WithEvents TBNOMMISPER As System.Windows.Forms.TextBox
    Friend WithEvents TBADRMISPER As System.Windows.Forms.TextBox
    Friend WithEvents TBSERMISPER As System.Windows.Forms.TextBox
    Friend WithEvents TBENTMISPER As System.Windows.Forms.TextBox
    Friend WithEvents TBLOGMISPER As System.Windows.Forms.TextBox
    Friend WithEvents BTOKMISPER As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BTCANMISPER As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents PERSONNELBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents PERSONNELTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.PERSONNELTableAdapter
    Friend WithEvents PERSONNELBindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents PERSONNELBindingSource8 As System.Windows.Forms.BindingSource
    Friend WithEvents PERSONNELBindingSource7 As System.Windows.Forms.BindingSource
    Friend WithEvents FillBy4ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillBy4ToolStripButton As System.Windows.Forms.ToolStripButton
End Class
