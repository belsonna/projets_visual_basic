Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.IO
Public Class UCEmploye
    Dim nom, chaine As String
    Private odataset As DataSet
    Private oemploye As CONTROLLEUR.CTREmploye
    Dim param, courant As Integer
    Sub efface()
        TBAdresse.Text = ""
        TBCNI.Text = ""
        TBEmail.Text = ""
        TBNom.Text = ""
        CbSer.Text = ""
        DPNaiss.Text = ""

    End Sub
    Sub verou()
        GbEmploye.Enabled = False
        TBAdresse.Enabled = False
        TBCNI.Enabled = False
        TBEmail.Enabled = False
        TBNom.Enabled = False
        DPNaiss.Enabled = False
        CbSer.Enabled = False
        'BTphoto.Enabled = False

    End Sub
    Sub deverou()
        GbEmploye.Enabled = True
        TBAdresse.Enabled = True
        TBCNI.Enabled = True
        TBEmail.Enabled = True
        TBNom.Enabled = True
        DPNaiss.Enabled = True
        CbSer.Enabled = True
        'BTphoto.Enabled = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        efface()
        deverou()
        nom = "Nouveau Employe"
        GbEmploye.Text = nom

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        deverou()
        nom = "Modification d'un Employe"
        GbEmploye.Text = nom
        TBCNI.Enabled = False
    End Sub

    Private Sub Pbenreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        verou()
        efface()
    End Sub

    Private Sub Pbanuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        verou()
        efface()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAnu.Click
        verou()
        efface()
    End Sub

    Private Sub BTphoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dlg As New OpenFileDialog
        dlg.Filter = "images(jpg)|*.jpg|images(png)|*.png"
        dlg.ShowDialog()

        Dim fichier As String = dlg.FileName
        ' MsgBox(fichier)
        'PBimCompte.Image = Image.FromFile(fichier)
    End Sub

    Private Sub BTEnreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTEnreg.Click
        If Me.GbEmploye.Text = "Nouveau Employe" Then
            param = 1
            enregistrer()
        ElseIf Me.GbEmploye.Text = "Modification d'un Employe" Then
            param = 2
            enregistrer()
        End If


    End Sub
    Sub enregistrer()
        If verifier() Then
            If param = 1 Then
                If (TBCNI.Text = "" Or TBAdresse.Text = "" Or CbSer.Text = "" Or TBEmail.Text = "" Or TBNom.Text = "" Or DPNaiss.Text = "") Then
                    MessageBox.Show("Tous les champs sont obligatoires", "Erreur Saisie")
                Else
                    Try
                        Using oemploye As New CONTROLLEUR.CTREmploye(G_ConString)

                            If oemploye.prochain(TBCNI.Text) Then
                                MessageBox.Show("Cet Employé existe déja", "Enregistrement impossible")
                            Else

                                If MsgBox("Etes-vous sûr de vouloir l'enregistrer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                                    If Ajouteremploye() = True Then
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
                    Using oemploye As New CONTROLLEUR.CTREmploye(G_ConString)

                        If MsgBox("Etes-vous sûr de vouloir modifier?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                            If modifieremploye() = True Then
                                MessageBox.Show("modifié avec succès!", "Enregistrement de l'utilisateur")
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
        Else
            efface()
        End If

    End Sub

    Private Sub CbSer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbSer.SelectedIndexChanged

    End Sub
    Sub rechercher()
        Dim nbe, param As Integer
        param = odataset.Tables("EMPLOYE").Rows.Count
        For i As Integer = 0 To odataset.Tables("EMPLOYE").Rows.Count - 1
            If odataset.Tables("EMPLOYE").Rows(i).Item("Nom").ToString <> Tbrech.Text Then
                nbe = i
            Else
                param = i
            End If

        Next
        If param <> odataset.Tables("EMPLOYE").Rows.Count Then
            GridEmploye.Rows(param).Selected = True

        Else
            liberer()
            MessageBox.Show("aucun element ne convient à ce critère!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Private Sub liberer()
        For i As Integer = 0 To odataset.Tables("EMPLOYE").Rows.Count - 1
            GridEmploye.Rows(i).Selected = False

        Next
    End Sub
    Private Sub UCEmploye_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadgrid()
        verou()
    End Sub

    Sub loadgrid()
        initialiser()
        Using oemploye As New CONTROLLEUR.CTREmploye(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = oemploye.Listemploye()
                GridEmploye.DataSource = Nothing
                GridEmploye.DataSource = odataset.Tables("EMPLOYE")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Function Ajouteremploye() As Boolean
        Using oemploye As New CONTROLLEUR.CTREmploye(G_ConString)
            'Get a new Project DataSet
            odataset = oemploye.NvEmploye()
            'Initialize a datarow object from the Project DataSet
            chaine = "..\..\PHOTOS\" & TBNom.Text & ".jpg"
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("EMPLOYE").NewRow
            'Set the values in the DataRow
            oDataRow.Item("CNI") = Trim(TBCNI.Text)
            oDataRow.Item("Nom") = Trim(TBNom.Text)
            oDataRow.Item("Adresse") = Trim(TBAdresse.Text)
            oDataRow.Item("Email") = Trim(TBEmail.Text)
            oDataRow.Item("DateNaiss") = Trim(DPNaiss.Value)
            oDataRow.Item("photo") = chaine
            oDataRow.Item("Service") = Trim(CbSer.Text)
            
            'Add the DataRow to the DataSet
            odataset.Tables("EMPLOYE").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not oemploye.Ajouteremploye(odataset) Then
                Throw New Exception("Echec d'enregistrement")
            Else
                Ajouteremploye = True
                'PBimCompte.Image.Save(chaine)

            End If
        End Using
    End Function
    Function modifieremploye() As Boolean
        Using oemploye As New CONTROLLEUR.CTREmploye(G_ConString)
            'Get a new Project DataSet
            odataset = oemploye.NvEmploye()
            'Initialize a datarow object from the Project DataSet
            chaine = "..\..\PHOTOS\" & TBNom.Text & ".jpg"
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("EMPLOYE").NewRow
            'Set the values in the DataRow
            oDataRow.Item("CNI") = Trim(TBCNI.Text)
            oDataRow.Item("Nom") = Trim(TBNom.Text)
            oDataRow.Item("Adresse") = Trim(TBAdresse.Text)
            oDataRow.Item("Email") = Trim(TBEmail.Text)
            oDataRow.Item("DateNaiss") = Trim(DPNaiss.Value)
            oDataRow.Item("photo") = chaine
            oDataRow.Item("Service") = Trim(CbSer.Text)

            'Add the DataRow to the DataSet
            odataset.Tables("EMPLOYE").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not oemploye.Majemploye(odataset) Then
                Throw New Exception("Echec de modification")
            Else
                modifieremploye = True
                'PBimCompte.Image.Save(chaine)

            End If
        End Using
    End Function

    Private Sub GridEmploye_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridEmploye.CellClick
        copie()
    End Sub
    Public Sub copie()

        courant = GridEmploye.CurrentRow.Index
        chargerphoto()
        TBCNI.Text = odataset.Tables("EMPLOYE").Rows(courant).Item("CNI").ToString
        TBNom.Text = odataset.Tables("EMPLOYE").Rows(courant).Item("Nom").ToString
        TBAdresse.Text = odataset.Tables("EMPLOYE").Rows(courant).Item("Adresse").ToString
        TBEmail.Text = odataset.Tables("EMPLOYE").Rows(courant).Item("Email").ToString
        DPNaiss.Text = odataset.Tables("EMPLOYE").Rows(courant).Item("DateNaiss").ToString
        CbSer.Text = odataset.Tables("EMPLOYE").Rows(courant).Item("Service").ToString

    End Sub
    Private Sub chargerphoto()
        Dim tof As String
        tof = odataset.Tables("EMPLOYE").Rows(courant).Item("photo").ToString
        ' MsgBox(fichier)
        'PBimCompte.Image = Image.FromFile(tof)
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Try
            Using oemploye As New CONTROLLEUR.CTREmploye(G_ConString)

                If MsgBox("Etes-vous sûr de vouloir supprimer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                    If oemploye.supemploye(TBCNI.Text) Then
                        MessageBox.Show("supprimé avec succès!", "Enregistrement de l'utilisateur")
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

        verou()
        efface()
    End Sub
    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        rechercher()
    End Sub

    Function verifier() As Boolean
        If (TBNom.Text = "" Or TBAdresse.Text = "" Or TBCNI.Text = "" Or TBEmail.Text = "" Or CbSer.Text = "" Or DPNaiss.Text = "") Then
            MessageBox.Show("tous les champs sont obligatoires!", "veillez les renseigner")
            verifier = False
            Exit Function
        End If
        If Not mailvalide(TBEmail.Text.Trim) Then
            MessageBox.Show("Mauvaise syntaxe de l'email  exemple@bon.com")
            verifier = False
            Exit Function
        End If
        If Not nomvalide(TBNom.Text.Trim) Or Not nomvalide(TBCNI.Text.Trim) Or Not nomvalide(TBAdresse.Text.Trim) Then
            MessageBox.Show("caractere alpha numerique recommandé")
            verifier = False
            Exit Function
        End If
        verifier = True
    End Function
    Function mailvalide(ByVal Adresse As String) As Boolean

        Dim rg As New Regex("^([\w]+)@([\w]+)\.([\w]+)$")
        Return rg.IsMatch(Adresse)

    End Function
    Function nomvalide(ByVal nom As String) As Boolean

        Dim rg As New Regex("^([\w]+)$")
        Return rg.IsMatch(nom)

    End Function
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        liste.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        presence.ShowDialog()
    End Sub
End Class
