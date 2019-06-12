Imports System.Windows.Forms

Public Class PlayerNameDialog
    Dim P1Edit = False
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Form1.PlayerPanel1.PlayerName = P1NameBox.Text
        Form1.PlayerPanel2.PlayerName = P2NameBox.Text
        Form1.PlayerPanel3.PlayerName = P3NameBox.Text
        Form1.PlayerPanel4.PlayerName = P4NameBox.Text
        Me.Close()
    End Sub

    Private Sub P1NameBox_Click(sender As Object, e As EventArgs) Handles P1NameBox.Click
        If P1NameBox.Text = "Player 1" Then

        End If
    End Sub
End Class
