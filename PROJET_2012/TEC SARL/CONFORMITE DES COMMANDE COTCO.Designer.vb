<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONFORMITE_DES_COMMANDE_COTCO
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CONFORMIEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENREGISTRERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IMPRIMERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMMANDECOTCOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENATTENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CONFORMIEToolStripMenuItem, Me.COMMANDECOTCOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(867, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CONFORMIEToolStripMenuItem
        '
        Me.CONFORMIEToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.CONFORMIEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENREGISTRERToolStripMenuItem, Me.IMPRIMERToolStripMenuItem})
        Me.CONFORMIEToolStripMenuItem.Name = "CONFORMIEToolStripMenuItem"
        Me.CONFORMIEToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.CONFORMIEToolStripMenuItem.Text = "CONFORMITE"
        '
        'ENREGISTRERToolStripMenuItem
        '
        Me.ENREGISTRERToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ENREGISTRERToolStripMenuItem.Name = "ENREGISTRERToolStripMenuItem"
        Me.ENREGISTRERToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ENREGISTRERToolStripMenuItem.Text = "ENREGISTRER"
        '
        'IMPRIMERToolStripMenuItem
        '
        Me.IMPRIMERToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.IMPRIMERToolStripMenuItem.Name = "IMPRIMERToolStripMenuItem"
        Me.IMPRIMERToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IMPRIMERToolStripMenuItem.Text = "IMPRIMER"
        '
        'COMMANDECOTCOToolStripMenuItem
        '
        Me.COMMANDECOTCOToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.COMMANDECOTCOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENATTENTEToolStripMenuItem})
        Me.COMMANDECOTCOToolStripMenuItem.Name = "COMMANDECOTCOToolStripMenuItem"
        Me.COMMANDECOTCOToolStripMenuItem.Size = New System.Drawing.Size(133, 20)
        Me.COMMANDECOTCOToolStripMenuItem.Text = "COMMANDE COTCO"
        '
        'ENATTENTEToolStripMenuItem
        '
        Me.ENATTENTEToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ENATTENTEToolStripMenuItem.Name = "ENATTENTEToolStripMenuItem"
        Me.ENATTENTEToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ENATTENTEToolStripMenuItem.Text = "EN ATTENTE"
        '
        'CONFORMITE_DES_COMMANDE_COTCO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.Image_acces_Conformité
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(867, 503)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CONFORMITE_DES_COMMANDE_COTCO"
        Me.Text = "CONFORMITE_DES_COMMANDE_COTCO"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CONFORMIEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ENREGISTRERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IMPRIMERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COMMANDECOTCOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ENATTENTEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
