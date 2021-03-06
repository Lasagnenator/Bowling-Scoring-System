﻿Public Class SingleFrame
    Protected ScoresValue As String() = New String(2) {} 'Array of length 3
    Public Property Scores() As String()
        Get
            Return ScoresValue
        End Get
        Set(ByVal value As String())
            ScoresValue = value
            Bowl1.Text = ScoresValue(0)
            Bowl2.Text = ScoresValue(1)
            If IsFrame10Value Then
                Bowl3.Text = ScoresValue(2)
            End If
        End Set
    End Property
    Private SubTotalValue As String = ""
    Public Property SubTotal() As String
        Get
            Return SubTotalValue
        End Get
        Set(ByVal value As String)
            SubTotalValue = value
            SubTotalBox.Text = vbCrLf + SubTotalValue
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
        UpdateColour()
    End Sub
    Private Sub UpdateFrame10(ByVal value As Boolean)
        If value = False Then 'Remove bowl 3 part
            Bowl3.Visible = False
            Bowl2.SelectionAlignment = HorizontalAlignment.Center
            ReDim ScoresValue(1)
        Else 'Add the bowl 3 part again
            Bowl3.Visible = True
            Bowl2.SelectionAlignment = HorizontalAlignment.Left
            ReDim ScoresValue(2)
        End If
    End Sub

    Private EvenTileValue As Boolean = False
    Public Property EvenTile() As Boolean
        Get
            Return EvenTileValue
        End Get
        Set(ByVal value As Boolean)
            EvenTileValue = value
            UpdateColour()
        End Set
    End Property
    Public Sub UpdateColour()
        Dim Odd = Color.FromArgb(80, 94, 103)
        Dim Even = Color.FromArgb(133, 162, 166)
        If EvenTileValue Then
            Bowl1.BackColor = Even
            Bowl2.BackColor = Even
            Bowl3.BackColor = Even
            SubTotalBox.BackColor = Even
            Me.BackColor = Even
            Bowl1.ForeColor = Color.FromArgb(22, 32, 42)
            Bowl2.ForeColor = Color.FromArgb(22, 32, 42)
            Bowl3.ForeColor = Color.FromArgb(22, 32, 42)
            SubTotalBox.ForeColor = Color.FromArgb(22, 32, 42)
        Else
            Bowl1.BackColor = Odd
            SubTotalBox.BackColor = Odd
            Bowl2.BackColor = Odd
            Bowl3.BackColor = Odd
            Me.BackColor = Odd
            'Me.ForeColor = Color.FromArgb(237, 255, 255)
            Bowl1.ForeColor = Color.FromArgb(237, 255, 255)
            Bowl2.ForeColor = Color.FromArgb(237, 255, 255)
            Bowl3.ForeColor = Color.FromArgb(237, 255, 255)
            SubTotalBox.ForeColor = Color.FromArgb(237, 255, 255)
        End If
    End Sub

End Class
