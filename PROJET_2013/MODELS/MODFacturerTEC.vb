Imports System.Data.SqlClient

Public Class MODFacturerTEC

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
    Public Function Ajouterfacturetec(ByVal facturef As DataSet) As Boolean
        Try

            Dim num, prof, Po, bank, compt As String
            Dim mont As Integer
            Dim datecre As Date
            'Ajouter les paramètres 
            num = facturef.Tables("FACTURERTEC").Rows(0).Item("Num")
            Po = facturef.Tables("FACTURERTEC").Rows(0).Item("Po")
            mont = facturef.Tables("FACTURERTEC").Rows(0).Item("montant")
            prof = facturef.Tables("FACTURERTEC").Rows(0).Item("lettre")
            datecre = facturef.Tables("FACTURERTEC").Rows(0).Item("datefac")
            bank = facturef.Tables("FACTURERTEC").Rows(0).Item("banque")
            compt = facturef.Tables("FACTURERTEC").Rows(0).Item("compte")
            MyBase.requet = "INSERT INTO FACTURERTEC VALUES ('" & num & "','" & Po & "', '" & mont & "', '" & prof & "','" & datecre & "', '" & bank & "','" & compt & "')"
            'Initialisation l'objet command
            MyBase.InitializeCommand()
            Ajouterfacturetec = ExecuteStoredProcedure()
        Catch ExceptionErr As OleDb.OleDbException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majfacturetec(ByVal facturef As DataSet) As Boolean
        Try
            Dim num, prof, Po As String
            Dim mont As Integer
            Dim datecre As Date
            'Ajouter les paramètres 
            num = facturef.Tables(" FACTURERTEC").Rows(0).Item("Num")
            Po = facturef.Tables("FACTURERTEC").Rows(0).Item("Po")
            mont = facturef.Tables("FACTURERTEC").Rows(0).Item("montant")
            prof = facturef.Tables("FACTURERTEC").Rows(0).Item("lettre")
            datecre = facturef.Tables("FACTURERTEC").Rows(0).Item("datefac")
            MyBase.requet = "Update  FACTURERTEC Set Po='" & num & "',montant='" & mont & "'datefac='" & datecre & "' where  Num=" & num
            MyBase.InitializeCommand()


            Majfacturetec = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function LISTEfacturert() As DataSet
        LISTEfacturert = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from FACTURERTEC "
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
        ObjetDataAdapter.Fill(LISTEfacturert, "FACTURERTEC")

    End Function
    Public Function factureexistant(ByVal facturet As DataSet) As DataSet
        Try
            Dim num As String
            factureexistant = New DataSet
            num = facturet.Tables("FACTURERTEC").Rows(0).Item("Num")


            MyBase.requet = "Select * FACTURERTEC where Num='" & num & "'"
            MyBase.InitializeCommand()

            MyBase.FillDataSet(factureexistant, "Compte")
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

#End Region



End Class
