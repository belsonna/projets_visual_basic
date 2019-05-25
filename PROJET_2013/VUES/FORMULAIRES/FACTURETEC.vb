Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FACTURETEC
    Private ofact As CONTROLLEUR.CTRFacturerTEC
    Private odataset As DataSet
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
        If (tbcom.Text = "" Or Tbfac.Text = "" Or TBLETTRE.Text = "") Then
            MsgBox("tous les champs sont obligatoires")
        Else
            If verifier() Then

                Try
                    Using ofact As New CONTROLLEUR.CTRFacturerTEC(G_ConString)

                        If MsgBox("Etes-vous sûr de vouloir Enregistrer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                            If ajoutert() = True Then
                                MessageBox.Show("Enregistré avec succès!", "Enregistrement d'une facture")
                                Me.Close()
                            Else
                                MessageBox.Show("Erreur de Modification !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End If

                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString)
                End Try
            End If
        End If
    End Sub
    Function ajoutert() As Boolean
        Using ofact As New CONTROLLEUR.CTRFacturerTEC(G_ConString)
            'Get a new Project DataSet
            odataset = ofact.Nvfacturertec()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("FACTURERTEC").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Num") = Trim(Tbfac.Text)
            oDataRow.Item("Po") = Trim(tbcom.Text)
            oDataRow.Item("montant") = Trim(Tbmont.Text)
            oDataRow.Item("lettre") = Trim(TBLETTRE.Text)
            oDataRow.Item("datefac") = Date.Now
            oDataRow.Item("banque") = Trim(Tbbank.Text)
            oDataRow.Item("compte") = Trim(tbcompte.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("FACTURERTEC").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not ofact.Ajouterfacturertec(odataset) Then
                Throw New Exception("Echec de modification")
            Else
                ajoutert = True
            End If
        End Using
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class