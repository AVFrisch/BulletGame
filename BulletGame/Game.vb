Public Class Game

    'General Variables
    Private Const BG As Char = "·"c
    Private blnStop As Boolean
    Private blnAudio As Boolean
    Private intRefresh As Integer
    Private placementRand As New Random
    Private oddsRand As New Random

    'Startup Settings Variables
    Public Shared chrPlayer As Char = "X"c
    Public strDifficulty As String = "Hard"
    Public intGameSpeed As Integer = 10
    Public intRefreshRate As Integer = 30


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
    Dim PC As New Player
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

        rowTop(placementRand.Next(16)) = New Obstacle

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

        ''Sends all row arrays down one and generates a new blank for the top
        ''this doesn't actually solve any of the problems I had before yet
        'playerRow = row0
        'row0 = row1
        'row1 = row2
        'row2 = row3
        'row3 = row4
        'row4 = row5
        'row5 = row6
        'row6 = row7
        'row7 = row8
        'row8 = row9
        'row9 = row10
        'row10 = row11
        'row11 = row12
        'row12 = row13
        'row13 = row14
        'row14 = row15
        'row15 = row16
        'row16 = rowTop
        'rowTop = LoadBlank()

        'ok but now this one does
        playerRow = Drop(row0, playerRow)
        row0 = Drop(row1, row0)
        row1 = Drop(row2, row1)
        row2 = Drop(row3, row2)
        row3 = Drop(row4, row3)
        row4 = Drop(row5, row4)
        row5 = Drop(row6, row5)
        row6 = Drop(row7, row6)
        row7 = Drop(row8, row7)
        row8 = Drop(row9, row8)
        row9 = Drop(row10, row9)
        row10 = Drop(row11, row10)
        row11 = Drop(row12, row11)
        row12 = Drop(row13, row12)
        row13 = Drop(row14, row13)
        row14 = Drop(row15, row14)
        row15 = Drop(row16, row15)
        row16 = Drop(rowTop, row16)
        rowTop = LoadTop()

        'Puts player back
        playerRow(intPlayerPos) = PC

    End Sub

    'Timer for projectiles
    Private Sub timProjectile_Tick(sender As Object, e As EventArgs) Handles timProjectile.Tick


        ' rowTop = LoadBlank()
        row16 = Raise(rowTop, row16)
        row15 = Raise(row16, row15)
        row14 = Raise(row15, row14)
        row13 = Raise(row14, row13)
        row12 = Raise(row13, row12)
        row11 = Raise(row12, row11)
        row10 = Raise(row11, row10)
        row9 = Raise(row10, row9)
        row8 = Raise(row9, row8)
        row7 = Raise(row8, row7)
        row6 = Raise(row7, row6)
        row5 = Raise(row6, row5)
        row4 = Raise(row5, row4)
        row3 = Raise(row4, row3)
        row2 = Raise(row3, row2)
        row1 = Raise(row2, row1)
        row0 = Raise(row1, row0)
        'playerRow = Raise(row0, playerRow)


    End Sub

    'Sets game refresh rate
    Private Sub timRefreshRate_Tick(sender As Object, e As EventArgs) Handles timRefreshRate.Tick

        UpdateBoard()

        'Currently hardcoded 10% chance for obstacles to drop on their own
        'every time the board is refreshed
        'If oddsRand.Next(100) < 10 Then
        '    rowTop(placementRand.Next(16)) = New Obstacle
        'End If

    End Sub

    '''''''''''''''
    'Buttons
    '''''''''''''''

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click

        'Moves the player index one to the left
        'unless the player is already at the furthest
        'left it can be
        If intPlayerPos > 0 Then
            playerRow(intPlayerPos) = New Blank
            intPlayerPos -= 1
            playerRow(intPlayerPos) = PC
        Else
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
        End If

    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click

        'Moves the player index one to the right
        'unless the player is already at the furthest
        'right it can be
        If intPlayerPos < (15) Then
            playerRow(intPlayerPos) = New Blank
            intPlayerPos += 1
            playerRow(intPlayerPos) = PC
        Else
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
        End If

    End Sub

    Private Sub btnShoot_Click(sender As Object, e As EventArgs) Handles btnShoot.Click

        row0(intPlayerPos) = New Bullet

    End Sub

    '''''''''''''''
    'Procedures and Functions
    '''''''''''''''

    Public Function Drop(ByVal pRowTop As Piece(), ByVal pRowBot As Piece()) As Piece()

        Dim i As Integer = 0

        For Each thing As Piece In pRowTop

            'The idea here is blanks and obstacles will drop as normal but
            'bullet objects are unaffected
            If TypeOf thing Is Obstacle Or TypeOf thing Is Blank Then
                pRowBot(i) = pRowTop(i)
            ElseIf TypeOf thing Is Bullet Then
                pRowBot(i) = pRowTop(i)
            End If

            i += 1
        Next

        Return pRowBot

    End Function

    Public Function Raise(ByVal pRowTop As Piece(), ByVal pRowBot As Piece()) As Piece()

        Dim i As Integer = 0

        For Each thing As Piece In pRowBot

            If TypeOf pRowTop(i) Is Obstacle Then
                'hit detection here
            ElseIf TypeOf thing Is Bullet Then
                pRowTop(i) = pRowBot(i)
                pRowBot(i) = New Blank
            End If

            i += 1
        Next

        Return pRowBot

    End Function



    Public Function LoadBlank() As Piece()

        Dim blankRow(15) As Piece

        For i As Integer = 0 To 15 Step 1
            blankRow(i) = New Blank
        Next

        Return blankRow

    End Function

    Public Function LoadTop() As Piece()

        Dim topRow(15) As Piece

        For i As Integer = 0 To 15 Step 1
            topRow(i) = New Blank
        Next

        Select Case strDifficulty
            Case "Easy"
                topRow(placementRand.Next(16)) = New Obstacle

            Case "Medium"
                topRow(placementRand.Next(16)) = New Obstacle
                topRow(placementRand.Next(16)) = New Obstacle

            Case "Hard"
                topRow(placementRand.Next(16)) = New Obstacle
                topRow(placementRand.Next(16)) = New Obstacle
                topRow(placementRand.Next(16)) = New Obstacle

        End Select


        Return topRow

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

    '''''''''''''''
    'Potentially retired code
    '''''''''''''''

    Private Sub OldDrop()

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

        'Dim strRow As String


        ''Controls shots from the player
        'lblRow0.Text = BulletTravel(lblRow0.Text)
        'lblRow1.Text = BulletTravel(lblRow1.Text)
        'lblRow2.Text = BulletTravel(lblRow2.Text)
        'lblRow3.Text = BulletTravel(lblRow3.Text)
        'lblRow4.Text = BulletTravel(lblRow4.Text)
        'lblRow5.Text = BulletTravel(lblRow5.Text)



        ''Puts player back
        'UpdatePlayer()

    End Sub

    Private Sub UpdatePlayer()

        'Prevents player from moving if game has stopped
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

    'Private Function BulletTravel(ByVal strRow As String) As String

    '    Dim chrRow As Char() = strRow.ToCharArray
    '    chrRow(intPlayerPos) = "|"

    '    Dim strNewRow As String = ""

    '    For Each c In chrRow
    '        strNewRow += c
    '    Next

    '    Return strNewRow

    'End Function

    'Private Function BulletFollow(ByVal strRow As String) As String

    '    Dim chrRow As Char() = strRow.ToCharArray
    '    chrRow(intPlayerPos) = BG

    '    Dim strNewRow As String = ""

    '    For Each c In chrRow
    '        strNewRow += c
    '    Next

    '    Return strNewRow

    'End Function

End Class