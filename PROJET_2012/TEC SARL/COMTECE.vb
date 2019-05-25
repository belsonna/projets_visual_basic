Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class COMTECE

    Private Sub COMTECE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim REPO As String
        REPO = InputBox(" NUMERO DE LA COMMANDE")
        Me.StoredProcedure1TableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.StoredProcedure1, REPO)
        Dim ObjetConnection As SqlConnection
        Dim ObjetCommand As SqlCommand
        Dim ObjetDataAdapter As SqlDataAdapter
        Dim ObjetDataSet As New DataSet
        Dim strSql As String
        Dim ObjetDataTable As DataTable
        Dim strConn As String

        strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
        strSql = "select *from commande WHERE NumTec='" + REPO + "' "
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
        ObjetDataAdapter.Fill(ObjetDataSet, "cotee")
        ObjetDataTable = ObjetDataSet.Tables("cotee")
        If ObjetDataTable.Rows.Count < 1 Then
            MsgBox(" CETTE COMMANDE N'EST PAS ENCORE ENEGISTREE")
            Me.Close()
        Else
            Me.StoredProcedure1TableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.StoredProcedure1, REPO)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub
End Class