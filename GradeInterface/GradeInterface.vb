Public Class GradeInterface




    Public Sub showGradeForm()
        Dim gradeForm As New GradeForm()
        gradeForm.MdiParent = Me
        gradeForm.Show()
    End Sub
    Public Sub showRegisterForm()
        Dim registerForm As New RegisterForm()
        registerForm.MdiParent = Me
        registerForm.Show()
    End Sub
    Public Sub showLoginForm()
        Dim loginForm As New LoginForm()
        loginForm.MdiParent = Me
        loginForm.Show()
    End Sub
    Private Sub gradesMenu_Click(sender As Object, e As EventArgs) Handles gradesMenu.Click
        Dim gradeForm As New GradeForm()
        gradeForm.MdiParent = Me
        gradeForm.Show()
    End Sub

    Private Sub signUpMenu_Click(sender As Object, e As EventArgs) Handles signUpMenu.Click
        Dim registerForm As New RegisterForm()
        registerForm.MdiParent = Me
        registerForm.Show()
    End Sub

    Private Sub exitMenu_Click(sender As Object, e As EventArgs) Handles exitMenu.Click
        End
    End Sub

    Private Sub loginMenu_Click(sender As Object, e As EventArgs) Handles loginMenu.Click
        Dim loginForm As New LoginForm()
        loginForm.MdiParent = Me
        loginForm.Show()
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        GradeForm.setDefaultForm()
        GradeForm.setDefaultFormFinal()
        GradeForm.studentNumberTextBox.Clear()
        GradeForm.studentNameTextBox.Clear()
        GradeForm.studentCourseTextBox.Clear()
        GradeForm.studentSectionTextBox.Clear()
        GradeForm.midtermPanel.Visible = False
        GradeForm.finalPanel.Visible = False
        GradeForm.nullMidtermPanel.Visible = False
        GradeForm.nullFinalPanel.Visible = False
        GradeForm.noRecordsYetPanel.Visible = False
        GradeForm.semGrade.Text = "0.00"
    End Sub

    Private Sub GradeInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showRegisterForm()
    End Sub

    Private Sub logoutMenu_Click(sender As Object, e As EventArgs) Handles logoutMenu.Click
        gradesMenu.Enabled = False
        showLoginForm()
    End Sub
End Class
