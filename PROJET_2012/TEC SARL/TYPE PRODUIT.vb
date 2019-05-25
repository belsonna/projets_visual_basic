Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class TYPE_PRODUIT

    Private Sub BTANUTYP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANUTYP.Click
        Me.TBNOMTYP.Text = ""
        Me.TBDESTYP.Text = ""
    End Sub

    Private Sub BTENRTYP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENRTYP.Click
        If (Me.TBDESTYP.Text = "" Or Me.TBNOMTYP.Text = "") Then
            MsgBox(" veuillez completer les informationns")
        Else
            Dim ObjetConnection As SqlConnection
            Dim ObjetCommand As SqlCommand
            Dim ObjetDataAdapter As SqlDataAdapter
            Dim ObjetDataSet As New DataSet
            Dim strSql As String
            Dim ObjetDataTable As DataTable
            Dim strConn As String

            strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
            strSql = "SELECT * FROM TYPEPRODUIT WHERE NomType='" + TBNOMTYP.Text + "'"
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
            ObjetDataAdapter.Fill(ObjetDataSet, "TYPEPRODUIT")
            ObjetDataTable = ObjetDataSet.Tables("TYPEPRODUIT")

            ObjetConnection.Close()
            If ObjetDataTable.Rows.Count < 1 Then

                strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
                strSql = "INSERT INTO TYPEPRODUIT(NomType,DesignationType) VALUES ('" + TBNOMTYP.Text + "','" + TBDESTYP.Text + "') "
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
                ObjetDataAdapter.Fill(ObjetDataSet, "TYPEPRODUIT")
                ObjetDataTable = ObjetDataSet.Tables("TYPEPRODUIT")
                Me.TBNOMTYP.Text = ""
                Me.TBDESTYP.Text = ""
                MsgBox("enregistrement reussi")
                ObjetConnection.Close()
            Else
                MsgBox(" CE TYPE DE PRODUIT EXISTE DEJA")
                Me.TBNOMTYP.Text = ""
                Me.TBDESTYP.Text = ""
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class