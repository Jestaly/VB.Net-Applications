<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ParentForm
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
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        RegistrationFormToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, ExitToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, SaveToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RegistrationFormToolStripMenuItem})
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(224, 26)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' RegistrationFormToolStripMenuItem
        ' 
        RegistrationFormToolStripMenuItem.Name = "RegistrationFormToolStripMenuItem"
        RegistrationFormToolStripMenuItem.Size = New Size(210, 26)
        RegistrationFormToolStripMenuItem.Text = "Registration Form"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.S
        SaveToolStripMenuItem.Size = New Size(224, 26)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(49, 24)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.X
        ExitToolStripMenuItem.Size = New Size(47, 24)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' ParentForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        ForeColor = SystemColors.ControlText
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "ParentForm"
        Text = "Parent Form"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrationFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem

End Class
