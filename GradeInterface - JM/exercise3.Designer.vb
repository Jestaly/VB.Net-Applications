<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class exercise3
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
        Panel1 = New Panel()
        extensionnameBox = New ComboBox()
        cityCombox = New ComboBox()
        BarangayBox = New ComboBox()
        cityField = New Label()
        barangayLabel = New Label()
        villageField = New TextBox()
        villageLabel = New Label()
        TextBox2 = New TextBox()
        streetLabel = New Label()
        MaskedTextBox1 = New MaskedTextBox()
        housenumLabel = New Label()
        TextBox1 = New TextBox()
        emailaddLabel = New Label()
        cellphonenumField = New MaskedTextBox()
        Label1 = New Label()
        addressLabel = New Label()
        ageField = New TextBox()
        ageLabel = New Label()
        birthdayField = New DateTimePicker()
        birthdayLabel = New Label()
        genderCombox = New ComboBox()
        genderLabel = New Label()
        givennameField = New TextBox()
        givennameLabel = New Label()
        extensionLabel = New Label()
        middlenameField = New TextBox()
        middlenameLabel = New Label()
        surnameField = New TextBox()
        surnameLabel = New Label()
        confmpassLabel = New Label()
        regisLabel = New Label()
        userLabel = New Label()
        usernamField = New TextBox()
        passwordField = New TextBox()
        passwordLabel = New Label()
        confpassField = New TextBox()
        confpassLabel = New Label()
        signUp = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(extensionnameBox)
        Panel1.Controls.Add(cityCombox)
        Panel1.Controls.Add(BarangayBox)
        Panel1.Controls.Add(cityField)
        Panel1.Controls.Add(barangayLabel)
        Panel1.Controls.Add(villageField)
        Panel1.Controls.Add(villageLabel)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(streetLabel)
        Panel1.Controls.Add(MaskedTextBox1)
        Panel1.Controls.Add(housenumLabel)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(emailaddLabel)
        Panel1.Controls.Add(cellphonenumField)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(addressLabel)
        Panel1.Controls.Add(ageField)
        Panel1.Controls.Add(ageLabel)
        Panel1.Controls.Add(birthdayField)
        Panel1.Controls.Add(birthdayLabel)
        Panel1.Controls.Add(genderCombox)
        Panel1.Controls.Add(genderLabel)
        Panel1.Controls.Add(givennameField)
        Panel1.Controls.Add(givennameLabel)
        Panel1.Controls.Add(extensionLabel)
        Panel1.Controls.Add(middlenameField)
        Panel1.Controls.Add(middlenameLabel)
        Panel1.Controls.Add(surnameField)
        Panel1.Controls.Add(surnameLabel)
        Panel1.Controls.Add(confmpassLabel)
        Panel1.Location = New Point(261, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(679, 544)
        Panel1.TabIndex = 0
        ' 
        ' extensionnameBox
        ' 
        extensionnameBox.FormattingEnabled = True
        extensionnameBox.Items.AddRange(New Object() {"Jr.", "Sr.", "II", "III"})
        extensionnameBox.Location = New Point(386, 157)
        extensionnameBox.Name = "extensionnameBox"
        extensionnameBox.Size = New Size(203, 28)
        extensionnameBox.TabIndex = 31
        ' 
        ' cityCombox
        ' 
        cityCombox.FormattingEnabled = True
        cityCombox.Items.AddRange(New Object() {"Pasig", "Pateros"})
        cityCombox.Location = New Point(275, 483)
        cityCombox.Name = "cityCombox"
        cityCombox.Size = New Size(183, 28)
        cityCombox.TabIndex = 30
        ' 
        ' BarangayBox
        ' 
        BarangayBox.FormattingEnabled = True
        BarangayBox.Location = New Point(39, 483)
        BarangayBox.Name = "BarangayBox"
        BarangayBox.Size = New Size(182, 28)
        BarangayBox.TabIndex = 29
        ' 
        ' cityField
        ' 
        cityField.AutoSize = True
        cityField.Location = New Point(275, 460)
        cityField.Name = "cityField"
        cityField.Size = New Size(34, 20)
        cityField.TabIndex = 28
        cityField.Text = "City"
        ' 
        ' barangayLabel
        ' 
        barangayLabel.AutoSize = True
        barangayLabel.Location = New Point(41, 460)
        barangayLabel.Name = "barangayLabel"
        barangayLabel.Size = New Size(71, 20)
        barangayLabel.TabIndex = 26
        barangayLabel.Text = "Barangay"
        ' 
        ' villageField
        ' 
        villageField.Location = New Point(399, 417)
        villageField.MaxLength = 20
        villageField.Name = "villageField"
        villageField.Size = New Size(236, 27)
        villageField.TabIndex = 25
        ' 
        ' villageLabel
        ' 
        villageLabel.AutoSize = True
        villageLabel.Location = New Point(399, 394)
        villageLabel.Name = "villageLabel"
        villageLabel.Size = New Size(176, 20)
        villageLabel.TabIndex = 24
        villageLabel.Text = "Village, Area, Subdivision"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(178, 417)
        TextBox2.MaxLength = 20
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(201, 27)
        TextBox2.TabIndex = 23
        ' 
        ' streetLabel
        ' 
        streetLabel.AutoSize = True
        streetLabel.Location = New Point(178, 394)
        streetLabel.Name = "streetLabel"
        streetLabel.Size = New Size(48, 20)
        streetLabel.TabIndex = 22
        streetLabel.Text = "Street"
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(41, 417)
        MaskedTextBox1.Mask = "00000000"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(111, 27)
        MaskedTextBox1.TabIndex = 21
        ' 
        ' housenumLabel
        ' 
        housenumLabel.AutoSize = True
        housenumLabel.Location = New Point(41, 394)
        housenumLabel.Name = "housenumLabel"
        housenumLabel.Size = New Size(111, 20)
        housenumLabel.TabIndex = 20
        housenumLabel.Text = "Unit/House No."
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(199, 305)
        TextBox1.MaxLength = 20
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(262, 27)
        TextBox1.TabIndex = 19
        ' 
        ' emailaddLabel
        ' 
        emailaddLabel.AutoSize = True
        emailaddLabel.Location = New Point(199, 282)
        emailaddLabel.Name = "emailaddLabel"
        emailaddLabel.Size = New Size(103, 20)
        emailaddLabel.TabIndex = 18
        emailaddLabel.Text = "Email Address"
        ' 
        ' cellphonenumField
        ' 
        cellphonenumField.Location = New Point(41, 305)
        cellphonenumField.Mask = "0000-000-0000"
        cellphonenumField.Name = "cellphonenumField"
        cellphonenumField.Size = New Size(128, 27)
        cellphonenumField.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(39, 282)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 20)
        Label1.TabIndex = 16
        Label1.Text = "Cellphone No."
        ' 
        ' addressLabel
        ' 
        addressLabel.AutoSize = True
        addressLabel.Font = New Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        addressLabel.Location = New Point(22, 358)
        addressLabel.Name = "addressLabel"
        addressLabel.Size = New Size(253, 24)
        addressLabel.TabIndex = 15
        addressLabel.Text = "Address Information"
        ' 
        ' ageField
        ' 
        ageField.Location = New Point(485, 233)
        ageField.MaxLength = 0
        ageField.Name = "ageField"
        ageField.ReadOnly = True
        ageField.Size = New Size(150, 27)
        ageField.TabIndex = 14
        ' 
        ' ageLabel
        ' 
        ageLabel.AutoSize = True
        ageLabel.Location = New Point(485, 211)
        ageLabel.Name = "ageLabel"
        ageLabel.Size = New Size(36, 20)
        ageLabel.TabIndex = 13
        ageLabel.Text = "Age"
        ' 
        ' birthdayField
        ' 
        birthdayField.Location = New Point(199, 234)
        birthdayField.Name = "birthdayField"
        birthdayField.Size = New Size(259, 27)
        birthdayField.TabIndex = 12
        ' 
        ' birthdayLabel
        ' 
        birthdayLabel.AutoSize = True
        birthdayLabel.Location = New Point(199, 211)
        birthdayLabel.Name = "birthdayLabel"
        birthdayLabel.Size = New Size(64, 20)
        birthdayLabel.TabIndex = 11
        birthdayLabel.Text = "Birthday"
        ' 
        ' genderCombox
        ' 
        genderCombox.FormattingEnabled = True
        genderCombox.Items.AddRange(New Object() {"Male", "Female"})
        genderCombox.Location = New Point(39, 233)
        genderCombox.Name = "genderCombox"
        genderCombox.Size = New Size(130, 28)
        genderCombox.TabIndex = 10
        ' 
        ' genderLabel
        ' 
        genderLabel.AutoSize = True
        genderLabel.Location = New Point(39, 210)
        genderLabel.Name = "genderLabel"
        genderLabel.Size = New Size(57, 20)
        genderLabel.TabIndex = 9
        genderLabel.Text = "Gender"
        ' 
        ' givennameField
        ' 
        givennameField.Location = New Point(386, 95)
        givennameField.MaxLength = 20
        givennameField.Name = "givennameField"
        givennameField.Size = New Size(250, 27)
        givennameField.TabIndex = 8
        ' 
        ' givennameLabel
        ' 
        givennameLabel.AutoSize = True
        givennameLabel.Location = New Point(386, 72)
        givennameLabel.Name = "givennameLabel"
        givennameLabel.Size = New Size(86, 20)
        givennameLabel.TabIndex = 7
        givennameLabel.Text = "Given Label"
        ' 
        ' extensionLabel
        ' 
        extensionLabel.AutoSize = True
        extensionLabel.Location = New Point(386, 134)
        extensionLabel.Name = "extensionLabel"
        extensionLabel.Size = New Size(116, 20)
        extensionLabel.TabIndex = 5
        extensionLabel.Text = "Extension Name"
        ' 
        ' middlenameField
        ' 
        middlenameField.Location = New Point(39, 157)
        middlenameField.MaxLength = 20
        middlenameField.Name = "middlenameField"
        middlenameField.Size = New Size(250, 27)
        middlenameField.TabIndex = 4
        ' 
        ' middlenameLabel
        ' 
        middlenameLabel.AutoSize = True
        middlenameLabel.Location = New Point(39, 134)
        middlenameLabel.Name = "middlenameLabel"
        middlenameLabel.Size = New Size(100, 20)
        middlenameLabel.TabIndex = 3
        middlenameLabel.Text = "Middle Name"
        ' 
        ' surnameField
        ' 
        surnameField.Location = New Point(39, 95)
        surnameField.MaxLength = 20
        surnameField.Name = "surnameField"
        surnameField.Size = New Size(250, 27)
        surnameField.TabIndex = 2
        ' 
        ' surnameLabel
        ' 
        surnameLabel.AutoSize = True
        surnameLabel.Location = New Point(39, 72)
        surnameLabel.Name = "surnameLabel"
        surnameLabel.Size = New Size(67, 20)
        surnameLabel.TabIndex = 1
        surnameLabel.Text = "Surname"
        ' 
        ' confmpassLabel
        ' 
        confmpassLabel.AutoSize = True
        confmpassLabel.Font = New Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        confmpassLabel.Location = New Point(22, 29)
        confmpassLabel.Name = "confmpassLabel"
        confmpassLabel.Size = New Size(267, 24)
        confmpassLabel.TabIndex = 0
        confmpassLabel.Text = "Personal Information"
        ' 
        ' regisLabel
        ' 
        regisLabel.AutoSize = True
        regisLabel.Font = New Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        regisLabel.Location = New Point(12, 125)
        regisLabel.Name = "regisLabel"
        regisLabel.Size = New Size(226, 33)
        regisLabel.TabIndex = 1
        regisLabel.Text = "REGISTRATION"
        ' 
        ' userLabel
        ' 
        userLabel.AutoSize = True
        userLabel.Location = New Point(12, 181)
        userLabel.Name = "userLabel"
        userLabel.Size = New Size(129, 20)
        userLabel.TabIndex = 2
        userLabel.Text = "Username/User ID"
        ' 
        ' usernamField
        ' 
        usernamField.Location = New Point(12, 204)
        usernamField.MaxLength = 20
        usernamField.Name = "usernamField"
        usernamField.Size = New Size(233, 27)
        usernamField.TabIndex = 3
        ' 
        ' passwordField
        ' 
        passwordField.Location = New Point(12, 275)
        passwordField.MaxLength = 8
        passwordField.Name = "passwordField"
        passwordField.PasswordChar = "*"c
        passwordField.Size = New Size(233, 27)
        passwordField.TabIndex = 5
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Location = New Point(12, 252)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(70, 20)
        passwordLabel.TabIndex = 4
        passwordLabel.Text = "Password"
        ' 
        ' confpassField
        ' 
        confpassField.Location = New Point(12, 346)
        confpassField.MaxLength = 8
        confpassField.Name = "confpassField"
        confpassField.PasswordChar = "*"c
        confpassField.Size = New Size(233, 27)
        confpassField.TabIndex = 7
        ' 
        ' confpassLabel
        ' 
        confpassLabel.AutoSize = True
        confpassLabel.Location = New Point(12, 323)
        confpassLabel.Name = "confpassLabel"
        confpassLabel.Size = New Size(127, 20)
        confpassLabel.TabIndex = 6
        confpassLabel.Text = "Confirm Password"
        ' 
        ' signUp
        ' 
        signUp.BackColor = SystemColors.ButtonFace
        signUp.Location = New Point(111, 384)
        signUp.Name = "signUp"
        signUp.Size = New Size(134, 30)
        signUp.TabIndex = 8
        signUp.Text = "Sign Up"
        signUp.UseVisualStyleBackColor = False
        ' 
        ' exercise3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(935, 540)
        Controls.Add(signUp)
        Controls.Add(confpassField)
        Controls.Add(confpassLabel)
        Controls.Add(passwordField)
        Controls.Add(passwordLabel)
        Controls.Add(usernamField)
        Controls.Add(userLabel)
        Controls.Add(regisLabel)
        Controls.Add(Panel1)
        Name = "exercise3"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents regisLabel As Label
    Friend WithEvents userLabel As Label
    Friend WithEvents usernamField As TextBox
    Friend WithEvents passwordField As TextBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents confpassField As TextBox
    Friend WithEvents confpassLabel As Label
    Friend WithEvents confmpassLabel As Label
    Friend WithEvents surnameLabel As Label
    Friend WithEvents surnameField As TextBox
    Friend WithEvents givennameField As TextBox
    Friend WithEvents givennameLabel As Label
    Friend WithEvents extensionLabel As Label
    Friend WithEvents middlenameField As TextBox
    Friend WithEvents middlenameLabel As Label
    Friend WithEvents genderLabel As Label
    Friend WithEvents genderCombox As ComboBox
    Friend WithEvents birthdayLabel As Label
    Friend WithEvents birthdayField As DateTimePicker
    Friend WithEvents ageLabel As Label
    Friend WithEvents ageField As TextBox
    Friend WithEvents addressLabel As Label
    Friend WithEvents cellphonenumField As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents emailaddLabel As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents housenumLabel As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents streetLabel As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents villageLabel As Label
    Friend WithEvents villageField As TextBox
    Friend WithEvents barangayLabel As Label
    Friend WithEvents cityField As Label
    Friend WithEvents BarangayBox As ComboBox
    Friend WithEvents cityCombox As ComboBox
    Friend WithEvents extensionnameBox As ComboBox
    Friend WithEvents signUp As Button

End Class
