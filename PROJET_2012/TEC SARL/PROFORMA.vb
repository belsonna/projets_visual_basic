
Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class PROFORMA

    Private Sub BTANUPROF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANUPROF.Click
        Me.TBNUMPROF.Text = ""
        Me.TBOBJPROF.Text = ""
        Me.ListBox1.Text = ""
        Me.ListBox2.Text = ""
        Me.ListBox3.Text = ""
    End Sub

    Private Sub BTSUIPROF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Me.TBNUMPROF.Text = "" Or Me.TBOBJPROF.Text = "") Then
            MsgBox(" enregistrer d'abord la PRO FORMA en question")
        Else
            PROFORMER.ShowDialog()
        End If

    End Sub

    Private Sub BTENRPROF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENRPROF.Click
        If (Me.TBNUMPROF.Text = "" Or Me.TBOBJPROF.Text = "") Then
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
            strSql = "SELECT * FROM PROFORMA WHERE NumProf='" + TBNUMPROF.Text + "'"
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
            ObjetDataAdapter.Fill(ObjetDataSet, "PROFORMA")
            ObjetDataTable = ObjetDataSet.Tables("PROFORMA")
            ObjetConnection.Close()
            If ObjetDataTable.Rows.Count < 1 Then
                strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
                strSql = "INSERT INTO PROFORMA ( NumProf,ObjetProf,DateProf,TypeProf,CotProf,FourProf) VALUES ('" + TBNUMPROF.Text + "','" + TBOBJPROF.Text + "',' " + Me.Dateprof.Value + " ','" + ListBox1.Text + "','" + ListBox2.Text + "','" + ListBox3.Text + "') "
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
                ObjetDataAdapter.Fill(ObjetDataSet, "PROFORMA")
                ObjetDataTable = ObjetDataSet.Tables("PROFORMA")
                Me.TBNUMPROF.Text = ""
                Me.TBOBJPROF.Text = ""
                MsgBox("enregistrement reussi")
                ObjetConnection.Close()
                PROFORMER.ShowDialog()
            Else
                MsgBox(" CETTE PRO FORMA EST DEJA ENREGISTREE")
                Me.TBNUMPROF.Text = ""
                Me.TBOBJPROF.Text = ""
            End If
        End If
    End Sub

    Private Sub PROFORMA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.FOURNISSEUR'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.FOURNISSEURTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.FOURNISSEUR)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.COTATION'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.COTATIONTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.COTATION)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.TYPEPRODUIT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.TYPEPRODUITTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.TYPEPRODUIT)
        Try
            Me.FOURNISSEURTableAdapter.FillBy2(Me.LOCAL_BUYING_HOUSEDataSet1.FOURNISSEUR)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox3.SelectedIndexChanged

    End Sub

    Private Sub FillBy2ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
End Class