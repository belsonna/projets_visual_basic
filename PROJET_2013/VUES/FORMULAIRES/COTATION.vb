Public Class COTATION

    Private Sub COTATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BUYINGHOUSEDataSet.coter'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.coterTableAdapter.Fill(Me.BUYINGHOUSEDataSet.coter)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class