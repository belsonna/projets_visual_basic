﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LISTE_DES_PRODUITS
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
        Me.LOCAL_BUYING_HOUSEDataSet = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.PRODUITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUITTableAdapter = New LOCAL_BUYING_HOUSEDataSet1TableAdapters.PRODUITTableAdapter()
        CType(Me.LOCAL_BUYING_HOUSEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PRODUITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PRODUITBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TEC_SARL.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 8)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1051, 551)
        Me.ReportViewer1.TabIndex = 0
        '
        'LOCAL_BUYING_HOUSEDataSet
        '
        Me.LOCAL_BUYING_HOUSEDataSet.DataSetName = "LOCAL_BUYING_HOUSEDataSet"
        Me.LOCAL_BUYING_HOUSEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PRODUITBindingSource
        '
        Me.PRODUITBindingSource.DataMember = "PRODUIT"
        Me.PRODUITBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet
        '
        'PRODUITTableAdapter
        '
        Me.PRODUITTableAdapter.ClearBeforeFill = True
        '
        'LISTE_DES_PRODUITS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 532)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "LISTE_DES_PRODUITS"
        Me.Text = "LISTE_DES_PRODUITS"
        CType(Me.LOCAL_BUYING_HOUSEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PRODUITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PRODUITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents PRODUITTableAdapter As LOCAL_BUYING_HOUSEDataSet1TableAdapters.PRODUITTableAdapter
End Class
