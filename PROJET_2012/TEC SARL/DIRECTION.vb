Public Class DIRECTION

    Private Sub LICENCIEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LICENCIEToolStripMenuItem.Click
        LISTE_DES_EMPLOYES.ShowDialog()
    End Sub

    Private Sub PARTENAIREToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PARTENAIREToolStripMenuItem.Click
        LISTE_CLIENT.ShowDialog()

    End Sub

    Private Sub PARTENAIREToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PARTENAIREToolStripMenuItem1.Click
        LISTE_FOURNISSEURS_ACTIF.ShowDialog()
    End Sub

    Private Sub CLIENTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CLIENTToolStripMenuItem.Click

    End Sub

    Private Sub ACTIFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACTIFToolStripMenuItem.Click
        ARCHIVES_PERSONNEL.ShowDialog()
    End Sub

    Private Sub ARCHIVESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARCHIVESToolStripMenuItem.Click
        ARCHIVE_CLIENT.ShowDialog()
    End Sub

    Private Sub ARCHIVEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ARCHIVEToolStripMenuItem.Click
        ARCHIVES_FOURNISSEUR.ShowDialog()
    End Sub
End Class