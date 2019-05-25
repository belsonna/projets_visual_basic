Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class FACTUR

    Private Sub FACTUR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.FACTURE'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
       
        Dim REPO As String
        REPO = InputBox(" NUMERO DE LA COMMANDE")
        Me.FACTURERTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.FACTURER, REPO)
        Dim ObjetConnection As SqlConnection
        Dim ObjetCommand As SqlCommand
        Dim ObjetDataAdapter As SqlDataAdapter
        Dim ObjetDataSet As New DataSet
        Dim strSql As String
        Dim ObjetDataTable As DataTable
        Dim strConn As String

        strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
        strSql = "select *from FACTURE WHERE NumPO='" + REPO + "' "
        ObjetConnection = New SqlConnection
        ObjetConnection.ConnectionString = strConn
        Try
            ObjetConnection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ObjetCommand = New SqlCommand(strSql)
        ObjetDataAdapter = New SqlDataAdapter(ObjetCommand)
        ObjetCommand.Connection() = ObjetConnection
        ObjetDataAdapter.Fill(ObjetDataSet, "FACTURE")
        ObjetDataTable = ObjetDataSet.Tables("FACTURE")
        If ObjetDataTable.Rows.Count < 1 Then
            MsgBox(" CETTE COMMANDE N'EST PAS ENCORE ENEGISTREE")
            Me.Close()
        Else
            Me.FACTURERTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.FACTURER, REPO)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class