Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System
Imports Microsoft.VisualBasic
Imports System.Data.DataRow

Public Class base
    Implements IDisposable
    Public requet As String
    Public connection As SqlConnection
    Public commande As SqlCommand
    Public DataAdapter As SqlDataAdapter
    Public DataReader As SqlDataReader
    Public disposedValue As Boolean = False
    Public cmBluider As SqlCommandBuilder

    Public ObjetConnection As SqlConnection
    Public ObjetCommand As SqlCommand
    Public ObjetDataAdapter As SqlDataAdapter
    Public ObjetDataSet As New DataSet
    Public strsql As String
    Public ObjetDataTable As DataTable
    Public strConn As String
    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: Libérer les ressources non gérées lors d'appel expplicite
                'on libere le dataReader
                If Not DataReader Is Nothing Then
                    DataReader.Close()
                    DataReader = Nothing
                End If
                'on libere le data adapter
                If Not DataAdapter Is Nothing Then
                    DataAdapter.Dispose()
                    DataAdapter = Nothing
                End If
                'on libere les commandes
                If Not commande Is Nothing Then
                    commande.Dispose()
                    commande = Nothing
                End If
                If Not connection Is Nothing Then
                    connection.Close()
                    connection.Dispose()
                    connection = Nothing
                End If
            End If

        End If
        Me.disposedValue = True
    End Sub

    Public Sub New(ByVal ConString As String)
        'Construire la chaine de connexion SQL et initialiser l'objet de connexion
        connection = New SqlConnection(ConString)
    End Sub


#Region " test de liberation de la memoire "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
    Public Sub OpenConnection()
        Try
            connection.Open()
        Catch sqlExceptionErr As SqlException
            Throw New System.Exception(sqlExceptionErr.Message, _
                sqlExceptionErr.InnerException)
        Catch InvalidOperationExceptionErr As InvalidOperationException
            Throw New System.Exception(InvalidOperationExceptionErr.Message, _
                InvalidOperationExceptionErr.InnerException)
        End Try
    End Sub

    Public Sub CloseConnection()
        Try
            cmBluider.GetUpdateCommand()
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub InitializeCommand()
        If commande Is Nothing Then
            Try
                commande = New SqlCommand(requet, connection)
                'Vérifier si c'est une procédure enregistrée
                If Not requet.ToUpper.StartsWith("SELECT ") _
                    And Not requet.ToUpper.StartsWith("INSERT ") _
                    And Not requet.ToUpper.StartsWith("UPDATE ") _
                    And Not requet.ToUpper.StartsWith("DELETE ") Then
                    'la StoredProcedure c'est koi?
                    commande.CommandType = CommandType.StoredProcedure
                End If
            Catch sqlExceptionErr As SqlException
                Throw New System.Exception(sqlExceptionErr.Message, _
                    sqlExceptionErr.InnerException)
            End Try
        End If
    End Sub

    Public Sub InitializeDataAdapter()
        Try
            DataAdapter = New SqlDataAdapter
            cmBluider = New SqlCommandBuilder(DataAdapter)

            DataAdapter.SelectCommand = commande
        Catch sqlExceptionErr As SqlException
            Throw New System.Exception(sqlExceptionErr.Message, _
            sqlExceptionErr.InnerException)
        End Try
    End Sub
    'fonction de remplisage du dataSet
    Public Sub FillDataSet(ByRef oDataSet As DataSet, ByVal TableName As String)
        Try
            InitializeCommand()
            InitializeDataAdapter()
            DataAdapter.Fill(oDataSet, TableName)

        Catch sqlExceptionErr As SqlException
            Throw New System.Exception(sqlExceptionErr.Message, _
                sqlExceptionErr.InnerException)
        Finally
            commande.Dispose()
            commande = Nothing
            DataAdapter.Dispose()
            DataAdapter = Nothing
        End Try
    End Sub
    ' fonction de remplisage du dataTable
    Public Sub FillDataTable(ByRef oDataTable As DataTable)
        Try
            InitializeCommand()
            InitializeDataAdapter()
            DataAdapter.Fill(oDataTable)
        Catch sqlExceptionErr As SqlException
            Throw New System.Exception(sqlExceptionErr.Message, _
                sqlExceptionErr.InnerException)
        Finally
            commande.Dispose()
            commande = Nothing
            DataAdapter.Dispose()
            DataAdapter = Nothing
        End Try
    End Sub

    Public Function ExecuteStoredProcedure() As Integer
        Try
            OpenConnection()
            ExecuteStoredProcedure = commande.ExecuteNonQuery()
        Catch ExceptionErr As Exception
            Throw New System.Exception(ExceptionErr.Message, _
                ExceptionErr.InnerException)
        Finally
            'CloseConnection()
        End Try
    End Function

End Class

