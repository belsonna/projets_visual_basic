Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class UCAutres

    Private oPRODUIT As CONTROLLEUR.CTRProduit
    Private oTYPEPRODUIT As CONTROLLEUR.CTRTypeproduit
    Private odataset As DataSet
    Dim nom As String
    Dim courantP, courantT, param, pivot As Integer
    Private Sub UCAutres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadgrid()
        LOADCOMBOBOX()
        effaceP()
        effaceT()
        verouP()
        verouT()
    End Sub
    Function nomvalide(ByVal nom As String) As Boolean

        Dim rg As New Regex("^([\w]+)$")
        Return rg.IsMatch(nom)
    End Function
    Function verifierp() As Boolean
        If Not nomvalide(Tbpro.Text.Trim) Or Not nomvalide(Cbtypepro.Text.Trim) Then
            MessageBox.Show("caractere alpha numerique recommandé")
            verifierp = False
            Exit Function
        End If
        verifierp = True
    End Function
    Function verifiert() As Boolean
        If Not nomvalide(TBcode.Text.Trim) Or Not nomvalide(TBinti.Text.Trim) Then
            MessageBox.Show("caractere alpha numerique recommandé")
            verifiert = False
            Exit Function
        End If
        verifiert = True
    End Function
    Sub loadgrid()
        initialiser()
        Using oPRODUIT As New CONTROLLEUR.CTRProduit(G_ConString)
            Try
                odataset = oPRODUIT.Listproduit()
                GridProduit.DataSource = Nothing
                GridProduit.DataSource = odataset.Tables("PRODUIT")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
        Using oTYPEPRODUIT As New CONTROLLEUR.CTRTypeproduit(G_ConString)
            Try
                odataset = oTYPEPRODUIT.ListTYPproduit()
                GridType.DataSource = Nothing
                GridType.DataSource = odataset.Tables("TYPEPRODUIT")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub LOADCOMBOBOX()
        Using oTYPEPRODUIT As New CONTROLLEUR.CTRTypeproduit(G_ConString)
            Try
                odataset = oTYPEPRODUIT.ListTYPproduitN()
                Cbtypepro.DataSource = Nothing
                Cbtypepro.DataSource = odataset.Tables("TYPEPRODUIT")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub

    Private Sub Cbtypepro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbtypepro.SelectedIndexChanged

    End Sub
    Sub effaceP()
        Tbpro.Text = ""
        Cbtypepro.Text = ""
    End Sub
    Sub verouP()
        gbpro.Enabled = False
        Tbpro.Enabled = False
        Cbtypepro.Enabled = False
    End Sub
    Sub deverouP()
        gbpro.Enabled = True
        Tbpro.Enabled = True
        Cbtypepro.Enabled = True

    End Sub
    Sub effaceT()
        TBcode.Text = ""
        TBinti.Text = ""
    End Sub
    Sub verouT()
        Gbtype.Enabled = False
        TBcode.Enabled = False
        TBinti.Enabled = False
    End Sub
    Sub deverouT()
        Gbtype.Enabled = True
        TBcode.Enabled = True
        TBinti.Enabled = True

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        effaceT()
        deverouT()
        Gbtype.Text = "Nouveau Type Produit"
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        deverouP()
        gbpro.Text = "Nouveau Produit"
        effaceP()
        pivot = 1
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        deverouP()
        Tbpro.Enabled = False
        gbpro.Text = "Modification d'un Produit"
        pivot = 2
    End Sub
    Private Sub libererP()
        For i As Integer = 0 To GridProduit.RowCount - 1
            GridProduit.Rows(i).Selected = False

        Next
    End Sub
    Private Sub libererT()
        For i As Integer = 0 To odataset.Tables("TYPEPRODUIT").Rows.Count - 1
            GridType.Rows(i).Selected = False

        Next
    End Sub
    Sub rechercherP()
        Dim nb, para As Integer
        para = GridProduit.RowCount
        For i As Integer = 0 To GridProduit.RowCount - 1
            If GridProduit(0, i).Value.ToString() <> Tbrechpro.Text Then
                nb = i
            Else
                para = i
            End If

        Next
        If para <> GridProduit.RowCount Then
            GridProduit.Rows(para).Selected = True

        Else
            libererP()
            MessageBox.Show("aucun element ne convient à ce critère!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Sub rechercherT()
        Dim nbe, param As Integer
        param = odataset.Tables("TYPEPRODUIT").Rows.Count
        For i As Integer = 0 To odataset.Tables("TYPEPRODUIT").Rows.Count - 1
            If odataset.Tables("TYPEPRODUIT").Rows(i).Item("Code").ToString <> Tbrechtyp.Text Then
                nbe = i
            Else
                param = i
            End If

        Next
        If param <> odataset.Tables("TYPEPRODUIT").Rows.Count Then
            GridType.Rows(param).Selected = True

        Else
            libererT()
            MessageBox.Show("aucun element ne convient à ce critère!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        libererT()
        rechercherT()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        libererP()
        rechercherP()
    End Sub
    Public Sub copieP()
        Dim i As Integer
        courantP = GridProduit.CurrentRow.Index
        i = courantP
        Tbpro.Text = GridProduit(0, i).Value.ToString()
        Cbtypepro.Text = GridProduit(1, i).Value.ToString()


    End Sub
    Public Sub copieT()
        Dim i As Integer
        courantT = GridType.CurrentRow.Index
        i = courantT
        TBcode.Text = GridType(0, i).Value.ToString()
        TBinti.Text = GridType(1, i).Value.ToString()


    End Sub

    Private Sub GridType_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridType.CellClick
        copieT()
    End Sub

    Private Sub GridProduit_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridProduit.CellClick
        copieP()
    End Sub

    Private Sub Btenrgty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btenrgty.Click
        enregtype()
    End Sub
    Sub enregtype()
        If (TBcode.Text = "" Or TBinti.Text = "") Then
            MessageBox.Show("Tous les champs sont obligatoires", "Erreur Saisie")
        Else
            Try
                If verifiert() Then
                    Using oTYPEPRODUIT As New CONTROLLEUR.CTRTypeproduit(G_ConString)
                        If oTYPEPRODUIT.exite(TBcode.Text) Then
                            MessageBox.Show("Type déja Enregistré", "Enregistrement impossible")
                        Else

                            If MsgBox("Etes-vous sûr de vouloir l'enregistrer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                                If Ajoutertype() = True Then
                                    MessageBox.Show("Enregistré avec succès!", "Enregistrement de l'utilisateur")
                                    loadgrid()
                                    effaceT()
                                Else
                                    MessageBox.Show("Erreur d'enregistrement !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End If
                        End If
                    End Using
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
        End If
        verouT()
        effaceT()
    End Sub
    Function Ajoutertype() As Boolean
        Using oTYPEPRODUIT As New CONTROLLEUR.CTRTypeproduit(G_ConString)
            'Get a new Project DataSet
            odataset = oTYPEPRODUIT.NvtypPRODUIT()
            MsgBox("bon")
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("TYPEPRODUIT").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Code") = Trim(TBcode.Text)
            oDataRow.Item("Intitule") = Trim(TBinti.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("TYPEPRODUIT").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not oTYPEPRODUIT.Ajoutertype(odataset) Then
                Throw New Exception("Echec d'enregistrement")
            Else
                Ajoutertype = True
            End If
        End Using
    End Function
    Function Ajouterproduit() As Boolean
        Using oPRODUIT As New CONTROLLEUR.CTRProduit(G_ConString)
            'Get a new Project DataSet
            odataset = oPRODUIT.NvPRODUIT()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("PRODUIT").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Nom") = Trim(Tbpro.Text)
            oDataRow.Item("Type") = Trim(Cbtypepro.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("PRODUIT").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not oPRODUIT.Ajouterproduit(odataset) Then
                Throw New Exception("Echec d'enregistrement")
            Else
                Ajouterproduit = True
            End If
        End Using
    End Function
    Function modifierproduit() As Boolean
        Using oPRODUIT As New CONTROLLEUR.CTRProduit(G_ConString)
            'Get a new Project DataSet
            odataset = oPRODUIT.NvPRODUIT()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("PRODUIT").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Nom") = Trim(Tbpro.Text)
            oDataRow.Item("Type") = Trim(Cbtypepro.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("PRODUIT").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not oPRODUIT.Majproduit(odataset) Then
                Throw New Exception("Echec d'enregistrement")
            Else
                modifierproduit = True
            End If
        End Using
    End Function
    Sub enregistrerp()
        If verifierp() Then
            If pivot = 1 Then
                If (Tbpro.Text = "" Or Cbtypepro.Text = "") Then
                    MessageBox.Show("Tous les champs sont obligatoires", "Erreur Saisie")
                Else
                    Try

                        Using oPRODUIT As New CONTROLLEUR.CTRProduit(G_ConString)

                            If oPRODUIT.exite(Tbpro.Text) Then
                                MessageBox.Show("Produit déja Enregistré", "Enregistrement impossible")
                            Else

                                If MsgBox("Etes-vous sûr de vouloir l'enregistrer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                                    If Ajouterproduit() = True Then
                                        MessageBox.Show("Enregistré avec succès!", "Enregistrement de l'utilisateur")
                                        loadgrid()
                                        effaceP()
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
        ElseIf pivot = 2 Then
            Try
                Using oclient As New CONTROLLEUR.CTRClient(G_ConString)


                    If MsgBox("Etes-vous sûr de vouloir modifier?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                        If modifierproduit() Then
                            MessageBox.Show("Modifié avec succès!", "mofification du client")
                            loadgrid()
                            effaceP()
                        Else
                            MessageBox.Show("Erreur de modification !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If

                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
        End If

        verouP()

            effaceP()
        End If
    End Sub

    Private Sub Btenregpro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btenregpro.Click
        enregistrerp()
    End Sub

    Private Sub Btanutyp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btanutyp.Click
        effaceT()
        verouT()
    End Sub

    Private Sub Btanupro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btanupro.Click
        effaceP()
        verouP()
    End Sub
   
End Class
