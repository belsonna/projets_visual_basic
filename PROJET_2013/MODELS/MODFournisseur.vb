Imports System.Data.SqlClient
Public Class MODFournisseur

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
    Public Function AjouterFOURNISSEUR(ByVal commande As DataSet) As Boolean
        Try


            Dim nom, adress, secteur, siege As String


            'Ajouter les paramètres 
            nom = commande.Tables("FOURNISSEUR").Rows(0).Item("Nom")
            adress = commande.Tables("FOURNISSEUR").Rows(0).Item("Adresse")
            siege = commande.Tables("FOURNISSEUR").Rows(0).Item("Siegesocial")
            secteur = commande.Tables("FOURNISSEUR").Rows(0).Item("Secteur")

            MyBase.requet = "INSERT INTO FOURNISSEUR VALUES ('" & nom & "', '" & adress & "', '" & siege & "', '" & secteur & "','Oui')"
            'Initialisation l'objet command
            MyBase.InitializeCommand()



            AjouterFOURNISSEUR = ExecuteStoredProcedure()
        Catch ExceptionErr As OleDb.OleDbException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function MajFOURNISSEUR(ByVal commande As DataSet) As Boolean
        Try
            Dim nom, adress, secteur, siege As String


            'Ajouter les paramètres 
            nom = commande.Tables("FOURNISSEUR").Rows(0).Item("Nom")
            adress = commande.Tables("FOURNISSEUR").Rows(0).Item("Adresse")
            siege = commande.Tables("FOURNISSEUR").Rows(0).Item("Siegesocial")
            secteur = commande.Tables("FOURNISSEUR").Rows(0).Item("Secteur")
            MyBase.requet = "Update  FOURNISSEUR Set Adresse='" & adress & "',Siegesocial='" & siege & "',Secteur='" & secteur & "' where  Nom='" & nom & "'"
            MyBase.InitializeCommand()


            MajFOURNISSEUR = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function ListFOURNISSEUR() As DataSet
        Try
            ListFOURNISSEUR = New DataSet
            MyBase.requet = "Select * from FOURNISSEUR where Order by Nom"
            MyBase.InitializeCommand()
            'remplir le dataset
            MyBase.FillDataSet(ListFOURNISSEUR, "logins")
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function FOURNISSEURexistant(ByVal cotation As DataSet) As DataSet
        Try
            Dim num As String
            FOURNISSEURexistant = New DataSet
            num = cotation.Tables("FOURNISSEUR").Rows(0).Item("Nom")

            MyBase.requet = "Select * FOURNISSEUR where Nom='" & num
            MyBase.InitializeCommand()

            MyBase.FillDataSet(FOURNISSEURexistant, "Compte")
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function SupFOURNISSEUR(ByVal fournisseur As String) As Boolean
        Try

            MyBase.requet = "UPDATE FOURNISSEUR set Partenaire='Non' where Nom='" & fournisseur & "'"

            MyBase.InitializeCommand()
            SupFOURNISSEUR = ExecuteStoredProcedure()
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function restorFOURNISSEUR(ByVal fournisseur As String) As Boolean
        Try

            MyBase.requet = "UPDATE FOURNISSEUR set Partenaire='Oui'  where Nom='" & fournisseur & "'"

            MyBase.InitializeCommand()
            restorFOURNISSEUR = ExecuteStoredProcedure()
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function dejaf(ByVal client As String) As DataSet
        Try
            Dim LoginDataset As DataSet
            LoginDataset = New DataSet

            MyBase.requet = "select * from FOURNISSEUR where Nom='" & client & "'"

            MyBase.InitializeCommand()

            MyBase.FillDataSet(LoginDataset, "FOURNISSEUR")

            dejaf = LoginDataset
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function LISTEfournisseur() As DataSet
        LISTEfournisseur = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from FOURNISSEUR where Partenaire='Oui' "
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
        ObjetDataAdapter.Fill(LISTEfournisseur, "FOURNISSEUR")

    End Function
    Public Function LISTEfournisseurC() As DataSet
        LISTEfournisseurC = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from FOURNISSEUR where Partenaire='Non' "
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
        ObjetDataAdapter.Fill(LISTEfournisseurC, "FOURNISSEUR")

    End Function
#End Region


End Class
