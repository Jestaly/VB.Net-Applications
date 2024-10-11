Public Class exercise3
    Private Sub ageField_Click(sender As Object, e As EventArgs) Handles ageField.Click
        Dim yr As Integer = DateDiff(DateInterval.Year, birthdayField.Value, Now)
        ageField.Text = yr & " Years "
    End Sub

    Private Sub cityCombox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cityCombox.SelectedIndexChanged
        BarangayBox.Items.Clear()
        Select Case cityCombox.SelectedItem.ToString
            Case "Pasig"
                BarangayBox.Items.Add("Bagong Ilog")
                BarangayBox.Items.Add("Bagong Katipunan")
                BarangayBox.Items.Add("Bambang")
                BarangayBox.Items.Add("Buting")
                BarangayBox.Items.Add("Caniogan")
                BarangayBox.Items.Add("Kalawaan")
                BarangayBox.Items.Add("Kapasigan")
                BarangayBox.Items.Add("Kapitolyo")
                BarangayBox.Items.Add("Malinao")
                BarangayBox.Items.Add("Oranbo")
                BarangayBox.Items.Add("Palatiw")
                BarangayBox.Items.Add("Pineda")
                BarangayBox.Items.Add("Sagad")
                BarangayBox.Items.Add("San Antonio")
                BarangayBox.Items.Add("San Joaquin")
                BarangayBox.Items.Add("San Jose")
                BarangayBox.Items.Add("San Nicolas (Poblacion)")
                BarangayBox.Items.Add("Santa Cruz")
                BarangayBox.Items.Add("Santa Rosa")
                BarangayBox.Items.Add("Santo Tomas")
                BarangayBox.Items.Add("Sumilang")
                BarangayBox.Items.Add("Ugong")
                BarangayBox.Items.Add("Dela Paz")
                BarangayBox.Items.Add("Manggahan")
                BarangayBox.Items.Add("Maybunga")
                BarangayBox.Items.Add("Pinagbuhatan")
                BarangayBox.Items.Add("Rosario")
                BarangayBox.Items.Add("Santa Lucia")
                BarangayBox.Items.Add("Santolan")
                BarangayBox.Items.Add("San Miguel")

            Case "Pateros"
                BarangayBox.Items.Add("Aguho")
                BarangayBox.Items.Add("Magtanggol")
                BarangayBox.Items.Add("Martires del 96")
                BarangayBox.Items.Add("Poblacion")
                BarangayBox.Items.Add("San Pedro")

        End Select



    End Sub

    Private Sub signUp_Click(sender As Object, e As EventArgs) Handles signUp.Click
        If passwordField.Text.Equals(confpassField.Text) Then
            MessageBox.Show("Successfully Registered!")
        Else
            MessageBox.Show("Password is not the same. Please Check")
        End If
    End Sub

    Private Sub exercise3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
