Public Class Form1
    Public CurrentPlayer As Integer = 0
    Public TotalPlayers As Integer
    Public CurrentFrame As Integer = 0 'Current frame number
    Public CurrentFrameBowl As Integer = 0 '0, 1, 2 for the current bowl in a frame
    Public PlayerScoreBoxes As RichTextBox(,) = New RichTextBox(0, 9) {}
    Public Enum ValidScores
        Miss
        One
        Two
        Three
        Four
        Five
        Six
        Seven
        Eight
        Nine
        Strike
        Spare
    End Enum
    Dim Rb As RadioButton() = {
        RadioButton0,
        RadioButton1,
        RadioButton2,
        RadioButton3,
        RadioButton4,
        RadioButton5,
        RadioButton6,
        RadioButton7,
        RadioButton8,
        RadioButton9,
        RadioButton10,
        RadioButton11}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayerNumDialog.ShowDialog()
        PlayerPanel1.Scores(0) = 1
    End Sub
    Public Sub MakePanels(ByVal num As Integer)
        For i = 0 To 3
            If i >= num Then
                SelectPlayer(i).Visible = False
            End If
        Next
    End Sub

    Private Sub EnterScoreButton_Click(sender As Object, e As EventArgs) Handles EnterScoreButton.Click
        If RadioButton0.Checked Then
            AddScore(ValidScores.Miss)
        ElseIf RadioButton1.Checked Then
            AddScore(ValidScores.One)
        ElseIf RadioButton2.Checked Then
            AddScore(ValidScores.Two)
        ElseIf RadioButton3.Checked Then
            AddScore(ValidScores.Three)
        ElseIf RadioButton4.Checked Then
            AddScore(ValidScores.Four)
        ElseIf RadioButton5.Checked Then
            AddScore(ValidScores.Five)
        ElseIf RadioButton6.Checked Then
            AddScore(ValidScores.Six)
        ElseIf RadioButton7.Checked Then
            AddScore(ValidScores.Seven)
        ElseIf RadioButton8.Checked Then
            AddScore(ValidScores.Eight)
        ElseIf RadioButton9.Checked Then
            AddScore(ValidScores.Nine)
        ElseIf RadioButton10.Checked Then
            AddScore(ValidScores.Strike)
        ElseIf RadioButton11.Checked Then
            AddScore(ValidScores.Spare)
        End If
    End Sub

    Public Sub AddScore(ByVal Score As Integer)
        SelectPlayer(CurrentPlayer).Frames(CurrentFrame).Scores(CurrentFrameBowl) = FormatOutput.ScoreToText(Score)
        Dim a = SelectPlayer(CurrentPlayer).Frames(CurrentFrame)
        If Score = ValidScores.Strike Then 'You got a strike so you don't need the second bowl unless frame 10
            If Not CurrentFrame = 9 Then 'Simulate the player taking a miss next bowl automatically.
                CurrentFrameBowl += 1
                SelectPlayer(CurrentPlayer).Frames(CurrentFrame).Scores(CurrentFrameBowl) = "-"
            End If

        End If
        UpdateScores(CurrentPlayer, Score)
    End Sub

    Public Sub UpdateScores(ByVal Player As Integer, ByVal Score As Integer)
        CurrentFrameBowl += 1
        If Score = ValidScores.Strike Then
            If Not CurrentFrame = 9 Then 'Not in frame 10
                IncrementNextPlayer()
            End If

        End If
        If CurrentFrameBowl > 1 Then 'bowl 3
            If Not CurrentFrame = 9 Then 'Not in Frame 10
                IncrementNextPlayer()
            ElseIf CurrentFrameBowl > 2 Then 'In Frame 10 and bowl 4
                IncrementNextPlayer()
            ElseIf CurrentFrame = 9 Then 'Did not earn the third bowl in frame 10
                If Not (SelectPlayer(CurrentPlayer).Frames(9).Scores(0) = ValidScores.Strike Or Score = ValidScores.Spare) Then
                    IncrementNextPlayer()
                End If
            End If
        End If
        If CurrentPlayer >= TotalPlayers Then
            CurrentPlayer = 0 'Go back to player 1
            CurrentFrame += 1 'Increment to next frame
        End If
        If CurrentFrame > 9 Then 'This should always occur
            'Game Ended
            MessageBox.Show("Player 1 Won", "Game Over")
        End If
        'DisplayScore(0, 2, "3", "4", SubTotal:="7")
        'PlayerScoreBoxes(0, 1).Text = FormatOutput.FormatScores("a", "b", SubTotal:="ab")
        'P1F2.Text = FormatOutput.FormatScores("a", "b", SubTotal:="cb")
    End Sub
    Public Function SelectPlayer(ByVal Player As Integer) As PlayerPanelControl.PlayerPanelControl
        Select Case Player
            Case 0
                Return PlayerPanel1
            Case 1
                Return PlayerPanel2
            Case 2
                Return PlayerPanel3
            Case 3
                Return PlayerPanel4
            Case Else

        End Select
    End Function
    Public Sub IncrementNextPlayer()
        CurrentFrameBowl = 0
        CurrentPlayer += 1
    End Sub
End Class
