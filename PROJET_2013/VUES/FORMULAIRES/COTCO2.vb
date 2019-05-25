Public Class COTCO2

    Private Sub COTCO2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BUYINGHOUSEDataSet.cotee'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.coteeTableAdapter.Fill(Me.BUYINGHOUSEDataSet.cotee, numero)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class