Public Class CTRLivrerTEC
    Implements IDisposable
    Private oDlivrertec As MODELS.MODLivrerTEC
    Private disposedValue As Boolean = False
#Region "Constructeur et Destructeur"
    Public Sub New(ByVal Constring As String)
        oDlivrertec = New MODELS.MoDlivrertec(Constring)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
            End If
            oDlivrertec.Dispose()
            oDlivrertec = Nothing
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
            UserDataSet = New DataSet
            Dim proch As Integer
            UserDataSet = oDlivrertec.LISTELIVRERTEC()

            proch = UserDataSet.Tables("LIVRERT").Rows.Count
            prochain = proch

        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function NvlivrerT() As DataSet
        Try
            'instancie un nouveau objet DataSet 
            NvlivrerT = New DataSet

            'crée un objet Datatable 
            Dim objDataTable As DataTable = NvlivrerT.Tables.Add("LIVRERT")

            'crée un objet DataColumn 
            Dim objDataColumn As DataColumn

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Numliv", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 50

            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Po", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 15
            objDataTable.Columns.Add(objDataColumn)

            objDataColumn = New DataColumn("Date", _
              Type.GetType("System.DateTime"))
            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Listlivrert() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listlivrert = oDlivrertec.LISTELIVRERTEC
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Ajouterlivrert(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour ajouter le nouvel utilisateur
            Return oDlivrertec.Ajouterlivrert(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function


#End Region

End Class
