Public Class UCFacturetec
    Private ofacturt As CONTROLLEUR.CTRFacturerTEC
    Private opo As CONTROLLEUR.CTRPO
    Private cot As CONTROLLEUR.CTRCotation
    Dim courant, i As Integer
    Dim com, cli ,taxe As String
    Dim odataset As DataSet
    Private Sub Gridfact_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Gridfact.CellClick
        Pbimp.Enabled = True
    End Sub

    Private Sub Pbimp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbimp.Click
        Using opo As New CONTROLLEUR.CTRPO(G_ConString)
            courant = Gridfact.CurrentRow.Index
            i = courant
            com = Gridfact.Item(1, i).Value.ToString
            cli = opo.cotpo(com)
            Using cot As New CONTROLLEUR.CTRCotation(G_ConString)
                taxe = cot.cottaxe(cli)
                numero = com
                If cli = "COTCO" Then
                    If taxe = "0.1925" Then
                        FACCOTCO.ShowDialog()
                    Else
                        FACTURE2.ShowDialog()
                    End If

                Else
                    FACTURECLI.ShowDialog()
                End If
            End Using
        End Using

    End Sub

    Private Sub UCFacturetec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadgrid()
    End Sub
    Sub loadgrid()

        initialiser()
        Using ofacturt As New CONTROLLEUR.CTRFacturerTEC(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = ofacturt.Listfacturertec()
                Gridfact.DataSource = Nothing
                Gridfact.DataSource = odataset.Tables("FACTURERTEC")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Private Sub liberer()
        For i As Integer = 0 To odataset.Tables("FACTURERTEC").Rows.Count - 1
            Gridfact.Rows(i).Selected = False

        Next
    End Sub
    Sub rechercher()
        Dim nbe, paramE As Integer
        paramE = odataset.Tables("FACTURERTEC").Rows.Count
        For i As Integer = 0 To odataset.Tables("FACTURERTEC").Rows.Count - 1
            If odataset.Tables("FACTURERTEC").Rows(i).Item("Po").ToString <> tbrech.Text Then
                nbe = i
            Else
                paramE = i
            End If

        Next
        If paramE <> odataset.Tables("FACTURERTEC").Rows.Count Then
            Gridfact.Rows(paramE).Selected = True

        Else
            liberer()
            MessageBox.Show("aucun element ne convient à ce critère!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        liberer()
        rechercher()
    End Sub
End Class
