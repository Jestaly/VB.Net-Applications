<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginFormForm
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
        loginlabel = New Label()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' loginlabel
        ' 
        loginlabel.AutoSize = True
        loginlabel.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loginlabel.Location = New Point(164, 55)
        loginlabel.Name = "loginlabel"
        loginlabel.Size = New Size(179, 38)
        loginlabel.TabIndex = 0
        loginlabel.Text = "Log-In Form"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(36, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 28)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(36, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 28)
        Label2.TabIndex = 2
        Label2.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(164, 142)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(235, 27)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(164, 194)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(235, 27)
        TextBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button1.Location = New Point(164, 254)
        Button1.Name = "Button1"
        Button1.Size = New Size(111, 49)
        Button1.TabIndex = 5
        Button1.Text = "LogIn"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(288, 254)
        Button2.Name = "Button2"
        Button2.Size = New Size(111, 49)
        Button2.TabIndex = 6
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' LoginFormForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(431, 326)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(loginlabel)
        Name = "LoginFormForm"
        Text = "Login Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents loginlabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
