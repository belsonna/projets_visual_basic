Imports System.Data.SqlClient

Public Class MODCommande
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
    Public Function Ajoutercommande(ByVal commande As DataSet) As Boolean
        Try

            Dim num, prof, objet As String

            'Ajouter les paramètres 
            num = commande.Tables("COMMANDE").Rows(0).Item("Numero")
            prof = commande.Tables("COMMANDE").Rows(0).Item("proforma")
            objet = commande.Tables("COMMANDE").Rows(0).Item("Objet")




            MyBase.requet = "INSERT INTO COMMANDE VALUES ('" & num & "','" & prof & "', '" & objet & "','En Cours')"
            'Initialisation l'objet command
            MyBase.InitializeCommand()



            Ajoutercommande = ExecuteStoredProcedure()
        Catch ExceptionErr As OleDb.OleDbException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majcommande(ByVal commande As DataSet) As Boolean
        Try
            Dim num, prof, objet As String
            'Ajouter les paramètres 
            num = commande.Tables("COMMANDE").Rows(0).Item("Numero")
            prof = commande.Tables("COMMANDE").Rows(0).Item("proforma")
            objet = commande.Tables("COMMANDE").Rows(0).Item("Objet")



            MyBase.requet = "Update  COMMANDE Set proforma='" & prof & "',Objet='" & objet & "'  where  Numero='" & num & "'"
            MyBase.InitializeCommand()


            Majcommande = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function livrecommande(ByVal commande As String) As Boolean
        Try

            MyBase.requet = "Update  COMMANDE Set etat='Livrée' where  Numero='" & commande & "'"
            MyBase.InitializeCommand()
            livrecommande = ExecuteStoredProcedure()
        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function LISTECOMMANDE() As DataSet
        LISTECOMMANDE = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from COMMANDE  "
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
        ObjetDataAdapter.Fill(LISTECOMMANDE, "COMMANDE")

    End Function
    Public Function LISTECOMMANDEp(ByVal prof As String) As DataSet
        LISTECOMMANDEp = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from COMMANDE where proforma='" & prof & "'  "
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
        ObjetDataAdapter.Fill(LISTECOMMANDEp, "COMMANDE")

    End Function


#End Region
End Class
