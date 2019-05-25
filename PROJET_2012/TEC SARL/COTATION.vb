Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class COTATION

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click, Label4.Click, Label3.Click

    End Sub
    Private Sub COTATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENRCOT.Click
        If (Me.TBNUMCOT.Text = "" Or Me.TBOBJCOT.Text = "") Then
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
            strSql = "SELECT * FROM COTATION WHERE NumCot='" + TBNUMCOT.Text + "'"
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
            ObjetDataAdapter.Fill(ObjetDataSet, "COTATION")
            ObjetDataTable = ObjetDataSet.Tables("COTATION")
           
            ObjetConnection.Close()
            If ObjetDataTable.Rows.Count < 1 Then
                strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"
                strSql = "INSERT INTO COTATION ( NumCot,ObjetCot,DateCot) VALUES ('" + TBNUMCOT.Text + "','" + TBOBJCOT.Text + "','" + Me.DateCot.Value + "' ) "
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
                ObjetDataAdapter.Fill(ObjetDataSet, "COTATION")
                ObjetDataTable = ObjetDataSet.Tables("COTATION")
                Me.TBNUMCOT.Text = ""
                Me.TBOBJCOT.Text = ""
                MsgBox("enregistrement reussi")
                ObjetConnection.Close()
            Else
                MsgBox(" CETTE COTATION EST DEJA ENREGISTREE")
                Me.TBNUMCOT.Text = ""
                Me.TBOBJCOT.Text = ""
            End If

        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BTANUCOT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTANUCOT.Click
        Me.TBNUMCOT.Text = ""
        Me.TBOBJCOT.Text = ""

    End Sub
End Class