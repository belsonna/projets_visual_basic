Public Class FACTURE2

    Private Sub FACTURE2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BUYINGHOUSEDataSet.facturee'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.factureeTableAdapter.Fill(Me.BUYINGHOUSEDataSet.facturee, numero)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class