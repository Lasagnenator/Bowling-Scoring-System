Imports System.Windows.Forms

Public Class PlayerNumDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Form1.MakePanels(PlayerNumbers.SelectedIndex + 1)
        Me.Close()
    End Sub

End Class
