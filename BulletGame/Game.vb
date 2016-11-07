Public Class Game

    'General Variables
    Private Const BG As Char = "·"c
    Private blnStop As Boolean
    Private blnAudio As Boolean
    Private intRefresh As Integer
    Private rand As New Random

    'Board Arrays
    Dim playerRow As Piece() = LoadBlank()
    Dim row0 As Piece() = LoadBlank()
    Dim row1 As Piece() = LoadBlank()
    Dim row2 As Piece() = LoadBlank()
    Dim row3 As Piece() = LoadBlank()
    Dim row4 As Piece() = LoadBlank()
    Dim row5 As Piece() = LoadBlank()
    Dim row6 As Piece() = LoadBlank()
    Dim row7 As Piece() = LoadBlank()
    Dim row8 As Piece() = LoadBlank()
    Dim row9 As Piece() = LoadBlank()
    Dim row10 As Piece() = LoadBlank()
    Dim row11 As Piece() = LoadBlank()
    Dim row12 As Piece() = LoadBlank()
    Dim row13 As Piece() = LoadBlank()
    Dim row14 As Piece() = LoadBlank()
    Dim row15 As Piece() = LoadBlank()
    Dim row16 As Piece() = LoadBlank()
    Dim rowTop As Piece() = LoadBlank()

    'Player variables
    Private chrPlayer As Char = "X"c
    Private strPlayerLine As String
    Private intPlayerPos As Integer


    '''''''''''''''
    'Debug buttons
    'all debug buttons use comic sans
    '''''''''''''''
    Private Sub btnDDrop_Click(sender As Object, e As EventArgs) Handles btnDDrop.Click

        ''New Line Generation
        ''Saves current line in case elements already exist on the line
        'Dim strNextLine As String = lblTopRow.Text
        ''Converts line into array of characters
        'Dim chrNextLine() As Char = strNextLine.ToCharArray

        ''Randomly adds an obstacle and pickup to the array
        ''amount and details depend on difficulty selected

        'chrNextLine(rand.Next(16)) = "+"

        ''Resets next line to be rebuilt with new positions
        'strNextLine = ""
        ''Rebuilds next line with new positions
        'For i As Integer = 0 To (chrNextLine.Length - 1) Step 1
        '    strNextLine &= chrNextLine(i)
        'Next

        ''Updates next line with new String
        'lblTopRow.Text = strNextLine

        rowTop(rand.Next(16)) = New Obstacle

    End Sub

    '''''''''''''''
    'Background
    '''''''''''''''

    'Form Load
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case intRefresh
            Case 15
                timRefreshRate.Interval = 67
            Case 30
                timRefreshRate.Interval = 33
            Case 60
                timRefreshRate.Interval = 17
        End Select

        intPlayerPos = 8
        UpdatePlayer()

    End Sub

    'Controls timed drops
    Private Sub timDrop_Tick(sender As Object, e As EventArgs) Handles timDrop.Tick

        'Sends all row arrays down one and generates a new blank for the top
        'this doesn't actually solve any of the problems I had before yet
        playerRow = row0
        row0 = row1
        row1 = row2
        row2 = row3
        row3 = row4
        row4 = row5
        row5 = row6
        row6 = row7
        row7 = row8
        row8 = row9
        row9 = row10
        row10 = row11
        row11 = row12
        row12 = row13
        row13 = row14
        row14 = row15
        row15 = row16
        row16 = rowTop
        rowTop = LoadBlank()

    End Sub

    'Sets game refresh rate
    Private Sub timRefreshRate_Tick(sender As Object, e As EventArgs) Handles timRefreshRate.Tick

        UpdateBoard()

    End Sub

    '''''''''''''''
    'Buttons
    '''''''''''''''

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click

        'Moves the player index one to the left
        'unless the player is already at the furthest
        'left it can be
        If intPlayerPos > 0 Then
            intPlayerPos -= 1
            'Calls procedure to update player line
            UpdatePlayer()
        Else
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
        End If

    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click

        'Moves the player index one to the right
        'unless the player is already at the furthest
        'right it can be
        If intPlayerPos < (15) Then
            intPlayerPos += 1
            'Calls procedure to update player line
            UpdatePlayer()
        Else
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
        End If

    End Sub

    Private Sub btnShoot_Click(sender As Object, e As EventArgs) Handles btnShoot.Click
        Shoot()
    End Sub

    '''''''''''''''
    'Procedures
    '''''''''''''''

    Private Sub Drop()

        ''Drops everything down a line and adds a blank line to the top
        ''I'm pretty sure I can't simplify this further
        'lblPlayerRow.Text = lblRow0.Text
        'lblRow0.Text = lblRow1.Text
        'lblRow1.Text = lblRow2.Text
        'lblRow2.Text = lblRow3.Text
        'lblRow3.Text = lblRow4.Text
        'lblRow4.Text = lblRow5.Text
        'lblRow5.Text = lblRow6.Text
        'lblRow6.Text = lblRow7.Text
        'lblRow7.Text = lblRow8.Text
        'lblRow8.Text = lblRow9.Text
        'lblRow9.Text = lblRow10.Text
        'lblRow10.Text = lblRow11.Text
        'lblRow11.Text = lblRow12.Text
        'lblRow12.Text = lblRow13.Text
        'lblRow13.Text = lblRow14.Text
        'lblRow14.Text = lblRow15.Text
        'lblRow15.Text = lblRow16.Text
        'lblRow16.Text = lblTopRow.Text
        'lblTopRow.Text = BLANK_LINE

        ''Puts player back
        'UpdatePlayer()


    End Sub

    Private Sub Shoot()

        Dim strRow As String


        'Controls shots from the player
        lblRow0.Text = BulletTravel(lblRow0.Text)
        lblRow1.Text = BulletTravel(lblRow1.Text)
        lblRow2.Text = BulletTravel(lblRow2.Text)
        lblRow3.Text = BulletTravel(lblRow3.Text)
        lblRow4.Text = BulletTravel(lblRow4.Text)
        lblRow5.Text = BulletTravel(lblRow5.Text)



        'Puts player back
        UpdatePlayer()

    End Sub

    Public Function LoadBlank() As Piece()

        Dim blankRow(15) As Piece

        For i As Integer = 0 To 15 Step 1
            blankRow(i) = New Blank
        Next

        Return blankRow

    End Function

    Public Sub UpdateBoard()

        lblTopRow.Text = LoadRow(rowTop)
        lblRow0.Text = LoadRow(row0)
        lblRow1.Text = LoadRow(row1)
        lblRow2.Text = LoadRow(row2)
        lblRow3.Text = LoadRow(row3)
        lblRow4.Text = LoadRow(row4)
        lblRow5.Text = LoadRow(row5)
        lblRow6.Text = LoadRow(row6)
        lblRow7.Text = LoadRow(row7)
        lblRow8.Text = LoadRow(row8)
        lblRow9.Text = LoadRow(row9)
        lblRow10.Text = LoadRow(row10)
        lblRow11.Text = LoadRow(row11)
        lblRow12.Text = LoadRow(row12)
        lblRow13.Text = LoadRow(row13)
        lblRow14.Text = LoadRow(row14)
        lblRow15.Text = LoadRow(row15)
        lblRow16.Text = LoadRow(row16)
        lblPlayerRow.Text = LoadRow(playerRow)

    End Sub

    Public Function LoadRow(ByVal pRow As Piece()) As String

        Dim i As Integer = 0
        Dim strBuildRow As String = ""

        For Each piece In pRow
            strBuildRow += pRow(i).Sym
            i += 1
        Next

        Return strBuildRow

    End Function

    Private Sub UpdatePlayer()

        ''Prevents player from moving if game has stopped
        'If blnStop Then
        '    Return
        'End If

        ''Saves the current Player line to a String
        'strPlayerLine = lblPlayerRow.Text

        ''Converts the Player string into an array of Characters
        'Dim chrPlayerLine() As Char = strPlayerLine.ToCharArray

        ''Searches array for existing PC char and
        ''replaces current position with a ·, otherwise
        ''the move leaves a trail
        'For i As Integer = 0 To (chrPlayerLine.Length - 1) Step 1
        '    If chrPlayerLine(i) = chrPlayer Then
        '        chrPlayerLine(i) = BG
        '    End If
        'Next

        ''Checks to see if the player touched another element
        ''HitDetect(chrPlayerLine(intPlayerPos))

        ''Puts the Player at the new location
        'chrPlayerLine(intPlayerPos) = chrPlayer

        ''Resets Player line to be rebuilt with new positions
        'strPlayerLine = ""
        ''Rebuilds Player line with new positions
        'For i As Integer = 0 To (chrPlayerLine.Length - 1) Step 1
        '    strPlayerLine &= chrPlayerLine(i)
        'Next

        ''Updates Player line with new String
        'lblPlayerRow.Text = strPlayerLine



    End Sub

    Private Function BulletTravel(ByVal strRow As String) As String

        Dim chrRow As Char() = strRow.ToCharArray
        chrRow(intPlayerPos) = "|"

        Dim strNewRow As String = ""

        For Each c In chrRow
            strNewRow += c
        Next

        Return strNewRow

    End Function

    Private Function BulletFollow(ByVal strRow As String) As String

        Dim chrRow As Char() = strRow.ToCharArray
        chrRow(intPlayerPos) = BG

        Dim strNewRow As String = ""

        For Each c In chrRow
            strNewRow += c
        Next

        Return strNewRow

    End Function

End Class