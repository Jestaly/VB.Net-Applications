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
        phoneNumberLabel = New Label()
        emailLabel = New Label()
        emailName = New TextBox()
        backButton2 = New Button()
        confirmButton = New Button()
        panel1 = New Panel()
        panel2 = New Panel()
        panel3 = New Panel()
        birthdayLabel = New Label()
        phoneNumberName = New MaskedTextBox()
        genderRadioButton.SuspendLayout()
        panel1.SuspendLayout()
        panel2.SuspendLayout()
        panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' userName
        ' 
        userName.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        userName.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        userName.ForeColor = SystemColors.Control
        userName.Location = New Point(29, 39)
        userName.Name = "userName"
        userName.PlaceholderText = "Username"
        userName.Size = New Size(286, 31)
        userName.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Verdana", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(64, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(265, 45)
        Label1.TabIndex = 1
        Label1.Text = "Register Now"
        ' 
        ' confirmPassword
        ' 
        confirmPassword.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        confirmPassword.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        confirmPassword.ForeColor = SystemColors.Control
        confirmPassword.Location = New Point(27, 156)
        confirmPassword.Name = "confirmPassword"
        confirmPassword.PlaceholderText = "Confirm Password"
        confirmPassword.Size = New Size(286, 31)
        confirmPassword.TabIndex = 3
        confirmPassword.UseSystemPasswordChar = True
        ' 
        ' password
        ' 
        password.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        password.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        password.ForeColor = SystemColors.Control
        password.Location = New Point(28, 96)
        password.Name = "password"
        password.PlaceholderText = "Password"
        password.Size = New Size(286, 31)
        password.TabIndex = 4
        password.UseSystemPasswordChar = True
        ' 
        ' nextButton
        ' 
        nextButton.BackColor = Color.Silver
        nextButton.ForeColor = SystemColors.ActiveCaptionText
        nextButton.Location = New Point(115, 194)
        nextButton.Name = "nextButton"
        nextButton.Size = New Size(94, 35)
        nextButton.TabIndex = 5
        nextButton.Text = "Next"
        nextButton.UseVisualStyleBackColor = False
        ' 
        ' surname
        ' 
        surname.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        surname.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        surname.ForeColor = SystemColors.Control
        surname.Location = New Point(29, 33)
        surname.Name = "surname"
        surname.PlaceholderText = "Surname"
        surname.Size = New Size(142, 31)
        surname.TabIndex = 7
        ' 
        ' givenName
        ' 
        givenName.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        givenName.Font = New Font("Segoe UI", 10.8F)
        givenName.ForeColor = SystemColors.Control
        givenName.Location = New Point(177, 34)
        givenName.Name = "givenName"
        givenName.PlaceholderText = "Given Name"
        givenName.Size = New Size(138, 31)
        givenName.TabIndex = 8
        ' 
        ' middleName
        ' 
        middleName.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        middleName.Font = New Font("Segoe UI", 10.8F)
        middleName.ForeColor = SystemColors.Control
        middleName.Location = New Point(29, 93)
        middleName.Name = "middleName"
        middleName.PlaceholderText = "Middle Name"
        middleName.Size = New Size(142, 31)
        middleName.TabIndex = 9
        ' 
        ' extensionName
        ' 
        extensionName.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        extensionName.Font = New Font("Segoe UI", 10.8F)
        extensionName.ForeColor = SystemColors.Control
        extensionName.Location = New Point(177, 92)
        extensionName.Name = "extensionName"
        extensionName.PlaceholderText = "Extension Name"
        extensionName.Size = New Size(138, 31)
        extensionName.TabIndex = 10
        ' 
        ' surnameLabel
        ' 
        surnameLabel.AutoSize = True
        surnameLabel.Location = New Point(29, 11)
        surnameLabel.Name = "surnameLabel"
        surnameLabel.Size = New Size(67, 20)
        surnameLabel.TabIndex = 11
        surnameLabel.Text = "Surname"
        ' 
        ' givenNameLabel
        ' 
        givenNameLabel.AutoSize = True
        givenNameLabel.Location = New Point(177, 11)
        givenNameLabel.Name = "givenNameLabel"
        givenNameLabel.Size = New Size(90, 20)
        givenNameLabel.TabIndex = 12
        givenNameLabel.Text = "Given Name"
        ' 
        ' middleNameLabel
        ' 
        middleNameLabel.AutoSize = True
        middleNameLabel.Location = New Point(29, 70)
        middleNameLabel.Name = "middleNameLabel"
        middleNameLabel.Size = New Size(100, 20)
        middleNameLabel.TabIndex = 13
        middleNameLabel.Text = "Middle Name"
        ' 
        ' extensionNameLabel
        ' 
        extensionNameLabel.AutoSize = True
        extensionNameLabel.Location = New Point(177, 70)
        extensionNameLabel.Name = "extensionNameLabel"
        extensionNameLabel.Size = New Size(116, 20)
        extensionNameLabel.TabIndex = 14
        extensionNameLabel.Text = "Extension Name"
        ' 
        ' unitName
        ' 
        unitName.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        unitName.Font = New Font("Segoe UI", 10.8F)
        unitName.ForeColor = SystemColors.Control
        unitName.Location = New Point(29, 150)
        unitName.Name = "unitName"
        unitName.PlaceholderText = "Unit or House Number"
        unitName.Size = New Size(169, 31)
        unitName.TabIndex = 15
        ' 
        ' unitLabel
        ' 
        unitLabel.AutoSize = True
        unitLabel.Location = New Point(27, 127)
        unitLabel.Name = "unitLabel"
        unitLabel.Size = New Size(36, 20)
        unitLabel.TabIndex = 16
        unitLabel.Text = "Unit"
        ' 
        ' streetName
        ' 
        streetName.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        streetName.Font = New Font("Segoe UI", 10.8F)
        streetName.ForeColor = SystemColors.Control
        streetName.Location = New Point(204, 150)
        streetName.Name = "streetName"
        streetName.PlaceholderText = "Street"
        streetName.Size = New Size(109, 31)
        streetName.TabIndex = 17
        ' 
        ' streetLabel
        ' 
        streetLabel.AutoSize = True
        streetLabel.Location = New Point(204, 127)
        streetLabel.Name = "streetLabel"
        streetLabel.Size = New Size(48, 20)
        streetLabel.TabIndex = 18
        streetLabel.Text = "Street"
        ' 
        ' areaLabel
        ' 
        areaLabel.AutoSize = True
        areaLabel.Location = New Point(29, 184)
        areaLabel.Name = "areaLabel"
        areaLabel.Size = New Size(40, 20)
        areaLabel.TabIndex = 20
        areaLabel.Text = "Area"
        ' 
        ' areaName
        ' 
        areaName.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        areaName.Font = New Font("Segoe UI", 10.8F)
        areaName.ForeColor = SystemColors.Control
        areaName.Location = New Point(27, 207)
        areaName.Name = "areaName"
        areaName.PlaceholderText = "Area"
        areaName.Size = New Size(173, 31)
        areaName.TabIndex = 19
        ' 
        ' barangayLabel
        ' 
        barangayLabel.AutoSize = True
        barangayLabel.Location = New Point(206, 184)
        barangayLabel.Name = "barangayLabel"
        barangayLabel.Size = New Size(71, 20)
        barangayLabel.TabIndex = 22
        barangayLabel.Text = "Barangay"
        ' 
        ' barangayName
        ' 
        barangayName.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        barangayName.Font = New Font("Segoe UI", 10.8F)
        barangayName.ForeColor = SystemColors.Control
        barangayName.Location = New Point(206, 207)
        barangayName.Name = "barangayName"
        barangayName.PlaceholderText = "Barangay"
        barangayName.Size = New Size(107, 31)
        barangayName.TabIndex = 21
        ' 
        ' cityLabel
        ' 
        cityLabel.AutoSize = True
        cityLabel.Location = New Point(27, 241)
        cityLabel.Name = "cityLabel"
        cityLabel.Size = New Size(34, 20)
        cityLabel.TabIndex = 24
        cityLabel.Text = "City"
        ' 
        ' cityName
        ' 
        cityName.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        cityName.Font = New Font("Segoe UI", 10.8F)
        cityName.ForeColor = SystemColors.Control
        cityName.Location = New Point(27, 264)
        cityName.Name = "cityName"
        cityName.PlaceholderText = "City"
        cityName.Size = New Size(286, 31)
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
        passwordLabel.Location = New Point(29, 73)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(70, 20)
        passwordLabel.TabIndex = 26
        passwordLabel.Text = "Password"
        ' 
        ' confirmPasswordLabel
        ' 
        confirmPasswordLabel.AutoSize = True
        confirmPasswordLabel.Location = New Point(27, 133)
        confirmPasswordLabel.Name = "confirmPasswordLabel"
        confirmPasswordLabel.Size = New Size(127, 20)
        confirmPasswordLabel.TabIndex = 27
        confirmPasswordLabel.Text = "Confirm Password"
        ' 
        ' nextButton2
        ' 
        nextButton2.BackColor = Color.Silver
        nextButton2.ForeColor = SystemColors.ActiveCaptionText
        nextButton2.Location = New Point(73, 310)
        nextButton2.Name = "nextButton2"
        nextButton2.Size = New Size(94, 35)
        nextButton2.TabIndex = 28
        nextButton2.Text = "Next"
        nextButton2.UseVisualStyleBackColor = False
        ' 
        ' backButton
        ' 
        backButton.BackColor = Color.Silver
        backButton.ForeColor = SystemColors.ActiveCaptionText
        backButton.Location = New Point(173, 310)
        backButton.Name = "backButton"
        backButton.Size = New Size(94, 35)
        backButton.TabIndex = 29
        backButton.Text = "Back"
        backButton.UseVisualStyleBackColor = False
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
        genderRadioButton.Location = New Point(27, 70)
        genderRadioButton.Name = "genderRadioButton"
        genderRadioButton.Size = New Size(105, 114)
        genderRadioButton.TabIndex = 33
        genderRadioButton.TabStop = False
        genderRadioButton.Text = "Gender"
        ' 
        ' birthday
        ' 
        birthday.CalendarFont = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        birthday.CalendarForeColor = SystemColors.Control
        birthday.CalendarMonthBackground = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        birthday.CalendarTitleBackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        birthday.CalendarTitleForeColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        birthday.CalendarTrailingForeColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        birthday.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        birthday.Format = DateTimePickerFormat.Short
        birthday.Location = New Point(143, 150)
        birthday.Name = "birthday"
        birthday.Size = New Size(174, 27)
        birthday.TabIndex = 34
        ' 
        ' phoneNumberLabel
        ' 
        phoneNumberLabel.AutoSize = True
        phoneNumberLabel.ForeColor = SystemColors.Control
        phoneNumberLabel.Location = New Point(143, 70)
        phoneNumberLabel.Name = "phoneNumberLabel"
        phoneNumberLabel.Size = New Size(108, 20)
        phoneNumberLabel.TabIndex = 36
        phoneNumberLabel.Text = "Phone Number"
        ' 
        ' emailLabel
        ' 
        emailLabel.AutoSize = True
        emailLabel.ForeColor = SystemColors.Control
        emailLabel.Location = New Point(24, 11)
        emailLabel.Name = "emailLabel"
        emailLabel.Size = New Size(46, 20)
        emailLabel.TabIndex = 38
        emailLabel.Text = "Email"
        ' 
        ' emailName
        ' 
        emailName.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        emailName.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        emailName.ForeColor = SystemColors.Control
        emailName.Location = New Point(24, 34)
        emailName.Name = "emailName"
        emailName.PlaceholderText = "Email"
        emailName.Size = New Size(293, 31)
        emailName.TabIndex = 37
        ' 
        ' backButton2
        ' 
        backButton2.BackColor = Color.Silver
        backButton2.Location = New Point(166, 203)
        backButton2.Name = "backButton2"
        backButton2.Size = New Size(94, 35)
        backButton2.TabIndex = 40
        backButton2.Text = "Back"
        backButton2.UseVisualStyleBackColor = False
        ' 
        ' confirmButton
        ' 
        confirmButton.BackColor = Color.Silver
        confirmButton.Location = New Point(66, 203)
        confirmButton.Name = "confirmButton"
        confirmButton.Size = New Size(94, 35)
        confirmButton.TabIndex = 39
        confirmButton.Text = "Confirm"
        confirmButton.UseVisualStyleBackColor = False
        ' 
        ' panel1
        ' 
        panel1.BackColor = Color.Transparent
        panel1.BackgroundImageLayout = ImageLayout.Stretch
        panel1.Controls.Add(usernameLabel)
        panel1.Controls.Add(userName)
        panel1.Controls.Add(confirmPassword)
        panel1.Controls.Add(password)
        panel1.Controls.Add(nextButton)
        panel1.Controls.Add(passwordLabel)
        panel1.Controls.Add(confirmPasswordLabel)
        panel1.Location = New Point(28, 81)
        panel1.Name = "panel1"
        panel1.Size = New Size(346, 345)
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
        panel2.Location = New Point(31, 81)
        panel2.Name = "panel2"
        panel2.Size = New Size(343, 348)
        panel2.TabIndex = 42
        panel2.Visible = False
        ' 
        ' panel3
        ' 
        panel3.BackColor = Color.Transparent
        panel3.Controls.Add(birthdayLabel)
        panel3.Controls.Add(phoneNumberName)
        panel3.Controls.Add(genderRadioButton)
        panel3.Controls.Add(birthday)
        panel3.Controls.Add(backButton2)
        panel3.Controls.Add(phoneNumberLabel)
        panel3.Controls.Add(confirmButton)
        panel3.Controls.Add(emailName)
        panel3.Controls.Add(emailLabel)
        panel3.ForeColor = SystemColors.ActiveCaptionText
        panel3.Location = New Point(31, 81)
        panel3.Name = "panel3"
        panel3.Size = New Size(340, 348)
        panel3.TabIndex = 43
        panel3.Visible = False
        ' 
        ' birthdayLabel
        ' 
        birthdayLabel.AutoSize = True
        birthdayLabel.ForeColor = SystemColors.Control
        birthdayLabel.Location = New Point(143, 127)
        birthdayLabel.Name = "birthdayLabel"
        birthdayLabel.Size = New Size(70, 20)
        birthdayLabel.TabIndex = 45
        birthdayLabel.Text = "Birthdate"
        ' 
        ' phoneNumberName
        ' 
        phoneNumberName.BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        phoneNumberName.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        phoneNumberName.ForeColor = SystemColors.Control
        phoneNumberName.Location = New Point(143, 93)
        phoneNumberName.Mask = "999-000-0000"
        phoneNumberName.Name = "phoneNumberName"
        phoneNumberName.PromptChar = "x"c
        phoneNumberName.Size = New Size(174, 31)
        phoneNumberName.TabIndex = 44
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(60), CByte(61), CByte(55))
        BackgroundImage = My.Resources.Resources.backmech
        ClientSize = New Size(402, 450)
        Controls.Add(panel1)
        Controls.Add(panel2)
        Controls.Add(Label1)
        Controls.Add(panel3)
        ForeColor = SystemColors.Control
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        Text = "Register"
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
    Friend WithEvents phoneNumberLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents emailName As TextBox
    Friend WithEvents backButton2 As Button
    Friend WithEvents confirmButton As Button
    Friend WithEvents panel1 As Panel
    Friend WithEvents panel2 As Panel
    Friend WithEvents panel3 As Panel
    Friend WithEvents phoneNumberName As MaskedTextBox
    Friend WithEvents birthdayLabel As Label

End Class
