﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PO_COTCO
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
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.COMMANDECOTCOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMMANDECOTCOTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.COMMANDECOTCOTableAdapter()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMMANDECOTCOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.COMMANDECOTCOBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TEC_SARL.Report12.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(909, 583)
        Me.ReportViewer1.TabIndex = 0
        '
        'LOCAL_BUYING_HOUSEDataSet1
        '
        Me.LOCAL_BUYING_HOUSEDataSet1.DataSetName = "LOCAL BUYING HOUSEDataSet1"
        Me.LOCAL_BUYING_HOUSEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COMMANDECOTCOBindingSource
        '
        Me.COMMANDECOTCOBindingSource.DataMember = "COMMANDECOTCO"
        Me.COMMANDECOTCOBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'COMMANDECOTCOTableAdapter
        '
        Me.COMMANDECOTCOTableAdapter.ClearBeforeFill = True
        '
        'PO_COTCO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 583)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "PO_COTCO"
        Me.Text = "PO_COTCO"
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMMANDECOTCOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents COMMANDECOTCOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMMANDECOTCOTableAdapter As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.COMMANDECOTCOTableAdapter
End Class
