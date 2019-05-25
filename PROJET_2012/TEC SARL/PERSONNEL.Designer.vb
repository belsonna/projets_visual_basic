<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PERSONNEL
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
        Me.BTENRPER = New System.Windows.Forms.Button()
        Me.TBNUMPER = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBNOMPER = New System.Windows.Forms.TextBox()
        Me.TBADRPER = New System.Windows.Forms.TextBox()
        Me.TBSERPER = New System.Windows.Forms.TextBox()
        Me.TBENTPER = New System.Windows.Forms.TextBox()
        Me.TBLOGPER = New System.Windows.Forms.TextBox()
        Me.BTANUPER = New System.Windows.Forms.Button()
        Me.PERSONNELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCALBUYINGHOUSEDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.PERSONNELTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.PERSONNELTableAdapter()
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.PERSONNELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCALBUYINGHOUSEDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ENREGISTREMENT"
        '
        'BTENRPER
        '
        Me.BTENRPER.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTENRPER.Location = New System.Drawing.Point(422, 418)
        Me.BTENRPER.Name = "BTENRPER"
        Me.BTENRPER.Size = New System.Drawing.Size(109, 38)
        Me.BTENRPER.TabIndex = 7
        Me.BTENRPER.Text = "ENREGISTRER"
        Me.BTENRPER.UseVisualStyleBackColor = False
        '
        'TBNUMPER
        '
        Me.TBNUMPER.Location = New System.Drawing.Point(126, 17)
        Me.TBNUMPER.Name = "TBNUMPER"
        Me.TBNUMPER.Size = New System.Drawing.Size(346, 20)
        Me.TBNUMPER.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ADRESSE:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(497, 785)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Button1"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "SERVICE:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "NUMERO:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "NOM:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ENTREPRISE:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "PASSWORD:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TBNOMPER
        '
        Me.TBNOMPER.Location = New System.Drawing.Point(126, 59)
        Me.TBNOMPER.Name = "TBNOMPER"
        Me.TBNOMPER.Size = New System.Drawing.Size(346, 20)
        Me.TBNOMPER.TabIndex = 2
        '
        'TBADRPER
        '
        Me.TBADRPER.Location = New System.Drawing.Point(126, 95)
        Me.TBADRPER.Name = "TBADRPER"
        Me.TBADRPER.Size = New System.Drawing.Size(346, 20)
        Me.TBADRPER.TabIndex = 3
        '
        'TBSERPER
        '
        Me.TBSERPER.Location = New System.Drawing.Point(126, 138)
        Me.TBSERPER.Name = "TBSERPER"
        Me.TBSERPER.Size = New System.Drawing.Size(346, 20)
        Me.TBSERPER.TabIndex = 4
        '
        'TBENTPER
        '
        Me.TBENTPER.Location = New System.Drawing.Point(126, 177)
        Me.TBENTPER.Name = "TBENTPER"
        Me.TBENTPER.Size = New System.Drawing.Size(346, 20)
        Me.TBENTPER.TabIndex = 5
        '
        'TBLOGPER
        '
        Me.TBLOGPER.Location = New System.Drawing.Point(126, 219)
        Me.TBLOGPER.Name = "TBLOGPER"
        Me.TBLOGPER.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBLOGPER.Size = New System.Drawing.Size(346, 20)
        Me.TBLOGPER.TabIndex = 6
        '
        'BTANUPER
        '
        Me.BTANUPER.BackColor = System.Drawing.SystemColors.Highlight
        Me.BTANUPER.Location = New System.Drawing.Point(643, 418)
        Me.BTANUPER.Name = "BTANUPER"
        Me.BTANUPER.Size = New System.Drawing.Size(110, 38)
        Me.BTANUPER.TabIndex = 8
        Me.BTANUPER.Text = "ANNULER"
        Me.BTANUPER.UseVisualStyleBackColor = False
        '
        'PERSONNELBindingSource
        '
        Me.PERSONNELBindingSource.DataMember = "PERSONNEL"
        '
        'LOCALBUYINGHOUSEDataSetBindingSource
        '
        Me.LOCALBUYINGHOUSEDataSetBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet
        Me.LOCALBUYINGHOUSEDataSetBindingSource.Position = 0
        '
        'LOCAL_BUYING_HOUSEDataSet
        '
        Me.LOCAL_BUYING_HOUSEDataSet.DataSetName = "LOCAL_BUYING_HOUSEDataSet"
        Me.LOCAL_BUYING_HOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PERSONNELTableAdapter
        '
        Me.PERSONNELTableAdapter.ClearBeforeFill = True
        '
        'LOCAL_BUYING_HOUSEDataSet1
        '
        Me.LOCAL_BUYING_HOUSEDataSet1.DataSetName = "LOCAL_BUYING_HOUSEDataSet1"
        Me.LOCAL_BUYING_HOUSEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.Users
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(21, 137)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 222)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.TBLOGPER)
        Me.Panel2.Controls.Add(Me.TBENTPER)
        Me.Panel2.Controls.Add(Me.TBSERPER)
        Me.Panel2.Controls.Add(Me.TBADRPER)
        Me.Panel2.Controls.Add(Me.TBNOMPER)
        Me.Panel2.Controls.Add(Me.TBNUMPER)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(296, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(492, 254)
        Me.Panel2.TabIndex = 5
        '
        'PERSONNEL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(842, 476)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.BTANUPER)
        Me.Controls.Add(Me.BTENRPER)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PERSONNEL"
        Me.Text = "PERSONNEL"
        CType(Me.PERSONNELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCALBUYINGHOUSEDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTENRPER As System.Windows.Forms.Button
    Friend WithEvents TBNUMPER As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TBNOMPER As System.Windows.Forms.TextBox
    Friend WithEvents TBADRPER As System.Windows.Forms.TextBox
    Friend WithEvents TBSERPER As System.Windows.Forms.TextBox
    Friend WithEvents TBENTPER As System.Windows.Forms.TextBox
    Friend WithEvents TBLOGPER As System.Windows.Forms.TextBox
    Friend WithEvents BTANUPER As System.Windows.Forms.Button
    Friend WithEvents LOCALBUYINGHOUSEDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents PERSONNELBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PERSONNELTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.PERSONNELTableAdapter
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
