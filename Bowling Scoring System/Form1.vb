Imports Bowling_Scoring_System.FormatOutput

Public Class Form1
    Public CurrentPlayer As Integer = 0
    Public TotalPlayers As Integer
    Public CurrentFrame As Integer = 0 'Current frame number
    Public CurrentFrameBowl As Integer = 0 '0, 1, 2 for the current bowl in a frame
    Public PlayerScoreBoxes As RichTextBox(,) = New RichTextBox(0, 9) {}
    Public TempScores As String() = New String(20) {} 'Used to make the Scores property function as intended.
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
        'Then a function to let players input names
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
        DisplayAndUpdateScores(Score)
        If Score = ValidScores.Strike Then 'You got a strike so you don't need the second bowl unless frame 10
            If Not CurrentFrame = 9 Then 'Simulate the player taking a miss next bowl automatically.
                CurrentFrameBowl += 1
                'Not sure if need to have this
                'DisplayAndUpdateScores(ValidScores.Miss)
            End If
        End If
        'CalculateSubtotals
        UpdatePlayer(CurrentPlayer, Score)
    End Sub

    Public Sub UpdatePlayer(ByVal Player As Integer, ByVal Score As Integer)
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
                If Not (TextToScore(SelectPlayer(CurrentPlayer).Frames(9).Scores(0)) = ValidScores.Strike Or Score = ValidScores.Spare) Then
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
            'This will get changed later
            MessageBox.Show("Player 1 Won", "Game Over")
        End If
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
        End Select
    End Function
    Public Sub IncrementNextPlayer()
        CurrentFrameBowl = 0
        CurrentPlayer += 1
    End Sub
    Public Sub DisplayAndUpdateScores(Score As Integer)
        TempScores = SelectPlayer(CurrentPlayer).Frames(CurrentFrame).Scores
        TempScores(CurrentFrameBowl) = ScoreToText(Score)
        SelectPlayer(CurrentPlayer).Frames(CurrentFrame).Scores = TempScores
    End Sub
    Public Sub CalculateSubtotals()
        Dim b1 As Integer
        Dim b2 As Integer
        Dim b3 As Integer
        Dim b4 As Integer
        Dim b5 As Integer
        For i = 0 To CurrentFrame
            Dim CFrame = SelectPlayer(CurrentPlayer).Frames(i)
            Dim Subtotal = 0
            If i = 9 Then 'bowl1 in frame 10
                b1 = TextToScore(CFrame.Scores(0)) 'b1f10
                b2 = TextToScore(CFrame.Scores(1)) 'b2f10
                b3 = TextToScore(CFrame.Scores(2)) 'b3f10
                b4 = b5 = 0                        'zeros
            ElseIf i = 8 Then 'bowl1 in frame 9
                Dim NFrame = SelectPlayer(CurrentPlayer).Frames(i + 1)

                b1 = TextToScore(CFrame.Scores(0)) 'b1f9
                b2 = TextToScore(CFrame.Scores(1)) 'b2f9
                b3 = TextToScore(NFrame.Scores(0)) 'b1f10
                b4 = TextToScore(NFrame.Scores(1)) 'b2f10
                b5 = TextToScore(NFrame.Scores(2)) 'b3f10
            Else 'bowl1 in frame 1-8
                Dim NFrame = SelectPlayer(CurrentPlayer).Frames(i + 1)
                Dim AFrame = SelectPlayer(CurrentPlayer).Frames(i + 2)

                b1 = TextToScore(CFrame.Scores(0)) 'b1fi
                b2 = TextToScore(CFrame.Scores(1)) 'b2fi
                b3 = TextToScore(NFrame.Scores(0)) 'b1fi+1
                b4 = TextToScore(NFrame.Scores(1)) 'b2fi+1
                b5 = TextToScore(AFrame.Scores(0)) 'b1fi+2
            End If

            If i = 9 Then 'bowl 1 in frame 10
                If ((b1 = b2) And (b2 = ValidScores.Strike)) Then 'b1=b2=strike
                    Subtotal = b1 + (2 * b2) + (3 * b3)
                ElseIf b1 = ValidScores.Strike Then
                    Subtotal = b1 + (2 * (b2 + b3))
                ElseIf b2 = ValidScores.Spare Then
                    Subtotal = 10 + (Subtotal * b3)
                Else
                    Subtotal = b1 + b2
                End If
            Else
                If (b1 = b3) And (b3 = b4) And (b4 = ValidScores.Strike) Then 'b1=b3=b4=strike
                    Subtotal = b1 + b3 + b4
                ElseIf (b1 = b3) And (b3 = ValidScores.Strike) Then 'b1=b3=strike
                    Subtotal = b1 + b3 + b5
                ElseIf (b1 = ValidScores.Strike) Then 'b1=strike
                    Subtotal = b1 + b3 + b4
                ElseIf (b2 = ValidScores.Spare) Then 'b2=spare
                    Subtotal = 10 + b3
                Else
                    Subtotal = b1 + b2
                End If
            End If
        Next
    End Sub
End Class
