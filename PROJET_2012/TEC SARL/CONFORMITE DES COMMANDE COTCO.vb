Public Class CONFORMITE_DES_COMMANDE_COTCO

    Private Sub ENREGISTRERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ENREGISTRERToolStripMenuItem.Click
        CONFIRMER.ShowDialog()
    End Sub



    Private Sub CONFORMITE_DES_COMMANDE_COTCO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IMPRIMERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMPRIMERToolStripMenuItem.Click
        CONFIRMEE.ShowDialog()
    End Sub

    Private Sub ENATTENTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ENATTENTEToolStripMenuItem.Click
        ATTENTE.ShowDialog()
    End Sub

    Private Sub COMMANDECOTCOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMMANDECOTCOToolStripMenuItem.Click

    End Sub
End Class