Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class MISE_A_JOUR_PROFORMA

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, Label8.Click, Label7.Click, Label6.Click, Label5.Click, Label4.Click, Label3.Click, Label2.Click, Label9.Click

    End Sub
    Private Sub MISE_A_JOUR_PROFORMA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.FOURNISSEUR'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.FOURNISSEURTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.FOURNISSEUR)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.COTATION'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.COTATIONTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.COTATION)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.TYPEPRODUIT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.TYPEPRODUITTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.TYPEPRODUIT)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.PROFORMA'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PROFORMATableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.PROFORMA)
        Try
            Me.PROFORMATableAdapter.FillBy(Me.LOCAL_BUYING_HOUSEDataSet1.PROFORMA)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

       
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged

    End Sub

    Private Sub BTMODMISPROF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTMODMISPROF.Click

        If Me.ComboBox1.Text = "" Then
            MsgBox("veuillez choisir l'element à modifier")
        Else
            Me.Label2.Visible = True
            Me.Label3.Visible = True
            Me.Label4.Visible = True
            Me.Label5.Visible = True
            Me.Label6.Visible = True
            Me.Label7.Visible = True
            Me.Label8.Visible = True
            Me.BTOKMISPROF.Visible = True
            Me.BTANUMISPROF.Visible = True
            Me.TextBox1.Visible = True
            Me.TextBox1.Text = Me.ComboBox1.Text
            Me.TextBox2.Visible = True
            Me.ComboBox2.Visible = True
            Me.ComboBox3.Visible = True
            Me.ComboBox4.Visible = True
            Me.DateTimePicker1.Visible = True
        End If

    End Sub

    Private Sub BTANUMISPROF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANUMISPROF.Click
        Me.Label2.Visible = False
        Me.Label3.Visible = False
        Me.Label4.Visible = False
        Me.Label5.Visible = False
        Me.Label6.Visible = False
        Me.Label7.Visible = False
        Me.Label8.Visible = False
        Me.BTOKMISPROF.Visible = False
        Me.BTANUMISPROF.Visible = False
        Me.TextBox1.Visible = False
        Me.TextBox2.Visible = False
        Me.ComboBox2.Visible = False
        Me.ComboBox3.Visible = False
        Me.ComboBox4.Visible = False
        Me.DateTimePicker1.Visible = False
    End Sub

    Private Sub BTOKMISPROF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOKMISPROF.Click
        If (Me.TextBox1.Text = "" Or Me.TextBox2.Text = "") Then
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
            strSql = "UPDATE PROFORMA SET NumProf='" + Me.TextBox1.Text + "', ObjetProf='" + Me.TextBox2.Text + "',DateProf= '" + Me.DateTimePicker1.Value + "', TypeProf='" + Me.ComboBox2.Text + "',CotProf='" + Me.ComboBox3.Text + "',FourProf='" + Me.ComboBox4.Text + "' WHERE NumProf='" + ComboBox1.Text + "'"
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
            ObjetDataTable = ObjetDataSet.Tables("PROFORMA")
            ObjetDataAdapter.Fill(ObjetDataSet, "PROFORMA")
            'Me.PROFORMATableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.PROFORMA)
            Try
                Me.PROFORMATableAdapter.FillBy(Me.LOCAL_BUYING_HOUSEDataSet1.PROFORMA)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

          


            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
            Me.ComboBox2.Text = ""
            Me.ComboBox3.Text = ""
            Me.ComboBox4.Text = ""
            Me.Label2.Visible = False
            Me.Label3.Visible = False
            Me.Label4.Visible = False
            Me.Label5.Visible = False
            Me.Label6.Visible = False
            Me.Label7.Visible = False
            Me.Label8.Visible = False
            Me.TextBox1.Visible = False
            Me.TextBox2.Visible = False
            Me.ComboBox2.Visible = False
            Me.ComboBox3.Visible = False
            Me.ComboBox4.Visible = False
            Me.ComboBox2.Visible = False
            Me.BTOKMISPROF.Visible = False
            Me.BTANUMISPROF.Visible = False
            Me.DateTimePicker1.Visible = False


            MsgBox("modification reussie")
            ObjetConnection.Close()


        End If
    End Sub

    Private Sub BTSUPMISPROF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTSUPMISPROF.Click
        If Me.ComboBox1.Text = "" Then
            MsgBox(" veuillez choisir l'element à restaurer")
        Else
            Dim ObjetConnection As SqlConnection
            Dim ObjetCommand As SqlCommand
            Dim ObjetDataAdapter As SqlDataAdapter
            Dim ObjetDataSet As New DataSet
            Dim strSql1 As String

            Dim ObjetDataTable As DataTable
            Dim strConn As String

            strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
            strSql1 = "UPDATE PROFORMA SET abouti='non'WHERE  NumProf='" + Me.ComboBox1.Text + "' "
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
                Me.PROFORMATableAdapter.FillBy(Me.LOCAL_BUYING_HOUSEDataSet1.PROFORMA)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try

            MsgBox("Suppression reussie")
            ObjetConnection.Close()
        End If

    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.FOURNISSEURTableAdapter.FillBy1(Me.LOCAL_BUYING_HOUSEDataSet1.FOURNISSEUR)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RESTAURER_PRO_FORMA.ShowDialog()

    End Sub
End Class