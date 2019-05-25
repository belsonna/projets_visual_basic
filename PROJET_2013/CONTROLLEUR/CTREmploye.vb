Public Class CTREmploye
    Implements IDisposable
    Private oDEmploye As MODELS.MODEmploye
    Private disposedValue As Boolean = False
#Region "Constructeur et Destructeur"
    Public Sub New(ByVal Constring As String)
        oDEmploye = New MODELS.MoDEmploye(Constring)
    End Sub
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
            End If
            oDEmploye.Dispose()
            oDEmploye = Nothing
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
    Function prochain(ByVal client As String) As Boolean
        Try
            Dim UserDataSet As DataSet
            UserDataSet = New DataSet
            Dim nbe As Integer
            UserDataSet = oDEmploye.employeexistant(client)
            nbe = UserDataSet.Tables("EMPLOYE").Rows.Count
            MsgBox(nbe)
            If nbe > 0 Then
                prochain = True
            Else
                prochain = False
            End If
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function NvEmploye() As DataSet
        Try
            'instancie un nouveau objet DataSet 
            NvEmploye = New DataSet

            'crée un objet Datatable 
            Dim objDataTable As DataTable = NvEmploye.Tables.Add("EMPLOYE")

            'crée un objet DataColumn 
            Dim objDataColumn As DataColumn

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("CNI", _
               Type.GetType("System.String"))
            objDataColumn.MaxLength = 15


            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Nom", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 15

            'Ajoute le datacolumn à la table
            objDataTable.Columns.Add(objDataColumn)

            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Adresse", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 15
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)
            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Email", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 100
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)
            objDataColumn = New DataColumn("DateNaiss", _
                Type.GetType("System.DateTime"))

            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)
            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("photo", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 100
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)
            'Instancie un nouveau DataColumn et fixe ses propriétés
            objDataColumn = New DataColumn("Service", _
                Type.GetType("System.String"))
            objDataColumn.MaxLength = 100
            'Add the column to the table
            objDataTable.Columns.Add(objDataColumn)


        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Listemploye() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listemploye = oDEmploye.LISTEEMPLOYE
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function Listemployec() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listemployec = oDEmploye.LISTEEMPLOYEC
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Listemployen() As DataSet
        Try
            'Appel le composant de donnée pour obtenir tous les utilisateurs
            Listemployen = oDEmploye.LISTEEMPLOYENOM
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Ajouteremploye(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour ajouter le nouvel utilisateur
            Return oDEmploye.AjouterEmploye(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

    Public Function Majemploye(ByVal client As DataSet) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDEmploye.Majemploye(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function supemploye(ByVal client As String) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDEmploye.SupEMPLOYE(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function
    Public Function resemploye(ByVal client As String) As Boolean
        Try
            'Valide les données de l'utilisateur

            'Appel le composant de données pour mettre à jour l'utilisateur
            Return oDEmploye.restorEMPLOYE(client)
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        End Try
    End Function

#End Region
End Class
