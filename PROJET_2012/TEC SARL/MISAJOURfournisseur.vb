Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class MISAJOURfournisseur

    Private Sub MISAJOURPRODUIT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.TYPEPRODUIT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.TYPEPRODUITTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.TYPEPRODUIT)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.FOURNISSEUR'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.FOURNISSEURTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.FOURNISSEUR)
        Try
            Me.FOURNISSEURTableAdapter.FillBy(Me.LOCAL_BUYING_HOUSEDataSet1.FOURNISSEUR)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

       
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (Me.TBADRMISFOUR.Text = "" Or Me.TBNOMMISFOUR.Text = "" Or Me.TBSIEMISFOUR.Text = "") Then
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
            strSql = "UPDATE FOURNISSEUR SET NomFour='" + Me.TBNOMMISFOUR.Text + "', AdresseFour='" + Me.TBADRMISFOUR.Text + "',SiegeSocialFour= '" + Me.TBSIEMISFOUR.Text + "', TypeFour='" + Me.ComboBox2.Text + "' WHERE NomFour='" + ComboBox1.Text + "'"
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
            ObjetDataTable = ObjetDataSet.Tables("FOURNISSEUR")
            ObjetDataAdapter.Fill(ObjetDataSet, "FOURNISSEUR")
            Try
                Me.FOURNISSEURTableAdapter.FillBy(Me.LOCAL_BUYING_HOUSEDataSet1.FOURNISSEUR)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
          

            Me.TBNOMMISFOUR.Text = ""
            Me.TBADRMISFOUR.Text = ""
            Me.TBSIEMISFOUR.Text = ""
            Me.Label2.Visible = False
            Me.Label3.Visible = False
            Me.Label4.Visible = False
            Me.Label5.Visible = False
            Me.Label6.Visible = False
            Me.TBNOMMISFOUR.Visible = False
            Me.TBADRMISFOUR.Visible = False
            Me.TBSIEMISFOUR.Visible = False
            Me.ComboBox2.Visible = False
            Me.Button3.Visible = False
            Me.Button4.Visible = False


            MsgBox("modification reussie")
            ObjetConnection.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If Me.ComboBox1.Text = "" Then
            MsgBox("veuillez choisir l'element à modifier")

        Else
            Me.Label2.Visible = True
            Me.Label3.Visible = True
            Me.Label4.Visible = True
            Me.Label5.Visible = True
            Me.Label6.Visible = True
            Me.TBADRMISFOUR.Visible = True
            Me.TBNOMMISFOUR.Visible = True
            Me.TBSIEMISFOUR.Visible = True
            Me.ComboBox2.Visible = True
            Me.Button3.Visible = True
            Me.Button4.Visible = True
            Me.TBNOMMISFOUR.Text = Me.ComboBox1.Text
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Label2.Visible = False
        Me.Label3.Visible = False
        Me.Label4.Visible = False
        Me.Label5.Visible = False
        Me.Label6.Visible = False
        Me.TBADRMISFOUR.Visible = False
        Me.TBNOMMISFOUR.Visible = False
        Me.TBSIEMISFOUR.Visible = False
        Me.ComboBox2.Visible = False
        Me.Button3.Visible = False
        Me.Button4.Visible = False
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.ComboBox1.Text = "" Then
            MsgBox(" veuillez choisir l'element a supprimer")
        Else
            Dim ObjetConnection As SqlConnection
            Dim ObjetCommand As SqlCommand
            Dim ObjetDataAdapter As SqlDataAdapter
            Dim ObjetDataSet As New DataSet
            Dim strSql As String
            Dim ObjetDataTable As DataTable
            Dim strConn As String

            strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
            strSql = "UPDATE FOURNISSEUR SET partenaire ='non'WHERE NomFour='" + ComboBox1.Text + "'"
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
            ObjetDataTable = ObjetDataSet.Tables("FOURNISSEUR")
            ObjetDataAdapter.Fill(ObjetDataSet, "FOURNISSEUR")
            Try
                Me.FOURNISSEURTableAdapter.FillBy(Me.LOCAL_BUYING_HOUSEDataSet1.FOURNISSEUR)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            MsgBox(" suppression reussie")
            ObjetConnection.Close()
        End If

    End Sub

   
    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        RESTAURER_FOURNISSEUR.ShowDialog()
    End Sub
End Class