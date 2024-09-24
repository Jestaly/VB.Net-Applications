<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        userName = New TextBox()
        Label1 = New Label()
        confirmPassword = New TextBox()
        password = New TextBox()
        nextButton = New Button()
        surname = New TextBox()
        givenName = New TextBox()
        middleName = New TextBox()
        extensionName = New TextBox()
        surnameLabel = New Label()
        givenNameLabel = New Label()
        middleNameLabel = New Label()
        extensionNameLabel = New Label()
        unitName = New TextBox()
        unitLabel = New Label()
        streetName = New TextBox()
        streetLabel = New Label()
        areaLabel = New Label()
        areaName = New TextBox()
        barangayLabel = New Label()
        barangayName = New TextBox()
        cityLabel = New Label()
        cityName = New TextBox()
        usernameLabel = New Label()
        passwordLabel = New Label()
        confirmPasswordLabel = New Label()
        nextButton2 = New Button()
        backButton = New Button()
        maleRadioButton = New RadioButton()
        femaleRadioButton = New RadioButton()
        genderRadioButton = New GroupBox()
        birthday = New DateTimePicker()
        phoneNumberName = New TextBox()
        phoneNumberLabel = New Label()
        emailLabel = New Label()
        emailName = New TextBox()
        backButton2 = New Button()
        confirmButton = New Button()
        panel1 = New Panel()
        panel2 = New Panel()
        panel3 = New Panel()
        genderRadioButton.SuspendLayout()
        panel1.SuspendLayout()
        panel2.SuspendLayout()
        panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' userName
        ' 
        userName.BackColor = Color.White
        userName.ForeColor = SystemColors.ControlText
        userName.Location = New Point(29, 39)
        userName.Name = "userName"
        userName.PlaceholderText = "Username"
        userName.Size = New Size(286, 27)
        userName.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(88, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(286, 46)
        Label1.TabIndex = 1
        Label1.Text = "Registration Form"
        ' 
        ' confirmPassword
        ' 
        confirmPassword.BackColor = Color.White
        confirmPassword.ForeColor = SystemColors.ControlText
        confirmPassword.Location = New Point(29, 145)
        confirmPassword.Name = "confirmPassword"
        confirmPassword.PlaceholderText = "Confirm Password"
        confirmPassword.Size = New Size(286, 27)
        confirmPassword.TabIndex = 3
        ' 
        ' password
        ' 
        password.BackColor = Color.White
        password.ForeColor = SystemColors.ControlText
        password.Location = New Point(28, 92)
        password.Name = "password"
        password.PlaceholderText = "Password"
        password.Size = New Size(286, 27)
        password.TabIndex = 4
        ' 
        ' nextButton
        ' 
        nextButton.ForeColor = SystemColors.ActiveCaptionText
        nextButton.Location = New Point(117, 180)
        nextButton.Name = "nextButton"
        nextButton.Size = New Size(94, 29)
        nextButton.TabIndex = 5
        nextButton.Text = "Next"
        nextButton.UseVisualStyleBackColor = True
        ' 
        ' surname
        ' 
        surname.Location = New Point(12, 32)
        surname.Name = "surname"
        surname.PlaceholderText = "Surname"
        surname.Size = New Size(142, 27)
        surname.TabIndex = 7
        ' 
        ' givenName
        ' 
        givenName.Location = New Point(160, 33)
        givenName.Name = "givenName"
        givenName.PlaceholderText = "Given Name"
        givenName.Size = New Size(138, 27)
        givenName.TabIndex = 8
        ' 
        ' middleName
        ' 
        middleName.Location = New Point(12, 98)
        middleName.Name = "middleName"
        middleName.PlaceholderText = "Middle Name"
        middleName.Size = New Size(142, 27)
        middleName.TabIndex = 9
        ' 
        ' extensionName
        ' 
        extensionName.Location = New Point(160, 97)
        extensionName.Name = "extensionName"
        extensionName.PlaceholderText = "Extension Name"
        extensionName.Size = New Size(138, 27)
        extensionName.TabIndex = 10
        ' 
        ' surnameLabel
        ' 
        surnameLabel.AutoSize = True
        surnameLabel.Location = New Point(12, 10)
        surnameLabel.Name = "surnameLabel"
        surnameLabel.Size = New Size(67, 20)
        surnameLabel.TabIndex = 11
        surnameLabel.Text = "Surname"
        ' 
        ' givenNameLabel
        ' 
        givenNameLabel.AutoSize = True
        givenNameLabel.Location = New Point(160, 10)
        givenNameLabel.Name = "givenNameLabel"
        givenNameLabel.Size = New Size(90, 20)
        givenNameLabel.TabIndex = 12
        givenNameLabel.Text = "Given Name"
        ' 
        ' middleNameLabel
        ' 
        middleNameLabel.AutoSize = True
        middleNameLabel.Location = New Point(12, 75)
        middleNameLabel.Name = "middleNameLabel"
        middleNameLabel.Size = New Size(100, 20)
        middleNameLabel.TabIndex = 13
        middleNameLabel.Text = "Middle Name"
        ' 
        ' extensionNameLabel
        ' 
        extensionNameLabel.AutoSize = True
        extensionNameLabel.Location = New Point(160, 75)
        extensionNameLabel.Name = "extensionNameLabel"
        extensionNameLabel.Size = New Size(116, 20)
        extensionNameLabel.TabIndex = 14
        extensionNameLabel.Text = "Extension Name"
        ' 
        ' unitName
        ' 
        unitName.Location = New Point(12, 156)
        unitName.Name = "unitName"
        unitName.PlaceholderText = "Unit or House Number"
        unitName.Size = New Size(171, 27)
        unitName.TabIndex = 15
        ' 
        ' unitLabel
        ' 
        unitLabel.AutoSize = True
        unitLabel.Location = New Point(12, 133)
        unitLabel.Name = "unitLabel"
        unitLabel.Size = New Size(36, 20)
        unitLabel.TabIndex = 16
        unitLabel.Text = "Unit"
        ' 
        ' streetName
        ' 
        streetName.Location = New Point(189, 156)
        streetName.Name = "streetName"
        streetName.PlaceholderText = "Street"
        streetName.Size = New Size(109, 27)
        streetName.TabIndex = 17
        ' 
        ' streetLabel
        ' 
        streetLabel.AutoSize = True
        streetLabel.Location = New Point(189, 133)
        streetLabel.Name = "streetLabel"
        streetLabel.Size = New Size(48, 20)
        streetLabel.TabIndex = 18
        streetLabel.Text = "Street"
        ' 
        ' areaLabel
        ' 
        areaLabel.AutoSize = True
        areaLabel.Location = New Point(12, 194)
        areaLabel.Name = "areaLabel"
        areaLabel.Size = New Size(40, 20)
        areaLabel.TabIndex = 20
        areaLabel.Text = "Area"
        ' 
        ' areaName
        ' 
        areaName.Location = New Point(12, 217)
        areaName.Name = "areaName"
        areaName.PlaceholderText = "Area"
        areaName.Size = New Size(171, 27)
        areaName.TabIndex = 19
        ' 
        ' barangayLabel
        ' 
        barangayLabel.AutoSize = True
        barangayLabel.Location = New Point(189, 194)
        barangayLabel.Name = "barangayLabel"
        barangayLabel.Size = New Size(71, 20)
        barangayLabel.TabIndex = 22
        barangayLabel.Text = "Barangay"
        ' 
        ' barangayName
        ' 
        barangayName.Location = New Point(189, 217)
        barangayName.Name = "barangayName"
        barangayName.PlaceholderText = "Barangay"
        barangayName.Size = New Size(109, 27)
        barangayName.TabIndex = 21
        ' 
        ' cityLabel
        ' 
        cityLabel.AutoSize = True
        cityLabel.Location = New Point(12, 256)
        cityLabel.Name = "cityLabel"
        cityLabel.Size = New Size(34, 20)
        cityLabel.TabIndex = 24
        cityLabel.Text = "City"
        ' 
        ' cityName
        ' 
        cityName.Location = New Point(12, 279)
        cityName.Name = "cityName"
        cityName.PlaceholderText = "City"
        cityName.Size = New Size(286, 27)
        cityName.TabIndex = 23
        ' 
        ' usernameLabel
        ' 
        usernameLabel.AutoSize = True
        usernameLabel.Location = New Point(29, 16)
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New Size(75, 20)
        usernameLabel.TabIndex = 25
        usernameLabel.Text = "Username"
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Location = New Point(29, 69)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(70, 20)
        passwordLabel.TabIndex = 26
        passwordLabel.Text = "Password"
        ' 
        ' confirmPasswordLabel
        ' 
        confirmPasswordLabel.AutoSize = True
        confirmPasswordLabel.Location = New Point(29, 122)
        confirmPasswordLabel.Name = "confirmPasswordLabel"
        confirmPasswordLabel.Size = New Size(127, 20)
        confirmPasswordLabel.TabIndex = 27
        confirmPasswordLabel.Text = "Confirm Password"
        ' 
        ' nextButton2
        ' 
        nextButton2.ForeColor = SystemColors.ActiveCaptionText
        nextButton2.Location = New Point(56, 312)
        nextButton2.Name = "nextButton2"
        nextButton2.Size = New Size(94, 29)
        nextButton2.TabIndex = 28
        nextButton2.Text = "Next"
        nextButton2.UseVisualStyleBackColor = True
        ' 
        ' backButton
        ' 
        backButton.ForeColor = SystemColors.ActiveCaptionText
        backButton.Location = New Point(156, 312)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 29)
        backButton.TabIndex = 29
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = True
        ' 
        ' maleRadioButton
        ' 
        maleRadioButton.AutoSize = True
        maleRadioButton.Location = New Point(6, 26)
        maleRadioButton.Name = "maleRadioButton"
        maleRadioButton.Size = New Size(63, 24)
        maleRadioButton.TabIndex = 30
        maleRadioButton.TabStop = True
        maleRadioButton.Text = "Male"
        maleRadioButton.UseVisualStyleBackColor = True
        ' 
        ' femaleRadioButton
        ' 
        femaleRadioButton.AutoSize = True
        femaleRadioButton.Location = New Point(6, 56)
        femaleRadioButton.Name = "femaleRadioButton"
        femaleRadioButton.Size = New Size(78, 24)
        femaleRadioButton.TabIndex = 32
        femaleRadioButton.TabStop = True
        femaleRadioButton.Text = "Female"
        femaleRadioButton.UseVisualStyleBackColor = True
        ' 
        ' genderRadioButton
        ' 
        genderRadioButton.Controls.Add(maleRadioButton)
        genderRadioButton.Controls.Add(femaleRadioButton)
        genderRadioButton.ForeColor = SystemColors.Control
        genderRadioButton.Location = New Point(3, 16)
        genderRadioButton.Name = "genderRadioButton"
        genderRadioButton.Size = New Size(105, 104)
        genderRadioButton.TabIndex = 33
        genderRadioButton.TabStop = False
        genderRadioButton.Text = "Gender"
        ' 
        ' birthday
        ' 
        birthday.Location = New Point(21, 130)
        birthday.Name = "birthday"
        birthday.Size = New Size(250, 27)
        birthday.TabIndex = 34
        ' 
        ' phoneNumberName
        ' 
        phoneNumberName.Location = New Point(114, 39)
        phoneNumberName.Name = "phoneNumberName"
        phoneNumberName.PlaceholderText = "Cellphone Number"
        phoneNumberName.Size = New Size(182, 27)
        phoneNumberName.TabIndex = 35
        ' 
        ' phoneNumberLabel
        ' 
        phoneNumberLabel.AutoSize = True
        phoneNumberLabel.ForeColor = SystemColors.Control
        phoneNumberLabel.Location = New Point(114, 16)
        phoneNumberLabel.Name = "phoneNumberLabel"
        phoneNumberLabel.Size = New Size(108, 20)
        phoneNumberLabel.TabIndex = 36
        phoneNumberLabel.Text = "Phone Number"
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.ForeColor = SystemColors.Control
        emailLabel.Location = New Point(114, 72)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(46, 20)
        emailLabel.TabIndex = 38
        emailLabel.Text = "Email"
        ' 
        ' emailName
        ' 
        emailName.Location = New Point(114, 97)
        emailName.Name = "emailName"
        emailName.PlaceholderText = "Email"
        emailName.Size = New Size(182, 27)
        emailName.TabIndex = 37
        ' 
        ' backButton2
        ' 
        backButton2.Location = New Point(147, 163)
        backButton2.Name = "backButton2"
        backButton2.Size = New Size(94, 29)
        backButton2.TabIndex = 40
        backButton2.Text = "Back"
        backButton2.UseVisualStyleBackColor = True
        ' 
        ' confirmButton
        ' 
        confirmButton.Location = New Point(47, 163)
        confirmButton.Name = "confirmButton"
        confirmButton.Size = New Size(94, 29)
        confirmButton.TabIndex = 39
        confirmButton.Text = "Confirm"
        confirmButton.UseVisualStyleBackColor = True
        ' 
        ' panel1
        ' 
        panel1.BackColor = Color.Transparent
        panel1.Controls.Add(usernameLabel)
        panel1.Controls.Add(userName)
        panel1.Controls.Add(confirmPassword)
        panel1.Controls.Add(password)
        panel1.Controls.Add(nextButton)
        panel1.Controls.Add(passwordLabel)
        panel1.Controls.Add(confirmPasswordLabel)
        panel1.Location = New Point(967, 48)
        panel1.Name = "panel1"
        panel1.Size = New Size(338, 267)
        panel1.TabIndex = 41
        ' 
        ' panel2
        ' 
        panel2.BackColor = Color.Transparent
        panel2.Controls.Add(surnameLabel)
        panel2.Controls.Add(areaLabel)
        panel2.Controls.Add(barangayName)
        panel2.Controls.Add(givenName)
        panel2.Controls.Add(barangayLabel)
        panel2.Controls.Add(areaName)
        panel2.Controls.Add(extensionName)
        panel2.Controls.Add(cityName)
        panel2.Controls.Add(surname)
        panel2.Controls.Add(middleNameLabel)
        panel2.Controls.Add(givenNameLabel)
        panel2.Controls.Add(streetLabel)
        panel2.Controls.Add(backButton)
        panel2.Controls.Add(cityLabel)
        panel2.Controls.Add(middleName)
        panel2.Controls.Add(streetName)
        panel2.Controls.Add(nextButton2)
        panel2.Controls.Add(unitLabel)
        panel2.Controls.Add(unitName)
        panel2.Controls.Add(extensionNameLabel)
        panel2.Location = New Point(624, 71)
        panel2.Name = "panel2"
        panel2.Size = New Size(312, 348)
        panel2.TabIndex = 42
        panel2.Visible = False
        ' 
        ' panel3
        ' 
        panel3.BackColor = Color.Transparent
        panel3.Controls.Add(genderRadioButton)
        panel3.Controls.Add(birthday)
        panel3.Controls.Add(phoneNumberName)
        panel3.Controls.Add(backButton2)
        panel3.Controls.Add(phoneNumberLabel)
        panel3.Controls.Add(confirmButton)
        panel3.Controls.Add(emailName)
        panel3.Controls.Add(emailLabel)
        panel3.ForeColor = SystemColors.ActiveCaptionText
        panel3.Location = New Point(181, 133)
        panel3.Name = "panel3"
        panel3.Size = New Size(307, 279)
        panel3.TabIndex = 43
        panel3.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(1317, 450)
        Controls.Add(panel3)
        Controls.Add(panel2)
        Controls.Add(panel1)
        Controls.Add(Label1)
        ForeColor = SystemColors.Control
        Name = "Form1"
        Text = "Form1"
        genderRadioButton.ResumeLayout(False)
        genderRadioButton.PerformLayout()
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        panel3.ResumeLayout(False)
        panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents userName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents confirmPassword As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents nextButton As Button
    Friend WithEvents surname As TextBox
    Friend WithEvents givenName As TextBox
    Friend WithEvents middleName As TextBox
    Friend WithEvents extensionName As TextBox
    Friend WithEvents surnameLabel As Label
    Friend WithEvents givenNameLabel As Label
    Friend WithEvents middleNameLabel As Label
    Friend WithEvents extensionNameLabel As Label
    Friend WithEvents unitName As TextBox
    Friend WithEvents unitLabel As Label
    Friend WithEvents streetName As TextBox
    Friend WithEvents streetLabel As Label
    Friend WithEvents areaLabel As Label
    Friend WithEvents areaName As TextBox
    Friend WithEvents barangayLabel As Label
    Friend WithEvents barangayName As TextBox
    Friend WithEvents cityLabel As Label
    Friend WithEvents cityName As TextBox
    Friend WithEvents usernameLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents confirmPasswordLabel As Label
    Friend WithEvents nextButton2 As Button
    Friend WithEvents backButton As Button
    Friend WithEvents maleRadioButton As RadioButton
    Friend WithEvents femaleRadioButton As RadioButton
    Friend WithEvents genderRadioButton As GroupBox
    Friend WithEvents birthday As DateTimePicker
    Friend WithEvents phoneNumberName As TextBox
    Friend WithEvents phoneNumberLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents emailName As TextBox
    Friend WithEvents backButton2 As Button
    Friend WithEvents confirmButton As Button
    Friend WithEvents panel1 As Panel
    Friend WithEvents panel2 As Panel
    Friend WithEvents panel3 As Panel

End Class
