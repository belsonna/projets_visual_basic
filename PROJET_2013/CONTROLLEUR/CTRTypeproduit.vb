Public Class CTRTypeproduit
    Implements IDisposable
    Private oDtypeproduit As MODELS.MODTypeproduit
    Private disposedValue As Boolean = False        ' Détection des appels rédondants

    ' IDisposable
#Region "Constructeur et Destructeur"
    Public Sub New(ByVal Constring As String)
        oDtypeproduit = New MODELS.MODTypeproduit(Constring)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
            End If
            oDtypeproduit.Dispose()
            oDtypeproduit = Nothing
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
            UserDataSet = oDtypeproduit.LISTETYPEPRODUITC(compte)
            MsgBox("je suis ici")

            If UserDataSet.Tables("TYPEPRODUIT").Rows.Count > 0 Then

                exite = True
            Else

                exite = False
            End If
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function NvtypPRODUIT() As DataSet
        Try
            'instancie un nouveau objet DataSet 
            NvtypPRODUIT = New DataSet

            'crée un objet Datatable 
            Dim objDataTable As DataTable = NvtypPRODUIT.Tables.Add("TYPEPRODUIT")

            'crée un objet DataColumn 
            Dim objDataColumn As DataColumn

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Code", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 50
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Intitule", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 15
            objDataTable.Columns.Add(objDataColumn)

        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function ListTYPproduit() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            ListTYPproduit = oDtypeproduit.LISTETYPEPRODUIT()
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function ListTYPproduitN() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            ListTYPproduitN = oDtypeproduit.LISTETYPEPRODUITNOM()
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Ajoutertype(ByVal compte As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour ajouter le nouvel utilisateur
            Return oDtypeproduit.Ajoutertypproduit(compte)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function


#End Region
End Class
