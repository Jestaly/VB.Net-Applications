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
        usernameTextBox = New TextBox()
        passwordTextBox = New TextBox()
        usernameLabel = New Label()
        passwordLabel = New Label()
        loginButton = New Button()
        exitButton = New Button()
        SuspendLayout()
        ' 
        ' usernameTextBox
        ' 
        usernameTextBox.Location = New Point(114, 110)
        usernameTextBox.Name = "usernameTextBox"
        usernameTextBox.PlaceholderText = "Username"
        usernameTextBox.Size = New Size(195, 27)
        usernameTextBox.TabIndex = 0
        ' 
        ' passwordTextBox
        ' 
        passwordTextBox.Location = New Point(114, 189)
        passwordTextBox.Name = "passwordTextBox"
        passwordTextBox.PlaceholderText = "Password"
        passwordTextBox.Size = New Size(195, 27)
        passwordTextBox.TabIndex = 1
        ' 
        ' usernameLabel
        ' 
        usernameLabel.AutoSize = True
        usernameLabel.Font = New Font("Segoe UI", 12F)
        usernameLabel.ForeColor = Color.WhiteSmoke
        usernameLabel.Location = New Point(114, 79)
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New Size(99, 28)
        usernameLabel.TabIndex = 2
        usernameLabel.Text = "Username"
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Font = New Font("Segoe UI", 12F)
        passwordLabel.ForeColor = Color.WhiteSmoke
        passwordLabel.Location = New Point(114, 158)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(93, 28)
        passwordLabel.TabIndex = 3
        passwordLabel.Text = "Password"
        ' 
        ' loginButton
        ' 
        loginButton.Font = New Font("Segoe UI", 12F)
        loginButton.ForeColor = Color.FromArgb(CByte(30), CByte(32), CByte(30))
        loginButton.Location = New Point(111, 250)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(96, 36)
        loginButton.TabIndex = 4
        loginButton.Text = "Login"
        loginButton.UseVisualStyleBackColor = True
        ' 
        ' exitButton
        ' 
        exitButton.Font = New Font("Segoe UI", 12F)
        exitButton.ForeColor = Color.FromArgb(CByte(30), CByte(32), CByte(30))
        exitButton.Location = New Point(213, 249)
        exitButton.Name = "exitButton"
        exitButton.Size = New Size(96, 36)
        exitButton.TabIndex = 5
        exitButton.Text = "Exit"
        exitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(30))
        ClientSize = New Size(413, 395)
        Controls.Add(exitButton)
        Controls.Add(loginButton)
        Controls.Add(passwordLabel)
        Controls.Add(usernameLabel)
        Controls.Add(passwordTextBox)
        Controls.Add(usernameTextBox)
        Name = "Form1"
        Text = "Login Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents usernameTextBox As TextBox
    Friend WithEvents passwordTextBox As TextBox
    Friend WithEvents usernameLabel As Label
    Friend WithEvents passwordLabel As Label
    Friend WithEvents loginButton As Button
    Friend WithEvents exitButton As Button

End Class
