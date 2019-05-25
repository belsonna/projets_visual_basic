Public Class LIVTEC

    Private Sub LIVTEC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BUYINGHOUSEDataSet.blivtec'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.blivtecTableAdapter.Fill(Me.BUYINGHOUSEDataSet.blivtec)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class