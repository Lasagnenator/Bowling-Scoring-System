Public Class SingleFrame
    Protected ScoresValue As String() = New String(2) {} 'Array of length 3
    Public Property Scores() As String()
        Get
            Return ScoresValue
        End Get
        Set(ByVal value As String())
            ScoresValue = value
            Bowl1.Text = ScoresValue(0)
            Bowl2.Text = ScoresValue(1)
            Try
                Bowl3.Text = ScoresValue(2)
            Catch ex As IndexOutOfRangeException

            End Try
        End Set
    End Property
    Private SubTotalValue As String = 0
    Public Property SubTotal() As String
        Get
            Return SubTotalValue
        End Get
        Set(ByVal value As String)
            SubTotalValue = value
            SubTotalBox.Text = SubTotalValue
        End Set
    End Property
    Private IsFrame10Value As Boolean = True
    Public Property IsFrame10Visible() As Boolean
        Get
            Return IsFrame10Value
        End Get
        Set(ByVal value As Boolean)
            IsFrame10Value = value
            UpdateFrame10(value)
        End Set
    End Property

    Private Sub SingleFrame_ControlAdded(sender As Object, e As ControlEventArgs) Handles Me.ControlAdded
        Bowl1.SelectionAlignment = HorizontalAlignment.Center
        Bowl2.SelectionAlignment = HorizontalAlignment.Left
        Bowl3.SelectionAlignment = HorizontalAlignment.Center
        SubTotalBox.SelectionAlignment = HorizontalAlignment.Center
    End Sub
    Private Sub UpdateFrame10(ByVal value As Boolean)
        If value = False Then 'Remove bowl 3 part
            Bowl3.Visible = False
            Bowl2.SelectionAlignment = HorizontalAlignment.Center
            ReDim ScoresValue(1)
        Else
            Bowl3.Visible = True
            Bowl2.SelectionAlignment = HorizontalAlignment.Left
            ReDim ScoresValue(2)
        End If
    End Sub
End Class
