Public Class HighScores

    Dim selDate As DateTime
    Dim selName As String
    Dim selScore As Integer
    Dim selChar As String
    Dim selectedIndex As Integer
    Dim HSTable As New HighScoresDataSetTableAdapters.HighScoresTableAdapter


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Closes form
        Me.Close()

    End Sub

    Private Sub HighScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.HighScoresTableAdapter.Fill(Me.HighScoresDataSet.HighScores)

    End Sub

    'Deletes item from database and gridview
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click


        HighScoresDataSet.HighScores.Rows(selectedIndex).Delete()
        HSTable.Delete(selDate, selName, selScore, selChar)


    End Sub

    'stores selected data
    Private Sub dgvScores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvScores.CellContentClick

        selDate = dgvScores.Rows(e.RowIndex).Cells(0).Value
        selName = dgvScores.Rows(e.RowIndex).Cells(1).Value
        selScore = dgvScores.Rows(e.RowIndex).Cells(2).Value
        selChar = dgvScores.Rows(e.RowIndex).Cells(3).Value
        selectedIndex = e.RowIndex

    End Sub

End Class