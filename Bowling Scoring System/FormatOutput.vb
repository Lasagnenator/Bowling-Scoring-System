Public Class FormatOutput
    '
    ' Summary:
    '     Formats Scores ready for being put into the score textboxes
    Public Shared Function FormatScores(ByVal Bowl1 As String, ByVal Optional Bowl2 As String = "", ByVal Optional Bowl3 As String = "", ByVal Optional SubTotal As String = Nothing) As String
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
