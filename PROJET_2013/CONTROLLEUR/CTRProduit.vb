Public Class CTRProduit
    Implements IDisposable
    Private oDproduit As MODELS.MODProduit
    Private disposedValue As Boolean = False        ' Détection des appels rédondants

    ' IDisposable
#Region "Constructeur et Destructeur"
    Public Sub New(ByVal Constring As String)
        oDproduit = New MODELS.MoDproduit(Constring)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
            End If
            oDproduit.Dispose()
            oDproduit = Nothing
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
            UserDataSet = oDproduit.dejaproduit(compte)

            If UserDataSet.Tables("PRODUIT").Rows.Count > 0 Then

                exite = True
            Else

                exite = False
            End If
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function NvPRODUIT() As DataSet
        Try
            'instancie un nouveau objet DataSet 
            NvPRODUIT = New DataSet

            'crée un objet Datatable 
            Dim objDataTable As DataTable = NvPRODUIT.Tables.Add("PRODUIT")

            'crée un objet DataColumn 
            Dim objDataColumn As DataColumn

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Nom", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 50


            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Type", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 50

            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Listproduit() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listproduit = oDproduit.LISTEPRODUIT()
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function Listproduitn(ByVal nom As String) As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listproduitn = oDproduit.LISTEPRODUITN(nom)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function


    Public Function Ajouterproduit(ByVal compte As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour ajouter le nouvel utilisateur
            Return oDproduit.Ajouterproduit(compte)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majproduit(ByVal compte As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDproduit.Majproduit(compte)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function


#End Region
End Class
