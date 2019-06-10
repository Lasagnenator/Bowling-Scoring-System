Imports System.Windows.Forms

Public Class PlayerPanelControl
    'Visible property is already made.
    Private NameValue As String
    Public Property PlayerName() As String
        Get
            Return NameValue
        End Get
        Set(ByVal value As String)
            MainGroupBox.Text = value
            NameValue = value
        End Set
    End Property
    Public ReadOnly Property Frames(ByVal Index As Integer) As SingleFrame.SingleFrame
        Get
            Select Case Index
                Case 0
                    Return F1
                Case 1
                    Return F2
                Case 2
                    Return F3
                Case 3
                    Return F4
                Case 4
                    Return F5
                Case 5
                    Return F6
                Case 6
                    Return F7
                Case 7
                    Return F8
                Case 8
                    Return F9
                Case 9
                    Return F10
            End Select
        End Get
    End Property
    Private ScoresValue As String() = New String(20) {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""}
    '21 length array
    Public Property Scores() As String()
        Get
            Return ScoresValue
        End Get
        Set(value As String())
            ScoresValue = value
            F1.Scores = {ScoresValue(0), ScoresValue(1)}
            F2.Scores = {ScoresValue(2), ScoresValue(3)}
            F3.Scores = {ScoresValue(4), ScoresValue(5)}
            F4.Scores = {ScoresValue(6), ScoresValue(7)}
            F5.Scores = {ScoresValue(8), ScoresValue(9)}
            F6.Scores = {ScoresValue(10), ScoresValue(11)}
            F7.Scores = {ScoresValue(12), ScoresValue(13)}
            F8.Scores = {ScoresValue(14), ScoresValue(15)}
            F9.Scores = {ScoresValue(16), ScoresValue(17)}
            F10.Scores = {ScoresValue(18), ScoresValue(19), ScoresValue(20)}
        End Set
    End Property
    Private TotalScoreValue As Integer
    Public Property TotalScore() As Integer
        Get
            Return TotalScoreValue
        End Get
        Set(ByVal value As Integer)
            TotalScoreValue = value
            TotalScoreBox.Text = vbCrLf + Convert.ToString(TotalScoreValue)
        End Set
    End Property
    Private SubTotalsValue As String() = New String(9) {}
    Public Property SubTotals() As String()
        Get
            Return SubTotalsValue
        End Get
        Set(ByVal value As String())
            SubTotalsValue = value
            F1.SubTotal = value(0)
            F2.SubTotal = value(1)
            F3.SubTotal = value(2)
            F4.SubTotal = value(3)
            F5.SubTotal = value(4)
            F6.SubTotal = value(5)
            F7.SubTotal = value(6)
            F8.SubTotal = value(7)
            F9.SubTotal = value(8)
            F10.SubTotal = value(9)

        End Set
    End Property

    Private Sub PlayerPanelControl_ControlAdded(sender As Object, e As ControlEventArgs) Handles Me.ControlAdded
        TotalScoreBox.SelectionAlignment = HorizontalAlignment.Center
    End Sub
End Class