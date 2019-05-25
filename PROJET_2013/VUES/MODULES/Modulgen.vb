Module Modulgen
    Public G_ConString As String
    Public G_VarString As String
    Public numero As String
    Public Function IsInvalidF(ByVal ctrl As Control, ByVal ErProv As ErrorProvider, ByVal ErMsg As String) As Boolean
        'voir si le control a un message d'erreur
        If Trim(ctrl.Text).Length = 0 Then
            MessageBox.Show(ErMsg, "Requis!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Pas de message d'erreur
            ctrl.Focus()
            Return False
        ElseIf ErProv.GetError(ctrl).Length = 0 Then
            Return True
        Else
            'Il y a une erreur. Afficher le message
            MessageBox.Show(ErProv.GetError(ctrl), "Error")
            'Rendre le focus au control
            ctrl.Focus()
            Return False
        End If
    End Function

    Sub initialiser()

        G_ConString = My.Settings.BUYINGHOUSEConnectionString
    End Sub
End Module
