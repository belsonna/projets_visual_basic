Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class LIVRAISON_TEC

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub LIVRAISON_TEC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.PRODUIT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PRODUITTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.PRODUIT)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.COMMANDE_COTCO'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.COMMANDECOTCOTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.COMMANDECOTCO)

    End Sub

    Private Sub BTANUENRLIVT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANUENRLIVT.Click
        Me.ComboBox1.Text = ""
        Me.ComboBox2.Text = ""
        Me.TBNUMLIVT.Text = ""
        Me.TBQTELIVT.Text = ""
        Me.TBPULIVT.Text = ""

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub BTENRLIVT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENRLIVT.Click
        If (Me.TBNUMLIVT.Text = "" Or Me.TBPULIVT.Text = "" Or Me.TBQTELIVT.Text = "") Then
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
            strSql = "SELECT * FROM LIVRERTEC WHERE NumLivT= '" + TBNUMLIVT.Text + "' OR POLiv='" + ComboBox1.Text + "'"
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
            ObjetDataAdapter.Fill(ObjetDataSet, "LIVRERTEC")
            ObjetDataTable = ObjetDataSet.Tables("LIVRERTEC")
            ObjetConnection.Close()
            If ObjetDataTable.Rows.Count < 1 Then

                strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
                strSql = "INSERT INTO LIVRERTEC(POLiv,ProPOLivT,NumlivT,QteLivT,PULivT,DateLivT) VALUES ('" + ComboBox1.Text + "','" + ComboBox2.Text + "',' " + TBNUMLIVT.Text + "','" + TBQTELIVT.Text + " ','" + TBPULIVT.Text + "','" + DateTimePicker1.Value + "') "
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
                ObjetDataAdapter.Fill(ObjetDataSet, "LIVRERTEC")
                ObjetDataTable = ObjetDataSet.Tables("LIVRERTEC")

                Me.TBNUMLIVT.Text = ""
                Me.TBPULIVT.Text = ""
                Me.TBQTELIVT.Text = ""
                MsgBox("enregistrement reussi")
                ObjetConnection.Close()
            Else
                MsgBox(" IL EXISTE DEJA UNE LIVRAISON PORTANT CE NUMERO")
                Me.TBNUMLIVT.Text = ""
                Me.TBPULIVT.Text = ""
                Me.TBQTELIVT.Text = ""
            End If
        End If
    End Sub
End Class