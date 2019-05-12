Imports System.Windows.Forms

Public Class PlayerNumDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If PlayerNumbers.SelectedIndex.Equals(-1) Then
            MessageBox.Show("You must select a value from the drop-down list!", "Error")
            Return
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Form1.MakePanels(PlayerNumbers.SelectedIndex + 1)
        Form1.TotalPlayers = PlayerNumbers.SelectedIndex + 1
        Me.Close()
    End Sub

End Class
