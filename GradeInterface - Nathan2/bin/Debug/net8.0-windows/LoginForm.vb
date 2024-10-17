Public Class LoginForm
    Dim counter As Integer = 3

    Public logged As Boolean
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButtonForm.Click

        If (usernameTextBoxForm.Text.Equals("Nathan") And passwordTextBoxForm.Text.Equals("Martinez")) Then
            MessageBox.Show("Login Success!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

            GradeInterface.gradesMenu.Enabled = True
            GradeInterface.showGradeForm()
            Close()
        ElseIf counter = 0 Then
            MessageBox.Show("Login Failed. Max Attempt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        Else
            MessageBox.Show("Login Failed. Try Again. Attempt: " & counter, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            counter = counter - 1
        End If
    End Sub

End Class
