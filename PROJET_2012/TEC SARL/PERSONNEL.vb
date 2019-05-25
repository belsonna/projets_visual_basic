
Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class PERSONNEL

    Private Sub PERSONNEL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.PERSONNEL'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PERSONNELTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.PERSONNEL)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click, Label5.Click

    End Sub

    Private Sub BTANUPER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANUPER.Click
        Me.TBNUMPER.Text = ""
        Me.TBNOMPER.Text = ""
        Me.TBADRPER.Text = ""
        Me.TBSERPER.Text = ""
        Me.TBENTPER.Text = ""
        Me.TBLOGPER.Text = ""
    End Sub

    Private Sub BTENRPER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENRPER.Click
        If (Me.TBADRPER.Text = "" Or Me.TBENTPER.Text = "" Or Me.TBLOGPER.Text = "" Or Me.TBNOMPER.Text = "" Or Me.TBNUMPER.Text = "" Or Me.TBSERPER.Text = "") Then
            MsgBox(" veuillez completez les informations")
        Else
            Dim ObjetConnection As SqlConnection
            Dim ObjetCommand As SqlCommand
            Dim ObjetDataAdapter As SqlDataAdapter
            Dim ObjetDataSet As New DataSet
            Dim strSql As String
            Dim ObjetDataTable As DataTable
            Dim strConn As String
            strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
            strSql = "select *from PERSONNEL where NumPer='" + TBNUMPER.Text + "'"
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
            ObjetDataAdapter.Fill(ObjetDataSet, "PERSONNEL")
            ObjetDataTable = ObjetDataSet.Tables("PERSONNEL")
            ObjetConnection.Close()
            If ObjetDataTable.Rows.Count < 1 Then

                strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
                strSql = "INSERT INTO PERSONNEL(NumPer, NomPer,AdressePer,ServicePer,EntreprisePer,LoginPer) VALUES ('" + TBNUMPER.Text + "','" + TBNOMPER.Text + "','" + TBADRPER.Text + "','" + TBSERPER.Text + "','" + TBENTPER.Text + "','" + TBLOGPER.Text + "') "
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
                ObjetDataAdapter.Fill(ObjetDataSet, "PERSONNEL")
                ObjetDataTable = ObjetDataSet.Tables("PERSONNEL")
                Me.TBNUMPER.Text = ""
                Me.TBNOMPER.Text = ""
                Me.TBADRPER.Text = ""
                Me.TBSERPER.Text = ""
                Me.TBENTPER.Text = ""
                Me.TBLOGPER.Text = ""
                MsgBox("enregistrement reussi")
                ObjetConnection.Close()
            Else
                MsgBox(" CE NUMERO A DEJA ETE ATTRIBUE A UN EMPLOYE")
                Me.TBNUMPER.Text = ""
                Me.TBNOMPER.Text = ""
                Me.TBADRPER.Text = ""
                Me.TBSERPER.Text = ""
                Me.TBENTPER.Text = ""
                Me.TBLOGPER.Text = ""
            End If
        End If
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
End Class