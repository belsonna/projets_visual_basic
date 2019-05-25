Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class CONFIRMER


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CONFIRMER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.CLIENT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CLIENTTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.CLIENT)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.COMMANDE_COTCO'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.COMMANDECOTCOTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.COMMANDECOTCO)
        Try
            Me.CLIENTTableAdapter.FillBy2(Me.LOCAL_BUYING_HOUSEDataSet1.CLIENT)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BTANUCON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANUCON.Click
        Me.TBSERCON.Text = ""
    End Sub

    Private Sub BTENRCON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENRCON.Click

        If (Me.TBSERCON.Text = "") Then
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
            strSql = "SELECT * FROM CONFIRMER WHERE ServiceEntry='" + TBSERCON.Text + "' OR  POCon='" + ComboBox1.Text + "'"
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
            ObjetDataAdapter.Fill(ObjetDataSet, "CONFIRMER")
            ObjetDataTable = ObjetDataSet.Tables("CONFIRMER")

            ObjetConnection.Close()

            If ObjetDataTable.Rows.Count < 1 Then
                strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
                strSql = "INSERT INTO CONFIRMER (ServiceEntry,POCon,CliCon,DateCon) VALUES ('" + TBSERCON.Text + "','" + ComboBox1.Text + "','" + ComboBox2.Text + "','" + DateCON.Value + "') "
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
                ObjetDataAdapter.Fill(ObjetDataSet, "CONFIRMER")
                ObjetDataTable = ObjetDataSet.Tables("CONFIRMER")
                Me.TBSERCON.Text = ""
                MsgBox("enregistrement reussi")
                ObjetConnection.Close()
            Else
                MsgBox(" CE NUMERO DE SERVICE ENTRY A DEJA ETE ATTRIBUE A UNE COMMANDE                                             OU CE PO A DEJA UN SERVICE ENTRY ")
                Me.TBSERCON.Text = ""

            End If
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub FillBy2ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
End Class