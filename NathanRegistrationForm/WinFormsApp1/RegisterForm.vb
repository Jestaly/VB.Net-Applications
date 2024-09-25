Public Class Form1

    Private Sub confirmButton_Click(sender As Object, e As EventArgs) Handles confirmButton.Click

        Dim userNameError = False
        Dim passwordError = False
        Dim passwordMatchError = False
        Dim invalidMessage = ""

        Dim gender As String = ""
        Dim age As String
        Dim birthYear As String = ""
        Dim i As Integer

        If (userName.Text.Length < 1 Or userName.Text.Length > 15) Then
            invalidMessage += "Username should have 1 to 15 Characters."
            userNameError = True
        End If

        If (password.Text.Length < 6 Or password.Text.Length > 16) Then
            invalidMessage += vbCrLf & "Password should have 6 to 16 Characters."
            passwordError = True
        End If

        If (Not (confirmPassword.Text.Equals(password.Text))) Then
            invalidMessage += vbCrLf & "Password do not match."
            passwordMatchError = True
        End If

        If (userNameError = True Or passwordError = True Or passwordMatchError = True) Then
            MessageBox.Show(invalidMessage, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End If

        If (extensionName.Text.Equals("")) Then
            extensionName.Text = "None"
        End If

        If (areaName.Text.Equals("")) Then
            areaName.Text = "None"
        End If

        If (maleRadioButton.Checked = True) Then
            gender = maleRadioButton.Text

        ElseIf (femaleRadioButton.Checked = True) Then
            gender = femaleRadioButton.Text
        End If

        For i = 1 To 4 Step 1
            birthYear = String.Join("", birthYear, birthday.Text.Chars(birthday.Text.Length - 5 + i))
        Next

        age = Date.Today.Year - CInt(birthYear)

        If (Not (surname.Text.Equals("") Or surname.Text.Length > 20 Or givenName.Text.Equals("") Or
            givenName.Text.Length > 20 Or middleName.Text.Equals("") Or
            middleName.Text.Length > 20 Or extensionName.Text.Length > 20 Or
            areaName.Text.Length > 20 Or streetName.Text.Equals("") Or
            streetName.Text.Length > 20 Or barangayName.Text.Equals("") Or barangayName.Text.Length > 20 Or
            cityName.Text.Equals("") Or cityName.Text.Length > 20) And phoneNumberName.Text.Length = 12 And
            emailName.Text.Contains("@") And emailName.Text.Contains(".") And Not (gender.Equals("")) And
            userNameError = False And passwordError = False And passwordMatchError = False) Then

            MessageBox.Show("You are now registered.", "Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            MessageBox.Show("Username: " & userName.Text & vbCrLf &
                            "Password: " & password.Text & vbCrLf &
                            "Gender: " & gender & vbCrLf &
                            "Surname: " & surname.Text & vbCrLf &
                            "Given name: " & givenName.Text & vbCrLf &
                            "Middle name: " & middleName.Text & vbCrLf &
                            "Extension name: " & extensionName.Text & vbCrLf &
                            "Birthday: " & birthday.Text & vbCrLf &
                             "Age: " & age & " Years old" & vbCrLf &
                             "Email: " & emailName.Text & vbCrLf &
                             "Phone number: " & phoneNumberName.Text & vbCrLf &
                            "Unit/House number: " & unitName.Text & vbCrLf &
                            "Street: " & streetName.Text & vbCrLf &
                            "Area: " & areaName.Text & vbCrLf &
                            "Barangay: " & barangayName.Text & vbCrLf &
                            "City: " & cityName.Text, "Information", MessageBoxButtons.OK,
                                                                      MessageBoxIcon.Information
                           )

        Else
            MessageBox.Show("Check invalid field/s.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        End
    End Sub
End Class
