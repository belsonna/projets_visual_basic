Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class CONNEXION
    Private ocompte As CONTROLLEUR.CTRCompte
    Private odataset As DataSet
    Function connection() As Boolean

        Using ocompte As New CONTROLLEUR.CTRCompte(G_ConString)
            'Get a new Project DataSet
            odataset = ocompte.NvDcompte()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("COMPTE").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Proprietaire") = Trim(cbuser.Text)
            oDataRow.Item("password") = Trim(tbpass.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("COMPTE").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not ocompte.ConPossible(odataset) Then
                connection = False
            Else
                connection = True
            End If
        End Using
    End Function
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If tbpass.Text = "" Or cbuser.Text = "" Then
            MessageBox.Show("Veuillez entrer les parametres de connexion!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If connection() Then
                PRINCIPAL.TBNOM.Text = cbuser.Text
                'PRINCIPAL.Pbcompt.Image = Image.FromFile("..\..\PHOTOS\" & cbuser.Text & ".jpg")
                Me.Visible = False
                PRINCIPAL.Show()
                Me.Close()
            Else
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbpass.Text = ""
                cbuser.Text = ""
            End If
        End If
    End Sub

    Private Sub CONNEXION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        initialiser()
    End Sub
End Class