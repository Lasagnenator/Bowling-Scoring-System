Public Class Form1
    Public CurrentPlayer As Integer = 0
    Public TotalPlayers As Integer
    Public CurrentFrame As Integer = 0 'Current frame number
    Public CurrentBowl As Integer = 0 'Where we are in the Scores variable horizontally
    Public CurrentFrameBowl As Integer = 0 '0, 1, 2 for the current bowl in a frame
    'Public Scores As Integer(,) = New Integer(3, 20) {} 'Make the array 4x21 (max scores x players) and Initialise with zeros
    Public PlayerScoreBoxes As RichTextBox(,) = New RichTextBox(0, 9) {}
    Public Scores As PlayerPanelControl.PlayerPanelControl() = New PlayerPanelControl.PlayerPanelControl(4) {}
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
        Scores = {PlayerPanel1, PlayerPanel2, PlayerPanel3, PlayerPanel4}
        PlayerNumDialog.ShowDialog()
        PlayerPanel1.Scores(0) = 1
    End Sub
    Public Sub MakePanels(ByVal num As Integer)
        For i = 0 To 3
            If i >= num Then
                Scores(i).Visible = False
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
        Scores(CurrentPlayer).Scores(CurrentBowl) = FormatOutput.ScoreToText(Score)
        If Score = ValidScores.Strike Then 'You got a strike so you don't need the second bowl unless frame 10
            If Not CurrentFrame = 9 Then
                CurrentBowl += 1
                Scores(CurrentPlayer).Scores(CurrentBowl) = "-"
            End If

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
                If Not (Scores(CurrentPlayer).Scores(18) = ValidScores.Strike Or Score = ValidScores.Spare) Then
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
End Class
