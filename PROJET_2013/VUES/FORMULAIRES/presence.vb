Public Class presence


    Private Sub rapport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'BUYINGHOUSEDataSet.EMPLOYE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.EMPLOYETableAdapter.Fill(Me.BUYINGHOUSEDataSet.EMPLOYE)
        'TODO: cette ligne de code charge les données dans la table 'BUYINGHOUSEDataSet2.cotee'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.vuerapport.RefreshReport()

    End Sub
End Class