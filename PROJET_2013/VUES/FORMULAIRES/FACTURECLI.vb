Public Class FACTURECLI

    Private Sub FACTURERTEE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FactureeTableAdapter.Fill(Me.BUYINGHOUSEDataSet.facturee, numero)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class