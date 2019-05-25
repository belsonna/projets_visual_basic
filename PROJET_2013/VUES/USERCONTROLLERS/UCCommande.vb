Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.IO
Public Class UCCommande
    Private odataset As DataSet
    Private oCOMMANDE As CONTROLLEUR.CTRCommande
    Private OFACF As CONTROLLEUR.CTRFACTURERF
    Private OPROFORMA As CONTROLLEUR.CTRproforma
    Private Olivrer As CONTROLLEUR.CTRLivrerf
    Dim courant As Integer
   
    Private Sub UCCommande_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadprof()
        loadgrid()
        verou()
    End Sub
    Sub loadprof()
        initialiser()
        Using oPROFORMA As New CONTROLLEUR.CTRproforma(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = oPROFORMA.Listproformalib
                CBprof.DataSource = Nothing
                CBprof.DataSource = odataset.Tables("PROFORMA")
                CBprof.DisplayMember = "Numero"
                CBprof.ValueMember = "Numero"
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub loadgrid()
        initialiser()
        Using oCOMMANDE As New CONTROLLEUR.CTRCommande(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = oCOMMANDE.Liscmmande()
                gridcommande.DataSource = Nothing
                gridcommande.DataSource = odataset.Tables("COMMANDE")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub loadgridlivraison(ByVal com As String)
        initialiser()
        Using Olivrer As New CONTROLLEUR.CTRLivrerf(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = Olivrer.ListlivrerT(com)
                LIVRAISONTEC.DataGridView1.DataSource = Nothing
                LIVRAISONTEC.DataGridView1.DataSource = odataset.Tables("LIVRAISON")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Using oCOMMANDE As New CONTROLLEUR.CTRCommande(G_ConString)
                    
                If MsgBox("Etes-vous sûr de vouloir Modifier?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                    If modifierCommande() = True Then
                        MessageBox.Show("Modifié avec succès!", "Modification  d'une  Commande")
                        loadgrid()
                        efface()
                    Else
                        MessageBox.Show("Erreur de Modification !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Gbcommande.Text = "Modifcation d'une Commande"
        deverou()

    End Sub
    Sub verou()
        tbobjet.Enabled = False
        CBprof.Enabled = False
        Tbnum.Enabled = False

    End Sub
    Sub deverou()
        CBprof.Enabled = True
        Tbnum.Enabled = True
        tbobjet.Enabled = True
    End Sub
    Sub efface()
        Tbnum.Text = ""
        tbobjet.Text = ""
    End Sub
    Sub copie()
        courant = gridcommande.CurrentRow.Index
        Tbnum.Text = odataset.Tables("COMMANDE").Rows(courant).Item("Numero").ToString
        tbobjet.Text = odataset.Tables("COMMANDE").Rows(courant).Item("Objet").ToString
        
    End Sub
    Sub rechercher()
        Dim nbe, param As Integer
        param = odataset.Tables("COMMANDE").Rows.Count
        For i As Integer = 0 To odataset.Tables("COMMANDE").Rows.Count - 1
            If odataset.Tables("COMMANDE").Rows(i).Item("proforma").ToString <> TBRECH.Text Then
                nbe = i
            Else
                param = i
            End If

        Next
        If param <> odataset.Tables("COMMANDE").Rows.Count Then
            gridcommande.Rows(param).Selected = True

        Else
            liberer()
            MessageBox.Show("aucun element ne convient à ce critère!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        efface()
        verou()
    End Sub

    Private Sub gridcommande_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridcommande.CellClick
        copie()
    End Sub
    Private Sub liberer()
        For i As Integer = 0 To odataset.Tables("COMMANDE").Rows.Count - 1
            gridcommande.Rows(i).Selected = False

        Next
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        rechercher()
    End Sub
    Function modifierCommande() As Boolean
        Using oCOMMANDE As New CONTROLLEUR.CTRCommande(G_ConString)
            'Get a new Project DataSet
            odataset = oCOMMANDE.Nvcommande()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("COMMANDE").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Numero") = Trim(Tbnum.Text)
            oDataRow.Item("proforma") = Trim(CBprof.Text)
            oDataRow.Item("Objet") = Trim(tbobjet.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("COMMANDE").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not oCOMMANDE.Majcommande(odataset) Then
                Throw New Exception("Echec de modification")
            Else
                modifierCommande = True
            End If
        End Using
    End Function


    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If Tbnum.Text = "" Then
            MsgBox("veuillez choirir la commande")
        Else
            LIVRAISONTEC.LBCOM.Text = Tbnum.Text
            LIVRAISONTEC.LBPROF.Text = CBprof.Text
            nomf(CBprof.Text)
            loadgridlivraison(Tbnum.Text)
            LIVRAISONTEC.ShowDialog()
        End If
    End Sub
    Private Sub nomf(ByVal prof As String)
        Using OPROFORMA As New CONTROLLEUR.CTRproforma(G_ConString)
            Dim nom As String
            Try
                odataset = OPROFORMA.nomfour(prof)
                nom = odataset.Tables("PROFORMA").Rows(0).Item("Fournisseur")
                LIVRAISONTEC.LBFOUR.Text = nom
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Tbnum.Text = "" Then
            MsgBox("veuillez chOisir une commande")
            efface()
            verou()
        Else
            FACTUREF.tbcom.Text = Tbnum.Text
            FACTUREF.tbcom.Enabled = False
            FACTUREF.ShowDialog()
        End If
    End Sub
   
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If Tbnum.Text = "" Then
            MsgBox("veuillez chOisir une commande")
            efface()
            verou()
        Else
            numero = Tbnum.Text
            TECCOMMANDE.ShowDialog()
        End If
    End Sub

    Private Sub Gbcommande_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gbcommande.Enter

    End Sub
End Class
