Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class PRODUIT

    Private Sub BTANUPRO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANUPRO.Click
        Me.TBNOMPRO.Text = ""
        Me.LBSSECPRO.Text = ""
    End Sub

    Private Sub BTENRPRO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENRPRO.Click
        If (Me.TBNOMPRO.Text = "") Then
            MsgBox("veuillez completer les informations")
        Else
            Dim ObjetConnection As SqlConnection
            Dim ObjetCommand As SqlCommand
            Dim ObjetDataAdapter As SqlDataAdapter
            Dim ObjetDataSet As New DataSet
            Dim strSql As String
            Dim ObjetDataTable As DataTable
            Dim strConn As String
            strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
            strSql = "SELECT * FROM  PRODUIT WHERE NomPro='" + TBNOMPRO.Text + "'"
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
            ObjetDataAdapter.Fill(ObjetDataSet, "PRODUIT")
            ObjetDataTable = ObjetDataSet.Tables("PRODUIT")

            ObjetConnection.Close()
            If ObjetDataTable.Rows.Count < 1 Then
                strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
                strSql = "INSERT INTO PRODUIT (NomPro,Secteur) VALUES ('" + TBNOMPRO.Text + "','" + Me.LBSSECPRO.Text + "') "
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
                ObjetDataAdapter.Fill(ObjetDataSet, "PRODUIT")
                ObjetDataTable = ObjetDataSet.Tables("PRODUIT")
                Me.TBNOMPRO.Text() = ""


                MsgBox("enregistrement reussi")
                ObjetConnection.Close()
            Else
                MsgBox(" CE PRODUIT EST DEJA ENREGISTRE")
                Me.TBNOMPRO.Text() = ""

            End If
        End If
    End Sub

    Private Sub PRODUIT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.TYPEPRODUIT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.TYPEPRODUITTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.TYPEPRODUIT)

    End Sub

    Private Sub LBSSECPRO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBSSECPRO.SelectedIndexChanged

    End Sub
End Class