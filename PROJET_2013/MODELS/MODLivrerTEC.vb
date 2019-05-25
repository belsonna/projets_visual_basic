Imports System.Data.SqlClient

Public Class MODLivrerTEC
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
    Public Function Ajouterlivrert(ByVal facturef As DataSet) As Boolean
        Try
            Dim num, numc As String
            Dim dat As Date

           
            'Ajouter les paramètres 
            num = facturef.Tables("LIVRERT").Rows(0).Item("Numliv")
            numc = facturef.Tables("LIVRERT").Rows(0).Item("Po")
            dat = facturef.Tables("LIVRERT").Rows(0).Item("Date")

            MyBase.requet = "INSERT INTO LIVRERT VALUES ('" & num & "','" & numc & "', '" & dat & "')"
            'Initialisation l'objet command
            MyBase.InitializeCommand()

            Ajouterlivrert = ExecuteStoredProcedure()
        Catch ExceptionErr As OleDb.OleDbException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function LISTELIVRERTEC() As DataSet
        LISTELIVRERTEC = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from LIVRERT  "
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
        ObjetDataAdapter.Fill(LISTELIVRERTEC, "LIVRERT")

    End Function
    Public Function Listlivrertcom(ByVal com As String) As DataSet
        Try
            Listlivrertcom = New DataSet
            MyBase.requet = "Select * from LIVRERT where Po='" & com & "' order by Numliv"
            MyBase.InitializeCommand()
            'remplir le dataset
            MyBase.FillDataSet(Listlivrertcom, "logins")
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
#End Region

End Class
