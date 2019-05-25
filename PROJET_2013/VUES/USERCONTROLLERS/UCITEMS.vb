Imports System.Text.RegularExpressions

Public Class UCITEMS
    Private oproformer As CONTROLLEUR.CTRProformer
    Dim courant, i As Integer
    Dim liv, res As Integer
    Dim odataset As DataSet
    Private Sub UCITEMS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        verou()
        loadgrid()
    End Sub
    Sub loadgrid()

        initialiser()
        Using oproformer As New CONTROLLEUR.CTRProformer(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = oproformer.Listproformer()
                GridPROFORMER.DataSource = Nothing
                GridPROFORMER.DataSource = odataset.Tables("PROFORMER")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
    Sub verou()
        Tbprof.Enabled = False
        tbpu.Enabled = False
        tbqtep.Enabled = False
        Tbnum.Enabled = False
        tbprod.Enabled = False
        Tbajout.Enabled = False
    End Sub
    Sub deverou()
        Tbajout.Enabled = True
    End Sub
    Sub efface()
        tbpu.Text = ""
        Tbprof.Text = ""
        tbqtep.Text = ""
        Tbnum.Text = ""
        tbprod.Text = ""
        Gblivf.Text = ""
        Tbajout.Text = ""
    End Sub
    Sub copie()
        courant = GridPROFORMER.CurrentRow.Index
        i = courant
        Tbnum.Text = GridPROFORMER(0, i).Value.ToString
        Tbprof.Text = GridPROFORMER(1, i).Value.ToString
        tbprod.Text = GridPROFORMER(2, i).Value.ToString
        tbpu.Text = GridPROFORMER(3, i).Value.ToString
        tbqtep.Text = GridPROFORMER(4, i).Value.ToString
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        loadgrid()
    End Sub

    Private Sub GridPROFORMER_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPROFORMER.CellClick
        copie()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If Tbnum.Text = "" Then
            MsgBox("Veuilez choisir l'item à modifier")
        Else
            Gblivf.Text = "Modification de la proforma"
            Tbajout.Enabled = True
        End If
    End Sub
    Function modifierprof() As Boolean
        Using oproformer As New CONTROLLEUR.CTRProformer(G_ConString)
            'Get a new Project DataSet
            odataset = oproformer.Nvproformer()
            'Initialize a datarow object from the Project DataSet
            Dim oDataRow As Data.DataRow = _
                  odataset.Tables("PROFORMER").NewRow
            'Set the values in the DataRow
            oDataRow.Item("Numero") = Trim(Tbnum.Text)
            oDataRow.Item("proforma") = Trim(Tbprof.Text)
            oDataRow.Item("produit") = Trim(tbprod.Text)
            oDataRow.Item("PU") = Trim(tbpu.Text)
            oDataRow.Item("qte") = CInt(tbqtep.Text) + CInt(Tbajout.Text)
            'Add the DataRow to the DataSet
            odataset.Tables("PROFORMER").Rows.Add(oDataRow)
            'Add the DataRow to the DataSet
            'Add the Project
            If Not oproformer.Majproformer(odataset) Then
                Throw New Exception("Echec de modification")
            Else
                modifierprof = True
            End If
        End Using
    End Function

    Function nomvalide(ByVal nom As String) As Boolean

        Dim rg As New Regex("^([\w]+)$")
        Return rg.IsMatch(nom)
    End Function
    Function nombrevalide(ByVal nom As String) As Boolean
        If IsNumeric(nom) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function verifier() As Boolean
        If Not nombrevalide(Tbajout.Text.Trim) Then
            MessageBox.Show("la quantitée Ajoutée doit etre un nombre")
            Tbajout.Text = ""
            verifier = False
            Exit Function
        End If
        verifier = True
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If verifier() Then
            Try

                Using oproformer As New CONTROLLEUR.CTRProformer(G_ConString)
                    If MsgBox("Etes-vous sûr de vouloir modifier?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then

                        If modifierprof() Then
                            MessageBox.Show("Modifié avec succès!", "mofification de la livraison")
                            loadgrid()
                            efface()
                        Else
                            MessageBox.Show("Erreur de modification !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If

                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
        verou()
            efface()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        verou()
        efface()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        initialiser()
        Using oproformer As New CONTROLLEUR.CTRProformer(G_ConString)
            Try
                'MsgBox(G_ConString)
                odataset = oproformer.Listproformerp(tbrech.Text)
                GridPROFORMER.DataSource = Nothing
                GridPROFORMER.DataSource = odataset.Tables("PROFORMER")
            Catch ExceptionErr As Exception
                MessageBox.Show(ExceptionErr.Message.ToString)
            End Try
        End Using
    End Sub
End Class
