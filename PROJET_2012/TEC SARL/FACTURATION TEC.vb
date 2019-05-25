Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class FACTURATION_TEC


    Private Sub BTANUFACT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANUFACT.Click
        Me.TBNUMFACT.Text = ""


    End Sub

    Private Sub FACTURATION_TEC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet.COMMANDECOTCO'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.COMMANDECOTCOTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet.COMMANDECOTCO)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet.CLIENT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CLIENTTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet.CLIENT)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet.CLIENT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CLIENTTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet.CLIENT)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.COMMANDECOTCO'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.COMMANDECOTCOTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.COMMANDECOTCO)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.PRODUIT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PRODUITTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.PRODUIT)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.COMMANDE_COTCO'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.COMMANDECOTCOTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.COMMANDECOTCO)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.CLIENT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.CLIENTTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.CLIENT)
        Try
            Me.CLIENTTableAdapter.FillBy1(Me.LOCAL_BUYING_HOUSEDataSet.CLIENT)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub COMMANDECOTCOBindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BTENRFACT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENRFACT.Click
        If (Me.TBNUMFACT.Text = "") Then
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
            strSql = "select * from FACTURERTEC where NumFacT='" + TBNUMFACT.Text + "' OR POFacT='" + ComboBox1.Text + "' "
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
            Try
                ObjetDataAdapter.Fill(ObjetDataSet, "FACTURERTEC")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            ObjetDataTable = ObjetDataSet.Tables("FACTURERTEC")
            ObjetConnection.Close()
            If ObjetDataTable.Rows.Count < 1 Then
                strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
                strSql = "INSERT INTO FACTURERTEC(POFacT,NumFacT,CliFacT,DateFacT) VALUES ('" + ComboBox1.Text + "','" + TBNUMFACT.Text + "','" + ListBox1.Text + "','" + DateTimePicker1.Value + "') "
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
                Try
                    ObjetDataAdapter.Fill(ObjetDataSet, "FACTURERTEC")
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                ObjetDataTable = ObjetDataSet.Tables("FACTURERTEC")

                Me.TBNUMFACT.Text = ""

                ObjetConnection.Close()
            Else
                MsgBox(" FACTURATION DEJA ENREGISTREE")
                Me.TBNUMFACT.Text = ""
            End If
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.CLIENTTableAdapter.FillBy1(Me.LOCAL_BUYING_HOUSEDataSet1.CLIENT)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.CLIENTTableAdapter.FillBy1(Me.LOCAL_BUYING_HOUSEDataSet1.CLIENT)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy1ToolStripButton1.Click
       

    End Sub

    Private Sub COMMANDECOTCOBindingSource5_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class