Imports System.Data.SqlClient
Public Class MODProforma
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
    Public Function Ajouterproforma(ByVal commande As DataSet) As Boolean
        Try

            Dim num, prof, po, cot, objet As String
            Dim mont As Integer
            'Ajouter les paramètres 
            num = commande.Tables("PROFORMA").Rows(0).Item("Numero")
            cot = commande.Tables("PROFORMA").Rows(0).Item("cotation")
            prof = commande.Tables("PROFORMA").Rows(0).Item("projet")
            po = commande.Tables("PROFORMA").Rows(0).Item("Fournisseur")
            objet = commande.Tables("PROFORMA").Rows(0).Item("type")
            mont = commande.Tables("PROFORMA").Rows(0).Item("montant")



            MyBase.requet = "INSERT INTO PROFORMA VALUES ('" & num & "','" & cot & "','" & prof & "', '" & po & "', '" & objet & "', '" & mont & "','Non')"
            'Initialisation l'objet command
            MyBase.InitializeCommand()



            Ajouterproforma = ExecuteStoredProcedure()
        Catch ExceptionErr As OleDb.OleDbException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majproforma(ByVal commande As DataSet) As Boolean
        Try
            Dim num, prof, po, objet As String
            Dim mont As Integer
            'Ajouter les paramètres 
            num = commande.Tables("PROFORMA").Rows(0).Item("Numero")
            prof = commande.Tables("PROFORMA").Rows(0).Item("projet")
            po = commande.Tables("PROFORMA").Rows(0).Item("Fournisseur")
            objet = commande.Tables("PROFORMA").Rows(0).Item("type")
            mont = commande.Tables("PROFORMA").Rows(0).Item("montant")


            MyBase.requet = "Update  PROFORMA Set projet='" & prof & "',Fournisseur='" & po & "',type='" & objet & "',montant='" & mont & "' where  Numero= '" & num & "'"
            MyBase.InitializeCommand()


            Majproforma = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function
    Public Function utilise(ByVal prof As String) As Boolean
        Try
            MyBase.requet = "Update  PROFORMA Set utilise='Oui' where Numero='" & prof & "'"
            MyBase.InitializeCommand()
            utilise = ExecuteStoredProcedure()
        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

   
    Public Function LISTEproforma() As DataSet
        LISTEproforma = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from PROFORMA "
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
        ObjetDataAdapter.Fill(LISTEproforma, "PROFORMA")

    End Function

    Public Function LISTEproformacot(ByVal cot As String) As DataSet
        LISTEproformacot = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from  PROFORMA WHERE cotation='" & cot & "'"
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
        ObjetDataAdapter.Fill(LISTEproformacot, "PROFORMA")

    End Function
    Public Function LISTEproformalib() As DataSet
        LISTEproformalib = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from  PROFORMA WHERE utilise='Non' "
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
        ObjetDataAdapter.Fill(LISTEproformalib, "PROFORMA")

    End Function
    Public Function LISTEproformautilise() As DataSet
        LISTEproformautilise = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from  PROFORMA WHERE utilise='Oui' "
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
        ObjetDataAdapter.Fill(LISTEproformautilise, "PROFORMA")

    End Function
    Public Function NOMFOUR(ByVal cot As String) As DataSet
        NOMFOUR = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select Fournisseur from  PROFORMA WHERE Numero='" & cot & "'"
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
        ObjetDataAdapter.Fill(NOMFOUR, "PROFORMA")

    End Function
    
#End Region
End Class
