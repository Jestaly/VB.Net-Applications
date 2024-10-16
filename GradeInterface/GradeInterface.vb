Public Class GradeInterface
    Dim gradeForm As New GradeForm()
    Dim registerForm As New RegisterForm()
    Dim loginForm As New LoginForm()
    Private Sub gradesMenu_Click(sender As Object, e As EventArgs) Handles gradesMenu.Click

        gradeForm.MdiParent = Me
        gradeForm.Show()
    End Sub

    Private Sub signUpMenu_Click(sender As Object, e As EventArgs) Handles signUpMenu.Click
        registerForm.MdiParent = Me
        registerForm.Show()
    End Sub

    Private Sub exitMenu_Click(sender As Object, e As EventArgs) Handles exitMenu.Click
        End
    End Sub

    Private Sub loginMenu_Click(sender As Object, e As EventArgs) Handles loginMenu.Click

        LoginForm.MdiParent = Me
        loginForm.Show()
    End Sub

    Private Sub refreshButton_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        gradeForm.setDefaultForm()
        gradeForm.setDefaultFormFinal()
        gradeForm.studentNumberTextBox.Clear()
        gradeForm.studentNameTextBox.Clear()
        gradeForm.studentCourseTextBox.Clear()
        gradeForm.studentSectionTextBox.Clear()
        gradeForm.midtermPanel.Visible = False
        gradeForm.finalPanel.Visible = False
        gradeForm.nullMidtermPanel.Visible = False
        gradeForm.nullFinalPanel.Visible = False
        gradeForm.noRecordsYetPanel.Visible = False
        gradeForm.semGrade.Text = "5.00"
    End Sub
End Class
