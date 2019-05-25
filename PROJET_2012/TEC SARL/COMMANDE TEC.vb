Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class COMMANDE_TEC

    Private Sub COMMANDE_TEC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.PROFORMA'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PROFORMATableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.PROFORMA)

    End Sub

    Private Sub BTANUTEC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANUTEC.Click
        Me.TBNUMTEC.Text = ""
        Me.ListBox1.Text = ""
        Me.TBOBJTEC.Text = ""
    End Sub

    Private Sub BTENRTEC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENRTEC.Click
        If (Me.TBNUMTEC.Text = "" Or Me.TBOBJTEC.Text = "") Then
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
            strSql = "SELECT *FROM  COMMANDETEC WHERE NumTec='" + TBNUMTEC.Text + "'"
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
            ObjetDataAdapter.Fill(ObjetDataSet, "COMMANDETEC")
            ObjetDataTable = ObjetDataSet.Tables("COMMANDETEC")
            ObjetConnection.Close()

            If ObjetDataTable.Rows.Count < 1 Then

                strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
                strSql = "INSERT INTO COMMANDETEC(NumTec, ProfTec,ObjetTec,DateTec) VALUES ('" + TBNUMTEC.Text + "','" + ListBox1.Text + "','" + TBOBJTEC.Text + "','" + DateTimePicker1.Value + "') "
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
                ObjetDataAdapter.Fill(ObjetDataSet, "COMMANDETEC")
                ObjetDataTable = ObjetDataSet.Tables("COMMANDETEC")
                Me.TBNUMTEC.Text = ""
                Me.TBOBJTEC.Text = ""

                MsgBox("enregistrement reussi")
                ObjetConnection.Close()
            Else
                MsgBox(" CETTE COMMANDE EST DEJA ENREGISTREE!")
                Me.TBNUMTEC.Text = ""
                Me.TBOBJTEC.Text = ""
            End If

        End If
    End Sub
End Class