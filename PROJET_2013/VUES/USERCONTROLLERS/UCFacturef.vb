Public Class UCFacturef
    Private ofacturf As CONTROLLEUR.CTRFACTURERF

    Dim odataset As DataSet
    Private Sub UCFacturef_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadgrid()
    End Sub
    Sub loadgrid()
        initialiser()
        Using ofacturf As New CONTROLLEUR.CTRFACTURERF(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = ofacturf.Listfacturerf()
                Gridfactf.DataSource = Nothing
                Gridfactf.DataSource = odataset.Tables("FACTURERF")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Private Sub liberer()
        For i As Integer = 0 To odataset.Tables("FACTURERF").Rows.Count - 1
            Gridfactf.Rows(i).Selected = False

        Next
    End Sub
    Sub rechercher()
        Dim nbe, paramE As Integer
        paramE = odataset.Tables("FACTURERF").Rows.Count
        For i As Integer = 0 To odataset.Tables("FACTURERF").Rows.Count - 1
            If odataset.Tables("FACTURERF").Rows(i).Item("COM").ToString <> tbrech.Text Then
                nbe = i
            Else
                paramE = i
            End If

        Next
        If paramE <> odataset.Tables("FACTURERF").Rows.Count Then
            Gridfactf.Rows(paramE).Selected = True

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
