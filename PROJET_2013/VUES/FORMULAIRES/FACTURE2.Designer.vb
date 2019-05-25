<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FACTURE2
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BUYINGHOUSEDataSet = New VUES.BUYINGHOUSEDataSet()
        Me.factureeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.factureeTableAdapter = New VUES.BUYINGHOUSEDataSetTableAdapters.factureeTableAdapter()
        CType(Me.BUYINGHOUSEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.factureeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.factureeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VUES.fact2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(617, 443)
        Me.ReportViewer1.TabIndex = 0
        '
        'BUYINGHOUSEDataSet
        '
        Me.BUYINGHOUSEDataSet.DataSetName = "BUYINGHOUSEDataSet"
        Me.BUYINGHOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'factureeBindingSource
        '
        Me.factureeBindingSource.DataMember = "facturee"
        Me.factureeBindingSource.DataSource = Me.BUYINGHOUSEDataSet
        '
        'factureeTableAdapter
        '
        Me.factureeTableAdapter.ClearBeforeFill = True
        '
        'FACTURE2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 443)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FACTURE2"
        Me.Text = "FACTURE2"
        CType(Me.BUYINGHOUSEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.factureeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents factureeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BUYINGHOUSEDataSet As VUES.BUYINGHOUSEDataSet
    Friend WithEvents factureeTableAdapter As VUES.BUYINGHOUSEDataSetTableAdapters.factureeTableAdapter
End Class
