<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        usernameTextBoxForm = New TextBox()
        passwordTextBoxForm = New TextBox()
        usernameLabelForm = New Label()
        passwordLabelForm = New Label()
        loginButtonForm = New Button()
        exitButtonForm = New Button()
        loginLabelForm = New Label()
        SuspendLayout()
        ' 
        ' usernameTextBoxForm
        ' 
        usernameTextBoxForm.Location = New Point(142, 119)
        usernameTextBoxForm.Name = "usernameTextBoxForm"
        usernameTextBoxForm.PlaceholderText = "Username"
        usernameTextBoxForm.Size = New Size(228, 27)
        usernameTextBoxForm.TabIndex = 0
        ' 
        ' passwordTextBoxForm
        ' 
        passwordTextBoxForm.Location = New Point(142, 190)
        passwordTextBoxForm.Name = "passwordTextBoxForm"
        passwordTextBoxForm.PlaceholderText = "Password"
        passwordTextBoxForm.Size = New Size(228, 27)
        passwordTextBoxForm.TabIndex = 1
        ' 
        ' usernameLabelForm
        ' 
        usernameLabelForm.AutoSize = True
        usernameLabelForm.Font = New Font("Segoe UI", 12F)
        usernameLabelForm.ForeColor = Color.WhiteSmoke
        usernameLabelForm.Location = New Point(142, 88)
        usernameLabelForm.Name = "usernameLabelForm"
        usernameLabelForm.Size = New Size(99, 28)
        usernameLabelForm.TabIndex = 2
        usernameLabelForm.Text = "Username"
        ' 
        ' passwordLabelForm
        ' 
        passwordLabelForm.AutoSize = True
        passwordLabelForm.Font = New Font("Segoe UI", 12F)
        passwordLabelForm.ForeColor = Color.WhiteSmoke
        passwordLabelForm.Location = New Point(142, 159)
        passwordLabelForm.Name = "passwordLabelForm"
        passwordLabelForm.Size = New Size(93, 28)
        passwordLabelForm.TabIndex = 3
        passwordLabelForm.Text = "Password"
        ' 
        ' loginButtonForm
        ' 
        loginButtonForm.Font = New Font("Segoe UI", 12F)
        loginButtonForm.ForeColor = Color.FromArgb(CByte(30), CByte(32), CByte(30))
        loginButtonForm.Location = New Point(153, 242)
        loginButtonForm.Name = "loginButtonForm"
        loginButtonForm.Size = New Size(96, 36)
        loginButtonForm.TabIndex = 4
        loginButtonForm.Text = "Login"
        loginButtonForm.UseVisualStyleBackColor = True
        ' 
        ' exitButtonForm
        ' 
        exitButtonForm.Font = New Font("Segoe UI", 12F)
        exitButtonForm.ForeColor = Color.FromArgb(CByte(30), CByte(32), CByte(30))
        exitButtonForm.Location = New Point(255, 242)
        exitButtonForm.Name = "exitButtonForm"
        exitButtonForm.Size = New Size(96, 36)
        exitButtonForm.TabIndex = 5
        exitButtonForm.Text = "Exit"
        exitButtonForm.UseVisualStyleBackColor = True
        ' 
        ' loginLabelForm
        ' 
        loginLabelForm.AutoSize = True
        loginLabelForm.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        loginLabelForm.ForeColor = Color.WhiteSmoke
        loginLabelForm.Location = New Point(142, 41)
        loginLabelForm.Name = "loginLabelForm"
        loginLabelForm.Size = New Size(221, 46)
        loginLabelForm.TabIndex = 6
        loginLabelForm.Text = "LOGIN FORM"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(46), CByte(7), CByte(63))
        ClientSize = New Size(506, 358)
        Controls.Add(loginLabelForm)
        Controls.Add(exitButtonForm)
        Controls.Add(loginButtonForm)
        Controls.Add(passwordLabelForm)
        Controls.Add(usernameLabelForm)
        Controls.Add(passwordTextBoxForm)
        Controls.Add(usernameTextBoxForm)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "LoginForm"
        Text = "S"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents usernameTextBoxForm As TextBox
    Friend WithEvents passwordTextBoxForm As TextBox
    Friend WithEvents usernameLabelForm As Label
    Friend WithEvents passwordLabelForm As Label
    Friend WithEvents loginButtonForm As Button
    Friend WithEvents exitButtonForm As Button
    Friend WithEvents loginLabelForm As Label

End Class
