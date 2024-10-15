Public Class GradeInterface
    Dim gradeForm As New GradeForm()
    Private Sub gradesMenu_Click(sender As Object, e As EventArgs) Handles gradesMenu.Click
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

    Private Sub GradeInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loginMenu_Click(sender As Object, e As EventArgs) Handles loginMenu.Click
        Dim loginForm As New LoginForm()
        loginForm.MdiParent = Me
        loginForm.Show()
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        gradeForm.setDefaultForm()
        gradeForm.studentNumberTextBox.Clear()
        gradeForm.studentNameTextBox.Clear()
        gradeForm.studentCourseTextBox.Clear()
        gradeForm.studentSectionTextBox.Clear()
        gradeForm.midtermPanel.Visible = False
        gradeForm.finalPanel.Visible = False
        gradeForm.nullMidtermPanel.Visible = False
        gradeForm.nullFinalPanel.Visible = False
    End Sub
End Class
