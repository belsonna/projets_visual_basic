Public Class CTRFacturerTEC
    Implements IDisposable
    Private oDfacturertec As MODELS.MODFacturerTEC
    Private disposedValue As Boolean = False        ' Détection des appels rédondants

    ' IDisposable
#Region "Constructeur et Destructeur"
    Public Sub New(ByVal Constring As String)
        oDfacturertec = New MODELS.MODFacturerTEC(Constring)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
            End If
            oDfacturertec.Dispose()
            oDfacturertec = Nothing
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
    

    Public Function Nvfacturertec() As DataSet
        Try
            'instancie un nouveau objet DataSet 
            Nvfacturertec = New DataSet

            'crée un objet Datatable 
            Dim objDataTable As DataTable = Nvfacturertec.Tables.Add("FACTURERTEC")

            'crée un objet DataColumn 
            Dim objDataColumn As DataColumn

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Num", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 15
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Po", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 15
            objDataTable.Columns.Add(objDataColumn)


            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("montant", _
                Type.GetType("System.Int32"))

            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)


            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("lettre", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 255
            objDataTable.Columns.Add(objDataColumn)
            'Instancie un nouveau DataColumn et fixe ses propriétés

            objDataColumn = New DataColumn("datefac", _
                Type.GetType("System.DateTime"))
            objDataTable.Columns.Add(objDataColumn)
            MsgBox("je suis ici")
            objDataColumn = New DataColumn("banque", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 255
            objDataTable.Columns.Add(objDataColumn)

            objDataColumn = New DataColumn("compte", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 255
            objDataTable.Columns.Add(objDataColumn)



        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Listfacturertec() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listfacturertec = oDfacturertec.LISTEfacturert
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Ajouterfacturertec(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour ajouter le nouvel utilisateur
            Return oDfacturertec.Ajouterfacturetec(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majfacturertec(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDfacturertec.Majfacturetec(client)
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
            UserDataSet = oDfacturertec.LISTEfacturert

            proch = UserDataSet.Tables("FACTURERTEC").Rows.Count

            prochain = proch
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function


#End Region
End Class
