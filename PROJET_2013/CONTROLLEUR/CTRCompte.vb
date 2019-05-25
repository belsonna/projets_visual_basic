Public Class CTRCompte
    Implements IDisposable
    Private oDcompte As MODELS.MODCompte
    Private disposedValue As Boolean = False        ' Détection des appels rédondants

    ' IDisposable
#Region "Constructeur et Destructeur"
    Public Sub New(ByVal Constring As String)
        oDcompte = New MODELS.MODCompte(Constring)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
            End If
            oDcompte.Dispose()
            oDcompte = Nothing
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
    Function exite(ByVal compte As String) As Boolean
        Try
            Dim UserDataSet As DataSet
            UserDataSet = New DataSet
            UserDataSet = oDcompte.compteexistant(compte)

            If UserDataSet.Tables("COMPTE").Rows.Count > 0 Then

                exite = True
            Else

                exite = False
            End If
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function NvDcompte() As DataSet
        Try
            'instancie un nouveau objet DataSet 
            NvDcompte = New DataSet

            'crée un objet Datatable 
            Dim objDataTable As DataTable = NvDcompte.Tables.Add("COMPTE")

            'crée un objet DataColumn 
            Dim objDataColumn As DataColumn

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Proprietaire", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 15


            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("password", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 15

            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("privilege", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 15
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)


        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Liscompte() As DataSet
        Try

            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Liscompte = oDcompte.LISTECOMPTE()
           
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

   
    Public Function ConPossible(ByVal compte As DataSet) As Boolean
        Try
            Dim dataset As DataSet = oDcompte.ConPossible(compte)

            If dataset.Tables("COMPTE").Rows.Count > 0 Then
                ConPossible = True
            Else
                ConPossible = False
            End If
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function AjouterCompte(ByVal compte As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour ajouter le nouvel utilisateur
            Return oDcompte.Ajoutercompte(compte)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majcompte(ByVal compte As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDcompte.Majcompte(compte)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Supcompte(ByVal compte As String) As Boolean
        Try
            'Appel le composant de données pour supprimer l'utilisateur
            Return oDcompte.Supcompte(compte)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
#End Region
End Class
