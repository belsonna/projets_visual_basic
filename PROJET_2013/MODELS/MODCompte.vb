Imports System.Data.SqlClient

Public Class MODCompte
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
    Public Function Ajoutercompte(ByVal compte As DataSet) As Boolean
        Try

            Dim log, pwd, priv As String
            'Ajouter les paramètres 
            log = compte.Tables("COMPTE").Rows(0).Item("Proprietaire")
            pwd = compte.Tables("COMPTE").Rows(0).Item("password")
            priv = compte.Tables("COMPTE").Rows(0).Item("privilege")

            MyBase.requet = "INSERT INTO COMPTE VALUES ('" & log & "','" & pwd & "', '" & priv & "')"
            'Initialisation l'objet command
            MyBase.InitializeCommand()



            Ajoutercompte = ExecuteStoredProcedure()
        Catch ExceptionErr As OleDb.OleDbException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majcompte(ByVal compte As DataSet) As Boolean
        Try

            Dim log, pwd, priv As String

            'Ajouter les paramètres 
            log = compte.Tables("COMPTE").Rows(0).Item("Proprietaire")
            pwd = compte.Tables("COMPTE").Rows(0).Item("password")
            priv = compte.Tables("COMPTE").Rows(0).Item("privilege")


            MyBase.requet = "Update  COMPTE Set password='" & pwd & "',privilege='" & priv & "' where  Proprietaire='" & log & "'"
            MyBase.InitializeCommand()
            Majcompte = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Listcompte() As DataSet
        Try

            Listcompte = New DataSet
            MyBase.requet = "Select Proprietaire,password,privilege from COMPTE Order by Proprietaire"
            MyBase.InitializeCommand()

            'remplir le dataset

            MsgBox("ah oui")
            DataAdapter.Fill(Listcompte, "COMPTE")

        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function compteexistant(ByVal compte As String) As DataSet
        Try
            compteexistant = New DataSet
            MyBase.requet = "Select Proprietaire,password,privilege from COMPTE where Proprietaire='" & compte & "'"
            MyBase.InitializeCommand()


            MyBase.FillDataSet(compteexistant, "Compte")

        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function ConPossible(ByVal compte As DataSet) As DataSet
        Try
            Dim LoginDataset As DataSet
            LoginDataset = New DataSet

            Dim pwd As String = compte.Tables("COMPTE").Rows(0).Item("password")

            Dim login As String = compte.Tables("COMPTE").Rows(0).Item("Proprietaire")

            MyBase.requet = "select * from COMPTE where password='" & pwd & "' and Proprietaire='" & login & "'"

            MyBase.InitializeCommand()

            MyBase.FillDataSet(LoginDataset, "COMPTE")

            ConPossible = LoginDataset
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function


    Public Function Supcompte(ByVal compte As String) As Boolean
        Try

            MyBase.requet = "Delete from COMPTE where Proprietaire='" & compte & "'"

            MyBase.InitializeCommand()
            Supcompte = ExecuteStoredProcedure()
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function LISTECOMPTE() As DataSet
        LISTECOMPTE = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from COMPTE "
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
        ObjetDataAdapter.Fill(LISTECOMPTE, "COMPTE")

    End Function
#End Region

End Class
