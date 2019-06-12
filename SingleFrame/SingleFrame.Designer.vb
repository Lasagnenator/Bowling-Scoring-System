<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SingleFrame
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
        Me.Bowl2 = New System.Windows.Forms.RichTextBox()
        Me.Bowl1 = New System.Windows.Forms.RichTextBox()
        Me.SubTotalBox = New System.Windows.Forms.RichTextBox()
        Me.Bowl3 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Bowl2
        '
        Me.Bowl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bowl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Bowl2.Location = New System.Drawing.Point(35, 0)
        Me.Bowl2.Name = "Bowl2"
        Me.Bowl2.ReadOnly = True
        Me.Bowl2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Bowl2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Bowl2.Size = New System.Drawing.Size(41, 52)
        Me.Bowl2.TabIndex = 1
        Me.Bowl2.Text = ""
        '
        'Bowl1
        '
        Me.Bowl1.BackColor = System.Drawing.SystemColors.Control
        Me.Bowl1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Bowl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Bowl1.Location = New System.Drawing.Point(-1, 3)
        Me.Bowl1.Name = "Bowl1"
        Me.Bowl1.ReadOnly = True
        Me.Bowl1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Bowl1.Size = New System.Drawing.Size(41, 52)
        Me.Bowl1.TabIndex = 2
        Me.Bowl1.Text = ""
        '
        'SubTotalBox
        '
        Me.SubTotalBox.BackColor = System.Drawing.SystemColors.Control
        Me.SubTotalBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SubTotalBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.SubTotalBox.Location = New System.Drawing.Point(35, 49)
        Me.SubTotalBox.Name = "SubTotalBox"
        Me.SubTotalBox.ReadOnly = True
        Me.SubTotalBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.SubTotalBox.Size = New System.Drawing.Size(41, 52)
        Me.SubTotalBox.TabIndex = 3
        Me.SubTotalBox.Text = ""
        '
        'Bowl3
        '
        Me.Bowl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bowl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Bowl3.Location = New System.Drawing.Point(57, 0)
        Me.Bowl3.Name = "Bowl3"
        Me.Bowl3.ReadOnly = True
        Me.Bowl3.Size = New System.Drawing.Size(22, 52)
        Me.Bowl3.TabIndex = 4
        Me.Bowl3.Text = ""
        '
        'SingleFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Bowl3)
        Me.Controls.Add(Me.Bowl2)
        Me.Controls.Add(Me.Bowl1)
        Me.Controls.Add(Me.SubTotalBox)
        Me.Name = "SingleFrame"
        Me.Size = New System.Drawing.Size(78, 100)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bowl2 As RichTextBox
    Friend WithEvents Bowl1 As RichTextBox
    Friend WithEvents SubTotalBox As RichTextBox
    Friend WithEvents Bowl3 As RichTextBox
End Class
