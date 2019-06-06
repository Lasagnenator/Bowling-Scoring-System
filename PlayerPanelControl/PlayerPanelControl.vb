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
            'UpdateSelf()
        End Set
    End Property
    Private ScoresValue As Integer() = New Integer(20) {} '21 length array
    Public Property Scores() As Integer()
        Get
            Return ScoresValue
        End Get
        Set(value As Integer())
            ScoresValue = value
            UpdateSelf()
        End Set
    End Property
    'Public Property Scores() As Integer() = New Integer(20) {} '21 length array
    Public Sub UpdateSelf()
        Dim i As Integer = 0
        For Each score In Scores

        Next
    End Sub
End Class