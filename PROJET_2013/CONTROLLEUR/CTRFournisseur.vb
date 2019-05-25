Public Class CTRFournisseur
    Implements IDisposable
    Private oDfournisseur As MODELS.MODFournisseur
    Private disposedValue As Boolean = False
#Region "Constructeur et Destructeur"
    Public Sub New(ByVal Constring As String)
        oDfournisseur = New MODELS.MoDfournisseur(Constring)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
            End If
            oDfournisseur.Dispose()
            oDfournisseur = Nothing
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
    Function exite(ByVal client As String) As Boolean
        Try
            Dim UserDataSet As DataSet
            UserDataSet = New DataSet
            UserDataSet = oDfournisseur.dejaf(client)

            If UserDataSet.Tables("FOURNISSEUR").Rows.Count > 0 Then

                exite = True
            Else

                exite = False
            End If
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Nvfournisseur() As DataSet
        Try
            'instancie un nouveau objet DataSet 
            Nvfournisseur = New DataSet

            'crée un objet Datatable 
            Dim objDataTable As DataTable = Nvfournisseur.Tables.Add("FOURNISSEUR")

            'crée un objet DataColumn 
            Dim objDataColumn As DataColumn

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Nom", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 50
            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Adresse", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 50
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Siegesocial", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 50

            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Secteur", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 50
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)
           


        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Listfournisseur() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listfournisseur = oDfournisseur.LISTEfournisseur
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function Listfournisseurc() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listfournisseurc = oDfournisseur.LISTEfournisseurC
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Ajouterfournisseur(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour ajouter le nouvel utilisateur
            Return oDfournisseur.AjouterFOURNISSEUR(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majfournisseur(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDfournisseur.MajFOURNISSEUR(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function supfournisseur(ByVal client As String) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur 
            Return oDfournisseur.SupFOURNISSEUR(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function resfournisseur(ByVal client As String) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDfournisseur.restorFOURNISSEUR(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

#End Region
End Class
