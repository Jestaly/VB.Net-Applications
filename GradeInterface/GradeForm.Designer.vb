<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label6 = New Label()
        Label4 = New Label()
        midtermExamTextBox = New TextBox()
        Label3 = New Label()
        recitationTextBox = New TextBox()
        Label2 = New Label()
        caseStudyTextBox = New TextBox()
        labExerciseTexBox = New TextBox()
        Label1 = New Label()
        quizzesTextBox = New TextBox()
        clearMidtermButton = New Button()
        computeMidtermButton = New Button()
        midtermGrade = New Label()
        quizzesLabel = New Label()
        attendanceLabel = New Label()
        attendanceTextBox = New TextBox()
        Panel2 = New Panel()
        Label9 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        Label7 = New Label()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        Label8 = New Label()
        TextBox11 = New TextBox()
        clearFinalButton = New Button()
        computeFinalButton = New Button()
        finalGrade = New Label()
        Label10 = New Label()
        Label11 = New Label()
        TextBox12 = New TextBox()
        studentNumberTextBox = New TextBox()
        studentNameTextBox = New TextBox()
        studentNumberLabel = New Label()
        studentNameLabel = New Label()
        semGrade = New Label()
        Label12 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(16), CByte(55), CByte(92))
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(midtermExamTextBox)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(recitationTextBox)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(caseStudyTextBox)
        Panel1.Controls.Add(labExerciseTexBox)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(quizzesTextBox)
        Panel1.Controls.Add(clearMidtermButton)
        Panel1.Controls.Add(computeMidtermButton)
        Panel1.Controls.Add(midtermGrade)
        Panel1.Controls.Add(quizzesLabel)
        Panel1.Controls.Add(attendanceLabel)
        Panel1.Controls.Add(attendanceTextBox)
        Panel1.Location = New Point(38, 146)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(954, 266)
        Panel1.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(552, 29)
        Label6.Name = "Label6"
        Label6.Size = New Size(332, 42)
        Label6.TabIndex = 18
        Label6.Text = "MIDTERM GRADE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans", 13.8F)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(278, 180)
        Label4.Name = "Label4"
        Label4.Size = New Size(178, 26)
        Label4.TabIndex = 17
        Label4.Text = "Midterm Exam"
        ' 
        ' midtermExamTextBox
        ' 
        midtermExamTextBox.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        midtermExamTextBox.Location = New Point(278, 210)
        midtermExamTextBox.Name = "midtermExamTextBox"
        midtermExamTextBox.Size = New Size(184, 34)
        midtermExamTextBox.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans", 13.8F)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(278, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 26)
        Label3.TabIndex = 15
        Label3.Text = "Recitation"
        ' 
        ' recitationTextBox
        ' 
        recitationTextBox.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        recitationTextBox.Location = New Point(278, 127)
        recitationTextBox.Name = "recitationTextBox"
        recitationTextBox.Size = New Size(184, 34)
        recitationTextBox.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans", 13.8F)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(278, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 26)
        Label2.TabIndex = 13
        Label2.Text = "Case Study"
        ' 
        ' caseStudyTextBox
        ' 
        caseStudyTextBox.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        caseStudyTextBox.Location = New Point(278, 50)
        caseStudyTextBox.Name = "caseStudyTextBox"
        caseStudyTextBox.Size = New Size(184, 34)
        caseStudyTextBox.TabIndex = 12
        ' 
        ' labExerciseTexBox
        ' 
        labExerciseTexBox.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        labExerciseTexBox.Location = New Point(52, 210)
        labExerciseTexBox.Name = "labExerciseTexBox"
        labExerciseTexBox.Size = New Size(184, 34)
        labExerciseTexBox.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(52, 185)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 21)
        Label1.TabIndex = 10
        Label1.Text = "Laboratory Exercise"
        ' 
        ' quizzesTextBox
        ' 
        quizzesTextBox.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        quizzesTextBox.Location = New Point(52, 127)
        quizzesTextBox.Name = "quizzesTextBox"
        quizzesTextBox.Size = New Size(184, 34)
        quizzesTextBox.TabIndex = 9
        ' 
        ' clearMidtermButton
        ' 
        clearMidtermButton.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clearMidtermButton.Location = New Point(504, 156)
        clearMidtermButton.Name = "clearMidtermButton"
        clearMidtermButton.Size = New Size(169, 48)
        clearMidtermButton.TabIndex = 8
        clearMidtermButton.Text = "Clear"
        clearMidtermButton.UseVisualStyleBackColor = True
        ' 
        ' computeMidtermButton
        ' 
        computeMidtermButton.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        computeMidtermButton.Location = New Point(504, 91)
        computeMidtermButton.Name = "computeMidtermButton"
        computeMidtermButton.Size = New Size(169, 48)
        computeMidtermButton.TabIndex = 7
        computeMidtermButton.Text = "Compute"
        computeMidtermButton.UseVisualStyleBackColor = True
        ' 
        ' midtermGrade
        ' 
        midtermGrade.AutoSize = True
        midtermGrade.BackColor = Color.FromArgb(CByte(36), CByte(54), CByte(66))
        midtermGrade.BorderStyle = BorderStyle.Fixed3D
        midtermGrade.Font = New Font("Lucida Sans", 48.0F)
        midtermGrade.ForeColor = SystemColors.ButtonHighlight
        midtermGrade.Location = New Point(731, 98)
        midtermGrade.Name = "midtermGrade"
        midtermGrade.Size = New Size(143, 93)
        midtermGrade.TabIndex = 6
        midtermGrade.Text = "00"
        midtermGrade.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' quizzesLabel
        ' 
        quizzesLabel.AutoSize = True
        quizzesLabel.Font = New Font("Lucida Sans", 13.8F)
        quizzesLabel.ForeColor = SystemColors.ButtonHighlight
        quizzesLabel.Location = New Point(52, 98)
        quizzesLabel.Name = "quizzesLabel"
        quizzesLabel.Size = New Size(99, 26)
        quizzesLabel.TabIndex = 4
        quizzesLabel.Text = "Quizzes"
        ' 
        ' attendanceLabel
        ' 
        attendanceLabel.AutoSize = True
        attendanceLabel.Font = New Font("Lucida Sans", 13.8F)
        attendanceLabel.ForeColor = SystemColors.ButtonHighlight
        attendanceLabel.Location = New Point(52, 21)
        attendanceLabel.Name = "attendanceLabel"
        attendanceLabel.Size = New Size(141, 26)
        attendanceLabel.TabIndex = 3
        attendanceLabel.Text = "Attendance"
        ' 
        ' attendanceTextBox
        ' 
        attendanceTextBox.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        attendanceTextBox.Location = New Point(52, 50)
        attendanceTextBox.Name = "attendanceTextBox"
        attendanceTextBox.Size = New Size(184, 34)
        attendanceTextBox.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(16), CByte(55), CByte(92))
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(TextBox9)
        Panel2.Controls.Add(TextBox10)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(TextBox11)
        Panel2.Controls.Add(clearFinalButton)
        Panel2.Controls.Add(computeFinalButton)
        Panel2.Controls.Add(finalGrade)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(TextBox12)
        Panel2.Location = New Point(38, 427)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(954, 276)
        Panel2.TabIndex = 1
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = SystemColors.ButtonHighlight
        Label9.Location = New Point(589, 33)
        Label9.Name = "Label9"
        Label9.Size = New Size(263, 42)
        Label9.TabIndex = 19
        Label9.Text = "FINAL GRADE"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans", 13.8F)
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(278, 110)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 26)
        Label5.TabIndex = 32
        Label5.Text = "Final Exam"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(278, 139)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(184, 34)
        TextBox2.TabIndex = 31
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(278, 37)
        Label7.Name = "Label7"
        Label7.Size = New Size(188, 21)
        Label7.TabIndex = 28
        Label7.Text = "Project / Case Study"
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox9.Location = New Point(278, 62)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(184, 34)
        TextBox9.TabIndex = 27
        ' 
        ' TextBox10
        ' 
        TextBox10.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox10.Location = New Point(52, 222)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(184, 34)
        TextBox10.TabIndex = 26
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(52, 198)
        Label8.Name = "Label8"
        Label8.Size = New Size(184, 21)
        Label8.TabIndex = 25
        Label8.Text = "Laboratory Exercise"
        ' 
        ' TextBox11
        ' 
        TextBox11.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox11.Location = New Point(52, 139)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(184, 34)
        TextBox11.TabIndex = 24
        ' 
        ' clearFinalButton
        ' 
        clearFinalButton.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clearFinalButton.Location = New Point(504, 166)
        clearFinalButton.Name = "clearFinalButton"
        clearFinalButton.Size = New Size(169, 48)
        clearFinalButton.TabIndex = 23
        clearFinalButton.Text = "Clear"
        clearFinalButton.UseVisualStyleBackColor = True
        ' 
        ' computeFinalButton
        ' 
        computeFinalButton.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        computeFinalButton.Location = New Point(504, 101)
        computeFinalButton.Name = "computeFinalButton"
        computeFinalButton.Size = New Size(169, 48)
        computeFinalButton.TabIndex = 22
        computeFinalButton.Text = "Compute"
        computeFinalButton.UseVisualStyleBackColor = True
        ' 
        ' finalGrade
        ' 
        finalGrade.AutoSize = True
        finalGrade.BackColor = Color.FromArgb(CByte(36), CByte(54), CByte(66))
        finalGrade.BorderStyle = BorderStyle.Fixed3D
        finalGrade.Font = New Font("Lucida Sans", 48.0F)
        finalGrade.ForeColor = SystemColors.ButtonHighlight
        finalGrade.Location = New Point(731, 110)
        finalGrade.Name = "finalGrade"
        finalGrade.Size = New Size(143, 93)
        finalGrade.TabIndex = 21
        finalGrade.Text = "00"
        finalGrade.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Lucida Sans", 13.8F)
        Label10.ForeColor = SystemColors.ButtonHighlight
        Label10.Location = New Point(52, 110)
        Label10.Name = "Label10"
        Label10.Size = New Size(99, 26)
        Label10.TabIndex = 20
        Label10.Text = "Quizzes"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Lucida Sans", 13.8F)
        Label11.ForeColor = SystemColors.ButtonHighlight
        Label11.Location = New Point(52, 33)
        Label11.Name = "Label11"
        Label11.Size = New Size(141, 26)
        Label11.TabIndex = 19
        Label11.Text = "Attendance"
        ' 
        ' TextBox12
        ' 
        TextBox12.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox12.Location = New Point(52, 62)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(184, 34)
        TextBox12.TabIndex = 18
        ' 
        ' studentNumberTextBox
        ' 
        studentNumberTextBox.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentNumberTextBox.Location = New Point(280, 50)
        studentNumberTextBox.Name = "studentNumberTextBox"
        studentNumberTextBox.Size = New Size(167, 47)
        studentNumberTextBox.TabIndex = 0
        ' 
        ' studentNameTextBox
        ' 
        studentNameTextBox.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        studentNameTextBox.Location = New Point(485, 50)
        studentNameTextBox.Name = "studentNameTextBox"
        studentNameTextBox.Size = New Size(300, 47)
        studentNameTextBox.TabIndex = 2
        ' 
        ' studentNumberLabel
        ' 
        studentNumberLabel.AutoSize = True
        studentNumberLabel.Font = New Font("Lucida Sans", 10.8F)
        studentNumberLabel.ForeColor = SystemColors.ButtonHighlight
        studentNumberLabel.Location = New Point(280, 26)
        studentNumberLabel.Name = "studentNumberLabel"
        studentNumberLabel.Size = New Size(158, 21)
        studentNumberLabel.TabIndex = 3
        studentNumberLabel.Text = "Student Number"
        ' 
        ' studentNameLabel
        ' 
        studentNameLabel.AutoSize = True
        studentNameLabel.Font = New Font("Lucida Sans", 10.8F)
        studentNameLabel.ForeColor = SystemColors.ButtonHighlight
        studentNameLabel.Location = New Point(485, 26)
        studentNameLabel.Name = "studentNameLabel"
        studentNameLabel.Size = New Size(136, 21)
        studentNameLabel.TabIndex = 4
        studentNameLabel.Text = "Student Name"
        ' 
        ' semGrade
        ' 
        semGrade.AutoSize = True
        semGrade.BackColor = Color.FromArgb(CByte(36), CByte(54), CByte(66))
        semGrade.BorderStyle = BorderStyle.Fixed3D
        semGrade.Font = New Font("Lucida Sans", 40.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        semGrade.ForeColor = SystemColors.ButtonHighlight
        semGrade.Location = New Point(122, 26)
        semGrade.Name = "semGrade"
        semGrade.Size = New Size(118, 78)
        semGrade.TabIndex = 9
        semGrade.Text = "00"
        semGrade.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Lucida Sans", 10.8F)
        Label12.ForeColor = SystemColors.ButtonHighlight
        Label12.Location = New Point(104, 113)
        Label12.Name = "Label12"
        Label12.Size = New Size(155, 21)
        Label12.TabIndex = 10
        Label12.Text = "Semestral Grade"
        ' 
        ' GradeForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(52), CByte(49), CByte(49))
        ClientSize = New Size(1030, 722)
        Controls.Add(Label12)
        Controls.Add(semGrade)
        Controls.Add(studentNameLabel)
        Controls.Add(studentNumberLabel)
        Controls.Add(studentNameTextBox)
        Controls.Add(studentNumberTextBox)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "GradeForm"
        Text = "Grade Form"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents studentNumberTextBox As TextBox
    Friend WithEvents studentNameTextBox As TextBox
    Friend WithEvents studentNumberLabel As Label
    Friend WithEvents studentNameLabel As Label
    Friend WithEvents attendanceTextBox As TextBox
    Friend WithEvents quizzesLabel As Label
    Friend WithEvents attendanceLabel As Label
    Friend WithEvents midtermGrade As Label
    Friend WithEvents clearMidtermButton As Button
    Friend WithEvents computeMidtermButton As Button
    Friend WithEvents semGrade As Label
    Friend WithEvents quizzesTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents caseStudyTextBox As TextBox
    Friend WithEvents labExerciseTexBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents midtermExamTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents recitationTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents clearFinalButton As Button
    Friend WithEvents computeFinalButton As Button
    Friend WithEvents finalGrade As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
End Class
