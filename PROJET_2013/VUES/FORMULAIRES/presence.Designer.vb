<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class presence
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.vuerapport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BUYINGHOUSEDataSet = New VUES.BUYINGHOUSEDataSet()
        Me.EMPLOYEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMPLOYETableAdapter = New VUES.BUYINGHOUSEDataSetTableAdapters.EMPLOYETableAdapter()
        CType(Me.BUYINGHOUSEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLOYEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vuerapport
        '
        Me.vuerapport.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "liste"
        ReportDataSource1.Value = Me.EMPLOYEBindingSource
        Me.vuerapport.LocalReport.DataSources.Add(ReportDataSource1)
        Me.vuerapport.LocalReport.ReportEmbeddedResource = "VUES.Presence.rdlc"
        Me.vuerapport.Location = New System.Drawing.Point(0, 0)
        Me.vuerapport.Name = "vuerapport"
        Me.vuerapport.Size = New System.Drawing.Size(723, 541)
        Me.vuerapport.TabIndex = 0
        '
        'BUYINGHOUSEDataSet
        '
        Me.BUYINGHOUSEDataSet.DataSetName = "BUYINGHOUSEDataSet"
        Me.BUYINGHOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMPLOYEBindingSource
        '
        Me.EMPLOYEBindingSource.DataMember = "EMPLOYE"
        Me.EMPLOYEBindingSource.DataSource = Me.BUYINGHOUSEDataSet
        '
        'EMPLOYETableAdapter
        '
        Me.EMPLOYETableAdapter.ClearBeforeFill = True
        '
        'presence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 541)
        Me.Controls.Add(Me.vuerapport)
        Me.Name = "presence"
        CType(Me.BUYINGHOUSEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLOYEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vuerapport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BUYINGHOUSEDataSet As VUES.BUYINGHOUSEDataSet
    Friend WithEvents EMPLOYEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPLOYETableAdapter As VUES.BUYINGHOUSEDataSetTableAdapters.EMPLOYETableAdapter
End Class
