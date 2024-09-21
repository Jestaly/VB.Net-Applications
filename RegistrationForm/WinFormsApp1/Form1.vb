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
        If (surname.Text.Length < 1 Or surname.Text.Length > 20) Then
            MessageBox.Show("Error, Surname should range from 1 to 20 Characters.")
        End If
        If (givenName.Text.Length < 1 Or surname.Text.Length > 20) Then
            MessageBox.Show("Error, Given name should range from 1 to 20 Characters.")
        End If
        If (middleName.Text.Length < 1 Or middleName.Text.Length > 20) Then
            MessageBox.Show("Error, Middle name should range from 1 to 20 Characters.")
        End If
        If (extensionName.Text.Length < 1 Or extensionName.Text.Length > 20) Then
            MessageBox.Show("Error, Extension name should range from 1 to 20 Characters.")
        End If
        If (areaName.Text.Length < 1 Or areaName.Text.Length > 20) Then
            MessageBox.Show("Error, Area should range from 1 to 20 Characters.")
        End If
        If (streetName.Text.Length < 1 Or streetName.Text.Length > 20) Then
            MessageBox.Show("Error, Street should range from 1 to 20 Characters.")
        End If
        If (barangayName.Text.Length < 1 Or barangayName.Text.Length > 20) Then
            MessageBox.Show("Error, Barangay should range from 1 to 20 Characters.")
        End If
        If (cityName.Text.Length < 1 Or cityName.Text.Length > 20) Then
            MessageBox.Show("Error, City should range from 1 to 20 Characters.")
        End If
        If (surname.Text.Length >= 1 And surname.Text.Length <= 20 And givenName.Text.Length >= 1 And
            surname.Text.Length <= 20 And middleName.Text.Length >= 1 And middleName.Text.Length <= 20 And
            extensionName.Text.Length >= 1 And extensionName.Text.Length <= 20 And
            areaName.Text.Length >= 1 And areaName.Text.Length <= 20 And streetName.Text.Length >= 1 And
            streetName.Text.Length <= 20 And barangayName.Text.Length >= 1 And barangayName.Text.Length <= 20 And
            cityName.Text.Length >= 1 And cityName.Text.Length <= 20) Then
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

    End Sub

End Class
