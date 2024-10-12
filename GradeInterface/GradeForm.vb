Public Class GradeForm

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim student As New Student()
        Dim studentNumber As String = studentNumberTextBox.Text
        Dim studentName As String = studentNameTextBox.Text
        'Dim studentCourse As String = studentCourseTextBox.Text
        'Dim studentSection As String = studentSectionTextBox.Text

        For i = 0 To student.studentNumArr.Length - 1

            If (studentNumber.Equals(student.studentNumArr(i))) Then
                studentName = student.studentNameArr(i)
                'studentCourse = student.studentCourseArr(i)
                'studentSection = student.studentSectionArr(i)
                Exit For
            End If
        Next

    End Sub

    Private Sub GradeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

Public Class Student
    Public studentNumArr() As String = {"23-00219", "23-00418", "22-01024"}
    Public studentNameArr() As String = {"Jestaly Joseph Castillo", "Cal Newport", "Robert Kiyosaki"}
    'Public studentCourseArr() As String = {"BSCS", "BSN", "BSCE"}
    'Public studentSectionArr() As String = {"2A", "1B", "3F"}


End Class