﻿Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class RESTAURER_FOURNISSEUR

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.ComboBox1.Text = "" Then
            MsgBox(" veuillez choisir l'element a supprimer")
        Else
            Dim ObjetConnection As SqlConnection
            Dim ObjetCommand As SqlCommand
            Dim ObjetDataAdapter As SqlDataAdapter
            Dim ObjetDataSet As New DataSet
            Dim strSql As String
            Dim ObjetDataTable As DataTable
            Dim strConn As String

            strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
            strSql = "UPDATE FOURNISSEUR SET partenaire ='oui'WHERE NomFour='" + ComboBox1.Text + "'"
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
            ObjetDataTable = ObjetDataSet.Tables("FOURNISSEUR")
            ObjetDataAdapter.Fill(ObjetDataSet, "FOURNISSEUR")
            Try
                Me.FOURNISSEURTableAdapter.FillBy3(Me.LOCAL_BUYING_HOUSEDataSet.FOURNISSEUR)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            Me.Close()
            MISAJOURfournisseur.Close()
        End If
    End Sub

    Private Sub RESTAURER_FOURNISSEUR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet.FOURNISSEUR'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.FOURNISSEURTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet.FOURNISSEUR)
        Try
            Me.FOURNISSEURTableAdapter.FillBy3(Me.LOCAL_BUYING_HOUSEDataSet.FOURNISSEUR)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy3ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.FOURNISSEURTableAdapter.FillBy3(Me.LOCAL_BUYING_HOUSEDataSet.FOURNISSEUR)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class