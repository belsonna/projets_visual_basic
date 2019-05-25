Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class UCProjet
    Private oclient As CONTROLLEUR.CTRClient
    Private oprojet As CONTROLLEUR.CTRProjet
    Private ocotation As CONTROLLEUR.CTRCotation
    Private odataset As DataSet
    Dim nom As String
    Dim courant, param As Integer
    Private Sub UCProjet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'verou()
        LOADCMBOBOX()
        loadgrid()
    End Sub
    Sub copie()
        courant = gridprojet.CurrentRow.Index
        tbnum.Text = odataset.Tables("PROJET").Rows(courant).Item("Numero").ToString
        tbdescription.Text = odataset.Tables("PROJET").Rows(courant).Item("Description").ToString
        cbcli.Text = odataset.Tables("PROJET").Rows(courant).Item("Client").ToString
        Datecre.Text = odataset.Tables("PROJET").Rows(courant).Item("Datecreation").ToString
    End Sub
    Sub prochaincot()
        Dim nb As Integer
        Try
            Using ocotation As New CONTROLLEUR.CTRCotation(G_ConString)

                nb = ocotation.prochain
                'MsgBox(nb)
                nb = nb + 1
                nom = "COT" & nb & Date.Now.Year

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Sub efface()
        tbdescription.Text = ""
        Datecre.Text = ""
        cbcli.Text = ""
        tbnum.Text = ""
    End Sub
    Sub verou()
        tbdescription.Enabled = False
        Datecre.Enabled = False
        cbcli.Enabled = False

    End Sub
    Sub deverou()
        tbdescription.Enabled = True
        Datecre.Enabled = True
        cbcli.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Gbprojet.Text = "Nouveau projet"
        efface()
        deverou()
        prochain()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If tbnum.Text = "" Then
            MsgBox("veuillez choisir le projet à modifier")
        Else
            Gbprojet.Text = "Modification d'un projet"
            deverou()
        End If
    End Sub
    Sub loadgrid()
        initialiser()
        Using oprojet As New CONTROLLEUR.CTRProjet(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = oprojet.Listprojet()
                gridprojet.DataSource = Nothing
                gridprojet.DataSource = odataset.Tables("PROJET")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub loadgridt()
        initialiser()
        Using oprojet As New CONTROLLEUR.CTRProjet(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = oprojet.Listprojett()
                gridprojet.DataSource = Nothing
                gridprojet.DataSource = odataset.Tables("PROJET")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub LOADCMBOBOX()
        initialiser()
        Using oclient As New CONTROLLEUR.CTRClient(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = oclient.LisclientN()
                cbcli.DataSource = Nothing
                cbcli.DataSource = odataset.Tables("CLIENT")
                cbcli.DisplayMember = "Nom"
                cbcli.ValueMember = "Nom"
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub

    Private Sub gridprojet_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridprojet.CellClick
        copie()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Gbprojet.Text = "Nouveau projet" Then
            If (tbnum.Text = "" Or tbdescription.Text = "" Or cbcli.Text = "" Or Datecre.Text = "") Then
                MessageBox.Show("Tous les champs sont obligatoires", "Erreur Saisie")
            Else
                Try
                    Using oprojet As New CONTROLLEUR.CTRProjet(G_ConString)

                            If MsgBox("Etes-vous sûr de vouloir l'enregistrer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                                If Ajouterprojet() = True Then
                                    MessageBox.Show("Enregistré avec succès!", "Enregistrement du fournisseur")
                                loadgrid()
                                efface()
                                Else
                                    MessageBox.Show("Erreur d'enregistrement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End If

                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString)
                End Try
            End If
        ElseIf Gbprojet.Text = "Modification d'un projet" Then
            Try
                Using oFOURNISSEUR As New CONTROLLEUR.CTRFournisseur(G_ConString)


                    If MsgBox("Etes-vous sûr de vouloir modifier?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                        If modifierprojet() Then
                            MessageBox.Show("Modifié avec succès!", "mofification du projet")
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
    Sub prochain()
        Dim nb As Integer
        Try
            Using oprojet As New CONTROLLEUR.CTRProjet(G_ConString)

                nb = oprojet.prochain
                nb = nb + 1
                tbnum.Text = "PROJ" & nb & Date.Now.Year

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Function Ajouterprojet() As Boolean
        Using oprojet As New CONTROLLEUR.CTRProjet(G_ConString)
            'Get a new Project DataSet
            odataset = oprojet.Nvprojet()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("PROJET").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Numero") = Trim(tbnum.Text)
            oDataRow.Item("Description") = Trim(tbdescription.Text)
            oDataRow.Item("Client") = Trim(cbcli.Text)
            oDataRow.Item("Datecreation") = Trim(Datecre.Value)
            oDataRow.Item("Datecloture") = Trim(Datecre.Value)
            'Add the DataRow to the DataSet
            odataset.Tables("PROJET").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not oprojet.Ajouterprojet(odataset) Then
                Throw New Exception("Echec d'enregistrement")
            Else
                Ajouterprojet = True
            End If
        End Using
    End Function
    Function modifierprojet() As Boolean
        Using oprojet As New CONTROLLEUR.CTRProjet(G_ConString)
            'Get a new Project DataSet
            odataset = oprojet.Nvprojet()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("PROJET").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Numero") = Trim(tbnum.Text)
            oDataRow.Item("Description") = Trim(tbdescription.Text)
            oDataRow.Item("Client") = Trim(cbcli.Text)
            oDataRow.Item("Datecreation") = Trim(Datecre.Value)
            oDataRow.Item("Datecloture") = Trim(Datecre.Value)
            'Add the DataRow to the DataSet
            odataset.Tables("PROJET").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not oprojet.Majprojet(odataset) Then
                Throw New Exception("Echec de modification")
            Else
                modifierprojet = True
            End If
        End Using
    End Function

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If tbnum.Text = "" Then
            MsgBox("Veuillez choisir le projet à supprimer")
        Else
            Try
                Using oprojet As New CONTROLLEUR.CTRProjet(G_ConString)

                    If MsgBox("Etes-vous sûr de vouloir supprimer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                        If oprojet.supprimer(tbnum.Text) = True Then
                            MessageBox.Show("Supprimé avec succès!", "suppression du projet")
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

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Try
            Using oprojet As New CONTROLLEUR.CTRProjet(G_ConString)

                If MsgBox("Etes-vous sûr de vouloir confirmer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                    If oprojet.confirme(tbnum.Text, Date.Now) = True Then
                        MessageBox.Show("Enregistré avec succès!", "Enregistrement d'une confirmation")
                        loadgrid()
                        efface()
                    Else
                        MessageBox.Show("Erreur d'enregistrement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub liberer()
        For i As Integer = 0 To odataset.Tables("PROJET").Rows.Count - 1
            gridprojet.Rows(i).Selected = False

        Next
    End Sub
    Sub rechercher()
        Dim nbe, paramE As Integer
        paramE = odataset.Tables("PROJET").Rows.Count
        For i As Integer = 0 To odataset.Tables("PROJET").Rows.Count - 1
            If odataset.Tables("PROJET").Rows(i).Item("Client").ToString <> Tbrech.Text Then
                nbe = i
            Else
                paramE = i
            End If

        Next
        If paramE <> odataset.Tables("PROJET").Rows.Count Then
            gridprojet.Rows(paramE).Selected = True

        Else
            liberer()
            MessageBox.Show("aucun element ne convient à ce critère!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        liberer()
        rechercher()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Ajoutecotation() = True Then
            MessageBox.Show("Enregistré avec succès!", "Enregistrement du fournisseur")
            efface()
        Else
            MessageBox.Show("Erreur d'enregistrement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Function Ajoutecotation() As Boolean
        Using ocotation As New CONTROLLEUR.CTRCotation(G_ConString)
            Dim nb As Integer
            nb = ocotation.prochain
            'MsgBox(nb)
            nb = nb + 1
            nom = "COT" & nb & Date.Now.Year
            'Get a new Project DataSet
            odataset = ocotation.Nvcotation()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("COTATION").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Numcot") = nom

            oDataRow.Item("projet") = Trim(tbnum.Text)

            oDataRow.Item("ObjetCOT") = "A renseigner plus tard"
            oDataRow.Item("taxe") = 0
            oDataRow.Item("Montant") = 0
            oDataRow.Item("lettre") = "zero"
            'Add the DataRow to the DataSet
            odataset.Tables("COTATION").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not ocotation.Ajoutercotation(odataset) Then
                Throw New Exception("Echec d'enregistrement")
            Else
                Ajoutecotation = True
            End If
        End Using
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        efface()
        verou()
    End Sub

    Private Sub PictureBox4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        loadgridt()
    End Sub

    Private Sub Pbcom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbcom.Click
        Try
            Using ocotation As New CONTROLLEUR.CTRCotation(G_ConString)

                If MsgBox("Etes-vous sûr de vouloir enregisté?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                    If Ajoutecotation() = True Then
                        MessageBox.Show("Enregistré avec succès!", "Enregistrement d'une confirmation")
                        loadgrid()
                        efface()
                    Else
                        MessageBox.Show("Erreur d'enregistrement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
End Class
