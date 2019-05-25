Public Class CTRCommande
    Implements IDisposable
    Private oDcommande As MODELS.MODCommande
    Private disposedValue As Boolean = False
#Region "Constructeur et Destructeur"
    Public Sub New(ByVal Constring As String)
        oDcommande = New MODELS.MODCommande(Constring)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
            End If
            oDcommande.Dispose()
            oDcommande = Nothing
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
            Dim com As Integer
            UserDataSet = New DataSet
            UserDataSet = oDcommande.LISTECOMMANDE

            com = UserDataSet.Tables("COMMANDE").Rows.Count

            prochain = com
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Nvcommande() As DataSet
        Try
            'instancie un nouveau objet DataSet 
            Nvcommande = New DataSet

            'crée un objet Datatable 
            Dim objDataTable As DataTable = Nvcommande.Tables.Add("COMMANDE")

            'crée un objet DataColumn 
            Dim objDataColumn As DataColumn

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Numero", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 15


            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("proforma", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 15

            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            objDataColumn = New DataColumn("Objet", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 255
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)
            'Instancie un nouveau DataColumn et fixe ses propriétés
            


        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Liscmmande() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Liscmmande = oDcommande.LISTECOMMANDE
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function Liscmmandep(ByVal prof As String) As Boolean
        Dim odataset As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            odataset = oDcommande.LISTECOMMANDEp(prof)
            If odataset.Tables("COMMANDE").Rows.Count < 0 Then
                Return True
            Else
                Return False
            End If
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Livreecommande(ByVal commande As String) As Boolean
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Livreecommande = oDcommande.livrecommande(commande)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Ajoutercommande(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour ajouter le nouvel utilisateur
            Return oDcommande.Ajoutercommande(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majcommande(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDcommande.Majcommande(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

#End Region
End Class
