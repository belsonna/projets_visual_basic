Public Class UCLivraisontec
    Private olivrert As CONTROLLEUR.CTRLivrerTEC
    Dim courant, i As Integer
    Dim com As String
    Dim odataset As DataSet
    Private Sub UCLivraisontec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadgrid()
    End Sub
    Sub loadgrid()

        initialiser()
        Using olivrert As New CONTROLLEUR.CTRLivrerTEC(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = olivrert.Listlivrert()
                Gridlivret.DataSource = Nothing
                Gridlivret.DataSource = odataset.Tables("LIVRERT")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub

    Private Sub Gridlivret_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Gridlivret.CellClick
        Pbimp.Enabled = True
    End Sub

    Private Sub Pbimp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pbimp.Click
        courant = Gridlivret.CurrentRow.Index
        i = courant
        com = Gridlivret.Item(1, i).Value.ToString
        numero = com
        LIVTEC.ShowDialog()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        liberer()
        rechercher()
    End Sub
    Private Sub liberer()
        For i As Integer = 0 To odataset.Tables("LIVRERT").Rows.Count - 1
            Gridlivret.Rows(i).Selected = False

        Next
    End Sub
    Sub rechercher()
        Dim nbe, paramE As Integer
        paramE = odataset.Tables("LIVRERT").Rows.Count
        For i As Integer = 0 To odataset.Tables("LIVRERT").Rows.Count - 1
            If odataset.Tables("LIVRERT").Rows(i).Item("Po").ToString <> tbrech.Text Then
                nbe = i
            Else
                paramE = i
            End If

        Next
        If paramE <> odataset.Tables("LIVRERT").Rows.Count Then
            Gridlivret.Rows(paramE).Selected = True

        Else
            liberer()
            MessageBox.Show("aucun element ne convient à ce critère!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

   
End Class
