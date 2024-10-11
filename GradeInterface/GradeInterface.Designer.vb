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
        ToolStrip1 = New ToolStrip()
        refreshButton = New ToolStripButton()
        ToolStripButton1 = New ToolStripButton()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
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
        fileMenu.Size = New Size(46, 24)
        fileMenu.Text = "File"
        ' 
        ' loginMenu
        ' 
        loginMenu.Name = "loginMenu"
        loginMenu.Size = New Size(224, 26)
        loginMenu.Text = "Login"
        ' 
        ' logoutMenu
        ' 
        logoutMenu.Name = "logoutMenu"
        logoutMenu.Size = New Size(139, 26)
        logoutMenu.Text = "Logout"
        ' 
        ' exitMenu
        ' 
        exitMenu.Name = "exitMenu"
        exitMenu.Size = New Size(139, 26)
        exitMenu.Text = "Exit"
        ' 
        ' gradesMenu
        ' 
        gradesMenu.Name = "gradesMenu"
        gradesMenu.Size = New Size(69, 24)
        gradesMenu.Text = "Grades"
        ' 
        ' signUpMenu
        ' 
        signUpMenu.Name = "signUpMenu"
        signUpMenu.Size = New Size(75, 24)
        signUpMenu.Text = "Sign Up"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {refreshButton, ToolStripButton1})
        ToolStrip1.Location = New Point(0, 28)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(800, 27)
        ToolStrip1.TabIndex = 3
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' refreshButton
        ' 
        refreshButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        refreshButton.Image = My.Resources.Resources.refresh
        refreshButton.ImageTransparentColor = Color.Magenta
        refreshButton.Name = "refreshButton"
        refreshButton.Size = New Size(29, 24)
        refreshButton.Text = "ToolStripButton1"
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = My.Resources.Resources.save
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(29, 24)
        ToolStripButton1.Text = "ToolStripButton1"
        ' 
        ' GradeInterface
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(36), CByte(54), CByte(66))
        ClientSize = New Size(800, 450)
        Controls.Add(ToolStrip1)
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
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
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
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents refreshButton As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton

End Class
