Public Class liste

    Private Sub liste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BUYINGHOUSEDataSet.EMPLOYE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.EMPLOYETableAdapter.Fill(Me.BUYINGHOUSEDataSet.EMPLOYE)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class