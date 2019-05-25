Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class LIVRAISON_FOURNISSEUR

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANULIVF.Click
        Me.TBNUMLIVF.Text = ""
        Me.TBQTELIVF.Text = ""
        Me.TBPULIVF.Text = ""


    End Sub

    Private Sub LIVRAISON_FOURNISSEUR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.PRODUIT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PRODUITTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.PRODUIT)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.COMMANDETEC'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.COMMANDETECTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.COMMANDETEC)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BTENRLIVF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENRLIVF.Click
        If (Me.TBNUMLIVF.Text = "" Or Me.TBPULIVF.Text = "" Or Me.TBQTELIVF.Text = "") Then
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
            strSql = "SELECT * FROM LIVRERF WHERE NumLivF='" + TBNUMLIVF.Text + "' OR  ComTec='" + ListBox1.Text + "'"
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
            ObjetDataAdapter.Fill(ObjetDataSet, "LIVRERF")
            ObjetDataTable = ObjetDataSet.Tables("LIVRERF")
            ObjetConnection.Close()
            If ObjetDataTable.Rows.Count < 1 Then

                strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
                strSql = "INSERT INTO LIVRERF(ComTec,ProLiv,NumlivF,QteLiv,PULiv) VALUES ('" + ListBox1.Text + "','" + ListBox2.Text + "',' " + TBNUMLIVF.Text + "','" + TBQTELIVF.Text + " ',' " + TBPULIVF.Text + "') "
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
                ObjetDataAdapter.Fill(ObjetDataSet, "LIVRERF")
                ObjetDataTable = ObjetDataSet.Tables("LIVRERF")
                Me.TBNUMLIVF.Text = ""
                Me.TBPULIVF.Text = ""
                Me.TBQTELIVF.Text = ""
                MsgBox("enregistrement reussi")
                ObjetConnection.Close()
            Else
                MsgBox(" LIVRAISON DEJA ENREGISTREE")
                Me.TBNUMLIVF.Text = ""
                Me.TBPULIVF.Text = ""
                Me.TBQTELIVF.Text = ""
            End If
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class