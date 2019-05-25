Public Class CTRCotation
    Implements IDisposable
    Private oDcotation As MODELS.MODCotation
    Private disposedValue As Boolean = False
#Region "Constructeur et Destructeur"
    Public Sub New(ByVal Constring As String)
        oDcotation = New MODELS.MODCotation(Constring)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
            End If
            oDcotation.Dispose()
            oDcotation = Nothing
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
            UserDataSet = oDcotation.LISTECOTATION

            proch = UserDataSet.Tables("COTATION").Rows.Count
            prochain = proch

        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Nvcotation() As DataSet
        Try
            'instancie un nouveau objet DataSet 
            Nvcotation = New DataSet

            'crée un objet Datatable 
            Dim objDataTable As DataTable = Nvcotation.Tables.Add("COTATION")

            'crée un objet DataColumn 
            Dim objDataColumn As DataColumn

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Numcot", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 15


            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)
            objDataColumn = New DataColumn("projet", _
              Type.GetType("System.String"))
            objDataColumn.MaxLength = 15


            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("ObjetCOT", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 55

            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)
            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("taxe", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 55

            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Montant", _
                Type.GetType("System.Int32"))
            objDataTable.Columns.Add(objDataColumn)
            'Instancie un nouveau DataColumn et fixe ses propriétés

            objDataColumn = New DataColumn("lettre", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 255
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)


        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Liscotation() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Liscotation = oDcotation.LISTECOTATION
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function LiscotationN() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            LiscotationN = oDcotation.LISTECOTATION
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function cottaxe(ByVal client As String) As String
        Try
            Dim cli As String
            Dim odataset As DataSet

            'Appel le composant de données pour ajouter le nouvel utilisateur
            odataset = oDcotation.taxe(client)
            cli = odataset.Tables("COTATION").Rows(0).Item("taxe").ToString
            cottaxe = cli
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Ajoutercotation(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour ajouter le nouvel utilisateur
            Return oDcotation.Ajoutercotation(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majcotation(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDcotation.Majcotation(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function MONTANTCOTATION(ByVal cot As String) As Integer
        Try
            Dim UserDataSet As DataSet
            Dim proch As Integer
            UserDataSet = New DataSet
            UserDataSet = oDcotation.montantcotation(cot)
            proch = 0
            If UserDataSet.Tables("PROFORMA").Rows.Count > 0 Then
                For i As Integer = 0 To UserDataSet.Tables("PROFORMA").Rows.Count - 1
                    proch = proch + UserDataSet.Tables("PROFORMA").Rows(i).Item("montant")
                   
                Next
            Else
                proch = 0
            End If
            MONTANTCOTATION = proch

        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

#End Region

End Class
