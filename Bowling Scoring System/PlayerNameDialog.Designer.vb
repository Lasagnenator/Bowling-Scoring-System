<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerNameDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.P1NameBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.P2NameBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.P3NameBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.P4NameBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(346, 520)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(6)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(180, 71)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Player 1 Name"
        '
        'P1NameBox
        '
        Me.P1NameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P1NameBox.Location = New System.Drawing.Point(383, 126)
        Me.P1NameBox.MaxLength = 30
        Me.P1NameBox.Name = "P1NameBox"
        Me.P1NameBox.Size = New System.Drawing.Size(428, 44)
        Me.P1NameBox.TabIndex = 1
        Me.P1NameBox.Text = "Player 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(313, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 42)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Player Names"
        '
        'P2NameBox
        '
        Me.P2NameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2NameBox.Location = New System.Drawing.Point(383, 201)
        Me.P2NameBox.MaxLength = 30
        Me.P2NameBox.Name = "P2NameBox"
        Me.P2NameBox.Size = New System.Drawing.Size(428, 44)
        Me.P2NameBox.TabIndex = 4
        Me.P2NameBox.Text = "Player 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(103, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 37)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Player 2 Name"
        '
        'P3NameBox
        '
        Me.P3NameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P3NameBox.Location = New System.Drawing.Point(383, 273)
        Me.P3NameBox.MaxLength = 30
        Me.P3NameBox.Name = "P3NameBox"
        Me.P3NameBox.Size = New System.Drawing.Size(428, 44)
        Me.P3NameBox.TabIndex = 6
        Me.P3NameBox.Text = "Player 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 37)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Player 3 Name"
        '
        'P4NameBox
        '
        Me.P4NameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P4NameBox.Location = New System.Drawing.Point(383, 341)
        Me.P4NameBox.MaxLength = 30
        Me.P4NameBox.Name = "P4NameBox"
        Me.P4NameBox.Size = New System.Drawing.Size(428, 44)
        Me.P4NameBox.TabIndex = 8
        Me.P4NameBox.Text = "Player 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(103, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(228, 37)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Player 4 Name"
        '
        'PlayerNameDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(870, 606)
        Me.Controls.Add(Me.P4NameBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.P3NameBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.P2NameBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.P1NameBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OK_Button)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PlayerNameDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Names of players"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents P1NameBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents P2NameBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents P3NameBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents P4NameBox As TextBox
    Friend WithEvents Label5 As Label
End Class
