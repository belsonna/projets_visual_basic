Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class CLIENT

    Dim LOCAL_BUYING_HOUSEDataSet As Object
    Dim CLIENTTableAdapter As Object


    Private Sub BTANUCLI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANUCLI.Click
        Me.TBNOMCLI.Text = ""
        Me.TBADRCLI.Text = ""
        Me.TBSIECLI.Text = ""
    End Sub

    Private Sub BTENRCLI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENRCLI.Click
        If (Me.TBADRCLI.Text = "" Or Me.TBNOMCLI.Text = "" Or TBSIECLI.Text = "") Then
            MsgBox(" veuillez completer les informations")
        Else
            Dim ObjetConnection As SqlConnection
            Dim ObjetCommand As SqlCommand
            Dim ObjetDataAdapter As SqlDataAdapter
            Dim ObjetDataSet As New DataSet
            Dim strSql As String
            Dim ObjetDataTable As DataTable
            Dim strConn As String
            strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
            strSql = "SELECT * FROM CLIENT WHERE NomCli = '" + TBNOMCLI.Text + "'"
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
            ObjetDataAdapter.Fill(ObjetDataSet, "CLIENT")
            ObjetDataTable = ObjetDataSet.Tables("CLIENT")
            ObjetConnection.Close()
            If ObjetDataTable.Rows.Count < 1 Then

                strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
                strSql = "INSERT INTO CLIENT(NomCli,AdresseCli,SiegeCli) VALUES ('" + TBNOMCLI.Text + "','" + TBADRCLI.Text + "','" + TBSIECLI.Text + "') "
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
                ObjetDataAdapter.Fill(ObjetDataSet, "CLIENT")
                ObjetDataTable = ObjetDataSet.Tables("CLIENT")
                Me.TBNOMCLI.Text = ""
                Me.TBADRCLI.Text = ""
                Me.TBSIECLI.Text = ""

                MsgBox("enregistrement reussi")
                ObjetConnection.Close()
            Else
                MsgBox(" UN CLIENT PORTANT CE NOM EXISTE DEJA!")
                Me.TBNOMCLI.Text = ""
                Me.TBADRCLI.Text = ""
                Me.TBSIECLI.Text = ""
            End If
        End If

    End Sub

End Class