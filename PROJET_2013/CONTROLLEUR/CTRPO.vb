Public Class CTRPO
    Implements IDisposable
    Private oDPO As MODELS.MODPo
    Private disposedValue As Boolean = False
#Region "Constructeur et Destructeur"
    Public Sub New(ByVal Constring As String)
        oDPO = New MODELS.MODPo(Constring)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
            End If
            oDPO.Dispose()
            oDPO = Nothing
        End If
        Me.disposedValue = True
    End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
#Region " Public User Functions "
    Function prochain(ByVal client As String) As Boolean
        Try
            Dim UserDataSet As DataSet
            UserDataSet = New DataSet
            UserDataSet = oDPO.LISTPOE(client)

            If UserDataSet.Tables("PO").Rows.Count > 0 Then
                prochain = True
            Else
                prochain = False
            End If


        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function NvPO() As DataSet
        Try
            'instancie un nouveau objet DataSet 
            NvPO = New DataSet

            'crée un objet Datatable 
            Dim objDataTable As DataTable = NvPO.Tables.Add("PO")

            'crée un objet DataColumn 
            Dim objDataColumn As DataColumn

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("NumPo", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 15


            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("client", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 15


            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)


            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Cotation", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 15


            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            objDataColumn = New DataColumn("DatePO", _
               Type.GetType("System.DateTime"))

            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("ObjetPO", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 255

            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("montant", _
                Type.GetType("System.Int32"))

            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)
            'Instancie un nouveau DataColumn et fixe ses propriétés



        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function LisPO() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            LisPO = oDPO.ListPO
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function AjouterPO(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour ajouter le nouvel utilisateur
            Return oDPO.AjouterPO(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function clipo(ByVal client As String) As String
        Try
            Dim cli As String
            Dim odataset As DataSet

            'Appel le composant de données pour ajouter le nouvel utilisateur
            odataset = oDPO.LISTPOcli(client)
            cli = odataset.Tables("PO").Rows(0).Item("client").ToString
            clipo = cli
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    
    Public Function cotpo(ByVal client As String) As String
        Try
            Dim cli As String
            Dim odataset As DataSet

            'Appel le composant de données pour ajouter le nouvel utilisateur
            odataset = oDPO.LISTPOcli(client)
            cli = odataset.Tables("PO").Rows(0).Item("Cotation").ToString
            cotpo = cli
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function MajPO(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDPO.MajPO(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

#End Region
End Class
