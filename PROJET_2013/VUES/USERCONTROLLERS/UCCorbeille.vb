Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class UCCorbeille
    Dim courant, param As Integer
    Dim odataset As DataSet
    Private oclient As CONTROLLEUR.CTRClient
    Private ofour As CONTROLLEUR.CTRFournisseur
    Private oemploye As CONTROLLEUR.CTREmploye

    Private Sub gridcorbeille_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridcorbeille.CellClick
        btrestaure.Enabled = True
    End Sub

    Private Sub UCCorbeille_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub loadclient()
        initialiser()
        Using oclient As New CONTROLLEUR.CTRClient(G_ConString)
            Try
                odataset = oclient.Lisclientc()
                gridcorbeille.DataSource = Nothing
                gridcorbeille.DataSource = odataset.Tables("CLIENT")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub loademploye()
        initialiser()
        Using oemploye As New CONTROLLEUR.CTREmploye(G_ConString)
            Try
                odataset = oemploye.Listemployec()
                gridcorbeille.DataSource = Nothing
                gridcorbeille.DataSource = odataset.Tables("EMPLOYE")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub loadfournisseur()
        initialiser()
        Using ofour As New CONTROLLEUR.CTRFournisseur(G_ConString)
            Try
                odataset = ofour.Listfournisseurc()
                gridcorbeille.DataSource = Nothing
                gridcorbeille.DataSource = odataset.Tables("FOURNISSEUR")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Cbrech.Text = "CLIENT" Then
            loadclient()
        Else
            If Cbrech.Text = "FOURNISSEUR" Then
                loadfournisseur()
            Else
                If Cbrech.Text = "EMPLOYE" Then
                    loademploye()
                Else
                    MsgBox("Choisissez un élément de la liste")
                End If
            End If
        End If
    End Sub

    Private Sub btrestaure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btrestaure.Click
        Dim nom As String
        courant = gridcorbeille.CurrentRow.Index
        If courant < 0 Then
            MsgBox("Aucun element n'a été selectionner")
        Else
            btrestaure.Enabled = True
            If Cbrech.Text = "CLIENT" Then
                Using oclient As New CONTROLLEUR.CTRClient(G_ConString)
                    nom = gridcorbeille(0, courant).Value.ToString()
                    If oclient.RESTAURE(nom) Then
                        loadclient()
                        btrestaure.Enabled = False

                    End If
                End Using
            Else
                If Cbrech.Text = "FOURNISSEUR" Then
                    Using ofour As New CONTROLLEUR.CTRFournisseur(G_ConString)
                        nom = gridcorbeille(0, courant).Value.ToString()
                        If ofour.resfournisseur(nom) Then
                            loadfournisseur()
                            btrestaure.Enabled = False

                        End If
                    End Using
                Else
                    If Cbrech.Text = "EMPLOYE" Then
                        Using oemploye As New CONTROLLEUR.CTREmploye(G_ConString)
                            nom = gridcorbeille(1, courant).Value.ToString()
                            If oemploye.resemploye(nom) Then
                                loademploye()
                                btrestaure.Enabled = False

                            End If
                        End Using

                    Else
                        MsgBox("Choisissez un element de la liste")
                    End If
                End If


            End If
        End If
    End Sub
End Class
