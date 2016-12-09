Public Class GameSettings

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Settings.chrPlayer = CChar(lblChar.Text)

        Select Case True
            Case radEasy.Checked
                Settings.strDifficulty = "Easy"
            Case radMed.Checked
                Settings.strDifficulty = "Medium"
            Case radHard.Checked
                Settings.strDifficulty = "Hard"
        End Select

        Settings.intGameSpeed = tkbSpeed.Value

        Select Case True
            Case rad15.Checked
                Settings.intRefresh = 15
            Case rad30.Checked
                Settings.intRefresh = 30
            Case rad60.Checked
                Settings.intRefresh = 60
        End Select

        If chkAudio.Checked Then
            Settings.blnAudio = 1
        Else
            Settings.blnAudio = 0
        End If

        If chkGrid.Checked Then
            Settings.chrGrid = "·"c
        Else
            Settings.chrGrid = " "c
        End If

        Game.ShowDialog()

    End Sub

    '
    'Aesthetic things
    '
    Private Sub cboCharacter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCharacter.SelectedIndexChanged

        lblChar.Text = cboCharacter.Text.Substring(0, 1)

    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click

        If Me.Height = 330 Then

            Me.Height = 500
            btnOptions.Text = "^ Less Options ^"

        Else

            Me.Height = 330
            btnOptions.Text = "v More Options v"

        End If

    End Sub

    Private Sub tkbSpeed_Scroll(sender As Object, e As EventArgs) Handles tkbSpeed.Scroll

        Dim dblSpeed As Double = CDbl(tkbSpeed.Value)

        't/s stands for ticks per second, referring to how fast the game will drop rows
        'will probably need testing for the range
        lblSpeed.Text = dblSpeed & " t/s"

    End Sub

    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click

        HighScores.Show()

    End Sub

    Private Sub GameSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboCharacter.SelectedIndex = 0

    End Sub

End Class
