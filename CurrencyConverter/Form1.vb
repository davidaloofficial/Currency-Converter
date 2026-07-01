Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_Start.Click
        'This will show a message if a user input wrong value
        Try
            GBPEURPrate = CDec(TextBox_GBPEUR.Text)
            GBPUSDrate = CDec(TextBox_GBPUSD.Text)
            USDEURrate = CDec(TextBox_USDEUR.Text)
            Me.Hide()
            Form2.Show()
            'If there are no problem it will open form 2
        Catch ex As Exception
            MessageBox.Show("Please Input Numbers.", "Error!")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox_Help.Click
        Me.Hide()
        Form3.Show()
    End Sub
End Class
