Public Class PROFAC

    Private Sub PROFAC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CoteeTableAdapter.Fill(Me.BUYINGHOUSEDataSet.cotee, numero)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class