Imports System
Imports System.Data
Imports System.Data.DataRow
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Public Class CONNEXION

    ' TODO: insérez le code pour effectuer une authentification personnalisée à l'aide du nom d'utilisateur et du mot de passe fournis 
    ' (Voir http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' L'objet Principal personnalisé peut ensuite être associé à l'objet Principal du thread actuel comme suit : 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' CustomPrincipal est l'implémentation IPrincipal utilisée pour effectuer l'authentification. 
    ' Par la suite, My.User retournera les informations d'identité encapsulées dans l'objet CustomPrincipal
    ' telles que le nom d'utilisateur, le nom complet, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        If Me.TBMDPCON.Text = "" Or Me.TBNOMCON.Text = "" Or Me.TBUTILCON.Text = "" Or Me.TBSERPER.Text = "" Then
            MsgBox(" COMPLETER LES INFORMATIONS POUR LA CONNEXION")

        Else

            If Me.TBMDPCON.Text = "belona" And Me.TBNOMCON.Text = "admin" And Me.TBSERPER.Text = "admin" And Me.TBUTILCON.Text = "admin" Then

                ACCEUIL.Show()
                Me.Close()

            Else

                Dim ObjetConnection As SqlConnection
                Dim ObjetCommand As SqlCommand
                Dim ObjetDataAdapter As SqlDataAdapter
                Dim ObjetDataSet As New DataSet
                Dim strSql As String
                Dim ObjetDataTable As DataTable
                Dim strConn As String




                strConn = "Data Source=.;Initial Catalog=LOCAL BUYING HOUSE;Integrated Security=True;Pooling=False"

                strSql = "SELECT *FROM PERSONNEL WHERE NomPer='" + Me.TBNOMCON.Text + "' AND (LoginPer= '" + Me.TBMDPCON.Text + "' AND licencie= 'non')"
                ObjetConnection = New SqlConnection
                ObjetConnection.ConnectionString = strConn
                Try
                    ObjetConnection.Open()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                ObjetCommand = New SqlCommand(strSql)
                ObjetDataAdapter = New SqlDataAdapter(ObjetCommand)
                ObjetCommand.Connection() = ObjetConnection
                ObjetDataAdapter.Fill(ObjetDataSet, "PERSONNEL")
                ObjetDataTable = ObjetDataSet.Tables("PERSONNEL")
                If ObjetDataTable.Rows.Count < 1 Then
                    MsgBox(" VEUILLEZ VOUS RAPPROCHER DE L'ADMINISTRATEUR")

                Else

                    If (Me.TBUTILCON.Text = "ADMINISTRATEUR" Or Me.TBUTILCON.Text = "administrateur") Then
                        MsgBox("BIENVENUE " + Me.TBNOMCON.Text)
                        ACCEUIL.Show()
                        Me.Close()
                    ElseIf (Me.TBUTILCON.Text = "ACHAT" Or Me.TBUTILCON.Text = "achat") Then
                        MsgBox("BIENVENUE " + Me.TBNOMCON.Text)
                        ACHAT.Show()
                        Me.Close()
                    ElseIf (Me.TBUTILCON.Text = "CONFORMITE" Or Me.TBUTILCON.Text = "conformite") Then
                        MsgBox("BIENVENUE " + Me.TBNOMCON.Text)
                        CONFORMITE_DES_COMMANDE_COTCO.Show()
                        Me.Close()
                    ElseIf (Me.TBUTILCON.Text = "DIRECTION" Or Me.TBUTILCON.Text = "direction") Then
                        MsgBox("BIENVENUE DIRECTEUR " + Me.TBNOMCON.Text)
                        DIRECTION.Show()
                        Me.Close()
                    Else

                        MsgBox("VERIFIER VOTRE NOM DE D'UTILISATEUR")
                    End If
                End If

            End If

        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LogoPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoPictureBox.Click

    End Sub

    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameLabel.Click

    End Sub

    Private Sub CONNEXION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
