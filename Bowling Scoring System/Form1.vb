Public Class Form1
    Public CurrentPlayer As Integer = 0
    Public TotalPlayers As Integer
    Public CurrentFrame As Integer = 0 'Current frame number
    Public CurrentBowl As Integer = 0 'Where we are in the Scores variable horizontally
    Public CurrentFrameBowl As Integer = 0 '0, 1, 2 for the current bowl in a frame
    Public Scores As Integer(,) = New Integer(3, 20) {} 'Make the array 4x21 (max scores x players) and Initialise with zeros
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
        'ReDim Scores(3, 20) 
        'Initialise The PlayerScoreBoxes array
        PlayerScoreBoxes = {
        {P1F1, P1F2, P1F3, P1F4, P1F5, P1F6, P1F7, P1F8, P1F9, P1F10}
        }
    End Sub
    Public Sub MakePanels(ByVal num As Integer)
        For i = 0 To 4
            If i >= num Then

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
        Scores(CurrentPlayer, CurrentBowl) = Score
        If Score = ValidScores.Strike Then 'You got a strike so you don't need the second bowl unless frame 10
            If Not CurrentFrame = 9 Then
                CurrentBowl += 1
                Scores(CurrentPlayer, CurrentBowl) = 0
            End If

        End If
        If CurrentFrameBowl = 0 And (Not (Score = ValidScores.Strike)) Then 'First bowl of frame
            DisplayScore(CurrentPlayer, CurrentFrame,
                         FormatOutput.ScoreToText(Scores(CurrentPlayer, CurrentBowl)))
        ElseIf CurrentFrame = 9 And Score = ValidScores.Strike And CurrentFrameBowl = 2 Then 'Third bowl in frame 10 as strike
            DisplayScore(CurrentPlayer, CurrentFrame,
                         FormatOutput.ScoreToText(Scores(CurrentPlayer, CurrentBowl - 2)),
                         FormatOutput.ScoreToText(Scores(CurrentPlayer, CurrentBowl - 1)),
                         FormatOutput.ScoreToText(Scores(CurrentPlayer, CurrentBowl)))
        ElseIf CurrentFrame = 9 And Score = ValidScores.Strike And CurrentFrameBowl = 0 Then 'First bowl of frame 10 as Strike
            DisplayScore(CurrentPlayer, CurrentFrame,
                         FormatOutput.ScoreToText(Scores(CurrentPlayer, CurrentBowl)))
        Else 'Second bowl of frame
            DisplayScore(CurrentPlayer, CurrentFrame,
                         FormatOutput.ScoreToText(Scores(CurrentPlayer, CurrentBowl - 1)),
                         FormatOutput.ScoreToText(Scores(CurrentPlayer, CurrentBowl)))
        End If
        UpdateScores(CurrentPlayer, Score)
        CurrentBowl += 1
    End Sub

    Public Sub UpdateScores(ByVal Player As Integer, ByVal Score As Integer)
        CurrentFrameBowl += 1
        If Score = ValidScores.Strike Then
            If Not CurrentFrame = 9 Then 'Not in frame 10
                CurrentFrameBowl = 0 'It should already be zero but just making sure
                CurrentPlayer += 1
            End If

        End If
        If CurrentFrameBowl > 1 Then
            If Not CurrentFrame = 9 Then 'Not in Frame 10
                CurrentFrameBowl = 0
                CurrentPlayer += 1
                CurrentBowl -= 2
            ElseIf CurrentFrameBowl > 2 Then 'In Frame 10 and bowl 3
                CurrentFrameBowl = 0
                CurrentPlayer += 1
                CurrentBowl -= 3
            ElseIf CurrentFrame = 9 Then 'Did not earn the third bowl in frame 10
                If Not (Score = ValidScores.Spare Or Score = ValidScores.Strike) Then
                    CurrentFrameBowl = 0
                    CurrentPlayer += 1
                    CurrentBowl -= 2
                End If
            End If
        End If
        If CurrentPlayer >= TotalPlayers Then
            CurrentPlayer = 0
            CurrentFrame += 1
        End If
        If CurrentBowl > 20 Or CurrentFrame > 9 Then 'This should always occur
            'Game Ended
            MessageBox.Show("Player 1 Won", "Game Over")
        End If
        'DisplayScore(0, 2, "3", "4", SubTotal:="7")
        'PlayerScoreBoxes(0, 1).Text = FormatOutput.FormatScores("a", "b", SubTotal:="ab")
        'P1F2.Text = FormatOutput.FormatScores("a", "b", SubTotal:="cb")
    End Sub

    Public Sub DisplayScore(ByVal Player As Integer, Frame As Integer, ByVal Bowl1 As String, ByVal Optional Bowl2 As String = "", ByVal Optional Bowl3 As String = "", ByVal Optional SubTotal As String = Nothing)
        Dim Score As String = FormatOutput.FormatScores(Bowl1, Bowl2, Bowl3, SubTotal)
        PlayerScoreBoxes(Player, Frame).Text = Score
    End Sub
End Class
