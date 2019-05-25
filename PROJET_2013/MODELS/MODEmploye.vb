Imports System.Data.SqlClient
Public Class MODEmploye
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
    Public Function AjouterEmploye(ByVal employe As DataSet) As Boolean
        Try

            Dim cni, nom, adress, email, photo, service As String
            Dim datecre As Date

            'Ajouter les paramètres 
            cni = employe.Tables("EMPLOYE").Rows(0).Item("CNI")
            nom = employe.Tables("EMPLOYE").Rows(0).Item("Nom")
            adress = employe.Tables("EMPLOYE").Rows(0).Item("Adresse")
            email = employe.Tables("EMPLOYE").Rows(0).Item("Email")
            datecre = employe.Tables("EMPLOYE").Rows(0).Item("DateNaiss")
            photo = employe.Tables("EMPLOYE").Rows(0).Item("photo")
            service = employe.Tables("EMPLOYE").Rows(0).Item("Service")


            MyBase.requet = "INSERT INTO Employe VALUES ('" & cni & "','" & nom & "', '" & adress & "', '" & email & "', '" & datecre & "','" & photo & "', '" & service & "','Non')"
            'Initialisation l'objet command
            MyBase.InitializeCommand()



            AjouterEmploye = ExecuteStoredProcedure()
        Catch ExceptionErr As OleDb.OleDbException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function LISTEEMPLOYE() As DataSet
        LISTEEMPLOYE = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from EMPLOYE where Licencie='Non' "
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
        ObjetDataAdapter.Fill(LISTEEMPLOYE, "EMPLOYE")
    End Function
    Public Function LISTEEMPLOYEC() As DataSet
        LISTEEMPLOYEC = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from EMPLOYE where Licencie='Oui' "
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
        ObjetDataAdapter.Fill(LISTEEMPLOYEC, "EMPLOYE")
    End Function
    Public Function LISTEEMPLOYENOM() As DataSet
        LISTEEMPLOYENOM = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select Nom from EMPLOYE where Licencie='Non' "
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
        ObjetDataAdapter.Fill(LISTEEMPLOYENOM, "EMPLOYE")
    End Function
    Public Function Majemploye(ByVal commande As DataSet) As Boolean
        Try
            Dim cni, nom, adress, email, photo, service As String
            Dim datecre As Date

            'Ajouter les paramètres 
            cni = commande.Tables("EMPLOYE").Rows(0).Item("CNI")
            nom = commande.Tables("EMPLOYE").Rows(0).Item("Nom")
            adress = commande.Tables("EMPLOYE").Rows(0).Item("Adresse")
            email = commande.Tables("EMPLOYE").Rows(0).Item("Email")
            datecre = commande.Tables("EMPLOYE").Rows(0).Item("DateNaiss")
            photo = commande.Tables("EMPLOYE").Rows(0).Item("photo")
            service = commande.Tables("EMPLOYE").Rows(0).Item("Service")



            MyBase.requet = "Update  EMPLOYE Set Nom='" & nom & "',Adresse='" & adress & "',Email='" & email & "',DateNaiss='" & datecre & "',photo='" & photo & "', Service='" & service & "' where  CNI='" & cni & "'"
            MyBase.InitializeCommand()


            Majemploye = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Listemploye() As DataSet
        Try
            Listemploye = New DataSet
            MyBase.requet = "Select * from EMPLOYE  Order by Nom"
            MyBase.InitializeCommand()
            'remplir le dataset
            MyBase.FillDataSet(Listemploye, "logins")
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function employeexistant(ByVal cotation As String) As DataSet
        employeexistant = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from EMPLOYE where CNI='" & cotation & "' "
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
        ObjetDataAdapter.Fill(employeexistant, "EMPLOYE")
    End Function
    Public Function SupEMPLOYE(ByVal employe As String) As Boolean
        Try

            MyBase.requet = "UPDATE EMPLOYE set Licencie='Oui' where CNI='" & employe & "'"

            MyBase.InitializeCommand()
            SupEMPLOYE = ExecuteStoredProcedure()
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function restorEMPLOYE(ByVal employe As String) As Boolean
        Try

            MyBase.requet = "UPDATE EMPLOYE set Licencie='Non' where Nom='" & employe & "'"

            MyBase.InitializeCommand()
            restorEMPLOYE = ExecuteStoredProcedure()
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

#End Region
End Class
