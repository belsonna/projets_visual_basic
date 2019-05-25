Public Class CTRFACTURERF
    Implements IDisposable
    Private oDfacturerF As MODELS.MODFacturerF
    Private disposedValue As Boolean = False        ' Détection des appels rédondants

    ' IDisposable
#Region "Constructeur et Destructeur"
    Public Sub New(ByVal Constring As String)
        oDfacturerF = New MODELS.MoDfacturerF(Constring)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
            End If
            oDfacturerF.Dispose()
            oDfacturerF = Nothing
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
    Function exite(ByVal client As DataSet) As Boolean
        Try
            Dim UserDataSet As DataSet
            UserDataSet = New DataSet
            UserDataSet = oDfacturerF.factureexistant(client)

            If UserDataSet.Tables("FACTURERF").Rows.Count > 0 Then

                exite = True
            Else

                exite = False
            End If
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Nvfacturerf() As DataSet
        Try
            'instancie un nouveau objet DataSet 
            Nvfacturerf = New DataSet

            'crée un objet Datatable 
            Dim objDataTable As DataTable = Nvfacturerf.Tables.Add("FACTURERF")

            'crée un objet DataColumn 
            Dim objDataColumn As DataColumn

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("NumFac", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 15
            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("COM", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 15

            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("montant", _
                Type.GetType("System.Int32"))

            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)
            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Datecrea", _
                Type.GetType("System.DateTime"))

            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)


        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Listfacturerf() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listfacturerf = oDfacturerF.LISTEFACTUREF
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Ajouterfacturer(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour ajouter le nouvel utilisateur
            Return oDfacturerF.Ajouterfacturef(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majfacturer(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDfacturerF.Majfacturef(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function prochain() As Integer
        Try
            Dim UserDataSet As DataSet
            Dim proch As Integer
            UserDataSet = New DataSet
            UserDataSet = oDfacturerF.LISTEFACTUREF

            proch = UserDataSet.Tables("FACTURERF").Rows.Count

            prochain = proch
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function


#End Region
End Class
