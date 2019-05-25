Imports System.Data.SqlClient
Public Class MODTypeproduit
    Inherits base

#Region "Constructor And Destructor"
    Sub New(ByVal ConString As String)
        MyBase.New(ConString)
    End Sub

    Public Shadows Sub Dispose()
        MyBase.Dispose()
    End Sub
#End Region

#Region " Public Role Functions "
    Public Function LISTETYPEPRODUITC(ByVal code As String) As DataSet
        LISTETYPEPRODUITC = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from TYPEPRODUIT where Code='" & code & "'"
        ObjetConnection = New SqlConnection
        ObjetConnection.ConnectionString = strConn
        Try
            ObjetConnection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ObjetCommand = New SqlCommand(strsql)
        ObjetDataAdapter = New SqlDataAdapter(ObjetCommand)
        ObjetCommand.Connection() = ObjetConnection
        ObjetDataAdapter.Fill(LISTETYPEPRODUITC, "TYPEPRODUIT")
    End Function
    Public Function LISTETYPEPRODUIT() As DataSet
        LISTETYPEPRODUIT = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from TYPEPRODUIT  "
        ObjetConnection = New SqlConnection
        ObjetConnection.ConnectionString = strConn
        Try
            ObjetConnection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ObjetCommand = New SqlCommand(strsql)
        ObjetDataAdapter = New SqlDataAdapter(ObjetCommand)
        ObjetCommand.Connection() = ObjetConnection
        ObjetDataAdapter.Fill(LISTETYPEPRODUIT, "TYPEPRODUIT")
    End Function
    Public Function LISTETYPEPRODUITNOM() As DataSet
        LISTETYPEPRODUITNOM = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select Code from TYPEPRODUIT "
        ObjetConnection = New SqlConnection
        ObjetConnection.ConnectionString = strConn
        Try
            ObjetConnection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ObjetCommand = New SqlCommand(strsql)
        ObjetDataAdapter = New SqlDataAdapter(ObjetCommand)
        ObjetCommand.Connection() = ObjetConnection
        ObjetDataAdapter.Fill(LISTETYPEPRODUITNOM, "TYPEPRODUIT")
    End Function
    Public Function Ajoutertypproduit(ByVal client As DataSet) As Boolean
        Try

            Dim nom, typ As String
            'Ajouter les paramètres 
            nom = client.Tables("TYPEPRODUIT").Rows(0).Item("Code")
            typ = client.Tables("TYPEPRODUIT").Rows(0).Item("Intitule")
            MyBase.requet = "INSERT INTO TYPEPRODUIT VALUES ('" & nom & "','" & typ & "')"
            'Initialisation l'objet command
            MyBase.InitializeCommand()

            Ajoutertypproduit = ExecuteStoredProcedure()
        Catch ExceptionErr As OleDb.OleDbException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function



    Public Function Listtypproduit() As DataSet
        Try
            Listtypproduit = New DataSet
            MyBase.requet = "Select * from TYPEPRODUIT where Order by Nom"
            MyBase.InitializeCommand()
            'remplir le dataset
            MyBase.FillDataSet(Listtypproduit, "logins")
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function



#End Region
End Class
