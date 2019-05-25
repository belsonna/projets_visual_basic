Public Class CTRLivrerf
    Implements IDisposable
    Private oDlivrerf As MODELS.MODLivrerF
    Private disposedValue As Boolean = False
#Region "Constructeur et Destructeur"
    Public Sub New(ByVal Constring As String)
        oDlivrerf = New MODELS.MODLivrerF(Constring)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
            End If
            oDlivrerf.Dispose()
            oDlivrerf = Nothing
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
            UserDataSet = oDlivrerf.LISTElivf()

            proch = UserDataSet.Tables("LIVRERF").Rows.Count
            prochain = proch
           
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Nvlivrerf() As DataSet
        Try
            'instancie un nouveau objet DataSet 
            Nvlivrerf = New DataSet

            'crée un objet Datatable 
            Dim objDataTable As DataTable = Nvlivrerf.Tables.Add("LIVRERF")

            'crée un objet DataColumn 
            Dim objDataColumn As DataColumn

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("NUM", _
               Type.GetType("System.Int32"))
            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("NUMCOM", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 15

            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)
            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("produit", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 15

            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            objDataColumn = New DataColumn("nbrecom", _
              Type.GetType("System.Int32"))
            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)
            objDataColumn = New DataColumn("nbreliv", _
              Type.GetType("System.Int32"))
            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)
            objDataColumn = New DataColumn("date", _
               Type.GetType("System.DateTime"))
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)


        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Listlivrerf() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listlivrerf = oDlivrerf.LISTte
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function ListlivrerT(ByVal COM As String) As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            ListlivrerT = oDlivrerf.LISTElivrertec(COM)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function Listlivrercom(ByVal COM As String) As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listlivrercom = oDlivrerf.LISTElivft(COM)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Ajouterlivrerf(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour ajouter le nouvel utilisateur
            Return oDlivrerf.Ajouterlivrerf(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majlivrerf(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDlivrerf.Majlivrerf(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
   
#End Region

End Class
