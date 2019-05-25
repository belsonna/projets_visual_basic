Imports System.Data.SqlClient
Public Class MODProduit
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
    Public Function Ajouterproduit(ByVal client As DataSet) As Boolean
        Try

            Dim nom, typ As String
            'Ajouter les paramètres 
            nom = client.Tables("PRODUIT").Rows(0).Item("Nom")
            typ = client.Tables("PRODUIT").Rows(0).Item("Type")
            MyBase.requet = "INSERT INTO PRODUIT VALUES ('" & nom & "','" & typ & "')"
            'Initialisation l'objet command
            MyBase.InitializeCommand()

            Ajouterproduit = ExecuteStoredProcedure()
        Catch ExceptionErr As OleDb.OleDbException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function LISTEPRODUIT() As DataSet
        LISTEPRODUIT = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from PRODUIT "
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
        ObjetDataAdapter.Fill(LISTEPRODUIT, "PRODUIT")
    End Function
    Public Function LISTEPRODUITN(ByVal nom As String) As DataSet
        LISTEPRODUITN = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select Nom  from PRODUIT  where type='" & nom & "'"
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
        ObjetDataAdapter.Fill(LISTEPRODUITN, "PRODUIT")
    End Function
    
    Public Function Majproduit(ByVal client As DataSet) As Boolean
        Try
            Dim nom, typ As String
            'Ajouter les paramètres 
            nom = client.Tables("PRODUIT").Rows(0).Item("Nom")
            typ = client.Tables("PRODUIT").Rows(0).Item("Type")


            MyBase.requet = "Update PRODUIT Set Type='" & typ & "' where  Nom= '" & nom & "'"
            MyBase.InitializeCommand()


            Majproduit = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function


    Public Function Listproduit() As DataSet
        Try
            Listproduit = New DataSet
            MyBase.requet = "Select * from PRODUIT where Order by Nom"
            MyBase.InitializeCommand()
            'remplir le dataset
            MyBase.FillDataSet(Listproduit, "logins")
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function dejaproduit(ByVal produit As String) As DataSet
        Try
            Dim LoginDataset As DataSet
            LoginDataset = New DataSet

            MyBase.requet = "select * from PRODUIT where Nom='" & produit & "'"

            MyBase.InitializeCommand()

            MyBase.FillDataSet(LoginDataset, "produit")

            dejaproduit = LoginDataset
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function



#End Region
End Class
