Imports System.Data.SqlClient
Public Class MODProjet
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
    Public Function Ajouterprojet(ByVal commande As DataSet) As Boolean
        Try


            Dim num, des, client As String
            Dim datecre, dateclo As Date


            'Ajouter les paramètres 
            num = commande.Tables("PROJET").Rows(0).Item("Numero")
            des = commande.Tables("PROJET").Rows(0).Item("Description")
            client = commande.Tables("PROJET").Rows(0).Item("Client")
            datecre = commande.Tables("PROJET").Rows(0).Item("Datecreation")
            dateclo = commande.Tables("PROJET").Rows(0).Item("Datecloture")

            MyBase.requet = "INSERT INTO PROJET VALUES ('" & num & "', '" & des & "', '" & client & "', '" & datecre & "', '" & datecre & "','En Cours')"
            'Initialisation l'objet command
            MyBase.InitializeCommand()



            Ajouterprojet = ExecuteStoredProcedure()
        Catch ExceptionErr As OleDb.OleDbException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function MajPROJET(ByVal commande As DataSet) As Boolean
        Try
            Dim num, des, client, etat As String
            Dim datecre, dateclo As Date


            'Ajouter les paramètres 
            num = commande.Tables("PROJET").Rows(0).Item("Numero").ToString
            des = commande.Tables("PROJET").Rows(0).Item("Description").ToString
            client = commande.Tables("PROJET").Rows(0).Item("Client").ToString
            datecre = commande.Tables("PROJET").Rows(0).Item("Datecreation")
            dateclo = commande.Tables("PROJET").Rows(0).Item("Datecloture")
            etat = commande.Tables("PROJET").Rows(0).Item("etat")
            MyBase.requet = "Update  PROJET Set Description='" & des & "',Client='" & client & "',Datecreation='" & datecre & "',Datecloture='" & dateclo & "',etat='" & etat & "' where  Numero='" & num & "'"
            MyBase.InitializeCommand()


            MajPROJET = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function LISTEPROJET() As DataSet
        LISTEPROJET = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from PROJET where etat='En Cours' "
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
        ObjetDataAdapter.Fill(LISTEPROJET, "PROJET")

    End Function
    Public Function LISTEPROJETp() As DataSet
        LISTEPROJETp = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from PROJET"
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
        ObjetDataAdapter.Fill(LISTEPROJETp, "PROJET")

    End Function
    
    Public Function PROJETclient(ByVal cotation As String) As DataSet
        PROJETclient = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select Client from PROJET where Numero= '" & cotation & "'"
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
        ObjetDataAdapter.Fill(PROJETclient, "PROJET")

    End Function
    Public Function Supprojet(ByVal proj As String) As Boolean
        Try

            MyBase.requet = "UPDATE PROJET set etat='archive' where Numero='" & proj & "' "

            MyBase.InitializeCommand()
            Supprojet = ExecuteStoredProcedure()
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function confirme(ByVal proj As String, ByVal dat As Date) As Boolean
        Try

            MyBase.requet = "UPDATE PROJET set etat='confirme' , Datecloture='" & dat & "' where Numero='" & proj & "'"

            MyBase.InitializeCommand()
            confirme = ExecuteStoredProcedure()
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function restorprojet(ByVal proj As String) As Boolean
        Try

            MyBase.requet = "UPDATE PROJET set etat='En Cours' where Numero='" & proj & "' "

            MyBase.InitializeCommand()
            restorprojet = ExecuteStoredProcedure()
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

#End Region

End Class
