<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GradeInterface
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
        MenuStrip1 = New MenuStrip()
        fileMenu = New ToolStripMenuItem()
        loginMenu = New ToolStripMenuItem()
        logoutMenu = New ToolStripMenuItem()
        exitMenu = New ToolStripMenuItem()
        gradesMenu = New ToolStripMenuItem()
        signUpMenu = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {fileMenu, gradesMenu, signUpMenu})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' fileMenu
        ' 
        fileMenu.DropDownItems.AddRange(New ToolStripItem() {loginMenu, logoutMenu, exitMenu})
        fileMenu.Name = "fileMenu"
        fileMenu.ShortcutKeys = Keys.Alt Or Keys.F
        fileMenu.Size = New Size(46, 24)
        fileMenu.Text = "File"
        ' 
        ' loginMenu
        ' 
        loginMenu.Name = "loginMenu"
        loginMenu.ShortcutKeys = Keys.Control Or Keys.L
        loginMenu.Size = New Size(189, 26)
        loginMenu.Text = "Login"
        ' 
        ' logoutMenu
        ' 
        logoutMenu.Name = "logoutMenu"
        logoutMenu.ShortcutKeys = Keys.Control Or Keys.Y
        logoutMenu.Size = New Size(189, 26)
        logoutMenu.Text = "Logout"
        ' 
        ' exitMenu
        ' 
        exitMenu.Name = "exitMenu"
        exitMenu.ShortcutKeys = Keys.Control Or Keys.X
        exitMenu.Size = New Size(189, 26)
        exitMenu.Text = "Exit"
        ' 
        ' gradesMenu
        ' 
        gradesMenu.Enabled = False
        gradesMenu.Name = "gradesMenu"
        gradesMenu.ShortcutKeys = Keys.Alt Or Keys.G
        gradesMenu.Size = New Size(69, 24)
        gradesMenu.Text = "Grades"
        ' 
        ' signUpMenu
        ' 
        signUpMenu.Name = "signUpMenu"
        signUpMenu.ShortcutKeys = Keys.Alt Or Keys.S
        signUpMenu.Size = New Size(75, 24)
        signUpMenu.Text = "Sign Up"
        ' 
        ' GradeInterface
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(36), CByte(54), CByte(66))
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        ForeColor = Color.FromArgb(CByte(36), CByte(54), CByte(66))
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "GradeInterface"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Grade Interface"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents fileMenu As ToolStripMenuItem
    Friend WithEvents loginMenu As ToolStripMenuItem
    Friend WithEvents logoutMenu As ToolStripMenuItem
    Friend WithEvents exitMenu As ToolStripMenuItem
    Friend WithEvents gradesMenu As ToolStripMenuItem
    Friend WithEvents signUpMenu As ToolStripMenuItem

End Class
