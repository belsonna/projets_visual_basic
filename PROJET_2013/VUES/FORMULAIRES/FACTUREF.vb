Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.IO
Public Class FACTUREF
    Private odataset As DataSet
    Private ofacf As CONTROLLEUR.CTRFACTURERF
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (tbcom.Text = "" Or Tbfac.Text = "") Then
            MsgBox("tous les champs sont obligatoires")
        Else
            Try
                Using ofacf As New CONTROLLEUR.CTRFACTURERF(G_ConString)

                    If MsgBox("Etes-vous sûr de vouloir Enregistrer?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
                        If ajouterf() = True Then
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
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Tbfac.Text = ""
        tbcom.Text = ""
        Tbmont.Text = ""
        Me.Close()
    End Sub
    Function ajouterf() As Boolean
        Using ofacf As New CONTROLLEUR.CTRFACTURERF(G_ConString)
            'Get a new Project DataSet
            odataset = ofacf.Nvfacturerf()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("FACTURERF").NewRow
            'Set the values in the DataRow
            oDataRow.Item("NumFac") = Trim(Tbfac.Text)
            oDataRow.Item("COM") = Trim(tbcom.Text)
            oDataRow.Item("montant") = Trim(Tbmont.Text)
            oDataRow.Item("Datecrea") = Date.Now
            'Add the DataRow to the DataSet
            odataset.Tables("FACTURERF").Rows.Add(oDataRow)

            'Add the DataRow to the DataSet
            'Add the Project
            If Not ofacf.Ajouterfacturer(odataset) Then
                Throw New Exception("Echec de modification")
            Else
                ajouterf = True
            End If
        End Using
    End Function
End Class