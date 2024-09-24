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

        If (extensionName.Text.Equals("")) Then
            extensionName.Text = "N/A"
        End If
        If (areaName.Text.Equals("")) Then
            areaName.Text = "N/A"
        End If

        If (surname.Text.Equals("") And surname.Text.Length > 20 And givenName.Text.Equals("") And
            surname.Text.Length > 20 And middleName.Text.Equals("") And
            middleName.Text.Length > 20 And extensionName.Text.Length > 20 And
            areaName.Text.Length > 20 And streetName.Text.Equals("") And
            streetName.Text.Length > 20 And barangayName.Text.Equals("") And barangayName.Text.Length > 20 And
            cityName.Text.Equals("") And cityName.Text.Length > 20) Then
            MessageBox.Show("Error, some field/s are invalid.")
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
        Dim gender = ""
        Dim age As String
        Dim birthYear = ""
        Dim i As Integer

        For i = 1 To 4 Step 1
            birthYear += birthday.Text.Chars(birthday.Text.Length - 5 + i)
        Next

        age = Date.Today.Year - CInt(birthYear)

        If (maleRadioButton.Checked = True) Then
            gender = maleRadioButton.Text
        ElseIf (femaleRadioButton.Checked = True) Then
            gender = femaleRadioButton.Text
        End If

        If (phoneNumberName.Text.Length = 12 And emailName.Text.Contains("@") And emailName.Text.Contains(".") And Not (gender.Equals(""))) Then
            MessageBox.Show("Success.")
            MessageBox.Show("---USER INFORMATION---" & vbNewLine &
                            "Username: " & userName.Text & vbNewLine &
                            "Password: " & password.Text & vbNewLine &
                            "Gender: " & gender & vbNewLine &
                            "Surname: " & surname.Text & vbNewLine &
                            "Given name: " & givenName.Text & vbNewLine &
                            "Middle name: " & middleName.Text & vbNewLine &
                            "Extension name: " & extensionName.Text & vbNewLine &
                            "Birthday: " & birthday.Text & vbNewLine &
                             "Age: " & age & " Years old" & vbNewLine &
                             "Email: " & emailName.Text & vbNewLine &
                             "Phone number: " & phoneNumberName.Text
                           )
            MessageBox.Show("---ADDRESS INFORMATION---" & vbNewLine &
                            "Unit/House number: " & unitName.Text & vbNewLine &
                            "Street: " & streetName.Text & vbNewLine &
                            "Area: " & areaName.Text & vbNewLine &
                            "Barangay: " & barangayName.Text & vbNewLine &
                            "City: " & cityName.Text)
            End
        Else
            MessageBox.Show("Error, some field/s are invalid.")
        End If


    End Sub

End Class
