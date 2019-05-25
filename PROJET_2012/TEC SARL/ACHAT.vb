Public Class ACHAT

    Private Sub ENREGISTRERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ENREGISTRERToolStripMenuItem.Click
        FOURNISSEUR.ShowDialog()
    End Sub

    Private Sub MODIFIERSUPPRIMERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MODIFIERSUPPRIMERToolStripMenuItem.Click
        MISAJOURfournisseur.ShowDialog()
    End Sub

    Private Sub ENREGISTRERToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ENREGISTRERToolStripMenuItem1.Click
        PROFORMA.ShowDialog()
    End Sub

    Private Sub MODIFIERSUPPRIMERToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MODIFIERSUPPRIMERToolStripMenuItem1.Click
        MISE_A_JOUR_PROFORMA.ShowDialog()
    End Sub

    Private Sub ENREGISTRERToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ENREGISTRERToolStripMenuItem2.Click
        COMMANDE_TEC.ShowDialog()
    End Sub



    Private Sub IMPRIMERToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMPRIMERToolStripMenuItem2.Click

    End Sub

    Private Sub IMPRIMERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMPRIMERToolStripMenuItem.Click
        LISTE_FOURNISSEURS_ACTIF.ShowDialog()
    End Sub

    Private Sub ARCHIVESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARCHIVESToolStripMenuItem.Click
        ARCHIVES_FOURNISSEUR.ShowDialog()
    End Sub

    Private Sub ACHAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ENREGISTRERToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ENREGISTRERToolStripMenuItem4.Click
        PRODUIT.ShowDialog()
    End Sub

    Private Sub MISEAJOURToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub IMPRIMERToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMPRIMERToolStripMenuItem4.Click
        LISTE_DES_PRODUITS.ShowDialog()
    End Sub

    Private Sub ENREGISTRERToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ENREGISTRERToolStripMenuItem3.Click
        TYPE_PRODUIT.ShowDialog()

    End Sub

    Private Sub IMPRIMERToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMPRIMERToolStripMenuItem3.Click
        LISTE_TYPE_PRODUIT.ShowDialog()
    End Sub

    Private Sub IMPRIMERToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMPRIMERToolStripMenuItem1.Click
        PROFORMA_UTILISE.ShowDialog()
    End Sub

    Private Sub ARCHIVESToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARCHIVESToolStripMenuItem1.Click
        ARCHIVE_PRO_FORMA.ShowDialog()
    End Sub

    Private Sub LIVRAISONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LIVRAISONToolStripMenuItem.Click

    End Sub

    Private Sub ENREGISTRERToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ENREGISTRERToolStripMenuItem6.Click
        LIVRAISON_TEC.ShowDialog()
    End Sub

    Private Sub IMPRIMERToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMPRIMERToolStripMenuItem5.Click
        LIVRER.ShowDialog()
    End Sub

    Private Sub ENREGISTRERToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ENREGISTRERToolStripMenuItem5.Click
        LIVRAISON_FOURNISSEUR.ShowDialog()
    End Sub
End Class