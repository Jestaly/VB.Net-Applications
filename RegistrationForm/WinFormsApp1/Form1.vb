Public Class Form1

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click

        If (userName.Text.Length < 5 Or userName.Text.Length > 15) Then
            MessageBox.Show("Error, Username should range from 5 to 15 Characters.")

        End If
        If (password.Text.Length < 8 Or password.Text.Length > 16) Then
            MessageBox.Show("Error, Password should range from 8 to 16 Characters.")
        End If
        If (Not (confirmPassword.Text.Equals(password.Text))) Then
            MessageBox.Show("Error, Password not matching.")
        End If
        If (userName.Text.Length >= 5 And userName.Text.Length <= 15 And
            password.Text.Length >= 8 And password.Text.Length <= 16 And
            confirmPassword.Text.Equals(password.Text)) Then
            panel1.Visible = False
            panel2.Visible = True
        End If

    End Sub

    Private Sub nextButton2_Click(sender As Object, e As EventArgs) Handles nextButton2.Click

        If (Not (surname.Text.Length >= 1 And surname.Text.Length <= 20 And givenName.Text.Length >= 1 And
            surname.Text.Length <= 20 And middleName.Text.Length >= 1 And middleName.Text.Length <= 20 And
            extensionName.Text.Length >= 1 And extensionName.Text.Length <= 20 And
            areaName.Text.Length >= 1 And areaName.Text.Length <= 20 And streetName.Text.Length >= 1 And
            streetName.Text.Length <= 20 And barangayName.Text.Length >= 1 And barangayName.Text.Length <= 20 And
            cityName.Text.Length >= 1 And cityName.Text.Length <= 20)) Then
            MessageBox.Show("Error, some fields are invalid.")
        Else
            panel2.Visible = False
            panel3.Visible = True
        End If

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        panel2.Visible = False
        panel1.Visible = True
    End Sub

    Private Sub backButton2_Click(sender As Object, e As EventArgs) Handles backButton2.Click
        panel3.Visible = False
        panel2.Visible = True
    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        If (Not (phoneNumberName.Text.Length = 11)) Then
            MessageBox.Show("Error, Phone format invalid.")
        ElseIf (Not (emailName.Text.Contains("@")) And emailName.Text.Equals("")) Then
            MessageBox.Show("Error, Invalid email.")
        Else
            MessageBox.Show("Success.")
            End
        End If


    End Sub

End Class
