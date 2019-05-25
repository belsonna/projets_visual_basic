Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.IO
Public Class LIVRAISONTEC
    Private odataset As DataSet
    Private olivrerf As CONTROLLEUR.CTRLivrerf
    Private Sub LIVRAISONTEC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Sub prochain()
        Dim nb As Integer
        Try
            Using olivrerf As New CONTROLLEUR.CTRLivrerf(G_ConString)

                nb = olivrerf.prochain
                LBNUMLIV.Text = nb + 1


            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Public Sub remplit()
        Try
            Using olivrerf As New CONTROLLEUR.CTRLivrerf(G_ConString)
                Dim ch As Boolean
                Dim n As Integer = DataGridView1.Rows.Count
                Dim p As Integer = 0

                'Set the values in the DataRow
                If n > 0 Then

                    For i As Integer = 0 To n - 1
                        prochain()
                        odataset = Nothing
                        odataset = olivrerf.Nvlivrerf()
                        Dim oDataRow As Data.DataRow = _
                        odataset.Tables("LIVRERF").NewRow
                        ch = DataGridView1(0, i).Value

                        If ch = True Then

                            oDataRow.Item("nbrecom") = DataGridView1(4, i).Value.ToString
                            oDataRow.Item("nbreliv") = DataGridView1(1, i).Value.ToString
                            oDataRow.Item("produit") = DataGridView1(2, i).Value.ToString
                            oDataRow.Item("NUM") = Trim(LBNUMLIV.Text)
                            oDataRow.Item("NUMCOM") = Trim(LBCOM.Text)
                            oDataRow.Item("date") = Date.Now
                            odataset.Tables("LIVRERF").Rows.Add(oDataRow)


                            If Not olivrerf.Ajouterlivrerf(odataset) Then
                                Exit For
                            End If
                        End If

                    Next
                Else
                    MsgBox("echec d'enregistrement des items")
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        remplit()
    End Sub
End Class