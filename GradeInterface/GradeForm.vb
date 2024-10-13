Public Class GradeForm
    Private attDouble, quizDouble, labExerDouble, caseStudyDouble, recitationDouble, examMidtermDouble As Double
    Private attStr, quizStr, labExerStr, caseStudyStr, recitationStr, examMidtermStr As String
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim student As New Student()
        Dim studentNumber As String = studentNumberTextBox.Text
        Dim studentName As String = studentNameTextBox.Text
        Dim studentCourse As String = studentCourseTextBox.Text
        Dim studentSection As String = studentSectionTextBox.Text
        Dim found As Boolean = False
        For i = 0 To student.studentNumArr.Length - 1
            If (studentNumber.Equals(student.studentNumArr(i))) Then
                studentNumberTextBox.Text = student.studentNumArr(i)
                studentNameTextBox.Text = student.studentNameArr(i)
                studentCourseTextBox.Text = student.studentCourseArr(i)
                studentSectionTextBox.Text = student.studentSectionArr(i)

                studentCourse = studentCourseTextBox.Text
                found = True
                Exit For
            End If

        Next

        If (Not found) Then
            MessageBox.Show("Student not found.")
            studentNumberTextBox.Clear()
            studentNameTextBox.Clear()
        End If

        courseChecker(studentCourse)

    End Sub
    Public Sub courseChecker(studentCourse)
        If (studentCourse.Equals("BSCS")) Then
            midtermCSPanel.Visible = True
            finalCSPanel.Visible = True
        ElseIf (studentCourse.Equals("BSN")) Then
            'midtermNPanel.Visible = True
            'finalNPanel.Visible = True
        ElseIf (studentCourse.Equals("BSCE")) Then
            'midtermCEPanel.Visible = True
            'finalCEPanel.Visible = True
        End If
    End Sub

    Private Sub clearCSMidtermButton_Click(sender As Object, e As EventArgs) Handles clearCSMidtermButton.Click
        attCSMidTextBox.Clear()
        quizCSMidTextBox.Clear()
        labExerCSMidTextBox.Clear()
        caseStudyCSMidTextBox.Clear()
        recitationCSMidTextBox.Clear()
        examCSMidTextBox.Clear()
    End Sub

    'CAUTION - KeyPresses dont have a backspace validator (MUST HAVE!)
    Private Sub attCSMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles attCSMidTextBox.KeyPress
        Try
            If (Not (e.KeyChar = ChrW(8))) Then
                attDouble = Integer.Parse(e.KeyChar)
                attStr &= attDouble
            End If
            If (Integer.Parse(attStr) < 0 Or Integer.Parse(attStr) > 5) Then
                e.Handled = True
                Console.Beep()
                attCSMidTextBox.Clear()
                attStr = ""
                attDouble = 0
            End If
        Catch ex As Exception
            e.Handled = True
            Console.Beep()
        End Try
    End Sub

    Private Sub quizCSMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quizCSMidTextBox.KeyPress
        Try
            If (Not (e.KeyChar = ChrW(8))) Then
                quizDouble = Integer.Parse(e.KeyChar)
                quizStr &= quizDouble
            End If
            If (Integer.Parse(quizStr) < 0 Or Integer.Parse(quizStr) > 15) Then
                e.Handled = True
                Console.Beep()
                quizCSMidTextBox.Clear()
                quizStr = ""
                quizDouble = 0
            End If
        Catch ex As Exception
            e.Handled = True
            Console.Beep()
        End Try
    End Sub

    Private Sub labExerCSMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles labExerCSMidTextBox.KeyPress
        Try
            If (Not (e.KeyChar = ChrW(8))) Then
                labExerDouble = Integer.Parse(e.KeyChar)
                labExerStr &= labExerDouble
            End If
            If (Integer.Parse(labExerStr) < 0 Or Integer.Parse(labExerStr) > 20) Then
                e.Handled = True
                Console.Beep()
                labExerCSMidTextBox.Clear()
                labExerStr = ""
                labExerDouble = 0
            End If
        Catch ex As Exception
            e.Handled = True
            Console.Beep()
        End Try
    End Sub

    Private Sub caseStudyCSMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles caseStudyCSMidTextBox.KeyPress
        Try
            If (Not (e.KeyChar = ChrW(8))) Then
                caseStudyDouble = Integer.Parse(e.KeyChar)
                caseStudyStr &= caseStudyDouble
            End If
            If (Integer.Parse(caseStudyStr) < 0 Or Integer.Parse(caseStudyStr) > 20) Then
                e.Handled = True
                Console.Beep()
                caseStudyCSMidTextBox.Clear()
                caseStudyStr = ""
                caseStudyDouble = 0
            End If
        Catch ex As Exception
            e.Handled = True
            Console.Beep()
        End Try
    End Sub

    Private Sub recitationCSMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles recitationCSMidTextBox.KeyPress
        Try
            If (Not (e.KeyChar = ChrW(8))) Then
                recitationDouble = Integer.Parse(e.KeyChar)
                recitationStr &= recitationDouble
            End If
            If (Integer.Parse(recitationStr) < 0 Or Integer.Parse(recitationStr) > 10) Then
                e.Handled = True
                Console.Beep()
                recitationCSMidTextBox.Clear()
                recitationStr = ""
                recitationDouble = 0
            End If
        Catch ex As Exception
            e.Handled = True
            Console.Beep()
        End Try
    End Sub

    Private Sub examCSMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles examCSMidTextBox.KeyPress
        Try
            If (Not (e.KeyChar = ChrW(8))) Then
                examMidtermDouble = Integer.Parse(e.KeyChar)
                examMidtermStr &= examMidtermDouble
            End If
            If (Integer.Parse(examMidtermStr) < 0 Or Integer.Parse(examMidtermStr) > 30) Then
                e.Handled = True
                Console.Beep()
                examCSMidTextBox.Clear()
                examMidtermStr = ""
                examMidtermDouble = 0
            End If

        Catch ex As Exception
            e.Handled = True
            Console.Beep()
        End Try
    End Sub
End Class

Public Class Student
    Public studentNumArr() As String = {"23-00219", "23-00418", "22-01024", "21-00325"}
    Public studentNameArr() As String = {"JESTALY JOSEPH CASTILLO", "CAL NEWPORT", "ROBERT KIYOSAKI", "MICHAEL GRANT"}
    Public studentCourseArr() As String = {"BSCS", "BSN", "BSCE", "BSCS"}
    Public studentSectionArr() As String = {"2A", "1B", "3F", "1A"}




End Class