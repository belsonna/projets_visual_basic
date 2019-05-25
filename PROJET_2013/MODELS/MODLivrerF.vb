Imports System.Data.SqlClient

Public Class MODLivrerF
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
    Public Function Ajouterlivrerf(ByVal facturef As DataSet) As Boolean
        Try
            Dim num, numc, prod As String
            Dim nbc, nbl, res As Integer
            Dim dat As Date

            'Ajouter les paramètres 
            num = facturef.Tables("LIVRERF").Rows(0).Item("NUM")
            'MsgBox("num")
            numc = facturef.Tables("LIVRERF").Rows(0).Item("NUMCOM")
            'MsgBox("numc")
            prod = facturef.Tables("LIVRERF").Rows(0).Item("produit")
            'MsgBox("pro")
            nbc = facturef.Tables("LIVRERF").Rows(0).Item("nbrecom")
            'MsgBox("nc")
            nbl = facturef.Tables("LIVRERF").Rows(0).Item("nbreliv")
            'MsgBox("nl")
            dat = facturef.Tables("LIVRERF").Rows(0).Item("date")
            'MsgBox("dat")
            'MsgBox(num & "," & numc & "," & prod & "," & nbc & "," & nbl & "," & dat)
            If nbl > nbc Then
                MsgBox("la quantite livree doit etre inferieure ou egal a la quantité commandée")
                Ajouterlivrerf = False
            Else
                res = nbc - nbl


                MyBase.requet = "INSERT INTO LIVRERF VALUES ('" & num & "','" & numc & "', '" & prod & "', '" & nbc & "','" & nbl & "', '" & res & "', '" & dat & "')"
                'Initialisation l'objet command
                MyBase.InitializeCommand()



                Ajouterlivrerf = ExecuteStoredProcedure()
            End If
        Catch ExceptionErr As OleDb.OleDbException
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majlivrerf(ByVal facturef As DataSet) As Boolean
        Try
            Dim num, numc, prod As String
            Dim nbc, nbl, res As Integer
            Dim dat As Date
            'Ajouter les paramètres 
            res = nbc - nbl
            'Ajouter les paramètres 
            num = facturef.Tables("LIVRERF").Rows(0).Item("NUM")
            numc = facturef.Tables("LIVRERF").Rows(0).Item("NUMCOM")
            prod = facturef.Tables("LIVRERF").Rows(0).Item("produit")
            nbc = facturef.Tables("LIVRERF").Rows(0).Item("nbrecom")
            nbl = facturef.Tables("LIVRERF").Rows(0).Item("nbreliv")
            dat = facturef.Tables("LIVRERF").Rows(0).Item("date")



            MyBase.requet = "Update  LIVRERF Set NUMCOM='" & numc & "',produit='" & prod & "',nbrecom='" & nbc & "',nbreliv='" & nbl & "',reste='" & res & "',date='" & dat & "' where  NUM=" & num
            MyBase.InitializeCommand()


            Majlivrerf = ExecuteStoredProcedure()

        Catch ExceptionErr As Exception
            'MsgBox(ExceptionErr.Message)
            Throw New System.Exception(ExceptionErr.Message, _
            ExceptionErr.InnerException)
        End Try
    End Function

    Public Function LISTElivf() As DataSet
        LISTElivf = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from LIVRERF "
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
        ObjetDataAdapter.Fill(LISTElivf, "LIVRERF")

    End Function
    Public Function LISTElivft(ByVal com As String) As DataSet
        LISTElivft = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from LIVRERF where NUMCOM='" & com & "'"
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
        ObjetDataAdapter.Fill(LISTElivft, "LIVRERF")

    End Function
    Public Function LISTElivrertec(ByVal COM As String) As DataSet
        LISTElivrertec = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select P.produit,P.PU,P.qte from PROFORMER P,PROFORMA PR, COMMANDE C where C.Numero='" & COM & "'AND C.proforma= PR.Numero AND PR.Numero=P.proforma"
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
        ObjetDataAdapter.Fill(LISTElivrertec, "LIVRAISON")

    End Function
    Public Function LISTte() As DataSet
        LISTte = New DataSet
        strConn = My.Settings.BUYINGHOUSEConnectionString
        strsql = "select * from LIVRERF "
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
        ObjetDataAdapter.Fill(LISTte, "LIVRERF")

    End Function
#End Region
End Class
