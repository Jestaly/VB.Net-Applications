Public Class ParentForm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub RegistrationFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationFormToolStripMenuItem.Click
        Dim registrationForm = New RegistrationForm()
        registrationForm.MdiParent = Me
        registrationForm.Show()
    End Sub
End Class