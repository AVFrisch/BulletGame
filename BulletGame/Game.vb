Imports System.Data
Imports System.Data.SqlClient

Public Class Game

    'General Variables
    Dim intScore As Integer = 0
    Dim dblTime As Double = 0
    Dim intSecondsCounter As Integer = 0
    Dim intTimeBonus As Integer = 0
    Dim intSpeedBonus As Integer = 0
    Dim intHitCount As Integer = 0
    Dim intShotCount As Integer = 0
    Dim intSpecial As Integer = 0
    Dim intLife As Integer = 10
    Dim strName As String = ""
    Dim HSTable As New HighScoresDataSetTableAdapters.HighScoresTableAdapter
    Private placementRand As New Random
    Private oddsRand As New Random


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
    'Background
    '''''''''''''''

    'Form Load
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Resets game in case of leftover data / initializes some things
        ResetGame()

        'Sets game refresh rate
        'Trade possible performance for accuracy
        Select Case intRefresh
            Case 15
                timRefreshRate.Interval = 67
            Case 30
                timRefreshRate.Interval = 33
            Case 60
                timRefreshRate.Interval = 17
        End Select

        'Sets game speed
        timDrop.Interval = CInt(1000 / Settings.intGameSpeed)

        'Places player onto the board
        intPlayerPos = 8

    End Sub

    'Form Close
    Private Sub Game_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        'Stops game so no sound effects or messages pop up when game is closed
        StopGame()

    End Sub

    '''''''''''''''
    'Timers
    '''''''''''''''

    'Records game time
    Private Sub timGame_Tick(sender As Object, e As EventArgs) Handles timGame.Tick

        'Standard timer counting by quarter seconds kind of
        'its a little slow but that's probably lag
        dblTime += 0.25

        'Used to cound whole seconds without using another timer, used for specials
        If intSecondsCounter <> 3 Then
            intSecondsCounter += 1
        Else
            intSecondsCounter = 0
        End If

        'ticks special counter ever second if a special isn't already off cooldown
        If intSecondsCounter = 0 And intSpecial <> 0 Then

            intSpecial -= 1

        End If

        'Turns special counter green when no longer on cooldown
        If intSpecial = 0 Then
            lblSpecial.ForeColor = Color.Green
        Else
            lblSpecial.ForeColor = Color.Black
        End If

    End Sub

    'Controls timed drops
    Private Sub timDrop_Tick(sender As Object, e As EventArgs) Handles timDrop.Tick

        'Memory management
        For Each thing As Piece In playerRow
            thing = Nothing
        Next

        'Moves rows down, ignoring bullets
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

        'Puts player back onto player row
        playerRow(intPlayerPos) = PC

        'Small score bonus for surviving each drop
        intScore += 5

    End Sub

    'Timer for projectiles
    Private Sub timProjectile_Tick(sender As Object, e As EventArgs) Handles timProjectile.Tick

        'Moves the bullets up
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
        'player row ignored since no bullets should be spawning there anyways

    End Sub

    'Sets game refresh rate
    Private Sub timRefreshRate_Tick(sender As Object, e As EventArgs) Handles timRefreshRate.Tick

        'Redraws all lines on the board
        UpdateBoard()

        'Updates labels
        lblTime.Text = dblTime.ToString("N2")
        lblScore.Text = intScore.ToString
        lblHits.Text = intHitCount.ToString
        lblLife.Text = intLife.ToString
        lblShots.Text = intShotCount.ToString
        lblSpecial.Text = intSpecial.ToString()

        'Checks to see if you've died yet
        If intLife <= 0 Then
            StopGame()
            'Stops game and shows ending options
            btnSubmit.Visible = True
            btnExit.Visible = True
            btnReset.Visible = True

            'Calculates bonuses depending on difficulty and game speed
            Select Case strDifficulty
                Case "Easy"
                    intTimeBonus = CInt(dblTime * 5)
                Case "Medium"
                    intTimeBonus = CInt(dblTime * 20)
                Case "Hard"
                    intTimeBonus = CInt(dblTime * 30)
            End Select

            intSpeedBonus = intGameSpeed ^ 2

            intScore += intTimeBonus + intSpeedBonus

            MessageBox.Show("Game Over!" & vbNewLine & "Your time bonus is " & intTimeBonus.ToString() & vbNewLine & "Your speed bonus is " & intSpeedBonus.ToString(), "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

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
            'Checks to see if the player has moved onto an obstacle or heart pickup and reacts accordingly
            If TypeOf playerRow(intPlayerPos) Is Heart Then
                intLife += 1
            ElseIf TypeOf playerRow(intPlayerPos) Is Obstacle Then
                intLife -= 1
                intScore -= 110
            End If
            playerRow(intPlayerPos) = PC
            'Movement bonus to encourage not staying still
            intScore += 10
        Else
            If blnAudio Then
                My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
            End If
        End If

    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click

        'Moves the player index one to the right
        'unless the player is already at the furthest
        'right it can be
        If intPlayerPos < (15) Then
            playerRow(intPlayerPos) = New Blank
            intPlayerPos += 1
            'Checks to see if the player has moved onto an obstacle or heart pickup and reacts accordingly
            If TypeOf playerRow(intPlayerPos) Is Heart Then
                intLife += 1
            ElseIf TypeOf playerRow(intPlayerPos) Is Obstacle Then
                intLife -= 1
                intScore -= 110
            End If
            playerRow(intPlayerPos) = PC
            'Movement bonus to encourage not staying still
            intScore += 10
        Else
            If blnAudio Then
                My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
            End If
        End If

    End Sub

    Private Sub btnShoot_Click(sender As Object, e As EventArgs) Handles btnShoot.Click

        'Fires a bullet depending on character selected
        'the offensive character shoots more powerful bullets than the other two
        If chrPlayer = "X"c Or chrPlayer = "O"c Then
            row0(intPlayerPos) = New Pew
        ElseIf chrPlayer = "V"c Then
            row0(intPlayerPos) = New Pow
        End If

        'Subtracts score for every shot to discourage spamming bullets randomly
        'and also penalizes people who think they're clever for just holding down shoot
        intScore -= 25
        intShotCount += 1

    End Sub

    Private Sub btnSpecial_Click(sender As Object, e As EventArgs) Handles btnSpecial.Click

        'Checks to make sure the special isn't on cooldown
        If intSpecial = 0 Then

            'Determines which special to use based on character selected
            Select Case chrPlayer
                Case "X"c

                    'Fires a bullet that expands on impact
                    row0(intPlayerPos) = New Bam
                    intSpecial = 5

                Case "O"c

                    'Turns all obstacles in the four rows above the player into hearts that increase life
                    For i As Integer = 0 To 15 Step 1
                        If TypeOf row0(i) Is Obstacle Then
                            row0(i) = New Heart
                        End If
                        If TypeOf row1(i) Is Obstacle Then
                            row0(i) = New Heart
                        End If
                        If TypeOf row2(i) Is Obstacle Then
                            row0(i) = New Heart
                        End If
                        If TypeOf row3(i) Is Obstacle Then
                            row0(i) = New Heart
                        End If
                    Next
                    intSpecial = 10


                Case "V"c

                    'Shoots two rows of powerful bullets at once
                    For i As Integer = 0 To 15 Step 1
                        row0(i) = New Diamond
                        row1(i) = New Diamond
                    Next
                    intSpecial = 7

            End Select



        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'Asks for the player's name for score submission
        btnSubmit.Enabled = False
        strName = InputBox("What is your name?", "Submit Score", "")

        'Cancels if the user doesn't enter a name, saves to database if they do
        If strName = "" Then
            MessageBox.Show("Score submission must have a name, please try again", "Submission failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnSubmit.Enabled = True
        Else
            HSTable.Insert(DateTime.Now, strName, intScore, chrPlayer)
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'Resets game and hides ending options
        btnSubmit.Visible = False
        btnExit.Visible = False
        btnReset.Visible = False
        ResetGame()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Exits game and hides ending options
        btnSubmit.Visible = False
        btnExit.Visible = False
        btnReset.Visible = False
        Me.Close()

    End Sub

    '''''''''''''''
    'Procedures and Functions
    '''''''''''''''

    'Drops everything except bullets down one, taking into account bullet collision
    Public Function Drop(ByVal pRowTop As Piece(), ByVal pRowBot As Piece()) As Piece()

        For i As Integer = 0 To 15 Step 1

            If TypeOf pRowTop(i) Is Heart And TypeOf pRowBot(i) Is Player Then

                intLife += 1

            ElseIf TypeOf pRowTop(i) Is Obstacle And TypeOf pRowBot(i) Is Player Then

                intLife -= 1
                intScore -= 200
                pRowTop(i) = Nothing

            ElseIf TypeOf (pRowTop(i)) IsNot Bullet And TypeOf (pRowBot(i)) IsNot Bullet Then

                pRowBot(i) = pRowTop(i)

            ElseIf TypeOf pRowTop(i) Is Obstacle And TypeOf pRowBot(i) Is Bullet Then

                If TypeOf pRowBot(i) Is Bam Then
                    'Special effect if special bullet hits
                    For i2 As Integer = 0 To 15 Step 1
                        pRowBot(i2) = New Pew
                    Next
                    Return pRowBot

                End If

                If (HitDetect(pRowBot(i), pRowTop(i))) Then
                    pRowTop(i) = New Blank
                End If

                pRowBot(i) = New Blank
                'lblDebug2.Text = "Drop"
            End If

        Next

        Return pRowBot

    End Function

    'Raises all bullets, taking into account collision with obstacles
    Public Function Raise(ByVal pRowTop As Piece(), ByVal pRowBot As Piece()) As Piece()

        For i As Integer = 0 To 15 Step 1

            If TypeOf pRowTop(i) Is Obstacle And TypeOf pRowBot(i) Is Bullet Then

                If TypeOf pRowBot(i) Is Bam Then
                    'Special effect if special bullet hits
                    For i2 As Integer = 0 To 15 Step 1
                        pRowBot(i2) = New Pew
                    Next
                    Return pRowBot

                End If

                If (HitDetect(pRowBot(i), pRowTop(i))) Then
                    pRowTop(i) = New Blank
                End If

                pRowBot(i) = New Blank
                'lblDebug2.Text = "Raise"
            ElseIf TypeOf pRowBot(i) Is Bullet Then
                pRowTop(i) = pRowBot(i)
                pRowBot(i) = New Blank
            End If

        Next

        Return pRowBot

    End Function

    Public Function HitDetect(ByRef bottom As Piece, ByRef top As Piece) As Boolean
        'Counts 1 for a hit
        intHitCount += 1

        If CType(top, Obstacle).Hit(CType(bottom, Bullet).Damage) Then

            '75 points for finishing off an obstacle
            intScore += 75
            Return 1

        Else

            '50 points for damaging an obstacle
            intScore += 50
            Return 0

        End If

    End Function

    'Loads a blank line
    Public Function LoadBlank() As Piece()

        Dim blankRow(15) As Piece

        For i As Integer = 0 To 15 Step 1
            blankRow(i) = New Blank
        Next

        Return blankRow

    End Function


    'Loads top line which includes obstacle generation
    Public Function LoadTop() As Piece()

        Dim topRow(15) As Piece

        'Starts with a blank line
        For i As Integer = 0 To 15 Step 1
            topRow(i) = New Blank
        Next

        'Determines how many obstacles to create based on difficulty
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

        'Redraws each board row
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

    'Function used for building each row
    Public Function LoadRow(ByVal pRow As Piece()) As String

        Dim i As Integer = 0
        Dim strBuildRow As String = ""

        For Each piece In pRow
            strBuildRow += pRow(i).Sym
            i += 1
        Next

        Return strBuildRow

    End Function

    'Resets variables, clears board, resets buttons, restarts timers
    Private Sub ResetGame()

        intScore = 0
        dblTime = 0
        intHitCount = 0
        intShotCount = 0
        intLife = 10

        PC.RefreshChar()

        playerRow = LoadBlank()
        row0 = LoadBlank()
        row1 = LoadBlank()
        row2 = LoadBlank()
        row3 = LoadBlank()
        row4 = LoadBlank()
        row5 = LoadBlank()
        row6 = LoadBlank()
        row7 = LoadBlank()
        row8 = LoadBlank()
        row9 = LoadBlank()
        row10 = LoadBlank()
        row11 = LoadBlank()
        row12 = LoadBlank()
        row13 = LoadBlank()
        row14 = LoadBlank()
        row15 = LoadBlank()
        row16 = LoadBlank()
        rowTop = LoadBlank()

        timGame.Enabled = True
        timDrop.Enabled = True
        timRefreshRate.Enabled = True
        timProjectile.Enabled = True

        btnSubmit.Enabled = True

    End Sub

    'Halts all timers
    Private Sub StopGame()
        timGame.Enabled = False
        timDrop.Enabled = False
        timRefreshRate.Enabled = False
        timProjectile.Enabled = False
    End Sub

End Class