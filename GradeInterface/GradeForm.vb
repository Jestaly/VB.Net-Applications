
Public Class GradeForm
    'Midterm Variables
    Private attDouble, quizDouble, labExerDouble, caseStudyDouble, recitationDouble, examMidtermDouble As Double
    Private attStr, quizStr, labExerStr, caseStudyStr, recitationStr, examMidtermStr As String

    'Final Variables
    Private attDoubleFin, quizDoubleFin, labExerDoubleFin, caseStudyDoubleFin, examFinalDouble As Double
    Private attStrFin, quizStrFin, labExerStrFin, caseStudyStrFin, examFinalStr As String

    Private studentOrder As Integer
    Dim student As New Student()

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click

        studentOrder = 0
        semGrade.Text = "5.00"
        Dim studentNumber As String = studentNumberTextBox.Text
        Dim studentName As String = studentNameTextBox.Text
        Dim studentCourse As String = studentCourseTextBox.Text
        Dim studentSection As String = studentSectionTextBox.Text
        Dim found As Boolean = False
        For i = studentOrder To student.studentNumArr.Length - 1
            If (studentNumber.Equals(student.studentNumArr(i))) Then
                studentNumberTextBox.Text = student.studentNumArr(i)
                studentNameTextBox.Text = student.studentNameArr(i)
                studentCourseTextBox.Text = student.studentCourseArr(i)
                studentSectionTextBox.Text = student.studentSectionArr(i)
                studentOrder = i
                If (student.studentSaveArr(i)) Then
                    attMidTextBox.Text = student.studentAttendanceArr(i)
                    quizMidTextBox.Text = student.studentQuizzesArr(i)
                    labExerMidTextBox.Text = student.studentLabExerciseArr(i)
                    caseStudyMidTextBox.Text = student.studentCaseStudyArr(i)
                    recitationMidTextBox.Text = student.studentRecitationArr(i)
                    examMidTextBox.Text = student.studentMidtermExamArr(i)
                    midtermGradeLabel.Text = student.studentMidtermGradeArr(i)
                    midtermPercLabel.Text = "MIDTERM GRADE: " & student.studentMidtermPercArr(i) & "%"
                    attPerc = student.studentAttPercArr(i)
                    quizPerc = student.studentQuizPercArr(i)
                    labExerPerc = student.studentLabExerPercArr(i)
                    caseStudyPerc = student.studentCaseStudyPercArr(i)
                    recitationPerc = student.studentRecitationPercArr(i)
                    examMidtermPerc = student.studentMidtermExamPercArr(i)
                    attPercStr = student.studentAttPercArr(i)
                    quizPercStr = student.studentQuizPercArr(i)
                    labExerPercStr = student.studentLabExerPercArr(i)
                    caseStudyPercStr = student.studentCaseStudyPercArr(i)
                    recitationPercStr = student.studentRecitationPercArr(i)
                    examMidtermPercStr = student.studentMidtermExamPercArr(i)
                    attendanceMidLabel.Text = "Attendance " & student.studentAttPercArr(i) & "%"
                    quizMidLabel.Text = "Quizzes " & student.studentQuizPercArr(i) & "%"
                    labExerMidLabel.Text = "Lab Exercise " & student.studentLabExerPercArr(i) & "%"
                    caseStudyMidLabel.Text = "Case Study " & student.studentCaseStudyPercArr(i) & "%"
                    recitationMidLabel.Text = "Recitation " & student.studentRecitationPercArr(i) & "%"
                    examMidLabel.Text = "Midterm Exam " & student.studentMidtermExamPercArr(i) & "%"
                    attStr = student.studentAttendanceArr(i)
                    quizStr = student.studentQuizzesArr(i)
                    labExerStr = student.studentLabExerciseArr(i)
                    caseStudyStr = student.studentCaseStudyArr(i)
                    recitationStr = student.studentRecitationArr(i)
                    examMidtermStr = student.studentMidtermExamArr(i)
                    attMidTextBox.Enabled = True
                    quizMidTextBox.Enabled = True
                    labExerMidTextBox.Enabled = True
                    caseStudyMidTextBox.Enabled = True
                    recitationMidTextBox.Enabled = True
                    examMidTextBox.Enabled = True
                    noRecordsYetPanel.Visible = False
                Else
                    setDefaultForm()
                End If

                If (student.studentSaveArrFin(i)) Then
                    attFinTextBox.Text = student.studentAttendanceArrFin(i)
                    quizFinTextBox.Text = student.studentQuizzesArrFin(i)
                    labExerFinTextBox.Text = student.studentLabExerciseArrFin(i)
                    caseStudyFinTextBox.Text = student.studentCaseStudyArrFin(i)
                    examFinTextBox.Text = student.studentFinalExamArr(i)
                    FinalGradeLabel.Text = student.studentFinalGradeArr(i)
                    finalPercLabel.Text = "FINAL GRADE: " & student.studentFinalPercArr(i) & "%"
                    attPercFin = student.studentAttPercArrFin(i)
                    quizPercFin = student.studentQuizPercArrFin(i)
                    labExerPercFin = student.studentLabExerPercArrFin(i)
                    caseStudyPercFin = student.studentCaseStudyPercArrFin(i)
                    examFinalPerc = student.studentFinalExamPercArr(i)
                    attPercStrFin = student.studentAttPercArrFin(i)
                    quizPercStrFin = student.studentQuizPercArrFin(i)
                    labExerPercStrFin = student.studentLabExerPercArrFin(i)
                    caseStudyPercStrFin = student.studentCaseStudyPercArrFin(i)
                    examFinalPercStr = student.studentFinalExamPercArr(i)
                    attendanceFinLabel.Text = "Attendance " & student.studentAttPercArrFin(i) & "%"
                    quizFinLabel.Text = "Quizzes " & student.studentQuizPercArrFin(i) & "%"
                    labExerFinLabel.Text = "Lab Exercise " & student.studentLabExerPercArrFin(i) & "%"
                    caseStudyFinLabel.Text = "Case Study / Project " & student.studentCaseStudyPercArrFin(i) & "%"
                    examFinLabel.Text = "Final Exam " & student.studentFinalExamPercArr(i) & "%"
                    attStrFin = student.studentAttendanceArrFin(i)
                    quizStrFin = student.studentQuizzesArrFin(i)
                    labExerStrFin = student.studentLabExerciseArrFin(i)
                    caseStudyStrFin = student.studentCaseStudyArrFin(i)
                    examFinalStr = student.studentFinalExamArr(i)
                    attFinTextBox.Enabled = True
                    quizFinTextBox.Enabled = True
                    labExerFinTextBox.Enabled = True
                    caseStudyFinTextBox.Enabled = True
                    examFinTextBox.Enabled = True
                    noRecordsYetPanel.Visible = False

                    semGrade.Text = student.studentSemestralGrade(i)
                Else
                    setDefaultFormFinal()
                End If

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
            nullRecordMidterm.Visible = True
            nullRecordFinal.Visible = True
            noRecordsYetPanel.Visible = False


        End If

        courseChecker(studentCourse)

    End Sub

    Public Sub setDefaultForm()
        attMidTextBox.Clear()
        quizMidTextBox.Clear()
        labExerMidTextBox.Clear()
        caseStudyMidTextBox.Clear()
        recitationMidTextBox.Clear()
        examMidTextBox.Clear()
        midtermPercLabel.Text = "MIDTERM GRADE: 0%"
        midtermGradeLabel.Text = "00"
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
        attMidTextBox.Enabled = False
        quizMidTextBox.Enabled = False
        labExerMidTextBox.Enabled = False
        caseStudyMidTextBox.Enabled = False
        recitationMidTextBox.Enabled = False
        examMidTextBox.Enabled = False
        noRecordsYetPanel.Visible = True
        nullRecordMidterm.Visible = False
        nullRecordFinal.Visible = False
        finalPanel.Visible = False

    End Sub

    Public Sub setDefaultFormFinal()
        attFinTextBox.Clear()
        quizFinTextBox.Clear()
        labExerFinTextBox.Clear()
        caseStudyFinTextBox.Clear()
        examFinTextBox.Clear()
        finalPercLabel.Text = "FINAL GRADE: 0%"
        FinalGradeLabel.Text = "00"
        attendanceFinLabel.Text = "Attendance %"
        quizFinLabel.Text = "Quizzes %"
        labExerFinLabel.Text = "Lab Exercise %"
        caseStudyFinLabel.Text = "Case Study %"
        examFinLabel.Text = "Final Exam %"
        attDoubleFin = 0
        quizDoubleFin = 0
        labExerDoubleFin = 0
        caseStudyDoubleFin = 0
        examFinalDouble = 0
        attStrFin = ""
        quizStrFin = ""
        labExerStrFin = ""
        caseStudyStrFin = ""
        examFinalStr = ""
        attPercFin = 0
        quizPercFin = 0
        labExerPercFin = 0
        caseStudyPercFin = 0
        examFinalPerc = 0
        attPercStrFin = ""
        quizPercStrFin = ""
        labExerPercStrFin = ""
        caseStudyPercStrFin = ""
        examFinalPercStr = ""
        percentageNameFin = ""
        totalPercentageFin = 0
        percentageTrackerFin = 0
        attFinTextBox.Enabled = False
        quizFinTextBox.Enabled = False
        labExerFinTextBox.Enabled = False
        caseStudyFinTextBox.Enabled = False
        examFinTextBox.Enabled = False

    End Sub

    Public Sub courseChecker(studentCourse)
        If (studentCourse.Equals("BSCS")) Then
            midtermPanel.Visible = True
            If (student.studentSaveArr(studentOrder)) Then
                finalPanel.Visible = True
            End If
            midtermPanel.BackColor = Color.FromArgb(16, 55, 92)
            finalPanel.BackColor = Color.FromArgb(16, 55, 92)
        ElseIf (studentCourse.Equals("BSN")) Then
            midtermPanel.Visible = True
            If (student.studentSaveArr(studentOrder)) Then
                finalPanel.Visible = True
            End If
            midtermPanel.BackColor = Color.FromArgb(210, 100, 154)
            finalPanel.BackColor = Color.FromArgb(210, 100, 154)
        ElseIf (studentCourse.Equals("BSCE")) Then
            midtermPanel.Visible = True
            If (student.studentSaveArr(studentOrder)) Then
                finalPanel.Visible = True
            End If
            midtermPanel.BackColor = Color.FromArgb(179, 19, 18)
            finalPanel.BackColor = Color.FromArgb(179, 19, 18)
        Else
            midtermPanel.Visible = False
            finalPanel.Visible = False
            nullMidtermPanel.Visible = True
            nullFinalPanel.Visible = True
        End If
    End Sub

    Private Sub clearMidtermButton_Click(sender As Object, e As EventArgs) Handles clearMidtermButton.Click
        attMidTextBox.Clear()
        quizMidTextBox.Clear()
        labExerMidTextBox.Clear()
        caseStudyMidTextBox.Clear()
        recitationMidTextBox.Clear()
        examMidTextBox.Clear()
    End Sub

    Private Sub attMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles attMidTextBox.KeyPress
        Try
            If e.KeyChar = "." Then
                attStr = attMidTextBox.Text & "." & "0"
            End If
            If Not e.KeyChar = ChrW(8) And Not e.KeyChar = "." Then
                attStr = attMidTextBox.Text
                attDouble = Double.Parse(e.KeyChar)
                attStr &= attDouble
            End If
            If Double.Parse(attStr) < 0 Or Double.Parse(attStr) > Integer.Parse(attPercStr) Then
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

    Private Sub quizMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quizMidTextBox.KeyPress
        Try
            If e.KeyChar = "." Then
                quizStr = quizMidTextBox.Text & "." & "0"
            End If
            If Not e.KeyChar = ChrW(8) And Not e.KeyChar = "." Then
                quizStr = quizMidTextBox.Text
                quizDouble = Integer.Parse(e.KeyChar)
                quizStr &= quizDouble
            End If
            If Double.Parse(quizStr) < 0 Or Double.Parse(quizStr) > Double.Parse(quizPercStr) Then
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

    Private Sub labExerMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles labExerMidTextBox.KeyPress
        Try
            If e.KeyChar = "." Then
                labExerStr = labExerMidTextBox.Text & "." & "0"
            End If
            If Not e.KeyChar = ChrW(8) And Not e.KeyChar = "." Then
                labExerStr = labExerMidTextBox.Text
                labExerDouble = Integer.Parse(e.KeyChar)
                labExerStr &= labExerDouble
            End If
            If Double.Parse(labExerStr) < 0 Or Double.Parse(labExerStr) > Double.Parse(labExerPercStr) Then
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

    Private Sub caseStudyMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles caseStudyMidTextBox.KeyPress
        Try
            If e.KeyChar = "." Then
                caseStudyStr = caseStudyMidTextBox.Text & "." & "0"
            End If
            If Not e.KeyChar = ChrW(8) And Not e.KeyChar = "." Then
                caseStudyStr = caseStudyMidTextBox.Text
                caseStudyDouble = Integer.Parse(e.KeyChar)
                caseStudyStr &= caseStudyDouble
            End If
            If Double.Parse(caseStudyStr) < 0 Or Double.Parse(caseStudyStr) > Double.Parse(caseStudyPercStr) Then
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

    Private Sub recitationMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles recitationMidTextBox.KeyPress
        Try
            If e.KeyChar = "." Then
                recitationStr = recitationMidTextBox.Text & "." & "0"
            End If
            If Not e.KeyChar = ChrW(8) And Not e.KeyChar = "." Then
                recitationStr = recitationMidTextBox.Text
                recitationDouble = Integer.Parse(e.KeyChar)
                recitationStr &= recitationDouble
            End If

            If Double.Parse(recitationStr) < 0 Or Double.Parse(recitationStr) > Double.Parse(recitationPercStr) Then
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

    Private Sub examMidTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles examMidTextBox.KeyPress
        Try
            If e.KeyChar = "." Then
                examMidtermStr = examMidTextBox.Text & "." & "0"
            End If
            If Not e.KeyChar = ChrW(8) And Not e.KeyChar = "." Then
                examMidtermStr = examMidTextBox.Text
                examMidtermDouble = Integer.Parse(e.KeyChar)
                examMidtermStr &= examMidtermDouble
            End If
            If Double.Parse(examMidtermStr) < 0 Or Double.Parse(examMidtermStr) > Double.Parse(examMidtermPercStr) Then
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
    Private percentageTrackerFin As Integer
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

    Public Function setPercentageFin(percentage As Integer, percentageStr As String, percentageName As String)
        While True
            Try
                percentageStr = InputBox("Enter " & percentageName & " Percentage")
                percentage = Integer.Parse(percentageStr)
                If (percentage >= 0) Then
                    percentageTrackerFin += 1
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

    'Midterm Variables
    Private attPerc, quizPerc, labExerPerc, caseStudyPerc, recitationPerc, examMidtermPerc As Integer
    Private attPercStr, quizPercStr, labExerPercStr, caseStudyPercStr, recitationPercStr, examMidtermPercStr As String
    Private percentageName As String
    Private totalPercentage As Double

    'Final Variables
    Private attPercFin, quizPercFin, labExerPercFin, caseStudyPercFin, recitationPercFin, examFinalPerc As Integer
    Private attPercStrFin, quizPercStrFin, labExerPercStrFin, caseStudyPercStrFin, examFinalPercStr As String
    Private percentageNameFin As String
    Private totalPercentageFin As Double

    Private Sub setPercentageMidButton_Click(sender As Object, e As EventArgs) Handles setPercentageMidButton.Click

        For i = percentageTracker To 5
            Select Case i
                Case 0
                    percentageName = "Attendance"
                    attPercStr = setPercentage(attPerc, attPercStr, percentageName)
                    If attPercStr.Equals("") Then
                        Exit Sub
                    End If
                    attPerc = attPercStr
                Case 1
                    percentageName = "Quiz"
                    quizPercStr = setPercentage(quizPerc, quizPercStr, percentageName)
                    If quizPercStr.Equals("") Then
                        Exit Sub
                    End If
                    quizPerc = quizPercStr
                Case 2
                    percentageName = "Laboratory Exercise"
                    labExerPercStr = setPercentage(labExerPerc, labExerPercStr, percentageName)
                    If labExerPercStr.Equals("") Then
                        Exit Sub
                    End If
                    labExerPerc = labExerPercStr
                Case 3
                    percentageName = "Case Study"
                    caseStudyPercStr = setPercentage(caseStudyPerc, caseStudyPercStr, percentageName)
                    If caseStudyPercStr.Equals("") Then
                        Exit Sub
                    End If
                    caseStudyPerc = caseStudyPercStr
                Case 4
                    percentageName = "Recitation"
                    recitationPercStr = setPercentage(recitationPerc, recitationPercStr, percentageName)
                    If recitationPercStr.Equals("") Then
                        Exit Sub
                    End If
                    recitationPerc = recitationPercStr
                Case 5
                    percentageName = "Midterm Exam"
                    examMidtermPercStr = setPercentage(examMidtermPerc, examMidtermPercStr, percentageName)
                    If examMidtermPercStr.Equals("") Then
                        Exit Sub
                    End If
                    examMidtermPerc = examMidtermPercStr
            End Select
            If percentageTracker > 5 Then
                percentageTracker = 0
            End If
        Next
        totalPercentage = attPerc + quizPerc + labExerPerc + caseStudyPerc + recitationPerc + examMidtermPerc
        MessageBox.Show(totalPercentage)

        If Not totalPercentage = 100 Then
            MessageBox.Show("Total Percentage must equal to 100.")
            attPercStr = ""
            quizPercStr = ""
            labExerPercStr = ""
            caseStudyPercStr = ""
            recitationPercStr = ""
            examMidtermPercStr = ""
            totalPercentage = 0
        Else
            attendanceMidLabel.Text = "Attendance " & attPerc & "%"
            quizMidLabel.Text = "Quizzes " & quizPerc & "%"
            labExerMidLabel.Text = "Lab Exercise " & labExerPerc & "%"
            caseStudyMidLabel.Text = "Case Study " & caseStudyPerc & "%"
            recitationMidLabel.Text = "Recitation " & recitationPerc & "%"
            examMidLabel.Text = "Midterm Exam " & examMidtermPerc & "%"
            attMidTextBox.Enabled = True
            quizMidTextBox.Enabled = True
            labExerMidTextBox.Enabled = True
            caseStudyMidTextBox.Enabled = True
            recitationMidTextBox.Enabled = True
            examMidTextBox.Enabled = True

        End If

    End Sub
    'Miterm Variables
    Private midtermGrade As Double
    Private midtermPerc As Double

    'Final Variables
    Private finalGrade As Double
    Private finalPerc As Double

    Private Sub computeMidtermButton_Click(sender As Object, e As EventArgs) Handles computeMidtermButton.Click
        Try
            attDouble = Double.Parse(attStr)
            quizDouble = Double.Parse(quizStr)
            labExerDouble = Double.Parse(labExerStr)
            caseStudyDouble = Double.Parse(caseStudyStr)
            recitationDouble = Double.Parse(recitationStr)
            examMidtermDouble = Double.Parse(examMidtermStr)

            midtermGrade = attDouble + quizDouble + labExerDouble + caseStudyDouble + recitationDouble + examMidtermDouble
            midtermGradeLabel.Text = midtermGrade
            midtermPerc = midtermGrade * 0.5
            midtermPercLabel.Text = "MIDTERM GRADE: " & midtermPerc & "%"
        Catch ex As Exception
            MessageBox.Show("Enter a Percentages First.")
        End Try

    End Sub

    Private Sub saveMidtermButton_Click(sender As Object, e As EventArgs) Handles saveMidtermButton.Click
        Try
            student.studentAttendanceArr(studentOrder) = Double.Parse(attStr)
            student.studentQuizzesArr(studentOrder) = Double.Parse(quizStr)
            student.studentLabExerciseArr(studentOrder) = Double.Parse(labExerStr)
            student.studentCaseStudyArr(studentOrder) = Double.Parse(caseStudyStr)
            student.studentRecitationArr(studentOrder) = Double.Parse(recitationStr)
            student.studentMidtermExamArr(studentOrder) = Double.Parse(examMidtermStr)
            student.studentMidtermGradeArr(studentOrder) = midtermGrade
            student.studentMidtermPercArr(studentOrder) = midtermPerc
            student.studentAttPercArr(studentOrder) = Double.Parse(attPercStr)
            student.studentQuizPercArr(studentOrder) = Double.Parse(quizPercStr)
            student.studentLabExerPercArr(studentOrder) = Double.Parse(labExerPercStr)
            student.studentCaseStudyPercArr(studentOrder) = Double.Parse(caseStudyPercStr)
            student.studentRecitationPercArr(studentOrder) = Double.Parse(recitationPercStr)
            student.studentMidtermExamPercArr(studentOrder) = Double.Parse(examMidtermPercStr)
            student.studentSaveArr(studentOrder) = True

            If (student.studentSaveArr(studentOrder)) Then
                finalPanel.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show("Fill all fields first.")
        End Try


    End Sub

    Private Sub clearFinalButton_Click(sender As Object, e As EventArgs) Handles clearFinalButton.Click
        attFinTextBox.Clear()
        quizFinTextBox.Clear()
        labExerFinTextBox.Clear()
        caseStudyFinTextBox.Clear()
        examFinTextBox.Clear()
    End Sub

    Private Sub setPercentageFinButton_Click(sender As Object, e As EventArgs) Handles setPercentageFinButton.Click

        For i = percentageTrackerFin To 4
            Select Case i
                Case 0
                    percentageNameFin = "Attendance"
                    attPercStrFin = setPercentageFin(attPercFin, attPercStrFin, percentageNameFin)
                    If attPercStrFin.Equals("") Then
                        Exit Sub
                    End If
                    attPercFin = attPercStrFin
                Case 1
                    percentageNameFin = "Quiz"
                    quizPercStrFin = setPercentageFin(quizPercFin, quizPercStrFin, percentageNameFin)
                    If quizPercStrFin.Equals("") Then
                        Exit Sub
                    End If
                    quizPercFin = quizPercStrFin
                Case 2
                    percentageNameFin = "Laboratory Exercise"
                    labExerPercStrFin = setPercentageFin(labExerPercFin, labExerPercStrFin, percentageNameFin)
                    If labExerPercStrFin.Equals("") Then
                        Exit Sub
                    End If
                    labExerPercFin = labExerPercStrFin
                Case 3
                    percentageNameFin = "Case Study"
                    caseStudyPercStrFin = setPercentageFin(caseStudyPercFin, caseStudyPercStrFin, percentageNameFin)
                    If caseStudyPercStrFin.Equals("") Then
                        Exit Sub
                    End If
                    caseStudyPercFin = caseStudyPercStrFin

                Case 4
                    percentageNameFin = "Midterm Exam"
                    examFinalPercStr = setPercentageFin(examFinalPerc, examFinalPercStr, percentageNameFin)
                    If examFinalPercStr.Equals("") Then
                        Exit Sub
                    End If
                    examFinalPerc = examFinalPercStr
            End Select
            If percentageTrackerFin > 4 Then
                percentageTrackerFin = 0
            End If
        Next
        totalPercentageFin = attPercFin + quizPercFin + labExerPercFin + caseStudyPercFin + recitationPercFin + examFinalPerc
        MessageBox.Show(totalPercentageFin)

        If Not totalPercentageFin = 100 Then
            MessageBox.Show("Total Percentage must equal to 100.")
            attPercStrFin = ""
            quizPercStrFin = ""
            labExerPercStrFin = ""
            caseStudyPercStrFin = ""
            examFinalPercStr = ""
            totalPercentageFin = 0
        Else
            attendanceFinLabel.Text = "Attendance " & attPercFin & "%"
            quizFinLabel.Text = "Quizzes " & quizPercFin & "%"
            labExerFinLabel.Text = "Lab Exercise " & labExerPercFin & "%"
            caseStudyFinLabel.Text = "Case Study / Project " & caseStudyPercFin & "%"
            examFinLabel.Text = "Final Exam " & examFinalPerc & "%"
            attFinTextBox.Enabled = True
            quizFinTextBox.Enabled = True
            labExerFinTextBox.Enabled = True
            caseStudyFinTextBox.Enabled = True
            examFinTextBox.Enabled = True

        End If
    End Sub

    Private Sub attFinTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles attFinTextBox.KeyPress
        Try
            If e.KeyChar = "." Then
                attStrFin = attFinTextBox.Text & "." & "0"
            End If
            If Not e.KeyChar = ChrW(8) And Not e.KeyChar = "." Then
                attStrFin = attFinTextBox.Text
                attDoubleFin = Double.Parse(e.KeyChar)
                attStrFin &= attDoubleFin
            End If
            If Double.Parse(attStrFin) < 0 Or Double.Parse(attStrFin) > Integer.Parse(attPercStrFin) Then
                e.Handled = True
                attFinTextBox.Clear()
                attStrFin = ""
            End If
        Catch ex As Exception
            e.Handled = True
        End Try
    End Sub

    Private Sub quizFinTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles quizFinTextBox.KeyPress
        Try
            If e.KeyChar = "." Then
                quizStrFin = quizFinTextBox.Text & "." & "0"
            End If
            If Not e.KeyChar = ChrW(8) And Not e.KeyChar = "." Then
                quizStrFin = quizFinTextBox.Text
                quizDoubleFin = Double.Parse(e.KeyChar)
                quizStrFin &= quizDoubleFin
            End If
            If Double.Parse(quizStrFin) < 0 Or Double.Parse(quizStrFin) > Integer.Parse(quizPercStrFin) Then
                e.Handled = True
                quizFinTextBox.Clear()
                quizStrFin = ""
            End If
        Catch ex As Exception
            e.Handled = True
        End Try
    End Sub

    Private Sub labExerFinTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles labExerFinTextBox.KeyPress
        Try
            If e.KeyChar = "." Then
                labExerStrFin = labExerFinTextBox.Text & "." & "0"
            End If
            If Not e.KeyChar = ChrW(8) And Not e.KeyChar = "." Then
                labExerStrFin = labExerFinTextBox.Text
                labExerDoubleFin = Double.Parse(e.KeyChar)
                labExerStrFin &= labExerDoubleFin
            End If
            If Double.Parse(labExerStrFin) < 0 Or Double.Parse(labExerStrFin) > Integer.Parse(labExerPercStrFin) Then
                e.Handled = True
                labExerFinTextBox.Clear()
                labExerStrFin = ""
            End If
        Catch ex As Exception
            e.Handled = True
        End Try
    End Sub

    Private Sub caseStudyFinTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles caseStudyFinTextBox.KeyPress
        Try
            If e.KeyChar = "." Then
                caseStudyStrFin = caseStudyFinTextBox.Text & "." & "0"
            End If
            If Not e.KeyChar = ChrW(8) And Not e.KeyChar = "." Then
                caseStudyStrFin = caseStudyFinTextBox.Text
                caseStudyDoubleFin = Double.Parse(e.KeyChar)
                caseStudyStrFin &= caseStudyDoubleFin
            End If
            If Double.Parse(caseStudyStrFin) < 0 Or Double.Parse(caseStudyStrFin) > Integer.Parse(caseStudyPercStrFin) Then
                e.Handled = True
                caseStudyFinTextBox.Clear()
                caseStudyStrFin = ""
            End If
        Catch ex As Exception
            e.Handled = True
        End Try
    End Sub

    Private Sub examFinTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles examFinTextBox.KeyPress
        Try
            If e.KeyChar = "." Then
                examFinalStr = examFinTextBox.Text & "." & "0"
            End If
            If Not e.KeyChar = ChrW(8) And Not e.KeyChar = "." Then
                examFinalStr = examFinTextBox.Text
                examFinalDouble = Double.Parse(e.KeyChar)
                examFinalStr &= examFinalDouble
            End If
            If Double.Parse(examFinalStr) < 0 Or Double.Parse(examFinalStr) > Integer.Parse(examFinalPercStr) Then
                e.Handled = True
                examFinTextBox.Clear()
                examFinalStr = ""
            End If
        Catch ex As Exception
            e.Handled = True
        End Try
    End Sub

    Private Sub computeFinalButton_Click(sender As Object, e As EventArgs) Handles computeFinalButton.Click
        Try
            attDoubleFin = Double.Parse(attStrFin)
            quizDoubleFin = Double.Parse(quizStrFin)
            labExerDoubleFin = Double.Parse(labExerStrFin)
            caseStudyDoubleFin = Double.Parse(caseStudyStrFin)
            examFinalDouble = Double.Parse(examFinalStr)

            finalGrade = attDoubleFin + quizDoubleFin + labExerDoubleFin + caseStudyDoubleFin + examFinalDouble
            FinalGradeLabel.Text = finalGrade
            finalPerc = finalGrade * 0.5
            finalPercLabel.Text = "FINAL GRADE: " & finalPerc & "%"
        Catch ex As Exception
            MessageBox.Show("Enter a Percentages first.")
        End Try
    End Sub
    Private semestralGrade As Double
    Private semestralPerc As Double
    Private Sub saveFinalButton_Click(sender As Object, e As EventArgs) Handles saveFinalButton.Click

        Try
            semestralPerc = finalPerc + midtermPerc

            Select Case semestralPerc
                Case Is >= 98
                    semGrade.Text = "1.00"
                Case Is >= 96
                    semGrade.Text = "1.25"
                Case Is >= 93
                    semGrade.Text = "1.50"
                Case Is >= 89
                    semGrade.Text = "1.75"
                Case Is >= 85
                    semGrade.Text = "2.00"
                Case Is >= 82
                    semGrade.Text = "2.25"
                Case Is >= 79
                    semGrade.Text = "2.50"
                Case Is >= 75
                    semGrade.Text = "2.75"
                Case Is < 75
                    semGrade.Text = "3.00"
            End Select

            student.studentAttendanceArrFin(studentOrder) = Double.Parse(attStrFin)
            student.studentQuizzesArrFin(studentOrder) = Double.Parse(quizStrFin)
            student.studentLabExerciseArrFin(studentOrder) = Double.Parse(labExerStrFin)
            student.studentCaseStudyArrFin(studentOrder) = Double.Parse(caseStudyStrFin)
            student.studentFinalExamArr(studentOrder) = Double.Parse(examFinalStr)
            student.studentFinalGradeArr(studentOrder) = finalGrade
            student.studentFinalPercArr(studentOrder) = finalPerc
            student.studentAttPercArrFin(studentOrder) = Double.Parse(attPercStrFin)
            student.studentQuizPercArrFin(studentOrder) = Double.Parse(quizPercStrFin)
            student.studentLabExerPercArrFin(studentOrder) = Double.Parse(labExerPercStrFin)
            student.studentCaseStudyPercArrFin(studentOrder) = Double.Parse(caseStudyPercStrFin)
            student.studentFinalExamPercArr(studentOrder) = Double.Parse(examFinalPercStr)
            student.studentSemestralGrade(studentOrder) = semGrade.Text
            student.studentSaveArrFin(studentOrder) = True
        Catch ex As Exception
            MessageBox.Show("Fill all fields first.")
        End Try

    End Sub

