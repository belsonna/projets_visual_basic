<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DIRECTION
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
        Me.PERSONNELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LICENCIEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACTIFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PARTENAIREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ARCHIVESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FOURNISSEURToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PARTENAIREToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ARCHIVEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BILANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HEBDOMADAIREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MENSUELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PERSONNELToolStripMenuItem, Me.CLIENTToolStripMenuItem, Me.FOURNISSEURToolStripMenuItem, Me.BILANToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PERSONNELToolStripMenuItem
        '
        Me.PERSONNELToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PERSONNELToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LICENCIEToolStripMenuItem, Me.ACTIFToolStripMenuItem})
        Me.PERSONNELToolStripMenuItem.Name = "PERSONNELToolStripMenuItem"
        Me.PERSONNELToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.PERSONNELToolStripMenuItem.Text = "PERSONNEL"
        '
        'LICENCIEToolStripMenuItem
        '
        Me.LICENCIEToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LICENCIEToolStripMenuItem.Name = "LICENCIEToolStripMenuItem"
        Me.LICENCIEToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LICENCIEToolStripMenuItem.Text = "ACTIF"
        '
        'ACTIFToolStripMenuItem
        '
        Me.ACTIFToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ACTIFToolStripMenuItem.Name = "ACTIFToolStripMenuItem"
        Me.ACTIFToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ACTIFToolStripMenuItem.Text = "ARCHIVE"
        '
        'CLIENTToolStripMenuItem
        '
        Me.CLIENTToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CLIENTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PARTENAIREToolStripMenuItem, Me.ARCHIVESToolStripMenuItem})
        Me.CLIENTToolStripMenuItem.Name = "CLIENTToolStripMenuItem"
        Me.CLIENTToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.CLIENTToolStripMenuItem.Text = "CLIENT"
        '
        'PARTENAIREToolStripMenuItem
        '
        Me.PARTENAIREToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PARTENAIREToolStripMenuItem.Name = "PARTENAIREToolStripMenuItem"
        Me.PARTENAIREToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PARTENAIREToolStripMenuItem.Text = "PARTENAIRE"
        '
        'ARCHIVESToolStripMenuItem
        '
        Me.ARCHIVESToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ARCHIVESToolStripMenuItem.Name = "ARCHIVESToolStripMenuItem"
        Me.ARCHIVESToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ARCHIVESToolStripMenuItem.Text = "ARCHIVES"
        '
        'FOURNISSEURToolStripMenuItem
        '
        Me.FOURNISSEURToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.FOURNISSEURToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PARTENAIREToolStripMenuItem1, Me.ARCHIVEToolStripMenuItem})
        Me.FOURNISSEURToolStripMenuItem.Name = "FOURNISSEURToolStripMenuItem"
        Me.FOURNISSEURToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.FOURNISSEURToolStripMenuItem.Text = "FOURNISSEUR"
        '
        'PARTENAIREToolStripMenuItem1
        '
        Me.PARTENAIREToolStripMenuItem1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PARTENAIREToolStripMenuItem1.Name = "PARTENAIREToolStripMenuItem1"
        Me.PARTENAIREToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PARTENAIREToolStripMenuItem1.Text = "PARTENAIRE"
        '
        'ARCHIVEToolStripMenuItem
        '
        Me.ARCHIVEToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ARCHIVEToolStripMenuItem.Name = "ARCHIVEToolStripMenuItem"
        Me.ARCHIVEToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ARCHIVEToolStripMenuItem.Text = "ARCHIVE"
        '
        'BILANToolStripMenuItem
        '
        Me.BILANToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BILANToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HEBDOMADAIREToolStripMenuItem, Me.MENSUELToolStripMenuItem})
        Me.BILANToolStripMenuItem.Name = "BILANToolStripMenuItem"
        Me.BILANToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.BILANToolStripMenuItem.Text = "BILAN "
        '
        'HEBDOMADAIREToolStripMenuItem
        '
        Me.HEBDOMADAIREToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.HEBDOMADAIREToolStripMenuItem.Name = "HEBDOMADAIREToolStripMenuItem"
        Me.HEBDOMADAIREToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.HEBDOMADAIREToolStripMenuItem.Text = "HEBDOMADAIRE"
        '
        'MENSUELToolStripMenuItem
        '
        Me.MENSUELToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MENSUELToolStripMenuItem.Name = "MENSUELToolStripMenuItem"
        Me.MENSUELToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.MENSUELToolStripMenuItem.Text = "MENSUEL"
        '
        'DIRECTION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TEC_SARL.My.Resources.Resources.Page_d_acceuil_Application
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 490)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "DIRECTION"
        Me.Text = "DIRECTION"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PERSONNELToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LICENCIEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ACTIFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLIENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PARTENAIREToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ARCHIVESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FOURNISSEURToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PARTENAIREToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ARCHIVEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BILANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HEBDOMADAIREToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MENSUELToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
