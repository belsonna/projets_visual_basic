Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class COMMANDE_COTCO

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click, Label7.Click, Label6.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub COMMANDECOTCO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.COMMANDECOTCO'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.COMMANDECOTCOTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.COMMANDECOTCO)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.COTATION'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.COTATIONTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.COTATION)

    End Sub

    Private Sub BTANUPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANUPO.Click
        Me.TBNUMPO.Text = ""
        Me.TBOBJPO.Text = ""
        Me.TBLETRCOT.Text = ""
        Me.TBMONCOT.Text = ""

    End Sub

    Private Sub BTENRPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENRPO.Click
        If (Me.TBNUMPO.Text = "" Or Me.TBOBJPO.Text = "") Then
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
            strSql = "SELECT * FROM COMMANDECOTCO WHERE NumPO ='" + TBNUMPO.Text + "'"
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
            ObjetDataAdapter.Fill(ObjetDataSet, "COMMANDECOTCO")
            ObjetDataTable = ObjetDataSet.Tables("COMMANDECOTCO")
            ObjetConnection.Close()

            If ObjetDataTable.Rows.Count < 1 Then

                strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
                strSql = "INSERT INTO COMMANDECOTCO(NumPO, CotPO,ObjetPO,DatePO,total,lettre) VALUES ('" + TBNUMPO.Text + "','" + ListBox1.Text + "','" + TBOBJPO.Text + "','" + DateTimePicker1.Value + "','" + TBMONCOT.Text + "','" + TBLETRCOT.Text + "') "
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
                ObjetDataAdapter.Fill(ObjetDataSet, "COMMANDECOTCO")
                ObjetDataTable = ObjetDataSet.Tables("COMMANDECOTCO")
                Me.TBNUMPO.Text = ""
                Me.TBOBJPO.Text = ""
                Me.TBLETRCOT.Text = ""
                Me.TBMONCOT.Text = ""
                MsgBox("enregistrement reussi")
                ObjetConnection.Close()
            Else
                MsgBox("CETTE COMMANDE EST DEJA ENREGISTRER")
                Me.TBNUMPO.Text = ""
                Me.TBOBJPO.Text = ""
                Me.TBLETRCOT.Text = ""
                Me.TBMONCOT.Text = ""
            End If
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class