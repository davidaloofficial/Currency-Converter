Public Class Form2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.Money_Coin_Sound_Effect, AudioPlayMode.Background)
        Dim Result As Decimal
        If TextBox_From.Text = "" Or ComboBox_From.Text = "" Or ComboBox_To.Text = "" Then
            MessageBox.Show("Please input all required values.", "Error")
            'This pops up if any of the value is blank.
        End If


        Try
            If ComboBox_From.Text = "GBP" And ComboBox_To.Text = "EUR" Then
                Result = CDec(TextBox_From.Text) * GBPEURPrate
                Lbl_Result.Text = "Result = " & Result.ToString("0.## ") & "EUR (1 GBP = " & GBPEURPrate & " EUR)"

            End If

            If ComboBox_From.Text = "EUR" And ComboBox_To.Text = "GBP" Then
                Result = CDec(TextBox_From.Text) / GBPEURPrate
                Lbl_Result.Text = "Result = " & Result.ToString("0.## ") & "GBP (1 GBP = " & GBPEURPrate & " EUR)"

            End If

            If ComboBox_From.Text = "GBP" And ComboBox_To.Text = "USD" Then
                Result = CDec(TextBox_From.Text) * GBPUSDrate
                Lbl_Result.Text = "Result = " & Result.ToString("0.## ") & "USD (1 GBP = " & GBPUSDrate & " USD)"
            End If

            If ComboBox_From.Text = "USD" And ComboBox_To.Text = "GBP" Then
                Result = CDec(TextBox_From.Text) / GBPUSDrate
                Lbl_Result.Text = "Result = " & Result.ToString("0.## ") & "GBP (1 GBP = " & GBPUSDrate & " USD)"
            End If

            If ComboBox_From.Text = "USD" And ComboBox_To.Text = "EUR" Then
                Result = CDec(TextBox_From.Text) * USDEURrate
                Lbl_Result.Text = "Result = " & Result.ToString("0.## ") & "EUR (1 USD = " & USDEURrate & " EUR)"
            End If

            If ComboBox_From.Text = "EUR" And ComboBox_To.Text = "USD" Then
                Result = CDec(TextBox_From.Text) / USDEURrate
                Lbl_Result.Text = "Result = " & Result.ToString("0.## ") & "USD (1 USD = " & USDEURrate & " EUR)"
            End If

            If ComboBox_From.Text = ComboBox_To.Text Then
                Lbl_Result.Text = "No Conversion Required, You might aswell convert to a different currency"
            End If
        Catch ex As Exception

            MessageBox.Show("Please input numbers.", "Error")
            'This shows an error message if there is an error
        End Try
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        Lbl_Result.Text = " "
        TextBox_From.Text = " "
        ComboBox_From.Text = -1
        ComboBox_To.Text = -1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn_Update_Rate.Click
        Me.Hide()
        Form1.Show()
        'This closes the current page and goes to the Home Page
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        If MessageBox.Show("Are you sure you want to exit program?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


End Class