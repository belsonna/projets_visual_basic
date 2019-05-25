Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class PROFORMER

    Private Sub PROFORMER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.PRODUIT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PRODUITTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.PRODUIT)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.PROFORMA'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PROFORMATableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.PROFORMA)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, Label7.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click

    End Sub

    Private Sub BTANUPROFER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANUPROFER.Click
        Me.TBNUMPROFER.Text = ""
        Me.ListBox1.Text = ""
        Me.ListBox2.Text = ""
        Me.TBQTEPROFER.Text = ""
        Me.TBPUPROFER.Text = ""

    End Sub

    Private Sub BTPREPROFER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPREPROFER.Click
        Me.Close()
    End Sub

    Private Sub BTENRPROFER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENRPROFER.Click
        If (Me.TBNUMPROFER.Text = "" Or Me.TBPUPROFER.Text = "" Or Me.TBQTEPROFER.Text = "") Then
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
            strSql = "INSERT INTO PROFORMER(NumProfer, ProfProfer,ProProf,Qtee,PUe) VALUES ('" + TBNUMPROFER.Text + "','" + ListBox1.Text + "','" + ListBox2.Text + "','" + TBQTEPROFER.Text + "','" + TBPUPROFER.Text + "') "
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
            ObjetDataAdapter.Fill(ObjetDataSet, "PROFORMER")
            ObjetDataTable = ObjetDataSet.Tables("PROFORMER")
            Me.TBNUMPROFER.Text = ""
            Me.ListBox1.Text = ""
            Me.ListBox2.Text = ""
            Me.TBQTEPROFER.Text = ""
            Me.TBPUPROFER.Text = ""

            MsgBox("enregistrement reussi")
            ObjetConnection.Close()
        End If

    End Sub
End Class