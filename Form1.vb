Public Class Form1


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_Start.Click
        My.Computer.Audio.Play(My.Resources.CoinWav, AudioPlayMode.Background)
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
            My.Computer.Audio.Play(My.Resources.buzzer_or_wrong_WAV, AudioPlayMode.Background)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox_Help.Click
        Me.Hide()
        HelpPage.Show()
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        If MessageBox.Show("Are you sure you want to exit program?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Welcome2_Wav, AudioPlayMode.Background)
    End Sub
End Class
