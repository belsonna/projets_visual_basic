Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class MIS_A_JOUR_PERSONNEL

    Private Sub MIS_A_JOUR_PERSONNEL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.PERSONNEL'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PERSONNELTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.PERSONNEL)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.PERSONNEL'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PERSONNELTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.PERSONNEL)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet.PERSONNEL'. Vous pouvez la déplacer ou la supprimer selon vos besoins
        Try
            Me.PERSONNELTableAdapter.FillBy1(Me.LOCAL_BUYING_HOUSEDataSet1.PERSONNEL)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.ComboBoxMISPER.Text = "" Then
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
            strSql = "UPDATE PERSONNEL SET  licencie='oui' WHERE NomPer='" + Me.ComboBoxMISPER.Text + "'"
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
            ObjetDataTable = ObjetDataSet.Tables("PERSONNEL")
            ObjetDataAdapter.Fill(ObjetDataSet, "PERSONNEL")
            Try
                Me.PERSONNELTableAdapter.FillBy1(Me.LOCAL_BUYING_HOUSEDataSet1.PERSONNEL)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
            MsgBox("suppression reussie")
            ObjetConnection.Close()
        End If



    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxMISPER.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.ComboBoxMISPER.Text = "" Then
            MsgBox("veuillez chisir l'element à modifier")
        Else
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            BTOKMISPER.Visible = True
            TBNUMMISPER.Visible = True
            TBNOMMISPER.Visible = True
            TBADRMISPER.Visible = True
            TBSERMISPER.Visible = True
            TBENTMISPER.Visible = True
            TBLOGMISPER.Visible = True
            BTCANMISPER.Visible = True
            Me.TBNOMMISPER.Text = Me.ComboBoxMISPER.Text
        End If






    End Sub

    Private Sub BTOKMISPER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOKMISPER.Click
        If (Me.TBADRMISPER.Text = "" Or Me.TBENTMISPER.Text = "" Or Me.TBLOGMISPER.Text = "" Or Me.TBNOMMISPER.Text = "" Or Me.TBNUMMISPER.Text = "" Or Me.TBSERMISPER.Text = "") Then
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
            strSql = "UPDATE PERSONNEL SET NumPer='" + Me.TBNUMMISPER.Text + "', NomPer='" + Me.TBNOMMISPER.Text + "',AdressePer=' " + Me.TBADRMISPER.Text + "',ServicePer='" + Me.TBSERMISPER.Text + "',Entrepriseper=' " + Me.TBENTMISPER.Text + "',LoginPer='" + Me.TBLOGMISPER.Text + " 'WHERE NomPer='" + ComboBoxMISPER.Text + "'"
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
            ObjetDataTable = ObjetDataSet.Tables("PERSONNEL")
            ObjetDataAdapter.Fill(ObjetDataSet, "PERSONNEL")
            Try
                Me.PERSONNELTableAdapter.FillBy1(Me.LOCAL_BUYING_HOUSEDataSet1.PERSONNEL)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
      

            TBNUMMISPER.Text = ""
            TBADRMISPER.Text = ""
            TBENTMISPER.Text = ""
            TBLOGMISPER.Text = ""
            TBNOMMISPER.Text = ""
            TBSERMISPER.Text = ""
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            BTOKMISPER.Visible = False
            TBNUMMISPER.Visible = False
            TBNOMMISPER.Visible = False
            TBADRMISPER.Visible = False
            TBSERMISPER.Visible = False
            TBENTMISPER.Visible = False
            TBLOGMISPER.Visible = False
            BTCANMISPER.Visible = False

            MsgBox("modification reussie")
            ObjetConnection.Close()
        End If

    End Sub

    Private Sub BTCANMISPER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTCANMISPER.Click
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        BTOKMISPER.Visible = False
        TBNUMMISPER.Visible = False
        TBNOMMISPER.Visible = False
        TBADRMISPER.Visible = False
        TBSERMISPER.Visible = False
        TBENTMISPER.Visible = False
        TBLOGMISPER.Visible = False
        BTCANMISPER.Visible = False
    End Sub

   

    Private Sub TBNUMMISPER_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBNUMMISPER.TextChanged

    End Sub

    Private Function LOCAL_BUYING_HOUSEDataSet() As Object
        Throw New NotImplementedException
    End Function

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.PERSONNELTableAdapter.FillBy(Me.LOCAL_BUYING_HOUSEDataSet1.PERSONNEL)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        RESTAURER_PERSONNEL.ShowDialog()


    End Sub

    Private Sub FillBy3ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.PERSONNELTableAdapter.FillBy4(Me.LOCAL_BUYING_HOUSEDataSet1.PERSONNEL)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ObjetConnection As SqlConnection
        Dim ObjetCommand As SqlCommand
        Dim ObjetDataAdapter As SqlDataAdapter
        Dim ObjetDataSet As New DataSet
        Dim strSql As String
        Dim ObjetDataTable As DataTable
        Dim strConn As String




        strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
        If Me.ComboBoxMISPER.Text = "" Then
            MsgBox(" veuillez choisir l'element à restaurer")
        Else

            strSql = "UPDATE PERSONNEL SET  licencie='non' WHERE NomPer='" + Me.ComboBoxMISPER.Text + "'"
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

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FillBy4ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy4ToolStripButton.Click
        Try
            Me.PERSONNELTableAdapter.FillBy4(Me.LOCAL_BUYING_HOUSEDataSet1.PERSONNEL)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class