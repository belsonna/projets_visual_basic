Imports System.Data
Imports System.Data.SqlClient
Module ModulConexion

    Dim frmSplash As New PRINCIPAL
#Region "vérification de connexion à la BD"

    Sub Main()
        If VerifDataBase() Then

            frmSplash.ShowDialog()

        Else
            MessageBox.Show("Connexion à la BD impossible", "Erreur de connexion", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Function VerifDataBase() As Boolean
        Dim oCon As SqlConnection
        Dim sp As String
        'Dim ds As String

        'ds = My.Settings.DataSource
        sp = Application.StartupPath
        '  G_ConString = " Data Source=" & sp & ds & ";" & _
        '"Integrated Security=True;User Instance=True"
        G_ConString = "Data Source=BELONA-PC;Initial Catalog=BUYINGHOUSE;Integrated Security=True"
        MsgBox(G_ConString)
        oCon = New SqlConnection(G_ConString)


        Try
            oCon.Open()
            VerifDataBase = True
            MsgBox("après connexion")
        Catch ex As Exception
            MsgBox(ex.Message)
            VerifDataBase = False
        End Try
    End Function

#End Region
End Module
