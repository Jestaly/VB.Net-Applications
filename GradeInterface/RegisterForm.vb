Public Class Form1

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click

        Dim userNameError = False
        Dim passwordError = False
        Dim passwordMatchError = False
        Dim errorMessage = ""

        If (userName.Text.Length < 5 Or userName.Text.Length > 15) Then
            errorMessage += "Username should range from 5 to 15 Characters."
            userNameError = True
        End If

        If (password.Text.Length < 8 Or password.Text.Length > 16) Then
            errorMessage += vbNewLine & "Password should range from 8 to 16 Characters."
            passwordError = True
        End If

        If (Not (confirmPassword.Text.Equals(password.Text))) Then
            errorMessage += vbNewLine & "Password not matching."
            passwordMatchError = True
        End If

        If (userNameError = True Or passwordError = True Or passwordMatchError = True) Then
            MessageBox.Show(errorMessage, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
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

        If (surname.Text.Equals("") Or surname.Text.Length > 20 Or givenName.Text.Equals("") Or
            givenName.Text.Length > 20 Or middleName.Text.Equals("") Or
            middleName.Text.Length > 20 Or extensionName.Text.Length > 20 Or
            areaName.Text.Length > 20 Or streetName.Text.Equals("") Or
            streetName.Text.Length > 20 Or barangayName.Text.Equals("") Or barangayName.Text.Length > 20 Or
            cityName.Text.Equals("") Or cityName.Text.Length > 20) Then
            MessageBox.Show("Error, some field/s are invalid.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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
        Dim gender As String = ""
        Dim age As String
        Dim birthYear As String = ""
        Dim i As Integer

        For i = 1 To 4 Step 1
            birthYear += birthday.Text.Chars(birthday.Text.Length - 5 + i)
        Next

        age = Date.Today.Year - CInt(birthYear)
        ageCalc.Text = age
        If (maleRadioButton.Checked = True) Then
            gender = maleRadioButton.Text
        ElseIf (femaleRadioButton.Checked = True) Then
            gender = femaleRadioButton.Text
        End If


        If (phoneNumberName.Text.Length = 12 And emailName.Text.Contains("@") And emailName.Text.Contains(".") And Not (gender.Equals(""))) Then
            MessageBox.Show("Registered Successfully!", "REGISTRATION SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show("Username: " & userName.Text & vbNewLine &
                            "Password: " & password.Text & vbNewLine &
                            "Gender: " & gender & vbNewLine &
                            "Surname: " & surname.Text & vbNewLine &
                            "Given name: " & givenName.Text & vbNewLine &
                            "Middle name: " & middleName.Text & vbNewLine &
                            "Extension name: " & extensionName.Text & vbNewLine &
                            "Birthday: " & birthday.Text & vbNewLine &
                             "Age: " & age & " Years old" & vbNewLine &
                             "Email: " & emailName.Text & vbNewLine &
                             "Phone number: " & phoneNumberName.Text, "USER INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information
                           )
            MessageBox.Show("Unit/House number: " & unitName.Text & vbNewLine &
                            "Street: " & streetName.Text & vbNewLine &
                            "Area: " & areaName.Text & vbNewLine &
                            "Barangay: " & barangayName.Text & vbNewLine &
                            "City: " & cityName.Text, "ADDRESS INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        Else
            MessageBox.Show("Error, some field/s are invalid.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub birthday_ValueChanged(sender As Object, e As EventArgs) Handles birthday.ValueChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
