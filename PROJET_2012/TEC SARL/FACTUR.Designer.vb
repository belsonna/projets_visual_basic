<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FACTUR
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
        Me.FACTURERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCAL_BUYING_HOUSEDataSet1 = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FACTUREBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FACTURETableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.FACTURETableAdapter()
        Me.FACTURERTableAdapter = New TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.FACTURERTableAdapter()
        CType(Me.FACTURERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FACTUREBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FACTURERBindingSource
        '
        Me.FACTURERBindingSource.DataMember = "FACTURER"
        Me.FACTURERBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'LOCAL_BUYING_HOUSEDataSet1
        '
        Me.LOCAL_BUYING_HOUSEDataSet1.DataSetName = "LOCAL BUYING HOUSEDataSet1"
        Me.LOCAL_BUYING_HOUSEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.FACTURERBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "TEC_SARL.Report19.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(927, 496)
        Me.ReportViewer1.TabIndex = 0
        '
        'FACTUREBindingSource
        '
        Me.FACTUREBindingSource.DataMember = "FACTURE"
        Me.FACTUREBindingSource.DataSource = Me.LOCAL_BUYING_HOUSEDataSet1
        '
        'FACTURETableAdapter
        '
        Me.FACTURETableAdapter.ClearBeforeFill = True
        '
        'FACTURERTableAdapter
        '
        Me.FACTURERTableAdapter.ClearBeforeFill = True
        '
        'FACTUR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 496)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FACTUR"
        Me.Text = "FACTUR"
        CType(Me.FACTURERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCAL_BUYING_HOUSEDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FACTUREBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents LOCAL_BUYING_HOUSEDataSet1 As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1
    Friend WithEvents FACTUREBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FACTURETableAdapter As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.FACTURETableAdapter
    Friend WithEvents FACTURERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FACTURERTableAdapter As TEC_SARL.LOCAL_BUYING_HOUSEDataSet1TableAdapters.FACTURERTableAdapter
End Class
