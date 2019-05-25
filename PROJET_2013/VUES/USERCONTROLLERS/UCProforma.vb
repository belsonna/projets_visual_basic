Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class UCProforma
    Private oprof As CONTROLLEUR.CTRproforma
    Private oprojet As CONTROLLEUR.CTRProjet
    Private ocot As CONTROLLEUR.CTRCotation
    Private ofour As CONTROLLEUR.CTRFournisseur
    Private otyp As CONTROLLEUR.CTRTypeproduit
    Private ocommande As CONTROLLEUR.CTRCommande
    Private oproduit As CONTROLLEUR.CTRProduit

    Private odataset As DataSet
    Dim nom As String
    Dim courant, param As Integer
    Private Sub UCProforma_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadcot()
        loadfour()
        loadgrid()
        loadtyp()
        loadproj()
        verou()

    End Sub
    Sub efface()
        tbnum.Text = ""
        Tbmont.Text = ""
    End Sub
    Sub verou()
        Tbmont.Enabled = False
        tbnum.Enabled = False
        cbcot.Enabled = False
        Cbfour.Enabled = False
        Cbproj.Enabled = False
        cbtyp.Enabled = False
    End Sub
    Sub COPIE()
        Dim i As Integer
        courant = gridproforma.CurrentRow.Index
        i = courant
        tbnum.Text = gridproforma(0, i).Value.ToString()
        cbcot.Text = gridproforma(1, i).Value.ToString()
        Cbproj.Text = gridproforma(2, i).Value.ToString()
        Cbfour.Text = gridproforma(3, i).Value.ToString()
        cbtyp.Text = gridproforma(4, i).Value.ToString()
        Tbmont.Text = gridproforma(5, i).Value.ToString()
    End Sub
    Sub deverou()
        Tbmont.Enabled = True
        cbcot.Enabled = True
        Cbfour.Enabled = True
        Cbproj.Enabled = True
        cbtyp.Enabled = True
    End Sub
    Sub loaproformer()
        initialiser()
        Using oproduit As New CONTROLLEUR.CTRProduit(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = oproduit.Listproduitn(cbtyp.Text)
                PROFORMER.gridproformer.DataSource = Nothing
                PROFORMER.gridproformer.DataSource = odataset.Tables("PRODUIT")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using

    End Sub
    Sub loadgrid()
        initialiser()
        Using oprof As New CONTROLLEUR.CTRproforma(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = oprof.Listproforma()
                gridproforma.DataSource = Nothing
                gridproforma.DataSource = odataset.Tables("PROFORMA")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub loadgriduti()
        initialiser()
        Using oprof As New CONTROLLEUR.CTRproforma(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = oprof.Listproformauti()
                gridproforma.DataSource = Nothing
                gridproforma.DataSource = odataset.Tables("PROFORMA")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub loadgridNU()
        initialiser()
        Using oprof As New CONTROLLEUR.CTRproforma(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = oprof.Listproformalib()
                gridproforma.DataSource = Nothing
                gridproforma.DataSource = odataset.Tables("PROFORMA")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub loadcot()
        initialiser()
        Using ocot As New CONTROLLEUR.CTRCotation(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = ocot.Liscotation()
                cbcot.DataSource = Nothing
                cbcot.DataSource = odataset.Tables("COTATION")
                cbcot.DisplayMember = "Numcot"
                cbcot.ValueMember = "Numcot"
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub loadproj()
        initialiser()
        Using oprojet As New CONTROLLEUR.CTRProjet(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = oprojet.Listprojet()
                Cbproj.DataSource = Nothing
                Cbproj.DataSource = odataset.Tables("PROJET")
                Cbproj.DisplayMember = "Numero"
                Cbproj.ValueMember = "Numero"
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub loadfour()
        initialiser()
        Using ofour As New CONTROLLEUR.CTRFournisseur(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = ofour.Listfournisseur()
                Cbfour.DataSource = Nothing
                Cbfour.DataSource = odataset.Tables("FOURNISSEUR")
                Cbfour.DisplayMember = "Nom"
                Cbfour.ValueMember = "Nom"
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub loadtyp()
        initialiser()
        Using otyp As New CONTROLLEUR.CTRTypeproduit(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = otyp.ListTYPproduitN()
                cbtyp.DataSource = Nothing
                cbtyp.DataSource = odataset.Tables("TYPEPRODUIT")
                cbtyp.DisplayMember = "Code"
                cbtyp.ValueMember = "Code"
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Gbproforma.Text = "Nouvelle Proforma"
        deverou()
        efface()
        prochain()

    End Sub
    Sub prochain()
        Dim nb As Integer
        Try
            Using oprof As New CONTROLLEUR.CTRproforma(G_ConString)

                nb = oprof.prochain
                nb = nb + 1
                tbnum.Text = "PROF" & nb & Date.Now.Year

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
   
    Function Ajouterproforma() As Boolean
       
        Using oprof As New CONTROLLEUR.CTRproforma(G_ConString)
            'Get a new Project DataSet
            odataset = oprof.Nvproforma()
            'Initialize a datarow object from the Project DataSet
                
                Dim oDataRow As Data.DataRow = _
                      odataset.Tables("PROFORMA").NewRow
                'Set the values in the DataRow
                oDataRow.Item("Numero") = Trim(tbnum.Text)
                oDataRow.Item("cotation") = Trim(cbcot.Text)
                oDataRow.Item("projet") = Trim(Cbproj.Text)
                oDataRow.Item("Fournisseur") = Trim(Cbfour.Text)
                oDataRow.Item("type") = Trim(cbtyp.Text)
                oDataRow.Item("montant") = Trim(Tbmont.Text)
                'Add the DataRow to the DataSet
                odataset.Tables("PROFORMA").Rows.Add(oDataRow)
                'Add the DataRow to the DataSet
                'Add the Project
                If Not oprof.Ajouterproforma(odataset) Then
                    Throw New Exception("Echec d'enregistrement")
                Else
                    Ajouterproforma = True
                End If
        End Using
    End Function
    Function Ajoutercommande() As Boolean
        Using ocommande As New CONTROLLEUR.CTRCommande(G_ConString)
            'Get a new Project DataSet
            odataset = ocommande.Nvcommande()
            Dim nb As Integer
            Dim prochainecommande As String

            nb = ocommande.prochain
            nb = nb + 1
            prochainecommande = "COMTEC" & nb & Date.Now.Year

            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("COMMANDE").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Numero") = Trim(prochainecommande)
            oDataRow.Item("proforma") = Trim(tbnum.Text)
            oDataRow.Item("Objet") = "A renseigner plus tard"

            'Add the DataRow to the DataSet
            odataset.Tables("COMMANDE").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not ocommande.Ajoutercommande(odataset) Then
                Throw New Exception("Echec d'enregistrement")
            Else
                Ajoutercommande = True
            End If
        End Using
    End Function
    Function modifierPROFORMA() As Boolean
        Using oprof As New CONTROLLEUR.CTRproforma(G_ConString)
            'Get a new Project DataSet
            odataset = oprof.Nvproforma()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("PROFORMA").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Numero") = Trim(tbnum.Text)
            oDataRow.Item("cotation") = Trim(cbcot.Text)
            oDataRow.Item("projet") = Trim(Cbproj.Text)
            oDataRow.Item("Fournisseur") = Trim(Cbfour.Text)
            oDataRow.Item("type") = Trim(cbtyp.Text)
            oDataRow.Item("montant") = Trim(Tbmont.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("PROFORMA").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not oprof.Majproforma(odataset) Then
                Throw New Exception("Echec de modification")
            Else
                modifierPROFORMA = True
            End If
        End Using
    End Function
    Function nombrevalide(ByVal nom As String) As Boolean
        If IsNumeric(nom) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function verifier() As Boolean
        If Not nombrevalide(Tbmont.Text.Trim) Then
            MessageBox.Show("la quantitée Ajoutée doit etre un nombre")
            Tbmont.Text = ""
            verifier = False
            Exit Function
        End If
        verifier = True
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If verifier() Then
            enregistrer()
        End If

    End Sub
    Sub enregistrer()
        If Gbproforma.Text = "Nouvelle Proforma" Then
            If (tbnum.Text = "" Or Tbmont.Text = "" Or cbcot.Text = "" Or Cbfour.Text = "" Or Cbproj.Text = "" Or cbtyp.Text = "") Then
                MessageBox.Show("Tous les champs sont obligatoires", "Erreur Saisie")
            Else
                Try
                    Using oprof As New CONTROLLEUR.CTRproforma(G_ConString)

                            If MsgBox("Etes-vous sûr de vouloir l'enregistrer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                            If Ajouterproforma() = True Then
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
        ElseIf Gbproforma.Text = "Modification d'une Proforma" Then
            Try
                Using oprof As New CONTROLLEUR.CTRproforma(G_ConString)


                    If MsgBox("Etes-vous sûr de vouloir modifier?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                        If modifierPROFORMA() Then
                            MessageBox.Show("Modifié avec succès!", "mofification de la proforma")
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

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Gbproforma.Text = "Modification d'une Proforma"
        deverou()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        efface()
        verou()

    End Sub

    Private Sub gridproforma_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridproforma.CellClick
        COPIE()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbcom.Click
        enregistrercom()
    End Sub
    Sub enregistrercom()
        Try
            Using ocommande As New CONTROLLEUR.CTRCommande(G_ConString)

                If MsgBox("Etes-vous sûr de vouloir l'enregistrer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                    If Ajoutercommande() = True Then
                        MessageBox.Show("Enregistré avec succès!", "Enregistrement d'une Commande")
                        utiliseprof()
                        efface()
                    Else
                        MessageBox.Show("Erreur d'enregistrement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        loadgridNU()
    End Sub
    Sub utiliseprof()
        Try
            Using oprof As New CONTROLLEUR.CTRproforma(G_ConString)

                If oprof.utilise(tbnum.Text) Then
                    MsgBox("Votre traitement a été pris en compte")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If tbnum.Text = "" Then
            MsgBox("veuillez choisir la proforma")
        Else
            PROFORMER.LBFOUR.Text = Cbfour.Text

            PROFORMER.lbnumprof.Text = tbnum.Text
            PROFORMER.LBTYP.Text = cbtyp.Text
            loaproformer()
            PROFORMER.ShowDialog()
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        loadgrid()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        If Cbrech.Text = "Utilisé" Then
            loadgriduti()
        ElseIf Cbrech.Text = "Non Utilisé" Then
            loadgridNU()
            Pbcom.Enabled = True
        End If
    End Sub

End Class
