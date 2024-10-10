Public Class GradeInterface

    Private Sub gradesMenu_Click(sender As Object, e As EventArgs) Handles gradesMenu.Click
        Dim gradeForm = New GradeForm
        gradeForm.MdiParent = Me
        gradeForm.Show()
    End Sub

    Private Sub signUpMenu_Click(sender As Object, e As EventArgs) Handles signUpMenu.Click
        Dim registerForm = New Form1
        registerForm.MdiParent = Me
        registerForm.Show()
    End Sub

    Private Sub exitMenu_Click(sender As Object, e As EventArgs) Handles exitMenu.Click
        End
    End Sub
End Class
