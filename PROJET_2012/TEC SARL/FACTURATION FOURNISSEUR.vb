Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class FACTURATION_FOURNISSEUR

    Private Sub FACTURATION_FOURNISSEUR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.PRODUIT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PRODUITTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.PRODUIT)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.PERSONNEL'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PERSONNELTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.PERSONNEL)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.PROFORMA'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.PROFORMATableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.PROFORMA)
        'TODO: cette ligne de code charge les données dans la table 'LOCAL_BUYING_HOUSEDataSet1.COMMANDETEC'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.COMMANDETECTableAdapter.Fill(Me.LOCAL_BUYING_HOUSEDataSet1.COMMANDETEC)
        Try
            Me.PERSONNELTableAdapter.FillBy2(Me.LOCAL_BUYING_HOUSEDataSet1.PERSONNEL)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BTENREGFACF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENREGFACF.Click
        If (Me.TBNUMFAC.Text = "") Then
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
            strSql = "SELECT * FROM FACTURERF WHERE NumFacF='" + TBNUMFAC.Text + "' OR ComTecFacF='" + ComboBox1.Text + "'"
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
            ObjetDataAdapter.Fill(ObjetDataSet, "FACTURERF")
            ObjetDataTable = ObjetDataSet.Tables("FACTURERF")
            ObjetConnection.Close()
            If ObjetDataTable.Rows.Count < 1 Then
                strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
                strSql = "INSERT INTO FACTURERF(NumFacF,ComTecFacF,PersoFacF,DateFacF) VALUES ('" + TBNUMFAC.Text + "','" + ComboBox1.Text + "','" + ComboBox2.Text + "','" + DateTimePicker1.Value + "') "
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
                ObjetDataAdapter.Fill(ObjetDataSet, "FACTURERF")
                ObjetDataTable = ObjetDataSet.Tables("FACTURERF")

                Me.TBNUMFAC.Text = ""
                MsgBox("enregistrement reussi")
                ObjetConnection.Close()
            Else
                MsgBox(" FACTURATION DEJA ENREGISTREE")
                Me.TBNUMFAC.Text = ""
            End If
        End If
    End Sub

    Private Sub FillBy2ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class