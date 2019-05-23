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
        Me.F1 = New System.Windows.Forms.RichTextBox()
        Me.Subtotal1 = New System.Windows.Forms.RichTextBox()
        Me.Total = New System.Windows.Forms.RichTextBox()
        Me.MainGroupBox.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainGroupBox
        '
        Me.MainGroupBox.Controls.Add(Me.TableLayoutPanel1)
        Me.MainGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.MainGroupBox.Name = "MainGroupBox"
        Me.MainGroupBox.Size = New System.Drawing.Size(1133, 151)
        Me.MainGroupBox.TabIndex = 0
        Me.MainGroupBox.TabStop = False
        Me.MainGroupBox.Text = "GroupBox1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 11
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090908!))
        Me.TableLayoutPanel1.Controls.Add(Me.F1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Subtotal1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Total, 10, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1123, 100)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'F1
        '
        Me.F1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.F1.Location = New System.Drawing.Point(3, 3)
        Me.F1.Name = "F1"
        Me.F1.ReadOnly = True
        Me.F1.Size = New System.Drawing.Size(96, 44)
        Me.F1.TabIndex = 0
        Me.F1.Text = ""
        '
        'Subtotal1
        '
        Me.Subtotal1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Subtotal1.Location = New System.Drawing.Point(3, 53)
        Me.Subtotal1.Name = "Subtotal1"
        Me.Subtotal1.ReadOnly = True
        Me.Subtotal1.Size = New System.Drawing.Size(96, 44)
        Me.Subtotal1.TabIndex = 1
        Me.Subtotal1.Text = ""
        '
        'Total
        '
        Me.Total.Location = New System.Drawing.Point(1023, 3)
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.TableLayoutPanel1.SetRowSpan(Me.Total, 2)
        Me.Total.Size = New System.Drawing.Size(97, 94)
        Me.Total.TabIndex = 2
        Me.Total.Text = ""
        '
        'PlayerPanelControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MainGroupBox)
        Me.Name = "PlayerPanelControl"
        Me.Size = New System.Drawing.Size(1133, 151)
        Me.MainGroupBox.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MainGroupBox As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents F1 As RichTextBox
    Friend WithEvents Subtotal1 As RichTextBox
    Friend WithEvents Total As RichTextBox
End Class
