Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class UCcompte
    Private ocompte As CONTROLLEUR.CTRCompte
    Private oemp As CONTROLLEUR.CTREmploye

    Private odataset As DataSet
    Dim nom As String
    Dim courant, param As Integer
    Sub loadcombobox()
        initialiser()
        Using oemp As New CONTROLLEUR.CTREmploye(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = oemp.Listemployen()
                cbpro.DataSource = Nothing
                cbpro.DataSource = odataset.Tables("EMPLOYE")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub loadgrid()
        initialiser()
        Using ocompte As New CONTROLLEUR.CTRCompte(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = ocompte.Liscompte()
                gridcompte.DataSource = Nothing
                gridcompte.DataSource = odataset.Tables("COMPTE")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Function AjouterCompte() As Boolean
        Using ocompte As New CONTROLLEUR.CTRCompte(G_ConString)
            'Get a new Project DataSet
            odataset = ocompte.NvDcompte()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("COMPTE").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Proprietaire") = Trim(cbpro.Text)
            oDataRow.Item("password") = Trim(tbpass.Text)
            oDataRow.Item("privilege") = Trim(Cbpri.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("COMPTE").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not ocompte.AjouterCompte(odataset) Then
                Throw New Exception("Echec d'enregistrement")
            Else
                AjouterCompte = True
            End If
        End Using
    End Function
    Function modifiercompte() As Boolean
        Using ocompte As New CONTROLLEUR.CTRCompte(G_ConString)
            'Get a new Project DataSet
            odataset = ocompte.NvDcompte()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("COMPTE").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Proprietaire") = Trim(cbpro.Text)
            oDataRow.Item("password") = Trim(tbpass.Text)
            oDataRow.Item("privilege") = Trim(Cbpri.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("COMPTE").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not ocompte.Majcompte(odataset) Then
                Throw New Exception("Echec de modification")
            Else
                modifiercompte = True
            End If
        End Using
    End Function
    Private Sub chargerphoto()
        Dim fichier, tof As String
        Dim i As Integer
        i = gridcompte.CurrentRow.Index
        tof = gridcompte(0, i).Value.ToString()
        fichier = "..\..\PHOTOS\" & tof & ".jpg"
        ' MsgBox(fichier)
        'PBimCompte.Image = Image.FromFile(fichier)
    End Sub
    Public Sub copie()
        Dim j As Integer
        initialiser()
        courant = gridcompte.CurrentRow.Index
        j = gridcompte.CurrentRow.Index
        chargerphoto()
        cbpro.Text = gridcompte(0, j).Value.ToString()
        tbpass.Text = gridcompte(0, j).Value.ToString()
        Cbpri.Text = gridcompte(0, j).Value.ToString()

    End Sub

    Private Sub UCcompte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadgrid()
        loadcombobox()
        verou()
    End Sub
    Sub annuler()
        tbpass.Text = ""
        Cbpri.Text = ""
        cbpro.Text = ""
        tofdefaut()
    End Sub
    Sub tofdefaut()
        Dim fichier, tof As String
        tof = "default"
        fichier = "..\..\PHOTOS\" & tof & ".jpg"
        ' MsgBox(fichier)
        'PBimCompte.Image = Image.FromFile(fichier)
    End Sub
    Sub verou()
        Gbcompte.Enabled = False
        tbpass.Enabled = False
        Cbpri.Enabled = False
        cbpro.Enabled = False
        Btenreg.Enabled = False
        Pbanuler.Enabled = False
        tofdefaut()

    End Sub
    Sub deverou()
        Gbcompte.Enabled = True
        tbpass.Enabled = True
        Cbpri.Enabled = True
        cbpro.Enabled = True
        Btenreg.Enabled = True
        Pbanuler.Enabled = True

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        annuler()
        nom = "Nouveau Compte"
        Gbcompte.Text = nom
        deverou()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If cbpro.Text = "" Then
            MsgBox("Veuillez choisir un compte à modifier")
        Else
            nom = "Modification du compte"
            Gbcompte.Text = nom
            deverou()
            cbpro.Enabled = False
        End If

    End Sub
    Sub rechercher()
        Dim nbe, param As Integer
        param = odataset.Tables("COMPTE").Rows.Count
        For i As Integer = 0 To odataset.Tables("COMPTE").Rows.Count - 1
            If odataset.Tables("COMPTE").Rows(i).Item("Proprietaire").ToString <> TBRECH.Text Then
                nbe = i
            Else
                param = i
            End If

        Next
        If param <> odataset.Tables("COMPTE").Rows.Count Then
            gridcompte.Rows(param).Selected = True

        Else
            liberer()
            MessageBox.Show("aucun element ne convient à ce critère!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Private Sub liberer()
        For i As Integer = 0 To odataset.Tables("COMPTE").Rows.Count - 1
            gridcompte.Rows(i).Selected = False

        Next
    End Sub
    Sub enregistrer()
        If param = 1 Then
            If (cbpro.Text = "" Or tbpass.Text = "" Or Cbpri.Text = "") Then
                MessageBox.Show("Tous les champs sont obligatoires", "Erreur Saisie")
            Else
                Try
                    Using ocompte As New CONTROLLEUR.CTRCompte(G_ConString)

                        If ocompte.exite(Cbpri.Text) Then
                            MessageBox.Show("Cet Employé possede deja un Compte", "Enregistrement impossible")
                        Else

                            If MsgBox("Etes-vous sûr de vouloir l'enregistrer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                                If AjouterCompte() = True Then
                                    MessageBox.Show("Enregistré avec succès!", "Enregistrement de l'utilisateur")
                                    loadgrid()
                                    annuler()
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
                Using ocompte As New CONTROLLEUR.CTRCompte(G_ConString)

                    If MsgBox("Etes-vous sûr de vouloir modifier?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                        If modifiercompte() = True Then
                            MessageBox.Show("modifié avec succès!", "Enregistrement de l'utilisateur")
                            loadgrid()
                            annuler()
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
        annuler()
    End Sub
    Private Sub Pbanuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbanuler.Click
        annuler()
        verou()

    End Sub

  
    Private Sub gridcompte_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridcompte.CellClick
        copie()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btenreg.Click
        If Me.Gbcompte.Text = "Nouveau Compte" Then
            param = 1
            enregistrer()
        ElseIf Me.Gbcompte.Text = "Modification du compte" Then
            param = 2
            enregistrer()
        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        rechercher()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If cbpro.Text = "" Then
            MsgBox("Veuillez choisir un compte à modifier")
        Else
            Try
                Using ocompte As New CONTROLLEUR.CTRCompte(G_ConString)
                    If MsgBox("Etes-vous sûr de vouloir supprimer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                        If ocompte.Supcompte(cbpro.Text) Then
                            MessageBox.Show("supprimé avec succès!", "Enregistrement de l'utilisateur")
                            loadgrid()
                            annuler()
                        Else
                            MessageBox.Show("Erreur de suppression !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try

            loadgrid()
            verou()
        End If
    End Sub
End Class
