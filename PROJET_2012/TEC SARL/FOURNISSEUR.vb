Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class FOURNISSEUR

    Private Sub BTANUFOUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANUFOUR.Click
        Me.TBNOMFOU.Text() = ""
        Me.TBADRFOU.Text() = ""
        Me.TBSIEFOU.Text() = ""
        Me.ListBox1.Text() = ""
    End Sub

    Private Sub BTENRFOUR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENRFOUR.Click
        If (Me.TBADRFOU.Text = "" Or Me.TBNOMFOU.Text = "" Or Me.TBSIEFOU.Text = "") Then
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
            strSql = "INSERT INTO FOURNISSEUR (NomFour,AdresseFour,SiegeSocialFour,TypeFour) VALUES ('" + TBNOMFOU.Text + "','" + TBADRFOU.Text + "','" + TBSIEFOU.Text + "','" + ListBox1.Text + "') "
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
            ObjetDataAdapter.Fill(ObjetDataSet, "FOURNISSEUR")
            ObjetDataTable = ObjetDataSet.Tables("FOURNISSEUR")
            ObjetConnection.Close()
            If ObjetDataTable.Rows.Count < 1 Then
                strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
                strSql = "INSERT INTO FOURNISSEUR (NomFour,AdresseFour,SiegeSocialFour,TypeFour) VALUES ('" + TBNOMFOU.Text + "','" + TBADRFOU.Text + "','" + TBSIEFOU.Text + "','" + ListBox1.Text + "') "
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
                ObjetDataAdapter.Fill(ObjetDataSet, "FOURNISSEUR")
                ObjetDataTable = ObjetDataSet.Tables("FOURNISSEUR")
                Me.TBNOMFOU.Text() = ""
                Me.TBADRFOU.Text() = ""
                Me.TBSIEFOU.Text() = ""

                MsgBox("enregistrement reussi")
                ObjetConnection.Close()
            Else
                MsgBox(" CE FOURNISSEUR EST DEJA ENREGISTRE")
                Me.TBNOMFOU.Text() = ""
                Me.TBADRFOU.Text() = ""
                Me.TBSIEFOU.Text() = ""

            End If
        End If

    End Sub

    Private Sub FOURNISSEUR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.TYPEPRODUIT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.TYPEPRODUITTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.TYPEPRODUIT)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class