Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        userName.Visible = False
        password.Visible = False
        confirmPassword.Visible = False
        nextButton.Visible = False
        usernameLabel.Visible = False
        passwordLabel.Visible = False
        confirmPasswordLabel.Visible = False

        surnameLabel.Visible = True
        givenNameLabel.Visible = True
        middleNameLabel.Visible = True
        extensionNameLabel.Visible = True
        unitLabel.Visible = True
        streetLabel.Visible = True
        areaLabel.Visible = True
        barangayLabel.Visible = True
        cityLabel.Visible = True

        surname.Visible = True
        givenName.Visible = True
        middleName.Visible = True
        extensionName.Visible = True
        unitName.Visible = True
        streetName.Visible = True
        areaName.Visible = True
        barangayName.Visible = True
        cityName.Visible = True
        nextButton2.Visible = True
        backButton.Visible = True
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub nextButton2_Click(sender As Object, e As EventArgs) Handles nextButton2.Click
        surnameLabel.Visible = False
        givenNameLabel.Visible = False
        middleNameLabel.Visible = False
        extensionNameLabel.Visible = False
        unitLabel.Visible = False
        streetLabel.Visible = False
        areaLabel.Visible = False
        barangayLabel.Visible = False
        cityLabel.Visible = False

        surname.Visible = False
        givenName.Visible = False
        middleName.Visible = False
        extensionName.Visible = False
        unitName.Visible = False
        streetName.Visible = False
        areaName.Visible = False
        barangayName.Visible = False
        cityName.Visible = False
        nextButton2.Visible = False
        backButton.Visible = False

        genderRadioButton.Visible = True
        phoneNumberLabel.Visible = True
        phoneNumberName.Visible = True
        emailLabel.Visible = True
        emailName.Visible = True
        birtday.Visible = True
        confirmButton.Visible = True
        backButton2.Visible = True

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        surnameLabel.Visible = False
        givenNameLabel.Visible = False
        middleNameLabel.Visible = False
        extensionNameLabel.Visible = False
        unitLabel.Visible = False
        streetLabel.Visible = False
        areaLabel.Visible = False
        barangayLabel.Visible = False
        cityLabel.Visible = False

        surname.Visible = False
        givenName.Visible = False
        middleName.Visible = False
        extensionName.Visible = False
        unitName.Visible = False
        streetName.Visible = False
        areaName.Visible = False
        barangayName.Visible = False
        cityName.Visible = False
        nextButton2.Visible = False
        backButton.Visible = False

        userName.Visible = True
        password.Visible = True
        confirmPassword.Visible = True
        nextButton.Visible = True
        usernameLabel.Visible = True
        passwordLabel.Visible = True
        confirmPasswordLabel.Visible = True
    End Sub

    Private Sub backButton2_Click(sender As Object, e As EventArgs) Handles backButton2.Click
        surnameLabel.Visible = True
        givenNameLabel.Visible = True
        middleNameLabel.Visible = True
        extensionNameLabel.Visible = True
        unitLabel.Visible = True
        streetLabel.Visible = True
        areaLabel.Visible = True
        barangayLabel.Visible = True
        cityLabel.Visible = True

        surname.Visible = True
        givenName.Visible = True
        middleName.Visible = True
        extensionName.Visible = True
        unitName.Visible = True
        streetName.Visible = True
        areaName.Visible = True
        barangayName.Visible = True
        cityName.Visible = True
        nextButton2.Visible = True
        backButton.Visible = True

        genderRadioButton.Visible = False
        phoneNumberLabel.Visible = False
        phoneNumberName.Visible = False
        emailLabel.Visible = False
        emailName.Visible = False
        birtday.Visible = False
        confirmButton.Visible = False
        backButton2.Visible = False
    End Sub

    Private Sub userName_TextChanged(sender As Object, e As EventArgs) Handles userName.TextChanged

    End Sub

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click
        If (userName.Text.Length > 15) Then
            MessageBox.Show("Error, User Name should atleast 20 chacaracters.")
        End If
        If (password.Text.Length > 9) Then
            MessageBox.Show("Error, Password should atleast 8 chacaracters.")
        End If
        If (Not (confirmPassword.Text.Equals(password.Text))) Then
            MessageBox.Show("Error, Password not matching.")
        End If
        If (surname.Text.Length > 20) Then
            MessageBox.Show("Error, Surname should atleast 20 chacaracters.")
        End If
        If (givenName.Text.Length > 20) Then
            MessageBox.Show("Error, Given name should atleast 20 chacaracters.")
        End If
        If (middleName.Text.Length > 20) Then
            MessageBox.Show("Error, Middle name should atleast 20 chacaracters.")
        End If
        If (userName.Text.Length > 20) Then
            MessageBox.Show("Error, User name should atleast 20 chacaracters.")
        End If
        If (userName.Text.Length > 5) Then
            MessageBox.Show("Error, Extension name should atleast 20 chacaracters.")
        End If
        If (userName.Text.Length > 20) Then
            MessageBox.Show("Error, User Name should atleast 20 chacaracters.")
        End If
        If (streetName.Text.Equals("") Or barangayName.Text.Equals("") Or cityName.Text.Equals("") Or userName.Text.Equals("") Or password.Text.Equals("") Or confirmButton.Text.Equals("") Or surname.Text.Equals("") Or givenName.Text.Equals("") Or middleName.Text.Equals("") Or extensionName.Text.Equals("") Or areaName.Text.Equals("") Or unitName.Text.Equals("")) Then
            MessageBox.Show("Error, Fill up the Text Fields.")
        End If
        Try

        Catch ex As Exception
            MessageBox.Show("Unit Field should be  an Integer.")
        End Try
    End Sub
End Class
