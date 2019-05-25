Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class UCPo
    Private opo As CONTROLLEUR.CTRPO
    Private ocot As CONTROLLEUR.CTRCotation
    Private ocli As CONTROLLEUR.CTRClient
    Private ofact As CONTROLLEUR.CTRFacturerTEC
    Private oliv As CONTROLLEUR.CTRLivrerTEC
    Private odataset As DataSet
    Dim proc As Integer
    Sub verou()
        Tbnum.Enabled = False
        tbobjet.Enabled = False
        tbobjet.Enabled = False
        Cbclient.Enabled = False
        Cbcot.Enabled = False
    End Sub
    Sub deverou()
        Tbnum.Enabled = True
        tbobjet.Enabled = True
        tbobjet.Enabled = True
        Cbclient.Enabled = True
        Cbcot.Enabled = True
    End Sub
    Sub loadboxclient()
        initialiser()
        Using ocli As New CONTROLLEUR.CTRClient(G_ConString)
            Try
                odataset = ocli.LisclientN()
                Cbclient.DataSource = Nothing
                Cbclient.DataSource = odataset.Tables("CLIENT")
                Cbclient.DisplayMember = "Nom"
                Cbclient.ValueMember = "Nom"
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub loadboxcot()
        initialiser()
        Using ocot As New CONTROLLEUR.CTRCotation(G_ConString)
            Try
                odataset = ocot.LiscotationN()
                Cbcot.DataSource = Nothing
                Cbcot.DataSource = odataset.Tables("COTATION")
                Cbcot.DisplayMember = "Numcot"
                Cbcot.ValueMember = "Numcot"
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub efface()
        Tbmont.Text = ""
        Tbnum.Text = ""
        tbobjet.Text = ""
        Cbclient.Text = ""
        Cbcot.Text = ""
    End Sub
    Sub loadgrid()

        initialiser()
        Using oPo As New CONTROLLEUR.CTRPO(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = oPo.LisPO()
                gridPO.DataSource = Nothing
                gridPO.DataSource = odataset.Tables("PO")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub prochaine()
        Using ofact As New CONTROLLEUR.CTRFacturerTEC(G_ConString)
            Try
                Dim n As Integer
                n = ofact.prochain
                FACTURETEC.Tbfac.Text = "FAC" & n + 1 & Date.Now.Year
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Function nombrevalide(ByVal nom As String) As Boolean
        If IsNumeric(nom) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function verifier() As Boolean
        If Not nombrevalide(Tbmont.Text.Trim) Then
            MessageBox.Show("le montant du PO doit etre un nombre")
            Tbmont.Text = ""
            verifier = False
            Exit Function
        End If
        verifier = True
    End Function
    Private Sub UCPo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadgrid()
        loadboxclient()
        loadboxcot()
        efface()
        verou()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        efface()
        GbPO.Text = "Nouveau PO"
        deverou()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        deverou()
        GbPO.Text = "Modification d'un PO"
    End Sub
    Sub enregistrer()
        If GbPO.Text = "Nouveau PO" Then
            If (Tbnum.Text = "" Or Tbmont.Text = "" Or tbobjet.Text = "" Or Tbmont.Text = "" Or Cbclient.Text = "" Or Cbcot.Text = "") Then
                MessageBox.Show("Tous les champs sont obligatoires", "Erreur Saisie")
            Else
                Try
                    Using opo As New CONTROLLEUR.CTRPO(G_ConString)

                        If MsgBox("Etes-vous sûr de vouloir l'enregistrer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                            If Ajoutepo() = True Then
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
        ElseIf GbPO.Text = "Modification d'un PO" Then
            Try
                Using opo As New CONTROLLEUR.CTRPO(G_ConString)


                    If MsgBox("Etes-vous sûr de vouloir modifier?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                        If modifierPO() Then
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
        GbPO.Text = ""
        efface()
    End Sub
    Sub COPIE()
        Dim courantp, i As Integer
        courantp = gridPO.CurrentRow.Index
        i = courantp
        Tbnum.Text = gridPO(0, i).Value.ToString()
        Cbclient.Text = gridPO(4, i).Value.ToString()
        Cbcot.Text = gridPO(1, i).Value.ToString()
        tbobjet.Text = gridPO(3, i).Value.ToString()
        Tbmont.Text = gridPO(5, i).Value.ToString()

    End Sub
    Function Ajoutepo() As Boolean
        Using opo As New CONTROLLEUR.CTRPO(G_ConString)
            'Get a new Project DataSet
            odataset = opo.NvPO()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("PO").NewRow
            'Set the values in the DataRow
            oDataRow.Item("NumPo") = Trim(Tbnum.Text)
            oDataRow.Item("client") = Trim(Cbclient.Text)
            oDataRow.Item("Cotation") = Trim(Cbcot.Text)
            oDataRow.Item("DatePO") = Date.Now
            oDataRow.Item("ObjetPO") = Trim(tbobjet.Text)
            oDataRow.Item("montant") = Trim(Tbmont.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("PO").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not opo.AjouterPO(odataset) Then
                Throw New Exception("Echec d'enregistrement")
            Else
                Ajoutepo = True
            End If
        End Using
    End Function
    Function Ajoutelivt() As Boolean
        Using oliv As New CONTROLLEUR.CTRLivrerTEC(G_ConString)
            'Get a new Project DataSet
            odataset = oliv.NvlivrerT()
            prochain()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("LIVRERT").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Numliv") = "BLTEC" & proc + 1 & Date.Now.Year
            oDataRow.Item("Po") = Trim(Tbnum.Text)
            oDataRow.Item("Date") = Date.Now
            'Add the DataRow to the DataSet
            odataset.Tables("LIVRERT").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not oliv.Ajouterlivrert(odataset) Then
                Throw New Exception("Echec d'enregistrement")
            Else
                Ajoutelivt = True
            End If
        End Using
    End Function
    Function modifierPO() As Boolean
        Using opo As New CONTROLLEUR.CTRPO(G_ConString)
            'Get a new Project DataSet
            odataset = opo.NvPO()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("PO").NewRow
            'Set the values in the DataRow
            oDataRow.Item("NumPo") = Trim(Tbnum.Text)
            oDataRow.Item("client") = Trim(Cbclient.Text)
            oDataRow.Item("Cotation") = Trim(Cbcot.Text)
            oDataRow.Item("DatePO") = Date.Now
            oDataRow.Item("ObjetPO") = Trim(tbobjet.Text)
            oDataRow.Item("montant") = Trim(Tbmont.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("PO").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not opo.MajPO(odataset) Then
                Throw New Exception("Echec de modification")
            Else
                modifierPO = True
            End If
        End Using
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If verifier() Then
            enregistrer()
        End If
    End Sub

    Private Sub GbPO_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GbPO.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        efface()
        verou()
        GbPO.Text = ""
    End Sub

    Private Sub gridPO_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridPO.CellClick
        COPIE()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        FACTURETEC.tbcom.Text = Tbnum.Text
        FACTURETEC.Tbmont.Text = Tbmont.Text
        prochaine()
        FACTURETEC.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Try
            Using oliv As New CONTROLLEUR.CTRLivrerTEC(G_ConString)


                If Ajoutelivt() Then
                    MessageBox.Show("Enregistré avec succès!", "Enregistrement du Bordereau de livraison")
                Else
                    MessageBox.Show("Echec d'Enregistrement!", "Enregistrement du Bordereau de livraison")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Sub prochain()
        Try
            Using oliv As New CONTROLLEUR.CTRLivrerTEC(G_ConString)

                proc = oliv.prochain
               
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Tbmont_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tbmont.TextChanged

    End Sub
End Class
