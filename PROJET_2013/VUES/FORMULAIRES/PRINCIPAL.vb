Public Class PRINCIPAL

  
    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        CONNEXION.Text = "CHANGER D'UTILISATEUR"
        Me.Visible = False
        CONNEXION.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim oUCAdh As New UCAcceuil
        contenu.Controls.Clear()
        contenu.Controls.Add(oUCAdh)
        Lbmodule.Text = "ACCEUIL"
    End Sub

    Private Sub PRINCIPAL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oUCAdh As New UCAcceuil
        contenu.Controls.Clear()
        contenu.Controls.Add(oUCAdh)
        Lbmodule.Text = "ACCEUIL"
    End Sub

  
    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TBNOM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBNOM.TextChanged

    End Sub
End Class