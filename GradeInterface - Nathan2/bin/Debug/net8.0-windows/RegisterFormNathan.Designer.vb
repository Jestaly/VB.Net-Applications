<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegisterFormNathan
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
        usernameLabel = New Label()
        passwordLabel = New Label()
        confirmPasswordLabel = New Label()
        maleRadioButton = New RadioButton()
        femaleRadioButton = New RadioButton()
        genderRadioButton = New GroupBox()
        birthday = New DateTimePicker()
        phoneNumberLabel = New Label()
        emailLabel = New Label()
        emailName = New TextBox()
        confirmButton = New Button()
        panel1 = New Panel()
        birthdayLabel = New Label()
        panel3 = New Panel()
        areaLabel = New Label()
        barangayName = New TextBox()
        barangayLabel = New Label()
        areaName = New TextBox()
        unitLabel = New Label()
        unitName = New TextBox()
        cityName = New TextBox()
        streetName = New TextBox()
        cityLabel = New Label()
        streetLabel = New Label()
        phoneNumberName = New MaskedTextBox()
        extensionNameLabel = New Label()
        middleName = New TextBox()
        givenNameLabel = New Label()
        middleNameLabel = New Label()
        surname = New TextBox()
        extensionName = New TextBox()
        givenName = New TextBox()
        surnameLabel = New Label()
        panel2 = New Panel()
        exitButton = New Button()
        genderRadioButton.SuspendLayout()
        panel1.SuspendLayout()
        panel3.SuspendLayout()
        panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' userName
        ' 
        userName.BackColor = Color.White
        userName.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0)
        userName.ForeColor = SystemColors.ControlText
        userName.Location = New Point(30, 92)
        userName.Name = "userName"
        userName.PlaceholderText = "Username"
        userName.Size = New Size(271, 31)
        userName.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Verdana", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        Label1.Location = New Point(399, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(265, 45)
        Label1.TabIndex = 1
        Label1.Text = "Register Now"
        ' 
        ' confirmPassword
        ' 
        confirmPassword.BackColor = Color.White
        confirmPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0)
        confirmPassword.ForeColor = SystemColors.ControlText
        confirmPassword.Location = New Point(30, 209)
        confirmPassword.Name = "confirmPassword"
        confirmPassword.PlaceholderText = "Confirm Password"
        confirmPassword.Size = New Size(271, 31)
        confirmPassword.TabIndex = 3
        confirmPassword.UseSystemPasswordChar = True
        ' 
        ' password
        ' 
        password.BackColor = Color.White
        password.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0)
        password.ForeColor = SystemColors.ControlText
        password.Location = New Point(30, 149)
        password.Name = "password"
        password.PlaceholderText = "Password"
        password.Size = New Size(271, 31)
        password.TabIndex = 4
        password.UseSystemPasswordChar = True
        ' 
        ' usernameLabel
        ' 
        usernameLabel.AutoSize = True
        usernameLabel.Location = New Point(32, 69)
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New Size(75, 20)
        usernameLabel.TabIndex = 25
        usernameLabel.Text = "Username"
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Location = New Point(32, 126)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(70, 20)
        passwordLabel.TabIndex = 26
        passwordLabel.Text = "Password"
        ' 
        ' confirmPasswordLabel
        ' 
        confirmPasswordLabel.AutoSize = True
        confirmPasswordLabel.Location = New Point(30, 186)
        confirmPasswordLabel.Name = "confirmPasswordLabel"
        confirmPasswordLabel.Size = New Size(127, 20)
        confirmPasswordLabel.TabIndex = 27
        confirmPasswordLabel.Text = "Confirm Password"
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
        genderRadioButton.BackColor = Color.Transparent
        genderRadioButton.Controls.Add(maleRadioButton)
        genderRadioButton.Controls.Add(femaleRadioButton)
        genderRadioButton.ForeColor = SystemColors.Control
        genderRadioButton.Location = New Point(177, 134)
        genderRadioButton.Name = "genderRadioButton"
        genderRadioButton.Size = New Size(138, 104)
        genderRadioButton.TabIndex = 33
        genderRadioButton.TabStop = False
        genderRadioButton.Text = "Gender"
        ' 
        ' birthday
        ' 
        birthday.CalendarFont = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0)
        birthday.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0)
        birthday.Location = New Point(30, 268)
        birthday.Name = "birthday"
        birthday.Size = New Size(271, 30)
        birthday.TabIndex = 34
        ' 
        ' phoneNumberLabel
        ' 
        phoneNumberLabel.AutoSize = True
        phoneNumberLabel.ForeColor = SystemColors.Control
        phoneNumberLabel.Location = New Point(29, 137)
        phoneNumberLabel.Name = "phoneNumberLabel"
        phoneNumberLabel.Size = New Size(108, 20)
        phoneNumberLabel.TabIndex = 36
        phoneNumberLabel.Text = "Phone Number"
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.ForeColor = SystemColors.Control
        emailLabel.Location = New Point(30, 12)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(46, 20)
        emailLabel.TabIndex = 38
        emailLabel.Text = "Email"
        ' 
        ' emailName
        ' 
        emailName.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0)
        emailName.Location = New Point(30, 35)
        emailName.Name = "emailName"
        emailName.PlaceholderText = "Email"
        emailName.Size = New Size(271, 31)
        emailName.TabIndex = 37
        ' 
        ' confirmButton
        ' 
        confirmButton.ForeColor = SystemColors.ActiveCaptionText
        confirmButton.Location = New Point(77, 297)
        confirmButton.Name = "confirmButton"
        confirmButton.Size = New Size(94, 35)
        confirmButton.TabIndex = 39
        confirmButton.Text = "Register"
        confirmButton.UseVisualStyleBackColor = True
        ' 
        ' panel1
        ' 
        panel1.BackColor = Color.Transparent
        panel1.Controls.Add(birthdayLabel)
        panel1.Controls.Add(usernameLabel)
        panel1.Controls.Add(userName)
        panel1.Controls.Add(confirmPassword)
        panel1.Controls.Add(birthday)
        panel1.Controls.Add(password)
        panel1.Controls.Add(passwordLabel)
        panel1.Controls.Add(confirmPasswordLabel)
        panel1.Controls.Add(emailName)
        panel1.Controls.Add(emailLabel)
        panel1.Location = New Point(27, 79)
        panel1.Name = "panel1"
        panel1.Size = New Size(328, 345)
        panel1.TabIndex = 41
        ' 
        ' birthdayLabel
        ' 
        birthdayLabel.AutoSize = True
        birthdayLabel.ForeColor = SystemColors.Control
        birthdayLabel.Location = New Point(32, 245)
        birthdayLabel.Name = "birthdayLabel"
        birthdayLabel.Size = New Size(70, 20)
        birthdayLabel.TabIndex = 45
        birthdayLabel.Text = "Birthdate"
        ' 
        ' panel3
        ' 
        panel3.BackColor = Color.Transparent
        panel3.Controls.Add(areaLabel)
        panel3.Controls.Add(barangayName)
        panel3.Controls.Add(barangayLabel)
        panel3.Controls.Add(areaName)
        panel3.Controls.Add(unitLabel)
        panel3.Controls.Add(unitName)
        panel3.Controls.Add(cityName)
        panel3.Controls.Add(streetName)
        panel3.Controls.Add(cityLabel)
        panel3.Controls.Add(streetLabel)
        panel3.ForeColor = SystemColors.Control
        panel3.Location = New Point(710, 79)
        panel3.Name = "panel3"
        panel3.Size = New Size(256, 345)
        panel3.TabIndex = 43
        ' 
        ' areaLabel
        ' 
        areaLabel.AutoSize = True
        areaLabel.Location = New Point(25, 69)
        areaLabel.Name = "areaLabel"
        areaLabel.Size = New Size(40, 20)
        areaLabel.TabIndex = 20
        areaLabel.Text = "Area"
        ' 
        ' barangayName
        ' 
        barangayName.Font = New Font("Segoe UI", 10.8F)
        barangayName.Location = New Point(23, 266)
        barangayName.Name = "barangayName"
        barangayName.PlaceholderText = "Barangay"
        barangayName.Size = New Size(213, 31)
        barangayName.TabIndex = 21
        ' 
        ' barangayLabel
        ' 
        barangayLabel.AutoSize = True
        barangayLabel.Location = New Point(23, 243)
        barangayLabel.Name = "barangayLabel"
        barangayLabel.Size = New Size(71, 20)
        barangayLabel.TabIndex = 22
        barangayLabel.Text = "Barangay"
        ' 
        ' areaName
        ' 
        areaName.Font = New Font("Segoe UI", 10.8F)
        areaName.Location = New Point(23, 92)
        areaName.Name = "areaName"
        areaName.PlaceholderText = "Area"
        areaName.Size = New Size(213, 31)
        areaName.TabIndex = 19
        ' 
        ' unitLabel
        ' 
        unitLabel.AutoSize = True
        unitLabel.Location = New Point(23, 12)
        unitLabel.Name = "unitLabel"
        unitLabel.Size = New Size(155, 20)
        unitLabel.TabIndex = 16
        unitLabel.Text = "Unit or House number"
        ' 
        ' unitName
        ' 
        unitName.Font = New Font("Segoe UI", 10.8F)
        unitName.Location = New Point(25, 35)
        unitName.Name = "unitName"
        unitName.PlaceholderText = "Unit / House Number"
        unitName.Size = New Size(211, 31)
        unitName.TabIndex = 15
        ' 
        ' cityName
        ' 
        cityName.Font = New Font("Segoe UI", 10.8F)
        cityName.Location = New Point(23, 149)
        cityName.Name = "cityName"
        cityName.PlaceholderText = "City"
        cityName.Size = New Size(213, 31)
        cityName.TabIndex = 23
        ' 
        ' streetName
        ' 
        streetName.Font = New Font("Segoe UI", 10.8F)
        streetName.Location = New Point(23, 209)
        streetName.Name = "streetName"
        streetName.PlaceholderText = "Street"
        streetName.Size = New Size(213, 31)
        streetName.TabIndex = 17
        ' 
        ' cityLabel
        ' 
        cityLabel.AutoSize = True
        cityLabel.Location = New Point(23, 126)
        cityLabel.Name = "cityLabel"
        cityLabel.Size = New Size(34, 20)
        cityLabel.TabIndex = 24
        cityLabel.Text = "City"
        ' 
        ' streetLabel
        ' 
        streetLabel.AutoSize = True
        streetLabel.Location = New Point(23, 186)
        streetLabel.Name = "streetLabel"
        streetLabel.Size = New Size(48, 20)
        streetLabel.TabIndex = 18
        streetLabel.Text = "Street"
        ' 
        ' phoneNumberName
        ' 
        phoneNumberName.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0)
        phoneNumberName.Location = New Point(28, 160)
        phoneNumberName.Mask = "999-000-0000"
        phoneNumberName.Name = "phoneNumberName"
        phoneNumberName.Size = New Size(143, 31)
        phoneNumberName.TabIndex = 44
        ' 
        ' extensionNameLabel
        ' 
        extensionNameLabel.AutoSize = True
        extensionNameLabel.Location = New Point(177, 71)
        extensionNameLabel.Name = "extensionNameLabel"
        extensionNameLabel.Size = New Size(116, 20)
        extensionNameLabel.TabIndex = 14
        extensionNameLabel.Text = "Extension Name"
        ' 
        ' middleName
        ' 
        middleName.Font = New Font("Segoe UI", 10.8F)
        middleName.Location = New Point(29, 94)
        middleName.Name = "middleName"
        middleName.PlaceholderText = "Middle Name"
        middleName.Size = New Size(142, 31)
        middleName.TabIndex = 9
        ' 
        ' givenNameLabel
        ' 
        givenNameLabel.AutoSize = True
        givenNameLabel.Location = New Point(177, 12)
        givenNameLabel.Name = "givenNameLabel"
        givenNameLabel.Size = New Size(90, 20)
        givenNameLabel.TabIndex = 12
        givenNameLabel.Text = "Given Name"
        ' 
        ' middleNameLabel
        ' 
        middleNameLabel.AutoSize = True
        middleNameLabel.Location = New Point(29, 71)
        middleNameLabel.Name = "middleNameLabel"
        middleNameLabel.Size = New Size(100, 20)
        middleNameLabel.TabIndex = 13
        middleNameLabel.Text = "Middle Name"
        ' 
        ' surname
        ' 
        surname.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0)
        surname.Location = New Point(29, 34)
        surname.Name = "surname"
        surname.PlaceholderText = "Surname"
        surname.Size = New Size(142, 31)
        surname.TabIndex = 7
        ' 
        ' extensionName
        ' 
        extensionName.Font = New Font("Segoe UI", 10.8F)
        extensionName.Location = New Point(177, 93)
        extensionName.Name = "extensionName"
        extensionName.PlaceholderText = "Extension Name"
        extensionName.Size = New Size(138, 31)
        extensionName.TabIndex = 10
        ' 
        ' givenName
        ' 
        givenName.Font = New Font("Segoe UI", 10.8F)
        givenName.Location = New Point(177, 35)
        givenName.Name = "givenName"
        givenName.PlaceholderText = "Given Name"
        givenName.Size = New Size(138, 31)
        givenName.TabIndex = 8
        ' 
        ' surnameLabel
        ' 
        surnameLabel.AutoSize = True
        surnameLabel.Location = New Point(29, 12)
        surnameLabel.Name = "surnameLabel"
        surnameLabel.Size = New Size(67, 20)
        surnameLabel.TabIndex = 11
        surnameLabel.Text = "Surname"
        ' 
        ' panel2
        ' 
        panel2.BackColor = Color.Transparent
        panel2.Controls.Add(exitButton)
        panel2.Controls.Add(phoneNumberName)
        panel2.Controls.Add(surnameLabel)
        panel2.Controls.Add(givenName)
        panel2.Controls.Add(confirmButton)
        panel2.Controls.Add(genderRadioButton)
        panel2.Controls.Add(extensionName)
        panel2.Controls.Add(surname)
        panel2.Controls.Add(middleNameLabel)
        panel2.Controls.Add(phoneNumberLabel)
        panel2.Controls.Add(givenNameLabel)
        panel2.Controls.Add(middleName)
        panel2.Controls.Add(extensionNameLabel)
        panel2.Location = New Point(361, 79)
        panel2.Name = "panel2"
        panel2.Size = New Size(343, 345)
        panel2.TabIndex = 42
        ' 
        ' exitButton
        ' 
        exitButton.ForeColor = SystemColors.ActiveCaptionText
        exitButton.Location = New Point(177, 297)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(94, 35)
        exitButton.TabIndex = 45
        exitButton.Text = "Exit"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' RegisterFormNathan
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkRed
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(991, 450)
        Controls.Add(panel1)
        Controls.Add(panel2)
        Controls.Add(Label1)
        Controls.Add(panel3)
        ForeColor = SystemColors.Control
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "RegisterFormNathan"
        Text = "Register"
        genderRadioButton.ResumeLayout(False)
        genderRadioButton.PerformLayout()
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        panel3.ResumeLayout(False)
        panel3.PerformLayout()
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents userName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents confirmPassword As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents usernameLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents confirmPasswordLabel As Label
    Friend WithEvents maleRadioButton As RadioButton
    Friend WithEvents femaleRadioButton As RadioButton
    Friend WithEvents genderRadioButton As GroupBox
    Friend WithEvents birthday As DateTimePicker
    Friend WithEvents phoneNumberLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents emailName As TextBox
    Friend WithEvents confirmButton As Button
    Friend WithEvents panel1 As Panel
    Friend WithEvents panel3 As Panel
    Friend WithEvents phoneNumberName As MaskedTextBox
    Friend WithEvents birthdayLabel As Label
    Friend WithEvents extensionNameLabel As Label
    Friend WithEvents unitName As TextBox
    Friend WithEvents unitLabel As Label
    Friend WithEvents streetName As TextBox
    Friend WithEvents middleName As TextBox
    Friend WithEvents cityLabel As Label
    Friend WithEvents streetLabel As Label
    Friend WithEvents givenNameLabel As Label
    Friend WithEvents middleNameLabel As Label
    Friend WithEvents surname As TextBox
    Friend WithEvents cityName As TextBox
    Friend WithEvents extensionName As TextBox
    Friend WithEvents areaName As TextBox
    Friend WithEvents barangayLabel As Label
    Friend WithEvents givenName As TextBox
    Friend WithEvents barangayName As TextBox
    Friend WithEvents areaLabel As Label
    Friend WithEvents surnameLabel As Label
    Friend WithEvents panel2 As Panel
    Friend WithEvents exitButton As Button

End Class
