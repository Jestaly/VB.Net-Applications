﻿Public Class LoginForm
    Dim counter As Integer = 3
    Private Sub usernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles usernameTextBoxForm.TextChanged

    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButtonForm.Click

        If (usernameTextBoxForm.Text.Equals("Jestaly") And passwordTextBoxForm.Text.Equals("Castillo")) Then
            MessageBox.Show("Login Success!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf counter = 0 Then
            MessageBox.Show("Login Failed. Max Attempt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        Else
            MessageBox.Show("Login Failed. Try Again. Attempt: " & counter, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            counter = counter - 1
        End If
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButtonForm.Click
        End
    End Sub
End Class