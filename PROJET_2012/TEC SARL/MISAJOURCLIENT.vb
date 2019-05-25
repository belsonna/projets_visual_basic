Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class MISAJOURCLIENT

    Private Sub MISAJOURCLIENT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.CLIENT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CLIENTTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.CLIENT)
       
        Try
            Me.CLIENTTableAdapter.FillBy(Me.LOCAL_BUYING_HOUSEDataSet1.CLIENT)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBNOMMISCLI.TextChanged, TBSIEMISCLI.TextChanged, TBADRMISCLI.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.ComboBox1.Text = "" Then
            MsgBox("veuillez choisir l'element à modifier")
        Else
            Me.Label3.Visible = True
            Me.Label4.Visible = True
            Me.Label5.Visible = True
            Me.Label6.Visible = True
            Me.TBNOMMISCLI.Visible = True
            Me.TBADRMISCLI.Visible = True
            Me.TBSIEMISCLI.Visible = True
            Me.BTOKMISCLI.Visible = True
            Me.BTANUMISCLI.Visible = True
            Me.BTANUMISCLI.Visible = True
            Me.TBNOMMISCLI.Text = Me.ComboBox1.Text
        End If
    End Sub

    Private Sub BTANUMISCLI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANUMISCLI.Click
        Me.Label3.Visible = False
        Me.Label4.Visible = False
        Me.Label5.Visible = False
        Me.Label6.Visible = False
        Me.TBNOMMISCLI.Visible = False
        Me.TBADRMISCLI.Visible = False
        Me.TBSIEMISCLI.Visible = False
        Me.BTOKMISCLI.Visible = False
        Me.BTANUMISCLI.Visible = False
    End Sub

    Private Sub BTOKMISCLI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOKMISCLI.Click

        If (Me.TBADRMISCLI.Text = "" Or Me.TBNOMMISCLI.Text = "" Or Me.TBSIEMISCLI.Text = "") Then
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
            strSql = "UPDATE CLIENT SET NomCli='" + Me.TBNOMMISCLI.Text + "', AdresseCli='" + Me.TBADRMISCLI.Text + "',SiegeCli= '" + Me.TBSIEMISCLI.Text + "'WHERE NomCli='" + ComboBox1.Text + "'"
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
            ObjetDataTable = ObjetDataSet.Tables("CLIENT")
            ObjetDataAdapter.Fill(ObjetDataSet, "CLIENT")
            Try
                Me.CLIENTTableAdapter.FillBy(Me.LOCAL_BUYING_HOUSEDataSet1.CLIENT)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try


          



            Me.TBNOMMISCLI.Text = ""
            Me.TBADRMISCLI.Text = ""
            Me.TBSIEMISCLI.Text = ""
            Me.Label3.Visible = False
            Me.Label4.Visible = False
            Me.Label5.Visible = False
            Me.Label6.Visible = False
            Me.TBNOMMISCLI.Visible = False
            Me.TBADRMISCLI.Visible = False
            Me.TBSIEMISCLI.Visible = False
            Me.BTOKMISCLI.Visible = False
            Me.BTANUMISCLI.Visible = False


            MsgBox("modification reussie")
            ObjetConnection.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.ComboBox1.Text = "" Then
            MsgBox(" veuillez choisir l'element à supprimer")
        Else
            Dim ObjetConnection As SqlConnection
            Dim ObjetCommand As SqlCommand
            Dim ObjetDataAdapter As SqlDataAdapter
            Dim ObjetDataSet As New DataSet
            Dim strSql As String
            Dim ObjetDataTable As DataTable
            Dim strConn As String

            strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
            strSql = "UPDATE CLIENT SET partenaire='non' WHERE NomCli='" + ComboBox1.Text + "'"
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
            ObjetDataTable = ObjetDataSet.Tables("CLIENT")
            ObjetDataAdapter.Fill(ObjetDataSet, "CLIENT")
            Try
                Me.CLIENTTableAdapter.FillBy(Me.LOCAL_BUYING_HOUSEDataSet1.CLIENT)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            MsgBox("suppression reussie")
            ObjetConnection.Close()
        End If



    End Sub

  



    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByToolStripButton.Click
      
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        RESTAURER_CLIENT.ShowDialog()

    End Sub
End Class