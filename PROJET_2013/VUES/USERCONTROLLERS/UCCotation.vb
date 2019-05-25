Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class UCCotation
    Private ocotation As CONTROLLEUR.CTRCotation
    Private oprof As CONTROLLEUR.CTRproforma
    Private oprojet As CONTROLLEUR.CTRProjet
    Private odataset As DataSet
    Dim nom As String
    Dim courant, param As Integer
    Dim tax, ttc, mkp, total As Integer
    Private Sub Btadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btadd.Click
        Dim mont As Integer
        Dim nom As String

        If Cbtaxe.Text = "" Then
            MsgBox("choisir le montant de la taxe")
        Else
            Try
                Using ocotation As New CONTROLLEUR.CTRCotation(G_ConString)
                    mont = ocotation.MONTANTCOTATION(Tbnum.Text)


                    If mont = 0 Then
                        MsgBox("cette cotation na pas encore de proforma")
                    Else
                        If Cbtaxe.Text = "0.165" Then
                            Using oprojet As New CONTROLLEUR.CTRProjet(G_ConString)
                                nom = oprojet.nomclient(Tbproj.Text)

                            End Using
                            If nom = "COTCO" Then
                                tax = CInt(mont * 0.165)
                                ttc = CInt(mont + tax)
                                mkp = CInt(0.1 * ttc)
                                total = CInt(ttc + mkp)
                                Tbmont.Text = total
                            Else
                                tax = CInt(mont * 0.165)
                                ttc = CInt(mont + tax)
                                Tbmont.Text = ttc
                            End If
                        Else
                            Using oprojet As New CONTROLLEUR.CTRProjet(G_ConString)
                                nom = oprojet.nomclient(Tbproj.Text)

                            End Using
                            If nom = "COTCO" Then
                                tax = CInt(mont * 0.1925)
                                ttc = CInt(mont + tax)
                                mkp = CInt(0.1 * ttc)
                                total = CInt(ttc + mkp)
                                Tbmont.Text = total
                            Else
                                tax = CInt(mont * 0.1925)
                                ttc = CInt(mont + tax)
                                Tbmont.Text = ttc
                            End If
                        End If

                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        efface()
        Gbcotation.Text = "Nouvelle Cotation"
        deverou()
        prochain()


    End Sub
    Sub prochain()
        Dim nb As Integer
        Try
            Using ocotation As New CONTROLLEUR.CTRCotation(G_ConString)

                'nb = ocotation.prochain
                nb = gridcotation.RowCount
                'MsgBox(nb)
                nb = nb + 1
                Tbnum.Text = "COT" & nb & Date.Now.Year

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Sub efface()
        Tbnum.Text = ""
        Tbmont.Text = 0
        Tbproj.Text = ""
        tblettre.Text = ""
        tblettre.Text = ""
        tbobjet.Text = ""

    End Sub
    Sub verou()
        Tbnum.Enabled = False
        Tbmont.Enabled = False
        tbobjet.Enabled = False
        tblettre.Enabled = False
        Btadd.Enabled = False
    End Sub
    Sub deverou()
        tbobjet.Enabled = True
        tblettre.Enabled = True
        Btadd.Enabled = True
    End Sub

    Private Sub UCCotation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        verou()
        loadgrid()
    End Sub
    Sub loadgrid()

        initialiser()
        Using ocotation As New CONTROLLEUR.CTRCotation(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = ocotation.Liscotation()
                gridcotation.DataSource = Nothing
                gridcotation.DataSource = odataset.Tables("COTATION")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Gbcotation.Text = "Modification d'une Cotation"
        deverou()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            enregistrer()

    End Sub
    Function nomvalide(ByVal nom As String) As Boolean

        Dim rg As New Regex("^([\w]+)$")
        Return rg.IsMatch(nom)
    End Function
    Function verifier() As Boolean
        If Not nomvalide(tbobjet.Text.Trim) Then
            MessageBox.Show("caracteres alpha numerique recommandés pour le Nom du client")
            verifier = False
            Exit Function
        End If
        verifier = True
    End Function
    Sub enregistrer()
        If Gbcotation.Text = "Nouvelle Cotation" Then
            If (Tbnum.Text = "" Or Tbmont.Text = "" Or tbobjet.Text = "" Or tblettre.Text = "") Then
                MessageBox.Show("Tous les champs sont obligatoires", "Erreur Saisie")
            Else
                Try
                    Using ocotation As New CONTROLLEUR.CTRCotation(G_ConString)

                        If MsgBox("Etes-vous sûr de vouloir l'enregistrer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                            If Ajoutecotation() = True Then
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
        ElseIf Gbcotation.Text = "Modification d'une Cotation" Then
            Try
                Using ocotation As New CONTROLLEUR.CTRCotation(G_ConString)


                    If MsgBox("Etes-vous sûr de vouloir modifier?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                        If modifiercotation() Then
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
    Function Ajoutecotation() As Boolean
        Using ocotation As New CONTROLLEUR.CTRCotation(G_ConString)
            'Get a new Project DataSet
            odataset = ocotation.Nvcotation()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("COTATION").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Numcot") = Trim(Tbnum.Text)
            oDataRow.Item("ObjetCOT") = Trim(tbobjet.Text)
            oDataRow.Item("taxe") = Trim(Cbtaxe.Text)
            oDataRow.Item("Montant") = Trim(Tbmont.Text)
            oDataRow.Item("lettre") = Trim(tblettre.Text)
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
    Function modifiercotation() As Boolean
        Using ocotation As New CONTROLLEUR.CTRCotation(G_ConString)
            'Get a new Project DataSet
            odataset = ocotation.Nvcotation()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("COTATION").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Numcot") = Trim(Tbnum.Text)
            oDataRow.Item("ObjetCOT") = Trim(tbobjet.Text)
            oDataRow.Item("taxe") = Trim(Cbtaxe.Text)
            oDataRow.Item("Montant") = Trim(Tbmont.Text)
            oDataRow.Item("lettre") = Trim(tblettre.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("COTATION").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not ocotation.Majcotation(odataset) Then
                Throw New Exception("Echec de modification")
            Else
                modifiercotation = True
            End If
        End Using
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        efface()
        verou()
    End Sub
    Sub COPIE()
        courant = gridcotation.CurrentRow.Index
        Tbnum.Text = odataset.Tables("COTATION").Rows(courant).Item("Numcot").ToString
        Tbproj.Text = odataset.Tables("COTATION").Rows(courant).Item("projet").ToString
        Cbtaxe.Text = odataset.Tables("COTATION").Rows(courant).Item("taxe").ToString
        tbobjet.Text = odataset.Tables("COTATION").Rows(courant).Item("ObjetCOT").ToString
        Tbmont.Text = odataset.Tables("COTATION").Rows(courant).Item("Montant").ToString
        tblettre.Text = odataset.Tables("COTATION").Rows(courant).Item("lettre").ToString

    End Sub

    Private Sub gridcotation_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridcotation.CellClick
        COPIE()
    End Sub


    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If Tbnum.Text = "" Then
            MsgBox("choisir une commande")
        Else

            Using oprojet As New CONTROLLEUR.CTRProjet(G_ConString)
                nom = oprojet.nomclient(Tbproj.Text)

            End Using
            If nom = "COTCO" Then
                numero = Tbnum.Text
                If Cbtaxe.Text = "0.1925" Then
                    COTATION.ShowDialog()
                Else
                    COTCO2.ShowDialog()
                End If

            Else
                numero = Tbnum.Text
                PROFAC.ShowDialog()
            End If
            End If
    End Sub
End Class
