Imports System.Net.Http.Headers

Public Class HelpPage
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Form1.Show()
        'This hides the help page and goes to the home page
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        If MessageBox.Show("Are you sure you want to exit program?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            'This shows a message box to confirm if the user wants to close the program
            Me.Close()
            'This eventually closes the programme if yes is clicked
        End If
    End Sub
End Class