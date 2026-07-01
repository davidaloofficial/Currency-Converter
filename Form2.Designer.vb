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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_From = New System.Windows.Forms.TextBox()
        Me.ComboBox_From = New System.Windows.Forms.ComboBox()
        Me.ComboBox_To = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Btn_Update_Rate = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Lbl_Result = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 25)
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
        Me.Label2.Size = New System.Drawing.Size(343, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "AMOUNT && SOURCE CURRENCY"
        '
        'TextBox_From
        '
        Me.TextBox_From.Location = New System.Drawing.Point(354, 83)
        Me.TextBox_From.Name = "TextBox_From"
        Me.TextBox_From.Size = New System.Drawing.Size(89, 31)
        Me.TextBox_From.TabIndex = 14
        '
        'ComboBox_From
        '
        Me.ComboBox_From.FormattingEnabled = True
        Me.ComboBox_From.Items.AddRange(New Object() {"GBP", "EUR", "USD"})
        Me.ComboBox_From.Location = New System.Drawing.Point(354, 120)
        Me.ComboBox_From.Name = "ComboBox_From"
        Me.ComboBox_From.Size = New System.Drawing.Size(89, 33)
        Me.ComboBox_From.TabIndex = 15
        '
        'ComboBox_To
        '
        Me.ComboBox_To.FormattingEnabled = True
        Me.ComboBox_To.Items.AddRange(New Object() {"GBP", "EUR", "USD"})
        Me.ComboBox_To.Location = New System.Drawing.Point(354, 213)
        Me.ComboBox_To.Name = "ComboBox_To"
        Me.ComboBox_To.Size = New System.Drawing.Size(89, 33)
        Me.ComboBox_To.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 221)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(276, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "DESTINATION CURRENCY"
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
        'Btn_Exit
        '
        Me.Btn_Exit.Location = New System.Drawing.Point(322, 371)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(148, 38)
        Me.Btn_Exit.TabIndex = 20
        Me.Btn_Exit.Text = "EXIT"
        Me.Btn_Exit.UseVisualStyleBackColor = True
        '
        'Btn_Clear
        '
        Me.Btn_Clear.Location = New System.Drawing.Point(322, 313)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(148, 38)
        Me.Btn_Clear.TabIndex = 21
        Me.Btn_Clear.Text = "CLEAR"
        Me.Btn_Clear.UseVisualStyleBackColor = True
        '
        'Btn_Update_Rate
        '
        Me.Btn_Update_Rate.Location = New System.Drawing.Point(51, 371)
        Me.Btn_Update_Rate.Name = "Btn_Update_Rate"
        Me.Btn_Update_Rate.Size = New System.Drawing.Size(176, 38)
        Me.Btn_Update_Rate.TabIndex = 22
        Me.Btn_Update_Rate.Text = "UPDATE RATE"
        Me.Btn_Update_Rate.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(135, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Lbl_Result
        '
        Me.Lbl_Result.AutoSize = True
        Me.Lbl_Result.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Result.Location = New System.Drawing.Point(15, 264)
        Me.Lbl_Result.Name = "Lbl_Result"
        Me.Lbl_Result.Size = New System.Drawing.Size(0, 28)
        Me.Lbl_Result.TabIndex = 25
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 478)
        Me.Controls.Add(Me.Lbl_Result)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btn_Update_Rate)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox_To)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_From As TextBox
    Friend WithEvents ComboBox_From As ComboBox
    Friend WithEvents ComboBox_To As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Btn_Exit As Button
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents Btn_Update_Rate As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lbl_Result As Label
End Class
