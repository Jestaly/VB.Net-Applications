Public Class GradeInterface

    Private Sub gradesMenu_Click(sender As Object, e As EventArgs) Handles gradesMenu.Click
        Dim gradeForm As New GradeForm()
        gradeForm.MdiParent = Me
        gradeForm.Show()
    End Sub

    Private Sub signUpMenu_Click(sender As Object, e As EventArgs) Handles signUpMenu.Click
        Dim registerForm As New Form1()
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
End Class
