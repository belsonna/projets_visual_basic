Imports System.Data.SqlClient

Public Class MODFacturerF
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
    Public Function Ajouterfacturef(ByVal facturef As DataSet) As Boolean
        Try
            Dim num, prof As String
            Dim po As Integer
            Dim datecre As Date
            'Ajouter les paramètres 
            num = facturef.Tables("FACTURERF").Rows(0).Item("NumFac")
            prof = facturef.Tables("FACTURERF").Rows(0).Item("COM")
            po = facturef.Tables("FACTURERF").Rows(0).Item("montant")
            datecre = facturef.Tables("FACTURERF").Rows(0).Item("Datecrea")



            MyBase.requet = "INSERT INTO FACTURERF VALUES ('" & num & "','" & prof & "', '" & po & "', '" & datecre & "')"
            'Initialisation l'objet command
            MyBase.InitializeCommand()



            Ajouterfacturef = ExecuteStoredProcedure()
        Catch ExceptionErr As OleDb.OleDbException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majfacturef(ByVal facturef As DataSet) As Boolean
        Try
            Dim num, prof As String
            Dim po As Integer
            Dim datecre As Date
            'Ajouter les paramètres 
            num = facturef.Tables(" FACTURERF").Rows(0).Item("NumFac")
            prof = facturef.Tables("FACTURERF").Rows(0).Item("COM")
            po = facturef.Tables("FACTURERF").Rows(0).Item("montant")
            datecre = facturef.Tables("FACTURERF").Rows(0).Item("Datecrea")


            MyBase.requet = "Update  FACTURERF Set COM='" & prof & "',montant='" & po & "'Datecrea='" & datecre & "' where  Numfac=" & num
            MyBase.InitializeCommand()


            Majfacturef = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function LISTEFACTUREF() As DataSet
        LISTEFACTUREF = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from FACTURERF  "
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
        ObjetDataAdapter.Fill(LISTEFACTUREF, "FACTURERF")

    End Function
    Public Function factureexistant(ByVal facturef As DataSet) As DataSet
        Try
            Dim num As String
            factureexistant = New DataSet
            num = facturef.Tables("FACTURERF").Rows(0).Item("NumFac")


            MyBase.requet = "Select * FACTURERF where NumFac='" & num & "'"
            MyBase.InitializeCommand()

            MyBase.FillDataSet(factureexistant, "Compte")
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

#End Region

End Class
