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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GradeInterface))
        MenuStrip1 = New MenuStrip()
        fileMenu = New ToolStripMenuItem()
        loginMenu = New ToolStripMenuItem()
        logoutMenu = New ToolStripMenuItem()
        exitMenu = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        gradesMenu = New ToolStripMenuItem()
        signUpMenu = New ToolStripMenuItem()
        ToolStrip1 = New ToolStrip()
        NewToolStripButton = New ToolStripButton()
        OpenToolStripButton = New ToolStripButton()
        SaveToolStripButton = New ToolStripButton()
        PrintToolStripButton = New ToolStripButton()
        toolStripSeparator = New ToolStripSeparator()
        CutToolStripButton = New ToolStripButton()
        CopyToolStripButton = New ToolStripButton()
        PasteToolStripButton = New ToolStripButton()
        toolStripSeparator1 = New ToolStripSeparator()
        HelpToolStripButton = New ToolStripButton()
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
        fileMenu.DropDownItems.AddRange(New ToolStripItem() {loginMenu, logoutMenu, exitMenu, ExitToolStripMenuItem})
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
        logoutMenu.Size = New Size(224, 26)
        logoutMenu.Text = "Registration"
        ' 
        ' exitMenu
        ' 
        exitMenu.Name = "exitMenu"
        exitMenu.Size = New Size(224, 26)
        exitMenu.Text = "Grading System"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(224, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' gradesMenu
        ' 
        gradesMenu.Name = "gradesMenu"
        gradesMenu.Size = New Size(49, 24)
        gradesMenu.Text = "Edit"
        ' 
        ' signUpMenu
        ' 
        signUpMenu.Name = "signUpMenu"
        signUpMenu.Size = New Size(55, 24)
        signUpMenu.Text = "Help"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {NewToolStripButton, OpenToolStripButton, SaveToolStripButton, PrintToolStripButton, toolStripSeparator, CutToolStripButton, CopyToolStripButton, PasteToolStripButton, toolStripSeparator1, HelpToolStripButton})
        ToolStrip1.Location = New Point(0, 28)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(800, 27)
        ToolStrip1.TabIndex = 7
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' NewToolStripButton
        ' 
        NewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), Image)
        NewToolStripButton.ImageTransparentColor = Color.Magenta
        NewToolStripButton.Name = "NewToolStripButton"
        NewToolStripButton.Size = New Size(29, 24)
        NewToolStripButton.Text = "&New"
        ' 
        ' OpenToolStripButton
        ' 
        OpenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        OpenToolStripButton.Image = CType(resources.GetObject("OpenToolStripButton.Image"), Image)
        OpenToolStripButton.ImageTransparentColor = Color.Magenta
        OpenToolStripButton.Name = "OpenToolStripButton"
        OpenToolStripButton.Size = New Size(29, 24)
        OpenToolStripButton.Text = "&Open"
        ' 
        ' SaveToolStripButton
        ' 
        SaveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), Image)
        SaveToolStripButton.ImageTransparentColor = Color.Magenta
        SaveToolStripButton.Name = "SaveToolStripButton"
        SaveToolStripButton.Size = New Size(29, 24)
        SaveToolStripButton.Text = "&Save"
        ' 
        ' PrintToolStripButton
        ' 
        PrintToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), Image)
        PrintToolStripButton.ImageTransparentColor = Color.Magenta
        PrintToolStripButton.Name = "PrintToolStripButton"
        PrintToolStripButton.Size = New Size(29, 24)
        PrintToolStripButton.Text = "&Print"
        ' 
        ' toolStripSeparator
        ' 
        toolStripSeparator.Name = "toolStripSeparator"
        toolStripSeparator.Size = New Size(6, 27)
        ' 
        ' CutToolStripButton
        ' 
        CutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CutToolStripButton.Image = CType(resources.GetObject("CutToolStripButton.Image"), Image)
        CutToolStripButton.ImageTransparentColor = Color.Magenta
        CutToolStripButton.Name = "CutToolStripButton"
        CutToolStripButton.Size = New Size(29, 24)
        CutToolStripButton.Text = "C&ut"
        ' 
        ' CopyToolStripButton
        ' 
        CopyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        CopyToolStripButton.Image = CType(resources.GetObject("CopyToolStripButton.Image"), Image)
        CopyToolStripButton.ImageTransparentColor = Color.Magenta
        CopyToolStripButton.Name = "CopyToolStripButton"
        CopyToolStripButton.Size = New Size(29, 24)
        CopyToolStripButton.Text = "&Copy"
        ' 
        ' PasteToolStripButton
        ' 
        PasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        PasteToolStripButton.Image = CType(resources.GetObject("PasteToolStripButton.Image"), Image)
        PasteToolStripButton.ImageTransparentColor = Color.Magenta
        PasteToolStripButton.Name = "PasteToolStripButton"
        PasteToolStripButton.Size = New Size(29, 24)
        PasteToolStripButton.Text = "&Paste"
        ' 
        ' toolStripSeparator1
        ' 
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New Size(6, 27)
        ' 
        ' HelpToolStripButton
        ' 
        HelpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        HelpToolStripButton.Image = CType(resources.GetObject("HelpToolStripButton.Image"), Image)
        HelpToolStripButton.ImageTransparentColor = Color.Magenta
        HelpToolStripButton.Name = "HelpToolStripButton"
        HelpToolStripButton.Size = New Size(29, 24)
        HelpToolStripButton.Text = "He&lp"
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
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents CutToolStripButton As ToolStripButton
    Friend WithEvents CopyToolStripButton As ToolStripButton
    Friend WithEvents PasteToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HelpToolStripButton As ToolStripButton

End Class
