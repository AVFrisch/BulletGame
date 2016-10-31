Public Class GameSettings

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Game.ShowDialog()

    End Sub

    '
    'Aesthetic things
    '
    Private Sub cboCharacter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCharacter.SelectedIndexChanged

        lblChar.Text = cboCharacter.Text.Substring(0, 1)

    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click

        If Me.Height = 300 Then

            Me.Height = 500
            btnOptions.Text = "^ Less Options ^"

        Else

            Me.Height = 300
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

End Class
