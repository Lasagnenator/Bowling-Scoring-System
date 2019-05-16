<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerPanelControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MainGroupBox = New System.Windows.Forms.GroupBox()
        Me.Bowl1 = New System.Windows.Forms.TextBox()
        Me.MainGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainGroupBox
        '
        Me.MainGroupBox.Controls.Add(Me.Bowl1)
        Me.MainGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.MainGroupBox.Name = "MainGroupBox"
        Me.MainGroupBox.Size = New System.Drawing.Size(1133, 151)
        Me.MainGroupBox.TabIndex = 0
        Me.MainGroupBox.TabStop = False
        Me.MainGroupBox.Text = "GroupBox1"
        '
        'Bowl1
        '
        Me.Bowl1.Location = New System.Drawing.Point(7, 31)
        Me.Bowl1.Name = "Bowl1"
        Me.Bowl1.Size = New System.Drawing.Size(38, 31)
        Me.Bowl1.TabIndex = 0
        '
        'PlayerPanelControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MainGroupBox)
        Me.Name = "PlayerPanelControl"
        Me.Size = New System.Drawing.Size(1133, 151)
        Me.MainGroupBox.ResumeLayout(False)
        Me.MainGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainGroupBox As GroupBox
    Friend WithEvents Bowl1 As TextBox
End Class
