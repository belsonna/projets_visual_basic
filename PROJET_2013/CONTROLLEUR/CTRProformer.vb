Public Class CTRProformer
    Implements IDisposable
    Private oDproformer As MODELS.MODProformer
    Private disposedValue As Boolean = False
#Region "Constructeur et Destructeur"
    Public Sub New(ByVal Constring As String)
        oDproformer = New MODELS.MoDproformer(Constring)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
            End If
            oDproformer.Dispose()
            oDproformer = Nothing
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
            UserDataSet = oDproformer.LISTEPRoformer()

            proch = UserDataSet.Tables("PROFORMER").Rows.Count
            prochain = proch

        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Nvproformer() As DataSet
        Try
            'instancie un nouveau objet DataSet 
            Nvproformer = New DataSet

            'crée un objet Datatable 
            Dim objDataTable As DataTable = Nvproformer.Tables.Add("PROFORMER")

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

            objDataColumn = New DataColumn("produit", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 15
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)


            objDataColumn = New DataColumn("PU", _
                Type.GetType("System.Int32"))
            objDataTable.Columns.Add(objDataColumn)

            objDataColumn = New DataColumn("qte", _
               Type.GetType("System.Int32"))
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)
            'Instancie un nouveau DataColumn et fixe ses propriétés


        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Listproformer() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listproformer = oDproformer.LISTEPRoformer
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function Listproformerp(ByVal prof As String) As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listproformerp = oDproformer.Listproformerprof(prof)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Ajouterproformer(ByVal client As DataSet) As Boolean
        Try

            Return oDproformer.AjouteRPROFORMER(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majproformer(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDproformer.MajPROFORMER(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

#End Region
End Class
