<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_From = New System.Windows.Forms.TextBox()
        Me.ComboBox_From = New System.Windows.Forms.ComboBox()
        Me.ComboBox_To = New System.Windows.Forms.ComboBox()
        Me.TextBox_To = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DAVID's CURRENCY CONVERTER"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(433, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 38)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "logo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "AMOUNT CURRENCY"
        '
        'TextBox_From
        '
        Me.TextBox_From.Location = New System.Drawing.Point(322, 80)
        Me.TextBox_From.Name = "TextBox_From"
        Me.TextBox_From.Size = New System.Drawing.Size(115, 31)
        Me.TextBox_From.TabIndex = 14
        '
        'ComboBox_From
        '
        Me.ComboBox_From.FormattingEnabled = True
        Me.ComboBox_From.Items.AddRange(New Object() {"GBP", "EUR", "USD"})
        Me.ComboBox_From.Location = New System.Drawing.Point(322, 128)
        Me.ComboBox_From.Name = "ComboBox_From"
        Me.ComboBox_From.Size = New System.Drawing.Size(121, 33)
        Me.ComboBox_From.TabIndex = 15
        '
        'ComboBox_To
        '
        Me.ComboBox_To.FormattingEnabled = True
        Me.ComboBox_To.Items.AddRange(New Object() {"GBP", "EUR", "USD"})
        Me.ComboBox_To.Location = New System.Drawing.Point(322, 263)
        Me.ComboBox_To.Name = "ComboBox_To"
        Me.ComboBox_To.Size = New System.Drawing.Size(121, 33)
        Me.ComboBox_To.TabIndex = 18
        '
        'TextBox_To
        '
        Me.TextBox_To.Location = New System.Drawing.Point(322, 215)
        Me.TextBox_To.Name = "TextBox_To"
        Me.TextBox_To.Size = New System.Drawing.Size(115, 31)
        Me.TextBox_To.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 221)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "CURRENCY EQUIVALENT"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(51, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(176, 38)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "CONVERT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(322, 371)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 38)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(322, 313)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(148, 38)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "CLEAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(51, 371)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(176, 38)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "UPDATE RATE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 444)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(343, 25)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Exchange Rate: 1 GBP = 1.20USD"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 478)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox_To)
        Me.Controls.Add(Me.TextBox_To)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox_From)
        Me.Controls.Add(Me.TextBox_From)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Page2of2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_From As TextBox
    Friend WithEvents ComboBox_From As ComboBox
    Friend WithEvents ComboBox_To As ComboBox
    Friend WithEvents TextBox_To As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label4 As Label
End Class
