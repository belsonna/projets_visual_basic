Public Class CTRProjet
    Implements IDisposable
    Private oDprojet As MODELS.MODProjet
    Private disposedValue As Boolean = False
    Dim odataset As DataSet
    Dim nom As String
#Region "Constructeur et Destructeur"
    Public Sub New(ByVal Constring As String)
        oDprojet = New MODELS.MoDprojet(Constring)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
            End If
            oDprojet.Dispose()
            oDprojet = Nothing
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
            UserDataSet = oDprojet.LISTEPROJETp()

            proch = UserDataSet.Tables("PROJET").Rows.Count
            prochain = proch

        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Nvprojet() As DataSet
        Try
            'instancie un nouveau objet DataSet 
            Nvprojet = New DataSet

            'crée un objet Datatable 
            Dim objDataTable As DataTable = Nvprojet.Tables.Add("PROJET")

            'crée un objet DataColumn 
            Dim objDataColumn As DataColumn

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Numero", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 15


            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Description", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 255

            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            objDataColumn = New DataColumn("client", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 50
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Datecreation", _
                Type.GetType("System.DateTime"))
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)
            'Instancie un nouveau DataColumn et fixe ses propriétés

            objDataColumn = New DataColumn("Datecloture", _
               Type.GetType("System.DateTime"))
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)

            objDataColumn = New DataColumn("etat", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 15
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)
            'Instancie un nouveau DataColumn et fixe ses propriétés


        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Listprojet() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listprojet = oDprojet.LISTEPROJET
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function Listprojett() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listprojett = oDprojet.LISTEPROJETp
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
   
    Public Function supprimer(ByVal proj As String) As Boolean
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            supprimer = oDprojet.Supprojet(proj)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function nomclient(ByVal proj As String) As String
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            odataset = oDprojet.PROJETclient(proj)
            Return odataset.Tables("PROJET").Rows(0).Item("Client").ToString
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function restaurer(ByVal proj As String) As Boolean
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            restaurer = oDprojet.restorprojet(proj)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function confirme(ByVal proj As String, ByVal dat As Date) As Boolean
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            confirme = oDprojet.confirme(proj, dat)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Ajouterprojet(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour ajouter le nouvel utilisateur
            Return oDprojet.Ajouterprojet(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majprojet(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDprojet.MajPROJET(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

#End Region
End Class
