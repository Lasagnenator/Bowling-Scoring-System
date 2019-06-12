Imports Bowling_Scoring_System.FormatOutput

Public Class Form1
    Public CurrentPlayer As Integer = 0
    Public TotalPlayers As Integer
    Public CurrentFrame As Integer = 0 'Current frame number
    Public CurrentBowl As Integer = 0 '0, 1, 2 for the current bowl in a frame
    Public PreviousSubTotals As Integer() = New Integer(9) {}
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

#Region "Control Flow Module"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayerNumDialog.ShowDialog()
        PlayerNameDialog.ShowDialog()
        CurrentPlayer = 0
        CurrentFrame = 0
        CurrentBowl = 0
    End Sub
    Public Sub MakePanels(ByVal num As Integer)
        For i = 0 To 3
            If i >= num Then
                SelectPlayer(i).Visible = False
            End If
        Next
    End Sub
    Public Sub AddScore(ByVal Score As Integer)
        'SelectPlayer(CurrentPlayer).IsCurrentPlayer = False
        DisplayScores(Score)
        If Score = ValidScores.Strike Then 'You got a strike so you don't need the second bowl unless frame 10
            If Not CurrentFrame = 9 Then 'Simulate the player taking a miss next bowl automatically.
                CurrentBowl += 1
                'Not sure if need to have this
                'DisplayAndUpdateScores(ValidScores.Miss)
            End If
        End If
        CalculateSubtotals()
        DisplayTotals()
        UpdatePlayer(CurrentPlayer, Score)
        UpdateButtons(Score)
        'SelectPlayer(CurrentPlayer).IsCurrentPlayer = True
    End Sub
    Public Sub UpdatePlayer(ByVal Player As Integer, ByVal Score As Integer)
        CurrentBowl += 1
        If ((Score = ValidScores.Strike) And (Not (CurrentBowl = 3))) Or (CurrentBowl = 2) Then
            If Not ((CurrentFrame = 9) And (EarnedFrame10())) Then
                IncrementNextPlayer()
            End If
            CheckFrame()
        ElseIf Not (CurrentBowl = 1) Then
            IncrementNextPlayer()
            CheckFrame()
        End If
    End Sub
    Public Sub UpdateButtons(ByVal Score As Integer)
        Dim temp = {RadioButton0, RadioButton1, RadioButton2, RadioButton3, RadioButton4, RadioButton5, RadioButton6, RadioButton7, RadioButton8, RadioButton9, RadioButton10, RadioButton11}
        'Enable all buttons
        For Each i In temp
            i.Enabled = True
        Next
        If (CurrentBowl = 0) Or (Score = ValidScores.Strike) Or (Score = ValidScores.Spare) Then
            'Disable spare
            RadioButton11.Enabled = False
        Else
            'Disable all buttons whose value is >= 10-score
            For i = 0 To 10
                If i >= (10 - Score) Then
                    temp(i).Enabled = False
                    'If current selected button gets disabled, select the miss button instead
                    If GetInputButtons(i).Checked Then
                        RadioButton0.Checked = True
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub Form1_KeyUp(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case "-"
                If Not RadioButton0.Enabled Then
                    Return
                End If
                RadioButton0.Checked = True
            Case "0"
                If Not RadioButton0.Enabled Then
                    Return
                End If
                RadioButton0.Checked = True
            Case "1"
                If Not RadioButton1.Enabled Then
                    Return
                End If
                RadioButton1.Checked = True
            Case "2"
                If Not RadioButton2.Enabled Then
                    Return
                End If
                RadioButton2.Checked = True
            Case "3"
                If Not RadioButton3.Enabled Then
                    Return
                End If
                RadioButton3.Checked = True
            Case "4"
                If Not RadioButton4.Enabled Then
                    Return
                End If
                RadioButton4.Checked = True
            Case "5"
                If Not RadioButton5.Enabled Then
                    Return
                End If
                RadioButton5.Checked = True
            Case "6"
                If Not RadioButton6.Enabled Then
                    Return
                End If
                RadioButton6.Checked = True
            Case "7"
                If Not RadioButton7.Enabled Then
                    Return
                End If
                RadioButton7.Checked = True
            Case "8"
                If Not RadioButton8.Enabled Then
                    Return
                End If
                RadioButton8.Checked = True
            Case "9"
                If Not RadioButton9.Enabled Then
                    Return
                End If
                RadioButton9.Checked = True
            Case "x"
                If Not RadioButton10.Enabled Then
                    Return
                End If
                RadioButton10.Checked = True
            Case "/"
                If Not RadioButton11.Enabled Then
                    Return
                End If
                RadioButton11.Checked = True
            Case vbCrLf
                EnterScoreButton_Click(New Object, New EventArgs())
        End Select
        Me.Refresh()
    End Sub

    Public Function GetInputButtons(index As Integer) As RadioButton
        Select Case index
            Case 0
                Return RadioButton0
            Case 1
                Return RadioButton1
            Case 2
                Return RadioButton2
            Case 3
                Return RadioButton3
            Case 4
                Return RadioButton4
            Case 5
                Return RadioButton5
            Case 6
                Return RadioButton6
            Case 7
                Return RadioButton7
            Case 8
                Return RadioButton8
            Case 9
                Return RadioButton9
            Case 10
                Return RadioButton10
            Case 11
                Return RadioButton11
        End Select
    End Function

#End Region

#Region "Input Module"
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
#End Region

#Region "Display Module"
    Public Sub DisplayScores(Score As Integer)
        'We need to do this as the property will not get updated properly if we try to edit the particular score directly
        Dim TempScores = SelectPlayer(CurrentPlayer).Frames(CurrentFrame).Scores
        TempScores(CurrentBowl) = ScoreToText(Score)
        SelectPlayer(CurrentPlayer).Frames(CurrentFrame).Scores = TempScores
    End Sub
    Public Sub DisplaySubTotals(ByVal Subtotal As Integer, Frame As Integer)
        'Same problem as above
        'We calculate the running totals because it's easy
        PreviousSubTotals(Frame) = Subtotal
        Dim Temp = SelectPlayer(CurrentPlayer).SubTotals
        For i = 0 To Frame - 1
            Subtotal += PreviousSubTotals(i)
        Next
        Temp(Frame) = Subtotal
        SelectPlayer(CurrentPlayer).SubTotals = Temp
    End Sub
    Public Sub DisplayTotals()
        Dim total = 0
        For Each score In PreviousSubTotals
            total += score
        Next
        SelectPlayer(CurrentPlayer).TotalScore = total
    End Sub
#End Region

#Region "Calculation Module"
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
                ElseIf (b1 = ValidScores.Strike) And (b3 = ValidScores.Spare) Then
                    Subtotal = b1 + 20
                ElseIf b1 = ValidScores.Strike Then 'b1=strike
                    Subtotal = b1 + (2 * (b2 + b3))
                ElseIf b2 = ValidScores.Spare Then 'b2=spare
                    Subtotal = 10 + (2 * b3)
                Else
                    Subtotal = b1 + b2
                End If
            Else
                If (b1 = b3) And (b3 = b4) And (b4 = ValidScores.Strike) Then 'b1=b3=b4=strike
                    Subtotal = b1 + b3 + b4
                ElseIf (b1 = b3) And (b3 = ValidScores.Strike) Then 'b1=b3=strike
                    Subtotal = b1 + b3 + b5
                ElseIf (b1 = ValidScores.Strike) And (b4 = ValidScores.Spare) Then 'b1=strike & b4=spare
                    Subtotal = b1 + 10
                ElseIf (b1 = ValidScores.Strike) Then 'b1=strike
                    Subtotal = b1 + b3 + b4
                ElseIf (b2 = ValidScores.Spare) Then 'b2=spare
                    Subtotal = 10 + b3
                Else
                    Subtotal = b1 + b2
                End If
            End If
            DisplaySubTotals(Subtotal, i)
        Next
    End Sub
#End Region

#Region "Used Functions"
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
        CurrentBowl = 0
        CurrentPlayer += 1
    End Sub
    Public Sub CheckFrame()
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
    Public Function EarnedFrame10() As Boolean
        Dim t1 = TextToScore(SelectPlayer(CurrentPlayer).Frames(9).Scores(0)) = ValidScores.Strike
        Dim t2 = TextToScore(SelectPlayer(CurrentPlayer).Frames(9).Scores(1)) = ValidScores.Spare
        Return t1 Or t2
    End Function

#End Region

End Class
