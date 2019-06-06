Public Class SingleFrame
    Private ScoresValue As String() = New String(1) {} 'Array of length 2
    Public Property Scores() As String()
        Get
            Return ScoresValue
        End Get
        Set(ByVal value As String())
            ScoresValue = value
            Bowl1.Text = ScoresValue(0)
            Bowl2.Text = ScoresValue(1)
        End Set
    End Property
    Private SubTotalValue As Integer
    Public Property NewProperty() As Integer
        Get
            Return SubTotalValue
        End Get
        Set(ByVal value As Integer)
            SubTotalValue = value
            SubTotal.Text = SubTotalValue
        End Set
    End Property

    Private Sub SingleFrame_ControlAdded(sender As Object, e As ControlEventArgs) Handles Me.ControlAdded
        Bowl1.SelectionAlignment = HorizontalAlignment.Center
        Bowl2.SelectionAlignment = HorizontalAlignment.Center
        SubTotal.SelectionAlignment = HorizontalAlignment.Center
    End Sub
End Class
