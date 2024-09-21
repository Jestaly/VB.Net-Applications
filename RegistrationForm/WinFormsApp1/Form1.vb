Public Class Form1

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        panel1.Visible = False
        panel2.Visible = True
    End Sub

    Private Sub nextButton2_Click(sender As Object, e As EventArgs) Handles nextButton2.Click
        panel2.Visible = False
        panel3.Visible = True
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
