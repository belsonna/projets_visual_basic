Imports System.Data.SqlClient

Public Class MODProformer
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
    Public Function AjouteRPROFORMER(ByVal facturef As DataSet) As Boolean
        Try
            Dim num, prof, prod As String
            Dim pu, qt, mont As Integer

            'Ajouter les paramètres 
            num = facturef.Tables("PROFORMER").Rows(0).Item("Numero")
            prof = facturef.Tables("PROFORMER").Rows(0).Item("proforma")
            prod = facturef.Tables("PROFORMER").Rows(0).Item("produit")
            pu = facturef.Tables("PROFORMER").Rows(0).Item("PU")
            qt = facturef.Tables("PROFORMER").Rows(0).Item("qte")
            mont = pu * qt


            MyBase.requet = "INSERT INTO PROFORMER VALUES ('" & num & "','" & prof & "', '" & prod & "', '" & pu & "','" & qt & "', '" & mont & "')"
            'Initialisation l'objet command
            MyBase.InitializeCommand()
            AjouteRPROFORMER = ExecuteStoredProcedure()
            'ObjetConnection.Close()
        Catch ExceptionErr As SqlException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function MajPROFORMER(ByVal facturef As DataSet) As Boolean
        Try
            Dim num, prof, prod As String
            Dim pu, qt, mont As Integer

            'Ajouter les paramètres 
            num = facturef.Tables("PROFORMER").Rows(0).Item("Numero")
            prof = facturef.Tables("PROFORMER").Rows(0).Item("proforma")
            prod = facturef.Tables("PROFORMER").Rows(0).Item("produit")
            pu = facturef.Tables("PROFORMER").Rows(0).Item("PU")
            qt = facturef.Tables("PROFORMER").Rows(0).Item("qte")
            mont = pu * qt

            MyBase.requet = "Update  PROFORMER Set proforma='" & prof & "',produit='" & prod & "',PU='" & pu & "',qte='" & qt & "',montant='" & mont & "' where  Numero=" & num
            MyBase.InitializeCommand()


            MajPROFORMER = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function LISTEPRoformer() As DataSet
        LISTEPRoformer = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from PROFORMER "
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
        ObjetDataAdapter.Fill(LISTEPRoformer, "PROFORMER")
    End Function
    Public Function Listproformerprof(ByVal com As String) As DataSet
        Listproformerprof = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from PROFORMER WHERE proforma = '" & com & "'"
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
        ObjetDataAdapter.Fill(Listproformerprof, "PROFORMER")
    End Function

    Public Function proformerexistant(ByVal cotation As DataSet) As Boolean
        Try
            Dim num As String
            num = cotation.Tables("PROFORMER").Rows(0).Item("Numero")

            MyBase.requet = "Select * from PROFORMER where Numero='" & num
            MyBase.InitializeCommand()

            proformerexistant = ExecuteStoredProcedure()
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
#End Region
End Class
