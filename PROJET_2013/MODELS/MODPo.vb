Imports System.Data.SqlClient

Public Class MODPo
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
    Public Function AjouterPO(ByVal commande As DataSet) As Boolean
        Try

            Dim num, cot, objet, client As String
            Dim datecre As Date
            Dim montant As Integer
            'Ajouter les paramètres 
            num = commande.Tables("PO").Rows(0).Item("NumPo")
            client = commande.Tables("PO").Rows(0).Item("client")
            cot = commande.Tables("PO").Rows(0).Item("Cotation")
            datecre = commande.Tables("PO").Rows(0).Item("DatePO")
            objet = commande.Tables("PO").Rows(0).Item("ObjetPO")
            montant = commande.Tables("PO").Rows(0).Item("montant")

            MyBase.requet = "INSERT INTO PO VALUES ('" & num & "','" & cot & "','" & datecre & "','" & objet & "','" & client & "', '" & montant & "', 'En Cours')"
            'Initialisation l'objet command
            MyBase.InitializeCommand()



            AjouterPO = ExecuteStoredProcedure()
        Catch ExceptionErr As OleDb.OleDbException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function MajPO(ByVal commande As DataSet) As Boolean
        Try
            Dim num, cot, objet, client As String
            Dim datecre As Date
            Dim montant As Integer
            'Ajouter les paramètres 
            num = commande.Tables("PO").Rows(0).Item("NumPo")
            client = commande.Tables("PO").Rows(0).Item("client")
            cot = commande.Tables("PO").Rows(0).Item("Cotation")
            datecre = commande.Tables("PO").Rows(0).Item("DatePO")
            objet = commande.Tables("PO").Rows(0).Item("ObjetPO")
            montant = commande.Tables("PO").Rows(0).Item("montant")

            MyBase.requet = "Update  PO Set Cotation='" & cot & "',DatePO='" & datecre & "',ObjetPO='" & objet & "',montant='" & montant & "', client='" & client & "' where  NumPo=" & num
            MyBase.InitializeCommand()
            MajPO = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function LISTPO() As DataSet
        LISTPO = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from PO "
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
        ObjetDataAdapter.Fill(LISTPO, "PO")
    End Function
    Public Function LISTPOcli(ByVal po As String) As DataSet
        LISTPOcli = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from PO  where NumPo='" & po & "'"
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
        ObjetDataAdapter.Fill(LISTPOcli, "PO")
    End Function
    Public Function LISTPOE(ByVal etat As String) As DataSet
        LISTPOE = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from PO where etat='" & etat & "'"
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
        ObjetDataAdapter.Fill(LISTPOE, "PO")
    End Function
   

#End Region
End Class
