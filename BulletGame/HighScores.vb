Public Class HighScores
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub HighScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HighScoresDataSet.HighScores' table. You can move, or remove it, as needed.
        Me.HighScoresTableAdapter.Fill(Me.HighScoresDataSet.HighScores)

    End Sub


End Class