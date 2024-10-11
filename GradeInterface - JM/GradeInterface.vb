Public Class GradeInterface

    Private Sub exitMenu_Click(sender As Object, e As EventArgs) Handles exitMenu.Click
        Dim gradeForm = New GradeForm
        gradeForm.MdiParent = Me
        gradeForm.Show()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub logoutMenu_Click(sender As Object, e As EventArgs) Handles logoutMenu.Click
        Dim RegisForm = New exercise3
        RegisForm.MdiParent = Me
        RegisForm.Show()/
    End Sub

    Private Sub loginMenu_Click(sender As Object, e As EventArgs) Handles loginMenu.Click
        Dim loginFormForm = New LoginFormForm
        loginFormForm.MdiParent = Me
        loginFormForm.Show()
    End Sub
End Class
