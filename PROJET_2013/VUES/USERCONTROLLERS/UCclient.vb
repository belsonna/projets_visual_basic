Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class UCclient
    Private oclient As CONTROLLEUR.CTRClient
    Private odataset As DataSet
    Dim nom As String
    Dim courant, param As Integer
    Private Sub UCclient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        efface()
        loadgrid()

    End Sub
    Private Sub liberer()
        For i As Integer = 0 To odataset.Tables("CLIENT").Rows.Count - 1
            Gridclient.Rows(i).Selected = False

        Next
    End Sub
    Function nomvalide(ByVal nom As String) As Boolean

        Dim rg As New Regex("^([\w]+)$")
        Return rg.IsMatch(nom)
    End Function
    Function verifier() As Boolean
        If Not nomvalide(TBNom.Text.Trim) Then
            MessageBox.Show("caracteres alpha numerique recommandés pour le Nom du client")
            verifier = False
            Exit Function
        End If
        verifier = True
    End Function
    Public Sub copie()

        courant = Gridclient.CurrentRow.Index
        TBNom.Text = odataset.Tables("CLIENT").Rows(courant).Item("Nom").ToString
        TBAdresse.Text = odataset.Tables("CLIENT").Rows(courant).Item("Adresse").ToString
        TBsiege.Text = odataset.Tables("CLIENT").Rows(courant).Item("Siege").ToString

    End Sub
    Sub loadgrid()
        initialiser()
        Using oclient As New CONTROLLEUR.CTRClient(G_ConString)
            Try
                odataset = oclient.Lisclient()
                Gridclient.DataSource = Nothing
                Gridclient.DataSource = odataset.Tables("CLIENT")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub efface()
        TBNom.Text = ""
        TBAdresse.Text = ""
        TBsiege.Text = ""


    End Sub
    Sub verou()
        Gbclient.Enabled = False
        TBAdresse.Enabled = False
        TBNom.Enabled = False
        TBsiege.Enabled = False


    End Sub
    Sub deverou()
        Gbclient.Enabled = True
        TBAdresse.Enabled = True
        TBNom.Enabled = True
        TBsiege.Enabled = True

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        nom = "Nouveau Client"
        Gbclient.Text = nom
        deverou()
        efface()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If TBNom.Text = "" Then
            MsgBox("choisissez le client a modifier")
        Else
            nom = "Modification d'un Client"
            Gbclient.Text = nom
            deverou()
            TBNom.Enabled = False
        End If
    End Sub
    Function AjouterClient() As Boolean
        Using oclient As New CONTROLLEUR.CTRClient(G_ConString)
            'Get a new Project DataSet
            odataset = oclient.Nvclient()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("CLIENT").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Nom") = Trim(TBNom.Text)
            oDataRow.Item("Adresse") = Trim(TBNom.Text)
            oDataRow.Item("Siege") = Trim(TBsiege.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("CLIENT").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not oclient.Ajouterclient(odataset) Then
                Throw New Exception("Echec d'enregistrement")
            Else
                AjouterClient = True
            End If
        End Using
    End Function
    Function modifierClient() As Boolean
        Using oclient As New CONTROLLEUR.CTRClient(G_ConString)
            'Get a new Project DataSet
            odataset = oclient.Nvclient()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("CLIENT").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Nom") = Trim(TBNom.Text)
            oDataRow.Item("Adresse") = Trim(TBNom.Text)
            oDataRow.Item("Siege") = Trim(TBsiege.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("CLIENT").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not oclient.Majclient(odataset) Then
                Throw New Exception("Echec de modification")
            Else
                modifierClient = True
            End If
        End Using
    End Function
    Sub enregistrer()
        If param = 1 Then
            If (TBNom.Text = "" Or TBAdresse.Text = "" Or TBsiege.Text = "") Then
                MessageBox.Show("Tous les champs sont obligatoires", "Erreur Saisie")
            Else
                Try
                    Using oclient As New CONTROLLEUR.CTRClient(G_ConString)

                        If oclient.exite(TBNom.Text) Then
                            MessageBox.Show("Client déja Enregistré", "Enregistrement impossible")
                        Else

                            If MsgBox("Etes-vous sûr de vouloir l'enregistrer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                                If AjouterClient() = True Then
                                    MessageBox.Show("Enregistré avec succès!", "Enregistrement de l'utilisateur")
                                    loadgrid()
                                    efface()
                                Else
                                    MessageBox.Show("Erreur d'enregistrement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End If
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString)
                End Try
            End If
        ElseIf param = 2 Then
            Try
                Using oclient As New CONTROLLEUR.CTRClient(G_ConString)


                    If MsgBox("Etes-vous sûr de vouloir modifier?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                        If modifierClient() Then
                            MessageBox.Show("Modifié avec succès!", "mofification du client")
                            loadgrid()
                            efface()
                        Else
                            MessageBox.Show("Erreur de modification !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If

                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
        End If

        verou()

        efface()
    End Sub

    Private Sub Pbanuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Gbclient.Text = "Nouveau Client" Then
            param = 1
            If verifier() Then
                enregistrer()
            End If
        ElseIf Gbclient.Text = "Modification d'un Client" Then
            param = 2
            If verifier() Then
                enregistrer()
            End If
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        verou()
        efface()
    End Sub

    Private Sub Gridclient_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Gridclient.CellClick
        copie()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If TBNom.Text = "" Then
            MsgBox("veillez choisir le client à supprimer")
        Else
            Try
                Using oclient As New CONTROLLEUR.CTRClient(G_ConString)


                    If MsgBox("Etes-vous sûr de vouloir supprimer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                        If oclient.archive(TBNom.Text) = True Then
                            MessageBox.Show("supprimé avec succès!", "suppression du client")
                            loadgrid()
                            efface()
                        Else
                            MessageBox.Show("Erreur de suppression !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If

                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        rechercher()
    End Sub
    Sub rechercher()
        Dim nbe, param As Integer
        param = odataset.Tables("CLIENT").Rows.Count
        For i As Integer = 0 To odataset.Tables("CLIENT").Rows.Count - 1
            If odataset.Tables("CLIENT").Rows(i).Item("Nom").ToString <> tbrech.Text Then
                nbe = i
            Else
                param = i
            End If

        Next
        If param <> odataset.Tables("CLIENT").Rows.Count Then
            Gridclient.Rows(param).Selected = True

        Else
            liberer()
            MessageBox.Show("aucun element ne convient à ce critère!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
End Class
