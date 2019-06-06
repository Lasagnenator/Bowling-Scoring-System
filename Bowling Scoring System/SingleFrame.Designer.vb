<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SingleFrame
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
        Me.Bowl2 = New System.Windows.Forms.RichTextBox()
        Me.Bowl1 = New System.Windows.Forms.RichTextBox()
        Me.SubTotal = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Bowl2
        '
        Me.Bowl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bowl2.Location = New System.Drawing.Point(49, 0)
        Me.Bowl2.Name = "Bowl2"
        Me.Bowl2.ReadOnly = True
        Me.Bowl2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Bowl2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Bowl2.Size = New System.Drawing.Size(50, 50)
        Me.Bowl2.TabIndex = 1
        Me.Bowl2.Text = ""
        '
        'Bowl1
        '
        Me.Bowl1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Bowl1.Location = New System.Drawing.Point(-1, 0)
        Me.Bowl1.Name = "Bowl1"
        Me.Bowl1.ReadOnly = True
        Me.Bowl1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Bowl1.Size = New System.Drawing.Size(50, 50)
        Me.Bowl1.TabIndex = 2
        Me.Bowl1.Text = ""
        '
        'SubTotal
        '
        Me.SubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SubTotal.Location = New System.Drawing.Point(49, 50)
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        Me.SubTotal.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.SubTotal.Size = New System.Drawing.Size(50, 50)
        Me.SubTotal.TabIndex = 3
        Me.SubTotal.Text = ""
        '
        'SingleFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Bowl2)
        Me.Controls.Add(Me.SubTotal)
        Me.Controls.Add(Me.Bowl1)
        Me.Name = "SingleFrame"
        Me.Size = New System.Drawing.Size(98, 98)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bowl2 As RichTextBox
    Friend WithEvents Bowl1 As RichTextBox
    Friend WithEvents SubTotal As RichTextBox
End Class
