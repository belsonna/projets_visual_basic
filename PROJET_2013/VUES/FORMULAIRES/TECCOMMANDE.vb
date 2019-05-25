Public Class TECCOMMANDE

    Private Sub TECCOMMANDE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BUYINGHOUSEDataSet.commandee'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.commandeeTableAdapter.Fill(Me.BUYINGHOUSEDataSet.commandee, numero)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class