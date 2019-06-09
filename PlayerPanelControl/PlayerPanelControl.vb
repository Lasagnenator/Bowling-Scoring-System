Imports System.Windows.Forms

Public Class PlayerPanelControl
    'Visible property is already made.
    Private FrameBoxes As SingleFrame.SingleFrame() = New SingleFrame.SingleFrame() {F1, F2, F3, F4, F5, F6, F7, F8, F9, F10}
    Private NameValue As String
    Public Property PlayerName() As String
        Get
            Return NameValue
        End Get
        Set(ByVal value As String)
            MainGroupBox.Text = value
            NameValue = value
            'UpdateSelf()
        End Set
    End Property
    Private ScoresValue As String() = New String(20) {} '21 length array
    Public Property Scores() As String()
        Get
            Return ScoresValue
        End Get
        Set(value As String())
            ScoresValue = value
            For i = 0 To 9 'loop through frames 1-9 and update their scores
                FrameBoxes(i).Scores = {ScoresValue(i * 2), ScoresValue((i * 2) + 1)}
            Next
            'Then update frame 10's score as it has 3 scores
            F10.Scores = {ScoresValue(18), ScoresValue(19), ScoresValue(20)}
        End Set
    End Property
    Private TotalScoreValue As String
    Public Property TotalScore() As String
        Get
            Return TotalScoreValue
        End Get
        Set(ByVal value As String)
            TotalScoreValue = value
            TotalScoreBox.Text = TotalScoreValue
        End Set
    End Property
    Private SubTotalsValue As String() = New String(20) {}
    Public Property SubTotals() As String()
        Get
            Return SubTotalsValue
        End Get
        Set(ByVal value As String())
            SubTotalsValue = value
            For i = 0 To 10
                FrameBoxes(i).SubTotal = value(i)
            Next
        End Set
    End Property
    'Public Property Scores() As Integer() = New Integer(20) {} '21 length array
End Class