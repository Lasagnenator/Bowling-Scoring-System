Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayerNumDialog.ShowDialog()
    End Sub
    Public Sub MakePanels(num As Integer)
        For index = 0 To num - 1
            PlayerPanels(index) = New System.Windows.Forms.Panel() With {
                .BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch,
                .BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                .Location = New System.Drawing.Point(13, 107 * index + 13),
                .Name = "Player" + Convert.ToString(index),
                .Size = New System.Drawing.Size(949, 100)
            }
            PlayerPanels(index).Controls.Add(TestTextBox)
            Me.Controls.Add(PlayerPanels(index))
        Next
    End Sub
    Friend PlayerPanels As Panel()
    Friend WithEvents TestTextBox As TextBox = New System.Windows.Forms.TextBox() With {
            .Location = New System.Drawing.Point(25, 35),
            .Name = "TextboxA",
            .Size = New System.Drawing.Size(100, 31)
        }
End Class
