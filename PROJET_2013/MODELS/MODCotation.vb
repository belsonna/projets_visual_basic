Imports System.Data.SqlClient
Public Class MODCotation
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
    Public Function Ajoutercotation(ByVal commande As DataSet) As Boolean
        Try

            Dim num, prof, objet, proj, taxe As String
            Dim montant As Integer
            'Ajouter les paramètres 
            num = commande.Tables("COTATION").Rows(0).Item("Numcot")
            'MsgBox(num)
            proj = commande.Tables("COTATION").Rows(0).Item("projet")
            ''MsgBox(proj)
            prof = commande.Tables("COTATION").Rows(0).Item("lettre")
            'MsgBox(prof)
            montant = commande.Tables("COTATION").Rows(0).Item("Montant")
            'MsgBox(montant)
            taxe = commande.Tables("COTATION").Rows(0).Item("taxe")
            objet = commande.Tables("COTATION").Rows(0).Item("ObjetCOT")
            'MsgBox(objet)
            MyBase.requet = "INSERT INTO COTATION VALUES ('" & num & "','" & proj & "', '" & objet & "', '" & taxe & "','" & montant & "', '" & prof & "')"
            'Initialisation l'objet command
            MyBase.InitializeCommand()

            Ajoutercotation = ExecuteStoredProcedure()
        Catch ExceptionErr As SqlException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majcotation(ByVal commande As DataSet) As Boolean
        Try
            Dim num, prof, objet, taxe As String
            Dim montant As Integer
            'Ajouter les paramètres 
            num = commande.Tables("COTATION").Rows(0).Item("Numcot")
            prof = commande.Tables("COTATION").Rows(0).Item("lettre")
            montant = commande.Tables("COTATION").Rows(0).Item("Montant")
            objet = commande.Tables("COTATION").Rows(0).Item("ObjetCOT")
            taxe = commande.Tables("COTATION").Rows(0).Item("taxe")


            MyBase.requet = "Update  COTATION Set ObjetCOT='" & objet & "',Montant='" & montant & "',lettre='" & prof & "',taxe='" & taxe & "' where  Numcot='" & num & "'"
            MyBase.InitializeCommand()


            Majcotation = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function LISTECOTATION() As DataSet
        LISTECOTATION = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from COTATION "
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
        ObjetDataAdapter.Fill(LISTECOTATION, "COTATION")

    End Function
    Public Function taxe(ByVal cot As String) As DataSet
        taxe = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select taxe from COTATION where Numcot='" & cot & "'"
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
        ObjetDataAdapter.Fill(taxe, "COTATION")

    End Function
    Public Function LISTECOTATIONN() As DataSet
        LISTECOTATIONN = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select Numcot from COTATION "
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
        ObjetDataAdapter.Fill(LISTECOTATION, "COTATION")

    End Function
    Public Function Listcotation() As DataSet
        Try
            Listcotation = New DataSet
            MyBase.requet = "Select * from COTATION where Order by Numcot"
            MyBase.InitializeCommand()
            'remplir le dataset
            MyBase.FillDataSet(Listcotation, "logins")
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    
    Public Function montantcotation(ByVal cot As String)
        montantcotation = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from PROFORMA WHERE cotation='" & cot & "'  "
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
        ObjetDataAdapter.Fill(montantcotation, "PROFORMA")

    End Function

#End Region
End Class
