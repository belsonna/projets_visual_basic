Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class RESTAURER_PRO_FORMA

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.ComboBox1.Text = "" Then
            MsgBox(" veuillez choisir l'element à supprimer")
        Else
            Dim ObjetConnection As SqlConnection
            Dim ObjetCommand As SqlCommand
            Dim ObjetDataAdapter As SqlDataAdapter
            Dim ObjetDataSet As New DataSet
            Dim strSql1 As String

            Dim ObjetDataTable As DataTable
            Dim strConn As String

            strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
            strSql1 = "UPDATE PROFORMA SET abouti='oui'WHERE  NumProf='" + Me.ComboBox1.Text + "' "
            ObjetConnection = New SqlConnection
            ObjetConnection.ConnectionString = strConn
            Try
                ObjetConnection.Open()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            ObjetCommand = New SqlCommand(strSql1)
            ObjetDataAdapter = New SqlDataAdapter(ObjetCommand)
            ObjetCommand.Connection() = ObjetConnection
            ObjetDataTable = ObjetDataSet.Tables("PROFORMA")
            ObjetDataAdapter.Fill(ObjetDataSet, "PROFORMA")
            Try
                Me.PROFORMATableAdapter.FillBy1(Me.LOCAL_BUYING_HOUSEDataSet.PROFORMA)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            Me.Close()
            MISE_A_JOUR_PROFORMA.Close()

        End If

    End Sub

    Private Sub RESTAURER_PRO_FORMA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet.PROFORMA'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PROFORMATableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet.PROFORMA)
        Try
            Me.PROFORMATableAdapter.FillBy1(Me.LOCAL_BUYING_HOUSEDataSet.PROFORMA)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.PROFORMATableAdapter.FillBy1(Me.LOCAL_BUYING_HOUSEDataSet.PROFORMA)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class