Public Class Form1
    Public CurrentPlayer As Integer = 0
    Public TotalPlayers As Integer
    Public CurrentBowl As Integer = 0
    Public Scores As Integer(,) = New Integer(3, 20) {} 'Make the array 4x21 (max scores x players) and Initialise with zeros
    Public PlayerScoreBoxes As RichTextBox(,) = {
        {P1F1, P1F2, P1F3, P1F4, P1F5, P1F6, P1F7, P1F8, P1F9, P1F10, Player1TotalScoreBox}
        }
    Private Enum ValidScores
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
    End Sub
    Public Sub MakePanels(num As Integer)
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
        UpdateScores(CurrentPlayer)
    End Sub
    Public Sub UpdateScores(Player As Integer)
        CurrentPlayer += 1
        If CurrentPlayer >= TotalPlayers Then
            CurrentPlayer = 0
            CurrentBowl += 1
        End If
        If CurrentBowl > 20 Then
            'Game Ended
            MessageBox.Show("Player 1 Won", "Game Over")
        End If
        'P1F2.Text = FormatScores("a", "b", SubTotal:="cb")
    End Sub

    Public Function FormatScores(ByVal Bowl1 As String, ByVal Optional Bowl2 As String = "", ByVal Optional Bowl3 As String = "", ByVal Optional SubTotal As String = Nothing) As String
        Dim FinalString As String = ""
        Dim Pad As Integer
        'No need to use padding as each score is one character long
        If Bowl2 = "" Then                          'Strike or still on first bowl
            If Bowl1 = "X" Then                     'Strike
                FinalString = "      X"             'Make the strike appear in the spot where bowl2 normally goes
            Else
                FinalString = Bowl1                 'First bowl only
            End If
        Else                                        'Two bowls taken
            FinalString = Bowl1 + "     " + Bowl2
        End If
        If Not (Bowl3 = "") Then                    'Frame 10 third bowl taken
            FinalString += "     " + Bowl3
        End If
        'If Subtotal is given
        'Padding needed here as scores can be 1,2 or 3 digits long
        If Not SubTotal = Nothing Then
            FinalString += vbNewLine + vbNewLine
            If Not (Bowl3 = "") Then
                Pad = 9
            Else
                Pad = 5
            End If
            Pad += SubTotal.Length - 1 'Make it more centered by shifting the padding over by SubTotal.Length-1
            FinalString += SubTotal.PadLeft(Pad, " ")
        End If
        Return FinalString
    End Function
End Class