End Class

Public Class Student
    Public studentNumArr() As String = {"23-00219", "23-00418", "22-01024", "21-00325"}
    Public studentNameArr() As String = {"JESTALY JOSEPH CASTILLO", "CAL NEWPORT", "ROBERT KIYOSAKI", "MICHAEL GRANT"}
    Public studentCourseArr() As String = {"BSCS", "BSN", "BSCE", "BSCS"}
    Public studentSectionArr() As String = {"2A", "1B", "3F", "1A"}
    Public studentAttendanceArr() As Double = {0, 0, 0, 0}
    Public studentQuizzesArr() As Double = {0, 0, 0, 0}
    Public studentLabExerciseArr() As Double = {0, 0, 0, 0}
    Public studentCaseStudyArr() As Double = {0, 0, 0, 0}
    Public studentRecitationArr() As Double = {0, 0, 0, 0}
    Public studentMidtermExamArr() As Double = {0, 0, 0, 0}
    Public studentMidtermGradeArr() As Double = {0, 0, 0, 0}
    Public studentMidtermPercArr() As Double = {0, 0, 0, 0}
    Public studentAttPercArr() As Integer = {0, 0, 0, 0}
    Public studentQuizPercArr() As Integer = {0, 0, 0, 0}
    Public studentLabExerPercArr() As Integer = {0, 0, 0, 0}
    Public studentCaseStudyPercArr() As Integer = {0, 0, 0, 0}
    Public studentRecitationPercArr() As Integer = {0, 0, 0, 0}
    Public studentMidtermExamPercArr() As Integer = {0, 0, 0, 0}
    Public studentSaveArr() As Boolean = {False, False, False, False}

    'FINAL VARIABLES
    Public studentAttendanceArrFin() As Double = {0, 0, 0, 0}
    Public studentQuizzesArrFin() As Double = {0, 0, 0, 0}
    Public studentLabExerciseArrFin() As Double = {0, 0, 0, 0}
    Public studentCaseStudyArrFin() As Double = {0, 0, 0, 0}
    Public studentFinalExamArr() As Double = {0, 0, 0, 0}
    Public studentFinalGradeArr() As Double = {0, 0, 0, 0}
    Public studentFinalPercArr() As Double = {0, 0, 0, 0}
    Public studentAttPercArrFin() As Integer = {0, 0, 0, 0}
    Public studentQuizPercArrFin() As Integer = {0, 0, 0, 0}
    Public studentLabExerPercArrFin() As Integer = {0, 0, 0, 0}
    Public studentCaseStudyPercArrFin() As Integer = {0, 0, 0, 0}
    Public studentFinalExamPercArr() As Integer = {0, 0, 0, 0}
    Public studentSaveArrFin() As Boolean = {False, False, False, False}

    'SEMESTER VARIABLE
    Public studentSemestralGrade() As String = {"5.00", "5.00", "5.00", "5.00"}
End Class