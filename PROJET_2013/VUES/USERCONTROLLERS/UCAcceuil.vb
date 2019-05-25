Public Class UCAcceuil


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btuti.Click
        Dim oUCAdh As New UCcompte
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "GESTION DES COMPTES"
    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim oUCAdh As New UCEmploye
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "GESTION DES EMPLOYES"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim oUCAdh As New UCclient
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "GESTION DES CLIENTS"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim oUCAdh As New UCFournisseur
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "GESTION DES FOURNISSEURS"
    End Sub


    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim oUCAdh As New UCAutres
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "GESTION DES PRODUITS"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim oUCAdh As New UCProforma
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "GESTION DES PROFORMA"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim oUCAdh As New UCCommande
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "GESTION DES COMMANDES TEC"
    End Sub

    Private Sub BTPROJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPROJ.Click
        Dim oUCAdh As New UCProjet
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "GESTION DES PROJETS"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim oUCAdh As New UCCotation
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "GESTION DES COTATIONS"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim oUCAdh As New UCPo
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "GESTION DES PO"
    End Sub


    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim oUCAdh As New UCCorbeille
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "CORBEILLE"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim oUCAdh As New UCLivraisontec
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "GESTION DES LIVRAISON TEC"
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Dim oUCAdh As New UCFacturetec
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "GESTION DE LA FACTURARTION TEC"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim oUCAdh As New UCITEMS
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "GESTION DES ITEMS"
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oUCAdh As New UClivrerf
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "GESTION DES LIVRAISONS FOURNISSEUR"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim oUCAdh As New UCFacturef
        PRINCIPAL.contenu.Controls.Clear()
        PRINCIPAL.contenu.Controls.Add(oUCAdh)
        PRINCIPAL.Lbmodule.Text = "GESTION DE LA FACTURATION DES FOURNISSEURS"
    End Sub

    Private Sub UCAcceuil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
