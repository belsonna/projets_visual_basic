Public Class LISTE_CLIENT

    Private Sub LISTE_CLIENT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet.CLIENT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CLIENTTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet.CLIENT)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    End Sub
End Class