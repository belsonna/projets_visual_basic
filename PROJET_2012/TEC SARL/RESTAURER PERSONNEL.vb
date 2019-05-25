Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class RESTAURER_PERSONNEL

    Private Sub RESTAURER_PERSONNEL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet.PERSONNEL'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PERSONNELTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet.PERSONNEL)
        Try
            Me.PERSONNELTableAdapter.FillBy3(Me.LOCAL_BUYING_HOUSEDataSet.PERSONNEL)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub FillBy3ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.PERSONNELTableAdapter.FillBy3(Me.LOCAL_BUYING_HOUSEDataSet.PERSONNEL)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ObjetConnection As SqlConnection
        Dim ObjetCommand As SqlCommand
        Dim ObjetDataAdapter As SqlDataAdapter
        Dim ObjetDataSet As New DataSet
        Dim strSql As String
        Dim ObjetDataTable As DataTable
        Dim strConn As String




        strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
        If Me.ComboBox1.Text = "" Then
            MsgBox(" veuillez choisir l'element à restaurer")
        Else

            strSql = "UPDATE PERSONNEL SET  licencie='non' WHERE NomPer='" + Me.ComboBox1.Text + "'"
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
            Try
                Me.PERSONNELTableAdapter.FillBy3(Me.LOCAL_BUYING_HOUSEDataSet.PERSONNEL)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            Me.Close()
            MIS_A_JOUR_PERSONNEL.Close()


        End If

    End Sub

    Private Sub FillBy3ToolStrip_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
End Class