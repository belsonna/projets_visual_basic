﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COTCO2
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
        Me.coteeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.coteeTableAdapter = New VUES.BUYINGHOUSEDataSetTableAdapters.coteeTableAdapter()
        CType(Me.BUYINGHOUSEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coteeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.coteeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VUES.cotcocote2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(678, 448)
        Me.ReportViewer1.TabIndex = 0
        '
        'BUYINGHOUSEDataSet
        '
        Me.BUYINGHOUSEDataSet.DataSetName = "BUYINGHOUSEDataSet"
        Me.BUYINGHOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'coteeBindingSource
        '
        Me.coteeBindingSource.DataMember = "cotee"
        Me.coteeBindingSource.DataSource = Me.BUYINGHOUSEDataSet
        '
        'coteeTableAdapter
        '
        Me.coteeTableAdapter.ClearBeforeFill = True
        '
        'COTCO2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 448)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "COTCO2"
        Me.Text = "COTCO2"
        CType(Me.BUYINGHOUSEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coteeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents coteeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BUYINGHOUSEDataSet As VUES.BUYINGHOUSEDataSet
    Friend WithEvents coteeTableAdapter As VUES.BUYINGHOUSEDataSetTableAdapters.coteeTableAdapter
End Class
