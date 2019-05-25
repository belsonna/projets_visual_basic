Imports System.Data.SqlClient
Public Class MODClient
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
    Public Function Ajouterclient(ByVal client As DataSet) As Boolean
        Try

            Dim log, pwd, nom As String
            'Ajouter les paramètres 
            nom = client.Tables("CLIENT").Rows(0).Item("Nom")
            log = client.Tables("CLIENT").Rows(0).Item("Adresse")
            pwd = client.Tables("CLIENT").Rows(0).Item("Siege")


            MyBase.requet = "INSERT INTO CLIENT VALUES ('" & nom & "','" & log & "','" & pwd & "', 'Oui')"
            'Initialisation l'objet command
            MyBase.InitializeCommand()



            Ajouterclient = ExecuteStoredProcedure()
        Catch ExceptionErr As OleDb.OleDbException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majclient(ByVal client As DataSet) As Boolean
        Try
            Dim log, pwd, nom As String

            'Ajouter les paramètres 
            nom = client.Tables("CLIENT").Rows(0).Item("Nom")
            log = client.Tables("CLIENT").Rows(0).Item("Adresse")
            pwd = client.Tables("CLIENT").Rows(0).Item("Siege")



            MyBase.requet = "Update CLIENT Set Adresse='" & log & "',Siege='" & pwd & "'  where  Nom='" & nom & "'"
            MyBase.InitializeCommand()


            Majclient = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function archivé(ByVal client As String) As Boolean
        Try

            MyBase.requet = "Update CLIENT Set Partenaire='Non'  where  Nom='" & client & "'"
            MyBase.InitializeCommand()


            archivé = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function restauré(ByVal client As String) As Boolean
        Try

            MyBase.requet = "Update CLIENT Set Partenaire='Oui'  where  Nom='" & client & "'"
            MyBase.InitializeCommand()


            restauré = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function LISTECLIENT() As DataSet
        LISTECLIENT = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from CLIENT where Partenaire='Oui' "
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
        ObjetDataAdapter.Fill(LISTECLIENT, "CLIENT")

    End Function
    Public Function LISTECLIENTC() As DataSet
        LISTECLIENTC = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from CLIENT where Partenaire='Non' "
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
        ObjetDataAdapter.Fill(LISTECLIENTC, "CLIENT")

    End Function
    Public Function LISTECLIENTN() As DataSet
        LISTECLIENTN = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select Nom from CLIENT where Partenaire='Oui' "
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
        ObjetDataAdapter.Fill(LISTECLIENT, "CLIENT")

    End Function

    Public Function dejaclient(ByVal client As String) As DataSet
        Try
            Dim LoginDataset As DataSet
            LoginDataset = New DataSet

            MyBase.requet = "select * from CLIENT where Nom='" & client & "'"

            MyBase.InitializeCommand()

            MyBase.FillDataSet(LoginDataset, "client")

            dejaclient = LoginDataset
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function


#End Region
End Class
