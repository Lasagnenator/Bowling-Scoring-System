Public Class PlayerPanelControl
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
    Public Property Scores() As Integer() = New Integer(20) {}
End Class