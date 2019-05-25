Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class UCFournisseur
    Private oFOURNISSEUR As CONTROLLEUR.CTRFournisseur
    Private OTYPE As CONTROLLEUR.CTRTypeproduit
    Private odataset As DataSet
    Dim nom As String
    Dim courant, param As Integer
    Private Sub UCFournisseur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadgrid()
        loadbox()
        deverou()
    End Sub
    Function nomvalide(ByVal nom As String) As Boolean

        Dim rg As New System.Text.RegularExpressions.Regex("^([\w]+)$")
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
    Private Sub Pbenreg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub liberer()
        For i As Integer = 0 To odataset.Tables("FOURNISSEUR").Rows.Count - 1
            Gridfournisseur.Rows(i).Selected = False

        Next
    End Sub
    Sub loadgrid()
        initialiser()
        Using oFOURNISSEUR As New CONTROLLEUR.CTRFournisseur(G_ConString)
            Try
                odataset = oFOURNISSEUR.Listfournisseur()
                Gridfournisseur.DataSource = Nothing
                Gridfournisseur.DataSource = odataset.Tables("FOURNISSEUR")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub EFFACE()
        TBNom.Text = ""
        TBAdresse.Text = ""
        TBsiege.Text = ""
        CbSec.Text = ""
    End Sub
    Sub verou()
        TBNom.Enabled = False
        TBAdresse.Enabled = False
        TBsiege.Enabled = False
        CbSec.Enabled = False

    End Sub
    Sub deverou()
        TBNom.Enabled = True
        TBAdresse.Enabled = True
        TBsiege.Enabled = True
        CbSec.Enabled = True
    End Sub
    Sub loadbox()
        initialiser()
        Using OTYPE As New CONTROLLEUR.CTRTypeproduit(G_ConString)
            Try
                odataset = OTYPE.ListTYPproduitN()
                CbSec.DataSource = Nothing
                CbSec.DataSource = odataset.Tables("TYPEPRODUIT")
                CbSec.DisplayMember = "Code"
                CbSec.ValueMember = "Code"
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        EFFACE()
        Gbfournisseur.Text = "Nouveau Fournisseur"
        deverou()
        'EFFACE()
        param = 1
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If TBNom.Text = "" Then
            MsgBox("Veuillez choisir le fournisseur à modifier")
        Else
            Gbfournisseur.Text = "Modification d'un fournisseur"
            deverou()
            param = 2
        End If
    End Sub
    Sub copie()
        Dim i As Integer
        i = Gridfournisseur.CurrentRow.Index

        TBNom.Text = Gridfournisseur(0, i).Value.ToString()
        TBAdresse.Text = Gridfournisseur(1, i).Value.ToString()
        TBsiege.Text = Gridfournisseur(2, i).Value.ToString()
        CbSec.Text = Gridfournisseur(3, i).Value.ToString()
    End Sub

    Private Sub Gridfournisseur_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Gridfournisseur.CellClick
        copie()
    End Sub

    Function Ajouterfournisseur() As Boolean
        Using oFOURNISSEUR As New CONTROLLEUR.CTRFournisseur(G_ConString)
            'Get a new Project DataSet
            odataset = oFOURNISSEUR.Nvfournisseur()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("FOURNISSEUR").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Nom") = Trim(TBNom.Text)
            oDataRow.Item("Adresse") = Trim(TBNom.Text)
            oDataRow.Item("Siegesocial") = Trim(TBsiege.Text)
            oDataRow.Item("Secteur") = Trim(CbSec.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("FOURNISSEUR").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not oFOURNISSEUR.Ajouterfournisseur(odataset) Then
                Throw New Exception("Echec d'enregistrement")
            Else
                Ajouterfournisseur = True
            End If
        End Using
    End Function
    Function modifierFournisseur() As Boolean
        Using oFOURNISSEUR As New CONTROLLEUR.CTRFournisseur(G_ConString)
            'Get a new Project DataSet
            odataset = oFOURNISSEUR.Nvfournisseur()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("FOURNISSEUR").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Nom") = Trim(TBNom.Text)
            oDataRow.Item("Adresse") = Trim(TBNom.Text)
            oDataRow.Item("Siegesocial") = Trim(TBsiege.Text)
            oDataRow.Item("Secteur") = Trim(CbSec.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("FOURNISSEUR").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not oFOURNISSEUR.Majfournisseur(odataset) Then
                Throw New Exception("Echec de modification")
            Else
                modifierFournisseur = True
            End If
        End Using
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If verifier() Then
            enregistrer()
        End If
    End Sub
    Sub enregistrer()
        If param = 1 Then
            If (TBNom.Text = "" Or TBAdresse.Text = "" Or TBsiege.Text = "") Then
                MessageBox.Show("Tous les champs sont obligatoires", "Erreur Saisie")
            Else
                Try
                    Using oFOURNISSEUR As New CONTROLLEUR.CTRFournisseur(G_ConString)

                        If oFOURNISSEUR.exite(TBNom.Text) Then
                            MessageBox.Show("Fournisseur déja Enregistré", "Enregistrement impossible")
                        Else

                            If MsgBox("Etes-vous sûr de vouloir l'enregistrer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                                If Ajouterfournisseur() = True Then
                                    MessageBox.Show("Enregistré avec succès!", "Enregistrement du fournisseur")
                                    loadgrid()
                                    EFFACE()
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
                Using oFOURNISSEUR As New CONTROLLEUR.CTRFournisseur(G_ConString)


                    If MsgBox("Etes-vous sûr de vouloir modifier?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                        If modifierFournisseur() Then
                            MessageBox.Show("Modifié avec succès!", "mofification du fournisseur")
                            loadgrid()
                            EFFACE()
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        EFFACE()
        verou()
    End Sub
    Sub rechercher()
        Dim nbe, paramE As Integer
        paramE = odataset.Tables("FOURNISSEUR").Rows.Count
        For i As Integer = 0 To odataset.Tables("FOURNISSEUR").Rows.Count - 1
            If odataset.Tables("FOURNISSEUR").Rows(i).Item("Nom").ToString <> TBRECHF.Text Then
                nbe = i
            Else
                paramE = i
            End If

        Next
        If paramE <> odataset.Tables("FOURNISSEUR").Rows.Count Then
            Gridfournisseur.Rows(paramE).Selected = True

        Else
            liberer()
            MessageBox.Show("aucun element ne convient à ce critère!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        rechercher()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If TBNom.Text = "" Then
            MsgBox("Veuillez choisir le fournisseur à modifier")
        Else
            Try
                Using oFOURNISSEUR As New CONTROLLEUR.CTRFournisseur(G_ConString)


                    If MsgBox("Etes-vous sûr de vouloir Supprimmer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                        If oFOURNISSEUR.supfournisseur(TBNom.Text) = True Then
                            MessageBox.Show("Supprimé avec succès!", "Suppression du fournisseur")
                            loadgrid()
                            EFFACE()
                        Else
                            MessageBox.Show("Erreur de suppression !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If

                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try

            verou()

            EFFACE()
        End If
    End Sub

    Private Sub TBAdresse_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBAdresse.TextChanged

    End Sub
End Class
