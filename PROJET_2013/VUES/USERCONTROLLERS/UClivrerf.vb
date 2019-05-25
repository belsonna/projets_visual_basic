Public Class UClivrerf
    Private olivrerf As CONTROLLEUR.CTRLivrerf
    Dim courant, i As Integer
    Dim liv, res As Integer
    Dim odataset As DataSet
    Private Sub UClivrerf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadgrid()
        verou()
    End Sub
    Sub loadgrid()

        initialiser()
        Using olivrerf As New CONTROLLEUR.CTRLivrerf(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = olivrerf.Listlivrerf()
                Gridlivrerf.DataSource = Nothing
                Gridlivrerf.DataSource = odataset.Tables("LIVRERF")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub verou()
        Tbcom.Enabled = False
        tbcomm.Enabled = False
        tbliv.Enabled = False
        Tbnum.Enabled = False
        tbprod.Enabled = False
        Tbajout.Enabled = False
    End Sub
    Sub deverou()
        Tbajout.Enabled = True
    End Sub
    Sub efface()
        Tbcom.Text = ""
        tbcomm.Text = ""
        tbliv.Text = ""
        Tbnum.Text = ""
        tbprod.Text = ""
        Tbajout.Text = ""
        Gblivf.Text = ""
    End Sub
    Sub copie()
        courant = Gridlivrerf.CurrentRow.Index
        i = courant
        Tbnum.Text = Gridlivrerf(0, i).Value.ToString
        Tbcom.Text = Gridlivrerf(1, i).Value.ToString
        tbprod.Text = Gridlivrerf(2, i).Value.ToString
        tbcomm.Text = Gridlivrerf(3, i).Value.ToString
        tbliv.Text = Gridlivrerf(4, i).Value.ToString
    End Sub
    Function modifierLIVF() As Boolean
        Using olivrerf As New CONTROLLEUR.CTRLivrerf(G_ConString)
            'Get a new Project DataSet
            odataset = olivrerf.Nvlivrerf()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("LIVRERF").NewRow
            'Set the values in the DataRow
            oDataRow.Item("NUM") = Trim(Tbnum.Text)
            oDataRow.Item("NUMCOM") = Trim(Tbcom.Text)
            oDataRow.Item("produit") = Trim(tbprod.Text)
            oDataRow.Item("nbrecom") = Trim(tbcomm.Text)
            oDataRow.Item("nbreliv") = liv
            oDataRow.Item("date") = Date.Now
            'Add the DataRow to the DataSet
            odataset.Tables("LIVRERF").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not olivrerf.Majlivrerf(odataset) Then
                Throw New Exception("Echec de modification")
            Else
                modifierLIVF = True
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
        If Not nombrevalide(Tbajout.Text.Trim) Then
            MessageBox.Show("la quantitée Ajoutée doit etre un nombre")
            Tbajout.Text = ""
            verifier = False
            Exit Function
        End If
        verifier = True
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If verifier() Then
            Try

                Using olivrerf As New CONTROLLEUR.CTRLivrerf(G_ConString)
                    If MsgBox("Etes-vous sûr de vouloir modifier?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                        liv = CInt(tbliv.Text) + CInt(Tbajout.Text)
                        If liv > CInt(tbcomm.Text) Then
                            MessageBox.Show("la Quantitée livrée ne peut pas être superieure à la quantitée Commandée!", "mofification de la livraison")
                        Else
                            res = CInt(tbcomm.Text) - liv
                            If modifierLIVF() Then
                                MessageBox.Show("Modifié avec succès!", "mofification de la livraison")
                                loadgrid()
                                efface()
                            Else
                                MessageBox.Show("Erreur de modification !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If
                    End If

                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try

            verou()
            efface()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        verou()
        efface()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If Tbnum.Text = "" Then
            MsgBox("veuillez choisir la livraison")
        Else
            Gblivf.Text = "Modification de la livraison"
            deverou()
        End If
    End Sub

    Private Sub Gridlivrerf_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Gridlivrerf.CellClick
        copie()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        initialiser()
        Using olivrerf As New CONTROLLEUR.CTRLivrerf(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = olivrerf.Listlivrercom(tbrech.Text)
                If odataset.Tables("LIVRERF").Rows.Count < 0 Then
                    tbrech.Text = ""
                    MsgBox("Cette Commande N'a pas encore été livrée")
                    loadgrid()
                Else
                    Gridlivrerf.DataSource = Nothing
                    Gridlivrerf.DataSource = odataset.Tables("LIVRERF")
                End If
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        loadgrid()
        tbrech.Text = ""
    End Sub
End Class
