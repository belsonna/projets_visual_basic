Public Class CTRproforma
    Implements IDisposable
    Private oDproforma As MODELS.MODProforma
    Private disposedValue As Boolean = False
#Region "Constructeur et Destructeur"
    Public Sub New(ByVal Constring As String)
        oDproforma = New MODELS.MoDproforma(Constring)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
            End If
            oDproforma.Dispose()
            oDproforma = Nothing
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
    Function prochain() As Integer
        Try
            Dim UserDataSet As DataSet
            Dim proch As Integer
            UserDataSet = New DataSet
            UserDataSet = oDproforma.LISTEproforma()

            proch = UserDataSet.Tables("PROFORMA").Rows.Count
            prochain = proch

        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Nvproforma() As DataSet
        Try
            'instancie un nouveau objet DataSet 
            Nvproforma = New DataSet

            'crée un objet Datatable 
            Dim objDataTable As DataTable = Nvproforma.Tables.Add("PROFORMA")

            'crée un objet DataColumn 
            Dim objDataColumn As DataColumn

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Numero", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 15


            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("cotation", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 15

            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            objDataColumn = New DataColumn("projet", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 15
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Fournisseur", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 15
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)
            'Instancie un nouveau DataColumn et fixe ses propriétés

            objDataColumn = New DataColumn("type", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 255
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)

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

    Public Function Listproforma() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listproforma = oDproforma.LISTEproforma
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function Listproformalib() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listproformalib = oDproforma.LISTEproformalib
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function Listproformauti() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listproformauti = oDproforma.LISTEproformautilise
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function nomfour(ByVal nom As String) As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            nomfour = oDproforma.NOMFOUR(nom)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Ajouterproforma(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour ajouter le nouvel utilisateur
            Return oDproforma.Ajouterproforma(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majproforma(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDproforma.Majproforma(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function utilise(ByVal client As String) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDproforma.utilise(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

#End Region
End Class
