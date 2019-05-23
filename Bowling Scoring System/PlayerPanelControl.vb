Public Class PlayerPanelControl
    Public Property PlayerName() As String
        Get
            Return MainGroupBox.Text
        End Get
        Set(ByVal value As String)
            MainGroupBox.Text = value
            'UpdateSelf()
        End Set
    End Property
    Public Property Scores() As Integer() = New Integer(20) {}

    Public Sub UpdateSelf()

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class
