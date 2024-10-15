
Public Class GradeForm
    Private attDouble, quizDouble, labExerDouble, caseStudyDouble, recitationDouble, examMidtermDouble As Double
    Private attStr, quizStr, labExerStr, caseStudyStr, recitationStr, examMidtermStr As String
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        setDefaultForm()

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
            studentNumberTextBox.Clear()
            studentNameTextBox.Clear()
            studentCourseTextBox.Clear()
            studentSectionTextBox.Clear()
            studentCourse = ""
        End If

        courseChecker(studentCourse)

    End Sub

    'Private attDouble, quizDouble, labExerDouble, caseStudyDouble, recitationDouble, examMidtermDouble As Double
    'Private attStr, quizStr, labExerStr, caseStudyStr, recitationStr, examMidtermStr As String
    Public Sub setDefaultForm()
        attMidTextBox.Clear()
        quizMidTextBox.Clear()
        labExerMidTextBox.Clear()
        caseStudyMidTextBox.Clear()
        recitationMidTextBox.Clear()
        examMidTextBox.Clear()
        midtermGradeLabel.Text = "MIDTERM GRADE: 0%"
        midtermGrade.Text = "00"
        attendanceMidLabel.Text = "Attendance %"
        quizMidLabel.Text = "Quizzes %"
        labExerMidLabel.Text = "Lab Exercise %"
        caseStudyMidLabel.Text = "Case Study %"
        recitationMidLabel.Text = "Recitation %"
        examMidLabel.Text = "Midterm Exam %"
        attDouble = 0
        quizDouble = 0
        labExerDouble = 0
        caseStudyDouble = 0
        recitationDouble = 0
        examMidtermDouble = 0
        attStr = ""
        quizStr = ""
        labExerStr = ""
        caseStudyStr = ""
        recitationStr = ""
        examMidtermStr = ""
        attPerc = 0
        quizPerc = 0
        labExerPerc = 0
        caseStudyPerc = 0
        recitationPerc = 0
        examMidtermPerc = 0
        attPercStr = ""
        quizPercStr = ""
        labExerPercStr = ""
        caseStudyPercStr = ""
        recitationPercStr = ""
        examMidtermPercStr = ""
        percentageName = ""
        totalPercentage = 0
        percentageTracker = 0

        'Private attPerc, quizPerc, labExerPerc, caseStudyPerc, recitationPerc, examMidtermPerc As Integer
        'Private attPercStr, quizPercStr, labExerPercStr, caseStudyPercStr, recitationPercStr, examMidtermPercStr As String
        'Private percentageName As String
        'Private totalPercentage As Double

    End Sub
    Public Sub courseChecker(studentCourse)
        If (studentCourse.Equals("BSCS")) Then
            midtermPanel.Visible = True
            finalPanel.Visible = True
            midtermPanel.BackColor = Color.FromArgb(16, 55, 92)
            finalPanel.BackColor = Color.FromArgb(16, 55, 92)
        ElseIf (studentCourse.Equals("BSN")) Then
            midtermPanel.Visible = True
            finalPanel.Visible = True
            midtermPanel.BackColor = Color.FromArgb(210, 100, 154)
            finalPanel.BackColor = Color.FromArgb(210, 100, 154)
        ElseIf (studentCourse.Equals("BSCE")) Then
            midtermPanel.Visible = True
            finalPanel.Visible = True
            midtermPanel.BackColor = Color.FromArgb(179, 19, 18)
            finalPanel.BackColor = Color.FromArgb(179, 19, 18)
        Else
            midtermPanel.Visible = False
            finalPanel.Visible = False
            nullMidtermPanel.Visible = True
            nullFinalPanel.Visible = True
        End If
    End Sub

    Private Sub clearCSMidtermButton_Click(sender As Object, e As EventArgs) Handles clearMidtermButton.Click
        attMidTextBox.Clear()
        quizMidTextBox.Clear()
        labExerMidTextBox.Clear()
        caseStudyMidTextBox.Clear()
        recitationMidTextBox.Clear()
        examMidTextBox.Clear()
    End Sub

    Private Sub attCSMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles attMidTextBox.KeyPress
        Try
            If (e.KeyChar = ".") Then
                attStr = attMidTextBox.Text & "." & "0"
            End If
            If (Not (e.KeyChar = ChrW(8)) And Not (e.KeyChar = ".")) Then
                attStr = attMidTextBox.Text
                attDouble = Double.Parse(e.KeyChar)
                attStr &= attDouble
            End If
            If (Double.Parse(attStr) < 0 Or Double.Parse(attStr) > Integer.Parse(attPercStr)) Then
                e.Handled = True
                Console.Beep()
                attMidTextBox.Clear()
                attStr = ""
            End If
        Catch ex As Exception
            e.Handled = True
            Console.Beep()
        End Try
    End Sub

    Private Sub quizCSMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quizMidTextBox.KeyPress
        Try
            If (e.KeyChar = ".") Then
                quizStr = quizMidTextBox.Text & "." & "0"
            End If
            If (Not (e.KeyChar = ChrW(8)) And Not (e.KeyChar = ".")) Then
                quizStr = quizMidTextBox.Text
                quizDouble = Integer.Parse(e.KeyChar)
                quizStr &= quizDouble
            End If
            If (Double.Parse(quizStr) < 0 Or Double.Parse(quizStr) > Double.Parse(quizPercStr)) Then
                e.Handled = True
                Console.Beep()
                quizMidTextBox.Clear()
                quizStr = ""
            End If
        Catch ex As Exception
            e.Handled = True
            Console.Beep()
        End Try
    End Sub

    Private Sub labExerCSMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles labExerMidTextBox.KeyPress
        Try
            If (e.KeyChar = ".") Then
                labExerStr = labExerMidTextBox.Text & "." & "0"
            End If
            If (Not (e.KeyChar = ChrW(8)) And Not (e.KeyChar = ".")) Then
                labExerStr = labExerMidTextBox.Text
                labExerDouble = Integer.Parse(e.KeyChar)
                labExerStr &= labExerDouble
            End If
            If (Double.Parse(labExerStr) < 0 Or Double.Parse(labExerStr) > Double.Parse(labExerPercStr)) Then
                e.Handled = True
                Console.Beep()
                labExerMidTextBox.Clear()
                labExerStr = ""
            End If
        Catch ex As Exception
            e.Handled = True
            Console.Beep()
        End Try
    End Sub

    Private Sub caseStudyCSMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles caseStudyMidTextBox.KeyPress
        Try
            If (e.KeyChar = ".") Then
                caseStudyStr = caseStudyMidTextBox.Text & "." & "0"
            End If
            If (Not (e.KeyChar = ChrW(8)) And Not (e.KeyChar = ".")) Then
                caseStudyStr = caseStudyMidTextBox.Text
                caseStudyDouble = Integer.Parse(e.KeyChar)
                caseStudyStr &= caseStudyDouble
            End If
            If (Double.Parse(caseStudyStr) < 0 Or Double.Parse(caseStudyStr) > Double.Parse(caseStudyPercStr)) Then
                e.Handled = True
                Console.Beep()
                caseStudyMidTextBox.Clear()
                caseStudyStr = ""
            End If
        Catch ex As Exception
            e.Handled = True
            Console.Beep()
        End Try
    End Sub

    Private Sub recitationCSMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles recitationMidTextBox.KeyPress
        Try
            If (e.KeyChar = ".") Then
                recitationStr = recitationMidTextBox.Text & "." & "0"
            End If
            If (Not (e.KeyChar = ChrW(8)) And Not (e.KeyChar = ".")) Then
                recitationStr = recitationMidTextBox.Text
                recitationDouble = Integer.Parse(e.KeyChar)
                recitationStr &= recitationDouble
            End If

            If (Double.Parse(recitationStr) < 0 Or Double.Parse(recitationStr) > Double.Parse(recitationPercStr)) Then
                e.Handled = True
                Console.Beep()
                recitationMidTextBox.Clear()
                recitationStr = ""
            End If
        Catch ex As Exception
            e.Handled = True
            Console.Beep()
        End Try
    End Sub

    Private Sub examCSMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles examMidTextBox.KeyPress
        Try
            If (e.KeyChar = ".") Then
                examMidtermStr = examMidTextBox.Text & "." & "0"
            End If
            If (Not (e.KeyChar = ChrW(8)) And Not (e.KeyChar = ".")) Then
                examMidtermStr = examMidTextBox.Text
                examMidtermDouble = Integer.Parse(e.KeyChar)
                examMidtermStr &= examMidtermDouble
            End If
            If (Double.Parse(examMidtermStr) < 0 Or Double.Parse(examMidtermStr) > Double.Parse(examMidtermPercStr)) Then
                e.Handled = True
                Console.Beep()
                examMidTextBox.Clear()
                examMidtermStr = ""
            End If

        Catch ex As Exception
            e.Handled = True
            Console.Beep()
        End Try
    End Sub

    Private percentageTracker As Integer
    Public Function setPercentage(percentage As Integer, percentageStr As String, percentageName As String)
        While True
            Try
                percentageStr = InputBox("Enter " & percentageName & " Percentage")
                percentage = Integer.Parse(percentageStr)
                If (percentage >= 0) Then
                    percentageTracker += 1
                    Return percentageStr
                End If
                MessageBox.Show("No negative numbers allowed.")
            Catch ex As Exception
                If (percentageStr.Equals("")) Then
                    Return percentageStr
                End If
                MessageBox.Show("Only numbers Allowed.")
            End Try
        End While
        Return percentageStr
    End Function

    Private attPerc, quizPerc, labExerPerc, caseStudyPerc, recitationPerc, examMidtermPerc As Integer
    Private attPercStr, quizPercStr, labExerPercStr, caseStudyPercStr, recitationPercStr, examMidtermPercStr As String
    Private percentageName As String
    Private totalPercentage As Double
    Private Sub setPercentageMidButton_Click(sender As Object, e As EventArgs) Handles setPercentageMidButton.Click

        For i = percentageTracker To 5
            Select Case i
                Case 0
                    percentageName = "Attendance"
                    attPercStr = setPercentage(attPerc, attPercStr, percentageName)
                    If (attPercStr.Equals("")) Then
                        Exit Sub
                    End If
                    attPerc = attPercStr
                Case 1
                    percentageName = "Quiz"
                    quizPercStr = setPercentage(quizPerc, quizPercStr, percentageName)
                    If (quizPercStr.Equals("")) Then
                        Exit Sub
                    End If
                    quizPerc = quizPercStr
                Case 2
                    percentageName = "Laboratory Exercise"
                    labExerPercStr = setPercentage(labExerPerc, labExerPercStr, percentageName)
                    If (labExerPercStr.Equals("")) Then
                        Exit Sub
                    End If
                    labExerPerc = labExerPercStr
                Case 3
                    percentageName = "Case Study"
                    caseStudyPercStr = setPercentage(caseStudyPerc, caseStudyPercStr, percentageName)
                    If (caseStudyPercStr.Equals("")) Then
                        Exit Sub
                    End If
                    caseStudyPerc = caseStudyPercStr
                Case 4
                    percentageName = "Recitation"
                    recitationPercStr = setPercentage(recitationPerc, recitationPercStr, percentageName)
                    If (recitationPercStr.Equals("")) Then
                        Exit Sub
                    End If
                    recitationPerc = recitationPercStr
                Case 5
                    percentageName = "Midterm Exam"
                    examMidtermPercStr = setPercentage(examMidtermPerc, examMidtermPercStr, percentageName)
                    If (examMidtermPercStr.Equals("")) Then
                        Exit Sub
                    End If
                    examMidtermPerc = examMidtermPercStr
            End Select
            If (percentageTracker > 5) Then
                percentageTracker = 0
            End If
        Next
        totalPercentage = attPerc + quizPerc + labExerPerc + caseStudyPerc + recitationPerc + examMidtermPerc
        MessageBox.Show(totalPercentage)

        If (Not (totalPercentage = 100)) Then
            MessageBox.Show("Total Percentage must equal to 100.")
            attPercStr = ""
            quizPercStr = ""
            labExerPercStr = ""
            caseStudyPercStr = ""
            recitationPercStr = ""
            examMidtermPercStr = ""
            totalPercentage = 0
        End If

        attendanceMidLabel.Text = "Attendance " & attPercStr & "%"
        quizMidLabel.Text = "Quizzes " & quizPercStr & "%"
        labExerMidLabel.Text = "Lab Exercise " & labExerPercStr & "%"
        caseStudyMidLabel.Text = "Case Study " & caseStudyPercStr & "%"
        recitationMidLabel.Text = "Recitation " & recitationPercStr & "%"
        examMidLabel.Text = "Midterm Exam " & examMidtermPercStr & "%"
    End Sub
    Private midtermPercentage As Double
    'Private attDouble, quizDouble, labExerDouble, caseStudyDouble, recitationDouble, examMidtermDouble As Double
    'Private attStr, quizStr, labExerStr, caseStudyStr, recitationStr, examMidtermStr As String
    Private Sub computeCSMidtermButton_Click(sender As Object, e As EventArgs) Handles computeMidtermButton.Click
        attDouble = Double.Parse(attStr)
        quizDouble = Double.Parse(quizStr)
        labExerDouble = Double.Parse(labExerStr)
        caseStudyDouble = Double.Parse(caseStudyStr)
        recitationDouble = Double.Parse(recitationStr)
        examMidtermDouble = Double.Parse(examMidtermStr)

        midtermPercentage = attDouble + quizDouble + labExerDouble + caseStudyDouble + recitationDouble + examMidtermDouble
        midtermGrade.Text = midtermPercentage
        midtermGradeLabel.Text = "MIDTERM GRADE: " & (midtermPercentage * 0.5) & "%"
    End Sub
End Class

Public Class Student
    Public studentNumArr() As String = {"23-00219", "23-00418", "22-01024", "21-00325"}
    Public studentNameArr() As String = {"JESTALY JOSEPH CASTILLO", "CAL NEWPORT", "ROBERT KIYOSAKI", "MICHAEL GRANT"}
    Public studentCourseArr() As String = {"BSCS", "BSN", "BSCE", "BSCS"}
    Public studentSectionArr() As String = {"2A", "1B", "3F", "1A"}

End Class