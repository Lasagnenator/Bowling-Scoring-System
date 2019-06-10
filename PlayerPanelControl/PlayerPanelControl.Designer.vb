<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlayerPanelControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MainGroupBox = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TotalScoreBox = New System.Windows.Forms.RichTextBox()
        Me.F1 = New SingleFrame.SingleFrame()
        Me.F2 = New SingleFrame.SingleFrame()
        Me.F3 = New SingleFrame.SingleFrame()
        Me.F4 = New SingleFrame.SingleFrame()
        Me.F5 = New SingleFrame.SingleFrame()
        Me.F6 = New SingleFrame.SingleFrame()
        Me.F7 = New SingleFrame.SingleFrame()
        Me.F8 = New SingleFrame.SingleFrame()
        Me.F9 = New SingleFrame.SingleFrame()
        Me.F10 = New SingleFrame.SingleFrame()
        Me.MainGroupBox.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainGroupBox
        '
        Me.MainGroupBox.AutoSize = True
        Me.MainGroupBox.Controls.Add(Me.TableLayoutPanel1)
        Me.MainGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainGroupBox.Location = New System.Drawing.Point(8, 8)
        Me.MainGroupBox.Name = "MainGroupBox"
        Me.MainGroupBox.Size = New System.Drawing.Size(947, 166)
        Me.MainGroupBox.TabIndex = 1
        Me.MainGroupBox.TabStop = False
        Me.MainGroupBox.Text = "GroupBox1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 11
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.Controls.Add(Me.F1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.F2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.F3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.F4, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.F5, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.F6, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.F7, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.F8, 7, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.F9, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TotalScoreBox, 10, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.F10, 9, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 30)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(935, 106)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TotalScoreBox
        '
        Me.TotalScoreBox.Location = New System.Drawing.Point(843, 3)
        Me.TotalScoreBox.Name = "TotalScoreBox"
        Me.TotalScoreBox.ReadOnly = True
        Me.TotalScoreBox.Size = New System.Drawing.Size(76, 100)
        Me.TotalScoreBox.TabIndex = 9
        Me.TotalScoreBox.Text = ""
        '
        'F1
        '
        Me.F1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.F1.IsFrame10Visible = False
        Me.F1.Location = New System.Drawing.Point(3, 3)
        Me.F1.Name = "F1"
        Me.F1.Scores = New String() {Nothing, Nothing}
        Me.F1.Size = New System.Drawing.Size(76, 100)
        Me.F1.SubTotal = ""
        Me.F1.TabIndex = 0
        '
        'F2
        '
        Me.F2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.F2.IsFrame10Visible = False
        Me.F2.Location = New System.Drawing.Point(87, 3)
        Me.F2.Name = "F2"
        Me.F2.Scores = New String() {Nothing, Nothing}
        Me.F2.Size = New System.Drawing.Size(76, 100)
        Me.F2.SubTotal = ""
        Me.F2.TabIndex = 1
        '
        'F3
        '
        Me.F3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.F3.IsFrame10Visible = False
        Me.F3.Location = New System.Drawing.Point(171, 3)
        Me.F3.Name = "F3"
        Me.F3.Scores = New String() {Nothing, Nothing}
        Me.F3.Size = New System.Drawing.Size(76, 100)
        Me.F3.SubTotal = ""
        Me.F3.TabIndex = 2
        '
        'F4
        '
        Me.F4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.F4.IsFrame10Visible = False
        Me.F4.Location = New System.Drawing.Point(255, 3)
        Me.F4.Name = "F4"
        Me.F4.Scores = New String() {Nothing, Nothing}
        Me.F4.Size = New System.Drawing.Size(76, 100)
        Me.F4.SubTotal = ""
        Me.F4.TabIndex = 3
        '
        'F5
        '
        Me.F5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.F5.IsFrame10Visible = False
        Me.F5.Location = New System.Drawing.Point(339, 3)
        Me.F5.Name = "F5"
        Me.F5.Scores = New String() {Nothing, Nothing}
        Me.F5.Size = New System.Drawing.Size(76, 100)
        Me.F5.SubTotal = ""
        Me.F5.TabIndex = 4
        '
        'F6
        '
        Me.F6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.F6.IsFrame10Visible = False
        Me.F6.Location = New System.Drawing.Point(423, 3)
        Me.F6.Name = "F6"
        Me.F6.Scores = New String() {Nothing, Nothing}
        Me.F6.Size = New System.Drawing.Size(76, 100)
        Me.F6.SubTotal = ""
        Me.F6.TabIndex = 5
        '
        'F7
        '
        Me.F7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.F7.IsFrame10Visible = False
        Me.F7.Location = New System.Drawing.Point(507, 3)
        Me.F7.Name = "F7"
        Me.F7.Scores = New String() {Nothing, Nothing}
        Me.F7.Size = New System.Drawing.Size(76, 100)
        Me.F7.SubTotal = ""
        Me.F7.TabIndex = 6
        '
        'F8
        '
        Me.F8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.F8.IsFrame10Visible = False
        Me.F8.Location = New System.Drawing.Point(591, 3)
        Me.F8.Name = "F8"
        Me.F8.Scores = New String() {Nothing, Nothing}
        Me.F8.Size = New System.Drawing.Size(76, 100)
        Me.F8.SubTotal = ""
        Me.F8.TabIndex = 7
        '
        'F9
        '
        Me.F9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.F9.IsFrame10Visible = False
        Me.F9.Location = New System.Drawing.Point(675, 3)
        Me.F9.Name = "F9"
        Me.F9.Scores = New String() {Nothing, Nothing}
        Me.F9.Size = New System.Drawing.Size(76, 100)
        Me.F9.SubTotal = ""
        Me.F9.TabIndex = 8
        '
        'F10
        '
        Me.F10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.F10.IsFrame10Visible = True
        Me.F10.Location = New System.Drawing.Point(759, 3)
        Me.F10.Name = "F10"
        Me.F10.Scores = New String() {Nothing, Nothing, Nothing}
        Me.F10.Size = New System.Drawing.Size(77, 100)
        Me.F10.SubTotal = Nothing
        Me.F10.TabIndex = 10
        '
        'PlayerPanelControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MainGroupBox)
        Me.Name = "PlayerPanelControl"
        Me.Size = New System.Drawing.Size(966, 180)
        Me.MainGroupBox.ResumeLayout(False)
        Me.MainGroupBox.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainGroupBox As Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents F1 As SingleFrame.SingleFrame
    Friend WithEvents F2 As SingleFrame.SingleFrame
    Friend WithEvents F3 As SingleFrame.SingleFrame
    Friend WithEvents F4 As SingleFrame.SingleFrame
    Friend WithEvents F5 As SingleFrame.SingleFrame
    Friend WithEvents F6 As SingleFrame.SingleFrame
    Friend WithEvents F7 As SingleFrame.SingleFrame
    Friend WithEvents F8 As SingleFrame.SingleFrame
    Friend WithEvents F9 As SingleFrame.SingleFrame
    Friend WithEvents TotalScoreBox As Windows.Forms.RichTextBox
    Friend WithEvents F10 As SingleFrame.SingleFrame
End Class
