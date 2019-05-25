Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.IO
Public Class PROFORMER
    Private odataset As DataSet
    Private oproformer As CONTROLLEUR.CTRProformer

    
    Private Sub PROFORMER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
   
    Sub prochain()
        Dim nb As Integer
        Try
            Using oproformer As New CONTROLLEUR.CTRProformer(G_ConString)

                nb = oproformer.prochain
                LBNUM.Text = nb + 1


            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub remplit()
        Try
            Using oproformer As New CONTROLLEUR.CTRProformer(G_ConString)
                Dim ch As Boolean
                Dim n As Integer = gridproformer.Rows.Count
                Dim p As Integer = 0

                'Set the values in the DataRow
                If n > 0 Then

                    For i As Integer = 0 To n - 1
                        prochain()
                        odataset = Nothing
                        odataset = oproformer.Nvproformer()
                        Dim oDataRow As Data.DataRow = _
                        odataset.Tables("PROFORMER").NewRow
                        ch = gridproformer(0, i).Value

                        If ch = True Then

                            oDataRow.Item("qte") = gridproformer(1, i).Value.ToString
                            oDataRow.Item("PU") = gridproformer(2, i).Value.ToString
                            oDataRow.Item("produit") = gridproformer(3, i).Value.ToString
                            oDataRow.Item("Numero") = Trim(LBNUM.Text)
                            oDataRow.Item("proforma") = Trim(lbnumprof.Text)
                            odataset.Tables("PROFORMER").Rows.Add(oDataRow)

                            If Not oproformer.Ajouterproformer(odataset) Then
                                Exit For
                            End If
                        End If

                    Next
                    MsgBox("enregistrements effectués avec succès")
                Else
                    MsgBox("echec d'enregistrement des items")
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        remplit()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class